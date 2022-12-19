/* 
КВАДРАТ ЧИСЛА

Console.WriteLine("Введи число ");
int number = int.Parse(Console.ReadLine()!);
//Математический
int sqr = number * number;

// C библиотекой
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine($"Квадрат числа {number} является число: математический {sqr}, c библиотекой {sqr1}");
*/


/*
ЧИСЛА ОТ -n ДО n

Console.WriteLine("Введи число ");
int num = int.Parse(Console.ReadLine()!);
int num1 = -num;

while (num1 <= num){
Console.Write($"{num1} ");
num1 ++;    
}
*/


/*

ПРОВЕРКА ЯВЛЯЕТСЯ ЛИ ЧИСЛО КВАДРАТОМ ВОТОРОГО ЧИСЛА

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Clear();
if(num1 == num2 * num2){
    Console.WriteLine($"Число {num1} является квадратом {num2}");
    }
    else{
        Console.WriteLine($"НЕТ!!! Число {num1} не является квадратом {num2}!");
    }
    */


/*

ДЕНЬ НЕДЕЛИ ПО ЕГО НОМЕРУ



    Console.WriteLine("Введи число от 1 до 7:");
int num = int.Parse(Console.ReadLine()!);
if(num == 1){
    Console.WriteLine("Понедельник");
}
else if(num == 2){
    Console.WriteLine("Вторнк");}
else if(num == 3){
    Console.WriteLine("Среда");}
else if(num == 4){
    Console.WriteLine("Четверг");}
else if(num == 5){
    Console.WriteLine("Пятница");}
else if(num == 6){
    Console.WriteLine("Суббота");}
else if(num == 7){
    Console.WriteLine("Восткресенье");}
else{
Console.WriteLine("Введите число от 1 до 7!!!");}
*/

/*

ВЫВОД ПОСЛЕДНЕЙ ЦИФРЫ ТРЕХЗНАЧНОГО ЧИСЛА


Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num % 10;
Console.Clear();
Console.Write($"Последняя цифра числа {num}: {result}");
*/

