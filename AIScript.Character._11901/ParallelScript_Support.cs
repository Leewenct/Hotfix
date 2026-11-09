using System.Collections.Generic;
using TrueSync;
using UnityEngine;

namespace AIScript.Character._11901;

public class ParallelScript_Support : ParallelScript
{
	private string scatteringDarts;

	private string scatteringDarts_P23;

	private int smallDartsCount;

	private FP smallDartsShootInterval;

	private string aoe_flower;

	private FP angle;

	private FP distance;

	private const int perkId_21 = 511921;

	private int count_21;

	private const int perkId_22 = 511922;

	private int paramId_22_cdReduce;

	private string areaEffect_22;

	private int paramId_22_count;

	private const int perkId_23 = 511923;

	private int once_23;

	private const int perkId_24 = 511924;

	private int hitDmgId_24;

	private string hitEffect_24;

	private int buffId_24;

	private int once_24;

	private const int perkId_25 = 511925;

	private int once_25;

	private const int parameterId_25 = 11952501;

	private const int perkId_26 = 511926;

	private readonly FP cd_26;

	private const int buff_26 = 11952611;

	private const int once_26 = 11952601;

	private const int perkId_27 = 511927;

	private const int perkId_28 = 511928;

	private const int once_28 = 11952801;

	private const int perkId_29 = 511929;

	private FP cd_29;

	private const int once_29 = 11952901;

	private const int perkId_30 = 511930;

	private const int perkId_32 = 511932;

	private const int once_32 = 11953201;

	private const int perkId_31 = 511931;

	private const int buff_31 = 11953111;

	private const int perkId_33 = 511933;

	private const int buff_33 = 11953311;

	private Dictionary<long, HashSet<long>> dicCount_21;

	private Dictionary<long, int> dicCount_22;

	private Dictionary<long, HashSet<AdventureActor>> dicMonster_24;

	private Dictionary<long, HashSet<AdventureActor>> dicMonster_26;

	private long tagUid;

