using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYorkTimes.Core.DTOs
{

    public class NewsDto
    {
        public Debug debug { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public EmailedArticle results { get; set; }

    }

    public class Debug
    {
        public float version { get; set; }
    }
    public class EmailedArticle
    {
        public string url { get; set; }
        public string adx_keywords { get; set; }
        public string subsection { get; set; }
        public string column { get; set; }
        public int eta_id { get; set; }
        public string section { get; set; }
        public int id { get; set; }
        public string nytdsection { get; set; }
        public string byline { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string Abstract { get; set; }
        public string source { get; set; }
        public string updated { get; set; }
        public Array des_facet { get; set; }
        public Array org_facet { get; set; }
        public Array per_facet { get; set; }
        public Array geo_facet { get; set; }
        public Media media { get; set; }
    }
    public class Media
    {
        public string type { get; set; }
        public string subtype { get; set; }
        public string caption { get; set; }
        public string copyright { get; set; }
        public bool approved_for_syndication { get; set; }
        public MediaMetadata mediametadata { get; set; }
    }
    public class MediaMetadata
    {
        public string url { get; set; }
        public string format { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
