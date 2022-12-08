using MyMethods.MyMethod;
MyMethod my = new MyMethod();

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

double[] userArray = my.ArrayGenD();


double[] ArrayCopy (double[] usersArray){
    double[] arrayCopied = new double[usersArray.Length];
    for (int i = 0; i<usersArray.Length; i++){
        arrayCopied[i] = usersArray[i];
    }
    return arrayCopied;
}