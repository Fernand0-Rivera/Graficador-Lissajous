namespace Lissajous
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Amplitud = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrafPar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Btpolar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btgraficar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lBsalida = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBfx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBxf = new System.Windows.Forms.TextBox();
            this.tBxi = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnLissajous = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Fase = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBA = new System.Windows.Forms.TextBox();
            this.tBw1 = new System.Windows.Forms.TextBox();
            this.tBw2 = new System.Windows.Forms.TextBox();
            this.tBf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Amplitud
            // 
            this.Amplitud.AutoSize = true;
            this.Amplitud.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amplitud.Location = new System.Drawing.Point(18, 215);
            this.Amplitud.Name = "Amplitud";
            this.Amplitud.Size = new System.Drawing.Size(20, 19);
            this.Amplitud.TabIndex = 8;
            this.Amplitud.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLissajous);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GrafPar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Btpolar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Btgraficar);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(172, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 337);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // GrafPar
            // 
            this.GrafPar.Location = new System.Drawing.Point(9, 224);
            this.GrafPar.Name = "GrafPar";
            this.GrafPar.Size = new System.Drawing.Size(82, 26);
            this.GrafPar.TabIndex = 14;
            this.GrafPar.Text = "Graficar";
            this.GrafPar.UseVisualStyleBackColor = true;
            this.GrafPar.Click += new System.EventHandler(this.GrafPar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Grafica \r\nparametrica";
            // 
            // Btpolar
            // 
            this.Btpolar.Location = new System.Drawing.Point(10, 155);
            this.Btpolar.Name = "Btpolar";
            this.Btpolar.Size = new System.Drawing.Size(82, 26);
            this.Btpolar.TabIndex = 12;
            this.Btpolar.Text = "Graficar";
            this.Btpolar.UseVisualStyleBackColor = true;
            this.Btpolar.Click += new System.EventHandler(this.Btpolar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Graficar f(x)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Graficar g(θ)";
            // 
            // Btgraficar
            // 
            this.Btgraficar.Location = new System.Drawing.Point(9, 92);
            this.Btgraficar.Name = "Btgraficar";
            this.Btgraficar.Size = new System.Drawing.Size(82, 26);
            this.Btgraficar.TabIndex = 0;
            this.Btgraficar.Text = "Graficar";
            this.Btgraficar.UseVisualStyleBackColor = true;
            this.Btgraficar.Click += new System.EventHandler(this.Btgraficar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.lBsalida);
            this.groupBox3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(280, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 337);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // lBsalida
            // 
            this.lBsalida.FormattingEnabled = true;
            this.lBsalida.ItemHeight = 19;
            this.lBsalida.Location = new System.Drawing.Point(22, 26);
            this.lBsalida.Name = "lBsalida";
            this.lBsalida.Size = new System.Drawing.Size(235, 289);
            this.lBsalida.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBf);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tBw2);
            this.groupBox1.Controls.Add(this.tBw1);
            this.groupBox1.Controls.Add(this.tBA);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Fase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Amplitud);
            this.groupBox1.Controls.Add(this.tBfx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBxf);
            this.groupBox1.Controls.Add(this.tBxi);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 337);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "g(θ)";
            // 
            // tBga
            // 
            this.tBga.Location = new System.Drawing.Point(48, 173);
            this.tBga.Name = "tBga";
            this.tBga.Size = new System.Drawing.Size(100, 27);
            this.tBga.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "f(x)";
            // 
            // tBfx
            // 
            this.tBfx.Location = new System.Drawing.Point(48, 130);
            this.tBfx.Name = "tBfx";
            this.tBfx.Size = new System.Drawing.Size(100, 27);
            this.tBfx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "xf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "xi";
            // 
            // tBxf
            // 
            this.tBxf.Location = new System.Drawing.Point(48, 87);
            this.tBxf.Name = "tBxf";
            this.tBxf.Size = new System.Drawing.Size(100, 27);
            this.tBxf.TabIndex = 1;
            // 
            // tBxi
            // 
            this.tBxi.Location = new System.Drawing.Point(48, 46);
            this.tBxi.Name = "tBxi";
            this.tBxi.Size = new System.Drawing.Size(100, 27);
            this.tBxi.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menú";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.SpringGreen;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(263, 26);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 289);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // BtnLissajous
            // 
            this.BtnLissajous.Location = new System.Drawing.Point(7, 282);
            this.BtnLissajous.Name = "BtnLissajous";
            this.BtnLissajous.Size = new System.Drawing.Size(82, 26);
            this.BtnLissajous.TabIndex = 16;
            this.BtnLissajous.Text = "Graficar";
            this.BtnLissajous.UseVisualStyleBackColor = true;
            this.BtnLissajous.Click += new System.EventHandler(this.BtnLissajous_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lissajous";
            // 
            // Fase
            // 
            this.Fase.AutoSize = true;
            this.Fase.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fase.Location = new System.Drawing.Point(14, 248);
            this.Fase.Name = "Fase";
            this.Fase.Size = new System.Drawing.Size(31, 19);
            this.Fase.TabIndex = 11;
            this.Fase.Text = "W1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "W2";
            // 
            // tBA
            // 
            this.tBA.Location = new System.Drawing.Point(48, 212);
            this.tBA.Name = "tBA";
            this.tBA.Size = new System.Drawing.Size(100, 27);
            this.tBA.TabIndex = 14;
            // 
            // tBw1
            // 
            this.tBw1.Location = new System.Drawing.Point(48, 248);
            this.tBw1.Name = "tBw1";
            this.tBw1.Size = new System.Drawing.Size(100, 27);
            this.tBw1.TabIndex = 15;
            // 
            // tBw2
            // 
            this.tBw2.Location = new System.Drawing.Point(48, 283);
            this.tBw2.Name = "tBw2";
            this.tBw2.Size = new System.Drawing.Size(100, 27);
            this.tBw2.TabIndex = 16;
            // 
            // tBf
            // 
            this.tBf.Location = new System.Drawing.Point(48, 316);
            this.tBf.Name = "tBf";
            this.tBf.Size = new System.Drawing.Size(100, 27);
            this.tBf.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "f";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Amplitud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GrafPar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btpolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btgraficar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lBsalida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBfx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBxf;
        private System.Windows.Forms.TextBox tBxi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BtnLissajous;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Fase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBw2;
        private System.Windows.Forms.TextBox tBw1;
        private System.Windows.Forms.TextBox tBA;
        private System.Windows.Forms.TextBox tBf;
        private System.Windows.Forms.Label label10;
    }
}

