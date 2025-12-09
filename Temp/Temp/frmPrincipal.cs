namespace Temp;

public partial class frmPrincipal : Form
{
    public frmPrincipal()
    {
        InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnAcceder_Click(object sender, EventArgs e)
    {
        Form1 form1= new Form1();
        form1.Visible = true;
        this.Visible = false;//oculta formulario actual
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        DialogResult = MessageBox.Show("¿Está seguro que desea salir ?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //si se elige Sí, cerrrar la aplicación
        if (DialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}