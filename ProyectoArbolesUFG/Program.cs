using System;

namespace ProyectoArbolesUFG
{
    class Program
    {
        static void Main(string[] args)
        {
            cNodo n1, n2, n3, n4;

            // Menu
            cArbol menu = new cArbol();
            cNodo raiz = menu.Insertar("Menú", TipoNodo.Categoría, null);

            // Desayuno
            n1 = menu.Insertar("Desayuno", TipoNodo.Categoría, raiz);
            // Tipicos
            n2 = menu.Insertar("Típicos", TipoNodo.Categoría, n1);
            // Pupusas
            n3 = menu.Insertar("Pupusas", TipoNodo.Comida, n2);
            // Empanadas
            n3 = menu.Insertar("Empanadas", TipoNodo.Comida, n2);
            // Típico con plátanos
            n3 = menu.Insertar("Típicos con plátanos", TipoNodo.Comida, n2);
            // Americanos
            n2 = menu.Insertar("Americanos", TipoNodo.Categoría, n1);
            // Hotcakes
            n3 = menu.Insertar("Hotcakes", TipoNodo.Comida, n2);

            // Almuerzo
            n1 = menu.Insertar("Almuerzo", TipoNodo.Categoría, raiz);
            // Pollo
            n2 = menu.Insertar("Pollo", TipoNodo.Comida, n1);
            // Pescado
            n2 = menu.Insertar("Pescado", TipoNodo.Comida, n1);
            // Carne de res
            n2 = menu.Insertar("Carne de res", TipoNodo.Comida, n1);

            // Cena
            n1 = menu.Insertar("Cena", TipoNodo.Categoría, raiz);
            // Típicos
            n2 = menu.Insertar("Típicos", TipoNodo.Categoría, n1);
            // Tamales
            n3 = menu.Insertar("Tamales", TipoNodo.Comida, n2);
            // Pasta
            n2 = menu.Insertar("Pasta", TipoNodo.Comida, n1);

            // Postre
            n1 = menu.Insertar("Postre", TipoNodo.Categoría, raiz);
            // Pan dulce
            n2 = menu.Insertar("Pan dulce", TipoNodo.Comida, n1);
            // Repostaría
            n2 = menu.Insertar("Repostería", TipoNodo.Categoría, n2);
            // Tartaletas
            n3 = menu.Insertar("Tartaletas", TipoNodo.Comida, n2);
            // Brownie
            n3 = menu.Insertar("Brownie", TipoNodo.Comida, n2);
            // Pastel
            n3 = menu.Insertar("Pastel", TipoNodo.Categoría, n2);
            // Limón
            n4 = menu.Insertar("Limón", TipoNodo.Comida, n3);
            // Helado
            n3 = menu.Insertar("Helado", TipoNodo.Comida, n2);

            // Bebida
            n1 = menu.Insertar("Bebida", TipoNodo.Categoría, raiz);
            // Frías
            n2 = menu.Insertar("Frías", TipoNodo.Categoría, n1);
            // Malteada
            n3 = menu.Insertar("Malteada", TipoNodo.Comida, n2);
            // Limonada
            n3 = menu.Insertar("Limonada", TipoNodo.Comida, n2);
            // Calientes
            n2 = menu.Insertar("Calientes", TipoNodo.Categoría, n1);
            // Té
            n3 = menu.Insertar("Té", TipoNodo.Comida, n2);
            // Café
            n3 = menu.Insertar("Café", TipoNodo.Comida, n2);

            menu.TransversaPreorder(raiz);

        }
    }
}