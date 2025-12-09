namespace SensorSubmarino;

public partial class frmAcceso : Form
{
    public frmAcceso()
    {
        InitializeComponent();
    }
    
    // Arreglos para cifrado César (desplazamiento de 3 posiciones)
    char[] abc = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    char[] cifradoCesar = {'d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','a','b','c'};

    string cifrado = "";
    
    // Método para cifrar texto usando cifrado César
    public string cifrar(string texto)
    {
        cifrado = "";
        for (int i = 0; i < texto.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (texto[i] == abc[j])
                {
                    cifrado += cifradoCesar[j];
                    break;
                }
            }
        }
        return cifrado;
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
        // Validar que los campos no estén vacíos
        if (txtUsuario.Text.Trim() != "")
        {
            if (txtContra.Text.Trim() != "")
            {
                // Cualquier usuario y contraseña son válidos
                // Se aplica cifrado César a la contraseña como demostración
                string contrasenaCifrada = cifrar(txtContra.Text);
                
                // Acceso permitido
                frmOperaciones fo = new frmOperaciones();
                fo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese la contraseña");
                txtContra.Focus();
            }
        }
        else
        {
            MessageBox.Show("Ingrese el usuario");
            txtUsuario.Focus();
        }
    }
}