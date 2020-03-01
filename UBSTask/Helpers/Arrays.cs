/*
 * Created by SharpDevelop.
 * User: kkowczur
 * Date: 2018-07-26
 * Time: 13:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UBSTask.Helpers
{
    /// <summary>
    /// Klasa przechowuje tabele, oraz metody randomizujące zmienne używane w klasie 'Progarm'
    /// </summary>
    public class Arrays
    {
        Random random = new Random();



        public string[] nameArray = new string[30]{"Marek","Bolesław","Kazimierz", "Lesław", "Mieszko", "Pankracy", "Zygmunt","Adrian", "Anzelm","Patryk","Wit","Jerzy",
                                                  "Wawrzyniec","Leopold","Kajetan","Mirosław","Albin","Szymon","Olgierd","Włodzimierz","Witold","Sebastian",
                                                  "Łukasz","Maciej","Aleksander","Rafał","Feliks","Ernest","Władysław","Zenon"};
        public string[] womanNameArray = new string[30]{"Bogumiła","Diana","Henryka", "Marlena", "Franciszka", "Judyta", "Sławomira","Aldona", "Iza","Kalina","Maja","Ida",
                                                  "Monika","Nina","Alicja","Teresa","Weronika","Klaudia","Zofia","Patrycja","Katarzyna","Felicja",
                                                  "Liliana","Aleksandra","Laura","Czesława","Wanda","Sylwia","Edyta","Honorata"};
        public string[] surnameArray = new string[30] {"Hola-Hernes","Kobiec","Dudaczyk","Terefenko","Mariak-Siebielec","Supel","Czarczyński-Hamerlik","Machaczka",
                                                       "Hałuszka","Mędrecki","Ryglewicz","Borzucki","Golubiewski-Dziamara","Szpalerski","Pojasek-Hernes","Grusiecki",
                                                       "Powideł","Drzystek","Miechowski","Jałkiewicz","Lenckowski-Ryglewicz","Czernichowski-Sztark","Fabisiewicz",
                                                       "Kacprzykowski-Kukowka","Knapkiewicz-Gamdzyk","Miechowski","Glombik","Wiczling","Zembala-Chilczuk","Szer"};
        public string[] streetArray = new string[30] {"Kaliska","Angorska","Kluczborska","Reymonta","Bełzy","Grójecka","Sybiraków","Argentyńska","Piłsudskiego","Kościuszki",
                                                      "Narwik","Światowida","Gryfa Pomorskiego","ul Kopalniana","Al. Rzeczypospolitej","Na Zjeździe","Wiosenna","Dzieci Warszawy",
                                                      "Rydygiera","Rembielińska","Swinarskiego","Słowackiego","Sklepowa","Powstańców ","Bogusławskiego","Gryfa Pomorskiego","Szumna",
                                                      "Skarżyńskiego","Siedlecka","Kowieńska"};

        public string[] cityArray = new string[30] {"Gdynia","Wieliczki","Szczecin","Gliwice","Bydgoszcz","Wrocław","Będzin","Brzeg","Białystok","Poznań","Warszawa","Mysłowice",
                                                    "Bielsko-Biała","Racibórz","Białystok","Olsztyn","Będzin","Jaworzno","Radom","Kielce","Kraków","Zabrze","Warszawa","Katowice",
                                                    "Chełm","Lublin","Zawiercie","Radom","Warszawa","Kraków"};
        public string[] ZipCodeArray = new string[30] {"81-591","19-404","70-886","44-122","85-791","53-147","42-500","49-300","15-587","61-315","00-202","41-409","43-300","47-404",
                                                    "15-758","10-321","42-500","43-603","26-612","25-645","31-610","41-811","03-814",
                                                    "40-528","22-115","20-827","42-400","26-603","03-180","30-625"};


        
        public int[] wGenderNumbers = new int[5] { 0, 2, 4, 6, 8 };
        public int[] mGenderNumbers = new int[5] { 1, 3, 5, 7, 9 };
        
        public string GetRandomItem(string[] array)
        {
            int index = random.Next(array.Length);
            return array[index];
        }

        public int GetRandomGender(int[] array)
        {
            int index = random.Next(array.Length);
            return array[index];
        }


        public string GetName()
        {
            int gender = random.Next(2);
            if (gender == 1)
            {
                return GetRandomItem(nameArray);
            }
            else
                return GetRandomItem(womanNameArray);
        }

        public string GetSurname()
        {
            return GetRandomItem(surnameArray);
        }

        public string GetStreet()
        {
            return GetRandomItem(streetArray);
        }

        public string GetCity()
        {
            return GetRandomItem(cityArray);
        }

        public string GetZipCode()
        {
            return GetRandomItem(ZipCodeArray);
        }


        public int GetArrayRandomNumber(int tableMaxValue)
        {
            return random.Next(0, tableMaxValue);
        }

    }
}
