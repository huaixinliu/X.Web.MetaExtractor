﻿using System.Collections.Generic;

namespace MetaExtractor
{
    public class Metadata
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public IEnumerable<string> Image { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Title}\r\n{Description}\r\n{Url}\r\n{Image}";
        }
    }
}
