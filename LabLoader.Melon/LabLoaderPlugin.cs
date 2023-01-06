using Labloader;
using MelonLoader;

namespace LabLoader.Melon
{
    public class LabLoaderPlugin : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Loader.Main();
        }
    }
}