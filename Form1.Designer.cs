namespace PremierProjet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.TextBoxAnnee = new System.Windows.Forms.TextBox();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEnregCandidat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxFautes = new System.Windows.Forms.TextBox();
            this.buttonEnregResultat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAffichRecus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelPourcent = new System.Windows.Forms.Label();
            this.labelPourcentM = new System.Windows.Forms.Label();
            this.labelPourcentF = new System.Windows.Forms.Label();
            this.listBoxRecus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Location = new System.Drawing.Point(90, 37);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(100, 22);
            this.TextBoxNom.TabIndex = 0;
            // 
            // TextBoxAnnee
            // 
            this.TextBoxAnnee.Location = new System.Drawing.Point(90, 79);
            this.TextBoxAnnee.Name = "TextBoxAnnee";
            this.TextBoxAnnee.Size = new System.Drawing.Size(100, 22);
            this.TextBoxAnnee.TabIndex = 1;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(90, 127);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(81, 20);
            this.radioButtonM.TabIndex = 2;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculin";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(90, 154);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(75, 20);
            this.radioButtonF.TabIndex = 3;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Féminin";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Année :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexe :";
            // 
            // buttonEnregCandidat
            // 
            this.buttonEnregCandidat.Location = new System.Drawing.Point(51, 202);
            this.buttonEnregCandidat.Name = "buttonEnregCandidat";
            this.buttonEnregCandidat.Size = new System.Drawing.Size(157, 25);
            this.buttonEnregCandidat.TabIndex = 8;
            this.buttonEnregCandidat.Text = "Enregistrer un candidat";
            this.buttonEnregCandidat.UseVisualStyleBackColor = true;
            this.buttonEnregCandidat.Click += new System.EventHandler(this.buttonEnregCandidat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numéro du candidat :";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(151, 248);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(14, 16);
            this.labelNumero.TabIndex = 12;
            this.labelNumero.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enreigstrer un Candidat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enregistrer le résultat d\'un candidat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numéro candidat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 113);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre de fautes :";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(392, 64);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumero.TabIndex = 17;
            // 
            // textBoxFautes
            // 
            this.textBoxFautes.Location = new System.Drawing.Point(392, 109);
            this.textBoxFautes.Name = "textBoxFautes";
            this.textBoxFautes.Size = new System.Drawing.Size(100, 22);
            this.textBoxFautes.TabIndex = 18;
            // 
            // buttonEnregResultat
            // 
            this.buttonEnregResultat.Location = new System.Drawing.Point(272, 202);
            this.buttonEnregResultat.Name = "buttonEnregResultat";
            this.buttonEnregResultat.Size = new System.Drawing.Size(220, 23);
            this.buttonEnregResultat.TabIndex = 19;
            this.buttonEnregResultat.Text = "Enregistrer un résultat";
            this.buttonEnregResultat.UseVisualStyleBackColor = true;
            this.buttonEnregResultat.Click += new System.EventHandler(this.buttonEnregResultat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Liste des candidats reçus";
            // 
            // buttonAffichRecus
            // 
            this.buttonAffichRecus.Location = new System.Drawing.Point(560, 202);
            this.buttonAffichRecus.Name = "buttonAffichRecus";
            this.buttonAffichRecus.Size = new System.Drawing.Size(156, 23);
            this.buttonAffichRecus.TabIndex = 22;
            this.buttonAffichRecus.Text = "Afficher reçus";
            this.buttonAffichRecus.UseVisualStyleBackColor = true;
            this.buttonAffichRecus.Click += new System.EventHandler(this.buttonAffichRecus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Pourcentage de reçus :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Pourcentage reçus H :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Pourcentage reçus F :";
            // 
            // labelPourcent
            // 
            this.labelPourcent.AutoSize = true;
            this.labelPourcent.Location = new System.Drawing.Point(712, 232);
            this.labelPourcent.Name = "labelPourcent";
            this.labelPourcent.Size = new System.Drawing.Size(14, 16);
            this.labelPourcent.TabIndex = 26;
            this.labelPourcent.Text = "0";
            // 
            // labelPourcentM
            // 
            this.labelPourcentM.AutoSize = true;
            this.labelPourcentM.Location = new System.Drawing.Point(712, 264);
            this.labelPourcentM.Name = "labelPourcentM";
            this.labelPourcentM.Size = new System.Drawing.Size(14, 16);
            this.labelPourcentM.TabIndex = 27;
            this.labelPourcentM.Text = "0";
            // 
            // labelPourcentF
            // 
            this.labelPourcentF.AutoSize = true;
            this.labelPourcentF.Location = new System.Drawing.Point(712, 296);
            this.labelPourcentF.Name = "labelPourcentF";
            this.labelPourcentF.Size = new System.Drawing.Size(14, 16);
            this.labelPourcentF.TabIndex = 28;
            this.labelPourcentF.Text = "0";
            // 
            // listBoxRecus
            // 
            this.listBoxRecus.FormattingEnabled = true;
            this.listBoxRecus.ItemHeight = 16;
            this.listBoxRecus.Location = new System.Drawing.Point(578, 40);
            this.listBoxRecus.Name = "listBoxRecus";
            this.listBoxRecus.Size = new System.Drawing.Size(147, 100);
            this.listBoxRecus.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 596);
            this.Controls.Add(this.listBoxRecus);
            this.Controls.Add(this.labelPourcentF);
            this.Controls.Add(this.labelPourcentM);
            this.Controls.Add(this.labelPourcent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonAffichRecus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonEnregResultat);
            this.Controls.Add(this.textBoxFautes);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonEnregCandidat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.TextBoxAnnee);
            this.Controls.Add(this.TextBoxNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNom;
        private System.Windows.Forms.TextBox TextBoxAnnee;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEnregCandidat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxFautes;
        private System.Windows.Forms.Button buttonEnregResultat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAffichRecus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelPourcent;
        private System.Windows.Forms.Label labelPourcentM;
        private System.Windows.Forms.Label labelPourcentF;
        private System.Windows.Forms.ListBox listBoxRecus;
    }
}

