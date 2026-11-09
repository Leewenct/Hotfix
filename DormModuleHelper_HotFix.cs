using UnityEngine;

public class DormModuleHelper_HotFix
{
	private static bool TryGetLevelController(out DormLevelController ctrl)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		return (byte)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0;
	}

	public static int GetCurRoomUsedCellNum()
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	public static long[] GetFur_EntityId_RootBubbleTrans(int nFurId, out Transform[] arrBB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		return (long[])checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
	}

	public static bool TryPickActorAtLastPressDown(out Transform rt, out int RoleId, out long entityId)
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	public static bool CaptureSceneImage(string scope, string imageFileName, bool useOutdoorSceneCamera)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static Sprite LoadSceneCaptureImageSprite(string scope, string imageFileName)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void ReleaseSceneCaptureImageSprite(Sprite sprite)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public static void CleanSceneCaptureImages(string scope, string[] keepFileNames)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}
}
