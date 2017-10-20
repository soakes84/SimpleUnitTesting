using System;
namespace BagTest
{
    public class Content
    {
        public Volume Volume { get; set; }


        public Content(float length, float width, float height)
        {
            Volume = new Volume(length, width, height);
        }
    }
}
