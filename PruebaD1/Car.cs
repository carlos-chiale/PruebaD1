using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaD1
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Model { get; set; }

        public DateTime DateOfCensus { get; set; }

        public ICollection<Piece> Pieces { get; set; }

        public Car(String aName, String aModel, DateTime aDateOfCensus)
        {
            Name = aName;
            Model = aModel;
            DateOfCensus = aDateOfCensus;
            Pieces = new List<Piece>();
        }
    }
}
