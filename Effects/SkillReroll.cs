﻿using ML_CrowdControl.Effects.Data;
using ML_CrowdControl.Effects;
using System;
using WarpWorld.CrowdControl;
using Services;
using Singletons;
using Characters.Gear.Weapons;
using Characters;
using MelonLoader;

namespace Skul_CrowdControl
{
    [MLCC_EffectData(
        ID = "SkillReroll",
        Name = "Reroll Skills",
        Description = "Rerolls the current weapon skills"

    )]
    class SkillReroll : MLCC_Effect
    {
        public override EffectResult OnTriggerEffect(CCEffectInstance effectInstance)
        {
            if (!Base.isReady()) return EffectResult.Retry;

            try
            {
                
                Character character = Singleton<Service>.Instance.levelManager.player;
                Weapon current = character.playerComponents.inventory.weapon.current;
                if (current.name.Equals("Skul"))
                    return EffectResult.Retry;

                
                current.RerollSkills();
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