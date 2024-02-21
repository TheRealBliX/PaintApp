using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        bool brushTool = true, rectTool = false, ellipseTool = false, wtfTool = false, isMouseDown = false;

        static SolidBrush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(brush, 1);
        Point lastPoint;

        private void WidthPanel_ValueChanged(object sender, System.EventArgs e)
        {
            pen.Width = (float)WidthPanel.Value;
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(rectTool || ellipseTool)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bitmap;
                }
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    if(rectTool && e.Location.X > lastPoint.X && e.Location.Y > lastPoint.Y)
                    {
                        g.DrawRectangle(pen, lastPoint.X, lastPoint.Y, e.Location.X - lastPoint.X, e.Location.Y - lastPoint.Y);
                        pictureBox1.Invalidate();
                    }
                    if (ellipseTool && e.Location.X > lastPoint.X && e.Location.Y > lastPoint.Y)
                    {
                        g.DrawEllipse(pen, lastPoint.X, lastPoint.Y, e.Location.X - lastPoint.X, e.Location.Y - lastPoint.Y);
                        pictureBox1.Invalidate();
                    }
                }
                lastPoint = e.Location;
                
            }
            lastPoint = Point.Empty;
            isMouseDown = false;
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown && lastPoint != null)
            {
                if(wtfTool)
                {
                    if(pictureBox1.Image == null)
                    {
                        Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = bitmap;
                    }
                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.DrawLine(pen, lastPoint, e.Location);
                        pictureBox1.Invalidate();
                    }
                }
                if (brushTool)
                {
                    if (pictureBox1.Image == null)
                    {
                        Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = bitmap;
                    }
                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.DrawLine(pen, lastPoint, e.Location);
                        pictureBox1.Invalidate();
                    }
                    lastPoint = e.Location;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastPoint = e.Location;
        }

        public Form1()
        {
            InitializeComponent();
            ColorPanel.BackColor = pen.Color;
        }

        private void ChangeTool()
        {
            if(BrushButton.Checked)
            {
                brushTool = true;
                rectTool = ellipseTool = wtfTool = false;
            }
            else if (RectButton.Checked)
            {
                rectTool = true;
                brushTool = ellipseTool = wtfTool = false;
            }
            else if (EllipseButton.Checked)
            {
                ellipseTool = true;
                rectTool = brushTool = wtfTool = false;
            }
            else if (WTFButton.Checked)
            {
                wtfTool = true;
                rectTool = ellipseTool = brushTool = false;
            }
        }

        private void ColorButton_Click(object sender, System.EventArgs e)
        {
            ColorsGroupBox.Visible = true;
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            if (RedButton.Checked)
            {
                pen.Color = Color.Red;
                ColorPanel.BackColor = Color.Red;
            }
            if (BlueButton.Checked)
            {
                pen.Color = Color.Blue;
                ColorPanel.BackColor = Color.Blue;
            }
            if (GreenButton.Checked)
            {
                pen.Color = Color.Green;
                ColorPanel.BackColor = Color.Green;
            }
            if (BlackButton.Checked)
            {
                pen.Color = Color.Black;
                ColorPanel.BackColor = Color.Black;
            }
            ColorsGroupBox.Visible = false;
        }

        private void BrushButton_CheckedChanged(object sender, System.EventArgs e)
        {
            ChangeTool();
        }

        private void RectButton_CheckedChanged(object sender, System.EventArgs e)
        {
            ChangeTool();
        }

        private void EllipseButton_CheckedChanged(object sender, System.EventArgs e)
        {
            ChangeTool();
        }

        private void WTFButton_CheckedChanged(object sender, System.EventArgs e)
        {
            ChangeTool();
        }
    }
}
