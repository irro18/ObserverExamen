namespace ObserverExamen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monitorearBoton = new System.Windows.Forms.Button();
            this.stopMonitorBoton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ConectadaLabel = new System.Windows.Forms.Label();
            this.DesconectadaLabel = new System.Windows.Forms.Label();
            this.CargandoLabel = new System.Windows.Forms.Label();
            this.DescargandoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de la Batería:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actividad Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo de carga/descarga:\r\n";
            // 
            // monitorearBoton
            // 
            this.monitorearBoton.Location = new System.Drawing.Point(42, 350);
            this.monitorearBoton.Name = "monitorearBoton";
            this.monitorearBoton.Size = new System.Drawing.Size(257, 23);
            this.monitorearBoton.TabIndex = 4;
            this.monitorearBoton.Text = "Monitorear";
            this.monitorearBoton.UseVisualStyleBackColor = true;
            this.monitorearBoton.Click += new System.EventHandler(this.MonitorearBoton_Click);
            // 
            // stopMonitorBoton
            // 
            this.stopMonitorBoton.Location = new System.Drawing.Point(42, 388);
            this.stopMonitorBoton.Name = "stopMonitorBoton";
            this.stopMonitorBoton.Size = new System.Drawing.Size(257, 23);
            this.stopMonitorBoton.TabIndex = 5;
            this.stopMonitorBoton.Text = "Dejar de Monitorear";
            this.stopMonitorBoton.UseVisualStyleBackColor = true;
            this.stopMonitorBoton.Click += new System.EventHandler(this.StopMonitorBoton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // ConectadaLabel
            // 
            this.ConectadaLabel.AutoSize = true;
            this.ConectadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectadaLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.ConectadaLabel.Location = new System.Drawing.Point(38, 202);
            this.ConectadaLabel.Name = "ConectadaLabel";
            this.ConectadaLabel.Size = new System.Drawing.Size(106, 22);
            this.ConectadaLabel.TabIndex = 7;
            this.ConectadaLabel.Text = "Conectada";
            // 
            // DesconectadaLabel
            // 
            this.DesconectadaLabel.AutoSize = true;
            this.DesconectadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesconectadaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DesconectadaLabel.Location = new System.Drawing.Point(184, 202);
            this.DesconectadaLabel.Name = "DesconectadaLabel";
            this.DesconectadaLabel.Size = new System.Drawing.Size(137, 22);
            this.DesconectadaLabel.TabIndex = 8;
            this.DesconectadaLabel.Text = "Desconectada";
            // 
            // CargandoLabel
            // 
            this.CargandoLabel.AutoSize = true;
            this.CargandoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargandoLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.CargandoLabel.Location = new System.Drawing.Point(38, 267);
            this.CargandoLabel.Name = "CargandoLabel";
            this.CargandoLabel.Size = new System.Drawing.Size(97, 22);
            this.CargandoLabel.TabIndex = 9;
            this.CargandoLabel.Text = "Cargando";
            // 
            // DescargandoLabel
            // 
            this.DescargandoLabel.AutoSize = true;
            this.DescargandoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescargandoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescargandoLabel.Location = new System.Drawing.Point(184, 267);
            this.DescargandoLabel.Name = "DescargandoLabel";
            this.DescargandoLabel.Size = new System.Drawing.Size(128, 22);
            this.DescargandoLabel.TabIndex = 10;
            this.DescargandoLabel.Text = "Descargando";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado de la Batería:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Conectada",
            "Desconectada"});
            this.comboBox1.Location = new System.Drawing.Point(101, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Actividad Actual:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cargando",
            "Descargando"});
            this.comboBox2.Location = new System.Drawing.Point(101, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Tag = "";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 456);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescargandoLabel);
            this.Controls.Add(this.CargandoLabel);
            this.Controls.Add(this.DesconectadaLabel);
            this.Controls.Add(this.ConectadaLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.stopMonitorBoton);
            this.Controls.Add(this.monitorearBoton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button monitorearBoton;
        private System.Windows.Forms.Button stopMonitorBoton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ConectadaLabel;
        private System.Windows.Forms.Label DesconectadaLabel;
        private System.Windows.Forms.Label CargandoLabel;
        private System.Windows.Forms.Label DescargandoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

