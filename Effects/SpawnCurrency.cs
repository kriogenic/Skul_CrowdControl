using WarpWorld.CrowdControl;
using Services;
using Singletons;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using System.Collections.Generic;

namespace Skul_CrowdControl
{

    [MLCC_ParamEffectData(
        ID = "SpawnCurrency",
        Name = "Give Currency",
        Description = "Gives the player 100 gold or 20 bones",
        Morality = Morality.Good,
        ParamArray = new string[] {"Gold", "Bones"}

    )]

    class SpawnCurrency : MLCC_ParamEffect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstanceParameters effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                //How to get which param was chosen?
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


