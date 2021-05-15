using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class The_Wall
    {
        public int x;
        public int y;
        public Image wallImg;
        public int sizeX;
        public int sizeY;

        public The_Wall(int x, int y)
        {
            wallImg = new Bitmap("C:\\Users\\vikap\\OneDrive\\Рабочий стол\\tube.png");
            this.x = x;
            this.y = y;
            sizeX = 49;
            sizeY = 250;
        }
    }
}
