using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrackDAL.Models
{
    public class OnTrackCar
    {
        [Key]
        public int TrackID { get; set; }
        public string TrackName { get; set; }
        public List<Car> Cars { get; set; }

    }
}
