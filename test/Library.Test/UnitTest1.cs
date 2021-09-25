using NUnit.Framework;

namespace RoleplayGame
{
    public class Tests
    {
        [Test]
        public void TestAtaque()
        {
            Dwarf testDwarf = new Dwarf("Test Dwarf");
            testDwarf.Shield = new Shield();
            testDwarf.Axe = new Axe();
            testDwarf.Helmet = new Helmet();

            Knight testKnight = new Knight("Test Knight");
            testKnight.Sword = new Sword();
            testKnight.Armor = new Armor();
            testKnight.Shield = new Shield();

            int expected = 100;
            Assert.AreEqual(expected, testKnight.Health);
        }

        [Test]
        public void TestAgregarHechizo()
        {
            SpellsBook testBook = new SpellsBook();
            testBook.Spells = new Spell[]{ new Spell() };

            int expected = 70;
            Assert.AreEqual(expected, testBook.AttackValue);
        }

        [Test]
        public void TestCurar()
        {
            Dwarf testDwarf = new Dwarf("Test Dwarf");
            testDwarf.Shield = new Shield();
            testDwarf.Axe = new Axe();
            testDwarf.Helmet = new Helmet();

            SpellsBook testBook = new SpellsBook();
            testBook.Spells = new Spell[]{ new Spell() };

            Wizard testWizard = new Wizard("Test Wizard");
            testWizard.Staff = new Staff();
            testWizard.SpellsBook = testBook;
            
            testDwarf.ReceiveAttack(testWizard);

            testDwarf.Cure();

            int expected = 100;
            Assert.AreEqual(expected, testDwarf.Health);
        }
        
    }
}