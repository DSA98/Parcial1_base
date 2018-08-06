namespace Parcial1_logic.OOP
{
    public class Armor:Gear
    {
        public Armor(float _def)
        {
            AumentoDef = _def;
        }
        public float ParamMod(float _paramBaseDefense)
        {
            _paramBaseDefense += _paramBaseDefense * AumentoDef;
            return _paramBaseDefense;
        }
    }
}