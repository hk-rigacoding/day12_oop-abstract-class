using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace day12_oop_abstract_class
{
    //bāzes klase !
    //no šīs klases atvasināsim apakšklases.
    abstract class Mebele
    {
        public Mebele()
        {
            info = new string[4];
            info[0] = "Nosaukums: ";
            info[1] = "Ražotājs: ";
            info[2] = "Izcelsmes Valsts: ";
            info[3] = "Info: ";
        }

        public void SetCena(double price)
        {
            cena = price;
        }

        //virtuāla metode, kuru mēs pārrakstīsim atšķirīgi, atkarībā no tā, 
        //kas tā būs par atvasināto klasi un kādas būs vajadzības
        //public virtual void SetInfo()
        //{
        //  kods
        //  kods
        //  kods
        //  kods
        //}


        //varbūt bāzes klasē šim kodam metodē nav jēgas
        //abstraktai metodei bāzes klasē nevar būt ķermenis (kods)

        //idejiski šai metodei ir jēga, bet tikai atvasinātajā klasē
        //pieprasu, lai visām atvasinātajā klasē būtu šī metode implementēta
        //klasei jābūt abstraktai !
        public abstract void SetInfo();



        public void SetDati(string[] dati)
        {
            info = dati;
        }



        string[] info;
        double cena;
        Color krasa;
    }
}
