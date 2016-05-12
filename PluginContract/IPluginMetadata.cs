using System.ComponentModel.Composition;
using System.Security.Cryptography.X509Certificates;

namespace PluginContract
{
    public interface IPluginMetadata
    {
        string PluginName { get; }
    }
}