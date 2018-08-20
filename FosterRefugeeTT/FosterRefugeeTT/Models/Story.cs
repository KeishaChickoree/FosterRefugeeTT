using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    public class Story
    {
        public Story()
        {
            this.Preference = StoryPreference.Protected;
        }

        string MyStory { get; set; }
        StoryPreference Preference { get; set; }

        public enum StoryPreference
        {
            Private,
            Protected,
            Public
        }
    }
}