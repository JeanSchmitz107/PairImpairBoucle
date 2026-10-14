namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */

        //int nbr;
        //string y_or_n = "y";
        //while (y_or_n != "n")
        //{
        //    Console.WriteLine("\n\nChoissisez un nombre entier.");
        //    nbr = Convert.ToInt32(Console.ReadLine());
        //    if((nbr % 2) == 0)
        //    {
        //        Console.WriteLine("\nLe nombre /" + nbr + " est pair !");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nLe nombre /" + nbr + "/ est impair !");
        //    }

        //    Console.WriteLine("\n\nVoulez vous continuer ? (y/n)");
        //    y_or_n = Console.ReadLine();

        //}
        //Console.WriteLine("\n\n\nMerci d'avoir teter mon programe.\n\n\n\n\n\n\n\n\n");


        int[] tbl_nbr;
        int N_tbl = 0, S_N_tbl = 0;
        string[] tbl_PorIP = ["ha"];
        string y_or_n = "y";
        while (y_or_n != "n")
        {
            Console.WriteLine("\n\nChoissisez un nombre entier.");
            tbl_nbr[N_tbl] = Convert.ToInt32(Console.ReadLine());

            if ((tbl_nbr[N_tbl] % 2) == 0)
            {
                tbl_PorIP[N_tbl] = "pair";
            }
            else
            {
                tbl_PorIP[N_tbl] = "impair";

            }

            Console.WriteLine("\n\nVoulez vous continuer ? (y/n)");
            y_or_n = Console.ReadLine();
            N_tbl++;
        }

        S_N_tbl = N_tbl;
        N_tbl = 0;

        Console.WriteLine("\n\n\n\n");

        while (N_tbl <= S_N_tbl)
        {
            if ((tbl_nbr[N_tbl] % 2) == 0)
            {
                Console.WriteLine("\n\nLe nombre /" + tbl_nbr[N_tbl] + "/ est " + tbl_PorIP[N_tbl] + " !");
            }
            else
            {
                Console.WriteLine("\n\nLe nombre /" + tbl_nbr[N_tbl] + "/ est " + tbl_PorIP[N_tbl] + " !");
            }
            N_tbl++;
        }

        Console.WriteLine("\n\n\nMerci d'avoir teter mon programe.\n\n\n\n\n\n\n\n\n");
    }
}
