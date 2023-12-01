// Используя показатели функции вычислить цепную дробь. Количество елементов дроби надо задавать с клавиатуры.
// Например, возьмем количество элементов дроби, равное — 6. Вот такое выражение должно у вас получится: 1+1/(1+1/(1+1/(1+1/(1+1/(1+1))))).
// А вот и правильный ответ: 1,61538.

double Message(string message) {
    Console.WriteLine(message);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double Drob(double num) {
    int count = 1;
    double result = 2;
        while(count < num) {
            result = 1 + 1 / result;
            count++;
        }
    return result;
}

double number = Message("Введите количество цепной дроби");
double Result = Drob(number);

Console.WriteLine(Result);

