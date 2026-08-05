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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDA70", Offset = "0x7BDCA70", VA = "0x187BDDA70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFIPIFGNGEO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HCHEOIINLGH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MMAHCJIBIEH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> JALLCOOCIEA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> DOCBGJNOCIG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BHHKODMFAMB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string GCPPOPOILJD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string CCPDMJMHFIL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6550", Offset = "0x7BD5550", VA = "0x187BD6550")]
	public static bool PJHMNFJHAAO(Guid NJFEOEDENBE, int AINKCBODBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5DF0", Offset = "0x7BD4DF0", VA = "0x187BD5DF0")]
	public static bool AFNCJGCHDKH(Guid NJFEOEDENBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5E80", Offset = "0x7BD4E80", VA = "0x187BD5E80")]
	public static string FBEOOHLOJGE(Guid DGNNPFFMIEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GENPBBPPBOP]
public enum MEPJOONJNNM
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
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELECTRICAL_UNIT,
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
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BDCFC0", Offset = "0x7BDBFC0", VA = "0x187BDCFC0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OAIANICEPIO
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MHLOOLHECKK;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid JCLNIHHLOOC;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid MFAMMECFKHP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ENEPMBKLIHO;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid ICNOLNNEKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid OFFENLLMACM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid AACODLKDCJO;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid HCNMPKEBAKO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid LLLFFEOMDLN;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid JHMEINNBDGP;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid KIFCLHGDANJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid CCHPJCDPCPO;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid LKNNOALKABB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid EFJLABHDMJP;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid EFIIPMPDEJP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid EOPALEHIEDG;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EPDOJACNJBJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IDDADKLGIAD;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid CAFFJLDCBLN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid CGPCPELDKPM;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid OINPDOLBLEO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NLNBLKKNJCG;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IMEMINPMNCO;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid FJFLNILJDNM;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid BHLJIIHFDED;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid MLFHGBDBLJK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GAHNLIHJBHN;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid KNLJHBGAGEK;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid DPHGIJIMDFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid AAHPKFBLFON;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EBFGLNCBGAD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GDKDHLPEANL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid DOBMGCNMFJP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GLEJIBMLMCA;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid BDOBNMIPHHP;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid ANBBIHPPDEH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid KKEEGBBMLMI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FJDHBAKDEHE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid COHFHBIIPDE;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BKPEPHDJBFK;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid GFCOKPMEODD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid MEJDOEGNJCA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DKHPAJFFLJG;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HCLLBALKKCA;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid MBOOBNFFNIH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FDCGMGGOBBA;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid KHDNHOPDFKD;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OCDIBMOHIHB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid PDNEFADOCHA;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid NIAOIAHBBHO;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid CEOCJJCIAAP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid IFCMLJEHHGN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EGBGNJMLEAD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JILMCFJNJLN;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DGJOEOIJDJA;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MCAGLLGCJJM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid IELNANMDFCH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid OKBMEGJJPBB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid NAIMEAINGPO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid JJEDLGOBMOF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NANKIBFLKDO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid DMFLNNFFDDJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MJCGAFKAPJH;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid KPFIECNAEJF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid DJJMKCIHNAO;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid NMHNDFBLODF;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AOFDIDIGBEC;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid IOHMPILEJIL;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JJAMFMAJCLO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GCMCNAEEKEB;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid GPAOAMIPAJL;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid CKCGBDCAPFI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid MDLENEIMIPH;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid DDLANLPFHAC;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid CKJCBECACAL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid NAJPJKFKEOL;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid HBOFOGLFHJM;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JFILBPDDNDB;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid AKHGJKJLAJC;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MEINFJNCFIK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid NECLAFLDCME;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KBJMJHFMCMO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid EOANACNPBFL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid ACAFEEJMAJC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid OJEDNMKILDL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid ILBLLDPKCPB;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid PEAAOFENODA;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid AMDDDMCBJCH;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OOCOKIOKJBN;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid MONGFAMIEGM;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid ANIPAGHNDMJ;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid LCFNDJKKGDC;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid ALJEBOINJPN;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EBCJMOKMMOJ;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid KDMBOEEAFAF;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PHDGMPJGBLK;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid IPMJEGNFCEH;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid LOLHCNMAMAK;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BIAOLMKOOIM;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid CBDKCDINEPN;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AFMEKHHCFHB;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid LOHDGMBHOKL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HCKLKMBGCDK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GABHHHONBAN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid KBFOIELCADI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid ONGNMIOFJJL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LKJNBEPIABB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LAKFMCANHPK;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid HGKOMJOLEKE;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid IJELHEPPFAM;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MLEFBOGHDGC;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid BIJOJNIDAHE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid CLMEENENBIC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IIPAENHANCK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BKBGCMPDLED;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid CHNFFBDODKL;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid POFCGLJOJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid BAFIHLIPHMN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JAEDJAFLNAC;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid HCJKEBNHNMF;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CLGBKMLDFKH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HBHFBMBCEBN;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid ICBHBMGHDOP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid LHJNDBGBEIK;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HKFPKBBAIKI;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid HEIDKIPOBEE;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid EJACCNHFGID;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid IBAIFBMFKLN;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid GAIHIEKOIHF;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KOPHOAICDEI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid OCANOGHDDCM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid CGMHBDNGMMO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid GFLNNJDPDLC;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid HGAPCBJOALM;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid AFKCPBOPAGH;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid NIBPIIKAGHF;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid PLCILJEFBNL;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MAJHDKIMHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid MMPFDEDBOBI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JJLFEJMFIGF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MEHEMGPIFHB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid IPKNDMCEHBC;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid EDAAMMBEKJI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid MJOANICBKCL;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid OKCAFMFFFIO;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid JIABDFMLGFO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BCGCDKCCDHH;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid DDJONHCOIGD;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OFMLMCFBNJE;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid CKAGOHMPFKF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid EBMDNJAKLPD;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid EKNMHGFLNMO;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid HAFIOKJLKCI;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid JNELDKBNDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DBOKCGKANMF;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HEBHBOHCIBE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid KOKIDOAFCNJ;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid BFMMNJJNBHM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PADFLJGKKKA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FFAOHAHHIEF;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid ABAHDDLJOHE;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid IKIDKOEDMCD;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JNPOGMFAHIA;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid AONCAOEKFAB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HFACFABHOFG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid CIOIPONOLML;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid OEAOOIGLHHK;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid OKPNGIFHNMA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EBMKNKJIDNG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LOMIDLNIIPM;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid DFFKIBOOCFD;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid EFGMKOFDFEF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GFACLDBDLOG;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid OLPFENOJNHH;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PBMJHIJPAGE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid FOKBPLHMKEJ;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BEGJAOJOEPP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MHHMEFEBABA;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FGKFFLNCNHC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid FNANPOFMEID;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid FFBEEDEIHHA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FLOOAAILBHC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid FBNJDAIAAEM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid ECHBKAKNMCB;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FAEIOHPHMNA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NFNPAPOHPEN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FCEBIENCEHD;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid GFCPEOFKFPE;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid ANJFBENOACH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid JLAKENDBMDN;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid PONMCLHDEFC;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid OHHKAPPCEAD;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MNKFLNCOFII;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LLPDMDKDPEP;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid ENHPOJDLIHC;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid KIBAPBBFELA;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid NDAMEALEIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid HMBCGEAHLDH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid FOIONDIPIOP;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GGBLEDPHIHA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid EJCKOMENDBP;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid FNMGAFCKIOO;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HOPHJECGIGH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid EGJLLEOABLE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DBOPGGMBCKF;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid BAONDMPLJIM;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid JIOFKKJHKPO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EJMMNDONIDI;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NMKFMNJAHIM;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PEACOFNEJPL;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid OBKJNAEIOHH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FBDPDHMMBOO;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DFPEEBGIDAI;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid HKEOMABMCEI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid IAACCGKJHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid CACLKHABCML;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PABJIBJKNHM;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid GGHGBDKJNOF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid JPGLJMCOGEN;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid PDHMBHAIPCB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid BACFJAECNOF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid IFGFCIGBHIN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KBNEHGFGCOH;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid LNKKOBMDFPN;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid AFFOEJMPFIM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid PKIMNABDBPD;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PFOGHABHPBJ;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid JIAPAAGMNML;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CGGBHMDHDIA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid HPBAFGDKOAF;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BPBCLICCDFK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid HGABHKNIHOH;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid GABKNBFBEMK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CHEHGHKFJPL;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KBKNGBBBIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid OEPHJMGBKIK;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GOMIACMCFHA;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid NACNCLCLGJJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid HBLFJLAJPOO;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid CBLAABFJGOP;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid HDJHKABAOCG;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid CBKGIDDPAJF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid ELEBIDFMMOO;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid IJMAIAELGOP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid EJKFMAJGFMI;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid FMOOCCNMEHD;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DGMMEJENDOM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MODOOFBLIKN;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AFLEKGGKLKB;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid ILMPPPAPFFN;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid OBEFBGONDNC;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NDLJBCBIIEG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AIHNKGPJPLL;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid JIOGBEFJIHB;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid IDCONKJMIEI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid FDLKBDEDOIH;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HAINBICGEKA;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid OGOANMICCAK;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HCNGPDFPBDD;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LELPAFACEKI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid GEDEFKJOKMF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MGFONDAPIDF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid OHACIEPGMCH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid EAMMBEKHEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OIDIHFFDBCF;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid CNOBANMKCIK;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid NPIMBLFCFCA;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid JOPJBGOELJM;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid IGJOMJDCONE;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid FNHBFGOAEKH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid CEOIJDPCGJH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LNAOHNMINFH;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid POIAENBCAJB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid JGIBDFLKCJF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HEJDFJJCJCB;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid MNEECBKDIJE;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CNCFHKGIEPB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KDMBJMLCNIM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MBFLNAPNCOC;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KOLFNNMADHM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid MJIPBPLNBKG;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid HOIMFJBCKNO;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid LNPOBMICNMP;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NBFILIOHBMB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid GJBJFENDIAP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid MBKMDJGCHBB;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid AEIHPFKJHFA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JLNHGAIIMLC;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IPHLPPJHCAE;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HPJHBPACJIE;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NLIDLFMFPDK;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid LGGOCIIGANA;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid CFGJIGAJKGD;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid PLPFFFKAJOM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid IKHCIGGKHLJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid HOFJGEMNCDA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid LIDFKDHBGGO;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OIIGFKIPFJM;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DJADEPCHNFG;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid IOCPJKNNIAO;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MAGPFMFJLBD;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid GFNDNHMMMBF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid ANGMOPAMIOH;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid IPAANINMIAM;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JJOHPHFLCIH;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OFINDAGJKNC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid ELOGLHEHJOF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MMHJCGPHCCM;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid PICJNEDFAOC;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NOADKEPHCAC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DPEPEDDONDA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid NOPPAGMGLGG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MMMFLGNBKID;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid LKNMJNEIBOD;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid FDOFEALCEML;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid GACGCPNLGGL;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid MHHOFJJGHNL;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FNCABKHPBOM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JAEBDAEDHBC;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid JOGIBHKEKNG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KBDNBMAPDLK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid OLHGAHDCFIO;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HAADNLBJHOC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CNAGJNKJGLI;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid FFBADPAHELH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid EEGNBKLANAN;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid ADFKAPGLLPJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KOBDMCDAPBJ;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid JHCMJEBHLHJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid OHIDJHLMLDL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GFEIFIEMMOC;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid CONEPMMBMLL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid MKINHJGIEJJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid FILBAGOIGED;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BAAEAPKIEPN;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GBOHEJMEGID;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid HLODPMADLIL;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DABCDOCEGDC;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid EOEBMMFPLOJ;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid AIDMJKCDNCM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid IFGENKNEAPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid OMAPGBMMIFJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid IFBFECJHCFK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IPLLGAIBEPC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid PAEGHANCOPE;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MDAMNNHBGPE;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid MBFKCBMFGNE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid MEBCOPOPHJB;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid PPBCGPKGPBN;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid AKHCNNDJHHG;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AEIAFMMEKEJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid CIOAKDKILFE;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ENFDFNNIJGD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid CNCOAAJMNNB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid ELLIHABIKBN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PLCCBKOMOCI;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid PAIPAPMBKHL;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid BLHIMGKBHJK;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IPDLHOBMDEC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JABMDOGGDNG;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid ABIBCCCCEJC;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid PLGBGBPJHCD;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OHBCFCPLEGL;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid OBHHCEPJHJI;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid IAHODFJMBCD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid MEEIAGPJBIH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid DLFKMJLKCAM;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OBKBIBADHBA;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid NEMHAKCIKOP;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid FBLBOIDLHAI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DFLOJEDBFIB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JBIEKKGHFIA;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid JEFEMMJALLP;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NJMLMJCCDFL;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid AIJCJDPLGIP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MPHADINIEHD;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid PBPNCMHOHMB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid NHPMIOKBEFN;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JPPKMKAGFLB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid GEOOINNHPAH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid BHCOAKNNNHD;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KPBFPMGBNBC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid IAMNMHGJECH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DFMPOCEJCAL;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid GAFNFKLLEGD;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid AAGNOHDHLJJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PLOBLIBONLG;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ADBKHMJNKOD;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DEIJFGMMCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid LAGMEFKAAKA;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid HGKPHLAJNML;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid KAIFPGEAJLD;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid PONDGHOKKNH;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid ONCOOOIBDFA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid GNBMCFHDHPM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BNECGLMPMBL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BHMJNNIOEGG;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AANNHLADKOG;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid CLMDIPAJENI;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid ICOIGFNIDKE;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid GOAOCNDHPKB;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid HCIGCDCLNAP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JANLAKCBICE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid OBIPDEHBFOK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid DEPPOIMGBIA;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GAOAFBLIOID;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid LPLMNMPACDJ;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DGFJBBLLLBJ;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MEBBDCNONCL;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ODPEMFOOIML;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FHBHIOGOHDE;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid FEDEFFJDHCH;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid LGFADMCMNCN;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid GPABFCKGGFE;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IKBCHEPHBAP;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MLAEKHOOJJC;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HEACKPLKPJF;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid AGOIOOGDBDI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NGNOCBGMLIH;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KDAAIJHELGH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid EDCBCNLBGEP;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid DFPAFCGPHNP;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NDGMOBAHDFE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid KNOOLMKOGEO;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JJLMPCDAHHA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PFMKFLFNBEC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GMHLHHANAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid HCOGJAFFLCL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OFKJGNHJGHN;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid BPGPFFPOLAN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid EKDMJMDDLPL;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid LGCJOPMFFBC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid OFKBMCMOKDJ;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid GMBLOEEACOF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GFCBMFGMOJJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid NGJHCFPIDHI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DIHIJLEOALN;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid MPMCKGLIIIA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid IHJNMFMPPCL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid DBAAACBEIAK;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PPKJDJAHHOO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NFCCPFDIKMI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid EJHHBIFLFME;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid IDNAKNGEBFE;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DLGFBAEOMGI;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid PIODOAHCOMB;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid ANHGEEKMDKI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid AHCFNGAJNEH;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GAHPJFNHBHG;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid GOLPGLINBHA;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid HODFPCNGLFG;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid PODNMFLDOOI;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid AMMFNAENPBL;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PBPJMILDOMA;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid IMBHBFJEEFD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KEPGNCDOKEM;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid BNCIHHODNFC;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid IEOCACJDHGI;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid HFOALKENPCB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid ECGEJPDLCIM;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JJKFHPJOKDM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid FOALAINPKDA;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid DIIPBNHHGHE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DECAIODPINE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid FOCNCKIDKGM;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid NCEFGJLDEDH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid FLLDIBHADML;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HJCBIEHJLJB;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid PPCDEKGPFMG;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid MHHMIEKKLHG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid GHBIMGLCOOD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CGNCHKFLJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BPGPJFPHONP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid CJFEBMAOIAF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid JPBGIDHOMNB;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HMEKIHNCOGB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid EKBLELEHDLH;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid IHODJCJKCIG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PONBNHICDIA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid ELBBKODNDCM;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AMOJOAHLLAC;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid JEGCEAKMKMG;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FGCAAPHILCH;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid JKFIDEMJNEK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid BGCEHDDNPJN;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid IOIJIJNMCJN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid JMDOMLFFCEL;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GCHHPLBHMMH;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid JBBPDLNPIEN;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid BMBEAOPKFDH;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid FCFCKMHEGAP;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid CPBLBGDNIKF;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid EGDICPCMAOF;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BOKLJMBOAIF;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid MGCFIPLMBBN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NDHJGIAOGAP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PPNHNLEJKAC;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid LGGDFJOKJHH;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid EGGGAEEEGIL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HCHDOHKBGKE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid FGIFFNEPJCC;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DFHFACIIDBB;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KMMFFIDKMDP;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid FLEDIPOLBNO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid CKFKEJOJKJF;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid IDMJABIIAGN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid IBCCIDPMHPB;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid EAFPFCOGGIA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid PONGBJMDBFD;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OPMKNIOPCME;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid BCKOFLINGKH;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LOHOFGNHFCG;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid OMNGABMNIDI;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid COCJJDJANGH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid MBFDGEIJJCF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid AOAPGIGILDB;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid CBNJHINOIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid MHMJCGKEKJG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EBDPAAHPBPI;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LKDFBNGOODO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GOAAONGKGEI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MANMDOLELAD;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid GPOLACPHIKK;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid ADDEHPHHNNK;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid NJDNCIBAFAA;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KDLOMEPLFME;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid ODCEFHLDPMJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid JFOJHKBBDEG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid OPKCOKIINFI;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JLFJCMPAMKO;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid CHBKCEPKGNH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IKMJIKJJMIH;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid JODCANDHMLP;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid CMNEPOFDAEI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid KIDFFIKNPFI;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid GEHEKDDBOFF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HGJDPNMIEOF;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid JCJOIECPFOB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid BEKKDOHHFIF;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid HMFKKFBCNHO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid AEAOLGNCFJF;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid APJKJEBDKIG;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LAONFOCBJON;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid IIPALEMEMIL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid AHEOMAKHDEP;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid KFCLOKNAKEB;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid BJKEJNAMHLP;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BPFLGOKHPGG;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid NGIMFGJDIJM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid EKPAHOBNLDC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid AHFGADCPCHH;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid LKFBKCADGFC;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid FJNLBPIFICN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid AJFOFIPCFHE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid JKBICBIJGDI;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid CFNOHGPOAAN;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid MIKHKJJJOEG;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IHPBGAFJEFH;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid KMBDJIKJEFM;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid MAGKJFINFDD;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid EMEBIIPOIBO;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid MIGKFLBBFAA;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid FHNCLFAMLLN;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid OCGCOECMNHL;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GDGLGKIGJHK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LJNCJEAECBM;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid JCDNOFHDOEK;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid LKDBABLBELD;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OOLABFJGFJN;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid NDGDJLEGFPL;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid EKHFNJLHNPG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid IBHDKJAOOCB;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid AELAEEKDACG;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid GFFGMAOKEAA;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid PBHJGHLICGG;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid LNJCEGLKNGN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid NCALNLNGKFF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid BNGNAAJMBBO;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid EIPHFDEBHJB;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid AHFDIPJGLAI;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IGCEIINFKKD;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MOMOBDICCHC;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid LCACGJAKOHL;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid AGEAKOECMKB;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid NAAFENBCHLB;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid MOLKNCGKKJC;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid AFPMNIAHJMN;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid FEFAMGAEDKA;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid HGJAMOHHMOE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid GCLNCLBDGBH;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid IOIMCEJCAHB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid FMLNKDAAIDI;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid GBKEILEFKCD;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BIDIGALKJHB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid IPBLLBDILNL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid LMIHBDMHEPH;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid MJEMNMFHGMH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid LKBBAIGJCHC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid KAFCMFLKHII;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid IDFOBOFFNLK;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid LBGIEIAGNMM;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid PEBPJPPKMDF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid CFGPMHCKPPN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LNAJICMDPFA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid HJFKCDEOJAC;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NOGIIDEBCPG;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid AHJBJDAJOAB;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid LAFKPLCEMHO;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MKANENJODDI;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LFEOEJHNMKA;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid DDGFOLJGPKF;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid NHOOEFHNBMI;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid IHOJIBHCNLI;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid BPCDAACMBLA;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid EDHDAGPBJLF;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid BLGCPFOLLCL;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid LHKHBKBOGKM;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid MGFJKDDHJNM;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid LGDEDHGNLIF;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid MDLEHKBNAMB;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid PNPPBHAMMCO;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid PNECNPCFPIG;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid EJCBHINLOFC;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid IGDFPAKMOAK;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid KHLBKADBFNM;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid JMEBNKOKHJM;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid DLBENIAGAFP;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid FNKOFFDMOIE;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid OLCKHAHKHLO;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid PCCOLEPLGNM;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid BAHMPJPDCLC;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid OFDJCCHHAHI;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid KNBDGGMMGBD;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JEBFACJIBMM;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid CJCMCPEMFFB;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid MLEIFMABLCP;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid FBCEINELJJN;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid PMCMMLDAHDG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid PJEIGCBCJDA;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid JEEJFGAJINK;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid ALEDMCJFLME;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly Dictionary<Guid, MEPJOONJNNM> LEAPKOEKDOC;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private static readonly Dictionary<MEPJOONJNNM, Guid> DFGNFHHIEFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MEPJOONJNNM> GMJCOHGDILA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDB50", Offset = "0x7BDCB50", VA = "0x187BDDB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MEPJOONJNNM, Guid> HFEFIALKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDAF0", Offset = "0x7BDCAF0", VA = "0x187BDDAF0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CNEAOGCCLOD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5D50", Offset = "0x7BD4D50", VA = "0x187BD5D50")]
	public static bool HMDHMDNIAHN(EPFNGLONGKG FJOBJBAABGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD59A0", Offset = "0x7BD49A0", VA = "0x187BD59A0")]
	private static bool HMDHMDNIAHN(FHKJOHOMFCJ MECICAJOHBD, EPFNGLONGKG FJOBJBAABGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BMNIONKHDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JHBCFLAOECG APDBNIMCPID, [Out] Dictionary<int, int> KKNHMACBLHB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(APPGMHGFBGI CLGIMKMFKGO, BEGBPHDBMGA ONFJNMMNHMC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KGIOPPFOOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly BOIDOHDBGAH CCLMFNNFKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly IEnumerable<DJNGLNAIHJJ> OINKOPKLOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<DJNGLNAIHJJ> BDHAKFANFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly EDBALDILLBK<BIEIIMCKPHN> PBMEMNEAACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> NHKPBIKCELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly HMPEPPHBKMF BGJKDFMEDLA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DABKHIMFMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCF50", Offset = "0x7BDBF50", VA = "0x187BDCF50")]
	public KGIOPPFOOPI(BOIDOHDBGAH HLKPCNLNBOA, IEnumerable<DJNGLNAIHJJ> GPHGBEGKLDA, IReadOnlyList<DJNGLNAIHJJ> KKMDBMFHEOJ, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> MNAJCMAGKLD, HMPEPPHBKMF CBHCMEKADCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KECMJBDOPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly BOIDOHDBGAH CCLMFNNFKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<DJNGLNAIHJJ> LJPKHKKHPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly EDBALDILLBK<BIEIIMCKPHN> PBMEMNEAACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> NHKPBIKCELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly ByteString FKNLKGCMPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly HMPEPPHBKMF BGJKDFMEDLA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCEE0", Offset = "0x7BDBEE0", VA = "0x187BDCEE0")]
	public KECMJBDOPMC(BOIDOHDBGAH HLKPCNLNBOA, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> MNAJCMAGKLD, ByteString CDBBEPNLPPM, IReadOnlyList<DJNGLNAIHJJ> BBCLCGJBJJA, HMPEPPHBKMF CBHCMEKADCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MJCIGHECEBG : FCOFBKLBGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly Guid LCFNKIFGMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly Dictionary<Guid, Guid> DHPEMHCCIBM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48CFC80", Offset = "0x48CEC80", VA = "0x1848CFC80")]
	private MJCIGHECEBG(Guid FIGKIMIMPCP, Dictionary<Guid, Guid> DHPEMHCCIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD0C0", Offset = "0x7BDC0C0", VA = "0x187BDD0C0")]
	public static MJCIGHECEBG ACADPGMDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD9C0", Offset = "0x7BDC9C0", VA = "0x187BDD9C0")]
	private static Dictionary<Guid, Guid> PMHDDKIIMOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD5C0", Offset = "0x7BDC5C0", VA = "0x187BDD5C0")]
	public static MJCIGHECEBG HGDGDAHMDMF(IReadOnlyDictionary<Guid, Guid> KIDPOMGFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD6D0", Offset = "0x7BDC6D0", VA = "0x187BDD6D0")]
	public static MJCIGHECEBG LKFCOIBNODJ(IEnumerable<KeyValuePair<Guid, Guid>> KIDPOMGFMKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD650", Offset = "0x7BDC650", VA = "0x187BDD650")]
	public Dictionary<Guid, Guid> JFHKHDHCFJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
	public Dictionary<Guid, Guid> NEKLGKIKCCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD5D0", Offset = "0x7BDC5D0", VA = "0x187BDD5D0")]
	public void IIGLPCDPOEE(Guid KIDPOMGFMKB, Guid ELDDEEODOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD150", Offset = "0x7BDC150", VA = "0x187BDD150")]
	public void AOIMHBCDJPH(IReadOnlyDictionary<Guid, Guid> FALJFAPHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD3D0", Offset = "0x7BDC3D0", VA = "0x187BDD3D0")]
	public Guid DBPHELPCAGH([In] Guid KIDPOMGFMKB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD520", Offset = "0x7BDC520", VA = "0x187BDD520")]
	public Guid GHNOODGANAA([In] Guid KIDPOMGFMKB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD050", Offset = "0x7BDC050", VA = "0x187BDD050")]
	public bool KIODLPJJOLF([In] Guid KIDPOMGFMKB, [Out] Guid ELDDEEODOKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD050", Offset = "0x7BDC050", VA = "0x187BDD050", Slot = "4")]
	private bool AABGOJINCNN([In] Guid KIDPOMGFMKB, [Out] Guid ELDDEEODOKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGJLHBKDBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CDIACDKPGMD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DAHFMEIEOHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public BOIDOHDBGAH staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DAHFMEIEOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD5D80", Offset = "0x7BD4D80", VA = "0x187BD5D80")]
		internal EDBALDILLBK<APOJALOJJAE> JNIDIFABFOD((EDBALDILLBK<BIEIIMCKPHN> GraphId, EDBALDILLBK<ALEKBGLLPHJ> NodeId) i)
		{
			return default(EDBALDILLBK<APOJALOJJAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly KOLDGJODODL<APOJALOJJAE, int?> OMGOHMNNMJE;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly long MMKLKFFOCDL;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8420", Offset = "0x7BC7420", VA = "0x187BC8420")]
	public static (long, long) GNAAGOKLOJH(BOIDOHDBGAH HCGLPHPPLNL, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BC82F0", Offset = "0x7BC72F0", VA = "0x187BC82F0")]
	public static long GAOEDAPOPPE([In] ReadOnlySpan<EDBALDILLBK<APOJALOJJAE>> DNCGOCMAILL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8850", Offset = "0x7BC7850", VA = "0x187BC8850")]
	private static long MCDBDMBNAHE()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AICAHOGODPA
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public static readonly HashSet<MEPJOONJNNM> FLDHOMEKPIH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JGNBFNMNGML
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EGLIJKPGBGE : IEnumerable<DJNGLNAIHJJ>, IEnumerable, IEnumerator<DJNGLNAIHJJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DJNGLNAIHJJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private DIFMPACHIKE spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public DIFMPACHIKE <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private OPJHJPKHKMN spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public OPJHJPKHKMN <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DJNGLNAIHJJ System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public EGLIJKPGBGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFD10", Offset = "0x7BDED10", VA = "0x187BDFD10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFF90", Offset = "0x7BDEF90", VA = "0x187BDFF90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE20", Offset = "0x7BDEE20", VA = "0x187BDFE20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DJNGLNAIHJJ> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE20", Offset = "0x7BDEE20", VA = "0x187BDFE20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBAA0", Offset = "0x7BDAAA0", VA = "0x187BDBAA0")]
	public static DIFMPACHIKE HHCFMBOEGJK([In] KECMJBDOPMC DGFHPPKMBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB920", Offset = "0x7BDA920", VA = "0x187BDB920")]
	public static DIFMPACHIKE HHCFMBOEGJK([In] KGIOPPFOOPI DGFHPPKMBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBD30", Offset = "0x7BDAD30", VA = "0x187BDBD30")]
	private static HashSet<IGLPJBODKFE<CDCOOBOKPHM>> IODMKCPDAHD(IReadOnlyList<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB230", Offset = "0x7BDA230", VA = "0x187BDB230")]
	private static void GJDMCMFMAPH(DIFMPACHIKE GCKGBGEDAEK, [In] KGIOPPFOOPI JLCNJPEJDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9B70", Offset = "0x7BD8B70", VA = "0x187BD9B70")]
	public static HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD> DJCNOAEEEFC(DIFMPACHIKE GCKGBGEDAEK, OPJHJPKHKMN AGACDABDCFN, MJCIGHECEBG? AJGLJAGEOPH, bool ABCLNEAOIBC)
	{
		return default(HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBC20", Offset = "0x7BDAC20", VA = "0x187BDBC20")]
	[IteratorStateMachine(typeof(EGLIJKPGBGE))]
	private static IEnumerable<DJNGLNAIHJJ> IDAIMGHDGJH(DIFMPACHIKE GCKGBGEDAEK, OPJHJPKHKMN AGACDABDCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB1C0", Offset = "0x7BDA1C0", VA = "0x187BDB1C0")]
	private static void GGCKMJPBNPO(DIFMPACHIKE GCKGBGEDAEK, OPJHJPKHKMN AGACDABDCFN, IReadOnlyCollection<ByteString>? CFCJBBEJABD, IReadOnlyCollection<ByteString>? HGEKKCEDFCA, IReadOnlyCollection<ByteString>? NJPKINGAKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC3A0", Offset = "0x7BDB3A0", VA = "0x187BDC3A0")]
	private static bool NMLGCDMONOI(DIFMPACHIKE GCKGBGEDAEK, APPGMHGFBGI CLGIMKMFKGO, OPJHJPKHKMN AGACDABDCFN, [Out][NotNullWhen(false)] string? JHEMEKBLBHP, [Out] Dictionary<int, int> KKNHMACBLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAEE0", Offset = "0x7BD9EE0", VA = "0x187BDAEE0")]
	private static Dictionary<Guid, FHKJOHOMFCJ> ELHEMCIBDHC(DIFMPACHIKE GCKGBGEDAEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB890", Offset = "0x7BDA890", VA = "0x187BDB890")]
	private static void GJKJPPKEPOK(bool CNPMPIOPELL, DJNGLNAIHJJ BJPIFCHFNAA, MJCIGHECEBG CCLPDFENGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC0D0", Offset = "0x7BDB0D0", VA = "0x187BDC0D0")]
	private static void KBKKPMIKCBB(DJNGLNAIHJJ BJPIFCHFNAA, Guid CJHMIILEEBE, DMMECELPFMA? FCGGKPLFOIN, Dictionary<Guid, FHKJOHOMFCJ> CHKBJMAIGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCA30", Offset = "0x7BDBA30", VA = "0x187BDCA30")]
	private static void OJPGNPHCIAM(IEnumerable<DJNGLNAIHJJ> MEBILOCBJAG, IReadOnlyCollection<ByteString> CFCJBBEJABD, IReadOnlyCollection<ByteString> HGEKKCEDFCA, IReadOnlyCollection<ByteString> NJPKINGAKGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OPJHJPKHKMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public bool CNPMPIOPELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public HMPEPPHBKMF CBHCMEKADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public DMMECELPFMA? FCGGKPLFOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public DMMECELPFMA? IHOAOJHOMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public BOIDOHDBGAH DNDGOEBFANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public AGJLHBKDBAF NNILGABBJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public BMNIONKHDLP ABDEGCMGBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public IGLPJBODKFE<BIEIIMCKPHN> PODKNGHCBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public KKGGGAABFLL LLBABNEJEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public List<DJNGLNAIHJJ> KBMAOABNPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public NEEICKGOONJ MDLABOGEJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public LCBLFMOAPAK JHPOJFDKCHD;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DMMECELPFMA
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private const float MHCNGPKFOFI = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Vector3 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Quaternion OOBEGCNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public float HDLKNIPAJGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 IDOMDEBINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF3C0", Offset = "0x7BDE3C0", VA = "0x187BDF3C0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS DKNGFCPGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF380", Offset = "0x7BDE380", VA = "0x187BDF380")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x13758A0", Offset = "0x13748A0", VA = "0x1813758A0")]
	public DMMECELPFMA(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float HDLKNIPAJGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF980", Offset = "0x7BDE980", VA = "0x187BDF980")]
	public DMMECELPFMA(UniformTRS BENKMGIEGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF670", Offset = "0x7BDE670", VA = "0x187BDF670")]
	public static DMMECELPFMA PPKKEIHODGJ(DMMECELPFMA JHDAOHEONAC, DMMECELPFMA GIHNPBBCGFE)
	{
		return default(DMMECELPFMA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF4D0", Offset = "0x7BDE4D0", VA = "0x187BDF4D0")]
	public static DMMECELPFMA OIFHDJNIHDL((Vector3, Quaternion, float) APDBNIMCPID)
	{
		return default(DMMECELPFMA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF4F0", Offset = "0x7BDE4F0", VA = "0x187BDF4F0")]
	public static DMMECELPFMA OIFHDJNIHDL(Matrix4x4 BCGGFLJIKFP)
	{
		return default(DMMECELPFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF8F0", Offset = "0x7BDE8F0", VA = "0x187BDF8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF2A0", Offset = "0x7BDE2A0", VA = "0x187BDF2A0")]
	public DMMECELPFMA JCIPHLOBJJE(Matrix4x4 KOOMPFGMBLG)
	{
		return default(DMMECELPFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF230", Offset = "0x7BDE230", VA = "0x187BDF230")]
	public static DMMECELPFMA GNIHJAOJPHB(Vector3 EPCLGOKLIPO)
	{
		return default(DMMECELPFMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF1A0", Offset = "0x7BDE1A0", VA = "0x187BDF1A0")]
	public readonly FGKPLMFNBOC GGKHCFLGEDG()
	{
		return default(FGKPLMFNBOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum EMNDPFDAKHI
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct MKPPMLCEJMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly HKAHGMIMBPB EJPNNEGOIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HIKDGBNCNDJ CFBICBAFLCG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x162A720", Offset = "0x1629720", VA = "0x18162A720")]
	private MKPPMLCEJMD(HKAHGMIMBPB KOJNMKELJGK, HIKDGBNCNDJ PJMGFCBKPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7FD0", Offset = "0x7BE6FD0", VA = "0x187BE7FD0")]
	public IADJFILHMLF CBFDANNKJHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7E60", Offset = "0x7BE6E60", VA = "0x187BE7E60")]
	public static HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD> ACADPGMDEBE(KHNHKAGGAAA<BONGKMFJEJA> PJMGFCBKPAH)
	{
		return default(HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7DB0", Offset = "0x7BE6DB0", VA = "0x187BE7DB0")]
	public static HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD> ACADPGMDEBE(IADJFILHMLF PJMGFCBKPAH)
	{
		return default(HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7F10", Offset = "0x7BE6F10", VA = "0x187BE7F10")]
	public static HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD> ACADPGMDEBE(string AOIFFMFICOD)
	{
		return default(HHHCCNLMPJL<MJCIGHECEBG, MKPPMLCEJMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum HKAHGMIMBPB
{
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GBIHHNMBOFJ : IDisposable, BGHHFILJFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private NativeList<KIKMAHKACEI> PENPBHIEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private float FOPKMCPIOCE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CMOLENMEPKL DDPGFAHMEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(CMOLENMEPKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LBBBPBOCHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B17A00", Offset = "0x6B16A00", VA = "0x186B17A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BKJCLJPPAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B17A10", Offset = "0x6B16A10", VA = "0x186B17A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<KNDCDMJKHOJ> JOCCGEFBCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HAJCLPENCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1520", Offset = "0x7BE0520", VA = "0x187BE1520", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float AEFFLELHGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1560", Offset = "0x7BE0560", VA = "0x187BE1560")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3350", Offset = "0x7BE2350", VA = "0x187BE3350")]
	public GBIHHNMBOFJ(CMOLENMEPKL EIBMLBPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1270", Offset = "0x7BE0270", VA = "0x187BE1270", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1FE0", Offset = "0x7BE0FE0", VA = "0x187BE1FE0")]
	public Vector3 MJINHKCHCED(int JDCGPDDDLBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1140", Offset = "0x7BE0140", VA = "0x187BE1140", Slot = "6")]
	public Quaternion DPKEIPKDLIL(int JDCGPDDDLBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE24B0", Offset = "0x7BE14B0", VA = "0x187BE24B0", Slot = "5")]
	public Vector3 MPIPJGDBDKB(int JDCGPDDDLBB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1770", Offset = "0x7BE0770", VA = "0x187BE1770", Slot = "7")]
	public float KCIEHOPPJPF(int JDCGPDDDLBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2890", Offset = "0x7BE1890", VA = "0x187BE2890")]
	public void OGKMLKGNMCN(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN, bool IKGHJOIMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BE26D0", Offset = "0x7BE16D0", VA = "0x187BE26D0")]
	private bool NMPFFJJFBFL(int MBJEBOIGEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2550", Offset = "0x7BE1550", VA = "0x187BE2550")]
	public void NINMPEBBHKB(Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BE12D0", Offset = "0x7BE02D0", VA = "0x187BE12D0")]
	public void EFDCGGOAAPK(int MBJEBOIGEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1360", Offset = "0x7BE0360", VA = "0x187BE1360")]
	public void GKAJKCFJOFA(int MBJEBOIGEBA, Vector3 EPCLGOKLIPO, Quaternion OOBEGCNALKF, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BE31A0", Offset = "0x7BE21A0", VA = "0x187BE31A0")]
	public void PDJHDIOGKGN(int MBJEBOIGEBA, float3 EPCLGOKLIPO, quaternion OOBEGCNALKF, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0FF0", Offset = "0x7BDFFF0", VA = "0x187BE0FF0")]
	public void CNHGDKAFNMA(int MBJEBOIGEBA, Vector3 EPCLGOKLIPO, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2730", Offset = "0x7BE1730", VA = "0x187BE2730")]
	public void ODKHGMMCFMC(int MBJEBOIGEBA, Vector3 HPAMHMBDLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BE17D0", Offset = "0x7BE07D0", VA = "0x187BE17D0")]
	public static Quaternion LHLEIFAFNAF(Quaternion BNLJKPCLJFI, int MBJEBOIGEBA, float MBAFNDBDDPG, BGHHFILJFDL PAMLFPGMJBA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0B50", Offset = "0x7BDFB50", VA = "0x187BE0B50")]
	public Bounds AIMJMDAMMIA(Transform KOOMPFGMBLG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE14B0", Offset = "0x7BE04B0", VA = "0x187BE14B0", Slot = "10")]
	public virtual void GNFJDLNJOKJ(bool MFHMFLLNAKN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE16A0", Offset = "0x7BE06A0", VA = "0x187BE16A0")]
	public NativeList<KIKMAHKACEI> KCFEHEHCBOE(float DHBMNFOEAIK = 1f)
	{
		return default(NativeList<KIKMAHKACEI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KNDCDMJKHOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public float3 MJJFMHOFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public float KFCBCCPHPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public quaternion GBKGDKAGMBA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7B70", Offset = "0x7BE6B70", VA = "0x187BE7B70")]
	public KNDCDMJKHOJ(Vector3 HNHGJPFCFDL, Quaternion BNLJKPCLJFI, float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7AB0", Offset = "0x7BE6AB0", VA = "0x187BE7AB0")]
	public Quaternion JEGADKNNKFO(Vector3 IGEMMIGMOOK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7620", Offset = "0x7BE6620", VA = "0x187BE7620")]
	public KNDCDMJKHOJ CNPDCJHMKCN(Vector3 IJBDKJIONCH, Vector3 PDPNINDCDKE, Vector3 IFNAGCEBEBM)
	{
		return default(KNDCDMJKHOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7910", Offset = "0x7BE6910", VA = "0x187BE7910")]
	public GJGCFPNBBDH HCFCBMPBBFA(Vector3 IGEMMIGMOOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class FBBGOOJMAKF : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0220", Offset = "0x7BDF220", VA = "0x187BE0220", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0520", Offset = "0x7BDF520", VA = "0x187BE0520")]
	private void PJMIBEJOFNC(Dictionary<Guid, Guid> HAOCCBOHLJM, IKCOMEOGCIM JNOLAADGBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0AF0", Offset = "0x7BDFAF0", VA = "0x187BE0AF0")]
	private void PJMIBEJOFNC(Dictionary<Guid, Guid> HAOCCBOHLJM, PIIOMGAIIPG NLKCEDNEMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BE02A0", Offset = "0x7BDF2A0", VA = "0x187BE02A0")]
	private void PJMIBEJOFNC(Dictionary<Guid, Guid> HAOCCBOHLJM, GDOMMPFIOLD HHDFMOPIDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FBBGOOJMAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PPIIJGPENFA : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9810", Offset = "0x7BE8810", VA = "0x187BE9810", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPIIJGPENFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class EGKCMBGKHBB : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFBB0", Offset = "0x7BDEBB0", VA = "0x187BDFBB0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EGKCMBGKHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class EDBILHHBKBH : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFA50", Offset = "0x7BDEA50", VA = "0x187BDFA50", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public EDBILHHBKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GMFCDMGOIBH : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE36A0", Offset = "0x7BE26A0", VA = "0x187BE36A0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GMFCDMGOIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MNEHMFJIMPM : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE83F0", Offset = "0x7BE73F0", VA = "0x187BE83F0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MNEHMFJIMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BLEKJDJJJBE : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDBB0", Offset = "0x7BDCBB0", VA = "0x187BDDBB0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public BLEKJDJJJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PPDNJDICAGP : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9720", Offset = "0x7BE8720", VA = "0x187BE9720", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PPDNJDICAGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MGANPMNKAFF : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7BF0", Offset = "0x7BE6BF0", VA = "0x187BE7BF0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MGANPMNKAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GDIGJMEGNKL : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BE33E0", Offset = "0x7BE23E0", VA = "0x187BE33E0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GDIGJMEGNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GEALLLECFEH : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BE35A0", Offset = "0x7BE25A0", VA = "0x187BE35A0", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GEALLLECFEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DDFHPCAMDGJ : OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public static readonly HCHGBNBPKHG IBIALEMMIDH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF070", Offset = "0x7BDE070", VA = "0x187BDF070", Slot = "4")]
	public void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DDFHPCAMDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EPFNGLONGKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public APPGMHGFBGI DJNGLBELENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public JLPHBPPDHAI EOPDLHGAHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public Dictionary<int, int> MCNDMOJMJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public Dictionary<Guid, Guid> GAOLMHIICLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public LCBLFMOAPAK JHPOJFDKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public bool ABCLNEAOIBC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OKBBGAGAKCH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIFNLANNFAK(HGENHGFPLKD OIOOHJPACBF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CBNKCFGDDNG
{
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private static readonly OKBBGAGAKCH[] GHIKGCHNAHD;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE1C0", Offset = "0x7BDD1C0", VA = "0x187BDE1C0")]
	public static void HJINKAFINJM(DJNGLNAIHJJ APDBNIMCPID, MJCIGHECEBG OPFDBDCKOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDF30", Offset = "0x7BDCF30", VA = "0x187BDDF30")]
	public static void BOGPEGPLLNO(DJNGLNAIHJJ? APDBNIMCPID, MJCIGHECEBG LGILLACKCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE810", Offset = "0x7BDD810", VA = "0x187BDE810")]
	public static void MKDNEGHIFCD(DJNGLNAIHJJ? APDBNIMCPID, MJCIGHECEBG CCLPDFENGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE440", Offset = "0x7BDD440", VA = "0x187BDE440")]
	public static void HMDHMDNIAHN(HGENHGFPLKD OIOOHJPACBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HGENHGFPLKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public APPGMHGFBGI NGAHGPBBOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public DJNGLNAIHJJ BJPIFCHFNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Dictionary<int, int> MCNDMOJMJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Dictionary<Guid, Guid> GAOLMHIICLC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BE38C0", Offset = "0x7BE28C0", VA = "0x187BE38C0")]
	public Guid MGDPJAKEGLJ(Guid DGNNPFFMIEE)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LCBLFMOAPAK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EBNHDKCINFK, [Out] Guid OEKGDELEHFH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class IKNHBNNCJJD
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private static readonly ProfilerMarker EKFJHKBPKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<string> BAOIAHDLBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly Dictionary<long, int> JMIEPEMKCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> JGAKKANANEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> BBAMDEDEGNN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> NHLOMDEHAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> GCHOGJDJOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> MPFOJEFIJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4430", Offset = "0x7BE3430", VA = "0x187BE4430")]
	public static void DFOCCKOPHOM(DIFMPACHIKE KPNCOLBEHBC, EKPOAKLBMCN KMCADENIJBF, MJCIGHECEBG IEJPNHBBCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5FA0", Offset = "0x7BE4FA0", VA = "0x187BE5FA0")]
	public static IKNHBNNCJJD JBPCGOJKFKE(BPLHNECCAPN MKIDPONBDDE, [Optional] EKPOAKLBMCN? KMCADENIJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4D90", Offset = "0x7BE3D90", VA = "0x187BE4D90")]
	public static IKNHBNNCJJD HBCFIPKGEKA(DIFMPACHIKE LPMBCJIIDDD, [Optional] EKPOAKLBMCN? KMCADENIJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5DA0", Offset = "0x7BE4DA0", VA = "0x187BE5DA0")]
	public static IKNHBNNCJJD IDLIEAKAEPC(IEnumerable<string> BAOIAHDLBFK, IDictionary<long, int> FGOIBKOAJPM, IReadOnlyCollection<Guid> BBAMDEDEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE69F0", Offset = "0x7BE59F0", VA = "0x187BE69F0")]
	private IKNHBNNCJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6820", Offset = "0x7BE5820", VA = "0x187BE6820")]
	private IKNHBNNCJJD(IEnumerable<string> BAOIAHDLBFK, IDictionary<long, int> FGOIBKOAJPM, IReadOnlyCollection<Guid> BBAMDEDEGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5610", Offset = "0x7BE4610", VA = "0x187BE5610")]
	private void ICJBPDAMNKO(BPLHNECCAPN MKIDPONBDDE, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE53F0", Offset = "0x7BE43F0", VA = "0x187BE53F0")]
	private void ICJBPDAMNKO(DIFMPACHIKE LPMBCJIIDDD, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE61A0", Offset = "0x7BE51A0", VA = "0x187BE61A0")]
	private void JKKOHADPINO(ByteString? CDBBEPNLPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5830", Offset = "0x7BE4830", VA = "0x187BE5830")]
	private void ICJBPDAMNKO(NDHLGJGDGLN? KNNDNAPJIDP, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3E30", Offset = "0x7BE2E30", VA = "0x187BE3E30")]
	private static void DFOCCKOPHOM(NDHLGJGDGLN? KNNDNAPJIDP, EKPOAKLBMCN KMCADENIJBF, MJCIGHECEBG IEJPNHBBCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE41C0", Offset = "0x7BE31C0", VA = "0x187BE41C0")]
	private static void DFOCCKOPHOM(PMLOKGMHNIB? GOJJJBGJPAM, EKPOAKLBMCN KMCADENIJBF, MJCIGHECEBG IEJPNHBBCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5B90", Offset = "0x7BE4B90", VA = "0x187BE5B90")]
	private void ICJBPDAMNKO(PMLOKGMHNIB? GOJJJBGJPAM, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4E10", Offset = "0x7BE3E10", VA = "0x187BE4E10")]
	private void HMNEKDMALPM(Guid? DGNNPFFMIEE, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4FF0", Offset = "0x7BE3FF0", VA = "0x187BE4FF0")]
	private void ICJBPDAMNKO(DJNGLNAIHJJ? BJPIFCHFNAA, EKPOAKLBMCN? KMCADENIJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE39E0", Offset = "0x7BE29E0", VA = "0x187BE39E0")]
	private static void DFOCCKOPHOM(DJNGLNAIHJJ? BJPIFCHFNAA, EKPOAKLBMCN KMCADENIJBF, MJCIGHECEBG IEJPNHBBCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3970", Offset = "0x7BE2970", VA = "0x187BE3970")]
	private void CJFFDNHGPJM(string? BHDJAEGILOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BE60D0", Offset = "0x7BE50D0", VA = "0x187BE60D0")]
	private void JJPGJCNOFOE(long OEOACNOOFPP, Guid PKDLBFIDCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6080", Offset = "0x7BE5080", VA = "0x187BE6080")]
	private void JJPGJCNOFOE(PHDPHMEKFEG? HDLNOLCMMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6020", Offset = "0x7BE5020", VA = "0x187BE6020")]
	private void JJPGJCNOFOE(MOIHIJBJAEA? HDLNOLCMMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NOJIPKODNOL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class MLDHBJMPONI : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private readonly IEnumerator<DictionaryEntry> FMKNFJBKBAJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry EENPIHKDHGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BE81C0", Offset = "0x7BE71C0", VA = "0x187BE81C0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8290", Offset = "0x7BE7290", VA = "0x187BE8290", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8340", Offset = "0x7BE7340", VA = "0x187BE8340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BE80E0", Offset = "0x7BE70E0", VA = "0x187BE80E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
		public MLDHBJMPONI(IEnumerator<DictionaryEntry> FMKNFJBKBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8040", Offset = "0x7BE7040", VA = "0x187BE8040", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8090", Offset = "0x7BE7090", VA = "0x187BE8090", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class IMPJNLDJALH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x7BE6CA0", Offset = "0x7BE5CA0", VA = "0x187BE6CA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public IMPJNLDJALH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6B50", Offset = "0x7BE5B50", VA = "0x187BE6B50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6C50", Offset = "0x7BE5C50", VA = "0x187BE6C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9E90", Offset = "0x7BE8E90", VA = "0x187BE9E90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object OEHHKNIGGMI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9DA0", Offset = "0x7BE8DA0", VA = "0x187BE9DA0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9F80", Offset = "0x7BE8F80", VA = "0x187BE9F80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9CE0", Offset = "0x7BE8CE0", VA = "0x187BE9CE0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9D40", Offset = "0x7BE8D40", VA = "0x187BE9D40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9F20", Offset = "0x7BE8F20", VA = "0x187BE9F20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7BE99A0", Offset = "0x7BE89A0", VA = "0x187BE99A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9A00", Offset = "0x7BE8A00", VA = "0x187BE9A00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9A60", Offset = "0x7BE8A60", VA = "0x187BE9A60", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
		public RoomObjectCounts(Dictionary<int, int> HLNIELOCCGD, [Optional] Dictionary<int, int> LJIDKIKDCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE98C0", Offset = "0x7BE88C0", VA = "0x187BE98C0")]
		[IteratorStateMachine(typeof(IMPJNLDJALH))]
		private IEnumerator<DictionaryEntry> JCMBLHHKIGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9FD0", Offset = "0x7BE8FD0", VA = "0x187BE9FD0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9BE0", Offset = "0x7BE8BE0", VA = "0x187BE9BE0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9AC0", Offset = "0x7BE8AC0", VA = "0x187BE9AC0", Slot = "9")]
		void IDictionary.Add(object OEHHKNIGGMI, object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9B20", Offset = "0x7BE8B20", VA = "0x187BE9B20", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9B80", Offset = "0x7BE8B80", VA = "0x187BE9B80", Slot = "8")]
		bool IDictionary.Contains(object OEHHKNIGGMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9C80", Offset = "0x7BE8C80", VA = "0x187BE9C80", Slot = "14")]
		void IDictionary.Remove(object OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9940", Offset = "0x7BE8940", VA = "0x187BE9940", Slot = "15")]
		void ICollection.CopyTo(Array NBBLCIBNPBK, int OHHMJGCBCKD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class BPNEOPHHDNF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x7BDDEE0", Offset = "0x7BDCEE0", VA = "0x187BDDEE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
			[DebuggerHidden]
			public BPNEOPHHDNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDD50", Offset = "0x7BDCD50", VA = "0x187BDDD50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7BDDE90", Offset = "0x7BDCE90", VA = "0x187BDDE90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7330", Offset = "0x7BE6330", VA = "0x187BE7330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object OEHHKNIGGMI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7200", Offset = "0x7BE6200", VA = "0x187BE7200", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7BE73E0", Offset = "0x7BE63E0", VA = "0x187BE73E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7140", Offset = "0x7BE6140", VA = "0x187BE7140", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7BE71A0", Offset = "0x7BE61A0", VA = "0x187BE71A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7380", Offset = "0x7BE6380", VA = "0x187BE7380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6DC0", Offset = "0x7BE5DC0", VA = "0x187BE6DC0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6E20", Offset = "0x7BE5E20", VA = "0x187BE6E20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6E80", Offset = "0x7BE5E80", VA = "0x187BE6E80", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x277DE00", Offset = "0x277CE00", VA = "0x18277DE00")]
		public Invention(long HJPLNJNIFLL, int JAALIADHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6CF0", Offset = "0x7BE5CF0", VA = "0x187BE6CF0")]
		[IteratorStateMachine(typeof(BPNEOPHHDNF))]
		private IEnumerator<DictionaryEntry> JCMBLHHKIGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7430", Offset = "0x7BE6430", VA = "0x187BE7430", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7000", Offset = "0x7BE6000", VA = "0x187BE7000", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6EE0", Offset = "0x7BE5EE0", VA = "0x187BE6EE0", Slot = "9")]
		void IDictionary.Add(object OEHHKNIGGMI, object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6F40", Offset = "0x7BE5F40", VA = "0x187BE6F40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6FA0", Offset = "0x7BE5FA0", VA = "0x187BE6FA0", Slot = "8")]
		bool IDictionary.Contains(object OEHHKNIGGMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BE70E0", Offset = "0x7BE60E0", VA = "0x187BE70E0", Slot = "14")]
		void IDictionary.Remove(object OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6D60", Offset = "0x7BE5D60", VA = "0x187BE6D60", Slot = "15")]
		void ICollection.CopyTo(Array NBBLCIBNPBK, int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> FFFGNOPMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyList<Invention> IIKADKIGCFI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	public NOJIPKODNOL(IReadOnlyDictionary<Guid, RoomObjectCounts> FGOPAMLJILF, IReadOnlyList<Invention> NCPGPOHEAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8D10", Offset = "0x7BE7D10", VA = "0x187BE8D10")]
	public static NOJIPKODNOL JBPCGOJKFKE(BPLHNECCAPN MKIDPONBDDE)
	{
		return default(NOJIPKODNOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8530", Offset = "0x7BE7530", VA = "0x187BE8530")]
	[CompilerGenerated]
	internal static int BEAGANLDENC([In] IReadOnlyDictionary<long, int> HPPBCJCOEBF, long? OEOACNOOFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8650", Offset = "0x7BE7650", VA = "0x187BE8650")]
	[CompilerGenerated]
	internal static void DFIDBLDJAGL(int NILMMOJNHBB, [In] NDHLGJGDGLN AJBLPHIOOHK, [In] Dictionary<long, int> HPPBCJCOEBF, [In] Dictionary<Guid, RoomObjectCounts> FGOPAMLJILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class EKPOAKLBMCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly MJCIGHECEBG ELMONFKMMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> NAGONOJAHFJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MJCIGHECEBG AOMPMGIDFGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE00D0", Offset = "0x7BDF0D0", VA = "0x187BE00D0")]
	public void IIGLPCDPOEE(Guid GKMMILGIBHH, Guid NFAOJGJACFN, IReadOnlyList<Guid> OJBHNBMKPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFFE0", Offset = "0x7BDEFE0", VA = "0x187BDFFE0")]
	public bool CBDDPOJFONC(Guid GFFBMHPJFDP, [Out] IReadOnlyList<Guid> BBAMDEDEGNN, [Out] bool DGBMEHOIJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0180", Offset = "0x7BDF180", VA = "0x187BE0180")]
	public EKPOAKLBMCN()
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
