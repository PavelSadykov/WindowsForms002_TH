
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WindowsForms002_TH
{
    public partial class Form1 : Form
    {
        private Point rectangleStartPoint;
        private List<Rectangle> rectangles = new List<Rectangle>();
        private List<string> names = new List<string>();

        private bool isDrawing = false;
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.Paint += pictureBox1_Paint;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rectangleStartPoint = e.Location;
                pictureBox1.MouseMove += pictureBox1_MouseMoveForRectangle;
                pictureBox1.MouseUp += pictureBox1_MouseUpForRectangle;

            }

        }
        private void pictureBox1_MouseMoveForRectangle(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            using (Graphics g = pictureBox1.CreateGraphics())
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                int x = Math.Min(rectangleStartPoint.X, e.X);
                int y = Math.Min(rectangleStartPoint.Y, e.Y);
                int width = Math.Abs(e.X - rectangleStartPoint.X);
                int height = Math.Abs(e.Y - rectangleStartPoint.Y);

                // Проверяем, чтобы прямоугольник не выходил за границы изображения
                x = Math.Max(x, 0);
                y = Math.Max(y, 0);
                width = Math.Min(width, pictureBox1.Width - x);
                height = Math.Min(height, pictureBox1.Height - y);

                Rectangle rect = new Rectangle(x, y, width, height);

                g.DrawRectangle(pen, rect);
            }
        }
        private void pictureBox1_MouseUpForRectangle(object sender, MouseEventArgs e)
        {
            pictureBox1.MouseMove -= pictureBox1_MouseMoveForRectangle;
            pictureBox1.MouseUp -= pictureBox1_MouseUpForRectangle;

            Rectangle rect = new Rectangle(
                Math.Min(rectangleStartPoint.X, e.X),
                Math.Min(rectangleStartPoint.Y, e.Y),
                Math.Abs(e.X - rectangleStartPoint.X),
                Math.Abs(e.Y - rectangleStartPoint.Y));

            rectangles.Add(rect);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                foreach (var rect in rectangles)
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        public object Interaction { get; private set; }


        private void Save_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine("Name,RectangleX,RectangleY,RectangleWidth,RectangleHeight");

                        for (int i = 0; i < rectangles.Count; i++)
                        {
                            Rectangle rect = rectangles[i];
                            string name = names[i];
                            writer.WriteLine($"{name},{rect.X},{rect.Y},{rect.Width},{rect.Height}");
                        }
                    }
                }
            }
        }


        private void inputNametextBox_TextChanged(object sender, EventArgs e)
        {
            string name = inputNametextBox.Text;
            if (rectangles.Count > 0 && names.Count < rectangles.Count)
            {
                names.Add(name);
                inputNametextBox.Clear();
            }
        }

        //кнопка загрузки картинки
        private void downLoadPicture_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                    rectangles.Clear();
                    names.Clear();
                    inputNametextBox.Clear();

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            pictureBox1.MouseClick -= pictureBox1_Click;

            rectangleStartPoint = Cursor.Position;


            pictureBox1.MouseUp += pictureBox1_MouseUpForRectangle;
        }

        
    }
}