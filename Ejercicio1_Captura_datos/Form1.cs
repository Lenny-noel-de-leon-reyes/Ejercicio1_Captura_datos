namespace Ejercicio1_Captura_datos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            lblDatos_Apellido.Visible = false;
            lblDatos_Carrera.Visible = false;
            lblDatos_Edad.Visible = false;
            lblDatos_Matricula.Visible = false;
            lblDatos_Nombre.Visible = false;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblDatos_Apellido.Visible = true;
            lblDatos_Carrera.Visible = true;
            lblDatos_Edad.Visible = true;
            lblDatos_Matricula.Visible = true;
            lblDatos_Nombre.Visible = true;
            String Nombre, Apellido, Carrera;
            int Edad, Matricula;

            Nombre = txt_nombre.Text;
            Apellido = txt_apellido.Text;
            Carrera = txt_carrera.Text;

            Matricula = int.Parse(txt_matricula.Text);
            Edad = int.Parse(txt_edad.Text);

            lblDatos_Nombre.Text = Nombre;
            lblDatos_Apellido.Text = Apellido;
            lblDatos_Carrera.Text = Carrera;
            lblDatos_Edad.Text = Edad.ToString();
            lblDatos_Matricula.Text = Matricula.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_carrera.Clear();
            txt_matricula.Clear();
            txt_edad.Clear();
            lblDatos_Nombre.Text = string.Empty;
            lblDatos_Apellido.Text = string.Empty;
            lblDatos_Edad.Text = string.Empty;
            lblDatos_Carrera.Text = string.Empty;
            lblDatos_Matricula.Text = string.Empty;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
