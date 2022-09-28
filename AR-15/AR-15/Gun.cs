using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_15
{
    internal class Gun
    {
        private int bulletsInStock = 8;
        private int bulletsInMag = 2;
        
        public void GunShot ()
        {
            if (bulletsInMag != 0 )
            {
                Console.WriteLine("Shot succesefully");
                bulletsInMag--;
            }
            else
            {
                Reload();
            }
        }
        public void Reload()
        {
            if (bulletsInMag == 0)
            {
                if (bulletsInStock >=3)
                {
                    bulletsInStock -= 3;
                    bulletsInMag += 3;
                    Console.WriteLine("Magazine is Fullly Reloaded!");
                }
                else if (bulletsInStock == 2)
                {
                    bulletsInStock -= 2;
                    bulletsInMag += 2;
                    Console.WriteLine("Magazine is Partially Reloaded!");
                }
                else if (bulletsInStock ==1)
                {
                    bulletsInStock -= 1;
                    bulletsInMag += 1;
                    Console.WriteLine("Magazine is Partially Reloaded!");
                }
                else
                {
                    Console.WriteLine("UOT of AMMO!");
                }
            }
            else if (bulletsInMag == 1)
            {
                if (bulletsInStock == 2)
                {
                    bulletsInStock -= 2;
                    bulletsInMag += 2;
                    Console.WriteLine("Magazine is Partially Reloaded!");
                }
                else if (bulletsInStock == 1)
                {
                    bulletsInStock -= 1;
                    bulletsInMag += 1;
                    Console.WriteLine("Magazine is Partially Reloaded!");
                }
                else
                {
                    Console.WriteLine("UOT of AMMO!");
                }
            }
            else if (bulletsInMag == 2)
            {
                if (bulletsInStock == 1)
                {
                    bulletsInStock -= 1;
                    bulletsInMag += 1;
                    Console.WriteLine("Magazine is Partially Reloaded!");
                }
                else
                {
                    Console.WriteLine("UOT of AMMO! Can't be Fully Loaded!");
                }
            }
            else
            {
                Console.WriteLine("Magazine is FULL! You may shoot!");
            }
        }
    }
}
