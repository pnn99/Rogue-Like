using System;


namespace RogueLike_TP_2020
{
    public class encounter
    {
        static Random rand = new Random();
        public static string getName()
        {
            switch(rand.Next(0, 8))
            {
                case 0:
                    return "Undead";
                case 1:
                    return "Esqueleto Ork";
                case 2:
                    return "Aranha Gigante";
                case 3:
                    return "Imp";
                case 4:
                    return "Necromante";
                case 6:
                    return "Troll Jovem";
                    case 7:
                        return "Drown";
            }
            return "Carniceiro";
        }
        public static void FirstEncounter()
        {
            Console.WriteLine("Eu me aproximo lentamente pelas costas, saco minha espada e avanço na criatura");
            Console.WriteLine("Ela se vira...\nPress any key");
            Console.ReadKey();
            combate(false, "Carniceiro", 1, 4);
        }
        public static void BasicEncounter()
        {
            Console.Clear();
            Console.WriteLine("Enquanto explora a masmorra, me deparo com uma criatura...");
            Console.ReadKey();
            combate(true, "", 0,0);
        }
        public static void necroEncounter()
        {
            Console.Clear();
            Console.WriteLine("Na escuridão da masmorra, escuro sussuros em um língua antiga, um ritual está acontecendo...");
            combate(true, "Necromante de Krak Drak", 4, 8);
        }
        public static void necroGolem()
        {
            Console.Clear();
            Console.WriteLine("Cheiro de carne podre e enxofre, sacrificios foram feitos aqui, o que eu vejo é uma montanha de carne e osso");
            Console.WriteLine("Um golem de carne dos desaventurados, ainda da pra escutar os gritos deles no fundo da criatura...");
            combate(true, "Golem de Carne", 7, 20);
        }
        public static void Sucubo()
        {
            Console.Clear();
            Console.WriteLine("Gemidos e gritos ecoam nesses corredores, sinto uma aura pesada e demoniaca");
            Console.WriteLine("Sucubos, deveria ter adivinhado, não posso deixar elas me controlarem...");
            combate(true, "Súcubo", 7, 12);
        }
        public static void horrorElmo()
        {
            Console.Clear();
            Console.WriteLine("Armaduras vazias preenchem o salão, quantas vidas foram perdidas aqui?");
            Console.WriteLine("Um impulso mágico ocorre, espiritos pertubados ocupam as armaduras vazias, seguindo seu ultimo desejo, matar...");
            combate(true, "Horror de Elmo", 12, 17);
        }
        public static void Boss()
        {
            Console.Clear();
            Console.WriteLine("Finalmente, o salão do Tesouro, nunca achei que chegaria aqui vivo. Quantos corpos fizeram meu caminho até aqui?");
            Console.WriteLine("Um tremor, luzes se acendem nos cristais pela sala, Um grande elemental surge, tão antigo quanto esse inferno...");
            combate(true, "Galeb Duhr, O Convocador de Rochas", 23, 50);
        }
        
