using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using WarpWorld.CrowdControl;
using Services;
using Singletons;
using Characters.AI.Behaviours;

namespace Skul_CrowdControl
{
    [MLCC_EffectData(
        ID = "ShieldPlayer",
        Name = "Shield Player",
        Description = "Adds 30 shield to the player",
        Morality = Morality.Good
    )]
    class ShieldPlayer : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;
            try
            {
                Singleton<Service>.Instance.levelManager.player.health.shield.AddOrUpdate(this, 30);
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }
    }
}