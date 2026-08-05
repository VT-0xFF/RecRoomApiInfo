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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AA1DF0", Offset = "0x7AA05F0", VA = "0x187AA1DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KLECIFLMJLN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GIAKAMMEGDN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> EAFMNFCMNPG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> EJDCDNHDLGI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LEMJMODEMOO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string IDOKKPKNCDG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string KCBFMHKHILC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string JGFIFIIDFNF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DFE0", Offset = "0x7A9C7E0", VA = "0x187A9DFE0")]
	public static bool BMCPFMEAFDO(Guid AJIOJKHIDBL, int JDPAOEJKIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A9DF50", Offset = "0x7A9C750", VA = "0x187A9DF50")]
	public static bool AGOBMPGONLL(Guid AJIOJKHIDBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A9E0E0", Offset = "0x7A9C8E0", VA = "0x187A9E0E0")]
	public static string PLCPJFCAPAG(Guid BGPPHEMBCAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ELGGHCEIMJH]
public enum INEMFMMFIIK
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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1980", Offset = "0x7AA0180", VA = "0x187AA1980", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LAOEKIHECMB
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid NFKGECBLOGJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KOHBDJPEFCB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid IGAJFLOJMPB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OHPGPMKFEOG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid CKAHJAOFMPD;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid JNFPLLOFEEC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NNFLFPDNBCM;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid MPGIAGFOGAK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid NICMJLCPDIO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LEFPMBEEBGE;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid JNCODMPKLDA;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid NPBCOJMKGLK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid CLHBJOPAKPC;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid MKIMEBJCLIA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid EELHNKJHEJL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid KCLFFLPJOGC;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid IJLLDPJMEHH;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LOJEHJOFFNP;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid OKLDIACKGNG;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PENBEJKOPKI;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid LKKJLODGIAN;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BMLHDNEDHDB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IKELDBGJCFG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid HJAEMNHMBEG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid CEOCNLGJNGK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid PINPDICLLCO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid LCKJBDPKFGI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FOIAPFJLNMP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OGLOOJNAGCP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid APKIHKNGOMN;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid ODGLKMHMHJD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JLDLNFGBPCA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GLBLPONAEMH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GFONLLANEEH;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid EHILLAALPME;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid IAADCKMJDEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PEBGPDHPAMH;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GGIHFGJBJBI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid EBGLNBHDGIO;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid COENDPAJKKI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LIMLBLDNHKA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid AFHKAMDJLII;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CCNJCLOHPIK;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid DIGBHCJDJEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid MDBPKFIOEIF;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid MLCFHOACMBB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid CNBKANFFOFI;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid PKFOKFMLIOM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid BKOEODNLGKC;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid IJCFFADIAHK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid EDOJAECNEFO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JINMDMLMCNM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid BDDGOOEBNHN;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid BBNLBBDKGAA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid PBBIOLOAPCA;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid BNBIGJHHKGO;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid IKMOLCHIEMN;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DKLJNBFCHIL;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid KNPMNOFFNLE;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PPHCMJAGAJM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PJCBPEMPKCF;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HLHDKMMDBIA;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NHGLMBMECMO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid CGGOHDDJLNC;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid PIOKOLPFOPP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid NENMPJNIALI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AKHEHGEPCAJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KFAAFDALCHE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid PGPHDJIEDPL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FFHFFPPLKKK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid KDMCBIHABOK;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid JDDALNJLOHJ;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NIEJNGELALD;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid PNGINHCENJC;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MFEENKEEDEG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IEIEPFBBADN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MICIFMNOLJL;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid NJJMPKAHAHO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid JFJJCANKGJO;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid PHPKJBBIKPC;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FKMLHGEBBIL;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JCBCCKHEEOK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid HNEFBGJGMGE;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid KJGJBLAOFAC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid HMFIIIHJKOM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid PPOCABDJEBK;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid EMCMEHAKDKE;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KBEHFJNPEOF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid KODPLFEPADO;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid HFFBNBBDPFN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NGHDCILLHFO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PNKMLCIMIFN;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KNFLLHFGPCB;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FOOLKDCBFOF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OFDLMKBMAIN;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OCHENJOKCKE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid GHPMKBCCODE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid FMCNNNNMCJO;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid CMBOKDKBPDD;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LIONCFKIFBN;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid KIPPLOMKOGE;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid EJLFKCEPDHL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid BMOIJIFEOIL;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FADLMEEHHGK;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid BBOKNAOJPBA;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid AKGHLCAFFHB;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OFDCHEGEGFP;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid HGHPOKDOPFA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EJPENHLBDDI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid HIJDGOHCJIA;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HAHLGAPKLMM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid KAGGMMKDNIP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ODBJPGNNNBF;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid GPFFCMDKKOH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid PMFMODKPNII;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid DEJNKEOBCJM;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid PPOPNAODDEH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid MPDMEFOFIGE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DFHDEKKFPEF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GMPBIJMODND;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NBCPKMGGHFA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid AEPOHNPEOKK;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid ANNGMFKPNGH;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid IKGNMHEJOML;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NPMBCAAEDCH;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid BOMBDAMHDOI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid CMAEKEFCJII;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid LCBMPDGBIIJ;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid MPHCMNDACPB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid CCGIGDAJIEM;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid LKPCAOLEEKL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid AMKPPAFEAIO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid GFNONEHMOFK;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid GFDOLGPBJJD;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid LIDKACBNAJF;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LPEHPAPGLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DPCDLIADFMP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PNJIPJACPDB;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid JGFMIHEGCOA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GBIAKIJIJJM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid CIHMMLBIBBC;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid DCFIFFJHLLH;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid ODODILMHAMP;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid GOGKDIECCIF;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid GJLBHFOLKJO;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid EBFIEMAJNHG;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid OIJEAFKPOJK;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid GJOAODECDPK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KMJMGEGHNJA;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BNNIJDMILBD;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IHMBAMNOIDM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid LAKPDBGEMGL;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid INOAKKOCLIB;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid FBFOPFHLFCI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PFMDAOEAHHE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PHJOLJHFIBM;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DHHDMKGDNKH;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid COAKBJHEIGP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IJAPILFOPLF;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid CPIJHAIPFCM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GIDGDDKGIDB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid GCGLABNBGEE;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OLFKEAMMLFK;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GBOHEIGGDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid CPFJPPDNHHH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid MEJLCONPNCO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid IKAPLGNHKHA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FNGABHCJHMH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EHIJONKGNGN;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid ECGEELMGNBF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid KIPCPPDOKHN;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FHDDNCHHPKD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid PEKCKDJKILA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DLLICNADKPK;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid EAFIGKDHKBP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid IPBEOOFBAPO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid IABFDLHAHJF;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MPOIMENGPFG;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FCPBDMDLJGH;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid ALAIFMBDDFP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid OFIKPBOGJML;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid JODHNFICKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid LPGNOGCBADO;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid BKGMEFNMMML;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid PIKOBFIBDCE;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid FEGKEIDGHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid IAHGBNIPOME;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FDHDDNKLJON;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid HMPPNIKFBKL;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid AEJPNCBINGL;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid HIGJDEHPOGH;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid GFLBGFLOAIC;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid IPLFOLCPNAB;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PLAAOGHJBCB;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid IDJCIAMKGGK;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid JHDBMBGDJCI;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid KOLKMKOGNAK;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LBHBPMOCPIN;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OFHMHNFBFEP;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JOJHAKKAHPM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid HMDOEPBJMCE;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IJFHBADKJPK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid MFKEEPNGIDE;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AINGNPAJAPH;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid BLMBCNBCKMD;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid FIBHBJCFHON;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid ECACOMPOGKL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LCEMPLBCLDA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid GFGHHNLPMMM;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid BKFAPJPFHOK;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid MANLKKGIAAD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JHCDIEMMOCC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid NFHKIMMOFJN;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LKIJHJNCAAL;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JFGDHKIIBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LADJMCBFBPC;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NPJLMLAHLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid LGLMJHCNHAO;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LOHAADJGBHG;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DPHGNCKCABO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid ELKAIGBBCMN;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid FEJJPGBEGMJ;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EHDLIHIFPOJ;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid CICIKOFGGGF;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid KGFMEPNPPCM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid OLAIJIPEJKB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HNPMLMHCCJK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KNAJNAICNFO;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DKLGAAGOHBC;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid BOJOFECDAJH;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid JJINKLFAJFH;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid HFPNFFJCFBN;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid LKDOPIOJKMP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid PPGKJNFMDIG;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PMKHGLANJIF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KMDIGLFIFFI;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid AILLHFJKAPK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid OCHMADPNAPB;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid DJLPFIOKGFJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid MKHJOKLLIHP;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid HFNELINKBIM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid FEFPJIEMPEL;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BCKAFKNPOPI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid DDNGAIFBGFE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KKOCOMGNHKG;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid BHEOCHKBMEG;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HBKOKDLFKFE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid KCPCHICOBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JNPPMEADOKO;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid LOFDEOJIIDN;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid ABJNDNKFFDK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CONCNPGIDKH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid GNPANONGBDI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid IFFKJBLFAAK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid ODGHNDABEHG;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BEOFOPLCMLL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid MHMDELHBONA;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid ENOMCMNNNOD;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CKHNGJFEPGB;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid PBPELEKBBLO;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KIJNFLNCGMF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FPLNKMAEPGO;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LBLADHCIGLB;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid ODBGMIPOHCA;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KNHINJEOEBP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid PNHHPEEPJHP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DLDBMODHFNA;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NPMOKMPFHIF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid AEMCAIGGIKL;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid PLPFHNPMBNF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid OCMOHFKGHAD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid GDMHJEEBHFO;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MBOFHEOLEPM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GMFOMDHFAIB;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid ENOHPJHLEMN;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NLBPFPBKKMB;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid EPOOMFDDFCP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid BKMAKMDNJPO;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LAJFMJMBNON;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid OMDCEFILGDF;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid ALGCMKBJJOF;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid DCOCIBPKJAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid DGDJMGFOJKG;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid HAMLKPJENNB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid KKGJIPKBPCG;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JKOAPJKKHFB;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GDILHEDBPHI;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IHKFPJOKKIA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid DDBLLKPFKKK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BNCCNIALCON;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid FLBPJLPMLIP;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DALLDMDGBLL;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LKELELPEEML;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid ODCJMAEHOKO;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PHOGONNGAIG;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid AACHHFOGAMH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DMNACFMNNJL;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid IDNBDNPCLNB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid BMFPBICKKBF;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid FMDBKDLENON;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid PDICNBJGILM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PIAECEPCEBF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IFMJMGFKFFH;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid AALAEOFFDBI;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JKKMKGPAIHJ;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid KDGOBDMDPPB;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid POHDHCKKAAI;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DBCAMIBIMLD;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FCNDNLMMBEP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JEFEBGFLLHG;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid ABGEHPIBLAM;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid INDPKOMGEGK;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid IPDKCHEOFKH;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid BIFJGMGJPEN;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid DHJJEEPDNEO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid JOMEDOAFFHI;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JCLBKMMMOAE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BKPMCFKKGFG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid GFKPCGMBMBD;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NPKEBCKPBLO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid AMFFIMPLBCN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid CHFAKDCPBBC;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JDBPLHJJLOK;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid LDLBMFHFHFF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid MNFLFHCODJL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid AFDBNGJPNCN;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid PDGINDOPAKP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid PHLPBLMKEFI;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid MPGLAPFDECH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AKMBEANFEGO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid DFLLHKHLBLD;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LAIKBEIPLOE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CGPCCOPGDLJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid LFEBIHFBGAE;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid LCIGLMLJOEN;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid JLGLHFHMFHA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PICHKPPIBEN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid ACBHANHLEGN;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HKNFCIPBJFF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid IICLNFAHPPD;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HNFLMOBJKGN;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid JEEBECEJKML;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid NCAAEMGGGLE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid CFFMHBOPMOM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid FMEOCPGOFLJ;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid PBFDDMPNJJN;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid PODNFAJMILI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid JFBMOMFACBO;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid JKIIJIHHCCJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NHKOHFPIHNK;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EJNPEDILMMI;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid KPNBIJFHEID;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MLKPPBAGODH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid OKJHIPDFIJK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid BAGJDJKOBMG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LIKPHINGDBM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid HBMNMFKEFMP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NCCNOHNDAPG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid MIJBPOIKMEB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BLKHJPNGEML;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid IGCKFENOBFK;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid KJJPBLBLPHM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid IIMDJHDLBEL;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HIPNLKEJNKE;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid CFNFBAKFAMP;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid IAAPBFIBJFJ;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid HFIGBAEAAJK;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OMNLDPDJLMH;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid GHCEBJBFLDK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HLECFLPAAHB;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KMBCOECOAAP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid GAGCEMIJEKE;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OHOKHOKKHBF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FHEIDHBPHDN;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid GKMIMHLMMDI;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid LBPCGLFEFIO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid DNAJEJFODDI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DFPCAPMEBNI;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid IFMDKCAFACH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MAMILHHGONA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DNACEOOJEOB;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PBEHGKGAPBP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid AIPEEFIIGBF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid EJDHNAAMDPG;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CAPHBGCHNME;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid DBOEHMEDEPH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid GDLLEBLKKAF;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid KOMBFDJMFOD;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DDLAEFALGPP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid ODNPGKPHHLK;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid KELNNMEDDOP;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid DEDAJOIBHMK;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid IIMFDPFFKII;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid LIOGFFPMFPB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CHBEDEGBNJM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid CGONOJBEMCB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid DLDMJGCPCID;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DNNKELFJFAG;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JGHICDJHMAA;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid APIFIKOHHJH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid ADOCNLBGDOP;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid GLIJGPPPKFA;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid HEHONMOJEPK;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid EONMFJOKIFP;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JJLLMFLAKHB;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid OKHIBINKFBD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid CGNLHMKMHMI;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid AEJKNBCHHKG;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid FOHLNFDHAGM;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid DLHKIKIGMPP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid HHIADGJAMCB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid INDIIGKFHMM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid OOLLKBPJNCE;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid DLKJFIGANBL;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid BAMKODCCBAO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid KONNEHMHNGE;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid GAHEPHBFDCM;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid HOMEKOPBGPH;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid PDBEMAABNCO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid MAHOKIJLNFM;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid BDHKEEFODIL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AKPIAKIMKPE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid HHGOKNIFHIE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid CIOPGLCGCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MLIAIBAKPAF;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid IAAOCOBJGFE;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GAEMHOHJJCL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid CMMOPHPFLEC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid KJIONCJJPNB;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CAKPEAFFCML;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid ELBFPLKMHHO;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid JIJBJLPGIKC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DDKHMBGDDHA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid LFMJINOPIPP;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid OEOFMLDHPLB;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PFFNPAPHHDF;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid ADCEEBOKIIE;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BIICJPNOPCD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid FOAGDGPJHEL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid FEJNAGCPLHH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LMENDJHHGII;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid KGEKLLJAEEM;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KNKOCFICKDP;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CMLKIBIECLA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DMCNPCKLDAN;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid EHNFPBLKACM;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid BBIKJGONAMF;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HNOAMMKLFMC;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid EMIKGKAIENP;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid IELMHOOOKLA;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid JNICHAEFEPH;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NDEGFAHJBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PGEHGMJDECL;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid NJEKOKIKAPB;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid ABBILOFHILI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid LEBNEGMHHDO;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid JPENFICNBDA;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DDAEMLEJMAN;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid AHBJPLKCAAI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid MPCBCFOKBDN;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid EFLHLMGIKMA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JHIEKKHNPNF;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid ICEBKFKDPBE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid KHGNLPOCEFD;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid ODCKLEALKNN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JPDJABLNJHC;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid NOKPBHIENFK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid OIKFDNMGKNL;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid AJIOOBAPMKP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid LOPLIMPHCKA;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid EFMLJBDHPMI;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CABODLDILNL;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid OMMFHFGGJGB;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IHBKBFOPJKL;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid HBAHGBAEHMA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LOIOLPNPCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid IAAFKFHPJHE;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid HIKDABGHKFG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid JNKPOOKOOMF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BPBDGOJHIIF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid JAJFKAGBBKJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid DKBLDNICHNG;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FLDHGMBLEKF;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MDEFJNKEAKC;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid ANPCCDPHMPD;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GDIAPONPGJN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FPKDCGLBGGC;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid DOAANCFLJLH;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid OABFCAPAOFF;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OCIJLLPCKCB;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BOHIIMJIAHC;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid EDMEKHLFIKP;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid MJFNEEHFIJM;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FEAALMKLPNL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid NLBAAIICAJI;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid KJOMKNJBHCL;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid MIBIJLGBIJF;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FGOJKHEIMJA;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid INAKPCPONFE;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MOEOOCLKGML;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid PNGPICFNOCM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DCDJDFAGADP;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OIIEGKCMKHM;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OOJGDJPALNK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LOHHIAHALPB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CADJHJKKGIH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid NAFOMJACKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JDDIGJEDKAH;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HGBPBDAHLBK;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid PCLBLCDGNGC;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid ACPEPBLGBCA;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid NGMDGEOGKOC;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid GCFMGMHKCDK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CDJJDOCABHF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid CJFCHNNIDMM;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EPPLNJHIPAN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MFKEPDEMFCP;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid KEIJNIHKCIK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid CIEEFOMKJHN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid JFNLMKDNGJC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid PIFIEKPBJGB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IOBCJCAGGCC;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid CHMPDDJIKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KJHLKLPDEGO;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid OFAMOCIBBOP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MNADGEKNOMJ;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid HGAODNEMAOG;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid CKCMADDBJMG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LBPJNBOKCCO;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid PJAGBOCOEAK;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid EOGLOPFHMPJ;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GDMEOHCKBKF;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid MACOIMOKMAH;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OJJJENJBNEL;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid FCKHLNMFEAL;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid GJOPBPAGLMK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid EMJAOKBKEIP;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid ELBPMKHMBCB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LHFJJNFCONG;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid FFDOJJPDIAF;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid JOIPHKPELIO;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid LLNOKCGECAA;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid OCKLIAJNANA;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid DCALAPFAHOA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PLBDGKHKAAN;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid CPHKPIELPAL;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid COIIDINMCOI;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid FHMKLHPAFGL;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid CIFMBMAJLKH;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid BIKKLOIDIPB;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PALPNCJLHCI;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GHCHMDJGIBC;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid LEEHNONJHDP;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CMEHKPPGMAP;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid INDOLJAHPHK;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DDMFJDKAKOK;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid OAEAKDHLMBP;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid EDHEFLHKEKF;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid DAEGEHEHOFH;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid AACGDKGHMOO;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid AGDFEILBHFC;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid LOIJNOHCIHN;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DACHLIDHOOP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid BDODMBABKIA;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GPONDAHMAKK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid AOMMKJPFLHA;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid OIHOBCBOFDN;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DOMGBKEOABC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid LPJJPJAONIG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid AGCMNIDFMIC;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid NJAIMEKLDGK;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid FFOPJLMJBMC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid OJDBJLGEHND;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KNKPLBBHCOD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid DMCELJHNOIK;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid LGACGJOOGID;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid GCHKECPCAKM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid JPGPNJDBDEG;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid MAFONPMGGDI;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid BDLFLNGOGMC;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid BPFFAFMLNCJ;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid HMJLLLIMFEG;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid PENPPLDMINA;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid KCOJIGNCOAD;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid EOEFIFHJGJA;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IMKOPDLCGFE;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid AMPLAGADNDO;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid HLBACLAIBPK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid HBLCNALNLAA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid JEDLEDAJNGP;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid EOCOLAKNDPB;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid CCHMIAAOKLL;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IDLEAEAFNNE;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid EEOAJKPGBFM;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid JMBNGKGBJBB;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid EGAADFCADLF;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid FLIIOEKOOGB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid MHKEHAKEHPM;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid HCFEMGLANGF;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid LPLMABFBBPB;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid KFKNCNPCOGC;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid NALPIJMMLOL;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DHLEMIMLEFM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid JJKJCMCHOKK;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid BCMJFLDFPNH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid KJABCCDMHFF;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid ICKGPHNKMPI;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid HONJEHHEMNG;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid DBCHEIGJHCD;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid GOFKMIAGDCK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid FOJENOLCKDC;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid JJCHBBBCAKJ;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid GKGAJDMIEAD;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid IDEGHGDJHGE;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid BHPMODLLPGN;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid KAIFELACMNF;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid CLEFKDGCPPA;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid ABJIHJJICFA;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid PMGJLGLIOMA;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid CNOMLLDOLDH;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid DMNIDFHELOI;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid GNJGPIFCDLM;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid PKHGPCJGGNJ;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid GCPOPPMDPIL;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid BNEAINFOHFK;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid IIFBIHMBAFA;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid PNIGPIINJFD;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid CLIGECDAJID;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid JEMOONBDOKP;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid HGNEHFIOBHM;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid ENKPGHJLKGO;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid GBLECNBCMHG;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid OHHBLBBPNEL;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid MEJPKJKLENJ;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid NJLDMFMPAOF;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid FLMCMOMOBPK;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid NKJJKGIKACC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid BJDPPKCNPOA;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid MDMEDOPCLOI;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid MKNOLFNJBDN;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid BEOKJAPLCLE;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly Dictionary<Guid, INEMFMMFIIK> LAAMJDCHPHM;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private static readonly Dictionary<INEMFMMFIIK, Guid> NODAOJGAOCD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, INEMFMMFIIK> MKHPDNNPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA18E0", Offset = "0x7AA00E0", VA = "0x187AA18E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<INEMFMMFIIK, Guid> BMOGFHCDIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA1930", Offset = "0x7AA0130", VA = "0x187AA1930")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MNFCLIIOBLD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1DC0", Offset = "0x7AA05C0", VA = "0x187AA1DC0")]
	public static bool FJCEIDPCADN(COPBPFOHIKO KHDBJELDODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1A10", Offset = "0x7AA0210", VA = "0x187AA1A10")]
	private static bool FJCEIDPCADN(DOFEKKANHKF HGAAJHCCLOF, COPBPFOHIKO KHDBJELDODN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LOLIBOAADLP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(HDEHPCNDLPP NFNBKNAJBPN, [Out] Dictionary<int, int> MKCBNCLNPPO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FHIIJIJJHKM AJPNAIELBKN, BKABIIFNONG FFIHBMCALMM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct ADGNCIGMMJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly LNOMLFPCEKA MLPGBFHPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly IEnumerable<PEBBACKHDPF> NDEHFNJADIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<PEBBACKHDPF> FMHCKPBAGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly NLPIAAOFKEO<PAJOPNAJIFC> CJADPFIJCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> LMODOBHCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly NDPKBBLDKKI CKFAOCDIMMD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KNLKCDALHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D400", Offset = "0x7A8BC00", VA = "0x187A8D400")]
	public ADGNCIGMMJG(LNOMLFPCEKA GNHNJLPKMFH, IEnumerable<PEBBACKHDPF> EIJIJJNENOI, IReadOnlyList<PEBBACKHDPF> JFCLOHKAMKL, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> AAJAHLLFBPH, NDPKBBLDKKI HLJMOPLENFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BAPHILOEFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly LNOMLFPCEKA MLPGBFHPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<PEBBACKHDPF> CHBGFKKBKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly NLPIAAOFKEO<PAJOPNAJIFC> CJADPFIJCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> LMODOBHCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly ByteString MMJNCFDJMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly NDPKBBLDKKI CKFAOCDIMMD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D470", Offset = "0x7A8BC70", VA = "0x187A8D470")]
	public BAPHILOEFCJ(LNOMLFPCEKA GNHNJLPKMFH, NLPIAAOFKEO<PAJOPNAJIFC> LAPNHIHIGLC, IReadOnlyList<CMDPIJDKPHC<KGLBPIDLJAB>> AAJAHLLFBPH, ByteString JGGLFPNHAPE, IReadOnlyList<PEBBACKHDPF> FCILMLJNHOE, NDPKBBLDKKI HLJMOPLENFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PPKBIHHKECD : OFGAPOFKLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly Guid HOFECIDHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly Dictionary<Guid, Guid> BGBFHIDBILE;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x488B450", Offset = "0x4889C50", VA = "0x18488B450")]
	private PPKBIHHKECD(Guid IJMMLBLOIDN, Dictionary<Guid, Guid> BGBFHIDBILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2320", Offset = "0x7AA0B20", VA = "0x187AA2320")]
	public static PPKBIHHKECD CJOJELENPLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2630", Offset = "0x7AA0E30", VA = "0x187AA2630")]
	private static Dictionary<Guid, Guid> FCEGIBDCMDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7AA26E0", Offset = "0x7AA0EE0", VA = "0x187AA26E0")]
	public static PPKBIHHKECD KGDADLBPJJG(IReadOnlyDictionary<Guid, Guid> GGBFBJAOFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2030", Offset = "0x7AA0830", VA = "0x187AA2030")]
	public static PPKBIHHKECD CFDGCPFBJHB(IEnumerable<KeyValuePair<Guid, Guid>> GGBFBJAOFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA26F0", Offset = "0x7AA0EF0", VA = "0x187AA26F0")]
	public Dictionary<Guid, Guid> KLNBLFKONII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
	public Dictionary<Guid, Guid> EPAGMENICLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2810", Offset = "0x7AA1010", VA = "0x187AA2810")]
	public void OIHLAKEIFNH(Guid GGBFBJAOFOK, Guid EFGFBKMBCFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA23B0", Offset = "0x7AA0BB0", VA = "0x187AA23B0")]
	public void EJONHEAMEID(IReadOnlyDictionary<Guid, Guid> CNNJPLPGAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1E70", Offset = "0x7AA0670", VA = "0x187AA1E70")]
	public Guid AJEDFPHBPIK([In] Guid GGBFBJAOFOK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2770", Offset = "0x7AA0F70", VA = "0x187AA2770")]
	public Guid LBNDDGMBJFF([In] Guid GGBFBJAOFOK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1FC0", Offset = "0x7AA07C0", VA = "0x187AA1FC0")]
	public bool BMAENDMGFPO([In] Guid GGBFBJAOFOK, [Out] Guid EFGFBKMBCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7AA1FC0", Offset = "0x7AA07C0", VA = "0x187AA1FC0", Slot = "4")]
	private bool MGGMGCJENCK([In] Guid GGBFBJAOFOK, [Out] Guid EFGFBKMBCFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DCPMLMBGGEJ
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
public sealed class FHAADBMLNBB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JDBFOKFHDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public LNOMLFPCEKA staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JDBFOKFHDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AB80", Offset = "0x7A99380", VA = "0x187A9AB80")]
		internal NLPIAAOFKEO<AGEMPNFBJCE> NBHBKOEJEJN((NLPIAAOFKEO<PAJOPNAJIFC> GraphId, NLPIAAOFKEO<KGLBPIDLJAB> NodeId) i)
		{
			return default(NLPIAAOFKEO<AGEMPNFBJCE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly GKFCELPELJB<AGEMPNFBJCE, int?> CBGPGBAMEJI;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly long NFDHGBANDMG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D720", Offset = "0x7A8BF20", VA = "0x187A8D720")]
	public static (long, long) PJKDBHNNKBF(LNOMLFPCEKA NKHFOLAJEDG, NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D600", Offset = "0x7A8BE00", VA = "0x187A8D600")]
	public static long FCKABDECOAE([In] ReadOnlySpan<NLPIAAOFKEO<AGEMPNFBJCE>> IBBMALNFAGM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A8D4E0", Offset = "0x7A8BCE0", VA = "0x187A8D4E0")]
	private static long DGAOCLNEDKP()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ACJMNGHHGPM
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public static readonly HashSet<INEMFMMFIIK> OHJJHHHCFNL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JFIIDBADHCP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LCEIIEJABPC : IEnumerable<PEBBACKHDPF>, IEnumerable, IEnumerator<PEBBACKHDPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private PEBBACKHDPF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private IBOGIMIPOGO spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public IBOGIMIPOGO <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private ABPOFGCDLBB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public ABPOFGCDLBB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PEBBACKHDPF System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE73320", Offset = "0xE71B20", VA = "0x180E73320")]
		[DebuggerHidden]
		public LCEIIEJABPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC890", Offset = "0x7AAB090", VA = "0x187AAC890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AACB10", Offset = "0x7AAB310", VA = "0x187AACB10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC9A0", Offset = "0x7AAB1A0", VA = "0x187AAC9A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PEBBACKHDPF> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC9A0", Offset = "0x7AAB1A0", VA = "0x187AAC9A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D780", Offset = "0x7A9BF80", VA = "0x187A9D780")]
	public static IBOGIMIPOGO PBBCLHMKPCL([In] BAPHILOEFCJ GNPCGFLAINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D600", Offset = "0x7A9BE00", VA = "0x187A9D600")]
	public static IBOGIMIPOGO PBBCLHMKPCL([In] ADGNCIGMMJG GNPCGFLAINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D1F0", Offset = "0x7A9B9F0", VA = "0x187A9D1F0")]
	private static HashSet<CMDPIJDKPHC<KIHBEDJDDFP>> NFOHKEFMHHO(IReadOnlyList<PEBBACKHDPF> GDOKGOIHILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D8F0", Offset = "0x7A9C0F0", VA = "0x187A9D8F0")]
	private static void PPLHLHINEPM(IBOGIMIPOGO CGBFOCMHCAM, [In] ADGNCIGMMJG OJCBLLDGPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BE80", Offset = "0x7A9A680", VA = "0x187A9BE80")]
	public static HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ> MIJEGICAJBI(IBOGIMIPOGO CGBFOCMHCAM, ABPOFGCDLBB CAINJJHCEID, PPKBIHHKECD? PFPNACHGHPN, bool IMOCJIJLNFC)
	{
		return default(HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A9ABF0", Offset = "0x7A993F0", VA = "0x187A9ABF0")]
	[IteratorStateMachine(typeof(LCEIIEJABPC))]
	private static IEnumerable<PEBBACKHDPF> BHAIKAEMGDA(IBOGIMIPOGO CGBFOCMHCAM, ABPOFGCDLBB CAINJJHCEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7A9D590", Offset = "0x7A9BD90", VA = "0x187A9D590")]
	private static void NIJGFFJFACD(IBOGIMIPOGO CGBFOCMHCAM, ABPOFGCDLBB CAINJJHCEID, IReadOnlyCollection<ByteString>? BEGKACGJGLO, IReadOnlyCollection<ByteString>? KEFBHEAODDP, IReadOnlyCollection<ByteString>? NDCAHOKFAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A9AD00", Offset = "0x7A99500", VA = "0x187A9AD00")]
	private static bool DODPDCCABLB(IBOGIMIPOGO CGBFOCMHCAM, FHIIJIJJHKM AJPNAIELBKN, ABPOFGCDLBB CAINJJHCEID, [Out][NotNullWhen(false)] string? LKNKJJBHDKO, [Out] Dictionary<int, int> MKCBNCLNPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B390", Offset = "0x7A99B90", VA = "0x187A9B390")]
	private static Dictionary<Guid, DOFEKKANHKF> JMNFLMGEFMH(IBOGIMIPOGO CGBFOCMHCAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BDF0", Offset = "0x7A9A5F0", VA = "0x187A9BDF0")]
	private static void LBLPAJHGJEB(bool CFACEGOKIHJ, PEBBACKHDPF GIKOLFBJMJH, PPKBIHHKECD CPFCGOKNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7A9BB20", Offset = "0x7A9A320", VA = "0x187A9BB20")]
	private static void KLBKELEBCEH(PEBBACKHDPF GIKOLFBJMJH, Guid OLBCGDKCLDF, OFBCOGHJAOI? CLNKHOIMBOB, Dictionary<Guid, DOFEKKANHKF> AMBBGDDOJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A9B670", Offset = "0x7A99E70", VA = "0x187A9B670")]
	private static void KJMIAAFKHDB(IEnumerable<PEBBACKHDPF> PEFNKCJIPKA, IReadOnlyCollection<ByteString> BEGKACGJGLO, IReadOnlyCollection<ByteString> KEFBHEAODDP, IReadOnlyCollection<ByteString> NDCAHOKFAMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ABPOFGCDLBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public bool CFACEGOKIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public NDPKBBLDKKI HLJMOPLENFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public OFBCOGHJAOI? CLNKHOIMBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public OFBCOGHJAOI? FBJFABBAIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public LNOMLFPCEKA HMGGPFMOMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public DCPMLMBGGEJ DJBIBDDIHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public LOLIBOAADLP LCHNIOBLBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public CMDPIJDKPHC<PAJOPNAJIFC> MPAKIJLKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public OGLLKKPOEEN AJKCONNEOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public List<PEBBACKHDPF> NCAPNJHEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public FIGGFBFOHNG PGLDOFMHGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public MEHIKOKIHML HNAHKLNDFHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OFBCOGHJAOI
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private const float NJFAFJCEMJE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Vector3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public float EGLHBCAIJLF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 HMDJDCPKJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AADAF0", Offset = "0x7AAC2F0", VA = "0x187AADAF0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS ELDBOBFOODF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE010", Offset = "0x7AAC810", VA = "0x187AAE010")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x135BA40", Offset = "0x135A240", VA = "0x18135BA40")]
	public OFBCOGHJAOI(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float EGLHBCAIJLF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE150", Offset = "0x7AAC950", VA = "0x187AAE150")]
	public OFBCOGHJAOI(UniformTRS HFODOKDFPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7AADD90", Offset = "0x7AAC590", VA = "0x187AADD90")]
	public static OFBCOGHJAOI HJNJHBBOICP(OFBCOGHJAOI DFPCBMGPBFO, OFBCOGHJAOI ELMGPNFMNKO)
	{
		return default(OFBCOGHJAOI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AADBF0", Offset = "0x7AAC3F0", VA = "0x187AADBF0")]
	public static OFBCOGHJAOI FGIKKMMHFBO((Vector3, Quaternion, float) NFNBKNAJBPN)
	{
		return default(OFBCOGHJAOI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7AADC10", Offset = "0x7AAC410", VA = "0x187AADC10")]
	public static OFBCOGHJAOI FGIKKMMHFBO(Matrix4x4 JJGLLBPBCGG)
	{
		return default(OFBCOGHJAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE0C0", Offset = "0x7AAC8C0", VA = "0x187AAE0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD980", Offset = "0x7AAC180", VA = "0x187AAD980")]
	public OFBCOGHJAOI AJCDICDCGDB(Matrix4x4 POFBAOBKAGL)
	{
		return default(OFBCOGHJAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE050", Offset = "0x7AAC850", VA = "0x187AAE050")]
	public static OFBCOGHJAOI NFBKJJOGOFI(Vector3 NCGKJMOKFAF)
	{
		return default(OFBCOGHJAOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AADA60", Offset = "0x7AAC260", VA = "0x187AADA60")]
	public readonly CLHPMEOLFDE CBIFHGFCFCO()
	{
		return default(CLHPMEOLFDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IGAEIGBKLOC
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EIBFMDLOMGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly FHFDFPBHEDO CHECJDOGKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly IGEMMGEDLOA HNNLDDDDPBA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
	private EIBFMDLOMGJ(FHFDFPBHEDO KJHADNKKPBJ, IGEMMGEDLOA BKJFBHOKLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6980", Offset = "0x7AA5180", VA = "0x187AA6980")]
	public PBBGHPPLFHN KKNDGPNBLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6760", Offset = "0x7AA4F60", VA = "0x187AA6760")]
	public static HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ> CJOJELENPLJ(ENHECPFIADM<OLONILFLODF> BKJFBHOKLGD)
	{
		return default(HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6810", Offset = "0x7AA5010", VA = "0x187AA6810")]
	public static HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ> CJOJELENPLJ(PBBGHPPLFHN BKJFBHOKLGD)
	{
		return default(HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7AA68C0", Offset = "0x7AA50C0", VA = "0x187AA68C0")]
	public static HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ> CJOJELENPLJ(string CLIOGHKIDNK)
	{
		return default(HCGBMJDNFKJ<PPKBIHHKECD, EIBFMDLOMGJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum FHFDFPBHEDO
{
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FJPFPPMKNLO : IDisposable, DFJCBJNFNEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private NativeList<OFEAEHKGGHH> PIEHIJCBJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private float EOLFHDIOPEH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MGFGEDENDIF OMAELGJELAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(MGFGEDENDIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EOPABMABJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69FCE40", Offset = "0x69FB640", VA = "0x1869FCE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IAPIPKGOAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69FCE50", Offset = "0x69FB650", VA = "0x1869FCE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<MEEEIJDJBDO> FELPBGCDOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KJPOFDKAHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA390", Offset = "0x7AA8B90", VA = "0x187AAA390", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float GBMDCOCIFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA9BA0", Offset = "0x7AA83A0", VA = "0x187AA9BA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB5E0", Offset = "0x7AA9DE0", VA = "0x187AAB5E0")]
	public FJPFPPMKNLO(MGFGEDENDIF ENMPGGCMLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9CE0", Offset = "0x7AA84E0", VA = "0x187AA9CE0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAACE0", Offset = "0x7AA94E0", VA = "0x187AAACE0")]
	public Vector3 LECANOODLJJ(int IGNBGDBAAAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9E30", Offset = "0x7AA8630", VA = "0x187AA9E30", Slot = "6")]
	public Quaternion FFGCOGALGGE(int IGNBGDBAAAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9B00", Offset = "0x7AA8300", VA = "0x187AA9B00", Slot = "5")]
	public Vector3 DBGPAOMJPPG(int IGNBGDBAAAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9DD0", Offset = "0x7AA85D0", VA = "0x187AA9DD0", Slot = "7")]
	public float ELOFCKFFIED(int IGNBGDBAAAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA3D0", Offset = "0x7AA8BD0", VA = "0x187AAA3D0")]
	public void KMEDGLEPKBH(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB, bool CNOLCMPANDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB3D0", Offset = "0x7AA9BD0", VA = "0x187AAB3D0")]
	private bool PGFENMAKCJH(int PALKGIMEKML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9F60", Offset = "0x7AA8760", VA = "0x187AA9F60")]
	public void GBNJEJCNHHD(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9D40", Offset = "0x7AA8540", VA = "0x187AA9D40")]
	public void EEOHGJGFOKJ(int PALKGIMEKML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA240", Offset = "0x7AA8A40", VA = "0x187AAA240")]
	public void KLHLIFOJPOI(int PALKGIMEKML, Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB430", Offset = "0x7AA9C30", VA = "0x187AAB430")]
	public void PJIJHGLHHHM(int PALKGIMEKML, float3 NCGKJMOKFAF, quaternion PMHMEKBKJJA, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB1B0", Offset = "0x7AA99B0", VA = "0x187AAB1B0")]
	public void LKCLCDGKNLK(int PALKGIMEKML, Vector3 NCGKJMOKFAF, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7AAA0E0", Offset = "0x7AA88E0", VA = "0x187AAA0E0")]
	public void IGCEMMNGPEB(int PALKGIMEKML, Vector3 GLANACDLEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9290", Offset = "0x7AA7A90", VA = "0x187AA9290")]
	public static Quaternion BOOIILAMLPM(Quaternion MODLABAKDKE, int PALKGIMEKML, float HNFIIFEOPPH, DFJCBJNFNEI BMAPFFOALKH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8E00", Offset = "0x7AA7600", VA = "0x187AA8E00")]
	public Bounds BOHLJHPAACA(Transform POFBAOBKAGL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA9A90", Offset = "0x7AA8290", VA = "0x187AA9A90", Slot = "10")]
	public virtual void CFEEKFEKMBA(bool HFMALAJGEAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB300", Offset = "0x7AA9B00", VA = "0x187AAB300")]
	public NativeList<OFEAEHKGGHH> MDHHBIDPGDE(float BDMNEPGOMEF = 1f)
	{
		return default(NativeList<OFEAEHKGGHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MEEEIJDJBDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public float3 COFBFGOOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public float FFLBHMOOMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public quaternion FBLKLJCKLDE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD260", Offset = "0x7AABA60", VA = "0x187AAD260")]
	public MEEEIJDJBDO(Vector3 NANJGAHEDND, Quaternion MODLABAKDKE, float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD1A0", Offset = "0x7AAB9A0", VA = "0x187AAD1A0")]
	public Quaternion PCIEAKMABPK(Vector3 ELEEIMOLKDP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AACEB0", Offset = "0x7AAB6B0", VA = "0x187AACEB0")]
	public MEEEIJDJBDO OBDFCKDFJHB(Vector3 MCLAJKMGIPE, Vector3 LCGHCNJEOFB, Vector3 GIOMPDHGCJO)
	{
		return default(MEEEIJDJBDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7AACD10", Offset = "0x7AAB510", VA = "0x187AACD10")]
	public DNPKMKHEIBC IHKNOFMJAJD(Vector3 ELEEIMOLKDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BCFCHEHEAGC : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2C30", Offset = "0x7AA1430", VA = "0x187AA2C30", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2F90", Offset = "0x7AA1790", VA = "0x187AA2F90")]
	private void EFGFDIEEFEL(Dictionary<Guid, Guid> GAIFFFKFGLJ, NAIEONPDBCM CONLABFIGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2CB0", Offset = "0x7AA14B0", VA = "0x187AA2CB0")]
	private void EFGFDIEEFEL(Dictionary<Guid, Guid> GAIFFFKFGLJ, ODJFAHFHAJP OHHHEEJLAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2D10", Offset = "0x7AA1510", VA = "0x187AA2D10")]
	private void EFGFDIEEFEL(Dictionary<Guid, Guid> GAIFFFKFGLJ, KHFFMEPGEDF CKILPFALACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public BCFCHEHEAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NKNDMPPBKOP : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD8D0", Offset = "0x7AAC0D0", VA = "0x187AAD8D0", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NKNDMPPBKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class AEDCHAANFEL : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2890", Offset = "0x7AA1090", VA = "0x187AA2890", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AEDCHAANFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KIMMENFLIDC : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC730", Offset = "0x7AAAF30", VA = "0x187AAC730", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KIMMENFLIDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class IHNJJCBBMHK : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AABA40", Offset = "0x7AAA240", VA = "0x187AABA40", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IHNJJCBBMHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class IEAGNOILHIO : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB900", Offset = "0x7AAA100", VA = "0x187AAB900", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IEAGNOILHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class HNEIBJNOFNE : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB770", Offset = "0x7AA9F70", VA = "0x187AAB770", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HNEIBJNOFNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PLBEHPGDMPA : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7AAE400", Offset = "0x7AACC00", VA = "0x187AAE400", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PLBEHPGDMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JFJHBAHELMO : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC580", Offset = "0x7AAAD80", VA = "0x187AAC580", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JFJHBAHELMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LLFDJAEFDFP : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7AACB60", Offset = "0x7AAB360", VA = "0x187AACB60", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public LLFDJAEFDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GILLKBOIFFJ : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB670", Offset = "0x7AA9E70", VA = "0x187AAB670", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GILLKBOIFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FCMLJFOMNLH : HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public static readonly FMHGIIIIJIH ICOGDILKNBA;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA7BB0", Offset = "0x7AA63B0", VA = "0x187AA7BB0", Slot = "4")]
	public void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FCMLJFOMNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct COPBPFOHIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public FHIIJIJJHKM JLNEBEJFOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public CKPJMHLMLJF DPLDPPKJEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public Dictionary<int, int> MFJLIIPEOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public Dictionary<Guid, Guid> NGPCMIGLCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public MEHIKOKIHML HNAHKLNDFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public bool IMOCJIJLNFC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HNJCMEBNJHP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEOOIGEIMLO(MHBONDKJCMN IDCBNAFLOGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FIGPJLOMPAN
{
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private static readonly HNJCMEBNJHP[] CLNECJIAHOI;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA80B0", Offset = "0x7AA68B0", VA = "0x187AA80B0")]
	public static void JFFKGIAMHIC(PEBBACKHDPF NFNBKNAJBPN, PPKBIHHKECD DOOFKMDCPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA8330", Offset = "0x7AA6B30", VA = "0x187AA8330")]
	public static void NLIFNGMDJII(PEBBACKHDPF? NFNBKNAJBPN, PPKBIHHKECD LIDMLEIEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7AA85C0", Offset = "0x7AA6DC0", VA = "0x187AA85C0")]
	public static void ONIOBKLNOEP(PEBBACKHDPF? NFNBKNAJBPN, PPKBIHHKECD CPFCGOKNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7AA7CE0", Offset = "0x7AA64E0", VA = "0x187AA7CE0")]
	public static void FJCEIDPCADN(MHBONDKJCMN IDCBNAFLOGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MHBONDKJCMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public FHIIJIJJHKM BILPBNNMEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public PEBBACKHDPF GIKOLFBJMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Dictionary<int, int> MFJLIIPEOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Dictionary<Guid, Guid> NGPCMIGLCKO;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AAD2E0", Offset = "0x7AABAE0", VA = "0x187AAD2E0")]
	public Guid DMBGNMNHKJH(Guid BGPPHEMBCAA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MEHIKOKIHML
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int CKBAHGKJLNE, [Out] Guid DENEKFDCKBP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class EEHGIOKIEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private static readonly ProfilerMarker EDHGGBEIPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<string> OELGIPOIKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly Dictionary<long, int> CHCIKEFFOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> EPBCAJHFGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> HILPBLCHKPB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> BDIBDMCIAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> JFMPMMLCHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> MAACJEEIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4B00", Offset = "0x7AA3300", VA = "0x187AA4B00")]
	public static void GJFAOGHAKLK(IBOGIMIPOGO NGMKJNFIHGG, AHDMIGLMAJL KCCGDPBOKFK, PPKBIHHKECD FMMMNEDGNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6280", Offset = "0x7AA4A80", VA = "0x187AA6280")]
	public static EEHGIOKIEIO KNFHOEKHCOD(IOKANKGCBIH PDNEBCPKAAP, [Optional] AHDMIGLMAJL? KCCGDPBOKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3940", Offset = "0x7AA2140", VA = "0x187AA3940")]
	public static EEHGIOKIEIO EIFLDHHPEAJ(IBOGIMIPOGO JIBMOKNLPNN, [Optional] AHDMIGLMAJL? KCCGDPBOKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3560", Offset = "0x7AA1D60", VA = "0x187AA3560")]
	public static EEHGIOKIEIO AMCLPPHDKCA(IEnumerable<string> OELGIPOIKJK, IDictionary<long, int> HPHKLFHMHMI, IReadOnlyCollection<Guid> HILPBLCHKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6600", Offset = "0x7AA4E00", VA = "0x187AA6600")]
	private EEHGIOKIEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6430", Offset = "0x7AA4C30", VA = "0x187AA6430")]
	private EEHGIOKIEIO(IEnumerable<string> OELGIPOIKJK, IDictionary<long, int> HPHKLFHMHMI, IReadOnlyCollection<Guid> HILPBLCHKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3D20", Offset = "0x7AA2520", VA = "0x187AA3D20")]
	private void ENPOKHDHGPA(IOKANKGCBIH PDNEBCPKAAP, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4550", Offset = "0x7AA2D50", VA = "0x187AA4550")]
	private void ENPOKHDHGPA(IBOGIMIPOGO JIBMOKNLPNN, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5B10", Offset = "0x7AA4310", VA = "0x187AA5B10")]
	private void HADPECKPDOE(ByteString? JGGLFPNHAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AA39C0", Offset = "0x7AA21C0", VA = "0x187AA39C0")]
	private void ENPOKHDHGPA(JLGDGBCLLFJ? PNDCHGJLEGG, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4770", Offset = "0x7AA2F70", VA = "0x187AA4770")]
	private static void GJFAOGHAKLK(JLGDGBCLLFJ? PNDCHGJLEGG, AHDMIGLMAJL KCCGDPBOKFK, PPKBIHHKECD FMMMNEDGNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA58A0", Offset = "0x7AA40A0", VA = "0x187AA58A0")]
	private static void GJFAOGHAKLK(MPFOGNHLCKF? GDFCBMOFMFN, AHDMIGLMAJL KCCGDPBOKFK, PPKBIHHKECD FMMMNEDGNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA4340", Offset = "0x7AA2B40", VA = "0x187AA4340")]
	private void ENPOKHDHGPA(MPFOGNHLCKF? GDFCBMOFMFN, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3760", Offset = "0x7AA1F60", VA = "0x187AA3760")]
	private void BANDJKAEIGL(Guid? BGPPHEMBCAA, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AA3F40", Offset = "0x7AA2740", VA = "0x187AA3F40")]
	private void ENPOKHDHGPA(PEBBACKHDPF? GIKOLFBJMJH, AHDMIGLMAJL? KCCGDPBOKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5460", Offset = "0x7AA3C60", VA = "0x187AA5460")]
	private static void GJFAOGHAKLK(PEBBACKHDPF? GIKOLFBJMJH, AHDMIGLMAJL KCCGDPBOKFK, PPKBIHHKECD FMMMNEDGNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6300", Offset = "0x7AA4B00", VA = "0x187AA6300")]
	private void LBJLJJJELCA(string? OEKMPKOLFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6100", Offset = "0x7AA4900", VA = "0x187AA6100")]
	private void JDJECKCFAAE(long PPDNIIFPKHP, Guid BJDCNLDCGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7AA61D0", Offset = "0x7AA49D0", VA = "0x187AA61D0")]
	private void JDJECKCFAAE(FNOPNMNIGKE? JPEOJCBJOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6220", Offset = "0x7AA4A20", VA = "0x187AA6220")]
	private void JDJECKCFAAE(EPONLKDMDDB? JPEOJCBJOFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ENILAPIFOEE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class MOBJEPLDNOK : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private readonly IEnumerator<DictionaryEntry> GDPKJELKNKD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry LLLJLEOIGKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD500", Offset = "0x7AABD00", VA = "0x187AAD500", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object FIEPPEJGGLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD5D0", Offset = "0x7AABDD0", VA = "0x187AAD5D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object GDCDOMLHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD680", Offset = "0x7AABE80", VA = "0x187AAD680", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD420", Offset = "0x7AABC20", VA = "0x187AAD420", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
		public MOBJEPLDNOK(IEnumerator<DictionaryEntry> GDPKJELKNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD380", Offset = "0x7AABB80", VA = "0x187AAD380", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AAD3D0", Offset = "0x7AABBD0", VA = "0x187AAD3D0", Slot = "9")]
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
		private sealed class NIMCLGMNLJH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AAD880", Offset = "0x7AAC080", VA = "0x187AAD880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public NIMCLGMNLJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD730", Offset = "0x7AABF30", VA = "0x187AAD730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD830", Offset = "0x7AAC030", VA = "0x187AAD830", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AAEAC0", Offset = "0x7AAD2C0", VA = "0x187AAEAC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object BELIEAFHDAH]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE9D0", Offset = "0x7AAD1D0", VA = "0x187AAE9D0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7AAEBA0", Offset = "0x7AAD3A0", VA = "0x187AAEBA0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE910", Offset = "0x7AAD110", VA = "0x187AAE910", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE970", Offset = "0x7AAD170", VA = "0x187AAE970", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7AAEB40", Offset = "0x7AAD340", VA = "0x187AAEB40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE5D0", Offset = "0x7AACDD0", VA = "0x187AAE5D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE630", Offset = "0x7AACE30", VA = "0x187AAE630", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE690", Offset = "0x7AACE90", VA = "0x187AAE690", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
		public RoomObjectCounts(Dictionary<int, int> KDOMGKLGMMC, [Optional] Dictionary<int, int> HMCBMGMDBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE4F0", Offset = "0x7AACCF0", VA = "0x187AAE4F0")]
		[IteratorStateMachine(typeof(NIMCLGMNLJH))]
		private IEnumerator<DictionaryEntry> LJEHKBDCKMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7AAEBF0", Offset = "0x7AAD3F0", VA = "0x187AAEBF0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE810", Offset = "0x7AAD010", VA = "0x187AAE810", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE6F0", Offset = "0x7AACEF0", VA = "0x187AAE6F0", Slot = "9")]
		void IDictionary.Add(object BELIEAFHDAH, object OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE750", Offset = "0x7AACF50", VA = "0x187AAE750", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE7B0", Offset = "0x7AACFB0", VA = "0x187AAE7B0", Slot = "8")]
		bool IDictionary.Contains(object BELIEAFHDAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE8B0", Offset = "0x7AAD0B0", VA = "0x187AAE8B0", Slot = "14")]
		void IDictionary.Remove(object BELIEAFHDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE570", Offset = "0x7AACD70", VA = "0x187AAE570", Slot = "15")]
		void ICollection.CopyTo(Array CPIDEKBKOPO, int FPEOONOJHML)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class OFLPBHJKNNL : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7AAE3B0", Offset = "0x7AACBB0", VA = "0x187AAE3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
			[DebuggerHidden]
			public OFLPBHJKNNL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE220", Offset = "0x7AACA20", VA = "0x187AAE220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7AAE360", Offset = "0x7AACB60", VA = "0x187AAE360", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AAC2A0", Offset = "0x7AAAAA0", VA = "0x187AAC2A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object BELIEAFHDAH]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC170", Offset = "0x7AAA970", VA = "0x187AAC170", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC350", Offset = "0x7AAAB50", VA = "0x187AAC350", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC0B0", Offset = "0x7AAA8B0", VA = "0x187AAC0B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC110", Offset = "0x7AAA910", VA = "0x187AAC110", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7AAC2F0", Offset = "0x7AAAAF0", VA = "0x187AAC2F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7AABD30", Offset = "0x7AAA530", VA = "0x187AABD30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7AABD90", Offset = "0x7AAA590", VA = "0x187AABD90", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7AABDF0", Offset = "0x7AAA5F0", VA = "0x187AABDF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x274AE20", Offset = "0x2749620", VA = "0x18274AE20")]
		public Invention(long MLBCMOLHELH, int PCFOAHIEPDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7AABC60", Offset = "0x7AAA460", VA = "0x187AABC60")]
		[IteratorStateMachine(typeof(OFLPBHJKNNL))]
		private IEnumerator<DictionaryEntry> LJEHKBDCKMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC3A0", Offset = "0x7AAABA0", VA = "0x187AAC3A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7AABF70", Offset = "0x7AAA770", VA = "0x187AABF70", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7AABE50", Offset = "0x7AAA650", VA = "0x187AABE50", Slot = "9")]
		void IDictionary.Add(object BELIEAFHDAH, object OPMIAMEJKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AABEB0", Offset = "0x7AAA6B0", VA = "0x187AABEB0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AABF10", Offset = "0x7AAA710", VA = "0x187AABF10", Slot = "8")]
		bool IDictionary.Contains(object BELIEAFHDAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC050", Offset = "0x7AAA850", VA = "0x187AAC050", Slot = "14")]
		void IDictionary.Remove(object BELIEAFHDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AABCD0", Offset = "0x7AAA4D0", VA = "0x187AABCD0", Slot = "15")]
		void ICollection.CopyTo(Array CPIDEKBKOPO, int FPEOONOJHML)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> NICMOHLHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyList<Invention> HAKJKBCMBBM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	public ENILAPIFOEE(IReadOnlyDictionary<Guid, RoomObjectCounts> KCKMJMHJHEH, IReadOnlyList<Invention> GKHDMFBMIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7AA6B10", Offset = "0x7AA5310", VA = "0x187AA6B10")]
	public static ENILAPIFOEE KNFHOEKHCOD(IOKANKGCBIH PDNEBCPKAAP)
	{
		return default(ENILAPIFOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7AA69F0", Offset = "0x7AA51F0", VA = "0x187AA69F0")]
	[CompilerGenerated]
	internal static int IDENKPNIIIA([In] IReadOnlyDictionary<long, int> HEIJIIPCEPL, long? PPDNIIFPKHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7AA74F0", Offset = "0x7AA5CF0", VA = "0x187AA74F0")]
	[CompilerGenerated]
	internal static void NCJPDOKCHLN(int BOMJOJAMLPN, [In] JLGDGBCLLFJ CFOFHMCCLKF, [In] Dictionary<long, int> HEIJIIPCEPL, [In] Dictionary<Guid, RoomObjectCounts> KCKMJMHJHEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class AHDMIGLMAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly PPKBIHHKECD KNOKBNGPENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> CDKJIDFFJPA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PPKBIHHKECD AFGBMBALCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2AE0", Offset = "0x7AA12E0", VA = "0x187AA2AE0")]
	public void OIHLAKEIFNH(Guid CNAINABLKFF, Guid LJCIALIBACL, IReadOnlyList<Guid> ONIEMOLPDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7AA29F0", Offset = "0x7AA11F0", VA = "0x187AA29F0")]
	public bool HJNAIICMDBA(Guid EBGOOOHIAPC, [Out] IReadOnlyList<Guid> HILPBLCHKPB, [Out] bool NBCBAJMMGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7AA2B90", Offset = "0x7AA1390", VA = "0x187AA2B90")]
	public AHDMIGLMAJL()
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
