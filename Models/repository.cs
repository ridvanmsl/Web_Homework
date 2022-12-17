namespace WebAssignmentt.Models
{
    public class repository
    {
        private List<movies> _mov = new List<movies>();
        private List<movieComment> _mov_comment = new List<movieComment>();
        public List<movies> mov
        {
            get
            {
                return _mov;    
            }
        }
        public List<movieComment> mov_comment
        {
            get
            {
                return _mov_comment;
            }
        }
        public void AddComments(movieComment movie_comment)
        {
            _mov_comment.Add(movie_comment);
        }
    }
}

