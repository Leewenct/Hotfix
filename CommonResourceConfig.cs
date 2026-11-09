using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class CommonResourceConfig
{
	public string alias;

	[ReadOnly]
	public string path;

	public GameObject prefab;

	[HideInInspector]
	public int preloadNum;

	public GameObject overridePrefab
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public CommonResourceConfig()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Invalid field token*/;
	}
}
