using System.Runtime.CompilerServices;
using UnityEngine;

public class HUDTargetMark : MonoBehaviour
{
	public Animator ani;

	public float blobOffset;

	private AdventureActor _targetBefore;

	private RectTransform parentRt;

	private RectTransform rt;

	private void OnEnable()
	{
	}

	public void HUDUpdate(float dt)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private unsafe Vector3 GetTargetPos(AdventureActor target)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		//IL_0011: Expected F4, but got I8
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		*(float*)(-2028540800) = -5.192823E+18f;
		if (/*Error near IL_0016: Stack underflow*/ < /*Error near IL_0016: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		this = (HUDTargetMark)checked(/*Error near IL_0017: Stack underflow*/ - /*Error near IL_0017: Stack underflow*/);
		return (Vector3)null;
	}

	public HUDTargetMark()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((float[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = ~((float[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[6];
		_ = 8717674422700861936L;
		/*Error near IL_000e: Unknown opcode: 0xE5*/;
	}
}
