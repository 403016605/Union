using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("StateMapping")]
    internal class StateMapping : Mapping<State>
    {
    }
}