        public static void victory()
        {
            Console.Clear();
            if(Program.currentPlayer.vida > 0)
            {
                Console.WriteLine("Eu consegui, após uma grande batalha, derrotei o guardião. Já consigo escutar os cantos com meu nome ecoando pelo pubs...");
                Console.WriteLine("Sim, isso, eu escuto o seu chamado, como um coração batendo, eu sinto seu poder");
                Console.ReadKey();
                Console.WriteLine("Você se depara com um grande bau de marmore, decorado com contos da Era Antiga, onde deuses andavam entre os homens.");
                Console.WriteLine("O selo mágico se rompe, e aquela grande arca abre, uma fumaça sai junto, ao olhar dentro, um Orbe com um tom azulado cerdado por escritas e runas");
                Console.WriteLine("O orbe se abre, tentaculos saem dele e penetram os olhos e boca do aventureiro, possuindo seu corpo...");
                Console.WriteLine("As luzes de Krak Drak se acendem, aquele lugar não era só uma masmorra, mas sim um prisão para um mal mais antigo que os homens... N'zareth");
                Console.ReadKey();
                Console.WriteLine("| -------------------------------------------------------------------------------- |");
                Console.WriteLine("| Obrigado por jogar Krak Drak, um projeto feito por Paulo Nogueira do Nascimento\nEstudante de Jogos Digitais na PUC-Minas |");
                Console.WriteLine("| Matéria: Laboratório de Algoritmos e Tecnicas de Programação\n 16/04/2020");
                Console.WriteLine("| -------------------------------------------------------------------------------- |");
            }
            else
            {
                Console.WriteLine("Então este é o guardião e Krak Drak, hum, minha feridas não vão aguentar por muito tempo... não vou morrer como um herói, só mais um desconhecido nesse buraco");
                Console.WriteLine("Somente você que está lendo este diário saberá de minha existência... Obrigado!");
                Console.ReadKey();
                Console.WriteLine("| -------------------------------------------------------------------------------- |");
                Console.WriteLine("| Obrigado por jogar Krak Drak, um projeto feito por Paulo Nogueira do Nascimento\nEstudante de Jogos Digitais na PUC-Minas |");
                Console.WriteLine("| Matéria: Laboratório de Algoritmos e Tecnicas de Programação\n 16/04/2020");
                Console.WriteLine("| -------------------------------------------------------------------------------- |");
            }
        }
        public static void randEncounter()
        {
            switch(rand.Next(1, 3))
            {
                case 1:
                    BasicEncounter();
                    break;
                case 2:
                    necroEncounter();
                    break;
            }
        }
        public static void combate(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            int dmg, atk, potionValue, c;
            

            if(random)
            {
                n = getName();
                p = rand.Next(5, 8);
                h = rand.Next(5, 12);
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Poder: "+ p + "\nVida: "+ h);
                Console.WriteLine("=========================");
                Console.WriteLine("| (1)Ataque (2)Defesa    |");
                Console.WriteLine("|    (3)Fugir  (4)Poção  |");
                Console.WriteLine("=========================");
                Console.WriteLine("  Poções: "+ Program.currentPlayer.potion + " Vida: "+ Program.currentPlayer.vida);
                int input = int.Parse(Console.ReadLine());

                    if(input == 1){
                        //ataque
                        dmg = p - Program.currentPlayer.armorValue;
                        if(dmg < 0)
                        {
                            dmg = 0;
                        }
                        atk = rand.Next(1, Program.currentPlayer.weaponValue) + rand.Next(1, 3);
                        Console.WriteLine("Você ataca o "+n+" que acaba revidando seu ataque...");
                        Console.WriteLine("Você deu "+atk+" e recebeu "+dmg+" de dano!!!");
                        Program.currentPlayer.vida -= dmg;
                        h -= atk;
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                    }
                    else if(input == 2){
                        //defesa
                        dmg = (p/2) - Program.currentPlayer.armorValue;
                        if(dmg < 0){
                            dmg = 0;
                        }
                        atk = rand.Next(1, Program.currentPlayer.weaponValue);
                        Console.WriteLine("Você prepara sua defesa contra "+n+"...");
                        Console.WriteLine("Você deu "+atk+" e recebeu "+dmg+" de dano!!!");
                        Program.currentPlayer.vida -= dmg;
                        h -= atk;
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                    }
                    else if(input == 3){
                        //fugir
                        if(rand.Next(0, 4) == 0)
                        {
                            Console.WriteLine("Enquanto fugia, o "+n+" rasga minhas costa, me jogando no chão, sinto minha vida acabando...");
                            Console.WriteLine("---------------Você morre como um covarde!!!---------------");
                        }
                        else
                        {
                            Console.WriteLine("Usando minha agilidade, fujo do confronto, como um covarde...");
                        }
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        Shop.loadShop(Program.currentPlayer);
                    }
                    else if(input == 4){
                        //poção
                        if(Program.currentPlayer.potion == 0)
                        {
                            Console.WriteLine("Desesperadamente procuro uma poção na mochila e encontro somente frascos vazios...");
                            dmg = p - Program.currentPlayer.armorValue;
                            if(dmg <= 0)
                            {
                                dmg = 0;
                            }
                            Console.WriteLine(n +" me ataca enquanto eu estava vulneravele recebo "+ dmg);
                        }
                        else
                        {
                            Console.WriteLine("Pego um frasco com um liquido visgoso, com um tom azul escuro e bebo. Me sinto revigorado no mesmo instante!");
                            potionValue = 10;
                            Console.WriteLine("Você foi curado em "+ potionValue);
                            
                            Program.currentPlayer.vida += potionValue;
                            if(Program.currentPlayer.vida >= 50){
                                Program.currentPlayer.vida = 50;
                            }
                        }
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                    }
                    if(Program.currentPlayer.vida <= 0){
                        //morte do jogador
                        switch(rand.Next(0, 3))
                        {
                            case 0:
                                Console.WriteLine("Enquanto "+ n +" me encurrala, minha feridas abertas não me deixam escapar, aqui, eu encontro meu destino...");
                                break;
                            case 1:
                                Console.WriteLine("Um golpe devastador mutila meu braço, caiu em uma poça de meu sangue, sentindo o frio da morte...");
                                break;
                            case 2:
                                Console.WriteLine("As feridas que cobrem meu corpo não podem mais ser fechadas, no escuro dessa masmorra, sinto o abraço da morte...");
                                break;
                        }
                        Console.WriteLine("Vocẽ morreu");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }
                }
            c = rand.Next(12, 25);
            Console.WriteLine("A criatura foi derrotada!!!\nSaqueando...");
            Console.ReadKey();
            Console.WriteLine("Você encontrou "+ c +" moedas");
            Program.currentPlayer.coin += c;
            Console.ReadKey();
            Shop.loadShop(Program.currentPlayer);
        }
    }
}
