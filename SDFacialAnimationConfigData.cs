using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SDFacialAnimationConfig", menuName = "游戏/SD角色/表情配置")]
public class SDFacialAnimationConfigData : ScriptableObject
{
	[Serializable]
	public class FacialExpressionEntry
	{
		public SDFacialExpression id;

		[Tooltip("勾选后视为手工修改，自动配置时跳过此条，不被覆盖")]
		public bool manualConfig;

		public bool useBlankFace;

		[Tooltip("如阴沉脸等整脸特殊表情；为空则用默认脸材质")]
		public Material faceMaterial;

		[Tooltip("如 face003；留空表示该表情不操作 face 的 BlendShape")]
		public string faceBlendShapeName;

		[Tooltip("如 eyebrow003；留空表示该表情不操作 eyebrow 的 BlendShape")]
		public string eyebrowBlendShapeName;

		public bool enableSpecialEye;

		public bool eyeUseMirror;

		public Material eyeMaterial;

		public bool enableBlush;

		public bool blushUseMirror;

		public Material blushMaterial;

		[Tooltip("为空则用默认嘴型材质")]
		public Material mouthMaterial;
	}

	public Material defaultFaceMaterial;

	public int faceRendererFaceSlot;

	public Material defaultBlankFaceMaterial;

	public Material defaultMouthMaterial;

	public List<FacialExpressionEntry> entries;

	[NonSerialized]
	private Dictionary<SDFacialExpression, FacialExpressionEntry> _lookup;

	public Dictionary<SDFacialExpression, FacialExpressionEntry> GetLookup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected I4, but got Unknown
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
		}
	}

	public unsafe bool TryGetEntry(SDFacialExpression id, out FacialExpressionEntry entry)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		if (/*Error near IL_0004: Stack underflow*/ >> (int)/*Error near IL_0004: Stack underflow*/ >= /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000a: Stack underflow*/| checked(/*Error near IL_0009: Stack underflow*/ + /*Error near IL_0009: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xC1*/;
	}

	public unsafe void InvalidateLookup()
	{
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public SDFacialAnimationConfigData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
