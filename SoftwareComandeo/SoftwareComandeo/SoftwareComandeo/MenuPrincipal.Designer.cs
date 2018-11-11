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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnCerrarSesionMenu = new System.Windows.Forms.Button();
            this.btnCorteDeCaja = new System.Windows.Forms.Button();
            this.btnComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarSesionMenu
            // 
            this.btnCerrarSesionMenu.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesionMenu.Location = new System.Drawing.Point(195, 341);
            this.btnCerrarSesionMenu.Name = "btnCerrarSesionMenu";
            this.btnCerrarSesionMenu.Size = new System.Drawing.Size(192, 68);
            this.btnCerrarSesionMenu.TabIndex = 2;
            this.btnCerrarSesionMenu.Text = "CERRAR SESION";
            this.btnCerrarSesionMenu.UseVisualStyleBackColor = true;
            this.btnCerrarSesionMenu.Click += new System.EventHandler(this.btnCerrarSesionMenu_Click);
            // 
            // btnCorteDeCaja
            // 
            this.btnCorteDeCaja.AutoSize = true;
            this.btnCorteDeCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorteDeCaja.BackgroundImage")));
            this.btnCorteDeCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCorteDeCaja.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteDeCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCorteDeCaja.ImageKey = "(ninguno)";
            this.btnCorteDeCaja.Location = new System.Drawing.Point(274, 15);
            this.btnCorteDeCaja.Name = "btnCorteDeCaja";
            this.btnCorteDeCaja.Size = new System.Drawing.Size(262, 320);
            this.btnCorteDeCaja.TabIndex = 1;
            this.btnCorteDeCaja.Text = "CORTE DE CAJA";
            this.btnCorteDeCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCorteDeCaja.UseVisualStyleBackColor = true;
            // 
            // btnComanda
            // 
            this.btnComanda.AutoSize = true;
            this.btnComanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComanda.BackgroundImage")));
            this.btnComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnComanda.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComanda.ImageKey = "(ninguno)";
            this.btnComanda.Location = new System.Drawing.Point(12, 15);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(262, 320);
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
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(548, 412);
            this.Controls.Add(this.btnCerrarSesionMenu);
            this.Controls.Add(this.btnCorteDeCaja);
            this.Controls.Add(this.btnComanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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