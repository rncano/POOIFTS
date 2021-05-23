﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_17_Clases_Abst_Computadora_
{
    class Notebook : Computadora
    {
        private string tipo_pantalla;
        private int tamaño_pantalla;
        private bool tiene_hdd = false;
        private int tamaño_disco;
        private int cant_teclas;
        private static int cont_Notebook;

        public bool Tiene_hdd { get => tiene_hdd; set => tiene_hdd = value; }

        public static int Cont_Notebook { get => cont_Notebook; set => cont_Notebook = value; }


        public Notebook()
        {
            IngresoDatosNotebook();

            Cont_Dispositivo();

        }
        public override string ToString()
        {
            string mensajeHDD = "";
            if (this.tiene_hdd)
            {
                mensajeHDD += "TIENE HDD";
            }
            else
            {
                mensajeHDD += "SIN DISCO SOLIDO";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            return ($" Dispositivo: Notebook.\n  {base.ToString()} \n Pantalla: {tipo_pantalla} \t Tamaño del dispositivo: {tamaño_pantalla} pulgadas \t Tamaño del disco: {tamaño_disco}\t Cantidad de teclas: {cant_teclas} \t {mensajeHDD}");
        }

        public void IngresoDatosNotebook()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("\n INGRESE TIPO DE PANTALLA: ");
            this.tipo_pantalla = Console.ReadLine();

            Console.Write("\n INGRESE TAMAÑO DEL DISPOSITIVO (númerico): ");
            this.tamaño_pantalla = int.Parse(Console.ReadLine());

            Console.Write("\n INGRESE TAMAÑO DEL DISCO: ");
            this.tamaño_disco = int.Parse(Console.ReadLine());


            Console.Write("\nIndique escribiendo SI o NO si tiene Disco Solido: ");
            if ("si".Equals(Console.ReadLine(), StringComparison.InvariantCultureIgnoreCase))
            {
                this.tiene_hdd = true;

            }

            Console.Write("\n Ingrese la cantidad de teclas del dispositivo: ");
            this.cant_teclas = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
        }

        public override int Cont_Dispositivo()
        {
            return cont_Notebook++;
        }
    }
}