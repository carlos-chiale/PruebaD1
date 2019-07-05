using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaD1
{
    public class Piece
    {
        int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public DateTime DateOfSupport { get; set; }

        public Piece(String aName, DateTime aDateOfSupport)
        {
            Name = aName;
            DateOfSupport = aDateOfSupport;
        }
    }
}
