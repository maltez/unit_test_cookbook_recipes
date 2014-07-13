using System.Text;

namespace SimpleMvcApplication.Helpers
{
    public class StringHelper
    {
        public const string Space = " ";

        public string ConcatTwoStrings(string firstString, string secondString)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(firstString);
            stringBuilder.Append(Space);
            stringBuilder.Append(secondString);

            return stringBuilder.ToString();
        }
    }
}