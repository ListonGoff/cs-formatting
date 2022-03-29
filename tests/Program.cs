using System;
using Formatting;

int a = 10;

Formatter.colorWrite("Hello World!", colors.RED);
Formatter.colorWrite("This is a Test", colors.BLUE);
Formatter.colorWrite("For My Formatting", colors.GREEN);
Formatter.colorWrite($"a = {a}", colors.MAGENTA);
Formatter.colorWrite($"a != {a + 1}");