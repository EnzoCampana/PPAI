namespace G1_PPA1_E1
{
    partial class PantallaConsulta
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.gridLlamadas = new System.Windows.Forms.DataGridView();
            this.btnBuscarLlamadas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(70, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(290, 35);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // gridLlamadas
            // 
            this.gridLlamadas.AllowUserToAddRows = false;
            this.gridLlamadas.AllowUserToDeleteRows = false;
            this.gridLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLlamadas.Location = new System.Drawing.Point(70, 90);
            this.gridLlamadas.Name = "gridLlamadas";
            this.gridLlamadas.ReadOnly = true;
            this.gridLlamadas.Size = new System.Drawing.Size(531, 285);
            this.gridLlamadas.TabIndex = 2;
            // 
            // btnBuscarLlamadas
            // 
            this.btnBuscarLlamadas.Location = new System.Drawing.Point(526, 32);
            this.btnBuscarLlamadas.Name = "btnBuscarLlamadas";
            this.btnBuscarLlamadas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLlamadas.TabIndex = 3;
            this.btnBuscarLlamadas.Text = "Buscar";
            this.btnBuscarLlamadas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 198);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(70, 13);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(104, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha Inicio Periodo";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(290, 13);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(93, 13);
            this.lblFechaFin.TabIndex = 6;
            this.lblFechaFin.Text = "Fecha Fin Periodo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(526, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PantallaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarLlamadas);
            this.Controls.Add(this.gridLlamadas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "PantallaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataGridView gridLlamadas;
        private System.Windows.Forms.Button btnBuscarLlamadas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

