using LessonMigrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail Detail { get; set; }
    }
}
