public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            Ocena Opis
            6 Celujący
            5 Bardzo dobry
            4 Dobry
            3 Dostateczny
            2 Dopuszczający
            1 Niedostateczny
            Dane testowe : 3
            Rezultat w terminalu : Dostateczny
        */

        Console.WriteLine("Podaj ocenę:");
        int note = Int32.Parse(Console.ReadLine());

        switch (note)
        {
            case 6:
                Console.WriteLine("Celujący");
                break;
            case 5:
                Console.WriteLine("Bardzo dobry");
                break;
            case 4:
                Console.WriteLine("Dobry");
                break;
            case 3:
                Console.WriteLine("Dostateczny");
                break;
            case 2:
                Console.WriteLine("Dopuszczający");
                break;
            case 1:
                Console.WriteLine("Niedostateczny");
                break;
            default:
                Console.WriteLine("Brak takiej oceny w tabeli!");
                break;
        }

     

    }

}