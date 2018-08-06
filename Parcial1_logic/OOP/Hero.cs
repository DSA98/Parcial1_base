using System;
namespace Parcial1_logic.OOP
{
    public class Hero:Actor, ICharacter
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }
        public Hero(float _atk, float _def)
        {
            BaseAtk = _atk;
            BaseDef = _def;
            
        }
        public void Move(MovementType _paramMove)
        {
            _paramMove = MovementType.Input;
            Console.WriteLine("Me muevo con un input");
            Console.WriteLine(_paramMove);
        }
        public void GetCurrentAttack()
        {
            CurrentWeapon.ParamMod(BaseAtk);
            Console.WriteLine(BaseAtk);
        }
        public void GetCurrentDefense()
        {
            CurrentArmor.ParamMod(BaseDef);
            Console.WriteLine(BaseDef);
        }
        public void Equip(Gear _gearRecieved)
        {
            if (_gearRecieved is Weapon)
            {
                GetCurrentAttack();
            }
            if (_gearRecieved is Armor)
            {
                GetCurrentDefense();
            }
        }
    }
}