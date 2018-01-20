using System;
using System.Collections.Generic;
using System.Linq;

namespace koord
{
    public class CircleContainer
    {
        private List<Circle> _circleArray;

        public CircleContainer()
        {
            _circleArray = new List<Circle>();
        }

        public void AddCircle(int x, int y, int rad)
        {
            _circleArray.Add(new Circle(x, y, rad));
        }

        public void AddCircle(Circle newCircle)
        {
            _circleArray.Add(newCircle);
        }

        public string ShowImpose(int number)
        {
            string answer = "";
            int count = _circleArray.Count;


            foreach (var item in _circleArray)
            {
                if (item != _circleArray[number])
                {
                    if (Circle.CheckImpose(item, _circleArray[number]))
                        answer += item.ToString();
                }
            }
            //TODO: Clean
            /*
            for (int i = 0; i < count; ++i)
            {
                if (i != number)
                {
                    if (Circle.CheckImpose(_circleArray[i], _circleArray[number]))
                        answer += _circleArray[i].ToString();
                }
            }
            */
            return answer;
        }

        public string ShowSortedArray()
        {
            //TODO: Tuple ?
            Dictionary<int, double> toSort = new Dictionary<int, double>();
            //TODO: Dont use unnecessary variable
            int count = _circleArray.Count;

            for (int i = 0; i < count; ++i)
                toSort.Add(i, _circleArray[i].DistanceFromZero());

            var sorted = toSort.OrderBy(i => i.Value).Select(i => i.Key);

            //TODO: Clean
            string answer = "";
            /*
            foreach (var item in sorted)
            {
                answer += item.Key.ToString() + "\n";
            }
            */
            answer = sorted.Aggregate("", (current, i) => $"{current} {i}\n");

            return answer;
        }


    }
}
