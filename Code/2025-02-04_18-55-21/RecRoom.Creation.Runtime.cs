using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7208410", Offset = "0x7207210", VA = "0x187208410")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HEEAAEKFJJB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> OIPJKEFIMAC;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> ABKMDIODKBG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> NINEMMHEDBL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> AAKJEPLEJPG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string LFMLFPPNJLD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CJFFCPPGIEH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string FMFFDHPIMHF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71F8C30", Offset = "0x71F7A30", VA = "0x1871F8C30")]
	public static bool IMNHCLGEODK(Guid GMEFGNPCNCC, int NIDAMOPCBKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71F8BA0", Offset = "0x71F79A0", VA = "0x1871F8BA0")]
	public static bool HKDEJODFJHH(Guid GMEFGNPCNCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71F84D0", Offset = "0x71F72D0", VA = "0x1871F84D0")]
	public static string DBMKANCMEHE(Guid OGOMDMBFOMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LKHJBNCKCPE]
public enum PIJLJGFFIPA
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
	COSTUME_DUMMY_OM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71FA860", Offset = "0x71F9660", VA = "0x1871FA860", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DICHOEAHEJN
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid CKHPCJGLFEN;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid EFLOFEJMNCB;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid HDIPAAJDNAI;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid NBEHLKHPEIM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid FIJEOKOGAAB;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid EMLMNEBHNKL;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid OKLGHHALOFO;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid MOJLGDAIDMH;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid KOMDDFMIBMN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid JPEKDAKIMNB;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid LNDBFJOBFHH;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid DHBOPEKGNPO;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid LBJCHKDMOIB;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid HNCHOMJHMEP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid MLHOBKONCIM;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MCFMMGPAAPA;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid CDCIDOGBBEB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid PBDCLOLCIOJ;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid FDBLOCOGKOI;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid NDJIMGEIFCN;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid PKOBFGDHHFH;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid AGHEODFOLBI;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid KBINKOILIMA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid NEHDAAAMJNL;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid JFJLPCNFILO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid KPBLOCIKNOH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid EPPCHDBEHKF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid OCIKJPMHNJH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GIBPKCNBFDH;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid NFEFHKEFOLG;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MLABPHOBGKM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid CNFNIAPLCLO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid ECFBJPJDMJI;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LDNEGBIAHCL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid GABDDJJGLLD;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HOBDKCNKGJN;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OCAKEBFHHON;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PNJFEKENMOL;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid BAOFBINDNKJ;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid NBEKDPCJOAC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid JJMHEKALBHA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JFLEABNJOIE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CLBNOJOFPOC;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid FHBLDCDNHED;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HEBGFIFAADD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid AKFJDNECENP;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GDPFGDFKHEM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GEMCMAKBAFN;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NGCMNIHNDGA;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid HPDCJCABBNO;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid NAMJLFAGMIG;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid MCFGGPDKHJB;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FNCNNEAFHLO;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LEMIANALNBI;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid ALHFCFMJGFL;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LOLFBHJECHO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid NIHBKILGKIE;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid MBJKOFBAGCF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LDANEPOIMHF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KNPKHFNAKCJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid KAONAJELGOB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid AEGLJIGCJFN;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ILHBCBBKLIN;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid CINJIMDGMPE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid GCPPEONEACB;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid KKKOGMMPAOK;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid AOINKBPJFKD;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EPJJMLGGGHB;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid AMHJFKEHDHG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LMJMBMJJBCO;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid DBJHOANIAIK;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid BNKJHMDDBID;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid GKKKNFMFOJC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid FFJCGPPHJMB;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KOEGJPKLBAP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PFBFINEIKOC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid BKBIKFHIELL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PPHKDBDMPEF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid EJFNIDHPLFO;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid EAEAMGFGFDL;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GHEHOKDPDPD;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BNBAMHEJDOD;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid HFJOEOOGMGO;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GGNKNEHDODA;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MFCJMIKOIMN;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NHHICMPDEKG;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid MNPEPDFCHPA;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid AIAKEDNPDGI;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LLADDHOFFDA;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AHHFPBNCPKK;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid BAJJOPBCKGG;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MBCIDENDBMO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid IHJLGKCOAKA;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid GKPMDDELKII;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid NFMMDFDKNND;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid OGIAHCFPCMD;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NMBNEMDFBJA;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid EIPIGGCPHAD;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid HKGHHIJHLNC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid FJGONJIICLG;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid BCBGNFOMNIO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid OPMBAFIFNGB;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KFPMKJIKCOP;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GDAKAFCABJO;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GLEKENKBBPD;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid DMFECPBGFPF;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid JBNHOGKCINH;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PPOHMEPJEFD;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid MDKIEIBIGLG;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid ABHIFFEKBFI;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OKFCIANCNAP;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid FIOJGEEPAEE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid ONHMIPEOCDI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid KACCAOFLMHH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid EADGDPBOCGD;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OKCIJDCIFKF;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid PCAOPBEEBOF;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid PHIANGMCNPK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OFIFJLLMFKG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid DOIFIAEEHAO;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid BAGMCPNOPLK;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid FJBKACENMCK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid FELOBGEGFBD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid LGFEJEBNMFM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DGPLKLHMNEC;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JFMHABEBKIL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid OOJBJGGHCJH;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid KKJLFENNBBH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FNNCHJGAKHE;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid JKCFNGIHICJ;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid BMFNAGFGPBB;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HHIMNCBHIIL;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid FKCLOGNABOB;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PIFCMDOOBFL;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid CJHPADKOAAN;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid BKIKHLMKLIN;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CECOHIIBAFH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IKDMAFMBNLA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid OEHLBEKMAHD;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JPDHCELGHHD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid GPGENELCAOE;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid AKCNAIMIHLN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NHBFLJHKEPD;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid NHHEOCGEMPJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid OHMEGOMLLJB;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid OJPLCPEPBAJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ABBFOANOFOE;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid CENFCHFBBII;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid MCPNEBBDCEA;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid HDMIFFEMAKF;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid AMBNKHDNNJF;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid HKLBGDKPMLB;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PAOLKNNFEJO;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid HPJIFOPOKMG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KFBKFJGDBCF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BNIFDEPPMFG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid CFJPJAFKKCN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HGPJDMJIDMM;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid DCPFFOPGNDP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CEOPMNBKHDK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid ICNOHNKKLNG;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid CJGCJFOAIHD;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid ODDOKAFCGPI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OLGCOMIMLJI;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FGLKDMHNBPD;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid BMDOJEKFEOK;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid KDAEEMEFBIF;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GPIGJOGHGCP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid BCAOMEPGLMA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid GMMLMHDEFKC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MDGADDNOHMM;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid HMNDLCJMIPE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid KPHJJEOOEFC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid COFEDLAKKCJ;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid GPLHBPFCLJB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid EIIJGKAIJLH;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid DBKMOKFFCCD;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid GKMGDPIKJKJ;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid MDGDEOPCGFF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DNOOKBCPGHN;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BIPABACGPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid CBLCBAIGOLA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LKICABDEMDO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MKHGEMHIAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BMAPCAPJHLE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FLDOJAABCHA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid GMPEGIKCCNP;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HBHIGOHEILD;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid BODOMCJLKJE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid BCFCEHCPIGM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MEFMDGEOGLB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LIPOCMNHAFB;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid BOCMPEANCEI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LLMNMFBAKNL;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IJKIHLJHDFF;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BGBCMGLJNKP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid LFDNCEDNECD;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid GMPJDEEMPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid OCBJLABJFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid LKODBPDNCMG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HGPPEMHJANF;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid KEJHMNEOKMD;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid EIAAADCCGNC;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DAMFIJKNFPN;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CPIFLCBLMPJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid JODMKCNDGPF;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid BDOMHADLHLN;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid IAOGFJEKJHO;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LLOEMEFFGIF;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid GDJBIAOIPHF;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid ODPIMMDENFO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid ECLPPDAILLJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid COJPLJIAOID;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid LIBBCDNOOOM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GBFEPIJJIDP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MJLNHCNHEOF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BAHLDKMCDJC;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BOCCHJNAHCK;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid KODBLHNDEBP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid MKHCMBKLGOD;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JDFKMEHICOA;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid FNKDDKCJBHE;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid PJEJMIMIHDN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DAEPAPMGBBI;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid ODGBKMFGGEM;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PAFDIACAHAJ;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid APMEIBLJKNN;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid JOLPGEEEDNM;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid ADCMOHAIFNC;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JFLCNADHFKP;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid CKCGFHLFIIP;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid BODPOGLALCK;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid PMHGMKMLHEK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid EOBADPFJGAA;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid LDLNEFHIAMA;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid OEAMGICBBFK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid CENNFOIAGBN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid GCILMBCIJEG;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid HEJDJFGGMGF;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HLFJLMDJGEM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KIEEEOAAEOG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid KFOIGMJBPPC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KMCHCMOFKMM;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FMFIBHAOHBG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JANJPNBPBDI;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NKKMPFNEBMC;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FPJNBGHPGDB;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid KLMGNHIAPCC;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GABANOMOFGD;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CAHAGBPKFNK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid JIPMGJMMIBP;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid OICHOOPCLFB;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FABDIIGKBBE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BJLBPGLABHG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid AOIAGAELKOJ;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KANLEBOHFJF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HMAMAHCEPLO;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BCFKJNFJILK;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid HJEDKNEBLCF;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ENEKFLMFFKG;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid JPKADFGCFBA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid MEFLJCHPPKM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid ODGMMLKBLLI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JEHAOOBNKMD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid AMMAONMBIKK;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IMMOFIHENAA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid GDAENGACPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid GPCKDAJJHHC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid EAEJHCJEBCJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid JGOGDBDANLI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid NINPIDPNIBH;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid JAEHFDHMPBE;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BAKBIJPOFPA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid OALLHCJHDHN;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid PNAGKEMNECA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FMJELKHFBJB;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid PKAMFCJBECE;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid EGBKNNONMFC;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid ABFONGPMFMO;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid NEAKLODLKOA;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FJJBNEEBIEB;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid OLCALFOFCAO;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid EFOCFDNLDFO;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MAKKJBBELGJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid IGOBPHJPGPF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid JLBHOMFMCBH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JALHECCHFDE;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid GCDGNKDBECB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid EIEFLPOBCGC;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid FDPMFLHONHK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid LNIBAPHNKNJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BNNIKDBKKAI;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CFMKAKDKMFO;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GPKOPEIAIMF;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid FMCPBPAPPIH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HEEGMLLMJPA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid OPNHGLJFCHD;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid BGIGFEACCNK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BOOKNJIPOOJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JJIBCMGGCFE;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid DINBCNCBHDH;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid KDGKADJPIGA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid LJLFKDLKKFB;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IKHHEDPEJEM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid IJDKENEJLNP;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid FOGIFOKNJKN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NOKLBPNOLCB;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid MFJHBPKFNDK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid FGDJEBEOAFK;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LHHMKDGHBIL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid DBKDAGLHOHN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid NMJJPIMPFBD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MKHJGHCMAHB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ONANGABHOKA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MIDHMHDELAC;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid DPCCBJICAHF;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid CONPPGBEMOL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid FGKEPFCFOFM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid NLENPKDMDIO;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JKBKJOOOOOH;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FDIBNEGAJEI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid MHNLLCAMJKN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LENEPOAFMOD;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AJGAGFMHLFG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JICINFMMNCB;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid NGHAIOJLHNP;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid LHIGLOINLLJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid GCMEBIFBDPP;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid HFNCFDIMFMO;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid PFBPFOPHOCD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid PJGPOBJEGGG;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid AINNBPLCCEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GKHKPIKBHHF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid BNDAICIBJKE;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NIPNKFMCJKN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KFMLPGPCCKF;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid GECCBLGHIJP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HLHDEIODLFI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NECHIECGADG;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid IJGILOEKADK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid OFNDJJMHDBP;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid BLBGIEIBKLE;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid FPGPAAHAMOA;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ENLPEOBDOJB;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LLFEEKFIDBO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid NHEKGCBEJNG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid MJNAKEJDMEM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid BAJEPBPLMJC;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid PDJODHIDGGE;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DOOGBKLKDKH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NHMAPDEAFIA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid NBEDDCPMBNG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GMMJJDLOIMG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DAJEKFPEOMP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DDFEAKGFKBJ;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid NEANKGGKMPP;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid NDJIIDMPMNA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CEFAFKNACEK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FLHALIIAEAI;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid MCAIKKOOLJO;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid APPOLKPDHLA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JALOFJHCLIK;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid PIEOOFMFIKN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid KMCOBNFGOKE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid EJCIAKKHEPA;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EHPJDGDDBHL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid NOAFOFBGFJA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IAKICIFDCPK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JINAJFFCPIH;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid NBJJAKGNECH;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid COKGLDGNFOE;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid JBMDGLPIDGO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid LDBFJKFBLOM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid LKBKDNAEGDI;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid FGDBBDAFPIB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AFPLKDACPHK;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MFCJLKDAMIM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid PMOIJMOFGBK;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid ECMCLHJHIOC;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid IEAIMGIFHKI;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EEGDGKOEHGA;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid HDDNNEEBGBB;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid NBEPHHAPBBO;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid OILPJJKNMIH;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BDKNLICHBAD;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid ACDAMDLNGHC;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LLIKLEPEACP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid AMBPHBDNPBH;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid HGCEDEIHBGG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid CFAMCFBNHOL;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid IFMLHNJDAID;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GFFCHAOJAIL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid CKJNOJFCPIL;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid ILONPJMIOBN;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid PEHDEAJCJJF;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid BCICBOMFBIJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid FAPPBIKCKOP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid ACCLONONKEL;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid KAJHDMHNLKK;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OFAIBLMPCPP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CMHHKJDJOGM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid FABCPBEPLEL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid IKCIJBFNPHN;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid HKCGDBFJPCG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid GODBBJONCNJ;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid OLJBMBFIAFH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JJPBMKEBIHN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BOHAPNALFHM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid OEBCIJIDGNI;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid MIAECBBNHEP;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid KLLHDLCILMA;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JNLFDDMKPPB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HKHADBFEEEE;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid PJDHDAKFLCC;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid HNAKCBOGJLM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FHEBLBCNJPF;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid HBMDHDOKDPF;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid NPJPKJINGIN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid DNBFKPGIGAC;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid ENJOENMICAN;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JKLFKGIPJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid EDIODFPALPO;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid BMHHLLJLFPO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid AELCKBBNHGC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid DPPPJJBEBOG;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid BIKPIEJHBNA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DOODEKMHLHO;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid DAPAGOIMBBD;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid MHHMMMPIGIF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PJGFHBFAHDL;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid JEOHCFKGMAN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid PGLFPCGHEJA;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid JICJPLEPBPI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid EEOMANAENKL;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JCAGKOOCDFD;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid MFOJIFCBOPD;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GLLJDDJGDGD;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid MABMGJKMKLE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid NGANBFDPICB;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid BNDBHJDBHCA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid ALDBBKEBHKG;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid PGHLIHMLCJG;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid HDJKILDGCJL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid ONIBJPPABOM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid DIJDPFINLBO;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MIMCDODPGGM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid BLMAMHBEKKK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MJOCIDMAKJF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid NDMGDKIPHIF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GBDLKNALLBK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid CFMHELKBMBO;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid LICGCJBLPKO;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid ENIBGDKFLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MHNPAFDIKHP;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid BLGCNNLDEPB;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid JIKGFNPLEBH;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NCENKJGGANC;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid GDMOPFMOGPF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PMOPFLHEPHA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid LIBLCGKEBFL;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid AMGHKELPAAM;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid CFABNANFLDB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid BFNNEPCPKFA;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid EOJJEJKKHNA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid COKDPJBFFKJ;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid MFAKKKJKBNP;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BPDCFOIFCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid EGIMHCDOLFM;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid DMPKBGOPJGL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid HEGNMAMLMGG;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid JBHNPKEJBIN;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid EFGDGLFEEEB;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid CLAKFKBAMCA;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid LBJHFMKGIMI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid EADNLLLLMKP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid NKFCKONIAPE;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid IFAJMCNGGJO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid LPLCIJPBPGF;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid LBIIOEFPEKI;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid NFLBPPKIJKH;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JDCFKELIIME;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OHDEAPMJEJI;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HABMJHKKJMF;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CDPGLDIOBJE;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JPONPHLDIDE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NEOMFDGOHBL;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid HKKNLOCLFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PMIBIKMOPHH;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid JEGOHJIKBMF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid LMMIIKFPKCP;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid DOAHPDKFINB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid MPIGKBGHILP;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid GHCNGMNOJON;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DPDOIHENOOI;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid MFKFJBDNFEL;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GMDGOOOHIDI;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid LJKPCELBPPB;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid OJPKIHOFMEL;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid PINOIFMIPIN;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KMBNLEHKIPE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid KFAHNGJBKLH;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HJAAGDGFPIA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OGGJDKMGODD;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid JIAFIOKDJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OFPKBOLADKA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid JEKALGCIBNL;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid PKPFLDGJGBC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DMOPLHCFIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid IIBDLJGDGKB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid APBGDKJGKCE;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid JBAIOCCOKGD;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid HMBFJEDBMOP;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid HDIPFPCMFLB;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NLPKNDPGHBG;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid DPPPFDPMMLE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid PHICMHEOPHN;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid PALOBHIHPFP;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid ADKFNCMKEPH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid PDBDGJJDHJM;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid GJBILAPFFNO;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid BAPGLOPNKIE;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid KNEOPDNJNMI;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid EFCLAOCAFLI;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid DEOLLHJKILC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OJIEPJMFACH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid BLOOINFEDFB;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid PPPGDGCFIIM;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EEDAHILCIBF;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KBGOIIEILPJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid DFOBHPJAMAJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid LLMPGNCIJEB;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KIIEMOJECHI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CBLKLHPHIMF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid LPIOLLEHKAM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid JBMFEFBEGHO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CHHJCEHEONK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BONOGDENMEG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid ONBNBCOEPLG;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid EFKPMDPGJDA;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LDNMGACHHIA;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid OAIMFNDFKGO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid DLOOJFLFCDI;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MEBIDOFGDBO;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid IHJIEGIMGIP;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JECHJAGCPCE;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid AGCININHJKA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid DJNBBNEAOBM;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid OALGJLLFBEC;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid PIOBNLFFFNK;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid AKOFELOIFCP;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid BLDDHJNMEKK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HKFGOEFPCFD;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid PBNEGMDNAFJ;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid IMEGJKOMNHB;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MOAPHBAFMFH;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid HOAOONCPEAE;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid EDDCKMFFFJC;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid AJNEKINGCIM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid GJIEOHHIFNP;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid MAHJKMAGHAM;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid FKPBFOHOOHE;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid IGJBPDEKHEK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid EBLKNHMBOAI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid FFKOGIIJHFM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid LGNPKALGPFK;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid HDDGJKENHMP;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid FPNEJACOBAJ;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HOIIONKIDAO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid EPLKHMKGKKL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid OGLGHLPKJLF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MFAHIFKOCAI;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid EKKCGGEKDFM;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid CBOILONLHAH;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BNIFFGGFHOE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid BAFBHGKMKBG;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid EMACEKECCPB;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid MNCIFONCLII;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DGBPBPDPEAO;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid EKAAOCHHCKG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid DLEJJGLGMIO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid HPNOMPEJPFN;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid OCBPFLFMEAF;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid BPPPGAAFOAJ;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid DJFPFDKBALJ;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid PGPILJOFCFK;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid DJJINDGPEFF;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JELFMFFKNLL;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid DACJIOJEBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KAFGGDJOJDB;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid KILCMEGJEHH;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid HKJCEDLJMHN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid NOMCDLDNLBK;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid NPEANODPLOI;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid EFFHOKFMBCB;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid AEHALANEEII;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid AMDPHOPKFHN;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid LNLKGOLHELN;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MLGPEPKFJAN;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid DOKMBDCFIIC;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid DDJLHNOMCIF;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LONPGMPEKKO;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid FMDEALNGENE;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid KGMLAMDFIEJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BNCIBNAHKAC;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid OJHIKMOGOBI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid ADOAOGPDLKB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid LMDAIFEPLIE;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IOAKDBLIBDL;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid LHEBCALHMAB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid KBAOABALEHP;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid OBPFAJMFCKH;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid GLFHCLNLPLH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid KEKKICELCLG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NONFFFJLNKO;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid CBMMKKCEKIK;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid NGPPCAGEONK;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid IHMNPJMKEDP;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FJJJIDCHNBB;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LMGLOPIIAMB;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid HPAAMOGDBHM;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid KNDIIMFKNEI;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid IDEDPDBDODG;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid EGKECGIEPOK;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid KPPELKJLIME;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid OMBNLPJCMNE;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid LOBBBIANFNF;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, PIJLJGFFIPA> CLFEJJIGAAN;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<PIJLJGFFIPA, Guid> PCHNPBJINAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PIJLJGFFIPA> FHCGJJJMIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71F41A0", Offset = "0x71F2FA0", VA = "0x1871F41A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PIJLJGFFIPA, Guid> GAJJCHPHDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71F4140", Offset = "0x71F2F40", VA = "0x1871F4140")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NFJDHJDLIAP
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x71FAD30", Offset = "0x71F9B30", VA = "0x1871FAD30")]
	public static bool PCIAJFHMIDC(MLBPMEFMECJ BMOCFGJJMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71FA980", Offset = "0x71F9780", VA = "0x1871FA980")]
	private static bool PCIAJFHMIDC(DHNBFDEFDEB JDNLPMLJDPE, MLBPMEFMECJ BMOCFGJJMMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MONFIEFADNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly EDALADINGLF JOAJKOMGDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<DACMPOAMDBF> EBFMDBIEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<DACMPOAMDBF> LPNLBNNCHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MMBOLDIBAHF<CHMLMGCOLME> OCKJCGOFKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<HFJNFIGGNLC<AHIDBKDCADN>> BFEINJCIPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString KMADDPACOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly MGDGAGBKOEK PJCJPHKAFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool FLMNKINIBBO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71FA8F0", Offset = "0x71F96F0", VA = "0x1871FA8F0")]
	public MONFIEFADNC(EDALADINGLF BLKDJICDONM, IEnumerable<DACMPOAMDBF> PFEGEFINGEH, IReadOnlyList<DACMPOAMDBF> KDOCBODICGG, MMBOLDIBAHF<CHMLMGCOLME> CKLHIMIDKKB, IReadOnlyList<HFJNFIGGNLC<AHIDBKDCADN>> NAIMOBPLEJH, ByteString BJDHFNJFGGB, MGDGAGBKOEK ABLPIFLOMGE, bool BCEJJBLNBAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CHJCHHEFEKE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(ABCBJIADDGP JOAPLPPIFPC, [Out] Dictionary<int, int> EFIIACLBOEF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JNOHDJLMBEA KJDMFKNPNCD, GPNBFBAJELF BOHFNHJBDBP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ENBPOAJJCJF : HMEPNEAJNFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid POJAPAGADML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> FKJLLDLDHHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> PLAFKHPBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x435DB40", Offset = "0x435C940", VA = "0x18435DB40")]
	private ENBPOAJJCJF([In] Guid MHKEIKABEPI, Dictionary<Guid, Guid> JINDLKJMCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71F4790", Offset = "0x71F3590", VA = "0x1871F4790")]
	public static ENBPOAJJCJF MKHEJJEDOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71F4490", Offset = "0x71F3290", VA = "0x1871F4490")]
	public static ENBPOAJJCJF IHBOGGDIGNJ(IReadOnlyDictionary<Guid, Guid> KMGKIJCJEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71F48D0", Offset = "0x71F36D0", VA = "0x1871F48D0")]
	public static ENBPOAJJCJF NIKJKGALHOP(IEnumerable<KeyValuePair<Guid, Guid>> KMGKIJCJEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71F4820", Offset = "0x71F3620", VA = "0x1871F4820")]
	private static Dictionary<Guid, Guid> MONEPODMOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71F4510", Offset = "0x71F3310", VA = "0x1871F4510")]
	public void MKBJLFOLDGF(IReadOnlyDictionary<Guid, Guid> KMGKIJCJEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x71F4BF0", Offset = "0x71F39F0", VA = "0x1871F4BF0")]
	public Guid OJLEKLMNAAB([In] Guid OGOMDMBFOMG, bool PMKKFHFIDGL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71F44A0", Offset = "0x71F32A0", VA = "0x1871F44A0")]
	public bool KKDMNGBLOJI([In] Guid MIFPCBFGGLI, [Out] Guid HEHELEANFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71F44A0", Offset = "0x71F32A0", VA = "0x1871F44A0", Slot = "4")]
	private bool MLGOCHPBIJB(Guid BKEPLGJNEJH, [Out] Guid COJIJIEDOKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCHNDNOBHBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJHDOOBJGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEIAPADJKML(ByteString IGPMBFACFOG, ENBPOAJJCJF PJIJEEGBBDA, [In] UniformTRS DOFFPJBKGJN, Space DAHIADBGFDG = Space.World);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CEJDKMPCLOF
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class NJOLIGBBIHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BMLKMCLIBGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public EDALADINGLF staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BMLKMCLIBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71F18C0", Offset = "0x71F06C0", VA = "0x1871F18C0")]
		internal MMBOLDIBAHF<DGKHNPEDJKJ> LPGHPMAKCGH((MMBOLDIBAHF<CHMLMGCOLME> GraphId, MMBOLDIBAHF<AHIDBKDCADN> NodeId) i)
		{
			return default(MMBOLDIBAHF<DGKHNPEDJKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private static readonly AMNAKHMFIGM<DGKHNPEDJKJ, int?> BOJONDNDFFN;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static readonly long IDKJKBOEGMG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71FAFB0", Offset = "0x71F9DB0", VA = "0x1871FAFB0")]
	public static (long, long) JOGNMNGIEDF(EDALADINGLF DPJIDGKOMEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71FAE80", Offset = "0x71F9C80", VA = "0x1871FAE80")]
	public static long IMNBFPPMGHJ([In] ReadOnlySpan<MMBOLDIBAHF<DGKHNPEDJKJ>> FAEEDOGLNHB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71FAD60", Offset = "0x71F9B60", VA = "0x1871FAD60")]
	private static long ELOLKPBFGKL()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KDNHBFACHDJ
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<PIJLJGFFIPA> HPOCCPBKJHI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KEDNEINEMBH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> LGJLFPHGFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> GPPBAMJCNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public KEDNEINEMBH(IReadOnlyDictionary<Guid, Guid> GENBKGCKONO, IReadOnlyDictionary<Guid, Guid> KFCNGLFFMFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GEHOMNMDOFA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class AJBIDDBDHOH : IEnumerable<DACMPOAMDBF>, IEnumerable, IEnumerator<DACMPOAMDBF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DACMPOAMDBF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private LOOANCLOMIF spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public LOOANCLOMIF <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private JOMIDADDDAA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JOMIDADDDAA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private DACMPOAMDBF System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public AJBIDDBDHOH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71F15C0", Offset = "0x71F03C0", VA = "0x1871F15C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71F1870", Offset = "0x71F0670", VA = "0x1871F1870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71F16D0", Offset = "0x71F04D0", VA = "0x1871F16D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DACMPOAMDBF> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71F16D0", Offset = "0x71F04D0", VA = "0x1871F16D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x71F4D50", Offset = "0x71F3B50", VA = "0x1871F4D50")]
	public static LOOANCLOMIF AHJONBLEFKD([In] MONFIEFADNC KLDIGJPBKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71F5210", Offset = "0x71F4010", VA = "0x1871F5210")]
	private static void BHMIFHNEPPL(LOOANCLOMIF MLKDJHDMLOP, [In] MONFIEFADNC GNGPIMDHKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71F6440", Offset = "0x71F5240", VA = "0x1871F6440")]
	public static PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA> KOBKIOOKHHE(LOOANCLOMIF MLKDJHDMLOP, JOMIDADDDAA HHENPPKBIAO, ENBPOAJJCJF? AOJIJOECKMA)
	{
		return default(PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71F6100", Offset = "0x71F4F00", VA = "0x1871F6100")]
	[IteratorStateMachine(typeof(AJBIDDBDHOH))]
	private static IEnumerable<DACMPOAMDBF> IDKHCIGCEEJ(LOOANCLOMIF MLKDJHDMLOP, JOMIDADDDAA HHENPPKBIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71F6200", Offset = "0x71F5000", VA = "0x1871F6200")]
	private static void IFOJGDIINOH(LOOANCLOMIF MLKDJHDMLOP, ENBPOAJJCJF? AOJIJOECKMA, JOMIDADDDAA HHENPPKBIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71F51A0", Offset = "0x71F3FA0", VA = "0x1871F51A0")]
	private static void BEFHHLJPJKJ(LOOANCLOMIF MLKDJHDMLOP, JOMIDADDDAA HHENPPKBIAO, IReadOnlyCollection<ByteString>? OCFGFLMLFFH, IReadOnlyCollection<ByteString>? GLKHGFFALLO, IReadOnlyCollection<ByteString>? PNEHGMDDBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71F7E40", Offset = "0x71F6C40", VA = "0x1871F7E40")]
	private static bool MCJAMCMECHH(LOOANCLOMIF MLKDJHDMLOP, JNOHDJLMBEA KJDMFKNPNCD, JOMIDADDDAA HHENPPKBIAO, [Out][NotNullWhen(false)] string? LKNDCPLLKMB, [Out] Dictionary<int, int> EFIIACLBOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x71F4EC0", Offset = "0x71F3CC0", VA = "0x1871F4EC0")]
	private static Dictionary<Guid, DHNBFDEFDEB> BDKHFKIIBCJ(LOOANCLOMIF MLKDJHDMLOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71F6060", Offset = "0x71F4E60", VA = "0x1871F6060")]
	private static void GMAAGDFEBFH(bool ACAHLKCOGNJ, DACMPOAMDBF HCOLLOKLDBB, Dictionary<Guid, Guid> CBNAMCECBOM, ENBPOAJJCJF AOJIJOECKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71F5870", Offset = "0x71F4670", VA = "0x1871F5870")]
	private static void FBOGGFHPGBM(DACMPOAMDBF HCOLLOKLDBB, Guid JJJCAJFEAAO, IHOBBJNOKBE? NOFOPLOBPEO, Dictionary<Guid, DHNBFDEFDEB> EDPEONPGOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71F5BB0", Offset = "0x71F49B0", VA = "0x1871F5BB0")]
	private static void FNLCNJAPHKI(IEnumerable<DACMPOAMDBF> HIHCHKJAABN, IReadOnlyCollection<ByteString> OCFGFLMLFFH, IReadOnlyCollection<ByteString> GLKHGFFALLO, IReadOnlyCollection<ByteString> PNEHGMDDBKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JOMIDADDDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public bool ACAHLKCOGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public MGDGAGBKOEK ABLPIFLOMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public IHOBBJNOKBE? NOFOPLOBPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public IHOBBJNOKBE? MJBJPBALKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public EDALADINGLF KNBFNDMIIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public CEJDKMPCLOF LELAABFHLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public CHJCHHEFEKE MBAALHACDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public NCHNDNOBHBN AHGOLLKOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public HFJNFIGGNLC<CHMLMGCOLME> DFJIAKNCDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public KDIJDIKDJEK IEEKLBLLHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public List<DACMPOAMDBF> BPKENNJLNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<string, object> KNLAFFCHNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public EIBKOIBBMIN ELMIINMAFOD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MENGAJBEAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71FA600", Offset = "0x71F9400", VA = "0x1871FA600")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IHOBBJNOKBE
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private const float KHJLABPABBO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Vector3 AKEODPFBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Quaternion CKABIAOPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public float KFHMJCONBDC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Matrix4x4 OMHDAFPGCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71FA390", Offset = "0x71F9190", VA = "0x1871FA390")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public UniformTRS CGIHPJEHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71F9DC0", Offset = "0x71F8BC0", VA = "0x1871F9DC0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x11C0700", Offset = "0x11BF500", VA = "0x1811C0700")]
	public IHOBBJNOKBE(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float KFHMJCONBDC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71FA530", Offset = "0x71F9330", VA = "0x1871FA530")]
	public IHOBBJNOKBE(UniformTRS JNCLBHGJIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x71F9E90", Offset = "0x71F8C90", VA = "0x1871F9E90")]
	public static IHOBBJNOKBE INHMBKLAHAJ(IHOBBJNOKBE IFAMCPHMKIP, IHOBBJNOKBE CBPGFMOJBNH)
	{
		return default(IHOBBJNOKBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71FA370", Offset = "0x71F9170", VA = "0x1871FA370")]
	public static IHOBBJNOKBE JCHCBNMNCNP((Vector3, Quaternion, float) JOAPLPPIFPC)
	{
		return default(IHOBBJNOKBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x71FA1F0", Offset = "0x71F8FF0", VA = "0x1871FA1F0")]
	public static IHOBBJNOKBE JCHCBNMNCNP(Matrix4x4 DKLKCMCBELP)
	{
		return default(IHOBBJNOKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71FA4A0", Offset = "0x71F92A0", VA = "0x1871FA4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71FA110", Offset = "0x71F8F10", VA = "0x1871FA110")]
	public IHOBBJNOKBE JBLPCJCDCDK(Matrix4x4 KAEMFHJNGPI)
	{
		return default(IHOBBJNOKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71F9D50", Offset = "0x71F8B50", VA = "0x1871F9D50")]
	public static IHOBBJNOKBE CIINPIKLJLM(Vector3 AKEODPFBHJE)
	{
		return default(IHOBBJNOKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71F9E00", Offset = "0x71F8C00", VA = "0x1871F9E00")]
	public readonly JGEIPOFGAHI GLKOCIBFEMO()
	{
		return default(JGEIPOFGAHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum LOAEFOPCGPO
{
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EKIKCKNCHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly MAILBGBNKCL MNBCHBNGHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly EOABGNINGBC IEMIHJKAGAH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x14426C0", Offset = "0x14414C0", VA = "0x1814426C0")]
	private EKIKCKNCHOA(MAILBGBNKCL NCGEJMOHJLG, EOABGNINGBC HMLLHKFCHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x71F4200", Offset = "0x71F3000", VA = "0x1871F4200")]
	public FDIBCACJGHL HLACIIALHMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x71F4270", Offset = "0x71F3070", VA = "0x1871F4270")]
	public static PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA> MKHEJJEDOII(ENHENMDMEBO<ENLEGHEGALI> HMLLHKFCHPO)
	{
		return default(PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71F4320", Offset = "0x71F3120", VA = "0x1871F4320")]
	public static PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA> MKHEJJEDOII(FDIBCACJGHL HMLLHKFCHPO)
	{
		return default(PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x71F43D0", Offset = "0x71F31D0", VA = "0x1871F43D0")]
	public static PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA> MKHEJJEDOII(string LHPKENDHBBA)
	{
		return default(PGOLMGNGGBM<KEDNEINEMBH, EKIKCKNCHOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MAILBGBNKCL
{
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CEFBLELADDP : IDisposable, PGOLGEJEGCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private NativeList<HNPJEHHNIMF> NNAHHJHOKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private float BFLIKMELPBO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GEJEIADHCHJ LPEAAOGDLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0")]
		[CompilerGenerated]
		get
		{
			return default(GEJEIADHCHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool CEEDOKLGEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71F2DC0", Offset = "0x71F1BC0", VA = "0x1871F2DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool CBPCKLIAJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71F2F40", Offset = "0x71F1D40", VA = "0x1871F2F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public List<OPNIOHFMNLN> OOPKJLHJFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CKIFJGLDFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71F2EA0", Offset = "0x71F1CA0", VA = "0x1871F2EA0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PEJHEGNDPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71F2950", Offset = "0x71F1750", VA = "0x1871F2950")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71F40B0", Offset = "0x71F2EB0", VA = "0x1871F40B0")]
	public CEFBLELADDP(GEJEIADHCHJ HNALEDONGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71F2A90", Offset = "0x71F1890", VA = "0x1871F2A90", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x71F30B0", Offset = "0x71F1EB0", VA = "0x1871F30B0")]
	public Vector3 NNAHFANKCBD(int NBNGIGCCLIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71F2DD0", Offset = "0x71F1BD0", VA = "0x1871F2DD0", Slot = "6")]
	public Quaternion LPDPKNEFEKF(int NBNGIGCCLIC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x71F2D20", Offset = "0x71F1B20", VA = "0x1871F2D20", Slot = "5")]
	public Vector3 LNKEMEINJKF(int NBNGIGCCLIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71F2AF0", Offset = "0x71F18F0", VA = "0x1871F2AF0", Slot = "7")]
	public float FODBJAHEPEE(int NBNGIGCCLIC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71F37C0", Offset = "0x71F25C0", VA = "0x1871F37C0")]
	public void OPGNGBOPCFA(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG, bool GGBMJDIJOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71F2EE0", Offset = "0x71F1CE0", VA = "0x1871F2EE0")]
	private bool NBFONBNBGBO(int PIIGEOOOOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71F2F50", Offset = "0x71F1D50", VA = "0x1871F2F50")]
	public void NDBAOLJANIE(Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71F3580", Offset = "0x71F2380", VA = "0x1871F3580")]
	public void OKHMPHDIMFM(int PIIGEOOOOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71F1FF0", Offset = "0x71F0DF0", VA = "0x1871F1FF0")]
	public void BGAIMBLKMEE(int PIIGEOOOOON, Vector3 AKEODPFBHJE, Quaternion CKABIAOPKPM, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71F3610", Offset = "0x71F2410", VA = "0x1871F3610")]
	public void ONMDBJOMLHM(int PIIGEOOOOON, float3 AKEODPFBHJE, quaternion CKABIAOPKPM, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71F1EA0", Offset = "0x71F0CA0", VA = "0x1871F1EA0")]
	public void AGNHNBOMNLH(int PIIGEOOOOON, Vector3 AKEODPFBHJE, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71F2BC0", Offset = "0x71F19C0", VA = "0x1871F2BC0")]
	public void GHFLPLDKCDD(int PIIGEOOOOON, Vector3 FOPIBLDPFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71F2140", Offset = "0x71F0F40", VA = "0x1871F2140")]
	public static Quaternion BHBOILPJJBO(Quaternion DIGMAMODBCJ, int PIIGEOOOOON, float LPACOEGKCPI, PGOLGEJEGCP JFOKBDEFMBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71F1930", Offset = "0x71F0730", VA = "0x1871F1930")]
	public Bounds ADOGODLKEOB(Transform KAEMFHJNGPI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71F2B50", Offset = "0x71F1950", VA = "0x1871F2B50", Slot = "10")]
	public virtual void GEOLGKNPBDE(bool EPLEMAEODLF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71F1DD0", Offset = "0x71F0BD0", VA = "0x1871F1DD0")]
	public NativeList<HNPJEHHNIMF> AEAGLHCKECH(float MLCCMJKOCPE = 1f)
	{
		return default(NativeList<HNPJEHHNIMF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OPNIOHFMNLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public float3 FJDJKDCINHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float LGDFBOABPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public quaternion BIDCBELANGP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x720DAB0", Offset = "0x720C8B0", VA = "0x18720DAB0")]
	public OPNIOHFMNLN(Vector3 COKJJHJKDKB, Quaternion DIGMAMODBCJ, float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x720D700", Offset = "0x720C500", VA = "0x18720D700")]
	public Quaternion IGOEGFJPHNP(Vector3 GGAAGAFEPHJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x720D7C0", Offset = "0x720C5C0", VA = "0x18720D7C0")]
	public OPNIOHFMNLN KAEBAMJMCEP(Vector3 OHKJJEGPLGN, Vector3 BABMPPPBFPO, Vector3 DOGKMIOCKEJ)
	{
		return default(OPNIOHFMNLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x720D560", Offset = "0x720C360", VA = "0x18720D560")]
	public JILCGPAKNEN GAIFPKGEANG(Vector3 GGAAGAFEPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class AKDDLLLBAGE : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7208540", Offset = "0x7207340", VA = "0x187208540", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72088A0", Offset = "0x72076A0", VA = "0x1872088A0")]
	private void BMDEMHGDNNH(Dictionary<Guid, Guid> FLBEBBLFLKP, NNHIIAPKBLB LDBEJGONCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x72085C0", Offset = "0x72073C0", VA = "0x1872085C0")]
	private void BMDEMHGDNNH(Dictionary<Guid, Guid> FLBEBBLFLKP, OIIOGLINGPL KPFJDCHNMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7208620", Offset = "0x7207420", VA = "0x187208620")]
	private void BMDEMHGDNNH(Dictionary<Guid, Guid> FLBEBBLFLKP, MOAGNACCKIJ IKJKLBPFKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public AKDDLLLBAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HOFKDPAEKAH : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x720BFB0", Offset = "0x720ADB0", VA = "0x18720BFB0", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public HOFKDPAEKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GMKCHLFJGHO : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x720BE50", Offset = "0x720AC50", VA = "0x18720BE50", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GMKCHLFJGHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MKMAJDNGMHF : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x720CD00", Offset = "0x720BB00", VA = "0x18720CD00", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public MKMAJDNGMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EBGAOIPIKIA : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x720BC30", Offset = "0x720AA30", VA = "0x18720BC30", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public EBGAOIPIKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DOEPNKCLAHM : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x720BAF0", Offset = "0x720A8F0", VA = "0x18720BAF0", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DOEPNKCLAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OINODOAMFJP : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x720D200", Offset = "0x720C000", VA = "0x18720D200", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OINODOAMFJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PJEKPFPBJKK : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x720EFA0", Offset = "0x720DDA0", VA = "0x18720EFA0", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PJEKPFPBJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KBMKOAFEMOD : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x720CA90", Offset = "0x720B890", VA = "0x18720CA90", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public KBMKOAFEMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OLAJOKIKCOO : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x720D3A0", Offset = "0x720C1A0", VA = "0x18720D3A0", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OLAJOKIKCOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JDJNFKIODCB : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x720C990", Offset = "0x720B790", VA = "0x18720C990", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JDJNFKIODCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class PCCNJEIDDGG : KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public static readonly FPOEPDBBHIN HPMEOGPDNLM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x720DB30", Offset = "0x720C930", VA = "0x18720DB30", Slot = "4")]
	public void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PCCNJEIDDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MLBPMEFMECJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public JNOHDJLMBEA BBDOELHAPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public OLCIGFHLLEM BHDNGHFDGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> FABLLHNGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> DCHNIOEFCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public EIBKOIBBMIN ELMIINMAFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public bool KILMFPPKPGG;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KBPAHHLFNPK
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHNCCPMMABL(KHAHIKIAAGM CEJAAIPJBLE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PDLINDCHEPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly KBPAHHLFNPK[] CHEBDCGLMCE;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x720DC60", Offset = "0x720CA60", VA = "0x18720DC60")]
	public static void CHFILMMPBGD(DACMPOAMDBF JOAPLPPIFPC, Dictionary<Guid, Guid> OLBKGPDLEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x720E540", Offset = "0x720D340", VA = "0x18720E540")]
	public static void PDHLELGJKJH(DACMPOAMDBF? JOAPLPPIFPC, ENBPOAJJCJF HKMOCHBHENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x720DEF0", Offset = "0x720CCF0", VA = "0x18720DEF0")]
	public static void GEBLMMBJIOL(DACMPOAMDBF? JOAPLPPIFPC, ENBPOAJJCJF AOJIJOECKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x720E170", Offset = "0x720CF70", VA = "0x18720E170")]
	public static void PCIAJFHMIDC(KHAHIKIAAGM CEJAAIPJBLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KHAHIKIAAGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public JNOHDJLMBEA EHLBGGFMJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public DACMPOAMDBF HCOLLOKLDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Dictionary<int, int> FABLLHNGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<Guid, Guid> DCHNIOEFCDM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x720CC50", Offset = "0x720BA50", VA = "0x18720CC50")]
	public Guid LILNGMICHNF(Guid OGOMDMBFOMG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EIBKOIBBMIN
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int NOIFAKCBCCF, [Out] Guid CKBIFGKBFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class ALFFPJAMDPL
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly ProfilerMarker CGKFOFDKCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private readonly HashSet<string> NIBCLCOFGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly Dictionary<long, int> KGBHONPJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly HashSet<Guid> EDLHNKGHEAE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IReadOnlyCollection<string> CIPPMGAMIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyDictionary<long, int> LAJPABIBBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x720A3E0", Offset = "0x72091E0", VA = "0x18720A3E0")]
	public static ALFFPJAMDPL LIPJOFDPNJE(PPNKBAMJHHC BGIEPHNJHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7209D60", Offset = "0x7208B60", VA = "0x187209D60")]
	public static ALFFPJAMDPL GOACMLAGMAK(LOOANCLOMIF MAIBBNKEOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x720A260", Offset = "0x7209060", VA = "0x18720A260")]
	public static ALFFPJAMDPL HFNLKNGFHDL(IEnumerable<string> NIBCLCOFGFP, IDictionary<long, int> GMKJDGIDFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x720A650", Offset = "0x7209450", VA = "0x18720A650")]
	private ALFFPJAMDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x720A510", Offset = "0x7209310", VA = "0x18720A510")]
	private ALFFPJAMDPL(IEnumerable<string> NIBCLCOFGFP, IDictionary<long, int> GMKJDGIDFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7209070", Offset = "0x7207E70", VA = "0x187209070")]
	private void BJMJDPMPEPB(PPNKBAMJHHC BGIEPHNJHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7208E70", Offset = "0x7207C70", VA = "0x187208E70")]
	private void BJMJDPMPEPB(LOOANCLOMIF MAIBBNKEOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7209DD0", Offset = "0x7208BD0", VA = "0x187209DD0")]
	private void HBEOEEOPGFJ(ByteString? BJDHFNJFGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7209270", Offset = "0x7208070", VA = "0x187209270")]
	private void BJMJDPMPEPB(BDBICHMFIED? DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7209A30", Offset = "0x7208830", VA = "0x187209A30")]
	private void BJMJDPMPEPB(LEEKCEDCACA? KFDHCNOCENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72096D0", Offset = "0x72084D0", VA = "0x1872096D0")]
	private void BJMJDPMPEPB(DACMPOAMDBF? HCOLLOKLDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7209B70", Offset = "0x7208970", VA = "0x187209B70")]
	private void DGEFNDALCOK(string? AHKPOGBPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7209BE0", Offset = "0x72089E0", VA = "0x187209BE0")]
	private void FBEBABAAMFN(long IENGHPNDFFA, Guid CEKPCOJHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7209CB0", Offset = "0x7208AB0", VA = "0x187209CB0")]
	private void FBEBABAAMFN(IADBOBPONFE? CENEHKKEOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7209D00", Offset = "0x7208B00", VA = "0x187209D00")]
	private void FBEBABAAMFN(MBHIKEDNAOB? CENEHKKEOLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DCEKGKINLOM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NHJBLNLBPOD : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private readonly IEnumerator<DictionaryEntry> NCNLLJPEKAC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public DictionaryEntry GEECONECLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x720CFE0", Offset = "0x720BDE0", VA = "0x18720CFE0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x720D0A0", Offset = "0x720BEA0", VA = "0x18720D0A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x720D150", Offset = "0x720BF50", VA = "0x18720D150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public object ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x720CF00", Offset = "0x720BD00", VA = "0x18720CF00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
		public NHJBLNLBPOD(IEnumerator<DictionaryEntry> NCNLLJPEKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x720CE60", Offset = "0x720BC60", VA = "0x18720CE60", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x720CEB0", Offset = "0x720BCB0", VA = "0x18720CEB0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class CBNKBMNLJHC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x720A8C0", Offset = "0x72096C0", VA = "0x18720A8C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public CBNKBMNLJHC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x720A770", Offset = "0x7209570", VA = "0x18720A770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x720A870", Offset = "0x7209670", VA = "0x18720A870", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x720F660", Offset = "0x720E460", VA = "0x18720F660", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IDictionary.this[object FFOHLCGHDKA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x720F570", Offset = "0x720E370", VA = "0x18720F570", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x720F750", Offset = "0x720E550", VA = "0x18720F750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x720F4B0", Offset = "0x720E2B0", VA = "0x18720F4B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x720F510", Offset = "0x720E310", VA = "0x18720F510", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x720F6F0", Offset = "0x720E4F0", VA = "0x18720F6F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x720F170", Offset = "0x720DF70", VA = "0x18720F170", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x720F1D0", Offset = "0x720DFD0", VA = "0x18720F1D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x720F230", Offset = "0x720E030", VA = "0x18720F230", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
		public RoomObjectCounts(Dictionary<int, int> IFNIJDIOGBE, [Optional] Dictionary<int, int> PMPPEFOIFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x720F090", Offset = "0x720DE90", VA = "0x18720F090")]
		[IteratorStateMachine(typeof(CBNKBMNLJHC))]
		private IEnumerator<DictionaryEntry> JCHBALFGPLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x720F7A0", Offset = "0x720E5A0", VA = "0x18720F7A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x720F3B0", Offset = "0x720E1B0", VA = "0x18720F3B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x720F290", Offset = "0x720E090", VA = "0x18720F290", Slot = "9")]
		void IDictionary.Add(object FFOHLCGHDKA, object IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x720F2F0", Offset = "0x720E0F0", VA = "0x18720F2F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x720F350", Offset = "0x720E150", VA = "0x18720F350", Slot = "8")]
		bool IDictionary.Contains(object FFOHLCGHDKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x720F450", Offset = "0x720E250", VA = "0x18720F450", Slot = "14")]
		void IDictionary.Remove(object FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x720F110", Offset = "0x720DF10", VA = "0x18720F110", Slot = "15")]
		void ICollection.CopyTo(Array EOOCBMPNEML, int KNCPCNBMDNF)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class PFCJBGAPOEM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x720EF50", Offset = "0x720DD50", VA = "0x18720EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public PFCJBGAPOEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x720EDC0", Offset = "0x720DBC0", VA = "0x18720EDC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x720EF00", Offset = "0x720DD00", VA = "0x18720EF00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x720C6A0", Offset = "0x720B4A0", VA = "0x18720C6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IDictionary.this[object FFOHLCGHDKA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x720C570", Offset = "0x720B370", VA = "0x18720C570", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x720C750", Offset = "0x720B550", VA = "0x18720C750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x720C4B0", Offset = "0x720B2B0", VA = "0x18720C4B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x720C510", Offset = "0x720B310", VA = "0x18720C510", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x720C6F0", Offset = "0x720B4F0", VA = "0x18720C6F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x720C130", Offset = "0x720AF30", VA = "0x18720C130", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x720C190", Offset = "0x720AF90", VA = "0x18720C190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x720C1F0", Offset = "0x720AFF0", VA = "0x18720C1F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2523650", Offset = "0x2522450", VA = "0x182523650")]
		public Invention(long MIFPCBFGGLI, int BMGBDLLODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x720C060", Offset = "0x720AE60", VA = "0x18720C060")]
		[IteratorStateMachine(typeof(PFCJBGAPOEM))]
		private IEnumerator<DictionaryEntry> JCHBALFGPLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x720C7A0", Offset = "0x720B5A0", VA = "0x18720C7A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x720C370", Offset = "0x720B170", VA = "0x18720C370", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x720C250", Offset = "0x720B050", VA = "0x18720C250", Slot = "9")]
		void IDictionary.Add(object FFOHLCGHDKA, object IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x720C2B0", Offset = "0x720B0B0", VA = "0x18720C2B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x720C310", Offset = "0x720B110", VA = "0x18720C310", Slot = "8")]
		bool IDictionary.Contains(object FFOHLCGHDKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x720C450", Offset = "0x720B250", VA = "0x18720C450", Slot = "14")]
		void IDictionary.Remove(object FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x720C0D0", Offset = "0x720AED0", VA = "0x18720C0D0", Slot = "15")]
		void ICollection.CopyTo(Array EOOCBMPNEML, int KNCPCNBMDNF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> PGKMEHCKNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyList<Invention> JCDJHHALCIL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	public DCEKGKINLOM(IReadOnlyDictionary<Guid, RoomObjectCounts> EIBEPLAOENP, IReadOnlyList<Invention> LCKDMNBMMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x720AA30", Offset = "0x7209830", VA = "0x18720AA30")]
	public static DCEKGKINLOM LIPJOFDPNJE(PPNKBAMJHHC BGIEPHNJHFK)
	{
		return default(DCEKGKINLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x720A910", Offset = "0x7209710", VA = "0x18720A910")]
	[CompilerGenerated]
	internal static int IPPENJJFECG([In] IReadOnlyDictionary<long, int> KKGCMENMAGJ, long? IENGHPNDFFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x720B440", Offset = "0x720A240", VA = "0x18720B440")]
	[CompilerGenerated]
	internal static void MGHDOFOGOBL(int OPGMNKFJJOF, [In] BDBICHMFIED PILILNPGAMH, [In] Dictionary<long, int> KKGCMENMAGJ, [In] Dictionary<Guid, RoomObjectCounts> EIBEPLAOENP)
	{
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
