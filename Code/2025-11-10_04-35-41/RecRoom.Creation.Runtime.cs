using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Build;
using RecRoom.CircuitsV1.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81EAE30", Offset = "0x81EA230", VA = "0x1881EAE30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class TDXBJWGRPKN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HAEDWNIRTWR;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GSMOFPYHFRT;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> QIMDXSOVQUH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> UKGRXUPONWQ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string YJHUFIGFVIG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string FQECIDBFTTB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string STJOMHXMMES;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81ECB70", Offset = "0x81EBF70", VA = "0x1881ECB70")]
	public static bool OHCVLXYVOTT(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81ECAE0", Offset = "0x81EBEE0", VA = "0x1881ECAE0")]
	public static bool MKMMINCVOXZ(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81EC460", Offset = "0x81EB860", VA = "0x1881EC460")]
	public static string ESQRTWBNVCG(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_HAMMER,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PAINTBALLSPRAYCAN,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_DISCOVERY_POPUPSHOP,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_ROOM_BOOST_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81EACD0", Offset = "0x81EA0D0", VA = "0x1881EACD0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NJNHRLAXLVG
	{
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid XHDHRCTDZNP;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid HQMHPVGCGWJ;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid UOJUXTIGDZB;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid FWUDDRIEUCP;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid XXMLBKDWGHE;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid ZWGNATTKRRM;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid OVJOSSUGUNZ;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid OSUTCDYUIKY;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid QXJXMWHQBPO;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid DKLVIBYLNMU;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid INSIWNRXSVH;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid IBXHFGSOQFC;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid HOLAUJQWHLV;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid HHASULDAEIY;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid TGUVGEVPFFJ;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid UTJWKNBSFDG;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid AODXZWVVCSC;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid YSYTDYBOXRV;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid BYYIODBQQYQ;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid SDIHAVQCINV;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid DRWXXUEKYNL;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid TZSXMHMJYZX;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid PFOMKAPCPPB;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid MUNFGTTTKDT;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid IYEMCXEUOZB;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid ILXEPWOTPEC;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid UZLVOGXHRLF;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid NGRWMXLEEYU;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid EUCCHTRQKHK;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid GFVUZNSYQLP;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid ODUUWDOGQVJ;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid PVRSVTVNSNQ;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid LSRLVKUOBQZ;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid BEJFJZSSHDK;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid KKUEHLPHWEG;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid LNBICRKDKJO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid YZHDHWVXJYG;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid DGXVQJGSBFW;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid THONYETTIOU;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid ELEVTILAWXQ;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid PWZAQINMGJI;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid GXKDBMFRQAA;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid FAYNTDXNBBX;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid QMFLLEDNLIK;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid XEANQZRQXSD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid SZXCFRTCVXZ;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid HEGKRDSQRNV;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid QROVUSOQAXI;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid VTHOFBNEMKV;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid WGYWPHXIUEM;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid UOCXCUMJTOQ;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid FEBIBQSZYZJ;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid EABMLDOQZGP;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid JFXEDNQZGFH;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid IDNQQHHAIMC;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid NMYVTQZEWWI;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid ABWPPRAFPXD;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid DYCSOUWUIGP;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid ZIWBOWMXOPY;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid QBYXPVRRNGT;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid VYIXANLZHZO;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid BGVPVAXIYJW;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid VRWBKQERJVR;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid WJNYMMGWHGK;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid EXPNBQODLNI;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid SFGBKUMIDFT;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid WRZMLGHLPYN;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid NPOMADBYXFK;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid IORNRGCZQAN;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid HSFXSFGRARI;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid KVWLUVGJZWN;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid YVVHMGTCVDS;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid ZHTUGDGWRXY;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid WIKARSCDJHT;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid GGBHZWPNIRF;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid YBAPZKZFCSH;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid ZUBTBLYVDPB;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid DAVKPCPBLSP;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid PLOAPNFSOZM;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid FWZVXQBGRDN;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid ATOLAUNHTKI;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid OZAKOJHRCQP;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid GIJEYWEAQLS;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid CLNIXBVHECA;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid VLXOUWOLIHU;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid FHEEDDWMXNX;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid XHKVEOUJLWM;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid ERXIDPVSBHC;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid NURJFJSEHWJ;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid WCPOBCLHBQB;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid ZWFXGTWZCTG;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid VLJNVVFROSM;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid CHMRFYFPBDC;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid CXVTARNKCDM;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid MIMTHAUKGSA;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid GNUELKWWJNX;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid WRXSOJXXTRC;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid FZHKSUFVQEM;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid KNTEZICKRJB;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid XYQLGKOLCTS;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid PVJJLUZDZIL;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid CFDJAJGJPLW;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid PVTXGIMYSFD;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid PULKFZRGGHI;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid UTJUPSAWEFK;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid ZQJAPKEDDHT;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid KBZDORVRJVQ;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid MYAYWCCFQTR;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid KBOPUEHWQYY;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid CUXRTRDJMFH;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid KBEBZQUBYCG;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid KZMNWFMPHJF;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid EVKSTDXJEFB;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid YBVNDCKKUWK;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid DCXXKHDXPXC;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid YVLDXLKLXFF;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid DKVIJBXEXYK;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid YAZYHXNRYHY;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid KABQOKDISPN;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid FJTSDAOYRKI;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid LZYKOUDVNAI;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid YYEIGJUNOZC;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid BXOGJKQCVOE;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid XOBYZOYXKLE;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid FJTUMVXOWNM;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid FTXOFHULFMC;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid DXPOLZPWRXF;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid SDAXWRYUXBK;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid YNWKSRXNYRY;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid SVHWGCHWZDY;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid BLUNVEBMWUJ;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid WWYYERXAJGG;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid RGTYASGBOPD;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid JEMWKIDLRSX;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid EHROISPDNSY;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid HHDPSWZZIHU;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid OGHEEDPVZYF;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid WRLOZLGPJET;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid NAWZRVDUANU;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid KPHOKEPOYQY;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid AGDWLGBZLXB;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid ARXPUXXXEEF;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid JKHNKYWOVWF;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid UEVIHQKIRWT;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid OHZGSKCHBWY;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid IVWQOSMDWYE;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid IWMLGMTVZGF;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid IWHEJFZYPUW;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid IVGVWYELUQD;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid IVBOZRKOLEU;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid IVRJRLSGNMV;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid IVMCUEYJEBM;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid XBHXZHFMEGM;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid QCXPTJSGJNE;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid NFIDYAWZXFB;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid OOAUBLEXCGX;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid DOJZLYMGGWW;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid VEWLIVHNDFX;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid NWOISEXZIOD;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid QAPNRERDTQP;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid KSDGPKYOGQU;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid HUDEOFRVKXE;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid LMTRFKKMHUP;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid LDFAQZBQWEO;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid ORVBAKEJHJX;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid IHSXVHPXTPN;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid CTCCNQGDIUU;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid NDRROENYVOF;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid IHYESOJVDAW;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid IIDLPVDSMMF;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid IGSPIZUKYKU;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid THKIEROEXVV;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid NLIWDJPUHXO;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid CXVMGZACMIZ;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid THPPBYICHHE;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid ZAZICETAUXB;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid RLRNBBBKEMG;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid MAJYOGNGPSQ;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid BQKRKBBRJAJ;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid GGUPZAFFCYN;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid OOWJESMHQSD;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid XNWYRFFGYCR;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid TCWXFTVFSHB;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid DSCFVKQLTHO;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid WMUJSJTRLDR;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid XGWZAMEPQMC;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid IUQVVYAUOCA;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid GBHJASUGWIG;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid MBNWBZVEWNK;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid FTLGTJIGCDP;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid ZJBRCOAIPNN;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid ECZPSORFZFA;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid OTDREJPZALG;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid AZUJUMYAWTF;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid XANUAVZTCIE;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid TGAKSDQMXUC;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid WXODPUCFQFV;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid RJSJESUUISG;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid PFCIKGDFLYB;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid PVDTJDFBTSB;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid DJXPWYMRAGY;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid LQIMTXHGGFP;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid LGIKZUNJEPU;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid AHSLBCCEFOU;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid OIJAKJLYNEG;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid MNBFHZCRWSN;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid HDGWYPJRIJK;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid FCSNFDIGIAM;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid HKKPDVGLOOT;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid NVVZWXTEFJH;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid LKQAZJNGRLW;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid ADWDCXUTHCF;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid LPZHASMLCEY;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid NSWJCFPGJDP;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid ICTEQOSGMZP;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid APMBQBYWVGT;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid UUNYZDWWHFZ;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid QYAYOMEPTMM;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid BTEYUKREBXI;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid PGGJPELQJCX;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid FEUHLPWTRLO;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid NZFWHPSRNWZ;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid UAODOQEOPGX;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid XMEODGHENRF;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid DVHKHYBCZOS;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid JDUJXSAAIQK;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid MDEESJLIVAB;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid MGBDYOUDNPO;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid QUOYYTLPTAX;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid QZMSARQCMYA;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid UMMGFIQAFIY;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid GATEQTXSGNE;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid TMLJCBRSQOU;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid BROXZFTUCZI;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid OSYGMYQENQU;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid FOPNQWQQUXF;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid IXEBQBUBRPY;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid EYGPJXIGLUA;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid LDQMETCXKUF;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid ZHBZAUKUBBW;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid EOUOUMHWGSP;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid KHSAXTIWGQF;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid MHJXQRGPQCX;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid GZYXIVWBOFQ;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid OJWCTJZGGHB;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid ARXUVSEVACW;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid EZMORNAJOES;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid AOPTEYXECEP;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid IUGLVODYDQO;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid QQCAXIYRSRQ;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid DQMSNWPOZVI;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid TOHOYCJSJIS;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid XQWDFYYQUSU;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid XKFVEYRQCNS;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid NPZKMXIPDFP;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid OEACASUINRP;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid OVWICMTQTWO;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid XOSMOEDPLBP;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid SYPPCSPJCDG;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid UMQPQKFNPYQ;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid LJMMGMHQBXH;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid IXPWGVTLGZG;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid XFWJVSHWHXS;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid IQLWMLEVKPG;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid CZVTZVMMGTI;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid IEEALAKCZRQ;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid STLALFBVTLI;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid EPLLOFKQCPM;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid MBTZSXVFDAH;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid UMFXGHTSIBJ;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid HBXEXNGHSMY;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid GXYEQYZELRR;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid FDBCGANCPAA;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid SJPCGOETAXC;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid CGDSSCCMPVZ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid EQMRDEYSGRA;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid UMUHHLQEWDO;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid PENJJCGNSEC;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid JVAAPWUWGEZ;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid BPUBERYYCBX;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid BCNRZEWURKZ;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid RAZYVSZFMSY;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid GOBRJEGWTGC;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid OZIBEYNYAHO;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid AVRKNYWOAJW;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid XNSNQORWUZZ;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid AAFBHHPVNTD;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid FERKBWCIKBD;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid UJLEXWOYDJY;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid EGMATWTNATQ;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid EXFMHDUKBKX;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid KHAPKAJMLGT;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid ACBCKRJNZTU;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid KQIAJCAMVKI;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid UGWFRMHFHBZ;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid UXBSGOZTGWE;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid HRQFHYSUDTT;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid LSXOQNHUVRM;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid LPPJIIYJYHU;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid MEMFPRAPBRK;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid AZSDTFMOXTB;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid WMWSFUCQGLP;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid BEXBFHKNWLN;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid DWDMDQNNIOO;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid BGXXDZUTYSH;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid JVAEVOGHDXZ;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid KBDOVXJAXQN;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid QVJHNTWUAIV;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid FAEOPZKEXJU;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid WBJABWKYYBA;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid NLGRGDFKBGU;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid PCCLIDUFLGS;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid HWDPHKWLBTE;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid YTZAVNUERXG;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid YBZKKCVIRVR;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid MHTPQGXOIWH;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid QYOKGFUYIGE;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid LQITORAXJEN;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid PVQNAXBXJEH;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid JIXMOQSSZGR;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid XMXABPHFRLG;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid BBEJPNFUBXG;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid CXFRHRZPGKT;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid PPDYBDVPTAN;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid TFYMVXKQVHJ;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid NELXMGVOKFN;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid WOXXPYUNVSQ;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid JYTBHTDFRCK;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid ZSEMKNFFWMF;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid XWPVNJMCDKL;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid RAAPWTFZHFL;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid LMSGFPQFUOF;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid LJQZTFAFBBM;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid ZUCUCEEDSZE;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid AJULLNCZUWG;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid MHHVKEQAIKN;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid DBZMRSLSDYN;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid YAOAPGCGQRO;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid VKQFQWKWKBY;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid AVQODLHUYDF;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid YLUCLSHDEEL;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid KXNRDANNSUG;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid QHEWJGSWQBR;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid ZWQNRSNPSIP;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid UQVYZCUDFUE;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid FTNIMWXSMFB;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid ITRRSQOGOTD;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid YSSASEKFNCK;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid ENTKYOWHDFV;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid XQPBYTKIYKU;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid ZHJQQRJFZWJ;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid BACSWQXDGCX;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid OOUJOVCYFIF;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid JUHMUORUSYD;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid VWGOYMTYVYI;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid ZJRFZSLXZQY;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid DILUKHQJCGZ;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid KMABSMMXKXK;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid UIVTBTYAISO;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid QXSKXHRUASW;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid IUKWUCLMNHZ;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid GOVSYYCUWAK;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid AWJUJPWUAEH;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid FCMXBYTGXOC;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid UHIKBAZKEML;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid QFTHVUIYNRH;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid QJMIPPYXVSO;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid RCRBZOYDTDU;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid IWSKMDWXSLI;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid XPXZKOXEQOK;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid EOTPGFDKXTI;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid ZCFQPYSDWYV;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid CKDNADIOMBE;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid GUGMOJKGYAP;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid HKHWXXUTRZO;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid LSOMEIYUAUT;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid FKNLEEPVTHI;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid TQKCJFFTAIJ;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid MNXJFYUEYHY;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid WRSIWZXTJER;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid MDWZSDPUING;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid IWUUSLGJQHP;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid VYOHYBJNDCH;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid GYUYNFEQYRS;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid XCKKCQALGVP;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid CRLPQCDRQPS;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid IMWZZGVVSKV;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid IVMMJRTLOQN;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid AYFSRXWRCYZ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid LGCYXAPLHDN;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid HNHBFKRIPPM;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid UYBBXABLJUU;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid YHIOXLLJEST;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid CZZLFJLLNXY;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid SNBUFUGHKOJ;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid FWSLYVHHIPV;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid QUFYABTSJSF;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid IMDHMCDPOIH;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid HZTECOERHUS;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid IOXOVFXVGZT;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid WZEXTBWWPHE;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid YUJDGBKWOAO;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid WDJTFKGYLOX;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid BQWNEZOLHQZ;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid ZGYRGMJRBRI;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid FREBKBWESXO;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid JDRZTDCQPEA;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid QLYRDEUPRHT;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid HCFKDHSQAFA;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid NFSZKJZGZSZ;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid TVCHWOTRAPH;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid PXKUKGXMDIC;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid YQYMGRIQLFW;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid FEXVQFXYQNE;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid PGCBCPDLLEV;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid PBOJTDEHTIY;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid XSHTTSFBZAI;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid QHXYWZSFBSO;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid SUQQNQQGTOM;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid MJMSLIRKBEC;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid FGKJUDFDNZF;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid PITAVJFKIHD;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid ABSSFVMFEIM;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid UIWFOXDXGJC;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid ACIMXPTXGQN;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid ACDGAIZZXFE;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid ABCXOBENCAL;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid AAXQQUKPSPC;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid ABNLIOSHUXD;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid ABIELHYKLLU;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid AAHVZACXQHB;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid AACPBTJAGVS;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid ESARXKNIDTM;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid IRWGCBMMOCS;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid QWMPBRHWAKL;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid ZEOPCTVGNPJ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid KJPFOPLLBYL;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid NUXTEKSBTRX;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid RSBVKMMYADO;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid PVZLKOLHZRC;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid BTQDEGRGEKB;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid LXJFKNSYLOP;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid PEQZKAYCIFM;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid VOASLXMVLUI;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid GADFCXPFKPK;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid MYIUXZTHLZN;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid JEVXADEIOHE;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid KMPQPNMVIRM;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid KJAREXDVPJD;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid WAHFUZJHQYB;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid YGYWBVASAKL;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid JATHMTJXZOT;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid IBIMNYRSGKE;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid IYYLQSWZTST;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid IZOGINERWAU;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid YHGCGWXANMK;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid MXQRSRVGSZJ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid FWTDBBGQHYC;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid ROUMNBBBRWT;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid HPZIRZBMLKP;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid CGNDYEYFPOM;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid KSNYKWIEUQU;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid ZMYWWGBOSLA;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid XHMDRXNTNQC;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid CJBIKSLBSTE;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid LPFVPFXMXRN;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid EPGGUTQXNBU;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid MWWXENAZUGC;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid MGJPUPLWHYD;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid RMGPBERRLPU;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid FUDQPRGOAWL;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid TQQKNQTBTOC;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid BVDDVEJQABA;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid OPJFIKBMCCV;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid LTDCHEQVIZI;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid ICXWOBOUEZY;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid QITXNDVZQTI;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid TEMMDNHSWMY;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid IIHXQEFVJAD;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid FNAYIVPGORR;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid VBINCPBCHGL;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid VGJJJAUQZZZ;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid AOZOQBWMDVZ;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid GPSKPNXXNQR;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid SPKINUDLMTE;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid QWRQIVUZOQR;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid KSPGKZSUTKD;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid TJFRTTVLTHA;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid TYYEFAPUQBC;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid BCTFNBUXPIN;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid QSPFOGDHMUS;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid NMGYKTETHAT;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid RGTCRLSNJSN;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid KEGLOXUMSOI;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid YVYAWAUTPYI;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid HPNERIVDJFC;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid PTTPRFSFIOQ;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid BWOSAFFIKQO;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid INUYUMZGBZD;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid ALFEOIQNMTF;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid KCCXDWQWFTY;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid NSOOLNUYNNP;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid YQTBFJZKOCG;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid YSONODQFRSX;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid EBZRQGOIVJQ;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid HNXHYJSNVEL;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid XPOHLPUHLZS;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid DCFGDNKLBJD;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid ZUZTZEYPZDH;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid JOVJWSIIENE;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid JWMCYXRFOQE;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid XUIHGJGAQUC;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid GZGXIXQSOTR;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid GXCJKJHTZIO;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid WYHDQGSBEEP;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid GJGXEOSWVGJ;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid QDZOYUMWXZG;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid QWELVRRQXXI;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid QWJSSYLOHIR;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid HLLMTIKOJKX;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid QTLNFRFBETX;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid ZKFRGRQZVFE;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid QLNMLICJNUE;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid BBWJGMXZITQ;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid IOSGTAMUMZJ;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid VCDSLUCEGFA;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid UQFQEVWYWPB;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid DKKJTXKIRJE;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid EWXLRUFFBBC;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid GPERBVTJCCF;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid IQRAZRNYYZQ;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid HMGJELJVBEI;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid BJETGCNGQUA;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid NSOHXMGJDQZ;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid GICNJEIAKCR;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid QIUFXPMCBRU;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid MAEUWKRDOHG;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid FZNBEXQJFMT;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid HUTUOAJTYHJ;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid RXPBBBNWLRC;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid SEQPJSAISLI;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid ZTYIBZGRLGK;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid AWKASPQOTFM;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid PDRHTUUPXQC;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid QFCVKFKWSOL;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid ZICSPBQADLZ;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid EXEBZIPUNQA;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid UUINRGNRRAB;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid EWLZWULAXIB;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid JSHKBRPDFJG;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid EOROBYRTFFP;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid BGHEXJJLBUK;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid YEYWKIWZHMU;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid EBEUZASBULP;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid AMKJZJUKQET;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid QQSKPSNXVZJ;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid SVTPHYAVQCL;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid YIHVNAXKEVR;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid YVYIYXCECZP;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid QWZCGXAZKAS;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid PLKNMUATVGX;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid UPGKZNTEDJA;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid WUDEUUTGKJK;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid SLBNSQONGYM;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid KKJJNIGCGPK;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid EDUFLMPIQUR;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid KGWZGXEYZMI;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid WBWNTSXCDVR;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid AZWWKYKFYSB;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid AZHBTECNWKA;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid AZMIQKWLFVJ;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid LFKFXLMIHEW;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid MEGZUVKSKRI;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid MEBSXOQVBFZ;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid VFXBAEMXDID;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid AGNETIYEMIL;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid HEHCFSZWVFN;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid XBBYMOLQIUA;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid XIJEAVOWWFP;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid VXGTAQQQNDV;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid IIQTPOBZUFK;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid EPBNUCXXDWC;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid MEGKSPSSQLB;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid NWSHVKFFMUT;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid URLQAQESHZF;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid NIPNMWOQVKJ;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid PCZMOEMAULG;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid GLGEFROLRBO;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid YLYUDEIUEAB;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid RZHVVEPUPFV;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid PRWZVXHOWTU;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid RESEKYIJLRV;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid XCVYGUAXMOR;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid VHUMMJWWQAP;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid MNYCDZKIUDT;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid FOVYLCBQSUO;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid ZFOLIHWVQNX;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid QLHUXRSRRDG;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid BCQSEEBARFG;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid VMDBOYAQDVE;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid ACOEQGWDPFV;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid DQLVKYIHQZD;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid KELPRTOGTZH;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid GXRFFSBDZRH;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid SEVRNNLIALB;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid KYARVWBHLOD;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid AUVRDBTVAID;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid RTEIXIIAWDK;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid ZRIKOCEVQVX;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid IEFRILWXUOL;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid GOOIZDSWWVW;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid NMKEDAEGBQL;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid OWGDSNYRHJB;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid BKYGTCIIOKJ;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid LEAOLTVPXMX;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid VUJMNJYFVTT;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid IPFHTZUUGHL;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid ARNGTXSOKSM;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid CJCOMNRQZZJ;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid RTJINKZDHLD;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid WNJAIMKZXWH;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid IMVWLPLDZUY;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid WZBSKCHITPU;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid JRKGOBEINYU;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid XWVWOWYWAJD;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid VSVCGRTJQMK;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid IZAGOTDOUTT;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid IBBUOYBUOYC;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid YVCIMHXGHGV;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid JRMNNICDOQV;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid CSUAZZYUHKT;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid LEWRRECTVYU;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid NVLZRSUHQNH;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid ZGJOBGOKWPH;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid TSPDPZGPQWY;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid DXVCJKAAPLO;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid SJPCOMLBNCP;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid ACSANVZBOJQ;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid DQJQEAAMOKH;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid VOIOSHUQTRM;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid KJDBIBXZAUP;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid XNJCXKKEEPD;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid UQVGJGEJXWQ;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid GBJTNVFQOLK;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid MBBPREQTKWJ;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public static readonly Guid OLUUDCPYAMM;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public static readonly Guid UJRIELPIBFN;

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public static readonly Guid OXMGUGLRCPW;

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public static readonly Guid WGHZTNFZBYN;

		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public static readonly Guid CGNDBCJCRUL;

		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public static readonly Guid WKVZYGVSGWG;

		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public static readonly Guid LVGXVEUECAI;

		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public static readonly Guid ZTIEKJDLCSV;

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private static readonly Dictionary<Guid, SpawnableToolType> NHZYOOWBNRH;

		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private static readonly Dictionary<SpawnableToolType, Guid> MPVSEFZGYSV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> WPVOBOVCLSE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81EADE0", Offset = "0x81EA1E0", VA = "0x1881EADE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> WYISOVSYDWA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x81EAD90", Offset = "0x81EA190", VA = "0x1881EAD90")]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class VWUVQMEDLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81F0580", Offset = "0x81EF980", VA = "0x1881F0580")]
		public static bool KFPRYICFAXJ(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81F0170", Offset = "0x81EF570", VA = "0x1881F0170")]
		private static bool KFPRYICFAXJ(YGKOEWMSPXW a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface FXCZNZKGNYN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(MUVSEZAENMX data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, MMFAKCCGJNV circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly KXJXLLGOBKY Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly IEnumerable<BMALMPEIUXS> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public readonly IReadOnlyList<BMALMPEIUXS> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public readonly Id32<HUXETNCTSFJ> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public readonly IReadOnlyList<Id128<FRZIQAPUPIV>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CLCCOLAODFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81EB8C0", Offset = "0x81EACC0", VA = "0x1881EB8C0")]
		public R1CreateTemplateParams(KXJXLLGOBKY circuits, IEnumerable<BMALMPEIUXS> rootData, IReadOnlyList<BMALMPEIUXS> allPersistableData, Id32<HUXETNCTSFJ> sourceGraphId, IReadOnlyList<Id128<FRZIQAPUPIV>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public readonly KXJXLLGOBKY Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public readonly IReadOnlyList<BMALMPEIUXS> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public readonly Id32<HUXETNCTSFJ> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public readonly IReadOnlyList<Id128<FRZIQAPUPIV>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81EB930", Offset = "0x81EAD30", VA = "0x1881EB930")]
		public R2CreateTemplateParams(KXJXLLGOBKY circuits, Id32<HUXETNCTSFJ> sourceGraphId, IReadOnlyList<Id128<FRZIQAPUPIV>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<BMALMPEIUXS> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ODIIBODJPET : ANIBKCUTPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly Guid HHOLSILATKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private readonly Dictionary<Guid, Guid> WYJUHVOTNZC;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4E3A8C0", Offset = "0x4E39CC0", VA = "0x184E3A8C0")]
		private ODIIBODJPET(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81EB4C0", Offset = "0x81EA8C0", VA = "0x1881EB4C0")]
		public static ODIIBODJPET New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81EB190", Offset = "0x81EA590", VA = "0x1881EB190")]
		private static Dictionary<Guid, Guid> GOOOOMKZRYZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81EB840", Offset = "0x81EAC40", VA = "0x1881EB840")]
		public static ODIIBODJPET WRLDBOPLTLM(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81EB550", Offset = "0x81EA950", VA = "0x1881EB550")]
		public static ODIIBODJPET UYUALOAXEMH(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81EB850", Offset = "0x81EAC50", VA = "0x1881EB850")]
		public Dictionary<Guid, Guid> ZCDVIVDBGNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
		public Dictionary<Guid, Guid> DFOSFKFEEEV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81EB000", Offset = "0x81EA400", VA = "0x1881EB000")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81EB240", Offset = "0x81EA640", VA = "0x1881EB240")]
		public void MTWNSBKJULW(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81EAEB0", Offset = "0x81EA2B0", VA = "0x1881EAEB0")]
		public Guid ARZRBRAFCKC([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81EB0F0", Offset = "0x81EA4F0", VA = "0x1881EB0F0")]
		public Guid GIHNQFFXBSD([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81EB080", Offset = "0x81EA480", VA = "0x1881EB080")]
		public bool BDCPKCPVLJK([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81EB080", Offset = "0x81EA480", VA = "0x1881EB080", Slot = "4")]
		private bool WBMWDKRRYNC([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface KSSVVVLPMYD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JRHDYFQAVZO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FOIQJEISQKE(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DJFOGPLHFTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<ByteString> GetValidRoomCurrencies();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<ByteString> GetValidRoomConsumables();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class RDXOMRMPIFB : KSSVVVLPMYD
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JDWHIWVNMBK : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private string JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string XRSXERLDEVX
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public JDWHIWVNMBK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x81EAC10", Offset = "0x81EA010", VA = "0x1881EAC10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x81EABD0", Offset = "0x81E9FD0", VA = "0x1881EABD0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x81EAB40", Offset = "0x81E9F40", VA = "0x1881EAB40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> DNUVTWOVQJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x81EAB40", Offset = "0x81E9F40", VA = "0x1881EAB40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private Dictionary<string, HashSet<Guid>>? MBFXVJDTXMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		protected Dictionary<string, string>? XFMHQRZNOGJ;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> UOBEXFPVQCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x81EB9A0", Offset = "0x81EADA0", VA = "0x1881EB9A0")]
			[IteratorStateMachine(typeof(JDWHIWVNMBK))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? PJOBBROBDSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool CXDAMRQDQGB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool LGIIPIHACWM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> LLRWSOTNRSH(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool RXSSWMMQKGV(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81EBA00", Offset = "0x81EAE00", VA = "0x1881EBA00")]
		public void EAENGIIMZJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD15010", Offset = "0xD14410", VA = "0x180D15010")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81EC130", Offset = "0x81EB530", VA = "0x1881EC130", Slot = "4")]
		public bool JRHDYFQAVZO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81EBE30", Offset = "0x81EB230", VA = "0x1881EBE30", Slot = "5")]
		public bool FOIQJEISQKE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81EC070", Offset = "0x81EB470", VA = "0x1881EC070")]
		private bool IYVVBKKGVHW(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81EBF00", Offset = "0x81EB300", VA = "0x1881EBF00")]
		protected List<Guid> ILZQENNELJD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected RDXOMRMPIFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class DYDMQHPIJRZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public KXJXLLGOBKY UTDNCCNREPO;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x81FA9C0", Offset = "0x81F9DC0", VA = "0x1881FA9C0")]
			internal Id32<FHMKUSQVKNG> OICHHSSLNHY((Id32<HUXETNCTSFJ> GraphId, Id32<FRZIQAPUPIV> NodeId) i)
			{
				return default(Id32<FHMKUSQVKNG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private const int OVDXJGRDXRG = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private readonly Dictionary<Id32<FHMKUSQVKNG>, PFOZBSILUNE> FEPNKOAMZFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private long TFIKOQXHQXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private long CJHKGTCRVNB;

		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private static readonly ReadOnlyIdArray<FHMKUSQVKNG, int?> NFRUKKUVCWW;

		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private static readonly long OQJUVIBJYNW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long RSEKNFXAYZA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81DD550", Offset = "0x81DC950", VA = "0x1881DD550")]
		public static DYDMQHPIJRZ ZQSVJFPTSYG(KXJXLLGOBKY a, Id128<HUXETNCTSFJ> b, [Optional] DYDMQHPIJRZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81DD1B0", Offset = "0x81DC5B0", VA = "0x1881DD1B0")]
		public static (long, long) YEUZDFCCWLC(KXJXLLGOBKY a, Id32<HUXETNCTSFJ> b, Id32<FRZIQAPUPIV> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81DD090", Offset = "0x81DC490", VA = "0x1881DD090")]
		public static long QTVNTSPUXMP([In] ReadOnlySpan<Id32<FHMKUSQVKNG>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x81DCF60", Offset = "0x81DC360", VA = "0x1881DCF60")]
		private static long KXOTRBFZPMY()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81EAAC0", Offset = "0x81E9EC0", VA = "0x1881EAAC0")]
		public DYDMQHPIJRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class PFOZBSILUNE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long YFPKVFRAQPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x10BA780", Offset = "0x10B9B80", VA = "0x1810BA780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D47200", Offset = "0x7D46600", VA = "0x187D47200")]
		public PFOZBSILUNE(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class AMIJXIKOQMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public static readonly HashSet<SpawnableToolType> HBFDEWDCWEV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RVZRXPRHLWX
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class BRXSHGJXADM : IEnumerable<BMALMPEIUXS>, IEnumerable, IEnumerator<BMALMPEIUXS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private BMALMPEIUXS JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private SpawnableTemplateData RGTXGRUTNRF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public SpawnableTemplateData HQVZVFMDCOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private SpawnTemplateParams VHZCBVFZVAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public SpawnTemplateParams QTPOWQFFWUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private int TSYGMCBXPQU;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private BMALMPEIUXS UGGBXGEAPFF
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public BRXSHGJXADM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x81F0960", Offset = "0x81EFD60", VA = "0x1881F0960", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81F0920", Offset = "0x81EFD20", VA = "0x1881F0920", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x81F07C0", Offset = "0x81EFBC0", VA = "0x1881F07C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BMALMPEIUXS> JYFKBSTPNAQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x81F07C0", Offset = "0x81EFBC0", VA = "0x1881F07C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81FD400", Offset = "0x81FC800", VA = "0x1881FD400")]
		public static SpawnableTemplateData RTYHNUYRJEI([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81FD580", Offset = "0x81FC980", VA = "0x1881FD580")]
		public static SpawnableTemplateData RTYHNUYRJEI([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81FD060", Offset = "0x81FC460", VA = "0x1881FD060")]
		private static HashSet<Id128<OPTEWREDVNL>> RTJVYUWQMYS(IReadOnlyList<BMALMPEIUXS> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81FD710", Offset = "0x81FCB10", VA = "0x1881FD710")]
		private static void WZQKHPLQHSH(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81FB5C0", Offset = "0x81FA9C0", VA = "0x1881FB5C0")]
		public static Result<ODIIBODJPET, TryCloneTemplateError> ONIZFFYAECK(SpawnableTemplateData a, SpawnTemplateParams b, ODIIBODJPET? srcRemapper, bool c)
		{
			return default(Result<ODIIBODJPET, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81FB220", Offset = "0x81FA620", VA = "0x1881FB220")]
		[IteratorStateMachine(typeof(BRXSHGJXADM))]
		private static IEnumerable<BMALMPEIUXS> GZSKKMKHJXB(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA90", Offset = "0x81F9E90", VA = "0x1881FAA90")]
		private static void ABFRBBNLEIU(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81FAB90", Offset = "0x81F9F90", VA = "0x1881FAB90")]
		private static bool FAWDIUCLDGX(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81FDD80", Offset = "0x81FD180", VA = "0x1881FDD80")]
		private static Dictionary<Guid, YGKOEWMSPXW> YQNKOGFPDGP(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81FAB00", Offset = "0x81F9F00", VA = "0x1881FAB00")]
		private static void EDYWGHLDVKF(bool a, BMALMPEIUXS b, ODIIBODJPET c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81FB330", Offset = "0x81FA730", VA = "0x1881FB330")]
		private static void MHUCVDDWESJ(BMALMPEIUXS a, Guid b, SpawnTransformData? c, Dictionary<Guid, YGKOEWMSPXW> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81FCBB0", Offset = "0x81FBFB0", VA = "0x1881FCBB0")]
		private static void QEDLTVCHJVO(IEnumerable<BMALMPEIUXS> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public KXJXLLGOBKY circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public DJFOGPLHFTR roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public FXCZNZKGNYN circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public Id128<HUXETNCTSFJ> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public SMYDLSZQBNT globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public List<BMALMPEIUXS> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public RUPGDKOYKXF photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 LUXQQMJINMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x81FEBE0", Offset = "0x81FDFE0", VA = "0x1881FEBE0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS JBQECQWQJVL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x81FE890", Offset = "0x81FDC90", VA = "0x1881FE890")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13C11E0", Offset = "0x13C05E0", VA = "0x1813C11E0")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x81FEFF0", Offset = "0x81FE3F0", VA = "0x1881FEFF0")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x81FED70", Offset = "0x81FE170", VA = "0x1881FED70")]
		public static SpawnTransformData UKTHEBHIZTJ(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x81FF0C0", Offset = "0x81FE4C0", VA = "0x1881FF0C0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81FF0E0", Offset = "0x81FE4E0", VA = "0x1881FF0E0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81FECE0", Offset = "0x81FE0E0", VA = "0x1881FECE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81FE9D0", Offset = "0x81FDDD0", VA = "0x1881FE9D0")]
		public SpawnTransformData LIFMPRYSKST(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81FE960", Offset = "0x81FDD60", VA = "0x1881FE960")]
		public static SpawnTransformData FFMSKTAEQDX(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81FE8D0", Offset = "0x81FDCD0", VA = "0x1881FE8D0")]
		public readonly CircuitsRigidTransform BLXKDGDGYYF()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly XOJOHOBKPDS _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1662AD0", Offset = "0x1661ED0", VA = "0x181662AD0")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, XOJOHOBKPDS innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81FF460", Offset = "0x81FE860", VA = "0x1881FF460")]
		public RMWBTSSRSGR SKUTZAWWYMS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81FF240", Offset = "0x81FE640", VA = "0x1881FF240")]
		public static Result<ODIIBODJPET, TryCloneTemplateError> New(HTWFPONLVPG<None> innerError)
		{
			return default(Result<ODIIBODJPET, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81FF3B0", Offset = "0x81FE7B0", VA = "0x1881FF3B0")]
		public static Result<ODIIBODJPET, TryCloneTemplateError> New(RMWBTSSRSGR innerError)
		{
			return default(Result<ODIIBODJPET, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81FF2F0", Offset = "0x81FE6F0", VA = "0x1881FF2F0")]
		public static Result<ODIIBODJPET, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<ODIIBODJPET, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ODWTRYYIVIY : IDisposable, FPHGYRGZIWF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private NativeList<CurvePointData> APESGTSPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private float POZDEDMICQT;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags DTVUNCVEUXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FPPOBFGIHQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x81F33D0", Offset = "0x81F27D0", VA = "0x1881F33D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool QKYTDLDTOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x81F31D0", Offset = "0x81F25D0", VA = "0x1881F31D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> CENTCBBGQZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int OGBNELLKOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x81F5210", Offset = "0x81F4610", VA = "0x1881F5210", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float COGQILKTLHS
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x81F3A60", Offset = "0x81F2E60", VA = "0x1881F3A60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81F5300", Offset = "0x81F4700", VA = "0x1881F5300")]
		public ODWTRYYIVIY(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81F3170", Offset = "0x81F2570", VA = "0x1881F3170", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81F3590", Offset = "0x81F2990", VA = "0x1881F3590")]
		public Vector3 JIOCAKLXSNL(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81F50E0", Offset = "0x81F44E0", VA = "0x1881F50E0", Slot = "6")]
		public Quaternion YMOCWVXOEZA(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81F3330", Offset = "0x81F2730", VA = "0x1881F3330", Slot = "5")]
		public Vector3 IJVVIPCEFZB(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81F4730", Offset = "0x81F3B30", VA = "0x1881F4730", Slot = "7")]
		public float UTDGDUXJZMO(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81F3BA0", Offset = "0x81F2FA0", VA = "0x1881F3BA0")]
		public void PHRZOAWDIBK(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81F4670", Offset = "0x81F3A70", VA = "0x1881F4670")]
		private bool SZJFSITXESA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81F4480", Offset = "0x81F3880", VA = "0x1881F4480")]
		public void PQHMSZTFFFK(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x81F45E0", Offset = "0x81F39E0", VA = "0x1881F45E0")]
		public void QSHHMLTNCAX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81F31E0", Offset = "0x81F25E0", VA = "0x1881F31E0")]
		public void HQYAUVCLLRY(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81F33E0", Offset = "0x81F27E0", VA = "0x1881F33E0")]
		public void JFWDEAEISHA(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81F4F90", Offset = "0x81F4390", VA = "0x1881F4F90")]
		public void VQFISJEVUMI(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81F3010", Offset = "0x81F2410", VA = "0x1881F3010")]
		public void BJQZLNMZTAD(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81F4790", Offset = "0x81F3B90", VA = "0x1881F4790")]
		public static Quaternion VQEYXRAWSZD(Quaternion a, int b, float c, FPHGYRGZIWF d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x81F2960", Offset = "0x81F1D60", VA = "0x1881F2960")]
		public Bounds AJKBNSMHTVV(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x81F46D0", Offset = "0x81F3AD0", VA = "0x1881F46D0", Slot = "10")]
		public virtual void TBMKTYKYZIB(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81F5250", Offset = "0x81F4650", VA = "0x1881F5250")]
		public NativeList<CurvePointData> ZMHSQARCCSP(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x81F0FC0", Offset = "0x81F03C0", VA = "0x1881F0FC0")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A70", Offset = "0x81EFE70", VA = "0x1881F0A70")]
		public Quaternion BLVQSQMMVIU(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x81F0CD0", Offset = "0x81F00D0", VA = "0x1881F0CD0")]
		public CurvePoint UBECRYBPCGY(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B30", Offset = "0x81EFF30", VA = "0x1881F0B30")]
		public EZCRAAESHDJ FRIDLIFXQOW(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class PBGZADXBBJL : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x81F5C40", Offset = "0x81F5040", VA = "0x1881F5C40", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x81F5380", Offset = "0x81F4780", VA = "0x1881F5380")]
		private void LUKOTGEOZQE(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x81F5BE0", Offset = "0x81F4FE0", VA = "0x1881F5BE0")]
		private void LUKOTGEOZQE(Dictionary<Guid, Guid> a, OVCRFKQDOYT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x81F5960", Offset = "0x81F4D60", VA = "0x1881F5960")]
		private void LUKOTGEOZQE(Dictionary<Guid, Guid> a, BZDUIKCAJRK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PBGZADXBBJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class NCODFMFUMJK : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81F28B0", Offset = "0x81F1CB0", VA = "0x1881F28B0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NCODFMFUMJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class UWAZULRKLYJ : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81FF6C0", Offset = "0x81FEAC0", VA = "0x1881FF6C0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UWAZULRKLYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class HJEGDQDPKDD : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81F18A0", Offset = "0x81F0CA0", VA = "0x1881F18A0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public HJEGDQDPKDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class KYJETTRTYFN : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81F21A0", Offset = "0x81F15A0", VA = "0x1881F21A0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KYJETTRTYFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class DIMDWDABWXK : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x81F1040", Offset = "0x81F0440", VA = "0x1881F1040", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DIMDWDABWXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GIMMWEGJTOY : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81F1710", Offset = "0x81F0B10", VA = "0x1881F1710", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GIMMWEGJTOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FGENSADETVJ : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81F1280", Offset = "0x81F0680", VA = "0x1881F1280", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public FGENSADETVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class LQOCKBGPGVD : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81F2570", Offset = "0x81F1970", VA = "0x1881F2570", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LQOCKBGPGVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class LAITZQGJICN : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81F23C0", Offset = "0x81F17C0", VA = "0x1881F23C0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LAITZQGJICN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class DLQTNFHMQWT : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81F1180", Offset = "0x81F0580", VA = "0x1881F1180", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DLQTNFHMQWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class WDZEIMYPPJE : JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public static readonly TNTAENRKYJK GYBJEWEOQQZ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82009E0", Offset = "0x81FFDE0", VA = "0x1882009E0", Slot = "4")]
		public void VWCLTTZJQWD(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WDZEIMYPPJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public RUPGDKOYKXF photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface JQZINMIVDMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VWCLTTZJQWD(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ZOIVRLEXXIX
	{
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly JQZINMIVDMG[] OZTKUROXFBL;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8201400", Offset = "0x8200800", VA = "0x188201400")]
		public static void OSAXQGFMSTO(BMALMPEIUXS a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8201680", Offset = "0x8200A80", VA = "0x188201680")]
		public static void OXXICKWNUZU(BMALMPEIUXS? data, ODIIBODJPET a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8201910", Offset = "0x8200D10", VA = "0x188201910")]
		public static void YQNYBRKIJDO(BMALMPEIUXS? data, ODIIBODJPET a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8201030", Offset = "0x8200430", VA = "0x188201030")]
		public static void KFPRYICFAXJ(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public BMALMPEIUXS viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81F5CC0", Offset = "0x81F50C0", VA = "0x1881F5CC0")]
		public Guid ROIZDZEAJJT(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface RUPGDKOYKXF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly HashSet<Guid> QAFHLCCBPZQ;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly HashSet<Guid> HZDZOODXWCA;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private static readonly HashSet<Guid> LSPTHHTELUW;

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private static readonly ProfilerMarker CKGURWCSHNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private readonly HashSet<string> QCVVFNTHVUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private readonly Dictionary<long, int> RMFPTEMVFFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private readonly HashSet<Guid> NVDQYPSSTTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private readonly HashSet<Guid> NQOBFBURZPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private readonly HashSet<Guid> IDJVMDEOSPK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> LMLUHHADOVX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> CAAAQZIJKUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> QRICMWICJDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> JLRCWHRSXHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81F9010", Offset = "0x81F8410", VA = "0x1881F9010")]
		public static void PMHTOCZXQIA(SpawnableTemplateData a, YQJNLLJILSE b, ODIIBODJPET c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x81F80B0", Offset = "0x81F74B0", VA = "0x1881F80B0")]
		public static PersistedRoomDataReferences MEFKWPKGYJS(PersistedRoomData a, YQJNLLJILSE? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81FA270", Offset = "0x81F9670", VA = "0x1881FA270")]
		public static PersistedRoomDataReferences XVDNSZLRKFN(SpawnableTemplateData a, YQJNLLJILSE? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81F7FF0", Offset = "0x81F73F0", VA = "0x1881F7FF0")]
		public static PersistedRoomDataReferences IXCJKMEJYZN(ZOWXJLETAIT a, YTUFITMDXDD b, YQJNLLJILSE? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x81F7650", Offset = "0x81F6A50", VA = "0x1881F7650")]
		public static PersistedRoomDataReferences BHDGIRPKKNG(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81FA860", Offset = "0x81F9C60", VA = "0x1881FA860")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x81FA690", Offset = "0x81F9A90", VA = "0x1881FA690")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x81F73B0", Offset = "0x81F67B0", VA = "0x1881F73B0")]
		private void ATAIIVFRHUN(PersistedRoomData a, YQJNLLJILSE? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x81F70A0", Offset = "0x81F64A0", VA = "0x1881F70A0")]
		private void ATAIIVFRHUN(SpawnableTemplateData a, YQJNLLJILSE? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x81F7850", Offset = "0x81F6C50", VA = "0x1881F7850")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x81F62C0", Offset = "0x81F56C0", VA = "0x1881F62C0")]
		private void ATAIIVFRHUN(ZOWXJLETAIT? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x81F7330", Offset = "0x81F6730", VA = "0x1881F7330")]
		private void ATAIIVFRHUN(YTUFITMDXDD? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x81F5D60", Offset = "0x81F5160", VA = "0x1881F5D60")]
		private void ATAIIVFRHUN(TCMOHRRZICV? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x81F7DF0", Offset = "0x81F71F0", VA = "0x1881F7DF0")]
		private static bool FALRRAPPPJY(TCMOHRRZICV a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x81F9CA0", Offset = "0x81F90A0", VA = "0x1881F9CA0")]
		private static bool PZSKUGVGFEO(TCMOHRRZICV a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x81F8B00", Offset = "0x81F7F00", VA = "0x1881F8B00")]
		private static void PMHTOCZXQIA(YTUFITMDXDD? root, YQJNLLJILSE a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81F9A10", Offset = "0x81F8E10", VA = "0x1881F9A10")]
		private static void PMHTOCZXQIA(TCMOHRRZICV? customProperties, YQJNLLJILSE a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x81F8780", Offset = "0x81F7B80", VA = "0x1881F8780")]
		private static void PMHTOCZXQIA(ZOWXJLETAIT? root, YQJNLLJILSE a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x81F8130", Offset = "0x81F7530", VA = "0x1881F8130")]
		private static void PMHTOCZXQIA(CircuitsV2.Protobuf.CircuitNodeData? node, YQJNLLJILSE a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x81F5F40", Offset = "0x81F5340", VA = "0x1881F5F40")]
		private void ATAIIVFRHUN(CircuitsV2.Protobuf.CircuitNodeData? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x81F9EE0", Offset = "0x81F92E0", VA = "0x1881F9EE0")]
		private void SZVAMRRNGYR(Guid? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x81F6CA0", Offset = "0x81F60A0", VA = "0x1881F6CA0")]
		private void ATAIIVFRHUN(BMALMPEIUXS? a, YQJNLLJILSE? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x81F8BD0", Offset = "0x81F7FD0", VA = "0x1881F8BD0")]
		private static void PMHTOCZXQIA(BMALMPEIUXS? viewData, YQJNLLJILSE a, ODIIBODJPET b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x81FA2F0", Offset = "0x81F96F0", VA = "0x1881FA2F0")]
		private void YVWEVIMRWQM(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x81FA150", Offset = "0x81F9550", VA = "0x1881FA150")]
		private void TXMIFFSTNAU(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x81FA220", Offset = "0x81F9620", VA = "0x1881FA220")]
		private void TXMIFFSTNAU(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x81FA0F0", Offset = "0x81F94F0", VA = "0x1881FA0F0")]
		private void TXMIFFSTNAU(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class FTEVEHLLOXF : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private readonly IEnumerator<DictionaryEntry> TKWTJQYYCTC;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x81F14F0", Offset = "0x81F08F0", VA = "0x1881F14F0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x81F15B0", Offset = "0x81F09B0", VA = "0x1881F15B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x81F1660", Offset = "0x81F0A60", VA = "0x1881F1660", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x81F1410", Offset = "0x81F0810", VA = "0x1881F1410", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
			public FTEVEHLLOXF(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x81F1370", Offset = "0x81F0770", VA = "0x1881F1370", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x81F13C0", Offset = "0x81F07C0", VA = "0x1881F13C0", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			[CompilerGenerated]
			private sealed class LVDRKINIGER : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058C")]
				private DictionaryEntry JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058D")]
				public RoomObjectCounts MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry JGSNEMAFPOJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x81F2860", Offset = "0x81F1C60", VA = "0x1881F2860", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
				[DebuggerHidden]
				public LVDRKINIGER(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x81F2760", Offset = "0x81F1B60", VA = "0x1881F2760", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x81F2720", Offset = "0x81F1B20", VA = "0x1881F2720", Slot = "8")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection MGBQVSEHVHT
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x81FE2A0", Offset = "0x81FD6A0", VA = "0x1881FE2A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x81FE550", Offset = "0x81FD950", VA = "0x1881FE550", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x81FE630", Offset = "0x81FDA30", VA = "0x1881FE630", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool GWCAGWGIOPC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x81FE710", Offset = "0x81FDB10", VA = "0x1881FE710", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool NDPEKZYYGFF
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x81FE1B0", Offset = "0x81FD5B0", VA = "0x1881FE1B0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection UEXQRCKDXNN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x81FE500", Offset = "0x81FD900", VA = "0x1881FE500", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int KSROHJTKZNS
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x81FE160", Offset = "0x81FD560", VA = "0x1881FE160", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool GHTEMZOOBVJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x81FE070", Offset = "0x81FD470", VA = "0x1881FE070", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object ZNOJWJRYKJY
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x81FE3E0", Offset = "0x81FD7E0", VA = "0x1881FE3E0", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x81FE370", Offset = "0x81FD770", VA = "0x1881FE370")]
			[IteratorStateMachine(typeof(LVDRKINIGER))]
			private IEnumerator<DictionaryEntry> MQQIZEIOFLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x81FE0C0", Offset = "0x81FD4C0", VA = "0x1881FE0C0", Slot = "19")]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x81FE430", Offset = "0x81FD830", VA = "0x1881FE430", Slot = "13")]
			private IDictionaryEnumerator RIXJQQMWVTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x81FE6C0", Offset = "0x81FDAC0", VA = "0x1881FE6C0", Slot = "9")]
			private void XEPRJRVUKNC(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x81FE200", Offset = "0x81FD600", VA = "0x1881FE200", Slot = "10")]
			private void DYTFXVGBMZI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x81FE320", Offset = "0x81FD720", VA = "0x1881FE320", Slot = "8")]
			private bool KQIUBNPFOFO(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x81FE250", Offset = "0x81FD650", VA = "0x1881FE250", Slot = "14")]
			private void FXNKHPRVZMR(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x81FE670", Offset = "0x81FDA70", VA = "0x1881FE670", Slot = "15")]
			private void WZMWWXFEVXX(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class YNISJXKMUVB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000591")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000592")]
				private DictionaryEntry JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000593")]
				public Invention MXVWDMPVVWS;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry JGSNEMAFPOJ
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x8200C60", Offset = "0x8200060", VA = "0x188200C60", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
				[DebuggerHidden]
				public YNISJXKMUVB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8200B40", Offset = "0x81FFF40", VA = "0x188200B40", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8200B00", Offset = "0x81FFF00", VA = "0x188200B00", Slot = "8")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection MGBQVSEHVHT
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x81F1C20", Offset = "0x81F1020", VA = "0x1881F1C20", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x81F1E90", Offset = "0x81F1290", VA = "0x1881F1E90", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x81F1FA0", Offset = "0x81F13A0", VA = "0x1881F1FA0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool GWCAGWGIOPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x81F2080", Offset = "0x81F1480", VA = "0x1881F2080", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool NDPEKZYYGFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x81F1B30", Offset = "0x81F0F30", VA = "0x1881F1B30", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection UEXQRCKDXNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x81F1E40", Offset = "0x81F1240", VA = "0x1881F1E40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int KSROHJTKZNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x81F1AE0", Offset = "0x81F0EE0", VA = "0x1881F1AE0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool GHTEMZOOBVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x81F1A00", Offset = "0x81F0E00", VA = "0x1881F1A00", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object ZNOJWJRYKJY
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x81F1D20", Offset = "0x81F1120", VA = "0x1881F1D20", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x285F9D0", Offset = "0x285EDD0", VA = "0x18285F9D0")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x81F1CC0", Offset = "0x81F10C0", VA = "0x1881F1CC0")]
			[IteratorStateMachine(typeof(YNISJXKMUVB))]
			private IEnumerator<DictionaryEntry> MQQIZEIOFLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x81F1A50", Offset = "0x81F0E50", VA = "0x1881F1A50", Slot = "19")]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x81F1D70", Offset = "0x81F1170", VA = "0x1881F1D70", Slot = "13")]
			private IDictionaryEnumerator RIXJQQMWVTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x81F2030", Offset = "0x81F1430", VA = "0x1881F2030", Slot = "9")]
			private void XEPRJRVUKNC(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x81F1B80", Offset = "0x81F0F80", VA = "0x1881F1B80", Slot = "10")]
			private void DYTFXVGBMZI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x81F1C70", Offset = "0x81F1070", VA = "0x1881F1C70", Slot = "8")]
			private bool KQIUBNPFOFO(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x81F1BD0", Offset = "0x81F0FD0", VA = "0x1881F1BD0", Slot = "14")]
			private void FXNKHPRVZMR(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x81F1FE0", Offset = "0x81F13E0", VA = "0x1881F1FE0", Slot = "15")]
			private void WZMWWXFEVXX(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x81FFEB0", Offset = "0x81FF2B0", VA = "0x1881FFEB0")]
		public static UgcRoomSaveStatsDetailed MEFKWPKGYJS(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8200860", Offset = "0x81FFC60", VA = "0x188200860")]
		[CompilerGenerated]
		internal static int QNZFSPBDQKO([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x81FF820", Offset = "0x81FEC20", VA = "0x1881FF820")]
		[CompilerGenerated]
		internal static void AFPKVRARIUK(int a, [In] ZOWXJLETAIT graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		ParticleVfx,
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		ConsumableItem
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class YQJNLLJILSE
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public readonly Guid KRLMJUGQZWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public readonly IReadOnlyList<Guid> CAAAQZIJKUQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public readonly UnitySubAssetKind LAFGGLSRZTW;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8200980", Offset = "0x81FFD80", VA = "0x188200980")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private readonly ODIIBODJPET MHHTQFCNSHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private readonly Dictionary<Guid, UnitySubAsset> XRAFZGVEDWD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ODIIBODJPET UZTIZBYSYOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8200CB0", Offset = "0x82000B0", VA = "0x188200CB0")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8200EB0", Offset = "0x82002B0", VA = "0x188200EB0")]
		public bool UUHULKNHONL(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8200FA0", Offset = "0x82003A0", VA = "0x188200FA0")]
		public YQJNLLJILSE()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
