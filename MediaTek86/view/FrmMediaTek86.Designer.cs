namespace MediaTek86
{
    partial class FrmMediatek
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPersonnel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.gbPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(713, 236);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(-1, 251);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(80, 251);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(170, 251);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(606, 251);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(274, 71);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(164, 22);
            this.txtMail.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(66, 74);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(152, 22);
            this.txtTel.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(274, 21);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(164, 22);
            this.txtPrenom.TabIndex = 11;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(66, 21);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(152, 22);
            this.txtNom.TabIndex = 12;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(261, 251);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(505, 21);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(121, 24);
            this.cboService.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "service";
            // 
            // gbPersonnel
            // 
            this.gbPersonnel.Controls.Add(this.txtNom);
            this.gbPersonnel.Controls.Add(this.label5);
            this.gbPersonnel.Controls.Add(this.label1);
            this.gbPersonnel.Controls.Add(this.cboService);
            this.gbPersonnel.Controls.Add(this.label2);
            this.gbPersonnel.Controls.Add(this.label3);
            this.gbPersonnel.Controls.Add(this.label4);
            this.gbPersonnel.Controls.Add(this.txtPrenom);
            this.gbPersonnel.Controls.Add(this.txtMail);
            this.gbPersonnel.Controls.Add(this.txtTel);
            this.gbPersonnel.Location = new System.Drawing.Point(0, 283);
            this.gbPersonnel.Name = "gbPersonnel";
            this.gbPersonnel.Size = new System.Drawing.Size(713, 100);
            this.gbPersonnel.TabIndex = 17;
            this.gbPersonnel.TabStop = false;
            this.gbPersonnel.Text = "Ajouter un personnel";
            // 
            // FrmMediatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 395);
            this.Controls.Add(this.gbPersonnel);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvPersonnel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMediatek";
            this.Text = "MediaTek 86";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.gbPersonnel.ResumeLayout(false);
            this.gbPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPersonnel;
    }
}

