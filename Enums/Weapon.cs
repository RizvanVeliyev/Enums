using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Weapon
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public BulletType BulletType { get; private set; }
        public int Capacity { get; private set; }
        private Queue<Bullet> _magazine;

        public Weapon(BulletType bulletType, int capacity)
        {
            Id = _id++;
            BulletType = bulletType;
            Capacity = capacity;
            _magazine = new Queue<Bullet>(capacity);
        }

        public void Fill()
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (_magazine.Count < Capacity)
                {
                    _magazine.Enqueue(new Bullet(BulletType));
                }
            }
        }

        public void Fire()
        {
            if (_magazine.Count > 0)
            {
                Bullet firedBullet = _magazine.Dequeue();
                Console.WriteLine($"Fired {firedBullet}. Bullets count: {_magazine.Count}");
            }
            else
            {
                Console.WriteLine("Dont have bullets!");
            }
        }

        public void PullTrigger()
        {
            if (_magazine.Count > 0)
            {
                Bullet nextBullet = _magazine.Peek();
                Console.WriteLine($"you can fire this bullet: {nextBullet}");
            }
            else
            {
                Console.WriteLine("No bullets in the next.");
            }
        }
    }

    
}
