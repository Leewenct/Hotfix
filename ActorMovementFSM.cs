using System;
using TrueSync;
using UnityEngine;

public class ActorMovementFSM : ActorFSM
{
	internal bool dashCanRotate;

	public ActorMoveState.MoveMode moveMode;

	internal TSVector2 direction;

	internal TSVector2 targetPosition;

	internal FP targetPositionY;

	internal LogicEntity trackTarget;

	internal FP stopDistance;

	internal bool stopDisIgnoreRadius;

	internal bool enableNavigation;

	internal NavAgentTypeNames.NavigationUpdateQualityLevel navigationUpdateQualityLevel;

	internal FP distance;

	internal FP speed;

	internal FP duration;

	internal bool forbiddenHeight;

	internal Action changeDir;

	internal readonly bool[] triggerStopS;

	internal FP minStopTime;

	internal bool playAnim;

	internal bool _checkStop;

	protected TSVector2 _accumulatedMovementDelta;

	protected FP _oldAngle;

	protected FP _newAngle;

	public bool forceMove;

	internal bool stayWhenReachTarget;

	private TSVector2 rootMotionDir;

	private bool enableRootMotionDir;

	public bool runtimeIgonreRootMotion;

	public bool rootMotionRotateOnlyChangeForward;

	private static readonly float SmoothTime;

	private float _currentDampVelocity;

	private float _currentForwardX;

	private float _currentForwardY;

	private float _currentVelocityDirX;

	private float _currentVelocityDirY;

