using PracticeOne._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne._1.Services.Contracts
{
    internal interface ICrudService
    {
        void Add(Entity entity);
        void Update(int id, Entity entity);
        void Delete(int id);
        Entity Get(int id);
        Entity[] GetAll();
    }
}
