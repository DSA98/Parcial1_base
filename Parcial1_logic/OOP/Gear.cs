namespace Parcial1_logic.OOP
{
    public abstract class Gear
    {
        static private float aumentoAtk=0;
        static private float aumentoDef=0;

        public float AumentoAtk { get => aumentoAtk; set => aumentoAtk = value; }
        public float AumentoDef { get => aumentoDef; set => aumentoDef = value; }
    }
}