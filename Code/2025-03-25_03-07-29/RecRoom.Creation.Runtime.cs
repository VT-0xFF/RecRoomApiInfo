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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x7791310", Offset = "0x7790710", VA = "0x187791310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ECLGDDEKDMP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> EGMOLNBMNBB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MPPAMPKLPFH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> LHLOPJFKMKI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> FPLAJNILPOK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JPDDOEKBJMN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string BHBOHDMMNGD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string FJGKFICGANH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7781D90", Offset = "0x7781190", VA = "0x187781D90")]
	public static bool MPOGKGOJFGL(Guid INGPIBPPIHC, int HEMEFHPHBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7781680", Offset = "0x7780A80", VA = "0x187781680")]
	public static bool DONIEDCFMAO(Guid INGPIBPPIHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7781710", Offset = "0x7780B10", VA = "0x187781710")]
	public static string FKPHKGJANOK(Guid IIBHEJCKGGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBFHLODFGOP]
public enum LFKLBCPEPFF
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
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7791280", Offset = "0x7790680", VA = "0x187791280", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KBFBPDFGKIO
{
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LCCDFPPOAHL;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid PLCOEFJHIBH;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid ODPMCIJIMAF;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid LFIMIFOKGNC;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid PHAHLLMKNJO;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KOGOJHHCLHN;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid ECJLHJLANHK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DCBGOJDJGHB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid CIDBAJHHABJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid KDMKPKCDCNE;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid IGIECNJPKNO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HCKOFKAANGG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid MCCOKGCOLDP;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid PIJJEFCNIEO;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid GKDPNFPLBKH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid DHKGAJABBGP;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid GIEMMGNNHAC;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CGOGJKJGDEJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid CBBAFENHCPO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IHCDMKIEODP;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid BLGPJNGOCKA;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LLDNCMCBNDA;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HLKNDFCFHII;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid FJLNHLELEID;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid FJPJCOHBIPF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid HMOGBGGFENP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ICPJCABEEKC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HNEFKNMPNMI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid IHIKGAKDCDI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GCNBGPIKOBP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid DOMOKFIOAEK;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid FKPJLNALMOF;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid FDFBKBHGCGO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid DPCAEDOJBPJ;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CPMPCACMHFB;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid ENLAFMNHBHA;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GMJKGNFBAGM;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JENMPIPDLPI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GHOIBJILGLB;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid BFLACOMHMDK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid HCJHFMOFKGM;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NFHDNGLNEJO;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid EEDKKODDKPO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid FMMOPFCEONC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EAHJMMFBMFF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MBFKBEJPADO;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid ACKAAAGNDDH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid GBNFGMLAGJG;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid HMAPMABHDMB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GPIBOLCJJEK;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid KALIIGFGANF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HJLCCAHDAAD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid OKFKOJAHKDF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid OHJECAHJFGH;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DFGPDHDEAPF;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid CLJNDDFBJBI;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid EHEELFDMDOB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid FFABIFOEMJI;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid CEBPOCCHAFH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JENCILFDAJK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid ECLADBNLJIJ;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EGAEPKBODGD;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NEEMICDANCD;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid EFDBMFECDKE;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid LACFOKPKCJO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid NLOJAPOJFON;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid KEPJJFBECHG;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid HHDCLNMDFEL;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid MEBIIKIJHND;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KKDJCIKHOFJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FJLMHEDKMMF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid PEEHDPNCLIC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid LHJHKCGMIHB;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid OBCAIMDKLID;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FHMBKMDNGAM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid KDAHINGKHEK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MAGNECFMDHD;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid CDHKBKHOMOJ;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MGJLDBNIOAA;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BPNCFDFCMHO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid PHLMKINGNLF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid CAJFAGECMAL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid DMGFILABGEC;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KGPMAIKMLEL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid CFAPODEJLLA;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid KHPJDFMKHIH;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid DAKCDPELMEM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid GGHFBFKADBE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid ABBAMNFKAOH;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid HJCFKONMLMJ;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid BEBDACPPDKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FDGDAHEECDA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid CPDDFEBHMBN;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DNJGGNANFNG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid ICMKLJFIGDK;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid PDAKMOBBFOD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid LCIOAGEBLPG;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid NNEKLPLIMNH;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid MLJKFONHNBG;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid BFHIEFOEMMN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BFJIPKCKDEK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid EHPAPBOJMBP;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid BNELAGINLFJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IJIGELMOGJF;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid CECMONCPFJH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid NGNMNKHPPNI;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid FMHIOEDAAEH;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GFHJEOLFKJF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid DEOGDHPIOOH;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid AKMLNAPMMPM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BBCICCIFHFJ;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GCBNENKKIHJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid KMKFCKCAPHG;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid DECDACKAEBF;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid JJOPAIOIOJP;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IBIPAOCPNKH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid CJIMJJMJJKN;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid PIINKEHKAHP;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid LHCNBFCMLIF;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid NGPMDJCGLOA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid LBEKGGCPIDL;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid AJPECLGDNDH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid EANGAPLGAOL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid MJHLNGILIIM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid FJEPEBFJKBB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid LJCIHIHJLDA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GPCGEDFMHKM;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MIIAOIPOGMK;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid NOKMCCPCBPD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid BJFIENCFKAG;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid MNJCCMDABJN;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LCMBMHEFILE;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PEMANNFCFHI;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid JCAKPGCBJMN;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DNPLLBOIAAC;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid INNPIPMCMGP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PDLPLNJOKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid OKNKJCJDGIO;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KHBEGDMAOKC;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JJFCPNKNJAL;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GCHCKOOMGGC;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GPDOAFFJMHK;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NLFIJJNNHNI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KHFNIKPKNHN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid AFDJDIFNGJO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid AJLHCJNHEJO;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid BCDPNPDOFCC;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid GADCKPIJAJN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MIKNKECCDID;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid EMBLBEBDKLL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid CHFBCGDCNKI;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid KHANIKLHBDF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GKLMBJNPEIG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid KFCLIOEKCME;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GFMBAFNIKLE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid CNEHIINEAFH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid ENKECOOJIOO;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PNKAAEIOEEK;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OAGBIAPDBDE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid GMHMPKDAGAM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid LHELCDKODJE;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FNBOLGJLGGC;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KKHHPLHHNCA;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BEFENOOJHHK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BPPPCBAINJL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid NIKFOCCOJFB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid AFCCDOBHDBG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NKDCMPIHOLM;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid KPHKDOKMJGO;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid MKMJBKJEFIF;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MNAMECJDMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LIONDGJKEFN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid GOBDHBEIEGH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OICNDPMGAJD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid FCPHGJEBOJL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HDAFKDHJEIF;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid CEDADFGDHMB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid NCGDEPCHAEI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid ADBDAKMHFOD;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid GLJIJEFEOLF;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FPEHPJGGOHP;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid AJAJPHIIJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JLCINHKJAAH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid GOLGMCELKKN;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid NLGIADDACDH;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid CHBPDFPOIHC;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid NJNALNEMGNP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NNHJONLJAJF;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid ENNALKEBHGM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DMLBBLFBMPL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid EEMLJOIFAPG;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MBCHLBGJOBD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid PBNIMJBIAPE;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid ODHLFMFODEO;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid PFOCBJCKDBJ;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DIHKGMLLNGN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JKCBBDGCPBB;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid AADIIPGIMEA;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid JBININCAODA;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid AFFHAJNEHGA;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid EGHFFOKDJLO;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GJOLJIDBEFI;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid HOKBMAECMLA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IFNKHNAICPI;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GAKOEBHCGMG;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid OIBJPAAABOA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid BOEGLKCEKEM;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EAEBPNPDFAF;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DMKIIMIKILF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid FJBDGBFMHFE;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LBCIBLCAEMD;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid DFBCKGODGEA;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PJAAPKHGGMO;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid IOLHANLJKKH;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid LEMIFEJHIIC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LIDHHKKCHGG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid KABBJMFGIEP;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid EBAGNKDIIDF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HGLFINEJGDG;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid GHFDIKMAOJM;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid ENCEMGMMCJP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid MLHHEEADEDB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KMKKOMNMOPN;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JMHJAINONBM;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid IDAGFCFFHIC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FCOPDKKOJJN;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid LFOPNIAGNOC;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NEMEKAJDAMB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid NJCJLLMCFJL;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid INCDJFKNANC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FAALKFCJDOG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IKDOGIDAKHC;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ALJBJIPDNMI;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OPLMGDGHLLA;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid EACDOLDELII;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MEMPCOOOAHB;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid GDKLPOPABAA;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GAAKJIFJFDA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid OPLOBNPOOIE;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FGFGFOGHJCI;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid OKECMMCMHAC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid MLMPKCBKOMJ;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OFDGGKACIEO;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LMJKNNIKPPF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HHEGMANGHDI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NDIGDOMNLKO;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid BBGNGAMIMCI;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid EHJOPJDAPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HHKAFPHNKDO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid KAHGFNJNFFA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid KOCBPHJPJDB;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid PBLCJEMOENB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JAKOCPDANBA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid AEJBLDCONNC;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid BLIECMMODHF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid KKIJJNACENK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid IBBNIJLGKLC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BJKJPIOIJKK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid NGKMGCOIIKK;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HDPACHGMLIJ;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MDEFHFIEDDM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid EJOIDAHDHDF;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid LLCHHACLNDB;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid DPEFPKFEJEP;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KCIDKOFFOLP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid KLLNDJOMGJH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid LKBLLGMEFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid MCJPNAGHOOP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid EFIOPCEMLNL;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IMKLFIMGCNF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NIKADELLPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid AOEHGNPDHFH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GHOKFJEIJGK;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid ELKBAKHBEEP;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid JCHHNNMIJHF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid ABGDKGECLMJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid OKKNFAIKADA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NIADCDDHLNN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DEFOFPJCOMO;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NJEBEODMCMK;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LCLNBGNHCLL;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid DELAKOCDHHB;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid EBGELOKGKGK;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid KJCLLMPNFLN;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid BGBBGFIKNNJ;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid IEOFEFEJNDF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HAHPIGCDBCO;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LMJBPIGNDLC;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid KGNFIPMMJAE;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid APOLHDMIEMC;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid KEEGCGCLNAI;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid PLPOOLLEKJK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LBPGKEOEHOB;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BMGFKKOEIML;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EMILNGMNAJH;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid MHODNJBKHHK;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid IIFPMLELOBP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CFJFBOLAPJC;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid MDCEEBKAOLF;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid IIOMOOIMMGL;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid GFOHCEHOOAC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid HNMMPMELNPN;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MOIGHDCEPCI;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid IDNANABDBDN;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PPOLGJPHDDN;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid AMLEOGELEON;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GGOAMBBJFDD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DFDNAHPODAO;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KNDMENMPELF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FOOEPMPIKHB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid ACBDKCGABDM;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid OKLHPNIOIJD;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DANDFGNDKCD;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KPCCFMMNCAL;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid NJEINDBNBBD;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CGGFOLFICPB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MHNDFMADJOD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MEBJPJBOEDK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JOFPCAHMHKJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FJMIFIDBFLI;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JMCAMGODPKB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EELPDAOEHHO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ODKOICODAFH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid JGBKBGMLGJF;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid OBECPGOIGKI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MNBBPDLPEBC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NIFBBNLDILM;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PIPNGNPKKLO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid BPGINPCLBIG;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid NPEDLJHPDLN;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid JEBNMABELAC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid COPCMONKACM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid CPHAGGGDBGF;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid BCBKECEDLHE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HILNJKGKEGN;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid BPGFCIONLFL;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid OIHIHMKPCCE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid HJCJHDCMCGI;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid IPDLABCMPLP;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FCJAPGHLOKL;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid AEMFNBILBII;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid JOBEKIOBDPN;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid MFFAJEBEECD;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GCHEDBKOGJJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LLOLFKGDEHF;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FBJDAPBAPBH;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid DMBIJIALHEL;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CINLBHJNJEN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BKEFEEADPCD;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid GEANGLAOKEG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid CDAICJNLOMH;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JDHIOHPPENM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid GENALOCFBMO;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid BKCPBPLHHID;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid JOACPFGJHAP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KCGFICGCEHM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid PPBDNBGHGLK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid NPAHCANPOIP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid PNEAMKDECJH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid FOEEEHACIDF;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PHGBCOLMKPG;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NAMNKKODIPO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FGBMHNIKINP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid NHKBKEHGKJO;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid NLFAIHLMAJE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid OJOHFEGJFLM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid BHGBBFMMBAI;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JPMPHBLHNJL;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid DMJDBJKNEJP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid IOFLOAKGIBG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid AAJKGOMLOBB;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid MADNEIIFLKH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid IINGBDIKLDL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid AOCMDDMPPNE;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ANKCFAOGFFD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid CKPJAHCHCEO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BOEHIPACJFO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid ICOHMCBDDJH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid EDFGCALENCM;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid PAHHBLKFMCA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LEEOOLFOGIO;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid NGLGHPCACPH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid HNOPCGPNHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid CJNLLPOBONP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid ICOKFBLAFFP;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid CPEFNGENKGO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HJKHLALCLNM;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid EKGNGKGPKEA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid OOMBLBGNODJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HFAJMEMBBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid AFDCJPAPFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid IOPHBLNMJDN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GDAACMIBHEK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FJEONFOEOKE;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid PPMCIPICIMD;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid CPMFCOMFEIG;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid GGMDMGMLKKF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid MAKBIBKGMGN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid FIMEEDGEOAH;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid KHLIHILCDLN;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid PHHDFOPFDAJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid AJOBJFAGJAG;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid EOCONGGBHIE;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid EHJMOJEFAGI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CHBLBBIPDLM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid JCNBAJMJKBN;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid FIINIMMELIC;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid FBLPKMAEDCB;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KDMOCCHCDHD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid MFJAGECCMNF;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid ONCGEBHHMNA;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid GJAOACPPNKN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GMJJPFGDMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid BKFPALANCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid IBIKKAGCPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid DCEHNOEDLDG;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid EEDMCPLBFDC;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid CPBLGOPHLOJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid BPMFBDNLBPF;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid HIDIFDDGHKB;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid JJJEHBGCKJI;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AJCFHAMOCLD;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid PCCOEJEEJJM;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AOBMHMOFLCO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid IEDININBJLI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BKFKOMJFCEM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid FHPBINHGLEE;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BCLFFHCAKIB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid PNHLMPNPDEK;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid LKCMBIGDHLP;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DGJFEJAFFIN;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IKDKLJFHDCM;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MJMBNOBFIGK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid AKNEJAADINP;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid PNCJMAEFPHG;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid HCDJCJKABJH;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GBPAKIDGHEJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid HBBJADFHFLG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid MHAIPKMKMLE;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DNDGGEGDNOG;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid PEGBHHBMEEL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid NFOHEONMIJA;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DLNBBBGAFMO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid IJOPCCEIICI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid EBFKPPGFEKF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid INAJOHAEGMK;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid ICMINHPJMGB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid MJEPEKEMAII;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KIGNIPHHBAL;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NNKMGCNNEPD;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid DAMFEMCFMPP;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid KANFJDKKCAB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid BEMMCEGHPLI;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid BCKLKAJEEJA;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid IBDMLNGNJMC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid INDOPJCGGAI;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid NHHILEINBCK;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OOLKFMGDDFL;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MKJBJILIOIM;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DAFGKGFBFAD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GDPPKGFJPFM;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid ABJODEKBEON;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid CCCOBJIOIAA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CLDLMAGFJDO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JGGGGBLNHEF;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JPKANFBDJNO;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid OGFIFGELLJE;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid MEJFIPCPOOE;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid AFOJGMEHMDO;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CJKPBEMHPEE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BOFGFEBEAID;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid GDJFGAFNEOB;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid GHJJFMCEBNG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LEMDLOIJNPG;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PEDCLPCHPBD;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IMFAKECGGBA;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid MHFHDLLBONG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid AJCJPKNNEIK;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid PFCDKGIGCMD;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid IHAOPGNKPCH;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid ANDEHKBDIIN;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BFOHBHAMEAJ;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid EKLHHANOIJP;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid IDANGLFDGGD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid HDNKJPNNFFM;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid HKFHFFJKHCN;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid ENFPPAGLIJK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid BKEJCAMPGEH;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MBNIKMMOOJA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KOHDLBGGIOO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid GECMMKIBOCC;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OKMIKNKOHAO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid OCOPBIHCGLD;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid NEBALMLNNGB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DMGJEMDCMDL;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MMFKBBMFKOE;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid AGBCFFGCEEB;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NGIJGKKHPID;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid AKAFOPDGPLA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid BHCJNPNDJEL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JIMANKPOGKA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid JANHFGOGOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HHDHIDCIBLM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KMDMLEABCPM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid NPDFOKELOFH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OJHOLBNCCHH;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid IIDAMAGMIGI;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid LAJJABDMEHG;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid LIIOHNGFILK;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid KFHKGONHDGL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid DHJMEIMDDLC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid CCEAHLNMHNE;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LGFIMHIDKCJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid DPPMBJAFLBN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid ODABCHGBNIO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HHFAMMOLEFM;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid LMMFAJGDMOL;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid INAIOEFOEEC;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid NFBNFMMNDKH;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BEIGEDDKBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid AIOLPNDGKPM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FJELPKHFLFF;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid AEBGNCELNCD;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IPFJKODOBJA;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AMNNKKAKPBL;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid BNCNJLFDJMF;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid IHBEOFIECPP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid ELIENIFEJBB;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid LDDDLIGNKEH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid FCJCOAOLOCC;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EBOLKCJPKDD;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid FIAFNDCDFCJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid BJENBGCBOFD;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid KFEEHPCKPBL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid FECBOGBDBDK;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid BOFEGDIBBNO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid IMILKHJBCKN;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid NIALEBNPIPH;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HLOBEJFFBPM;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid CKMBKOPHCFO;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid NJIGCECCIIB;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid GCNBIKPEPKO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GAENNGHJGLE;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid MIIDLOBHPAF;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LALGLAILODL;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid EKHIBMDEJIH;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OFAIEAILMKO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid ACDOKIOIGEG;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid KKLIAJJIJEC;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid FOFKDAKILAM;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid JDMHGLLOHEK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid ICIJGCHEKHM;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid AMLDNOLGJBO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid MGGDIABOPLA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HJDBGCOEKDN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid LMBPBDGDGJN;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid LGNOPHDLINA;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid JMBLCAEEPLN;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid MIEJPMDHEAO;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid CAPPNLFIIPO;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid IDPNMMAFJJJ;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid OKMKLGPEGCB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid ACOBIGBOFGP;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid LNCNEOPEILJ;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid OANKBDAGJGP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid FECLKCNHBEJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GNODIEGPEAD;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid PNEJIMHEECL;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid FGFPBLOFMJD;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid IHKDPOADBLK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OFPEDIIFGOM;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid MDADKLCLGGJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid GCNPBLBBOBK;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JNLDHIHBJHC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid AHFDBKBCKKE;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid DFGFCBDEFEL;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid APJIANLODLD;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid OHBPNGPMBIK;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid JGOEPAOIBBB;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid ECNFBLHAIEM;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IEMLDBDNBKL;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid BPAMIBJOELE;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid CEOPHCBMJMC;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid NHEBKEEAELD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MGDCHGPEIDI;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid MLEIGBPOMCE;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid POPMHEBMLPE;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid ELLDDICKLIN;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid HIFDHEBOJIA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DJMBOOKHFJN;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid LJAAAOBEMDF;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid IJOGDBHOLJJ;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid JNAELOCGOEB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GNBEGPLDGOI;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid GLJKPLNKEKJ;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid OAPJMAFGCHB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid ANKIFPDLFKG;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid OOGOHGMPHIO;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid MLLEECNIOJD;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid LNPBJCMELKM;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NANOHPAPBBF;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid IIFBDFEAOEI;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JBKDMIMEBHI;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid CIJIAHOMHGN;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FGBCIOLPKCK;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid HEFCMGHBNID;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MELFIIBHAJK;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid IEECPFBKHKD;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid FIIPOCMNJPH;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid DLCNBCBBJHJ;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MCBLPMAKIGJ;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LNJFCCJEEDI;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid MAFCNICPBDA;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid BJNHECGCAPE;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid GLNJIEKHPGI;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid LFCGCENCHOJ;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid ANNBEHPGDEI;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid JDLMAJEJFBP;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid PDJPDEEGOHB;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid EHPIAGDEGCC;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid BHBNFBPLBBE;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid ELPLGADNOBF;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid AGMGJPMNNLN;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid MFLFLOANLNJ;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid DMCLEMBDPJH;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid DJMHLALJLGJ;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid CDGEPLKHIIK;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid HCCJBAGIJNL;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid PLNFEMAMIGB;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid IDPDFDIENBI;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid EJDFBMFIENN;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid CCNDLCFCNPO;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid CIEDLIHCIIK;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid KFCAAHNPHJK;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid NPELABLBPJG;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid BDMNDLEMIDH;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid DAJIJJDLMDI;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid HKLCPILLDOA;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid CFONEFPKGOI;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private static readonly Dictionary<Guid, LFKLBCPEPFF> PJDDBCFEBBB;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private static readonly Dictionary<LFKLBCPEPFF, Guid> EDAAEDHPCDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LFKLBCPEPFF> EPNPMAOABCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7790E50", Offset = "0x7790250", VA = "0x187790E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LFKLBCPEPFF, Guid> BNDPHBHGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7790E00", Offset = "0x7790200", VA = "0x187790E00")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KPIMFIADKCM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7790EA0", Offset = "0x77902A0", VA = "0x187790EA0")]
	public static bool PIMNLPDIEKA(FGAPKBADBDC EGJBLEDEOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7790ED0", Offset = "0x77902D0", VA = "0x187790ED0")]
	private static bool PIMNLPDIEKA(JHKBPFFCGFI DBBKCMNDDPN, FGAPKBADBDC EGJBLEDEOLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DHOBNGOPBFN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(GNJOOMLNPNP AMHCLKHIFKH, [Out] Dictionary<int, int> OHBIFPGAIPK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OLMIOOOKIFM HFLOKGEFHLB, COAPECFAABJ CGNFLCAGGBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EENBCKEPOOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public readonly JKEAOGPLPFE AGHAGIFABBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public readonly IEnumerable<EBFEMKEPGFD> GHGDNIIEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly IReadOnlyList<EBFEMKEPGFD> OAOOAEEINMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly EECNAGIPCBM<JJJHHLABGOM> NNJOEBLMKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> CLIBILAGHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly CPLJDLKPMMA KJAEEFLKBGE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBLFJPBAAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77836F0", Offset = "0x7782AF0", VA = "0x1877836F0")]
	public EENBCKEPOOA(JKEAOGPLPFE HFBBADPBDNI, IEnumerable<EBFEMKEPGFD> NLKDNDLFMAK, IReadOnlyList<EBFEMKEPGFD> AHDFHMBBJAE, EECNAGIPCBM<JJJHHLABGOM> NAOCMNCGBGA, IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> MGHKILINENF, CPLJDLKPMMA IBJJPMNCGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DLENIFHKHOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly JKEAOGPLPFE AGHAGIFABBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly IReadOnlyList<EBFEMKEPGFD> FDHEJJFNBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly EECNAGIPCBM<JJJHHLABGOM> NNJOEBLMKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> CLIBILAGHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly ByteString PDNMJKGOIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly CPLJDLKPMMA KJAEEFLKBGE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7781610", Offset = "0x7780A10", VA = "0x187781610")]
	public DLENIFHKHOE(JKEAOGPLPFE HFBBADPBDNI, EECNAGIPCBM<JJJHHLABGOM> NAOCMNCGBGA, IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> MGHKILINENF, ByteString EALENNLNKMM, IReadOnlyList<EBFEMKEPGFD> LLFBJGGMABF, CPLJDLKPMMA IBJJPMNCGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PHKCMDAMKJI : MONNNCACBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly Guid BBMKICFKPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private readonly Dictionary<Guid, Guid> EBAHFMPNPGP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4675450", Offset = "0x4674850", VA = "0x184675450")]
	private PHKCMDAMKJI(Guid MDDLEDOOKCG, Dictionary<Guid, Guid> EBAHFMPNPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7791390", Offset = "0x7790790", VA = "0x187791390")]
	public static PHKCMDAMKJI AFLKMMODJAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7791B60", Offset = "0x7790F60", VA = "0x187791B60")]
	private static Dictionary<Guid, Guid> LGDBAGFJLEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77918D0", Offset = "0x7790CD0", VA = "0x1877918D0")]
	public static PHKCMDAMKJI IMDMOOOLGME(IReadOnlyDictionary<Guid, Guid> ICAPBAKKPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7791570", Offset = "0x7790970", VA = "0x187791570")]
	public static PHKCMDAMKJI CPKGPFBDNOB(IEnumerable<KeyValuePair<Guid, Guid>> ICAPBAKKPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7791C90", Offset = "0x7791090", VA = "0x187791C90")]
	public Dictionary<Guid, Guid> NLPONADINJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
	public Dictionary<Guid, Guid> OGKMHFLJEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7791C10", Offset = "0x7791010", VA = "0x187791C10")]
	public void LLICHLCEEGA(Guid ICAPBAKKPBL, Guid DHFBCDKDEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77918E0", Offset = "0x7790CE0", VA = "0x1877918E0")]
	public void JIEMPBMOGPN(IReadOnlyDictionary<Guid, Guid> AINBMDGLBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7791420", Offset = "0x7790820", VA = "0x187791420")]
	public Guid BCBMOMFIGIH([In] Guid ICAPBAKKPBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7791D10", Offset = "0x7791110", VA = "0x187791D10")]
	public Guid OOKBHDJJKED([In] Guid ICAPBAKKPBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7791860", Offset = "0x7790C60", VA = "0x187791860")]
	public bool IIJOBCELLOG([In] Guid ICAPBAKKPBL, [Out] Guid DHFBCDKDEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7791860", Offset = "0x7790C60", VA = "0x187791860", Slot = "4")]
	private bool HEEKGAPJAAO([In] Guid ICAPBAKKPBL, [Out] Guid DHFBCDKDEBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FLNFBKAPKFG
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
public sealed class HLHCOLNKJOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ACIMBMKGCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public JKEAOGPLPFE staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ACIMBMKGCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x777DD40", Offset = "0x777D140", VA = "0x18777DD40")]
		internal EECNAGIPCBM<APMGFEHLJPN> JNHDIGFOKID((EECNAGIPCBM<JJJHHLABGOM> GraphId, EECNAGIPCBM<DJONKGBCHFD> NodeId) i)
		{
			return default(EECNAGIPCBM<APMGFEHLJPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly ICNPICGMOCM<APMGFEHLJPN, int?> EKFKEMNFPKK;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly long FOIIKLJBMMP;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77839A0", Offset = "0x7782DA0", VA = "0x1877839A0")]
	public static (long, long) MOHDAAFHODG(JKEAOGPLPFE ACIBIKFNIII, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7783760", Offset = "0x7782B60", VA = "0x187783760")]
	public static long CAAAMCBEFJH([In] ReadOnlySpan<EECNAGIPCBM<APMGFEHLJPN>> OFPLAMAJDGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7783880", Offset = "0x7782C80", VA = "0x187783880")]
	private static long KENNILLHEKK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DDODGPMIBAG
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public static readonly HashSet<LFKLBCPEPFF> IGOLPCHJEHE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DAPIBCNJDEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DCOMEBEPGPO : IEnumerable<EBFEMKEPGFD>, IEnumerable, IEnumerator<EBFEMKEPGFD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private EBFEMKEPGFD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private LNMNMAONBND spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public LNMNMAONBND <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private ANELIHKPOPN spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public ANELIHKPOPN <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private EBFEMKEPGFD System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public DCOMEBEPGPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7781130", Offset = "0x7780530", VA = "0x187781130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77813B0", Offset = "0x77807B0", VA = "0x1877813B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7781240", Offset = "0x7780640", VA = "0x187781240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EBFEMKEPGFD> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7781240", Offset = "0x7780640", VA = "0x187781240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7780780", Offset = "0x777FB80", VA = "0x187780780")]
	public static LNMNMAONBND HOCPLNJJCFC([In] DLENIFHKHOE DGNBLGFDOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77808F0", Offset = "0x777FCF0", VA = "0x1877808F0")]
	public static LNMNMAONBND HOCPLNJJCFC([In] EENBCKEPOOA DGNBLGFDOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x777E360", Offset = "0x777D760", VA = "0x18777E360")]
	private static HashSet<IEBAHENHLEA<POBMEBKLCBD>> DKJPALLADFM(IReadOnlyList<EBFEMKEPGFD> LMHGCJEGHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x777E700", Offset = "0x777DB00", VA = "0x18777E700")]
	private static void EGLIFEPGFKH(LNMNMAONBND NLLGLLNANMB, [In] EENBCKEPOOA PGCCNPMNDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x777F400", Offset = "0x777E800", VA = "0x18777F400")]
	public static AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE> GNBLKKDDAGH(LNMNMAONBND NLLGLLNANMB, ANELIHKPOPN MDBJLDFKNDE, PHKCMDAMKJI? MLFGNMGNILP, bool KMMHJFEAHEE)
	{
		return default(AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7781020", Offset = "0x7780420", VA = "0x187781020")]
	[IteratorStateMachine(typeof(DCOMEBEPGPO))]
	private static IEnumerable<EBFEMKEPGFD> PBHJMKFLAKG(LNMNMAONBND NLLGLLNANMB, ANELIHKPOPN MDBJLDFKNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x777E2F0", Offset = "0x777D6F0", VA = "0x18777E2F0")]
	private static void DBEGDJPEGFJ(LNMNMAONBND NLLGLLNANMB, ANELIHKPOPN MDBJLDFKNDE, IReadOnlyCollection<ByteString>? PIPOFDICBGF, IReadOnlyCollection<ByteString>? OLBOFAPFPKA, IReadOnlyCollection<ByteString>? GCHECEGEAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x777ED60", Offset = "0x777E160", VA = "0x18777ED60")]
	private static bool GHEBLKNDAPA(LNMNMAONBND NLLGLLNANMB, OLMIOOOKIFM HFLOKGEFHLB, ANELIHKPOPN MDBJLDFKNDE, [Out][NotNullWhen(false)] string? DFEFGBECJNJ, [Out] Dictionary<int, int> OHBIFPGAIPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7780D40", Offset = "0x7780140", VA = "0x187780D40")]
	private static Dictionary<Guid, JHKBPFFCGFI> JNNAPJDPGAA(LNMNMAONBND NLLGLLNANMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x777DDB0", Offset = "0x777D1B0", VA = "0x18777DDB0")]
	private static void CFAJPEFPOCP(bool OKBKPAOGGHG, EBFEMKEPGFD IBPIFPONGON, PHKCMDAMKJI EOCJOOEFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7780A70", Offset = "0x777FE70", VA = "0x187780A70")]
	private static void IJDPDHMMHLP(EBFEMKEPGFD IBPIFPONGON, Guid EPPHOMAKDFP, HOIFIHKDPKF? IONHHILDKFB, Dictionary<Guid, JHKBPFFCGFI> LBLBMGAPBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x777DE40", Offset = "0x777D240", VA = "0x18777DE40")]
	private static void CINDFEKIEPE(IEnumerable<EBFEMKEPGFD> FNJLOEPGIAJ, IReadOnlyCollection<ByteString> PIPOFDICBGF, IReadOnlyCollection<ByteString> OLBOFAPFPKA, IReadOnlyCollection<ByteString> GCHECEGEAGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ANELIHKPOPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool OKBKPAOGGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public CPLJDLKPMMA IBJJPMNCGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public HOIFIHKDPKF? IONHHILDKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public HOIFIHKDPKF? LGKELGIDHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public JKEAOGPLPFE MBKGBPNGNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public FLNFBKAPKFG NDHOCFFMFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public DHOBNGOPBFN JPAGLGFGFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public IEBAHENHLEA<JJJHHLABGOM> IGBEDKLHICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public FOBIELMFHMM BKPENMKDPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public List<EBFEMKEPGFD> ONENKHAEHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public GPMAMEJIKCA KMNMEJOOKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public FAIAKKBPEOH CMFKOADHGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HOIFIHKDPKF
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private const float IKFKOBANDFF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public Vector3 JPKKPDPLAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Quaternion BENMKDDDBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public float PGJAFHMCBJK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 LJJFAJOKGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77972A0", Offset = "0x77966A0", VA = "0x1877972A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS LIELKFFEGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7797260", Offset = "0x7796660", VA = "0x187797260")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1296330", Offset = "0x1295730", VA = "0x181296330")]
	public HOIFIHKDPKF(Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float PGJAFHMCBJK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7797950", Offset = "0x7796D50", VA = "0x187797950")]
	public HOIFIHKDPKF(UniformTRS OFCCJMOCNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7797640", Offset = "0x7796A40", VA = "0x187797640")]
	public static HOIFIHKDPKF PCMCPLCKMHD(HOIFIHKDPKF PBIFOHNGFLL, HOIFIHKDPKF KBMEJPKAAAL)
	{
		return default(HOIFIHKDPKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7797430", Offset = "0x7796830", VA = "0x187797430")]
	public static HOIFIHKDPKF MDKCMNAEKLA((Vector3, Quaternion, float) AMHCLKHIFKH)
	{
		return default(HOIFIHKDPKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7797450", Offset = "0x7796850", VA = "0x187797450")]
	public static HOIFIHKDPKF MDKCMNAEKLA(Matrix4x4 LBPNFEAGGIB)
	{
		return default(HOIFIHKDPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77978C0", Offset = "0x7796CC0", VA = "0x1877978C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7797180", Offset = "0x7796580", VA = "0x187797180")]
	public HOIFIHKDPKF CCAMNJMDFME(Matrix4x4 NPHMCHFKJHC)
	{
		return default(HOIFIHKDPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77975D0", Offset = "0x77969D0", VA = "0x1877975D0")]
	public static HOIFIHKDPKF PAHJPKEAOBD(Vector3 JPKKPDPLAGA)
	{
		return default(HOIFIHKDPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x77973A0", Offset = "0x77967A0", VA = "0x1877973A0")]
	public readonly AGDIGDNFMBO LCDGONJKNEJ()
	{
		return default(AGDIGDNFMBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KJDGBDLJLFM
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct BIBOLIFAOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public readonly AFOJFCADKBI CKDPKKPOENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly EPFFDEGDAEO JFICDKBAGGI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1522D40", Offset = "0x1522140", VA = "0x181522D40")]
	private BIBOLIFAOAE(AFOJFCADKBI BKKCGGLCOFC, EPFFDEGDAEO OAHPDJDJBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77928B0", Offset = "0x7791CB0", VA = "0x1877928B0")]
	public EIBOIADIOGN ONHECGKLCKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7792690", Offset = "0x7791A90", VA = "0x187792690")]
	public static AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE> AFLKMMODJAC(OAPCAHNDPEI<DKANDHFOMPH> OAHPDJDJBOP)
	{
		return default(AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7792740", Offset = "0x7791B40", VA = "0x187792740")]
	public static AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE> AFLKMMODJAC(EIBOIADIOGN OAHPDJDJBOP)
	{
		return default(AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x77927F0", Offset = "0x7791BF0", VA = "0x1877927F0")]
	public static AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE> AFLKMMODJAC(string OOAMCLLOKIB)
	{
		return default(AEAAIINGJNL<PHKCMDAMKJI, BIBOLIFAOAE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum AFOJFCADKBI
{
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KGNAOLMDFOB : IDisposable, MPAIKKNNIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private NativeList<HDHHCFJCJDP> FBNICMAOOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private float GLIMJAGGHLA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JIHOGGHEDMF OLAGIMJAHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0")]
		[CompilerGenerated]
		get
		{
			return default(JIHOGGHEDMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IOAMBCNIOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6737E70", Offset = "0x6737270", VA = "0x186737E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool JAIOFJDCHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6737E80", Offset = "0x6737280", VA = "0x186737E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<OEOAFMEOOLN> AAMLFMDIINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HIJPCHJBGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7798610", Offset = "0x7797A10", VA = "0x187798610", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float NHCPMEDFNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7798B20", Offset = "0x7797F20", VA = "0x187798B20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x779ADF0", Offset = "0x779A1F0", VA = "0x18779ADF0")]
	public KGNAOLMDFOB(JIHOGGHEDMF CPMLONDPBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7799460", Offset = "0x7798860", VA = "0x187799460", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7798650", Offset = "0x7797A50", VA = "0x187798650")]
	public Vector3 BMELLEAEBAH(int MGJOIMHBHJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x779AAD0", Offset = "0x7799ED0", VA = "0x18779AAD0", Slot = "6")]
	public Quaternion OKGBBABFCKA(int MGJOIMHBHJO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x779A810", Offset = "0x7799C10", VA = "0x18779A810", Slot = "5")]
	public Vector3 LKFLIBJJIFD(int MGJOIMHBHJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x779AA70", Offset = "0x7799E70", VA = "0x18779AA70", Slot = "7")]
	public float MLEHACGIKNA(int MGJOIMHBHJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7799B30", Offset = "0x7798F30", VA = "0x187799B30")]
	public void JAMGKONGPKE(Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP, bool IBDAMEMCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x779AA10", Offset = "0x7799E10", VA = "0x18779AA10")]
	private bool MIIDILPFNBO(int CDFGMKFEAEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x779AC00", Offset = "0x779A000", VA = "0x18779AC00")]
	public void OOGCACICGHO(Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7799950", Offset = "0x7798D50", VA = "0x187799950")]
	public void FLKOOPKLENA(int CDFGMKFEAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x77999E0", Offset = "0x7798DE0", VA = "0x1877999E0")]
	public void HLDOKPOHGHL(int CDFGMKFEAEA, Vector3 JPKKPDPLAGA, Quaternion BENMKDDDBDG, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x779A510", Offset = "0x7799910", VA = "0x18779A510")]
	public void KJIJMDABGBG(int CDFGMKFEAEA, float3 JPKKPDPLAGA, quaternion BENMKDDDBDG, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x779A6C0", Offset = "0x7799AC0", VA = "0x18779A6C0")]
	public void LKFAEPNBMDI(int CDFGMKFEAEA, Vector3 JPKKPDPLAGA, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x779A8B0", Offset = "0x7799CB0", VA = "0x18779A8B0")]
	public void MHFKOLENIPJ(int CDFGMKFEAEA, Vector3 HAKFDJFOEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7798C60", Offset = "0x7798060", VA = "0x187798C60")]
	public static Quaternion DAHKNPAEICJ(Quaternion GJCDHPPPAHJ, int CDFGMKFEAEA, float LNGHMFNCIGB, MPAIKKNNIGN DKPELJENLEG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x77994C0", Offset = "0x77988C0", VA = "0x1877994C0")]
	public Bounds FJCDNPIPAGB(Transform NPHMCHFKJHC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x779AD80", Offset = "0x779A180", VA = "0x18779AD80", Slot = "10")]
	public virtual void OPNFAMHCDNG(bool ICACFBFGBGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x779A440", Offset = "0x7799840", VA = "0x18779A440")]
	public NativeList<HDHHCFJCJDP> JCHKBCNIGKJ(float DHGDGMFHOGL = 1f)
	{
		return default(NativeList<HDHHCFJCJDP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OEOAFMEOOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public float3 CPGAKMJDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public float NHGCPPGEOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public quaternion CBGFLJDPLDI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x779B910", Offset = "0x779AD10", VA = "0x18779B910")]
	public OEOAFMEOOLN(Vector3 FPPHNHEFIKD, Quaternion GJCDHPPPAHJ, float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x779B560", Offset = "0x779A960", VA = "0x18779B560")]
	public Quaternion GLJBLJEIFIG(Vector3 DLBKBBJEBDD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x779B620", Offset = "0x779AA20", VA = "0x18779B620")]
	public OEOAFMEOOLN HAEILHICAAL(Vector3 EJNJAMGBGKN, Vector3 COCKLDFIHCM, Vector3 DLOIOGKMGNM)
	{
		return default(OEOAFMEOOLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x779B3C0", Offset = "0x779A7C0", VA = "0x18779B3C0")]
	public MDEPOKODCBJ FKADOOFGDCM(Vector3 DLBKBBJEBDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class PIJEFEALEKG : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x779D410", Offset = "0x779C810", VA = "0x18779D410", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x779CB50", Offset = "0x779BF50", VA = "0x18779CB50")]
	private void GEDFFPJJOFB(Dictionary<Guid, Guid> CMHDDJAKMFD, DKNJBECFMBF BJPCLOLOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x779D3B0", Offset = "0x779C7B0", VA = "0x18779D3B0")]
	private void GEDFFPJJOFB(Dictionary<Guid, Guid> CMHDDJAKMFD, GELKKCJJMPK ENDKMEEIODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x779D130", Offset = "0x779C530", VA = "0x18779D130")]
	private void GEDFFPJJOFB(Dictionary<Guid, Guid> CMHDDJAKMFD, OJCPFDOOMIO AFIGLLNKJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public PIJEFEALEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class IFECHAIFNEB : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7797A20", Offset = "0x7796E20", VA = "0x187797A20", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public IFECHAIFNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class FILLFAGKFLN : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7793C10", Offset = "0x7793010", VA = "0x187793C10", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public FILLFAGKFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class MOHAPOHFICE : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x779AFC0", Offset = "0x779A3C0", VA = "0x18779AFC0", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MOHAPOHFICE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GOPJBGHNDIG : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7794100", Offset = "0x7793500", VA = "0x187794100", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public GOPJBGHNDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LKDLPAHHIKD : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x779AE80", Offset = "0x779A280", VA = "0x18779AE80", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LKDLPAHHIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class FIAMLHCDFHF : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7793A80", Offset = "0x7792E80", VA = "0x187793A80", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public FIAMLHCDFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IHOFLCACNKB : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7797AD0", Offset = "0x7796ED0", VA = "0x187797AD0", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public IHOFLCACNKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ABMGKCAJOFK : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7791E50", Offset = "0x7791250", VA = "0x187791E50", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ABMGKCAJOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GEBPJKKNFAC : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7793F50", Offset = "0x7793350", VA = "0x187793F50", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public GEBPJKKNFAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NMIIEMDHHOO : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x779B120", Offset = "0x779A520", VA = "0x18779B120", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public NMIIEMDHHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JNCIBOIINKH : NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public static readonly FAPJLBNEBEP FCDOGDFPBFO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x77984E0", Offset = "0x77978E0", VA = "0x1877984E0", Slot = "4")]
	public void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JNCIBOIINKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct FGAPKBADBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public OLMIOOOKIFM DFDKLALNEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public BOIIODNOJMF PMCAJOAOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public Dictionary<int, int> LCLGAPJGBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public Dictionary<Guid, Guid> OPCBMBBBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public FAIAKKBPEOH CMFKOADHGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public bool KMMHJFEAHEE;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface NLAGLAMAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMPOCLIPMGC(ANMKIPAKKOK LCCPBGFFGAL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FEEOENBLEIB
{
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private static readonly NLAGLAMAFGJ[] ADIJJHNNCCE;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7792E40", Offset = "0x7792240", VA = "0x187792E40")]
	public static void GJNLJOMECCI(EBFEMKEPGFD AMHCLKHIFKH, PHKCMDAMKJI DALNPOEFEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7792920", Offset = "0x7791D20", VA = "0x187792920")]
	public static void ALIPLKFCOGK(EBFEMKEPGFD? AMHCLKHIFKH, PHKCMDAMKJI MCCGCBJKJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7792BC0", Offset = "0x7791FC0", VA = "0x187792BC0")]
	public static void CEJODFMCAEP(EBFEMKEPGFD? AMHCLKHIFKH, PHKCMDAMKJI EOCJOOEFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x77930C0", Offset = "0x77924C0", VA = "0x1877930C0")]
	public static void PIMNLPDIEKA(ANMKIPAKKOK LCCPBGFFGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ANMKIPAKKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public OLMIOOOKIFM MIBMNHJKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public EBFEMKEPGFD IBPIFPONGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public Dictionary<int, int> LCLGAPJGBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public Dictionary<Guid, Guid> OPCBMBBBCAH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7792000", Offset = "0x7791400", VA = "0x187792000")]
	public Guid NEMMDKEAFGL(Guid IIBHEJCKGGH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FAIAKKBPEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MFMEBDAKEIK, [Out] Guid NDPJCADKGJJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class HECDLJHFNEH
{
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private static readonly ProfilerMarker EMMKJGFICEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private readonly HashSet<string> EPDNEBKOPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly Dictionary<long, int> CHKDMLJAOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly HashSet<Guid> LEIBJLMEGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly HashSet<Guid> MPJNMLGDPDG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> HAAPCGEMLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> PNCFCBGPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> MEFLLOMEFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x77955A0", Offset = "0x77949A0", VA = "0x1877955A0")]
	public static void GPGMNBNPGPG(LNMNMAONBND OBKDJMDDBJI, BCHCIFHCAFD GIBLHDGIJLF, PHKCMDAMKJI LIABKFFFKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7796D10", Offset = "0x7796110", VA = "0x187796D10")]
	public static HECDLJHFNEH OHPGCOGPION(BPGLDJMOGPH BDAPIDPALOK, [Optional] BCHCIFHCAFD? GIBLHDGIJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7795320", Offset = "0x7794720", VA = "0x187795320")]
	public static HECDLJHFNEH DIHHPDMIFPD(LNMNMAONBND NGOEIFJHIKN, [Optional] BCHCIFHCAFD? GIBLHDGIJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x77953A0", Offset = "0x77947A0", VA = "0x1877953A0")]
	public static HECDLJHFNEH FCIOCIPEEJF(IEnumerable<string> EPDNEBKOPOI, IDictionary<long, int> HGCAKCPDPAD, IReadOnlyCollection<Guid> MPJNMLGDPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7796E50", Offset = "0x7796250", VA = "0x187796E50")]
	private HECDLJHFNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7796FB0", Offset = "0x77963B0", VA = "0x187796FB0")]
	private HECDLJHFNEH(IEnumerable<string> EPDNEBKOPOI, IDictionary<long, int> HGCAKCPDPAD, IReadOnlyCollection<Guid> MPJNMLGDPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7794CA0", Offset = "0x77940A0", VA = "0x187794CA0")]
	private void AEFAMAOJJHM(BPGLDJMOGPH BDAPIDPALOK, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7794680", Offset = "0x7793A80", VA = "0x187794680")]
	private void AEFAMAOJJHM(LNMNMAONBND NGOEIFJHIKN, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x77966B0", Offset = "0x7795AB0", VA = "0x1877966B0")]
	private void MNGOJIBAIMO(ByteString? EALENNLNKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7794320", Offset = "0x7793720", VA = "0x187794320")]
	private void AEFAMAOJJHM(KLOIJACNDNF? FDNIDHBNFHE, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7796310", Offset = "0x7795710", VA = "0x187796310")]
	private static void GPGMNBNPGPG(KLOIJACNDNF? FDNIDHBNFHE, BCHCIFHCAFD GIBLHDGIJLF, PHKCMDAMKJI LIABKFFFKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x77960A0", Offset = "0x77954A0", VA = "0x1877960A0")]
	private static void GPGMNBNPGPG(GLEDMEBDEEF? JOMDOBIKCNM, BCHCIFHCAFD GIBLHDGIJLF, PHKCMDAMKJI LIABKFFFKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7794EC0", Offset = "0x77942C0", VA = "0x187794EC0")]
	private void AEFAMAOJJHM(GLEDMEBDEEF? JOMDOBIKCNM, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7795140", Offset = "0x7794540", VA = "0x187795140")]
	private void CNNJPDDFINA(Guid? IIBHEJCKGGH, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x77948A0", Offset = "0x7793CA0", VA = "0x1877948A0")]
	private void AEFAMAOJJHM(EBFEMKEPGFD? IBPIFPONGON, BCHCIFHCAFD? GIBLHDGIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7795C60", Offset = "0x7795060", VA = "0x187795C60")]
	private static void GPGMNBNPGPG(EBFEMKEPGFD? IBPIFPONGON, BCHCIFHCAFD GIBLHDGIJLF, PHKCMDAMKJI LIABKFFFKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x77950D0", Offset = "0x77944D0", VA = "0x1877950D0")]
	private void BEPBDHDKDCO(string? FGEEGGJFKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7796C40", Offset = "0x7796040", VA = "0x187796C40")]
	private void MNPJPIKCNEM(long OHMNKLMNMLG, Guid ELICHFLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7796B90", Offset = "0x7795F90", VA = "0x187796B90")]
	private void MNPJPIKCNEM(CPGHGGHEHEA? GPNCGKCMPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7796BE0", Offset = "0x7795FE0", VA = "0x187796BE0")]
	private void MNPJPIKCNEM(DKOJJMADHBI? GPNCGKCMPOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PHLFGHKBPCA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class BEGIEKGECNH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private readonly IEnumerator<DictionaryEntry> BLIPHGJEAAJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry KMAHBNABBHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7792460", Offset = "0x7791860", VA = "0x187792460", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7792530", Offset = "0x7791930", VA = "0x187792530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x77925E0", Offset = "0x77919E0", VA = "0x1877925E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object NDNCOCJHCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7792380", Offset = "0x7791780", VA = "0x187792380", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
		public BEGIEKGECNH(IEnumerator<DictionaryEntry> BLIPHGJEAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77922E0", Offset = "0x77916E0", VA = "0x1877922E0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7792330", Offset = "0x7791730", VA = "0x187792330", Slot = "9")]
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
		private sealed class NMPAAJIKOIE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x779B370", Offset = "0x779A770", VA = "0x18779B370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public NMPAAJIKOIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x779B220", Offset = "0x779A620", VA = "0x18779B220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x779B320", Offset = "0x779A720", VA = "0x18779B320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x779DA60", Offset = "0x779CE60", VA = "0x18779DA60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object MCBJECJLDOM]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x779D970", Offset = "0x779CD70", VA = "0x18779D970", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x779DB40", Offset = "0x779CF40", VA = "0x18779DB40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x779D8B0", Offset = "0x779CCB0", VA = "0x18779D8B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x779D910", Offset = "0x779CD10", VA = "0x18779D910", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x779DAE0", Offset = "0x779CEE0", VA = "0x18779DAE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x779D570", Offset = "0x779C970", VA = "0x18779D570", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x779D5D0", Offset = "0x779C9D0", VA = "0x18779D5D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x779D630", Offset = "0x779CA30", VA = "0x18779D630", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
		public RoomObjectCounts(Dictionary<int, int> HGHBNININIL, [Optional] Dictionary<int, int> IBJPILEGODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x779D490", Offset = "0x779C890", VA = "0x18779D490")]
		[IteratorStateMachine(typeof(NMPAAJIKOIE))]
		private IEnumerator<DictionaryEntry> CHGIFLNFGEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x779DB90", Offset = "0x779CF90", VA = "0x18779DB90", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x779D7B0", Offset = "0x779CBB0", VA = "0x18779D7B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x779D690", Offset = "0x779CA90", VA = "0x18779D690", Slot = "9")]
		void IDictionary.Add(object MCBJECJLDOM, object FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x779D6F0", Offset = "0x779CAF0", VA = "0x18779D6F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x779D750", Offset = "0x779CB50", VA = "0x18779D750", Slot = "8")]
		bool IDictionary.Contains(object MCBJECJLDOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x779D850", Offset = "0x779CC50", VA = "0x18779D850", Slot = "14")]
		void IDictionary.Remove(object MCBJECJLDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x779D510", Offset = "0x779C910", VA = "0x18779D510", Slot = "15")]
		void ICollection.CopyTo(Array KCPGIJAPEHH, int KDCAMOIGIMA)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class FPOJAEKACJG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xB47C60", Offset = "0xB47060", VA = "0x180B47C60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7793F00", Offset = "0x7793300", VA = "0x187793F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public FPOJAEKACJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7793D70", Offset = "0x7793170", VA = "0x187793D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7793EB0", Offset = "0x77932B0", VA = "0x187793EB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7798200", Offset = "0x7797600", VA = "0x187798200", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object MCBJECJLDOM]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x77980D0", Offset = "0x77974D0", VA = "0x1877980D0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x77982B0", Offset = "0x77976B0", VA = "0x1877982B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7798010", Offset = "0x7797410", VA = "0x187798010", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7798070", Offset = "0x7797470", VA = "0x187798070", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7798250", Offset = "0x7797650", VA = "0x187798250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7797C90", Offset = "0x7797090", VA = "0x187797C90", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7797CF0", Offset = "0x77970F0", VA = "0x187797CF0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7797D50", Offset = "0x7797150", VA = "0x187797D50", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x26392F0", Offset = "0x26386F0", VA = "0x1826392F0")]
		public Invention(long IIKCEJDFBDH, int PPLOBPJCNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7797BC0", Offset = "0x7796FC0", VA = "0x187797BC0")]
		[IteratorStateMachine(typeof(FPOJAEKACJG))]
		private IEnumerator<DictionaryEntry> CHGIFLNFGEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7798300", Offset = "0x7797700", VA = "0x187798300", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7797ED0", Offset = "0x77972D0", VA = "0x187797ED0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7797DB0", Offset = "0x77971B0", VA = "0x187797DB0", Slot = "9")]
		void IDictionary.Add(object MCBJECJLDOM, object FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7797E10", Offset = "0x7797210", VA = "0x187797E10", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7797E70", Offset = "0x7797270", VA = "0x187797E70", Slot = "8")]
		bool IDictionary.Contains(object MCBJECJLDOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7797FB0", Offset = "0x77973B0", VA = "0x187797FB0", Slot = "14")]
		void IDictionary.Remove(object MCBJECJLDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7797C30", Offset = "0x7797030", VA = "0x187797C30", Slot = "15")]
		void ICollection.CopyTo(Array KCPGIJAPEHH, int KDCAMOIGIMA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> OECDKPIFOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public readonly IReadOnlyList<Invention> NIJFEGEKAGI;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	public PHLFGHKBPCA(IReadOnlyDictionary<Guid, RoomObjectCounts> EKMOKMLPNOP, IReadOnlyList<Invention> EDNGIPEEFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x779C170", Offset = "0x779B570", VA = "0x18779C170")]
	public static PHLFGHKBPCA OHPGCOGPION(BPGLDJMOGPH BDAPIDPALOK)
	{
		return default(PHLFGHKBPCA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x779C050", Offset = "0x779B450", VA = "0x18779C050")]
	[CompilerGenerated]
	internal static int KCHABGKPJPC([In] IReadOnlyDictionary<long, int> PPLNPEBIKDJ, long? OHMNKLMNMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x779B990", Offset = "0x779AD90", VA = "0x18779B990")]
	[CompilerGenerated]
	internal static void DLBGDHDPNGM(int AEKJEGEPDFM, [In] KLOIJACNDNF FDMNLPKAGEM, [In] Dictionary<long, int> PPLNPEBIKDJ, [In] Dictionary<Guid, RoomObjectCounts> EKMOKMLPNOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class BCHCIFHCAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private readonly PHKCMDAMKJI ADPJBGNNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> ABLHNIDIFNA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PHKCMDAMKJI OHCHBKOBHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7792190", Offset = "0x7791590", VA = "0x187792190")]
	public void LLICHLCEEGA(Guid LAJAJNKBHAO, Guid APPEGPBKFGD, IReadOnlyList<Guid> AMDDBNMGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x77920A0", Offset = "0x77914A0", VA = "0x1877920A0")]
	public bool CPMHHGDBDCM(Guid EGICFNIMLNL, [Out] IReadOnlyList<Guid> MPJNMLGDPDG, [Out] bool DBKNJCEMNEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7792240", Offset = "0x7791640", VA = "0x187792240")]
	public BCHCIFHCAFD()
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
