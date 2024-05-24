using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;

namespace EstonianLocalization
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class EstonianLocalization : BaseUnityPlugin
    {
        public const string PluginGUID = "com.juljus777.EstonianLocalization";
        public const string PluginName = "EstonianLocalization";
        public const string PluginVersion = "0.0.5";

        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            Jotunn.Logger.LogInfo("EstonianLocalization has landed");
        }
    }
}

