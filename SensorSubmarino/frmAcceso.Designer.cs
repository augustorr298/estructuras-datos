using System.ComponentModel;

namespace SensorSubmarino;

partial class frmAcceso
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
        panel1 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        lblNota = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label3 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        txtContra = new System.Windows.Forms.MaskedTextBox();
        txtUsuario = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.Highlight;
        panel1.Controls.Add(label2);
        panel1.Location = new System.Drawing.Point(28, 20);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(791, 170);
        panel1.TabIndex = 0;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.HighlightText;
        label2.Location = new System.Drawing.Point(135, 25);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(488, 123);
        label2.TabIndex = 0;
        label2.Text = "ACCESO";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        panel2.Controls.Add(lblNota);
        panel2.Controls.Add(pictureBox1);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(txtContra);
        panel2.Controls.Add(txtUsuario);
        panel2.Location = new System.Drawing.Point(221, 196);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(430, 405);
        panel2.TabIndex = 1;
        // 
        // lblNota
        // 
        lblNota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        lblNota.ForeColor = System.Drawing.Color.DimGray;
        lblNota.Location = new System.Drawing.Point(44, 340);
        lblNota.Name = "lblNota";
        lblNota.Size = new System.Drawing.Size(330, 50);
        lblNota.TabIndex = 5;
        lblNota.Text = "Nota: Puede acceder con cualquier usuario y contraseña no vacíos.";
        lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(102, 25);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(230, 192);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(44, 293);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(114, 28);
        label3.TabIndex = 3;
        label3.Text = "Contraseña";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(44, 249);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(118, 21);
        label1.TabIndex = 2;
        label1.Text = "Usuario";
        // 
        // txtContra
        // 
        txtContra.Location = new System.Drawing.Point(176, 290);
        txtContra.Name = "txtContra";
        txtContra.Size = new System.Drawing.Size(194, 27);
        txtContra.TabIndex = 1;
        // 
        // txtUsuario
        // 
        txtUsuario.Location = new System.Drawing.Point(176, 249);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new System.Drawing.Size(197, 27);
        txtUsuario.TabIndex = 0;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(251, 640);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(168, 45);
        button1.TabIndex = 2;
        button1.Text = "Acceder";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button2.Location = new System.Drawing.Point(461, 639);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(175, 46);
        button2.TabIndex = 3;
        button2.Text = "Salir";
        button2.UseVisualStyleBackColor = false;
        // 
        // frmAcceso
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(832, 734);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Text = "frmAcceso";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.MaskedTextBox txtContra;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblNota;
    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}