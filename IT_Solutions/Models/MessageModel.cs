using System.ComponentModel.DataAnnotations;

namespace IT_Solutions.Models
{
    public class MessageModel
    {
        [Required(ErrorMessage = "Please fill up your email address.")]
        [EmailAddress(ErrorMessage = "The email field is not a valid e-mail address.")]
        public string SenderEmail { get; set; }
        [Required(ErrorMessage = "Please write your message.")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Please fill up your name.")]
        public string Name { get; set; }
    }
}
