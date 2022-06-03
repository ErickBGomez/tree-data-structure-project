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

        public cNodo Insertar(string pDato, TipoNodo tipoNodo, cNodo pNodo)
        {
            // si no hay donde insertar, tomamos como si fuera la raiz
            if (pNodo == null)
            {
                raiz = new cNodo();
                raiz.Dato = pDato;
                raiz.Tipo = tipoNodo;

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
                temp.Tipo = tipoNodo;

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
                temp.Tipo = tipoNodo;

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

            Console.WriteLine(tipoSimbolo + " " + pNodo.Dato);

            if (pNodo.Hijo != null)
            {
                i++;
                TransversaPreorder(pNodo.Hijo);
                i--;
            }

            if (pNodo.Hermano != null)
                TransversaPreorder(pNodo.Hermano);
        }
    }
}
