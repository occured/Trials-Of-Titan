using System;
using TitanCore.Core;
using TitanCore.Net.Packets.Server;
using Utils.NET.Geometry;
using World.GameState;

namespace World.Abilities
{
    public class SentinelAbility : ClassAbility
    {
        public override ClassType ClassType => ClassType.Sentinel;

        private uint fortifyEndTime;

        public override void OnHit(Entities.EntityState entity, uint time, ref int damageTaken)
        {
            // Slight damage mitigation while fortified
            if (time <= fortifyEndTime)
                damageTaken = Math.Max(0, (int)(damageTaken * 0.8f));
        }

        public override void OnMove(Vec2 position, uint time)
        {
            // no positional effects
        }

        public override TnPlayEffect UseAbility(uint time, Vec2 position, Vec2 target, byte value, int attack, ref byte rage, out byte rageCost, out bool sendToSelf, out bool failedToUse)
        {
            rageCost = AbilityFunctions.Sentinel.GetRageCost(rage);
            if (rageCost == 0)
            {
                failedToUse = true;
                sendToSelf = false;
                return null;
            }

            fortifyEndTime = time + (uint)(3000 + rageCost * 40);

            rage -= rageCost;
            sendToSelf = false;
            failedToUse = false;
            return null;
        }
    }
}
