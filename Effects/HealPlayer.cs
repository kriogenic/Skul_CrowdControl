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
        //During testing, the CC Interactive page would show a success and failure toast upon triggering if it had been queued?
        //Further live testing required
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;
            try
            {
                if(Singleton<Service>.Instance.levelManager.player.health.currentHealth > Singleton<Service>.Instance.levelManager.player.health.maximumHealth - 20)
                    return EffectResult.Retry;

                Singleton<Service>.Instance.levelManager.player.health.Heal(20, false);
                    
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }
    }
}