using System;
using System.Collections.Generic;

namespace SalaryCalculation.Model
{
    public abstract class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Дата приема сотрудника на работу 
        /// </summary>
        public DateTime WorkingSince { get; set; }

        /// <summary>
        /// Размер базовой ставки заработной платы сотрудника
        /// </summary>
        public decimal BaseSalary { get; set; }

        /// <summary>
        /// Id Начальника
        /// </summary>
        public int ChiefId { get; set; }

        /// <summary>
        /// Группа, к которой относится сотрудник (Manager, Salesman, Employee)
        /// </summary>
        public Group Group { get; set; }

        //Если у дочерних классов не будет реализован свой метод расчета,
        //то в качестве заработной платы используется базовая ставка сотрудника.
        public virtual decimal GetSalary(DateTime payDate)
        {
            return BaseSalary;
        }

        //decimal GetBonus() нуно ли получать отдельно сумму надбавки???

    }
}
