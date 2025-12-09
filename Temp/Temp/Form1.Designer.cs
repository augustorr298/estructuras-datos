using System.DirectoryServices.ActiveDirectory;

namespace Temp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button btnGraficar;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.TextBox txtDesv;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Label Promedio;

 
        
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        label8 = new System.Windows.Forms.Label();
        txtNoTem = new System.Windows.Forms.TextBox();
        btnGenerar = new System.Windows.Forms.Button();
        btnCrear = new System.Windows.Forms.Button();
        cmbTem = new System.Windows.Forms.ComboBox();
        lstTem = new System.Windows.Forms.ListBox();
        dtgTem = new System.Windows.Forms.DataGridView();
        dtgAsc = new System.Windows.Forms.DataGridView();
        dtgDes = new System.Windows.Forms.DataGridView();
        groupBox1 = new System.Windows.Forms.GroupBox();
        txtDes = new System.Windows.Forms.TextBox();
        txt3Min = new System.Windows.Forms.TextBox();
        txt3Max = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        txtMin = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtMax = new System.Windows.Forms.TextBox();
        txtVar = new System.Windows.Forms.TextBox();
        txtProm = new System.Windows.Forms.TextBox();
        txtSum = new System.Windows.Forms.TextBox();
        btnGraficar = new System.Windows.Forms.Button();
        btnCalcular = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        Promedio = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        btnLimpiar = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        picGrafica = new System.Windows.Forms.PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtgTem).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dtgAsc).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dtgDes).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picGrafica).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(37, 53);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(802, 69);
        label1.TabIndex = 0;
        label1.Text = "Temperaturas";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        label1.Click += label1_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(label8);
        panel1.Controls.Add(txtNoTem);
        panel1.Controls.Add(btnGenerar);
        panel1.Controls.Add(btnCrear);
        panel1.Location = new System.Drawing.Point(36, 125);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(803, 174);
        panel1.TabIndex = 1;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(56, 73);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(222, 26);
        label8.TabIndex = 3;
        label8.Text = "Número de temperaturas";
        // 
        // txtNoTem
        // 
        txtNoTem.ImeMode = System.Windows.Forms.ImeMode.On;
        txtNoTem.Location = new System.Drawing.Point(322, 74);
        txtNoTem.Name = "txtNoTem";
        txtNoTem.Size = new System.Drawing.Size(97, 27);
        txtNoTem.TabIndex = 2;
        txtNoTem.KeyPress += txtNoTem_KeyPress;
        // 
        // btnGenerar
        // 
        btnGenerar.Location = new System.Drawing.Point(645, 99);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new System.Drawing.Size(122, 51);
        btnGenerar.TabIndex = 1;
        btnGenerar.Text = "Generar";
        btnGenerar.UseVisualStyleBackColor = true;
        btnGenerar.Click += btnGenerar_Click_1;
        // 
        // btnCrear
        // 
        btnCrear.Location = new System.Drawing.Point(644, 38);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new System.Drawing.Size(124, 40);
        btnCrear.TabIndex = 0;
        btnCrear.Text = "Crear";
        btnCrear.UseVisualStyleBackColor = true;
        btnCrear.Click += button1_Click;
        // 
        // cmbTem
        // 
        cmbTem.FormattingEnabled = true;
        cmbTem.Location = new System.Drawing.Point(41, 320);
        cmbTem.Name = "cmbTem";
        cmbTem.Size = new System.Drawing.Size(233, 28);
        cmbTem.TabIndex = 2;
        // 
        // lstTem
        // 
        lstTem.FormattingEnabled = true;
        lstTem.Location = new System.Drawing.Point(41, 366);
        lstTem.Name = "lstTem";
        lstTem.Size = new System.Drawing.Size(233, 164);
        lstTem.TabIndex = 3;
        // 
        // dtgTem
        // 
        dtgTem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgTem.Location = new System.Drawing.Point(304, 321);
        dtgTem.Name = "dtgTem";
        dtgTem.RowHeadersWidth = 51;
        dtgTem.Size = new System.Drawing.Size(99, 207);
        dtgTem.TabIndex = 4;
        dtgTem.Text = "dataGridView1";
        // 
        // dtgAsc
        // 
        dtgAsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgAsc.Location = new System.Drawing.Point(429, 321);
        dtgAsc.Name = "dtgAsc";
        dtgAsc.RowHeadersWidth = 51;
        dtgAsc.Size = new System.Drawing.Size(95, 207);
        dtgAsc.TabIndex = 5;
        dtgAsc.Text = "dataGridView2";
        // 
        // dtgDes
        // 
        dtgDes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgDes.Location = new System.Drawing.Point(548, 323);
        dtgDes.Name = "dtgDes";
        dtgDes.RowHeadersWidth = 51;
        dtgDes.Size = new System.Drawing.Size(106, 205);
        dtgDes.TabIndex = 6;
        dtgDes.Text = "dataGridView3";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtDes);
        groupBox1.Controls.Add(txt3Min);
        groupBox1.Controls.Add(txt3Max);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(txtMin);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtMax);
        groupBox1.Controls.Add(txtVar);
        groupBox1.Controls.Add(txtProm);
        groupBox1.Controls.Add(txtSum);
        groupBox1.Controls.Add(btnGraficar);
        groupBox1.Controls.Add(btnCalcular);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(Promedio);
        groupBox1.Controls.Add(label2);
        groupBox1.Location = new System.Drawing.Point(681, 320);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(179, 351);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // txtDes
        // 
        txtDes.Location = new System.Drawing.Point(112, 126);
        txtDes.Name = "txtDes";
        txtDes.Size = new System.Drawing.Size(49, 27);
        txtDes.TabIndex = 18;
        // 
        // txt3Min
        // 
        txt3Min.Location = new System.Drawing.Point(111, 261);
        txt3Min.Name = "txt3Min";
        txt3Min.Size = new System.Drawing.Size(47, 27);
        txt3Min.TabIndex = 17;
        // 
        // txt3Max
        // 
        txt3Max.Location = new System.Drawing.Point(113, 221);
        txt3Max.Name = "txt3Max";
        txt3Max.Size = new System.Drawing.Size(50, 27);
        txt3Max.TabIndex = 16;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(18, 250);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(63, 29);
        label9.TabIndex = 15;
        label9.Text = "3Mínimo";
        // 
        // txtMin
        // 
        txtMin.Location = new System.Drawing.Point(111, 185);
        txtMin.Name = "txtMin";
        txtMin.Size = new System.Drawing.Size(57, 27);
        txtMin.TabIndex = 14;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(16, 191);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(65, 16);
        label3.TabIndex = 13;
        label3.Text = "Mínimo";
        // 
        // txtMax
        // 
        txtMax.Location = new System.Drawing.Point(111, 156);
        txtMax.Name = "txtMax";
        txtMax.Size = new System.Drawing.Size(57, 27);
        txtMax.TabIndex = 12;
        // 
        // txtVar
        // 
        txtVar.Location = new System.Drawing.Point(111, 93);
        txtVar.Name = "txtVar";
        txtVar.Size = new System.Drawing.Size(57, 27);
        txtVar.TabIndex = 10;
        // 
        // txtProm
        // 
        txtProm.Location = new System.Drawing.Point(112, 61);
        txtProm.Name = "txtProm";
        txtProm.Size = new System.Drawing.Size(56, 27);
        txtProm.TabIndex = 9;
        // 
        // txtSum
        // 
        txtSum.Location = new System.Drawing.Point(112, 23);
        txtSum.Name = "txtSum";
        txtSum.Size = new System.Drawing.Size(55, 27);
        txtSum.TabIndex = 8;
        // 
        // btnGraficar
        // 
        btnGraficar.Location = new System.Drawing.Point(101, 302);
        btnGraficar.Name = "btnGraficar";
        btnGraficar.Size = new System.Drawing.Size(62, 33);
        btnGraficar.TabIndex = 7;
        btnGraficar.Text = "Graficar";
        btnGraficar.UseVisualStyleBackColor = true;
        btnGraficar.Click += btnGraficar_Click;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new System.Drawing.Point(14, 302);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(72, 34);
        btnCalcular.TabIndex = 6;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click_1;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(17, 222);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(64, 28);
        label7.TabIndex = 5;
        label7.Text = "3Máximo";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(15, 159);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(69, 32);
        label6.TabIndex = 4;
        label6.Text = "Máximo";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(13, 131);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(68, 34);
        label5.TabIndex = 3;
        label5.Text = "Desv. Est.";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(14, 96);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(69, 35);
        label4.TabIndex = 2;
        label4.Text = "Varianza";
        // 
        // Promedio
        // 
        Promedio.Location = new System.Drawing.Point(13, 64);
        Promedio.Name = "Promedio";
        Promedio.Size = new System.Drawing.Size(70, 32);
        Promedio.TabIndex = 1;
        Promedio.Text = "Promedio";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(14, 26);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(70, 27);
        label2.TabIndex = 0;
        label2.Text = "Suma";
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new System.Drawing.Point(446, 622);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(104, 38);
        btnLimpiar.TabIndex = 8;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click_1;
        // 
        // btnSalir
        // 
        btnSalir.Location = new System.Drawing.Point(567, 622);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(98, 38);
        btnSalir.TabIndex = 9;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        // 
        // picGrafica
        // 
        picGrafica.Location = new System.Drawing.Point(35, 558);
        picGrafica.Name = "picGrafica";
        picGrafica.Size = new System.Drawing.Size(394, 207);
        picGrafica.TabIndex = 10;
        picGrafica.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(878, 816);
        Controls.Add(picGrafica);
        Controls.Add(btnSalir);
        Controls.Add(btnLimpiar);
        Controls.Add(groupBox1);
        Controls.Add(dtgDes);
        Controls.Add(dtgAsc);
        Controls.Add(dtgTem);
        Controls.Add(lstTem);
        Controls.Add(cmbTem);
        Controls.Add(panel1);
        Controls.Add(label1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dtgTem).EndInit();
        ((System.ComponentModel.ISupportInitialize)dtgAsc).EndInit();
        ((System.ComponentModel.ISupportInitialize)dtgDes).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picGrafica).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox picGrafica;

    private System.Windows.Forms.TextBox txt3Min;
    private System.Windows.Forms.TextBox txtDes;

    private System.Windows.Forms.TextBox txtNoTem;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtSum;
    private System.Windows.Forms.TextBox txtProm;
    private System.Windows.Forms.TextBox txtVar;
    private System.Windows.Forms.TextBox txtMax;
    private System.Windows.Forms.TextBox txtMin;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.TextBox txt3Max;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.Button btnGenerar;
    private System.Windows.Forms.ComboBox cmbTem;
    private System.Windows.Forms.ListBox lstTem;
    private System.Windows.Forms.DataGridView dtgTem;
    private System.Windows.Forms.DataGridView dtgAsc;
    private System.Windows.Forms.DataGridView dtgDes;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    /*
     */
    #endregion
}