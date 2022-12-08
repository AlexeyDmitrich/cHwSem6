using MyMethods;
MyMethod my = new MyMethod();

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
3 -> 11
2 -> 10
*/

int number = my.IntInput("любое целое число");
int[] binNumber = TenToBin(number);
my.Print(binNumber);


int[] TenToBin (int num){
    int numRange = 0;
    int numTemp = num;
    while (numTemp > 0){
    numTemp /= 2;
    numRange ++;
    //my.Print(numRange);
    }
    int length = numRange;
    int[] arr = new int[length];
    for (int i = length-1; i >= 0; i--)
    {
        arr[i] = num%2;  // 45%2 =1
        num = num/2;
       // my.Print(arr[i]);
    }
    
    return arr;
}