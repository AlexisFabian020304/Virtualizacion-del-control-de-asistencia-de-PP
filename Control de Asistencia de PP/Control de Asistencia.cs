namespace Control_de_Asistencia_de_PP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm) 
        { 
            if(activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();
        }

        private void botton_Alumno_Click(object sender, EventArgs e)
        {
            openChildForm(new Alumno());
        }

        private void botton_Asociar_Click(object sender, EventArgs e)
        {
            openChildForm(new Asociar());
        }

        private void botton_Datos_Click(object sender, EventArgs e)
        {
            openChildForm(new Datos());
        }
    }
}