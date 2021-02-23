/*
Nome: Paulo Nogueira do Nascimento
Curso: Jogos Digitais PUC-Minas
Projeto: RogueLike Text-Based, Trabalho prático de Laboratorio de ATP
Orientador: Guilherme Itabayana Braga da Fonseca
Data: 17/04/2020
*/
using System;


namespace RogueLike_TP_2020
{
    
    public class Program
    {
        
        static void Start(){
            Console.Clear();
            Console.Write("Nome: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            if(currentPlayer.name == ""){
                Console.WriteLine("Meu nome não importa nessa jornada...");
                }
            else{
                Console.WriteLine("Eu sou "+ currentPlayer.name);
            }
            Console.WriteLine("Finalmente, após dias explorando essas ruínas encontrei a entrada para Krak Drak");
            Console.Write("Histórias obscuras sobre esse local, poucos voltaram, muitos servem como almas ambulantes da escuridão...");
            Console.WriteLine("Hoje eu inicio minha jornada, minha vida não vale nada, então não tenho nada a perder.");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Entro na masmorra, ja vejo alguns corpos de desafortunados na entrada");
            Console.WriteLine("Alguns estão frescos, devo ter cuidado.");
            Console.WriteLine("Vejo um carniceiro estripando um corpo, ele não percebeu minha presença...");
        }
        public static Player currentPlayer = new Player();
        public static bool loop = true;
        static void Main(string[] args)
        {
            int aux;

            Console.WriteLine("Nas ruínas de uma antiga cidade Ork, uma masmorra, onde tesouros de eras perdidas estão guardados");
            Console.WriteLine("Quais perigos te aguardam aventureiro(a)?");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------Krak Drak--------------");
            Console.WriteLine("1 - Novo Jogo");
            Console.WriteLine("2 - Regras");
            Console.WriteLine("3 - Sair");
            aux = int.Parse(Console.ReadLine());
  
            if(aux == 1)
            {    
            }
            if(aux == 2)
            {
                Console.WriteLine("1- Morte Permanemte, fim da execução\n2- Acesso a loja após a cada encontro");
                Console.WriteLine("3- Ao fugir de cada luta, retorna a loja, existe uma chance de morrer durante o processo");
                Console.WriteLine("4- Fique forte, vença os horrores de Krak Drak e enfrente a escuridão nas entranhas de Krak Drak");
                Console.ReadKey();
            }
            else if(aux == 3)
            {
                System.Environment.Exit(0);
            }
            Start();
            encounter.FirstEncounter();
            encounter.randEncounter();
            encounter.randEncounter();
            encounter.randEncounter();
            encounter.necroGolem();
            encounter.randEncounter();
            encounter.randEncounter();
            encounter.Sucubo();
            encounter.randEncounter();
            encounter.randEncounter();
            encounter.horrorElmo();
            encounter.randEncounter();
            encounter.Boss();
            encounter.victory();
        }
    }
}
