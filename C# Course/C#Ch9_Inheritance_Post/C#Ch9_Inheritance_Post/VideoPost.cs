using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ch9_Inheritance_Post
{
    internal class VideoPost : Post
    {
        // Member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        // Properties
        public string VideoURL;
        public int VideoLength;
        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, string videoURL, int videoLength, bool isPublic) 
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.VideoLength = videoLength;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}s long by {4}", 
                this.ID, this.Title, this.VideoURL, this.VideoLength, this.SendByUsername);
        }
        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
                isPlaying = true;
            }
        }
        private void TimerCallback(Object o)
        {
            if (currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();   
            } else {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }

        }
    }
}
