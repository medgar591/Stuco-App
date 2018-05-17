using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    class MDItem
    {
        //Probably not even necessary
        public MDItem()
        {
            TargetType = typeof(MDItem);
            Title = "Title 4";
        }

        //Properties which can be edited. TargetType may be useless
        public View Page { get; set; } //What the user gets redirected to
        public String Title { get; set; } //The menu name shown
        public Type TargetType { get; set; }
    }
}
