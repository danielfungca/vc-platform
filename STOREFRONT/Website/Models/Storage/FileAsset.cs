﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtoCommerce.Web.Models.Storage
{
    public class FileAsset
    {
        public byte[] ByteContent { get; set; }
        public string Content { get; set; }
        public string ContentType { get; set; }
        public string Id { get; set; }
        public DateTime Updated { get; set; }
    }
}