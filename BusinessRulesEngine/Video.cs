using System;

namespace BusinessRulesEngine
{
    public class Video
    {
        public Video(string videoType)
        {
            Console.WriteLine("Packing Slip Generated");
            if (videoType.ToLower().Equals("video (learning to ski)"))
            {
                new FirstAid();   //For specific video First aid video will be provided free.
            }
        }
    }
}
