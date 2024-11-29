using System;

namespace LeetcodeProblems.Problems {

    class CarFleet { 
        public void solve() {
            int target = Convert.ToInt32(Console.ReadLine());
            string postionInput = Console.ReadLine();
            string[] temp = postionInput.Split(',');
            int[] position = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++) {
                position[i] = Convert.ToInt32(temp[i]);
            }
            string speedInput = Console.ReadLine();
            string[] speedTemp = speedInput.Split(',');
            int[] speed = new int[speedTemp.Length];
            for (int i = 0; i < speedTemp.Length; i++)
            {
                speed[i] = Convert.ToInt32(speedTemp[i]);
            }
            int res = carFleet(target, position, speed);
            Console.WriteLine("carfleet is {0}",res);

        }

        public int carFleet(int target, int[] position, int[] speed) {
            int[][] pair = new int[position.Length][];
            for (int i = 0; i < position.Length; i++)
            {
                pair[i] = new int[] { position[i], speed[i] };
            }
            Array.Sort(pair, (a,b)=>b[0].CompareTo(a[0]));
            Stack<double> stack = new Stack<double>();
            foreach(var p in pair) {
                stack.Push((double)(target - p[0]) / p[1]);
                if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                    stack.Pop();
                }
            }
            return stack.Count;
            
            
            
            
        } 
    }
}