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
        private TipoNodo tipo;
        private float precio;
        private float cantidad;

        // Punteros para el árbol
        private cNodo hijo; // Con esto podemos asignar si tiene hijos o hermanos
        private cNodo hermano;

        // Puntero para las listas ligadsa
        private cNodo siguiente;

        public string Dato { get => dato; set => dato = value; }
        public TipoNodo Tipo { get => tipo; set => tipo = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public cNodo Hijo { get => hijo; set => hijo = value; }
        public cNodo Hermano { get => hermano; set => hermano = value; }
        public cNodo Siguiente { get => siguiente; set => siguiente = value; }

        public cNodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }

        public override string ToString()
        {
            return $"Dato: {Dato}, Tipo: {Tipo}, Precio: {Precio}, Cantidad: {Cantidad}";
        }
    }
}
