using Homework_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(40);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            // Увольнение всех работников с именем "Агата"
            repository.DeleteWorkerByName("Алима");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после первого преобразования");

            // Увольнение всех работников с фамилией "Иванова"
            repository.DeleteWorkerBylastName("Иванова");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после второго преобразования");

            //Увольнение по мин и макс зп
            repository.DeleteWorkerByMinSalary(20000);
            repository.DeleteWorkerBySalary(45000);
            repository.Print("База данных после третьего преобразования");

            //Увольнение по максимальному возрасту 
            repository.DeleteWorkerByAge(45);
            repository.Print("База данных после четвертого преобразования");

            Console.ReadKey();


            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
