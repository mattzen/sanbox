using System;
namespace CSharpSandbox
{
    public class Recursion
    {

        public void CalculatePaths()
        {




        }

        public int Sum(List<int> listOfInt)
        {
            if (listOfInt.Count == 1)
            {
                return Convert.ToInt32(listOfInt[0]);

            }
            else
            {
                return Convert.ToInt32(listOfInt[0]) + Sum(listOfInt.Skip(1).ToList());

            }
        }

        public int SumUpNumbers(int numbers)
        {
            if (numbers == 0)
                return 0;

            // Last digit + recursively calling n/10
            return numbers % 10 + SumUpNumbers(numbers / 10);
        }

        public int SumUpNumbers2(int numbers)
        {
            var str = numbers.ToString();
            if (str.Length == 1)
                return str[0];

            return int.Parse(str[0].ToString()) + SumUpNumbers(int.Parse(str.Substring(1)));
        }
    }

    public class Backtracking
    {
        public void CombinationSum()
        {
            var inputs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var allSolutions = new List<List<int>>();

            SumHelper(inputs, -1, 0, new List<int>(), 15, allSolutions);

            Console.WriteLine(String.Join(Environment.NewLine, allSolutions));
            var sol = allSolutions.Last();
        }

        public void SumHelper(int[] inputs, int currentIndex, int sum, List<int> solution, int target, List<List<int>> allSolutions)
        {
            if (sum == target)
            {
                allSolutions.Add(solution);
                return;
            }
            if (sum > target)
            {
                return;
            }

            for (int i = currentIndex; i < inputs.Length - 1;)
            {
                i = i + 1;
                var newSolution = new List<int>();
                newSolution.AddRange(solution);
                newSolution.Add(inputs[i]);
                SumHelper(inputs, i, sum + inputs[i], newSolution, target, allSolutions);
            }

        }
    }
}