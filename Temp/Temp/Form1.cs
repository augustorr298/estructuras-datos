using System.ComponentModel.Design;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
namespace Temp;

public partial class Form1 : Form
{
    int[] temp;
    int[] asc;
    int[] desc;
    int i,j,min,max,sum =0,n;
    double prom, var, desEs;
    public Form1()
    {
        


        InitializeComponent();
         txt3Max.Enabled = false;
         txt3Min.Enabled = false; 
         txtDes.Enabled = false;
         txtMin.Enabled = false;
         txtMax.Enabled = false;
         txtProm.Enabled = false;  
         txtSum.Enabled = false;
         txtVar.Enabled = false;      
         btnGenerar.Visible = false;
      btnCalcular.Visible = false;
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    public void ordenamiento()
    {
     
        for (i = 0; i < n; i++)
        {
            desc[i] = temp[i];
            asc[i] = temp[i];
        }

        //asc
        for (i = 0; i < n - 1; i++)
        {
            for (j = 0; j < n - i - 1; j++)
            {
                if (desc[j] < desc[j + 1])
                {
                    int tempVal = desc[j];
                    desc[j] = desc[j + 1];
                    desc[j + 1] = tempVal;
                }
            }
        }


        for (i = 0; i < n - 1; i++)
        {
            for (j = 0; j < n - i - 1; j++)
            {
                if (asc[j] > asc[j + 1])
                {
                    int tempVal = asc[j];
                    asc[j] = asc[j + 1];
                    asc[j + 1] = tempVal;
                }
            }
        }


        DataTable tablaDesc = new DataTable();
        tablaDesc.Columns.Add("Desc", typeof(int));
        for (i = 0; i < n; i++)
        {
            DataRow fila = tablaDesc.NewRow();
            fila["Desc"] = desc[i];
            tablaDesc.Rows.Add(fila);
        }
        dtgDes.DataSource = tablaDesc;

        DataTable tablaAsc = new DataTable();
        tablaAsc.Columns.Add("Asc", typeof(int));
        for (i = 0; i < n; i++)
        {
            DataRow filaA = tablaAsc.NewRow();
            filaA["Asc"] = asc[i];
            tablaAsc.Rows.Add(filaA);
        }
        dtgAsc.DataSource = tablaAsc;
    }
    public int Maximo()
    {
        max = temp[0];
        for (i = 1; i < n; i++)
        {
            if (temp[i] > max)
                max = temp[i];
        }
        return max;
    }

    public int Minimo()
    {
        min = temp[0];
        for (i = 1; i < n; i++)
        {
            if (temp[i] < min)
                min = temp[i];
        }
        return min;
    }
    public string TresMax()
    {
        ordenamiento();
        string TresMaxi = "";
        for (int i = 0; i < Math.Min(3, n); i++)
        {
            TresMaxi += desc[i] + " ";
        }
        return TresMaxi.Trim();
    }

    public string TresMin()
    {
        ordenamiento();
        string TresMini = "";
        for (int i = 0; i < Math.Min(3, n); i++)
        {
            TresMini += asc[i] + " ";
        }
        return TresMini.Trim();
    }

    
    public int Suma (){
     
        sum=0;
        for(i=0;i<temp.Length;i++)
        {
            sum+=temp[i];
        }
        return sum;
    }
    
    public double promedio1()
    {
        prom = (double)Suma() / n;
        return prom;
    }

    public double Varianza()
    {
        double suma = 0;
        double promedio = promedio1();
        for (i = 0; i < n; i++)
        {
            suma += Math.Pow(temp[i] - promedio, 2);
        }
        var = suma / n;
        return var;
    }

    public double DesviacionEstandar()
    {
        desEs = Math.Sqrt(Varianza());
        return desEs;
    }
    
    private void DibujarGrafica()
    {
        Bitmap bmp = new Bitmap(picGrafica.Width, picGrafica.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.White);

            int ancho = picGrafica.Width;
            int alto = picGrafica.Height;
            int max = temp.Max();
            int min = temp.Min();
            double rango = max - min;
            if (rango == 0) rango = 1;

            Point[] puntos = new Point[temp.Length];
            for (int k = 0; k < temp.Length; k++)
            {
                int x = (int)((k / (double)(temp.Length - 1)) * (ancho - 20)) + 10;
                int y = (int)((1 - (temp[k] - min) / rango) * (alto - 20)) + 10;
                puntos[k] = new Point(x, y);
            }

            g.DrawLines(Pens.Blue, puntos);

            foreach (var p in puntos)
            {
                g.FillEllipse(Brushes.Red, p.X - 3, p.Y - 3, 6, 6);
            }
        }
        picGrafica.Image = bmp;
    }

    
    
    private void button1_Click(object sender, EventArgs e)
    {
        if (txtNoTem.Text.Trim() != "")
        {
            n = Convert.ToInt32(txtNoTem.Text);
            temp = new int [n];
            desc = new int[n];
            asc = new int[n];
            MessageBox.Show("Arreglo creado");
            btnCrear.Enabled = false;
            btnGenerar.Visible = true;
            btnGenerar.Enabled = true;
        }
        else
        {
            MessageBox.Show("Ingresa el número de temperaturas");
            txtNoTem.Focus(); //manda el cursos al txtTemp
        }
    }



    private void btnCalcular_Click_1(object sender, EventArgs e)
    {
    txtSum.Enabled = true;
    txtProm.Enabled = true;
    txtVar.Enabled = true;
    txtDesv.Enabled = true;
    txtMax.Enabled = true;
    txtMin.Enabled = true;
    txt3Max.Enabled = true;
    txt3Min.Enabled = true;

    txtSum.Text = "" + Suma();
    txtProm.Text = "" + promedio1();
    txtVar.Text = "" + Varianza();
    txtDesv.Text = "" + DesviacionEstandar();
    txtMax.Text = "" + Maximo();
    txtMin.Text = "" + Minimo();
    txt3Max.Text = TresMax();
    txt3Min.Text = TresMin();

    ordenamiento();
    }

    private void btnGenerar_Click_1(object sender, EventArgs e)
    {
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            temp[i] = r.Next(-2, 33);
            cmbTem.Items.Add(temp[i]);
            lstTem.Items.Add(temp[i]);
            btnGenerar.Enabled = false;
            btnCalcular.Visible = true;
        }
    }

    private void btnLimpiar_Click_1(object sender, EventArgs e)
    {
        {
            txt3Max.Clear();
            txt3Min.Clear();
            txtDesv.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtProm.Clear();
            txtSum.Clear();
            txtNoTem.Clear();
            txtVar.Clear();
            lstTem.Items.Clear();
            cmbTem.Items.Clear();
            // chrTem.Series.Clear();
            dtgAsc.Rows.Clear();
            dtgDes.Rows.Clear();
            dtgTem.Rows.Clear();
            dtgTem.DataSource = null;
            dtgDes.DataSource = null;
            dtgDes.DataSource = null;
        
            btnGenerar.Visible= false;
            btnCalcular.Visible = false;
            txtNoTem.Enabled = true;
            //Application.Restart();

        }
    }

    private void txtNoTem_KeyPress(object sender, KeyPressEventArgs e)
    {
        // Permitir solo números enteros
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Bloquear la tecla
        }
    }

    private void btnGraficar_Click(object sender, EventArgs e)
    {
       DibujarGrafica();
    }
}