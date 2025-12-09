namespace SensorSubmarino;

partial class frmInventarios
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new System.Windows.Forms.Label();
        panelCrear = new System.Windows.Forms.Panel();
        btnCrear = new System.Windows.Forms.Button();
        txtNumProductos = new System.Windows.Forms.TextBox();
        lblNumProductos = new System.Windows.Forms.Label();
        panelOperaciones = new System.Windows.Forms.Panel();
        btnEliminar = new System.Windows.Forms.Button();
        btnModificar = new System.Windows.Forms.Button();
        btnConsultar = new System.Windows.Forms.Button();
        btnInsertar = new System.Windows.Forms.Button();
        panelValor = new System.Windows.Forms.Panel();
        btnConfirmar = new System.Windows.Forms.Button();
        lblValor = new System.Windows.Forms.Label();
        txtValor = new System.Windows.Forms.TextBox();
        dtgInventario = new System.Windows.Forms.DataGridView();
        panelBotones = new System.Windows.Forms.Panel();
        btnRegresar = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        panelCrear.SuspendLayout();
        panelOperaciones.SuspendLayout();
        panelValor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtgInventario).BeginInit();
        panelBotones.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
        lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
        lblTitulo.Location = new System.Drawing.Point(200, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new System.Drawing.Size(400, 51);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "SISTEMA DE INVENTARIO";
        // 
        // panelCrear
        // 
        panelCrear.BackColor = System.Drawing.Color.LightSteelBlue;
        panelCrear.Controls.Add(btnCrear);
        panelCrear.Controls.Add(txtNumProductos);
        panelCrear.Controls.Add(lblNumProductos);
        panelCrear.Location = new System.Drawing.Point(12, 70);
        panelCrear.Name = "panelCrear";
        panelCrear.Size = new System.Drawing.Size(760, 60);
        panelCrear.TabIndex = 1;
        // 
        // btnCrear
        // 
        btnCrear.BackColor = System.Drawing.Color.SteelBlue;
        btnCrear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnCrear.ForeColor = System.Drawing.Color.White;
        btnCrear.Location = new System.Drawing.Point(580, 12);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new System.Drawing.Size(160, 35);
        btnCrear.TabIndex = 2;
        btnCrear.Text = "Crear Inventario";
        btnCrear.UseVisualStyleBackColor = false;
        btnCrear.Click += btnCrear_Click;
        // 
        // txtNumProductos
        // 
        txtNumProductos.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtNumProductos.Location = new System.Drawing.Point(420, 15);
        txtNumProductos.Name = "txtNumProductos";
        txtNumProductos.Size = new System.Drawing.Size(140, 29);
        txtNumProductos.TabIndex = 1;
        txtNumProductos.KeyPress += txtNumProductos_KeyPress;
        // 
        // lblNumProductos
        // 
        lblNumProductos.AutoSize = true;
        lblNumProductos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblNumProductos.Location = new System.Drawing.Point(20, 15);
        lblNumProductos.Name = "lblNumProductos";
        lblNumProductos.Size = new System.Drawing.Size(380, 25);
        lblNumProductos.TabIndex = 0;
        lblNumProductos.Text = "Número de productos a registrar (filas):";
        // 
        // panelOperaciones
        // 
        panelOperaciones.BackColor = System.Drawing.Color.DarkSlateBlue;
        panelOperaciones.Controls.Add(btnEliminar);
        panelOperaciones.Controls.Add(btnModificar);
        panelOperaciones.Controls.Add(btnConsultar);
        panelOperaciones.Controls.Add(btnInsertar);
        panelOperaciones.Location = new System.Drawing.Point(12, 140);
        panelOperaciones.Name = "panelOperaciones";
        panelOperaciones.Size = new System.Drawing.Size(760, 55);
        panelOperaciones.TabIndex = 2;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = System.Drawing.Color.IndianRed;
        btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnEliminar.ForeColor = System.Drawing.Color.White;
        btnEliminar.Location = new System.Drawing.Point(570, 10);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(170, 35);
        btnEliminar.TabIndex = 3;
        btnEliminar.Text = "Eliminar Producto";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnModificar
        // 
        btnModificar.BackColor = System.Drawing.Color.DarkOrange;
        btnModificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnModificar.ForeColor = System.Drawing.Color.White;
        btnModificar.Location = new System.Drawing.Point(385, 10);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new System.Drawing.Size(170, 35);
        btnModificar.TabIndex = 2;
        btnModificar.Text = "Modificar Stock";
        btnModificar.UseVisualStyleBackColor = false;
        btnModificar.Click += btnModificar_Click;
        // 
        // btnConsultar
        // 
        btnConsultar.BackColor = System.Drawing.Color.MediumSeaGreen;
        btnConsultar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnConsultar.ForeColor = System.Drawing.Color.White;
        btnConsultar.Location = new System.Drawing.Point(200, 10);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new System.Drawing.Size(170, 35);
        btnConsultar.TabIndex = 1;
        btnConsultar.Text = "Consultar Producto";
        btnConsultar.UseVisualStyleBackColor = false;
        btnConsultar.Click += btnConsultar_Click;
        // 
        // btnInsertar
        // 
        btnInsertar.BackColor = System.Drawing.Color.RoyalBlue;
        btnInsertar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnInsertar.ForeColor = System.Drawing.Color.White;
        btnInsertar.Location = new System.Drawing.Point(15, 10);
        btnInsertar.Name = "btnInsertar";
        btnInsertar.Size = new System.Drawing.Size(170, 35);
        btnInsertar.TabIndex = 0;
        btnInsertar.Text = "Insertar Producto";
        btnInsertar.UseVisualStyleBackColor = false;
        btnInsertar.Click += btnInsertar_Click;
        // 
        // panelValor
        // 
        panelValor.BackColor = System.Drawing.Color.LightSteelBlue;
        panelValor.Controls.Add(btnConfirmar);
        panelValor.Controls.Add(lblValor);
        panelValor.Controls.Add(txtValor);
        panelValor.Location = new System.Drawing.Point(12, 205);
        panelValor.Name = "panelValor";
        panelValor.Size = new System.Drawing.Size(760, 55);
        panelValor.TabIndex = 3;
        // 
        // btnConfirmar
        // 
        btnConfirmar.BackColor = System.Drawing.Color.SeaGreen;
        btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnConfirmar.ForeColor = System.Drawing.Color.White;
        btnConfirmar.Location = new System.Drawing.Point(450, 10);
        btnConfirmar.Name = "btnConfirmar";
        btnConfirmar.Size = new System.Drawing.Size(180, 35);
        btnConfirmar.TabIndex = 2;
        btnConfirmar.Text = "Confirmar Acción";
        btnConfirmar.UseVisualStyleBackColor = false;
        btnConfirmar.Click += btnConfirmar_Click;
        // 
        // lblValor
        // 
        lblValor.AutoSize = true;
        lblValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        lblValor.Location = new System.Drawing.Point(20, 15);
        lblValor.Name = "lblValor";
        lblValor.Size = new System.Drawing.Size(60, 25);
        lblValor.TabIndex = 0;
        lblValor.Text = "Valor:";
        // 
        // txtValor
        // 
        txtValor.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtValor.Location = new System.Drawing.Point(250, 13);
        txtValor.Name = "txtValor";
        txtValor.Size = new System.Drawing.Size(180, 29);
        txtValor.TabIndex = 1;
        txtValor.KeyPress += txtValor_KeyPress;
        // 
        // dtgInventario
        // 
        dtgInventario.AllowUserToAddRows = false;
        dtgInventario.AllowUserToDeleteRows = false;
        dtgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dtgInventario.BackgroundColor = System.Drawing.Color.White;
        dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgInventario.Location = new System.Drawing.Point(12, 270);
        dtgInventario.Name = "dtgInventario";
        dtgInventario.ReadOnly = true;
        dtgInventario.RowHeadersWidth = 51;
        dtgInventario.Size = new System.Drawing.Size(760, 280);
        dtgInventario.TabIndex = 4;
        // 
        // panelBotones
        // 
        panelBotones.BackColor = System.Drawing.Color.Gainsboro;
        panelBotones.Controls.Add(btnRegresar);
        panelBotones.Controls.Add(btnLimpiar);
        panelBotones.Location = new System.Drawing.Point(12, 560);
        panelBotones.Name = "panelBotones";
        panelBotones.Size = new System.Drawing.Size(760, 55);
        panelBotones.TabIndex = 5;
        // 
        // btnRegresar
        // 
        btnRegresar.BackColor = System.Drawing.Color.Gray;
        btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnRegresar.ForeColor = System.Drawing.Color.White;
        btnRegresar.Location = new System.Drawing.Point(580, 10);
        btnRegresar.Name = "btnRegresar";
        btnRegresar.Size = new System.Drawing.Size(160, 35);
        btnRegresar.TabIndex = 1;
        btnRegresar.Text = "Regresar";
        btnRegresar.UseVisualStyleBackColor = false;
        btnRegresar.Click += btnRegresar_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.BackColor = System.Drawing.Color.Goldenrod;
        btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        btnLimpiar.ForeColor = System.Drawing.Color.White;
        btnLimpiar.Location = new System.Drawing.Point(400, 10);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(160, 35);
        btnLimpiar.TabIndex = 0;
        btnLimpiar.Text = "Limpiar / Reiniciar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // frmInventarios
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.WhiteSmoke;
        ClientSize = new System.Drawing.Size(784, 650);
        Controls.Add(panelBotones);
        Controls.Add(dtgInventario);
        Controls.Add(panelValor);
        Controls.Add(panelOperaciones);
        Controls.Add(panelCrear);
        Controls.Add(lblTitulo);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "frmInventarios";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Sistema de Inventario - Arreglo Bidimensional";
        panelCrear.ResumeLayout(false);
        panelCrear.PerformLayout();
        panelOperaciones.ResumeLayout(false);
        panelValor.ResumeLayout(false);
        panelValor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dtgInventario).EndInit();
        panelBotones.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Panel panelCrear;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.TextBox txtNumProductos;
    private System.Windows.Forms.Label lblNumProductos;
    private System.Windows.Forms.Panel panelOperaciones;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.Button btnInsertar;
    private System.Windows.Forms.Panel panelValor;
    private System.Windows.Forms.Button btnConfirmar;
    private System.Windows.Forms.Label lblValor;
    private System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.DataGridView dtgInventario;
    private System.Windows.Forms.Panel panelBotones;
    private System.Windows.Forms.Button btnRegresar;
    private System.Windows.Forms.Button btnLimpiar;
}
