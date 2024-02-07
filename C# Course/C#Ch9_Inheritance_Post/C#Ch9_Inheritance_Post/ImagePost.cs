using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ch9_Inheritance_Post
{
    // Derives from Post and adds a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextId();  // Calling inherited method from Post - no need to be defined here
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
    
}
