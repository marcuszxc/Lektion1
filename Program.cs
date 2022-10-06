using System.Diagnostics;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("\n\n\n\n\n\n");

string MidelText = "Windows";

Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (MidelText.Length / 2)) + "}", MidelText));

Console.WriteLine("\n\tAn error has occurred. To continue:\n\n\tPress Enter to return to Windows, or\n\n\tPress CTRL+ALT+DEL to restart your computer. if you do this,\n\tyou will lose any unsaved information in all open applications.\n\n\tError: 0E : 016F : BFF9B3D4");


while (true)
{
    if (Console.ReadKey().Key == ConsoleKey.Enter) 
    {
        Process.Start("ShutDown", "/r /t 1");
    }
}