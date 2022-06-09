using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Unidad6
{
    class Program
    {
        class InventarioAmazon
        {

            public void AgregarProducto()
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);

                try
                {
                    Console.Clear();

                    Console.Write("Ingresa el nombre del producto: ");
                    string Nombre = Console.ReadLine();

                    Console.Write("Ingresa la descripcion del producto: ");
                    string Descripcion = Console.ReadLine();

                    Console.Write("Ingresa el precio del producto: ");
                    float Precio = float.Parse(Console.ReadLine());

                    Console.Write("Ingresa la cantidad en Stock: ");
                    int CantidadStock = int.Parse(Console.ReadLine());

                    Console.Clear();

                    sw.WriteLine("Nombre del producto: " + Nombre);
                    sw.WriteLine("Descripcion: " + Descripcion);
                    sw.WriteLine("Precio: {0:C}", Precio);
                    sw.WriteLine("Cantidad en Stock: " + CantidadStock);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.Clear();
                    Console.WriteLine("Prodcuto agregado");
                    Console.Write("\n Presione enter para terminar la Escritura de Datos y regresar al menu ");
                    sw.Close();
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            public void LimpiarInventario()
            {
                Console.WriteLine("Se limpio el inventario");
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            int opcion;
            InventarioAmazon inv = new InventarioAmazon();
            do
            {
                Console.WriteLine("---INVENTARIO AMAZON-----");
                Console.WriteLine();
                Console.WriteLine("1. Ingresar un nuevo producto");
                Console.WriteLine("2. Limpiar inventario");
                Console.WriteLine("3. Salida del programa");
                Console.Write("¿Qué opción desea? ");
                opcion = Int16.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        inv.AgregarProducto();
                        break;
                    case 2:
                        inv.LimpiarInventario();
                        break;
                    case 3:
                        Console.Write("Presione ENTER para Salir del Programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Esa Opción no Existe !!, Presione ENTER para Continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
