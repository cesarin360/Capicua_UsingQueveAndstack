using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;


namespace Colas
{
    class Program
    {

        private static bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');

            }
            return sw;
        }

        private static void capicua()
        {
            bool capicua;
            String numero;
            Queue qt = new Queue();
            Stack pilas = new Stack();
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        qt.Enqueue(c);
                        pilas.Push(c);
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)qt.Dequeue();
                        capicua = d.Equals(pilas.Peek()); //compara la igualdad
                        pilas.Pop();
                    } while (capicua && qt.Count > 0);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"njmero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                    // vaciar estructuras

                    qt.Clear();
                    pilas.Clear();

                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }
        }
        static void Main(string[] args)
        {
            // programa capicua
            capicua();
        }
    }
}

