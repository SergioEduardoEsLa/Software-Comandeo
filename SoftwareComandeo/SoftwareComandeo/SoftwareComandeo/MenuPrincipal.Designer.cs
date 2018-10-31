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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "CERRAR SESION";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCorteDeCaja
            // 
            this.btnCorteDeCaja.AutoSize = true;
            this.btnCorteDeCaja.Image = global::SoftwareComandeo.Properties.Resources.descarga;
            this.btnCorteDeCaja.ImageKey = "(ninguno)";
            this.btnCorteDeCaja.Location = new System.Drawing.Point(274, 40);
            this.btnCorteDeCaja.Name = "btnCorteDeCaja";
            this.btnCorteDeCaja.Size = new System.Drawing.Size(231, 276);
            this.btnCorteDeCaja.TabIndex = 1;
            this.btnCorteDeCaja.Text = "CORTE DE CAJA";
            this.btnCorteDeCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteDeCaja.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = global::SoftwareComandeo.Properties.Resources.descarga;
            this.button1.ImageKey = "(ninguno)";
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 276);
            this.button1.TabIndex = 0;
            this.button1.Text = "COMANDA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCorteDeCaja);
            this.Controls.Add(this.button1);
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCorteDeCaja;
        private System.Windows.Forms.Button button2;
    }
}