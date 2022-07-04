// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
  
  Console.Write("Введите степень: ");
  int num2 = Convert.ToInt32(Console.ReadLine());
  
  int temp = 1;
  for(int i = 0; i < num2; i++) 
  {
   temp *= num1;
  }
  Console.WriteLine("{0} ^ {1} = {2}", num1, num2, temp);