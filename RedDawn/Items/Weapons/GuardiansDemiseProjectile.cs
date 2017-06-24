using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedDawn.Items.Weapons
{
	public class GuardiansDemiseProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.name = "";
			projectile.width = 36;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.penetrate = 3;
			projectile.timeLeft = 200;
			projectile.light = 0.8f;
			projectile.extraUpdates = 1;
			projectile.damage = 46;
			projectile.ignoreWater = true;
			projectile.aiStyle = 5;
		}
		public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
            if(target.type == 68)
            {
                damage =  20000;
            }
        }        
	}
}
