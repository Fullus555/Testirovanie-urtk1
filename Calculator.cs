namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Calculator();
        }
    }


    public class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Введите 1 число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 2 число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Сложение (+)");
            Console.WriteLine("2 - Вычитание (-)");
            Console.WriteLine("3 - Умножение (*)");
            Console.WriteLine("4 - Деление (/)");

            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case 1:
                    result = Plus(a, b);
                    break;
                case 2:
                    result = Minus(a, b);
                    break;
                case 3:
                    result = Multiply(a, b);
                    break;
                case 4:
                    if (b != 0)
                    {
                        result = Divide(a, b);
                    }
                    else
                    {
                        validOperation = false;
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    }
                    break;
                default:
                    validOperation = false;
                    Console.WriteLine("Ошибка: Неверный выбор операции.");
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Результат: {result}");
            }
        }

        public double Plus(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
