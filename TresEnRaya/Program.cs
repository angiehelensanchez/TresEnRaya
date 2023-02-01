using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tablero = new char[3, 3];
            Console.WriteLine(TableroVisual(tablero));
            Console.ReadLine();
        }

        static void InicializarTablero(ref char [,] tablero)
    {
        for(int contador1 = 0; contador1 < 3; contador1++)
        {
                for (int contador2 = 0; contador2 < 3; contador2++)
                {
                    tablero[contador1, contador2] = ' ';
                }
        }
    }
        static string TableroVisual(char[,] tablero)
        {
            string tableroVisual = "";
            tableroVisual = "    A  B  C" + Environment.NewLine;
            tableroVisual += "  ┌───┬───┬───┐" + Environment.NewLine;
            tableroVisual += $"1 │ {tablero[0,0]} │ {tablero[0,1]} │ {tablero[0,2]} │" + Environment.NewLine;
            tableroVisual += "  ├───┼───┼───┤" + Environment.NewLine;
            tableroVisual += $"2 │ {tablero[1,0]} │ {tablero[1,1]} │ {tablero[1,2]} │" + Environment.NewLine;
            tableroVisual += "  ├───┼───┼───┤" + Environment.NewLine;
            tableroVisual += $"3 │ {tablero[2,0]} │ {tablero[2,1]} │ {tablero[2,2]} │" + Environment.NewLine;
            tableroVisual += "  └───┴───┴───┘" + Environment.NewLine;
            return tableroVisual;
        }

        static bool haGanadoAlguien(char[,] tablero)
        {
            
        }
    }
}