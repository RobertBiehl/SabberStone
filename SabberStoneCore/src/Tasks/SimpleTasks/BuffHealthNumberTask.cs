﻿using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class BuffHealthNumberTask : SimpleTask
	{
		public EntityType Type { get; set; }

		public BuffHealthNumberTask(EntityType type)
		{
			Type = type;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			var source = Source as IPlayable;
			if (source == null || Number == 0)
			{
				return TaskState.STOP;
			}

			var buff = new BuffTask(Buffs.Health(Number), Type, null);
			buff.Stamp(this);

			return buff.Process();
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(BuffHealthNumberTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new BuffHealthNumberTask(Type);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}