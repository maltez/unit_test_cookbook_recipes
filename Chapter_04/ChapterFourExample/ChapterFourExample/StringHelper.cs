using System.Collections.Generic;
using System.Text;

namespace ChapterFourExample
{
    public class StringHelper
    {
        public string JoinList<T>(List<T> list) where T : struct 
        {
            var output = new StringBuilder();

            foreach (T item in list)
            {
                output.Append(item);
                output.Append(", ");
            }

            string result = output.ToString();

            return result.Substring(0, result.Length - 2);
        }

        public bool AreEqualIgnoreCase(string first, string second)
        {
            return first.ToUpper().Equals(second.ToUpper());
        }

        public string GenerateSignature(string firstName, string secondName)
        {
            return string.Format("Sincerely yours {0} {1}", firstName, secondName);
        }
    }
}
