namespace Control_de_Asistencia_de_PP
{
    partial class Datos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Guardar = new System.Windows.Forms.Button();
            this.columIdAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ausPres = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalInas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIdAl,
            this.columNombre,
            this.coluApellido,
            this.hEntrada,
            this.ausPres,
            this.fecha,
            this.totalAsis,
            this.totalInas});
            this.dataGridView1.Location = new System.Drawing.Point(31, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // but_Guardar
            // 
            this.but_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_Guardar.Location = new System.Drawing.Point(610, 334);
            this.but_Guardar.Name = "but_Guardar";
            this.but_Guardar.Size = new System.Drawing.Size(126, 27);
            this.but_Guardar.TabIndex = 1;
            this.but_Guardar.Text = "Guardar";
            this.but_Guardar.UseVisualStyleBackColor = true;
            this.but_Guardar.Click += new System.EventHandler(this.but_Guardar_Click);
            // 
            // columIdAl
            // 
            this.columIdAl.DataPropertyName = "id_Alumno";
            this.columIdAl.HeaderText = "Id Alumno";
            this.columIdAl.Name = "columIdAl";
            // 
            // columNombre
            // 
            this.columNombre.DataPropertyName = "Nombre";
            this.columNombre.HeaderText = "Nombre";
            this.columNombre.Name = "columNombre";
            // 
            // coluApellido
            // 
            this.coluApellido.DataPropertyName = "Apellido";
            this.coluApellido.HeaderText = "Apellido";
            this.coluApellido.Name = "coluApellido";
            // 
            // hEntrada
            // 
            this.hEntrada.DataPropertyName = "Hora_de_Entrada";
            this.hEntrada.HeaderText = "Hora de Entrada";
            this.hEntrada.Name = "hEntrada";
            // 
            // ausPres
            // 
            this.ausPres.DataPropertyName = "Condicion";
            this.ausPres.HeaderText = "Condicion";
            this.ausPres.Name = "ausPres";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // totalAsis
            // 
            this.totalAsis.DataPropertyName = "total_Asistencia";
            this.totalAsis.HeaderText = "Total de Asistencia";
            this.totalAsis.Name = "totalAsis";
            // 
            // totalInas
            // 
            this.totalInas.DataPropertyName = "total_Inasistencias";
            this.totalInas.HeaderText = "Total de Inasistencia";
            this.totalInas.Name = "totalInas";
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 385);
            this.Controls.Add(this.but_Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button but_Guardar;
        private DataGridViewTextBoxColumn columIdAl;
        private DataGridViewTextBoxColumn columNombre;
        private DataGridViewTextBoxColumn coluApellido;
        private DataGridViewTextBoxColumn hEntrada;
        private DataGridViewComboBoxColumn ausPres;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn totalAsis;
        private DataGridViewTextBoxColumn totalInas;
    }
}