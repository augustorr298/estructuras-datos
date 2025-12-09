namespace SensorSubmarino;

public partial class frmOperaciones : Form
{
    public frmOperaciones()
    {
        InitializeComponent();
    }

    // Menú Operaciones (no hace nada, solo despliega submenú)
    private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Este menú solo despliega las opciones de arreglo unidimensional y bidimensional
    }
    
    // Opción: Arreglo Unidimensional
    private void arregloUnidimensionalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmOpeUnidimensional frmUni = new frmOpeUnidimensional();
        frmUni.Visible = true;
        this.Visible = false;
    }
    
    // Opción: Arreglo Bidimensional (Inventarios)
    private void arregloBidimensionalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmInventarios frmInv = new frmInventarios();
        frmInv.Visible = true;
        this.Visible = false;
    }
    
    // Opción: Sensor de Temperaturas
    private void sensorDeTemperaturasToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form1 frmSensor = new Form1();
        frmSensor.Visible = true;
        this.Visible = false;
    }
    
    // Botón Salir
    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}