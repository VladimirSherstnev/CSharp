Console.WriteLine("Задача 34:");

int func(int length, int min, int max){
    int[] array = new int[length];
    var someList = new List<int>();
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max);
        if(array[i] % 2 == 0){
            someList.Add(array[i]);
        }
     } 
    int result = someList.Count;
    return result;
}

Console.WriteLine("Количество четных чисел в массиве: " + func(20, 100, 1000)); 



Console.WriteLine("Задача 36:");

int func2(int length, int min, int max){
    int[] array = new int[length];
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max);
        if(i % 2 !=0){
            result += array[i];
        }
        
     } 
    return result;
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + func2(20, 1, 100)); 



Console.WriteLine("Задача 38:");

int func3(int length, int min, int max){
    int[] array = new int[length];
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max);
        int maxnum = array[0];
        int minnum = array[0];
            if(maxnum < array[i]){
                maxnum = array[i];
            }else if(minnum > array[i]){
                minnum = array[i];
            }
        result = maxnum - minnum;
     } 
    return result;
}

Console.WriteLine("Разницу между максимальным и минимальным элементом массива: " + func3(20, 1, 100)); 

