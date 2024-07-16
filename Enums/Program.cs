namespace Enums
{
    internal class Program
    {
        static void Main()
        {
            Weapon myWeapon = new Weapon(BulletType.Mid, 5);
            myWeapon.Fill();

            myWeapon.PullTrigger(); 
            myWeapon.Fire();       
            myWeapon.Fire();        

            myWeapon.PullTrigger(); 
        }
    }
}