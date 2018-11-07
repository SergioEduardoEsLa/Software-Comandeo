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
            this.btnCerrarSesionMenu = new System.Windows.Forms.Button();
            this.btnCorteDeCaja = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarSesionMenu
            // 
            this.btnCerrarSesionMenu.Location = new System.Drawing.Point(161, 337);
            this.btnCerrarSesionMenu.Name = "btnCerrarSesionMenu";
            this.btnCerrarSesionMenu.Size = new System.Drawing.Size(192, 68);
            this.btnCerrarSesionMenu.TabIndex = 2;
            this.btnCerrarSesionMenu.Text = "CERRAR SESION";
            this.btnCerrarSesionMenu.UseVisualStyleBackColor = true;
            // 
            // btnCorteDeCaja
            // 
            this.btnCorteDeCaja.AutoSize = true;
            this.btnCorteDeCaja.ImageKey = "(ninguno)";
            this.btnCorteDeCaja.Location = new System.Drawing.Point(274, 40);
            this.btnCorteDeCaja.Name = "btnCorteDeCaja";
            this.btnCorteDeCaja.Size = new System.Drawing.Size(231, 276);
            this.btnCorteDeCaja.TabIndex = 1;
            this.btnCorteDeCaja.Text = "CORTE DE CAJA";
            this.btnCorteDeCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteDeCaja.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.AutoSize = true;
            this.btnComanda.ImageKey = "(ninguno)";
            this.btnComanda.Location = new System.Drawing.Point(12, 40);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(231, 276);
            this.btnComanda.TabIndex = 0;
            this.btnComanda.Text = "COMANDA";
            this.btnComanda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 421);
            this.Controls.Add(this.btnCerrarSesionMenu);
            this.Controls.Add(this.btnCorteDeCaja);
            this.Controls.Add(this.btnComanda);
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnCorteDeCaja;
        private System.Windows.Forms.Button btnCerrarSesionMenu;
    }
}