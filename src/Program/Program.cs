using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            IPersonaje igandalf = gandalf;
            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Shield = new Shield();
            gimli.Helmet = new Helmet();
            IPersonaje igimli = gimli;

            Console.WriteLine($"Gimli has {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with {gandalf.AttackValue}");

            igimli.ReceiveAttack(igandalf);

            Console.WriteLine($"Gimli has {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has {gimli.Health}");
        }
    }
}
