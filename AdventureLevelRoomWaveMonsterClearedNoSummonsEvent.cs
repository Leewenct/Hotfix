public class AdventureLevelRoomWaveMonsterClearedNoSummonsEvent : BaseAdventureEvent
{
	public int x;

	public int y;

	public string wave;

	public string room;

	public bool isFinalWave;

	public static AdventureLevelRoomWaveMonsterClearedNoSummonsEvent Generate()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public unsafe AdventureLevelRoomWaveMonsterClearedNoSummonsEvent()
	{
		switch (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		}
	}

	public unsafe override void Clear()
	{
		*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}
}
