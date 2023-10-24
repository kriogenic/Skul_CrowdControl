using WarpWorld.CrowdControl;
using Services;
using Singletons;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;

namespace Skul_CrowdControl
{
    [MLCC_ParamEffectData(
        ID = "SpawnCommonSkul",
        Name = "Common Skul",
        Description = "Spawns a Common quality Skul",
        Categories = new string[]{"Skul Spawns"},
        Morality = Morality.Good,
        ParamArray = new string[] {"Common", "Rare", "Legendary", "Unique"  }
    )]
    class SpawnCommonWeapon : MLCC_ParamEffect
    {

        //Not entirely sure how to use this effect type and use the selected param, may be best to split into individual effects in its own spawn category
        public override EffectResult OnTriggerEffect(CCEffectInstanceParameters effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                Singleton<Service>.Instance.levelManager.player.StartCoroutine(Base.SpawnWeaponSkullRoutine(Rarity.Common));
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }
    }
}