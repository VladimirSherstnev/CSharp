Console.WriteLine("Задача 25:");

int func1(int number, int degree){
    int i = 1;
    int result = number;
    while (i < degree){
        result *= number; 
        i++;
    }
    return result;
}

int res25_1 = func1(3, 5);
Console.WriteLine("Степень = " + res25_1);

int res25_2 = func1(2, 4);
Console.WriteLine("Степень = " + res25_2);



Console.WriteLine("Задача 27:");

int func2(int numb){
    int result = 0;
    string str = numb.ToString();

    for(int i = 0; i < str.Length; i++){
        char beta = str[i];
        result += int.Parse(beta.ToString());
    }
    return result;
}


int res27_1 = func2(452);
Console.WriteLine("Сумма чисел = " + res27_1); 

int res27_2 = func2(82);
Console.WriteLine("Сумма чисел = " + res27_2); 

int res27_3 = func2(9012);
Console.WriteLine("Сумма чисел = " + res27_3); 



Console.WriteLine("Задача 29:");

int[] func3(int length, int min, int max){
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max);
        } 
    return array;
}

Console.WriteLine(string.Join(" ", func3(8, 1, 21)));
Console.WriteLine(string.Join(" ", func3(8, 20, 31)));

