using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Warsztaty.ViewModel.sadsadasdasd
{
    public class ContactViewModel
    {
        [MaxLength(5)]
        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
