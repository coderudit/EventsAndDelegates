using System;
using System.Runtime.CompilerServices;

namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Invoking events as notifications
            VideoEncoderPublisher publisher = new VideoEncoderPublisher();
            VideoEncoderSubscriber subscriber = new VideoEncoderSubscriber();
            publisher.VideoEncoded += subscriber.OnVideoEncoded;
            publisher.Encode(new Video());
            publisher.VideoEncoded += null;
            publisher.Encode(new Video());

            //Invoking delegates as notifications
            VideoEncoderPublisher.VideoEncoderEventHandler delegateType = subscriber.OnVideoEncoded;
            delegateType += subscriber.OnVideoEncoded2;
            publisher.EncodeWithDelegate(new Video(), delegateType);
            delegateType = null;
            publisher.EncodeWithDelegate(new Video(), delegateType);
        }
    }
}
