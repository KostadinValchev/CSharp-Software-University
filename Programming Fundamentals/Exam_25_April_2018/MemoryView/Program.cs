namespace MemoryView
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = "";
            int stringSize = 0;
            int whiteSpaceCount = 0;
            StringBuilder sb = new StringBuilder();
            StringBuilder results = new StringBuilder();
            string textForWorking = "";

            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                sb.Append(input);
                sb.Append(" ");
            }
            for (int i = 0; i < sb.Length; i++)
            {
                char currentChar = sb[i];
                if (currentChar == '3')
                {
                    int start = i;
                    int end = start + 17;
                    textForWorking = sb.ToString();
                    var lastIndex = textForWorking.ToString().IndexOf('3', end - 1);
                    if (lastIndex - start == 16)
                    {
                        var items = textForWorking.Substring(end, 6).Trim().Split().ToList();
                        stringSize = int.Parse(items[1]);
                        for (int j = end + 6; j < textForWorking.Length; j++)
                        {
                            char currentSbChar = textForWorking[j];
                            if (currentSbChar == ' ')
                            {
                                whiteSpaceCount++;
                            }
                            if (whiteSpaceCount == stringSize + 1)
                            {
                                int charEnd = j;
                                var result = textForWorking.Substring(end + 7, (j - (end + 6)));
                                var name = result.Trim().Split().Select(int.Parse).ToList();
                                foreach (var c in name)
                                {
                                    results.Append((char)c);
                                }
                                whiteSpaceCount = 0;
                                break;
                            }
                        }
                    }
                }
            }
            var draw = results.ToString().TrimEnd().ToString().Split();
            foreach (var item in draw)
            {
                Console.WriteLine(item);
            }
        }
    }
}

