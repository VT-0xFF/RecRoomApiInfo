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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x84635F0", Offset = "0x8461BF0", VA = "0x1884635F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMIMJNKMCHI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> BKDNHAFLEAO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> EDOIEOKADLA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> HOLNEPKANHM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> GOFKFFLNLNA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JPBFIGGDCPJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LIENOLIDFGH;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string HNMPAIDBAMI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8450D90", Offset = "0x844F390", VA = "0x188450D90")]
	public static bool MHAFJKOAFGO(Guid BPELLLGFJGO, int KJMPFKNDPPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8450D00", Offset = "0x844F300", VA = "0x188450D00")]
	public static bool LLILEGJKJFC(Guid BPELLLGFJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8450630", Offset = "0x844EC30", VA = "0x188450630")]
	public static string DHMLBIHDPNO(Guid JJCLDINKIFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NLOGEJFOJJC]
public enum AELECJPEKOC
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
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8463440", Offset = "0x8461A40", VA = "0x188463440", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LKICBMBCCLI
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid IHLBPFMOCFJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid JKJINGPMMDA;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid OHGOJCJFOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MDJOAJHEMHF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid ILLNLKKEKGG;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid DFLEEJCNNPH;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid DEEJLPNKMMG;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid BOOKKLADPII;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid POFBAMGOCIA;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid AIAPDNNNKHM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid IEEMJGBKMBG;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid CCBOGNIIPDM;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HNIDJJJANJO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid KPKIIPIALBM;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KNAHJKGGHFG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DAPKCNJILAH;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid NNFLNIFHJEE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid FOEJEOGDOBD;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid HBJKCFMGFLL;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid IPPIKIFKCAB;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid JMMGPMIILHP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid BAABKNEBHGK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid HDKPABGHFKE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid MHDMGMEHNPI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GMJJDEIJPFN;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid BDCDIFENBOC;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid OFHBEBFIJKL;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid OGJAICMOAJH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PPIPHJEAPKH;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid HFFKMDFHMDJ;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid FNBIKNPEHLD;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NNFPMJFIHPI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NBCHMLCNHEC;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid JKKMGLJICJO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid LDCGHLKLJBO;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JDAPEMLBGGC;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid DKIDDBLLGIK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LMAGJCJILDA;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid CLJMNMIFBEJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid HKONIKIGKKJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IDPCONJGOFE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid KFOLOOPPFAO;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid ONMNOFHMFHN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid ALMMAANNCGG;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid BKCJOCFFDLN;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid EIFMHLPFNBD;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LOPFCKPMONE;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid KKFFKBBBMJF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid GMOHMHACAHH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid AFNACDPCAPK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid KOOBCADLBBK;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid IBFCJKGGPHE;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid KJMCGOJGKGG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GNHEGCEABEJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid DBNLLNGNCMK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid HGCHMDDFGKC;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid COFKNADPDEE;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid KLLNBCFDNOH;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid CCMGENEFDKO;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid IAHJGFEBHAI;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JPBHFFHJKNH;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GPKEIFEKGEC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ALILCJHHHBF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid GFPEBDOPLMC;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid CMDDKBCOEAM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LOOHNJFFPDP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid GCIIAAKFPCE;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid MKEONFGHGBC;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid OHIPKMLMJKK;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid ADMEMEGJFNO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LDGMMFIKOGO;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid IFEGKMDNEFL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid AJHCABBMPON;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid GDDCDHIBPCO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid PFFHLDGBBND;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid MFGPCNOONPG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid ADHDLCEGFCB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid BJINIBECJHG;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid HGHFFDOCOON;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid EFLMHEHPFMO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JPKPMOLBLOJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BJGONCPENJF;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid FMLCDOCNCNN;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid ILMLEMIBDAI;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JDCALBFAPKP;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid PNOEPPPPDKP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid JJHIGDCOCFD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid POIJOLOADCE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid AMOICBEINLP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid FHOPGNNEBIO;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DNAIOEDDOLP;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid GLFDEPHKODA;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid PMFMHFAKPIB;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid CMBKOIDFNNA;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid COFALHMJMLG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid BDLFLPACBBF;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OAEPLFAEKDB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid IJOJJDLFLCL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HNLDPNGNFLC;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid CGBHDMPGJJD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid CPHPOJOPKBP;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid JOGMMDHOMOJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid AIPLCHIAPMM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid LAGOMCEHGBK;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid KABOLFHJIAG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DJPBALJMEHC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FAIIMKENFMN;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid BMFGKBBHIKH;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DNCAHLPCGML;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid IPOKHAIPDPP;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid GEFNGDNKDIO;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GJNNDLAIMGF;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid GLDOKDDCGJC;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid LOHEMEEBOMO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IGKAICAPHEP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid AHIMCCFGDJB;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HPEOHAJGGGN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid KCMDBOOHPPB;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid NPAABDADKCD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid CEGCEAMBDBB;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DALFFJKFKAL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MFJIEOCALLP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid APOKJANGHIF;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid HHJJNKLELLF;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FLAJFCACGHJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid FPNOFDMBNGN;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EKEACLDFKAD;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KLEDKKJLLFO;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid OIOFECFPIAI;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid FKBPMLPJKHK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BJLAMBKMEHE;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GABLBPEDKFF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LIGCGIFAONK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid EMHJJGANFAI;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JCBBDMOBOPC;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid OGIOJBLJPCA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid LNHCOHCNBNA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid CDGDHMMBBCN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid ILGLHNABHHM;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid APDEPOHJPLK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid JFBFOAMOIDD;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid PNPILKDFNJE;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HBBALJEIBOB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid KOJJINKBJEO;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid MKCIFJNIADN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid AOMJHDEOBIB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid EDIIEHODFEH;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid OJPHGPMAKII;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid KCADHOLDHGP;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid KNAPBOGPNMB;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid JPBBBMDDLOM;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NAHEGEAPNEM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KMPNIJLNMGE;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid GKFPODFNPMM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LANEPIEMDPI;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid PHEEPBMLFOC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid NADALNOMMHB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid FDDBGOBBCPN;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid HCOPDPGLJJL;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid GFMLNKOBIIN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KBELGLJHAJP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LMHNJBHHOFD;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid BIOKGILLCJO;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid LDFJPMLEMID;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid FIILJAMBPFC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid OIAGKBODAIN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid LBCELDLLAMM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid LHELFPJIGAF;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid DOEPLOIIEAK;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid AJOCGDDBDGN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid NCEIDCKFPLC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DFCCCEEHGIO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid NDJKFFENDJG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid CALACFACONL;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid OOLHEHLCNBF;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NOJGLKGJIHK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DDEALMHGAOP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NPAAJMGHLLP;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid KFNDPOPDHIP;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JLIINMAKKOL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid IHELBPOJJAA;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CCBENOIBAOI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DDODGKEHLKG;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FFPGBPAGAJH;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid CPKKLGAJKBH;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid HMFKPBPEEDK;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid NJALMJFPOKI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JFCLIIGJIMM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid JCFPFMCEFHL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid FKCIOPALJLK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GAJPFDNKLJA;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid COPAKJNEOPH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NBNGBPAJEFO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid LLKAGAOHKGN;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid IEAIFODAKOH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HNJFKFOIJLK;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DKECJFODLOI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid DKKDMHGDHBD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DMHOEDLDJCA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LJDHCLNKGGP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid HJKJIBLGOEN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PFAELIAJDBN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PFOFLPOBCFF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid DGNBCLEDONG;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ICACPCGNLKE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid JLDFFKPOKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid BLINPNADJFA;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid FDINIOICENG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid EFBBBGCLJLG;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DPAFHECJAPL;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HNHPCMGNHIB;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid PFGEJEFAADI;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KHKOJIPCELA;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid MFJNJLIHDHO;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid OJBHMNEOFFF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid JBICCKADLOC;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HFKPHJGFMKJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FHEIKGCFONF;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid FBKIOPBJPEF;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KMGMDBILHMA;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid ALKHGPFEJHD;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid PJMHACHJPCI;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid DHKNNKPPKFK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FJGKDAHJBGA;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid AGAHMHNEMPF;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CMMKAJBGHMI;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid LLENAEBPPNL;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid IJFPLILGMPC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid PENBIDNJHMI;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid OCAHDMMOBMM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JLPPMIIFKDD;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid IFNEHMOEIKN;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid GEKOHECMAEL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid FKLEPOKGANI;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid DOOEBKDBCFF;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid FGEPOADMDCC;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DDDFKPHDNNN;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid ABBFHKMLDBC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid FAGLLEDKLDB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FMKHALLAHAO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BDCGDGAKGDI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid FIBAFKHFKPB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IDGECALONJG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid BACIHFONENK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid NPHNADHOKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid CIABFAFIPBF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CAOOMJGKOBC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid DFEIAEFJGBI;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid EGGLJIAEBBL;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid DFAGFFAMPFN;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid FAEFLCOBDOG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid KINIIJIDANL;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid AFNGJGJOAEM;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid NABIGHJDBJF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LIINKFKMOLC;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid OJFHFPOPIOE;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MMEFNAJHMAJ;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid BJHBDPJIJGC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid EINMGDEDEPN;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NDEKHHCIFCE;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid LIJNCDIMFCJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CDCMFAOBNOJ;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid OMOEJEDINLI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CHOHJBBEKDJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid BOBICDGAALO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BKBPIABNGAB;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid COCIKOFOFHH;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid FFAENEIJBKI;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid GKICNBCEGAE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid ABAHEHFFHFM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid HKIPNAKAFBF;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid GGHNIEDEAAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid OLAJEFKHIGF;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid HIDJECFMPFJ;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid IKICDPADKMH;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BCBDNCPKEDK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NBGBFNIFPJM;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PGCPFBLJDCL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MCDKLNDLKND;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid HDAPKECDNEJ;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid ILDDDDGFDKJ;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid ENMDJPJLPMH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid CJHDHNPPOPO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NBDDABJOOKG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid GBBFKJDHDLD;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IPEGLAKMOEL;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PPPEAHFAHCP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IHBDJFJNANP;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid NFNDEJAPLDA;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NNMOCILKALC;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid NHJMHKMAMGE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid DJHKBCEGNJN;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GGMJHIPLNCO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid MHAKGAAMHIL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PKPCPFEFHMI;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid EKDLCCMAONN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid EEIBEGNKFKA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid NOAEFHCFMHC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid IDHIOINMKJD;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid OFPLBNKGDLB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FCKGDCNBEGD;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid MABELEEEMBG;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid AMNIDPOCGID;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid ONPOKEPMFNJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid KDAPAJDJKEB;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JGIMJCPAGGI;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid NJLCDGDLPEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid FGBNOOHECGK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BCOCMCDMDEF;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid LGPKPOBMBCP;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JDONNGCKCKG;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid LABJEMCOAKN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid OKOFJCHKOHB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid JGMDHDPCIMP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid ACLOOPNFLAN;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid DDLKJPICINL;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid MIOBILACKEM;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid ONBLBEIMIEB;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid DHIAENKGJMB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid JGCKIOOIDDB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid LKFOAPMACPI;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid PKCCPKNDENP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FLMLCPOLIMO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid PMBCGKGLELB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid INGIJJHCOKN;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OAKOBOKLFLD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid APKNDGGHFKD;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PHCFFKAHEHJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid CHLMEAMHMAO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid MMHKEDJLKCN;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid JKINMKBOMFG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PLGABAEGLPN;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid AJAGKKKIDIE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GJFFPFCHDFP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CDDFEEFEIBB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid CEGIHCCLMHD;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid DHALCCMMIGE;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid DMMDNEDLNNB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EGBHMJEMCNO;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid OOKLJIDPDJN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NGJHCKFFDBI;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid IHBNPKHOFJK;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NDNCLKADLIF;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid LDAPHCNOJML;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LDLPBEEIGPK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid PEPOKPBHMKI;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid BKBPBMFPMHN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid ELBAGPNBADO;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DDCGNJFHLMM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KGHCOAACMON;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IPFNOHIOGFD;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid DNAIENFIIMD;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid HFPKMLAOGMC;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid AICANDBCFFJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid KAMJHGEDDCP;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid MAKNFIOKBNA;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid AIDLIMHPLCB;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DDBBHIIGMGG;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JOPPHGLHGHP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OCEGNCLKJFG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid LMNHGNDKJFC;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid MAEMJIBAFAL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DMLHOEBDBOH;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IGMLABPJMNF;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid BGICNHPOJIB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PEHOPOPDNGC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid CKPJMGCOABN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KICKEMHHGHM;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid ABALIKLABKC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid OAAOPFFCOBO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid BDBHOCPNDMP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid IOFPAMBFEFI;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid MGIMGIAFKBB;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid LJOAEFNCDNJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid HADBEMKEOFA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid NDKAPIEFPAM;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid GDOPFLCKEMA;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid KGHIEOPMGMH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PKANLMOMDHJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid OODKEIJBKLG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FJFPFMEPOHP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid ACBMKMEKJBB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BJFPHDONJJK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GPLKMJHKPOF;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid OGDDDACBEGK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid EFLNJPFMPBF;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ODHNDDDJPCE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid DIPPMNJDBDG;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid ABGJJDMBEHA;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid GIICEECHPEJ;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid NPMEGEPEFDE;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid GEIBAFKPOHK;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid GHPLGBDGGBI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FOLJOPIKCKF;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid EMCPEMDMKFP;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid GNMNGPGDPOG;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LDEJKHHLHBP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid AFNPAMLENEA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid CMGFOFEOCGN;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid INOGBBNPCGM;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid NDMDEEANKPB;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MGBFGJECIBD;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid KDIIGFICKNB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid OGMJBJAANAN;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid HIMNEJNIMJF;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid GHPKNLEEIDJ;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid BMAIEBCCAHM;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid BFGFNEHANLH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid DPGCEDFNHCI;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid MGGNDGLLNDI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid GDEAOANHEJF;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DLBMNGEKBCM;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid KMMIMGOAOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid HHBDBNJNIGE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid AKCHHHGOLAC;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MOJJNHAPGEK;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid OHLCNPLOCFM;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid IBHAJFEPDAM;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DAIJCEIOCAA;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid DNKOHPGHACK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid MDACEHHAHLE;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid BOGMECHAFGL;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid IODGKIBOAMP;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PJIOKAHHNMF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DABKENPJAEI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DMOJBOAFDEN;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid FDHPLPELBFH;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid NNOBPMPDJMN;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HMOIOIBJNFG;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KFHABDLCOOK;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid AMEAFOODHOB;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid HAFBPMLHMBF;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid CFGKEJGDAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid HNIJLGBGOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid LLFBONFFCGF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid MCENGLIIEME;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid LPFKLHINJIK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BHHCJEOCHGD;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DIEFOLMLDBL;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MFMAKEDPBKH;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MJIGFBJGEPA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid LPNFEEABPML;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid NFNDCGAKPAK;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid ANMMMGHJMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid NGOAEOMIPOH;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JBIIDAGCLMK;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid IHNMCPKCENO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid DDJFJADENHE;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid FDAGDFCNJBK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid KAFDDIPHLIK;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ILLJFPOECKK;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid BLDHHKCNBOD;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JLDIAHCNOPC;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid PDBKJBPGNBG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JFOIMLNPOOE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid BHCKDEGGOIJ;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid MOHBENFFMCD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HKJMLLHEGCP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BKIDOIMGIBJ;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid BOFBHHJMNFP;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid KFDMHPLJGBI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid KBBDGMCCKDG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LHAPCNLCMKN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid ICCHCLLINBA;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HDJFNKMHDGD;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid OLAFBHGMPGN;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid DODNDDGJOEG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid CMBOAKAIOOH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid GJKODAGMKJP;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FNCBCLLKPHG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid ICNIONEDNNH;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid FAIOKJGKALD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid EOEEADBNDCK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid BAFPEFAPNAI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid AENAINENNIE;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid KBGEOELGMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GNDMOHEAHLP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GMAKJEBDMGA;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HMLFDCIHJKM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid BBMBBDFNKEE;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LDJPIICBDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid APFFPFPHIMC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BKBNKEFBNNN;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid PMJFHCPPHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DOJLGEGHJNG;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid GMEIJAOBMND;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid MAEEOJPGNHO;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid LAMGEMCMLLN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid NEOPGLABCAK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid ENPNIDMGLOE;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid KCLPMJNBJEK;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IOGHBAJPIBM;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid FLCMCHBCAOB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid EOMPFFGFBML;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MFFJFHGLBJM;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid ABBMFCPGCLE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FFBKAPHNIOP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AAPJHGIBBDH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid OFIENDAFBAE;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid PBELDDPGIPA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid BMBJLBAIGPL;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid EDOOPLKMPFO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid PJANIEMBECP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LNJOIOGLHGO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid AOEFNDIDMJD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ACICHKFKDOO;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid LADJLIHNJIP;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid DLPJLEILJOH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid DAFNFIOGDAD;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid NACOHDCFLDM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JIFACPPLDGM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid IFLFFGKDMFI;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OBEKBHFOHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid PPJOBJGLOGP;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid DHJBJBHKKHM;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid FGMHMBIOEFO;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CKIDAPEPLBN;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid DCFDLDJGHPD;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid EBEENOOKBMF;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid AKMHBFPLHHH;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid HNAKALPHGJH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid HDINKKIHEJP;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid DKCDOAAKNNK;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid JPEOHJNMAKH;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid EHCCJKHFFNH;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GEAPKJHNBIO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid HHMLHFFLEOO;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid AEPLMBDDLNJ;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HIHODPONJNB;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid DPJCLPHIPLI;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid CHLGJMKMELI;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid AMPCKJOAFCH;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid COKADOPHDBE;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid PGKOPAPCIAP;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IPMMNILJKPA;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid LDDBJEEGMBH;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid LOFDGNCGHAL;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PKNBKBJJKIN;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GPEEFDMOCIM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DDDOBHAJLJE;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid DOOPNEHIAHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid MDGLKEPBILL;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid OOJFEOFNKKG;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid EGFCHCDMPMC;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid MOJOOCDKMCJ;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid KHFOCOABPDH;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid CLECNGFHDOM;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid PFNINDJPHEP;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid DELMMDHEPAI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IFIHIEOECDK;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MCPDGCIGHPD;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid BOOEPHCJDFE;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid BEGJJMJIJNB;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid OMIKGGLKMNF;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid HFMMIEABAMP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid OGMKBKGLPFN;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid OBLKJKJGCLD;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid DAODLHLDLNA;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid KBHLIDFHFKL;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid GLJKBKNGCNG;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid GEKFILHMFDO;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JDAKHJCAEEO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid EPBFNIPCJPI;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid IJAJJKNFLCC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid AJBINJDBGED;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid MCCANLCDPAB;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid CLDNMGJELDN;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid ONNDDJGIPNE;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid FEJNCBKODLC;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid LJOJHGDDEBB;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid NLMIMHMJKMN;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid JPLFNFAPGPP;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid KLAHMIOMOFD;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid FGODCBENCEK;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid GDGMLCBLJPO;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GONLHCCEJPB;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FIGGBOHNHJL;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LKOLOBJGDMK;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BLPNHDPAPPK;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid EDBOFLOFEAG;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid MNGLEGNLBGE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CPCNMHCDFLK;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid ALODJIOCGPF;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid LJPCPGMJAOJ;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid KCKEFOMJGOG;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FGBDHLDHCKD;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid BJIOLGCACNG;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid HOBDNNJHFDE;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid JALOHEFPONG;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DMFLNBDFFEJ;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid CCCFMNGHLMP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid KHGMGIEBLPK;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JDFJCKAGAAA;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid JDDCJENHNIA;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FCHOFIDKAHM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid MNLKHOPHFHL;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid FFMJIGMNOOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BKDJINGCMBF;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid MDIDBCJKMFF;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid ECDKOOBHCDN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid IEDKDGMANFI;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid PHGGJEMOHLF;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid KNEJNGGPCKK;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid NDALHBKCJKL;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid AGBMMEMGOLG;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid MGPFGHGGFFH;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid LMKOFJCOKME;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid JOGKHEIHBDG;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid EHIBNJIIOBP;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid NNFGCBJOONK;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid JOPHKMDELBP;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid BEAGCJEBPOL;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid GFHEJOFCEFH;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid HONHCHHNIDN;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid HBEKAKNCKOB;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid GPCMNIHBMHA;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid IIGMBHDLCPH;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid CDFDHLDBFMK;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid NLLHNNABIHN;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid KPEHEEKAMLM;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid AMHJBJIGPJM;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid OKHNBKFAEMI;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid KJHLBJOPEDI;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid DLIBHDJIFNF;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid KLBKFNMGFEI;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid ICIGLGHKGDO;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid CLIOENEIABK;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid BPLHIGPPPBN;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid FCPLMPMFLIO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid FLELPHKCEJG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid MPBKCKCFCMD;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid CKMEBPPCDIJ;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid FEBOILHBKLM;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid LGBAFPCHLGK;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid BNFAIOOPILN;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid KDDBDPMALBA;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid DPAEFDOKHFJ;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid CMIEFDDHGMM;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid GKLBIELILCI;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid KICNBIAKOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid NDOCNMGADIH;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid AOHIEODKHGO;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid GGEPGCGKAIA;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid DLFFCHGBOBO;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid DMJHIMMEMHE;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public static readonly Guid FGKDLLGGOPC;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public static readonly Guid OLCIPACHOIO;

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public static readonly Guid HKDEJGENAKE;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public static readonly Guid MGNCGOHBCKM;

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly Dictionary<Guid, AELECJPEKOC> BHHPCJAMHPK;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly Dictionary<AELECJPEKOC, Guid> LMNPCBBFCBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, AELECJPEKOC> EKHIAGEFPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8463380", Offset = "0x8461980", VA = "0x188463380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<AELECJPEKOC, Guid> EDMBIGAKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84633E0", Offset = "0x84619E0", VA = "0x1884633E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IECIDOHJKNE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8462780", Offset = "0x8460D80", VA = "0x188462780")]
	public static bool LHGDNAADNBD(AJNJONKJMPC COBFNEFMCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8462360", Offset = "0x8460960", VA = "0x188462360")]
	private static bool LHGDNAADNBD(LJADOIIMAPO PFIDGGFALEN, AJNJONKJMPC COBFNEFMCBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PPBKKGEPPAK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MOCGOGNPGIC CDDIADBJAOB, [Out] Dictionary<int, int> LAFNPOHCPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FJLAJMAFHGO AICDFHFBCHA, IKPBAMDFNLC MPLBHNFMMCG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NBMOJLNJOGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly ELFEGFIGAKH NBBLIJNKCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly IEnumerable<ALMOPHBCAAE> CDJLDCHGCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly IReadOnlyList<ALMOPHBCAAE> HLBCNEKBCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly AIOJMGEOJFK<NEJNMGMJLDN> KAAGALGEMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly IReadOnlyList<HFKDGKKLFAL<OMGMEOLCEJA>> MIMFFOOJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly KKJAMJEKAAB JDFLPCILADI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLJLJMDADOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8463580", Offset = "0x8461B80", VA = "0x188463580")]
	public NBMOJLNJOGG(ELFEGFIGAKH LONMFMIANGN, IEnumerable<ALMOPHBCAAE> KDCPGEAFOGE, IReadOnlyList<ALMOPHBCAAE> GJAJJLKJLEO, AIOJMGEOJFK<NEJNMGMJLDN> BODLIFJJHFF, IReadOnlyList<HFKDGKKLFAL<OMGMEOLCEJA>> MDACGAPPHLC, KKJAMJEKAAB IEENBKAPJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MHMMNIEHGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ELFEGFIGAKH NBBLIJNKCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly IReadOnlyList<ALMOPHBCAAE> ELOCCBLBPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly AIOJMGEOJFK<NEJNMGMJLDN> KAAGALGEMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public readonly IReadOnlyList<HFKDGKKLFAL<OMGMEOLCEJA>> MIMFFOOJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public readonly ByteString OBLFPHIFBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public readonly KKJAMJEKAAB JDFLPCILADI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8463510", Offset = "0x8461B10", VA = "0x188463510")]
	public MHMMNIEHGJA(ELFEGFIGAKH LONMFMIANGN, AIOJMGEOJFK<NEJNMGMJLDN> BODLIFJJHFF, IReadOnlyList<HFKDGKKLFAL<OMGMEOLCEJA>> MDACGAPPHLC, ByteString IOLCAFLKJGI, IReadOnlyList<ALMOPHBCAAE> HDDGHGLOPAG, KKJAMJEKAAB IEENBKAPJPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LGEECNFNGGB : FNNCOCNHIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public readonly Guid FLFHCJPGIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private readonly Dictionary<Guid, Guid> PLDHKFPNKBN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50805A0", Offset = "0x507EBA0", VA = "0x1850805A0")]
	private LGEECNFNGGB(Guid LDFDDDEHLJA, Dictionary<Guid, Guid> PLDHKFPNKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8462960", Offset = "0x8460F60", VA = "0x188462960")]
	public static LGEECNFNGGB CPNHECDILPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84631D0", Offset = "0x84617D0", VA = "0x1884631D0")]
	private static Dictionary<Guid, Guid> LNKOMFICINH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8462FD0", Offset = "0x84615D0", VA = "0x188462FD0")]
	public static LGEECNFNGGB HKHIJCHGHMK(IReadOnlyDictionary<Guid, Guid> PPEFJKBNOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8462CE0", Offset = "0x84612E0", VA = "0x188462CE0")]
	public static LGEECNFNGGB HCFNJCHJDPM(IEnumerable<KeyValuePair<Guid, Guid>> PPEFJKBNOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8463280", Offset = "0x8461880", VA = "0x188463280")]
	public Dictionary<Guid, Guid> MDJBJIFBHMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
	public Dictionary<Guid, Guid> OIFJBPPKKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8463300", Offset = "0x8461900", VA = "0x188463300")]
	public void MEFAAGOGBHI(Guid PPEFJKBNOEP, Guid DNPKCGAKHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84629F0", Offset = "0x8460FF0", VA = "0x1884629F0")]
	public void EHEIMMECEEI(IReadOnlyDictionary<Guid, Guid> GJHJNDBGLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8462FE0", Offset = "0x84615E0", VA = "0x188462FE0")]
	public Guid KBIHJGOPHCO([In] Guid PPEFJKBNOEP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8463130", Offset = "0x8461730", VA = "0x188463130")]
	public Guid LNGEBDOJEJA([In] Guid PPEFJKBNOEP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8462C70", Offset = "0x8461270", VA = "0x188462C70")]
	public bool ELKGDOAOKLK([In] Guid PPEFJKBNOEP, [Out] Guid DNPKCGAKHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8462C70", Offset = "0x8461270", VA = "0x188462C70", Slot = "4")]
	private bool PCBGBEMKFJK([In] Guid PPEFJKBNOEP, [Out] Guid DNPKCGAKHLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EMDDAKAFNKI
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJDIFGPIKLD(Guid JJCLDINKIFD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHOHEMJDBJB(Guid JJCLDINKIFD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ICNEDGDHFNL
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
public abstract class PIKFJIOKOCP : EMDDAKAFNKI
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JOFCMKGBELJ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public JOFCMKGBELJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84627B0", Offset = "0x8460DB0", VA = "0x1884627B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8462910", Offset = "0x8460F10", VA = "0x188462910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8462870", Offset = "0x8460E70", VA = "0x188462870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8462870", Offset = "0x8460E70", VA = "0x188462870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private Dictionary<string, HashSet<Guid>>? CEIIDPDAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	protected Dictionary<string, string>? FAMOIMJOJJF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> KEODIDNILBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8463AF0", Offset = "0x84620F0", VA = "0x188463AF0")]
		[IteratorStateMachine(typeof(JOFCMKGBELJ))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? GMOEILJMHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool ECPGDBDKHAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool FCEDCAAPOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract List<Guid> EFJIAAKBKGC(string LFIHDMNMNIL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract bool KFBDCBAEPMC(string LFIHDMNMNIL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8463670", Offset = "0x8461C70", VA = "0x188463670")]
	public void BNFFHNDJADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x10354A0", Offset = "0x1033AA0", VA = "0x1810354A0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8463E00", Offset = "0x8462400", VA = "0x188463E00", Slot = "4")]
	public bool PJDIFGPIKLD(Guid JJCLDINKIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8463D30", Offset = "0x8462330", VA = "0x188463D30", Slot = "5")]
	public bool NHOHEMJDBJB(Guid JJCLDINKIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8463C70", Offset = "0x8462270", VA = "0x188463C70")]
	private bool JGGIAHEAJFK(string HOOCOGBLGGO, Guid JJCLDINKIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8463B50", Offset = "0x8462150", VA = "0x188463B50")]
	protected List<Guid> FMNILELOKJI(string GKPOOJOMDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected PIKFJIOKOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HJACACJCBGB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class ECGCOHFMPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public ELFEGFIGAKH staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ECGCOHFMPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8469F80", Offset = "0x8468580", VA = "0x188469F80")]
		internal AIOJMGEOJFK<OCHAFKCJLHH> AIGIEKFECLO((AIOJMGEOJFK<NEJNMGMJLDN> GraphId, AIOJMGEOJFK<OMGMEOLCEJA> NodeId) i)
		{
			return default(AIOJMGEOJFK<OCHAFKCJLHH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private const int BGDDMIAAHNK = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private readonly Dictionary<AIOJMGEOJFK<OCHAFKCJLHH>, HPFNIBNDJFK> LBCLGKCCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private long AFBGLBNHCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private long GFILIGAGBDK;

	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly ECIKEEECPGI<OCHAFKCJLHH, int?> LAOPMBHEIJI;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly long GCKHJEIILDK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long LIKIAPJHJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8454C10", Offset = "0x8453210", VA = "0x188454C10")]
	public static HJACACJCBGB KNDHHMKJOGC(ELFEGFIGAKH HGODILHMKNG, HFKDGKKLFAL<NEJNMGMJLDN> MGAOCLEOKGJ, [Optional] HJACACJCBGB EIJPJOBKALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8454850", Offset = "0x8452E50", VA = "0x188454850")]
	public static (long, long) GKCBDEPEKKD(ELFEGFIGAKH HGODILHMKNG, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OMGMEOLCEJA> PLBMJMHLGMM)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8454720", Offset = "0x8452D20", VA = "0x188454720")]
	public static long BBCAFKDLGMI([In] ReadOnlySpan<AIOJMGEOJFK<OCHAFKCJLHH>> ICINIFFMFFN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8455180", Offset = "0x8453780", VA = "0x188455180")]
	private static long NPKGACDHIAC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84622D0", Offset = "0x84608D0", VA = "0x1884622D0")]
	public HJACACJCBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HPFNIBNDJFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEB19B0", Offset = "0xEAFFB0", VA = "0x180EB19B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long CKMDONPDFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xE15260", Offset = "0xE13860", VA = "0x180E15260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FC58F0", Offset = "0x7FC3EF0", VA = "0x187FC58F0")]
	public HPFNIBNDJFK(long LMJBLNOIBOL, long EKINOOFAGOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NIOHPPHDPGP
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public static readonly HashSet<AELECJPEKOC> DCOHLADMNAB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GEGEIPIELFL
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IJIBIJBHHCO : IEnumerable<ALMOPHBCAAE>, IEnumerable, IEnumerator<ALMOPHBCAAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private ALMOPHBCAAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private LENDKCEJOHO spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public LENDKCEJOHO <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private NIFHCOIDNAF spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public NIFHCOIDNAF <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private ALMOPHBCAAE System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public IJIBIJBHHCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x846DF00", Offset = "0x846C500", VA = "0x18846DF00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x846E180", Offset = "0x846C780", VA = "0x18846E180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x846E010", Offset = "0x846C610", VA = "0x18846E010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ALMOPHBCAAE> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x846E010", Offset = "0x846C610", VA = "0x18846E010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x846A6B0", Offset = "0x8468CB0", VA = "0x18846A6B0")]
	public static LENDKCEJOHO CAENCOBNOAC([In] MHMMNIEHGJA GBNMBOKNLML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x846A830", Offset = "0x8468E30", VA = "0x18846A830")]
	public static LENDKCEJOHO CAENCOBNOAC([In] NBMOJLNJOGG GBNMBOKNLML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x846B230", Offset = "0x8469830", VA = "0x18846B230")]
	private static HashSet<HFKDGKKLFAL<CPJCKADHKAF>> GHFMBJLLFLE(IReadOnlyList<ALMOPHBCAAE> IINBHIJICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x846A9C0", Offset = "0x8468FC0", VA = "0x18846A9C0")]
	private static void ECLMJNFKOBE(LENDKCEJOHO GONFCIMKNAF, [In] NBMOJLNJOGG PGJEFBNGFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x846C120", Offset = "0x846A720", VA = "0x18846C120")]
	public static CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA> JOEPONPNKLC(LENDKCEJOHO GONFCIMKNAF, NIFHCOIDNAF MHBBDKLHADD, LGEECNFNGGB? FBAGGMBKAIM, bool DDOHGPEJNLK)
	{
		return default(CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x846B020", Offset = "0x8469620", VA = "0x18846B020")]
	[IteratorStateMachine(typeof(IJIBIJBHHCO))]
	private static IEnumerable<ALMOPHBCAAE> EGHMMMMEMBJ(LENDKCEJOHO GONFCIMKNAF, NIFHCOIDNAF MHBBDKLHADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x846B1C0", Offset = "0x84697C0", VA = "0x18846B1C0")]
	private static void GEDKGPDAMBA(LENDKCEJOHO GONFCIMKNAF, NIFHCOIDNAF MHBBDKLHADD, IReadOnlyCollection<ByteString>? AGDBCPEJEAJ, IReadOnlyCollection<ByteString>? FLJMFPKPOAL, IReadOnlyCollection<ByteString>? LEIJJCKLDGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x846B5D0", Offset = "0x8469BD0", VA = "0x18846B5D0")]
	private static bool IJEJHHPAPDN(LENDKCEJOHO GONFCIMKNAF, FJLAJMAFHGO AICDFHFBCHA, NIFHCOIDNAF MHBBDKLHADD, [Out][NotNullWhen(false)] string? DAANGKEHOHD, [Out] Dictionary<int, int> LAFNPOHCPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x846D740", Offset = "0x846BD40", VA = "0x18846D740")]
	private static Dictionary<Guid, LJADOIIMAPO> MHAMMFACGHK(LENDKCEJOHO GONFCIMKNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x846B130", Offset = "0x8469730", VA = "0x18846B130")]
	private static void EINLOKMHKPA(bool PIFCNPFOLLP, ALMOPHBCAAE CMEDEPJOKEH, LGEECNFNGGB FMNPOOEHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x846A420", Offset = "0x8468A20", VA = "0x18846A420")]
	private static void APJABMNEICD(ALMOPHBCAAE CMEDEPJOKEH, Guid EIEGDICNOIG, NINOKFKPDKO? KMJHJKKIMAN, Dictionary<Guid, LJADOIIMAPO> FBAMBGEJLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x846BC70", Offset = "0x846A270", VA = "0x18846BC70")]
	private static void INCMAIMJHNP(IEnumerable<ALMOPHBCAAE> AEKLIDHODJO, IReadOnlyCollection<ByteString> AGDBCPEJEAJ, IReadOnlyCollection<ByteString> FLJMFPKPOAL, IReadOnlyCollection<ByteString> LEIJJCKLDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NIFHCOIDNAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool PIFCNPFOLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public KKJAMJEKAAB IEENBKAPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public NINOKFKPDKO? KMJHJKKIMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public NINOKFKPDKO? CEAOKCKOJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public ELFEGFIGAKH KHJIKPOPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public ICNEDGDHFNL ODGDLDPACNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public PPBKKGEPPAK GNNLMKMFBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public HFKDGKKLFAL<NEJNMGMJLDN> FNBPIIPPLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public KNJBKMBJGCF FEPIABNMMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public List<ALMOPHBCAAE> OBNAHAHGEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public ANOCIKLGHAF NLJPEGOLHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public IKJDPDODNFF CCKLKBHBECF;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NINOKFKPDKO
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private const float AAPLDKNPAPI = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Vector3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public float EAHAEIJNIMH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 HGPEANEFHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84732D0", Offset = "0x84718D0", VA = "0x1884732D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS KEBDMOHGIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8473290", Offset = "0x8471890", VA = "0x188473290")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x16AB9B0", Offset = "0x16A9FB0", VA = "0x1816AB9B0")]
	public NINOKFKPDKO(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float EAHAEIJNIMH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8473B90", Offset = "0x8472190", VA = "0x188473B90")]
	public NINOKFKPDKO(UniformTRS NJNDPHFHNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84737F0", Offset = "0x8471DF0", VA = "0x1884737F0")]
	public static NINOKFKPDKO MCAHNOINNJO(NINOKFKPDKO BEBONNCPGLF, NINOKFKPDKO PGJEKCGJOCF)
	{
		return default(NINOKFKPDKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84733E0", Offset = "0x84719E0", VA = "0x1884733E0")]
	public static NINOKFKPDKO HNGLNPFKABH((Vector3, Quaternion, float) CDDIADBJAOB)
	{
		return default(NINOKFKPDKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8473400", Offset = "0x8471A00", VA = "0x188473400")]
	public static NINOKFKPDKO HNGLNPFKABH(Matrix4x4 IJHMHLIGNLA)
	{
		return default(NINOKFKPDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8473B00", Offset = "0x8472100", VA = "0x188473B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8473560", Offset = "0x8471B60", VA = "0x188473560")]
	public NINOKFKPDKO JAKFNJCBMJB(Matrix4x4 CCHLCEHOKAD)
	{
		return default(NINOKFKPDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8473780", Offset = "0x8471D80", VA = "0x188473780")]
	public static NINOKFKPDKO JMIGLLFKHKA(Vector3 APHHGJIDDCM)
	{
		return default(NINOKFKPDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8473A70", Offset = "0x8472070", VA = "0x188473A70")]
	public readonly DDJOFEAHMAB PMMKMNKIOKJ()
	{
		return default(DDJOFEAHMAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DIHFLGCIKKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PHLJNBBILKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public readonly MOACJGCIPEN JAEPJMGMGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly EHNKGHFFBGH LHNAFOEKCHJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1998FA0", Offset = "0x19975A0", VA = "0x181998FA0")]
	private PHLJNBBILKA(MOACJGCIPEN LJNIMHNLCFF, EHNKGHFFBGH HBLECKGPBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8475370", Offset = "0x8473970", VA = "0x188475370")]
	public IGJAGJOGKBA ICMKFLHEKPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8475200", Offset = "0x8473800", VA = "0x188475200")]
	public static CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA> CPNHECDILPK(KBOFMKIIKFO<IHJGGHCFJKD> HBLECKGPBJG)
	{
		return default(CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8475150", Offset = "0x8473750", VA = "0x188475150")]
	public static CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA> CPNHECDILPK(IGJAGJOGKBA HBLECKGPBJG)
	{
		return default(CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84752B0", Offset = "0x84738B0", VA = "0x1884752B0")]
	public static CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA> CPNHECDILPK(string EHCNPMEPJEH)
	{
		return default(CKPAOGHIJHA<LGEECNFNGGB, PHLJNBBILKA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum MOACJGCIPEN
{
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MNMEHCGPOED : IDisposable, BBLLJDDJMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private NativeList<KMFOEBEFONO> CCHCBDNJBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private float MCMECGHHKJF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LIJKMCLPLEC FHDDNCDOEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180")]
		[CompilerGenerated]
		get
		{
			return default(LIJKMCLPLEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA7130", Offset = "0xAA5730", VA = "0x180AA7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FAPLOFMIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72F0440", Offset = "0x72EEA40", VA = "0x1872F0440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FJOBMDEIJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72F0450", Offset = "0x72EEA50", VA = "0x1872F0450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<BJHHGDHGGLI> CBLHLMDAOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CFKNNEFAKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x846F5F0", Offset = "0x846DBF0", VA = "0x18846F5F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float LKPPAGJEPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8470110", Offset = "0x846E710", VA = "0x188470110")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84714C0", Offset = "0x846FAC0", VA = "0x1884714C0")]
	public MNMEHCGPOED(LIJKMCLPLEC ANBGOGICGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84700B0", Offset = "0x846E6B0", VA = "0x1884700B0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8470FF0", Offset = "0x846F5F0", VA = "0x188470FF0")]
	public Vector3 OEFBNPACJDM(int IFMKBBDLCHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x846EF50", Offset = "0x846D550", VA = "0x18846EF50", Slot = "6")]
	public Quaternion CEHMIGOHPAM(int IFMKBBDLCHB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x846FFA0", Offset = "0x846E5A0", VA = "0x18846FFA0", Slot = "5")]
	public Vector3 DMJCDHHNMOM(int IFMKBBDLCHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8470DD0", Offset = "0x846F3D0", VA = "0x188470DD0", Slot = "7")]
	public float HNIAGNEJJAC(int IFMKBBDLCHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8470250", Offset = "0x846E850", VA = "0x188470250")]
	public void FHKNGGAKLFE(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO, bool BJIOMNMDJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8470E30", Offset = "0x846F430", VA = "0x188470E30")]
	private bool KEEJFFGDDGE(int HFNNMANCDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8470E90", Offset = "0x846F490", VA = "0x188470E90")]
	public void KIEONDLLHFO(Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x846ED10", Offset = "0x846D310", VA = "0x18846ED10")]
	public void AODFJKNEGFB(int HFNNMANCDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8470B30", Offset = "0x846F130", VA = "0x188470B30")]
	public void FOJCOOBFGEF(int HFNNMANCDPE, Vector3 APHHGJIDDCM, Quaternion LDAEEKEKDJC, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x846EDA0", Offset = "0x846D3A0", VA = "0x18846EDA0")]
	public void CDDBJBAJAHM(int HFNNMANCDPE, float3 APHHGJIDDCM, quaternion LDAEEKEKDJC, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8470C80", Offset = "0x846F280", VA = "0x188470C80")]
	public void HDLDPJKDBAB(int HFNNMANCDPE, Vector3 APHHGJIDDCM, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x846F630", Offset = "0x846DC30", VA = "0x18846F630")]
	public void DCEOCHGCNMJ(int HFNNMANCDPE, Vector3 EPCDDFCHPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x846F790", Offset = "0x846DD90", VA = "0x18846F790")]
	public static Quaternion DLEHNLCMLOF(Quaternion LBDLDEPDKMC, int HFNNMANCDPE, float APMDFHILOBP, BBLLJDDJMAF ONCPPCGCCMB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x846F150", Offset = "0x846D750", VA = "0x18846F150")]
	public Bounds CMMAHBAJGAB(Transform CCHLCEHOKAD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8470040", Offset = "0x846E640", VA = "0x188470040", Slot = "10")]
	public virtual void DNFDNBLOFGB(bool IMMJCJANIMA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x846F080", Offset = "0x846D680", VA = "0x18846F080")]
	public NativeList<KMFOEBEFONO> CKNACKOFDAC(float ALPMFKBMFLC = 1f)
	{
		return default(NativeList<KMFOEBEFONO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BJHHGDHGGLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public float3 PGBNPPMBLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public float MNAJFFMBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public quaternion JCPLBHEKABO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8469C00", Offset = "0x8468200", VA = "0x188469C00")]
	public BJHHGDHGGLI(Vector3 ALFMKPLFANJ, Quaternion LBDLDEPDKMC, float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8469B40", Offset = "0x8468140", VA = "0x188469B40")]
	public Quaternion KOGNJLHKGGB(Vector3 JPDMHOCEDGB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84696B0", Offset = "0x8467CB0", VA = "0x1884696B0")]
	public BJHHGDHGGLI IHFOODEBIKG(Vector3 LCNMNFJJBJP, Vector3 CIBFPKPGHMH, Vector3 PAEGOBDGKPA)
	{
		return default(BJHHGDHGGLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x84699A0", Offset = "0x8467FA0", VA = "0x1884699A0")]
	public DJODJDOOOJN JKBBKANDODD(Vector3 JPDMHOCEDGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class NFPJOAGLNEE : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x84720D0", Offset = "0x84706D0", VA = "0x1884720D0", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8471810", Offset = "0x846FE10", VA = "0x188471810")]
	private void KBJFIAEIJKM(Dictionary<Guid, Guid> CINJGJBFPBF, KFJDGKEEHON MPDAOADDBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8472070", Offset = "0x8470670", VA = "0x188472070")]
	private void KBJFIAEIJKM(Dictionary<Guid, Guid> CINJGJBFPBF, OOBCCFBHDLM AECGPCPLGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8471DF0", Offset = "0x84703F0", VA = "0x188471DF0")]
	private void KBJFIAEIJKM(Dictionary<Guid, Guid> CINJGJBFPBF, FKBOKFOAAIK OEOPFCDGNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public NFPJOAGLNEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AJLACNAEAJO : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8469100", Offset = "0x8467700", VA = "0x188469100", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public AJLACNAEAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ANOLNMGNMID : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x84691B0", Offset = "0x84677B0", VA = "0x1884691B0", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public ANOLNMGNMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DGFOCJDFACE : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8469E20", Offset = "0x8468420", VA = "0x188469E20", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DGFOCJDFACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AAFKEMCMBCN : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8464140", Offset = "0x8462740", VA = "0x188464140", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public AAFKEMCMBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FKLKOJGDCDN : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x846A2E0", Offset = "0x84688E0", VA = "0x18846A2E0", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FKLKOJGDCDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DAICCMBAJKK : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8469C80", Offset = "0x8468280", VA = "0x188469C80", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DAICCMBAJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PBKBDDKLOID : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8473E70", Offset = "0x8472470", VA = "0x188473E70", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PBKBDDKLOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class JIOOLJHLCJG : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x846EAF0", Offset = "0x846D0F0", VA = "0x18846EAF0", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JIOOLJHLCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class NDNBABNPKCO : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8471650", Offset = "0x846FC50", VA = "0x188471650", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public NDNBABNPKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class MOAAJCJHIHI : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8471550", Offset = "0x846FB50", VA = "0x188471550", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public MOAAJCJHIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class GLCLNKALKKJ : KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public static readonly AFOIBIPBCKI GCCMCJFOPFI;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x846DDD0", Offset = "0x846C3D0", VA = "0x18846DDD0", Slot = "4")]
	public void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GLCLNKALKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct AJNJONKJMPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public FJLAJMAFHGO AENIMEGPBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public IKDOHLKMJIE HNDOLCNGMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public Dictionary<int, int> FKCDMDKPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public Dictionary<Guid, Guid> EPIIEOOFMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public IKJDPDODNFF CCKLKBHBECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public bool DDOHGPEJNLK;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KGHGEPCGDKL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDDJFEBCOMB(EPKMGLIJKMH HGDFEFDCJFE);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NINDFMNNHKO
{
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private static readonly KGHGEPCGDKL[] NJIMMODCIGC;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8472A40", Offset = "0x8471040", VA = "0x188472A40")]
	public static void MHPPDNLKBOO(ALMOPHBCAAE CDDIADBJAOB, LGEECNFNGGB BKCFEDOKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8472150", Offset = "0x8470750", VA = "0x188472150")]
	public static void AJBDEPLFBFP(ALMOPHBCAAE? CDDIADBJAOB, LGEECNFNGGB JIJPLMAANNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x84723F0", Offset = "0x84709F0", VA = "0x1884723F0")]
	public static void GBBDMGNKABJ(ALMOPHBCAAE? CDDIADBJAOB, LGEECNFNGGB FMNPOOEHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8472670", Offset = "0x8470C70", VA = "0x188472670")]
	public static void LHGDNAADNBD(EPKMGLIJKMH HGDFEFDCJFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EPKMGLIJKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public FJLAJMAFHGO JNDMAOFPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public ALMOPHBCAAE CMEDEPJOKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public Dictionary<int, int> FKCDMDKPCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public Dictionary<Guid, Guid> EPIIEOOFMOE;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x846A230", Offset = "0x8468830", VA = "0x18846A230")]
	public Guid FGMEPCLFFOL(Guid JJCLDINKIFD)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IKJDPDODNFF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int POGFMIOEHHC, [Out] Guid EFLPCBBALMA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class AIMMAGINDFK
{
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private static readonly HashSet<Guid> BCIHAKJOAHN;

	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private static readonly HashSet<Guid> CEBCKLGACJJ;

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private static readonly HashSet<Guid> AMOBAJHPPNG;

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly ProfilerMarker LBCIILIHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private readonly HashSet<string> DFJMMOELNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private readonly Dictionary<long, int> HELHNAFPFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly HashSet<Guid> BONPHBNEGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly HashSet<Guid> EPGCLENICIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly HashSet<Guid> HNMPAMJFCLB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> KOLHJBADCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyCollection<Guid> MIMGHHGOBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<Guid> IFGMIKHALOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IReadOnlyDictionary<long, int> CECBKOEBKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8467760", Offset = "0x8465D60", VA = "0x188467760")]
	public static void OEOBDAHEMNM(LENDKCEJOHO EJMKPHCDBNP, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8466380", Offset = "0x8464980", VA = "0x188466380")]
	public static AIMMAGINDFK GOCPAMMBPMO(NIDHIPJBPAM PGEPJKBFLOM, BENHLLCEJIF? KCLFJDGMHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8466400", Offset = "0x8464A00", VA = "0x188466400")]
	public static AIMMAGINDFK HHFIKLDEFMA(LENDKCEJOHO BODJEJJPOCA, BENHLLCEJIF? KCLFJDGMHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8465DF0", Offset = "0x84643F0", VA = "0x188465DF0")]
	public static AIMMAGINDFK CHOAEBGCIDB(JGJHKBJJNFE MPLBHNFMMCG, NPNLCEPPPFN MEJIKACDFLB, BENHLLCEJIF? KCLFJDGMHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8465EB0", Offset = "0x84644B0", VA = "0x188465EB0")]
	public static AIMMAGINDFK CLGIAODBMEP(IEnumerable<string> DFJMMOELNFP, IReadOnlyDictionary<long, int> CJDKCLMHOPJ, IReadOnlyCollection<Guid> HNMPAMJFCLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8468D70", Offset = "0x8467370", VA = "0x188468D70")]
	private AIMMAGINDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8468F00", Offset = "0x8467500", VA = "0x188468F00")]
	private AIMMAGINDFK(IEnumerable<string> DFJMMOELNFP, IReadOnlyDictionary<long, int> CJDKCLMHOPJ, IReadOnlyCollection<Guid> HNMPAMJFCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84656E0", Offset = "0x8463CE0", VA = "0x1884656E0")]
	private void AEFBOELINJJ(NIDHIPJBPAM PGEPJKBFLOM, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8465B60", Offset = "0x8464160", VA = "0x188465B60")]
	private void AEFBOELINJJ(LENDKCEJOHO BODJEJJPOCA, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8466480", Offset = "0x8464A80", VA = "0x188466480")]
	private void ILLAKLBLKBM(ByteString? IOLCAFLKJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8464580", Offset = "0x8462B80", VA = "0x188464580")]
	private void AEFBOELINJJ(JGJHKBJJNFE? BOCNDANOLJJ, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8464500", Offset = "0x8462B00", VA = "0x188464500")]
	private void AEFBOELINJJ(NPNLCEPPPFN? MEJIKACDFLB, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8465980", Offset = "0x8463F80", VA = "0x188465980")]
	private void AEFBOELINJJ(IJIDMJNGJED? BDFBEIOCAGI, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8466180", Offset = "0x8464780", VA = "0x188466180")]
	private static bool GBOMMOCLBKN(IJIDMJNGJED BDFBEIOCAGI, int MKOJKGHNBHH, [Out] string? CFAEIEHLACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8465F40", Offset = "0x8464540", VA = "0x188465F40")]
	private static bool FFGJLNGFOJL(IJIDMJNGJED BDFBEIOCAGI, int MKOJKGHNBHH, [Out] Guid MLDNIONDEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8468500", Offset = "0x8466B00", VA = "0x188468500")]
	private static void OEOBDAHEMNM(NPNLCEPPPFN? BOCNDANOLJJ, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84674D0", Offset = "0x8465AD0", VA = "0x1884674D0")]
	private static void OEOBDAHEMNM(IJIDMJNGJED? BDFBEIOCAGI, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8468160", Offset = "0x8466760", VA = "0x188468160")]
	private static void OEOBDAHEMNM(JGJHKBJJNFE? BOCNDANOLJJ, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8466E80", Offset = "0x8465480", VA = "0x188466E80")]
	private static void OEOBDAHEMNM(FJELPMMGBOL? EMOGDLPNEGA, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8465360", Offset = "0x8463960", VA = "0x188465360")]
	private void AEFBOELINJJ(FJELPMMGBOL? EMOGDLPNEGA, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8466A80", Offset = "0x8465080", VA = "0x188466A80")]
	private void MFIKPOILCLP(Guid? JJCLDINKIFD, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8464F60", Offset = "0x8463560", VA = "0x188464F60")]
	private void AEFBOELINJJ(ALMOPHBCAAE? CMEDEPJOKEH, BENHLLCEJIF? KCLFJDGMHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84685D0", Offset = "0x8466BD0", VA = "0x1884685D0")]
	private static void OEOBDAHEMNM(ALMOPHBCAAE? CMEDEPJOKEH, BENHLLCEJIF KCLFJDGMHJM, LGEECNFNGGB NBLLMKFPHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8466C90", Offset = "0x8465290", VA = "0x188466C90")]
	private void MIKKDNPPCAL(string? MCILHLFIJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8466D00", Offset = "0x8465300", VA = "0x188466D00")]
	private void NDGDEHDHGKK(long BGLPCAMMGKF, Guid NCAGFINAFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8466E30", Offset = "0x8465430", VA = "0x188466E30")]
	private void NDGDEHDHGKK(CLAHEJHFPMH? IMPPKBFLHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8466DD0", Offset = "0x84653D0", VA = "0x188466DD0")]
	private void NDGDEHDHGKK(HBPNLGKGJGA? IMPPKBFLHPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct PFCNBGHBABK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class GKEOFPDOLEO : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private readonly IEnumerator<DictionaryEntry> DPOHFMKDFJP;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public DictionaryEntry DLDENEBDDCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x846DBA0", Offset = "0x846C1A0", VA = "0x18846DBA0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object HPFJLGDHMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x846DC70", Offset = "0x846C270", VA = "0x18846DC70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public object CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x846DD20", Offset = "0x846C320", VA = "0x18846DD20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public object MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x846DAC0", Offset = "0x846C0C0", VA = "0x18846DAC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
		public GKEOFPDOLEO(IEnumerator<DictionaryEntry> DPOHFMKDFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x846DA20", Offset = "0x846C020", VA = "0x18846DA20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x846DA70", Offset = "0x846C070", VA = "0x18846DA70", Slot = "9")]
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
		private sealed class AHLJHBGEJHC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x84644B0", Offset = "0x8462AB0", VA = "0x1884644B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public AHLJHBGEJHC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8464360", Offset = "0x8462960", VA = "0x188464360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8464460", Offset = "0x8462A60", VA = "0x188464460", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x84759B0", Offset = "0x8473FB0", VA = "0x1884759B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object HAELBKGFDIJ]
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x84758C0", Offset = "0x8473EC0", VA = "0x1884758C0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8475AA0", Offset = "0x84740A0", VA = "0x188475AA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8475800", Offset = "0x8473E00", VA = "0x188475800", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8475860", Offset = "0x8473E60", VA = "0x188475860", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8475A40", Offset = "0x8474040", VA = "0x188475A40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x84754C0", Offset = "0x8473AC0", VA = "0x1884754C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8475520", Offset = "0x8473B20", VA = "0x188475520", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8475580", Offset = "0x8473B80", VA = "0x188475580", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
		public RoomObjectCounts(Dictionary<int, int> DMPHGIMALPM, [Optional] Dictionary<int, int> HGBCEEAAKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x84753E0", Offset = "0x84739E0", VA = "0x1884753E0")]
		[IteratorStateMachine(typeof(AHLJHBGEJHC))]
		private IEnumerator<DictionaryEntry> KGPFOIKLNCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8475AF0", Offset = "0x84740F0", VA = "0x188475AF0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8475700", Offset = "0x8473D00", VA = "0x188475700", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84755E0", Offset = "0x8473BE0", VA = "0x1884755E0", Slot = "9")]
		void IDictionary.Add(object HAELBKGFDIJ, object KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8475640", Offset = "0x8473C40", VA = "0x188475640", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84756A0", Offset = "0x8473CA0", VA = "0x1884756A0", Slot = "8")]
		bool IDictionary.Contains(object HAELBKGFDIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84757A0", Offset = "0x8473DA0", VA = "0x1884757A0", Slot = "14")]
		void IDictionary.Remove(object HAELBKGFDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8475460", Offset = "0x8473A60", VA = "0x188475460", Slot = "15")]
		void ICollection.CopyTo(Array GHKPAFFMJAO, int PMIGBJGNLLP)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class EOKMGAPPIKG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x846A1E0", Offset = "0x84687E0", VA = "0x18846A1E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public EOKMGAPPIKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x846A050", Offset = "0x8468650", VA = "0x18846A050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x846A190", Offset = "0x8468790", VA = "0x18846A190", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x846E810", Offset = "0x846CE10", VA = "0x18846E810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IDictionary.this[object HAELBKGFDIJ]
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x846E6E0", Offset = "0x846CCE0", VA = "0x18846E6E0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x846E8C0", Offset = "0x846CEC0", VA = "0x18846E8C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x846E620", Offset = "0x846CC20", VA = "0x18846E620", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x846E680", Offset = "0x846CC80", VA = "0x18846E680", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x846E860", Offset = "0x846CE60", VA = "0x18846E860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x846E2A0", Offset = "0x846C8A0", VA = "0x18846E2A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x846E300", Offset = "0x846C900", VA = "0x18846E300", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x846E360", Offset = "0x846C960", VA = "0x18846E360", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B41580", Offset = "0x2B3FB80", VA = "0x182B41580")]
		public Invention(long NMILEMOAODL, int LMJBLNOIBOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x846E1D0", Offset = "0x846C7D0", VA = "0x18846E1D0")]
		[IteratorStateMachine(typeof(EOKMGAPPIKG))]
		private IEnumerator<DictionaryEntry> KGPFOIKLNCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x846E910", Offset = "0x846CF10", VA = "0x18846E910", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x846E4E0", Offset = "0x846CAE0", VA = "0x18846E4E0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x846E3C0", Offset = "0x846C9C0", VA = "0x18846E3C0", Slot = "9")]
		void IDictionary.Add(object HAELBKGFDIJ, object KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x846E420", Offset = "0x846CA20", VA = "0x18846E420", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x846E480", Offset = "0x846CA80", VA = "0x18846E480", Slot = "8")]
		bool IDictionary.Contains(object HAELBKGFDIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x846E5C0", Offset = "0x846CBC0", VA = "0x18846E5C0", Slot = "14")]
		void IDictionary.Remove(object HAELBKGFDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x846E240", Offset = "0x846C840", VA = "0x18846E240", Slot = "15")]
		void ICollection.CopyTo(Array GHKPAFFMJAO, int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> IOBKHNFIJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public readonly IReadOnlyList<Invention> AOPMBDFKMMA;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	public PFCNBGHBABK(IReadOnlyDictionary<Guid, RoomObjectCounts> NBECCJMADIL, IReadOnlyList<Invention> IAKMLMLFOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8474740", Offset = "0x8472D40", VA = "0x188474740")]
	public static PFCNBGHBABK GOCPAMMBPMO(NIDHIPJBPAM PGEPJKBFLOM)
	{
		return default(PFCNBGHBABK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8474620", Offset = "0x8472C20", VA = "0x188474620")]
	[CompilerGenerated]
	internal static int GFCEIMFLJOE([In] IReadOnlyDictionary<long, int> OPOIBHLBPOF, long? BGLPCAMMGKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8473F60", Offset = "0x8472560", VA = "0x188473F60")]
	[CompilerGenerated]
	internal static void DACAJKGOJGP(int IILJNNLFING, [In] JGJHKBJJNFE PJMIMLFBNEF, [In] Dictionary<long, int> OPOIBHLBPOF, [In] Dictionary<Guid, RoomObjectCounts> NBECCJMADIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum HOJHICJGBBP
{
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BENHLLCEJIF
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class KHCJNLNIBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public readonly Guid MOKHOFHMPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public readonly IReadOnlyList<Guid> MIMGHHGOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public readonly HOJHICJGBBP JAEPJMGMGPC;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x846ECB0", Offset = "0x846D2B0", VA = "0x18846ECB0")]
		public KHCJNLNIBEN(Guid EBBMLCHFLPJ, IReadOnlyList<Guid> HNMPAMJFCLB, HOJHICJGBBP LJNIMHNLCFF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly LGEECNFNGGB FJIDAINMHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly Dictionary<Guid, KHCJNLNIBEN> MFAHPKHPNBK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LGEECNFNGGB GNOOJGKNBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8469400", Offset = "0x8467A00", VA = "0x188469400")]
	public void MEFAAGOGBHI(Guid PAFHHBHFGDH, Guid EALDGLIMKDD, IReadOnlyList<Guid> LOFNMAKFABE, HOJHICJGBBP LJNIMHNLCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8469310", Offset = "0x8467910", VA = "0x188469310")]
	public bool LCKDBDJLFHP(Guid CFCALHCNLGO, [Out] KHCJNLNIBEN FDKHHMLANMG, [Out] bool DBDCFFNCDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8469610", Offset = "0x8467C10", VA = "0x188469610")]
	public BENHLLCEJIF()
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
