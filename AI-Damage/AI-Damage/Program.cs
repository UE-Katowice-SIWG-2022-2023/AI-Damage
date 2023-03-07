using System;

namespace AI_Damage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Popraw damage
            //Hitscans
            Weapon karabin = new Weapon("Karabin", weaponType.Hitscan, 0, 0, Penetration.small);
            Weapon dzialko = new Weapon("Działko", weaponType.Hitscan, 0, 0, Penetration.medium);

            //Projectiles
            Weapon fleszetka = new Weapon("Fleszetka", weaponType.Projectile, 0, 0, Penetration.small);
            Weapon rakieta = new Weapon("Rakieta", weaponType.Projectile, 0, 0, Penetration.big);

            //Aoe
            Weapon bombaBu = new Weapon("Bomba burząca", weaponType.Aoe, 0, 0, Penetration.medium);
            Weapon bombaTo = new Weapon("Bomba tocząca", weaponType.Aoe, 0, 0, Penetration.big);
            Weapon bombaOd = new Weapon("Bombaodłamkowa", weaponType.Aoe, 0, 0, Penetration.small);
            Weapon bombaZa = new Weapon("Bomba zapalająca", weaponType.Aoe, 0, 0, Penetration.small);
        }
    }
}
