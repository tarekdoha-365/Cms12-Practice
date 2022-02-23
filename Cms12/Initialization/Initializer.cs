using EPiServer.Cms.Shell;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Cms12.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializableModule))]
    public class Initializer : IInitializableModule
    {

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
    }
