using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weaponTest
{
    public class weapon
    {
        int attack;//공격력
        int attack_speed;//공격속도

        protected weapon()//생성자
        {
            attack = 5;
            attack_speed = 10;
        }

        protected int[] getInfo()
        {
            int[] info = new int[2];
            info[0] = attack;
            info[1] = attack_speed;
            return info;
        }
    }

    public class Rifle : weapon
    {
        int bullet = 10;
        
        public int CombatPoint() => getInfo()[0] * getInfo()[1] * bullet;
        
    }

    public class Knife : weapon
    {
        int acuity = 5;
        public int CombatPoint() => getInfo()[0] * getInfo()[1] * acuity;

    }

}
