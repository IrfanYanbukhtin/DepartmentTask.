using PracticeOne._1.Models;
using PracticeOne._1.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne._1.Services
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _teacher = new Teacher[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 9)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 10 müəllim elave etmek olar");

                return;
            }

            _teacher[_currentIndex++] = (Teacher)entity;
            Console.WriteLine("Müəllim ugurla elave edildi!");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _teacher.Length; i++)
            {
                if (_teacher[i] == null)
                    continue;

                if (id == _teacher[i].Id)
                {
                    found = true;

                    for (int j = i; j < _teacher.Length - 1; j++)
                    {
                        _teacher[j] = _teacher[j + 1];
                    }
                    _currentIndex--;

                    Console.WriteLine($"{id}-li müəllim silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"{id}-li müəllim not found");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _teacher.Length; i++)
            {
                if (_teacher[i] == null) continue;

                if (_teacher[i].Id == id)
                {
                    return _teacher[i];
                }
            }

            Console.WriteLine("Not found!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _teacher;
        }

        public void Print()
        {
            foreach (var item in _teacher)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _teacher.Length; i++)
            {
                if (_teacher[i] == null) continue;

                if (_teacher[i].Id == id)
                {
                    _teacher[i] = (Teacher)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Not found!");
        }

    }
}
