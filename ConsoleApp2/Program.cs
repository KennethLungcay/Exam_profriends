using Newtonsoft.Json;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter your range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            int cand = 1;
            List<Multiplication> multilist = new List<Multiplication>();

            var multiplication = new Multiplication();
            while (cand < range + 1)         
            {
                for (int plier = 1; plier < 11; plier++)
                {
                    int result = cand * plier;

                    Console.WriteLine("Multiplicand : " + cand);
                    Console.WriteLine("Multiplier : " + plier);
                    Console.WriteLine("Product : " + result + "\n");

                    multilist.Add(new Multiplication { multiplicand = cand , multiplier=plier,product=result});
                                       
                     }
                    string strResultJson = JsonConvert.SerializeObject(multilist);
                    File.WriteAllText(@"multiplication.json", strResultJson);
                cand++;
            }
            Console.WriteLine("JSON FILE STORED");

            }
                    
      
        [Serializable]
        public class Multiplication
        {
            public int multiplicand { get; set; }
            public int multiplier { get; set; }
            public int product { get; set; }
        }

    }
}
