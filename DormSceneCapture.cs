using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DormSceneCapture : MonoBehaviour
{
	public Camera indoorSceneCaptureCamera;

	public Camera outdoorSceneCaptureCamera;

	public Vector2Int captureSize;

	public float spritePixelsPerUnit;

	private const string kImageExtension = ".png";

	public static DormSceneCapture Instance
	{
		[CompilerGenerated]
		get
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = -1;
			/*Error: End of method reached without returning.*/;
		}
		[CompilerGenerated]
		private set
		{
			/*Error: Invalid field token*/;
		}
	}

	public static string GetStorageDirectoryPath(string scope)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void Awake()
	{
		/*Error: Invalid field token*/;
	}

	private void OnDestroy()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe bool CaptureImage(string scope, string imageFileName, bool useOutdoorSceneCamera)
	{
		//Discarded unreachable code: IL_0087, IL_00f7
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between I8 and Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected native int or pointer, but got Obj
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 211 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
		}
		Color32[] array = (Color32[])(nint)((IntPtr[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/];
		if (((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] >= (long)checked((0f - *unchecked((float*)(~checked((short)/*Error near IL_0008: ldloca 86 (out-of-bounds)*/)))) * __arglist))
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0018: Stack underflow*/ <= /*Error near IL_0018: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_001c: Stack underflow*/>> (int)checked((ushort)(object)this);
		/*Error near IL_001c: Invalid branch target*/;
	}

	public unsafe Texture2D LoadCaptureImage(string scope, string imageFileName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		*(double*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) = 0.0;
		_ = ((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void ReleaseCaptureImage(Texture2D texture)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public Sprite LoadCaptureImageSprite(string scope, string imageFileName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void ReleaseCaptureImageSprite(Sprite sprite)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	public unsafe void CleanCaptureImages(string scope, string[] keepFileNames)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		*(double*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) = 0.0;
		_ = ((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public DormSceneCapture()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
