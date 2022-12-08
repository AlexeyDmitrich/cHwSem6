namespace MyMethods;
public class MyMethod {
    Random rnd = new Random();

    public int IntInput (string commonText){
        Console.WriteLine ($"Ожидается целое число : {commonText}");
        bool isInt = int.TryParse((Console.ReadLine()), out int num);
        if (! isInt){
            Console.WriteLine ("Недопустимый тип данных");
            return IntInput(commonText);
        } else {
            return num;
        }
    }

    public uint UintInput (string commonText){
        Console.WriteLine ($"Ожидается целое число : {commonText}");
        bool isUint = uint.TryParse((Console.ReadLine()), out uint num);
        if (! isUint){
            Console.WriteLine ("Недопустимый тип данных");
            return UintInput(commonText);
        } else {
            return num;
        }
    }

    public double DoubleInput (string commonText){
        Console.WriteLine ($"Ожидается вещественное число : {commonText}");
        bool isDouble = double.TryParse((Console.ReadLine()), out double num);
        if (! isDouble){
            Console.WriteLine ("Недопустимый тип данных");
            return DoubleInput(commonText);
        } else {
            return num;
        }
    }

    public void Print (string text){
        Console.WriteLine(text);
    }
    
    public void Print (object text){
        Console.WriteLine(text);
    }

    public void Print (object[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }

    public void Print (uint[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }
    public void Print (double[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }
    public void Print (object[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void Print (double[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public int Md (int num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    }
    public double Md (double num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    }

    // метод для генерации массива 
    public int[] ArrayGen()
    {
        int length = IntInput("длина массива");
        int min = IntInput("минимальное значение");
        int max = IntInput("максимальное значение");
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min, max);  
        }
        // отладка:
        // my.PrintArr(array);

        return array;
    }

    public double[] ArrayGenD()
    {
        int length = IntInput("длина массива");
        int min = IntInput("минимальное значение");
        int max = IntInput("максимальное значение");
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min, max);  
        }
        // отладка:
        // my.Print(array);
        return array;
    }

    double Max (double[] usersArray){
        double max = double.NegativeInfinity; 
        for (int i = 0; i<usersArray.Length; i++){
            if (usersArray[i]>max){
                max=usersArray[i];
            }
        }
        return max;
    }
    int Max (int[] usersArray){
        int max = usersArray[0]; 
        for (int i = 1; i<usersArray.Length; i++){
            if (usersArray[i]>max){
                max=usersArray[i];
            }
        }
        return max;
    }

    double Min (double[] usersArray){
        double min = double.PositiveInfinity; 
        for (int i = 0; i<usersArray.Length; i++){
            if (usersArray[i]<min){
                min=usersArray[i];
            }
        }
        return min;
    }
    int Min (int[] usersArray){
        int min = usersArray[0]; 
        for (int i = 1; i<usersArray.Length; i++){
            if (usersArray[i]<min){
                min=usersArray[i];
            }
        }
        return min;
    }

    double[] ArrayCopy (double[] usersArray){
        double[] arrayCopied = new double[usersArray.Length];
        for (int i = 0; i<usersArray.Length; i++){
            arrayCopied[i] = usersArray[i];
        }
        return arrayCopied;
        }

}