using UnityEngine;

namespace AIScript;

public class TowerDefenseFogOfWar
{
	private const string FOG_PREFAB_PATH = "Assets/AssetBundles/Environment/TowerDefence/Perfab/TowerDefence_WarFog.prefab";

	private const string GRID_ROOT_NAME = "GridMapRoot";

	private const string FOG_GRID_NAME = "fogGrid";

	private const string MAT_ROOT = "Assets/AssetBundles/FX/TowerDefence/Materials/";

	private const string MAT_DARK_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_dark.mat";

	private const string MAT_C1_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_c1.mat";

	private const string MAT_C2OPP_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_c2opp.mat";

	private const string MAT_C2ADJ_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_c2adj.mat";

	private const string MAT_C3_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_c3.mat";

	private const string MAT_C4_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_c4.mat";

	private const string MAT_E1_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e1.mat";

	private const string MAT_E2OPP_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e2opp.mat";

	private const string MAT_E2ADJ_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e2adj.mat";

	private const string MAT_E3_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e3.mat";

	private const string MAT_E1CR_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e1cr.mat";

	private const string MAT_E1CL_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e1cl.mat";

	private const string MAT_E1C2_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e1c2.mat";

	private const string MAT_E2ADJC1_NAME = "Assets/AssetBundles/FX/TowerDefence/Materials/fx_td_light_mat_e2adjc1.mat";

	private Material matDark;

	private Material matC1;

	private Material matC2Opp;

	private Material matC2Adj;

	private Material matC3;

	private Material matC4;

	private Material matE1;

	private Material matE2Opp;

	private Material matE2Adj;

	private Material matE3;

	private Material matE1Cr;

	private Material matE1Cl;

	private Material matE1C2;

	private Material matE2AdjC1;

	private int sizeX;

	private int sizeY;

	private GameObject fogRoot;

	private GameObject[] gridObjects;

	private MeshRenderer[] renderers;

	private bool[] litFlags;

	public void Init(ITowerDefenseGameplayHost host)
	{
	}

	public void InitGrid(int cols, int rows, float gridScaleX, float gridScaleZ, float addedX = 0f, float addedZ = 0f)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE4*/;
		}
	}

	public void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
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
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		}
	}

	public void SetGridLit(int x, int y, bool lit)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void SetAllLit(bool lit)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void RefreshAffected(int cx, int cy)
	{
		/*Error: Unknown opcode: 0xEA*/;
	}

	private void RefreshAll()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void RefreshCell(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private bool ResolveState(int x, int y, out Material mat, out float rotY)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((ushort[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0007: Unknown opcode: 0xEA*/;
	}

	private unsafe void LoadMaterials()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I8
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if ((long)/*Error near IL_0007: Stack underflow*/ < *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((double[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (double)/*Error near IL_0008: Stack underflow*/;
		checked
		{
			_ = (short)(/*Error near IL_0009: Stack underflow*/ >> unchecked((int)/*Error near IL_0009: Stack underflow*/));
			/*Error near IL_000b: Unknown opcode: 0xE1*/;
		}
	}

	private static Material LoadMat(string path)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void ApplyVisual(int x, int y, bool isLit, Material mat, float rotY)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Not a type handle*/;
	}

	private unsafe int Index(int x, int y)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Expected native int or pointer, but got Obj
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0004: Stack underflow*/ < 8)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_000a: Stack underflow*/ >= (int)(*(uint*)(nint)this))
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = /*Error near IL_000b: Stack underflow*/* /*Error near IL_000b: Stack underflow*/;
			/*Error: End of method reached without returning.*/;
		}
	}

	private bool InBounds(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private bool IsLit(int x, int y)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}
}
