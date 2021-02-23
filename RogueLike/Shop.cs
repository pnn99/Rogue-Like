using System;


namespace RogueLike_TP_2020
{
    /*
    Aumento de vida
    Aumento de dano
    Aumenta armadura
    Compra de poção
    */
    public class Shop
    {
        public static void loadShop(Player p)
        {
            runShop(p);
        }

        public static void Buy(string item, int cost, Player p)
        {
            //checagem pra ver se tem moedas suficientes
            if(p.coin >= cost)
            {
                if(item == "poção")
                    p.potion++;
                else if(item == "Dano")
                {
                    p.dano = p.dano + 2;
                }
                else if(item == "Armadura")
                {
                    p.armorValue = p.armorValue + 3;
                }
                else if(item == "Vida")
                {
                    p.vida = p.vida + 5;
                }

                p.coin -= cost;
            }
            else
            {
                Console.WriteLine("Moedas Insuficiente!!!");
                Console.ReadKey();
            }
        }
        public static void runShop(Player p)
        {
            //precificação
            int vidaP = 10;
            int danoP = 15;
            int armorP = 15;
            int potionP = 20;

            while(true){
                Console.Clear();
                Console.WriteLine("              |LOJA|         ");
                Console.WriteLine("Melhoria nos status e compra de poção");
                Console.WriteLine("Vida -> 5hp\nDano -> 2 dano\nArmadura -> 3 armadura");
                Console.WriteLine("||====================================================||");
                Console.WriteLine("|   (1)Vida -> 10 moeda || (2)Dano -> 15 moedas    |");
                Console.WriteLine("| ----------------------------------------------   |");
                Console.WriteLine("|    (3)Armadura -> 15 || (4)Poção -> 20 moedas    |");
                Console.WriteLine("                     (5)Sair");
                Console.WriteLine("||====================================================||\n");
                //Status do Jogador
                Console.WriteLine("\n"+ p.name +"'s Atributos");
                Console.WriteLine("===============================");
                Console.WriteLine("Moedas: "+ p.coin);
                Console.WriteLine("Vida: "+ p.vida);
                Console.WriteLine("Armadura: "+ p.armorValue);
                Console.WriteLine("Dano: "+ p.dano);
                Console.WriteLine("Poção: "+ p.potion);
                Console.WriteLine("===============================");
                int input = int.Parse(Console.ReadLine());
                
                if(input == 1)
                {
                    Buy("Vida", vidaP, p);
                }
                else if(input == 2)
                {
                    Buy("Dano", danoP, p);
                }
                else if(input == 3)
                {
                    Buy("Armadura", armorP, p);
                }
                else if(input == 4)
                {
                    Buy("Poção", potionP, p);
                }
                else if(input == 5)
                    break;
            }
        }
    }
}
