using System;


namespace Morpion
{
    class Program
    {
        // structure d'un tableau 
        struct StrMorpion
        {
            public int col;
            public int lig;
            
        }
        struct StrGagnant
        {
            
            public int joueur;
            public bool cas;

        }
        static void Main(string[] args)
        {

            int play = 2;

            do
            {
                // déclaration du tableau de 3 cases
                // chaque case contenant une partie col et une partie lig
                StrMorpion[] morpion = new StrMorpion[9];
            StrGagnant[] gagnant = new StrGagnant[34];

             


            int player = 1;

            //tableau de positionnement x et y
            int[] x = new int[4];
            x[1] = 6;
            x[2] = 8;
            x[3] = 10;
            int[] y = new int[4];
            y[1] = 11;
            y[2] = 15;
            y[3] = 19;


            bool[] cas = new bool[34];
            cas[11] = false;
            cas[12] = false;
            cas[13] = false;
            cas[21] = false;
            cas[22] = false;
            cas[23] = false;
            cas[31] = false;
            cas[32] = false;
            cas[33] = false;




            // ligne horizontale
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("-----------");
            //verticale
            Console.SetCursorPosition(9, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(9, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(9, 10);
            Console.WriteLine("|");

            Console.SetCursorPosition(13, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(13, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(13, 10);
            Console.WriteLine("|");

            Console.SetCursorPosition(17, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(17, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(17, 10);
            Console.WriteLine("|");

            Console.SetCursorPosition(21, 6);
            Console.WriteLine("|");
            Console.SetCursorPosition(21, 8);
            Console.WriteLine("|");
            Console.SetCursorPosition(21, 10);
            Console.WriteLine("|");
            //PHRASE JEU
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("C'est au tour du joueur  X : " + player);
            Console.SetCursorPosition(12, 16);
            Console.WriteLine("Ligne :");
            Console.SetCursorPosition(10, 17);
            Console.WriteLine("Colonne :");

           


            //déclaration variable
            int coup = 0;
            bool gagnantbool = false;
            bool saisi = false;
            

                //fait la boucle tant qu'il n ya pas de gagnant ou 9 coup ou boolean
                do {



                    //saisi et verification 
                    do
                    {   //effacer ancienne saisi
                        Console.SetCursorPosition(20, 16);
                        Console.Write("_");
                        Console.SetCursorPosition(20, 17);
                        Console.Write("_");
                        saisi = false;
                        Console.SetCursorPosition(20, 16);
                        morpion[coup].lig = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

                        Console.SetCursorPosition(20, 17);
                        morpion[coup].col = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

                        //recuperation valeur rentrée
                        int xv = morpion[coup].lig;
                        int yv = morpion[coup].col;
                        //convertion en int pour tester la case
                        string xs = xv.ToString() + yv.ToString();
                        int test = Convert.ToInt32(xs);

                        if (morpion[coup].lig < 4 && morpion[coup].col < 4 && morpion[coup].lig > 0 && morpion[coup].col > 0 && gagnant[test].cas == false)
                        {
                            //determine si la valeur est utilisé
                            gagnant[test].cas = true;
                            saisi = true;
                            Console.SetCursorPosition(28, 17);

                        }


                    } while (saisi != true);


                    if (saisi == true)
                    {
                        int xv = morpion[coup].lig;
                        int yv = morpion[coup].col;
                        //convertion en int pour tester la case
                        string xs = xv.ToString() + yv.ToString();
                        int test = Convert.ToInt32(xs);
                        //changement de joueur et marquage joueur 1 croix joueur 2 rond
                        if (player == 1)
                        {
                            xv = morpion[coup].lig;
                            yv = morpion[coup].col;
                            gagnant[test].joueur = 1;
                            Console.SetCursorPosition(y[yv], x[xv]);
                            Console.WriteLine("X");
                            player = 2;
                            Console.SetCursorPosition(0, 15);
                            Console.WriteLine("C'est au tour du joueur  O : " + player);



                        }
                        else
                        {
                            xv = morpion[coup].lig;
                            yv = morpion[coup].col;
                            gagnant[test].joueur = 2;
                            Console.SetCursorPosition(y[yv], x[xv]);
                            Console.WriteLine("O");
                            player = 1;
                            Console.SetCursorPosition(0, 15);
                            Console.WriteLine("C'est au tour du joueur  X : " + player);


                        }
                        //boucle pour determiner si il  ya un gagnant
                        if ((gagnant[11].joueur == 1 && gagnant[12].joueur == 1 && gagnant[13].joueur == 1) || (gagnant[21].joueur == 1 && gagnant[22].joueur == 1 && gagnant[23].joueur == 1) || (gagnant[31].joueur == 1 && gagnant[32].joueur == 1 && gagnant[33].joueur == 1) || (gagnant[11].joueur == 1 && gagnant[22].joueur == 1 && gagnant[33].joueur == 1) || (gagnant[13].joueur == 1 && gagnant[22].joueur == 1 && gagnant[31].joueur == 1) || (gagnant[11].joueur == 1 && gagnant[21].joueur == 1 && gagnant[31].joueur == 1))
                        {
                            Console.SetCursorPosition(25, 25);

                            Console.WriteLine("****** Le joueur 1 a gagné ******");
                            Console.SetCursorPosition(25, 27);
                            Console.WriteLine("---------------------------------");
                            gagnantbool = true;
                        }
                        //boucle pour determiner si il  ya un gagnant
                        else if ((gagnant[11].joueur == 2 && gagnant[12].joueur == 2 && gagnant[13].joueur == 2) || (gagnant[11].joueur == 2 && gagnant[12].joueur == 2 && gagnant[13].joueur == 2) || (gagnant[21].joueur == 2 && gagnant[22].joueur == 2 && gagnant[23].joueur == 2) || (gagnant[31].joueur == 2 && gagnant[32].joueur == 2 && gagnant[33].joueur == 2) || (gagnant[11].joueur == 2 && gagnant[22].joueur == 2 && gagnant[33].joueur == 2) || (gagnant[13].joueur == 2 && gagnant[22].joueur == 2 && gagnant[31].joueur == 2) || (gagnant[11].joueur == 2 && gagnant[21].joueur == 2 && gagnant[31].joueur == 2))
                        {
                            Console.SetCursorPosition(25, 25);

                            Console.WriteLine("****** Le joueur 2 a gagné ******");
                            Console.SetCursorPosition(25, 27);
                            Console.WriteLine("---------------------------------");
                            gagnantbool = true;
                        }


                        coup++;
                    }

                   


                }
                while (gagnantbool == false && coup < 9);


                if (coup == 9)
                {
                    Console.SetCursorPosition(0, 18);
                    Console.Write("partie terminé, il y a égalité...");


                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Souhaitez vous faire une autre partie (0/1)? ");
                play = Convert.ToInt32(Console.ReadKey().KeyChar);
            } while (play == 1 && play == 2);
            Console.Read();
        }
    }
}
