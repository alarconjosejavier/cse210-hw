using System;
using System.Security.Cryptography.X509Certificates;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // creating videos objects
//         Video video1 = new Video("Best soccer player", "SportChannel", 120);
//         Video video2 = new Video("Top hits 2025", "Music Channel", 60);
//         Video video3 = new Video("Best Macbook 2024", "Tech Channel", 240);

//         // creating comment objects
//         Comment comment1 = new Comment("Jose Alarcon", "To me is Leonel Messi");
//         Comment comment2 = new Comment("Eliseo", "Not to me is Cristiano Ronaldo");
//         Comment comment3 = new Comment("Pedro", "You are wrong the best player is Neymar");

//         // adding comments to video1
//         video1.AddComment(comment1);
//         video1.AddComment(comment2);
//         video1.AddComment(comment3);

//         // creating comment objects for video2
//         Comment comment4 = new Comment("Samuelito", "La Macarena is the best");
//         Comment comment5 = new Comment("Marcos", "La lambada is the best");
//         Comment comment6 = new Comment("Zendaya", "Thriller is the best of all the time");

//         // adding comments to video2
//         video2.AddComment(comment4);
//         video2.AddComment(comment5);
//         video2.AddComment(comment6);

//         // creating comment objects for video3
//         Comment comment7 = new Comment("Tehc USer", "To me is the Macbook Pro 14 inches");
//         Comment comment8 = new Comment("Javier Penson", "The macbook air 15 inches");
//         Comment comment9 = new Comment("Zack Pelton", "The Macbook pro 16 inches");
//         Comment comment10 = new Comment("Pele", "No anyone I prefer the macmini");

//         // adding comments to video3
//         video3.AddComment(comment7);
//         video3.AddComment(comment8);
//         video3.AddComment(comment9);
//         video3.AddComment(comment10);

//         // creating list video 1 to save the list with comments
//         List<Video> videosComments = new List<Video>() { video1 };

//         // printing video1
//         foreach (Video v in videosComments)
//         {
//             Console.WriteLine(v.GetDisplayVideoText());
//         }

//         // printing space
//         Console.WriteLine();

//         // creating list video2 to save the list with comments
//         List<Video> videosComments2 = new List<Video>() { video2 };

//         // printing video2
//         foreach (Video v in videosComments2)
//         {
//             Console.WriteLine(v.GetDisplayVideoText());
//         }

//         // printing a space
//         Console.WriteLine();

//         // creating list video3 to save the list with comments
//         List<Video> videosComments3 = new List<Video>() { video3 };

//         // printing video3
//         foreach (Video v in videosComments3)
//         {
//             Console.WriteLine(v.GetDisplayVideoText());
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        // creating videos objects
        Video video1 = new Video("Best soccer player", "SportChannel", 120);
        Video video2 = new Video("Top hits 2025", "Music Channel", 60);
        Video video3 = new Video("Best Macbook 2024", "Tech Channel", 240);

        // creating comment objects
        Comment comment1 = new Comment("Jose Alarcon", "To me is Leonel Messi");
        Comment comment2 = new Comment("Eliseo", "Not to me is Cristiano Ronaldo");
        Comment comment3 = new Comment("Pedro", "You are wrong the best player is Neymar");

        // adding comments to video1
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // creating comment objects for video2
        Comment comment4 = new Comment("Samuelito", "La Macarena is the best");
        Comment comment5 = new Comment("Marcos", "La lambada is the best");
        Comment comment6 = new Comment("Zendaya", "Thriller is the best of all the time");

        // adding comments to video2
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        // creating comment objects for video3
        Comment comment7 = new Comment("Tehc USer", "To me is the Macbook Pro 14 inches");
        Comment comment8 = new Comment("Javier Penson", "The macbook air 15 inches");
        Comment comment9 = new Comment("Zack Pelton", "The Macbook pro 16 inches");
        Comment comment10 = new Comment("Pele", "No anyone I prefer the macmini");

        // adding comments to video3
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        // creating list video 1 to save the list with comments
        // I copied my code above to ChatGPT to recieved feedabck and
        // ChatGPT suggested me to created just one list and I copied the last
        // part of this line because I didn't remember the syntax to add different element
        // in a list
        List<Video> videosComments = new List<Video>() { video1, video2, video3 };

        // printing video1
        foreach (Video v in videosComments)
        {
            Console.WriteLine(v.GetDisplayVideoText());
        }
    }
}