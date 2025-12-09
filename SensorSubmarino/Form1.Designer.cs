namespace SensorSubmarino;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        dtgTemp = new System.Windows.Forms.DataGridView();
        cmbTemp = new System.Windows.Forms.ComboBox();
        btnGenerar = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        label12 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        tprDom = new System.Windows.Forms.TextBox();
        tprSab = new System.Windows.Forms.TextBox();
        tprVie = new System.Windows.Forms.TextBox();
        tprJue = new System.Windows.Forms.TextBox();
        tprMie = new System.Windows.Forms.TextBox();
        tprMar = new System.Windows.Forms.TextBox();
        tprLun = new System.Windows.Forms.TextBox();
        tminDom = new System.Windows.Forms.TextBox();
        tminSab = new System.Windows.Forms.TextBox();
        tminVie = new System.Windows.Forms.TextBox();
        tminJue = new System.Windows.Forms.TextBox();
        tminMie = new System.Windows.Forms.TextBox();
        tminMar = new System.Windows.Forms.TextBox();
        tminLun = new System.Windows.Forms.TextBox();
        tmaxDom = new System.Windows.Forms.TextBox();
        tmaxSab = new System.Windows.Forms.TextBox();
        tmaxVie = new System.Windows.Forms.TextBox();
        tmaxJue = new System.Windows.Forms.TextBox();
        tmaxMie = new System.Windows.Forms.TextBox();
        tmaxMar = new System.Windows.Forms.TextBox();
        tmaxLun = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        tprSem = new System.Windows.Forms.TextBox();
        tminSem = new System.Windows.Forms.TextBox();
        tmaxSem = new System.Windows.Forms.TextBox();
        label13 = new System.Windows.Forms.Label();
        btnCalcular = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        btnRegresar = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)dtgTemp).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(40, -2);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(674, 57);
        label1.TabIndex = 0;
        label1.Text = "SENSOR SUBMARINO";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // dtgTemp
        // 
        dtgTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgTemp.Location = new System.Drawing.Point(12, 58);
        dtgTemp.Name = "dtgTemp";
        dtgTemp.RowHeadersWidth = 51;
        dtgTemp.Size = new System.Drawing.Size(672, 428);
        dtgTemp.TabIndex = 1;
        dtgTemp.Text = "dataGridView1";
        // 
        // cmbTemp
        // 
        cmbTemp.FormattingEnabled = true;
        cmbTemp.Location = new System.Drawing.Point(703, 99);
        cmbTemp.Name = "cmbTemp";
        cmbTemp.Size = new System.Drawing.Size(188, 28);
        cmbTemp.TabIndex = 2;
        // 
        // btnGenerar
        // 
        btnGenerar.Location = new System.Drawing.Point(703, 58);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new System.Drawing.Size(142, 35);
        btnGenerar.TabIndex = 3;
        btnGenerar.Text = "Generar";
        btnGenerar.UseVisualStyleBackColor = true;
        btnGenerar.Click += btnGenerar_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(label12);
        panel1.Controls.Add(label11);
        panel1.Controls.Add(label10);
        panel1.Controls.Add(label9);
        panel1.Controls.Add(label8);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(tprDom);
        panel1.Controls.Add(tprSab);
        panel1.Controls.Add(tprVie);
        panel1.Controls.Add(tprJue);
        panel1.Controls.Add(tprMie);
        panel1.Controls.Add(tprMar);
        panel1.Controls.Add(tprLun);
        panel1.Controls.Add(tminDom);
        panel1.Controls.Add(tminSab);
        panel1.Controls.Add(tminVie);
        panel1.Controls.Add(tminJue);
        panel1.Controls.Add(tminMie);
        panel1.Controls.Add(tminMar);
        panel1.Controls.Add(tminLun);
        panel1.Controls.Add(tmaxDom);
        panel1.Controls.Add(tmaxSab);
        panel1.Controls.Add(tmaxVie);
        panel1.Controls.Add(tmaxJue);
        panel1.Controls.Add(tmaxMie);
        panel1.Controls.Add(tmaxMar);
        panel1.Controls.Add(tmaxLun);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Location = new System.Drawing.Point(12, 522);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(702, 137);
        panel1.TabIndex = 4;
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(618, 2);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(72, 21);
        label12.TabIndex = 31;
        label12.Text = "Domingo";
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(539, 2);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(63, 21);
        label11.TabIndex = 30;
        label11.Text = "Sábado";
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(459, 2);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(63, 21);
        label10.TabIndex = 29;
        label10.Text = "Viernes";
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(376, 2);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(63, 21);
        label9.TabIndex = 28;
        label9.Text = "Jueves";
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(287, 2);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(83, 21);
        label8.TabIndex = 27;
        label8.Text = "Miércoles";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(198, 2);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(63, 21);
        label7.TabIndex = 26;
        label7.Text = "Martes";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(105, 2);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(91, 21);
        label6.TabIndex = 25;
        label6.Text = "Lunes";
        // 
        // tprDom
        // 
        tprDom.Location = new System.Drawing.Point(618, 102);
        tprDom.Name = "tprDom";
        tprDom.Size = new System.Drawing.Size(63, 27);
        tprDom.TabIndex = 24;
        // 
        // tprSab
        // 
        tprSab.Location = new System.Drawing.Point(539, 102);
        tprSab.Name = "tprSab";
        tprSab.Size = new System.Drawing.Size(63, 27);
        tprSab.TabIndex = 23;
        // 
        // tprVie
        // 
        tprVie.Location = new System.Drawing.Point(459, 102);
        tprVie.Name = "tprVie";
        tprVie.Size = new System.Drawing.Size(63, 27);
        tprVie.TabIndex = 22;
        // 
        // tprJue
        // 
        tprJue.Location = new System.Drawing.Point(376, 102);
        tprJue.Name = "tprJue";
        tprJue.Size = new System.Drawing.Size(63, 27);
        tprJue.TabIndex = 21;
        // 
        // tprMie
        // 
        tprMie.Location = new System.Drawing.Point(288, 102);
        tprMie.Name = "tprMie";
        tprMie.Size = new System.Drawing.Size(63, 27);
        tprMie.TabIndex = 20;
        // 
        // tprMar
        // 
        tprMar.Location = new System.Drawing.Point(198, 102);
        tprMar.Name = "tprMar";
        tprMar.Size = new System.Drawing.Size(63, 27);
        tprMar.TabIndex = 19;
        // 
        // tprLun
        // 
        tprLun.Location = new System.Drawing.Point(105, 102);
        tprLun.Name = "tprLun";
        tprLun.Size = new System.Drawing.Size(63, 27);
        tprLun.TabIndex = 18;
        // 
        // tminDom
        // 
        tminDom.Location = new System.Drawing.Point(618, 69);
        tminDom.Name = "tminDom";
        tminDom.Size = new System.Drawing.Size(63, 27);
        tminDom.TabIndex = 17;
        // 
        // tminSab
        // 
        tminSab.Location = new System.Drawing.Point(539, 69);
        tminSab.Name = "tminSab";
        tminSab.Size = new System.Drawing.Size(63, 27);
        tminSab.TabIndex = 16;
        // 
        // tminVie
        // 
        tminVie.Location = new System.Drawing.Point(459, 69);
        tminVie.Name = "tminVie";
        tminVie.Size = new System.Drawing.Size(63, 27);
        tminVie.TabIndex = 15;
        // 
        // tminJue
        // 
        tminJue.Location = new System.Drawing.Point(376, 69);
        tminJue.Name = "tminJue";
        tminJue.Size = new System.Drawing.Size(63, 27);
        tminJue.TabIndex = 14;
        // 
        // tminMie
        // 
        tminMie.Location = new System.Drawing.Point(288, 69);
        tminMie.Name = "tminMie";
        tminMie.Size = new System.Drawing.Size(63, 27);
        tminMie.TabIndex = 13;
        // 
        // tminMar
        // 
        tminMar.Location = new System.Drawing.Point(198, 69);
        tminMar.Name = "tminMar";
        tminMar.Size = new System.Drawing.Size(63, 27);
        tminMar.TabIndex = 12;
        // 
        // tminLun
        // 
        tminLun.Location = new System.Drawing.Point(105, 69);
        tminLun.Name = "tminLun";
        tminLun.Size = new System.Drawing.Size(63, 27);
        tminLun.TabIndex = 11;
        // 
        // tmaxDom
        // 
        tmaxDom.Location = new System.Drawing.Point(618, 35);
        tmaxDom.Name = "tmaxDom";
        tmaxDom.Size = new System.Drawing.Size(63, 27);
        tmaxDom.TabIndex = 10;
        // 
        // tmaxSab
        // 
        tmaxSab.Location = new System.Drawing.Point(539, 35);
        tmaxSab.Name = "tmaxSab";
        tmaxSab.Size = new System.Drawing.Size(63, 27);
        tmaxSab.TabIndex = 9;
        // 
        // tmaxVie
        // 
        tmaxVie.Location = new System.Drawing.Point(459, 35);
        tmaxVie.Name = "tmaxVie";
        tmaxVie.Size = new System.Drawing.Size(63, 27);
        tmaxVie.TabIndex = 8;
        // 
        // tmaxJue
        // 
        tmaxJue.Location = new System.Drawing.Point(376, 35);
        tmaxJue.Name = "tmaxJue";
        tmaxJue.Size = new System.Drawing.Size(63, 27);
        tmaxJue.TabIndex = 7;
        // 
        // tmaxMie
        // 
        tmaxMie.Location = new System.Drawing.Point(288, 35);
        tmaxMie.Name = "tmaxMie";
        tmaxMie.Size = new System.Drawing.Size(63, 27);
        tmaxMie.TabIndex = 6;
        // 
        // tmaxMar
        // 
        tmaxMar.Location = new System.Drawing.Point(198, 35);
        tmaxMar.Name = "tmaxMar";
        tmaxMar.Size = new System.Drawing.Size(63, 27);
        tmaxMar.TabIndex = 5;
        // 
        // tmaxLun
        // 
        tmaxLun.Location = new System.Drawing.Point(105, 35);
        tmaxLun.Name = "tmaxLun";
        tmaxLun.Size = new System.Drawing.Size(63, 27);
        tmaxLun.TabIndex = 4;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(11, 105);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(102, 21);
        label5.TabIndex = 3;
        label5.Text = "Promedio";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(11, 69);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(102, 21);
        label4.TabIndex = 2;
        label4.Text = "Mínimo";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(11, 38);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(102, 21);
        label3.TabIndex = 1;
        label3.Text = "Máximo";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(3, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 0;
        label2.Text = "Día";
        // 
        // panel2
        // 
        panel2.Controls.Add(tprSem);
        panel2.Controls.Add(tminSem);
        panel2.Controls.Add(tmaxSem);
        panel2.Controls.Add(label13);
        panel2.Location = new System.Drawing.Point(752, 525);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(139, 134);
        panel2.TabIndex = 5;
        // 
        // tprSem
        // 
        tprSem.Location = new System.Drawing.Point(28, 100);
        tprSem.Name = "tprSem";
        tprSem.Size = new System.Drawing.Size(63, 27);
        tprSem.TabIndex = 33;
        // 
        // tminSem
        // 
        tminSem.Location = new System.Drawing.Point(28, 67);
        tminSem.Name = "tminSem";
        tminSem.Size = new System.Drawing.Size(63, 27);
        tminSem.TabIndex = 32;
        // 
        // tmaxSem
        // 
        tmaxSem.Location = new System.Drawing.Point(28, 33);
        tmaxSem.Name = "tmaxSem";
        tmaxSem.Size = new System.Drawing.Size(63, 27);
        tmaxSem.TabIndex = 32;
        // 
        // label13
        // 
        label13.Location = new System.Drawing.Point(28, 7);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(121, 26);
        label13.TabIndex = 0;
        label13.Text = "Semana";
        // 
        // btnCalcular
        // 
        btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCalcular.Location = new System.Drawing.Point(152, 686);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(177, 44);
        btnCalcular.TabIndex = 6;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = false;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnLimpiar.Location = new System.Drawing.Point(357, 686);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(177, 44);
        btnLimpiar.TabIndex = 7;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnRegresar
        // 
        btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        btnRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRegresar.Location = new System.Drawing.Point(551, 686);
        btnRegresar.Name = "btnRegresar";
        btnRegresar.Size = new System.Drawing.Size(177, 44);
        btnRegresar.TabIndex = 8;
        btnRegresar.Text = "Regresar";
        btnRegresar.UseVisualStyleBackColor = false;
        btnRegresar.Click += btnRegresar_Click;
        // 
        // btnSalir
        // 
        btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSalir.Location = new System.Drawing.Point(752, 686);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(177, 44);
        btnSalir.TabIndex = 9;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        btnSalir.Click += btnSalir_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(703, 150);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(274, 336);
        pictureBox1.TabIndex = 10;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1070, 742);
        Controls.Add(pictureBox1);
        Controls.Add(btnSalir);
        Controls.Add(btnRegresar);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCalcular);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(btnGenerar);
        Controls.Add(cmbTemp);
        Controls.Add(dtgTemp);
        Controls.Add(label1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dtgTemp).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnRegresar;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnLimpiar;

    private System.Windows.Forms.TextBox tmaxSem;
    private System.Windows.Forms.TextBox tminSem;
    private System.Windows.Forms.TextBox tprSem;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label13;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tmaxLun;
    private System.Windows.Forms.TextBox tmaxMar;
    private System.Windows.Forms.TextBox tmaxMie;
    private System.Windows.Forms.TextBox tmaxJue;
    private System.Windows.Forms.TextBox tmaxVie;
    private System.Windows.Forms.TextBox tmaxSab;
    private System.Windows.Forms.TextBox tmaxDom;
    private System.Windows.Forms.TextBox tminLun;
    private System.Windows.Forms.TextBox tminMar;
    private System.Windows.Forms.TextBox tminMie;
    private System.Windows.Forms.TextBox tminJue;
    private System.Windows.Forms.TextBox tminVie;
    private System.Windows.Forms.TextBox tminSab;
    private System.Windows.Forms.TextBox tminDom;
    private System.Windows.Forms.TextBox tprLun;
    private System.Windows.Forms.TextBox tprMar;
    private System.Windows.Forms.TextBox tprMie;
    private System.Windows.Forms.TextBox tprJue;
    private System.Windows.Forms.TextBox tprVie;
    private System.Windows.Forms.TextBox tprSab;
    private System.Windows.Forms.TextBox tprDom;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.DataGridView dtgTemp;
    private System.Windows.Forms.ComboBox cmbTemp;
    private System.Windows.Forms.Button btnGenerar;

    private System.Windows.Forms.Label label1;

    #endregion
}