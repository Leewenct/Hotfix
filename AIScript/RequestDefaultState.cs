using System.Runtime.CompilerServices;

namespace AIScript;

public class RequestDefaultState
{
	public BaseNormalStatus defalutStatus;

	public unsafe void Reset()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}
}
