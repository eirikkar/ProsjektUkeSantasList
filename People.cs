using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsjektUkeSantasList
{
    public class People
    {

        public string? Id { get; set; }
        public string? Name { get; set; }
        public bool? ToiletPaperOutward { get; set; }
        public bool? DonatesToCharity { get; set; }
        public bool? WashesHands { get; set; }
        public List<string>? MusicGenres { get; set; }
        public string? HomeAdress { get; set; }
        public string? CarModel { get; set; }

    }
}
