namespace SoftwareComandeo
{
    partial class frmMenuPrincipal
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnCorteDeCaja = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 415);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "CERRAR SESION";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCorteDeCaja
            // 
            this.btnCorteDeCaja.AutoSize = true;
            this.btnCorteDeCaja.ImageKey = "(ninguno)";
            this.btnCorteDeCaja.Location = new System.Drawing.Point(365, 49);
            this.btnCorteDeCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCorteDeCaja.Name = "btnCorteDeCaja";
            this.btnCorteDeCaja.Size = new System.Drawing.Size(308, 340);
            this.btnCorteDeCaja.TabIndex = 1;
            this.btnCorteDeCaja.Text = "CORTE DE CAJA";
            this.btnCorteDeCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteDeCaja.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.AutoSize = true;
            this.btnComanda.ImageKey = "(ninguno)";
            this.btnComanda.Location = new System.Drawing.Point(16, 49);
            this.btnComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(308, 340);
            this.btnComanda.TabIndex = 0;
            this.btnComanda.Text = "COMANDA";
            this.btnComanda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCorteDeCaja);
            this.Controls.Add(this.btnComanda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnCorteDeCaja;
        private System.Windows.Forms.Button button2;
    }
}