using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDay3
{
    class Person
    {
        string imie;
        int id;
        string nazwisko;
        string adres;

        // posiadamy tu konstruktory przeciążone ponieważ jest ich więcej niż jeden a ich liczbaargumentów się różni
        public Person()
        {
            id = 1;
            imie = "Mateusz";
            nazwisko = "Misiak";
        }

        public Person(string imie, string nazwisko, string adres, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.id = id;
        }

        public Person(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            adres = "Łódz";

        }
    }
}
