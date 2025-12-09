namespace Inventarios
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            iniBtn = new Button();
            numeroProd = new TextBox();
            label111 = new Label();
            dtgArreglo = new DataGridView();
            panel2 = new Panel();
            eliminarBtn = new Button();
            modBtn = new Button();
            consulBtn = new Button();
            insertBtn = new Button();
            panel3 = new Panel();
            confirmarBtn = new Button();
            label88 = new Label();
            valorTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgArreglo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 65);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(iniBtn);
            panel1.Controls.Add(numeroProd);
            panel1.Controls.Add(label111);
            panel1.Location = new Point(26, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 70);
            panel1.TabIndex = 1;
            // 
            // iniBtn
            // 
            iniBtn.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniBtn.Location = new Point(554, 28);
            iniBtn.Name = "iniBtn";
            iniBtn.Size = new Size(138, 26);
            iniBtn.TabIndex = 2;
            iniBtn.Text = "Inicializar";
            iniBtn.UseVisualStyleBackColor = true;
            iniBtn.Click += iniBtn_Click;
            // 
            // numeroProd
            // 
            numeroProd.Location = new Point(434, 28);
            numeroProd.Name = "numeroProd";
            numeroProd.Size = new Size(100, 23);
            numeroProd.TabIndex = 1;
            numeroProd.KeyPress += numeroProd_KeyPress;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label111.Location = new Point(23, 19);
            label111.Name = "label111";
            label111.Size = new Size(402, 29);
            label111.TabIndex = 0;
            label111.Text = "Número de productos a registrar";
            // 
            // dtgArreglo
            // 
            dtgArreglo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgArreglo.Location = new Point(26, 285);
            dtgArreglo.Name = "dtgArreglo";
            dtgArreglo.Size = new Size(695, 307);
            dtgArreglo.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(eliminarBtn);
            panel2.Controls.Add(modBtn);
            panel2.Controls.Add(consulBtn);
            panel2.Controls.Add(insertBtn);
            panel2.Location = new Point(26, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 63);
            panel2.TabIndex = 3;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarBtn.Location = new Point(465, 13);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(117, 34);
            eliminarBtn.TabIndex = 3;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // modBtn
            // 
            modBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modBtn.Location = new Point(317, 13);
            modBtn.Name = "modBtn";
            modBtn.Size = new Size(117, 34);
            modBtn.TabIndex = 2;
            modBtn.Text = "Modificar";
            modBtn.UseVisualStyleBackColor = true;
            modBtn.Click += modBtn_Click;
            // 
            // consulBtn
            // 
            consulBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            consulBtn.Location = new Point(171, 13);
            consulBtn.Name = "consulBtn";
            consulBtn.Size = new Size(117, 34);
            consulBtn.TabIndex = 1;
            consulBtn.Text = "Consultar";
            consulBtn.UseVisualStyleBackColor = true;
            consulBtn.Click += consulBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertBtn.Location = new Point(26, 13);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(117, 34);
            insertBtn.TabIndex = 0;
            insertBtn.Text = "Insertar";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(confirmarBtn);
            panel3.Controls.Add(label88);
            panel3.Controls.Add(valorTxt);
            panel3.Location = new Point(25, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(696, 53);
            panel3.TabIndex = 4;
            // 
            // confirmarBtn
            // 
            confirmarBtn.BackColor = Color.WhiteSmoke;
            confirmarBtn.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmarBtn.Location = new Point(300, 3);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(235, 39);
            confirmarBtn.TabIndex = 2;
            confirmarBtn.Text = "Confirmar acción";
            confirmarBtn.UseVisualStyleBackColor = false;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // label88
            // 
            label88.AutoSize = true;
            label88.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label88.Location = new Point(36, 3);
            label88.Name = "label88";
            label88.Size = new Size(69, 32);
            label88.TabIndex = 1;
            label88.Text = "Valor";
            // 
            // valorTxt
            // 
            valorTxt.Location = new Point(139, 12);
            valorTxt.Name = "valorTxt";
            valorTxt.Size = new Size(100, 23);
            valorTxt.TabIndex = 3;
            valorTxt.TextChanged += valorTxt_TextChanged;
            valorTxt.KeyPress += valorTxt_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 604);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dtgArreglo);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgArreglo).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox numProd;
        private DataGridView dtgArreglo;
        private Panel panel2;
        private Button eliminarBtn;
        private Button modBtn;
        private Button consulBtn;
        private Button insertBtn;
        public Label label111;
        private TextBox numeroProd;
        private Button iniBtn;
        private Panel panel3;
        private Button confirmarBtn;
        private Label label88;
        private TextBox valorTxt;
    }
}
