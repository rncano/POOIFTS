﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_17_Clases_Abst_Computadora_
{
    class PacAllinOne : PcEscritorio
    {
        private int tipo_Pantalla;
        private int tamaño_Pantalla;
        private bool pantalla_Tactil = false;
        private int cant_teclas;
        private static int cont_PacAll;

        public bool Pantalla_Tactil { get => pantalla_Tactil; set => pantalla_Tactil = value; }
        public static int Cont_PacAll { get => cont_PacAll; set => cont_PacAll = value; }

        public PacAllinOne()
        {

            IngresoDatosPacAllInone();


        }

        public override string ToString()
        {
            string mensajepantalla = "";
            if (this.pantalla_Tactil)
            {
                mensajepantalla += "PANTALLA TACTIL: SI";
            }
            else
            {
                mensajepantalla += "PANTALLA TACTI: NO";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            return ($" Tipo de Dispositivo: PAC ALL IN ONE \t {base.ToString()}  \n Pantalla: {tipo_Pantalla} \t Tamaño del dispositivo: {tamaño_Pantalla} pulgadas \t Cantidad de teclas: {cant_teclas} \t {mensajepantalla}");
        }

        public void IngresoDatosPacAllInone()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n INGRESE TIPO (número) DE PANTALLA: ");
            this.tipo_Pantalla = int.Parse(Console.ReadLine());

            Console.Write("\n INGRESE TAMAÑO (número) DEL DISPOSITIVO: ");
            this.tamaño_Pantalla = int.Parse(Console.ReadLine());

            Console.Write("\n POSEE PANTALLA TACTIL. Escriba SI - NO:  ");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.pantalla_Tactil = false;
            }


            Console.WriteLine("\n Ingrese la cantidad de teclas del dispositivo ");
            this.cant_teclas = int.Parse(Console.ReadLine());

            cont_PacAll++;

            Console.WriteLine("\n");
        }

    }
}
