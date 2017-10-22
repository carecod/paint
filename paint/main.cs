using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    class main:Form
    {
        int artis = 0,
            yukselis=0;


        public main(int with, int heigh)
          {
            SetBounds(0,0,with, heigh);
            Text = "Paint";
            Paint += Main_P;
            KeyDown += Main_KeyDown;
           


            }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue==(int)Keys.Left)
            {
                artis -= 10;
            }
            if (e.KeyValue == (int)Keys.Right)
            {
                artis += 10;
            }
            if (e.KeyValue == (int)Keys.Up)
            {
                yukselis -= 10;
            }
            if (e.KeyValue == (int)Keys.Down)
            {
                yukselis += 10;
            }

            Invalidate();
        }

        private void Main_P(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, artis, yukselis, 100, 100);
        }
    }
}
