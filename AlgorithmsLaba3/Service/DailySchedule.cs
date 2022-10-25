using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Service
{
    internal class DailySchedule
    {
        private OurList<Exercise> exercises;
        private OurList<Exercise> compliteExercises;
        public DailySchedule()
        {
            exercises = new OurList<Exercise>();
            compliteExercises = new OurList<Exercise>();
        }
        public void AddExercises(string name, string description = "")
        {
            Exercise exercise = new Exercise(name, description);
            exercises.AddLast(exercise);
        }
        public void RemoveExercises(string name)
        {
            Exercise exercise = SearchExercise(name);
            exercises.Remove(exercise);
        }
        public void CompliteExercises(string name)
        {
            Exercise exercise = SearchExercise(name);
            compliteExercises.AddLast(exercise);
            exercises.Remove(exercise);
        }
        public OurList<Exercise> GetExercises()
        {
            return exercises;
        }
        public OurList<Exercise> GetCompliteExercises()
        {
            return compliteExercises;
        }
        public string GetAllExercisesToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Текущие задания\n");
            foreach (var item in exercises)
            {
                result.Append($"Задание: {item.GetName()} Описание: {item.GetDescription()}\n");
            }
            return result.ToString();
        }
        public string GetAllCompliteExercisesToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Выполненые задания\n");
            foreach (var item in compliteExercises)
            {
                result.Append($"Задание: {item.GetName()} Описание: {item.GetDescription()}\n");
            }
            return result.ToString();
        }
        private Exercise SearchExercise(string name)
        {
            foreach (var item in exercises)
            {
                if (item.GetName().Equals(name))
                {
                    return item;
                }
            }
            throw new Exception("Задание не найдено");
        }
    }
}