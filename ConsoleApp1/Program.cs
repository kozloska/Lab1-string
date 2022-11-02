namespace FirstApp
{
    public class Logic
    {
        public static string removDuplicat(string word1)
        {
            int size = word1.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        if (word1[i] == word1[j])
                        {
                            word1 = word1.Remove(j, 1);
                            size--;
                        }

                    }
                }
            }
            return word1;
        }
        public static string Task(string word1, string word2)
        {
            string word = "";
            bool flag;
            word1 = Logic.removDuplicat(word1);
            for (int i = 0; i < word1.Length; i++)
            {
                flag = true;
                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    word += "нет ";
                }
                else
                {
                    word += "да ";
                }
            }
            return word;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово: ");
            string word1 = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            string word2 = Console.ReadLine();
            string word3 = Logic.Task(word1, word2);
            Console.WriteLine(word3);
        }
    }
}