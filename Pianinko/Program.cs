using System;
using System.Threading;

class Piano
{
    static int[] fourdoctave = new int[] { 261,277, 293, 311, 294, 329, 349, 370, 392, 415, 440, 466, 493 }; // Частоты для четвёртой октавы (C4-B4) 
    static int[] fithoctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 }; // Частоты для пятой  октавы (C5-B5) 
    static int[] sixthoctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };  // Частоты для шестой октавы (C6-B6)
    static int[] nashatoctave; // Текущая октава 
    static bool running = true;

    static void Main(string[] args)
    {
        Console.WriteLine("Приветсвую вас в консольном пианино.");
        Console.WriteLine("Нажмите Q, W, E, R, T, Y, U для белых клавиш. Для черных клавиш  используйте Z,X,C, V.");
        Console.WriteLine("Нажмите F4, F5, F6 для переключения между четвёртой, пятой, шестой октавами.");
        Console.WriteLine("Для выхода нажмите Esc.");

        ConsoleKeyInfo keyInfo;
        nashatoctave = fourdoctave;

        while (running)
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                running = false;
            }
            else if (keyInfo.Key == ConsoleKey.F4)
            {
                nashatoctave = fourdoctave;
                Console.WriteLine("Четвёртая октава.");
            }
            else if (keyInfo.Key == ConsoleKey.F5)
            {
                nashatoctave = fithoctave;
                Console.WriteLine("Пятая октава.");
            }
            else if (keyInfo.Key == ConsoleKey.F6)
            {
                nashatoctave = sixthoctave;
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

        switch (key)
        {
            case ConsoleKey.Q:
                index = 0;
                break;
            case ConsoleKey.Z:
                index = 1;
                break;
            case ConsoleKey.W:
                index = 2;
                break;
            case ConsoleKey.X:
                index = 3;
                break;
            case ConsoleKey.E:
                index = 4;
                break;
            case ConsoleKey.R:
                index = 5;
                break;
            case ConsoleKey.C:
                index = 6;
                break;
            case ConsoleKey.T:
                index = 7;
                break;
            case ConsoleKey.Y:
                index = 8;
                break;
            case ConsoleKey.U:
                index = 9;
                break;
            case ConsoleKey.V:
                index = 10;
                break;
            case ConsoleKey.I:
                index = 11;
                break ;
        }

        if (index >= 0)
        {
            int ZXC = nashatoctave[index];
            Console.Beep(ZXC, 650);
        }
    }
}