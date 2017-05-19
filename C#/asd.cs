using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortPoPutevke : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Turagenstvo turAg = x as Turagenstvo;
            Turagenstvo turAg2 = y as Turagenstvo;
            if (turAg != null && turAg2 != null)
            {
                return String.Compare(turAg.putevka, turAg2.putevka);
            }
            throw new NotImplementedException();
        }
    }

    class SortPoProdoljitelnosti : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Turagenstvo turAg = x as Turagenstvo;
            Turagenstvo turAg2 = y as Turagenstvo;
            if (turAg != null && turAg2 != null)
            {
                return String.Compare(turAg.prodol, turAg2.prodol);
            }
            throw new NotImplementedException();
        }
    }

    class Turagenstvo  //базовый класс
    {
        public string putevka;
        public string prodol;
        protected double stoimost;
        protected string ekskursii;
        virtual public string print()
        {
            return "\nПутёвка " + putevka + "; Продолжительность " + prodol + "; Стоимость " + stoimost + "; \nНаличие экскурсий " + ekskursii;
        }


        public string Pputevka
        {
            get { return putevka; }
            set { putevka = value; }
        }

        public string Pprodol
        {
            get { return prodol; }
            set { prodol = value; }
        }
        public Turagenstvo()
        {
            putevka = "";
            prodol = "";
            stoimost = 0;
            ekskursii = "";
        }
        public Turagenstvo(string putevka, string prodol, double stoimost, string ekskursii)
        {
            this.putevka = putevka;
            this.prodol = prodol;
            this.stoimost = stoimost;
            this.ekskursii = ekskursii;
        }
    }
    class Turist : Turagenstvo //производный класс
    {
        string marshrut;
        string cpravka;
        public Turist()
            : base()
        {
            marshrut = " ";
            cpravka = " ";
        }
        public Turist(string putevka, string prodol, double stoimost, string ekskursii, string marshrut, string cpravka)
            : base(putevka, prodol, stoimost, ekskursii)
        {
            this.marshrut = marshrut;
            this.cpravka = cpravka;
        }
        public string Mmarshrut
        {
            get { return marshrut; }
            set { marshrut = value; }
        }
        public string Ccpravka
        {
            get { return cpravka; }
            set { cpravka = value; }
        }
        public override string print()
        {
            return base.print() + "; Категория маршрута " + marshrut + "; Справка от врача " + cpravka;
        }
    }
    class Sanatorii : Turagenstvo //производный класс
    {
        string zabolevanie;
        public Sanatorii()
            : base()
        {
            zabolevanie = "";
        }
        public Sanatorii(string putevka, string prodol, double stoimost, string ekskursii, string zabolevanie)
            : base(putevka, prodol, stoimost, ekskursii)
        {

            this.zabolevanie = zabolevanie;
        }

        public string Zzabolevanie
        {
            get { return zabolevanie; }
            set { zabolevanie = value; }
        }
        public override string print()
        {
            return base.print() + "; Заболевание  " + zabolevanie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Turagenstvo> q = new List<Turagenstvo>();

            Sanatorii san1 = new Sanatorii("Урал", " 14 дней", 37800, "Есть", "Алергия");
            Sanatorii san2 = new Sanatorii("Загран", " 21 дней", 12800, "Нет", "еаси");

            Turist tur1 = new Turist("Росс-Тур", "7 ночей", 38657, "Есть", "Сложный", "Не нужна");
            Turist tur2 = new Turist("ТурТур", "атата", 38657, "Нету", "Легкий", "Не нужна");

            q.Add(san1);
            q.Add(san2);

            q.Add(tur1);
            q.Add(tur2);

            var a = q.ToArray();

            foreach (Turagenstvo w in a)
            {
                Console.WriteLine(w.print());
            }

            Console.WriteLine("\nСортировка по Путевке\n");
            Array.Sort(a, new SortPoPutevke());

            foreach (Turagenstvo w in a)
            {
                Console.WriteLine(w.print());
            }

            Console.WriteLine("\nСортировка по Продолжительности\n");
            Array.Sort(a, new SortPoProdoljitelnosti());

            foreach (Turagenstvo w in a)
            {
                Console.WriteLine(w.print());
            }


            Console.ReadKey();
        }
    }
}
