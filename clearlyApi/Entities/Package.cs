﻿using System;
using clearlyApi.Enums;

namespace clearlyApi.Entities
{
    public class Package : PersistantObject
    {
        public int TitleId { get; set; }
        public LocalizedString Title { get; set; }

        public int DescriptionId { get; set; }
        public LocalizedString Description { get; set; }

        public int Price { get; set; }

        public PackageType Type { get; set; }
    }
}
