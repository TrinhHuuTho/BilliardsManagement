using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsManagement
{

    public class FoodAndDrink
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int SL { get; set; }

    }

    public class Bill : FoodAndDrink
    {
    }


}