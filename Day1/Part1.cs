using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Part1
    {
        public int GetIds(string[] ids)
        {
            List<int> groupOne = new List<int>();
            List<int> groupTwo = new List<int>();

            foreach(string id in ids)
            {
                string[] idDiv= id.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                groupOne.Add(int.Parse(idDiv[0].Trim()));
                groupTwo.Add(int.Parse(idDiv[1].Trim()));
            }
            int totalDistance = 0;
            while(groupOne.Count > 0)
            {
                int nowLowestG1 = groupOne.Min();
                int nowLowestG2 = groupTwo.Min();
                totalDistance += Math.Abs(nowLowestG1 - nowLowestG2);
                groupOne.Remove(nowLowestG1);
                groupTwo.Remove(nowLowestG2);
            }
            return totalDistance;
        }
    }
}
