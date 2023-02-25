// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = InputInt("Введите число A: ");
int numberB = InputInt("Введите число B: ");
Input(numberA, numberB);

void Input(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}