	public override void OnEnable()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) + 0;
		/*Error near IL_0003: stloc 237 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected override void OnMainControlCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		}
	}

	public override void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent evt, MonsterAdventureActor monster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public override void OnHitPost(AdventureActorReceiveDamageEvent evt, MonsterAdventureActor monster)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		case 70:
			/*Error: Invalid branch target*/;
		case 71:
			/*Error: Invalid branch target*/;
		case 72:
			/*Error: Invalid branch target*/;
		case 73:
			/*Error: Invalid branch target*/;
		case 74:
			/*Error: Invalid branch target*/;
		case 75:
			/*Error: Invalid branch target*/;
		case 76:
			/*Error: Invalid branch target*/;
		case 77:
			/*Error: Invalid branch target*/;
		case 78:
			/*Error: Invalid branch target*/;
		case 79:
			/*Error: Invalid branch target*/;
		case 80:
			/*Error: Invalid branch target*/;
		case 81:
			/*Error: Invalid branch target*/;
		case 82:
			/*Error: Invalid branch target*/;
		case 83:
			/*Error: Invalid branch target*/;
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		case 88:
			/*Error: Invalid branch target*/;
		case 89:
			/*Error: Invalid branch target*/;
		case 90:
			/*Error: Invalid branch target*/;
		case 91:
			/*Error: Invalid branch target*/;
		case 92:
			/*Error: Invalid branch target*/;
		case 93:
			/*Error: Invalid branch target*/;
		case 94:
			/*Error: Invalid branch target*/;
		case 95:
			/*Error: Invalid branch target*/;
		case 96:
			/*Error: Invalid branch target*/;
		case 97:
			/*Error: Invalid branch target*/;
		case 98:
			/*Error: Invalid branch target*/;
		case 99:
			/*Error: Invalid branch target*/;
		case 100:
			/*Error: Invalid branch target*/;
		case 101:
			/*Error: Invalid branch target*/;
		case 102:
			/*Error: Invalid branch target*/;
		case 103:
			/*Error: Invalid branch target*/;
		case 104:
			/*Error: Invalid branch target*/;
		case 105:
			/*Error: Invalid branch target*/;
		case 106:
			/*Error: Invalid branch target*/;
		case 107:
			/*Error: Invalid branch target*/;
		case 108:
			/*Error: Invalid branch target*/;
		case 109:
			/*Error: Invalid branch target*/;
		case 110:
			/*Error: Invalid branch target*/;
		case 111:
			/*Error: Invalid branch target*/;
		case 112:
			/*Error: Invalid branch target*/;
		case 113:
			/*Error: Invalid branch target*/;
		case 114:
			/*Error: Invalid branch target*/;
		case 115:
			/*Error: Invalid branch target*/;
		case 116:
			/*Error: Invalid branch target*/;
		case 117:
			/*Error: Invalid branch target*/;
		case 118:
			/*Error: Invalid branch target*/;
		case 119:
			/*Error: Invalid branch target*/;
		case 120:
			/*Error: Invalid branch target*/;
		case 121:
			/*Error: Invalid branch target*/;
		case 122:
			/*Error: Invalid branch target*/;
		case 123:
			/*Error: Invalid branch target*/;
		case 124:
			/*Error: Invalid branch target*/;
		case 125:
			/*Error: Invalid branch target*/;
		case 126:
			/*Error: Invalid branch target*/;
		case 127:
			/*Error: Invalid branch target*/;
		case 128:
			/*Error: Invalid branch target*/;
		case 129:
			/*Error: Invalid branch target*/;
		case 130:
			/*Error: Invalid branch target*/;
		case 131:
			/*Error: Invalid branch target*/;
		case 132:
			/*Error: Invalid branch target*/;
		case 133:
			/*Error: Invalid branch target*/;
		case 134:
			/*Error: Invalid branch target*/;
		case 135:
			/*Error: Invalid branch target*/;
		case 136:
			/*Error: Invalid branch target*/;
		case 137:
			/*Error: Invalid branch target*/;
		case 138:
			/*Error: Invalid branch target*/;
		case 139:
			/*Error: Invalid branch target*/;
		case 140:
			/*Error: Invalid branch target*/;
		case 141:
			/*Error: Invalid branch target*/;
		case 142:
			/*Error: Invalid branch target*/;
		case 143:
			/*Error: Invalid branch target*/;
		case 144:
			/*Error: Invalid branch target*/;
		case 145:
			/*Error: Invalid branch target*/;
		case 146:
			/*Error: Invalid branch target*/;
		case 147:
			/*Error: Invalid branch target*/;
		case 148:
			/*Error: Invalid branch target*/;
		case 149:
			/*Error: Invalid branch target*/;
		case 150:
			/*Error: Invalid branch target*/;
		case 151:
			/*Error: Invalid branch target*/;
		case 152:
			/*Error: Invalid branch target*/;
		case 153:
			/*Error: Invalid branch target*/;
		case 154:
			/*Error: Invalid branch target*/;
		case 155:
			/*Error: Invalid branch target*/;
		case 156:
			/*Error: Invalid branch target*/;
		case 157:
			/*Error: Invalid branch target*/;
		case 158:
			/*Error: Invalid branch target*/;
		case 159:
			/*Error: Invalid branch target*/;
		case 160:
			/*Error: Invalid branch target*/;
		case 161:
			/*Error: Invalid branch target*/;
		case 162:
			/*Error: Invalid branch target*/;
		case 163:
			/*Error: Invalid branch target*/;
		case 164:
			/*Error: Invalid branch target*/;
		case 165:
			/*Error: Invalid branch target*/;
		case 166:
			/*Error: Invalid branch target*/;
		case 167:
			/*Error: Invalid branch target*/;
		case 168:
			/*Error: Invalid branch target*/;
		case 169:
			/*Error: Invalid branch target*/;
		case 170:
			/*Error: Invalid branch target*/;
		case 171:
			/*Error: Invalid branch target*/;
		case 172:
			/*Error: Invalid branch target*/;
		case 173:
			/*Error: Invalid branch target*/;
		case 174:
			/*Error: Invalid branch target*/;
		case 175:
			/*Error: Invalid branch target*/;
		case 176:
			/*Error: Invalid branch target*/;
		case 177:
			/*Error: Invalid branch target*/;
		case 178:
			/*Error: Invalid branch target*/;
		case 179:
			/*Error: Invalid branch target*/;
		case 180:
			/*Error: Invalid branch target*/;
		}
	}

	public unsafe override void OnSkillShoot(IEvent evt)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0x78*/;
	}

	private ScatteringDartsEntity ShootScatterDart(Vector3 pos)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected I4, but got Unknown
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
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		}
	}

	private long NewTagUid()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private unsafe bool CheckAreaAlive(long id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) = 0L;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe ParallelScript_Support()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)checked((short)(*unchecked((long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))));
		/*Error near IL_0004: Unknown opcode: 0xE1*/;
	}
}
