using System;
using System.Collections.Generic;
namespace BagTest
{
    public class Bag
    {
        public Volume Volume { get; set; }
        public List<Pocket> Pockets { get; set; }
        public List<Content> Contents { get; set; }

        public Bag(int length, int width, int height)
        {
            Contents = new List<Content>();
            Pockets = new List<Pocket>();
            Volume = new Volume(length, width, height);
        }

        public bool Add(Content content)
        {
            if (content.Volume.Length <= Volume.Length
                && content.Volume.Width <= Volume.Width
                && content.Volume.Height <= Volume.Height)
            {
                if (content.Volume.Length > 0
                && content.Volume.Height > 0
                && content.Volume.Width > 0)
                {
                    Contents.Add(content);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool Remove(Content content)
        {
            Contents.Remove(content);
            return true;
        }

        public float VolumeAmount(float length, float width, float height)
        {
            return length + width + height;
        }
    }
}
