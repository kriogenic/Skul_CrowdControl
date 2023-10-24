using WarpWorld.CrowdControl;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using FX;

namespace Skul_CrowdControl
{
    [MLCC_TimedEffectData(
        ID = "InfiniteDash",
        Name = "Infinite Dash",
        Description = "Lets the player dash without cooldown",
        Duration = 10
    )]
    class InfiniteDash : MLCC_TimedEffect
    {
        public override EffectResult OnStart(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                Base.infiniteDashActivated = true;
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }


        public override bool OnStop(CCEffectInstance effectInstance, bool force)
        {
            try
            {
                Base.infiniteDashActivated = false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public override bool ShouldRun()
        {
            try
            {
                if (!Base.isReady()) return false;
            }
            catch (Exception ex)
            {
                base.Logger.Msg(ex.ToString() ?? "");
                return false;
            }
            return true;
        }

    }
}