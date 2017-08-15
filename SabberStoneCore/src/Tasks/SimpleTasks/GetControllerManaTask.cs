﻿using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class GetControllerManaTask : SimpleTask
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public override TaskState Process()
		{
			Number = Controller.RemainingMana;
			return TaskState.COMPLETE;
		}

		protected override string InternalToHash(params GameTag[] ignore)
		{
			return typeof(GetControllerManaTask).Name;
		}

		protected override ISimpleTask InternalDeepClone(Game newGame)
		{
			return new GetControllerManaTask();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}