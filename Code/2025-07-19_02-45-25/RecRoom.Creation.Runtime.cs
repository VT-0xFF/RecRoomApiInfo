using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80DC6B0", Offset = "0x80DB6B0", VA = "0x1880DC6B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LIEPPKNDFOL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HCIPEFLNBBD;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> LNIKJOEDMMM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> COCHPAGNBDD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LNKOOMCIPKD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ADFIKDMNEDK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string NKNNGHLBNBG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string OKAKHOKMPAK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80D8640", Offset = "0x80D7640", VA = "0x1880D8640")]
	public static bool PHONDMJNLKN(Guid MNGMCBHONAE, int BOIGGPCEIHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80D7EE0", Offset = "0x80D6EE0", VA = "0x1880D7EE0")]
	public static bool ALFLGKIFBLH(Guid MNGMCBHONAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80D7F70", Offset = "0x80D6F70", VA = "0x1880D7F70")]
	public static string LGALBECPNKC(Guid JFLBGDIIGHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJGMAGCACGC]
public enum LDIHBKOMEAF
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
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80DBFD0", Offset = "0x80DAFD0", VA = "0x1880DBFD0", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AFHGIHKNEMF
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OFMHBPPKDHB;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid LICJABAHNNM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid CAMLBKJOPNE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NNMEDOFOLPG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid OINOEKHIFKB;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid NPJDOPMCBMM;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JOCKLPDBOFP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid PABPJDDFLEJ;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid OPDAOJCEBAP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid IHEMIFGEOBP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid DKMJDDLMDCM;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MNNKCPLGIEC;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid JHDIBCPJIDL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid CODFIIIPLEO;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid NBOFILHDKBB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid IMIBPDOJMBF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid HHHBNMHOGEK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid LGMKKDEMAIC;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JAPCGGAOFIA;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid APDOJKJBCDI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PHJBFLEDBNH;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GKOOKPICBJO;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HIKICLEKBFC;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid DMOJCCLCDIN;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid PGFOFOLKBGL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid DNKJPIHAKNE;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid HCDNIOMNIHK;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CHKINKPOLII;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LLLHFEMMOHF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid LNMOPDGDOBF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid KGKLCJKNNHA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid ENCCGMCHIIL;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid JLGGHFDIMGA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid LDBCCCCHKHL;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LGJEBMDDOIO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid ELJAIIKCJBC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid FNLBJBHCMCB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MDHHKEMEHKI;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid NMLEGKHKKED;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FDHECJLGKBD;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid DOGDJKJBBLF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid DFFGGENLCDH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid BGBDPKMGPEO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DNCLMPDGNDH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid KECEJAPKNIM;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid IENHDOEBLDJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DHNPLPJKPDA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid FMHOHHAEPFE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GJBEOCIOCPA;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid AKPCDAPFJNI;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid FBEJJOBIGGE;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid GENJJEJDMDD;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LKIFDCAGEEC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid DIONGHIFKBL;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NODGGLFIIKG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid PBKILAFOOHD;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FDGMDNLJNPD;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid PDDNFDJJBCM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MDDBBNNCLBA;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GKFOHOAGEPO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid IFLHAGPNACI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid MCFBIEEBJJC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid KAPCCAIDNDB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BLLAOHLIKLF;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid DMCDNECFIMJ;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BBBOFHGCAMN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid EBDGPBHLHLA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid OCAJKHHPNPJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid OEIJMLPDBGD;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid BIGLDLJCDDG;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid HMDGDCFFLLP;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CGAAAAKFHGC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid NFDNMLDJFBE;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HPCDLHIJOEO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid KILKLEHHALG;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HGOGGNACGPI;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IJKOBAIPFJK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid IBFGGCIENBC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PACOLNAFNLN;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CPJKBADNNBP;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid NHDAJBEDHKA;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid MCKALDMNCOL;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid FABILAJFPCG;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DDNIJJEEJEC;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid AANNLBIDAEM;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid AOMLHJJEDMJ;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IHBLLLIIDGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid CPFCMPJOPGK;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid BGGIFPGHHJM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid FEFOGBEOJEM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid DNLMALGKCBG;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid KMCDICBICFC;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HEJLNNGOCMK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OADMLAICDPJ;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid MGAAMJILEGP;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid DPLEIFHFIGL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid CLNLAFLEEFK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid HNHBILJFPNH;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JJGOJPPDCJO;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid OMEDOGEGHGF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid DLPMJHMECHB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid FPGBNOJBGOH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid JCABJKMEJFI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LGDOBJHCMPB;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid CMOKIDDPIKM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid EAPBOEAECKL;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EAAJBBPHLDM;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid NIDFFDBLELJ;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid DEFJHJJNDKG;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid FKHMMIMOEMH;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HHHLLCDGNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid FIGOJPIJAPA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KHPEOFNLNLN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PODOFGDGGIK;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid GBICGKGAIFH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PBEHCEAECAL;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid AMMDJAKKBAB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid DNEOMOIHNAB;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid LMCGBMNKEON;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid HLOJEJBOFII;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid AAAOOCOEDAH;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid OJGCMBAMCFP;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid HNLPDLPOBGO;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid COGOBNPMHDD;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid DFHACHJAPEL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid EMIKLGHNECH;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid MKBJPOFGBHP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OMMKODIGELF;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BLNCJFPJGBK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid AHPOCNGHFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FEOCKCOFCLA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid IDIEDIPHMEE;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid FCMAHGHJHIL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid BBMEHFBGPFE;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LANEGONAJEF;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid NKDNHKHGONI;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid ELNDKIDDMGF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid NDDPJAPJFFM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NAIDEANGBNJ;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid GEFJAPEPJCA;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FBFJJELJLPP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FOKNHKNLKEP;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid FLNIGEJBOID;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid AOCKGPMEMPB;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid NKMENMJOJJJ;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DFBCLBEOCCI;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OANHHLBNDEP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid DEPBLDCCCBA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PEFMKCPGJCB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MOFJGGFIJKL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid IMHNCOFJMFH;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid EFDHHDBMGDO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IOIMBMNDOGA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DAHPKJMFGLP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid PHPHHEAPDDC;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid LKHPKBFOFEA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OEFHKLLEHIM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid JEAGAFKAKNM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ILDGLONOEHD;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid LMGLDFNCIIL;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BANIKILMAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BELKDKDHIOP;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid CFIAGDHPLHN;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid GAKNDJOOLEA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid JDBMDMKDBDM;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KGBOGKCPIGM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid IEOFNDLOGBK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DDDLNMLAOOH;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid MLBHICKEMDC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OBJPPMIJFAH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid NPCLAKEAOKG;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PPBDKJGDEEM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid HGEFHBHEKEO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid CMMEGHDGIPH;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BPHEOFMJBFK;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OCLBLNFIGLG;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid MDCLDPMFJNM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid CLHGGDOLDAN;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DBFJOCMMOKH;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HBDOFJIPAAK;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid MBEAIKACODA;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JLKLMJIOEEL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DEMKDDLMCOC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MGHJMOEPAOB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid OMCEFGKPOIG;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JGJICAOGDMA;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BOBMBDHBLHE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid MFDLIPBOMEJ;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DIOGMGBCKCL;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DBELMFGHOIF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CPMIFDPEGED;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid EOMEAMILCDI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GNCFIACOBDH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CIJDGCJFHBD;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OHMJCIHNKHA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid NKABFFMIBNG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BGGAALPNDNF;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid ILALHNMDBHO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid HKIJMFNKLLG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid NPKCHNJFDMC;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NJOFMKMDEAD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EDOOONGKOPF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LNCENKAJBAI;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid JBGGJJCGLHJ;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BPMHENFOIPK;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FFKLEEJLLJM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid GIILCKKFNNC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GODBOBCBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GJICPJJFAIB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid ODMAEGFAPPI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid KHJJHENJEHE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid JFNCGDIKHEC;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid NLBHPLBEANI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GLHAGOKHAEL;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid BDGNNHGJGGE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DGEFEKEDPCG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid BGFDJMCPGIH;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid CIGLCBNNNCL;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HLIFKNGCGOL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid LNFMDLNIHGI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PGHBICBNGJH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid DLBOCHLFGHL;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DNEMJLMIBPA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid PHENGMFNIBN;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BKACGHLAFPA;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid GEPIJPIPMPF;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid BCMEGMAMNKH;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MJMJDBHFOGH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid FJACKPEECLP;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid PJMMAGJKOKO;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid LAIONJKLHHO;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid LNJAMPAIMHK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FOMANLLANIC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HBJCPOPMIBL;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CPJCEGLGIPH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid IKEDBBABGMD;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid AEOJDFBGFAP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid JLEEEOCPEJK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ALDPLIEMDIH;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid GHMONNNPGDC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid BMKKMIPCGHG;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid AKMNLIJDENL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid PHEIPBHNEOI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid JPKENGKKDBH;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid HAPLNHLLPGK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid EEJHKMACCND;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PFIBHICCAFF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid KNBHFNOIEEL;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CPFJCMEECJH;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid FKIAHELBGKI;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid EIOJBGBMNHO;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid FKJOACHGAAA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid NBAFLOEIGOB;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GJHECPEJKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid EBKAIIKIIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid IBHLLCBHHIP;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid IGFEPNAJHIP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid DFBKCNLADOE;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PCCMMKPMFML;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HEMGOBPBEOO;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid HCCBABEBOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OGMMPDIJMIE;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid AAFPBFJEHEK;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid EOLNKLMMCLC;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid MJAAKOGAKOH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CODBHBEILMN;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid JGEHAKGOFNO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid PKGMDGDKJKL;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid DOANEECAOEL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid IDNKHIACGKG;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DPKBCGHEEDG;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid ALLKFKGEHKP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid INNOFCBOGKD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid HJCOBOBKHAG;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid IDMACKLJFII;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid FNENJIACACP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid MLMDBMDCEEK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid ABNGMCHPNMA;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LGMJJGPBGFF;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid GKIJHOFHMEH;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid KHEAEAAODGD;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid CGFBMBIHMIB;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid CGKGNDHLGNG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid EBHEPBJCPOJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid BOJGLBAPOPG;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PEHGEAFHLCG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid AOAPIECPHNL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IKABBJCIAIN;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid HIIFMOLIPKC;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CKDAEGHIMGJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid FNIJCFLIOPD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid AKIJFLAGFFF;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JDFFCFNALBK;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid DDEEFHPPBIJ;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid KHBHALIGKEF;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NIPMGDMHLEA;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid EHIPLCCABMN;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid JKMPPCEKFND;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid BFMCPKOIDBD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid IJGFAKAODLI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid GNBPEFMOKDF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid NDGIMEMJONJ;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid ONACFMJHHIF;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid GAIAMPGJLKB;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid IDNGFGCBMHB;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid IKPNIDAFECD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MFMJNHLGKIP;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PMPKNDAFCBP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AIFHGAOELGI;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid KEECJDFMPHP;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid MKCPIOHGFFF;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid IHLDLCMOKKH;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid MDJEIAHIMEC;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid AKCIPGAIGFC;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LHEFHKEFDKI;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid ICFNACAONLE;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid AKJFNNNBGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PKBCBPCNEAH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HHGEKIPPHNE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid AJGMNEHIEFO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid GJKEJKEFMAE;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid EOLNOBKLAGC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NPGEKKGACJN;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid DEPPENEMEIF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid OBODIDGNEPJ;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid MJJGAJHJMLL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid JHBOAENAKAK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid INJADJKOOIK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid KCHDBEIOBLC;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NDDFKDGMGJK;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FAMGMCHFMNC;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid IMBGPFKDPON;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LMKJONOCAJF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BHEHMNMDFCG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid GFMMCGAHBND;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid BLJOFCMCLOH;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid HBPPBHDFCIF;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid LLAHGPAJOMJ;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid GDCMGOHGHHB;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid BDMLKCECJNE;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BMDAGCGMABH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IBIEHIAJFOD;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid MHGIELBJBLB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid CIOGNEKEEHC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NFCEJAAFAIL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MAONFFAMJME;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid AFMJLPJFCJJ;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KHCEIDGKLDB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GKFBDBMAPMP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid GCFNHKPGGBN;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KANLNKPGFBN;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NDFIIABHMBH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid NDACNIPBJIF;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CPFBCAGLIIH;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LIFLJMBFLDH;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MJNOLNOIOFJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid AIJDBMKLGOK;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid OFNNCGEOGBK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KACCHLCHPKC;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid FKGGJHAGNIB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid GCJGPMBEDBC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid EINKCOIACDF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid BCGOOCPECGJ;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BCJLCNGADMM;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid AIIIPGCJPFL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid EIFCLCBOINP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid HPKMMKKIFJM;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid OBEMMAPELHI;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid PCCJFEKDKBK;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KHFEHIJGCMK;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid BMGNKDKKPBK;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid APLDKMENLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid IJNDHJDHELA;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid EKOCEIEGJOO;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid PMMPAPMANAG;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid AJBPHJGIIEB;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid NEJMACNENAK;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid LOPEMIHFAHJ;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid BBGJLNELPHE;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid HJBFDPGNKMJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid LCANOOELMGB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HEFMJELHALC;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid GNHEENAHIND;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid FHMHKONFOBM;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid ICDOLCGJNHO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OEODAONNPAB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HOFNBNEHCBC;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DOPBBAFEAOF;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CFNNBANGCEO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid OPCHCJDNLNN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BAJEFDDKDHL;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BDDCEAIOCLP;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GJEAIPHOLHE;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BPMLFBKEEAN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FNMEGJEEKAI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid EADIHMJLMNH;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CIICJNOBIAN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LEAAJDINHBI;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CFCDALBKKGH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid HHJDLDKJGOH;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid FIPCEMMNJKA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid MLCLOHFNLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid HKKHIPAHLAK;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid BJMEBBLOFCM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GLOKKHMFHMK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GIEEGMKACHG;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EGBAKLFBMNL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OPIAMEFBPKO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HGJMKCAIFEK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OKDJDJLBBEB;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HCDHAFCIFOE;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid ICENDLKIHCN;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid KLJGFONNLHC;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid OACGBONACCC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid FCENHBDNNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid DGBCPJBMGOB;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid LHPGMOONAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid AEPHOGHCDFM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid ILOGEHJLGPG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid CDCINIOPDML;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid AINMBOBBBLM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid DOOFJAAHBKE;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid KGFGEKDAJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid EIKKNHFEHKH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid IDPDDCFABJF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PGAOLLCKPPB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CLIDPECKPEP;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid CDBGFPFKPJL;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid JHPKANIALIG;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid CLJBBAGBJHG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid KLNDNJAHEHC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BHILDACKEHB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid KMHLCPLAMFF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PABHDKEDCCA;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid FCIMKHKLBKC;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid HEJFPLPCNOI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid MHMJODBNCDE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid GFPPGDOMLDF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid FKNLJLBPGBI;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CMDBKGEBEHF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IAPDKCFJAMG;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid ILIDEKDDOEO;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LEAEHHDOEMP;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid MECCHOEEJMB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GEEHJJFCKIB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid AIEGOHONHAD;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid GMOKNKDKFKP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid KAJOLENEPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JLHJFMGBPKC;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MMIEINKFLPB;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid LMHPJMAPAOG;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid IGDLFDPCFOP;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid OLOEFMFGLOC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PKLLDACIIMA;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid ALGIOLDKBAB;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GENKOKMBJFN;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid HIIJABPEAGP;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid FHKOOMEACOL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DKMNEPEODOD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid OOMAOACODJK;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid LIIPIGHKLME;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid GHLPFJDEMOC;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid NAHKPDHPACG;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HGPHOMOJMFN;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid IJCGBMEBKIM;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid HCMPBDGDFGH;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid DCKOLFBICJB;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid COFNMAIBMBL;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid GFFCBIPBJFI;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EJHKGPPDCAC;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CMHBDLIKFLD;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid DMOAPELPGHG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid NEEADLEMFEB;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GILNNLMCLED;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid KOANAAOIPJM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid ECDFOHDEGPB;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid APNCDMIINOC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HPHKMPOJPDE;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid BCMMGJICPAP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid HNNJBLCADIN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FEGJLDDDDGD;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CGFBCIGLAPN;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BAEMEMDHCME;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PIAHJLJHGPI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BPNNPADLLPG;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid JOCEFMHIKCF;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid HBAFJFKFKOG;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MCANKOAFPIO;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PMAPNCHELME;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid LNNJFOOEHFN;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid AHJCGOENHEP;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid IJJLOHDMPEL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CMHHAIKPDLL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HNBCKCPILLH;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OHJFCHMIPPL;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid ONJJCKOCLEA;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid HJODCPLOAIC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KEEBJNNJPJH;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid NNIGJFKAICA;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid DEEHFIPEMND;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FAMBCNCHFDM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid ANINCJJKLAG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FEFEFDHPIHH;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NMPFBHOLKLP;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid OANOOBIADHD;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid JDLELDOECAG;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid GAPKBDOEOHG;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid EHEOOIOKHHH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid CAPMIGNPLJC;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PMEAMGONNMF;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid FGMDEOMIPKL;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CGAJDJCBDBM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid OOGLPKBNKNL;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EELONKBHDGB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid JIPOIEJAGKO;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BIGOMOILHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid DIOKFNOHHIC;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GKFFJNONGJA;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CCDFHEIKCMH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KIHPNBEIADK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JDPCBFAMDKA;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ADKOMJGBHHJ;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid PMFNBAMEPHK;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LKDNDLAEODM;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OHLFGMJMCGM;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GONAEEEAAGO;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid NOMMBCCFMKN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid NKALOJPKHHP;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid JJPJJDKFOFA;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid BAGAODMELIG;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid JGEMNKODNHD;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid NDDEHHICPIF;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid HEBLNLJMIKD;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid INLMKKAPNEM;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid MLKONEBGCBJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid POOOOCJPMNH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid ACKKANNHBEM;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid FCNGANLPKPJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid JPEEHIHOAEB;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid IJBHKGCMHNH;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid IHGEPKCHBDL;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BFIGJALCEGP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid OLHMBNKAJFI;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid PGBIFLNJDKM;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid CDMPNOFEKKF;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid AOKFDPMDCML;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid OPPCBJMCCFA;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid MKJGPPOEPIK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid BCMOFODGIFD;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid BNACDHOICIC;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid MEEDAOCDIJK;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid OCPNCIMEMFL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid JGLJEHAHLFJ;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid GJCINDENHEJ;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid IPIKLFJFLMM;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid JHIGCFJNHOP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid APPBGIHPJCP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid JKHLJILNHNK;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid DJOMKENJCIG;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KCHMKGOPNIA;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid OCBPNDBGKLP;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid KEOOLIOLFOM;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid NJGOOBJIFAA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid DCFNPLJEAKA;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid FMNPBJLJLJA;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid BEEODBCFJCI;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid GACCJHLJPIL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid AFECPNKFKOD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid JPCMFGCINOD;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid IONODANPGHC;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid DIMPOOJGNJK;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid BBELKGKDNBK;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid DMJEHLELMEK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid LBDLJMLIGPO;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid OEEKOKJEBGP;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid EPFBPDNNLKE;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MKKOJENIOAO;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid AMDIBPGPBBK;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid OHCFNIIEMLC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid CCEGOHCAJKG;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid GIONOEDALGL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JMAMEGHGPDM;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid IFBOFBDELOE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid KLOIFJOMAJK;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid HAFPKBILACI;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid KFNLGPLKLKF;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid ILHBCIEFFAD;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid KMLFDPBMLON;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid MAAEKCLJOEC;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid ECHCCOOCFAK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid MMAEAMGIDGL;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid PAOHMNIBPJG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid JLGEIPKJIAA;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid AGBDNOFFCEF;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JFFKMGFJDHJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid POMHKANIMHM;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid JOLINKKKMNM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid BGPMEKJDGKF;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid JLJAGFHBGLA;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid EBBPNEIOEIP;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid BJFJADFFFKK;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid IIPFNGIBDAG;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid FOMPHFMHLMH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LFBBPKAADEM;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid CNGNHABAMEP;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid BDLGJDABFKM;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid ODEINDCDOEH;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid OLDJCBMHHND;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid LOMPIBMLBMA;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid ICCMJOLAMDO;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid HCDAFKDIKOM;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid EEAAKJPHKNO;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid FKPDONCDLHC;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid OLLNDDKLKKF;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid DDDPGJPOIEG;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid NBEPDABCEDD;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid MJEGIMPHCGM;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid KKFDGIJIKCL;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid BMCIGPIFEFJ;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid KFFAKOBJCEG;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid MCADNADODKA;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid LCIJDGMEAKB;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid OBLGBGDMJPF;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid IBHGHLCMAIN;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid DIANPOLGLBF;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid PACJEMBNMIK;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid FMJJCFGBOCN;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid LELFAKOJBMO;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid OOJNLGJJFJI;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid OJBJCCCNKGF;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid IHBBIHODCIO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid KLODHJGANBA;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid GAMMOJHMKPG;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid NLKPCMAFEAN;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid AEALCKEEIHO;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid GECNKGNEKKL;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid PDAMEABIBGB;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid LCIPMIAAFFL;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid CLOMKDAMOAA;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid ACPEPIOIBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid IBMEFPDNMKO;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid CMKACLDHOKP;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid CCNGFEJHLLK;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid AGBAENOEHLE;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid JEHNODDPAFH;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid AIJDACOBNMG;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid AEOOIKAJDON;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly Dictionary<Guid, LDIHBKOMEAF> AOBBJJBNMEA;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly Dictionary<LDIHBKOMEAF, Guid> OAFHNPFPHBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LDIHBKOMEAF> FDKNMBPLFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80C98B0", Offset = "0x80C88B0", VA = "0x1880C98B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LDIHBKOMEAF, Guid> MOOHLGDKANO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80C9910", Offset = "0x80C8910", VA = "0x1880C9910")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AMFKIEADAMK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x80C9D90", Offset = "0x80C8D90", VA = "0x1880C9D90")]
	public static bool KNLIAOKJPGK(KJGFLHAIJPF PHPGNIBIPOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x80C9970", Offset = "0x80C8970", VA = "0x1880C9970")]
	private static bool KNLIAOKJPGK(HLJDEFAJFEC BMNJGIBEPLM, KJGFLHAIJPF PHPGNIBIPOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ODFKJLBIFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(DLMAGNBMHFN INCJDDLACNP, [Out] Dictionary<int, int> PKAHGOPOEDI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(HDAFNIGDFEN EIOEKEEKFGG, CBJCLJJKMJM KMNEDPLFCHD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EPEIPCLJNFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly FENGPBODGKE NJPHMHJPCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IEnumerable<NFPOLOGAGBB> EOGICNFJKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<NFPOLOGAGBB> JLDFEFEAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly OCIDMCEKJIP<FJLLKPMEKPL> PKBAKCBPIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly IReadOnlyList<KPKGHKLEPDF<HENCEPHGHEP>> PPIFAHLNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly FLCGCAOAACM ELGFHPPGNHL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HLMFHOAOOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x80D74E0", Offset = "0x80D64E0", VA = "0x1880D74E0")]
	public EPEIPCLJNFB(FENGPBODGKE EDPKNDPEAMB, IEnumerable<NFPOLOGAGBB> GLILNIKDFLG, IReadOnlyList<NFPOLOGAGBB> JMNKFONOLPF, OCIDMCEKJIP<FJLLKPMEKPL> GKKFBPOHIBF, IReadOnlyList<KPKGHKLEPDF<HENCEPHGHEP>> NKFOPPINIFL, FLCGCAOAACM JFHCPLDHICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ILONADGIEFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly FENGPBODGKE NJPHMHJPCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<NFPOLOGAGBB> CKFFFJJJNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly OCIDMCEKJIP<FJLLKPMEKPL> PKBAKCBPIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyList<KPKGHKLEPDF<HENCEPHGHEP>> PPIFAHLNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ByteString MFKGLGKGNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly FLCGCAOAACM ELGFHPPGNHL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80D7E70", Offset = "0x80D6E70", VA = "0x1880D7E70")]
	public ILONADGIEFC(FENGPBODGKE EDPKNDPEAMB, OCIDMCEKJIP<FJLLKPMEKPL> GKKFBPOHIBF, IReadOnlyList<KPKGHKLEPDF<HENCEPHGHEP>> NKFOPPINIFL, ByteString GCPGFLNMMKN, IReadOnlyList<NFPOLOGAGBB> MDDKLHFHCGG, FLCGCAOAACM JFHCPLDHICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AEIOPFEPOFF : JOLCCMOHKAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly Guid OALOLJENENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly Dictionary<Guid, Guid> JPAPECBEEIF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F3E0", Offset = "0x4E1E3E0", VA = "0x184E1F3E0")]
	private AEIOPFEPOFF(Guid BFMHNPDFFJF, Dictionary<Guid, Guid> JPAPECBEEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x80C9770", Offset = "0x80C8770", VA = "0x1880C9770")]
	public static AEIOPFEPOFF MPFKOOIPONO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80C96C0", Offset = "0x80C86C0", VA = "0x1880C96C0")]
	private static Dictionary<Guid, Guid> MMJMGBDKFFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80C98A0", Offset = "0x80C88A0", VA = "0x1880C98A0")]
	public static AEIOPFEPOFF OGIMJAAKHLH(IReadOnlyDictionary<Guid, Guid> BKFMBMLFOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80C93D0", Offset = "0x80C83D0", VA = "0x1880C93D0")]
	public static AEIOPFEPOFF KOMCFCKPECF(IEnumerable<KeyValuePair<Guid, Guid>> BKFMBMLFOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x80C8F10", Offset = "0x80C7F10", VA = "0x1880C8F10")]
	public Dictionary<Guid, Guid> DPONFMKGGPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
	public Dictionary<Guid, Guid> IHBGGIKIAAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80C8E90", Offset = "0x80C7E90", VA = "0x1880C8E90")]
	public void DOPEKGIEJEC(Guid BKFMBMLFOLE, Guid HCPHGFGFIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80C9000", Offset = "0x80C8000", VA = "0x1880C9000")]
	public void FMFHLGCFNJF(IReadOnlyDictionary<Guid, Guid> GIHLJMADJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80C9280", Offset = "0x80C8280", VA = "0x1880C9280")]
	public Guid GKPFIEDCNDO([In] Guid BKFMBMLFOLE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x80C9800", Offset = "0x80C8800", VA = "0x1880C9800")]
	public Guid NPGODMAMNCO([In] Guid BKFMBMLFOLE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80C8F90", Offset = "0x80C7F90", VA = "0x1880C8F90")]
	public bool FHNBINMJCKD([In] Guid BKFMBMLFOLE, [Out] Guid HCPHGFGFIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80C8F90", Offset = "0x80C7F90", VA = "0x1880C8F90", Slot = "4")]
	private bool OGBKBCCEPFB([In] Guid BKFMBMLFOLE, [Out] Guid HCPHGFGFIBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KPLDMHFKHLM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMHOHELFFNG(Guid JFLBGDIIGHK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KMIKCJPJFPH(Guid JFLBGDIIGHK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PHFACCKEMLF
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
public abstract class NOEKPCJEAHJ : KPLDMHFKHLM
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IEMDIAGILCJ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public IEMDIAGILCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80D7CC0", Offset = "0x80D6CC0", VA = "0x1880D7CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80D7E20", Offset = "0x80D6E20", VA = "0x1880D7E20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80D7D80", Offset = "0x80D6D80", VA = "0x1880D7D80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80D7D80", Offset = "0x80D6D80", VA = "0x1880D7D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GCCNFANDONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public NOEKPCJEAHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7550", Offset = "0x80D6550", VA = "0x1880D7550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80D7C60", Offset = "0x80D6C60", VA = "0x1880D7C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private Dictionary<string, HashSet<Guid>>? PPHMBIODPCF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> ELDBBCFAMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80DC4F0", Offset = "0x80DB4F0", VA = "0x1880DC4F0")]
		[IteratorStateMachine(typeof(IEMDIAGILCJ))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? BDBJNFDLGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool CCMONJCBJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool APMBGDFLKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> EALPGMHHEEN(string PJFFNNLBKHD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x80DC410", Offset = "0x80DB410", VA = "0x1880DC410")]
	[AsyncStateMachine(typeof(GCCNFANDONM))]
	public Task GEFLNIHHMMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x12C4280", Offset = "0x12C3280", VA = "0x1812C4280")]
	public void JPJFAMEFLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80DC160", Offset = "0x80DB160", VA = "0x1880DC160", Slot = "4")]
	public bool FMHOHELFFNG(Guid JFLBGDIIGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x80DC550", Offset = "0x80DB550", VA = "0x1880DC550", Slot = "5")]
	public bool KMIKCJPJFPH(Guid JFLBGDIIGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80DC0A0", Offset = "0x80DB0A0", VA = "0x1880DC0A0")]
	private bool DACFOOCNLMB(string DBDMGCPDCEK, Guid JFLBGDIIGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected NOEKPCJEAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ELJEHCCAIIA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BOKLJKKNIKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public FENGPBODGKE staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BOKLJKKNIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x80DFF90", Offset = "0x80DEF90", VA = "0x1880DFF90")]
		internal OCIDMCEKJIP<MGGMPJOFOCO> JJKMJKHOGKE((OCIDMCEKJIP<FJLLKPMEKPL> GraphId, OCIDMCEKJIP<HENCEPHGHEP> NodeId) i)
		{
			return default(OCIDMCEKJIP<MGGMPJOFOCO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private static readonly AOPCIKCNONB<MGGMPJOFOCO, int?> MCBKCGFOIEF;

	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly long DLLIKHLLNGP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80C9DC0", Offset = "0x80C8DC0", VA = "0x1880C9DC0")]
	public static (long, long) JDHHFGLNOKC(FENGPBODGKE JAPMKIKEFLN, OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<HENCEPHGHEP> OMEKNOMEFGA)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80CA380", Offset = "0x80C9380", VA = "0x1880CA380")]
	public static long JLDODHPHFJP([In] ReadOnlySpan<OCIDMCEKJIP<MGGMPJOFOCO>> IKBONNMECBB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80CA260", Offset = "0x80C9260", VA = "0x1880CA260")]
	private static long JEHMIDPJCDK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class APBBPLCFJDN
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public static readonly HashSet<LDIHBKOMEAF> IKHHJKEADOL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AFHNCPAOCPK
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FCBOFOJENDO : IEnumerable<NFPOLOGAGBB>, IEnumerable, IEnumerator<NFPOLOGAGBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private NFPOLOGAGBB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private MJIKPNKKBEG spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public MJIKPNKKBEG <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private OIMFDJIMADA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public OIMFDJIMADA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private NFPOLOGAGBB System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public FCBOFOJENDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x80E7060", Offset = "0x80E6060", VA = "0x1880E7060", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x80E72E0", Offset = "0x80E62E0", VA = "0x1880E72E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80E7170", Offset = "0x80E6170", VA = "0x1880E7170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NFPOLOGAGBB> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80E7170", Offset = "0x80E6170", VA = "0x1880E7170", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80DF9C0", Offset = "0x80DE9C0", VA = "0x1880DF9C0")]
	public static MJIKPNKKBEG MPDENPNJOKH([In] ILONADGIEFC LBNGHEMJPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80DF830", Offset = "0x80DE830", VA = "0x1880DF830")]
	public static MJIKPNKKBEG MPDENPNJOKH([In] EPEIPCLJNFB LBNGHEMJPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80DCA10", Offset = "0x80DBA10", VA = "0x1880DCA10")]
	private static HashSet<KPKGHKLEPDF<JOIDJCLFHEB>> CIINPJCNMOC(IReadOnlyList<NFPOLOGAGBB> MNJFHAHKNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x80DECB0", Offset = "0x80DDCB0", VA = "0x1880DECB0")]
	private static void HNGIKEMBPKK(MJIKPNKKBEG LGJONPCIONH, [In] EPEIPCLJNFB PNDEDPDLOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80DD6D0", Offset = "0x80DC6D0", VA = "0x1880DD6D0")]
	public static DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL> DEHGHBFLKKG(MJIKPNKKBEG LGJONPCIONH, OIMFDJIMADA PHBJGGHMNDO, AEIOPFEPOFF? MBJEDLHHNCD, bool OAKHLIJBMNB)
	{
		return default(DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80DFB40", Offset = "0x80DEB40", VA = "0x1880DFB40")]
	[IteratorStateMachine(typeof(FCBOFOJENDO))]
	private static IEnumerable<NFPOLOGAGBB> ONKPHLKJIJE(MJIKPNKKBEG LGJONPCIONH, OIMFDJIMADA PHBJGGHMNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80DF7C0", Offset = "0x80DE7C0", VA = "0x1880DF7C0")]
	private static void MIBPPMOMIGK(MJIKPNKKBEG LGJONPCIONH, OIMFDJIMADA PHBJGGHMNDO, IReadOnlyCollection<ByteString>? LJCJOIHHHIP, IReadOnlyCollection<ByteString>? EOBCPCIDPJF, IReadOnlyCollection<ByteString>? PKLPJGKDGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80DD040", Offset = "0x80DC040", VA = "0x1880DD040")]
	private static bool COJCLPBKKAC(MJIKPNKKBEG LGJONPCIONH, HDAFNIGDFEN EIOEKEEKFGG, OIMFDJIMADA PHBJGGHMNDO, [Out][NotNullWhen(false)] string? MGECNFLHDHF, [Out] Dictionary<int, int> PKAHGOPOEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80DC730", Offset = "0x80DB730", VA = "0x1880DC730")]
	private static Dictionary<Guid, HLJDEFAJFEC> AGEKNDOCILF(MJIKPNKKBEG LGJONPCIONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80DEC20", Offset = "0x80DDC20", VA = "0x1880DEC20")]
	private static void GMHHMHLBKOA(bool BNGPIKJPJBE, NFPOLOGAGBB ECILKPBELDK, AEIOPFEPOFF MBADOCGINHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80DCDB0", Offset = "0x80DBDB0", VA = "0x1880DCDB0")]
	private static void CNEANOEONPL(NFPOLOGAGBB ECILKPBELDK, Guid ACHLNPFJANI, JKEFCKMOIEK? GAOOPFKOBCP, Dictionary<Guid, HLJDEFAJFEC> KLPAKLCLMAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80DF310", Offset = "0x80DE310", VA = "0x1880DF310")]
	private static void KIBMILCOFLI(IEnumerable<NFPOLOGAGBB> HHFKIKGBIKK, IReadOnlyCollection<ByteString> LJCJOIHHHIP, IReadOnlyCollection<ByteString> EOBCPCIDPJF, IReadOnlyCollection<ByteString> PKLPJGKDGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OIMFDJIMADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public bool BNGPIKJPJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public FLCGCAOAACM JFHCPLDHICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public JKEFCKMOIEK? GAOOPFKOBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public JKEFCKMOIEK? FPAIFOCEPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public FENGPBODGKE AEEHEAMOOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public PHFACCKEMLF NNAJOHMKJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public ODFKJLBIFEG DNNKMBNAEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public KPKGHKLEPDF<FJLLKPMEKPL> KHOGPFOCABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public GILAEPOFEOK LLKDEOHBBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public List<NFPOLOGAGBB> OOJNJNLKOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public ENKCMKGNHEJ PIGFCDMOMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public POBPAJJGBOJ MJPJFBIFKIL;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JKEFCKMOIEK
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private const float MCJJPALBJAA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public Vector3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public Quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public float AJNABLFIHCD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 FIEMJNBGBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x80E8B80", Offset = "0x80E7B80", VA = "0x1880E8B80")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS IPKLIOHEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80E89C0", Offset = "0x80E79C0", VA = "0x1880E89C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x15DB7D0", Offset = "0x15DA7D0", VA = "0x1815DB7D0")]
	public JKEFCKMOIEK(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float AJNABLFIHCD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80E8D20", Offset = "0x80E7D20", VA = "0x1880E8D20")]
	public JKEFCKMOIEK(UniformTRS PHBKENDFCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80E86B0", Offset = "0x80E76B0", VA = "0x1880E86B0")]
	public static JKEFCKMOIEK FCDLGEHPKDB(JKEFCKMOIEK EBJBKAEFOPM, JKEFCKMOIEK KNKPKBMPKJG)
	{
		return default(JKEFCKMOIEK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80E8A00", Offset = "0x80E7A00", VA = "0x1880E8A00")]
	public static JKEFCKMOIEK MJOOONLKLLN((Vector3, Quaternion, float) INCJDDLACNP)
	{
		return default(JKEFCKMOIEK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80E8A20", Offset = "0x80E7A20", VA = "0x1880E8A20")]
	public static JKEFCKMOIEK MJOOONLKLLN(Matrix4x4 DLJLANCEEOF)
	{
		return default(JKEFCKMOIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80E8C90", Offset = "0x80E7C90", VA = "0x1880E8C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80E8420", Offset = "0x80E7420", VA = "0x1880E8420")]
	public JKEFCKMOIEK CPFOHFJKJFB(Matrix4x4 PLPGMCABFBF)
	{
		return default(JKEFCKMOIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80E8640", Offset = "0x80E7640", VA = "0x1880E8640")]
	public static JKEFCKMOIEK DADNIIJNMBF(Vector3 EBGKGBGFPOC)
	{
		return default(JKEFCKMOIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80E8930", Offset = "0x80E7930", VA = "0x1880E8930")]
	public readonly FCDFDLEBKGO GOKBMMCNCMM()
	{
		return default(FCDFDLEBKGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JLHNGEOBOFF
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct LJCNAPOFLBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly KCLNCGJMKII EIGJJLPLNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly BJPMMCEJAGH APMACDBNKCN;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x188EFE0", Offset = "0x188DFE0", VA = "0x18188EFE0")]
	private LJCNAPOFLBL(KCLNCGJMKII CBONFFLHKGG, BJPMMCEJAGH GKIDLPDHAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80E9BE0", Offset = "0x80E8BE0", VA = "0x1880E9BE0")]
	public HDOCICHDABC AEMCDIHBGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80E9C50", Offset = "0x80E8C50", VA = "0x1880E9C50")]
	public static DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL> MPFKOOIPONO(ENHFGEECAON<GAAICFLNCNK> GKIDLPDHAHM)
	{
		return default(DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80E9D00", Offset = "0x80E8D00", VA = "0x1880E9D00")]
	public static DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL> MPFKOOIPONO(HDOCICHDABC GKIDLPDHAHM)
	{
		return default(DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80E9DB0", Offset = "0x80E8DB0", VA = "0x1880E9DB0")]
	public static DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL> MPFKOOIPONO(string KKCILBODEDL)
	{
		return default(DAFIFKKNPFP<AEIOPFEPOFF, LJCNAPOFLBL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KCLNCGJMKII
{
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DOILECGDGBO : IDisposable, DLCDHJHIFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private NativeList<KOLICHJFOBE> JCIKIOMMJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private float FPNEDMBKALE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DDFFFHLEFPB JICIOLPIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(DDFFFHLEFPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MGDPCEGMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8AE0", Offset = "0x6FA7AE0", VA = "0x186FA8AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FPPEKFEGFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8AF0", Offset = "0x6FA7AF0", VA = "0x186FA8AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<LKDBPIMLOCP> EKEOJNIGACN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KHBPCAMHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x80E60F0", Offset = "0x80E50F0", VA = "0x1880E60F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float GBEDEEKDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80E6130", Offset = "0x80E5130", VA = "0x1880E6130")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x80E6B70", Offset = "0x80E5B70", VA = "0x1880E6B70")]
	public DOILECGDGBO(DDFFFHLEFPB OMENDEGIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x80E5B50", Offset = "0x80E4B50", VA = "0x1880E5B50", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80E5BB0", Offset = "0x80E4BB0", VA = "0x1880E5BB0")]
	public Vector3 EJELKIJONMN(int LFBGKHDOJNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80E43C0", Offset = "0x80E33C0", VA = "0x1880E43C0", Slot = "6")]
	public Quaternion AEMHDOLFCOB(int LFBGKHDOJNO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80E6980", Offset = "0x80E5980", VA = "0x1880E6980", Slot = "5")]
	public Vector3 OJPCHPDDCAF(int LFBGKHDOJNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x80E6740", Offset = "0x80E5740", VA = "0x1880E6740", Slot = "7")]
	public float LOPOCPOAEFI(int LFBGKHDOJNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80E45C0", Offset = "0x80E35C0", VA = "0x1880E45C0")]
	public void AMOBOPJPOAJ(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ, bool JECAFHNEHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80E6580", Offset = "0x80E5580", VA = "0x1880E6580")]
	private bool LFPCGANGCOG(int LNKIILEAJOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x80E6270", Offset = "0x80E5270", VA = "0x1880E6270")]
	public void JODNHNNNKMA(Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80E68F0", Offset = "0x80E58F0", VA = "0x1880E68F0")]
	public void NDOBJEANGPO(int LNKIILEAJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80E67A0", Offset = "0x80E57A0", VA = "0x1880E67A0")]
	public void MHIKJKAKPJC(int LNKIILEAJOA, Vector3 EBGKGBGFPOC, Quaternion KDHLIJMPIFF, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80E63D0", Offset = "0x80E53D0", VA = "0x1880E63D0")]
	public void KEIBCKCNHBO(int LNKIILEAJOA, float3 EBGKGBGFPOC, quaternion KDHLIJMPIFF, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x80E6A20", Offset = "0x80E5A20", VA = "0x1880E6A20")]
	public void PKLLBFCLOKI(int LNKIILEAJOA, Vector3 EBGKGBGFPOC, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80E65E0", Offset = "0x80E55E0", VA = "0x1880E65E0")]
	public void LILJGICIPIB(int LNKIILEAJOA, Vector3 PNJPAIKKPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80E4EA0", Offset = "0x80E3EA0", VA = "0x1880E4EA0")]
	public static Quaternion BKKNJNNHEKK(Quaternion FKHDNOPJIJO, int LNKIILEAJOA, float PGOBGEGKPDF, DLCDHJHIFNO EMDOKHPMGEI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80E56B0", Offset = "0x80E46B0", VA = "0x1880E56B0")]
	public Bounds CCLLHOHFOMP(Transform PLPGMCABFBF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80E6080", Offset = "0x80E5080", VA = "0x1880E6080", Slot = "10")]
	public virtual void EMHIBPAGOGE(bool AADLOAKMBFB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x80E44F0", Offset = "0x80E34F0", VA = "0x1880E44F0")]
	public NativeList<KOLICHJFOBE> ALLPIPPBNON(float EDJJOMPOGKH = 1f)
	{
		return default(NativeList<KOLICHJFOBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LKDBPIMLOCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public float3 JILMILDHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public float OPLEFDPFCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public quaternion OONGJBHEPPK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80EA420", Offset = "0x80E9420", VA = "0x1880EA420")]
	public LKDBPIMLOCP(Vector3 GGHGIDAMNEE, Quaternion FKHDNOPJIJO, float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80EA1C0", Offset = "0x80E91C0", VA = "0x1880EA1C0")]
	public Quaternion HEONLFLDIEI(Vector3 NBFEGPDMMPI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x80E9ED0", Offset = "0x80E8ED0", VA = "0x1880E9ED0")]
	public LKDBPIMLOCP GFOBKAHGIPP(Vector3 MPPMELCJCAC, Vector3 FCOFNLHKDFK, Vector3 LEGEFOEEHLK)
	{
		return default(LKDBPIMLOCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80EA280", Offset = "0x80E9280", VA = "0x1880EA280")]
	public AHKDJAEJNCM OBELPAEBEKJ(Vector3 NBFEGPDMMPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LFGEGHIHIKP : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80E9110", Offset = "0x80E8110", VA = "0x1880E9110", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x80E91F0", Offset = "0x80E81F0", VA = "0x1880E91F0")]
	private void KEEEBFPBPEK(Dictionary<Guid, Guid> LICMOENDMLC, KKDDEHIDKHE FDOEIEEAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x80E9190", Offset = "0x80E8190", VA = "0x1880E9190")]
	private void KEEEBFPBPEK(Dictionary<Guid, Guid> LICMOENDMLC, AEMJDCPGKCL PEMDBCDHIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x80E97C0", Offset = "0x80E87C0", VA = "0x1880E97C0")]
	private void KEEEBFPBPEK(Dictionary<Guid, Guid> LICMOENDMLC, ECNJLGOEAOJ GDOPFEGDJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LFGEGHIHIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class CPEAIFLMIDH : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x80E0060", Offset = "0x80DF060", VA = "0x1880E0060", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CPEAIFLMIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LPBNHKBNPKB : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x80EA4A0", Offset = "0x80E94A0", VA = "0x1880EA4A0", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LPBNHKBNPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GJJILCEEFPH : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x80E7330", Offset = "0x80E6330", VA = "0x1880E7330", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GJJILCEEFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DEIDOHJAPNP : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x80E41A0", Offset = "0x80E31A0", VA = "0x1880E41A0", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DEIDOHJAPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KILMIIJIEAA : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x80E8DF0", Offset = "0x80E7DF0", VA = "0x1880E8DF0", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KILMIIJIEAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class PJCENHPHMOB : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x80ECBE0", Offset = "0x80EBBE0", VA = "0x1880ECBE0", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PJCENHPHMOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class NOGHALBKEGI : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA600", Offset = "0x80E9600", VA = "0x1880EA600", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NOGHALBKEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class OABJHCJDBDF : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x80EA6F0", Offset = "0x80E96F0", VA = "0x1880EA6F0", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OABJHCJDBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class ICFHKOIJKIF : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x80E7590", Offset = "0x80E6590", VA = "0x1880E7590", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ICFHKOIJKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class GMCBLLGEGHB : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x80E7490", Offset = "0x80E6490", VA = "0x1880E7490", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GMCBLLGEGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class BLKBCJGFCPH : IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public static readonly DLEBKKJNMPJ LKGDJLFGDBA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80DFE60", Offset = "0x80DEE60", VA = "0x1880DFE60", Slot = "4")]
	public void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BLKBCJGFCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KJGFLHAIJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public HDAFNIGDFEN LMOHNMMFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public PMGHIJOEHAP FLCMABNKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public Dictionary<int, int> KEPBNDNMGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public Dictionary<Guid, Guid> OPAAFJMCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public POBPAJJGBOJ MJPJFBIFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public bool OAKHLIJBMNB;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IBOENEAACEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCOEPGHBALD(EIINCMFJAJD BMDCCPCMHKP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PDPAJAOGMJO
{
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private static readonly IBOENEAACEK[] LLGMEMOIHEF;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80EBAA0", Offset = "0x80EAAA0", VA = "0x1880EBAA0")]
	public static void ACPAAJOMEHI(NFPOLOGAGBB INCJDDLACNP, AEIOPFEPOFF MIPEFMJCJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x80EC360", Offset = "0x80EB360", VA = "0x1880EC360")]
	public static void KPBFOPNDCGJ(NFPOLOGAGBB? INCJDDLACNP, AEIOPFEPOFF OCILODPLIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x80EBD20", Offset = "0x80EAD20", VA = "0x1880EBD20")]
	public static void IBCGJCBMNJG(NFPOLOGAGBB? INCJDDLACNP, AEIOPFEPOFF MBADOCGINHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80EBF90", Offset = "0x80EAF90", VA = "0x1880EBF90")]
	public static void KNLIAOKJPGK(EIINCMFJAJD BMDCCPCMHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EIINCMFJAJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public HDAFNIGDFEN CBMBJJAPGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public NFPOLOGAGBB ECILKPBELDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public Dictionary<int, int> KEPBNDNMGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	public Dictionary<Guid, Guid> OPAAFJMCDBC;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80E6FB0", Offset = "0x80E5FB0", VA = "0x1880E6FB0")]
	public Guid LJIKOKIBOLD(Guid JFLBGDIIGHK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface POBPAJJGBOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int JMFNCMHOPBO, [Out] Guid MFLIKGKCCFO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class CPNDADKHIOH
{
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private static readonly HashSet<Guid> CGFLLGECJDK;

	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private static readonly ProfilerMarker LDPOFJPHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly HashSet<string> NDAPPENKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private readonly Dictionary<long, int> BODHJDHANFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly HashSet<Guid> GNFNEGGIOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private readonly HashSet<Guid> OLGPGANPAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly HashSet<Guid> KADALGBFDOH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> IICGIGCGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> LLCFINKPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> EDNBJCIILFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> MBFKNMONLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x80E0BC0", Offset = "0x80DFBC0", VA = "0x1880E0BC0")]
	public static void AGDHNEMFBIJ(MJIKPNKKBEG HJDJFHMDDPP, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80E33C0", Offset = "0x80E23C0", VA = "0x1880E33C0")]
	public static CPNDADKHIOH MFIIMENLEBM(KDGPCLGNAFG IANLOKBOBGO, JGHPCOGANGL? MAGNPAAOMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x80E2F40", Offset = "0x80E1F40", VA = "0x1880E2F40")]
	public static CPNDADKHIOH CLBJEEMECLE(MJIKPNKKBEG ALDEEOODLPD, JGHPCOGANGL? MAGNPAAOMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x80E3200", Offset = "0x80E2200", VA = "0x1880E3200")]
	public static CPNDADKHIOH FINGOFNKMPI(ADCMECGCFPG KMNEDPLFCHD, PIPMECJNPGB PCOPFIMLFLG, JGHPCOGANGL? MAGNPAAOMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80E32C0", Offset = "0x80E22C0", VA = "0x1880E32C0")]
	public static CPNDADKHIOH GIMLKIKKNDB(IEnumerable<string> NDAPPENKKIL, IReadOnlyDictionary<long, int> JICAJMHJKNH, IReadOnlyCollection<Guid> KADALGBFDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80E4010", Offset = "0x80E3010", VA = "0x1880E4010")]
	private CPNDADKHIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80E3E10", Offset = "0x80E2E10", VA = "0x1880E3E10")]
	private CPNDADKHIOH(IEnumerable<string> NDAPPENKKIL, IReadOnlyDictionary<long, int> JICAJMHJKNH, IReadOnlyCollection<Guid> KADALGBFDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80E24E0", Offset = "0x80E14E0", VA = "0x1880E24E0")]
	private void BAFHOLNDJNL(KDGPCLGNAFG IANLOKBOBGO, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80E1E50", Offset = "0x80E0E50", VA = "0x1880E1E50")]
	private void BAFHOLNDJNL(MJIKPNKKBEG ALDEEOODLPD, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80E3650", Offset = "0x80E2650", VA = "0x1880E3650")]
	private void PPNOHJNPHCB(ByteString? GCPGFLNMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80E2BE0", Offset = "0x80E1BE0", VA = "0x1880E2BE0")]
	private void BAFHOLNDJNL(ADCMECGCFPG? NKBKNNLLHKF, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80E1DD0", Offset = "0x80E0DD0", VA = "0x1880E1DD0")]
	private void BAFHOLNDJNL(PIPMECJNPGB? PCOPFIMLFLG, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x80E2780", Offset = "0x80E1780", VA = "0x1880E2780")]
	private void BAFHOLNDJNL(PMHONPDANON? ALDCOJPGEOE, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80E2FC0", Offset = "0x80E1FC0", VA = "0x1880E2FC0")]
	private static bool EEHJJCFGMGA(PMHONPDANON ALDCOJPGEOE, int HHJFEGDBBAB, [Out] Guid KOLJFICFDHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80E0110", Offset = "0x80DF110", VA = "0x1880E0110")]
	private static void AGDHNEMFBIJ(PIPMECJNPGB? NKBKNNLLHKF, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80E15C0", Offset = "0x80E05C0", VA = "0x1880E15C0")]
	private static void AGDHNEMFBIJ(PMHONPDANON? ALDCOJPGEOE, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80E0830", Offset = "0x80DF830", VA = "0x1880E0830")]
	private static void AGDHNEMFBIJ(ADCMECGCFPG? NKBKNNLLHKF, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80E01E0", Offset = "0x80DF1E0", VA = "0x1880E01E0")]
	private static void AGDHNEMFBIJ(PDODJHKBMFI? ABOLKPCCJOL, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80E28C0", Offset = "0x80E18C0", VA = "0x1880E28C0")]
	private void BAFHOLNDJNL(PDODJHKBMFI? ABOLKPCCJOL, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80E3440", Offset = "0x80E2440", VA = "0x1880E3440")]
	private void OANOOFDCFIB(Guid? JFLBGDIIGHK, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80E20E0", Offset = "0x80E10E0", VA = "0x1880E20E0")]
	private void BAFHOLNDJNL(NFPOLOGAGBB? ECILKPBELDK, JGHPCOGANGL? MAGNPAAOMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80E1800", Offset = "0x80E0800", VA = "0x1880E1800")]
	private static void AGDHNEMFBIJ(NFPOLOGAGBB? ECILKPBELDK, JGHPCOGANGL MAGNPAAOMIH, AEIOPFEPOFF KPKLNLKKGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80E3350", Offset = "0x80E2350", VA = "0x1880E3350")]
	private void JIPODPHENGB(string? NIEHBNLLFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80E1CB0", Offset = "0x80E0CB0", VA = "0x1880E1CB0")]
	private void AOJONPJNDHH(long GOECKJMEMHG, Guid BMDBNKCBFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80E1D80", Offset = "0x80E0D80", VA = "0x1880E1D80")]
	private void AOJONPJNDHH(JIMFPJIPHHK? DGAPLMPHBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80E1C50", Offset = "0x80E0C50", VA = "0x1880E1C50")]
	private void AOJONPJNDHH(BGONKKPEFOF? DGAPLMPHBNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct OBCNPIOAICJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class EELGLNNPLCL : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private readonly IEnumerator<DictionaryEntry> CGEANDCJOJI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry LIKDEMLCJEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x80E6D80", Offset = "0x80E5D80", VA = "0x1880E6D80", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object OKAFGBBEFIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x80E6E50", Offset = "0x80E5E50", VA = "0x1880E6E50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object BDJLGAHJNPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x80E6F00", Offset = "0x80E5F00", VA = "0x1880E6F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x80E6CA0", Offset = "0x80E5CA0", VA = "0x1880E6CA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
		public EELGLNNPLCL(IEnumerator<DictionaryEntry> CGEANDCJOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80E6C00", Offset = "0x80E5C00", VA = "0x1880E6C00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80E6C50", Offset = "0x80E5C50", VA = "0x1880E6C50", Slot = "9")]
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
		private sealed class LGLMHFIJOHH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x80E9B90", Offset = "0x80E8B90", VA = "0x1880E9B90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public LGLMHFIJOHH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x80E9A40", Offset = "0x80E8A40", VA = "0x1880E9A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x80E9B40", Offset = "0x80E8B40", VA = "0x1880E9B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x80ED350", Offset = "0x80EC350", VA = "0x1880ED350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object DAKIIEIEKNI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x80ED260", Offset = "0x80EC260", VA = "0x1880ED260", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x80ED440", Offset = "0x80EC440", VA = "0x1880ED440", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x80ED1A0", Offset = "0x80EC1A0", VA = "0x1880ED1A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x80ED200", Offset = "0x80EC200", VA = "0x1880ED200", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x80ED3E0", Offset = "0x80EC3E0", VA = "0x1880ED3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x80ECE60", Offset = "0x80EBE60", VA = "0x1880ECE60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x80ECEC0", Offset = "0x80EBEC0", VA = "0x1880ECEC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x80ECF20", Offset = "0x80EBF20", VA = "0x1880ECF20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
		public RoomObjectCounts(Dictionary<int, int> DIHHONCAICG, [Optional] Dictionary<int, int> CJPJPFOPPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80ECD80", Offset = "0x80EBD80", VA = "0x1880ECD80")]
		[IteratorStateMachine(typeof(LGLMHFIJOHH))]
		private IEnumerator<DictionaryEntry> NGLNPMFOPAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x80ED490", Offset = "0x80EC490", VA = "0x1880ED490", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x80ED0A0", Offset = "0x80EC0A0", VA = "0x1880ED0A0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80ECF80", Offset = "0x80EBF80", VA = "0x1880ECF80", Slot = "9")]
		void IDictionary.Add(object DAKIIEIEKNI, object IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x80ECFE0", Offset = "0x80EBFE0", VA = "0x1880ECFE0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x80ED040", Offset = "0x80EC040", VA = "0x1880ED040", Slot = "8")]
		bool IDictionary.Contains(object DAKIIEIEKNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x80ED140", Offset = "0x80EC140", VA = "0x1880ED140", Slot = "14")]
		void IDictionary.Remove(object DAKIIEIEKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x80ECE00", Offset = "0x80EBE00", VA = "0x1880ECE00", Slot = "15")]
		void ICollection.CopyTo(Array MFIJBPNIELL, int HLGKMAPOEBE)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class KLJHJBEDEMN : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x80E90C0", Offset = "0x80E80C0", VA = "0x1880E90C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public KLJHJBEDEMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x80E8F30", Offset = "0x80E7F30", VA = "0x1880E8F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x80E9070", Offset = "0x80E8070", VA = "0x1880E9070", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x80E7D90", Offset = "0x80E6D90", VA = "0x1880E7D90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object DAKIIEIEKNI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x80E7C60", Offset = "0x80E6C60", VA = "0x1880E7C60", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x80E7E40", Offset = "0x80E6E40", VA = "0x1880E7E40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x80E7BA0", Offset = "0x80E6BA0", VA = "0x1880E7BA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x80E7C00", Offset = "0x80E6C00", VA = "0x1880E7C00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x80E7DE0", Offset = "0x80E6DE0", VA = "0x1880E7DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x80E7820", Offset = "0x80E6820", VA = "0x1880E7820", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x80E7880", Offset = "0x80E6880", VA = "0x1880E7880", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x80E78E0", Offset = "0x80E68E0", VA = "0x1880E78E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A22480", Offset = "0x2A21480", VA = "0x182A22480")]
		public Invention(long PBJHGGBBAAF, int MFFPIAPMHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x80E7750", Offset = "0x80E6750", VA = "0x1880E7750")]
		[IteratorStateMachine(typeof(KLJHJBEDEMN))]
		private IEnumerator<DictionaryEntry> NGLNPMFOPAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x80E7E90", Offset = "0x80E6E90", VA = "0x1880E7E90", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x80E7A60", Offset = "0x80E6A60", VA = "0x1880E7A60", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x80E7940", Offset = "0x80E6940", VA = "0x1880E7940", Slot = "9")]
		void IDictionary.Add(object DAKIIEIEKNI, object IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x80E79A0", Offset = "0x80E69A0", VA = "0x1880E79A0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x80E7A00", Offset = "0x80E6A00", VA = "0x1880E7A00", Slot = "8")]
		bool IDictionary.Contains(object DAKIIEIEKNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x80E7B40", Offset = "0x80E6B40", VA = "0x1880E7B40", Slot = "14")]
		void IDictionary.Remove(object DAKIIEIEKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x80E77C0", Offset = "0x80E67C0", VA = "0x1880E77C0", Slot = "15")]
		void ICollection.CopyTo(Array MFIJBPNIELL, int HLGKMAPOEBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> MJHONOLBIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public readonly IReadOnlyList<Invention> GMGBFJBIGGP;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	public OBCNPIOAICJ(IReadOnlyDictionary<Guid, RoomObjectCounts> PJCEFKJEKCE, IReadOnlyList<Invention> FOLMDEGIDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x80EB090", Offset = "0x80EA090", VA = "0x1880EB090")]
	public static OBCNPIOAICJ MFIIMENLEBM(KDGPCLGNAFG IANLOKBOBGO)
	{
		return default(OBCNPIOAICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80EAF70", Offset = "0x80E9F70", VA = "0x1880EAF70")]
	[CompilerGenerated]
	internal static int FLJPHHGKILB([In] IReadOnlyDictionary<long, int> KENMPOKPEBD, long? GOECKJMEMHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA8B0", Offset = "0x80E98B0", VA = "0x1880EA8B0")]
	[CompilerGenerated]
	internal static void CEPKJPDJBBJ(int PONOJOAOHFL, [In] ADCMECGCFPG PCJBLEJIMMO, [In] Dictionary<long, int> KENMPOKPEBD, [In] Dictionary<Guid, RoomObjectCounts> PJCEFKJEKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum KKCBJHBPPDH
{
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class JGHPCOGANGL
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class LJKEHCFJCMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public readonly Guid HFOOKKOGBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public readonly IReadOnlyList<Guid> LLCFINKPDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public readonly KKCBJHBPPDH EIGJJLPLNJL;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x80E9E70", Offset = "0x80E8E70", VA = "0x1880E9E70")]
		public LJKEHCFJCMA(Guid KFODHBMOBPP, IReadOnlyList<Guid> KADALGBFDOH, KKCBJHBPPDH CBONFFLHKGG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private readonly AEIOPFEPOFF AMBLOAGNBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private readonly Dictionary<Guid, LJKEHCFJCMA> MFBJGKBENCA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public AEIOPFEPOFF ADANMCIKHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x80E8170", Offset = "0x80E7170", VA = "0x1880E8170")]
	public void DOPEKGIEJEC(Guid FGCOKJHDPEL, Guid CNOLHKCAMDF, IReadOnlyList<Guid> HLEPIFIMJBJ, KKCBJHBPPDH CBONFFLHKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x80E8080", Offset = "0x80E7080", VA = "0x1880E8080")]
	public bool AIHAMHKDKPC(Guid DBNBFIIFJKI, [Out] LJKEHCFJCMA OJONIKNFAOK, [Out] bool DFPEMLDLLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x80E8380", Offset = "0x80E7380", VA = "0x1880E8380")]
	public JGHPCOGANGL()
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
