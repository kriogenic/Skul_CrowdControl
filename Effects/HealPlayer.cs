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
        ID = "HealPlayer",
        Name = "Heal Player",
        Description = "Heals the player by 20 Health",
        Morality = Morality.Good
    )]
    class HealPlayer : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;
            try
            {
                //If we aren't missing over 20 Health don't heal
                if(Singleton<Service>.Instance.levelManager.player.health.currentHealth > Singleton<Service>.Instance.levelManager.player.health.currentHealth - 20)
                    return EffectResult.Retry;

                Singleton<Service>.Instance.levelManager.player.health.Heal(20, true);
                    
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }
    }
}