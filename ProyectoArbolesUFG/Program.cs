using System;

namespace ProyectoArbolesUFG
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            Program dialogos = new Program();

            cNodo n1, n2, n3, n4;

            int opcion;
            bool salir = false;

            #endregion

            #region Creación del menú

            // Menu
            cArbol menu = new cArbol();
            cNodo raiz = menu.Insertar("Menú", TipoNodo.Categoría, null);

            // Desayuno
            n1 = menu.Insertar("Desayuno", TipoNodo.Categoría, raiz);
            // Tipicos
            n2 = menu.Insertar("Típicos", TipoNodo.Categoría, n1);
            // Pupusas
            n3 = menu.Insertar("Pupusas", TipoNodo.Comida, 10, n2);
            // Empanadas
            n3 = menu.Insertar("Empanadas", TipoNodo.Comida, 20, n2);
            // Típico con plátanos
            n3 = menu.Insertar("Típicos con plátanos", TipoNodo.Comida, 30, n2);
            // Americanos
            n2 = menu.Insertar("Americanos", TipoNodo.Categoría, n1);
            // Hotcakes
            n3 = menu.Insertar("Hotcakes", TipoNodo.Comida, 40, n2);

            // Almuerzo
            n1 = menu.Insertar("Almuerzo", TipoNodo.Categoría, raiz);
            // Pollo
            n2 = menu.Insertar("Pollo", TipoNodo.Comida, 50, n1);
            // Pescado
            n2 = menu.Insertar("Pescado", TipoNodo.Comida, 60, n1);
            // Carne de res
            n2 = menu.Insertar("Carne de res", TipoNodo.Comida, 70, n1);

            // Cena
            n1 = menu.Insertar("Cena", TipoNodo.Categoría, raiz);
            // Típicos
            n2 = menu.Insertar("Típicos", TipoNodo.Categoría, n1);
            // Tamales
            n3 = menu.Insertar("Tamales", TipoNodo.Comida, 80, n2);
            // Pasta
            n2 = menu.Insertar("Pasta", TipoNodo.Comida, 90, n1);

            // Postre
            n1 = menu.Insertar("Postre", TipoNodo.Categoría, raiz);
            // Pan dulce
            n2 = menu.Insertar("Pan dulce", TipoNodo.Comida, 101.1f, n1);
            // Repostaría
            n2 = menu.Insertar("Repostería", TipoNodo.Categoría, n2);
            // Tartaletas
            n3 = menu.Insertar("Tartaletas", TipoNodo.Comida, 102.2f, n2);
            // Brownie
            n3 = menu.Insertar("Brownie", TipoNodo.Comida, 103.3f, n2);
            // Pastel
            n3 = menu.Insertar("Pastel", TipoNodo.Categoría, n2);
            // Limón
            n4 = menu.Insertar("Limón", TipoNodo.Comida, 104.4f, n3);
            // Helado
            n3 = menu.Insertar("Helado", TipoNodo.Comida, 105.5f, n2);

            // Bebida
            n1 = menu.Insertar("Bebida", TipoNodo.Categoría, raiz);
            // Frías
            n2 = menu.Insertar("Frías", TipoNodo.Categoría, n1);
            // Malteada
            n3 = menu.Insertar("Malteada", TipoNodo.Comida, 106.6f, n2);
            // Limonada
            n3 = menu.Insertar("Limonada", TipoNodo.Comida, 107.7f, n2);
            // Calientes
            n2 = menu.Insertar("Calientes", TipoNodo.Categoría, n1);
            // Té
            n3 = menu.Insertar("Té", TipoNodo.Comida, 108.8f, n2);
            // Café
            n3 = menu.Insertar("Café", TipoNodo.Comida, 109.9f, n2);

            #endregion

            #region Bienvenida y opciones

            do
            {
                Console.Clear();

                Console.WriteLine("Bienvenido al restaurante AAA:\nIngrese la opción que sea realizar:");
                Console.WriteLine("[1] Consultar menú\n[2] Ver platos pedidos\n[3] Pagar pedido\n[0] Salir");

                
                opcion = dialogos.IngresarOpcion();

                switch (opcion)
                {
                    // Consultar menú
                    case 1:
                        dialogos.MostrarOpcionesMenu(menu, raiz);
                        break;

                    // Ver platos pedidos
                    case 2:
                        // Llamar esto
                        // Se recomienda usar listas ligadas para poder guardas los platos que se van ingresando
                        break;

                    // Pagar pedido
                    case 3:
                        // Limpiar los platos pedidos y preguntar si se quiere seguir pidiendo
                        break;

                    case 0:
                        salir = true;
                        Console.WriteLine("Saliendo del sistema, gracias por preferirnos");
                        Console.ReadKey();
                        break;

                    default:
                        
                        break;
                }

            }
            while (!salir);

            


            #endregion
        }

        // Evitar una Exception cuando se ingresa un valor no numérico
        public int IngresarOpcion()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                return -1;
            }
        }

        private void MostrarOpcionesMenu(cArbol menu, cNodo raiz)
        {
            int opcion;
            bool salir = false;

            do
            {
                Console.Clear();

                menu.TransversaPreorder(raiz);

                Console.WriteLine("Ingrese una opción:");
                Console.WriteLine("[1] Ingresar un pedido\n[0] Salir");

                
                opcion = IngresarOpcion();

                switch (opcion)
                {
                    case 1:
                        string plato;

                        Console.WriteLine("Ingrese el nombre del plato:");
                        plato = Console.ReadLine();

                        // Pendiente: Buscar entre todos los elementos del árbol con el que coincida lo que ingresó el usuario.
                        // Luego, si estos es verdadero, imprimir su precio y preguntar por la cantidad.
                        // En caso que no exista, indicarlo
                        // En caso que el nodo no es una comida, indicarlo

                        break;
                    case 0:
                        salir = true;
                        break;
                }

            }
            while (!salir);
            
        }
    }
}