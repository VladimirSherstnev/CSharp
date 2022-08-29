Console.WriteLine("Задача 41:");

Console.Write("Введите некоторые числа, используйте пробел как разделитель: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int func1(int[] arr){
    
    int result = 0;

    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > 0){
            result++;
        }
    }
    
    return result;
}

int res41_1 = func1(arr);
Console.WriteLine("Количество чисел больше 0: " + res41_1);



Console.WriteLine("Задача 43:");
 
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");



