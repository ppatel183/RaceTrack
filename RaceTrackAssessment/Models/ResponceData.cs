using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceTrackAssessment.Models
{
    /// <summary>
    ///  this class will be use to send resonce back to front-end
    /// </summary>
    public class ResponceData
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}