namespace FindWaitingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // NOTE case 1
            string name = "Eric";
            int agents = 2;
            string otherNames = "Adam Caroline Rebbacca Frank";
        // NOTE case 2
        //    string name = "Zed";
        //    int agents = 1;
        //    string otherNames = "Bob Jim Becky Pal";
           Console.WriteLine( findWaitingTime(name, agents, otherNames));
        }
        public static int findWaitingTime(string name,int noOfAgents,string otherNames)
        {
            List<string> names = otherNames.Split(' ').ToList();
            names.Add(name);
            names.Sort();
            int index=names.FindIndex(x => x == name);
            //calculate to rounds of waiting 
            int waitingRounds = (index)/noOfAgents;
            // +1 since complletion time should be calculated
            int completionTime = (waitingRounds + 1) * 20;
            return completionTime;
        }
    }
}