using System.Data;

namespace SensorSubmarino;

public partial class frmInventarios : Form
{
    // Variables
    int n;
    int columnas = 4;
    int[,] inventario;
    int totalProductos = 0;
    string operacionActual = "";
    int indiceEncontrado = -1;
    DataTable dt = new DataTable();

    public frmInventarios()
    {
        InitializeComponent();
        btnInsertar.Enabled = false;
        btnConsultar.Enabled = false;
        btnModificar.Enabled = false;
        btnEliminar.Enabled = false;
        btnConfirmar.Enabled = false;
        txtValor.Enabled = false;
        txtNumProductos.Focus();
    }

    // Buscar producto por código
    private int Buscar(int codigo)
    {
        for (int i = 0; i < n; i++)
        {
            if (inventario[i, 0] == codigo)
                return i;
        }
        return -1;
    }

    // Mostrar datos
    private void MostrarDatos()
    {
        dt.Clear();
        for (int i = 0; i < n; i++)
        {
            if (inventario[i, 0] != -1)
            {
                DataRow fila = dt.NewRow();
                fila["Código"] = inventario[i, 0];
                fila["Cantidad"] = inventario[i, 1];
                fila["Precio"] = inventario[i, 2];
                fila["Proveedor"] = inventario[i, 3];
                dt.Rows.Add(fila);
            }
        }
        dtgInventario.DataSource = dt;
    }

    // Limpiar estado
    private void Limpiar()
    {
        operacionActual = "";
        indiceEncontrado = -1;
        lblValor.Text = "Valor:";
        txtValor.Clear();
        txtValor.Enabled = false;
        btnConfirmar.Enabled = false;
        btnConfirmar.Text = "Confirmar";
    }

