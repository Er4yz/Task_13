using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.services
{
    public static class CurrencyConverter
    {
        #region свойства
        public static double UsdRate { get; set; }
        public static double EurRate { get; set; }
        #endregion

        #region конструктор
        /// <summary>
        /// Выводит сообщение в консоль: "[CurrencyConverter]: Загрузка курсов валют. Устанавливает базовые значения: UsdRate = 92.5;, EurRate = 100.2;.
        /// </summary>
        static CurrencyConverter()
        {
            UsdRate = 92.5;
            EurRate = 100.2;
            Console.WriteLine("[CurrencyConverter]: Загрузка курсов валют...");
        }
        #endregion

        #region статические методы
        /// <summary>
        /// обновляет курсы с проверкой (курсы должны быть строго > 0);
        /// </summary>
        /// <param name="newUsd">новый курс в долларах</param>
        /// <param name="newEur">новый курс в евро</param>
        public static void UpdateRates(double newUsd, double newEur)
        {
            if (newUsd > 0)
            {
                Console.WriteLine("Все круто");
            }
            else if (newEur <= 0)
            {
                Console.WriteLine("Все не круто");
            }
            else if (newEur > 0)
            {
                Console.WriteLine("Все круто2");
            }
            else if (newEur <= 0)
            {
                Console.WriteLine("Все не круто2");
            }
        }
        /// <summary>
        /// переводит сумму в рубли в зависимости от валюты ("USD" или "EUR"). При некорректном коде возвращает исходную сумму.
        /// </summary>
        /// <param name="foreignAmount">Иностранная сумма</param>
        /// <param name="currencyCode">код валюты</param>
        /// <returns></returns>
        public static decimal ConvertToRub(decimal foreignAmount, decimal currencyCode)
        {
            
            return ;
        }
        #endregion
    }
}
