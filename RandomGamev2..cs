{
    // Этап 1.Генерация загаданного числа
    Random x = new Random();
    int n = x.Next(0, 50);
    //Этап 1.2.Отсчет числа попыток
    int count = 1;
    //Этап 2. Текстовое задание для пользователя.
    Console.WriteLine("Загадано число от 0 до 50. Попробуйте отгдать его? У Вас будет 3 попытки.");
    Console.WriteLine("Введите первое число:");
    //Этап 3. Распознавание введеного числа.
    int k = Convert.ToInt32(Console.ReadLine());
    //Этап 4. Цикл и колличество попыток для отгадывания загаданного числа.
    while (count <= 3)
    {
        if (k == n)
        {
            Console.WriteLine("Поздравляю, ты угадал число " + k + " с " + count + " попытки!");
            break;
        }
        else
        {
            count++;
            if (count == 4)
            {
                Console.WriteLine("Увы, вы не угадали, загаданное число было " + n + "");
                break;
            }
        }
        {
            Console.WriteLine("Число " + k + " не подходит. Попытка №" + count + "");
            k = Convert.ToInt32(Console.ReadLine());
        }


    }
}
