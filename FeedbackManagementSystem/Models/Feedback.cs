
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagementSystem.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        [Range(1, 5, ErrorMessage = "Select a rating from 1 to 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Please enter your comments.")]
        [StringLength(500, ErrorMessage = "Maximum 500 characters allowed.")]
        public string Comments { get; set; }
    }
}
