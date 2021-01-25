using System;
using System.Diagnostics;
using System.Threading;

namespace _7
{
    class Program
    {
        public static void Main()
        {
            //определяет, зарегестрирован ли источник событий на ПК
            if (!EventLog.SourceExists("Lab7"))
            {
                //Задает указанное имя источника в качестве допустимого источника событий
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("Создан источник события");
                //Тут, как я понял, надо закрыть программу, чтобы начало работать
                return;
            }

            //Создается экземпляр класса и назначается его источник
            EventLog myLog = new EventLog();
            myLog.Source = "MySource";

            //Запись в журнал событий
            myLog.WriteEntry("Запись в журнал событий");
        }
}
