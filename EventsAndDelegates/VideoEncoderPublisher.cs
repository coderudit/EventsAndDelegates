using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegates
{
    public class VideoEncoderPublisher
    {
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        //public event VideoEncoderEventHandler VideoEncoded;
        public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Inside the publisher.");
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new EventArgs { });
        }

        public void EncodeWithDelegate(Video video, VideoEncoderEventHandler eventHandlers)
        {
            Console.WriteLine("Inside the publisher.");
            OnVideoEncodedWithDelegate(video, eventHandlers);
        }

        protected virtual void OnVideoEncodedWithDelegate(Video video, VideoEncoderEventHandler eventHandlers)
        {
            eventHandlers?.Invoke(this, new EventArgs { });
        }
    }
}
