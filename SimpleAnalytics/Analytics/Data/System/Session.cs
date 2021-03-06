
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Session
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The length of a visit to your property measured in seconds and reported in second increments. The filter returned is a string.")]
            public static DataItem visitLength = new DataItem("visitLength");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("Counts the total number of sessions.")]
            public static DataItem visits = new DataItem("visits");
                                      
            [DescriptionAttribute("The total number of single page (or single engagement hit) sessions for your property.")]
            public static DataItem bounces = new DataItem("bounces");
                                      
            [DescriptionAttribute("The total duration of visitor sessions represented in total seconds.")]
            public static DataItem timeOnSite = new DataItem("timeOnSite");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The percentage of single-page visits (i.e., visits in which the person left your property from the first page). (ga:bounces / ga:visits ) ")]
            public static DataItem visitBounceRate = new DataItem("visitBounceRate");
                                      
            [DescriptionAttribute("The average duration visitor sessions represented in total seconds. (ga:timeOnSite / ga:visits ) ")]
            public static DataItem avgTimeOnSite = new DataItem("avgTimeOnSite");
                                      
            }
        }
    }
}
