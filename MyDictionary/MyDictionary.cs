using System;
using System.Collections.Generic;
using System.Text;

namespace homework2
{
    class MyDictionary<T1,T2>
    {
        T1[] points;
        T2[] films;
        public MyDictionary()
        {
            points = new T1[0];
            films = new T2[0];
        }
        public void Add(T1 point,T2 film)
        {
            T1[] tempArrayp = points;
            T2[] tempArrayf = films;
            points = new T1[points.Length + 1];
            films = new T2[films.Length + 1];
            for (int i = 0; i < tempArrayf.Length; i++)
            {
                points[i] = tempArrayp[i];
                films[i] = tempArrayf[i];

            }
            points[points.Length - 1] = point;
            films[films.Length - 1] = film;
        }
        public void Listing()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i] + " puanlı film " + films[i]);
            }
           
        }
    }
}
