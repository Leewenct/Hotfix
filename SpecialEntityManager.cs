using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpecialEntityManager : SceneSingleton<SpecialEntityManager>
{
	private List<ISpecialEntity> _queryList;

	private List<LogicEntity> _specialEntities
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public ISpecialEntity PlaySpecialProcess(AdventureActor owner, GameObject prefab, Vector3 spawnPosition, Quaternion spawnRotation)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xBC*/;
	}

	public ISpecialEntity GenerateSpecialEntity(GameObject prefab, Vector3 spawnPosition, Quaternion spawnRotation)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public unsafe void StopSpecialEntity(long id)
	{
		//IL_0002: Expected Obj, but got I4
		ISpecialEntity specialEntity = (ISpecialEntity)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public void StopAllSpecialEntity()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public unsafe ISpecialEntity GetSpecialEntity(long id)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	public unsafe List<ISpecialEntity> GetSpecialEntitiesByOwner(AdventureActor owner)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	protected unsafe Transform Spawn(GameObject fxPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE6*/;
		}
	}

	public unsafe void Despawn(Transform transform)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		_ = *(short*)(nint)/*Error near IL_0003: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public SpecialEntityManager()
	{
		/*Error: Invalid field token*/;
	}
}
