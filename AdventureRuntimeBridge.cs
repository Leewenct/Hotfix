using UnityEngine;

internal static class AdventureRuntimeBridge
{
	private sealed class AdventurePlayerRuntimeAdapter : IAdventurePlayerRuntime
	{
		public bool TryGetPlayerPosition(out Vector3 position)
		{
			/*Error: Unknown opcode: 0xFD*/;
		}

		public bool TryGetPlayerActorGameObject(out GameObject playerActorGameObject)
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	private sealed class AdventureIndicatorRuntimeAdapter : IAdventureIndicatorRuntime
	{
		public void ActiveOcclusionHighlight(GameObject target)
		{
			/*Error: Unknown opcode: 0xFD*/;
		}

		public void DeactiveOcclusionHighlight(GameObject target)
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	private sealed class AdventureWwiseRuntimeAdapter : IAdventureWwiseRuntime
	{
		public int CurrentLevelType
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public bool IsInAlert
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public int ActivedPlayerActorDataID
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public int ActivedPlayerActorId
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public int ActorCount
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public bool IsStarTowerPrologue
		{
			get
			{
				/*Error: Unknown opcode: 0xFD*/;
			}
		}

		public bool TryGetActorSkinId(int characterId, out int skinId)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
			}
		}

		public bool TryGetActorGameObject(int actorId, out GameObject gameObject)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Expected I4, but got Unknown
			return (byte)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 0;
		}

		public int GetActorDataIdAt(int index)
		{
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	public unsafe static void Register()
	{
		_ = (byte)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFA*/;
	}

	public static void Unregister()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}
}
