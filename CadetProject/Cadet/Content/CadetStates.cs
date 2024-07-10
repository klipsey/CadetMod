using CadetMod.Modules.BaseStates;
using CadetMod.Cadet.SkillStates;

namespace CadetMod.Cadet.Content
{
    public static class CadetStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(BaseCadetSkillState));
            Modules.Content.AddEntityState(typeof(MainState));
            Modules.Content.AddEntityState(typeof(BaseCadetState));
            Modules.Content.AddEntityState(typeof(ShootSmg));
            Modules.Content.AddEntityState(typeof(ThrowGun));
            Modules.Content.AddEntityState(typeof(EnterReload));
            Modules.Content.AddEntityState(typeof(EnterReload));
            Modules.Content.AddEntityState(typeof(Reload));
            Modules.Content.AddEntityState(typeof(Rolload));
            Modules.Content.AddEntityState(typeof(SlideLoad));
            Modules.Content.AddEntityState(typeof(FireEcho));
        }
    }
}
