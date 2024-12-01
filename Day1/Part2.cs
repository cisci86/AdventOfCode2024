using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Part2
    {
        public int CalculateSimilarityScore(string[] ids)
        {
            List<int> groupOne = new List<int>();
            List<int> groupTwo = new List<int>();

            foreach (string id in ids)
            {
                string[] idDiv = id.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                groupOne.Add(int.Parse(idDiv[0].Trim()));
                groupTwo.Add(int.Parse(idDiv[1].Trim()));
            }
            int similarityScore = 0;
            foreach(int num  in groupOne)
            {
                var g2 = groupTwo.FindAll(x => x == num);
                similarityScore += (num * g2.Count);
            }
            return similarityScore;
        }
    }
}
