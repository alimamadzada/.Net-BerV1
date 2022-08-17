using Beryllium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.ViewModels
{
    public class IndexViewModel
    {
        public List<ArchitectureImage> architectureImages { get; set; }
        public List<Work> works { get; set; }
        public List<News> news { get; set; }
        public List<Testimonials> testimonials { get; set; }
        public List<Feature> features { get; set; }
        public List<Message> messages { get; set; }
    }
}
