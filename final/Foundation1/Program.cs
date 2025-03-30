using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        List<Comment> comments = new List<Comment>();
        Comment comment1 = new Comment("CraftGremlin", "Wow this changed my life!");
        Comment comment2 = new Comment("Yarn100", "Great job!");
        Comment comment3 = new Comment("apple_yum", "first tutorial to explain clearly");
        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        Video v1 = new Video("How to make a bow", "Bows4Days", 300, comments);

        comments = new List<Comment>();
        comment1 = new Comment("BobHasHat", "Wow this changed my entire way of doing things!");
        comment2 = new Comment("Yarn101", "Bad job!");
        comment3 = new Comment("Strawberry_yum", "first!");
        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        Video v2 = new Video("Crazy! 15 ways to eat a tree!", "TreeEaterr", 900, comments);

        comments = new List<Comment>();
        comment1 = new Comment("sadlittleguy", "Will you be my friend :O");
        comment2 = new Comment("Dude1000", "My other car is a bulbasaur");
        comment3 = new Comment("FlowerChild", "How bad is it if the engine is on fire?");
        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        Video v3 = new Video("How to fix your car window, Kia Spectra 2007", "The_Car_Guy", 1200, comments);

        comments = new List<Comment>();
        comment1 = new Comment("zoroswords", "Where am I?");
        comment2 = new Comment("akinu", "He had it coming");
        comment3 = new Comment("marcoBirb", "WHY WOULD YOU DO THIS TO ME!!!!!");
        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);
        Video v4 = new Video("Tragic Donuts compilation", "luffysHat", 90000, comments);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach (Video video in videos)
        {
            string title = video.GetTitle();
            string author = video.GetAuthor();
            int length = video.GetLength();
            int num = video.NumOfComments();
            List<Comment> comments1 = new List<Comment>(video.GetComments());

            System.Console.WriteLine($"{title}: {author}, {length} seconds, {num} comments\n");
            foreach (Comment comment in comments1)
            {
                System.Console.WriteLine($"{comment.GetName()}: {comment.GetContent()}");
            }
            System.Console.WriteLine();
        }
    }
}