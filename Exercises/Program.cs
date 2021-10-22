using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post
            {
                Title = "Test Post",
                Description = "This is a test post"
            };
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine($"The post {post.Title}, with a description of {post.Description}, has {post.CurrentVoteValue} votes");
        }
        //StopWatch stopWatch = new StopWatch();
        //bool keepRunning = true;
        //while(keepRunning)
        //{
        //    Console.WriteLine("Press any key to start your stopwatch.");
        //    Console.ReadKey();
        //    stopWatch.Start();
        //    Console.WriteLine("Now press any key to stop your stopwatch.");
        //    Console.ReadKey();
        //    stopWatch.Stop();
        //    Console.WriteLine($"Duration: {stopWatch.GetTime()} ");
        //    Console.ReadKey();

        //    Console.WriteLine("Would you like to run it again? Y or N : ");
        //    string answer = Console.ReadLine();
        //    if(answer.ToLower() == "n")
        //    {
        //        break;
        //    }
        //}
    }
}
