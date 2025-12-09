using System.ComponentModel;

namespace Temp;

partial class frmPrincipal
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
        btnAcceder = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // btnAcceder
        // 
        btnAcceder.Location = new System.Drawing.Point(472, 302);
        btnAcceder.Name = "btnAcceder";
        btnAcceder.Size = new System.Drawing.Size(119, 63);
        btnAcceder.TabIndex = 0;
        btnAcceder.Text = "Acceder";
        btnAcceder.UseVisualStyleBackColor = true;
        btnAcceder.Click += btnAcceder_Click;
        // 
        // btnSalir
        // 
        btnSalir.Location = new System.Drawing.Point(623, 302);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(112, 63);
        btnSalir.TabIndex = 1;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(337, 40);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(368, 35);
        label1.TabIndex = 2;
        label1.Text = "UNIVERSIDAD TECNOLÓGICA DE SAN JUAN DEL RÍO";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.ImageLocation = "C:\\Users\\ALUMNOS\\Downloads\\Logo_UTSJR_new.gif";
        pictureBox1.Location = new System.Drawing.Point(12, 19);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(500, 200);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(339, 75);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(170, 44);
        label2.TabIndex = 4;
        label2.Text = "ESTRUCURA DE DATOS";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(339, 109);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(366, 39);
        label3.TabIndex = 5;
        label3.Text = "Aplicación de arreglo unidimensional";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(337, 148);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(390, 54);
        label4.TabIndex = 6;
        label4.Text = "DS02SM-24 ROMERO RODRÍGUEZ URIEL AUGUSTO";
        label4.Click += label4_Click;
        // 
        // frmPrincipal
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(pictureBox1);
        Controls.Add(btnSalir);
        Controls.Add(btnAcceder);
        Text = "frmPrincipal";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button btnAcceder;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}