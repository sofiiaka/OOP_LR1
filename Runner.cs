using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLr1
{
    public class Runner
    {
        static void Main()
        {
            GameAccount playing1 = new GameAccount("Andrii", 1100);
            GameAccount playing2 = new GameAccount("Serhii", 1200);
            GameAccount playing3 = new GameAccount("Volodymyr", 1400);
            GameAccount playing4 = new GameAccount("Bohdan", 600);

            playing1.WinGame(playing2, 30);
            playing3.LoseGame(playing2, 21);
            playing1.WinGame(playing4, 12);
            playing1.LoseGame(playing3, 100);
            playing1.WinGame(playing2, 630);

            playing1.GetStatistics();
        }
    }
}
