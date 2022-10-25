using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Models;
using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class Task3
    {
        public Task3()
        {

        }
        public void ListPart()
        {
            DailySchedule dailySchedule = new DailySchedule();
            dailySchedule.AddExercises("сделать уроки", "сделать 3 лабу по алгоритмам, и ещё миллион лаб каких-то");
            Console.WriteLine(dailySchedule.GetAllExercisesToString());
            Console.WriteLine(dailySchedule.GetAllCompliteExercisesToString());
            Console.WriteLine("Добавили сделать уроки");
            dailySchedule.AddExercises("помыть посуду", "все тарелки");
            Console.WriteLine(dailySchedule.GetAllExercisesToString());
            Console.WriteLine(dailySchedule.GetAllCompliteExercisesToString());
            Console.WriteLine("Добавили помыть посуду");
            dailySchedule.CompliteExercises("помыть посуду");
            Console.WriteLine(dailySchedule.GetAllExercisesToString());
            Console.WriteLine(dailySchedule.GetAllCompliteExercisesToString());
            Console.WriteLine("Выполнили помыть посуду");
        }
        public void QueuePart()
        {
            QueueAtTheClinic queueAtTheClinic = new QueueAtTheClinic();
            Registry registry = new Registry("1", queueAtTheClinic);
            Ticket ticket1 = queueAtTheClinic.Put();
            Console.WriteLine($"Вы взяли билет, ваш номер {ticket1.GetId()}");
            registry.Consultation();
        }
        public void TreePart()
        {
            List<int> items = new List<int>();
            items.Add(123);
            items.Add(43);
            items.Add(9);
            items.Add(7);
            items.Add(34);
            items.Add(4);
            items.Add(8);
            Console.WriteLine("Входные данные");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированые данные");
            HeapSort<int> heapSort = new HeapSort<int>(items);
            heapSort.Sort();
            var test = heapSort.Items;
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
