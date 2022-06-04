using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolesUFG
{
    class cArbol
    {
        private cNodo raiz;
        private cNodo trabajo; // se ocupara en las operaciones
        private int i = 0; // Con esto podemos controlar la profundidad y altura del árbol

        public cArbol()
        {
            raiz = new cNodo(); // instanciamos el nodo raiz
        }

        // Método común para insertar un nodo (para insertar un nodo de tipo Comida, consultar el otro método overloaded< Insertar)
        public cNodo Insertar(string pDato, TipoNodo pTipoNodo, cNodo pNodo)
        {
            // si no hay donde insertar, tomamos como si fuera la raiz
            if (pNodo == null)
            {
                raiz = new cNodo();
                raiz.Dato = pDato;
                raiz.Tipo = pTipoNodo;

                // como no hay hijo
                raiz.Hijo = null;

                // como no hay hermano
                raiz.Hermano = null;
                return raiz; // raiz es el nodo recién insertado
            }

            if (pNodo.Hijo == null)
            {
                cNodo temp = new cNodo();
                temp.Dato = pDato;
                temp.Tipo = pTipoNodo;

                // Conectamos el nuevo nodo como hujo
                pNodo.Hijo = temp;
                return temp;
            }
            else // si ya teien hijo, tenemos uqe insertarlo como hermano
            {
                trabajo = pNodo.Hijo;
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // creamos nodo temporal
                cNodo temp = new cNodo();
                temp.Dato = pDato;
                temp.Tipo = pTipoNodo;

                // conectamos (o unimos) a temp con el último hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }

        // Overload el método Insertar, este se usa cuando se ingresa un nodo de tipo Comida, ya que se puede ingresar el precio
        public cNodo Insertar(string pDato, TipoNodo pTipoNodo, float pPrecio, cNodo pNodo)
        {
            // si no hay donde insertar, tomamos como si fuera la raiz
            if (pNodo == null)
            {
                raiz = new cNodo();
                raiz.Dato = pDato;
                raiz.Tipo = pTipoNodo;
                raiz.Precio = pPrecio;

                // como no hay hijo
                raiz.Hijo = null;

                // como no hay hermano
                raiz.Hermano = null;
                return raiz; // raiz es el nodo recién insertado
            }

            if (pNodo.Hijo == null)
            {
                cNodo temp = new cNodo();
                temp.Dato = pDato;
                temp.Tipo = pTipoNodo;
                temp.Precio = pPrecio;

                // Conectamos el nuevo nodo como hujo
                pNodo.Hijo = temp;
                return temp;
            }
            else // si ya teien hijo, tenemos uqe insertarlo como hermano
            {
                trabajo = pNodo.Hijo;
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // creamos nodo temporal
                cNodo temp = new cNodo();
                temp.Dato = pDato;
                temp.Tipo = pTipoNodo;
                temp.Precio = pPrecio;

                // conectamos (o unimos) a temp con el último hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }

        public void TransversaPreorder(cNodo pNodo)
        {
            if (pNodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write("    ");

            // Ternary operator: Asignar un valor a una variable dependiendo de la condición
            // Si el nodo es de tipo Comida, guardar el símbolo "o". Si es Categoría, guardar el símbolo "v". Si no es ninguna, guardar ""
            string tipoSimbolo = (pNodo.Tipo == TipoNodo.Comida) ? "o" : (pNodo.Tipo == TipoNodo.Categoría) ? "v" : "";

            // Mostrar el símbolo del nodo y el dato
            Console.Write($"{tipoSimbolo} {pNodo.Dato}");

            // En caso que sea un nodo Comida, mostrar el precio
            if (pNodo.Tipo == TipoNodo.Comida)
            {
                Console.Write($" (${pNodo.Precio})");
            }

            // Agregar un salto de línea sin importar el tipo de nodo
            Console.Write("\n");

            if (pNodo.Hijo != null)
            {
                i++;
                TransversaPreorder(pNodo.Hijo);
                i--;
            }

            if (pNodo.Hermano != null)
                TransversaPreorder(pNodo.Hermano);
        }

        // Agarrar el nodo que se ingresa en "stringEncontrar" y se realizará una busqueda lineal
        // Si el nodo deseado se encuentra en el árbol, se guardará en el parámetro de referencia "nodoGuardar"
        public void AgarrarNodo(cNodo pNodo, string stringEncontrar, ref cNodo nodoGuardar)
        {
            // Si el nodo no existe, 
            if (pNodo == null)
                return;

            // Si el dato ingresado coincide con el dato del nodo actual, guardarlo en el parámetro de referencia
            if (stringEncontrar == pNodo.Dato)
            {
                nodoGuardar = pNodo;
            }
            // Pero si ese no es el nodo que se quiere encontrar:
            else
            {
                // Moverse a un hijo (en el caso que los tenga)
                if (pNodo.Hijo != null)
                    AgarrarNodo(pNodo.Hijo, stringEncontrar, ref nodoGuardar);
                // O pasarse a un hermano (en el caso que los tenga)
                if (pNodo.Hermano != null)
                    AgarrarNodo(pNodo.Hermano, stringEncontrar, ref nodoGuardar);
            }            
        }
    }
}
