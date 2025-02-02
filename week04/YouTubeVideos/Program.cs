// Program Execution
class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("C# Basics", "Code Masters", 300);
        video1.AddComment(new Comment("Michael", "Fantastic tutorial!"));
        video1.AddComment(new Comment("Sophia", "This was really helpful!"));
        video1.AddComment(new Comment("Liam", "Clear and concise explanation."));

        Video video2 = new Video("Advanced C#", "Tech Academy", 600);
        video2.AddComment(new Comment("Olivia", "Loved the examples!"));
        video2.AddComment(new Comment("Noah", "Great in-depth analysis."));
        video2.AddComment(new Comment("Ava", "Best tutorial so far!"));

        Video video3 = new Video("C# OOP Concepts", "Dev Pro", 450);
        video3.AddComment(new Comment("Ethan", "Really insightful content."));
        video3.AddComment(new Comment("Isabella", "Super useful, thanks!"));
        video3.AddComment(new Comment("Mason", "Helped me understand OOP better!"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
