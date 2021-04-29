using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningDataModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRefresh();
        }
        private void LoadRefresh()
        {
            int iPersonen = 0;
            int iBadge = 0;
            if (cbPersonen.SelectedIndex > 0) iPersonen = cbPersonen.SelectedIndex;
            if (cbBadge.SelectedIndex > 0) iBadge = cbBadge.SelectedIndex;
            cbPersonen.Items.Clear();
            cbBadge.Items.Clear();
            using (ExperimentalEntities ctx = new ExperimentalEntities())
            {
                foreach (var persoon in ctx.Persoons)
                {
                    cbPersonen.Items.Add(new ComboItem(persoon.id, persoon.Voornaam.Trim() + " " + persoon.Achternaam.Trim()));
                }
                foreach (var badge in ctx.Badges)
                {
                    cbBadge.Items.Add(new ComboItem(badge.ID_Badge, badge.name.Trim()));
                }
            }
            if (cbPersonen.Items.Count > 0)
                cbPersonen.SelectedIndex = (iPersonen < cbPersonen.Items.Count)?iPersonen:0;
            if (cbBadge.Items.Count > 0)
                cbBadge.SelectedIndex = (iBadge < cbBadge.Items.Count)?iBadge:0;
        }
        private void btBewerken_Click(object sender, EventArgs e)
        {
            if (cbPersonen.Text == "")
            {
                Persoon nieuwePersoon = new Persoon();
                if (tbVoornaam.Text != "") nieuwePersoon.Voornaam = tbVoornaam.Text;
                if (tbAchternaam.Text != "") nieuwePersoon.Achternaam = tbAchternaam.Text;
                if (numLeeftijd.Value > 0) nieuwePersoon.Leeftijd = Convert.ToInt32(numLeeftijd.Value);
                if ((nieuwePersoon.Voornaam != null) && (nieuwePersoon.Achternaam != null))
                    using (ExperimentalEntities ctx = new ExperimentalEntities())
                    {
                        ctx.Persoons.Add(nieuwePersoon);
                        ctx.SaveChanges();
                    }
            }
            else
            {
                ComboItem selectedItem = cbPersonen.SelectedItem as ComboItem;
                using (ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    Persoon aanTePassenPersoon = ctx.Persoons.Where(p => p.id == selectedItem.Key).FirstOrDefault();
                    aanTePassenPersoon.Achternaam = tbAchternaam.Text;
                    aanTePassenPersoon.Voornaam = tbVoornaam.Text;
                    aanTePassenPersoon.Leeftijd = Convert.ToInt32(numLeeftijd.Value);
                    ctx.SaveChanges();
                }
            }
            LoadRefresh();
        }
        private void cbPersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(ExperimentalEntities ctx = new ExperimentalEntities())
            {
                ComboItem selectedItem = cbPersonen.SelectedItem as ComboItem;
                var selectedPersoon = ctx.Persoons.Where(p => p.id == selectedItem.Key).FirstOrDefault();
                if (selectedPersoon != null)
                {
                    tbVoornaam.Text = selectedPersoon.Voornaam.Trim();
                    tbAchternaam.Text = selectedPersoon.Achternaam.Trim();
                    numLeeftijd.Value = Convert.ToInt32(selectedPersoon.Leeftijd);
                    var assignedBadges = ctx.PersoonBadges  .Where(pb => pb.ID_Persoon == selectedItem.Key)
                                                            .Join(ctx.Badges,
                                                            pb => pb.ID_Badge,
                                                            b => b.ID_Badge,
                                                            (pb, b) => new { pb, b }
                                                            );
                    lbBadges.Items.Clear();
                    if (assignedBadges != null)
                    {
                        foreach (var badge in assignedBadges)
                        {
                            lbBadges.Items.Add(badge.b.name);
                        }
                    }
                }
            }
        }
        private void btToevoegen_Click(object sender, EventArgs e)
        {
            cbPersonen.Text = "";
            cbPersonen.ValueMember = "";
            tbVoornaam.Text = "";
            tbAchternaam.Text = "";
            numLeeftijd.Value = 0;
        }
        private void btVerwijder_Click(object sender, EventArgs e)
        {
            if (cbPersonen.Text != "")
            {
                ComboItem selectedItem = cbPersonen.SelectedItem as ComboItem;
                using(ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    ctx.Persoons.Remove(ctx.Persoons.FirstOrDefault(p => p.id == selectedItem.Key));
                    ctx.PersoonBadges.RemoveRange(ctx.PersoonBadges.Where(pb => pb.ID_Persoon == selectedItem.Key));
                    ctx.SaveChanges();
                    LoadRefresh();
                }
            }
        }
        private void btBadgeToevoegen_Click(object sender, EventArgs e)
        {
            cbBadge.Text = "<nieuwe badge>";
        }
        private void btBadgeBewerken_Click(object sender, EventArgs e)
        {
            if ((cbBadge.Text != "") && (cbBadge.Text != "<nieuwe badge>"))
            {
                Badge nieuweBadge = new Badge();
                nieuweBadge.name = cbBadge.Text;
                using (ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    if (ctx.Badges.Where(b=>b.name == nieuweBadge.name).Count() == 0)
                    {
                        ctx.Badges.Add(nieuweBadge);
                        ctx.SaveChanges();
                        LoadRefresh();
                    }
                }
            }
        }
        private void btBadgeVerwijderen_Click(object sender, EventArgs e)
        {
            if ((cbBadge.Text != "") && ((cbBadge.SelectedItem as ComboItem) != null))
            {
                ComboItem teVerwijderen = cbBadge.SelectedItem as ComboItem;
                using (ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    ctx.Badges.Remove(ctx.Badges.FirstOrDefault(p => p.ID_Badge == teVerwijderen.Key));
                    if (ctx.PersoonBadges.Where(pb=>pb.ID_Badge == teVerwijderen.Key).Count() > 0)
                        ctx.PersoonBadges.RemoveRange(ctx.PersoonBadges.Where(pb => pb.ID_Badge == teVerwijderen.Key));
                    ctx.SaveChanges();
                    LoadRefresh();
                }
            }
        }
        private void btToewijzen_Click(object sender, EventArgs e)
        {
            if ((cbBadge.Text != "") && (cbPersonen.Text != "") && ((cbBadge.SelectedItem as ComboItem) != null))
            {
                ComboItem toetewijzenBadge = cbBadge.SelectedItem as ComboItem;
                ComboItem toetewijzenPersoon = cbPersonen.SelectedItem as ComboItem;
                using(ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    if (ctx.PersoonBadges.Where(p=>(p.ID_Badge == toetewijzenBadge.Key) && (p.ID_Persoon == toetewijzenPersoon.Key)).Count() == 0)
                    {
                        PersoonBadge nieuweVerwijzing = new PersoonBadge();
                        nieuweVerwijzing.ID_Badge = toetewijzenBadge.Key;
                        nieuweVerwijzing.ID_Persoon = toetewijzenPersoon.Key;
                        ctx.PersoonBadges.Add(nieuweVerwijzing);
                        ctx.SaveChanges();
                        LoadRefresh();
                    }
                }
            }
        }
        private void btPBVerwijder_Click(object sender, EventArgs e)
        {
            if ((cbBadge.Text != "") && (cbPersonen.Text != "") && ((cbBadge.SelectedItem as ComboItem) != null) && ((cbPersonen.SelectedItem as ComboItem) != null))
            {
                ComboItem currentBadge = cbBadge.SelectedItem as ComboItem;
                ComboItem CurrentPersoon = cbPersonen.SelectedItem as ComboItem;
                using (ExperimentalEntities ctx = new ExperimentalEntities())
                {
                    if (ctx.PersoonBadges.Where(p => (p.ID_Badge == currentBadge.Key) && (p.ID_Persoon == CurrentPersoon.Key)).Count() > 0)
                    {
                        ctx.PersoonBadges.RemoveRange(ctx.PersoonBadges.Where(pb => (pb.ID_Badge == currentBadge.Key) && (pb.ID_Persoon == CurrentPersoon.Key)));
                        ctx.SaveChanges();
                        LoadRefresh();
                    }
                }
            }
        }
        private void cbBadge_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbBadge.Text == "<nieuwe badge>") cbBadge.Text = "";
        }
    }

    class ComboItem
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public ComboItem(int key, string value)
        {
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
