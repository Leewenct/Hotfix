using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DormTimelineBinder : MonoBehaviour
{
	[Serializable]
	public class ConstraintBinding
	{
		public ParentConstraint constraint;

		public string[] sourcePaths;
	}

	public List<ConstraintBinding> bindings;

	private const string kRootNodeSymbol = "%%ROOT%%";

	public void Retarget(Transform targetRoot)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public unsafe DormTimelineBinder()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF9*/;
	}
}
