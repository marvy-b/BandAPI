using BandAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Models
{
   
    public class AlbumForCreatingDto //: AlbumManipulationDto
    {
       // public override string Description { get => throw new NotImplementedException(); set
         //       => throw new NotImplementedException();}
         public string Title { get; set; }
         public string Description { get; set; }
        

    }
}
