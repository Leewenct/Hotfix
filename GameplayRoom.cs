using System;
using System.Runtime.CompilerServices;
using TrueSync;

public class GameplayRoom
{
	public virtual bool isComplete
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public virtual void InitRoom(GameplayRoomData data, Action<HotfixEnum.levelState, int> levelStateCallback)
	{
	}

	public virtual void EntryRoom()
	{
	}

	public virtual void UpdateLogic(FP logicDeltaTime)
	{
	}

	public virtual void Pause()
	{
	}

	public virtual void Resume()
	{
	}

	public virtual void LeaveRoom()
	{
	}

	public GameplayRoom()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
