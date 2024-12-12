using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Skibidi toilet", "BrainRotCentral", 69696969);
        video1.AddComment(new Comment("MemeLord420", "Love it lol skibidi"));
        video1.AddComment(new Comment("LaFaunda", "Kids these days..."));
        video1.AddComment(new Comment("DatGuyB0B", "If my parents found me watching this I would be grounded for a year"));

        Video video2 = new Video("24 Hour EXTREME Cheese Puff Challenge!", "CrazyContentCreators", 600);
        video2.AddComment(new Comment("FitnessFanatic", "This looks SO unhealthy"));
        video2.AddComment(new Comment("MemeWatcher99", "I can't believe someone actually did this"));
        video2.AddComment(new Comment("CouchPotato", "Darwin Award incoming"));

        Video video3 = new Video("How to Fold Socks Like a Ninja in 3 Minutes", "LifeHackGuru", 300);
        video3.AddComment(new Comment("OrganizationFreak", "Finally, a solution to my sock chaos!"));
        video3.AddComment(new Comment("RandomDude", "Is this what adulting looks like?"));
        video3.AddComment(new Comment("SockEnthusiast", "Best tutorial I've watched this week"));

        List<Video> videos = new List<Video> {video1, video2, video3};
        
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}