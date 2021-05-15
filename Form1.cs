using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        Player bird;
        The_Wall wall1;
        The_Wall wall2;
        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
        }

        public void Init()
        {
            bird = new Player(200, 200);
            wall1 = new The_Wall(500, -100);
            wall2 = new The_Wall(500, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(bird.birdImg, bird.x, bird.y, bird.size, bird.size);

            wall1.wallImg.RotateFlip(RotateFlipType.Rotate180FlipX);
            graphics.DrawImage(wall1.wallImg, wall1.x, wall1.y, wall1.sizeX, wall1.sizeY);

            wall1.wallImg.RotateFlip(RotateFlipType.Rotate180FlipNone);
            graphics.DrawImage(wall2.wallImg, wall2.x, wall2.y, wall2.sizeX, wall2.sizeY);
        }
    }
}
