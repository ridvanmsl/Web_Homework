namespace WebAssignmentt.Models
{
    public class repository
    {
        private List<movies> _mov = new List<movies>();
<<<<<<< HEAD

        //private List<contact_info> _contact_infos = new List<contact_info>();

        private List<movieComment> _mov_comment = new List<movieComment>();

=======
>>>>>>> b41895285b59b2d6e8d05d7cea5e6c33138d21a8
        public List<movies> mov
        {
            get
            {
                return _mov;
            }
        }
<<<<<<< HEAD
        public List<movieComment> mov_comment
        {
            get
            {
                return _mov_comment;
            }
        }
        //public List<contact_info> contact_infos
        //{
        //    get
        //    {
        //        return _contact_infos;
        //    }
        //}

        public void AddComments(movieComment movie_comment)
        {
            _mov_comment.Add(movie_comment);
        }

        //public void Add_Info(contact_info info)
        //{
        //    _contact_infos.Add(info);              
        //}

=======
>>>>>>> b41895285b59b2d6e8d05d7cea5e6c33138d21a8
    }
}

