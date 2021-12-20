using Nop.Core;
using System;

namespace MyTVO.Core.Domain
{
    public partial class MyTVO_Car : BaseEntity
    {
        public string Code { get; set; }

        public string Manufacture { get; set; }

        public string Model { get; set; }

        public string VehicleType { get; set; }

        public string StartYear { get; set; }

        public string EndYear { get; set; }

        public string EngineSize { get; set; }

        public string TrimLevel { get; set; }

     
    }
}
