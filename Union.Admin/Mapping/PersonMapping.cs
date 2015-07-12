using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("PersonMapping")]
    internal class PersonMapping : Mapping<Person>
    {
    }
}