﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        private int dato;
        private Nodo sig = null;
        private Nodo ant = null;

        public int Dato { get => dato; set => dato = value; }
        public Nodo Sig { get => sig; set => sig = value; }
        public Nodo Ant { get => ant; set => ant = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }

}