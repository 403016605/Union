using System.ComponentModel.Composition;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Union.Core
{
    [InheritedExport]
    public interface IMapping
    {
        void RegistTo(ConfigurationRegistrar configurationRegistrar);
    }
}