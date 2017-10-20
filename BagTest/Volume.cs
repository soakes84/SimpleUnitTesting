using System;
namespace BagTest
{
    public class Volume
    {
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Volume(float length, float width, float height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
