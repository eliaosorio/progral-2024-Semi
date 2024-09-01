using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    class Program

        using System;

class Program
    {
        static void Main()
        {
            MenuConversores();
        }

        static void MenuConversores()
        {
            int i = 1;
            while (i == 1)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Conversores");
                Console.WriteLine("1. Monedas");
                Console.WriteLine("2. Masas");
                Console.WriteLine("3. Volumen");
                Console.WriteLine("4. Tiempo");
                Console.WriteLine("5. Area");
                Console.WriteLine("0-) Regresar");
                Console.Write("Elija una categoria: ");
                int op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                if (op == 1)
                {
                    MenuMonedas();
                    i = 1;
                }
                else if (op == 2)
                {
                    MenuMasa();
                    i = 1;
                }
             
                else if (op == 3)
                {
                    MenuVolumen();
                    i = 1;
                }
                else if (op == 4)
                {
                    MenuTiempo();
                    i = 1;
                }
                else if (op == 5)
                {
                    MenuVolumen();
                    i = 1;
                }
                else if (op == 6)
                {
                    MenuArea();
                    i = 1;
                }
                else if (op == 0)
                {
                    i = 0;
                }
                else if (op > 7)
                {
                    Console.WriteLine("Opcion no valida");
                    Console.WriteLine("Presiona enter para continuar " + "\n");
                    Console.ReadLine();
                    i = 1;
                }
            }
        }

        static void MenuMonedas() { /* Implementacion */ }
        static void MenuLongitud() { /* Implementacion */ }
        static void MenuMasa() { /* Implementacion */ }
        static void MenuAlmacen() { /* Implementacion */ }
        static void MenuTiempo() { /* Implementacion */ }
        static void MenuVolumen() { /* Implementacion */ }
        static void MenuArea() { /* Implementacion */ }
    }



    {
        static void Menu monedas(string[] args)
        {
            int m = 1;
            while (m == 1)
            {
                Console.WriteLine("CONVERSOR de Monedas");


                Console.WriteLine("1-) Dolares a Pesos Chilenos");
                Console.WriteLine("2-) Pesos Chilenos a Dolares");
                Console.WriteLine("3-) Dolares a Euros");
                Console.WriteLine("4-) Euros a Dolares");
                Console.WriteLine("5-) Pesos Mexicanos a Dolares");
                Console.WriteLine("6-) Dolares a Pesos Mexicanos");
                Console.WriteLine("7-) Dolares a Yenes");
                Console.WriteLine("8-) Yenes a Dolares");
                Console.WriteLine("9-) Dolares a Yuanes");
                Console.WriteLine("10-) Yuanes a Dolares");
                Console.WriteLine("0-) Regresar");
                Console.WriteLine("");

                int hl = Convert.ToInt32(Console.ReadLine());
                if (hl == 1)
                {
                    Console.WriteLine("Cantidad en Dolares: ");
                    var mon1 = Convert.ToInt32(Console.ReadLine());
                    double v1 = mon1 * 937.55;
                    Console.WriteLine("Pesos Chilenos = " + v1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 2)
                {
                    Console.Write("Cantidad de Pesos Chilenos: ");
                    double mon2 = Convert.ToDouble(Console.ReadLine());
                    double v2 = mon2 / 937.55;
                    Console.WriteLine("Dolares = " + v2);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 3)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon3 = Convert.ToInt32(Console.ReadLine());
                    double v3 = mon3 * 0.9121;
                    Console.WriteLine("Euros = " + v3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 4)
                {
                    Console.Write("Cantidad de Euros: ");
                    int mon4 = Convert.ToInt32(Console.ReadLine());
                    double v4 = mon4 / 0.9121;
                    Console.WriteLine("Dolares = " + v4);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 5)
                {
                    Console.Write("Cantidad de Pesos Mexicanos: ");
                    int mon5 = Convert.ToInt32(Console.ReadLine());
                    double v5 = mon5 / 18.64;
                    Console.WriteLine("Dolares = " + v5);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 6)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon6 = Convert.ToInt32(Console.ReadLine());
                    double v6 = mon6 * 18.64;
                    Console.WriteLine("Pesos Mexicanos = " + v6);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 7)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon7 = Convert.ToInt32(Console.ReadLine());
                    double v7 = mon7 * 148.92;
                    Console.WriteLine("Yenes = " + v7);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 8)
                {
                    Console.Write("Cantidad de Yenes: ");
                    int mon8 = Convert.ToInt32(Console.ReadLine());
                    double v8 = mon8 / 148.92;
                    Console.WriteLine("Dolares = " + v8);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 9)
                {
                    Console.Write("Cantidad de Dolares: ");
                    int mon9 = Convert.ToInt32(Console.ReadLine());
                    double v9 = mon9 * 7.1767;
                    Console.WriteLine("Yuanes = " + v9);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 10)
                {
                    Console.Write("Cantidad de Yuanes: ");
                    int mon10 = Convert.ToInt32(Console.ReadLine());
                    double v10 = mon10 / 7.1767;
                    Console.WriteLine("Dolares = " + v10);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 0)
                {
                    m = 0;
                }
                else
                {
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
            }
        }
        static void Menu de masa(string[] args)
        {
            { // CONVERSOR DE MASAS
                Console.WriteLine("Conversor de Masas");
                Console.WriteLine(" ");


                double kilogramos;

                Console.WriteLine("Ingrese la cantidad de kilogramos: ");
                kilogramos = double.Parse(Console.ReadLine());


                double toneladas = kilogramos / 1000;
                double toneladasl = kilogramos / 1016;
                double gramos = kilogramos * 1000;
                double libras = kilogramos * 2.205;
                double onzas = kilogramos * 35.274;
                double stones = kilogramos / 6.35;
                double miligramos = kilogramos * 0.000001;
                double microgramos = kilogramos * 0.000000001;
                double hectogramos = kilogramos * 10;
                double decagramos = kilogramos * 100;

                Console.WriteLine("-----------------------------");
                Console.WriteLine(" 1).TONELADAS " + toneladas.ToString("0.00"));
                Console.WriteLine(" 2).TONELADAS LARGAS " + toneladasl.ToString("0.00"));
                Console.WriteLine(" 3).GRAMOS " + gramos.ToString("0.00"));
                Console.WriteLine(" 4).LIBRAS " + libras.ToString("0.00"));
                Console.WriteLine(" 5).ONZAS " + onzas.ToString("0.00"));
                Console.WriteLine(" 6).STONE " + stones.ToString("0.00"));
                Console.WriteLine(" 7).MILIGRAMOS " + miligramos.ToString("0.00"));
                Console.WriteLine(" 8).MICROGRAMOS " + microgramos.ToString("0.00"));
                Console.WriteLine(" 9).HECTOGRAMOS " + hectogramos.ToString("0.00"));
                Console.WriteLine(" 10).DECAGRAMOS " + decagramos.ToString("0.00"));


                Console.ReadLine();
            }

        }
        static void Menu de volumen(string[] args)
        {

            int m = 1;
            while (m == 1)
            {
                Console.WriteLine("CONVERSOR DE VOLUMEN");


                Console.WriteLine("1-) litros a mililitros ");
                Console.WriteLine("2-) mililitros a litros ");
                Console.WriteLine("3-) litros a metros cubicos ");
                Console.WriteLine("4-) metros cubicos a litros ");
                Console.WriteLine("5-) litros a pies cubicos ");
                Console.WriteLine("6-) pies cubicos a litros ");
                Console.WriteLine("7-) litros a pulgadas cubicas ");
                Console.WriteLine("8-) pulgadas cubicas a litros ");
                Console.WriteLine("9-) litros a galones ");
                Console.WriteLine("10-) galones a litros ");
                Console.WriteLine("0-) Regresar o Salir del conversor...");
                Console.WriteLine("");



                double vl = Convert.ToDouble(Console.ReadLine());
                if (vl == 1)

                {
                    Console.WriteLine("cantidad de litros: ");
                    double litros = Convert.ToDouble(Console.ReadLine());
                    double mililitros = litros * 1000;
                    Console.WriteLine("ml = " + mililitros);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (vl == 2)
                {
                    Console.WriteLine("cantidad de mililitros: ");
                    double mililitros1 = Convert.ToDouble(Console.ReadLine());
                    double litros1 = mililitros1 / 1000;
                    Console.WriteLine("lt = " + litros1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (vl == 3)
                {
                    Console.WriteLine("cantidad de litros: ");
                    double litros2 = Convert.ToDouble(Console.ReadLine());
                    double mtr3 = litros2 / 1000;
                    Console.WriteLine("mtrs cubicos = " + mtr3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (vl == 4)
                {

                    Console.WriteLine("cantidad de metros cubicos: ");
                    double mtcub = Convert.ToDouble(Console.ReadLine());
                    double litros3 = mtcub * 1000;
                    Console.WriteLine("lt = " + litros3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (vl == 5)
                {
                    Console.WriteLine("cantidad de litros: ");
                    double litros4 = Convert.ToDouble(Console.ReadLine());
                    double pies = litros4 * 28.317;
                    Console.WriteLine("Pies cubicos = " + pies);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (vl == 6)
                {
                    Console.WriteLine("cantidad de pies cubicos: ");
                    double pies2 = Convert.ToDouble(Console.ReadLine());
                    double litros5 = pies2 / 28.317;
                    Console.WriteLine("lt = " + litros5);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (vl == 7)
                {
                    Console.WriteLine("cantidad de litros: ");
                    double litros6 = Convert.ToDouble(Console.ReadLine());
                    double pulgcub = litros6 * 61.024;
                    Console.WriteLine("pulgadas cubicas = " + pulgcub);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (vl == 8)
                {
                    Console.WriteLine("cantidad de pulgadas cubicas: ");
                    double pulg3 = Convert.ToDouble(Console.ReadLine());
                    double litros7 = pulg3 / 61.024;
                    Console.WriteLine("lt = " + litros7);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (vl == 9)
                {
                    Console.WriteLine("cantidad de litros: ");
                    double litros8 = Convert.ToDouble(Console.ReadLine());
                    double gals = litros8 / 3.785;
                    Console.WriteLine("Galon Estadounidense = " + gals);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (vl == 10)
                {
                    Console.WriteLine("cantidad de Galones: ");
                    double gals1 = Convert.ToDouble(Console.ReadLine());
                    double litros9 = gals1 * 52.143;
                    Console.WriteLine("lt = " + litros9);
                    Console.WriteLine("Presiona enter para continuar");

                    Console.ReadLine();
                }
                else if (vl == 0)
                {
                    m = 0;
                }
                else
                {

                    Console.WriteLine("Opcion invalida!");
                    Console.ReadLine();
                }

            }

        }
        static void Menu de longitub(string[] args)
        {
            Console.WriteLine("CONVERSOR DE LONGITUD");

            Console.WriteLine("1-) metros a pies");
            Console.WriteLine("2-) pies a metros");
            Console.WriteLine("3-) pulgadas a centimetros");
            Console.WriteLine("4-) centimetros a pulgadas");
            Console.WriteLine("5-) kilometros a metros");
            Console.WriteLine("6-) metros a kilometros");
            Console.WriteLine("7-) yardas a millas");
            Console.WriteLine("8-) millas a yardas");
            Console.WriteLine("9-) metros a milimetros");
            Console.WriteLine("10-) milimetros a metros");
            Console.WriteLine("0-) Regresar");
            Console.WriteLine("");

            double valor = Convert.ToDouble(Console.ReadLine());

            double hl = Convert.ToDouble(Console.ReadLine());
            if (hl == 1)

            {
                Console.WriteLine("cantidad de metros: ");
                double metros = Convert.ToDouble(Console.ReadLine());
                double pies = metros * 3.28084;
                Console.WriteLine("pies = " + pies);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();
            }
            else if (hl == 2)
            {
                Console.WriteLine("cantidad de pies: ");
                double pies = Convert.ToDouble(Console.ReadLine());
                double metros1 = pies / 0.3048;
                Console.WriteLine("metros = " + metros1);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();
            }
            else if (hl == 3)
            {
                Console.WriteLine("cantidad de pulgadas: ");
                double pulgadas = Convert.ToDouble(Console.ReadLine());
                double centimetros = pulgadas * 2.54;
                Console.WriteLine("centimetros = " + centimetros);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();
            }
            else if (hl == 4)
            {

                Console.WriteLine("cantidad centimetros: ");
                double centimetros = Convert.ToDouble(Console.ReadLine());
                double pulgadas2 = centimetros / 0.393701;
                Console.WriteLine("pulgadas = " + pulgadas2);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();

            }
            else if (hl == 5)
            {
                Console.WriteLine("cantidad de kilometros: ");
                double kilometros = Convert.ToDouble(Console.ReadLine());
                double metros2 = kilometros * 100;
                Console.WriteLine("metros = " + metros2);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();

            }
            else if (hl == 6)
            {
                Console.WriteLine("cantidad de metros: ");
                double metros2 = Convert.ToDouble(Console.ReadLine());
                double kilometros1 = metros2 / 0.001;
                Console.WriteLine("kilometros = " + kilometros1);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();
            }
            else if (hl == 7)
            {
                Console.WriteLine("cantidad de yardas: ");
                double yardas = Convert.ToDouble(Console.ReadLine());
                double millas = yardas / 0.000568182;
                Console.WriteLine("millas = " + millas);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();

            }
            else if (hl == 8)
            {
                Console.WriteLine("cantidad de millas: ");
                double millas = Convert.ToDouble(Console.ReadLine());
                double yardas = millas * 1760;
                Console.WriteLine("yardas = " + yardas);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();

            }
            else if (hl == 9)
            {
                Console.WriteLine("cantidad de metros: ");
                double metros3 = Convert.ToDouble(Console.ReadLine());
                double milimetros = metros3 * 1000;
                Console.WriteLine("milimetros = " + milimetros);
                Console.WriteLine("Presiona enter para continuar");
                Console.ReadLine();

            }
            else if (hl == 10)
            {
                Console.WriteLine("cantidad de milimetros: ");
                double milimetros2 = Convert.ToDouble(Console.ReadLine());
                double metros4 = milimetros2 / 0.001;
                Console.WriteLine("metros = " + metros4);
                Console.WriteLine("Presiona enter para continuar");

                Console.WriteLine("Opcion invalida!");
                Console.ReadLine();
            }

        }
        static void Menu de almacenamiento(string[] args)
        {

            int m = 1;
            while (m == 1)
            {
                Console.WriteLine("CONVERSOR de ALMACENAMIENTO");

                Console.WriteLine("1-) bytes a kilobytes. ");
                Console.WriteLine("2-) kilobytes a Megabytes. ");
                Console.WriteLine("3-) Megabytes a Gigabytes. ");
                Console.WriteLine("4-) Gigabytes a Terabytes. ");
                Console.WriteLine("5-) Terabytes a Petabytes. ");
                Console.WriteLine("6-) bytes a bits. ");
                Console.WriteLine("7-) bits a megabits. ");
                Console.WriteLine("8-) megabits a gigabits. ");
                Console.WriteLine("9-) gigabits a terabits. ");
                Console.WriteLine("10-) terabits a bytes");
                Console.WriteLine("0-) Regresar");
                Console.WriteLine("");

                int al = Convert.ToInt32(Console.ReadLine());
                if (al == 1)
                {
                    Console.WriteLine("Cantidad en bytes: ");
                    var bytes = Convert.ToInt32(Console.ReadLine());
                    double kilobytes = bytes / 1000;
                    Console.WriteLine("kilobytes = " + kilobytes);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 2)
                {
                    Console.Write("Cantidad de kilobytes: ");
                    double kilobytes1 = Convert.ToDouble(Console.ReadLine());
                    double Megabytes = kilobytes1 / 1000;
                    Console.WriteLine("Megabytes = " + Megabytes);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 3)
                {
                    Console.Write("Cantidad de Megabytes: ");
                    int Megabytes1 = Convert.ToInt32(Console.ReadLine());
                    double Gigabytes = Megabytes1 / 1000;
                    Console.WriteLine("Gigabytes = " + Gigabytes);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 4)
                {
                    Console.Write("Cantidad de Giabytes: ");
                    int Gigabytes = Convert.ToInt32(Console.ReadLine());
                    double Terabytes = Gigabytes / 1000;
                    Console.WriteLine("Terabytes = " + Terabytes);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 5)
                {
                    Console.Write("Cantidad de Terabytes: ");
                    int Terabytes1 = Convert.ToInt32(Console.ReadLine());
                    double Petabytes = Terabytes1 / 1000;
                    Console.WriteLine("Petabytes = " + Petabytes);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 6)
                {
                    Console.Write("Cantidad de bytes: ");
                    int bytes1 = Convert.ToInt32(Console.ReadLine());
                    double bits = bytes1 * 8;
                    Console.WriteLine("bits = " + bits);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 7)
                {
                    Console.Write("Cantidad de bits: ");
                    int bits1 = Convert.ToInt32(Console.ReadLine());
                    double megabits = bits1 / 1000;
                    Console.WriteLine("megabits = " + megabits);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 8)
                {
                    Console.Write("Cantidad de megabits: ");
                    int megabits1 = Convert.ToInt32(Console.ReadLine());
                    double gigabits = megabits1 / 1000;
                    Console.WriteLine("gigabits = " + gigabits);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 9)
                {
                    Console.Write("Cantidad de gigabits: ");
                    int gigabits1 = Convert.ToInt32(Console.ReadLine());
                    double terabits = gigabits1 / 1000;
                    Console.WriteLine("terabits = " + terabits);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 10)
                {
                    Console.Write("Cantidad de terabits: ");
                    int terabits1 = Convert.ToInt32(Console.ReadLine());
                    double bytes1 = terabits1 / 8;
                    Console.WriteLine("Bytes = " + bytes1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (al == 0)
                {
                    m = 0;
                }
                else
                {
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
            }
        }
        static void Menu de tiempo(string[] args)
        {
            int m = 1;
            while (m == 1)
            {

                Console.WriteLine("CONVERSOR DE TIEMPO");
                Console.WriteLine("1-) dias a semanas ");
                Console.WriteLine("2-) semanas a dias ");
                Console.WriteLine("3-) dias a años");
                Console.WriteLine("4-) años a dias");
                Console.WriteLine("5-) minutos a horas");
                Console.WriteLine("6-) horas a minutos");
                Console.WriteLine("7-) minutos a segundos ");
                Console.WriteLine("8-) segundos a minutos");
                Console.WriteLine("9-) semanas a años");
                Console.WriteLine("10-) años a semanas ");
                Console.WriteLine("0-) Regresar");
                Console.WriteLine("");

                // double valor = Convert.ToDouble(Console.ReadLine());

                double hl = Convert.ToDouble(Console.ReadLine());
                if (hl == 1)

                {
                    Console.WriteLine("cantidad de dias: ");
                    double dias = Convert.ToDouble(Console.ReadLine());
                    double semanas = dias / 7;
                    Console.WriteLine("semanas = " + semanas);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 2)
                {
                    Console.WriteLine("cantidad de semanas: ");
                    double semanas1 = Convert.ToDouble(Console.ReadLine());
                    double dias1 = semanas1 * 7;
                    Console.WriteLine("dias = " + dias1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 3)
                {
                    Console.WriteLine("cantidad de dias: ");
                    double dias3 = Convert.ToDouble(Console.ReadLine());
                    double años = dias3 / 365;
                    Console.WriteLine("años = " + años);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 4)
                {

                    Console.WriteLine("cantidad años: ");
                    double años2 = Convert.ToDouble(Console.ReadLine());
                    double dias4 = años2 * 365;
                    Console.WriteLine("dias = " + dias4);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (hl == 5)
                {
                    Console.WriteLine("cantidad de minutos: ");
                    double minutos = Convert.ToDouble(Console.ReadLine());
                    double horas = minutos / 60;
                    Console.WriteLine("horas = " + horas);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (hl == 6)
                {
                    Console.WriteLine("cantidad de horas: ");
                    double horas1 = Convert.ToDouble(Console.ReadLine());
                    double minutos1 = horas1 * 60;
                    Console.WriteLine("minutos = " + minutos1);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();
                }
                else if (hl == 7)
                {
                    Console.WriteLine("cantidad de minutos: ");
                    double minutos2 = Convert.ToDouble(Console.ReadLine());
                    double segundos = minutos2 * 60;
                    Console.WriteLine("segundos = " + segundos);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (hl == 8)
                {
                    Console.WriteLine("cantidad de segundos: ");
                    double segundos1 = Convert.ToDouble(Console.ReadLine());
                    double minutos3 = segundos1 / 60;
                    Console.WriteLine("minutos = " + minutos3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (hl == 9)
                {
                    Console.WriteLine("cantidad de semanas: ");
                    double semanas2 = Convert.ToDouble(Console.ReadLine());
                    double años3 = semanas2 / 52.143;
                    Console.WriteLine("años = " + años3);
                    Console.WriteLine("Presiona enter para continuar");
                    Console.ReadLine();

                }
                else if (hl == 10)
                {
                    Console.WriteLine("cantidad de años: ");
                    double años4 = Convert.ToDouble(Console.ReadLine());
                    double semanas3 = años4 * 52.143;
                    Console.WriteLine("semanas = " + semanas3);
                    Console.WriteLine("Presiona enter para continuar");

                    Console.ReadLine();
                }
                else if (hl == 0)
                {
                    m = 0;
                }
                else
                {

                    Console.WriteLine("Opcion invalida!");
                    Console.ReadLine();
                }
            }
        }
    }
}





























            