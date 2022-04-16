using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.UI
{
    public class UserManager
    {
        public List<City> cityList = new List<City> { new City() };
        public void Add(City city)
        {
                cityList.Add(city);
        }

        public List<City> GetList() 
        {
            return cityList;
        }
    }
}