	public ActorMovementFSM(GameObject actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public override void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE9*/;
		}
	}

	protected virtual void Move(TSVector2 movementDelta)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
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
		}
	}

	protected void UpdateForwardDirection(FP forwardRotationSpeed)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected I4, but got Unknown
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
		case 181:
			/*Error: Invalid branch target*/;
		case 182:
			/*Error: Invalid branch target*/;
		case 183:
			/*Error: Invalid branch target*/;
		case 184:
			/*Error: Invalid branch target*/;
		case 185:
			/*Error: Invalid branch target*/;
		case 186:
			/*Error: Invalid branch target*/;
		case 187:
			/*Error: Invalid branch target*/;
		case 188:
			/*Error: Invalid branch target*/;
		case 189:
			/*Error: Invalid branch target*/;
		case 190:
			/*Error: Invalid branch target*/;
		case 191:
			/*Error: Invalid branch target*/;
		case 192:
			/*Error: Invalid branch target*/;
		case 193:
			/*Error: Invalid branch target*/;
		case 194:
			/*Error: Invalid branch target*/;
		case 195:
			/*Error: Invalid branch target*/;
		case 196:
			/*Error: Invalid branch target*/;
		case 197:
			/*Error: Invalid branch target*/;
		case 198:
			/*Error: Invalid branch target*/;
		case 199:
			/*Error: Invalid branch target*/;
		case 200:
			/*Error: Invalid branch target*/;
		case 201:
			/*Error: Invalid branch target*/;
		case 202:
			/*Error: Invalid branch target*/;
		case 203:
			/*Error: Invalid branch target*/;
		case 204:
			/*Error: Invalid branch target*/;
		case 205:
			/*Error: Invalid branch target*/;
		case 206:
			/*Error: Invalid branch target*/;
		case 207:
			/*Error: Invalid branch target*/;
		case 208:
			/*Error: Invalid branch target*/;
		case 209:
			/*Error: Invalid branch target*/;
		case 210:
			/*Error: Invalid branch target*/;
		case 211:
			/*Error: Invalid branch target*/;
		case 212:
			/*Error: Invalid branch target*/;
		case 213:
			/*Error: Invalid branch target*/;
		case 214:
			/*Error: Invalid branch target*/;
		case 215:
			/*Error: Invalid branch target*/;
		case 216:
			/*Error: Invalid branch target*/;
		case 217:
			/*Error: Invalid branch target*/;
		case 218:
			/*Error: Invalid branch target*/;
		case 219:
			/*Error: Invalid branch target*/;
		case 220:
			/*Error: Invalid branch target*/;
		case 221:
			/*Error: Invalid branch target*/;
		case 222:
			/*Error: Invalid branch target*/;
		case 223:
			/*Error: Invalid branch target*/;
		case 224:
			/*Error: Invalid branch target*/;
		case 225:
			/*Error: Invalid branch target*/;
		case 226:
			/*Error: Invalid branch target*/;
		case 227:
			/*Error: Invalid branch target*/;
		case 228:
			/*Error: Invalid branch target*/;
		case 229:
			/*Error: Invalid branch target*/;
		case 230:
			/*Error: Invalid branch target*/;
		case 231:
			/*Error: Invalid branch target*/;
		case 232:
			/*Error: Invalid branch target*/;
		case 233:
			/*Error: Invalid branch target*/;
		case 234:
			/*Error: Invalid branch target*/;
		case 235:
			/*Error: Invalid branch target*/;
		case 236:
			/*Error: Invalid branch target*/;
		case 237:
			/*Error: Invalid branch target*/;
		case 238:
			/*Error: Invalid branch target*/;
		case 239:
			/*Error: Invalid branch target*/;
		case 240:
			/*Error: Invalid branch target*/;
		case 241:
			/*Error: Invalid branch target*/;
		case 242:
			/*Error: Invalid branch target*/;
		case 243:
			/*Error: Invalid branch target*/;
		case 244:
			/*Error: Invalid branch target*/;
		case 245:
			/*Error: Invalid branch target*/;
		case 246:
			/*Error: Invalid branch target*/;
		case 247:
			/*Error: Invalid branch target*/;
		case 248:
			/*Error: Invalid branch target*/;
		case 249:
			/*Error: Invalid branch target*/;
		case 250:
			/*Error: Invalid branch target*/;
		case 251:
			/*Error: Invalid branch target*/;
		case 252:
			/*Error: Invalid branch target*/;
		case 253:
			/*Error: Invalid branch target*/;
		case 254:
			/*Error: Invalid branch target*/;
		case 255:
			/*Error: Invalid branch target*/;
		case 256:
			/*Error: Invalid branch target*/;
		case 257:
			/*Error: Invalid branch target*/;
		case 258:
			/*Error: Invalid branch target*/;
		case 259:
			/*Error: Invalid branch target*/;
		case 260:
			/*Error: Invalid branch target*/;
		case 261:
			/*Error: Invalid branch target*/;
		case 262:
			/*Error: Invalid branch target*/;
		case 263:
			/*Error: Invalid branch target*/;
		case 264:
			/*Error: Invalid branch target*/;
		case 265:
			/*Error: Invalid branch target*/;
		case 266:
			/*Error: Invalid branch target*/;
		case 267:
			/*Error: Invalid branch target*/;
		case 268:
			/*Error: Invalid branch target*/;
		case 269:
			/*Error: Invalid branch target*/;
		case 270:
			/*Error: Invalid branch target*/;
		case 271:
			/*Error: Invalid branch target*/;
		case 272:
			/*Error: Invalid branch target*/;
		case 273:
			/*Error: Invalid branch target*/;
		case 274:
			/*Error: Invalid branch target*/;
		case 275:
			/*Error: Invalid branch target*/;
		case 276:
			/*Error: Invalid branch target*/;
		case 277:
			/*Error: Invalid branch target*/;
		case 278:
			/*Error: Invalid branch target*/;
		case 279:
			/*Error: Invalid branch target*/;
		case 280:
			/*Error: Invalid branch target*/;
		case 281:
			/*Error: Invalid branch target*/;
		case 282:
			/*Error: Invalid branch target*/;
		case 283:
			/*Error: Invalid branch target*/;
		case 284:
			/*Error: Invalid branch target*/;
		case 285:
			/*Error: Invalid branch target*/;
		case 286:
			/*Error: Invalid branch target*/;
		case 287:
			/*Error: Invalid branch target*/;
		case 288:
			/*Error: Invalid branch target*/;
		case 289:
			/*Error: Invalid branch target*/;
		case 290:
			/*Error: Invalid branch target*/;
		case 291:
			/*Error: Invalid branch target*/;
		case 292:
			/*Error: Invalid branch target*/;
		case 293:
			/*Error: Invalid branch target*/;
		case 294:
			/*Error: Invalid branch target*/;
		case 295:
			/*Error: Invalid branch target*/;
		case 296:
			/*Error: Invalid branch target*/;
		case 297:
			/*Error: Invalid branch target*/;
		case 298:
			/*Error: Invalid branch target*/;
		case 299:
			/*Error: Invalid branch target*/;
		case 300:
			/*Error: Invalid branch target*/;
		case 301:
			/*Error: Invalid branch target*/;
		case 302:
			/*Error: Invalid branch target*/;
		case 303:
			/*Error: Invalid branch target*/;
		case 304:
			/*Error: Invalid branch target*/;
		case 305:
			/*Error: Invalid branch target*/;
		case 306:
			/*Error: Invalid branch target*/;
		case 307:
			/*Error: Invalid branch target*/;
		case 308:
			/*Error: Invalid branch target*/;
		case 309:
			/*Error: Invalid branch target*/;
		case 310:
			/*Error: Invalid branch target*/;
		case 311:
			/*Error: Invalid branch target*/;
		case 312:
			/*Error: Invalid branch target*/;
		case 313:
			/*Error: Invalid branch target*/;
		case 314:
			/*Error: Invalid branch target*/;
		case 315:
			/*Error: Invalid branch target*/;
		case 316:
			/*Error: Invalid branch target*/;
		case 317:
			/*Error: Invalid branch target*/;
		case 318:
			/*Error: Invalid branch target*/;
		case 319:
			/*Error: Invalid branch target*/;
		case 320:
			/*Error: Invalid branch target*/;
		case 321:
			/*Error: Invalid branch target*/;
		case 322:
			/*Error: Invalid branch target*/;
		case 323:
			/*Error: Invalid branch target*/;
		case 324:
			/*Error: Invalid branch target*/;
		case 325:
			/*Error: Invalid branch target*/;
		case 326:
			/*Error: Invalid branch target*/;
		case 327:
			/*Error: Invalid branch target*/;
		case 328:
			/*Error: Invalid branch target*/;
		case 329:
			/*Error: Invalid branch target*/;
		case 330:
			/*Error: Invalid branch target*/;
		case 331:
			/*Error: Invalid branch target*/;
		case 332:
			/*Error: Invalid branch target*/;
		case 333:
			/*Error: Invalid branch target*/;
		case 334:
			/*Error: Invalid branch target*/;
		case 335:
			/*Error: Invalid branch target*/;
		case 336:
			/*Error: Invalid branch target*/;
		case 337:
			/*Error: Invalid branch target*/;
		case 338:
			/*Error: Invalid branch target*/;
		case 339:
			/*Error: Invalid branch target*/;
		case 340:
			/*Error: Invalid branch target*/;
		case 341:
			/*Error: Invalid branch target*/;
		case 342:
			/*Error: Invalid branch target*/;
		case 343:
			/*Error: Invalid branch target*/;
		case 344:
			/*Error: Invalid branch target*/;
		case 345:
			/*Error: Invalid branch target*/;
		case 346:
			/*Error: Invalid branch target*/;
		case 347:
			/*Error: Invalid branch target*/;
		case 348:
			/*Error: Invalid branch target*/;
		case 349:
			/*Error: Invalid branch target*/;
		case 350:
			/*Error: Invalid branch target*/;
		case 351:
			/*Error: Invalid branch target*/;
		case 352:
			/*Error: Invalid branch target*/;
		case 353:
			/*Error: Invalid branch target*/;
		case 354:
			/*Error: Invalid branch target*/;
		case 355:
			/*Error: Invalid branch target*/;
		case 356:
			/*Error: Invalid branch target*/;
		case 357:
			/*Error: Invalid branch target*/;
		case 358:
			/*Error: Invalid branch target*/;
		case 359:
			/*Error: Invalid branch target*/;
		case 360:
			/*Error: Invalid branch target*/;
		case 361:
			/*Error: Invalid branch target*/;
		case 362:
			/*Error: Invalid branch target*/;
		case 363:
			/*Error: Invalid branch target*/;
		case 364:
			/*Error: Invalid branch target*/;
		case 365:
			/*Error: Invalid branch target*/;
		case 366:
			/*Error: Invalid branch target*/;
		case 367:
			/*Error: Invalid branch target*/;
		case 368:
			/*Error: Invalid branch target*/;
		case 369:
			/*Error: Invalid branch target*/;
		case 370:
			/*Error: Invalid branch target*/;
		case 371:
			/*Error: Invalid branch target*/;
		case 372:
			/*Error: Invalid branch target*/;
		case 373:
			/*Error: Invalid branch target*/;
		case 374:
			/*Error: Invalid branch target*/;
		case 375:
			/*Error: Invalid branch target*/;
		case 376:
			/*Error: Invalid branch target*/;
		case 377:
			/*Error: Invalid branch target*/;
		case 378:
			/*Error: Invalid branch target*/;
		case 379:
			/*Error: Invalid branch target*/;
		case 380:
			/*Error: Invalid branch target*/;
		case 381:
			/*Error: Invalid branch target*/;
		case 382:
			/*Error: Invalid branch target*/;
		case 383:
			/*Error: Invalid branch target*/;
		case 384:
			/*Error: Invalid branch target*/;
		case 385:
			/*Error: Invalid branch target*/;
		case 386:
			/*Error: Invalid branch target*/;
		case 387:
			/*Error: Invalid branch target*/;
		case 388:
			/*Error: Invalid branch target*/;
		case 389:
			/*Error: Invalid branch target*/;
		case 390:
			/*Error: Invalid branch target*/;
		case 391:
			/*Error: Invalid branch target*/;
		case 392:
			/*Error: Invalid branch target*/;
		case 393:
			/*Error: Invalid branch target*/;
		case 394:
			/*Error: Invalid branch target*/;
		case 395:
			/*Error: Invalid branch target*/;
		case 396:
			/*Error: Invalid branch target*/;
		case 397:
			/*Error: Invalid branch target*/;
		case 398:
			/*Error: Invalid branch target*/;
		case 399:
			/*Error: Invalid branch target*/;
		case 400:
			/*Error: Invalid branch target*/;
		case 401:
			/*Error: Invalid branch target*/;
		case 402:
			/*Error: Invalid branch target*/;
		case 403:
			/*Error: Invalid branch target*/;
		case 404:
			/*Error: Invalid branch target*/;
		case 405:
			/*Error: Invalid branch target*/;
		case 406:
			/*Error: Invalid branch target*/;
		case 407:
			/*Error: Invalid branch target*/;
		case 408:
			/*Error: Invalid branch target*/;
		case 409:
			/*Error: Invalid branch target*/;
		case 410:
			/*Error: Invalid branch target*/;
		case 411:
			/*Error: Invalid branch target*/;
		case 412:
			/*Error: Invalid branch target*/;
		case 413:
			/*Error: Invalid branch target*/;
		case 414:
			/*Error: Invalid branch target*/;
		case 415:
			/*Error: Invalid branch target*/;
		case 416:
			/*Error: Invalid branch target*/;
		}
	}

	public void EnableRootMotionForceDir(TSVector2 forceDir)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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
		}
	}

	public void DisableRootMotionForceDir()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
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
		}
	}

	protected FP GetAngel(FP angle)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) != 8)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public virtual void UpdateAnimation(bool applyRootMotion, bool applyRootMotionRotate)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected I4, but got Unknown
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
		case 181:
			/*Error: Invalid branch target*/;
		case 182:
			/*Error: Invalid branch target*/;
		case 183:
			/*Error: Invalid branch target*/;
		case 184:
			/*Error: Invalid branch target*/;
		case 185:
			/*Error: Invalid branch target*/;
		case 186:
			/*Error: Invalid branch target*/;
		case 187:
			/*Error: Invalid branch target*/;
		case 188:
			/*Error: Invalid branch target*/;
		case 189:
			/*Error: Invalid branch target*/;
		case 190:
			/*Error: Invalid branch target*/;
		case 191:
			/*Error: Invalid branch target*/;
		case 192:
			/*Error: Invalid branch target*/;
		case 193:
			/*Error: Invalid branch target*/;
		case 194:
			/*Error: Invalid branch target*/;
		case 195:
			/*Error: Invalid branch target*/;
		case 196:
			/*Error: Invalid branch target*/;
		case 197:
			/*Error: Invalid branch target*/;
		case 198:
			/*Error: Invalid branch target*/;
		case 199:
			/*Error: Invalid branch target*/;
		case 200:
			/*Error: Invalid branch target*/;
		case 201:
			/*Error: Invalid branch target*/;
		case 202:
			/*Error: Invalid branch target*/;
		case 203:
			/*Error: Invalid branch target*/;
		case 204:
			/*Error: Invalid branch target*/;
		case 205:
			/*Error: Invalid branch target*/;
		case 206:
			/*Error: Invalid branch target*/;
		case 207:
			/*Error: Invalid branch target*/;
		case 208:
			/*Error: Invalid branch target*/;
		case 209:
			/*Error: Invalid branch target*/;
		case 210:
			/*Error: Invalid branch target*/;
		case 211:
			/*Error: Invalid branch target*/;
		case 212:
			/*Error: Invalid branch target*/;
		case 213:
			/*Error: Invalid branch target*/;
		case 214:
			/*Error: Invalid branch target*/;
		case 215:
			/*Error: Invalid branch target*/;
		case 216:
			/*Error: Invalid branch target*/;
		case 217:
			/*Error: Invalid branch target*/;
		case 218:
			/*Error: Invalid branch target*/;
		case 219:
			/*Error: Invalid branch target*/;
		case 220:
			/*Error: Invalid branch target*/;
		case 221:
			/*Error: Invalid branch target*/;
		case 222:
			/*Error: Invalid branch target*/;
		case 223:
			/*Error: Invalid branch target*/;
		case 224:
			/*Error: Invalid branch target*/;
		case 225:
			/*Error: Invalid branch target*/;
		case 226:
			/*Error: Invalid branch target*/;
		case 227:
			/*Error: Invalid branch target*/;
		case 228:
			/*Error: Invalid branch target*/;
		case 229:
			/*Error: Invalid branch target*/;
		case 230:
			/*Error: Invalid branch target*/;
		case 231:
			/*Error: Invalid branch target*/;
		case 232:
			/*Error: Invalid branch target*/;
		case 233:
			/*Error: Invalid branch target*/;
		case 234:
			/*Error: Invalid branch target*/;
		case 235:
			/*Error: Invalid branch target*/;
		case 236:
			/*Error: Invalid branch target*/;
		case 237:
			/*Error: Invalid branch target*/;
		case 238:
			/*Error: Invalid branch target*/;
		case 239:
			/*Error: Invalid branch target*/;
		case 240:
			/*Error: Invalid branch target*/;
		case 241:
			/*Error: Invalid branch target*/;
		case 242:
			/*Error: Invalid branch target*/;
		case 243:
			/*Error: Invalid branch target*/;
		case 244:
			/*Error: Invalid branch target*/;
		case 245:
			/*Error: Invalid branch target*/;
		case 246:
			/*Error: Invalid branch target*/;
		case 247:
			/*Error: Invalid branch target*/;
		case 248:
			/*Error: Invalid branch target*/;
		case 249:
			/*Error: Invalid branch target*/;
		case 250:
			/*Error: Invalid branch target*/;
		case 251:
			/*Error: Invalid branch target*/;
		case 252:
			/*Error: Invalid branch target*/;
		case 253:
			/*Error: Invalid branch target*/;
		case 254:
			/*Error: Invalid branch target*/;
		case 255:
			/*Error: Invalid branch target*/;
		case 256:
			/*Error: Invalid branch target*/;
		case 257:
			/*Error: Invalid branch target*/;
		case 258:
			/*Error: Invalid branch target*/;
		case 259:
			/*Error: Invalid branch target*/;
		case 260:
			/*Error: Invalid branch target*/;
		case 261:
			/*Error: Invalid branch target*/;
		case 262:
			/*Error: Invalid branch target*/;
		case 263:
			/*Error: Invalid branch target*/;
		case 264:
			/*Error: Invalid branch target*/;
		case 265:
			/*Error: Invalid branch target*/;
		case 266:
			/*Error: Invalid branch target*/;
		case 267:
			/*Error: Invalid branch target*/;
		case 268:
			/*Error: Invalid branch target*/;
		case 269:
			/*Error: Invalid branch target*/;
		case 270:
			/*Error: Invalid branch target*/;
		case 271:
			/*Error: Invalid branch target*/;
		case 272:
			/*Error: Invalid branch target*/;
		case 273:
			/*Error: Invalid branch target*/;
		case 274:
			/*Error: Invalid branch target*/;
		case 275:
			/*Error: Invalid branch target*/;
		case 276:
			/*Error: Invalid branch target*/;
		case 277:
			/*Error: Invalid branch target*/;
		case 278:
			/*Error: Invalid branch target*/;
		case 279:
			/*Error: Invalid branch target*/;
		case 280:
			/*Error: Invalid branch target*/;
		case 281:
			/*Error: Invalid branch target*/;
		case 282:
			/*Error: Invalid branch target*/;
		case 283:
			/*Error: Invalid branch target*/;
		case 284:
			/*Error: Invalid branch target*/;
		case 285:
			/*Error: Invalid branch target*/;
		case 286:
			/*Error: Invalid branch target*/;
		case 287:
			/*Error: Invalid branch target*/;
		case 288:
			/*Error: Invalid branch target*/;
		case 289:
			/*Error: Invalid branch target*/;
		case 290:
			/*Error: Invalid branch target*/;
		case 291:
			/*Error: Invalid branch target*/;
		case 292:
			/*Error: Invalid branch target*/;
		case 293:
			/*Error: Invalid branch target*/;
		case 294:
			/*Error: Invalid branch target*/;
		case 295:
			/*Error: Invalid branch target*/;
		case 296:
			/*Error: Invalid branch target*/;
		case 297:
			/*Error: Invalid branch target*/;
		case 298:
			/*Error: Invalid branch target*/;
		case 299:
			/*Error: Invalid branch target*/;
		case 300:
			/*Error: Invalid branch target*/;
		case 301:
			/*Error: Invalid branch target*/;
		case 302:
			/*Error: Invalid branch target*/;
		case 303:
			/*Error: Invalid branch target*/;
		case 304:
			/*Error: Invalid branch target*/;
		case 305:
			/*Error: Invalid branch target*/;
		case 306:
			/*Error: Invalid branch target*/;
		case 307:
			/*Error: Invalid branch target*/;
		case 308:
			/*Error: Invalid branch target*/;
		case 309:
			/*Error: Invalid branch target*/;
		case 310:
			/*Error: Invalid branch target*/;
		case 311:
			/*Error: Invalid branch target*/;
		case 312:
			/*Error: Invalid branch target*/;
		case 313:
			/*Error: Invalid branch target*/;
		case 314:
			/*Error: Invalid branch target*/;
		case 315:
			/*Error: Invalid branch target*/;
		case 316:
			/*Error: Invalid branch target*/;
		case 317:
			/*Error: Invalid branch target*/;
		case 318:
			/*Error: Invalid branch target*/;
		case 319:
			/*Error: Invalid branch target*/;
		case 320:
			/*Error: Invalid branch target*/;
		case 321:
			/*Error: Invalid branch target*/;
		case 322:
			/*Error: Invalid branch target*/;
		case 323:
			/*Error: Invalid branch target*/;
		case 324:
			/*Error: Invalid branch target*/;
		case 325:
			/*Error: Invalid branch target*/;
		case 326:
			/*Error: Invalid branch target*/;
		case 327:
			/*Error: Invalid branch target*/;
		case 328:
			/*Error: Invalid branch target*/;
		case 329:
			/*Error: Invalid branch target*/;
		case 330:
			/*Error: Invalid branch target*/;
		case 331:
			/*Error: Invalid branch target*/;
		case 332:
			/*Error: Invalid branch target*/;
		case 333:
			/*Error: Invalid branch target*/;
		case 334:
			/*Error: Invalid branch target*/;
		case 335:
			/*Error: Invalid branch target*/;
		case 336:
			/*Error: Invalid branch target*/;
		case 337:
			/*Error: Invalid branch target*/;
		case 338:
			/*Error: Invalid branch target*/;
		case 339:
			/*Error: Invalid branch target*/;
		case 340:
			/*Error: Invalid branch target*/;
		case 341:
			/*Error: Invalid branch target*/;
		case 342:
			/*Error: Invalid branch target*/;
		case 343:
			/*Error: Invalid branch target*/;
		case 344:
			/*Error: Invalid branch target*/;
		case 345:
			/*Error: Invalid branch target*/;
		case 346:
			/*Error: Invalid branch target*/;
		case 347:
			/*Error: Invalid branch target*/;
		case 348:
			/*Error: Invalid branch target*/;
		case 349:
			/*Error: Invalid branch target*/;
		case 350:
			/*Error: Invalid branch target*/;
		case 351:
			/*Error: Invalid branch target*/;
		case 352:
			/*Error: Invalid branch target*/;
		case 353:
			/*Error: Invalid branch target*/;
		case 354:
			/*Error: Invalid branch target*/;
		case 355:
			/*Error: Invalid branch target*/;
		case 356:
			/*Error: Invalid branch target*/;
		case 357:
			/*Error: Invalid branch target*/;
		case 358:
			/*Error: Invalid branch target*/;
		case 359:
			/*Error: Invalid branch target*/;
		case 360:
			/*Error: Invalid branch target*/;
		case 361:
			/*Error: Invalid branch target*/;
		case 362:
			/*Error: Invalid branch target*/;
		case 363:
			/*Error: Invalid branch target*/;
		case 364:
			/*Error: Invalid branch target*/;
		case 365:
			/*Error: Invalid branch target*/;
		case 366:
			/*Error: Invalid branch target*/;
		case 367:
			/*Error: Invalid branch target*/;
		case 368:
			/*Error: Invalid branch target*/;
		case 369:
			/*Error: Invalid branch target*/;
		case 370:
			/*Error: Invalid branch target*/;
		case 371:
			/*Error: Invalid branch target*/;
		case 372:
			/*Error: Invalid branch target*/;
		case 373:
			/*Error: Invalid branch target*/;
		case 374:
			/*Error: Invalid branch target*/;
		case 375:
			/*Error: Invalid branch target*/;
		case 376:
			/*Error: Invalid branch target*/;
		case 377:
			/*Error: Invalid branch target*/;
		case 378:
			/*Error: Invalid branch target*/;
		case 379:
			/*Error: Invalid branch target*/;
		case 380:
			/*Error: Invalid branch target*/;
		case 381:
			/*Error: Invalid branch target*/;
		case 382:
			/*Error: Invalid branch target*/;
		case 383:
			/*Error: Invalid branch target*/;
		case 384:
			/*Error: Invalid branch target*/;
		case 385:
			/*Error: Invalid branch target*/;
		case 386:
			/*Error: Invalid branch target*/;
		case 387:
			/*Error: Invalid branch target*/;
		case 388:
			/*Error: Invalid branch target*/;
		case 389:
			/*Error: Invalid branch target*/;
		case 390:
			/*Error: Invalid branch target*/;
		case 391:
			/*Error: Invalid branch target*/;
		case 392:
			/*Error: Invalid branch target*/;
		case 393:
			/*Error: Invalid branch target*/;
		case 394:
			/*Error: Invalid branch target*/;
		case 395:
			/*Error: Invalid branch target*/;
		case 396:
			/*Error: Invalid branch target*/;
		case 397:
			/*Error: Invalid branch target*/;
		case 398:
			/*Error: Invalid branch target*/;
		case 399:
			/*Error: Invalid branch target*/;
		case 400:
			/*Error: Invalid branch target*/;
		case 401:
			/*Error: Invalid branch target*/;
		case 402:
			/*Error: Invalid branch target*/;
		case 403:
			/*Error: Invalid branch target*/;
		case 404:
			/*Error: Invalid branch target*/;
		case 405:
			/*Error: Invalid branch target*/;
		case 406:
			/*Error: Invalid branch target*/;
		case 407:
			/*Error: Invalid branch target*/;
		case 408:
			/*Error: Invalid branch target*/;
		case 409:
			/*Error: Invalid branch target*/;
		case 410:
			/*Error: Invalid branch target*/;
		case 411:
			/*Error: Invalid branch target*/;
		case 412:
			/*Error: Invalid branch target*/;
		case 413:
			/*Error: Invalid branch target*/;
		case 414:
			/*Error: Invalid branch target*/;
		case 415:
			/*Error: Invalid branch target*/;
		case 416:
			/*Error: Invalid branch target*/;
		case 417:
			/*Error: Invalid branch target*/;
		case 418:
			/*Error: Invalid branch target*/;
		case 419:
			/*Error: Invalid branch target*/;
		case 420:
			/*Error: Invalid branch target*/;
		case 421:
			/*Error: Invalid branch target*/;
		case 422:
			/*Error: Invalid branch target*/;
		case 423:
			/*Error: Invalid branch target*/;
		case 424:
			/*Error: Invalid branch target*/;
		case 425:
			/*Error: Invalid branch target*/;
		case 426:
			/*Error: Invalid branch target*/;
		case 427:
			/*Error: Invalid branch target*/;
		case 428:
			/*Error: Invalid branch target*/;
		case 429:
			/*Error: Invalid branch target*/;
		case 430:
			/*Error: Invalid branch target*/;
		case 431:
			/*Error: Invalid branch target*/;
		case 432:
			/*Error: Invalid branch target*/;
		case 433:
			/*Error: Invalid branch target*/;
		case 434:
			/*Error: Invalid branch target*/;
		case 435:
			/*Error: Invalid branch target*/;
		case 436:
			/*Error: Invalid branch target*/;
		case 437:
			/*Error: Invalid branch target*/;
		case 438:
			/*Error: Invalid branch target*/;
		case 439:
			/*Error: Invalid branch target*/;
		case 440:
			/*Error: Invalid branch target*/;
		case 441:
			/*Error: Invalid branch target*/;
		case 442:
			/*Error: Invalid branch target*/;
		case 443:
			/*Error: Invalid branch target*/;
		case 444:
			/*Error: Invalid branch target*/;
		case 445:
			/*Error: Invalid branch target*/;
		case 446:
			/*Error: Invalid branch target*/;
		case 447:
			/*Error: Invalid branch target*/;
		case 448:
			/*Error: Invalid branch target*/;
		case 449:
			/*Error: Invalid branch target*/;
		case 450:
			/*Error: Invalid branch target*/;
		case 451:
			/*Error: Invalid branch target*/;
		case 452:
			/*Error: Invalid branch target*/;
		case 453:
			/*Error: Invalid branch target*/;
		case 454:
			/*Error: Invalid branch target*/;
		case 455:
			/*Error: Invalid branch target*/;
		case 456:
			/*Error: Invalid branch target*/;
		case 457:
			/*Error: Invalid branch target*/;
		case 458:
			/*Error: Invalid branch target*/;
		case 459:
			/*Error: Invalid branch target*/;
		case 460:
			/*Error: Invalid branch target*/;
		case 461:
			/*Error: Invalid branch target*/;
		case 462:
			/*Error: Invalid branch target*/;
		case 463:
			/*Error: Invalid branch target*/;
		case 464:
			/*Error: Invalid branch target*/;
		case 465:
			/*Error: Invalid branch target*/;
		case 466:
			/*Error: Invalid branch target*/;
		case 467:
			/*Error: Invalid branch target*/;
		case 468:
			/*Error: Invalid branch target*/;
		case 469:
			/*Error: Invalid branch target*/;
		case 470:
			/*Error: Invalid branch target*/;
		case 471:
			/*Error: Invalid branch target*/;
		case 472:
			/*Error: Invalid branch target*/;
		case 473:
			/*Error: Invalid branch target*/;
		case 474:
			/*Error: Invalid branch target*/;
		case 475:
			/*Error: Invalid branch target*/;
		case 476:
			/*Error: Invalid branch target*/;
		case 477:
			/*Error: Invalid branch target*/;
		case 478:
			/*Error: Invalid branch target*/;
		case 479:
			/*Error: Invalid branch target*/;
		case 480:
			/*Error: Invalid branch target*/;
		case 481:
			/*Error: Invalid branch target*/;
		case 482:
			/*Error: Invalid branch target*/;
		case 483:
			/*Error: Invalid branch target*/;
		case 484:
			/*Error: Invalid branch target*/;
		case 485:
			/*Error: Invalid branch target*/;
		case 486:
			/*Error: Invalid branch target*/;
		case 487:
			/*Error: Invalid branch target*/;
		case 488:
			/*Error: Invalid branch target*/;
		case 489:
			/*Error: Invalid branch target*/;
		case 490:
			/*Error: Invalid branch target*/;
		case 491:
			/*Error: Invalid branch target*/;
		case 492:
			/*Error: Invalid branch target*/;
		case 493:
			/*Error: Invalid branch target*/;
		case 494:
			/*Error: Invalid branch target*/;
		case 495:
			/*Error: Invalid branch target*/;
		case 496:
			/*Error: Invalid branch target*/;
		case 497:
			/*Error: Invalid branch target*/;
		case 498:
			/*Error: Invalid branch target*/;
		case 499:
			/*Error: Invalid branch target*/;
		case 500:
			/*Error: Invalid branch target*/;
		case 501:
			/*Error: Invalid branch target*/;
		case 502:
			/*Error: Invalid branch target*/;
		case 503:
			/*Error: Invalid branch target*/;
		case 504:
			/*Error: Invalid branch target*/;
		case 505:
			/*Error: Invalid branch target*/;
		case 506:
			/*Error: Invalid branch target*/;
		case 507:
			/*Error: Invalid branch target*/;
		case 508:
			/*Error: Invalid branch target*/;
		case 509:
			/*Error: Invalid branch target*/;
		case 510:
			/*Error: Invalid branch target*/;
		case 511:
			/*Error: Invalid branch target*/;
		case 512:
			/*Error: Invalid branch target*/;
		case 513:
			/*Error: Invalid branch target*/;
		case 514:
			/*Error: Invalid branch target*/;
		case 515:
			/*Error: Invalid branch target*/;
		case 516:
			/*Error: Invalid branch target*/;
		case 517:
			/*Error: Invalid branch target*/;
		case 518:
			/*Error: Invalid branch target*/;
		case 519:
			/*Error: Invalid branch target*/;
		case 520:
			/*Error: Invalid branch target*/;
		case 521:
			/*Error: Invalid branch target*/;
		case 522:
			/*Error: Invalid branch target*/;
		case 523:
			/*Error: Invalid branch target*/;
		case 524:
			/*Error: Invalid branch target*/;
		case 525:
			/*Error: Invalid branch target*/;
		case 526:
			/*Error: Invalid branch target*/;
		case 527:
			/*Error: Invalid branch target*/;
		case 528:
			/*Error: Invalid branch target*/;
		case 529:
			/*Error: Invalid branch target*/;
		case 530:
			/*Error: Invalid branch target*/;
		case 531:
			/*Error: Invalid branch target*/;
		case 532:
			/*Error: Invalid branch target*/;
		}
	}

	static ActorMovementFSM()
	{
		/*Error: Invalid field token*/;
	}
}
