using System;
using ProjetoRPG.src.Entities;


namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 10, "Cavaleiro");
            Wizard wizard = new Wizard("Jennica", 25, "White Wizard");
            Ninja wedge = new Ninja ("Wedge", 50, "Ninja");
            BlackWizard topappa = new BlackWizard("Topappa", 40,  "Black Wizard");
          
            Console.WriteLine(arus.Attack(40));
            Console.WriteLine(arus.Attack(120));
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(wizard.Attack(100));
            Console.WriteLine(wedge.Attack("Dia", 50));
            Console.WriteLine(wedge.Attack("Noite", 120));
            Console.WriteLine(topappa.Attack("dia", 20));
            Console.WriteLine(topappa.Attack("Noite", 100));
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine("Após uma difícil batalha o inimigo foi derrotado!");
        }
    }
}