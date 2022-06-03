using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolesUFG
{
    // Este enum nos ayuda a poder categorizar el tipo de nodo que estamos ingresando. Ya sea una categoría (Como Desayuno, Almuerzo)
    // o una comida en sí (como Pupusas, Hotcakes)
    public enum TipoNodo
    {
        Categoría,
        Comida
    }

    class cNodo
    {
        // definimos el comportamiento del nodo
        private string dato;

        private cNodo hijo; // Con esto podemos asignar si tiene hijos o hermanos
        private cNodo hermano;

        private TipoNodo tipo;

        public string Dato { get => dato; set => dato = value; }
        public cNodo Hijo { get => hijo; set => hijo = value; }
        public cNodo Hermano { get => hermano; set => hermano = value; }
        public TipoNodo Tipo { get => tipo; set => tipo = value; }

        public cNodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }

        public override string ToString()
        {
            return "Dato: " + Dato + " Tipo: " + Tipo;
        }
    }
}
