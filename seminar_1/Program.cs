Console.WriteLine("Задача 2:");

int gamma = 5;
int beta = 7;

if (gamma < beta){
    Console.WriteLine("Самое большое число: " + beta);
}else{
    Console.WriteLine("Самое большое число: " + gamma);
}

int gamma2 = 2;
int beta2 = 10;

if (gamma2 < beta2){
    Console.WriteLine("Самое большое число: " + beta2);
}else{
    Console.WriteLine("Самое большое число: " + gamma2);
}

int gamma3 = -9;
int beta3 = -3;

if (gamma3 < beta3){
    Console.WriteLine("Самое большое число: " + beta3);
}else{
    Console.WriteLine("Самое большое число: " + gamma3);
}

Console.WriteLine("Задача 4:");

int alfa = 2;
int vita = 3;
int delta = 7;


int[] numbers = {alfa, vita, delta};
int result = numbers[0];

for(int i = 0; i < numbers.Length; i++){
    if(numbers[i] >= result){
       result = numbers[i];
    }
}
Console.WriteLine("Самое большое число: " + result);

int alfa2 = 44;
int vita2 = 5;
int delta2 = 78;

int[] numbers2 = {alfa2, vita2, delta2};
int result2 = numbers2[0];

for(int i = 0; i < numbers2.Length; i++){
    if(numbers2[i] >= result2){
       result2 = numbers2[i];
    }
}
Console.WriteLine("Самое большое число: " + result2);

int alfa3 = 22;
int vita3 = 3;
int delta3 = 9;


int[] numbers3 = {alfa3, vita3, delta3};
int result3 = numbers3[0];

for(int i = 0; i < numbers3.Length; i++){
    if(numbers3[i] >= result3){
       result3 = numbers3[i];
    }
}
Console.WriteLine("Самое большое число: " + result3);

Console.WriteLine("Задача 6:");

double omega = 4;

if(omega % 2 == 0){
    Console.WriteLine("Число четное");
}else{
    Console.WriteLine("Число не четное");
}

double omega2 = -3;

if(omega2 % 2 == 0){
    Console.WriteLine("Число четное");
}else{
    Console.WriteLine("Число не четное");
}

double omega3 = 7;

if(omega3 % 2 == 0){
    Console.WriteLine("Число четное");
}else{
    Console.WriteLine("Число не четное");
}

Console.WriteLine("Задача 8:");

int N = new Random().Next(1, 11);
Console.WriteLine("Случайное число: " + N);
for (int i = 2; i <= N; i+=2){
    Console.WriteLine(i);
}