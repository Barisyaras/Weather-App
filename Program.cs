using Weather.UI;

UserManager manager = new UserManager();

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

    manager.Add(city);

}

List<City> cityList = manager.GetList();
int length = cityList.Count;
for (int i = 0; i < length; i++)
{

    Console.WriteLine(cityList[i].Name+" "+cityList[i].Fahrenheit+"Fahrenheit");
}