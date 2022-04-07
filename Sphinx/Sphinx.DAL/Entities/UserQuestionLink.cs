using System.ComponentModel.DataAnnotations;

namespace Sphinx.DAL.Entities
{
    public class UserQuestionLink
    {
        //[Key]
        //public UserEntity User { get; set; }   
        [Key]
        public string Questions { get; set; }
        public DateTime ExpiredFrom { get; set; }
    }
}
