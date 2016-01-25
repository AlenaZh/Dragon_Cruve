using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;

namespace Курсовая_работа_Кривая_дракона_
{
    public partial class Form1 : Form
    {
        Color paintcolor=Color.Black;
        bool choose = false;
        bool drawRound = false;
        float x_1 = 0, y_1 = 0,xk,yk;
        string str = "";
        int n = 1;     
        Graphics g;
        Bitmap picture;
        double dLineBasic = 50, dLine = 50;           
        float x;
        double a = Math.PI / 2;
        float y;
        double rCount;
        Pen p_1 = new Pen(Color.Black, 2);        
        Hashtable hList = new Hashtable();
        int countAngle=1;
        int dl=1;
              
        double da = Math.PI / 2;

        public Form1()
        {
            InitializeComponent();
            cmbBoxBrush.SelectedIndex = 0;
            cmbBoxDepth.SelectedIndex = 0;           
            cmbAlngle.SelectedIndex = 0;
            chList.SelectedItem = 0;       
           
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            trb.Value = 0;

            str = "1";
            if (!examOnRange(txtBox))
                return;
            n = Convert.ToInt32(txtBox.Text);
            dLineBasic = dLine;
            int t = n;
            init(ref str, t);            
            pctBox_Paint(this, null);
        }

        private void init(ref string str, int t)
        {
            if (t > 1)
            {
                string wor = str.Remove(str.Length / 2, 1);
                wor = wor.Insert(str.Length / 2, "0");
                str = String.Concat(str, "1", wor);
                wor = "";
                init(ref str, (--t));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            pctBoxColorNow.Paint += new PaintEventHandler(pctBoxColorNow_Paint);
            pctBox.Image = picture;
            
            this.DoubleBuffered = true;
            x_1 = y_1 = (pctBox.Width < pctBox.Height) ? pctBox.Height / 2 : pctBox.Height / 2;
            
        }

        private bool examOnRange(TextBox txt)
        {
            try
            {
                int d = Convert.ToInt32(txt.Text);
                if (d >= 17)
                    throw new ArgumentOutOfRangeException();

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(this, "Введенное значение должно быть меньше 17!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return false;
            }
            return true;
        }

        private void dragon(bool c)
        {         
           
            double l = dLine;
           
            foreach(int indexChecked in chList.CheckedIndices)          
            {
                x = x_1;
                y = y_1;

                a = (float)indexChecked * Math.PI / 2+rCount;
               if(c)
                lineTo(ref x, ref y, l, a,(Color)hList[indexChecked],!c,dl);
               else
                   lineTo(ref x, ref y, l, a, (Color)hList[indexChecked]);
                if (str.Length > 0)
                    for (int i = 0; i <str.Length; i++)
                    {

                        if (str[i] == '0')
                        {
                            a = a - da;
                        }
                        else
                        {
                            a = a + da;
                        }

                        if (c)
                            lineTo(ref x, ref y, l, a, (Color)hList[indexChecked], c,dl);
                        else
                            lineTo(ref x, ref y, l, a, (Color)hList[indexChecked]);
                    }                
            }
        }        

        private void lineTo(ref float x, ref float y, double l, double a, Color color)
        {
            p_1 = new Pen(color, cmbBoxDepth.SelectedIndex + 1);
            p_1.DashStyle = (DashStyle)cmbBoxBrush.SelectedIndex;
            g.DrawLine(p_1, x, y, (float)(x + l * Math.Cos(a)), (float)(y - l * Math.Sin(a)));
            x = (float)(x + l * Math.Cos(a));
            y = (float)(y - l * Math.Sin(a));

        }
        private void lineTo(ref float x, ref float y, double l, double a, Color color,bool c, int dl) 
        {
            p_1 = new Pen(color, cmbBoxDepth.SelectedIndex + 1);
            p_1.DashStyle = (DashStyle)cmbBoxBrush.SelectedIndex;

            float xm1 = (x + (float)(x + l * Math.Cos(a)) / 4) / 1.25f;
            float ym1 = (y + (float)(y - l * Math.Sin(a)) / 4) / 1.25f;

            float xm2 = (x + (float)(x + l * Math.Cos(a)) * 4) / 5;
            float ym2 = (y + (float)(y - l * Math.Sin(a)) * 4) / 5;           

           
            if (c)
                g.DrawLine(p_1, xk, yk, xm1, ym1);           
            g.DrawLine(p_1, xm1, ym1, xm2, ym2);

            xk = xm2;
            yk = ym2;

            x = (float)(x + l * Math.Cos(a));
            y = (float)(y - l * Math.Sin(a));
 
        }

        private void pctBoxColor_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
            pctBoxColorNow.Visible = true;      
        }

        private void pctBoxColor_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose)
            {
                Bitmap bmp = (Bitmap)pctBoxColor.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                pctBoxColorNow.BackColor = paintcolor;
                pctBoxColorNow.Paint += new PaintEventHandler(pctBoxColorNow_Paint);

            }
        }

