﻿using Skateboard3Server.Web.Models.Common;

namespace Skateboard3Server.Web.Models.SkateProfile
{
    public class StartLoginProcess
    {
        public PlatformType PlatformType { get; set; }
        public long UserId { get; set; }
        public string SessionKey { get; set; }
        public bool DeleteThumbs { get; set; }
        public int Difficulty { get; set; } //TODO: enum?
        public ulong TotalBoardSales { get; set; }
    }
}