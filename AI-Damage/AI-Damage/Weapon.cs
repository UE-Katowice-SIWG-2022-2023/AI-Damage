using System;
using System.Collections.Generic;
using System.Text;

namespace AI_Damage
{
    public class Weapon
    {
        public Weapon(string name, weaponType type, short min, short max, float penetration)
        {
            this.name = name;
            this.type = type;
            this.minDmg = min;
            this.maxDmg = max;
            this.penetration = penetration;
        }

        public string name;
        public weaponType type;

        public short minDmg;
        public short maxDmg;
        public float penetration;
    }
    public enum weaponType
    {
        Hitscan,
        Projectile,
        Aoe
    }
    public static class Penetration
    {
        public const float small = 0.2f;
        public const float medium = 0.5f;
        public const float big = 0.9f;
    }
}
