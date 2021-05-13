using System;

namespace day12_oop_abstract_class
{

    class Galds : Mebele
    {
        public Galds()
        {
        }


        //parrakstam bāzes klases metodi - lai pielāgotu savām vajadzībām
        
        public override void SetInfo()
        {
            string[] info = new string[4];
            info[0] = "Nosaukums: Galds";
            info[1] = "Ražotājs: ???";
            info[2] = "Izcelsmes Valsts: Ķīna ";
            info[3] = "Info: <NAV>";

            kaju_skaits = 4;
        }
        

        int kaju_skaits;
    }
    class GrozamsKresls : Mebele
    {

        public GrozamsKresls()
        {
        }

        public override void SetInfo()
        {
            string[] info = new string[4];
            info[0] = "Nosaukums: GrozamsKresls";
            info[1] = "Ražotājs: ???";
            info[2] = "Izcelsmes Valsts: Ķīna ";
            info[3] = "Info: <NAV>";

            kaju_skaits = 1;
        }

        int kaju_skaits;

    }
    class Tafele : Mebele
    {
        bool pie_sienas_liekama;

        public Tafele()
        {
        }

        public override void SetInfo()
        {
            string[] info = new string[4];
            info[0] = "Nosaukums: Tafele";
            info[1] = "Ražotājs: ???";
            info[2] = "Izcelsmes Valsts: Ķīna ";
            info[3] = "Info: <NAV>";
            pie_sienas_liekama = true;
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            //izveidojiet atsevišķā failā bāzes klasi tā, lai varētu radīt atvasinātas klases
            //klasei jābūt jēgpilnai

            //bāzes klase satur :
            //1 vai 2 laukus
            //1 vai 2 metodes



            //nav iespējas instancēt abstraktu klasi !
            //Mebele m = new Mebele();
            //m.SetInfo();
            

            Galds g = new Galds();
            g.SetInfo();


            GrozamsKresls gr = new GrozamsKresls();
            gr.SetInfo();


            Console.WriteLine("Hello World!");
        }
    }
}
