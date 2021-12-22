using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите заданную букву: ");
        char a = char.Parse(Console.ReadLine());
        int k = 0;
        foreach (String s in File.ReadAllLines("text.txt"))
        {
            string s1 = Regex.Replace(s, "[-.?!)(,:]", "");

            s1 = s1.ToLower().Trim();

            if (s1 != null && s1.Length > 0 && s1[0] == a && s1[s1.Length - 1] == a)
                k++;
        }

        Console.WriteLine("k= " + k);
        Console.ReadKey();
    }
}