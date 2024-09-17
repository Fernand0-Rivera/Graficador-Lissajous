using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;
namespace Lissajous{
    internal class Graficas{
        private double xi, xf;
        private int n;
        private double[] x;
        private double[] y;

        public Graficas(int n){
            this.n = n;
            x = new double[n];
            y = new double[n];
        }
        public double[] X{
            set { x = value; }
            get { return x; }
        }
        public double[] Y{
            set { y = value; }
            get { return y; }
        }

        public double fu(double x, string fx){
            double r;
            ExpressionParser P1 = new ExpressionParser();
            r = Math.Cos(x);
            P1.Values.Add("x", x);
            r = P1.Parse(fx);
            return r;
        }
        public void Graficador(double xi, double xf, string fx){
            double h;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++){
                X[k] = xi + k * h;
                Y[k] = fu(X[k], fx);
            }
        }

        public void GrafPolar(double xi, double xf, string ga){
            double h, ang, r;
            string g;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++){
                ang = xi + k * h;
                r = fu(ang, ga);
                X[k] = r * Math.Cos(ang);
                Y[k] = r * Math.Sin(ang);
            }
        }
        public void GrafParam(double xi, double xf, string ft, string gt){
            double h, t;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++){
                t = xi + k * h;
                X[k] = fu(t, ft);
                Y[k] = fu(t, gt);
            }
        }
        public void GrafLissajous(double xi, double xf, double fw1, double fw2, double Am, double fa) {
            double h, t1, t2;
            h = (xf - xi) / n; 
            for(int k = 0;k < n; k++){
                t1 = (xi + k * h) * fw1;
                t2 = (xi + k * h) * fw2 + fa;
                X[k] = Am * Math.Cos(t1);
                Y[k] = Am * Math.Cos(t2);
            }
        }
    }
}
