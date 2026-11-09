using UnityEngine;

[CreateAssetMenu(fileName = "BootConfig", menuName = "BootConfig/BootConfig", order = 10)]
public class BootConfig : ScriptableObject, IBootConfig
{
	public const string PREFS_KEY_CONFIG_PATH = "editor_game_boot_config";

	public string entryLuaFile;

	public string entryModuleName;

	public bool skipUpdateClient;

	public bool skipUpdateResource;

	public bool skipNetworkConnection;

	public bool cleanBeforeInstall;

	public AdventureModuleLevelLoadParams adventureModuleLevelLoadParams;

	[SerializeField]
	public GameTeamConfig teamConfig;

	public AdventureAutoBattleConfig autoBattleConfig;

	public int metaTag;

	[TextArea(5, 50)]
	public string metaData;

	[Space]
	[TextArea(5, 50)]
	public string comment;

	string IBootConfig.EntryLuaFile
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	string IBootConfig.EntryModuleName
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	bool IBootConfig.SkipNetworkConnection
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	bool IBootConfig.SkipUpdateClient
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	bool IBootConfig.SkipUpdateResource
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	bool IBootConfig.CleanBeforeInstall
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	int IBootConfig.MetaTag
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	string IBootConfig.MetaData
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public int GetMetaTag()
	{
		/*Error: Invalid field token*/;
	}

	public object GetMetaData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
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
		}
	}

	public BootConfig()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
