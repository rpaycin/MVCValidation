using System;
using System.ComponentModel.DataAnnotations;

namespace MVCValidation.Models
{
    public class User
    {
        [Required(ErrorMessage ="Adı giriniz!")]
        public string Name { get; set; }

        [Range(0,99,ErrorMessage ="0-99 arası olabilir")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz!")]
        [EmailAddress(ErrorMessage = "Email formatı yanlış!")]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Telefon numarası yanlış")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime  BirthDay { get; set; }
    }
}