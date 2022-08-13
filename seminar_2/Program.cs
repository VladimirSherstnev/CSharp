Console.WriteLine("Задача 10:");

int N = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " + N);

string str = N.ToString();

Console.WriteLine("Вторая цифра этого числа: " + str[1]);


Console.WriteLine("Задача 13:");

int Num = new Random().Next(1, 1000);
Console.WriteLine("Случайное число: " + Num);

string STR = Num.ToString();

if(STR.Length < 3){
Console.WriteLine("Третьей цифры нет, увы"); 
}else{
Console.WriteLine("Третья цифра этого числа: " + STR[2]);
}


Console.WriteLine("Задача 15:");

int day = new Random().Next(1, 8);
Console.WriteLine("Случайное число: " + day);

if(day <= 5){
    Console.WriteLine("Это будний день, милорд. Не выходной");
}else{
    Console.WriteLine("Это выходной!");
}