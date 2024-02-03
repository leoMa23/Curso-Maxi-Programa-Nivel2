namespace presentacion
{
    partial class frmVerDetalle
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
            this.pbDetalle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDetalle
            // 
            this.pbDetalle.Location = new System.Drawing.Point(55, 45);
            this.pbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.pbDetalle.Name = "pbDetalle";
            this.pbDetalle.Size = new System.Drawing.Size(285, 286);
            this.pbDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetalle.TabIndex = 0;
            this.pbDetalle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "DETALLE ARTICULO";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.Location = new System.Drawing.Point(55, 338);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.Size = new System.Drawing.Size(284, 143);
            this.txtDetalles.TabIndex = 8;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 525);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDetalle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerDetalle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Detalle";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalles;
    }
}