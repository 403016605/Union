using System.ComponentModel;
using Union.Core.Base;

namespace Union.FixedAssets.Entities
{
    public class AssetInfo : EntityBase
    {
        [Description("名称")]
        public string Name { get; set; }

        [Description("编码")]
        public string Code { get; set; }
    }
}
