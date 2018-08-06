using System;
namespace Parcial1_logic.OOP
{
    public class NPC:ICharacter
    {
        public void Interaction()
        {
            string message = "Hola jugador, yo doy pistas y habito en un pueblo";
            Console.WriteLine(message);
        }
        public void Move(MovementType _param)
        {
            _param = MovementType.Waypoint;
            Console.WriteLine("Yo me muevo en una ruta definida de diseño");
            Console.WriteLine(_param);
        }
    }
}