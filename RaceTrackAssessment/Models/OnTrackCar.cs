using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.Models
{
    public class OnTrackCar
    {
        [Key]
        public int TrackID { get; set; }
        public string TrackName { get; set; }
        public List<Car> Cars { get; set; }
       
    }
}