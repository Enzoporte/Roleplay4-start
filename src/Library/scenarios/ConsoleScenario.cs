namespace RoleplayGame.Scenarios
{
    using Characters;
    using Items;
    using System;
    public class ConsoleScenario: IScenario
    {
        Character Enzo;
        Character Mati;
        Character Pablo;
        Character Gonza;
        Coraza Coraza;
        Palo Palo;
        CapaInvisibilidad Capa;
        Character Winner1;
        Character Winner2;
        public void Setup()
        {
            this.Enzo = new Elf("Enzo");
            this.Mati = new Troll("Mati");
            this.Pablo = new Princesa("Pablo");
            this.Gonza = new Wizard("Gonza");
            Enzo.AddItem(Palo);
            Pablo.AddItem(Coraza);
            Gonza.AddItem(Capa);
        }

        public void Run()
        {
            while (Enzo.IsDead == true || Pablo.IsDead == true)
            {
                Enzo.ReceiveAttack(Pablo.AttackPower);
                Pablo.ReceiveAttack(Enzo.AttackPower);
            }
            if (Enzo.IsDead == true)
            {
                Character Winner1 = Pablo;
                Console.WriteLine("Winner 1: Pablo");
            }
            else
            {
                Character Winner1 = Enzo;
                Console.WriteLine("Winner 1: Enzo");
            }
            while (Mati.IsDead == true || Gonza.IsDead == true)
            {
                Mati.ReceiveAttack(Gonza.AttackPower);
                Gonza.ReceiveAttack(Mati.AttackPower);
            }
            if (Mati.IsDead == true)
            {
                Character Winner2 = Gonza;
                Console.WriteLine("Winner 2: Gonza");
            }
            else
            {
                Character Winner2 = Mati;
                Console.WriteLine("Winner 2: Mati");
            }

            while (Winner1.IsDead == true || Winner2.IsDead == true)
            {
                Winner1.ReceiveAttack(Winner2.AttackPower);
                Winner2.ReceiveAttack(Winner1.AttackPower);
            }
            if (Winner1.IsDead == true)
            {
                Console.WriteLine("Winner: "+ Winner2);
            }
            else
            {
                Console.WriteLine("Winner: "+ Winner1);
            }
        }
    }
}