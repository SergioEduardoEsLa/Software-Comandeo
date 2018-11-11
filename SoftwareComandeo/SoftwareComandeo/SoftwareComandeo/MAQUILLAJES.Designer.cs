namespace SoftwareComandeo
{
    partial class MAQUILLAJES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAQUILLAJES));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRegresarMaquillajes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 185);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "MAQUILLAJE PROFESIONAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "MAQUILLAJE DE NOVIA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "MAQUILLAJE XV AÑOS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 85);
            this.button4.TabIndex = 2;
            this.button4.Text = "PRUEBA MAQUILLAJE NOVIA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 85);
            this.button5.TabIndex = 2;
            this.button5.Text = "PRUEBA MAQUILLAJE XV AÑOS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(311, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 85);
            this.button6.TabIndex = 3;
            this.button6.Text = "MAQUILLAJE AEROGRAFO";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMaquillajes
            // 
            this.btnRegresarMaquillajes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresarMaquillajes.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarMaquillajes.Image")));
            this.btnRegresarMaquillajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresarMaquillajes.Location = new System.Drawing.Point(169, 205);
            this.btnRegresarMaquillajes.Name = "btnRegresarMaquillajes";
            this.btnRegresarMaquillajes.Size = new System.Drawing.Size(148, 79);
            this.btnRegresarMaquillajes.TabIndex = 2;
            this.btnRegresarMaquillajes.Text = "REGRESAR";
            this.btnRegresarMaquillajes.UseVisualStyleBackColor = true;
            this.btnRegresarMaquillajes.Click += new System.EventHandler(this.btnRegresarMaquillajes_Click);
            // 
            // MAQUILLAJES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(483, 296);
            this.Controls.Add(this.btnRegresarMaquillajes);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MAQUILLAJES";
            this.Text = "MAQUILLAJES";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRegresarMaquillajes;
    }
}