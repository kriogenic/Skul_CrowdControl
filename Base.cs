using FX;
using HarmonyLib;
using MelonLoader;
using Services;
using Singletons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Skul_CrowdControl
{

    [HarmonyPatch(typeof(Characters.Actions.SimpleAction), nameof(Characters.Actions.SimpleAction.TryStart))]
    class SimpleActionPatch
    {

        static bool Prefix(Characters.Actions.SimpleAction __instance, ref bool __result)
        {
            if (Base.infiniteDashActivated && __instance.type == Characters.Actions.Action.Type.Dash)
            {
                __instance.cooldown.time.remainTime = 0;
            }

            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;

        }

    }

    [HarmonyPatch(typeof(Characters.Actions.AttackHitTriggerAction), nameof(Characters.Actions.AttackHitTriggerAction.TryStart))]
    class AttackHitTriggerActionPatch
    {

        static bool Prefix(Characters.Actions.AttackHitTriggerAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.ChainAction), nameof(Characters.Actions.ChainAction.TryStart))]
    class ChainActionPatch
    {

        static bool Prefix(Characters.Actions.ChainAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.ChargeAction), nameof(Characters.Actions.ChargeAction.TryStart))]
    class ChargeActionPatch
    {

        static bool Prefix(Characters.Actions.ChargeAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.ChargeComboAction), nameof(Characters.Actions.ChargeComboAction.TryStart))]
    class ChargeComboActionPatch
    {

        static bool Prefix(Characters.Actions.ChargeComboAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.ComboAction), nameof(Characters.Actions.ComboAction.TryStart))]
    class ComboActionPatch
    {

        static bool Prefix(Characters.Actions.ComboAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.EnhanceableComboAction), nameof(Characters.Actions.EnhanceableComboAction.TryStart))]
    class EnhanceableComboActionPatch
    {

        static bool Prefix(Characters.Actions.EnhanceableComboAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked; ;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.GhoulHookAction), nameof(Characters.Actions.GhoulHookAction.TryStart))]
    class GhoulHookActionPatch
    {

        static bool Prefix(Characters.Actions.GhoulHookAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.HoldAction), nameof(Characters.Actions.HoldAction.TryStart))]
    class HoldActionPatch
    {

        static bool Prefix(Characters.Actions.HoldAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.MultiChargeAction), nameof(Characters.Actions.MultiChargeAction.TryStart))]
    class MultiChargeActionPatch
    {

        static bool Prefix(Characters.Actions.MultiChargeAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.MultipleAction), nameof(Characters.Actions.MultipleAction.TryStart))]
    class MultipleActionPatch
    {

        static bool Prefix(Characters.Actions.MultipleAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.NonblockAction), nameof(Characters.Actions.NonblockAction.TryStart))]
    class NonblockActionPatch
    {

        static bool Prefix(Characters.Actions.NonblockAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.ParryAction), nameof(Characters.Actions.ParryAction.TryStart))]
    class ParryActionPatch
    {

        static bool Prefix(Characters.Actions.ParryAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.PowerbombAction), nameof(Characters.Actions.PowerbombAction.TryStart))]
    class PowerbombActionPatch
    {

        static bool Prefix(Characters.Actions.PowerbombAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.PowerbombChainAction), nameof(Characters.Actions.PowerbombChainAction.TryStart))]
    class PowerbombChainActionPatch
    {

        static bool Prefix(Characters.Actions.PowerbombChainAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.RandomAction), nameof(Characters.Actions.RandomAction.TryStart))]
    class RandomActionPatch
    {

        static bool Prefix(Characters.Actions.RandomAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.SequentialAction), nameof(Characters.Actions.SequentialAction.TryStart))]
    class SequentialActionPatch
    {

        static bool Prefix(Characters.Actions.SequentialAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }

    [HarmonyPatch(typeof(Characters.Actions.StreakAction), nameof(Characters.Actions.StreakAction.TryStart))]
    class StreakActionPatch
    {

        static bool Prefix(Characters.Actions.StreakAction __instance, ref bool __result)
        {
            bool isBlocked = Base.isSkillBlocked(__instance);
            __result = isBlocked;
            return isBlocked;
        }

    }



    public class Base
    {

        public static bool patched = false;
        public static bool noAbilitiesActivated = false;
        public static bool infiniteDashActivated = false;
        public static Type characterMoveType = typeof(Characters.Movements.Movement);
        public static Type configType = typeof(Characters.Movements.Movement.Config);

        public void start()
        {

        }

        public static void patch()
        {
            if (!patched)
            {
                patched = true;
                var harmony = new HarmonyLib.Harmony("com.warpworld.skulcc");

                harmony.PatchAll();

                MelonLogger.Msg("Patched ALL PATCHES");
            }
        }


        public static bool isReady()
        {
            if (Singleton<Service>.Instantiated && Singleton<Service>.Instance.levelManager != null &&
                Singleton<Service>.Instance.levelManager.player != null && Singleton<Service>.Instance.levelManager.player.liveAndActive)
                return true;

            return false;
        }

        public static bool isSkillBlocked(Characters.Actions.Action __instance)
        {
            if (__instance.type == Characters.Actions.Action.Type.Skill && noAbilitiesActivated)
            {
                if (__instance.owner == Singleton<Service>.Instance.levelManager.player)
                {
                    MelonLogger.Msg("Stopping the use of " + __instance.name);
                    return false;
                }
                else
                {
                    MelonLogger.Msg(__instance.name + " not owned by player, allowing!");
                }
            }

            return true;
        }

        public static Resource.WeaponReference FindWeaponByKey(string key)
        {
            GearManager GM = Singleton<Service>.Instance.gearManager;

            Type weaponType = typeof(GearManager);
            FieldInfo weaponField = weaponType.GetField("_weapons", BindingFlags.NonPublic | BindingFlags.Instance);
            EnumArray<Rarity, Resource.WeaponReference[]> EA = (EnumArray<Rarity, Resource.WeaponReference[]>)weaponField.GetValue(GM);

            KeyValuePair<Rarity, Resource.WeaponReference[]>[] KVP = EA.ToKeyValuePairs();

            //MelonLogger.Msg("WE TEST: " + KVP.Length);
            foreach (KeyValuePair<Rarity, Resource.WeaponReference[]> kv in KVP)
            {
                // MelonLogger.Msg("RARITY: " + kv.Key);
                foreach (Resource.WeaponReference item in kv.Value)
                {
                    //if(!item.obtainable)


                    if (item.displayNameKey.Equals(key))
                    {
                        MelonLogger.Msg("We found weapon: " + item.displayNameKey);
                        return item;
                    }


                }
            }
            MelonLogger.Msg("We didn't find weapon with " + key);
            return null;
        }

        public static IEnumerator SpawnWeaponSkullRoutine(Rarity rarity = Rarity.Legendary, string path = null)
        {
            Resource.Request<Characters.Gear.Weapons.Weapon> weaponToTake = Singleton<Service>.Instance.gearManager.GetWeaponToTake(rarity).LoadAsync();
            if (path != null)
            {
                Resource.WeaponReference WR = FindWeaponByKey(path);
                if (WR != null)
                {
                    weaponToTake = WR.LoadAsync();
                }
            }
            MelonLogger.Msg("Attempting to drop item!");

            int retries = 0;
            while (!weaponToTake.isDone && retries++ < 300)
            {
                yield return new WaitForEndOfFrame();
            }

            MelonLogger.Msg("Loaded the item to drop: " + weaponToTake.isDone);

            if (weaponToTake.isDone)
            {
                MelonLogger.Msg("WEAPON: " + weaponToTake.asset.displayName + " - " + weaponToTake.asset.description);
                Singleton<Service>.Instance.levelManager.DropWeapon(weaponToTake.asset);
            }

            yield return null;
        }

    }
}

