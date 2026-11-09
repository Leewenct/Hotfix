using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class DormCommonInteractionAnimationLibrary : MonoBehaviour
{
	[Serializable]
	public class Entry
	{
		public DormCommonInteractionAnimationType actionType;

		public GameObject timelinePrefab;
	}

	public GameObject idleShowTimelinePrefab;

	[Space]
	public GameObject catchTimelinePrefab;

	public GameObject idleTimelinePrefab;

	[Space]
	public GameObject openTimelinePrefab;

	[Space]
	public GameObject closeTimelinePrefab;

	[Space]
	public List<Entry> entries;

	public GameObject GetAnimationTimeline(DormCommonInteractionAnimationType animationType)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected I4, but got Unknown
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
		}
	}

	public unsafe DormCommonInteractionAnimationLibrary()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xE9*/;
	}
}
