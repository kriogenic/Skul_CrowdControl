using WarpWorld.CrowdControl;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;

namespace Skul_CrowdControl
{
    [MLCC_TimedEffectData(
        ID = "FlipControls",
        Name = "Flip Controls",
        Description = "Flips the players horizontal control for 20 seconds",
        Duration = 20
    )]
    class FlipControls : MLCC_TimedEffect
    {
        public override EffectResult OnStart(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                UserInput.KeyMapper.Map.Move.InvertXAxis = true;
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
                UserInput.KeyMapper.Map.Move.InvertXAxis = false;
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