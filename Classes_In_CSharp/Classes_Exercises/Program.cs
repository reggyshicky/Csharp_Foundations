namespace Classes_Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //STOPWATCH
            StopWatch s = new StopWatch();

            DateTime start = s.start();

            Console.WriteLine("____starting");
            //Perform some operation to measure
            //For example, simulate some  work with a delay
            Thread.Sleep(2000);

            DateTime stop = s.stop();
            Console.WriteLine("____stopping");

            TimeSpan duration = s.GetDuration(start, stop);
            Console.WriteLine(duration);


            //STACKOVERFLOW
            Post post = new Post("Asp.Net Core", "It is a framework in .Net used in building of modern, cloud-based, internet based applications");

            int upvote;
            for (int i = 0; i <=4 ; i++) {
                upvote = post.UpVote();
                Console.WriteLine(upvote); 
            }

            

            int downvote = post.DownVote();
            int downvote1 = post.DownVote();
            Console.WriteLine(downvote1);



        }
    }
}
