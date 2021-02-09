using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2EFMVC.Models {
    public class Team {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Title { get; set; }

        public ICollection<Member> Enrolled { get; }
    }
}
