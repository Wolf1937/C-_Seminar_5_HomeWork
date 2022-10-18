// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = GetArray(15, 100, 999);
int count = 0;
Console.WriteLine($"Заданный массив: [{String.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++) {
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел в массиве равно: {count}");

int[] GetArray(int size, int minValue, int maxValue) {
    int[] res = new int[size];
    for (int i = 0; i < size; i++) {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}