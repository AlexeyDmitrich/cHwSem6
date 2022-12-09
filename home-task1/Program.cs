using static MyMethods.MyMethod;

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] usersArray = InputArrInt();
Print(usersArray);
int res = PositiveNumsValue(usersArray);
Print($"Введено {res} чисел больше 0");

int PositiveNumsValue (int[] array){
    int counter = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i]>0) {
            counter ++;
        }
    }
    return counter;
}