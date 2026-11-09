using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DormInterAnimConfig", menuName = "游戏/后宅/交互动画配置")]
public class DormInteractionAnimationConfigData : ScriptableObject
{
	[Serializable]
	public class TimelineEntry
	{
		public DormCommonInteractionAnimationType actorCommonAnimationType;

		public GameObject actorTimelinePrefab;

		public GameObject interacteeTimelinePrefab;

		[Min(0f)]
		public int weight;

		public bool isSkip;

		public TimelineEntry()
		{
			/*Error: Unknown opcode: 0xF0*/;
		}
	}

	[Serializable]
	public class AnimationSegment
	{
		public List<TimelineEntry> timelineEntries;

		[Min(1f)]
		public int loopCountMin;

		[Min(1f)]
		public int loopCountMax;

		public TimelineEntry PickRandomEntry()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			case 5:
				/*Error: Invalid branch target*/;
			case 6:
				/*Error: Invalid branch target*/;
			case 7:
				/*Error: Invalid branch target*/;
			case 8:
				/*Error: Invalid branch target*/;
			case 9:
				/*Error: Invalid branch target*/;
			case 10:
				/*Error: Invalid branch target*/;
			case 11:
				/*Error: Invalid branch target*/;
			case 12:
				/*Error: Invalid branch target*/;
			case 13:
				/*Error: Invalid branch target*/;
			case 14:
				/*Error: Invalid branch target*/;
			case 15:
				/*Error: Invalid branch target*/;
			case 16:
				/*Error: Invalid branch target*/;
			case 17:
				/*Error: Invalid branch target*/;
			case 18:
				/*Error: Invalid branch target*/;
			case 19:
				/*Error: Invalid branch target*/;
			case 20:
				/*Error: Invalid branch target*/;
			case 21:
				/*Error: Invalid branch target*/;
			case 22:
				/*Error: Invalid branch target*/;
			case 23:
				/*Error: Invalid branch target*/;
			case 24:
				/*Error: Invalid branch target*/;
			case 25:
				/*Error: Invalid branch target*/;
			case 26:
				/*Error: Invalid branch target*/;
			case 27:
				/*Error: Invalid branch target*/;
			case 28:
				/*Error: Invalid branch target*/;
			case 29:
				/*Error: Invalid branch target*/;
			case 30:
				/*Error: Invalid branch target*/;
			case 31:
				/*Error: Invalid branch target*/;
			case 32:
				/*Error: Invalid branch target*/;
			case 33:
				/*Error: Invalid branch target*/;
			case 34:
				/*Error: Invalid branch target*/;
			case 35:
				/*Error: Invalid branch target*/;
			case 36:
				/*Error: Invalid branch target*/;
			case 37:
				/*Error: Invalid branch target*/;
			case 38:
				/*Error: Invalid branch target*/;
			case 39:
				/*Error: Invalid branch target*/;
			case 40:
				/*Error: Invalid branch target*/;
			case 41:
				/*Error: Invalid branch target*/;
			case 42:
				/*Error: Invalid branch target*/;
			case 43:
				/*Error: Invalid branch target*/;
			case 44:
				/*Error: Invalid branch target*/;
			case 45:
				/*Error: Invalid branch target*/;
			case 46:
				/*Error: Invalid branch target*/;
			}
		}

		public int RollLoopCount()
		{
			/*Error: Unknown opcode: 0xEC*/;
		}

		public unsafe AnimationSegment()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Expected Obj, but got Unknown
			((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (object)(/*Error near IL_0003: Stack underflow*/ ^ (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public class InteractionPlaybackSegment
	{
		public DormCommonInteractionAnimationType actorCommonAnimationType;

		public GameObject actorTimelinePrefab;

		public GameObject interacteeTimelinePrefab;

		public int loopCount;
	}

	public class PlaybackData
	{
		public List<InteractionPlaybackSegment> sequence;
	}

	public List<AnimationSegment> segments;

	public unsafe PlaybackData Resolve()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xAA*/;
	}

	public unsafe DormInteractionAnimationConfigData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xEE*/;
	}
}
