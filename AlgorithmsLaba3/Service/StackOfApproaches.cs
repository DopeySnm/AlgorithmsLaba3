using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Service
{
    internal class StackOfApproaches
    {
        private OurStack<SportExercise> stack;
        private OurList<SportExercise> compliteSportExercises;
        public StackOfApproaches()
        {
            compliteSportExercises = new OurList<SportExercise>();
            stack = new OurStack<SportExercise>();
        }
        public void AddExercise(string name, int num, int numberOfApproaches)
        {
            stack.Push(new SportExercise(name, num, numberOfApproaches));
            SortStack();
        }
        public void SkipExercise()
        {
            stack.Pop();
        }
        public void Complite()
        {
            compliteSportExercises.AddLast(stack.Pop());
        }
        public SportExercise CheckNextExercise()
        {
            return stack.Top();
        }
        public void PrintStackExercise()
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
        private void SortStack()
        {
            SportExercise[] sportExercise = new SportExercise[stack.GetCount()];
            for (int i = 0; i < sportExercise.Length; i++)
            {
                sportExercise[i] = stack.Pop();
            }
            sportExercise = sportExercise.OrderBy(x => x.GetNum()).ToArray();
            for (int i = sportExercise.Length - 1; i >= 0; i--)
            {
                sportExercise[i].SetNum(i + 1);
                stack.Push(sportExercise[i]);
            }
        }
    }
}
