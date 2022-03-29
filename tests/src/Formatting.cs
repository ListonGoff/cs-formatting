using System;
using System.Data;

namespace Formatting
{
    enum colors{
        RED, BLUE, GREEN,
        MAGENTA, BLACK, GRAY
    }

    class color{
        colors m_color;
        public color(colors color)
        {
            m_color = color;
        }

        public ConsoleColor toConsole(){ 
            switch(m_color){
                case colors.RED:
                    return ConsoleColor.Red;

                case colors.BLUE:
                    return ConsoleColor.Blue;

                case colors.GREEN:
                    return ConsoleColor.Green;

                case colors.MAGENTA:
                    return ConsoleColor.Magenta;

                case colors.BLACK:
                    return ConsoleColor.Black;

                case colors.GRAY:
                    return ConsoleColor.Gray;
                    
                default:
                    return ConsoleColor.Black;
            }
        }
    }

    class Formatter
    {
        public static void colorWrite(string s, colors ForegroundColor = colors.GRAY, colors BackgroundColor = colors.BLACK)
        {
            color Foreground = new color(ForegroundColor);
            color Background = new color(BackgroundColor);

            ConsoleColor defaultBackground = Console.BackgroundColor;
            ConsoleColor defaultForeground = Console.ForegroundColor;

            Console.ForegroundColor = Foreground.toConsole();
            Console.BackgroundColor = Background.toConsole();
            Console.WriteLine(s);
            Console.ForegroundColor = defaultForeground;
            Console.BackgroundColor = defaultBackground;
        }
    }
}