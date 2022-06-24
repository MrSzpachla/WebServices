using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServices.Controllers;
using System.Collections;

namespace WebServices
{
    public class ZnajdzOsobe : IZnajdzOsobe
    {

        public string Znajdz(string nazwisko)
        {
            List<Osoby> osoba = new List<Osoby>();

            osoba.Add(new Osoby() { imie = "Andrzej",  nazwisko = "Gablik", adres = "Mijowska 44" });
            osoba.Add(new Osoby() { imie = "Anna", nazwisko = "Kopernik", adres = "Lisia 789" });
            osoba.Add(new Osoby() { imie = "Marcin", nazwisko = "Michalski", adres = "Debowa 5" });
            osoba.Add(new Osoby() { imie = "Janusz", nazwisko = "Koziol", adres = "Dabrowskiego 13" });
            osoba.Add(new Osoby() { imie = "Nadia", nazwisko = "Krawc", adres = "Bema 1" });
            osoba.Add(new Osoby() { imie = "Michalina", nazwisko = "Kuniek", adres = "Sucharskiego 41" });
            osoba.Add(new Osoby() { imie = "Mirek", nazwisko = "Walczyk", adres = "Plac Grunwaldu 543" });
            osoba.Add(new Osoby() { imie = "Jurek", nazwisko = "Kaiswo", adres = "Gornicza 27" });
            osoba.Add(new Osoby() { imie = "Juliusz", nazwisko = "Wajdlejt", adres = "Pomorska 33" });
            osoba.Add(new Osoby() { imie = "Martyna", nazwisko = "Mikulska", adres = "Wiejska 7" });
            osoba.Add(new Osoby() { imie = "Ewelina", nazwisko = "Krotka", adres = "Wilcza 22" });

            Osoby wynik = osoba.Find(x => x.nazwisko.Contains(nazwisko));
            if (wynik == null)
            {
                return "Brak takiej osoby";
            }
            else
            {
                return string.Format(wynik.imie, wynik.nazwisko, wynik.adres);
            }

        }
    }
}
