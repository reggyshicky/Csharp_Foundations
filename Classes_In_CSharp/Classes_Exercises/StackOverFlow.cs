using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Exercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; } //declaring a value with a getter but no setter means you can only retrieve the value of
        //of CreationDateTime  from outised the class but cannot modifiy it onces it is set within the constructor
        private int _voteValue;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            _voteValue = 0;
        }

        public int UpVote ()
        {
            _voteValue++;
            return _voteValue;
        }

        public int DownVote()
        {
            _voteValue--;
            return _voteValue;
        }
    }
}
