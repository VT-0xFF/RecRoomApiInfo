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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CF00", Offset = "0x7F0B700", VA = "0x187F0CF00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ANCHEKHKCFA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> BPCAHHLAINM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> ELJAKCJKHHB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GBBCKLEHODL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> ICFIMOGDHMD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string FPGFFMDJCCG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string ACMHHPEOMPD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string LGIDJENLGAA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F05550", Offset = "0x7F03D50", VA = "0x187F05550")]
	public static bool HBHAECIHKIG(Guid NLDAIKFJALP, int HDOAOLFLGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F05650", Offset = "0x7F03E50", VA = "0x187F05650")]
	public static bool MMBHNOFJJFF(Guid NLDAIKFJALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F04ED0", Offset = "0x7F036D0", VA = "0x187F04ED0")]
	public static string BMDIPKHLGEK(Guid JMHOEKKPCPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CFGGLIFLDBH]
public enum AMIMCBGKLID
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
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C3E0", Offset = "0x7F0ABE0", VA = "0x187F0C3E0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PANPOJAFDBO
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid ADACJKGJOCE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid AHOLOFBHKFC;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NGGKKFELJPO;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid HAGFFPKMEBE;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid GMNMDBBDLHA;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BHGGCIOBAOM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid CPMHGOPIGLB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KCBPMMOIJIE;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JMGKCNGDFMK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid JCEIKPLHJPB;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid KLICCDHEPHC;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid GGNJIGDPJDL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid KMBFFGDKIAF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid PJOALBPDMMF;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid EPBOEBDHGJO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OMBEGLMKOAJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DKKOHBNIBJK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid CBGJGKGCGDH;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MANBNHAEMMN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid JOANPEEEIGN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid NCEFNHJIMDL;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid OAKIKIMAPLE;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JNJODIAMIBH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JCNKFPPFGCG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid FCBMFONIKNN;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid OPIGLAOKPCE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BDKNNNMAAHK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid NLKNFNDFAIN;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid OGIFEDJBEKF;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HJCLGMLONIJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid BPBKAPJNOIO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid ICIJOMHHCBE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid FADCHDBKICI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid JEPPMLENOGP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid HAPBDCIDLHM;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid APDHJEPHEKN;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MPFLGNKACBN;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid CGOAJMECAPN;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid PHLLIJCFMDE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid GKLJIAKHEBO;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JGCGFFOOLAB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid PEIBAPEKEGH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid CGEDPJDLJCD;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JIPHIMFLFMB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JJAHPJLNGCG;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KJIHJNELGHD;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EHPMBMFEPMA;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BCENIICPAMM;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid EJIMCGIIMPJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid ADIGAENDIFP;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid KDFLPGKFDNP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid AMDLNAJLHGA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid HLKOJIMGDHP;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid GKINDMICPGN;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid IMHDIJAKOCB;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid NGFGKDBHJMB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid GDMEBKBEKCF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid MIELNBHLAKA;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CJCNIOCOANO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid BNODHPIHPPB;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BMJLLCKDAJB;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HIMEIBPJAGF;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid IEKHIFIDHJL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid GPLHKOJFHIH;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid AAMFFHFMEKI;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid FEKFKOCJHAF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DFJOPOJMGAN;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LICCOKDLDGJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid AANJNFKHAMJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid NKHBEKIONCI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BGKPHLCLGPP;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid CIJLPMBIFMK;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid OBIAILDPMML;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KDDDEAHDNJJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid ENADLIPJAKN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid JACPBCLLGPO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HMKHGABGFPA;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid PABNBGLJACO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CKLKBDENLLK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid NOCCPAAHPIB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid ELKBNGGCKGK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JHDNNOHEFNA;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid OBHBKPEMDJL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid GFGHAJCJIGI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid IEFJIMFDKDM;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid EHEDIAMPJPF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid KLLOPGDNKAB;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid GDPJEBLBIEB;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid DODFENOJGBG;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GIHHPLILCBE;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LLBNCFPMGMB;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid AIGHAOPCEIO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid HFJLCHAEHEE;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GFAIJFBHFCA;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid IMDLDFLNAMF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid PFGLPAHNEML;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ANCPFLOJEEO;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KHDIANADDAL;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid BINGNBPACKH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid NNDGMDDECNN;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid DMJBBBMCPBN;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid IAPHKOJIDNN;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GPDKIGBFICB;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NHEIKMCCKNI;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid HGDLGAPMGGM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OBNDDGCPJHG;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PADOKFPHBIA;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GGAFAGLFEIB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LLKELIMMJHC;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BNHBKNCFMBN;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid CNOGGLFDHBP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid LLHOMBDAMGA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid ILJIPIJCBGM;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FFMLLFHDBDE;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DFJFAIBLKGL;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BAKDCAABHEF;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid IIPCDLPBHEK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MCPNFGGDAPH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid OAEFEAHHIMC;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EJMDAMBLOFD;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DEODDLONEDN;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid KNLCFBFKLOD;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid JCOMIGGHOJE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IEGIMOBAFHD;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid NLPGKIGEDOA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid PKEBBBFEOJB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid FMIKFHLMAGL;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid BICPNFAGAMK;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid PFNGBDENEBM;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid LNHBAHBLDHL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BDFDPDFHLKB;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ADAFNLKGGIM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BCENMHFCHFI;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid APEDJIPDBIJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BKKFIABMFHC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid FHJFKJNINPL;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid BMEGMNIMPCI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid GAJDABFPCCC;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HHNIOJFBLCC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid OFGHGKLDKNC;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid CBIINHOCBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid AOLHDCDNLJE;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid MIAHKEEEPDB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid DLLBBEHLDMG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid PFODNMLIALA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid EKOEOGHPLKD;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid CPFMONHAOON;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MKLHADFPPFC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AHGFJIIFCKO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OKOLOLEJJHP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid GJNMIBGMPML;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid AEBLBDKHEJG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid JOEMHBOMAAM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid LEEDLPHGELK;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid FDDOJPGGODL;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid EIDOEMCELLI;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid NJLJNJIFBHP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NGNCBGAMBDK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LFCPNIIDINI;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid EAMCBPAJMNF;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid BKDIGJFGHLP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HHHEMPJJCEK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid FIFBJFEOOMH;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid FANGDCMKCCO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GKAIFMLLGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid LGFDFCCOLGP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid OOLEPOKHENI;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JFIGKJEJLMG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid EEGBMDJKCCC;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AOMMMJGPMGP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FKAAEGFOMKK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid JNBIDADBGBC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid JENPHHJDLKK;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BJILNDOPCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid CGKHKNBJIAB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GDDFEBEHOIL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid CKFEFGFEHLP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid APJAFAOKNFD;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid FCKJGBIHIEG;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid DCOHDALEEOK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GEFMAIMHIBA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid ABEJOJHEOEJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MIIALHIMKKP;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DGFFGICIOKA;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid AJJEALGGCON;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid HMCMFLGAHMB;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid FHIBEFFKNOL;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IIBHIJKEPBE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid KANFBEGFALL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid JGLHDCHFCJF;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid PBOGPLCEACO;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid PIPMFIBCAIH;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid DCIDBLPELFE;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DINOBIFDBJI;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid JEKMINCEDFB;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid IHDAKPGIACL;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PGJFAJAOMBM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid BLIGMEJAJIE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PACHBAHAOBL;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CLHDLKINPKL;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JMMIAONCHAO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MFEGDBNDLKN;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid NCEJJCFAFMG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HDOAGPPFKNI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LJEFEEGOMLH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PDJHMDJHIND;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IFJDCIKOAMD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MGENOLLDHFC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid OBBLOPGOOOB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid MJGELHMACLM;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OBHCOPBPFEC;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GBHKCILLLBC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid COJKAHGIIKP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KBMGHPBEADO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LLICJDCGDLM;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid IJCDLMCJELC;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid NJAJHNGLKCK;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DFLLCEOODNG;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid HLNPIJPDJGK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid FPJDCFBJBKC;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DBPNGHDNALB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MPGLKEOKFMO;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DJCAHFCOHLB;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid NGLEFNJPBCF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DHGFKOJHLEH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid PLMINMGCGHH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid OKDGHHHDNBK;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid JBALFLFGAFK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid EJCCEINDKBF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DPIHANBHEMM;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid LBJMLKALNFN;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid CIDLEOLJCEI;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid CDBIMFOLOCM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid HABIDONIHKB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid IFLNDFAGJHP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KOIIAIFFLAO;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid MCPMMCCAFMB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid FBGNLLBBGME;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid DMACIJMDDBC;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BKKFBDEJMNC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid JMNHENMLLLH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KNPAKHAECPH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JOMGIBCAKIF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid POBLMKCIABL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NADOBJHMFCE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid INOBOEBKEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid KNEKAODLKOB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PHEGBKCAHJE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid CCGIDGILCDA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GDJCHDKAJOD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GGFKHPBMOOH;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LJJBOPPOAFM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CGKNLNCLBCG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid HJPKDHMFOCB;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NNBDNLNKOMH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FJHBCBJGLCA;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid OAJHAFIFGBD;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid INIPDIMNEJD;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid PPFDLODOCCI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid LLHBOEGAIDB;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid CHGNJCGNJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KOOEIOCDHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid JOKFAPGJOEK;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KNICNNNEPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid INMMNMOBHCB;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid CGDCJABLILP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NACPIPKLFLG;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid ENGOOJFPMND;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OJJFNEJLJBP;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GFJLGCPEFLF;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid KIAKNOFCBFP;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GAGDBAFKHLP;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CFCBMIDLDCM;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MHHODINGCHM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NAHKNFLPGIF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid IDHPDNOEMNK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid KELLPEHEFPP;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CKAMEFOHHHG;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid OHHGPGAGILA;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid DIKCHDDIBGN;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LKEGMKICDLE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid PLAGHICFDNJ;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid HPIHECMFKBL;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EOEKDJKEJOE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid LDLNPGFIHFH;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MFKMKLFHDEN;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid GIHBFPJMBKP;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EFCCKJHNAKP;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid BKPODNKLGGK;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid HKALALLKPBC;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NACAEBIKAGC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LAILFBOMINN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid LBANCJPMGHM;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid GNGGGBFFEJN;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid LGGFNGCGMEB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid DBBOAIILMHP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid MILLNBHBBEN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EJAHOLPBDEF;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LBCCAAIPLHE;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid GEKOPJBKINK;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid FHDDLNEFDAA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid CMCOJCEKOMM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid ELHGFPPEDMD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JBHLPDIGOMC;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid LDLCFGPJABN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid IAKMKBCDBBC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid NCGJEKPDDAE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid JLJNFIEPBFF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid NKFFNIJMMGF;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid ODLFAELOLJD;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NMLFHPKABOH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid NMMAAMBIBJD;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid IDJJJALAAKD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid DJEKMKBAGPK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KBDIBEAMCND;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid PBCKOOKCICC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid ILCEJHLBIHG;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid MCPKJPHIBLO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid HPEACDBJFDL;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HILDCOIGDGF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NPDPIHAHHAD;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid BKPCBGJBECH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid IAPLDBHENGM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KPLEGNDPADJ;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid GJPPCLLKCDC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid DNGLLDFIALO;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid MCJGJPNLJEM;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid KIGHCBKBDEF;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid FAGBDCELKHB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ECAIEGAKJGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid NHDOIMJMMGL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FMBJIIMGCEM;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OBAHGDGOHHN;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid DBIBPLLHFAA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid NHNGBONHNAA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid LKPPOHADKGD;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BJFEHEHCNDM;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FPDGCCADBMI;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid CDOFGLIPOPA;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NIOHJJMMMAB;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid ILJBOJJEJGO;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid BHANNHKGKPA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DHIDFBDMCPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OLJCECLKMPD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IKAICNMELMP;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid IEENIPAHJPN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MBKPDIJNIDD;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JLEIGGMAJBE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FICMCJDJNDC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ALMCEIBEHEK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid HKEHFDJOLHN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NLFLOPCMPHJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid FGDBLPELHAK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IOBCLNGILKD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid OCOOPBHMAGI;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid OPHCOGJPAAN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid DOJPAMBCEGA;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ILFKGKFKHMO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NHOJBEONPPD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid EDDLFOJJHGE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid PIEHEJNANEM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid GOCPAEOCKGF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid KJEPLGIIFHD;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid ALHCGDMKBHN;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid GELBDGGAOCA;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KKMBFOIINKG;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid NIKDJFHPDNN;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid LHCDKGJCGHJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OCNIMIPIOCJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DIGIFPBENCG;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid KEFDGMFMFLA;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid ECOKGLGDCPH;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LHDLFCNEDOP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid NGJAIDCMFMI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ALHHIILPIGA;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BIHBCFOKOIC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid ABHKPBIKPLE;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid NKFDAGHJAIO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid BHLEALAGPDI;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid HHIELGJLOEM;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid FDDCFCCIHAO;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid POHHHBANFPA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PCJLJKEDCKE;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid LOHBHOLGACD;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid NBLIGONPMDD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CGHHLCLJFEJ;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid IPCILMMHHJM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ONBMKMDPFEF;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid PANCOMDOIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PIMLCOCALBL;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid IJNJLFJANNF;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid AFIBCJADDDL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid APCAIDIMPNN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid OFCIMBGBCML;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid AHJMJMBKHBL;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid FFFELALIOMI;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid LDKCEFHDHDD;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid ONFBDDCNPOO;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BEHCADCNOID;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KPKDMMHMMJO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid OJEFCJMPMCP;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid MGAAJLEDAOM;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid ONOHOLHLPIK;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IAGIPOIOFMP;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FABIIDPPCFJ;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BLPBNELDCGG;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PIKFDIEIAJF;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid GHDDDJNBAGK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid PLEGELNFDCE;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid GMFCMHNMCED;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FMKOOBGABMC;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NABLIGOCFFB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid EDEGNEKNIFF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid JAGAFAENMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BCAFKMGFBFA;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid LDKPGFCNPJH;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OIIOLFLBOEJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid KFLIFHKBEBL;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid EFDLLNAIFKM;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HJMFHOPBHFJ;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid GPGJDELIEGC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid OIPFAFJLHOB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GKFHKCAOCFL;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GCEJLCFAFJC;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid ANAPMHBDGOM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid FFLCGHIONLN;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid DFFLBNHNACB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FJDELOFAHJC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid GAFNMGLLLCL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NCFBDFFEFOP;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid DIIABDDNPHK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid PEBLELEAGLC;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DHAMGJFDHPG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JKAINOLAPLM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BPJBENHPNBL;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid FMDOFCBGMDM;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid JLHBAHFKCAI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid MKOCMGEBBDC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid AOGFMCBCAOC;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid EMCNDPBOBED;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid CENBPMPLCJA;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DFHDALMOKKI;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid PBNNKNFPGDK;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid PDAOFOGMELK;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JPAMJDGHNDL;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid NIHLDOIACMA;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GLKJCLOPNJI;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid BPKHFKMJMHM;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid GPKPFIJNMAC;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid BKAHFGGIBHJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CBFBHDJFJEI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PJBMJBAGHNN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid JBBEAKDNMBG;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PADKAELGPKA;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JLOJHPMOKDH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid PPPALNFBKHO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid BKIFGKJCNIB;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid HMAAPDFFPMP;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DFBNCGDBHOG;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid OEKFEIHKAKB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid GNCFLMBAPIM;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid KHDOCNKNMCK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid HCFBMDJKMMG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid NJNMKHKOIGG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GPDGDFBOPIN;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid ADGAFNFNADL;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid POBNHGFMFHD;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JAODBICHFMG;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid DOMECNHLDFN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid OLPIIOLFKKP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JCFDJCNBPFB;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NMIADFKDMAG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid PNEANHNHIKM;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid KDJFEKBBDHG;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid JHEGABJOFKB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid IBBKGLMJKPO;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid IGPGLIOEFHI;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid FBBLNNONDOA;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MDBGOFNHPKD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid GCPCCBCNDJB;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JPLMDMLGPGO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid IFIBHBNLNDI;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid EMJCCIPKKOD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid KLCOCOEMAAJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MHCALOHCKBF;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid CFLJIOONEBP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid INBNKAMIDBL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid CGGNKMHBEHO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid AMEOGGDIOFN;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid KLNOJKECKLE;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid FCHEMKHAIIA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid JGJOJOOGHCA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HHOMAOKEFMH;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JIAEDHGCGML;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FHNNIFLMBPH;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid COEFNPIDNBJ;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid GNLCHMGNAMC;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EENPGLNECJI;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid KEBLCOIEKKO;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid ENKLBDFEGFN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MJKBJHDEHCF;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OJFLJKLCDOD;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DLNNNHBKCKL;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MFOAIDGLFFE;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KHAGLFJGDGE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid AHINGNHFADP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid DMMLFHDCDGE;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid NFFIDCBOAIM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid FPHJGDCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CBFGILGANKL;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KGMCKGAODLH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid APIHIHHHNBF;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GGMLBONONGL;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid OBFABGEPFPI;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid FFLHOLJGENJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid BAGNDFICMIB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid LMHPODDJOHD;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KBHCEAIEGNI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid LHHLPEMFLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid AEEEDLKCBIE;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid DJIPIEOAAIB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IMENJEBBFBL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MAFHBLNOJMN;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid LLAIEKOGIJD;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DIEJALBKKGN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid GPPMABBDMLA;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid EBPFFGKIDKL;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid FMMCLIACNNO;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid KAAPHCCFPIB;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid JHJAIHIGKLJ;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid KPACCKCBNHA;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid CKBBOEEPLNA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid EJBLCAOAICG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid BIFHHFONMPM;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid AOEKALJMKBM;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid INOIGPMELOE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid BIKKOMMNCPG;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid AHDLKANHEJK;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid BIEEAEGJFPH;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid HHAKBAMIMIF;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid OMIKDHMJDIM;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid KAMIMGHPDIO;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid NLPEDENPPDN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IDKKAOOICDI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid FOMKGLMPEON;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DHANEBKKAON;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid IPAABLJCOJO;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GEEJKLANMFE;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DFOFCCJDFPA;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid OMKCHPEPIHO;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid HNHNDKBAKGH;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DKPFOIDHLJJ;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GGJONGCLBLA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid CPEOCEDOBOE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GAJLHNEBONM;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid NFGFEAPDNBF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid PDJNLNAKANB;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid NILDAMOHNKO;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid EFDDGPNDACM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid EPFDGMCJLNI;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid PCCGHDAHNMK;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid LFBIENLBOFN;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid HLLDLIBFOLJ;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid OLIAABBIDGI;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid CCKJEINDEPM;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IHJFOPJLMOI;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OALBOBFKNGD;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PLKEBBCJHMB;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid CALAJJCJKDJ;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid HKFFCGHAGCB;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid APNONJPMFGF;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid EHLEJCHGFEG;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JDHAOMCPOBP;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid BMKLEEAIICD;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid OHNMNPADPAD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid PHHILEOJNIO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid OBCLGLGDKFH;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid OMKHHDAJEKE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid LKPCJPDMGIE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid MIDCDBKMFKB;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid PKJDPEEJIAG;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IADAPLPJKDB;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid CCDCBOOHKLG;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid AKJIEOFJLOM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid CNMBFNPCHKM;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FFEJFMBEBLJ;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid FICNPAMHKKM;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid IOAJLPCINKJ;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid PLFNPNNBAIK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid JEKFBJGANBH;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CIKOHIOHGLI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid IBJADOOIGFL;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GGCFAJKEDKF;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DOJMIGNBOAC;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid IGKBKNBEFLL;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid GLNAEAIIJCL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid MDBOCNAFKEP;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DPEIHHFGKME;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid MDNGJPKLOLD;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid EPENNFLHNBL;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NPPOAMLLMDH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid BBFBOMEDMED;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid AGCKEEPCMGI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid HHAAJPMCEPI;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid NJCBGEOFFBJ;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid ABIKAHBLODA;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NAMNLBOMFCL;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid EFCLGPMBNMF;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid IHHBOLAHKMP;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid ANLFJCKIMDE;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid MCJGNKKGCJF;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid OEECJJJJFMJ;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid PLMFFJMGDNF;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid JEDBLPDAEBG;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid JCNJCOOEEJH;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid FNKGLHPIONL;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid CGIJBJNJPBB;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid OOOKGKAADCH;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid BKJLFHANMBN;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid CAFEFPEJJLL;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid LKHGBHDCPCO;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid NCDOJCJFKKJ;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid PHCFDHMCPBM;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid KODMEAGMJHN;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid EMGOGDJOOIJ;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid ONGLHPDMEII;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid OFDPHPNMHGD;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid KCJLHNAAHLN;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid ICGMKMKKPJD;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid NKHPNKNICGO;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid KEAMJCCFIKL;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid HDKKDGIMGID;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid FOJHFAOFNJG;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid NFAFEEIPNPC;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid EBCOIOFDDPI;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid DMCEOMNJOEK;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid EMLAFOKIPEL;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid IIIAHKPEAFH;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid NHPJFIMICAO;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid DDEHAKOMANA;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly Dictionary<Guid, AMIMCBGKLID> ABJKIHFBCLO;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly Dictionary<AMIMCBGKLID, Guid> ACKOOKLEFJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, AMIMCBGKLID> ICOFMOABKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A620", Offset = "0x7F18E20", VA = "0x187F1A620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<AMIMCBGKLID, Guid> INIJEEDDLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A670", Offset = "0x7F18E70", VA = "0x187F1A670")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EGOKJJPCFGK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BF20", Offset = "0x7F0A720", VA = "0x187F0BF20")]
	public static bool CACIAHDMLIH(GFCFJDPJGNH GFELFENEINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BF50", Offset = "0x7F0A750", VA = "0x187F0BF50")]
	private static bool CACIAHDMLIH(MINGNBNMEMF IJCALHAOPEH, GFCFJDPJGNH GFELFENEINL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDLAFOINLJI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(NLJALAIPNOA IMINNNCPCJF, [Out] Dictionary<int, int> IPMODNEGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(EIJMMJGEKKD OCMJFPPAPMF, GPKOCHLDLIB GIAAIENPCCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HAHLDCPBEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly GPHHIGAIGLA KKIIGDNEJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly IEnumerable<KCDFJLGNJKD> OGKKCEIECPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<KCDFJLGNJKD> CFEKEMGCEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly DPJIAIFILPM<NIMKICIFGFC> MNHLILDMHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<DJLGBBEFIHD<NCBBKKLBDCC>> LPIKNBOBHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly MIFPAMLFEIF HNMJENGAJCP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EMMKKFBDMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C370", Offset = "0x7F0AB70", VA = "0x187F0C370")]
	public HAHLDCPBEOE(GPHHIGAIGLA CAFGHLJIFEA, IEnumerable<KCDFJLGNJKD> PGLDAGHMLJJ, IReadOnlyList<KCDFJLGNJKD> KIGDLHLLAOB, DPJIAIFILPM<NIMKICIFGFC> HABFMOLCJFB, IReadOnlyList<DJLGBBEFIHD<NCBBKKLBDCC>> FCJLIMEKJMF, MIFPAMLFEIF DIBPPPCMKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GDJMNCDJOOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly GPHHIGAIGLA KKIIGDNEJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<KCDFJLGNJKD> EEDNIKGMFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly DPJIAIFILPM<NIMKICIFGFC> MNHLILDMHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<DJLGBBEFIHD<NCBBKKLBDCC>> LPIKNBOBHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly ByteString GKPODJBGDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly MIFPAMLFEIF HNMJENGAJCP;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C300", Offset = "0x7F0AB00", VA = "0x187F0C300")]
	public GDJMNCDJOOG(GPHHIGAIGLA CAFGHLJIFEA, DPJIAIFILPM<NIMKICIFGFC> HABFMOLCJFB, IReadOnlyList<DJLGBBEFIHD<NCBBKKLBDCC>> FCJLIMEKJMF, ByteString MABHFHOJMGF, IReadOnlyList<KCDFJLGNJKD> CGBNJCOJEBO, MIFPAMLFEIF DIBPPPCMKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MIDOJLJFPNH : ABJKGIEDKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly Guid EDPHMGMLLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly Dictionary<Guid, Guid> LILGCKMMEFL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BFDC30", Offset = "0x4BFC430", VA = "0x184BFDC30")]
	private MIDOJLJFPNH(Guid IGPCNCELCFO, Dictionary<Guid, Guid> LILGCKMMEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C4E0", Offset = "0x7F0ACE0", VA = "0x187F0C4E0")]
	public static MIDOJLJFPNH CCPKJDCALBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C600", Offset = "0x7F0AE00", VA = "0x187F0C600")]
	private static Dictionary<Guid, Guid> GLDGAIHJOOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C570", Offset = "0x7F0AD70", VA = "0x187F0C570")]
	public static MIDOJLJFPNH FNDMPLPFPLJ(IReadOnlyDictionary<Guid, Guid> GJKNNKIANJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C9D0", Offset = "0x7F0B1D0", VA = "0x187F0C9D0")]
	public static MIDOJLJFPNH MAJFIFJCGHF(IEnumerable<KeyValuePair<Guid, Guid>> GJKNNKIANJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CE10", Offset = "0x7F0B610", VA = "0x187F0CE10")]
	public Dictionary<Guid, Guid> OLCEFBIMJFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
	public Dictionary<Guid, Guid> JDPAIEGHEDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C580", Offset = "0x7F0AD80", VA = "0x187F0C580")]
	public void GGGBGBDKNKJ(Guid GJKNNKIANJJ, Guid NMNMOFPMJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C6B0", Offset = "0x7F0AEB0", VA = "0x187F0C6B0")]
	public void GNJOOMBHMNH(IReadOnlyDictionary<Guid, Guid> FKDNKIAHNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CCC0", Offset = "0x7F0B4C0", VA = "0x187F0CCC0")]
	public Guid OHGBGJPHNHF([In] Guid GJKNNKIANJJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C930", Offset = "0x7F0B130", VA = "0x187F0C930")]
	public Guid IEFPLCGPNPB([In] Guid GJKNNKIANJJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C470", Offset = "0x7F0AC70", VA = "0x187F0C470")]
	public bool OBGEGMIOPJH([In] Guid GJKNNKIANJJ, [Out] Guid NMNMOFPMJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C470", Offset = "0x7F0AC70", VA = "0x187F0C470", Slot = "4")]
	private bool AADNLBOKGMD([In] Guid GJKNNKIANJJ, [Out] Guid NMNMOFPMJKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FCCFMGMLIFP
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
public sealed class OLLLEFHIFOL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NDJNOMECDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public GPHHIGAIGLA staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NDJNOMECDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CE90", Offset = "0x7F0B690", VA = "0x187F0CE90")]
		internal DPJIAIFILPM<FLJIFEAIIIO> HJGBDAMBLDE((DPJIAIFILPM<NIMKICIFGFC> GraphId, DPJIAIFILPM<NCBBKKLBDCC> NodeId) i)
		{
			return default(DPJIAIFILPM<FLJIFEAIIIO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private static readonly EGJGIDLOLKO<FLJIFEAIIIO, int?> MMFKPMJGJPA;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly long EGPNLFGDBKD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F0CF80", Offset = "0x7F0B780", VA = "0x187F0CF80")]
	public static (long, long) FFMCPKKJHHD(GPHHIGAIGLA EMGIFAICNBL, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D4D0", Offset = "0x7F0BCD0", VA = "0x187F0D4D0")]
	public static long OLDMHCACDKK([In] ReadOnlySpan<DPJIAIFILPM<FLJIFEAIIIO>> DLDKICOJIGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F0D3B0", Offset = "0x7F0BBB0", VA = "0x187F0D3B0")]
	private static long IMEIICJFCCB()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CFHDEGJNGBD
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public static readonly HashSet<AMIMCBGKLID> IHEIBKEKOJO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DIJDPJCMOLB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CDFNPLEFGCN : IEnumerable<KCDFJLGNJKD>, IEnumerable, IEnumerator<KCDFJLGNJKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private KCDFJLGNJKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private EGOPMJOJPDK spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public EGOPMJOJPDK <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private KIHEJBBDOFI spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public KIHEJBBDOFI <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KCDFJLGNJKD System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xF10EA0", Offset = "0xF0F6A0", VA = "0x180F10EA0")]
		[DebuggerHidden]
		public CDFNPLEFGCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BB60", Offset = "0x7F1A360", VA = "0x187F1BB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BDE0", Offset = "0x7F1A5E0", VA = "0x187F1BDE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BC70", Offset = "0x7F1A470", VA = "0x187F1BC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KCDFJLGNJKD> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BC70", Offset = "0x7F1A470", VA = "0x187F1BC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B300", Offset = "0x7F09B00", VA = "0x187F0B300")]
	public static EGOPMJOJPDK IGKMOADGIIL([In] GDJMNCDJOOG LHEHCBLJNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B470", Offset = "0x7F09C70", VA = "0x187F0B470")]
	public static EGOPMJOJPDK IGKMOADGIIL([In] HAHLDCPBEOE LHEHCBLJNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0AF60", Offset = "0x7F09760", VA = "0x187F0AF60")]
	private static HashSet<DJLGBBEFIHD<NAHPMJADIDC>> HICIJOCAJBF(IReadOnlyList<KCDFJLGNJKD> JBLIANBCKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B5F0", Offset = "0x7F09DF0", VA = "0x187F0B5F0")]
	private static void JBDMMJPGGNB(EGOPMJOJPDK DPDCFBDHAPK, [In] HAHLDCPBEOE IKCNJBHEJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F08BC0", Offset = "0x7F073C0", VA = "0x187F08BC0")]
	public static AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME> CKKJBCHOPII(EGOPMJOJPDK DPDCFBDHAPK, KIHEJBBDOFI KBEEALMDOCC, MIDOJLJFPNH? EFINLGPFLBJ, bool BGBJBPNHGOP)
	{
		return default(AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A930", Offset = "0x7F09130", VA = "0x187F0A930")]
	[IteratorStateMachine(typeof(CDFNPLEFGCN))]
	private static IEnumerable<KCDFJLGNJKD> FEGICONFOIG(EGOPMJOJPDK DPDCFBDHAPK, KIHEJBBDOFI KBEEALMDOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F0AA40", Offset = "0x7F09240", VA = "0x187F0AA40")]
	private static void HAMILEKJFOO(EGOPMJOJPDK DPDCFBDHAPK, KIHEJBBDOFI KBEEALMDOCC, IReadOnlyCollection<ByteString>? GANMHIPLGIA, IReadOnlyCollection<ByteString>? FOBKDNJPPOH, IReadOnlyCollection<ByteString>? NHFDKIFGJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A210", Offset = "0x7F08A10", VA = "0x187F0A210")]
	private static bool ECIGJLGNLFG(EGOPMJOJPDK DPDCFBDHAPK, EIJMMJGEKKD OCMJFPPAPMF, KIHEJBBDOFI KBEEALMDOCC, [Out][NotNullWhen(false)] string? MEBFHJECJFA, [Out] Dictionary<int, int> IPMODNEGMFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F09F30", Offset = "0x7F08730", VA = "0x187F09F30")]
	private static Dictionary<Guid, MINGNBNMEMF> DKFNHKBAMFI(EGOPMJOJPDK DPDCFBDHAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A8A0", Offset = "0x7F090A0", VA = "0x187F0A8A0")]
	private static void FAAHGDBIJGG(bool DDFAOBOHLMI, KCDFJLGNJKD KLFCHOKODFK, MIDOJLJFPNH EPEPDBAEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BC50", Offset = "0x7F0A450", VA = "0x187F0BC50")]
	private static void PMJOIADGHGP(KCDFJLGNJKD KLFCHOKODFK, Guid CNLMHNDILAN, MIBJLBAFNEG? HNCMEGOLFOF, Dictionary<Guid, MINGNBNMEMF> ACBMLNBCKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F0AAB0", Offset = "0x7F092B0", VA = "0x187F0AAB0")]
	private static void HCNAPDPGJMB(IEnumerable<KCDFJLGNJKD> CILDNHCMHJA, IReadOnlyCollection<ByteString> GANMHIPLGIA, IReadOnlyCollection<ByteString> FOBKDNJPPOH, IReadOnlyCollection<ByteString> NHFDKIFGJLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KIHEJBBDOFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public bool DDFAOBOHLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public MIFPAMLFEIF DIBPPPCMKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public MIBJLBAFNEG? HNCMEGOLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public MIBJLBAFNEG? FAPMIGCIDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public GPHHIGAIGLA FBPDAMHCOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public FCCFMGMLIFP JFKBDJFPDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public FDLAFOINLJI EBPFKFOEPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public DJLGBBEFIHD<NIMKICIFGFC> NFAFBCFAPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public EBCFBHBHMMG NINBOJKPADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public List<KCDFJLGNJKD> IGPAOICFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public APNNOCBGIPF JDGDDEMCMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public CBAALAIJBFJ GHILKDLJIOB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MIBJLBAFNEG
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const float JDJPDDCFBFO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Vector3 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Quaternion FENAGHBAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public float DKMKOJPHLDD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 CHGEKIANAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F25CA0", Offset = "0x7F244A0", VA = "0x187F25CA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS NAIBIGMIJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F25DA0", Offset = "0x7F245A0", VA = "0x187F25DA0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x14AA7E0", Offset = "0x14A8FE0", VA = "0x1814AA7E0")]
	public MIBJLBAFNEG(Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float DKMKOJPHLDD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F26470", Offset = "0x7F24C70", VA = "0x187F26470")]
	public MIBJLBAFNEG(UniformTRS BNMKBLBBCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F26080", Offset = "0x7F24880", VA = "0x187F26080")]
	public static MIBJLBAFNEG LBADLCFODHL(MIBJLBAFNEG MJNLMOPPION, MIBJLBAFNEG IGHCBIDKKLP)
	{
		return default(MIBJLBAFNEG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F25E50", Offset = "0x7F24650", VA = "0x187F25E50")]
	public static MIBJLBAFNEG KEINEINMKGA((Vector3, Quaternion, float) IMINNNCPCJF)
	{
		return default(MIBJLBAFNEG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F25E70", Offset = "0x7F24670", VA = "0x187F25E70")]
	public static MIBJLBAFNEG KEINEINMKGA(Matrix4x4 LDNLGDCCPPJ)
	{
		return default(MIBJLBAFNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F263E0", Offset = "0x7F24BE0", VA = "0x187F263E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F26300", Offset = "0x7F24B00", VA = "0x187F26300")]
	public MIBJLBAFNEG NJLFKCCBLJL(Matrix4x4 KCODNJGBFEK)
	{
		return default(MIBJLBAFNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F25DE0", Offset = "0x7F245E0", VA = "0x187F25DE0")]
	public static MIBJLBAFNEG IHNFPEBIKBP(Vector3 KKEEFCOJJFM)
	{
		return default(MIBJLBAFNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F25FF0", Offset = "0x7F247F0", VA = "0x187F25FF0")]
	public readonly DCHGOJPKONH KIOCAINFMMO()
	{
		return default(DCHGOJPKONH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BEAHOLOMGGH
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EBOIDIEOOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly KNOIDBNJKHL IBAGPHGCHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly GCGCHICJANP GDJKKHCFDMD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x175B230", Offset = "0x1759A30", VA = "0x18175B230")]
	private EBOIDIEOOME(KNOIDBNJKHL ENEFJOLLDHH, GCGCHICJANP CMHAJKANLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F20360", Offset = "0x7F1EB60", VA = "0x187F20360")]
	public IJDNLMNOAFN CDGFIACPFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F202B0", Offset = "0x7F1EAB0", VA = "0x187F202B0")]
	public static AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME> CCPKJDCALBG(BAFGCCNMMHJ<KCHLBHAFJKA> CMHAJKANLLD)
	{
		return default(AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F20200", Offset = "0x7F1EA00", VA = "0x187F20200")]
	public static AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME> CCPKJDCALBG(IJDNLMNOAFN CMHAJKANLLD)
	{
		return default(AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F20140", Offset = "0x7F1E940", VA = "0x187F20140")]
	public static AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME> CCPKJDCALBG(string FBHHDFCHJMJ)
	{
		return default(AOGODOAGAAO<MIDOJLJFPNH, EBOIDIEOOME>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KNOIDBNJKHL
{
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HPANIMIBAKC : IDisposable, PPOCPEKNDDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private NativeList<KKEDALOMPGI> MCOAFGEEKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private float HCNINLMJGAD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CMGJMELDMAG MGOGELABEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(CMGJMELDMAG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DKPHBKKHGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E566D0", Offset = "0x6E54ED0", VA = "0x186E566D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool JBBJIPINAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E566E0", Offset = "0x6E54EE0", VA = "0x186E566E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<KCOFEBKAACP> BGJHCPDLEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NBONHAOJJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F23070", Offset = "0x7F21870", VA = "0x187F23070", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float IKJJDOCENKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F23C60", Offset = "0x7F22460", VA = "0x187F23C60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F23FB0", Offset = "0x7F227B0", VA = "0x187F23FB0")]
	public HPANIMIBAKC(CMGJMELDMAG NMFHGOAHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F21900", Offset = "0x7F20100", VA = "0x187F21900", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F22700", Offset = "0x7F20F00", VA = "0x187F22700")]
	public Vector3 FPLOBOLGBPF(int BIJFLLMPINH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F22BD0", Offset = "0x7F213D0", VA = "0x187F22BD0", Slot = "6")]
	public Quaternion GLHOAPBJABN(int BIJFLLMPINH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F22D00", Offset = "0x7F21500", VA = "0x187F22D00", Slot = "5")]
	public Vector3 HCCPHELEGJK(int BIJFLLMPINH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F218A0", Offset = "0x7F200A0", VA = "0x187F218A0", Slot = "7")]
	public float AOJONEDIOJO(int BIJFLLMPINH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F21DF0", Offset = "0x7F205F0", VA = "0x187F21DF0")]
	public void FNNGEKJEFCF(Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL, bool BGKPNCJLAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F23F50", Offset = "0x7F22750", VA = "0x187F23F50")]
	private bool POHKFBDGKOD(int IDKKELOIPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F22DA0", Offset = "0x7F215A0", VA = "0x187F22DA0")]
	public void IBODCEICOMP(Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F23280", Offset = "0x7F21A80", VA = "0x187F23280")]
	public void MBFEIJOINED(int IDKKELOIPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F22F20", Offset = "0x7F21720", VA = "0x187F22F20")]
	public void JPKOKKECONF(int IDKKELOIPAI, Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F23DA0", Offset = "0x7F225A0", VA = "0x187F23DA0")]
	public void PBDHFGIPJCG(int IDKKELOIPAI, float3 KKEEFCOJJFM, quaternion FENAGHBAFHI, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F23310", Offset = "0x7F21B10", VA = "0x187F23310")]
	public void MMDDIKOMMOB(int IDKKELOIPAI, Vector3 KKEEFCOJJFM, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F230B0", Offset = "0x7F218B0", VA = "0x187F230B0")]
	public void LHFDLOAKBDD(int IDKKELOIPAI, Vector3 IILAMILCBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F23460", Offset = "0x7F21C60", VA = "0x187F23460")]
	public static Quaternion NFPAHJPMIIB(Quaternion KHAMCCGPNHN, int IDKKELOIPAI, float IGAIKCIOLCI, PPOCPEKNDDK PHEFAJKBLLI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F21960", Offset = "0x7F20160", VA = "0x187F21960")]
	public Bounds FACLJADOCGI(Transform KCODNJGBFEK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F23210", Offset = "0x7F21A10", VA = "0x187F23210", Slot = "10")]
	public virtual void LPEBPGEFALD(bool LIOMELCEJEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F217D0", Offset = "0x7F1FFD0", VA = "0x187F217D0")]
	public NativeList<KKEDALOMPGI> ABPIOBKHKKL(float PHGAIBNCDOJ = 1f)
	{
		return default(NativeList<KKEDALOMPGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KCOFEBKAACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public float3 EOALAOOGNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public float DDOAMKNOBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public quaternion JOKDAPELKHA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F24FB0", Offset = "0x7F237B0", VA = "0x187F24FB0")]
	public KCOFEBKAACP(Vector3 HFIBPPGFFAG, Quaternion KHAMCCGPNHN, float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7F24A60", Offset = "0x7F23260", VA = "0x187F24A60")]
	public Quaternion JPHCFIODNBF(Vector3 LONBCENHPHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F24CC0", Offset = "0x7F234C0", VA = "0x187F24CC0")]
	public KCOFEBKAACP NIHCJCAKBAH(Vector3 KFOGHFHJCOI, Vector3 MBFKIFNDCJL, Vector3 OEHIAOFHMLD)
	{
		return default(KCOFEBKAACP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F24B20", Offset = "0x7F23320", VA = "0x187F24B20")]
	public GFAEGMAPGCC NENLNOBFHBM(Vector3 LONBCENHPHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KIOHOEJBEBM : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F258E0", Offset = "0x7F240E0", VA = "0x187F258E0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F25090", Offset = "0x7F23890", VA = "0x187F25090")]
	private void AJHMCFCEPJM(Dictionary<Guid, Guid> LPJFJLBAHAL, OBOEMAIKLKN NLAKBOBECOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F25030", Offset = "0x7F23830", VA = "0x187F25030")]
	private void AJHMCFCEPJM(Dictionary<Guid, Guid> LPJFJLBAHAL, HADNOBKCMIF IEKBAOIFJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F25660", Offset = "0x7F23E60", VA = "0x187F25660")]
	private void AJHMCFCEPJM(Dictionary<Guid, Guid> LPJFJLBAHAL, JDPHMBEMIKF MHLOMKNLKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KIOHOEJBEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ODFAINADCOC : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F267C0", Offset = "0x7F24FC0", VA = "0x187F267C0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ODFAINADCOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class MEMFFCFMMED : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F25B40", Offset = "0x7F24340", VA = "0x187F25B40", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MEMFFCFMMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BKAJJLDOEDJ : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BA00", Offset = "0x7F1A200", VA = "0x187F1BA00", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BKAJJLDOEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MJFDPCEOINK : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F26540", Offset = "0x7F24D40", VA = "0x187F26540", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MJFDPCEOINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OOFFLGEIFOD : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F26FB0", Offset = "0x7F257B0", VA = "0x187F26FB0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OOFFLGEIFOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DOALFNNAJIH : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FFB0", Offset = "0x7F1E7B0", VA = "0x187F1FFB0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DOALFNNAJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class APGDBIBANKG : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A7F0", Offset = "0x7F18FF0", VA = "0x187F1A7F0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public APGDBIBANKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HJKOMKDNGOK : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F21580", Offset = "0x7F1FD80", VA = "0x187F21580", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HJKOMKDNGOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PJGOMIKKPEK : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F270F0", Offset = "0x7F258F0", VA = "0x187F270F0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PJGOMIKKPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IJBEGNHMPAH : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F24040", Offset = "0x7F22840", VA = "0x187F24040", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IJBEGNHMPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ABCPKJMBOMP : BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public static readonly GLGFNINFMAD JHIJLHHCAIA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A6C0", Offset = "0x7F18EC0", VA = "0x187F1A6C0", Slot = "4")]
	public void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ABCPKJMBOMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GFCFJDPJGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public EIJMMJGEKKD EHCBHNLMEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public NIPLJADAEIJ ANAIOLFMGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Dictionary<int, int> CJLOPDIIOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public Dictionary<Guid, Guid> ICDLCABAFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public CBAALAIJBFJ GHILKDLJIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public bool BGBJBPNHGOP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface BOINPAKKKMG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMELMOHLMDI(HPAHCECHJGB IHKLIHBOECE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BJBGCFBPKFI
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private static readonly BOINPAKKKMG[] ABEFMDGALLO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AF40", Offset = "0x7F19740", VA = "0x187F1AF40")]
	public static void IILDAGAMKAI(KCDFJLGNJKD IMINNNCPCJF, MIDOJLJFPNH DDJMDDJLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1ACB0", Offset = "0x7F194B0", VA = "0x187F1ACB0")]
	public static void CJOAJCGIEHN(KCDFJLGNJKD? IMINNNCPCJF, MIDOJLJFPNH IOHIMNMLGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B1C0", Offset = "0x7F199C0", VA = "0x187F1B1C0")]
	public static void KCEPIIJNBJF(KCDFJLGNJKD? IMINNNCPCJF, MIDOJLJFPNH EPEPDBAEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A8E0", Offset = "0x7F190E0", VA = "0x187F1A8E0")]
	public static void CACIAHDMLIH(HPAHCECHJGB IHKLIHBOECE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HPAHCECHJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public EIJMMJGEKKD EFPILEMLAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public KCDFJLGNJKD KLFCHOKODFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public Dictionary<int, int> CJLOPDIIOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public Dictionary<Guid, Guid> ICDLCABAFBK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F21730", Offset = "0x7F1FF30", VA = "0x187F21730")]
	public Guid GPHBFPDIKEN(Guid JMHOEKKPCPG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CBAALAIJBFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int NNKHKOELHFF, [Out] Guid HMJEDKPBAPA);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CPEHNNLLNFC
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private static readonly HashSet<Guid> NADBCPMMOEB;

	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly ProfilerMarker FHFFOFJBLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly HashSet<string> DEHBNOFJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly Dictionary<long, int> GBIKFNPKLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly HashSet<Guid> KMEAMAALIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> OBCFGPFMHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> JHHKJMFGPBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> GKPBEEBGLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> JGLLBLKFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyCollection<Guid> KIJNMBINMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<long, int> KFIMNMDFLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DA80", Offset = "0x7F1C280", VA = "0x187F1DA80")]
	public static void FLHKBPHDPNC(EGOPMJOJPDK PILIIBJKJBM, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F880", Offset = "0x7F1E080", VA = "0x187F1F880")]
	public static CPEHNNLLNFC OAHMPOMLPGB(PCENONMPPIA JPCNIAHCHAA, OFMHNCMFBIG? CIFHANDEOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F5F0", Offset = "0x7F1DDF0", VA = "0x187F1F5F0")]
	public static CPEHNNLLNFC IOIAAOBGODI(EGOPMJOJPDK MCEMHDAIOII, OFMHNCMFBIG? CIFHANDEOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D9C0", Offset = "0x7F1C1C0", VA = "0x187F1D9C0")]
	public static CPEHNNLLNFC CHBINGHCJPK(HMFAMONFOHI GIAAIENPCCJ, PPCMPMBAJNB EFHAKLBGNAC, OFMHNCMFBIG? CIFHANDEOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F7F0", Offset = "0x7F1DFF0", VA = "0x187F1F7F0")]
	public static CPEHNNLLNFC NMBMPJKNEBJ(IEnumerable<string> DEHBNOFJHIN, IReadOnlyDictionary<long, int> NNCKLMCDCHI, IReadOnlyCollection<Guid> JHHKJMFGPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FA80", Offset = "0x7F1E280", VA = "0x187F1FA80")]
	private CPEHNNLLNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FC10", Offset = "0x7F1E410", VA = "0x187F1FC10")]
	private CPEHNNLLNFC(IEnumerable<string> DEHBNOFJHIN, IReadOnlyDictionary<long, int> NNCKLMCDCHI, IReadOnlyCollection<Guid> JHHKJMFGPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CB90", Offset = "0x7F1B390", VA = "0x187F1CB90")]
	private void CEMEAHFIHKK(PCENONMPPIA JPCNIAHCHAA, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D730", Offset = "0x7F1BF30", VA = "0x187F1D730")]
	private void CEMEAHFIHKK(EGOPMJOJPDK MCEMHDAIOII, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C280", Offset = "0x7F1AA80", VA = "0x187F1C280")]
	private void BEAJEDCDGBF(ByteString? MABHFHOJMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D2B0", Offset = "0x7F1BAB0", VA = "0x187F1D2B0")]
	private void CEMEAHFIHKK(HMFAMONFOHI? MJAMEBJFAIN, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CE30", Offset = "0x7F1B630", VA = "0x187F1CE30")]
	private void CEMEAHFIHKK(PPCMPMBAJNB? EFHAKLBGNAC, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D5F0", Offset = "0x7F1BDF0", VA = "0x187F1D5F0")]
	private void CEMEAHFIHKK(DAGBEHDKCBE? MDCDFIHAHKH, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C040", Offset = "0x7F1A840", VA = "0x187F1C040")]
	private static bool AMIOGMMOLNA(DAGBEHDKCBE MDCDFIHAHKH, int DLJLEHEPLFH, [Out] Guid NFMNOJKLIAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E470", Offset = "0x7F1CC70", VA = "0x187F1E470")]
	private static void FLHKBPHDPNC(PPCMPMBAJNB? MJAMEBJFAIN, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E540", Offset = "0x7F1CD40", VA = "0x187F1E540")]
	private static void FLHKBPHDPNC(DAGBEHDKCBE? MDCDFIHAHKH, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F210", Offset = "0x7F1DA10", VA = "0x187F1F210")]
	private static void FLHKBPHDPNC(HMFAMONFOHI? MJAMEBJFAIN, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E780", Offset = "0x7F1CF80", VA = "0x187F1E780")]
	private static void FLHKBPHDPNC(CIFJKEPGJPA? CJEDGIAKFCF, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C870", Offset = "0x7F1B070", VA = "0x187F1C870")]
	private void CEMEAHFIHKK(CIFJKEPGJPA? CJEDGIAKFCF, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BE30", Offset = "0x7F1A630", VA = "0x187F1BE30")]
	private void AGCIHJBCMIL(Guid? JMHOEKKPCPG, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CEB0", Offset = "0x7F1B6B0", VA = "0x187F1CEB0")]
	private void CEMEAHFIHKK(KCDFJLGNJKD? KLFCHOKODFK, OFMHNCMFBIG? CIFHANDEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EDD0", Offset = "0x7F1D5D0", VA = "0x187F1EDD0")]
	private static void FLHKBPHDPNC(KCDFJLGNJKD? KLFCHOKODFK, OFMHNCMFBIG CIFHANDEOFC, MIDOJLJFPNH LIEHANLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F580", Offset = "0x7F1DD80", VA = "0x187F1F580")]
	private void HEDGMOINBNE(string? BOGJMDBEIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F670", Offset = "0x7F1DE70", VA = "0x187F1F670")]
	private void NLOPJKPFPGK(long CHMDHAIDMFA, Guid EOPIGLIECBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F740", Offset = "0x7F1DF40", VA = "0x187F1F740")]
	private void NLOPJKPFPGK(DBOGHCILOBI? MEOFOHIGFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F790", Offset = "0x7F1DF90", VA = "0x187F1F790")]
	private void NLOPJKPFPGK(FKJFEJALKKM? MEOFOHIGFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GCIDJCCAILD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class ONGKMCJABLJ : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private readonly IEnumerator<DictionaryEntry> DCDHHMABBCF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DictionaryEntry EPEIFNGGIJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F26D90", Offset = "0x7F25590", VA = "0x187F26D90", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object IIACIMCDNIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7F26E50", Offset = "0x7F25650", VA = "0x187F26E50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object HDAKFEADKFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7F26F00", Offset = "0x7F25700", VA = "0x187F26F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7F26CB0", Offset = "0x7F254B0", VA = "0x187F26CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
		public ONGKMCJABLJ(IEnumerator<DictionaryEntry> DCDHHMABBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F26C10", Offset = "0x7F25410", VA = "0x187F26C10", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F26C60", Offset = "0x7F25460", VA = "0x187F26C60", Slot = "9")]
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
		private sealed class DKEDGFNEDOO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FF60", Offset = "0x7F1E760", VA = "0x187F1FF60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public DKEDGFNEDOO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FE10", Offset = "0x7F1E610", VA = "0x187F1FE10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FF10", Offset = "0x7F1E710", VA = "0x187F1FF10", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7F27870", Offset = "0x7F26070", VA = "0x187F27870", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IDictionary.this[object MNMCNOJCKAF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7F27780", Offset = "0x7F25F80", VA = "0x187F27780", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7F27950", Offset = "0x7F26150", VA = "0x187F27950", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7F276C0", Offset = "0x7F25EC0", VA = "0x187F276C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7F27720", Offset = "0x7F25F20", VA = "0x187F27720", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7F278F0", Offset = "0x7F260F0", VA = "0x187F278F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7F27380", Offset = "0x7F25B80", VA = "0x187F27380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F273E0", Offset = "0x7F25BE0", VA = "0x187F273E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7F27440", Offset = "0x7F25C40", VA = "0x187F27440", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
		public RoomObjectCounts(Dictionary<int, int> EGAGIOFKHPM, [Optional] Dictionary<int, int> PANIMACANJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F272A0", Offset = "0x7F25AA0", VA = "0x187F272A0")]
		[IteratorStateMachine(typeof(DKEDGFNEDOO))]
		private IEnumerator<DictionaryEntry> GJBDOEBANMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F279A0", Offset = "0x7F261A0", VA = "0x187F279A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F275C0", Offset = "0x7F25DC0", VA = "0x187F275C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F274A0", Offset = "0x7F25CA0", VA = "0x187F274A0", Slot = "9")]
		void IDictionary.Add(object MNMCNOJCKAF, object MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F27500", Offset = "0x7F25D00", VA = "0x187F27500", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F27560", Offset = "0x7F25D60", VA = "0x187F27560", Slot = "8")]
		bool IDictionary.Contains(object MNMCNOJCKAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F27660", Offset = "0x7F25E60", VA = "0x187F27660", Slot = "14")]
		void IDictionary.Remove(object MNMCNOJCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F27320", Offset = "0x7F25B20", VA = "0x187F27320", Slot = "15")]
		void ICollection.CopyTo(Array LPBOBEPEKNH, int PNJCJGEIDHG)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MDAMLJICFPP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x7F25AF0", Offset = "0x7F242F0", VA = "0x187F25AF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public MDAMLJICFPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7F25960", Offset = "0x7F24160", VA = "0x187F25960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7F25AA0", Offset = "0x7F242A0", VA = "0x187F25AA0", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F24780", Offset = "0x7F22F80", VA = "0x187F24780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IDictionary.this[object MNMCNOJCKAF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7F24650", Offset = "0x7F22E50", VA = "0x187F24650", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7F24830", Offset = "0x7F23030", VA = "0x187F24830", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7F24590", Offset = "0x7F22D90", VA = "0x187F24590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7F245F0", Offset = "0x7F22DF0", VA = "0x187F245F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F247D0", Offset = "0x7F22FD0", VA = "0x187F247D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7F24210", Offset = "0x7F22A10", VA = "0x187F24210", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F24270", Offset = "0x7F22A70", VA = "0x187F24270", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F242D0", Offset = "0x7F22AD0", VA = "0x187F242D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2870710", Offset = "0x286EF10", VA = "0x182870710")]
		public Invention(long EBHOIBHGECB, int FMGALNGIOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F24140", Offset = "0x7F22940", VA = "0x187F24140")]
		[IteratorStateMachine(typeof(MDAMLJICFPP))]
		private IEnumerator<DictionaryEntry> GJBDOEBANMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F24880", Offset = "0x7F23080", VA = "0x187F24880", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F24450", Offset = "0x7F22C50", VA = "0x187F24450", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F24330", Offset = "0x7F22B30", VA = "0x187F24330", Slot = "9")]
		void IDictionary.Add(object MNMCNOJCKAF, object MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F24390", Offset = "0x7F22B90", VA = "0x187F24390", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F243F0", Offset = "0x7F22BF0", VA = "0x187F243F0", Slot = "8")]
		bool IDictionary.Contains(object MNMCNOJCKAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F24530", Offset = "0x7F22D30", VA = "0x187F24530", Slot = "14")]
		void IDictionary.Remove(object MNMCNOJCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F241B0", Offset = "0x7F229B0", VA = "0x187F241B0", Slot = "15")]
		void ICollection.CopyTo(Array LPBOBEPEKNH, int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> IDKHKPMEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyList<Invention> DHANEKKIBFF;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	public GCIDJCCAILD(IReadOnlyDictionary<Guid, RoomObjectCounts> CPDDOLLGPHJ, IReadOnlyList<Invention> CJJKADGELDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F20BA0", Offset = "0x7F1F3A0", VA = "0x187F20BA0")]
	public static GCIDJCCAILD OAHMPOMLPGB(PCENONMPPIA JPCNIAHCHAA)
	{
		return default(GCIDJCCAILD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F20A80", Offset = "0x7F1F280", VA = "0x187F20A80")]
	[CompilerGenerated]
	internal static int GIAOEAMGBKF([In] IReadOnlyDictionary<long, int> GNJLDLDPFCJ, long? CHMDHAIDMFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F203D0", Offset = "0x7F1EBD0", VA = "0x187F203D0")]
	[CompilerGenerated]
	internal static void FDBCHLFFJED(int GJMHAPNNMNJ, [In] HMFAMONFOHI OHNHPAHDOON, [In] Dictionary<long, int> GNJLDLDPFCJ, [In] Dictionary<Guid, RoomObjectCounts> CPDDOLLGPHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum FGIGJBEFPBC
{
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OFMHNCMFBIG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class ODCMIMCIAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly Guid LABAJPNFKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly IReadOnlyList<Guid> JGLLBLKFPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly FGIGJBEFPBC IBAGPHGCHIM;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F26760", Offset = "0x7F24F60", VA = "0x187F26760")]
		public ODCMIMCIAJO(Guid DPCIEGDDHDL, IReadOnlyList<Guid> JHHKJMFGPBK, FGIGJBEFPBC ENEFJOLLDHH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly MIDOJLJFPNH OKIHKKEAICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly Dictionary<Guid, ODCMIMCIAJO> KJEHIGJHHHP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MIDOJLJFPNH MFCILJHDINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F26870", Offset = "0x7F25070", VA = "0x187F26870")]
	public void GGGBGBDKNKJ(Guid KNPEIJCOPHN, Guid EMFJBPNGNJE, IReadOnlyList<Guid> IAKFCDJKLFK, FGIGJBEFPBC ENEFJOLLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F26A80", Offset = "0x7F25280", VA = "0x187F26A80")]
	public bool MPJNKFANBAL(Guid KBLGNLDFCAF, [Out] ODCMIMCIAJO CKAIPOOLBLJ, [Out] bool EANLNKLMFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F26B70", Offset = "0x7F25370", VA = "0x187F26B70")]
	public OFMHNCMFBIG()
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
