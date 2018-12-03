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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandaGeneral));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnColaborador = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarBox = new System.Windows.Forms.Button();
            this.btnCantidadMas = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnCantidadMenos = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClienteBuscar = new System.Windows.Forms.Label();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlServicios = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnPeinado = new System.Windows.Forms.Button();
            this.btnMaquillaje = new System.Windows.Forms.Button();
            this.pnlColaborador = new System.Windows.Forms.FlowLayoutPanel();
            this.btnColaborador1 = new System.Windows.Forms.Button();
            this.btnColaborador2 = new System.Windows.Forms.Button();
            this.btnColaborador3 = new System.Windows.Forms.Button();
            this.btnColaborador4 = new System.Windows.Forms.Button();
            this.btnColaborador5 = new System.Windows.Forms.Button();
            this.btnColaborador6 = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnBorrarNota = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnRegresarComanda = new System.Windows.Forms.Button();
            this.dataServicios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlServicios.SuspendLayout();
            this.pnlColaborador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Silver;
            this.btnCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(6, 6);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(189, 42);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.BackColor = System.Drawing.Color.Silver;
            this.btnServicio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.Location = new System.Drawing.Point(207, 6);
            this.btnServicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(189, 42);
            this.btnServicio.TabIndex = 1;
            this.btnServicio.Text = "SERVICIO";
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.BackColor = System.Drawing.Color.Silver;
            this.btnColaborador.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador.Location = new System.Drawing.Point(408, 6);
            this.btnColaborador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador.TabIndex = 2;
            this.btnColaborador.Text = "COLABORADOR";
            this.btnColaborador.UseVisualStyleBackColor = false;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
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
            this.panel1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(622, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 270);
            this.panel1.TabIndex = 3;
            // 
            // btnEditarBox
            // 
            this.btnEditarBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarBox.Location = new System.Drawing.Point(666, 124);
            this.btnEditarBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditarBox.Name = "btnEditarBox";
            this.btnEditarBox.Size = new System.Drawing.Size(163, 70);
            this.btnEditarBox.TabIndex = 11;
            this.btnEditarBox.Text = "EDITAR";
            this.btnEditarBox.UseVisualStyleBackColor = true;
            // 
            // btnCantidadMas
            // 
            this.btnCantidadMas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMas.Location = new System.Drawing.Point(367, 222);
            this.btnCantidadMas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCantidadMas.Name = "btnCantidadMas";
            this.btnCantidadMas.Size = new System.Drawing.Size(94, 42);
            this.btnCantidadMas.TabIndex = 8;
            this.btnCantidadMas.Text = "+";
            this.btnCantidadMas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Location = new System.Drawing.Point(666, 26);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(163, 70);
            this.btnAgregarServicio.TabIndex = 10;
            this.btnAgregarServicio.Text = "AGREGAR";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnCantidadMenos
            // 
            this.btnCantidadMenos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadMenos.Location = new System.Drawing.Point(530, 220);
            this.btnCantidadMenos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCantidadMenos.Name = "btnCantidadMenos";
            this.btnCantidadMenos.Size = new System.Drawing.Size(94, 42);
            this.btnCantidadMenos.TabIndex = 9;
            this.btnCantidadMenos.Text = "-";
            this.btnCantidadMenos.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(204, 225);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(90, 29);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtColaborador
            // 
            this.txtColaborador.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaborador.Location = new System.Drawing.Point(204, 157);
            this.txtColaborador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(417, 29);
            this.txtColaborador.TabIndex = 6;
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(204, 89);
            this.txtServicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(417, 29);
            this.txtServicio.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(204, 22);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(417, 29);
            this.txtCliente.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(24, 231);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(130, 23);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "CANITIDAD:";
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.Location = new System.Drawing.Point(24, 162);
            this.lblColaborador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(154, 23);
            this.lblColaborador.TabIndex = 2;
            this.lblColaborador.Text = "COLABORADOR:";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(24, 94);
            this.lblServicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(118, 23);
            this.lblServicio.TabIndex = 1;
            this.lblServicio.Text = "SERVICIO:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(24, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(106, 23);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnServicio);
            this.flowLayoutPanel1.Controls.Add(this.btnColaborador);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 54);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataServicios);
            this.panel2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(622, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 474);
            this.panel2.TabIndex = 6;
            // 
            // lblClienteBuscar
            // 
            this.lblClienteBuscar.AutoSize = true;
            this.lblClienteBuscar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBuscar.Location = new System.Drawing.Point(6, 0);
            this.lblClienteBuscar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClienteBuscar.Name = "lblClienteBuscar";
            this.lblClienteBuscar.Size = new System.Drawing.Size(106, 23);
            this.lblClienteBuscar.TabIndex = 7;
            this.lblClienteBuscar.Text = "CLIENTE:";
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteBuscar.Location = new System.Drawing.Point(124, 6);
            this.txtClienteBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(371, 29);
            this.txtClienteBuscar.TabIndex = 8;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteBuscar.Location = new System.Drawing.Point(507, 6);
            this.btnClienteBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(77, 42);
            this.btnClienteBuscar.TabIndex = 9;
            this.btnClienteBuscar.Text = "BUSCAR";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblClienteBuscar);
            this.pnlCliente.Controls.Add(this.txtClienteBuscar);
            this.pnlCliente.Controls.Add(this.btnClienteBuscar);
            this.pnlCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCliente.Location = new System.Drawing.Point(6, 94);
            this.pnlCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(600, 61);
            this.pnlCliente.TabIndex = 10;
            this.pnlCliente.Visible = false;
            // 
            // pnlServicios
            // 
            this.pnlServicios.Controls.Add(this.btnCorte);
            this.pnlServicios.Controls.Add(this.btnPeinado);
            this.pnlServicios.Controls.Add(this.btnMaquillaje);
            this.pnlServicios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlServicios.Location = new System.Drawing.Point(6, 162);
            this.pnlServicios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(600, 229);
            this.pnlServicios.TabIndex = 11;
            this.pnlServicios.Visible = false;
            // 
            // btnCorte
            // 
            this.btnCorte.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.Location = new System.Drawing.Point(6, 6);
            this.btnCorte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(592, 65);
            this.btnCorte.TabIndex = 0;
            this.btnCorte.Text = "CORTE";
            this.btnCorte.UseVisualStyleBackColor = true;
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // btnPeinado
            // 
            this.btnPeinado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeinado.Location = new System.Drawing.Point(6, 83);
            this.btnPeinado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPeinado.Name = "btnPeinado";
            this.btnPeinado.Size = new System.Drawing.Size(592, 65);
            this.btnPeinado.TabIndex = 3;
            this.btnPeinado.Text = "PEINADOS";
            this.btnPeinado.UseVisualStyleBackColor = true;
            this.btnPeinado.Click += new System.EventHandler(this.btnPeinado_Click);
            // 
            // btnMaquillaje
            // 
            this.btnMaquillaje.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaquillaje.Location = new System.Drawing.Point(6, 160);
            this.btnMaquillaje.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMaquillaje.Name = "btnMaquillaje";
            this.btnMaquillaje.Size = new System.Drawing.Size(592, 65);
            this.btnMaquillaje.TabIndex = 4;
            this.btnMaquillaje.Text = "MAQUILLAJE";
            this.btnMaquillaje.UseVisualStyleBackColor = true;
            this.btnMaquillaje.Click += new System.EventHandler(this.btnMaquillaje_Click);
            // 
            // pnlColaborador
            // 
            this.pnlColaborador.Controls.Add(this.btnColaborador1);
            this.pnlColaborador.Controls.Add(this.btnColaborador2);
            this.pnlColaborador.Controls.Add(this.btnColaborador3);
            this.pnlColaborador.Controls.Add(this.btnColaborador4);
            this.pnlColaborador.Controls.Add(this.btnColaborador5);
            this.pnlColaborador.Controls.Add(this.btnColaborador6);
            this.pnlColaborador.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlColaborador.Location = new System.Drawing.Point(6, 402);
            this.pnlColaborador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlColaborador.Name = "pnlColaborador";
            this.pnlColaborador.Size = new System.Drawing.Size(600, 113);
            this.pnlColaborador.TabIndex = 12;
            this.pnlColaborador.Visible = false;
            // 
            // btnColaborador1
            // 
            this.btnColaborador1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador1.Location = new System.Drawing.Point(6, 6);
            this.btnColaborador1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador1.Name = "btnColaborador1";
            this.btnColaborador1.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador1.TabIndex = 0;
            this.btnColaborador1.Text = "1";
            this.btnColaborador1.UseVisualStyleBackColor = true;
            // 
            // btnColaborador2
            // 
            this.btnColaborador2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador2.Location = new System.Drawing.Point(207, 6);
            this.btnColaborador2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador2.Name = "btnColaborador2";
            this.btnColaborador2.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador2.TabIndex = 1;
            this.btnColaborador2.Text = "2";
            this.btnColaborador2.UseVisualStyleBackColor = true;
            // 
            // btnColaborador3
            // 
            this.btnColaborador3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador3.Location = new System.Drawing.Point(6, 60);
            this.btnColaborador3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador3.Name = "btnColaborador3";
            this.btnColaborador3.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador3.TabIndex = 2;
            this.btnColaborador3.Text = "3";
            this.btnColaborador3.UseVisualStyleBackColor = true;
            // 
            // btnColaborador4
            // 
            this.btnColaborador4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador4.Location = new System.Drawing.Point(207, 60);
            this.btnColaborador4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador4.Name = "btnColaborador4";
            this.btnColaborador4.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador4.TabIndex = 3;
            this.btnColaborador4.Text = "4";
            this.btnColaborador4.UseVisualStyleBackColor = true;
            // 
            // btnColaborador5
            // 
            this.btnColaborador5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador5.Location = new System.Drawing.Point(6, 114);
            this.btnColaborador5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador5.Name = "btnColaborador5";
            this.btnColaborador5.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador5.TabIndex = 4;
            this.btnColaborador5.Text = "5";
            this.btnColaborador5.UseVisualStyleBackColor = true;
            // 
            // btnColaborador6
            // 
            this.btnColaborador6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaborador6.Location = new System.Drawing.Point(207, 114);
            this.btnColaborador6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColaborador6.Name = "btnColaborador6";
            this.btnColaborador6.Size = new System.Drawing.Size(189, 42);
            this.btnColaborador6.TabIndex = 5;
            this.btnColaborador6.Text = "6";
            this.btnColaborador6.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(623, 788);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(191, 103);
            this.btnCobrar.TabIndex = 13;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarNota
            // 
            this.btnBorrarNota.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNota.Location = new System.Drawing.Point(836, 788);
            this.btnBorrarNota.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBorrarNota.Name = "btnBorrarNota";
            this.btnBorrarNota.Size = new System.Drawing.Size(191, 103);
            this.btnBorrarNota.TabIndex = 14;
            this.btnBorrarNota.Text = "BORRAR";
            this.btnBorrarNota.UseVisualStyleBackColor = true;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuesto.Location = new System.Drawing.Point(1049, 788);
            this.btnPresupuesto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(191, 103);
            this.btnPresupuesto.TabIndex = 15;
            this.btnPresupuesto.Text = "PRESUPEUSTO";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnRegresarComanda
            // 
            this.btnRegresarComanda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresarComanda.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarComanda.Location = new System.Drawing.Point(1261, 788);
            this.btnRegresarComanda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegresarComanda.Name = "btnRegresarComanda";
            this.btnRegresarComanda.Size = new System.Drawing.Size(191, 103);
            this.btnRegresarComanda.TabIndex = 16;
            this.btnRegresarComanda.Text = "REGRESAR";
            this.btnRegresarComanda.UseVisualStyleBackColor = true;
            this.btnRegresarComanda.Click += new System.EventHandler(this.btnRegresarComanda_Click);
            // 
            // dataServicios
            // 
            this.dataServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServicios.Location = new System.Drawing.Point(3, 6);
            this.dataServicios.Name = "dataServicios";
            this.dataServicios.RowTemplate.Height = 31;
            this.dataServicios.Size = new System.Drawing.Size(826, 465);
            this.dataServicios.TabIndex = 8;
            // 
            // ComandaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnRegresarComanda;
            this.ClientSize = new System.Drawing.Size(1472, 914);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnBorrarNota);
            this.Controls.Add(this.pnlColaborador);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.btnRegresarComanda);
            this.Controls.Add(this.pnlServicios);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ComandaGeneral";
            this.Text = "ComandaGeneral";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlServicios.ResumeLayout(false);
            this.pnlColaborador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataServicios)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel pnlCliente;
        private System.Windows.Forms.FlowLayoutPanel pnlServicios;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnPeinado;
        private System.Windows.Forms.Button btnMaquillaje;
        private System.Windows.Forms.FlowLayoutPanel pnlColaborador;
        private System.Windows.Forms.Button btnColaborador1;
        private System.Windows.Forms.Button btnColaborador2;
        private System.Windows.Forms.Button btnColaborador3;
        private System.Windows.Forms.Button btnColaborador4;
        private System.Windows.Forms.Button btnColaborador5;
        private System.Windows.Forms.Button btnColaborador6;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnBorrarNota;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnRegresarComanda;
        private System.Windows.Forms.DataGridView dataServicios;
    }
}