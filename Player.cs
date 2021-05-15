using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlappyBird
{
    class Player
    {
        public int x;
        public int y;
        public Image birdImg;
        public int size;

        public Player(int x,int y)
        {
            this.x = x;
            this.y = y;
            birdImg = new Bitmap("C:\\Users\\vikap\\OneDrive\\Рабочий стол\\bird.png");
            size = 49;
        }
    }
}
