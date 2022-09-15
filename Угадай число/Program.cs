// See https://aka.ms/new-console-template for more information

        // Этап 1.Генерация загаданного числа
        Random x = new Random();
        int n = x.Next(0, 50);
        //Этап 2. Текстовое задание для пользователя.
        Console.WriteLine("Загадано число от 0 до 50. Попробуйте отгдать его? Сейчас колличество Ваших попыток не ограничено.");
        Console.WriteLine("Введите первое число:");
        //Этап 3. Распознавание введеного числа.
        int k = Convert.ToInt32(Console.ReadLine());
        //Этап 4. Цикл и колличество попыток для отгадывания загаданного числа.
        for (int i = 1; i < 100; i++)
        {
            if (k == n)
            {
                Console.WriteLine("Поздравляю, ты угадал число " + k + " с " + i + " попытки!");
                break;
            }
            else
            {
                Console.WriteLine("Попробуйте еще раз!");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
