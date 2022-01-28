using System.ComponentModel;
using System.Configuration.Install;
using JetBrains.Annotations;

namespace DemoService
{
    [RunInstaller(true)]
    [PublicAPI]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
