using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    internal class Tabla
    {
        char[,] t;

        public Tabla(string fajlNev)
        {
            this.t = new char[8, 8];
            string[] beolvasas = File.ReadAllLines(fajlNev);
            for (int i = 0; i < beolvasas.Length; i++)
            {
                for (int j = 0; j < beolvasas[i].Length; j++)
                {
                    t[i, j] = beolvasas[i][j];
                }
            }
        }

        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(t[i, j]);
                }
                Console.WriteLine();
            }
        }

        public byte MezokSzama(char c)
        {
            byte darab = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (t[i, j] == c)
                    {
                        darab++;
                    }
                }
            }
            return darab;
        }

        public bool VanForditas(char jatekos, byte sor, byte oszlop, byte iranySor, byte iranyOszlop)
        {
            int aktSor, aktOszlop;
            char ellenfel;
            bool nincsEllenfel;
            aktSor = sor + iranySor;
            aktOszlop = oszlop + iranyOszlop;
            ellenfel = 'K';

            if (jatekos == 'K')
            {
                ellenfel = 'F';
            }
            nincsEllenfel = true;
            while (aktSor > 0 && aktSor < 8 && aktOszlop > 0 && aktOszlop < 8 && t[aktSor, aktOszlop] == ellenfel)
            {
                aktSor = aktSor + iranySor;
                aktOszlop = aktOszlop + iranyOszlop;
                nincsEllenfel = false;
            }
            if (nincsEllenfel || aktOszlop < 0 || aktSor > 7 || aktOszlop < 0 || aktOszlop > 7 || t[aktSor, aktOszlop] != jatekos)
            {
                return false;
            }
            return true;
        }

        public bool IsSzabalyos(char jatekos, byte sor, byte oszlop)
        {
            if (t[sor, oszlop] == '#')
            {
                bool jo = false;

                return jo;
            }
            else
            {
                return false;
            }
        }
    }
}
