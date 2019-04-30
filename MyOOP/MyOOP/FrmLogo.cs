using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOOP
{
    public partial class FrmLogo : Form
    {

        protected string Title
        {
            set
            {
                this.label1.Text = value ;
            }
        }

        public FrmLogo()
        {
            InitializeComponent();
            this.Paint += FrmLogo_Paint;
            this.Resize += FrmLogo_Resize;
            this.color1 = Color.Black;
            this.color2 = Color.Blue;
        }

        private void FrmLogo_Resize(object sender, EventArgs e)
        {
            this.Invalidate();//畫面重繪
        }
        private Color M_color2;
        public Color color1 { get; set; }
        public Color color2
        {
            get
            {
                return M_color2;
            }
            set
            {
                this.M_color2 = value;
                this.Invalidate();
            }
        }
        private void FrmLogo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;//畫布
            Point p1 = new Point(0, 0);//起始點
            Point p2 = new Point(ClientRectangle.Width, ClientRectangle.Height);//終點
            LinearGradientBrush brush = new LinearGradientBrush(p1, p2, this.color1, this.color2);//筆刷
            g.FillRectangle(brush, ClientRectangle);//繪圖
        }
    }
}
