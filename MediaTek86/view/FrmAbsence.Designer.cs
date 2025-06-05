namespace MediaTek86
{
    partial class FrmAbsence
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
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdpersonnel = new System.Windows.Forms.TextBox();
            this.txtDatedebut = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtDatefin = new System.Windows.Forms.TextBox();
            this.gbAbsence = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.gbAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(0, 0);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.RowHeadersWidth = 51;
            this.dgvAbsence.RowTemplate.Height = 24;
            this.dgvAbsence.Size = new System.Drawing.Size(673, 292);
            this.dgvAbsence.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(113, 298);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(216, 298);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(8, 298);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(330, 298);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "idpersonnel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "date début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "motif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "date fin";
            // 
            // txtIdpersonnel
            // 
            this.txtIdpersonnel.Location = new System.Drawing.Point(90, 33);
            this.txtIdpersonnel.Name = "txtIdpersonnel";
            this.txtIdpersonnel.Size = new System.Drawing.Size(145, 22);
            this.txtIdpersonnel.TabIndex = 9;
            // 
            // txtDatedebut
            // 
            this.txtDatedebut.Location = new System.Drawing.Point(318, 30);
            this.txtDatedebut.Name = "txtDatedebut";
            this.txtDatedebut.Size = new System.Drawing.Size(156, 22);
            this.txtDatedebut.TabIndex = 10;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(90, 92);
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(145, 22);
            this.txtMotif.TabIndex = 11;
            // 
            // txtDatefin
            // 
            this.txtDatefin.Location = new System.Drawing.Point(318, 95);
            this.txtDatefin.Name = "txtDatefin";
            this.txtDatefin.Size = new System.Drawing.Size(156, 22);
            this.txtDatefin.TabIndex = 12;
            // 
            // gbAbsence
            // 
            this.gbAbsence.Controls.Add(this.txtIdpersonnel);
            this.gbAbsence.Controls.Add(this.txtDatefin);
            this.gbAbsence.Controls.Add(this.label1);
            this.gbAbsence.Controls.Add(this.txtMotif);
            this.gbAbsence.Controls.Add(this.label2);
            this.gbAbsence.Controls.Add(this.txtDatedebut);
            this.gbAbsence.Controls.Add(this.label3);
            this.gbAbsence.Controls.Add(this.label4);
            this.gbAbsence.Location = new System.Drawing.Point(0, 355);
            this.gbAbsence.Name = "gbAbsence";
            this.gbAbsence.Size = new System.Drawing.Size(502, 128);
            this.gbAbsence.TabIndex = 13;
            this.gbAbsence.TabStop = false;
            this.gbAbsence.Text = "Ajouter une absence";
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 495);
            this.Controls.Add(this.gbAbsence);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.gbAbsence.ResumeLayout(false);
            this.gbAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdpersonnel;
        private System.Windows.Forms.TextBox txtDatedebut;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtDatefin;
        private System.Windows.Forms.GroupBox gbAbsence;
    }
}