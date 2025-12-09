
using System.Data;

namespace SensorSubmarino;

public partial class frmOpeUnidimensional : Form
{
    public frmOpeUnidimensional()
    {
        InitializeComponent();
        btnBuscar.Visible = false;
        btnConsultar.Enabled = false;
        btnEliminar.Enabled = false;
        btnInsertar.Enabled = false;
        btnModificar.Enabled = false;
        btnAceptar.Enabled = false;
        txtElemento.Enabled = false;
        txtNvoEle.Enabled = false;
        txtNoEle.Focus();
    }

    private int[] A;
    private int i = -1, elemento, n;
    private string opcion = "";
    DataTable dt = new DataTable();

    // Buscar elemento, retorna índice o -1
    public int buscar(int elem)
    {
        for (int k = 0; k <= i; k++)
        {
            if (A[k] == elem)
                return k;
        }
        return -1;
    }

    // Mostrar arreglo
    public void mostrarData()
    {
        dt.Clear();
        for (int k = 0; k <= i; k++)
        {
            DataRow fila = dt.NewRow();
            fila["Valor"] = A[k];
            dt.Rows.Add(fila);
        }
        dtgArreglo.DataSource = null;
        dtgArreglo.DataSource = dt;
    }

    // Limpiar
    private void limpiar()
    {
        opcion = "";
        txtElemento.Clear();
        txtNvoEle.Clear();
        txtElemento.Enabled = false;
        txtNvoEle.Enabled = false;
        btnBuscar.Visible = false;
        btnAceptar.Enabled = false;
    }

