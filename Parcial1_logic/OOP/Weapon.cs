using System;
namespace Parcial1_logic.OOP
{
    public class Weapon:Gear
    {
        public Weapon(float _atk)
        {
            AumentoAtk = _atk;
        }
        public float ParamMod(float _paramBaseAttack)
        {
            _paramBaseAttack += _paramBaseAttack * AumentoAtk;
            return _paramBaseAttack;
        }
    }
}