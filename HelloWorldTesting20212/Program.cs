using System;

namespace HelloWorldTesting20212
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string NumerosRomanos(int num)
        {
            var result = "";
            var m = Decimal.Truncate(num / 1000) % 10;
            var c = Decimal.Truncate(num / 100) % 10;
            var d = Decimal.Truncate(num / 10) % 10;
            var u = Decimal.Truncate(num / 1) % 10;

            switch (m)
            {
                case 1:
                    result = result + "M";
                    break;
                case 2:
                    result = result + "MM";
                    break;
                case 3:
                    result = result + "MMM";
                    break;
                default:
                    break;
            }
            switch (c)
            {
                case 1:
                    result = result + "C";
                    break;
                case 2:
                    result = result + "CC";
                    break;
                case 3:
                    result = result + "CCC";
                    break;
                case 4:
                    result = result + "CD";
                    break;
                case 5:
                    result = result + "D";
                    break;
                case 6:
                    result = result + "DC";
                    break;
                case 7:
                    result = result + "DCC";
                    break;
                case 8:
                    result = result + "DCCC";
                    break;
                case 9:
                    result = result + "CM";
                    break;
                default:
                    break;

            }
            switch (d)
            {
                case 1:
                    result = result + "X";
                    break;
                case 2:
                    result = result + "XX";
                    break;
                case 3:
                    result = result + "XXX";
                    break;
                case 4:
                    result = result + "XL";
                    break;
                case 5:
                    result = result + "L";
                    break;
                case 6:
                    result = result + "LX";
                    break;
                case 7:
                    result = result + "LXX";
                    break;
                case 8:
                    result = result + "LXXX";
                    break;
                case 9:
                    result = result + "XC";
                    break;
                default:
                    break;
            }
            switch (u)
            {
                case 1:
                    result = result + "I";
                    break;
                case 2:
                    result = result + "II";
                    break;
                case 3:
                    result = result + "III";
                    break;
                case 4:
                    result = result + "IV";
                    break;
                case 5:
                    result = result + "V";
                    break;
                case 6:
                    result = result + "VI";
                    break;
                case 7:
                    result = result + "VII";
                    break;
                case 8:
                    result = result + "VIII";
                    break;
                case 9:
                    result = result + "IX";
                    break;
                default:
                    break;
            }
            return result; 

        }

        public string PiedraPapelyTijera(Jugador j1, Jugador J2)
        {

            return "";

        }
    }

}
