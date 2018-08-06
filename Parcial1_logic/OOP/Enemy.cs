using System;
namespace Parcial1_logic.OOP
{
    public class Enemy:Actor, ICharacter
    {
        public Enemy(float _atk, float _def)
        {
            BaseAtk = _atk;
            BaseDef = _def;
        }
        public void Move(MovementType _paramMove)
        {
            _paramMove = MovementType.AI;
            Console.WriteLine("Me muevo como un AI");
            Console.WriteLine(_paramMove);

        }
    }
}