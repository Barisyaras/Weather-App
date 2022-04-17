using Weather.UI;

List<City> cityList = new List<City>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Eklemek istediğiniz şehiri yazınız");
    string name = Console.ReadLine();

    Console.WriteLine("Eklemek istediğiniz şehrin sıcaklığını celcius cinsinden yazınız");
    double celcius = Convert.ToInt32(Console.ReadLine());
    double fahrenheit = celcius * 1.8 + 32;

    City city = new City();
    city.Name = name;
    city.Fahrenheit = fahrenheit;
    city.Celcius = celcius; 

    cityList.Add(city);

}


int length = cityList.Count;
for (int i = 0; i < length; i++)
{

    Console.WriteLine(cityList[i].Name+" "+cityList[i].Fahrenheit+"Fahrenheit "+cityList[i].Celcius+"Celcius");
}