using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AztuChat.ViewModel
{
    public class RegisterVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        public IFormFile Image { get; set; }
    }
}
