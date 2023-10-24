using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using WarpWorld.CrowdControl;
using Services;
using Singletons;

namespace Skul_CrowdControl
{

    //TODO
    [MLCC_EffectData(
        ID = "GiveGold",
        Name = "Give Gold",
        Description = "Gives the player gold"

    )]
    
    class GiveCoin : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                
                Singleton<Service>.Instance.levelManager.DropGold(100, 100);
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