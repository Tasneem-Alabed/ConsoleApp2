using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.Make="kjnbh";
            bool display = true;
            while (display)
            {
                mainMenu();
            }
            int x = 0;
            switch (x)
            {
                case 1: { Console.WriteLine("Hello, World!"); }
                    break;
                    default: { Console.WriteLine("Hello, World!"); }
                    break;
            }

            double a = 9.8;
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            Console.WriteLine();
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            Console.WriteLine("Type Your First Name?");
            String MyFirstNAme;
            MyFirstNAme = Console.ReadLine();
            Console.WriteLine("Type Your Last Name?");
            String MyLastNAme;
            MyLastNAme = Console.ReadLine();
            Console.WriteLine("Hello" + MyFirstNAme + " " + MyLastNAme);
            Console.ReadLine();
            int[] numbers = new int[] {3,4,5,6,7,8};
            String[] names = new String[] { "aa", "ii" };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (String ANME in names) { 
                Console.WriteLine(ANME);
            }
            String zig = "poikuhytrdftgyhujikoplkojihuygtfdf" + "lkjhj";
            char[] charArray=zig.ToCharArray();
            foreach (char c in charArray)
            {
                Console.Write(c);
            }
            Console.ReadLine ();

            ReversString("poiuyhtgfrghjk");

            // String myString = "My \"so-called\" life?";
            //String myString = @"Go to your c:\\ driv";
            //String myString = String.Format("{0} = {1}" , "First" , "second");
            // String myString = "What if i need a\nnew line?";
            // String myString = String.Format("{0:c}" ,123, 45);
           // String myString = String.Format("{0:N}", 12387654545);
            

        }

        public static void ReversString(String masseg)
        {
           // String masseg = "Hello World!";

                char[] massegArray = masseg.ToCharArray();
            Array.Reverse(massegArray);
            foreach (char c in massegArray)
            {
                Console.Write(c.ToString());
            }

        }

        public static bool mainMenu()
        {
            Console.WriteLine("Selector option");
            Console.WriteLine("1) option 1");
            Console.WriteLine("2) option 2");
            Console.WriteLine("3) exiet");
            String result= Console.ReadLine();
            if(result =="1")
            {
                Console.WriteLine();
                return true;
            }
            else if(result =="2")
            {
                Console.WriteLine();
                return true;
            }
            else if (result == "3")
            {
                Console.WriteLine();
                return false;  
            }
            else
            {
               
                return true;
            }
              
        }
    }
    class car
    {
        public String Make { get; set };

    }

}