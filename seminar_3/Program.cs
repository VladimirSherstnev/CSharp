Console.WriteLine("Задача 19:");

int number = 14212;

string str = number.ToString();

char[] arraynum = str.ToCharArray();
Array.Reverse(arraynum);

string rev = new string(arraynum);

if(str == rev){
    Console.WriteLine(number + " - это палиндром!");
}else{
    Console.WriteLine(number + " - это не палиндром");
}

int number2 = 12821;

string str2 = number2.ToString();

char[] arraynum2 = str2.ToCharArray();
Array.Reverse(arraynum2);

string rev2 = new string(arraynum2);

if(str2 == rev2){
    Console.WriteLine(number2 + " - это палиндром!");
}else{
    Console.WriteLine(number2 + " - это не палиндром");
}

int number3 = 23432;

string str3 = number3.ToString();

char[] arraynum3 = str3.ToCharArray();
Array.Reverse(arraynum3);

string rev3 = new string(arraynum3);

if(str3 == rev3){
    Console.WriteLine(number3 + " - это палиндром!");
}else{
    Console.WriteLine(number3 + " - это не палиндром");
}

Console.WriteLine("Задача 21:");

int[] firstdot = {3, 6, 8};
int[] seconddot = {2, 1, -7};

double result = Math.Sqrt((Math.Pow((seconddot[0]-firstdot[0]), 2)) + (Math.Pow((seconddot[1]-firstdot[1]), 2)) + (Math.Pow((seconddot[2]-firstdot[2]), 2)));

result = Math.Truncate(result * 100) / 100;

Console.WriteLine("Расстояние между двумя точками: " + result);

int[] firstdot2 = {7, -5, 0};
int[] seconddot2 = {1, -1, 9};

double result2 = Math.Sqrt((Math.Pow((seconddot2[0]-firstdot2[0]), 2)) + (Math.Pow((seconddot2[1]-firstdot2[1]), 2)) + (Math.Pow((seconddot2[2]-firstdot2[2]), 2)));

result2 = Math.Truncate(result2 * 100) / 100;

Console.WriteLine("Расстояние между двумя точками: " + result2);

Console.WriteLine("Задача 23:");

int N = new Random().Next(1, 11);
Console.WriteLine("Случайное число: " + N);
for(int i = 1; i <= N; i++){
    Console.Write(Math.Pow(i, 3) + " ");
}