using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    class WebClient
    {

        public static void alertFlapDetected()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:3000/flap");
            request.Method = "GET";
            request.ContentType = "application/xml";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string returnString = response.StatusCode.ToString();
        }
    }
}
