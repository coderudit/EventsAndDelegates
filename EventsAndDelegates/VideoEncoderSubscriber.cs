using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class VideoEncoderSubscriber
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Inside the subscriber.");
        }

        public void OnVideoEncoded2(object source, EventArgs args)
        {
            Console.WriteLine("Inside the subscriber.");
        }

    }
}
