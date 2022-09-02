namespace Control_de_Asistencia_de_PP
{
    partial class Alumno
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
            this.button_IngresarDatos = new System.Windows.Forms.Button();
            this.texbox_Apellido = new System.Windows.Forms.TextBox();
            this.texbox_Nombre = new System.Windows.Forms.TextBox();
            this.dato_Nombre = new System.Windows.Forms.Label();
            this.titulo_Alumnos = new System.Windows.Forms.Label();
            this.dato_Apellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_IngresarDatos
            // 
            this.button_IngresarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_IngresarDatos.Location = new System.Drawing.Point(319, 200);
            this.button_IngresarDatos.Name = "button_IngresarDatos";
            this.button_IngresarDatos.Size = new System.Drawing.Size(154, 30);
            this.button_IngresarDatos.TabIndex = 12;
            this.button_IngresarDatos.Text = "Ingresar";
            this.button_IngresarDatos.UseVisualStyleBackColor = true;
            this.button_IngresarDatos.Click += new System.EventHandler(this.button_IngresarDatos_Click);
            // 
            // texbox_Apellido
            // 
            this.texbox_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.texbox_Apellido.Location = new System.Drawing.Point(329, 140);
            this.texbox_Apellido.Name = "texbox_Apellido";
            this.texbox_Apellido.Size = new System.Drawing.Size(132, 23);
            this.texbox_Apellido.TabIndex = 11;
            // 
            // texbox_Nombre
            // 
            this.texbox_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.texbox_Nombre.Location = new System.Drawing.Point(329, 87);
            this.texbox_Nombre.Name = "texbox_Nombre";
            this.texbox_Nombre.Size = new System.Drawing.Size(132, 23);
            this.texbox_Nombre.TabIndex = 10;
            // 
            // dato_Nombre
            // 
            this.dato_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dato_Nombre.AutoSize = true;
            this.dato_Nombre.Location = new System.Drawing.Point(369, 69);
            this.dato_Nombre.Name = "dato_Nombre";
            this.dato_Nombre.Size = new System.Drawing.Size(51, 15);
            this.dato_Nombre.TabIndex = 9;
            this.dato_Nombre.Text = "Nombre";
            // 
            // titulo_Alumnos
            // 
            this.titulo_Alumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo_Alumnos.AutoSize = true;
            this.titulo_Alumnos.Location = new System.Drawing.Point(351, 35);
            this.titulo_Alumnos.Name = "titulo_Alumnos";
            this.titulo_Alumnos.Size = new System.Drawing.Size(95, 15);
            this.titulo_Alumnos.TabIndex = 8;
            this.titulo_Alumnos.Text = "Ingresar Alumno";
            // 
            // dato_Apellido
            // 
            this.dato_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dato_Apellido.AutoSize = true;
            this.dato_Apellido.Location = new System.Drawing.Point(369, 122);
            this.dato_Apellido.Name = "dato_Apellido";
            this.dato_Apellido.Size = new System.Drawing.Size(51, 15);
            this.dato_Apellido.TabIndex = 13;
            this.dato_Apellido.Text = "Apellido";
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 385);
            this.Controls.Add(this.dato_Apellido);
            this.Controls.Add(this.button_IngresarDatos);
            this.Controls.Add(this.texbox_Apellido);
            this.Controls.Add(this.texbox_Nombre);
            this.Controls.Add(this.dato_Nombre);
            this.Controls.Add(this.titulo_Alumnos);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_IngresarDatos;
        private TextBox texbox_Apellido;
        private TextBox texbox_Nombre;
        private Label dato_Nombre;
        private Label titulo_Alumnos;
        private Label dato_Apellido;
    }
}