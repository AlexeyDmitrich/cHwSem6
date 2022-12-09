using static MyMethods.MyMethod;
using MyMethods;
MyGenerate gen = new MyGenerate();

/*
Задача 40: Напишите программу, которая принимает на
вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int a = 3; // IntInput("длина стороны А");
int b = 4; // IntInput("длина стороны B");
int c = 5; // IntInput("длина стороны C");

bool res = IsTriangle(a, b, c);
Print(res);

bool IsTriangle (int a, int b, int c){
    return (a<(b+c) && b<(a+c) && c<(a+b));
}

