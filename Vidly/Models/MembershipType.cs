using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        //[Required]
        public string Name { get; set; }

        // below to get rid of "magic numbers" which other people when reading code wont know what is like in the min18years class there are checks to see whether membership type is 0 or 1 but what does that mean???? and where does someone else look?? hence below
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}