namespace CodeHollow.FeedReader.Feeds
{
    using System;

    /// <summary>
    /// The parsed "dc:" elements in a feed
    /// </summary>
    public class Littlstar
    {
        /// <summary>
        /// The "duration" element
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// The "image" element
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// The "content-type" element
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// The "content-layout" field
        /// </summary>
        public string ContentLayout { get; set; }

        /// <summary>
        /// The "feed" element
        /// </summary>
        public bool? Feed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Littlstar"/> class.
        /// default constructor (for serialization)
        /// </summary>
        public Littlstar()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Littlstar"/> class.
        /// Reads a littlstar (ls:) element based on the xml given in element
        /// </summary>
        /// <param name="item">item element as xml</param>
        public Littlstar(System.Xml.Linq.XElement item)
        {
            this.Duration = item.GetValue("ls:duration");
            this.Image = item.GetValue("ls:image");
            this.ContentType = item.GetValue("ls:content-type");
            this.ContentLayout = item.GetValue("ls:content-layout");
            this.Feed = Helpers.TryParseBool(item.GetValue("ls:feed"));
        }
    }
}
