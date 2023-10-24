using WarpWorld.CrowdControl;
using Services;
using Singletons;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;

namespace Skul_CrowdControl
{

    [MLCC_EffectData(
        ID = "SpawnSkull",
        Name = "Spawn Skul",
        Description = "Spawns a random Skul for the player",
        Morality = Morality.Neutral

    )]

    class SpawnWeapon : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                
                Singleton<Service>.Instance.levelManager.player.StartCoroutine(Base.SpawnWeaponSkullRoutine((Rarity)MMMaths.random.Next(4)));
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }

        public override void OnLoad()
        {
            Base.patch();
        }
    }
}


