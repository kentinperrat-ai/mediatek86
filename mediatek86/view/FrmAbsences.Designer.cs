namespace mediatek86.view
{
    partial class Form2
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
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(12, 12);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(776, 357);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(100, 386);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAbsence.TabIndex = 1;
            this.btnAjouterAbsence.Text = "Ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(375, 386);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAbsence.TabIndex = 2;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(671, 386);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnRetour;
    }
}