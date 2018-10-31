namespace SoftwareComandeo
{
    partial class ComandaGeneral
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCantidadMas = new System.Windows.Forms.Button();
            this.btnCantidadMenos = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnEditarBox = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClienteBuscar = new System.Windows.Forms.Label();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(3, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(103, 23);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(112, 3);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(103, 23);
            this.btnServicio.TabIndex = 1;
            this.btnServicio.Text = "SERVICIO";
            this.btnServicio.UseVisualStyleBackColor = true;
            // 
            // btnColaborador
            // 
            this.btnColaborador.Location = new System.Drawing.Point(221, 3);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(103, 23);
            this.btnColaborador.TabIndex = 2;
            this.btnColaborador.Text = "COLABORADOR";
            this.btnColaborador.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnEditarBox);
            this.panel1.Controls.Add(this.btnCantidadMas);
            this.panel1.Controls.Add(this.btnAgregarServicio);
            this.panel1.Controls.Add(this.btnCantidadMenos);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtColaborador);
            this.panel1.Controls.Add(this.txtServicio);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.lblColaborador);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(339, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 146);
            this.panel1.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 14);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(13, 51);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(60, 13);
            this.lblServicio.TabIndex = 1;
            this.lblServicio.Text = "SERVICIO:";
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Location = new System.Drawing.Point(13, 88);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(92, 13);
            this.lblColaborador.TabIndex = 2;
            this.lblColaborador.Text = "COLABORADOR:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 125);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "CANITIDAD:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(111, 12);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(229, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(111, 48);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(229, 20);
            this.txtServicio.TabIndex = 5;
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(111, 85);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(229, 20);
            this.txtColaborador.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(111, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(51, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnCantidadMas
            // 
            this.btnCantidadMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMas.Location = new System.Drawing.Point(200, 120);
            this.btnCantidadMas.Name = "btnCantidadMas";
            this.btnCantidadMas.Size = new System.Drawing.Size(51, 23);
            this.btnCantidadMas.TabIndex = 8;
            this.btnCantidadMas.Text = "+";
            this.btnCantidadMas.UseVisualStyleBackColor = true;
            // 
            // btnCantidadMenos
            // 
            this.btnCantidadMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMenos.Location = new System.Drawing.Point(289, 119);
            this.btnCantidadMenos.Name = "btnCantidadMenos";
            this.btnCantidadMenos.Size = new System.Drawing.Size(51, 23);
            this.btnCantidadMenos.TabIndex = 9;
            this.btnCantidadMenos.Text = "-";
            this.btnCantidadMenos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(363, 14);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(89, 38);
            this.btnAgregarServicio.TabIndex = 10;
            this.btnAgregarServicio.Text = "AGREGAR";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnEditarBox
            // 
            this.btnEditarBox.Location = new System.Drawing.Point(363, 67);
            this.btnEditarBox.Name = "btnEditarBox";
            this.btnEditarBox.Size = new System.Drawing.Size(89, 38);
            this.btnEditarBox.TabIndex = 11;
            this.btnEditarBox.Text = "EDITAR";
            this.btnEditarBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnServicio);
            this.flowLayoutPanel1.Controls.Add(this.btnColaborador);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(339, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 257);
            this.panel2.TabIndex = 6;
            // 
            // lblClienteBuscar
            // 
            this.lblClienteBuscar.AutoSize = true;
            this.lblClienteBuscar.Location = new System.Drawing.Point(3, 0);
            this.lblClienteBuscar.Name = "lblClienteBuscar";
            this.lblClienteBuscar.Size = new System.Drawing.Size(55, 13);
            this.lblClienteBuscar.TabIndex = 7;
            this.lblClienteBuscar.Text = "CLIENTE:";
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Location = new System.Drawing.Point(64, 3);
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(204, 20);
            this.txtClienteBuscar.TabIndex = 8;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(274, 3);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(42, 23);
            this.btnClienteBuscar.TabIndex = 9;
            this.btnClienteBuscar.Text = "BUSCAR";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblClienteBuscar);
            this.flowLayoutPanel2.Controls.Add(this.txtClienteBuscar);
            this.flowLayoutPanel2.Controls.Add(this.btnClienteBuscar);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(324, 33);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // ComandaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ComandaGeneral";
            this.Text = "ComandaGeneral";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditarBox;
        private System.Windows.Forms.Button btnCantidadMas;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnCantidadMenos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClienteBuscar;
        private System.Windows.Forms.TextBox txtClienteBuscar;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}