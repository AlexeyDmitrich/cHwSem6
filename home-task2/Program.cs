using static MyMethods.MyMethod;
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Print("Введите значения для линейного уравнения:");
Print("  /‾");
Print(" |  y = k1 * x + b1");
Print("< ");
Print(" |  y = k2 * x + b2");
Print("  \\_");

double k1 = DoubleInput("k1");
double b1 = DoubleInput("b1");
double k2 = DoubleInput("k2");
double b2 = DoubleInput("b2");

//InterPoint();

// точка входа
//void InterPoint (){
    try {
    double xCoordinate = FindVerticalPositionX(k1, b1, k2, b2);
    double yCoordinate = FindVerticalPositionX(k1, b1, k2, b2);
    Print($"Точка пересечения прямых находится на коордитнатах: ({xCoordinate}; {yCoordinate})");
    } catch (Exception e) {
        Print($"({e.Message})");
        return;
    }
//}



bool LinearFunctionIntersection (double k1, double b1, double k2, double b2){
    bool haveIntersection = true;
    if (k1 == k2){
        if (b1 == b2) {
            Print ("прямые совпадают");
        } else {
            Print ("прямые параллельны");
        }
        haveIntersection = false;
    }
    return haveIntersection;
}

double FindVerticalPositionX (double k1, double b1, double k2, double b2){
    if (LinearFunctionIntersection(k1, b1, k2, b2)) return (b2-b1)/(k1-k2);
    else throw new Exception("Отсутствует единая точка пересечения");
}

double FindHorisontalPositionY (double k1, double b1, double k2, double b2){
    if (LinearFunctionIntersection(k1, b1, k2, b2)) return k1*(b2-b1)/(k1-k2)+b1;
    else throw new Exception("Отсутствует единая точка пересечения");
}
