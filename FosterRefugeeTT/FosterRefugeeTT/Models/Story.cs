using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class Story
    {
        [Key]
        public Guid id;
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