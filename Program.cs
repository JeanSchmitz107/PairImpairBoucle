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

        int nbr;
        string y_or_n = "y";
        while (y_or_n != "n")
        {
            Console.WriteLine("\n\nChoissisez un nombre entier.");
            nbr = Convert.ToInt32(Console.ReadLine());
            if((nbr % 2) == 0)
            {
                Console.WriteLine("\nLe nombre " + nbr + " est pair !");
            }
            else
            {
                Console.WriteLine("\nLe nombre " + nbr + " est impair !");
            }

            Console.WriteLine("\n\nVoulez vous continuer ? (y/n)");
            y_or_n = Console.ReadLine();

        }
        Console.WriteLine("\n\n\nMerci d'avoir teter mon programe.\n\n\n\n\n\n\n\n\n");

    }
}
