using System;
using System.Collections.Generic;
using dio_series.src.Interfaces;

namespace dio_series.src.Classes
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> SerieList = new List<Serie>();
        public void Update(int id ,Serie entity)
        {
            SerieList(id) = entity;
        }

        public void Delete(int id)
        {
            SerieList(id).Delete();
        }

        public int NextId()
        {
            return SerieList.Count;
        }

        public void Insert(Serie entity)
        {
            SerieList.Add(entity);
        }

        public T ReturnById(int id)
        {
            return SerieList(id);
        }

        public List<Serie> List()
        {
            return SerieList;
        }
    }
}