namespace HashTablePro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");

            bool check = true;



            Console.WriteLine("Select Proper Option\n" +
                "1)Get the Frequency of Words to be used\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //creating an object of mapnode class using key value pair
                    //key and value has both same data type

                    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                    hash.Add("0", "To");
                    hash.Add("1", "be");
                    hash.Add("2", "or");
                    hash.Add("3", "not");
                    hash.Add("4", "To");
                    hash.Add("5", "be");
                    hash.GetFrequency("To");
                    string hash5 = hash.Get("5");
                    Console.WriteLine("5th index value: " + hash5);
                    break;

                default:
                    Console.WriteLine("Please Enter Proper Option");
                    break;
            }
        }
    }
}
