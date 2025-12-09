using System.ComponentModel;

namespace SensorSubmarino;

partial class frmOperaciones
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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        menuStrip2 = new System.Windows.Forms.MenuStrip();
        menuStrip3 = new System.Windows.Forms.MenuStrip();
        menuStrip4 = new System.Windows.Forms.MenuStrip();
        aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        sensorDeTemperaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        button1 = new System.Windows.Forms.Button();
        arregloUnidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        arregloBidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip4.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Location = new System.Drawing.Point(0, 76);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // menuStrip2
        // 
        menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip2.Location = new System.Drawing.Point(0, 52);
        menuStrip2.Name = "menuStrip2";
        menuStrip2.Size = new System.Drawing.Size(800, 24);
        menuStrip2.TabIndex = 1;
        menuStrip2.Text = "menuStrip2";
        // 
        // menuStrip3
        // 
        menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip3.Location = new System.Drawing.Point(0, 28);
        menuStrip3.Name = "menuStrip3";
        menuStrip3.Size = new System.Drawing.Size(800, 24);
        menuStrip3.TabIndex = 2;
        menuStrip3.Text = "Aplicaciones";
        // 
        // menuStrip4
        // 
        menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { aplicacionesToolStripMenuItem });
        menuStrip4.Location = new System.Drawing.Point(0, 0);
        menuStrip4.Name = "menuStrip4";
        menuStrip4.Size = new System.Drawing.Size(800, 28);
        menuStrip4.TabIndex = 3;
        menuStrip4.Text = "menuStrip4";
        // 
        // aplicacionesToolStripMenuItem
        // 
        aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { operacionesToolStripMenuItem, sensorDeTemperaturasToolStripMenuItem });
        aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
        aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
        aplicacionesToolStripMenuItem.Text = "Aplicaciones";
        // 
        // operacionesToolStripMenuItem
        // 
        operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { arregloUnidimensionalToolStripMenuItem, arregloBidimensionalToolStripMenuItem });
        operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
        operacionesToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
        operacionesToolStripMenuItem.Text = "Operaciones";
        operacionesToolStripMenuItem.Click += operacionesToolStripMenuItem_Click;
        // 
        // sensorDeTemperaturasToolStripMenuItem
        // 
        sensorDeTemperaturasToolStripMenuItem.Name = "sensorDeTemperaturasToolStripMenuItem";
        sensorDeTemperaturasToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
        sensorDeTemperaturasToolStripMenuItem.Text = "Sensor de temperaturas";
        sensorDeTemperaturasToolStripMenuItem.Click += sensorDeTemperaturasToolStripMenuItem_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(592, 356);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(166, 49);
        button1.TabIndex = 4;
        button1.Text = "Salir";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // arregloUnidimensionalToolStripMenuItem
        // 
        arregloUnidimensionalToolStripMenuItem.Name = "arregloUnidimensionalToolStripMenuItem";
        arregloUnidimensionalToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
        arregloUnidimensionalToolStripMenuItem.Text = "Arreglo Unidimensional";
        arregloUnidimensionalToolStripMenuItem.Click += arregloUnidimensionalToolStripMenuItem_Click;
        // 
        // arregloBidimensionalToolStripMenuItem
        // 
        arregloBidimensionalToolStripMenuItem.Name = "arregloBidimensionalToolStripMenuItem";
        arregloBidimensionalToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
        arregloBidimensionalToolStripMenuItem.Text = "Arreglo Bidimensional";
        arregloBidimensionalToolStripMenuItem.Click += arregloBidimensionalToolStripMenuItem_Click;
        // 
        // frmOperaciones
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button1);
        Controls.Add(menuStrip1);
        Controls.Add(menuStrip2);
        Controls.Add(menuStrip3);
        Controls.Add(menuStrip4);
        MainMenuStrip = menuStrip1;
        Text = "frmOperaciones";
        menuStrip4.ResumeLayout(false);
        menuStrip4.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem arregloUnidimensionalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem arregloBidimensionalToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip4;
    private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sensorDeTemperaturasToolStripMenuItem;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.MenuStrip menuStrip3;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.MenuStrip menuStrip2;

    #endregion
}