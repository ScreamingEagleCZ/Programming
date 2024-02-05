using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ch9_Inheritance_Post
{
    // Idea of post is a container for other posts like image post or video post...
    class Post
    {
        private static int currentPostId;
        // Properties
        protected int ID { get; set; }  // Protected means that only be used by this class and deriviing/inheriting classes
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }
        // Default constructor. If derived class does not invoke a base class constructor explicitly,
        // the default constroctor is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "Default Title of Post";
            IsPublic = true;
            SendByUsername = "Default sender";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        protected int GetNextId()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        // Virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}