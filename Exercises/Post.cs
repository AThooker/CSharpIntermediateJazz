using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
        private int _upVote;
        private int _downVote;
        public int CurrentVoteValue
        {
            get
            {
               return _upVote - _downVote;
            }
        }
        public void UpVote()
        {
            _upVote += 1;
        }
        public void DownVote()
        {
            _downVote += 1;
        }
    }
}
