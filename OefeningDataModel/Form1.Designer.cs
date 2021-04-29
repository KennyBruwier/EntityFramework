
namespace OefeningDataModel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.btBewerken = new System.Windows.Forms.Button();
            this.cbPersonen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btVerwijder = new System.Windows.Forms.Button();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBadge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btBadgeToevoegen = new System.Windows.Forms.Button();
            this.btBadgeVerwijderen = new System.Windows.Forms.Button();
            this.btBadgeBewerken = new System.Windows.Forms.Button();
            this.lbBadges = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btToewijzen = new System.Windows.Forms.Button();
            this.btPBVerwijder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(183, 25);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(168, 20);
            this.tbVoornaam.TabIndex = 1;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(183, 64);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(168, 20);
            this.tbAchternaam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leeftijd";
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(183, 103);
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(168, 20);
            this.numLeeftijd.TabIndex = 5;
            // 
            // btBewerken
            // 
            this.btBewerken.Location = new System.Drawing.Point(11, 234);
            this.btBewerken.Name = "btBewerken";
            this.btBewerken.Size = new System.Drawing.Size(168, 23);
            this.btBewerken.TabIndex = 6;
            this.btBewerken.Text = "Bewaren";
            this.btBewerken.UseVisualStyleBackColor = true;
            this.btBewerken.Click += new System.EventHandler(this.btBewerken_Click);
            // 
            // cbPersonen
            // 
            this.cbPersonen.FormattingEnabled = true;
            this.cbPersonen.Location = new System.Drawing.Point(9, 24);
            this.cbPersonen.Name = "cbPersonen";
            this.cbPersonen.Size = new System.Drawing.Size(147, 21);
            this.cbPersonen.TabIndex = 7;
            this.cbPersonen.SelectedIndexChanged += new System.EventHandler(this.cbPersonen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Persoon aanduiden";
            // 
            // btVerwijder
            // 
            this.btVerwijder.Location = new System.Drawing.Point(11, 263);
            this.btVerwijder.Name = "btVerwijder";
            this.btVerwijder.Size = new System.Drawing.Size(168, 23);
            this.btVerwijder.TabIndex = 9;
            this.btVerwijder.Text = "Verwijder";
            this.btVerwijder.UseVisualStyleBackColor = true;
            this.btVerwijder.Click += new System.EventHandler(this.btVerwijder_Click);
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(11, 205);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(168, 23);
            this.btToevoegen.TabIndex = 10;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Assigned badges";
            // 
            // cbBadge
            // 
            this.cbBadge.FormattingEnabled = true;
            this.cbBadge.Location = new System.Drawing.Point(9, 64);
            this.cbBadge.Name = "cbBadge";
            this.cbBadge.Size = new System.Drawing.Size(147, 21);
            this.cbBadge.TabIndex = 11;
            this.cbBadge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbBadge_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Persoon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Badge:";
            // 
            // btBadgeToevoegen
            // 
            this.btBadgeToevoegen.Location = new System.Drawing.Point(185, 205);
            this.btBadgeToevoegen.Name = "btBadgeToevoegen";
            this.btBadgeToevoegen.Size = new System.Drawing.Size(168, 23);
            this.btBadgeToevoegen.TabIndex = 16;
            this.btBadgeToevoegen.Text = "Toevoegen";
            this.btBadgeToevoegen.UseVisualStyleBackColor = true;
            this.btBadgeToevoegen.Click += new System.EventHandler(this.btBadgeToevoegen_Click);
            // 
            // btBadgeVerwijderen
            // 
            this.btBadgeVerwijderen.Location = new System.Drawing.Point(185, 263);
            this.btBadgeVerwijderen.Name = "btBadgeVerwijderen";
            this.btBadgeVerwijderen.Size = new System.Drawing.Size(168, 23);
            this.btBadgeVerwijderen.TabIndex = 15;
            this.btBadgeVerwijderen.Text = "Verwijder";
            this.btBadgeVerwijderen.UseVisualStyleBackColor = true;
            this.btBadgeVerwijderen.Click += new System.EventHandler(this.btBadgeVerwijderen_Click);
            // 
            // btBadgeBewerken
            // 
            this.btBadgeBewerken.Location = new System.Drawing.Point(185, 234);
            this.btBadgeBewerken.Name = "btBadgeBewerken";
            this.btBadgeBewerken.Size = new System.Drawing.Size(168, 23);
            this.btBadgeBewerken.TabIndex = 14;
            this.btBadgeBewerken.Text = "Bewaren";
            this.btBadgeBewerken.UseVisualStyleBackColor = true;
            this.btBadgeBewerken.Click += new System.EventHandler(this.btBadgeBewerken_Click);
            // 
            // lbBadges
            // 
            this.lbBadges.FormattingEnabled = true;
            this.lbBadges.Location = new System.Drawing.Point(183, 142);
            this.lbBadges.Name = "lbBadges";
            this.lbBadges.Size = new System.Drawing.Size(168, 43);
            this.lbBadges.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lijst badges:";
            // 
            // btToewijzen
            // 
            this.btToewijzen.Location = new System.Drawing.Point(9, 91);
            this.btToewijzen.Name = "btToewijzen";
            this.btToewijzen.Size = new System.Drawing.Size(96, 23);
            this.btToewijzen.TabIndex = 21;
            this.btToewijzen.Text = "Toewijzen";
            this.btToewijzen.UseVisualStyleBackColor = true;
            this.btToewijzen.Click += new System.EventHandler(this.btToewijzen_Click);
            // 
            // btPBVerwijder
            // 
            this.btPBVerwijder.Location = new System.Drawing.Point(9, 120);
            this.btPBVerwijder.Name = "btPBVerwijder";
            this.btPBVerwijder.Size = new System.Drawing.Size(96, 23);
            this.btPBVerwijder.TabIndex = 20;
            this.btPBVerwijder.Text = "Verwijder";
            this.btPBVerwijder.UseVisualStyleBackColor = true;
            this.btPBVerwijder.Click += new System.EventHandler(this.btPBVerwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 305);
            this.Controls.Add(this.btToewijzen);
            this.Controls.Add(this.btPBVerwijder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbBadges);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btBadgeToevoegen);
            this.Controls.Add(this.btBadgeVerwijderen);
            this.Controls.Add(this.btBadgeBewerken);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBadge);
            this.Controls.Add(this.btToevoegen);
            this.Controls.Add(this.btVerwijder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPersonen);
            this.Controls.Add(this.btBewerken);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.Button btBewerken;
        private System.Windows.Forms.ComboBox cbPersonen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btVerwijder;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBadge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btBadgeToevoegen;
        private System.Windows.Forms.Button btBadgeVerwijderen;
        private System.Windows.Forms.Button btBadgeBewerken;
        private System.Windows.Forms.ListBox lbBadges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btToewijzen;
        private System.Windows.Forms.Button btPBVerwijder;
    }
}