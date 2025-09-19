using MelonLoader;

[assembly: MelonInfo(typeof(SprintMod.Core), "SprintMod", "1.0.0", "Exil_S", null)]
[assembly: MelonGame("AnUnfinishedGameCompany", "UnfinishedGame")]

namespace SprintMod
{
    public class Core : MelonMod
    {
        public static MelonLogger.Instance Logger;

        SprintHandler sprintHandler;
        public override void OnInitializeMelon()
        {
            Logger = LoggerInstance;
            sprintHandler = new SprintHandler();
            LoggerInstance.Msg("Initialized.");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            base.OnSceneWasLoaded(buildIndex, sceneName);
            sprintHandler.OnSwitchScene(buildIndex, sceneName);
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            sprintHandler.Update();
        }
    }
}