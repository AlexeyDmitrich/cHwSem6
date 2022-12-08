using MyMethods;
MyMethod my = new MyMethod();

/*
Задача 40: Напишите программу, которая принимает на
вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int a = my.IntInput("длина стороны А");
int b = my.IntInput("длина стороны B");
int c = my.IntInput("длина стороны C");

bool res = IsTriangle(a, b, c);
my.Print(res);

bool IsTriangle (int a, int b, int c){
    return (a<(b+c) && b<(a+c) && c<(a+b));
}