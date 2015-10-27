using System;

namespace Pt13ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            // Событие, подписчики - цепочка обработчиков, кототрые за невозможностью обработки толкают событие дальше.
            // Событие в итоге может оказаться не обработанным по 2 причинам: нет подписчика, или же нет прямого обработчика

            Console.ReadLine();
        }
    }
}