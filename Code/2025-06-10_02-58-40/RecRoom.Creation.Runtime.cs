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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BCE240", Offset = "0x7BCD440", VA = "0x187BCE240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KLBJHIOPGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> NGDLJLPBBNG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MMCIAJNODPO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> OCAEOBDHPDD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LJGJHPIMFHB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ENDMGHLAIAE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LDPEODCKPNA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string CMKMFMCKJKH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9290", Offset = "0x7BB8490", VA = "0x187BB9290")]
	public static bool ILBOALCNPOH(Guid BHBFKBMOLLD, int EKADHNCIENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9A10", Offset = "0x7BB8C10", VA = "0x187BB9A10")]
	public static bool OPBFCOKPLOM(Guid BHBFKBMOLLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9390", Offset = "0x7BB8590", VA = "0x187BB9390")]
	public static string OANKKEKMKKD(Guid DJOIAEMCFDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BDBCAOHHABP]
public enum HPGMMJIAFMO
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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0B10", Offset = "0x7BBFD10", VA = "0x187BC0B10", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KJFDFDAGFAP
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid HCPKMCNGFDI;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KKKAFPMJMBD;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid BHGEKPCGKCE;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid HCKNJBFGBAK;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid IDBKCPJCHOD;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid CCMCGPGPMEI;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid GKBGINJKHLD;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FFNEKPMNCIC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JEKGJDJDADL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid DLNMMJOOLBL;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HMGHAONHOEA;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid EDGFIKAPCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BICGIEEHCLK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid FCGAHIAEDDI;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GDFOBGGBDAE;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid MNJKLEMIBIO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid BEBLCGFLEPP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EFLPLGKJAAP;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid FELJLPCLMCN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid JJPMIEOINNJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid MCGMHPAPHNM;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid NEKBMOBFPEO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid EAEHNLMOBCJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid INDHBMAHDHD;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid LIMJDLHAONA;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid LLKKDKHNCIP;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BLOMBJMIHLF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GDKBHPHIMCK;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FKKMJPOBLNP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BHMBBONKKJB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid AJIGLFMFGMI;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid IJGGHCBNCPE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid LKAJCGMNDOC;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid LEEHBHPFDIC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid HNKAACKGCGJ;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid PEAJJENIHFH;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MPCPAAPLNJG;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid OIEBKMLHIOE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid JPKLKDAMCGB;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ADDKHFNJNOG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CPOECPKNDJK;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid JAGNHACKJBD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid IBPOEEFCACK;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JGLNNPPMLOD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid GHDGAPKJJIG;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid MLMLCOLEEAE;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid JHGPOCPJCLF;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid EIJHFJBFPIJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FFGKFOCFMPP;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IOOMDKJDHFL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid OIMFEGHGPAI;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MMADLMPGOKH;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid LLBMKKGBBJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FKPFOPDMPMM;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid IKHGBLHKOIL;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BHAPFBKHCHI;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PICNODJCLGO;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid BBNFDCBCJIO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CAIBOAFFAPA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LKDFNDCPJBC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid HGILIKHFCHO;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BPMOGFACFNO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid EIAPPKACIIO;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid OLOPLHEIMHE;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid PMOLDONDNGM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MHCIFKLMBFD;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JBKJFDCEGKP;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid EPBDBOKEBLP;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NNLKDPCBCOF;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid DDIFFGBIMIB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid APAMBMPNNPG;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ECJFIIBDPML;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid DAMNFAFJDFB;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid GBBFEKKOLJA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid AOJNBLOCAHN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DJCAEOALJOO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid KNJPKIGLAEB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid AOFKDMJAMIK;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid FKLJAPLANKH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BGBHDEJJHHK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HFFGFABMAND;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid HJBILNGLHPP;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid AJJIIGMFMJN;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IFBGBMFFNDF;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid JAILKFPCMDL;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid CMNLKGHBDIF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid LMHLJIKCKNE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid OOMJDOGMKBP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid OMFCEDOEDBB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid IPDFGGPHGAC;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BEMNDNOELEA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HFNAMCGBEKL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid BPPCODGCMAO;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KEMEOKHKBMJ;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid LNKMJAAJBNI;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid CPCCECPNLFD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ACMIIPPGCCE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid BMPEFOIOCPB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JOAAGLEICAI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid ABMBAANHLMG;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid NADDKDFGAAO;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HLAIJDPGINH;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IBMDAOFHNGD;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NEEGPNCJHLK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OBKBMLGLCOK;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HALCCGOEOKJ;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid OHGAEJCEDNE;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GJLLPLMDDBK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid DKGPPNNDMJG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GLCMLDDGNDH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid KKGBKCHDBAP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid LAMNAGCCFJI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IMMHDJJCFIF;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ECHJMLBDFGK;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FCNFOOMNJDK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid AINHPLELKJO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MIMDCAOCMEO;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GMMJHLDMIPH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid DPMMHCNJMHN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KPICLAMIJPH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid BBLONAMHNMD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid COENFDJGBLB;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IFPDCNDBPOJ;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid MEDDOOHPANF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid MDMJAJNMMBO;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NOEOPPLBNAH;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DECBCKLGBKC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid IDALPPFENIN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NNDIIGAHKLO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid IMHNFJGJCBJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid NBBLGGBFCFB;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid CMDAJDHEGNJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BKOOPOEOAEO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid MEBKODIGIIM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OCKNDACNPPI;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid CEKMCEAEPFK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid BCPMFBOPIDL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MANOEMLJKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PGHENOCCHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid NDEFACLDJFO;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid HBMEFOFPKOG;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KODCPPMIKMA;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid GACONBDLHGK;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid ABCLJJFJGOP;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HNAJPDGBMGD;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NPEFKBHLMJO;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LIPNOJDODGK;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid IJNMJDEKEPO;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid IOJMACIPNBB;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid NLBNGJJGDLE;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid DOEEFPBKJOI;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HJGEAJMFFGD;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid LKDBOGFBHAD;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid KJFJFLKBBGI;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid DOOLHLOILDF;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid ILLNILKIHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid GDIIHEOONBB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OKKLPHGFKKE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid PKNFKFMLCIP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid BKEPAAHGEIO;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid OBILDMPCLAB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LJCHALAADAM;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NKAKJODABEN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid JPIOBOMPLMN;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IGMHBLJAPLJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ANBKJMODMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NEDBBIGJBEB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid KCJCBCJDAHG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid MPHEPEHCCDO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KFKKJNLIAHK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FHLDLMGNGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LHFPDHOIMJA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid ILOGOAPIING;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OBDNNMFLPJP;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid LOOFBBGEAJI;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid BLAHHBCFDJK;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid LKIHBCHOPEA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid HNBAMNMAJJB;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid CKGLNDMKGLN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid JNHAOJLOJBM;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IDAOGNGEBAO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MALLIOKPEOA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid HAMCDHOBPGM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid IILEMKBKLPC;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MKENPOHDIPP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid KBLLEHEADIB;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CCDELNNJMBO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid ALJEJGPEHHO;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DKOGBFCHIGH;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid JCLHCKMNLBM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ICIEOJBKPNA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BGHJKBPHEMD;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EJPAAKNLGMF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid AJOPGFHNAJA;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid CGAHDNKHPGC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid HPMPIPLMELN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid ICFEHJFKNAF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid AJDDOHJGIGE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid GIEBANJOLOG;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid ECMGIDLMFLG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid LBCCNLDOOBE;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid KBOPHHAMNPA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid LCJADLPBEEA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid DIIKMPLFOIJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid ILLPBHNGJAO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DKJGKBJAHEL;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid CDPFJAEFFBE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid IIGJKOIGEIN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid NFCHDPIOEAD;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid GHDOJAKFOCN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid IKKJLMLDAKI;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid MFLIIPAHDMP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NAFGCGMALLP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid AHCDJFAMOKE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LCHGOPGGJEN;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JAADFNGBJHB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid IDCIIPKEJKH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid KPNBINCHDEM;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid HLGODFKGCCF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DBOCDHIKCHP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DIFMHCJNMHH;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid PIALKIDNHLP;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid MKHKEOAJNHG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid ANGECIFCGCJ;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GLHCFOFBDEK;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid EGGMDMJJLAM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid CPEIJPOPKKI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid DGJIHOAGJIK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid AMJOOPIBGEF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid BNKAPAJMKNE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid AKEIJOILEMF;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid MPBHFCODCBB;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid DMBOMFLPKHN;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid FNPKJNGIGDM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HJPHGPFFGBE;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DEJGEDMKCLH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GIJLOINMBJN;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JOPHNEDPJAL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PFKPBDNBOGH;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid LMJMLHOLCEM;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid FIODEFAOEOE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid BLIHMFDJFLE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid INKLOLOHCKI;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid JCOHMPBAHKP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CABBOHMOIHA;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid GNNNEDKOPDH;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid EAJCONNJJEK;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid NFBLINIFOGM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid HDOOIPJDMDO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid DFNLNIHLNLP;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid HODNJDHOKHM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid KNCJGKJFDBM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid LECLKELJICD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid KKKOHDIMCEP;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid ICMNFHDJDDO;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MFFCFIPDEAN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid AFHBHMKBDGG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid OJHJJOMHPJB;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid FKGGDOIDJHP;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid BNNCEKPDMMP;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid AHMCFGICAAL;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FPGBPOOIGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid ECPKOOJEGIE;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid IEHMGHEHMEA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid DLEDODMCCCK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid IMBLABAIIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid KENNGDKKDHN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BIFHFNNHIMP;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OODDGKGILBI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid HPMKGAJLKMO;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid MAAFNNAAKEN;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid LKDEABKFBLD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid KMMLDHIODID;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid BBDNOAIHAME;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NHNAIEIOPKO;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PBINENFFNDJ;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid AAGJFLKNAJH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid HCLFEBIGMDM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid OMIIDNAEBBP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GHFFBNDNEJD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid NEJLAFFGHKJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid OMLPHNNAGKD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid NEEPOCIODPE;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CDCPLGCJHBN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid LOAEKLLKDAC;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MMJCNFHKMPF;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid AOFBDIDACAH;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MMJMIADJLNH;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid LJHJLNBNFGJ;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid AOKPBEEBEJP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HAMPAIHIEDC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid DLIEGNFPKLF;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid EKJBOOKHPKC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid PJIKOEJMDCO;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HMNAJJDMCED;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid BOBAMKEFEPD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid DFCOPFFBGBD;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EFMLMAIGPON;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LKDLIBEBEBE;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid NJPABJMIDND;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid OIAHOOBLBPC;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HPGKPIDACDK;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PEPFPHKDHCD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PCLIJAMMHBN;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid ELLGLKFFHGF;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GFGHFFNGKJO;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FGPCIDJKIFC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid ILIFALDNJPE;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid BPOHLFFCNDC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AMNKDPPECON;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NBJAOMDMDAO;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FMFOEEMOPFN;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KIABJCOEINI;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid JEMIHONMBOP;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KNECJHLJMBB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid GAAHLEPGFLI;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid BNDAEEHELEC;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JDGCAAMJIMJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid MNBAHIJGMAA;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NLKIGNAILGE;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid PDKHDHKJMHH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid EKCHEIKKAHO;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EPCNEHPFOHN;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LJMMAPPGGBI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ANCNJMGABDH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NGHDBMDMOLA;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HMGGIEINGJB;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid IBIJCILEBGP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OABCHMMPNFB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid LAPAIJPCOFG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid DDEDJNOLMGM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid JKCIKBCDICB;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JBAGAFHCJPE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HHCMNJJOGMA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid BBCIHJHCELC;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BBNBLFFMGMF;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid OKEDOGOOOAN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid JPDMEIAKAME;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FPHBGKGDPAM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NMPEOAMCFEI;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid HFGGGKAEKDE;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid BNFIGAMNPEN;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MMKBICIOEHD;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid AAACJFKFGEE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid JNGDDHGJGDL;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EILGDFFFAND;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid ABLNCMANOKB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid GHOCNNAHJHM;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HJGBMAAOGEO;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid OHJJGLKCGOO;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid KDJKGNMPBOI;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid KIDFGIEGGOP;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid ANONJKIBHKC;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LBEJIAFGGNO;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid GFENOLHMKLP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GKGOOAGMBOA;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid NKFDFGAPKOD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KGPIPCOOIEO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid EHHLJPGFHCH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid APEFEJACMIM;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid KPCBFPFGMJP;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid ODAKCILEOOP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BNMHEPBDFMM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid MMBAPDENNHG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid LNDLNOCPJNK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PJFAIMOPBAL;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid BICDNKFNPJB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid DEDCCOEMDDB;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HMOBKKKJIGL;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid IGOCDJFKIDI;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid FJFOEJKNGCG;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid IJGLBINJHJB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IKAKKBGFEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid KGKDFLFAKCM;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid DOPBMPPMOFG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid APDPDNKAANF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MAHEAHLALDB;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid EKNFNHJMBCN;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid MLMEBABCLAO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JDJHKGNHLFF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid CALBEGGLNHB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LNCBDJPNPAO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid OFPGDLFDHDB;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CICAIGFNPBA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid LIMHGKFCGFE;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CFCOCDANHBL;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid JIHHLECAKON;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ALFIGAENCCJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid OGNLBDKGNJJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid BLAGJLIELHM;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid CHFNGGOGIKM;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid APGBMABGMDM;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JAFEIPOFCHA;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HIIKGFJNHLN;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid MONDLAFBBCB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JCDOGIGKICH;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid HALPNGNIIEH;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid ODGEEMFAIGE;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid FJFBEIBMDOB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid MCBNHDFHNHL;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid EIBDGLEFLGD;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid GCEPGFKFNEO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid NOOGEPALADH;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KPKBNGLKMCF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid HNHFPCABADC;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CBIJCJCPPGH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid FEFFFPODGPL;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KBCMAPKBJPE;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid PLONNPBBJEL;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid AKFBGHKFJNC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HIJKFNBNGIF;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid BNDNCPBBFDL;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid FCELJLAFINL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid DKAHLEMNHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid HHOHCOAHJKK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid OAMCAPFOMLH;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid AHLMHECGKIA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid IOMLKEECJEA;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid CPDFPAJMCLF;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid GKIJOOCOEHK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid ABEBCBOKMAM;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid IEMFLGNDBGE;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid ENAHAMKLGKK;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid KOICCFJGIFN;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid FEELCHMONOJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid OENGOIEPMDK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid EDAGIGDMKKG;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DDJDIHGBEBM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KKNHLCGJMAK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid FDHOHJNGACN;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MEFDMDMOMDN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid HCPOFAAKDNE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid IOICFOLPGHD;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DAMHHHOOJNM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid KGCEGAGCGKC;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NMECLFDBPEC;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid AKODAGAGLIL;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid BLADDOAJPBE;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid IJCBDGAGALL;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MHNAIMPJGBD;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JFJGGDBADHP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid JODFNNAPLFL;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid DPKALKANACG;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid HNIHCFGPKDO;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CCFLNCEBPGF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid CPOAFCADGNO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NPLENDIDLPL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid JAONKILBOBO;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MEBKEPPPGOE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid PFEAGNEMBPH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid IANJJNLOEPB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid ENIHKBJMPCM;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid FACIGHDGLHB;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid HIDJKGDGNKM;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PCIPIPDDEPE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid AGDIADELMMC;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid IHJAIPPGLKC;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid KLFPJOFFBMO;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AIONFEDCOCL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JGKOKBOJMOO;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid MJCDGKKECIK;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid FHKAGJPFNEN;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid MFPIGBDEBFM;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid OAMBHGLOBAO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PKHMOPHECLH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DMNNICDMODL;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JMFDKIPMPPF;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid ODNNJBOEDAN;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid LOPJBNMEPMH;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid EEKEOFCEGCP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JIFAGFJHJCI;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NEEAFBOAGJK;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid AHILNCNEIHL;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MCHIPIHAHDD;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid PGCLHOOHBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BNLOMBFAJEI;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BGALLOGMJIB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid JFNDBOOJIGG;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid IIFFPJJKJJC;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid ALPLDNPILHG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GGBJODMMHFF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid OLNDEGCEDOK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid AOMDBHGGCJH;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid ODBMGAGCOKJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid LNPNKGFNNHE;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MCKMOHKBOON;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid NEBLDLLNFDI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid LPBHNDFEDGP;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GPNGCFEBHGG;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid PGGHENDJFAD;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid EGJHHOHFPDD;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid MKHFJCAGMDI;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid OBHKCBPHFJB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid ALLOJDNCDID;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid OFGPHFAAKKM;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid FCEILFFPJNC;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid KPLLIHPKHJL;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PHAGKHKPHML;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JENAJNNEMMK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NFBIKLBOILA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HOGOPNCFFGL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid CBJFHLKPAPL;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid MNNDALKBMNH;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KGCKIGIJFOG;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid BDBGPBHJHCA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HOPLGOONACF;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid IILCPONNCIH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid KHGKINJEODA;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid LIHMKEJONMK;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HHIJAAKKIKG;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid HLNLIHDPPEM;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid NDHLNJEHNKP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid OJMAPDNDJAO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NCFEOJMDAMC;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LLGNPMLHHOP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid ICLMHENMDDD;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FNCLJLNOKHH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LEEHLPAJDMN;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid PMNEHLLGCNP;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid NAHGGOENDBN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid DHDNNBIFDEP;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid FGNKCMBLGGB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MIKGGICKMIF;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid EFJJCEAGBLI;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NNFEEOBMJDL;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CGEJEIEKDCP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid ILFAHAELBPG;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid ENHFPHMPJNB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid BHDCODFPFEE;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid FDEAFIDGMOH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid PKPGNKFECNP;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid LJCFIAHKAAB;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid FHCPLMOFEKJ;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid DMHJEPPJPMO;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid NAPADBKCDJO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid HJEGGBLKEHN;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LELCNIHFNBA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid LHBBFKJKDOB;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HLGEMCGFHEE;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid JBBFKKDAHAO;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid EDKEJAGDGJL;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GDMDKBIFKHC;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid ADEHEJMIDPG;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid MAGGDJAALOI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid OFAHCCDJAHN;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid ENBOGDKCMFO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid EODMEGNFABK;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid HBMJIKFGMAF;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid HFMFIJGKJOI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid ECEKFGHPHKK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid ILCDNOGFJOO;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid NIOGKCCDHLA;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GLHLAFNADDB;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JGOBCKCLFLO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid AAGCONHFNIC;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid GEBHJPDGKIM;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid IBIHEDKHKMG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid JIKJMLNFNHI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid FDEPPGACMPK;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid FJLEBECFPDB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid NJNJGBAOCDI;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HOKBBKCMBEG;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid BGGFHHHIIDE;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid ENKMOAJBBHL;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid IAMIFOOPIHC;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GOCNLKJNMCA;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OENBAGEJOMH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid GOHPHKHCLKO;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid LBOAMDJBKDN;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid IHADFOCPPFJ;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid ABPAGBMBGLJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid HDDGGGIPKMI;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid BFGPHFHCNCJ;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid HLOMGGJCFEN;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JEFPNPOANHE;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid ONAOOEKPEIA;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid GDEPMDHIBKD;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid FBDNMDPOGFK;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid BOINPCGINOG;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid AENFKMNDCHJ;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid PANLGIAEPEF;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid OLKBNCIJGKH;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid DMKFBDHNDDF;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid PALJIJANGOH;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EBBJKBEOGKF;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid CPANOAKGCMC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid OCHABBKBNHA;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid HILKDAFHKBG;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JLMAJBPPNCJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid INBCFKHCLEJ;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid DHDFBHIHBEN;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DKBEIDMGGIO;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid EKMNDFNNFNN;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid KCAMMJCECIG;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid AJPAGDKHBMI;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid FOBJCMHHKAJ;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid KIEIMJGCJAL;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid ILBCIEIEDLM;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid PBINEMJFFJD;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid KJBCHDNEBHE;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid JNJCLGNGFEE;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid BFJDIGCOCMO;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid HGCAOLFAKEO;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid KPNBHLKCCLG;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid NDCFOHKAFMK;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid OMFNMHIOKLH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BENAELOPCMJ;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JGKJBBABNBK;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid MPFMBGEHIPH;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid LPHEDLABGMB;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid HJNKFAJMAHL;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid LHNHBMLLKLD;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid MIGKHCBHPII;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid HAADGKPDJHJ;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid LJMLFGFJCEF;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid OKFJGIDJCIC;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid FJDIHFEAIAA;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid LLAOFCHBAHD;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid BFHHNHFDIPB;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid JKGGCFGINNI;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid LCPIJMJDOGE;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid CLIDIMKPOLA;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid EGOEJDCINKD;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid PDHLDMGHKAK;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid LKLHEKKNNPP;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid DOEHCELHJBB;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid MEBDEHDJGOM;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid IANJCCBLJHP;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid NMPDIHNENPF;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid GNOEAOAAEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid KEGAHJMGMAC;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid LFICPCJGDCE;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid EJNGLBGJLCI;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid BIOHFPEGHAD;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid HDCBNLDCOJO;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid IPAIFHNNHCD;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid MEIEDPCFKCA;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid DJHCCEEMLOO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid PEKDJENFJGB;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid MHGNDOJOHHD;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly Dictionary<Guid, HPGMMJIAFMO> PPDCFCPMPEO;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private static readonly Dictionary<HPGMMJIAFMO, Guid> HJDDOEIDMJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, HPGMMJIAFMO> JFLFJFICFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BB91F0", Offset = "0x7BB83F0", VA = "0x187BB91F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<HPGMMJIAFMO, Guid> MFDLBGIGJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9240", Offset = "0x7BB8440", VA = "0x187BB9240")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BMNJNDPLFKO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8ED0", Offset = "0x7BB80D0", VA = "0x187BB8ED0")]
	public static bool KPBNANNLKDK(KIHGCFJDKME GAEHAEEJIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8B20", Offset = "0x7BB7D20", VA = "0x187BB8B20")]
	private static bool KPBNANNLKDK(KPPAPHMMKAL DDCBOGLJKIC, KIHGCFJDKME GAEHAEEJIJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EABNBCAMIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(OCNMNCDPMOI CAIGHLKIDBF, [Out] Dictionary<int, int> DKPGOHHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(MGNNNNPADNA MAFCBLAOPBI, PDPEGHKHEND GJMFDBFOOGK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JFBMHOCOHGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly ALMOMMLHNFJ CNMPLMKDBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly IEnumerable<IHCKNOKFLCP> NNNMCEIDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<IHCKNOKFLCP> GIGCOBNMGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly KCKEEEOMPIF<BGIICJNKCNN> FHAGJCDIMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<NJGNBLJMMHF<DMIELAKFPBJ>> KNAHAIHJDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly PENNCKBJFOM PKPAAJMOKPH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool APJDDDOBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9110", Offset = "0x7BB8310", VA = "0x187BB9110")]
	public JFBMHOCOHGN(ALMOMMLHNFJ AKHADIKOCFN, IEnumerable<IHCKNOKFLCP> LOKNLHCGCLB, IReadOnlyList<IHCKNOKFLCP> CGGACDABGPA, KCKEEEOMPIF<BGIICJNKCNN> KBFABLKMDPO, IReadOnlyList<NJGNBLJMMHF<DMIELAKFPBJ>> IDMHGFIHEPE, PENNCKBJFOM JKMPKLDNDEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JFDCEMKJOPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly ALMOMMLHNFJ CNMPLMKDBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<IHCKNOKFLCP> ONOOIGODCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly KCKEEEOMPIF<BGIICJNKCNN> FHAGJCDIMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<NJGNBLJMMHF<DMIELAKFPBJ>> KNAHAIHJDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly ByteString OFLFPGMFOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly PENNCKBJFOM PKPAAJMOKPH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9180", Offset = "0x7BB8380", VA = "0x187BB9180")]
	public JFDCEMKJOPG(ALMOMMLHNFJ AKHADIKOCFN, KCKEEEOMPIF<BGIICJNKCNN> KBFABLKMDPO, IReadOnlyList<NJGNBLJMMHF<DMIELAKFPBJ>> IDMHGFIHEPE, ByteString HCODAOPDMHE, IReadOnlyList<IHCKNOKFLCP> IINJPMMBOBM, PENNCKBJFOM JKMPKLDNDEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LNMMLGJHBEE : JJFPNJBPBIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly Guid OHNEEOJIKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private readonly Dictionary<Guid, Guid> ABMKJAEMGBO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B80D70", Offset = "0x4B7FF70", VA = "0x184B80D70")]
	private LNMMLGJHBEE(Guid KHEANLAFCJJ, Dictionary<Guid, Guid> ABMKJAEMGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BC02E0", Offset = "0x7BBF4E0", VA = "0x187BC02E0")]
	public static LNMMLGJHBEE FAHGDJGLLGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0460", Offset = "0x7BBF660", VA = "0x187BC0460")]
	private static Dictionary<Guid, Guid> HNOMONCCONA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0B00", Offset = "0x7BBFD00", VA = "0x187BC0B00")]
	public static LNMMLGJHBEE PBEPOFMCLBL(IReadOnlyDictionary<Guid, Guid> LMDCFNDMKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0510", Offset = "0x7BBF710", VA = "0x187BC0510")]
	public static LNMMLGJHBEE IBDBINFMGNL(IEnumerable<KeyValuePair<Guid, Guid>> LMDCFNDMKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC03E0", Offset = "0x7BBF5E0", VA = "0x187BC03E0")]
	public Dictionary<Guid, Guid> HBLDCBFPALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
	public Dictionary<Guid, Guid> NBLILDDPLCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0800", Offset = "0x7BBFA00", VA = "0x187BC0800")]
	public void LHOMNBOIMGH(Guid LMDCFNDMKMH, Guid MCOCJMBCCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0880", Offset = "0x7BBFA80", VA = "0x187BC0880")]
	public void NAHOEIBNFLF(IReadOnlyDictionary<Guid, Guid> OHJCDBAKCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC00F0", Offset = "0x7BBF2F0", VA = "0x187BC00F0")]
	public Guid DKKIOFIIKKJ([In] Guid LMDCFNDMKMH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0240", Offset = "0x7BBF440", VA = "0x187BC0240")]
	public Guid EKOJPGEHMIG([In] Guid LMDCFNDMKMH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0370", Offset = "0x7BBF570", VA = "0x187BC0370")]
	public bool PKLJMCGLEMB([In] Guid LMDCFNDMKMH, [Out] Guid MCOCJMBCCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0370", Offset = "0x7BBF570", VA = "0x187BC0370", Slot = "4")]
	private bool GHHCPCHNALL([In] Guid LMDCFNDMKMH, [Out] Guid MCOCJMBCCJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLBIKMHLHEJ
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
public sealed class MFEMFBOKICK
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AMCAEJIODEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public ALMOMMLHNFJ staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AMCAEJIODEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8AB0", Offset = "0x7BB7CB0", VA = "0x187BB8AB0")]
		internal KCKEEEOMPIF<PEGBLOGFHGN> IAMHDFAFLFI((KCKEEEOMPIF<BGIICJNKCNN> GraphId, KCKEEEOMPIF<DMIELAKFPBJ> NodeId) i)
		{
			return default(KCKEEEOMPIF<PEGBLOGFHGN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private static readonly BNLMKIEDIGD<PEGBLOGFHGN, int?> LCBGODLFPEK;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly long PCHAAKLPDGI;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0BA0", Offset = "0x7BBFDA0", VA = "0x187BC0BA0")]
	public static (long, long) DENIIOMPBDH(ALMOMMLHNFJ CLHFLBKEIHB, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0FD0", Offset = "0x7BC01D0", VA = "0x187BC0FD0")]
	public static long LECCHAONFAM([In] ReadOnlySpan<KCKEEEOMPIF<PEGBLOGFHGN>> KCLALLDEBGM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BC10F0", Offset = "0x7BC02F0", VA = "0x187BC10F0")]
	private static long PLNMDCHFIIF()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EJBODCJHHLI
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public static readonly HashSet<HPGMMJIAFMO> HJMNBKJJMGN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LKCLCJAADNH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HANIJGILPFM : IEnumerable<IHCKNOKFLCP>, IEnumerable, IEnumerator<IHCKNOKFLCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private IHCKNOKFLCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private JDGCHBGAGIG spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public JDGCHBGAGIG <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private BLLDMJFDAEA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public BLLDMJFDAEA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IHCKNOKFLCP System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xED9970", Offset = "0xED8B70", VA = "0x180ED9970")]
		[DebuggerHidden]
		public HANIJGILPFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD47C0", Offset = "0x7BD39C0", VA = "0x187BD47C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4A40", Offset = "0x7BD3C40", VA = "0x187BD4A40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BD48D0", Offset = "0x7BD3AD0", VA = "0x187BD48D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IHCKNOKFLCP> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BD48D0", Offset = "0x7BD3AD0", VA = "0x187BD48D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFB20", Offset = "0x7BBED20", VA = "0x187BBFB20")]
	public static JDGCHBGAGIG KJCDLHKONBI([In] JFDCEMKJOPG HLLMCFGMJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFC90", Offset = "0x7BBEE90", VA = "0x187BBFC90")]
	public static JDGCHBGAGIG KJCDLHKONBI([In] JFBMHOCOHGN HLLMCFGMJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF780", Offset = "0x7BBE980", VA = "0x187BBF780")]
	private static HashSet<NJGNBLJMMHF<DLHPMCKOHHB>> KDGILHBMMGI(IReadOnlyList<IHCKNOKFLCP> ONJBDCAAEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCE80", Offset = "0x7BBC080", VA = "0x187BBCE80")]
	private static void BGICGHIBIHH(JDGCHBGAGIG HKOGNNCBHIE, [In] JFBMHOCOHGN ADKPFLNGLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDEC0", Offset = "0x7BBD0C0", VA = "0x187BBDEC0")]
	public static DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM> DJAOHINLAON(JDGCHBGAGIG HKOGNNCBHIE, BLLDMJFDAEA LPPCNDDHPPA, LNMMLGJHBEE? ELMDIEHENKE, bool CJNAOIFLGHO)
	{
		return default(DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCD70", Offset = "0x7BBBF70", VA = "0x187BBCD70")]
	[IteratorStateMachine(typeof(HANIJGILPFM))]
	private static IEnumerable<IHCKNOKFLCP> AHDMMKAJGLC(JDGCHBGAGIG HKOGNNCBHIE, BLLDMJFDAEA LPPCNDDHPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD4E0", Offset = "0x7BBC6E0", VA = "0x187BBD4E0")]
	private static void BKBAJFKOKBC(JDGCHBGAGIG HKOGNNCBHIE, BLLDMJFDAEA LPPCNDDHPPA, IReadOnlyCollection<ByteString>? HFOHEDCOOMC, IReadOnlyCollection<ByteString>? CGNIOHCHHGP, IReadOnlyCollection<ByteString>? DPIOLNPIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD550", Offset = "0x7BBC750", VA = "0x187BBD550")]
	private static bool BPLPEAJFOKA(JDGCHBGAGIG HKOGNNCBHIE, MGNNNNPADNA MAFCBLAOPBI, BLLDMJFDAEA LPPCNDDHPPA, [Out][NotNullWhen(false)] string? HKIJLMNBOAG, [Out] Dictionary<int, int> DKPGOHHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFE10", Offset = "0x7BBF010", VA = "0x187BBFE10")]
	private static Dictionary<Guid, KPPAPHMMKAL> LECJJDNCOJF(JDGCHBGAGIG HKOGNNCBHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF240", Offset = "0x7BBE440", VA = "0x187BBF240")]
	private static void GHHAMJNKNAB(bool BHIOAAMNJPA, IHCKNOKFLCP ABECEAAIGGD, LNMMLGJHBEE EAMJGKMAAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDBF0", Offset = "0x7BBCDF0", VA = "0x187BBDBF0")]
	private static void CMOGGPHLABO(IHCKNOKFLCP ABECEAAIGGD, Guid BGFODCFIGMI, CFBNLOOHJEC? PGGFKGMKKAK, Dictionary<Guid, KPPAPHMMKAL> PFIAJDPBLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF2D0", Offset = "0x7BBE4D0", VA = "0x187BBF2D0")]
	private static void JPILLIGGEGL(IEnumerable<IHCKNOKFLCP> FAFMPLAPHDN, IReadOnlyCollection<ByteString> HFOHEDCOOMC, IReadOnlyCollection<ByteString> CGNIOHCHHGP, IReadOnlyCollection<ByteString> DPIOLNPIGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BLLDMJFDAEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public bool BHIOAAMNJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public PENNCKBJFOM JKMPKLDNDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public CFBNLOOHJEC? PGGFKGMKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public CFBNLOOHJEC? HPJGCFOFBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public ALMOMMLHNFJ PFBJPGKDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public PLBIKMHLHEJ EELFGPIJKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public EABNBCAMIEN PBOKCFNDLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public NJGNBLJMMHF<BGIICJNKCNN> AELHOHIIHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public OLOMDBJKJCC PLCGAAECDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public List<IHCKNOKFLCP> EPDNBOOJOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public DDJGKBBEDKH PJIJELJFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public HPPMEDCIKJB FIBGBGEFEFF;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CFBNLOOHJEC
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const float POLAFODHJME = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Vector3 FICCENLPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public float GPOEDAABNAL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 ACMDJNLAHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3160", Offset = "0x7BD2360", VA = "0x187BD3160")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS GDPPIDBNGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3120", Offset = "0x7BD2320", VA = "0x187BD3120")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1489500", Offset = "0x1488700", VA = "0x181489500")]
	public CFBNLOOHJEC(Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float GPOEDAABNAL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BD37F0", Offset = "0x7BD29F0", VA = "0x187BD37F0")]
	public CFBNLOOHJEC(UniformTRS KLHMBJICPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3360", Offset = "0x7BD2560", VA = "0x187BD3360")]
	public static CFBNLOOHJEC ODGDIJPHPDA(CFBNLOOHJEC FLKKOCNDECC, CFBNLOOHJEC OMDLHGJJMMB)
	{
		return default(CFBNLOOHJEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BD35E0", Offset = "0x7BD27E0", VA = "0x187BD35E0")]
	public static CFBNLOOHJEC PDHAGBEBCNG((Vector3, Quaternion, float) CAIGHLKIDBF)
	{
		return default(CFBNLOOHJEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3600", Offset = "0x7BD2800", VA = "0x187BD3600")]
	public static CFBNLOOHJEC PDHAGBEBCNG(Matrix4x4 PKABAMEENCN)
	{
		return default(CFBNLOOHJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3760", Offset = "0x7BD2960", VA = "0x187BD3760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2F00", Offset = "0x7BD2100", VA = "0x187BD2F00")]
	public CFBNLOOHJEC HCINCEECMCG(Matrix4x4 JGOMLHGOKKB)
	{
		return default(CFBNLOOHJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD32F0", Offset = "0x7BD24F0", VA = "0x187BD32F0")]
	public static CFBNLOOHJEC KJGPKJEGMNM(Vector3 FICCENLPJEL)
	{
		return default(CFBNLOOHJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3260", Offset = "0x7BD2460", VA = "0x187BD3260")]
	public readonly PHDIMGIMIIP ILLNBGJKKPG()
	{
		return default(PHDIMGIMIIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GMCJCCGMLJF
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KJEHDBLJELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly CPLBNMKFDDE IJEKEHGMOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly JNEBIKAJDEN LLJJIHLBCKH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x174AAF0", Offset = "0x1749CF0", VA = "0x18174AAF0")]
	private KJEHDBLJELM(CPLBNMKFDDE LHEEKNEOKAD, JNEBIKAJDEN KBHJDNGIMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5630", Offset = "0x7BD4830", VA = "0x187BD5630")]
	public LKHFBILEJAO LOOBBJAAAEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5580", Offset = "0x7BD4780", VA = "0x187BD5580")]
	public static DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM> FAHGDJGLLGD(MAAGJJPKGFG<LMEKHMKKIDI> KBHJDNGIMJM)
	{
		return default(DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5410", Offset = "0x7BD4610", VA = "0x187BD5410")]
	public static DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM> FAHGDJGLLGD(LKHFBILEJAO KBHJDNGIMJM)
	{
		return default(DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BD54C0", Offset = "0x7BD46C0", VA = "0x187BD54C0")]
	public static DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM> FAHGDJGLLGD(string BKFMMHJOHPD)
	{
		return default(DJNAMIFBMIO<LNMMLGJHBEE, KJEHDBLJELM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CPLBNMKFDDE
{
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ACKEJBNOHCJ : IDisposable, POJLDBNILMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private NativeList<FOAHBAFICDA> BACDLJGLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private float HAMKEMFIEFO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FEDMKIFLINL OEEKOEDDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
		[CompilerGenerated]
		get
		{
			return default(FEDMKIFLINL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JCPJHKNGOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5CC0", Offset = "0x6AE4EC0", VA = "0x186AE5CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IKGKNGBFGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5CD0", Offset = "0x6AE4ED0", VA = "0x186AE5CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<NJJEDGNFKNM> LGDEEKIFAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DAIEFNGNGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE4E0", Offset = "0x7BCD6E0", VA = "0x187BCE4E0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float PGMEEBHPBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD0560", Offset = "0x7BCF760", VA = "0x187BD0560")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0A50", Offset = "0x7BCFC50", VA = "0x187BD0A50")]
	public ACKEJBNOHCJ(FEDMKIFLINL FFMDBMBLMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF190", Offset = "0x7BCE390", VA = "0x187BCF190", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCECC0", Offset = "0x7BCDEC0", VA = "0x187BCECC0")]
	public Vector3 DMNJOMPGKLC(int CIAPLOIMNOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD03D0", Offset = "0x7BCF5D0", VA = "0x187BD03D0", Slot = "6")]
	public Quaternion LGNNOJCHMEG(int CIAPLOIMNOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD06A0", Offset = "0x7BCF8A0", VA = "0x187BD06A0", Slot = "5")]
	public Vector3 MGEIKIPABMM(int CIAPLOIMNOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0500", Offset = "0x7BCF700", VA = "0x187BD0500", Slot = "7")]
	public float LHMJLOEGPPO(int CIAPLOIMNOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BCFAF0", Offset = "0x7BCECF0", VA = "0x187BCFAF0")]
	public void JPJPKIGOMMO(Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH, bool BJBDNNHOBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0890", Offset = "0x7BCFA90", VA = "0x187BD0890")]
	private bool ONDNJCNGNAG(int PJHEDIKALCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BD08F0", Offset = "0x7BCFAF0", VA = "0x187BD08F0")]
	public void PFHPHICAEAI(Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF260", Offset = "0x7BCE460", VA = "0x187BCF260")]
	public void GGAMPHHEDCN(int PJHEDIKALCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0740", Offset = "0x7BCF940", VA = "0x187BD0740")]
	public void MNADKCKMFBB(int PJHEDIKALCF, Vector3 FICCENLPJEL, Quaternion NDOBKEDDJAJ, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE680", Offset = "0x7BCD880", VA = "0x187BCE680")]
	public void DANILEIMDFB(int PJHEDIKALCF, float3 FICCENLPJEL, quaternion NDOBKEDDJAJ, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE390", Offset = "0x7BCD590", VA = "0x187BCE390")]
	public void ADIGKOKEKOP(int PJHEDIKALCF, Vector3 FICCENLPJEL, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE520", Offset = "0x7BCD720", VA = "0x187BCE520")]
	public void COABHBHFAKE(int PJHEDIKALCF, Vector3 BNGNHOGLPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF2F0", Offset = "0x7BCE4F0", VA = "0x187BCF2F0")]
	public static Quaternion JKAENICLFEC(Quaternion DIFHEMCKFDL, int PJHEDIKALCF, float JEIDFPDHBBJ, POJLDBNILMM OJIKLDMECAE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE830", Offset = "0x7BCDA30", VA = "0x187BCE830")]
	public Bounds DKOFHFEHHAM(Transform JGOMLHGOKKB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF1F0", Offset = "0x7BCE3F0", VA = "0x187BCF1F0", Slot = "10")]
	public virtual void ECFNELJFHGB(bool JADGFLIMFHO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE2C0", Offset = "0x7BCD4C0", VA = "0x187BCE2C0")]
	public NativeList<FOAHBAFICDA> ACIJLALDLAI(float NDMFCLKMKKL = 1f)
	{
		return default(NativeList<FOAHBAFICDA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NJJEDGNFKNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public float3 MILMNOPOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public float NLABEFHONMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public quaternion JBHJGLCDBPL;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA760", Offset = "0x7BD9960", VA = "0x187BDA760")]
	public NJJEDGNFKNM(Vector3 ICPEADDPOJA, Quaternion DIFHEMCKFDL, float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA210", Offset = "0x7BD9410", VA = "0x187BDA210")]
	public Quaternion BLPCLFFJNBL(Vector3 JBACNGDELHL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA470", Offset = "0x7BD9670", VA = "0x187BDA470")]
	public NJJEDGNFKNM PBLDOJJFOHB(Vector3 DEDELEDCOPE, Vector3 IBHOFCHJGEO, Vector3 PBICPDAJJIK)
	{
		return default(NJJEDGNFKNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA2D0", Offset = "0x7BD94D0", VA = "0x187BDA2D0")]
	public OLMJOIFOOPE IJBBOOIGDKB(Vector3 JBACNGDELHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DFGECECBNDG : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4180", Offset = "0x7BD3380", VA = "0x187BD4180", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3B40", Offset = "0x7BD2D40", VA = "0x187BD3B40")]
	private void DABFEGPBAEP(Dictionary<Guid, Guid> FBGLCKAPGAI, LCDMLFIEJBI KCJALAPDKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4120", Offset = "0x7BD3320", VA = "0x187BD4120")]
	private void DABFEGPBAEP(Dictionary<Guid, Guid> FBGLCKAPGAI, PAKDFNNCKBG CFPKCNBABGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BD38C0", Offset = "0x7BD2AC0", VA = "0x187BD38C0")]
	private void DABFEGPBAEP(Dictionary<Guid, Guid> FBGLCKAPGAI, GMCHBHMNBFO GDMNBFHPBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DFGECECBNDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class MGDMIIFBNKM : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9A30", Offset = "0x7BD8C30", VA = "0x187BD9A30", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public MGDMIIFBNKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class PDKHHLJDBPJ : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAA10", Offset = "0x7BD9C10", VA = "0x187BDAA10", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PDKHHLJDBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FOHHOGOIIED : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4420", Offset = "0x7BD3620", VA = "0x187BD4420", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public FOHHOGOIIED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FKJJMOLJKKA : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4200", Offset = "0x7BD3400", VA = "0x187BD4200", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public FKJJMOLJKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OGJIHOKMFDJ : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA8D0", Offset = "0x7BD9AD0", VA = "0x187BDA8D0", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OGJIHOKMFDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LELHHGMHGOL : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BD96F0", Offset = "0x7BD88F0", VA = "0x187BD96F0", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LELHHGMHGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NKFGGMGAKAL : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA7E0", Offset = "0x7BD99E0", VA = "0x187BDA7E0", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NKFGGMGAKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class LOCABALHADO : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9880", Offset = "0x7BD8A80", VA = "0x187BD9880", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LOCABALHADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NHLGEMBCILF : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA060", Offset = "0x7BD9260", VA = "0x187BDA060", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public NHLGEMBCILF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class AKNKAABJADI : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1C40", Offset = "0x7BD0E40", VA = "0x187BD1C40", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public AKNKAABJADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PFCONECAADF : HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public static readonly OEBPBNNAGAK IMIFBIFHNAN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDAB70", Offset = "0x7BD9D70", VA = "0x187BDAB70", Slot = "4")]
	public void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PFCONECAADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KIHGCFJDKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public MGNNNNPADNA EPCDIDIGEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public DKAIOKKDNAG NOOEDMLEAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Dictionary<int, int> MGBFCIHEDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public Dictionary<Guid, Guid> KIMAFPMDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public HPPMEDCIKJB FIBGBGEFEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public bool CJNAOIFLGHO;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HJMDEEBFGAG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCIHDGLIJFH(GMHKPMNNFNO AHCGPLMGKOM);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AFKMJHBIHPC
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private static readonly HJMDEEBFGAG[] HLEEGKBMEJH;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0AE0", Offset = "0x7BCFCE0", VA = "0x187BD0AE0")]
	public static void JABKJGNNBJM(IHCKNOKFLCP CAIGHLKIDBF, LNMMLGJHBEE LDANDDGBNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD13B0", Offset = "0x7BD05B0", VA = "0x187BD13B0")]
	public static void MAHONGFPMMG(IHCKNOKFLCP? CAIGHLKIDBF, LNMMLGJHBEE FKKOMAHAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0D60", Offset = "0x7BCFF60", VA = "0x187BD0D60")]
	public static void JGIFNKGOIDI(IHCKNOKFLCP? CAIGHLKIDBF, LNMMLGJHBEE EAMJGKMAAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0FE0", Offset = "0x7BD01E0", VA = "0x187BD0FE0")]
	public static void KPBNANNLKDK(GMHKPMNNFNO AHCGPLMGKOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GMHKPMNNFNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public MGNNNNPADNA ICJKPMCNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public IHCKNOKFLCP ABECEAAIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public Dictionary<int, int> MGBFCIHEDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public Dictionary<Guid, Guid> KIMAFPMDDNK;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4720", Offset = "0x7BD3920", VA = "0x187BD4720")]
	public Guid IKMHDKMGPKG(Guid DJOIAEMCFDK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HPPMEDCIKJB
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EPBMAKFOPEN, [Out] Guid GFPADKPELNM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LEFCPINKBPL
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private static readonly HashSet<Guid> EBHJGHCMGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly ProfilerMarker NBNPLLDIAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly HashSet<string> EFAJONAFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly Dictionary<long, int> HOEGNCPJGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly HashSet<Guid> BJJODGFJAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> FPDFLIDFLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> FJAAAGGEHFE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> NBIKEPHPDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> EIHMOMLLMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyCollection<Guid> KPIGNKFEFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<long, int> PPPGOMJMKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BD75E0", Offset = "0x7BD67E0", VA = "0x187BD75E0")]
	public static void OMDCPCMLOEI(JDGCHBGAGIG FLFKJAMBMAE, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7350", Offset = "0x7BD6550", VA = "0x187BD7350")]
	public static LEFCPINKBPL JNGCCCOBCAF(OJIMHFCMHLE JCFOMPGDMKN, NFBMMPLDNBK? BDNGMBOANGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6810", Offset = "0x7BD5A10", VA = "0x187BD6810")]
	public static LEFCPINKBPL FKGJOMHAPEH(JDGCHBGAGIG GHKFAGNCENM, NFBMMPLDNBK? BDNGMBOANGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9120", Offset = "0x7BD8320", VA = "0x187BD9120")]
	public static LEFCPINKBPL PNHCMBKIEMN(BGHIBIIDEAE GJMFDBFOOGK, JMCHCKCNMMA HBEMCIPCOAI, NFBMMPLDNBK? BDNGMBOANGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD73D0", Offset = "0x7BD65D0", VA = "0x187BD73D0")]
	public static LEFCPINKBPL KMCMOIHJJNC(IEnumerable<string> EFAJONAFDHH, IReadOnlyDictionary<long, int> KDKJICKMEEL, IReadOnlyCollection<Guid> FJAAAGGEHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9360", Offset = "0x7BD8560", VA = "0x187BD9360")]
	private LEFCPINKBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD94F0", Offset = "0x7BD86F0", VA = "0x187BD94F0")]
	private LEFCPINKBPL(IEnumerable<string> EFAJONAFDHH, IReadOnlyDictionary<long, int> KDKJICKMEEL, IReadOnlyCollection<Guid> FJAAAGGEHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6570", Offset = "0x7BD5770", VA = "0x187BD6570")]
	private void AACCKBFGCFI(OJIMHFCMHLE JCFOMPGDMKN, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD61A0", Offset = "0x7BD53A0", VA = "0x187BD61A0")]
	private void AACCKBFGCFI(JDGCHBGAGIG GHKFAGNCENM, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6890", Offset = "0x7BD5A90", VA = "0x187BD6890")]
	private void FLCNIALIOAM(ByteString? HCODAOPDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5AA0", Offset = "0x7BD4CA0", VA = "0x187BD5AA0")]
	private void AACCKBFGCFI(BGHIBIIDEAE? OLEJNEHCCLF, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6120", Offset = "0x7BD5320", VA = "0x187BD6120")]
	private void AACCKBFGCFI(JMCHCKCNMMA? HBEMCIPCOAI, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6430", Offset = "0x7BD5630", VA = "0x187BD6430")]
	private void AACCKBFGCFI(IPIOEIAGLIA? NFFIHFHPJCH, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6E90", Offset = "0x7BD6090", VA = "0x187BD6E90")]
	private static bool HMECIBIBKNE(IPIOEIAGLIA NFFIHFHPJCH, int GPCBLAIKKNA, [Out] Guid KBPLABLNAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8CB0", Offset = "0x7BD7EB0", VA = "0x187BD8CB0")]
	private static void OMDCPCMLOEI(JMCHCKCNMMA? OLEJNEHCCLF, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7FE0", Offset = "0x7BD71E0", VA = "0x187BD7FE0")]
	private static void OMDCPCMLOEI(IPIOEIAGLIA? NFFIHFHPJCH, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8D80", Offset = "0x7BD7F80", VA = "0x187BD8D80")]
	private static void OMDCPCMLOEI(BGHIBIIDEAE? OLEJNEHCCLF, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8660", Offset = "0x7BD7860", VA = "0x187BD8660")]
	private static void OMDCPCMLOEI(HJDOBBJKMEM? HFACGLFOMBB, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5E00", Offset = "0x7BD5000", VA = "0x187BD5E00")]
	private void AACCKBFGCFI(HJDOBBJKMEM? HFACGLFOMBB, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7140", Offset = "0x7BD6340", VA = "0x187BD7140")]
	private void JCJKNDJHOCH(Guid? DJOIAEMCFDK, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BD56A0", Offset = "0x7BD48A0", VA = "0x187BD56A0")]
	private void AACCKBFGCFI(IHCKNOKFLCP? ABECEAAIGGD, NFBMMPLDNBK? BDNGMBOANGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8220", Offset = "0x7BD7420", VA = "0x187BD8220")]
	private static void OMDCPCMLOEI(IHCKNOKFLCP? ABECEAAIGGD, NFBMMPLDNBK BDNGMBOANGD, LNMMLGJHBEE AKDDOLMOLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BD70D0", Offset = "0x7BD62D0", VA = "0x187BD70D0")]
	private void IHIMBMFILBN(string? BEEKDDKGMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD74C0", Offset = "0x7BD66C0", VA = "0x187BD74C0")]
	private void OGBPDPKINCF(long GENJIKHAHJC, Guid FBECHAPLEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7590", Offset = "0x7BD6790", VA = "0x187BD7590")]
	private void OGBPDPKINCF(ILFGOFEEEPE? MEGDFPEBGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7460", Offset = "0x7BD6660", VA = "0x187BD7460")]
	private void OGBPDPKINCF(LOMODEEFLMO? MEGDFPEBGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BCPBDGNNKBM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class PKFGCPNDNAD : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private readonly IEnumerator<DictionaryEntry> CMBGOOFPBLB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DictionaryEntry HANNHKMAACK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7BDAE20", Offset = "0x7BDA020", VA = "0x187BDAE20", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object JLFEKHMMFHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7BDAEF0", Offset = "0x7BDA0F0", VA = "0x187BDAEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object LFLEGEJLLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BDAFA0", Offset = "0x7BDA1A0", VA = "0x187BDAFA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object FJFNMMOOKII
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7BDAD40", Offset = "0x7BD9F40", VA = "0x187BDAD40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
		public PKFGCPNDNAD(IEnumerator<DictionaryEntry> CMBGOOFPBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BDACA0", Offset = "0x7BD9EA0", VA = "0x187BDACA0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDACF0", Offset = "0x7BD9EF0", VA = "0x187BDACF0", Slot = "9")]
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
		private sealed class FPOEGPPIJIA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BD46D0", Offset = "0x7BD38D0", VA = "0x187BD46D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public FPOEGPPIJIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4580", Offset = "0x7BD3780", VA = "0x187BD4580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4680", Offset = "0x7BD3880", VA = "0x187BD4680", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BDB620", Offset = "0x7BDA820", VA = "0x187BDB620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IDictionary.this[object MHDODBCCAJB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB530", Offset = "0x7BDA730", VA = "0x187BDB530", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB700", Offset = "0x7BDA900", VA = "0x187BDB700", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB470", Offset = "0x7BDA670", VA = "0x187BDB470", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB4D0", Offset = "0x7BDA6D0", VA = "0x187BDB4D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB6A0", Offset = "0x7BDA8A0", VA = "0x187BDB6A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB130", Offset = "0x7BDA330", VA = "0x187BDB130", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB190", Offset = "0x7BDA390", VA = "0x187BDB190", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7BDB1F0", Offset = "0x7BDA3F0", VA = "0x187BDB1F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
		public RoomObjectCounts(Dictionary<int, int> BFIHHCCNIBL, [Optional] Dictionary<int, int> IIHFAGNPGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB050", Offset = "0x7BDA250", VA = "0x187BDB050")]
		[IteratorStateMachine(typeof(FPOEGPPIJIA))]
		private IEnumerator<DictionaryEntry> IDHHBAMIDEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB750", Offset = "0x7BDA950", VA = "0x187BDB750", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB370", Offset = "0x7BDA570", VA = "0x187BDB370", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB250", Offset = "0x7BDA450", VA = "0x187BDB250", Slot = "9")]
		void IDictionary.Add(object MHDODBCCAJB, object KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB2B0", Offset = "0x7BDA4B0", VA = "0x187BDB2B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB310", Offset = "0x7BDA510", VA = "0x187BDB310", Slot = "8")]
		bool IDictionary.Contains(object MHDODBCCAJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB410", Offset = "0x7BDA610", VA = "0x187BDB410", Slot = "14")]
		void IDictionary.Remove(object MHDODBCCAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB0D0", Offset = "0x7BDA2D0", VA = "0x187BDB0D0", Slot = "15")]
		void ICollection.CopyTo(Array KBILCKNPAKO, int CMDFFDAPDIB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class MGMAKLPBMFM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BD9C70", Offset = "0x7BD8E70", VA = "0x187BD9C70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public MGMAKLPBMFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7BD9AE0", Offset = "0x7BD8CE0", VA = "0x187BD9AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7BD9C20", Offset = "0x7BD8E20", VA = "0x187BD9C20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BD50D0", Offset = "0x7BD42D0", VA = "0x187BD50D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IDictionary.this[object MHDODBCCAJB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4FA0", Offset = "0x7BD41A0", VA = "0x187BD4FA0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7BD5180", Offset = "0x7BD4380", VA = "0x187BD5180", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4EE0", Offset = "0x7BD40E0", VA = "0x187BD4EE0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4F40", Offset = "0x7BD4140", VA = "0x187BD4F40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7BD5120", Offset = "0x7BD4320", VA = "0x187BD5120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4B60", Offset = "0x7BD3D60", VA = "0x187BD4B60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4BC0", Offset = "0x7BD3DC0", VA = "0x187BD4BC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4C20", Offset = "0x7BD3E20", VA = "0x187BD4C20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x288BE40", Offset = "0x288B040", VA = "0x18288BE40")]
		public Invention(long APBCLGNDGBE, int OCEHNHGKKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4A90", Offset = "0x7BD3C90", VA = "0x187BD4A90")]
		[IteratorStateMachine(typeof(MGMAKLPBMFM))]
		private IEnumerator<DictionaryEntry> IDHHBAMIDEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7BD51D0", Offset = "0x7BD43D0", VA = "0x187BD51D0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4DA0", Offset = "0x7BD3FA0", VA = "0x187BD4DA0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4C80", Offset = "0x7BD3E80", VA = "0x187BD4C80", Slot = "9")]
		void IDictionary.Add(object MHDODBCCAJB, object KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4CE0", Offset = "0x7BD3EE0", VA = "0x187BD4CE0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4D40", Offset = "0x7BD3F40", VA = "0x187BD4D40", Slot = "8")]
		bool IDictionary.Contains(object MHDODBCCAJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4E80", Offset = "0x7BD4080", VA = "0x187BD4E80", Slot = "14")]
		void IDictionary.Remove(object MHDODBCCAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD4B00", Offset = "0x7BD3D00", VA = "0x187BD4B00", Slot = "15")]
		void ICollection.CopyTo(Array KBILCKNPAKO, int CMDFFDAPDIB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HGGKGOGKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyList<Invention> JEMEBPDIECI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	public BCPBDGNNKBM(IReadOnlyDictionary<Guid, RoomObjectCounts> DJOMGEINNHD, IReadOnlyList<Invention> PFJODPDLNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2520", Offset = "0x7BD1720", VA = "0x187BD2520")]
	public static BCPBDGNNKBM JNGCCCOBCAF(OJIMHFCMHLE JCFOMPGDMKN)
	{
		return default(BCPBDGNNKBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2400", Offset = "0x7BD1600", VA = "0x187BD2400")]
	[CompilerGenerated]
	internal static int HJBDCMDEFDJ([In] IReadOnlyDictionary<long, int> HLCCAKMICLD, long? GENJIKHAHJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1D40", Offset = "0x7BD0F40", VA = "0x187BD1D40")]
	[CompilerGenerated]
	internal static void ENNCOKGJNJP(int MMFIEFJANOM, [In] BGHIBIIDEAE EJEJKPIJEPM, [In] Dictionary<long, int> HLCCAKMICLD, [In] Dictionary<Guid, RoomObjectCounts> DJOMGEINNHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum GAFPFHPADLO
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
public sealed class NFBMMPLDNBK
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class JJIDONKEFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly Guid GJJACFEFMNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly IReadOnlyList<Guid> EIHMOMLLMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly GAFPFHPADLO IJEKEHGMOMM;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD53B0", Offset = "0x7BD45B0", VA = "0x187BD53B0")]
		public JJIDONKEFDN(Guid KNDLKPHHAPO, IReadOnlyList<Guid> FJAAAGGEHFE, GAFPFHPADLO LHEEKNEOKAD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly LNMMLGJHBEE CJLAGBJNJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly Dictionary<Guid, JJIDONKEFDN> ELOKBJIHIOA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LNMMLGJHBEE NJIHAFBFCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9DB0", Offset = "0x7BD8FB0", VA = "0x187BD9DB0")]
	public void LHOMNBOIMGH(Guid DIKAMEMHKPL, Guid NMFBFAGHDHK, IReadOnlyList<Guid> LCPHKKNHGHC, GAFPFHPADLO LHEEKNEOKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9CC0", Offset = "0x7BD8EC0", VA = "0x187BD9CC0")]
	public bool BBMGJKNAGJI(Guid AMMJLOOGFJK, [Out] JJIDONKEFDN GKMHFNCJKGE, [Out] bool KJFBGCBDOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9FC0", Offset = "0x7BD91C0", VA = "0x187BD9FC0")]
	public NFBMMPLDNBK()
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