    // Botón crear
    private void btnCrear_Click(object sender, EventArgs e)
    {
        if (txtNumProductos.Text.Trim() == "")
        {
            MessageBox.Show("Ingrese el número de productos.", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNumProductos.Focus();
            return;
        }

        n = int.Parse(txtNumProductos.Text);
        
        if (n <= 0)
        {
            MessageBox.Show("El número de productos debe ser mayor a 0.", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNumProductos.Focus();
            return;
        }

        inventario = new int[n, columnas];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                inventario[i, j] = -1;
            }
        }

        dt = new DataTable();
        dt.Columns.Add("Código", typeof(int));
        dt.Columns.Add("Cantidad", typeof(int));
        dt.Columns.Add("Precio", typeof(int));
        dt.Columns.Add("Proveedor", typeof(int));

        MessageBox.Show("Inventario creado para " + n + " productos.\n\n" +
            "Arreglo bidimensional: int[" + n + ", 4]\n" +
            "Columnas: Código, Cantidad, Precio, Proveedor", 
            "Inventario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnInsertar.Enabled = true;
        btnConsultar.Enabled = true;
        btnModificar.Enabled = true;
        btnEliminar.Enabled = true;
        btnCrear.Enabled = false;
        txtNumProductos.Enabled = false;
        totalProductos = 0;
    }

    // Botón insertar
    private void btnInsertar_Click(object sender, EventArgs e)
    {
        if (totalProductos >= n)
        {
            MessageBox.Show("El inventario está lleno. No se pueden agregar más productos.", 
                "Inventario lleno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        operacionActual = "insertar_codigo";
        lblValor.Text = "Código del producto:";
        txtValor.Enabled = true;
        txtValor.Clear();
        txtValor.Focus();
        btnConfirmar.Enabled = true;
        btnConfirmar.Text = "OK, continuar";
    }

    // Botón consultar
    private void btnConsultar_Click(object sender, EventArgs e)
    {
        if (totalProductos == 0)
        {
            MessageBox.Show("El inventario está vacío.", "Inventario vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        operacionActual = "consultar";
        lblValor.Text = "Código a consultar:";
        txtValor.Enabled = true;
        txtValor.Clear();
        txtValor.Focus();
        btnConfirmar.Enabled = true;
        btnConfirmar.Text = "Buscar";
    }

    // Botón modificar
    private void btnModificar_Click(object sender, EventArgs e)
    {
        if (totalProductos == 0)
        {
            MessageBox.Show("El inventario está vacío.", "Inventario vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        operacionActual = "buscar_modificar";
        lblValor.Text = "Código de producto:";
        txtValor.Enabled = true;
        txtValor.Clear();
        txtValor.Focus();
        btnConfirmar.Enabled = true;
        btnConfirmar.Text = "Modificar";
    }

    // Botón eliminar
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (totalProductos == 0)
        {
            MessageBox.Show("El inventario está vacío.", "Inventario vacío", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        operacionActual = "eliminar";
        lblValor.Text = "Código de producto:";
        txtValor.Enabled = true;
        txtValor.Clear();
        txtValor.Focus();
        btnConfirmar.Enabled = true;
        btnConfirmar.Text = "Eliminar";
    }

    // Botón confirmar
    private void btnConfirmar_Click(object sender, EventArgs e)
    {
        if (txtValor.Text.Trim() == "")
        {
            MessageBox.Show("Ingrese un valor.", "Validación", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtValor.Focus();
            return;
        }

        int valor = int.Parse(txtValor.Text);

        switch (operacionActual)
        {
            case "insertar_codigo":
                if (Buscar(valor) != -1)
                {
                    MessageBox.Show("Ya existe un producto con ese código.", "Código duplicado", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
                inventario[totalProductos, 0] = valor;
                operacionActual = "insertar_cantidad";
                lblValor.Text = "Cantidad en stock:";
                txtValor.Clear();
                txtValor.Focus();
                break;

            case "insertar_cantidad":
                if (valor < 0)
                {
                    MessageBox.Show("La cantidad no puede ser negativa.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
                inventario[totalProductos, 1] = valor;
                operacionActual = "insertar_precio";
                lblValor.Text = "Precio unitario:";
                txtValor.Clear();
                txtValor.Focus();
                break;

            case "insertar_precio":
                if (valor < 0)
                {
                    MessageBox.Show("El precio no puede ser negativo.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
                inventario[totalProductos, 2] = valor;
                operacionActual = "insertar_proveedor";
                lblValor.Text = "Código proveedor:";
                txtValor.Clear();
                txtValor.Focus();
                break;

            case "insertar_proveedor":
                inventario[totalProductos, 3] = valor;
                MessageBox.Show("Producto insertado correctamente.\n\n" +
                    "Código: " + inventario[totalProductos, 0] + "\n" +
                    "Cantidad: " + inventario[totalProductos, 1] + "\n" +
                    "Precio: " + inventario[totalProductos, 2] + "\n" +
                    "Proveedor: " + inventario[totalProductos, 3], 
                    "Producto insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalProductos++;
                MostrarDatos();
                Limpiar();
                break;

            case "consultar":
                int indice = Buscar(valor);
                if (indice != -1)
                {
                    MessageBox.Show("Encontrado en fila " + indice + " del arreglo\n" +
                        "───────────────────\n" +
                        "Código: " + inventario[indice, 0] + "\n" +
                        "Cantidad en stock: " + inventario[indice, 1] + "\n" +
                        "Precio unitario: $" + inventario[indice, 2] + "\n" +
                        "Código proveedor: " + inventario[indice, 3], 
                        "Consulta de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto con código " + valor + " no encontrado.", 
                        "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Limpiar();
                break;

            case "buscar_modificar":
                indiceEncontrado = Buscar(valor);
                if (indiceEncontrado != -1)
                {
                    operacionActual = "modificar_cantidad";
                    lblValor.Text = "Nueva cantidad:";
                    btnConfirmar.Text = "Confirmar";
                    txtValor.Clear();
                    txtValor.Focus();
                }
                else
                {
                    MessageBox.Show("Producto con código " + valor + " no encontrado.", 
                        "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                }
                break;

            case "modificar_cantidad":
                if (valor < 0)
                {
                    MessageBox.Show("La cantidad no puede ser negativa.", "Validación", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
                int cantidadAnterior = inventario[indiceEncontrado, 1];
                inventario[indiceEncontrado, 1] = valor;
                MessageBox.Show("Stock modificado correctamente.\n\n" +
                    "Cantidad anterior: " + cantidadAnterior + "\n" +
                    "Cantidad nueva: " + valor, 
                    "Stock modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
                Limpiar();
                break;

            case "eliminar":
                int indiceEliminar = Buscar(valor);
                if (indiceEliminar != -1)
                {
                    DialogResult confirmar = MessageBox.Show(
                        "Encontrado en fila " + indiceEliminar + " del arreglo\n" +
                        "───────────────────\n" +
                        "¿Está seguro de eliminar el producto?\n\n" +
                        "Código: " + inventario[indiceEliminar, 0] + "\n" +
                        "Cantidad: " + inventario[indiceEliminar, 1] + "\n" +
                        "Precio: $" + inventario[indiceEliminar, 2] + "\n" +
                        "Proveedor: " + inventario[indiceEliminar, 3],
                        "Confirmar eliminación", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmar == DialogResult.Yes)
                    {
                        inventario[indiceEliminar, 0] = -1;
                        inventario[indiceEliminar, 1] = -1;
                        inventario[indiceEliminar, 2] = -1;
                        inventario[indiceEliminar, 3] = -1;
                        totalProductos--;

                        MessageBox.Show("Producto eliminado correctamente.\n" +
                            "La fila " + indiceEliminar + " ahora está disponible.", 
                            "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Producto con código " + valor + " no encontrado.", 
                        "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Limpiar();
                break;
        }
    }

    // Botón limpiar
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        if (inventario != null)
        {
            DialogResult confirmar = MessageBox.Show(
                "¿Desea reiniciar el inventario?\nSe perderán todos los datos.",
                "Confirmar reinicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                dt.Clear();
                dtgInventario.DataSource = null;
                txtNumProductos.Clear();
                txtNumProductos.Enabled = true;
                btnCrear.Enabled = true;
                btnInsertar.Enabled = false;
                btnConsultar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                inventario = null;
                totalProductos = 0;
                Limpiar();
                txtNumProductos.Focus();
            }
        }
    }

    // Botón regresar
    private void btnRegresar_Click(object sender, EventArgs e)
    {
        frmOperaciones fo = new frmOperaciones();
        fo.Show();
        this.Close();
    }

    // Validación numérica
    private void txtNumProductos_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }

    private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }
}
