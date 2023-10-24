using WarpWorld.CrowdControl;
using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using Services;
using Singletons;
using System.Reflection;

namespace Skul_CrowdControl
{
    [MLCC_TimedEffectData(
        ID = "AlwaysMove",
        Name = "Restless",
        Description = "Player can't stand still for the next",
        Duration = 20
    )]
    class AlwaysMove : MLCC_TimedEffect
    {
        public override EffectResult OnStart(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                //Gets the private config field from Movement class
                Type characterMoveType = typeof(Characters.Movements.Movement);
                FieldInfo configField = characterMoveType.GetField("_config", BindingFlags.NonPublic | BindingFlags.Instance);
                //Gets the private keepMove field from the Movement.Config class
                Type configType = typeof(Characters.Movements.Movement.Config);
                FieldInfo moveField = configType.GetField("keepMove", BindingFlags.NonPublic | BindingFlags.Instance);


                Characters.Movements.Movement.Config CMMC = (Characters.Movements.Movement.Config)configField.GetValue(Singleton<Service>.Instance.levelManager.player.movement);
                moveField.SetValue(CMMC, true);
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
                //Gets the private config field from Movement class
                FieldInfo configField = Base.characterMoveType.GetField("_config", BindingFlags.NonPublic | BindingFlags.Instance);
                //Gets the private keepMove field from the Movement.Config class
                FieldInfo moveField = Base.configType.GetField("keepMove", BindingFlags.NonPublic | BindingFlags.Instance);

                Characters.Movements.Movement.Config CMMC = (Characters.Movements.Movement.Config)configField.GetValue(Singleton<Service>.Instance.levelManager.player.movement);
                moveField.SetValue(CMMC, false);
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