using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
namespace Lissajous{
    public partial class Form1 : Form{
        double xi, xf, A, W;
        int n;
        string fx, g;
        public Form1(){
            InitializeComponent();
            n = chart1.Width;
        }
        private void firmaToolStripMenuItem_Click(object sender, EventArgs e) =>  System.Diagnostics.Process.Start("Firma_2.exe");
        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void GrafPar_Click(object sender, EventArgs e){
            Graficas grpar = new Graficas(n);
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            fx = tBfx.Text;
            g = tBga.Text;
            grpar.GrafParam(xi, xf, fx, g);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(grpar.X[k], grpar.Y[k]);
                lBsalida.Items.Add(grpar.X[k] + "\t\t" + grpar.Y[k]);
            }
        }

        private void BtnLissajous_Click(object sender, EventArgs e){
            double xi, xf, w1, w2, A, f;
            w1 = double.Parse(tBw1.Text);
            w2 = double.Parse(tBw2.Text);
            A =  double.Parse(tBA.Text); 
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            f = double.Parse(tBf.Text);
            Graficas grlis = new Graficas(n);
            grlis.GrafLissajous(xi, xf, w1, w2, A,f);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(grlis.X[k], grlis.Y[k]);
                lBsalida.Items.Add(grlis.X[k] + "\t\t" + grlis.Y[k]);
            }
        }

        private void Btpolar_Click(object sender, EventArgs e){
            string ga;
            double xi, xf;
            Graficas grp1 = new Graficas(n);
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            ga = tBga.Text;
            grp1.GrafPolar(xi, xf, ga);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(grp1.X[k], grp1.Y[k]);
                lBsalida.Items.Add(grp1.X[k] + "\t\t" + grp1.Y[k]);
            }
        }
        private void Btgraficar_Click(object sender, EventArgs e){
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);
            fx = tBfx.Text;
            Graficas gr1 = new Graficas(n);
            gr1.Graficador(xi, xf, fx);
            chart1.Series["Series1"].Points.Clear();
            lBsalida.Items.Clear();
            for (int k = 0; k < n; k++){
                chart1.Series["Series1"].Points.AddXY(gr1.X[k], gr1.Y[k]);
                lBsalida.Items.Add(gr1.X[k] + "\t\t" + gr1.Y[k]);
            }
        }
        

    }
}
