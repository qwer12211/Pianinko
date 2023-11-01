using System;

class Piano
{
    static int[] fourdoctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 }; 
    static int[] fithoctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };  
    static int[] sixthoctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };  
    static int[] currentOctave; 
    static bool running = true;

    static void Main(string[] args)
    {
        Console.WriteLine("Используйте Q, W, E, R, T, Y, U, I, белых клавиш. Use Z, X, C, V для чёрных клавиш.");
        Console.WriteLine("Нажмите для  F4, F5, F6 для переключения между четвёртойБ пятойБ шестой октавой.");
        ConsoleKeyInfo keyInfo;
        currentOctave = fourdoctave;

        while (running)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                running = false;
            }
            else if (keyInfo.Key == ConsoleKey.F4)
            {
                currentOctave = fourdoctave;
                Console.WriteLine("Четвёртая октава.");
            }
            else if (keyInfo.Key == ConsoleKey.F5)
            {
                currentOctave = fithoctave;
                Console.WriteLine("Пятая октава.");
            }
            else if (keyInfo.Key == ConsoleKey.F6)
            {
                currentOctave = sixthoctave;
                Console.WriteLine("Шестая октава.");
            }
            else
            {
                PlaySound(keyInfo.Key);
            }
        }
    }

    static void PlaySound(ConsoleKey key)
    {
        int index = -1;

        if (key == ConsoleKey.Q)
        {
            index = 0;
        }
        else if (key == ConsoleKey.W)
        {
            index = 1;
        }
        else if (key == ConsoleKey.E)
        {
            index = 2;
        }
        else if (key == ConsoleKey.R)
        {
            index = 3;
        }
        else if (key == ConsoleKey.T)
        {
            index = 4;
        }
        else if (key == ConsoleKey.Y)
        {
            index = 5;
        }
        else if (key == ConsoleKey.U)
        {
            index = 6;
        }
        else if (key == ConsoleKey.Z)
        {
            index = 7;
        }
        else if (key == ConsoleKey.X)
        {
            index = 8;
        }
        else if (key == ConsoleKey.C)
        {
            index = 9;
        }
        else if (key == ConsoleKey.V)
        {
            index = 10;
        }
        else if (key == ConsoleKey.I)
        {
            index = 11;
        }
 
        if (index >= 0)
        {
            int frequency = currentOctave[index];
            Console.Beep(frequency, 650);
        }
    }
}
