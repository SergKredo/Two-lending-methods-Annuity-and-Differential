﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differencyrovannyi_method
{
    //class Differencyrovannyi
    //{
    //    private double stavkaToMonth, zaymSumma;        // Закрытые поля типа удвоенной точности после запятой, характеризующие ставку кредитования в месяц, общую сумму займа
    //    private double[] outstandingBalance, mainDebt, accruedInterest;          // Массивы данных характеризующих остаток общей суммы займа по месяцам, основную сумму выплаты кредита по месяцам, сумму выплаты по процентам в месяц
    //    private int countCreditMonth;                                            // Количество месяцев кредитования
    //    private double StavkaToMonth                                             // Закрытое свойство характеризующее ставку кредитования в месяц
    //    {
    //        get                                                                  // Метод доступа чтения
    //        {
    //            return stavkaToMonth;
    //        }
    //        set                                                                  // Метод доступа записи
    //        {
    //            stavkaToMonth = value;
    //        }
    //    }

    //    private double ZaymSumma                                                 // Закрытое свойство характеризующее общую сумму займа
    //    {
    //        get
    //        {
    //            return zaymSumma;
    //        }
    //        set
    //        {
    //            zaymSumma = value;
    //        }
    //    }

    //    private int CountCreditMonth                                            // Закрытое свойство характеризующее количество месяцев кредитования
    //    {
    //        get
    //        {
    //            return countCreditMonth;
    //        }
    //        set
    //        {
    //            countCreditMonth = value;
    //        }
    //    }

    //    public Differencyrovannyi(double stavkaToYear, double zaymSumma, int countCreditYear)            // Пользовательский конструктор для инициализации закрытых полей данного класса
    //    {
    //        this.StavkaToMonth = (stavkaToYear / 12) * 0.01;                                           // Процентная ставка с года в месяц при пересчете в доли
    //        this.ZaymSumma = zaymSumma;
    //        this.CountCreditMonth = countCreditYear * 12;                                          // Пересчет из количества лет кредитования в месяцы
    //    }

        
    //    public double CreditPaymentToMonth()                                                      // Метод, позволяющий расчитать ежемесячную оплату клиентом банка по кредитному займу без учета процентов кредитования
    //    {
    //        return this.ZaymSumma/this.CountCreditMonth;
    //    }

    //    public void OutstandingBalance()                                                          // Метод, который позволяет расчитать основные характеристики по кредитному займу
    //    {
    //        int paymentNumber = 1;
    //        outstandingBalance = new double[this.CountCreditMonth];
    //        accruedInterest = new double[this.CountCreditMonth];
    //        mainDebt = new double[this.CountCreditMonth];
    //        double sum = this.ZaymSumma;
    //        double totalSumOne = 0, totalSumTwo = 0, totalSumThree = 0;
    //        Console.Write("Payment number     Amount of payment      Main debt       Accrued interest       Outstanding balance");
    //        Console.WriteLine("\n");
    //        for (int i = 0; i < outstandingBalance.Length; i++)
    //        {
    //            accruedInterest[i] = sum * this.StavkaToMonth;
    //            mainDebt[i] = CreditPaymentToMonth() + accruedInterest[i];

    //            outstandingBalance[i] = sum - CreditPaymentToMonth();
    //            sum = outstandingBalance[i];
    //            if (outstandingBalance[i] < 0)
    //            {
    //                outstandingBalance[i] = 0;
    //            }
    //            switch (paymentNumber.ToString().Length)
    //            {
    //                case 1:
    //                    Console.Write("      " + paymentNumber++ + "                 " + mainDebt[i].ToString("F") + "            " + CreditPaymentToMonth().ToString("F") + "            " + accruedInterest[i].ToString("F") + "                 " + outstandingBalance[i].ToString("F"));
    //                    break;
    //                case 2:
    //                    Console.Write("      " + paymentNumber++ + "                " + mainDebt[i].ToString("F") + "            " + CreditPaymentToMonth().ToString("F") + "            " + accruedInterest[i].ToString("F") + "                 " + outstandingBalance[i].ToString("F"));
    //                    break;
    //                case 3:
    //                    Console.Write("      " + paymentNumber++ + "               " + mainDebt[i].ToString("F") + "            " + CreditPaymentToMonth().ToString("F") + "            " + accruedInterest[i].ToString("F") + "                 " + outstandingBalance[i].ToString("F"));
    //                    break;

    //            }
    //            Console.WriteLine();
    //            totalSumTwo += CreditPaymentToMonth();
    //            totalSumOne += mainDebt[i];
    //            totalSumThree += accruedInterest[i];
    //        }
    //        Console.WriteLine();
    //        Console.Write("  Total loan:           {0:F}          {1:F}          {2:F}".ToUpper(), totalSumOne, totalSumTwo, totalSumThree);
    //    }

    //}
}
