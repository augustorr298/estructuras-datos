using System.Data;
using System.Drawing;
using System.Linq;

namespace SensorSubmarino;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //declarar arreglo bidimensional
    int [,] temp = new int [24, 7];
    int maxSem,minSem,promSem=0;
    private int i, j;
    Random r = new Random();
    
    private void btnGenerar_Click(object sender, EventArgs e)
    {
        Random r=new Random();
        DataTable dt= new DataTable();
        dt.Columns.Add("Lunes");
        dt.Columns.Add("Martes");
        dt.Columns.Add("Miércoles");
        dt.Columns.Add("Jueves");
        dt.Columns.Add("Viernes");
        dt.Columns.Add("Sabado");
        dt.Columns.Add("Domingo");

        for (int i = 0; i < 24; i++)
        {
            //crear una fila para cada hora
            DataRow fila = dt.NewRow();
            for (j = 0; j < 7; j++)
            {
                temp[i,j] = r.Next(-2, 40);
                cmbTemp.Items.Add(temp[i,j]);
                //asignar a la fila la temperatura que se acaba de generar
                fila[j] = temp[i,j];
                
            }
            dt.Rows.Add(fila);  //agregar la fila al dt
        }
        //mandar contendido del datatable dt al datagridview
        dtgTemp.DataSource = dt;
    }

    private void label4_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        int maxDia, minDia;
        double promDia = 0;
        string dia = "";
        string maxTextbox = "", minTextbox = "", promTextbox = "";
        
        maxSem=temp[0, 0];
        minSem=temp[0, 0];
        for (int columnas = 0; columnas < 7; columnas++)
        {
            promDia = 0;
            maxDia = temp[0, columnas];
            minDia = temp[0, columnas];
            promDia += temp[0, columnas];
            promSem += temp[0, columnas];
            for (int filas = 0; filas < 24; filas++)
            {
                if (filas != 0)
                {
                    if (temp[filas, columnas] > maxDia)
                    {
                        maxDia = temp[filas, columnas];

                    }

                    if (temp[filas, columnas] < minDia)
                    {
                        minDia = temp[filas, columnas];
                    }

                    promDia += temp[filas, columnas];
                    promSem += temp[filas, columnas];
                }

                if (temp[filas, columnas] < minSem)
                {
                    minSem = temp[filas, columnas];
                }else if (temp[filas, columnas] > maxSem)
                {
                    maxSem = temp[filas, columnas];
                }


            }
            
            switch (columnas)
            {
                case 0:
                    dia = "Lun";
                    break;
                case 1:
                    dia = "Mar";
                    break;
                case 2:
                    dia = "Mie";
                    break;
                case 3:
                    dia = "Jue";
                    break;
                case 4:
                    dia = "Vie";
                    break;
                case 5:
                    dia = "Sab";
                    break;
                case 6:
                    dia = "Dom";
                    break;



            }
            maxTextbox = "tmax" + dia;
            minTextbox = "tmin" + dia;
            promTextbox = "tpr" + dia;
            
            promDia = promDia / 24;
            
            TextBox textBox = panel1.Controls.Find(maxTextbox, true).FirstOrDefault() as TextBox;
            if (textBox != null)
            {
                // Muestra el resultado en el TextBox 
                textBox.Text = maxDia.ToString();
            }

            TextBox textBox2 = panel1.Controls.Find(minTextbox, true).FirstOrDefault() as TextBox;
            if (textBox2 != null)
            {
                textBox2.Text = minDia.ToString();
            }

            TextBox textBox3 = panel1.Controls.Find(promTextbox, true).FirstOrDefault() as TextBox;
            if (textBox3 != null)
            {
                textBox3.Text = promDia.ToString();
            }

            maxDia = 0;
            minDia = 0;
        }
        
        
        promSem = promSem / 168;
        tprSem.Text=promSem.ToString();
        tmaxSem.Text=maxSem.ToString();
        tminSem.Text=minSem.ToString();
        
        GenerarGrafico();
    }

    private void GenerarGrafico()
    {
        // 1. PREPARACIÓN DE DATOS
        // Arreglo para almacenar los 7 promedios (uno por día de la semana)
        double[] promediosDiarios = new double[7];
        string[] diasSemana = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
        
        // Calcular el promedio de temperatura para cada día
        for (int dia = 0; dia < 7; dia++)
        {
            double suma = 0;
            // Sumar las 24 temperaturas del día
            for (int hora = 0; hora < 24; hora++)
            {
                suma += temp[hora, dia];
            }
            // Dividir entre 24 para obtener el promedio diario
            promediosDiarios[dia] = suma / 24;
        }
        
        // 2. CREACIÓN DEL LIENZO
        // Crear un bitmap del mismo tamaño que el PictureBox (274x336 píxeles)
        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        Graphics g = Graphics.FromImage(bmp);
        g.Clear(Color.White); // Fondo blanco
        
        // 3. DEFINICIÓN DE MÁRGENES
        // Espacios para dejar lugar a las etiquetas y el título
        int margenIzq = 50;   // Espacio para etiquetas del eje Y (valores de temperatura)
        int margenDer = 20;   // Espacio derecho
        int margenSup = 30;   // Espacio para el título
        int margenInf = 50;   // Espacio para etiquetas del eje X (días de la semana)
        int anchoGrafico = bmp.Width - margenIzq - margenDer;   // Área útil para barras
        int altoGrafico = bmp.Height - margenSup - margenInf;   // Altura útil para barras
        
        // 4. CÁLCULO DE ESCALA
        // Encontrar valores máximo y mínimo para escalar las barras proporcionalmente
        double maxTemp = promediosDiarios.Max();
        double minTemp = promediosDiarios.Min();
        double rangoTemp = maxTemp - minTemp;
        if (rangoTemp == 0) rangoTemp = 1; // Evitar división por cero si todos los valores son iguales
        
        // 5. CONFIGURACIÓN BÁSICA
        int anchoBarra = anchoGrafico / 7;  // Dividir el ancho entre 7 días
        Font font = new Font("Arial", 8);
        Pen penEjes = new Pen(Color.Black, 2);  // Lápiz negro de grosor 2 para los ejes
        
        // 6. DIBUJO DE EJES
        // Eje X (horizontal, en la parte inferior)
        g.DrawLine(penEjes, margenIzq, margenSup + altoGrafico, margenIzq + anchoGrafico, margenSup + altoGrafico);
        // Eje Y (vertical, en el lado izquierdo)
        g.DrawLine(penEjes, margenIzq, margenSup, margenIzq, margenSup + altoGrafico);
        
        // 7. TÍTULO DEL GRÁFICO
        g.DrawString("Temperatura Promedio por Día (°C)", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, margenIzq, 5);
        
        // 8. DIBUJO DE BARRAS
        // Colores del arcoíris para cada día de la semana
        Color[] colores = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
        
        for (int i = 0; i < 7; i++)
        {
            // Calcular altura de la barra proporcionalmente al promedio
            // Fórmula: (valorActual - valorMínimo) / rango × altoDisponible
            int alturaBarra = (int)((promediosDiarios[i] - minTemp) / rangoTemp * altoGrafico);
            
            // Calcular posición y dimensiones de la barra
            int x = margenIzq + (i * anchoBarra) + 5;  // Posición horizontal
            int y = margenSup + altoGrafico - alturaBarra;  // Posición vertical (de abajo hacia arriba)
            int ancho = anchoBarra - 10;  // Ancho con espacio entre barras
            
            // Dibujar la barra con color
            SolidBrush brush = new SolidBrush(colores[i]);
            g.FillRectangle(brush, x, y, ancho, alturaBarra);  // Relleno de color
            g.DrawRectangle(Pens.Black, x, y, ancho, alturaBarra);  // Borde negro
            
            // Mostrar valor numérico arriba de la barra
            string valorTexto = promediosDiarios[i].ToString("F1");  // Formato: 1 decimal
            SizeF tamTexto = g.MeasureString(valorTexto, font);
            g.DrawString(valorTexto, font, Brushes.Black, x + (ancho - tamTexto.Width) / 2, y - 15);  // Centrado
            
            // Mostrar nombre del día debajo del eje X
            SizeF tamDia = g.MeasureString(diasSemana[i], font);
            g.DrawString(diasSemana[i], font, Brushes.Black, x + (ancho - tamDia.Width) / 2, margenSup + altoGrafico + 5);
        }
        
        // 9. ESCALA DEL EJE Y
        // Dibujar 6 líneas de referencia horizontales con sus valores
        for (int i = 0; i <= 5; i++)
        {
            // Calcular el valor de temperatura para esta línea
            double valor = minTemp + (rangoTemp * i / 5);
            // Calcular la posición Y de esta línea
            int y = margenSup + altoGrafico - (i * altoGrafico / 5);
            // Dibujar el valor numérico a la izquierda
            g.DrawString(valor.ToString("F1"), font, Brushes.Black, 5, y - 7);
            // Dibujar línea de referencia horizontal en gris claro
            g.DrawLine(Pens.LightGray, margenIzq, y, margenIzq + anchoGrafico, y);
        }
        
        // 10. FINALIZACIÓN
        pictureBox1.Image = bmp;  // Asignar el gráfico al PictureBox
        g.Dispose();  // Liberar recursos del objeto Graphics
    }


    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        dtgTemp.DataSource = null;
        cmbTemp.Items.Clear();
        
        foreach (Control control in panel1.Controls)
        {
            if (control is TextBox)
            {
                control.Text = "";
            }
        }
        
        tprSem.Text = "";
        tmaxSem.Text = "";
        tminSem.Text = "";
        
        pictureBox1.Image = null;
        
        for (int i = 0; i < 24; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                temp[i, j] = 0;
            }
        }
    }

    private void btnRegresar_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}