        private void pctBoxColor_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;           
            pctBoxColorNow.Visible = false;
        }

        private void pctBoxColorNow_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, pctBoxColorNow.Width, pctBoxColorNow.Height);
            pctBoxColorNow.Region = new Region(shape);
        }

        private void trb_Scroll(object sender, EventArgs e)
        {
            pctBox.Image = null;
            if (trb.Value >= 0)
            {
                dLine = dLineBasic * (trb.Value + 1);                   
            }
            else
                if (trb.Value < 0)
                {
                    dLine = dLineBasic / Math.Abs(trb.Value - 1);              
                }
            pctBox_Paint(this, null);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            x_1 -= (float)numMove.Value;
            pctBox_Paint(this, null);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            x_1 += (float)numMove.Value;
            pctBox_Paint(this, null);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            y_1 += (float)numMove.Value;
            pctBox_Paint(this, null);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            y_1 -= (float)numMove.Value;
            pctBox_Paint(this, null);
        }

        private void btnZoomP_Click(object sender, EventArgs e)
        {
            trb.Value += 1;
            trb_Scroll(this, null);
        }

        private void btnZoomM_Click(object sender, EventArgs e)
        {
            trb.Value -= 1;
            trb_Scroll(this, null);
        }

        private void cmbBoxBrush_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            using (Pen p = new Pen(e.ForeColor, 2))
            {
                p.DashStyle = (DashStyle)e.Index;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(p, e.Bounds.Left, y, e.Bounds.Right, y);
            }
            e.DrawFocusRectangle();
        }

        private void cmbBoxBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            p_1.DashStyle = (DashStyle)cmbBoxBrush.SelectedIndex;
            pctBox_Paint(this, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sDialog = new SaveFileDialog();
            sDialog.FileName = "Новая кривая дракона";
            sDialog.DefaultExt = ".bmp";
            sDialog.Filter = "(.bmp)|*.bmp";

            if (sDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Save(sDialog.FileName);
            }
        }

        private void chkBoxScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxScroll.Checked)
                trb.Visible = true;
            else
                trb.Visible = false;
        }

        private void pctBox_Paint(object sender, PaintEventArgs e)
        {
            picture = new Bitmap(pctBox.Width, pctBox.Height);
           
            g = Graphics.FromImage(picture);
            g.Clear(Color.White);
            this.DoubleBuffered = true;           
            countAngle = cmbAlngle.SelectedIndex + 1;        
                    
            dragon(drawRound);
            pctBox.Image = picture;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {         
            chList.SetItemChecked(0, true);
            pctColor1.BackColor = paintcolor;
        }

        private void btnRotLeft_Click(object sender, EventArgs e)
        {
            rCount += Math.PI / countAngle;
            pctBox_Paint(this, null);
        }

        private void btnRotRight_Click(object sender, EventArgs e)
        {
            rCount -= Math.PI / countAngle;
            pctBox_Paint(this, null);
        }

        private void pctColor1_BackColorChanged(object sender, EventArgs e)
        {
            hList.Clear();

            hList.Add(0, pctColor1.BackColor);
            hList.Add(1, pctColor2.BackColor);
            hList.Add(2, pctColor3.BackColor);
            hList.Add(3, pctColor4.BackColor);
            pctBox_Paint(this, null);
        }

        private void pctColor1_Click(object sender, EventArgs e)
        {
            pctColor1.BackColor = paintcolor;
            pctBox_Paint(this, null);
        }

        private void pctColor2_Click(object sender, EventArgs e)
        {
            pctColor2.BackColor = paintcolor;
            pctBox_Paint(this, null);
        }

        private void pctColor3_Click(object sender, EventArgs e)
        {
            pctColor3.BackColor = paintcolor;
            pctBox_Paint(this, null);
        }

        private void pctColor4_Click(object sender, EventArgs e)
        {
            pctColor4.BackColor = paintcolor;
            pctBox_Paint(this, null);
        }

        private void mnuInform_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnInform_Click(object sender, EventArgs e)
        {
            Inform inform = new Inform();
            inform.ShowDialog();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            drawRound =!drawRound;
            btnRound.ImageList = imgList;
           
            if (drawRound)
            btnRound.ImageIndex = 0;
            else
                btnRound.ImageIndex = 1;                       

            pctBox_Paint(this, null);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }    

               
    }
}
