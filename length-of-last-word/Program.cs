namespace length_of_last_word
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
           
            s = s.Trim();

           
            int lastSpaceIndex = s.LastIndexOf(' ');

            
            if (lastSpaceIndex == -1)
            {
                return s.Length;
            }

            
            return s.Length - lastSpaceIndex - 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            
            Console.WriteLine(solution.LengthOfLastWord("Hello World")); 
            Console.WriteLine(solution.LengthOfLastWord("   fly me   to   the moon  ")); 
            Console.WriteLine(solution.LengthOfLastWord("luffy is still joyboy")); 
            Console.WriteLine(solution.LengthOfLastWord("   ")); 
        }
    }
}
