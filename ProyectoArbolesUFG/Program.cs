/* Proyecto hecho por: Grupo 3
Iván Enrique Galdámez Guzmán. GG100221
Jasson Ernesto García Cortez. GC100720
Erick Bladimir Gómez Hernández. GH100321
María José Granillo Guardado. GG101921
Diego Ernesto Guerrero Zarate. GZ100221 
 */

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

            #region Creación del menú y lista

            // Menu
            cArbol menu = new cArbol();
            cNodo raiz = menu.Insertar("Menú", TipoNodo.Categoría, null);

            // Desayuno
            n1 = menu.Insertar("Desayuno", TipoNodo.Categoría, raiz);
            // Tipicos
            n2 = menu.Insertar("Típicos", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Pupusas", TipoNodo.Comida, 0.75f, n2);

            n3 = menu.Insertar("Empanadas", TipoNodo.Comida, 1.6f, n2);

            n3 = menu.Insertar("Típicos con plátanos", TipoNodo.Comida, 0.5f, n2);
            // Americanos
            n2 = menu.Insertar("Americanos", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Hotcakes", TipoNodo.Comida, 0.25f, n2);

            // Almuerzo
            n1 = menu.Insertar("Almuerzo", TipoNodo.Categoría, raiz);

            n2 = menu.Insertar("Pollo", TipoNodo.Comida, 15f, n1);

            n2 = menu.Insertar("Pescado", TipoNodo.Comida, 12f, n1);

            n2 = menu.Insertar("Carne de res", TipoNodo.Comida, 30f, n1);

            // Cena
            n1 = menu.Insertar("Cena", TipoNodo.Categoría, raiz);

            n2 = menu.Insertar("Tamales", TipoNodo.Comida, 1.5f, n1);

            n2 = menu.Insertar("Pasta", TipoNodo.Comida, 2f, n1);

            // Postre
            n1 = menu.Insertar("Postre", TipoNodo.Categoría, raiz);

            n2 = menu.Insertar("Pan dulce", TipoNodo.Comida, 0.25f, n1);
            // Repostaría
            n2 = menu.Insertar("Repostería", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Tartaletas", TipoNodo.Comida, 3.5f, n2);

            n3 = menu.Insertar("Brownie", TipoNodo.Comida, 1.25f, n2);
            // Pastel
            n2 = menu.Insertar("Pasteles", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Pastel de Limón", TipoNodo.Comida, 10f, n2);

            n3 = menu.Insertar("Pastel de Fresa", TipoNodo.Comida, 12f, n2);

            n3 = menu.Insertar("Pastel de Chocolate", TipoNodo.Comida, 12f, n2);

            n2 = menu.Insertar("Helado", TipoNodo.Comida, 2f, n1);

            // Bebida
            n1 = menu.Insertar("Bebida", TipoNodo.Categoría, raiz);
            // Frías
            n2 = menu.Insertar("Frías", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Malteada", TipoNodo.Comida, 5f, n2);

            n3 = menu.Insertar("Limonada", TipoNodo.Comida, 6f, n2);
            // Calientes
            n2 = menu.Insertar("Calientes", TipoNodo.Categoría, n1);

            n3 = menu.Insertar("Té", TipoNodo.Comida, 1.25f, n2);

            n3 = menu.Insertar("Café", TipoNodo.Comida, 2f, n2);


            // Lista de ordenes guardadas
            cListaLigada ordenesGuardadas = new cListaLigada();

            #endregion

            #region Bienvenida y opciones

            do
            {
                Console.Clear();

                Console.WriteLine("Bienvenido a .NET Restaurant\nIngrese la opción que sea realizar:");
                Console.WriteLine("[1] Consultar menú\n[2] Ver platos pedidos\n[3] Pagar pedido\n[0] Salir");

                opcion = dialogos.IngresarOpcionNumerica();

                switch (opcion)
                {
                    // Consultar menú
                    case 1:
                        dialogos.MostrarOpcionesMenu(menu, raiz, ordenesGuardadas);
                        break;

                    // Ver platos pedidos
                    case 2:
                        ordenesGuardadas.Transversa(false);

                        Console.WriteLine("\nPresione cualquier tecla para salir...");
                        Console.ReadKey();
                        break;

                    // Pagar pedido
                    case 3:
                        ordenesGuardadas.Transversa(true);

                        if (ordenesGuardadas.Cantidad() > 0)
                        {
                            Console.WriteLine("\n¿Desea pagar sus órdenes?:");
                            Console.WriteLine("[1] Sí\n[0] No");

                            int confirmarPago = dialogos.IngresarOpcionNumerica();

                            switch (confirmarPago)
                            {
                                // Sí
                                case 1:
                                    // Limpiar la lista de órdenes
                                    ordenesGuardadas.LimpiarLista();

                                    Console.WriteLine("Órdenes pagadas, gracias por preferirnos");
                                    break;

                                default:
                                    Console.WriteLine("Las órdenes no se han pagado");
                                    break;
                            }
                        }

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 0:
                        salir = true;
                        Console.WriteLine("Saliendo del sistema, gracias por preferirnos");
                        Console.ReadKey();
                        break;

                    default:
                        // Si se ingresa un input que no sea numérico, simplemente se repite el bucle una vez más
                        break;
                }

            }
            while (!salir);

            


            #endregion
        }

        // Evitar una Exception cuando se ingresa un valor no numérico
        public int IngresarOpcionNumerica()
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

        private void MostrarOpcionesMenu(cArbol menu, cNodo raiz, cListaLigada ordenesGuardadas)
        {
            int opcion;
            bool salir = false;

            do
            {
                Console.Clear();

                // Mostrar el menú completo
                menu.TransversaPreorder(raiz);

                Console.WriteLine("\nIngrese una opción:");
                Console.WriteLine("[1] Ingresar un pedido\n[0] Salir");

                opcion = IngresarOpcionNumerica();

                switch (opcion)
                {
                    case 1:
                        string plato; // Guardará el string que el usuario ingresará cuando le pida escribir el nombre del plato
                        cNodo guardarPlato = null; // El nodo encontrado en el árbol será guardado en este puntero

                        Console.WriteLine("\nIngrese el nombre del plato:");
                        plato = Console.ReadLine();

                        // Guardar el nodo con el dato que el usuario ingresó
                        menu.AgarrarNodo(raiz, plato, ref guardarPlato);

                        // En el caso que el nodo ingresado sí existe en el árbol 
                        if (guardarPlato != null)
                        {
                            // Verificar si el nodo es de tipo Comida
                            if (guardarPlato.Tipo == TipoNodo.Comida)
                            {
                                Console.WriteLine($"\nEl producto: {guardarPlato.Dato} cuesta ${guardarPlato.Precio}.\n¿Desea agregarlo a su orden?\n[1] Sí\n[0] No");

                                int confirmarPlato = IngresarOpcionNumerica();

                                switch (confirmarPlato)
                                {
                                    // Sí
                                    case 1:

                                        Console.WriteLine("\nIngrese la cantidad de su orden:");

                                        int cantidadPlato = IngresarOpcionNumerica();

                                        if (cantidadPlato > 0)
                                        {
                                            ordenesGuardadas.Adicionar(guardarPlato, cantidadPlato);

                                            Console.WriteLine("Plato guardado a su orden.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Error: Cantidad no válida");
                                        }
                                            
                                        break;
                                    // No o cualquier otra acción
                                    default:
                                        Console.WriteLine("El plato no se guardó a su orden.");
                                        break;
                                }
                            }
                            // Pero si es de tipo Categoría
                            else if (guardarPlato.Tipo == TipoNodo.Categoría)
                            {
                                Console.WriteLine("Error: El dato que usted ingresó no es un producto que usted pueda ordenar");
                            }
                        }
                        // En el caso que el nodo no existe
                        else
                        {
                            Console.WriteLine("Error: El dato que usted ingresó no existe");
                        }

                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();

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