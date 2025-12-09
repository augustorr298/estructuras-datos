using System.ComponentModel;

namespace SensorSubmarino;

partial class frmOpeUnidimensional
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        btnInsertar = new System.Windows.Forms.Button();
        btnModificar = new System.Windows.Forms.Button();
        btnEliminar = new System.Windows.Forms.Button();
        btnConsultar = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        btnCrear = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        txtNoEle = new System.Windows.Forms.TextBox();
        panel3 = new System.Windows.Forms.Panel();
        btnBuscar = new System.Windows.Forms.Button();
        txtNvoEle = new System.Windows.Forms.TextBox();
        txtElemento = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        panel4 = new System.Windows.Forms.Panel();
        btnSalir = new System.Windows.Forms.Button();
        btnRegresar = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        btnAceptar = new System.Windows.Forms.Button();
        dtgArreglo = new System.Windows.Forms.DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtgArreglo).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.SteelBlue;
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(1, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(801, 123);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.Highlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.SystemColors.Control;
        label1.Location = new System.Drawing.Point(0, 31);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(825, 68);
        label1.TabIndex = 0;
        label1.Text = "OPERACIONES EN ARREGLO UNIDIMENSIONAL";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnInsertar
        // 
        btnInsertar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnInsertar.Location = new System.Drawing.Point(53, 157);
        btnInsertar.Name = "btnInsertar";
        btnInsertar.Size = new System.Drawing.Size(128, 52);
        btnInsertar.TabIndex = 1;
        btnInsertar.Text = "INSERTAR";
        btnInsertar.UseVisualStyleBackColor = true;
        btnInsertar.Click += btnInsertar_Click;
        // 
        // btnModificar
        // 
        btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnModificar.Location = new System.Drawing.Point(232, 157);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new System.Drawing.Size(128, 52);
        btnModificar.TabIndex = 2;
        btnModificar.Text = "MODIFICAR";
        btnModificar.UseVisualStyleBackColor = true;
        btnModificar.Click += btnModificar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnEliminar.Location = new System.Drawing.Point(418, 157);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(128, 52);
        btnEliminar.TabIndex = 3;
        btnEliminar.Text = "ELIMINAR";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnConsultar
        // 
        btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnConsultar.Location = new System.Drawing.Point(611, 157);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new System.Drawing.Size(128, 52);
        btnConsultar.TabIndex = 4;
        btnConsultar.Text = "CONSULTAR";
        btnConsultar.UseVisualStyleBackColor = true;
        btnConsultar.Click += btnConsultar_Click;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        panel2.Controls.Add(btnCrear);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(txtNoEle);
        panel2.Location = new System.Drawing.Point(53, 242);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(493, 93);
        panel2.TabIndex = 5;
        // 
        // btnCrear
        // 
        btnCrear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnCrear.Location = new System.Drawing.Point(334, 20);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new System.Drawing.Size(128, 52);
        btnCrear.TabIndex = 6;
        btnCrear.Text = "CREAR";
        btnCrear.UseVisualStyleBackColor = true;
        btnCrear.Click += button5_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(19, 37);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(187, 23);
        label2.TabIndex = 1;
        label2.Text = "Número de elementos";
        // 
        // txtNoEle
        // 
        txtNoEle.Location = new System.Drawing.Point(207, 33);
        txtNoEle.Name = "txtNoEle";
        txtNoEle.Size = new System.Drawing.Size(100, 27);
        txtNoEle.TabIndex = 0;
        txtNoEle.KeyPress += txtNoEle_KeyPress;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        panel3.Controls.Add(btnBuscar);
        panel3.Controls.Add(txtNvoEle);
        panel3.Controls.Add(txtElemento);
        panel3.Controls.Add(label4);
        panel3.Controls.Add(label3);
        panel3.Location = new System.Drawing.Point(53, 360);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(492, 134);
        panel3.TabIndex = 6;
        // 
        // btnBuscar
        // 
        btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnBuscar.Location = new System.Drawing.Point(334, 23);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new System.Drawing.Size(128, 52);
        btnBuscar.TabIndex = 7;
        btnBuscar.Text = "BUSCAR";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // txtNvoEle
        // 
        txtNvoEle.Location = new System.Drawing.Point(207, 67);
        txtNvoEle.Name = "txtNvoEle";
        txtNvoEle.Size = new System.Drawing.Size(100, 27);
        txtNvoEle.TabIndex = 8;
        txtNvoEle.KeyPress += txtNvoEle_KeyPress;
        // 
        // txtElemento
        // 
        txtElemento.Location = new System.Drawing.Point(207, 19);
        txtElemento.Name = "txtElemento";
        txtElemento.Size = new System.Drawing.Size(100, 27);
        txtElemento.TabIndex = 7;
        txtElemento.KeyPress += txtElemento_KeyPress;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(27, 70);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(150, 32);
        label4.TabIndex = 1;
        label4.Text = "Nuevo elemento";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(27, 23);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 0;
        label3.Text = "Elemento";
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.Color.SteelBlue;
        panel4.Controls.Add(btnSalir);
        panel4.Controls.Add(btnRegresar);
        panel4.Controls.Add(btnLimpiar);
        panel4.Controls.Add(btnAceptar);
        panel4.Location = new System.Drawing.Point(1, 562);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(801, 92);
        panel4.TabIndex = 1;
        // 
        // btnSalir
        // 
        btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnSalir.Location = new System.Drawing.Point(610, 25);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(128, 52);
        btnSalir.TabIndex = 10;
        btnSalir.Text = "SALIR";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // btnRegresar
        // 
        btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnRegresar.Location = new System.Drawing.Point(417, 25);
        btnRegresar.Name = "btnRegresar";
        btnRegresar.Size = new System.Drawing.Size(128, 52);
        btnRegresar.TabIndex = 9;
        btnRegresar.Text = "REGRESAR";
        btnRegresar.UseVisualStyleBackColor = true;
        btnRegresar.Click += btnRegresar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnLimpiar.Location = new System.Drawing.Point(231, 25);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(128, 52);
        btnLimpiar.TabIndex = 8;
        btnLimpiar.Text = "LIMPIAR";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnAceptar
        // 
        btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnAceptar.Location = new System.Drawing.Point(52, 25);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new System.Drawing.Size(128, 52);
        btnAceptar.TabIndex = 8;
        btnAceptar.Text = "ACEPTAR";
        btnAceptar.UseVisualStyleBackColor = true;
        btnAceptar.Click += btnAceptar_Click;
        // 
        // dtgArreglo
        // 
        dtgArreglo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgArreglo.Location = new System.Drawing.Point(577, 242);
        dtgArreglo.Name = "dtgArreglo";
        dtgArreglo.RowHeadersWidth = 51;
        dtgArreglo.Size = new System.Drawing.Size(203, 282);
        dtgArreglo.TabIndex = 7;
        dtgArreglo.Text = "dataGridView1";
        // 
        // frmOpeUnidimensional
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(801, 651);
        Controls.Add(dtgArreglo);
        Controls.Add(panel4);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(btnConsultar);
        Controls.Add(btnInsertar);
        Controls.Add(btnEliminar);
        Controls.Add(btnModificar);
        Controls.Add(panel1);
        Text = "frmOpeUnidimensional";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dtgArreglo).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dtgArreglo;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnRegresar;
    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtNoEle;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtElemento;
    private System.Windows.Forms.TextBox txtNvoEle;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;

    #endregion
}