    // Botón crear
    private void button5_Click(object sender, EventArgs e)
    {
        if (txtNoEle.Text.Trim() != "")
        {
            n = Convert.ToInt32(txtNoEle.Text);
            
            if (n <= 0)
            {
                MessageBox.Show("El tamaño debe ser mayor a 0", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoEle.Focus();
                return;
            }
            
            A = new int[n];
            i = -1;
            
            dt = new DataTable();
            dt.Columns.Add("Valor", typeof(int));
            
            MessageBox.Show("Arreglo creado de tamaño " + n, "Arreglo creado", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            btnInsertar.Enabled = true;
            btnCrear.Enabled = false;
            txtNoEle.Enabled = false;
            
            dtgArreglo.DataSource = dt;
        }
        else
        {
            MessageBox.Show("Ingrese el número de elementos", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNoEle.Focus();
        }
    }

    // Botón insertar
    private void btnInsertar_Click(object sender, EventArgs e)
    {
        if (i >= n - 1)
        {
            MessageBox.Show("El arreglo está lleno.", "Arreglo lleno", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        opcion = "insertar";
        txtElemento.Enabled = true;
        btnAceptar.Enabled = true;
        txtElemento.Clear();
        txtElemento.Focus();
    }

    // Botón consultar
    private void btnConsultar_Click(object sender, EventArgs e)
    {
        if (i < 0)
        {
            MessageBox.Show("El arreglo está vacío.", "Arreglo vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        opcion = "consultar";
        txtElemento.Enabled = true;
        btnAceptar.Enabled = true;
        txtElemento.Clear();
        txtElemento.Focus();
    }

    // Botón modificar
    private void btnModificar_Click(object sender, EventArgs e)
    {
        if (i < 0)
        {
            MessageBox.Show("El arreglo está vacío.", "Arreglo vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        opcion = "modificar";
        txtElemento.Enabled = true;
        btnBuscar.Visible = true;
        txtElemento.Clear();
        txtElemento.Focus();
    }

    // Botón eliminar
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (i < 0)
        {
            MessageBox.Show("El arreglo está vacío.", "Arreglo vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        opcion = "eliminar";
        txtElemento.Enabled = true;
        btnAceptar.Enabled = true;
        txtElemento.Clear();
        txtElemento.Focus();
    }

    // Botón buscar
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtElemento.Text.Trim() == "")
        {
            MessageBox.Show("Ingrese el elemento a buscar", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtElemento.Focus();
            return;
        }

        elemento = Convert.ToInt32(txtElemento.Text);
        int indice = buscar(elemento);

        if (indice != -1)
        {
            MessageBox.Show("Elemento " + elemento + " encontrado en la posición " + indice, 
                "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (opcion == "modificar")
            {
                txtNvoEle.Enabled = true;
                btnAceptar.Enabled = true;
                txtNvoEle.Focus();
            }
            txtElemento.Enabled = false;
            btnBuscar.Visible = false;
        }
        else
        {
            MessageBox.Show("Elemento " + elemento + " no encontrado", 
                "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtElemento.Clear();
            txtElemento.Focus();
        }
    }

    // Botón aceptar
    public void btnAceptar_Click(object sender, EventArgs e)
    {
        switch (opcion)
        {
            case "insertar":
                if (txtElemento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el elemento", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtElemento.Focus();
                    return;
                }

                if (i < n - 1)
                {
                    i++;
                    A[i] = Convert.ToInt32(txtElemento.Text);
                    MessageBox.Show("Elemento " + A[i] + " insertado en la posición " + i, 
                        "Elemento insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    btnConsultar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    
                    mostrarData();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No hay espacio en el arreglo", "Arreglo lleno", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                break;

            case "consultar":
                if (txtElemento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el elemento a consultar", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtElemento.Focus();
                    return;
                }

                elemento = Convert.ToInt32(txtElemento.Text);
                int indiceConsulta = buscar(elemento);

                if (indiceConsulta != -1)
                {
                    MessageBox.Show("Elemento encontrado\n\n" +
                        "Valor: " + A[indiceConsulta] + "\n" +
                        "Posición: " + indiceConsulta, 
                        "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Elemento " + elemento + " no existe en el arreglo", 
                        "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiar();
                break;

            case "eliminar":
                if (txtElemento.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el elemento a eliminar", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtElemento.Focus();
                    return;
                }

                elemento = Convert.ToInt32(txtElemento.Text);
                int indiceEliminar = buscar(elemento);

                if (indiceEliminar != -1)
                {
                    A[indiceEliminar] = 0; // Marcar como eliminado
                    
                    MessageBox.Show("Elemento " + elemento + " eliminado", 
                        "Elemento eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mostrarData();
                }
                else
                {
                    MessageBox.Show("Elemento " + elemento + " no encontrado", 
                        "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                limpiar();
                break;

            case "modificar":
                if (txtNvoEle.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el nuevo valor", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNvoEle.Focus();
                    return;
                }

                int indiceModificar = buscar(elemento);
                if (indiceModificar != -1)
                {
                    int valorAnterior = A[indiceModificar];
                    A[indiceModificar] = Convert.ToInt32(txtNvoEle.Text);
                    
                    MessageBox.Show("Elemento modificado\n\n" +
                        "Valor anterior: " + valorAnterior + "\n" +
                        "Valor nuevo: " + A[indiceModificar], 
                        "Elemento modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mostrarData();
                }
                limpiar();
                break;
        }
    }

    // Botón limpiar
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        DialogResult confirmar = MessageBox.Show(
            "¿Desea reiniciar el arreglo?\nSe perderán todos los datos.",
            "Confirmar reinicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmar == DialogResult.Yes)
        {
            dt.Clear();
            dtgArreglo.DataSource = null;
            txtNoEle.Clear();
            txtNoEle.Enabled = true;
            btnCrear.Enabled = true;
            btnInsertar.Enabled = false;
            btnConsultar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            A = null;
            i = -1;
            limpiar();
            txtNoEle.Focus();
        }
    }

    // Botón regresar
    private void btnRegresar_Click(object sender, EventArgs e)
    {
        frmOperaciones fo = new frmOperaciones();
        fo.Show();
        this.Close();
    }

    // Botón salir
    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // Validaciones
    private void txtNoEle_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private void txtNvoEle_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }
}