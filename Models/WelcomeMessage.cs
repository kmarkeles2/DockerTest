using System.ComponentModel.DataAnnotations.Schema;

namespace DockerTest.Models
{
    public class WelcomeMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WelcomeMessageId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
