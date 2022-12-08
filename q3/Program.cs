using MyMethods;
MyMethod my = new MyMethod();

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

uint usersNumber = my.UintInput("число предела");
uint[] fib = Fibonacci(usersNumber);
my.Print(fib);


uint[] Fibonacci (uint userNum) {
    uint[] arr = new uint [userNum];
    if (!(userNum>1)) return arr;
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i<userNum; i++){
        arr[i] = arr[i-1]+arr[i-2];
    }
    return arr;
}