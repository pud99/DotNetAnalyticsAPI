
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class SocialActivities
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("For a social data hub activity, this filter represents the URL of the social activity (e.g. the Google+ post URL, the blog comment URL, etc.)")]
            public static DataItem socialActivityEndorsingUrl = new DataItem("socialActivityEndorsingUrl");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the title of the social activity posted by the social network user.")]
            public static DataItem socialActivityDisplayName = new DataItem("socialActivityDisplayName");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the content of the social activity posted by the social network user (e.g. The message content of a Google+ post)")]
            public static DataItem socialActivityPost = new DataItem("socialActivityPost");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents when the social activity occurred on the social network.")]
            public static DataItem socialActivityTimestamp = new DataItem("socialActivityTimestamp");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the social network handle (e.g. name or ID) of the user who initiated the social activity.")]
            public static DataItem socialActivityUserHandle = new DataItem("socialActivityUserHandle");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the URL of the photo associated with the users social network profile.")]
            public static DataItem socialActivityUserPhotoUrl = new DataItem("socialActivityUserPhotoUrl");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the URL of the associated users social network profile.")]
            public static DataItem socialActivityUserProfileUrl = new DataItem("socialActivityUserProfileUrl");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the URL shared by the associated social network user.")]
            public static DataItem socialActivityContentUrl = new DataItem("socialActivityContentUrl");
                                      
            [DescriptionAttribute("For a social data hub activity, this is a comma-separated set of tags associated with the social activity.")]
            public static DataItem socialActivityTagsSummary = new DataItem("socialActivityTagsSummary");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).")]
            public static DataItem socialActivityAction = new DataItem("socialActivityAction");
                                      
            [DescriptionAttribute("For a social data hub activity, this filter represents the type of social action and the social network where the activity originated.")]
            public static DataItem socialActivityNetworkAction = new DataItem("socialActivityNetworkAction");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The count of activities where a content URL was shared / mentioned on a social data hub partner network.")]
            public static DataItem socialActivities = new DataItem("socialActivities");
                                      

            public sealed class Calculated
            {
                
            }
        }
    }
}
