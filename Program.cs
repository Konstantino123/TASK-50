// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

 { 
Console.Write("Введите номер строки");
int a = Int32.Parse(Console.ReadLine()) -1; 
Console.Write("Введите номер столбца");
int b = Int32.Parse(Console.ReadLine()) -1;
if (a > m && b > n)
Console.WriteLine("Нет такого");
else
{
    object c = numbs.GetValue(a,b);
    Console.WriteLine(c);
}
}

