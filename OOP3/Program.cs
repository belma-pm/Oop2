using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            
           TasitKrediManager tasitKrediManager = new TasitKrediManager();
            

            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLOggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, DatabaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediÖnBilgilendirmeYap(krediler);

            
        }
    }
}
