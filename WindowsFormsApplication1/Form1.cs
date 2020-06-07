using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    struct PointF3d
    {
        public PointF3d(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x;
        public float y;
        public float z;
    }
  
    public partial class Form1 : Form
    {
        Graphics g;
        PointF center;
        float Q1 ;
        float Q2;
        float[,] figure = { {  50,  0,  0,  1 },
                            {   0, 50,  0,  1 },
                            {   0,  0, 50,  1 },
                            {   0,  0,  0,  1 } };

        public Form1()
        {
            InitializeComponent();
            g = display.CreateGraphics();
            center = new PointF(display.Width / 2, display.Height / 2);
            
        }
        
        private void draw_axises()
        {
            float width = display.Width;
            float height = display.Height;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, center.X, center.Y, width, center.Y); // x axis
            g.DrawLine(pen, width, center.Y, width - 15, center.Y - 5);
            g.DrawLine(pen, width, center.Y, width - 15, center.Y + 5);
            
            g.DrawLine(pen, center.X, 10, center.X, center.Y); // y axis
            g.DrawLine(pen, center.X, 10, center.X - 5, 25);
            g.DrawLine(pen, center.X, 10, center.X + 5, 25);

            g.DrawLine(pen, center.X, center.Y, 30, height - 30);

            Font mf = new Font("Arial", 12);
            g.DrawString("x", mf, Brushes.Black, new PointF( width - 10, center.Y + 5 ));
            g.DrawString("y", mf, Brushes.Black, new PointF( center.X + 5, 15));
            g.DrawString("z", mf, Brushes.Black, new PointF(30, height - 30));
            g.DrawString("0", mf, Brushes.Black, new PointF(center.X + 10, center.Y + 10) );   
        }

        private float[,] reflect_xoy()
        {
            float[,] matr = { {1, 0,  0, 0 },
                              {0, 1,  0, 0 },
                              {0, 0, -1, 0 },
                              {0, 0,  0, 1 } };
            return matr;
        }

        private float[,] reflect_yoz()
        {
            float[,] matr = { {-1, 0,  0, 0 },
                              { 0, 1,  0, 0 },
                              { 0, 0,  1, 0 },
                              { 0, 0,  0, 1 } };
            return matr;
        }

        private float[,] reflect_zox()
        {
            float[,] matr = { {1,  0,  0, 0 },
                              {0, -1,  0, 0 },
                              {0,  0, 1, 0 },
                              {0,  0,  0, 1 } };
            return matr;
        }


        private float[,] multiply(float [,] m1, float[,] m2)
        {
            int columns = m1.GetLength(1);
            int rows    = m1.GetLength(0);

            float[,] res = new float[rows, columns];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    for (int loop = 0; loop < columns; loop++)
                        res[i, j] += m1[i, loop] * m2[loop, j];
                }

            return res;
        }

        private void draw_figure()
        {
            Pen pen = new Pen(Color.Red, 2);
                            
            //              [                 X                      ], [                  Y                     ]    [                  X                     ]  [                    Y                    ]
            g.DrawLine(pen, center.X + figure[0, 0] - figure[0, 2] / 2, center.Y - figure[0, 1] + figure[0, 2] / 2,   center.X + figure[1, 0] - figure[1, 2] / 2, center.Y - figure[1, 1] + figure[1, 2] / 2);
            g.DrawLine(pen, center.X + figure[1, 0] - figure[1, 2] / 2, center.Y - figure[1, 1] + figure[1, 2] / 2,   center.X + figure[2, 0] - figure[2, 2] / 2, center.Y - figure[2, 1] + figure[2, 2] / 2);
            g.DrawLine(pen, center.X + figure[2, 0] - figure[2, 2] / 2, center.Y - figure[2, 1] + figure[2, 2] / 2,   center.X + figure[0, 0] - figure[0, 2] / 2, center.Y - figure[0, 1] + figure[0, 2] / 2);
            g.DrawLine(pen, center.X + figure[0, 0] - figure[0, 2] / 2, center.Y - figure[0, 1] + figure[0, 2] / 2,   center.X + figure[3, 0] - figure[3, 2] / 2, center.Y - figure[3, 1] + figure[3, 2] / 2);
            g.DrawLine(pen, center.X + figure[1, 0] - figure[1, 2] / 2, center.Y - figure[1, 1] + figure[1, 2] / 2,   center.X + figure[3, 0] - figure[3, 2] / 2, center.Y - figure[3, 1] + figure[3, 2] / 2);
            g.DrawLine(pen, center.X + figure[2, 0] - figure[2, 2] / 2, center.Y - figure[2, 1] + figure[2, 2] / 2,   center.X + figure[3, 0] - figure[3, 2] / 2, center.Y - figure[3, 1] + figure[3, 2] / 2);
        }


        private void btn_reflect_zox_Click(object sender, EventArgs e)
        {
            Refresh();
            draw_axises();
            var ref_matr = reflect_zox();
            this.figure = this.multiply(figure, ref_matr);
            draw_figure();
        }

        private void btn_reflect_xoy_Click(object sender, EventArgs e)
        {
            Refresh();
            draw_axises();
            var ref_matr = reflect_xoy();
            this.figure = this.multiply(figure, ref_matr);
            draw_figure();
        }

        private void btn_reflect_yoz_Click(object sender, EventArgs e)
        {
            Refresh();
            draw_axises();
            var ref_matr = reflect_yoz();
            this.figure = this.multiply(figure, ref_matr);
            draw_figure();
        }

        private float[,] reflect_vrash()
        {
            float[,] matr = { { 1, 0,  0, 0 },
                              {0, (float)Math.Cos( Q2* Math.PI / 180),  (float)Math.Sin( Q2*Math.PI / 180), 0 },
                              {0, (float)-Math.Sin( Q2*Math.PI / 180), (float)Math.Cos( Q2* Math.PI / 180), 0 },
                              {0, 0,  0, 1 } };
            return matr;

        }
        private void trackBar1_Scroll(object sender, EventArgs e) //по иксу
        {
            Refresh();
            draw_axises();
            Q2 = 0;
            Q2 = trackBar1.Value;
            Edit2.Text = Q2.ToString();
            var ref_matr = reflect_vrash();
            this.figure = this.multiply(figure, ref_matr);
            draw_figure();
        }
        private float[,] reflect_vresh()
        {
            float[,] matr = { { (float)Math.Cos(Q1* Math.PI / 180), 0,  (float)-Math.Sin( Q1 * Math.PI / 180), 0 },
                              {0, 1,  0, 0 },
                              {(float)Math.Sin( Q1*Math.PI / 180), 0, (float)Math.Cos( Q1* Math.PI / 180), 0 },
                              {0, 0,  0, 1 } };
            return matr;
          
        }

        private void redraw(float[,] matr)
        {
            Pen pen = new Pen(Color.BlueViolet, 2);

            //              [                 X                      ], [                  Y                     ]    [                  X                     ]  [                    Y                    ]
            g.DrawLine(pen, center.X + matr[0, 0] - matr[0, 2] / 2, center.Y - matr[0, 1] + matr[0, 2] / 2, center.X + matr[1, 0] - matr[1, 2] / 2, center.Y - matr[1, 1] + matr[1, 2] / 2);
            g.DrawLine(pen, center.X + matr[1, 0] - matr[1, 2] / 2, center.Y - matr[1, 1] + matr[1, 2] / 2, center.X + matr[2, 0] - matr[2, 2] / 2, center.Y - matr[2, 1] + matr[2, 2] / 2);
            g.DrawLine(pen, center.X + matr[2, 0] - matr[2, 2] / 2, center.Y - matr[2, 1] + matr[2, 2] / 2, center.X + matr[0, 0] - matr[0, 2] / 2, center.Y - matr[0, 1] + matr[0, 2] / 2);
            g.DrawLine(pen, center.X + matr[0, 0] - matr[0, 2] / 2, center.Y - matr[0, 1] + matr[0, 2] / 2, center.X + matr[3, 0] - matr[3, 2] / 2, center.Y - matr[3, 1] + matr[3, 2] / 2);
            g.DrawLine(pen, center.X + matr[1, 0] - matr[1, 2] / 2, center.Y - matr[1, 1] + matr[1, 2] / 2, center.X + matr[3, 0] - matr[3, 2] / 2, center.Y - matr[3, 1] + matr[3, 2] / 2);
            g.DrawLine(pen, center.X + matr[2, 0] - matr[2, 2] / 2, center.Y - matr[2, 1] + matr[2, 2] / 2, center.X + matr[3, 0] - matr[3, 2] / 2, center.Y - matr[3, 1] + matr[3, 2] / 2);
        }
        private void trackBar2_Scroll(object sender, EventArgs e) //по игрику
        {
            Refresh();
            draw_axises();
            Q1 = 0;
            Q1 = trackBar2.Value;
            Edit1.Text = Q1.ToString();
            var ref_matr = reflect_vresh();
            this.figure = this.multiply(figure, ref_matr);
            draw_figure();
        }

        private float[,] projection_trimetry(float alpha, float beta)
        {
            float cos_beta  = (float)Math.Cos(beta);
            float sin_beta  = (float)Math.Sin(beta);
            float cos_alpha = (float)Math.Cos(alpha);
            float sin_alpha = (float)Math.Sin(alpha);
            float[,] matr = { { cos_beta,  sin_alpha * sin_beta, 0, 0},
                              {        0,             cos_alpha, 0, 0},
                              { sin_beta, -sin_alpha * cos_beta, 0, 0},
                              {        0,                     0, 0, 1 } };
            return matr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float angle_x = float.Parse(Edit1.Text);
            float angle_y = float.Parse(Edit2.Text);
            var ref_matr = projection_trimetry(angle_x, angle_y);
            ref_matr = this.multiply(figure, ref_matr);
            redraw(ref_matr);
        }

    }
}
