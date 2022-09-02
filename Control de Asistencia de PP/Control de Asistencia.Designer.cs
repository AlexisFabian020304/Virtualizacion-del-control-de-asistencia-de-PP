namespace Control_de_Asistencia_de_PP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSlide = new System.Windows.Forms.Panel();
            this.botton_Datos = new System.Windows.Forms.Button();
            this.botton_Asociar = new System.Windows.Forms.Button();
            this.botton_Alumno = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Red;
            this.panelSlide.Controls.Add(this.botton_Datos);
            this.panelSlide.Controls.Add(this.botton_Asociar);
            this.panelSlide.Controls.Add(this.botton_Alumno);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(181, 385);
            this.panelSlide.TabIndex = 0;
            // 
            // botton_Datos
            // 
            this.botton_Datos.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_Datos.Location = new System.Drawing.Point(0, 108);
            this.botton_Datos.Name = "botton_Datos";
            this.botton_Datos.Size = new System.Drawing.Size(181, 54);
            this.botton_Datos.TabIndex = 2;
            this.botton_Datos.Text = "Datos";
            this.botton_Datos.UseVisualStyleBackColor = true;
            this.botton_Datos.Click += new System.EventHandler(this.botton_Datos_Click);
            // 
            // botton_Asociar
            // 
            this.botton_Asociar.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_Asociar.Location = new System.Drawing.Point(0, 54);
            this.botton_Asociar.Name = "botton_Asociar";
            this.botton_Asociar.Size = new System.Drawing.Size(181, 54);
            this.botton_Asociar.TabIndex = 1;
            this.botton_Asociar.Text = "Asociar";
            this.botton_Asociar.UseVisualStyleBackColor = true;
            this.botton_Asociar.Click += new System.EventHandler(this.botton_Asociar_Click);
            // 
            // botton_Alumno
            // 
            this.botton_Alumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.botton_Alumno.Location = new System.Drawing.Point(0, 0);
            this.botton_Alumno.Name = "botton_Alumno";
            this.botton_Alumno.Size = new System.Drawing.Size(181, 54);
            this.botton_Alumno.TabIndex = 0;
            this.botton_Alumno.Text = "Alumno";
            this.botton_Alumno.UseVisualStyleBackColor = true;
            this.botton_Alumno.Click += new System.EventHandler(this.botton_Alumno_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(181, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(586, 385);
            this.panelChildForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 385);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSlide);
            this.MinimumSize = new System.Drawing.Size(783, 424);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSlide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSlide;
        private Button botton_Datos;
        private Button botton_Asociar;
        private Button botton_Alumno;
        private Panel panelChildForm;
    }
}