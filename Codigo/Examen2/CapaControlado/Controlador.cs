﻿using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlado
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public string[] items(string tabla, string campo1, string campo2)
        {
            string[] Items = sn.llenarCmb(tabla, campo1, campo2);

            return Items;


        }

        ///Controlador 2///

        public DataTable enviar(string tabla, string campo1, string campo2)
        {
            var dt1 = sn.obtener(tabla, campo1, campo2);
            return dt1;
        }
    }
}
