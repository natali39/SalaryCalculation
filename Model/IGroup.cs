using System;
using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public interface IGroup
    {
        /// <summary>
        /// доля от базовой ставки за каждый год работы
        /// </summary>
        decimal AnnualRate { get; }

        /// <summary>
        /// максимальная доля от базовой ставки, которая может быть выплачена сотруднику в качестве надбавки за стаж работы
        /// </summary>
        decimal MaxAnnualRate { get; }

        /// <summary>
        /// доля от суммарной зарплаты всех подчененных первого уровня
        /// </summary>
        decimal RateForSubordinates { get; }

        /// <summary>
        /// Возвращает сумму зарплат подчиненных
        /// </summary>
        /// <param name="subordinates"></param>
        /// <returns></returns>
        decimal GetSubordinatesSalary(List<Staff> subordinates, DateTime payDate);
    }
}