namespace HashTablePro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");

            bool check = true;



            Console.WriteLine("Select Proper Option\n" +
                "1)Get the Frequency of Words to be used\n" +
                "2)Get the Frequency of Phrase from the Paragraph\n");

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

                case 2:

                    MyMapNode<string, string> hash1 = new MyMapNode<string, string>(20);
                    String sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

                    //split is splitting a string into an array of substrings separated by a character
                    string[] Phrase = sentence.Split(' ');

                    int SLength = Phrase.Length;
                    // Itreating along each word and adding it to hash set
                    for (int i = 0; i < SLength; i++)
                    {
                        hash1.Add(Convert.ToString(i), Phrase[i]);
                    }
                    //iterating through each loop to get the frequency of each word in the sentence
                    foreach (string word in Phrase)
                    {
                        hash1.GetFrequency(word);
                    }

                    break;


                default:
                    Console.WriteLine("Please Enter Proper Option");
                    break;
            }
        }
    }
}
