namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            int z = 1; switch (2 * x)

            {

                case 1:

                    z = 10;

                    break;

                case 2:

                    z *= x;

                    break;

                case 4:

                    z += x + 5;

                    break;

                case 6:

                case 8:

                    z = 3;

                    break;

                default:

                    z = 0;

                    break;

            }
            Console.WriteLine(z);
        }
    }
}
