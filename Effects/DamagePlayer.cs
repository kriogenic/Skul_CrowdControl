using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using WarpWorld.CrowdControl;
using Services;
using Singletons;
using Characters.AI.Behaviours;
using UnityEngine;
using MelonLoader;

namespace Skul_CrowdControl
{
    [MLCC_EffectData(
        ID = "DamagePlayer",
        Name = "Damage Player",
        Description = "Deals 20 damage to the player",
        Morality = Morality.Evil
    )]
    class DamagePlayer : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;
            try
            {
                Characters.Damage CD = new Characters.Damage(Singleton<Service>.Instance.levelManager.player, 20,
                Vector2.zero, Characters.Damage.Attribute.Fixed, Characters.Damage.AttackType.Additional,
                Characters.Damage.MotionType.Basic);

                double dmgTaken;
                Singleton<Service>.Instance.levelManager.player.health.TakeDamage(ref CD, out dmgTaken);
                MelonLogger.Msg("Damage Player Effect: Player took " + dmgTaken + " damage!");
            }
            catch (Exception e)
            {
                return EffectResult.Retry;
            }
            return EffectResult.Success;
        }
    }
}