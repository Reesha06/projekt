
class Program
{
      static List<string> Säck = new List<string>();

      static bool gamecontinue= true;
    static void Main()
    {
        Console.WriteLine("=== TEXTÄVENTYRET ===");

        while (gamecontinue)
        {
            StartScene();
            Console.WriteLine("Vill du spela igen? (Ja/Nej). ");
            string answer = Console.ReadLine().ToLower();

            if (answer!= "ja")
            {
                gamecontinue = false;
            }
        }

    }
     
     static void StartScene()
    {
        Console.WriteLine("\nDu vaknar upp i en mörk skog.");
        Console.WriteLine("Vänster mot floden.");
        Console.WriteLine("Höger mot berget.");
        Console.Write("Vad väljer du?");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "vänster")
            RiverScene();         
        else if (choice == "höger")
            MountainScene();
        else
         Console.WriteLine("Du irrade bort dig i skogen.");
        
    }
     
    static void RiverScene()
    {

        Console.WriteLine("\nDu når floden och ser en gammal bro.");
        Console.Write("vill du gå över bron? (ja/nej) ");
        string choice = Console.ReadLine().ToLower().Trim();

        if (choice == "ja")
        {
            Console.WriteLine("Du hittar en Silvernyckel!");
            Säck.Add("Silvernyckel");
            Ending();
        }
        else
        {
            Ending();
        }

    }


     static void MountainScene()
    {
        Console.WriteLine("\nDu når berget och ser en grotta.");
        Console.Write("Gå in i grottan? (ja/nej) ");
        string choice = Console.ReadLine().ToLower().Trim();

        if (choice == "ja")
        {
            Console.WriteLine("Väktaren säger: Sök sanningen i floden.");
            RiverScene();
        }
        else
        {
           Console.WriteLine("stigen försvann bakom dig och du dör"); 
            Ending();

        }
    
    }        
    
static void Ending()
    {
        Console.WriteLine("\n--- SLUTET ---");

        if(Säck.Contains("Silvernyckel"))
        {
            Console.WriteLine("Du fann friheten.");
            Console.WriteLine("Gratis");
        }

         else
            {
               Console.WriteLine("Du överlevde, men saknade modet.");
             }
         Console.WriteLine("\nTryck Enter för att fortsätta...");
        Console.ReadLine();
     
    }



    
}        
       


