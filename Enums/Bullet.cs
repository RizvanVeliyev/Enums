using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Bullet
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public BulletType Type { get; private set; }

        public Bullet(BulletType type)
        {
            Id = _id++;
            Type = type;
        }

        public override string ToString()
        {
            return $"Bullet ID: {Id}, Type: {Type}";
        }
    }
}
