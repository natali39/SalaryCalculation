using System;

namespace SalaryCalculation.Model
{
    interface IGetSalary
    {
        /// <summary>
        /// Возвращает величину ежемесячной зарплаты сотрудника с учетом всех надбавок 
        /// </summary>
        /// <param name="payDate"></param>
        /// <returns></returns>
        decimal GetSalary(DateTime payDate);
    }
}
