using System;
namespace Parcial1_logic.OOP
{
    public abstract class Actor
    {
        private float baseAtk;
        private float baseDef;

        public float BaseAtk { get => baseAtk; set => baseAtk = value; }
        public float BaseDef { get => baseDef; set => baseDef = value; }
        
        public void Atacar()
        {
            Console.WriteLine("Ataco cualquier actor");
        }
    }
}