using WarpWorld.CrowdControl;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using Services;
using Singletons;

namespace Skul_CrowdControl
{
    [MLCC_TimedEffectData(
        ID = "ExtraJumps",
        Name = "Additional Jump",
        Description = "Allows the player to jump an additional time",
        Duration = 20,
        Morality = Morality.Good
    )]
    class ExtraJumps : MLCC_TimedEffect
    {
        public override EffectResult OnStart(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                Singleton<Service>.Instance.levelManager.player.movement.airJumpCount.Add(this, 1);
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
                Singleton<Service>.Instance.levelManager.player.movement.airJumpCount.Remove(this);
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