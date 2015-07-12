using System.ComponentModel.Composition;
using Union.FixedAssets.Entities;

namespace Union.FixedAssets.Mapping
{
    [Export("AssetInfoMapping")]
    internal class AssetInfoMapping : Mapping<AssetInfo>
    {
    }
}