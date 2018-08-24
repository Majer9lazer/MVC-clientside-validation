using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace MVC_clientside_validation.Models
{
    public class InvoiceNumber
    {
        [WebDisplayName("Номер накладной")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(36, ErrorMessage = "Поле не должно превышать 36 символов")]

        [RegularExpression(@"^[A-Z0-9]\w*[^A-Za-z]$", ErrorMessage = "Номер должен начинаться только с числа или заглавной буквы, и только!\n" +
                                                                     "Последний символ не должен быть буквой")]
        public string Invoice { get; set; }

    }
}