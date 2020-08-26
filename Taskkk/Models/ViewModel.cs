using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taskkk.Models;

namespace Taskkk.Model
{
    public class ViewModel
    {

        public TblTransorders transorders { get; set; }
        public TblClcards clcards { get; set; }
        public TblSpecodes specodes { get; set; }
        public TblPoints points { get; set; }
        public TblFirms firms { get; set; }

    }
}
