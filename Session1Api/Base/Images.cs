namespace Session1Api.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Images
    {
        public System.Guid Id { get; set; }
        public byte[] Name { get; set; }
        public byte[] Data { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ContentType { get; set; }
    }
}
