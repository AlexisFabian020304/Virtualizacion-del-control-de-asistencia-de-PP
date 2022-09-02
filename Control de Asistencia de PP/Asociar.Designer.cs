namespace Control_de_Asistencia_de_PP
{
    partial class Asociar
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
            this.txt_Alumno = new System.Windows.Forms.Label();
            this.cmBox_Alumno = new System.Windows.Forms.ComboBox();
            this.txt_Tarjeta = new System.Windows.Forms.Label();
            this.textBox_Tarjeta = new System.Windows.Forms.TextBox();
            this.asociar_Button = new System.Windows.Forms.Button();
            this.desasociar_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Alumno
            // 
            this.txt_Alumno.AutoSize = true;
            this.txt_Alumno.Location = new System.Drawing.Point(244, 56);
            this.txt_Alumno.Name = "txt_Alumno";
            this.txt_Alumno.Size = new System.Drawing.Size(50, 15);
            this.txt_Alumno.TabIndex = 0;
            this.txt_Alumno.Text = "Alumno";
            // 
            // cmBox_Alumno
            // 
            this.cmBox_Alumno.FormattingEnabled = true;
            this.cmBox_Alumno.Location = new System.Drawing.Point(300, 53);
            this.cmBox_Alumno.Name = "cmBox_Alumno";
            this.cmBox_Alumno.Size = new System.Drawing.Size(168, 23);
            this.cmBox_Alumno.TabIndex = 1;
            this.cmBox_Alumno.SelectedIndexChanged += new System.EventHandler(this.cmBox_Alumno_SelectedIndexChanged);
            this.cmBox_Alumno.SelectionChangeCommitted += new System.EventHandler(this.cmBox_Alumno_SelectionChangeCommitted);
            // 
            // txt_Tarjeta
            // 
            this.txt_Tarjeta.AutoSize = true;
            this.txt_Tarjeta.Location = new System.Drawing.Point(244, 102);
            this.txt_Tarjeta.Name = "txt_Tarjeta";
            this.txt_Tarjeta.Size = new System.Drawing.Size(55, 15);
            this.txt_Tarjeta.TabIndex = 2;
            this.txt_Tarjeta.Text = "ID Tarjeta";
            // 
            // textBox_Tarjeta
            // 
            this.textBox_Tarjeta.Location = new System.Drawing.Point(300, 99);
            this.textBox_Tarjeta.Name = "textBox_Tarjeta";
            this.textBox_Tarjeta.Size = new System.Drawing.Size(168, 23);
            this.textBox_Tarjeta.TabIndex = 3;
            // 
            // asociar_Button
            // 
            this.asociar_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.asociar_Button.Location = new System.Drawing.Point(87, 153);
            this.asociar_Button.Name = "asociar_Button";
            this.asociar_Button.Size = new System.Drawing.Size(233, 32);
            this.asociar_Button.TabIndex = 4;
            this.asociar_Button.Text = "Asociar";
            this.asociar_Button.UseVisualStyleBackColor = true;
            this.asociar_Button.Click += new System.EventHandler(this.asociar_Button_Click);
            // 
            // desasociar_Button
            // 
            this.desasociar_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.desasociar_Button.Location = new System.Drawing.Point(351, 153);
            this.desasociar_Button.Name = "desasociar_Button";
            this.desasociar_Button.Size = new System.Drawing.Size(233, 32);
            this.desasociar_Button.TabIndex = 5;
            this.desasociar_Button.Text = "Desasociar";
            this.desasociar_Button.UseVisualStyleBackColor = true;
            this.desasociar_Button.Click += new System.EventHandler(this.desasociar_Button_Click);
            // 
            // Asociar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 385);
            this.Controls.Add(this.desasociar_Button);
            this.Controls.Add(this.asociar_Button);
            this.Controls.Add(this.textBox_Tarjeta);
            this.Controls.Add(this.txt_Tarjeta);
            this.Controls.Add(this.cmBox_Alumno);
            this.Controls.Add(this.txt_Alumno);
            this.Name = "Asociar";
            this.Text = "Asociar";
            this.Load += new System.EventHandler(this.Asociar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_Alumno;
        private ComboBox cmBox_Alumno;
        private Label txt_Tarjeta;
        private TextBox textBox_Tarjeta;
        private Button asociar_Button;
        private Button desasociar_Button;
    }
}