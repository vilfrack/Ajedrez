using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajedrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tablero();
        }

        private void Tablero()
        {
            /*8x8*/
            bool bColor = true;
            int x = 0;
            int y = 0;
            for (int EjeY = 0; EjeY < 8; EjeY++)
            {
                for (int EjeX = 0; EjeX < 8; EjeX++)
                {
                    x = x + 82;
                    PictureBox cuadro = new PictureBox();
                    cuadro.Name = "cuadro" + EjeX + EjeY;
                    cuadro.MouseHover += new System.EventHandler(cuadro_MouseHover);
                    cuadro.Width = 80;
                    cuadro.Height = 80;
                    cuadro.Location = new Point(x, y);
                    if (bColor)
                    {
                        cuadro.BackColor = Color.White;
                        bColor = false;
                    }
                    else
                    {
                        cuadro.BackColor = Color.Black;
                        bColor = true;
                    }

                    PanelGame.Controls.Add(cuadro);
                }
                bColor = bColor == true ? false : true;

                y = y + 80;
                x = 0;
            }
        }

        private void cuadro_MouseHover(object sender, System.EventArgs e)
        {
            //obtenemos el nombre del control
            string name = ((PictureBox)sender).Name;
            MessageBox.Show(name);
        }
    }
}
