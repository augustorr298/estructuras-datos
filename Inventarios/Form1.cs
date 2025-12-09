using System.Data;

namespace Inventarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Deshabilitar botones hasta que se inicialice el arreglo
            insertBtn.Enabled = false;
            consulBtn.Enabled = false;
            modBtn.Enabled = false;
            eliminarBtn.Enabled = false;
            confirmarBtn.Enabled = false;
            valorTxt.Enabled = false;
        }

        // Arreglo bidimensional para almacenar productos
        // Columnas: 0 = ID Producto, 1 = Cantidad, 2 = Precio
        int n; // tamaño del arreglo (número de productos)
        int columnas = 3; // columnas del arreglo
        int[,] productos; // arreglo bidimensional de productos
        int productoActual = 0; // índice del producto actual a insertar
        string operacionActual = ""; // operación que se está realizando
        int indiceConsulta = -1; // índice del producto consultado/modificado
        DataTable dt = new DataTable();

        // Inicializar el arreglo
        private void iniBtn_Click(object sender, EventArgs e)
        {
            if (numeroProd.Text.Trim() != "")
            {
                n = Convert.ToInt32(numeroProd.Text);
                productos = new int[n, columnas];
                
                // Inicializar el arreglo con -1 para indicar vacío
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        productos[i, j] = -1;
                    }
                }
                
                // Configurar DataTable
                dt = new DataTable();
                dt.Columns.Add("Producto", typeof(int));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Precio", typeof(int));
                
                MessageBox.Show("Arreglo de inventario creado para " + n + " productos.");
                
                insertBtn.Enabled = true;
                consulBtn.Enabled = true;
                modBtn.Enabled = true;
                eliminarBtn.Enabled = true;
                iniBtn.Enabled = false;
                numeroProd.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese el número de productos.");
                numeroProd.Focus();
            }
        }

        // Botón Insertar
        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (productoActual >= n)
            {
                MessageBox.Show("El inventario está lleno. No se pueden agregar más productos.");
                return;
            }
            
            operacionActual = "insertar_producto";
            label88.Text = "ID Producto:";
            valorTxt.Enabled = true;
            valorTxt.Clear();
            valorTxt.Focus();
            confirmarBtn.Enabled = true;
        }

        // Botón Consultar
        private void consulBtn_Click(object sender, EventArgs e)
        {
            operacionActual = "consultar";
            label88.Text = "ID a buscar:";
            valorTxt.Enabled = true;
            valorTxt.Clear();
            valorTxt.Focus();
            confirmarBtn.Enabled = true;
        }

        // Botón Modificar
        private void modBtn_Click(object sender, EventArgs e)
        {
            operacionActual = "buscar_modificar";
            label88.Text = "ID a modificar:";
            valorTxt.Enabled = true;
            valorTxt.Clear();
            valorTxt.Focus();
            confirmarBtn.Enabled = true;
        }

        // Botón Eliminar
        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            operacionActual = "eliminar";
            label88.Text = "ID a eliminar:";
            valorTxt.Enabled = true;
            valorTxt.Clear();
            valorTxt.Focus();
            confirmarBtn.Enabled = true;
        }

        // Confirmar acción
        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (valorTxt.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un valor.");
                valorTxt.Focus();
                return;
            }

            int valor = Convert.ToInt32(valorTxt.Text);

            switch (operacionActual)
            {
                case "insertar_producto":
                    // Insertar ID del producto
                    productos[productoActual, 0] = valor;
                    operacionActual = "insertar_cantidad";
                    label88.Text = "Cantidad:";
                    valorTxt.Clear();
                    valorTxt.Focus();
                    break;

                case "insertar_cantidad":
                    // Insertar cantidad
                    productos[productoActual, 1] = valor;
                    operacionActual = "insertar_precio";
                    label88.Text = "Precio:";
                    valorTxt.Clear();
                    valorTxt.Focus();
                    break;

                case "insertar_precio":
                    // Insertar precio y finalizar
                    productos[productoActual, 2] = valor;
                    MessageBox.Show("Producto insertado correctamente.");
                    productoActual++;
                    valorTxt.Enabled = false;
                    confirmarBtn.Enabled = false;
                    label88.Text = "Valor";
                    valorTxt.Clear();
                    MostrarDatos();
                    break;

                case "consultar":
                    // Buscar producto por ID
                    int indice = BuscarProducto(valor);
                    if (indice != -1)
                    {
                        MessageBox.Show("Producto encontrado:\n" +
                            "ID: " + productos[indice, 0] + "\n" +
                            "Cantidad: " + productos[indice, 1] + "\n" +
                            "Precio: " + productos[indice, 2]);
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                    valorTxt.Enabled = false;
                    confirmarBtn.Enabled = false;
                    label88.Text = "Valor";
                    valorTxt.Clear();
                    break;

                case "buscar_modificar":
                    // Buscar producto para modificar
                    indiceConsulta = BuscarProducto(valor);
                    if (indiceConsulta != -1)
                    {
                        MessageBox.Show("Producto encontrado. Ingrese la nueva cantidad.");
                        operacionActual = "modificar_cantidad";
                        label88.Text = "Nueva cantidad:";
                        valorTxt.Clear();
                        valorTxt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                        valorTxt.Enabled = false;
                        confirmarBtn.Enabled = false;
                        label88.Text = "Valor";
                        valorTxt.Clear();
                    }
                    break;

                case "modificar_cantidad":
                    // Modificar cantidad
                    productos[indiceConsulta, 1] = valor;
                    operacionActual = "modificar_precio";
                    label88.Text = "Nuevo precio:";
                    valorTxt.Clear();
                    valorTxt.Focus();
                    break;

                case "modificar_precio":
                    // Modificar precio
                    productos[indiceConsulta, 2] = valor;
                    MessageBox.Show("Producto modificado correctamente.");
                    valorTxt.Enabled = false;
                    confirmarBtn.Enabled = false;
                    label88.Text = "Valor";
                    valorTxt.Clear();
                    MostrarDatos();
                    break;

                case "eliminar":
                    // Buscar y eliminar producto
                    int indiceEliminar = BuscarProducto(valor);
                    if (indiceEliminar != -1)
                    {
                        // Marcar como eliminado (-1)
                        productos[indiceEliminar, 0] = -1;
                        productos[indiceEliminar, 1] = -1;
                        productos[indiceEliminar, 2] = -1;
                        MessageBox.Show("Producto eliminado correctamente.");
                        MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                    valorTxt.Enabled = false;
                    confirmarBtn.Enabled = false;
                    label88.Text = "Valor";
                    valorTxt.Clear();
                    break;
            }
        }

        // Buscar producto por ID, retorna el índice o -1 si no existe
        private int BuscarProducto(int id)
        {
            for (int i = 0; i < n; i++)
            {
                if (productos[i, 0] == id)
                {
                    return i;
                }
            }
            return -1;
        }

        // Mostrar datos en el DataGridView
        private void MostrarDatos()
        {
            dt.Clear();
            for (int i = 0; i < n; i++)
            {
                // Solo mostrar productos válidos (no eliminados)
                if (productos[i, 0] != -1)
                {
                    DataRow fila = dt.NewRow();
                    fila["Producto"] = productos[i, 0];
                    fila["Cantidad"] = productos[i, 1];
                    fila["Precio"] = productos[i, 2];
                    dt.Rows.Add(fila);
                }
            }
            dtgArreglo.DataSource = dt;
        }

        // Validar solo números
        private void numeroProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void valorTxt_TextChanged(object sender, EventArgs e)
        {
            // No se necesita implementación
        }

        private void valorTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
