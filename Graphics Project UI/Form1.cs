using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using DevExpress.XtraEditors;

namespace Graphics_Project_UI
{
    public partial class Form1 : MaterialForm
    {

        Graphics g;
        Pen p;

        public Form1()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            setColors();
        }

        public void setColors()
        {
            List<ColorPickEdit> list = new List<ColorPickEdit>();
            list.Add(colorDDA);
            list.Add(colorBresenham);
            list.Add(colorCircle);
            list.Add(colorEllipse);

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Color = Color.DarkViolet;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            /*
             Preparing The DDA Properties
             */

            int Xs = (int) DDAXs.Value,
                Ys = (int)DDAYs.Value,
                Xe = (int)DDAXs.Value,
                Ye = (int)DDAXs.Value,
                penWidth = (int)penDDA.Value;

            Color color = colorDDA.Color;

            g = pnlDDA.CreateGraphics();

            p = new Pen(color, penWidth);


            g.DrawRectangle(p, Xs, Ys, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Add The main axis to the panels
        }
    }
}
