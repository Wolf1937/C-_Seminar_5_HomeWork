// Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем).
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double minValue = Int32.MinValue;
double maxValue = Int32.MaxValue;
double min = 0;
double max = 0;

double[] array = GetArray(5, minValue, maxValue);
Console.WriteLine($"Заданный массив: [{String.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++) {
    if (array[i] < min) {
        min = array[i];
    }
    if (array[i] > max) {
        max = array[i];
    }
}

Console.WriteLine($"Минимальное значение массива {min}, Максимальное значение массива {max}.");
Console.WriteLine($"Разница между минимальным и максимальным элементом равна {max-min}.");

double[] GetArray (int size, double minValue, double maxValue) {
    double[] res = new double[size];
    for (int i = 0; i < size; i++) {
        res[i] = new Random().Next(Int32.MinValue, Int32.MaxValue);
    }
    return res;
}