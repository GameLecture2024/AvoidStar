using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidStar
{
    class EnemyStar
    {
        public int posX;
        public int posY;
        public bool isAlive;

        public EnemyStar() { }
        public EnemyStar(int posX, int posY, bool isAlive)
        {
            this.posX = posX;
            this.posY = posY;
            this.isAlive = isAlive;
        }
    }
}
