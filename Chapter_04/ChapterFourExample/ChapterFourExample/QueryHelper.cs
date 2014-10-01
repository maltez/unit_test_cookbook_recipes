using System.Collections.Generic;
using System.Linq;

namespace ChapterFourExample
{
    public class QueryHelper
    {
        private readonly Dictionary<int, string> _dishes = new Dictionary<int,string>
        {
            {0, "Hamburger"},
            {1, "BigMac"},
            {2, "MacFlury"},
            {3, "ChickenMacNagets"},
            {4, "Shake"},
            {5, "IceCream"}
        };

        public string GetDishById(int id)
        {
            string output = null;

            if (_dishes.Keys.Contains(id))
            {
                output = _dishes[id];
            }

            return output;
        }

        public List<string> GetAllDishes()
        {
            var temp = _dishes.Values.ToList();
            return temp;
        }
    }
}
