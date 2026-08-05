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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x845A150", Offset = "0x8458B50", VA = "0x18845A150")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCJDCMDHFEB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> FIDKHIAEDMM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MFDLCKICGGC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> FEJIBNFCPFI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> GFONAMCDJJC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string DOIPHMILGGA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string EMNPKGNFGJO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string GCIKBBPHMBK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8456730", Offset = "0x8455130", VA = "0x188456730")]
	public static bool MHBKGOJMELO(Guid EECLMBLGCGI, int MKFLFCHJIGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8456830", Offset = "0x8455230", VA = "0x188456830")]
	public static bool PPIJNNKFAEA(Guid EECLMBLGCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8456060", Offset = "0x8454A60", VA = "0x188456060")]
	public static string GABIJKMLMFH(Guid OCONCDFGCOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MEHDELHJEOO]
public enum FKBLBGCNFAH
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8455F90", Offset = "0x8454990", VA = "0x188455F90", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HHHNEACPKBD
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GDPJOLHMEMP;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid CKGIFBNJJDE;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid NDOCPNINHBO;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid GPJNCLFECIL;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JKFHKBJNJHH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid BJFGGFCPDDI;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid DEAEBFEMLHH;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid EHPHBFBHKAK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid ONGNMBCHEHL;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HALGAMDEOAI;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid HMNEEKLANHM;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid MNJABMBHNDC;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DABEHBDAHHH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LGJMJJLFJEE;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid NFCOCDPBFMD;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GBDIDIEMFON;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid MDIAEBAKCEO;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GEMKLEBIPBE;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PHDGJMILOPB;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GECABKBHAPM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid ABIMIOCBEJF;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CJGKALIJJHJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid PENIHAPIHCD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid KOHKAMOFCIA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid OLAPKIFICPE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid ONIJBIFKLMJ;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CHCKKEGGBIB;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid HOCICMKONJD;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid AEKEPCEALCG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GINMLHBLPEG;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid NCLKKMHPHFI;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid GDDGDFDKEMI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid FJLJAJOJPCF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid ABNELHFEOJI;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid MMCACANAEHC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JPFEFODJPKK;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid DFFIKFBKLCN;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FGADJNNJGFD;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid LJADMPBNJNB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LILBGIMDHDD;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid DOBADILLICC;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BLECOINCAKP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LMPFHLFKAFN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid DKMKIEGEFDK;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FANDDLBGOML;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JDPDLHPNCOG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BKHGOOFJNAF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid KMGLEKEIGDE;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid GCMCBAGKHGO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid HDABNFDLEEG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid BKMEEMJDBCC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KHLCHAHCIGN;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NPNLJFJCFEM;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NIEIGEHHNNJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid LEEDGMJBPNN;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MJCHMHHBKIG;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OLCPEJJAPMM;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MEJNFNCKCIM;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid FACPKNCPDGO;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid MEGHEPPMIJA;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JLOKHBGGDAB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid LOMEDIODJLH;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NOKKNKJIIME;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid NLLJFIGFHJK;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid MAGNBLFBDIA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HILENIPHHHC;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid BFBKFGMMFOO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid JMGIACMEEMN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid BNEFCDLPICE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid OBDNKEKOOMI;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid IAPBLBLBPOC;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid BGHJEICAJJO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JICDCIDLJEN;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HKBJKEGNNJG;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid JJONKEILFPI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid GKFFBIFMEGG;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid HFCLCJJMLOC;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid LLGBPNLMNDA;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid GGBDALNPCFL;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid MEBEOCDLIHD;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid NJHBENOKALJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid JPNGOCOBGDA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid CEPCLCJDOAO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid MBNFBDOCBEE;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KAFNLDFBFNI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid OGEFGHJJPGH;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid GPPMCAOLHPK;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ACLBOLEGINC;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid DLCFEADLFDM;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JGEKFIOLDOH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid MEFOJDGDHGB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JJLADPJEHCF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid PPAFFMBEOGF;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid MHHKHEMJJAB;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FADGCEDBNPK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FFFKKONABJP;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid KNMJBFHMJHH;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid DIKEAOFELFK;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid FNABANNNJIM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid FHNBIMDLFDF;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EKGFDHBOBLA;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DCEHJGJINEF;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid BIHFLGCFPEI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MEOOFIDEIAK;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HIHPKCPJNJI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid COGAEEENAJE;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BALOEMLICLN;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid DLNJFDBIOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DEOBENAEOOC;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid COMGAEOBLBA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KDCPOKLPNFI;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid HPCOJMHAHAB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CDMBOHFPKKA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HNKOCCGOOJF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CHEHCJMLMPA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HKECBAKLODD;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid DBEGEHGNFML;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DKJBGJHBBDF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid PCDCCPAMGCD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid GONIDMCDBBG;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid KIIGGBKNHLJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MFJIDLAPPAF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ENPIOOONFIG;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid AFKAFMOBHBC;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid MAECLLAPHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid DJHIAHOEGHJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid DMKOKFKOMNF;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid NJOMKKHEKDP;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KFLAGFJGAHD;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid IPOJAHPMEME;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BDMNBCIFNIJ;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MEILGEDADBK;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid ECCNKKDNICO;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BDCHFGJJHPE;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HDOBDDKOKCM;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid MOECOKLFHPP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid ENKNDKHIMIA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid PAMMENGACPF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid CFINKMPNBPO;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid GGLMMMIOMFP;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid DEICLHKGKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid NPFOAKKKECC;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid EIPICCOICGH;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid KALPNOIDBJH;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid AJMCMDJEEDB;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid COHKLMPBHGN;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PMNHCAKMLJB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid JDKAKGELBMG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LCIFIGKHJLE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LGALHPOHFKC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid HJPBNPLHNJA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid KNDIFHGOPLA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid EEKJDBHCHDC;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BJIICDJAIII;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid NDBJLGJAIFL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid NEOOHANAGAB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid CIFKIGAKNBP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid GCHOKHGJGEP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JJGCIJGOFIG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid JDEHFAPHBIA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid PPPJMKFNLMF;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BEPBHJNEALI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid ACJHOCPMGIH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OCPLFANADML;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OEDCNMLHDJF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid PFECJBIGADC;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GOMPKBCFHDG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MLBMKKNOBLP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid KBNNJKCCJLB;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PLAOGMHLKLM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid HPDODJPEPDG;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid CNOGFGPPDFG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid HKPCFKONBJE;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid DIJIABOGJMM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CEKKDONFICP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid IPNHONHKCCG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IJKDHFMCNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid JBOPFKMGFBF;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PJNPHEGKICI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JAGHHNNMEHI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LKLGMAPOLFO;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid DHLOKLBBIMI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid JIGHABNDDPJ;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid OKAEKBCPHNM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JKIKNNGBNKC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FPCBINKGLHE;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid APECGLAIKHM;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CJIKPAKCJOO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid IKCDPLGMHIK;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LGEFINDCKGE;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid MBPKIOIIDNL;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid FFFHBMGBKKO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AFEJMICHJFH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid ICPCHOIILEH;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GJEOPJODMEG;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid ABMFPABLNAF;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid EFECJCPANKP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IBDJNKCDDCL;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid PACAOOCFNCD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid JEKBHMOADMK;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KBKDBMEEHML;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FOOEEOMDOKB;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid AMABLLCAKGB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid GKOENDMFNCF;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KFJLMCJJGOC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid CLJHMPJAHIE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid CNLOOAMDPBG;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid GEIEGOIJPII;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid FJLAMIFMDBI;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid PJONEMHOMKE;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid AFEJFJBIINK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid EOEKBFECJMN;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid OFIPCAHMNOM;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid CPAMDKLELLH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EBPMPCNGLFA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid ACONCLPLPBG;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid EDJOBKFCGEE;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid PCMBNPFMCEN;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid EOEDNKDMFGI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid NJMFKHJCFBN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid MIIKHCHKFGB;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid OGIBPEAPJCE;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid DGOBJFGIBMK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JFIAGMICPGN;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid GOHOAAGILPL;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid PCGOEBKAPNA;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DBDINHODMIE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid DOKPPLIEBKL;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid FLOFKKEMAKC;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PCLNMKGEKLK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GODCCNJIDIH;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid DGIFGAOJLCN;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid AFBHGAIPPLL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid PBGDKCPICOA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid JHBPNBGAOPL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid LDPIEHMMMGG;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid GDGHKLCCFFM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid DDGCCFDDLEP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HLNJELMLIPH;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid NBCFJHJHALD;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GFADKFLOLHD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid BDIGBPFOJFO;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid HNKNLMKPGED;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid GLFNNHHOCMP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MPGMJJDFCOC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid AHGDKEELPJG;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid OOIGJHAJHKP;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BJNHEPHKPBG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid ALPAIPGJAAK;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BGOCCOKHANA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HBHOAIKNMHD;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid HJMHNHGACLN;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HOHOBKAMFIE;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid PAKPEONNLBI;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid FOFBHCBNGHD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LNPKDHFJEKG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GMBPBPIHFKG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid ANFHEPJIEEI;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid ICKHHBKAIGG;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OPBGBHLHACC;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid LLFBMFBHDFA;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid PLGHNCJLBPH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid PMEILCEPKEE;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid PFLJKEAGNPG;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid CPAPCCGGMNC;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CLADIHNDDIN;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid IEGMDPOKNCD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid PKPOIPHEMEL;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid IBBCDKNOKFE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid MPDKOFHPFOA;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid NCAKMMCPHOB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LJFLFENIFCA;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GKILHBBNNMM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JEOIMFJKHEA;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PDJKMJAGKPN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FGJLDGKDIHB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HLDDMADKOOA;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HFFALMFOKNG;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid CJHGDAKGKEO;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid MKLJNCINOGD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid LBKJECNMKFF;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AJCIACPGIFN;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LLLIHBGPODA;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid CHLFDBPGLOE;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid PAGLKNKKFPP;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid BFBHHBEEGIF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LMOKFHIFKKH;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid JJOJBIPBHHJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DABBAMGBKJO;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid CMMFBLJFHAH;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DOPNAPEGMKI;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CBOAKFNBCJE;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GKJGJLHBPCJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid OEHCIFKKEBO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JILMPFBNNHP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BNBJOKNCAOL;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid MMBEANMIHOE;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JEHKBOKAJNJ;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid FEJCMAFPNCM;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FJADEBFCOON;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid PAHOLIDNFAK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NEEHIFKLKBK;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid CNCCBLOBHOC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid PLPLGOMJHAI;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid GJOFPKEPMPJ;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CBJLAFEOIHF;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid JKCLJMGGLOO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid KEEEFIIEDNG;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid FJHDICGHGFG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid LIEDMACOKEJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid FJICLDEMGEI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid IBMJKJJGBDK;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ENGOKJNNEEB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LIFFLHBGDDP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JLGHCEDLOCD;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid KPGMEHNJFOJ;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HJDDLDCNHED;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HPAAIMECGLL;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid MHLBDOPBGBC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid EONAPJFONHC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid PKNMILJMJHC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CEGHKDFIFLJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid CFGCLBDBFAO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid KEFGJMFLMFJ;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IBCMKMAAEDA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CJODEFOFKHD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid FIIICKJBBKM;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid EICBLBOPLBL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid NDFGJPFNMJN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid IMBOCKONGOD;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid MHAOOOMCEFL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid HPEGPOLAJDL;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HOJJAFNDIKD;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid PDFLPJNBHKI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FAADAJJGGKM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IHIIJKCNJLH;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CEMBBLAIHHO;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid ACKKEGGLPCF;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BCECHIFNKMI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid EBJNJGJJDAL;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HIFKGMDHMDP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid ALCCFAECFAL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid BJHBKJDPANF;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid CBGNHNMKEND;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FJGLFEHAEFD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AOFPJHOAPGF;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GLMFKGPPPHK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid MNCBGBAPLAO;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DOFHIGLCENN;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NEIFNJEAJOH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid ANBHLBNAMIB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GIGDFMFBNPK;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid GOMBKJAOHIB;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid OIOGCDHIDDB;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid EMEHLCPOICO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid CJHIKJOHNLI;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PBBJOFAOHOB;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DOFLIANPOLD;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid HGDFNELEAHE;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid JLDNGBHBDNE;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid AKODNFGNEKF;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HECPAJBGBDJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BFIDEIOLKEB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid HBDBJJNJMNP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid GGHBIBBPHOF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ACNCMNFFONO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid JIPHDNNFDBF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid JHCFNCKCPLG;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid ALGJCABPODO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IHMPCOAHAJH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PKGLFJDEPAD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid KDNFLFIODBO;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KGAGAFCDDAF;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KABBFPIDJAG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid ICIPABGJNKB;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid AGDDMPDKJAB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid PIBKJBMBBLE;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CEINMNPGACB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PEKNPOBNKPG;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid NKGAFCGJOHL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid LAMJDEEHELJ;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid CANMOLCLMIN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid NKFLFGCJGPL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GKOLCMCNJEK;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NJDFIHDGOGA;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JPBEDKJENAG;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid BOEAHECBEMF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BHKCBDAKEPP;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid HOFNLEKCCLC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DPNHBCGLHFB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IFIJGFLDIBN;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid PMMLMBEPELF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid CLNFKMNAFCE;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FPCKANBKHBG;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid AACHPDKKNAO;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid MBFDFBCLPIE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BEKBDHBIFFI;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GPDEMKMFHBD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HCCONIBNDLC;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid AIKGDFODJDO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid NICCGNENDLC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FCPEOMIGIAN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid MPNFPPLOJBA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid NMNLBBCEKIN;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid HEGOPGKNEHP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid HEFHCJPIPEJ;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid KPABPNONMOE;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid CHEIJDIHGJD;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MHHEEHNEACM;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DNGAIKPKFBC;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MDJABJPKIDC;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid IPNNKPCJADC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid NCFIFKILHGA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid CDMLPLLLHOC;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FJPHJBDMLBD;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid NCIEPCIHFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid HHGKFEMEKPL;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PGJALOAJPEI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid PGLIAMIJHIF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid EGBHKFKOOJL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid EKFNCLDHEKA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid ONCOMDACDGE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid DNBAJOBKALG;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid MMENCDOPLJO;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid ACFABPABFFM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid OCOILBJICEG;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CHMJLDAPEIC;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OLCMFENIHEG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DGGKMEOOGNM;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid PBCLJLHGINM;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid KFBGEJHGGGE;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid AGFDINBLEEE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid AGEGLDBOMJB;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid JIJIKMJODDE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid IJNNKKHBFHL;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid BJDJINJEADJ;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid AIGCLMECPED;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid KNCLGDCPLCG;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid CLLBGHBLDPA;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DFMJEECJMEH;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid OAPEPKJFFPL;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid LBANOKBDIHN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid DOLEIGAKKOB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BAIMLEBLKHE;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid DODFNCPEPMK;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid LIOCFIKKDGB;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KAPODMNJFCA;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid ONNNLFNNMDD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PFDOILDENFD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid MNCBPDMMHPA;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GLIILDLJOAE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid FLIKDFJAKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid KPFPEPIIFIO;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GPNNHMPLLOJ;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid EHMHLFKKHAB;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid KKCHDAKLNOK;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid NBGLILPHIGF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HICNNKNKHIJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JBHDCBMMHGC;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid KHLGINPAAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid GAKNGNOBODA;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid EECNINPHCCD;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid KJFBCEJGDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid IHHGPLOGNLG;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PBLFMGBMLAC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid DNIAIEAJACN;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OFDHEAPACBO;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BIHIOAJMCPN;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid APPNLOINAFK;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FCIFGIGHNKN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid HNMHKJMOPNC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid HDGHNFECEMM;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AOMBGINAGAP;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid MHCFMBEELOI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JADPAOOKLLM;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid CLPJLCFDIFE;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MJENFLJJNGE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GJPMHMABOBB;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid KEFDGCKCBLK;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LHNKEEEEJBA;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid GPGHEGEOILJ;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid BIAOOFEHDHM;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid CDGKDCNOEEH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HBKDFLDINGN;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FMNEPKKNEFI;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid NMCBGEKIEDG;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid IMIHPIPNLLP;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid COLKMEACGIJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid KIGPBFENNAG;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid DBFDBALCEBA;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid IKENGMNMMFL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IPAOAELHPOL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid LIGAJELFDHH;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KFNPKDPHGFI;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid HEJEIHMBEKG;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid JCBKFAHPJLG;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FLDIAHMFBAN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AAHCNGCGBNG;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid GECHAENIHIL;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BMOHFEOPECA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid JNGHBFFKFNP;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid EMINHFOCPNM;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid ENJHDPKKDBE;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LLMMGLHCHDM;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NCCBPKKNCBK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid OMFEDCJPFGO;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PEIOGJAKLDH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BBLKMAFGKHA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AJPIEKOJOFN;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HNACJALAPCH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid LNOHOBNDCGN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KBIKENBOPBD;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid KMHKGBIDEKE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DACOPODMKHE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HAKFCLFPPCC;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NDBIELEJBJP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid NOBJJABHKEG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KJBOKINJEFE;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid DFOFACODAPF;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid GFKMDBIANDE;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid GAFFDBALGOL;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid BDDDKBBCPLF;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid EJPBAAFGELD;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid FKBNBMIFPNP;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid FKJDIFPOAOK;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid FFODCJKMGID;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid LBEJKKJMJEE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LOAEOACEGKJ;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid GPPAIGMMBNA;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid LCKHFKAOCGG;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid ADPAKHPNHJD;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid AIOMBDCHKAI;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid NIAHAOEFADF;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OKANJBCCCCP;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LLAMEDAIOPK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid OHLEGMHJBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OHMCCDOBOIJ;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid NICONPGMMLN;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GNJBJDJOMPH;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid NIIDCDCMKMI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid LPDGDLCILAF;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid OCBJKBEJNOC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid NECCCEMBEAA;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid EOIEEKGOGHA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid AHKCPEKCDCM;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CBOLBLFJDIF;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid GLEDOFIIOKI;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid BBOLAIJAPPF;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid NICAOFKHOCD;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid CPPIFAELEEM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MNKBNBLLPPN;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid OEBKBFDEAOI;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GIJNHPFLHDJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid NAIHFBEGBAG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid BHJJOMGPLAA;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid ICENOMBCDGP;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GPIKOMFJGOK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid BDFMNACBKAK;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid HMHDMOKICND;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid ECKIMCFBEBP;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid BCNBIFBHFII;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JHFECEAPAAP;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid OCKJPDLOAFD;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid OJENAOFMLJL;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid KCALGNEHOKL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid DJOKFCIKLBC;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid IENMHKGOLIJ;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid FFJEJKDIBDA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid GMAOLECCGIB;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid LALLNCMAOBP;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid NMABCEGCCIK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid BGAHJFNAPFH;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IMKCPKAAOPL;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid CDFJCOOOCCA;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MPNICPCLOJA;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid MNINPKPFHOL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid ADNGODJHFPA;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid BLDJOPFPDPL;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid LFANKMPOOPP;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DIBCALGHNCG;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid FLPBGEIAEBG;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid BIJHOIGINDO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid NKLDNOHGOGP;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid MCNHIOAGDBO;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid BMLJJOMMANB;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid NEMNJCNAHDK;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid GKEJJFKIELF;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid EMJOENBHAFM;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HGEFKOFAJGI;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid EKJHGNMOCPI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MNJMAEOAJIB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid LGNJAHPKNBM;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid ICAGNNKFDLA;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid FMODALHBOHF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid LMEGBIJMMCN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid DIOOGEFODHN;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid AHIKKMGGMDC;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LGGMPGLEFLM;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid PLEIDAEMHEJ;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid KDOHHKLDIGP;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid OPBEDCPPOCK;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid CBNOOIHMBKK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid NPDINAAGIIP;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid KHANKPGNBPG;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid DJAEAHCIMBO;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid FKAEGLCEOAC;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid BHNPHBDLMLP;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid NDIFMNBNMJO;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid LOLDEJAINEE;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid IBKFOFIDCFA;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid CKDEAIKELIC;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid MDOKPHJDBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid JEGCLMALHII;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid DKBHFCNGJKB;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid PBCHFBMLAKC;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid FEMEJDIMJGN;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid MGOIGKBEEJI;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid DELNNDOCCKP;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid ACAEPPCPBJH;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid FGLEIBIEBOH;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid NJFBNNHHKJB;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid DDOHBJMGHNO;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid JEHPGMAEGPH;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid OBIEFAIGMOI;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid NFFFDAGDOKA;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid EGEKJKDIMEJ;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid FPJLDDOFFHP;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid PFMDDNJONPF;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid JEOIAMLAJOC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid GBDPKOGLOKN;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid IGAKNDLGIIL;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid NGLCOMJGBIC;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid OPPGIOMJADB;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid PFLHOMHKIPO;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid PIIBPFFECMG;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid HKBKMLADPGA;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid NKFANMPFEOF;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid HKPCDAJLKGC;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid EBKHPNCMAIK;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid NPFFFJKMPCB;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid KAOOBAMCECB;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid FFGODGGCANJ;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid HNEHDNPEGOF;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid CFNNOFHFCMH;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid EACCLBDAJGE;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public static readonly Guid LJEMFENOJEJ;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public static readonly Guid EFOKLJEMLEB;

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public static readonly Guid JKCKHNAHKHC;

	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public static readonly Guid LCDPEOHMPNO;

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly Dictionary<Guid, FKBLBGCNFAH> DIFLNBINKKO;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly Dictionary<FKBLBGCNFAH, Guid> KBPDIKFCKLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FKBLBGCNFAH> GMCJABFJNOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8447760", Offset = "0x8446160", VA = "0x188447760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FKBLBGCNFAH, Guid> LMEPAMFIANH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84477C0", Offset = "0x84461C0", VA = "0x1884477C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EEBHECHAMAD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8447730", Offset = "0x8446130", VA = "0x188447730")]
	public static bool LDPMMBKBIBJ(IMHFMPKKMMM CJPMIIMPGEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8447310", Offset = "0x8445D10", VA = "0x188447310")]
	private static bool LDPMMBKBIBJ(GCMIEOKPPGI ADCKJPAFCJG, IMHFMPKKMMM CJPMIIMPGEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IGOHKDHPAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(FEPGMCGLAEM BLPDDGCLNPE, [Out] Dictionary<int, int> IIFIFOCKFHE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FPGEPAJMDDO HGDEOGIJDKK, FOFJPNEMKPL ELNNIIMIPPH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BFMENIIJCEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly HGAPEJNOIKC MMMLNPEBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly IEnumerable<LNEHPBAPDKG> JFHKGEFKHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly IReadOnlyList<LNEHPBAPDKG> JJFLOICPMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly HOHDPLDONAJ<NJOGNKEOOCE> AFOCGHMLBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly IReadOnlyList<JPBAHMPLNNG<IOBEEHHAIPN>> LFOABOGMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly LANJBKKFHMI BBNBCAENIKO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EHMJJBBOIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8446880", Offset = "0x8445280", VA = "0x188446880")]
	public BFMENIIJCEG(HGAPEJNOIKC HCGCAILEBLD, IEnumerable<LNEHPBAPDKG> EIEEKKOLFMO, IReadOnlyList<LNEHPBAPDKG> NLJIJKIIKAD, HOHDPLDONAJ<NJOGNKEOOCE> OPOIGPPMOMB, IReadOnlyList<JPBAHMPLNNG<IOBEEHHAIPN>> ALLMOCPGMCH, LANJBKKFHMI DOCEMJJKGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LNHABKDPMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly HGAPEJNOIKC MMMLNPEBKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly IReadOnlyList<LNEHPBAPDKG> FCDMHJJAJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly HOHDPLDONAJ<NJOGNKEOOCE> AFOCGHMLBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public readonly IReadOnlyList<JPBAHMPLNNG<IOBEEHHAIPN>> LFOABOGMNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public readonly ByteString EDIIJCHDGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public readonly LANJBKKFHMI BBNBCAENIKO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8455F20", Offset = "0x8454920", VA = "0x188455F20")]
	public LNHABKDPMGM(HGAPEJNOIKC HCGCAILEBLD, HOHDPLDONAJ<NJOGNKEOOCE> OPOIGPPMOMB, IReadOnlyList<JPBAHMPLNNG<IOBEEHHAIPN>> ALLMOCPGMCH, ByteString IJKBJGKDPAF, IReadOnlyList<LNEHPBAPDKG> IKNIOMKANKP, LANJBKKFHMI DOCEMJJKGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DKNMEMDIMDP : ENHNPAODHKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public readonly Guid FHPCPLJBCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private readonly Dictionary<Guid, Guid> HJAOHCJPEIK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50718D0", Offset = "0x50702D0", VA = "0x1850718D0")]
	private DKNMEMDIMDP(Guid AHJGMKAGKDJ, Dictionary<Guid, Guid> HJAOHCJPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84471E0", Offset = "0x8445BE0", VA = "0x1884471E0")]
	public static DKNMEMDIMDP KDBDJPAJKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8446D50", Offset = "0x8445750", VA = "0x188446D50")]
	private static Dictionary<Guid, Guid> DCGKDGIHOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8446970", Offset = "0x8445370", VA = "0x188446970")]
	public static DKNMEMDIMDP BELCKBLEKJF(IReadOnlyDictionary<Guid, Guid> KGCMICBGABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8446EF0", Offset = "0x84458F0", VA = "0x188446EF0")]
	public static DKNMEMDIMDP JCPCFNELFIM(IEnumerable<KeyValuePair<Guid, Guid>> KGCMICBGABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84468F0", Offset = "0x84452F0", VA = "0x1884468F0")]
	public Dictionary<Guid, Guid> AGAOIDGGKPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
	public Dictionary<Guid, Guid> BNGFABMJLGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8446E70", Offset = "0x8445870", VA = "0x188446E70")]
	public void HMDNMGBNKIA(Guid KGCMICBGABJ, Guid MPGFNEFLINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8446980", Offset = "0x8445380", VA = "0x188446980")]
	public void BHJOOPGNBME(IReadOnlyDictionary<Guid, Guid> FOHGODPILHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8446C00", Offset = "0x8445600", VA = "0x188446C00")]
	public Guid CLGJABBJIBF([In] Guid KGCMICBGABJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8447270", Offset = "0x8445C70", VA = "0x188447270")]
	public Guid KNCFKMCINHN([In] Guid KGCMICBGABJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8446E00", Offset = "0x8445800", VA = "0x188446E00")]
	public bool GBJMDGGEICG([In] Guid KGCMICBGABJ, [Out] Guid MPGFNEFLINC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8446E00", Offset = "0x8445800", VA = "0x188446E00", Slot = "4")]
	private bool GBKBFDGFHBA([In] Guid KGCMICBGABJ, [Out] Guid MPGFNEFLINC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PECFALNFNHB
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPKEENEMIJL(Guid OCONCDFGCOB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKBHCLEBHFF(Guid OCONCDFGCOB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CPHHCANMMJF
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
public abstract class KPIBMEDAALG : PECFALNFNHB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class AHNPIENIPPB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public AHNPIENIPPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84466D0", Offset = "0x84450D0", VA = "0x1884466D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8446830", Offset = "0x8445230", VA = "0x188446830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8446790", Offset = "0x8445190", VA = "0x188446790", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8446790", Offset = "0x8445190", VA = "0x188446790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private Dictionary<string, HashSet<Guid>>? GIFPLAOFGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	protected Dictionary<string, string>? LJPHCMJNBLP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> ECPHNKECGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84559F0", Offset = "0x84543F0", VA = "0x1884559F0")]
		[IteratorStateMachine(typeof(AHNPIENIPPB))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? CJJDOFKNOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool HLOOGFDEPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool JAHGAHMCNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract List<Guid> GNNBABHMCFK(string HPIEKKEBBPG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract bool NMNLLPAFMMN(string HPIEKKEBBPG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8455570", Offset = "0x8453F70", VA = "0x188455570")]
	public void EPMFOOCFKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1041A60", Offset = "0x1040460", VA = "0x181041A60")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8455B20", Offset = "0x8454520", VA = "0x188455B20", Slot = "4")]
	public bool IPKEENEMIJL(Guid OCONCDFGCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8455A50", Offset = "0x8454450", VA = "0x188455A50", Slot = "5")]
	public bool HKBHCLEBHFF(Guid OCONCDFGCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8455DD0", Offset = "0x84547D0", VA = "0x188455DD0")]
	private bool NOILNIEJFKP(string KLJBIBANJDP, Guid OCONCDFGCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8455450", Offset = "0x8453E50", VA = "0x188455450")]
	protected List<Guid> AFFCCPDIJNP(string AHJKDMCNJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected KPIBMEDAALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HKPCCDMCIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KIELGKFALOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public HGAPEJNOIKC staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KIELGKFALOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8464AC0", Offset = "0x84634C0", VA = "0x188464AC0")]
		internal HOHDPLDONAJ<NKKJJAOFDIH> JNJFNPFPHLN((HOHDPLDONAJ<NJOGNKEOOCE> GraphId, HOHDPLDONAJ<IOBEEHHAIPN> NodeId) i)
		{
			return default(HOHDPLDONAJ<NKKJJAOFDIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private const int LPAPHIFJKNJ = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private readonly Dictionary<HOHDPLDONAJ<NKKJJAOFDIH>, GLPPBBOCCPB> BFDGFBELGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private long AFGNKADKJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private long CDINCGNHPCB;

	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly KGNGOLAIAHD<NKKJJAOFDIH, int?> DCABLJKPNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly long KGIMBMACPDG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long OKJKJBDMIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8447A70", Offset = "0x8446470", VA = "0x188447A70")]
	public static HKPCCDMCIPK KHOKOFDKKOC(HGAPEJNOIKC PJDCMHFEPHP, JPBAHMPLNNG<NJOGNKEOOCE> DMLHLBNFKCO, [Optional] HKPCCDMCIPK PJEJFKKJHBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8447FD0", Offset = "0x84469D0", VA = "0x188447FD0")]
	public static (long, long) NBIMNEFDJDD(HGAPEJNOIKC PJDCMHFEPHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8447820", Offset = "0x8446220", VA = "0x188447820")]
	public static long CGLHCPMBHPE([In] ReadOnlySpan<HOHDPLDONAJ<NKKJJAOFDIH>> GOJGLIOBOHK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8447950", Offset = "0x8446350", VA = "0x188447950")]
	private static long DCMDPOMDFAH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x84553C0", Offset = "0x8453DC0", VA = "0x1884553C0")]
	public HKPCCDMCIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GLPPBBOCCPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEBBA50", Offset = "0xEBA450", VA = "0x180EBBA50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long NENPHPJPDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FB5BB0", Offset = "0x7FB45B0", VA = "0x187FB5BB0")]
	public GLPPBBOCCPB(long MHMCOJIKNCI, long PFCGNNJMDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EGEIKJMHCHJ
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public static readonly HashSet<FKBLBGCNFAH> GBNOBMAMPBP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FFJIGMGCKGF
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EGBKNPGJKKK : IEnumerable<LNEHPBAPDKG>, IEnumerable, IEnumerator<LNEHPBAPDKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private LNEHPBAPDKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private EAFBDFDMHAJ spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public EAFBDFDMHAJ <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private COKBHAEPIMN spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public COKBHAEPIMN <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private LNEHPBAPDKG System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public EGBKNPGJKKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x845E6B0", Offset = "0x845D0B0", VA = "0x18845E6B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x845E930", Offset = "0x845D330", VA = "0x18845E930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x845E7C0", Offset = "0x845D1C0", VA = "0x18845E7C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LNEHPBAPDKG> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x845E7C0", Offset = "0x845D1C0", VA = "0x18845E7C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8461790", Offset = "0x8460190", VA = "0x188461790")]
	public static EAFBDFDMHAJ ENEECAIJCCP([In] LNHABKDPMGM JNLGIKHEJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8461910", Offset = "0x8460310", VA = "0x188461910")]
	public static EAFBDFDMHAJ ENEECAIJCCP([In] BFMENIIJCEG JNLGIKHEJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8461CB0", Offset = "0x84606B0", VA = "0x188461CB0")]
	private static HashSet<JPBAHMPLNNG<ADIAPADJBFH>> LJKPDLFEEAA(IReadOnlyList<LNEHPBAPDKG> MHCLJLIBLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8462050", Offset = "0x8460A50", VA = "0x188462050")]
	private static void NIKMJNMDELJ(EAFBDFDMHAJ KMKMMKEBFFM, [In] BFMENIIJCEG OKEBDDOGIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x845F560", Offset = "0x845DF60", VA = "0x18845F560")]
	public static FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK> BBIHCKONKID(EAFBDFDMHAJ KMKMMKEBFFM, COKBHAEPIMN EGKGGPPIHPF, DKNMEMDIMDP? LCGEEPNCDGB, bool IHLLGJEMFID)
	{
		return default(FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8461B30", Offset = "0x8460530", VA = "0x188461B30")]
	[IteratorStateMachine(typeof(EGBKNPGJKKK))]
	private static IEnumerable<LNEHPBAPDKG> KDIMIGFFJPI(EAFBDFDMHAJ KMKMMKEBFFM, COKBHAEPIMN EGKGGPPIHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8461C40", Offset = "0x8460640", VA = "0x188461C40")]
	private static void KJBCAKNMINM(EAFBDFDMHAJ KMKMMKEBFFM, COKBHAEPIMN EGKGGPPIHPF, IReadOnlyCollection<ByteString>? BHMEMFFGJGF, IReadOnlyCollection<ByteString>? MHDPIOEACBJ, IReadOnlyCollection<ByteString>? CEIAHCOJJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84610F0", Offset = "0x845FAF0", VA = "0x1884610F0")]
	private static bool EHEPKMNAHIO(EAFBDFDMHAJ KMKMMKEBFFM, FPGEPAJMDDO HGDEOGIJDKK, COKBHAEPIMN EGKGGPPIHPF, [Out][NotNullWhen(false)] string? IHPAEKNOMOJ, [Out] Dictionary<int, int> IIFIFOCKFHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8460E10", Offset = "0x845F810", VA = "0x188460E10")]
	private static Dictionary<Guid, GCMIEOKPPGI> CMHDJDHMAGE(EAFBDFDMHAJ KMKMMKEBFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8461AA0", Offset = "0x84604A0", VA = "0x188461AA0")]
	private static void FBEAHOKJOHK(bool MPJAIMMMCIJ, LNEHPBAPDKG CKBAKJANFMC, DKNMEMDIMDP PIPGAOCAIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8460B80", Offset = "0x845F580", VA = "0x188460B80")]
	private static void BLDKKDJDMMH(LNEHPBAPDKG CKBAKJANFMC, Guid FJFCHHLHHFI, EGEJIKFLDGB? EGPBFACIIDF, Dictionary<Guid, GCMIEOKPPGI> FKBBMIGJFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84626B0", Offset = "0x84610B0", VA = "0x1884626B0")]
	private static void OPFONBKAMAP(IEnumerable<LNEHPBAPDKG> LODKMNBFFBC, IReadOnlyCollection<ByteString> BHMEMFFGJGF, IReadOnlyCollection<ByteString> MHDPIOEACBJ, IReadOnlyCollection<ByteString> CEIAHCOJJFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct COKBHAEPIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool MPJAIMMMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public LANJBKKFHMI DOCEMJJKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public EGEJIKFLDGB? EGPBFACIIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public EGEJIKFLDGB? DOACDLAHOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public HGAPEJNOIKC OOOLPGNPLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public CPHHCANMMJF GNEAPEGPCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public IGOHKDHPAAM JEJMMNFNPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public JPBAHMPLNNG<NJOGNKEOOCE> FMKJODEIPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public DKMDMMLONLB PJJJKGEHHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public List<LNEHPBAPDKG> GOFAJGGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public HCBPGOEJGIG NKKNHPEMCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public BHCDPENCFMP EFCENPINIIN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EGEJIKFLDGB
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private const float HNDFKAOFGGN = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Vector3 KFJFDPLEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Quaternion AMHDLJKDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public float NIAMAMNMMFM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 HOHCHNFJBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x845F2F0", Offset = "0x845DCF0", VA = "0x18845F2F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS AMACGBHLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x845F2B0", Offset = "0x845DCB0", VA = "0x18845F2B0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x16B05C0", Offset = "0x16AEFC0", VA = "0x1816B05C0")]
	public EGEJIKFLDGB(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float NIAMAMNMMFM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x845F490", Offset = "0x845DE90", VA = "0x18845F490")]
	public EGEJIKFLDGB(UniformTRS NBBMMEGGCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x845EDA0", Offset = "0x845D7A0", VA = "0x18845EDA0")]
	public static EGEJIKFLDGB JLGEAFLNBBM(EGEJIKFLDGB AEMEEJKFKNN, EGEJIKFLDGB PDMMOKEEPFG)
	{
		return default(EGEJIKFLDGB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x845ED80", Offset = "0x845D780", VA = "0x18845ED80")]
	public static EGEJIKFLDGB HDPJNBPLGPE((Vector3, Quaternion, float) BLPDDGCLNPE)
	{
		return default(EGEJIKFLDGB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x845EC20", Offset = "0x845D620", VA = "0x18845EC20")]
	public static EGEJIKFLDGB HDPJNBPLGPE(Matrix4x4 JKPJFGMOCNJ)
	{
		return default(EGEJIKFLDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x845F400", Offset = "0x845DE00", VA = "0x18845F400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x845F090", Offset = "0x845DA90", VA = "0x18845F090")]
	public EGEJIKFLDGB KHJMHLDBDEK(Matrix4x4 HALOMIKDIAH)
	{
		return default(EGEJIKFLDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x845F020", Offset = "0x845DA20", VA = "0x18845F020")]
	public static EGEJIKFLDGB KCPEEJDDBFE(Vector3 KFJFDPLEJOD)
	{
		return default(EGEJIKFLDGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x845EB90", Offset = "0x845D590", VA = "0x18845EB90")]
	public readonly EEBMPNDMDKB DMHMEEJBBFA()
	{
		return default(EEBMPNDMDKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JJGCMBIDEKA
{
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct IAAKHHHMMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public readonly AKKPBDEKCBE DHHFFBBJINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly NKNFPHMKKGH GOFCCMOJEJD;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x199CE10", Offset = "0x199B810", VA = "0x18199CE10")]
	private IAAKHHHMMEK(AKKPBDEKCBE EDFBAIGMJKK, NKNFPHMKKGH JDLDLDMKBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8463530", Offset = "0x8461F30", VA = "0x188463530")]
	public KJKEMMENJDN LMPIOOOICAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8463480", Offset = "0x8461E80", VA = "0x188463480")]
	public static FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK> KDBDJPAJKDJ(LOKOBNLIHCL<LJBIGLJNMFO> JDLDLDMKBAN)
	{
		return default(FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84633D0", Offset = "0x8461DD0", VA = "0x1884633D0")]
	public static FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK> KDBDJPAJKDJ(KJKEMMENJDN JDLDLDMKBAN)
	{
		return default(FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8463310", Offset = "0x8461D10", VA = "0x188463310")]
	public static FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK> KDBDJPAJKDJ(string CNAGDMMLLHB)
	{
		return default(FEENKEDBOAD<DKNMEMDIMDP, IAAKHHHMMEK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum AKKPBDEKCBE
{
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CMMNONHBAPP : IDisposable, MDKBNFJPNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private NativeList<CMNLAHEDKFC> EKCIGFBAOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	private float EAPFJJDMJHF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DHMONCPGFAD KHMKEDNINPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(DHMONCPGFAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KNCKDCDBBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72EBD10", Offset = "0x72EA710", VA = "0x1872EBD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BJALDGACCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72EBD20", Offset = "0x72EA720", VA = "0x1872EBD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<GCKPAPGBCCB> DIPBGPEMDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MHJOBAICFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x845AB40", Offset = "0x8459540", VA = "0x18845AB40", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CPIGKBCKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x845BF30", Offset = "0x845A930", VA = "0x18845BF30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x845CF70", Offset = "0x845B970", VA = "0x18845CF70")]
	public CMMNONHBAPP(DHMONCPGFAD JHBIAAAGFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x845AAE0", Offset = "0x84594E0", VA = "0x18845AAE0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x845C1C0", Offset = "0x845ABC0", VA = "0x18845C1C0")]
	public Vector3 NICLNDKIPOD(int HBDKIKFKCEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x845ACE0", Offset = "0x84596E0", VA = "0x18845ACE0", Slot = "6")]
	public Quaternion FLILAKHJAFA(int HBDKIKFKCEE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x845AA40", Offset = "0x8459440", VA = "0x18845AA40", Slot = "5")]
	public Vector3 CGIDJHGFGPD(int HBDKIKFKCEE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x845AE10", Offset = "0x8459810", VA = "0x18845AE10", Slot = "7")]
	public float GOGGIFFOCCO(int HBDKIKFKCEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x845AFC0", Offset = "0x84599C0", VA = "0x18845AFC0")]
	public void JFLBJHABIKD(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG, bool BDOEPACEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x845A970", Offset = "0x8459370", VA = "0x18845A970")]
	private bool BKDGFBIAIPL(int PKNAKCKKEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x845B930", Offset = "0x845A330", VA = "0x18845B930")]
	public void KEMKAHFPLOP(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x845B8A0", Offset = "0x845A2A0", VA = "0x18845B8A0")]
	public void JLOADFGFCLP(int PKNAKCKKEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x845C070", Offset = "0x845AA70", VA = "0x18845C070")]
	public void NGPBNOFEKPG(int PKNAKCKKEMA, Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x845A7C0", Offset = "0x84591C0", VA = "0x18845A7C0")]
	public void ADLOHHIBPMB(int PKNAKCKKEMA, float3 KFJFDPLEJOD, quaternion AMHDLJKDJBK, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x845AE70", Offset = "0x8459870", VA = "0x18845AE70")]
	public void JEAMHOOPCJC(int PKNAKCKKEMA, Vector3 KFJFDPLEJOD, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x845AB80", Offset = "0x8459580", VA = "0x18845AB80")]
	public void FANFFBECAMK(int PKNAKCKKEMA, Vector3 BJGHDDIMDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x845C690", Offset = "0x845B090", VA = "0x18845C690")]
	public static Quaternion OLKDBCJOEAC(Quaternion FLGMEAGNLEE, int PKNAKCKKEMA, float ABNLCCBGHFG, MDKBNFJPNEA HKAIOBBCBGO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x845BA90", Offset = "0x845A490", VA = "0x18845BA90")]
	public Bounds LJCCMKBGJAM(Transform HALOMIKDIAH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x845A9D0", Offset = "0x84593D0", VA = "0x18845A9D0", Slot = "10")]
	public virtual void BLHLLIHLBKG(bool IPMHKFDNABE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x845CEA0", Offset = "0x845B8A0", VA = "0x18845CEA0")]
	public NativeList<CMNLAHEDKFC> PLKBFKDKHHA(float GFJJLLEGDBK = 1f)
	{
		return default(NativeList<CMNLAHEDKFC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GCKPAPGBCCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public float3 NGNFCFGNCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public float HNJLIBKLAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public quaternion AMLFHGGHIFE;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84630B0", Offset = "0x8461AB0", VA = "0x1884630B0")]
	public GCKPAPGBCCB(Vector3 FNPMGHGMCGE, Quaternion FLGMEAGNLEE, float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8462E50", Offset = "0x8461850", VA = "0x188462E50")]
	public Quaternion DOAKLHHIIPJ(Vector3 HLNPPHJBENM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8462B60", Offset = "0x8461560", VA = "0x188462B60")]
	public GCKPAPGBCCB AGPOMMPIGII(Vector3 DFHCOOHEOLA, Vector3 KMGDDDHJAFG, Vector3 HKLNBPAFKGN)
	{
		return default(GCKPAPGBCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8462F10", Offset = "0x8461910", VA = "0x188462F10")]
	public KLJIEDNMGBC JILDKPADKHA(Vector3 HLNPPHJBENM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class INEMKGJMDHE : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8463F60", Offset = "0x8462960", VA = "0x188463F60", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8463980", Offset = "0x8462380", VA = "0x188463980")]
	private void AHBFPDFOJJO(Dictionary<Guid, Guid> MIDADGEMMEI, GIOBIMJPJIE CJAEPPFKKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x84636A0", Offset = "0x84620A0", VA = "0x1884636A0")]
	private void AHBFPDFOJJO(Dictionary<Guid, Guid> MIDADGEMMEI, COHGJADJDHN CPKHIGMEDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8463700", Offset = "0x8462100", VA = "0x188463700")]
	private void AHBFPDFOJJO(Dictionary<Guid, Guid> MIDADGEMMEI, DFNLBHLLJII JMKMGNCEHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public INEMKGJMDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LBGABELNHMH : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8464CF0", Offset = "0x84636F0", VA = "0x188464CF0", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LBGABELNHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KNBFIBDKDCG : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8464B90", Offset = "0x8463590", VA = "0x188464B90", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KNBFIBDKDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PKOEEBFNMND : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x846A160", Offset = "0x8468B60", VA = "0x18846A160", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PKOEEBFNMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NHDKGFCOJLH : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8464FF0", Offset = "0x84639F0", VA = "0x188464FF0", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NHDKGFCOJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AGGOEAGHMGD : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x845A390", Offset = "0x8458D90", VA = "0x18845A390", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AGGOEAGHMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MHJOOKCCBBP : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8464E50", Offset = "0x8463850", VA = "0x188464E50", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MHJOOKCCBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BLOAMNEOLJJ : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x845A4D0", Offset = "0x8458ED0", VA = "0x18845A4D0", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BLOAMNEOLJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class AEBLFBFJJNI : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x845A1D0", Offset = "0x8458BD0", VA = "0x18845A1D0", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public AEBLFBFJJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class JIKOBKLJGHI : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8464900", Offset = "0x8463300", VA = "0x188464900", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JIKOBKLJGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IJKIDFACIPA : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84635A0", Offset = "0x8461FA0", VA = "0x1884635A0", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IJKIDFACIPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class DBGKLACINLE : HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public static readonly INKJCOKJFII JGHKHMOEBHC;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x845D000", Offset = "0x845BA00", VA = "0x18845D000", Slot = "4")]
	public void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DBGKLACINLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct IMHFMPKKMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public FPGEPAJMDDO PKNNCMNKNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public GBFAPFIPMIB FIJEHJPEGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public Dictionary<int, int> CANJNOFKKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public Dictionary<Guid, Guid> DGDDEIAGOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public BHCDPENCFMP EFCENPINIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public bool IHLLGJEMFID;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HABDBJJNJML
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEJNDIKEMGL(LDKHFPKADKH HHNMLKDBAGL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PPDABCFMJOI
{
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private static readonly HABDBJJNJML[] ABPKPLPMKAN;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x846A550", Offset = "0x8468F50", VA = "0x18846A550")]
	public static void BHGEEHCEKNH(LNEHPBAPDKG BLPDDGCLNPE, DKNMEMDIMDP JIKIMENJFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x846A2C0", Offset = "0x8468CC0", VA = "0x18846A2C0")]
	public static void BDNCMKJPDKG(LNEHPBAPDKG? BLPDDGCLNPE, DKNMEMDIMDP ACNMIMNNCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x846A7D0", Offset = "0x84691D0", VA = "0x18846A7D0")]
	public static void CEHGLFPNJFJ(LNEHPBAPDKG? BLPDDGCLNPE, DKNMEMDIMDP PIPGAOCAIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x846AA40", Offset = "0x8469440", VA = "0x18846AA40")]
	public static void LDPMMBKBIBJ(LDKHFPKADKH HHNMLKDBAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LDKHFPKADKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public FPGEPAJMDDO JHLPHOMMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public LNEHPBAPDKG CKBAKJANFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public Dictionary<int, int> CANJNOFKKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public Dictionary<Guid, Guid> DGDDEIAGOHN;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8464DA0", Offset = "0x84637A0", VA = "0x188464DA0")]
	public Guid NMPCMPDLEFL(Guid OCONCDFGCOB)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BHCDPENCFMP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KHJLFNFMIIH, [Out] Guid CJIBMIGJIFO);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class PFPIICJOBLP
{
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private static readonly HashSet<Guid> GMKGGJCHAKA;

	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private static readonly HashSet<Guid> CHCKIJKPFLA;

	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private static readonly HashSet<Guid> LEKHDPHMKOH;

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly ProfilerMarker EJIMCPMAAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private readonly HashSet<string> MPBPDJPGACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private readonly Dictionary<long, int> CFKFDDCJAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly HashSet<Guid> PLCGKEAJBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly HashSet<Guid> KJCFFBLHAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly HashSet<Guid> JKMNMPPBLLJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> NPHCIECCAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyCollection<Guid> EKHCFDBMCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<Guid> KMJCCFNPLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IReadOnlyDictionary<long, int> JIFIMEOJKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8467A70", Offset = "0x8466470", VA = "0x188467A70")]
	public static void KODIHNNFBKN(EAFBDFDMHAJ DPKICHDJBCK, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8465560", Offset = "0x8463F60", VA = "0x188465560")]
	public static PFPIICJOBLP EDMJBKCLEAC(EHIMHNJBHOL KALMEDGIGPJ, PIKPDCGCPGG? BOKCAFKCABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8465420", Offset = "0x8463E20", VA = "0x188465420")]
	public static PFPIICJOBLP DCHDGLPJHFL(EAFBDFDMHAJ FGBPDEJHGNA, PIKPDCGCPGG? BOKCAFKCABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84654A0", Offset = "0x8463EA0", VA = "0x1884654A0")]
	public static PFPIICJOBLP ECDJPEMKHMM(BCCNGGOEKHP ELNNIIMIPPH, MNJFCAMKFFA BKFKEKMLADJ, PIKPDCGCPGG? BOKCAFKCABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x84655E0", Offset = "0x8463FE0", VA = "0x1884655E0")]
	public static PFPIICJOBLP FDCIHMHBFCM(IEnumerable<string> MPBPDJPGACO, IReadOnlyDictionary<long, int> DGLKAIBDJLB, IReadOnlyCollection<Guid> JKMNMPPBLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8469A30", Offset = "0x8468430", VA = "0x188469A30")]
	private PFPIICJOBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8469BC0", Offset = "0x84685C0", VA = "0x188469BC0")]
	private PFPIICJOBLP(IEnumerable<string> MPBPDJPGACO, IReadOnlyDictionary<long, int> DGLKAIBDJLB, IReadOnlyCollection<Guid> JKMNMPPBLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8466210", Offset = "0x8464C10", VA = "0x188466210")]
	private void JJICOGOJMHG(EHIMHNJBHOL KALMEDGIGPJ, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84664B0", Offset = "0x8464EB0", VA = "0x1884664B0")]
	private void JJICOGOJMHG(EAFBDFDMHAJ FGBPDEJHGNA, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8468F00", Offset = "0x8467900", VA = "0x188468F00")]
	private void MGAENNCKMJB(ByteString? IJKBJGKDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84667C0", Offset = "0x84651C0", VA = "0x1884667C0")]
	private void JJICOGOJMHG(BCCNGGOEKHP? FAIGKPPBFHA, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8466740", Offset = "0x8465140", VA = "0x188466740")]
	private void JJICOGOJMHG(MNJFCAMKFFA? BKFKEKMLADJ, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8466030", Offset = "0x8464A30", VA = "0x188466030")]
	private void JJICOGOJMHG(IKHAOFKMPAK? JDJMLCHCEJO, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8467190", Offset = "0x8465B90", VA = "0x188467190")]
	private static bool JPCDNALHDJH(IKHAOFKMPAK JDJMLCHCEJO, int CHABPLIFHOA, [Out] string? MOBIKPGKNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8465670", Offset = "0x8464070", VA = "0x188465670")]
	private static bool HBLOFPBAFCG(IKHAOFKMPAK JDJMLCHCEJO, int CHABPLIFHOA, [Out] Guid EIIBKOHHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8468E30", Offset = "0x8467830", VA = "0x188468E30")]
	private static void KODIHNNFBKN(MNJFCAMKFFA? FAIGKPPBFHA, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8467390", Offset = "0x8465D90", VA = "0x188467390")]
	private static void KODIHNNFBKN(IKHAOFKMPAK? JDJMLCHCEJO, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8468460", Offset = "0x8466E60", VA = "0x188468460")]
	private static void KODIHNNFBKN(BCCNGGOEKHP? FAIGKPPBFHA, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84687E0", Offset = "0x84671E0", VA = "0x1884687E0")]
	private static void KODIHNNFBKN(FGFIIOICEGK? MNHKIMAOFNO, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84658B0", Offset = "0x84642B0", VA = "0x1884658B0")]
	private void JJICOGOJMHG(FGFIIOICEGK? MNHKIMAOFNO, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8465210", Offset = "0x8463C10", VA = "0x188465210")]
	private void CGFLBNEDPAI(Guid? OCONCDFGCOB, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8465C30", Offset = "0x8464630", VA = "0x188465C30")]
	private void JJICOGOJMHG(LNEHPBAPDKG? CKBAKJANFMC, PIKPDCGCPGG? BOKCAFKCABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8467620", Offset = "0x8466020", VA = "0x188467620")]
	private static void KODIHNNFBKN(LNEHPBAPDKG? CKBAKJANFMC, PIKPDCGCPGG BOKCAFKCABC, DKNMEMDIMDP CADEIGCCLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84694F0", Offset = "0x8467EF0", VA = "0x1884694F0")]
	private void NBCPDCDAHOL(string? AILKBPCAHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8469610", Offset = "0x8468010", VA = "0x188469610")]
	private void NJLPILHMIDN(long ELFJEIAPLLG, Guid OGFLDFLEODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x84695C0", Offset = "0x8467FC0", VA = "0x1884695C0")]
	private void NJLPILHMIDN(POLJMOPIHJH? JNFDGAEKDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8469560", Offset = "0x8467F60", VA = "0x188469560")]
	private void NJLPILHMIDN(BGCCHFICAHI? JNFDGAEKDMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct DPOHPDMEBDA
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class DOKFCIHKOLK : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private readonly IEnumerator<DictionaryEntry> BNAAJHEIBMD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public DictionaryEntry JONLLCKHHEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x845D2B0", Offset = "0x845BCB0", VA = "0x18845D2B0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object PHLFNBHNCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x845D370", Offset = "0x845BD70", VA = "0x18845D370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public object AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x845D420", Offset = "0x845BE20", VA = "0x18845D420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public object IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x845D1D0", Offset = "0x845BBD0", VA = "0x18845D1D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
		public DOKFCIHKOLK(IEnumerator<DictionaryEntry> BNAAJHEIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x845D130", Offset = "0x845BB30", VA = "0x18845D130", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x845D180", Offset = "0x845BB80", VA = "0x18845D180", Slot = "9")]
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
		private sealed class CEBOLDJCHKH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x845A710", Offset = "0x8459110", VA = "0x18845A710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public CEBOLDJCHKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x845A5C0", Offset = "0x8458FC0", VA = "0x18845A5C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x845A6C0", Offset = "0x84590C0", VA = "0x18845A6C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x846B9B0", Offset = "0x846A3B0", VA = "0x18846B9B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object HPFHOBCPNEF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x846B8C0", Offset = "0x846A2C0", VA = "0x18846B8C0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x846BAA0", Offset = "0x846A4A0", VA = "0x18846BAA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x846B800", Offset = "0x846A200", VA = "0x18846B800", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x846B860", Offset = "0x846A260", VA = "0x18846B860", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x846BA40", Offset = "0x846A440", VA = "0x18846BA40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x846B4C0", Offset = "0x8469EC0", VA = "0x18846B4C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x846B520", Offset = "0x8469F20", VA = "0x18846B520", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x846B580", Offset = "0x8469F80", VA = "0x18846B580", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
		public RoomObjectCounts(Dictionary<int, int> FFEOFLEBGIG, [Optional] Dictionary<int, int> LCCGPKPIFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x846B3E0", Offset = "0x8469DE0", VA = "0x18846B3E0")]
		[IteratorStateMachine(typeof(CEBOLDJCHKH))]
		private IEnumerator<DictionaryEntry> FDPMLKMBAHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x846BAF0", Offset = "0x846A4F0", VA = "0x18846BAF0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x846B700", Offset = "0x846A100", VA = "0x18846B700", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x846B5E0", Offset = "0x8469FE0", VA = "0x18846B5E0", Slot = "9")]
		void IDictionary.Add(object HPFHOBCPNEF, object KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x846B640", Offset = "0x846A040", VA = "0x18846B640", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x846B6A0", Offset = "0x846A0A0", VA = "0x18846B6A0", Slot = "8")]
		bool IDictionary.Contains(object HPFHOBCPNEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x846B7A0", Offset = "0x846A1A0", VA = "0x18846B7A0", Slot = "14")]
		void IDictionary.Remove(object HPFHOBCPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x846B460", Offset = "0x8469E60", VA = "0x18846B460", Slot = "15")]
		void ICollection.CopyTo(Array BHEONMJLANC, int KABGMIEBEFC)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class HHEPPLJKLDP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x84632C0", Offset = "0x8461CC0", VA = "0x1884632C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public HHEPPLJKLDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8463130", Offset = "0x8461B30", VA = "0x188463130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8463270", Offset = "0x8461C70", VA = "0x188463270", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8464620", Offset = "0x8463020", VA = "0x188464620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IDictionary.this[object HPFHOBCPNEF]
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x84644F0", Offset = "0x8462EF0", VA = "0x1884644F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x84646D0", Offset = "0x84630D0", VA = "0x1884646D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8464430", Offset = "0x8462E30", VA = "0x188464430", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8464490", Offset = "0x8462E90", VA = "0x188464490", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8464670", Offset = "0x8463070", VA = "0x188464670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x84640B0", Offset = "0x8462AB0", VA = "0x1884640B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8464110", Offset = "0x8462B10", VA = "0x188464110", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8464170", Offset = "0x8462B70", VA = "0x188464170", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B43B80", Offset = "0x2B42580", VA = "0x182B43B80")]
		public Invention(long NMAIBBDGPCD, int MHMCOJIKNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8463FE0", Offset = "0x84629E0", VA = "0x188463FE0")]
		[IteratorStateMachine(typeof(HHEPPLJKLDP))]
		private IEnumerator<DictionaryEntry> FDPMLKMBAHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8464720", Offset = "0x8463120", VA = "0x188464720", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84642F0", Offset = "0x8462CF0", VA = "0x1884642F0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84641D0", Offset = "0x8462BD0", VA = "0x1884641D0", Slot = "9")]
		void IDictionary.Add(object HPFHOBCPNEF, object KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8464230", Offset = "0x8462C30", VA = "0x188464230", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8464290", Offset = "0x8462C90", VA = "0x188464290", Slot = "8")]
		bool IDictionary.Contains(object HPFHOBCPNEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84643D0", Offset = "0x8462DD0", VA = "0x1884643D0", Slot = "14")]
		void IDictionary.Remove(object HPFHOBCPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8464050", Offset = "0x8462A50", VA = "0x188464050", Slot = "15")]
		void ICollection.CopyTo(Array BHEONMJLANC, int KABGMIEBEFC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> MAINPJGGCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	public readonly IReadOnlyList<Invention> NNAENEBIBFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	public DPOHPDMEBDA(IReadOnlyDictionary<Guid, RoomObjectCounts> KPFNBIKDEMF, IReadOnlyList<Invention> CAIIOFLFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x845DCA0", Offset = "0x845C6A0", VA = "0x18845DCA0")]
	public static DPOHPDMEBDA EDMJBKCLEAC(EHIMHNJBHOL KALMEDGIGPJ)
	{
		return default(DPOHPDMEBDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x845DB80", Offset = "0x845C580", VA = "0x18845DB80")]
	[CompilerGenerated]
	internal static int DNMAIEPHNIB([In] IReadOnlyDictionary<long, int> NJPLGACBPLC, long? ELFJEIAPLLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x845D4D0", Offset = "0x845BED0", VA = "0x18845D4D0")]
	[CompilerGenerated]
	internal static void BDPGCGDPNJO(int OGPMENPNBPG, [In] BCCNGGOEKHP HKJGLGIGIFG, [In] Dictionary<long, int> NJPLGACBPLC, [In] Dictionary<Guid, RoomObjectCounts> KPFNBIKDEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum HMIBPDDAODI
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
public sealed class PIKPDCGCPGG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class CMKGBLOLHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public readonly Guid CFMLHNHKJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public readonly IReadOnlyList<Guid> EKHCFDBMCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public readonly HMIBPDDAODI DHHFFBBJINF;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x845A760", Offset = "0x8459160", VA = "0x18845A760")]
		public CMKGBLOLHNK(Guid NDKPBPBIOMO, IReadOnlyList<Guid> JKMNMPPBLLJ, HMIBPDDAODI EDFBAIGMJKK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private readonly DKNMEMDIMDP PJKBCNMNHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private readonly Dictionary<Guid, CMKGBLOLHNK> BOCOHGGNDON;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public DKNMEMDIMDP ONBINLCKOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8469EB0", Offset = "0x84688B0", VA = "0x188469EB0")]
	public void HMDNMGBNKIA(Guid OLMHICKMBIE, Guid ALJBALNLKOI, IReadOnlyList<Guid> MIMLKCJOLFP, HMIBPDDAODI EDFBAIGMJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8469DC0", Offset = "0x84687C0", VA = "0x188469DC0")]
	public bool BHCCHOFAGJP(Guid MLEPBDNANIK, [Out] CMKGBLOLHNK CGEMCGOGFDL, [Out] bool PGCBAIFBPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x846A0C0", Offset = "0x8468AC0", VA = "0x18846A0C0")]
	public PIKPDCGCPGG()
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
