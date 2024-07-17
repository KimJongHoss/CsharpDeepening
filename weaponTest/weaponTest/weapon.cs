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

        protected virtual int[] getInfo()
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

        protected override int [] getInfo()
        {
            int[] baseInfo = base.getInfo();
            int[] info = new int[3];
            info[0] = base.getInfo()[0];
            info[1] = base.getInfo()[1];
            info[2] = bullet;
            return info;
        }
        public int CombatPoint() => getInfo()[0] * getInfo()[1] * bullet;

        public int CombatPoint(int[] info) => info[0] * info[1] * info[2];

        public int[] setCombatPoint(int attack)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = getInfo()[1];
            ints[2] = getInfo()[2];
            return ints;
        }

        public int[] setCombatPoint(int attack, int speed)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = speed;
            ints[2] = getInfo()[2];
            return ints;
        }

        public int[] setCombatPoint(int attack, int speed, int bullet)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = speed;
            ints[2] = bullet;
            return ints;
        }

    }

    public class Knife : weapon
    {
        int acuity = 5;

        protected override int[] getInfo()
        {
            int[] baseInfo = base.getInfo();
            int[] info = new int[3];
            info[0] = base.getInfo()[0];
            info[1] = base.getInfo()[1];
            info[2] = acuity;
            return info;
        }

        public int CombatPoint() => getInfo()[0] * getInfo()[1] * acuity;

        public int CombatPoint(int[] info) => info[0] * info[1] * info[2];

        
        public int[] setCombatPoint(int attack)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = getInfo()[1];
            ints[2] = getInfo()[2];
            return ints;
        }

        public int[] setCombatPoint(int attack, int speed)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = speed;
            ints[2] = getInfo()[2];
            return ints;
        }

        public int[] setCombatPoint(int attack, int speed, int acuity)
        {
            int[] ints = new int[3];
            ints[0] = attack;
            ints[1] = speed;
            ints[2] = acuity;
            return ints;
        }

    }

    

}
