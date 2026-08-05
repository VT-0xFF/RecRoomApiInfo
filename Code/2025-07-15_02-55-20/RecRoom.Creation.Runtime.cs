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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80688E0", Offset = "0x80674E0", VA = "0x1880688E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FKPPNPCANMO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> AIJHPKMFEEF;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> AGKDHBBFJLC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> EJHBJBFNJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> OIFBDFMDGIG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BEJFEAKAJBC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LEIOMGNODID;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string BMFLBIICNEC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80562E0", Offset = "0x8054EE0", VA = "0x1880562E0")]
	public static bool MJMPELPINAC(Guid BGPKPDKFHMJ, int IJIMHOANFNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80563E0", Offset = "0x8054FE0", VA = "0x1880563E0")]
	public static bool PFJPMLBLOHC(Guid BGPKPDKFHMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8055C10", Offset = "0x8054810", VA = "0x188055C10")]
	public static string GHDPFCPAJLC(Guid FHNOHJCOOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PBHBPDECGHH]
public enum HJEMCLLENMB
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
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8067E80", Offset = "0x8066A80", VA = "0x188067E80", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OMIEAHGDBJM
{
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid FMMKNODNDMC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid ELNFKDCFPOE;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid DOBIMLMMPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GNCPJLABMKB;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MPDNKGCNFLO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid FFBHHNADAAA;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid ACFLPCDMKFM;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid ECHILJBFJNP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ONIIFPLBFMM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid IGODBJNHHMH;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MLDIEJMEAAM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GOANJAIGLKO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MEDNEHCPHOE;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid CBNKHJFMDDL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid DOHEAHHOPNB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GLGPMDMODPI;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NOPAIMBLJDI;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid APOJHPKNAIG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid CNIFLDJFFBO;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid LLGLNDEHNDK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GJGGNGDPCMC;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PGMJNEBKCFF;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid BHLLPLNNBAK;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EECPKJLFDNH;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HPGIOLGGLLL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JOBGNFAJIBL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid CGAADDCMEDI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CMNHACAIKGH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid ONJJBKPEJOD;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid JJKGFIPCLFG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FDNNMGNBOBE;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid DMDHFICPFDD;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid EEKBAIFJLLA;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid CGEBFBOIOAC;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid DHIGDGBIFOF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid AKLPDIDJGMN;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GCNMLGODCFA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid BBBBLMMBPMK;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HLBPGMAFJNK;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HGNMCOEAIPK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid OGAEGHGOHOC;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid KCMNFNFBEDG;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LDLKJINKEGE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MEOIFEKDING;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid IIIJAEIMEFP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NOCJIHIEDPA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PLAFHHOFPAB;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid JMAHKGIGIHB;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OPBKFDHMIGG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ODMOAPINAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid GONGHIMEKHD;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid KIBHIJHNFHF;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid OBNEFKAFLDA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PMKKJMJDBDG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid AFAOAIGNKOF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid JLPJDDMIJKK;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GHDLKEKNCMH;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid OFHOPIEPOFI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid IANEMNLOGJB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid IOBLGHCKENH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid OEINIJFGHGI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid EANNEFCEDNE;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid PJHENBBPOLG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FBMFNBMJHBA;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MJJLOALPIGB;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid LEMOMJPLEGI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid CCMLHBKDCJE;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NBKHJFPFPCC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NJBGOFCHKNC;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MFEIDHMCOON;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid MIEAMANHPIC;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid CMOFHGNJOJM;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid PAHNMKNDKAH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid DGLHAEOJBGI;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid CENIOJPNAPK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JHPIMMIIGIE;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid FJKBJOGJOPI;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid AIKPNMNECHD;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid AHDBAIFOCJF;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid PKHMHLELNOB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FFNKMGDLPEC;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid FBDJPLOONGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PGHPNBPFAMF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JEPEJLMPOOC;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DDKHFJGGKBK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid BLAJDONAKDN;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid EAKDDPAGFFJ;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GOHDPPPNKFF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid IFMPBBDIKAP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid MCFMICEAFJE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GHONINEFEAI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid PNBAIOOELNB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid IINCDPDAPBA;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LPOKIPNCCNC;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid GDACACFDMGP;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid BAKJDMDNPPJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GGAJIHNLPDH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid DGNJDPFKACI;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid ONIJPNHAOLC;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid EEKJNNNEOJD;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid EMMLMCDPDPI;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid KJNJMELHJJI;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid OAHEPNIIOOF;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid JECLCLAPHFO;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid NEJPBGJEPLH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JFFOFDCHFDF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid AHFKDIAPBLO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid JOBCEOPGECI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FBMHJDADLDB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BFNMGKDAMKG;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid OMJGIHIHFND;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid LEIOCCIALFI;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LPGGFNOAIBM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JNHDINPAPGF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PGHMFNJAMOM;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid ELCELCKOHEL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CPOKLBPEGPE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GPGDAOPJJMB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid LCMMPLCCDIM;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JJGGKAMJKKK;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid AJLINKGPEBD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JNEAECNCLCN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid DJGHIAMJDOK;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid EJLIFKLDNCL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LEHJKGDGIHF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid KAHBEPJLAAG;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PIFABFEBAJF;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DCDFJMLOKCP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LHEALBCNDNH;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BAEDHPMBIAA;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid DLABPEDBGOK;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid DDEKPDNFNFC;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid DNBAFNPHIGC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PPLIOMDPILI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid ALBDKDEAPFK;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NMIKHNDHFHG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid FOCLFENBILO;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BKBIJFHHOAO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid ECNHMDEECNL;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid APGPLJOKCED;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HCBILJPPFHF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DDBMANJOPCI;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FGNDCMGOADH;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OEJDKKAGMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FJJANAKIPJK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HJLMCLFJIHP;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid MPIHCBCDBPC;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid DFBJJPDANJL;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid FAGFNMNNEPB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid BGCKLNJEBKO;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid IFFDMACIOIF;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid IBPJMIFNFDI;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DHHCIGDPJNE;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid NFNNKHMADJB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid APOLPDELMBA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid ICNCGNEKIJH;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BIIOFEKLKNK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid HJEAFHIOIHL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid EHFMCMIFMEC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid FNLLHADJGMN;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid KIGCCFHDCGD;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid KHLMAKOOIPG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid EABDFGOCJIP;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid FNEPFEIEGCK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LDNGDJDBPOF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FOKOFHLMPEI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid IKDFKECEIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid EGLCACLKAAH;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid PFLJJLJGMOL;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GBNBLOJJNCG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid KGCONGBLOHB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JFLKIALKKJM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid LLDLDICHGFC;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid ICKAKMCPKJC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid MGBELKLDKBC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid CKJHGJGFLNG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid DGPOFNIGJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid JMNAHPFADPD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid IOFHMIAALDP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid PEKBKKLIKFB;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid ABHPNFEDEFO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid OGPDHLPLHMI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DEIFAPDAIBN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DKNEONPAGHG;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CHKBCCJAAGK;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ILNGJCINKHB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid PDFDEGGDCLK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KJGOPDMPEED;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OMLCHFKGFJL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid HMIPAAKGAMM;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid FCHOFOMELMC;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MDLMMMEJCEG;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid BAJFHHAHJHK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid ABBCGHCAFGM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid LDIIMIDANAH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OKIACHGLJOP;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IGEBMIMBJAO;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JBNIOFEGGNM;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HNOLBBAILAE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid MLLJPBHPELN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JHJDDAONODB;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NMGDKEACJOF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid DJLBNIELMNA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid EJDCKDNNKGA;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid HIDDKNCPPME;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid ODMHJHKMGKI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NNNKLOKDHMK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid AMKNJINFAML;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GBHGLJMJACA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GJGJGGECNAN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HEHFPJMBBBF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid CFNMAINGCLE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid CEFIMJNELMF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid ADOGJCLPBPB;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CKMJPCLGILH;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GMJNNCAIKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid NECJAFHJCFJ;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid DIAAPOOCGOM;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid NPFDEDECMGH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BOKIMHKDNEA;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FHHDJOLCBKC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid LGEMAFPFMEJ;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid EDIDILNFKGA;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OPMNNCMLLME;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NLKIFNCPIKG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HGDDEMPFMBG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid EKKLDCHCGOI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid AANLGFJCMLE;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LCGNECNDIDH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PCKBDBGAKDO;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid FJACLNJPEMF;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GGCMBLEIDMI;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FDLIGIIFKNK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KKLDCAGDMMG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OMNPDMOLNAG;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OGBCFPNBNIP;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KCGHDGHIIDM;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HOBHCEPBIOP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid HCBMJFLFDJK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid EGMPKKKDIIP;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid FPKLEJHMMHP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid IMODJCDMKAB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MMGFKBIKNHL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HNBJDMCEBJN;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GKGGOGDHFGF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LHHPAKMNIBP;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DNKHNLOKCFK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid CFCCDBCNEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid ICLFFHFAFLJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid JHMAGNHKOIM;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid CMJJGBDDGFN;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid DBNMCMEOCKN;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid CDIGPLJDJBN;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JGJKHGKCNFN;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid JOMPDNLLPAC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid JFIIJKAJGFH;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FCCDGFADFIB;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KGJAEGFMNGH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid EDHIBCKMLAH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MHAAMEOIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid ANJNOBHGDIB;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid EDCACLKDJFC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid MJLOILNPKBL;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KJCKLOJOBDP;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid DCDKLIOPJHC;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid MKAMGBMHOIF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid ONLPBIHBOGD;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid AGCOCHIGCDJ;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid INKFFGBEODB;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HAOEICPAKFG;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NEANCPIIOAF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid PHDCCDHJHOA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CLDLAIPDGIF;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid ACDPIOGINNI;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CONHJNLJCEK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid IKBCJOAMIAD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid IMFLFKIEIMO;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EDOMJCGNCEM;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GHOBFHNLFHK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid CBEBJMJAHBM;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IAKKOFOHGPD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid LEIFKEHLFBE;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid PNPJLKHKCCL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid ANMGPLEGNGD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid MDFGHHNHGIL;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid DIBLNDMNIMK;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid AJHMPHCMNIK;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid OHLMHPCECKN;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid DCPODLDKMKJ;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid HCODBGFJLGF;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid FNFGLLKCIFB;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid LHDILMKAEJA;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid CJJCECDMHNK;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JJMICFIEPLE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JHFELHJFCIE;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid PNNBJJAANNA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid DKEJIFLLEIN;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PLLENNDMFEM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GEFJBHIGCCL;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid OPJKOBLIAMC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid KLLCFMCPEMH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid OEMEPNLCIMC;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid PLPDOFCNDML;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JBMHDNAPHME;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid KLKEKHKICAI;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid AFEPOMPMFCJ;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DNNPHMOLILJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LDGCAOEJFGC;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid BAIHEELDIEI;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KLOAADHKGLB;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid ONOFDMOIMOA;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid LLEGBADJPAG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GNOPEIAKHPL;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid CNGFLJGKAAA;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid DCCBKINHNFM;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LLJFJJGNDED;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DHOAICKJPDK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HHLCJDIGLNI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid OGIKIIAGDLD;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid GHNMCDGECLJ;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid BBMAMHHOLIK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid AHHBOGCOPKP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GKNGAAPLOIL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NGHEBKOFEDC;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LKJFAABBCNF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid ODKOPJHFHIB;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LPDPADIMIBL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid LGPCOKMPHMI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid HNLPDPKPDLM;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid PFCPANPIJJI;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid CNHMJEJJFLF;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid HPFKBOHFBAG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DGMJPGGHJLC;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid GHHHAFJMEHH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PHEKHBOKKEA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid GFNJPFKOKLL;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IAGMLEIIINO;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid BBMKEENAKNL;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid ANABIDBJINC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AHOIIJCGKKI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EHGBBDNDAOL;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid CIANDBCJABP;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BPEKBGENFFJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid ODAPGMBPDIG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid KGFJOOGBMIO;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid OKJFMEDAKIN;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EJPPLCFPBDD;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FGIBBAJOENK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid PNLFEGOKKOP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid CFHPIKKBJLP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid MGDANIGCJBJ;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KBEHBKGNBDB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GLELJEDMMAP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FOJNOCMNFNE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid IJBFNNJLFMF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AFOJENNMGKD;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JGLALKENHMN;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid KKGFADJANDK;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HCLBKKBIAMF;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EIMDIBOEKIL;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid PLIOPAPFPAH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JGAAMCNHDOI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid INJIFKFGINA;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid LPGHCHFNGCO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PIDIHCNEHCP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid GGEDBIABALF;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid MJIEBGPPPMO;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid MOAGMJAHLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NFEFELICBOI;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid DOKHOJKAKOB;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid FIEGIGFOMHO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid DNICECACPGO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid KCFGADNIAOL;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid DHAFCBACDPF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid PPOIIBBIAJA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid MEILPPAKLEL;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid LECFKKCCFFP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid GGKMFNPKGNK;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HJHHDOMOOMH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid AGJOJCMDBFA;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NBDMOMIFLJK;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid LINLLMGOFNL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FNOKHIBINJO;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid GOKJDLOKAMI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid EBGCGLFCOAD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid HCHDJALAHBD;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HNFKPOODALM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BALNPDLFFEO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid LLANBJDGBHC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid IBOGJHLKFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BALCHMKIFOO;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid GHMDBANMNJB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BGAJFMFDNKC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IBPFBKMBFIH;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid MMNEIHPCGPO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid OGHJHDBHCBJ;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid PJOOGGBBAAM;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CFBPEIBBOOD;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid GGFHKCDDPHH;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid FNILPBJAPNP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid AFAKLIIJMNA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid MOIAEDCOOOP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid IBMPMPMJCEI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JIPKALCECKA;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MNIDBNKHCHE;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FMIDCGAMJPG;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid IACMBFIDEGH;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid CLKBDAIJAPK;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OLJCHDFMCJO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid AEGIAAHKCBP;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid GAJFMJAJNCP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CDEMOMDILCG;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid CBHDAMNDNKP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid BJLLMEPCNAF;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DFABCPMIHOI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid EFABCGAGPJN;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GNBJEFGAFCA;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NANBIGBGGKN;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid LMPAICOEPLK;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MCGDAPPMCIL;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid FCAHJECABKD;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid IMGFLAAHCGK;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OPGICIIDJCF;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OFNPAAIGLFK;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid NCFOJILFKIB;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CEPOCGHFOJM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PGEGOFIEGPA;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MPJDLJHNFDF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid MACIEDOMKMM;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid KPNMDMPLCJK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid FFCBLFMHAMF;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid PGBIGMPOBGK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BFJGLGPOKHA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid GLCEJDENHDO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid MCDJODFBJOK;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MLNLFOJIFPC;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NEMJKADMEIG;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid DGCJNKGIJCL;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KKBLGOLGAMD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DHBHFDCHIBF;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid EHPEIEPKFLA;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid JLEGFEAHMNO;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MMFJBOFMMBN;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid KGBBDGODEEA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid GFJOPNIALOG;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid KNECBKBKFBK;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid PJIBBCAKONL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid JAJDEAIEJCG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OOKHHKLIDAD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid LEOPBLGMEMI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MOGHOGOJBPE;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid IJDOAKKHPDN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid OADFHFOABFF;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid MJDDIMJJHHF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid LODBEGBNGFJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid PPFBAJFEGBN;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KPGDDKJJFBB;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JPMCALBMEDL;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GAGIJJBFEHL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid BECABJGIHLG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DBHLMIBGKMK;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BPDIEJGHJOF;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid IMDPIPIIBDB;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid NCFDEFFBBJM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IBHDDFMNINC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BLNDGJALFMO;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BNKJCPCFGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid LLHKAGALKFI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid PFHHCPJGGMI;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BJKBAKBDENO;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid CDMCCCEMMKI;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid PKMLAPLJAFI;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid JOILKJKGEND;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid JMPCMBNCNJI;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DFCDMAIOFNP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid CBKHPCHKIJO;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid FNCJDCAFIKA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid LEAIGDMHCFN;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid JCHHBDLEOND;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid BLMGHOJHKFB;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid JGMCMBNOJGL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OOFOBPGCAFE;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CBDFPGIDPHC;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid CJJHOKPKCNH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid EOHPNBLEJBL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid IIBNCGFEAIL;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FMPJLKGDIMP;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JHKECEKPEND;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid EODKECIMPCK;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid GOIBAICJCGH;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid MNGDIJFHGIH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid FMPNLMMKHLM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid PNOGBPOHOBO;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid MHANAPNPDEL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid MBLFIOAMNPN;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid ELOAIFBBJPO;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid CMADJOOLMKE;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MDPNCLMMFKF;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KNGGOJELOAL;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MOKMFBOMBAE;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid HIOPCKPFHHN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid ANKDDEHHEGF;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BELLPDKMEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KGDFDIIBADP;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NNBBDFBLONB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid PILFONNPJOM;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid KDJGHKLKOJJ;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EILKCHIJJAF;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CFHPDKEJPHA;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NJBPFANBOGB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PNABMHJKPKK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MHLHANOGJLI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid GEIBGBCEEJM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PJKMGEMBEAL;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid AMFNHFGCIJH;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid AFDONFGNNCK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid ELOBNBEGHNG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AANECLJGJAC;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MEAHEMPOACO;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CGLPJIGIAPK;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid FKHPCKGNLKP;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid HJFKOCBECGM;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid PANDKAOPJGG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid JLFNDOFKEHE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid NPKIJHKIDCA;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid IDKPPCGCADK;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid DPJLINMPNIB;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid FLBNFCODOEN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid IMKDDIPNMMF;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GKGAFBOGKJH;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid FKOGALGOMNN;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid AKAJBDACLDK;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid CMOCIOMDDMI;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid MPEDGHKMLJB;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid EFEPALMKGNG;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid FEEMNIHKABD;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid JJFHMIAOEMP;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid KHLHKAJKKIO;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid HDEOGCCGEKL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid HPPOBDJFCKF;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid NGOMDPNDOJG;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid CDHMNGHPILN;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid PEGFBDONEIF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid INICKMCDPMO;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid CGMMODKJJMA;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid BAGPJIGLKJB;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid PDFIKHHDFID;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HBFABJHONAO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid NKBOKKBPLCD;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid IBCAFLBIPJC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid EGMIMHJOEKA;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CAICAAFMMIC;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid PCKJLAOMDGA;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid DEPKBKJJNKD;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid LOACBCOOBHD;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid AIODPELGLKK;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid CIAEFLPNHHD;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid NOEHMEJCGKD;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid CBAAGFAPNBB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid BFIPALLIJHO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid JKDGBLJAMBG;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid CFBKAGADHLB;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid OIDBGHHEKEK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid CFMNHBDDHKB;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid AGFKOACOHKB;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid LPIBMEGGMKM;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid KAHLHDNBGCL;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid KHLFDDPBEBO;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JDLHAGJIPKF;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid PEDBMKGOIHK;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid BOCEJOJAOPJ;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid PBDAOFOIHNM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid DOOPGJIHIEF;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IGLAAJDKCJE;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid LDNDJBLFNNO;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid ODHEAMGLIDD;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MNOEPDCINFH;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid HBNJBEDLIOH;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EELPEPPOPLN;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FMNGCFADIDH;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid KIKGCEBGPAD;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid GPADCLNEKEK;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid OILGPHGDEEF;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid PBJLBCKCDEJ;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CJFJIENALCC;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid EILGCPGIKGH;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid MENEELFFBDH;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid HNHIECFFIAH;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BCEKNFPAANJ;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid GOKIGAHEMDL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid OBGIEPNHOHM;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid EBGKHOPFANB;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BFNNAPACBOP;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid AAHDBMFAJNN;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid BJLAMJCLNBB;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid KIOOBBJKBBP;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid KEOBFJKJLKD;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid BJLMEKPEDEF;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LNBCJMMGBDI;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid DCGGFCMAFAF;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid MMLCCBGKABI;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid INEAIEJHMHI;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid ODLEGDLPMEC;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid HCMFNGGFLOK;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid JKLCADOKLHC;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid CKILBHNHCKP;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid NFDHDNGGJLB;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid CBDBFGIEEDJ;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid AFDDDKAIOON;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid ONBNODIBOAH;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid GIPIFHBDJNJ;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid HBCBOPBNLHL;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid MDLCKPCNJMB;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid BJOAHIHOEMJ;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid GJDHCCFPNPG;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid FGEIBKOKDNP;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid FJOLHJAOOHB;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid CPLKDFAIHBC;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid PEHAHGJCBIF;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid FHCMALBKHBI;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid JJOPOOIILIO;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid CFKIKDJOPNE;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid FBFNEIAFHIK;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid DEFEDAFHFJF;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid JGBEJKLOKDN;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid MBFPPFDCNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid OOAJDJKNPGH;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid LPMBJPEGFNI;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JEAEFBABJIB;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid KHNLALDDMEG;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid DGBCBPAHOGH;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid MOCCIIKBNHO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid GDBLEDLFCKG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid MFAOBBIIDDE;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid ENNOOLADLMB;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid AHHFBFKNGCG;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid JDNKFMLOGGM;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid FIBKKKAHAAC;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid EFFDBMPPPIF;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid GLLJEFENPMI;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid NLLMEBCIJAI;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid LJALJBMNLIK;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid JNAEGJEAAOK;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid CFIHNCBNCKA;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid PEPFNOCPMJK;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid EEFPNEGOACF;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private static readonly Dictionary<Guid, HJEMCLLENMB> CELOBGLPBAE;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private static readonly Dictionary<HJEMCLLENMB, Guid> ODKMOMPOHLG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, HJEMCLLENMB> EFGELOAJKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8068960", Offset = "0x8067560", VA = "0x188068960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<HJEMCLLENMB, Guid> GAJGAGFGNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80689C0", Offset = "0x80675C0", VA = "0x1880689C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PJJLKKPBNEE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8068E40", Offset = "0x8067A40", VA = "0x188068E40")]
	public static bool NDGCAPODIMK(NNHECIEINDI DOFDFHJBEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8068A20", Offset = "0x8067620", VA = "0x188068A20")]
	private static bool NDGCAPODIMK(IJNCJFOMLFN GLMMAMOKOAD, NNHECIEINDI DOFDFHJBEJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KCICNJDHNAA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CPKLKLJIILG CBCNBAPLLJM, [Out] Dictionary<int, int> MHLNPKHEAGG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JLCEMONIDLM BLKCBLLLHDE, KNLFDFNLGFD ACNGBGDDKFB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FPEFGFHFBLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly LIHOBAKPJHP FLOOCCFFBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly IEnumerable<CMPHAOCHJPD> GLIDGNJHAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly IReadOnlyList<CMPHAOCHJPD> HDHJCPMAEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly COMEADPNKEA<MAPJCLOKAJL> HEHBGIKBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<GHGLFDGPACE<DDIFFCPDEKA>> MLFCLHFAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly ELEBBIJBICC HCCBIGFOECD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BMJEEAIJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8059CD0", Offset = "0x80588D0", VA = "0x188059CD0")]
	public FPEFGFHFBLH(LIHOBAKPJHP OAIMCOBNNHA, IEnumerable<CMPHAOCHJPD> EHDILJIPCBA, IReadOnlyList<CMPHAOCHJPD> GEHOIJOAHPF, COMEADPNKEA<MAPJCLOKAJL> GEKIMFCLJBA, IReadOnlyList<GHGLFDGPACE<DDIFFCPDEKA>> BAEBDOAHDLD, ELEBBIJBICC GOLNIEGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MBFPGJCODFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly LIHOBAKPJHP FLOOCCFFBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly IReadOnlyList<CMPHAOCHJPD> IHBGKEOEMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly COMEADPNKEA<MAPJCLOKAJL> HEHBGIKBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<GHGLFDGPACE<DDIFFCPDEKA>> MLFCLHFAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly ByteString GNCAACKEFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly ELEBBIJBICC HCCBIGFOECD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8067F50", Offset = "0x8066B50", VA = "0x188067F50")]
	public MBFPGJCODFA(LIHOBAKPJHP OAIMCOBNNHA, COMEADPNKEA<MAPJCLOKAJL> GEKIMFCLJBA, IReadOnlyList<GHGLFDGPACE<DDIFFCPDEKA>> BAEBDOAHDLD, ByteString AGMGLAJABCA, IReadOnlyList<CMPHAOCHJPD> BELBMFGGJAN, ELEBBIJBICC GOLNIEGBABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KMDPEJAOLPJ : ANMDHDJDGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly Guid PEJCJGPNJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private readonly Dictionary<Guid, Guid> LDOBEDEHEFO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E00110", Offset = "0x4DFED10", VA = "0x184E00110")]
	private KMDPEJAOLPJ(Guid HICCOILHILD, Dictionary<Guid, Guid> LDOBEDEHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8067CD0", Offset = "0x80668D0", VA = "0x188067CD0")]
	public static KMDPEJAOLPJ MJMNOIPJNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8067460", Offset = "0x8066060", VA = "0x188067460")]
	private static Dictionary<Guid, Guid> EBOALFHKJHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8067B70", Offset = "0x8066770", VA = "0x188067B70")]
	public static KMDPEJAOLPJ LCAHHLKHKFI(IReadOnlyDictionary<Guid, Guid> OJNBCCCOMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8067880", Offset = "0x8066480", VA = "0x188067880")]
	public static KMDPEJAOLPJ KBFMIBLIEPB(IEnumerable<KeyValuePair<Guid, Guid>> OJNBCCCOMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8067580", Offset = "0x8066180", VA = "0x188067580")]
	public Dictionary<Guid, Guid> ICIMBHGMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
	public Dictionary<Guid, Guid> OEHIKOKINDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8067D60", Offset = "0x8066960", VA = "0x188067D60")]
	public void NDGLNAHKHEG(Guid OJNBCCCOMPJ, Guid IOKMBOFHINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8067600", Offset = "0x8066200", VA = "0x188067600")]
	public void IKJPKNMIENP(IReadOnlyDictionary<Guid, Guid> OLMEOILOICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8067B80", Offset = "0x8066780", VA = "0x188067B80")]
	public Guid MDDDLDBOOKE([In] Guid OJNBCCCOMPJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8067DE0", Offset = "0x80669E0", VA = "0x188067DE0")]
	public Guid OKNCLAGAFJN([In] Guid OJNBCCCOMPJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8067510", Offset = "0x8066110", VA = "0x188067510")]
	public bool KCMOJHGCLLO([In] Guid OJNBCCCOMPJ, [Out] Guid IOKMBOFHINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8067510", Offset = "0x8066110", VA = "0x188067510", Slot = "4")]
	private bool HJDKMHPFNKN([In] Guid OJNBCCCOMPJ, [Out] Guid IOKMBOFHINB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EEPCLMJNNNB
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICGFFMLKOAG(Guid FHNOHJCOOKK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLAHKAALLHE(Guid FHNOHJCOOKK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IFCEDININMD
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
public abstract class FHJBLJHMLDG : EEPCLMJNNNB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MKGDGFBDEDB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public MKGDGFBDEDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8067FC0", Offset = "0x8066BC0", VA = "0x188067FC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8068120", Offset = "0x8066D20", VA = "0x188068120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8068080", Offset = "0x8066C80", VA = "0x188068080", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8068080", Offset = "0x8066C80", VA = "0x188068080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NNPFDJOMEDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public FHJBLJHMLDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8068170", Offset = "0x8066D70", VA = "0x188068170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8068880", Offset = "0x8067480", VA = "0x188068880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private Dictionary<string, HashSet<Guid>>? IOEICEOMPEA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> BLKLMHLHGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80556D0", Offset = "0x80542D0", VA = "0x1880556D0")]
		[IteratorStateMachine(typeof(MKGDGFBDEDB))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? NIKOKCJODPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool FAIPFPFDNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool FKGNLAHDGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> FGECOGPDPLM(string AJOPFIPGPCE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8055AA0", Offset = "0x80546A0", VA = "0x188055AA0")]
	[AsyncStateMachine(typeof(NNPFDJOMEDM))]
	public Task IIHNAGIBOCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x128AEC0", Offset = "0x1289AC0", VA = "0x18128AEC0")]
	public void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8055730", Offset = "0x8054330", VA = "0x188055730", Slot = "4")]
	public bool ICGFFMLKOAG(Guid FHNOHJCOOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8055600", Offset = "0x8054200", VA = "0x188055600", Slot = "5")]
	public bool BLAHKAALLHE(Guid FHNOHJCOOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80559E0", Offset = "0x80545E0", VA = "0x1880559E0")]
	private bool IHCFGGGHNKP(string AJJDGIEGCPA, Guid FHNOHJCOOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected FHJBLJHMLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JKIPJDBOGKO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PAPOGDAMJMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public LIHOBAKPJHP staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PAPOGDAMJMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8073430", Offset = "0x8072030", VA = "0x188073430")]
		internal COMEADPNKEA<HJOCNMCEAGM> JNOKFJFIJIJ((COMEADPNKEA<MAPJCLOKAJL> GraphId, COMEADPNKEA<DDIFFCPDEKA> NodeId) i)
		{
			return default(COMEADPNKEA<HJOCNMCEAGM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static readonly LJMABMKBOOJ<HJOCNMCEAGM, int?> GHOLBPBFEAL;

	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly long NLOMIKBDPOG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8059D40", Offset = "0x8058940", VA = "0x188059D40")]
	public static (long, long) DJAIOCDHHKI(LIHOBAKPJHP PLOJGDNFOLK, COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<DDIFFCPDEKA> LJOMDKEKAFC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x805A300", Offset = "0x8058F00", VA = "0x18805A300")]
	public static long HEMKCIHCENP([In] ReadOnlySpan<COMEADPNKEA<HJOCNMCEAGM>> HMLIMJNAIGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x805A1E0", Offset = "0x8058DE0", VA = "0x18805A1E0")]
	private static long EEGBBMMDKFC()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NLBICOIIGEG
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public static readonly HashSet<HJEMCLLENMB> JLEPKPDHPLL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PPDCIADPENJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LCIBEBBLMNF : IEnumerable<CMPHAOCHJPD>, IEnumerable, IEnumerator<CMPHAOCHJPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private CMPHAOCHJPD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private MEEBHFOCAAH spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public MEEBHFOCAAH <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private JPAHKIAOPNA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public JPAHKIAOPNA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private CMPHAOCHJPD System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public LCIBEBBLMNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8071F70", Offset = "0x8070B70", VA = "0x188071F70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x80721F0", Offset = "0x8070DF0", VA = "0x1880721F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8072080", Offset = "0x8070C80", VA = "0x188072080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CMPHAOCHJPD> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8072080", Offset = "0x8070C80", VA = "0x188072080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80783A0", Offset = "0x8076FA0", VA = "0x1880783A0")]
	public static MEEBHFOCAAH HEJKNJPDGHA([In] MBFPGJCODFA KDKHLMJPEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8078210", Offset = "0x8076E10", VA = "0x188078210")]
	public static MEEBHFOCAAH HEJKNJPDGHA([In] FPEFGFHFBLH KDKHLMJPEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8079120", Offset = "0x8077D20", VA = "0x188079120")]
	private static HashSet<GHGLFDGPACE<CHOODMPBJML>> OKMAGJONNHK(IReadOnlyList<CMPHAOCHJPD> LFKLINJNHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8077700", Offset = "0x8076300", VA = "0x188077700")]
	private static void FJPJKODHHAM(MEEBHFOCAAH PPKJJHDNMJP, [In] FPEFGFHFBLH BBKHNPMKEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x80761B0", Offset = "0x8074DB0", VA = "0x1880761B0")]
	public static IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB> EALJFDMCPNM(MEEBHFOCAAH PPKJJHDNMJP, JPAHKIAOPNA FOFCFKJFAGK, KMDPEJAOLPJ? FCBGMJCFBIH, bool PHJEKGELBEN)
	{
		return default(IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8075FA0", Offset = "0x8074BA0", VA = "0x188075FA0")]
	[IteratorStateMachine(typeof(LCIBEBBLMNF))]
	private static IEnumerable<CMPHAOCHJPD> BBIGNCLOOCD(MEEBHFOCAAH PPKJJHDNMJP, JPAHKIAOPNA FOFCFKJFAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8076140", Offset = "0x8074D40", VA = "0x188076140")]
	private static void CJPAKDNEHEE(MEEBHFOCAAH PPKJJHDNMJP, JPAHKIAOPNA FOFCFKJFAGK, IReadOnlyCollection<ByteString>? NDHBMCBKHBL, IReadOnlyCollection<ByteString>? INCJOCDKJBP, IReadOnlyCollection<ByteString>? HCBKLGPHBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8078A90", Offset = "0x8077690", VA = "0x188078A90")]
	private static bool NJNPCKBICFI(MEEBHFOCAAH PPKJJHDNMJP, JLCEMONIDLM BLKCBLLLHDE, JPAHKIAOPNA FOFCFKJFAGK, [Out][NotNullWhen(false)] string? PDIIGKEPNLO, [Out] Dictionary<int, int> MHLNPKHEAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x80787B0", Offset = "0x80773B0", VA = "0x1880787B0")]
	private static Dictionary<Guid, IJNCJFOMLFN> KPOILJMPNOA(MEEBHFOCAAH PPKJJHDNMJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80760B0", Offset = "0x8074CB0", VA = "0x1880760B0")]
	private static void BDCEOHCGDGI(bool ADHEBEFPJGK, CMPHAOCHJPD JFKNJMNMLKG, KMDPEJAOLPJ FFHLMKMHNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8078520", Offset = "0x8077120", VA = "0x188078520")]
	private static void IIGPLNMMJIF(CMPHAOCHJPD JFKNJMNMLKG, Guid MJIIKICHOLO, MDJONPMFIEG? DCFDPLDFIOO, Dictionary<Guid, IJNCJFOMLFN> ECBOPIKJLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8077D60", Offset = "0x8076960", VA = "0x188077D60")]
	private static void GBENNGPNIOE(IEnumerable<CMPHAOCHJPD> LPPGFCOIEDN, IReadOnlyCollection<ByteString> NDHBMCBKHBL, IReadOnlyCollection<ByteString> INCJOCDKJBP, IReadOnlyCollection<ByteString> HCBKLGPHBNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JPAHKIAOPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public bool ADHEBEFPJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public ELEBBIJBICC GOLNIEGBABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public MDJONPMFIEG? DCFDPLDFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public MDJONPMFIEG? GOOPLIBNNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public LIHOBAKPJHP HNLMOOJAICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public IFCEDININMD FGBPGOJDGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public KCICNJDHNAA FEJHCMNOFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public GHGLFDGPACE<MAPJCLOKAJL> KONODEEPMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public ONBHDEGBKCP DAGODDLPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public List<CMPHAOCHJPD> AOMIGHEMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public MJAPGGNPMGD HMOHGLOAPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public OIJNDPMJBOM MJNDFOHKLJB;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MDJONPMFIEG
{
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private const float JPKFGNGAHGF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public Vector3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public Quaternion DINDLKHALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public float ECJMFFOLCCL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 LIOAGOICGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8072930", Offset = "0x8071530", VA = "0x188072930")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS HLPCBAGEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80728F0", Offset = "0x80714F0", VA = "0x1880728F0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x15B2210", Offset = "0x15B0E10", VA = "0x1815B2210")]
	public MDJONPMFIEG(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float ECJMFFOLCCL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8072CE0", Offset = "0x80718E0", VA = "0x188072CE0")]
	public MDJONPMFIEG(UniformTRS HMCPNHMMFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8072670", Offset = "0x8071270", VA = "0x188072670")]
	public static MDJONPMFIEG FLMIPMFBKLE(MDJONPMFIEG IEPNOLIPIDE, MDJONPMFIEG FHBDLACOADP)
	{
		return default(MDJONPMFIEG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8072A40", Offset = "0x8071640", VA = "0x188072A40")]
	public static MDJONPMFIEG KDDDGPNBGLG((Vector3, Quaternion, float) CBCNBAPLLJM)
	{
		return default(MDJONPMFIEG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8072A60", Offset = "0x8071660", VA = "0x188072A60")]
	public static MDJONPMFIEG KDDDGPNBGLG(Matrix4x4 PGMIPCEGLHK)
	{
		return default(MDJONPMFIEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8072C50", Offset = "0x8071850", VA = "0x188072C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8072450", Offset = "0x8071050", VA = "0x188072450")]
	public MDJONPMFIEG CPHCNCPIFGO(Matrix4x4 LMGPODOPMIJ)
	{
		return default(MDJONPMFIEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80723E0", Offset = "0x8070FE0", VA = "0x1880723E0")]
	public static MDJONPMFIEG AKALGCHNIAM(Vector3 FEMJLOIOGIK)
	{
		return default(MDJONPMFIEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8072BC0", Offset = "0x80717C0", VA = "0x188072BC0")]
	public readonly NEEOLPHFNHI LECIIFMCGPN()
	{
		return default(NEEOLPHFNHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LAKDALHENKH
{
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DDDJFAKKCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public readonly BOOJPAOOLBM FHBGENBBKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly KLHHEJIOGEP KAPCAIMNJAB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1876FA0", Offset = "0x1875BA0", VA = "0x181876FA0")]
	private DDDJFAKKCJB(BOOJPAOOLBM MEGBHLJHDNE, KLHHEJIOGEP ILAEMFJEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80693D0", Offset = "0x8067FD0", VA = "0x1880693D0")]
	public HIAABMCLABB CFBCIKMGFMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8069440", Offset = "0x8068040", VA = "0x188069440")]
	public static IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB> MJMNOIPJNFN(NPLFHLPCFHA<DIKEICNGGBM> ILAEMFJEICD)
	{
		return default(IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80695B0", Offset = "0x80681B0", VA = "0x1880695B0")]
	public static IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB> MJMNOIPJNFN(HIAABMCLABB ILAEMFJEICD)
	{
		return default(IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80694F0", Offset = "0x80680F0", VA = "0x1880694F0")]
	public static IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB> MJMNOIPJNFN(string FDNAEPOBGFA)
	{
		return default(IADHIMOENNN<KMDPEJAOLPJ, DDDJFAKKCJB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BOOJPAOOLBM
{
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PFBNLPGFMCB : IDisposable, KOACOFFPOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private NativeList<FKNJJMFFJFL> PMNENKNDJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private float JLAPNPFLIGK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EHENCINGLKE PGBEBHMACKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110")]
		[CompilerGenerated]
		get
		{
			return default(EHENCINGLKE);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EFJCMLILDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A900", Offset = "0x6F39500", VA = "0x186F3A900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool PNOGJBAJKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A910", Offset = "0x6F39510", VA = "0x186F3A910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<GJOPJPLELOE> DCLDFJFJAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IDBMPGPCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8075ED0", Offset = "0x8074AD0", VA = "0x188075ED0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JLIHHPCMCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8075C30", Offset = "0x8074830", VA = "0x188075C30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8075F10", Offset = "0x8074B10", VA = "0x188075F10")]
	public PFBNLPGFMCB(EHENCINGLKE HHPCFHFLKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8073A00", Offset = "0x8072600", VA = "0x188073A00", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8074080", Offset = "0x8072C80", VA = "0x188074080")]
	public Vector3 KKOCDHCNOLL(int DFLLFMHMLAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8073A60", Offset = "0x8072660", VA = "0x188073A60", Slot = "6")]
	public Quaternion EFKBJCHFLLA(int DFLLFMHMLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8073FE0", Offset = "0x8072BE0", VA = "0x188073FE0", Slot = "5")]
	public Vector3 JMDBPLFPMAI(int DFLLFMHMLAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8073EB0", Offset = "0x8072AB0", VA = "0x188073EB0", Slot = "7")]
	public float ICFANJNHMEE(int DFLLFMHMLAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8075350", Offset = "0x8073F50", VA = "0x188075350")]
	public void NFNDPOGKDJE(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK, bool EGDCAHBBELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80739A0", Offset = "0x80725A0", VA = "0x1880739A0")]
	private bool DLKJPOGODOB(int AHJGONENGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8075D70", Offset = "0x8074970", VA = "0x188075D70")]
	public void NMCCDICKFDP(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8073760", Offset = "0x8072360", VA = "0x188073760")]
	public void BKIBLJMBJFB(int AHJGONENGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8074550", Offset = "0x8073150", VA = "0x188074550")]
	public void LFICDBNPENE(int AHJGONENGIO, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x80737F0", Offset = "0x80723F0", VA = "0x1880737F0")]
	public void DKMBPCBFKIO(int AHJGONENGIO, float3 FEMJLOIOGIK, quaternion DINDLKHALMD, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8073D60", Offset = "0x8072960", VA = "0x188073D60")]
	public void HMELGJKEOBA(int AHJGONENGIO, Vector3 FEMJLOIOGIK, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8073B90", Offset = "0x8072790", VA = "0x188073B90")]
	public void GJPFACADHJC(int AHJGONENGIO, Vector3 JMBLGBJKENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x80746A0", Offset = "0x80732A0", VA = "0x1880746A0")]
	public static Quaternion LIJGHHHDIIN(Quaternion HAGOIDNFICA, int AHJGONENGIO, float LICPNGJPDPO, KOACOFFPOFJ GPPOCCBIKEF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8074EB0", Offset = "0x8073AB0", VA = "0x188074EB0")]
	public Bounds MOHPILOIBIG(Transform LMGPODOPMIJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8073CF0", Offset = "0x80728F0", VA = "0x188073CF0", Slot = "10")]
	public virtual void HAOFCEICPEO(bool FJIDDEBIEAM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8073F10", Offset = "0x8072B10", VA = "0x188073F10")]
	public NativeList<FKNJJMFFJFL> JAKKOFAOMLN(float DPMABOLPPPF = 1f)
	{
		return default(NativeList<FKNJJMFFJFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GJOPJPLELOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public float3 BCBKGNPANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public float INHNPLLHFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public quaternion BBLCHIEHLKA;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x806C180", Offset = "0x806AD80", VA = "0x18806C180")]
	public GJOPJPLELOE(Vector3 ALEIFNEHIBI, Quaternion HAGOIDNFICA, float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x806C0C0", Offset = "0x806ACC0", VA = "0x18806C0C0")]
	public Quaternion IJHGPOPPMID(Vector3 DBIJDHDPOAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x806BC30", Offset = "0x806A830", VA = "0x18806BC30")]
	public GJOPJPLELOE EEMBDNNIOKG(Vector3 HLGHBAGIBJG, Vector3 MIDNAHIMNFO, Vector3 LJJLNPEEEFE)
	{
		return default(GJOPJPLELOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x806BF20", Offset = "0x806AB20", VA = "0x18806BF20")]
	public JJDGLEJGAMD EKMCDIGOADC(Vector3 DBIJDHDPOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EKBLHGKHPCC : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8069A00", Offset = "0x8068600", VA = "0x188069A00", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8069D60", Offset = "0x8068960", VA = "0x188069D60")]
	private void ICEMCGLKNLM(Dictionary<Guid, Guid> ODONALCLAEF, ECOEKLICCIB JKCAOJIPNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8069A80", Offset = "0x8068680", VA = "0x188069A80")]
	private void ICEMCGLKNLM(Dictionary<Guid, Guid> ODONALCLAEF, NDCFMBDKMMM FEFPNOKAFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8069AE0", Offset = "0x80686E0", VA = "0x188069AE0")]
	private void ICEMCGLKNLM(Dictionary<Guid, Guid> ODONALCLAEF, AAKCPGFFOEA IIHDDCGDNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public EKBLHGKHPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LLMIHDIBLEF : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8072330", Offset = "0x8070F30", VA = "0x188072330", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public LLMIHDIBLEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PFACFGELKKB : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8073600", Offset = "0x8072200", VA = "0x188073600", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PFACFGELKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HDOEPDDGEFJ : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x806C200", Offset = "0x806AE00", VA = "0x18806C200", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HDOEPDDGEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GFCANGLOINO : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x806BA10", Offset = "0x806A610", VA = "0x18806BA10", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GFCANGLOINO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GDMIFLDKOPH : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x806B8D0", Offset = "0x806A4D0", VA = "0x18806B8D0", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public GDMIFLDKOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NNNNOFLPCHJ : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8072FC0", Offset = "0x8071BC0", VA = "0x188072FC0", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public NNNNOFLPCHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class LHDDAACHCFB : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8072240", Offset = "0x8070E40", VA = "0x188072240", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public LHDDAACHCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class AFGKMGIOCFC : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8068E70", Offset = "0x8067A70", VA = "0x188068E70", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public AFGKMGIOCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class ANEBDBEEEGM : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8069030", Offset = "0x8067C30", VA = "0x188069030", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public ANEBDBEEEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PEDHCKJIBAA : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8073500", Offset = "0x8072100", VA = "0x188073500", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PEDHCKJIBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class OOBBCAHCJLF : DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public static readonly ICFANKKJIHN MHBGBJPMJJA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8073300", Offset = "0x8071F00", VA = "0x188073300", Slot = "4")]
	public void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public OOBBCAHCJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NNHECIEINDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public JLCEMONIDLM LAHAJPPAFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public OLMJEBKIAHL NEHLADHDNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public Dictionary<int, int> LIHPJCBFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public Dictionary<Guid, Guid> ABMIAACKNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public OIJNDPMJBOM MJNDFOHKLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public bool PHJEKGELBEN;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DFNPPMJOELK
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIMIBBMKGDG(JFGHOLLKGNA BHPOIHPPMKO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IBCGIHJJBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private static readonly DFNPPMJOELK[] POACMHKKODN;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x806C860", Offset = "0x806B460", VA = "0x18806C860")]
	public static void JIFCCMBILNJ(CMPHAOCHJPD CBCNBAPLLJM, KMDPEJAOLPJ FDCICPCGOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x806C5D0", Offset = "0x806B1D0", VA = "0x18806C5D0")]
	public static void ILIAHHNFCDL(CMPHAOCHJPD? CBCNBAPLLJM, KMDPEJAOLPJ OLALOKPGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x806C360", Offset = "0x806AF60", VA = "0x18806C360")]
	public static void HBHGKOBJDJM(CMPHAOCHJPD? CBCNBAPLLJM, KMDPEJAOLPJ FFHLMKMHNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x806CAE0", Offset = "0x806B6E0", VA = "0x18806CAE0")]
	public static void NDGCAPODIMK(JFGHOLLKGNA BHPOIHPPMKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JFGHOLLKGNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public JLCEMONIDLM DBPPANCMNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public CMPHAOCHJPD JFKNJMNMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public Dictionary<int, int> LIHPJCBFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public Dictionary<Guid, Guid> ABMIAACKNHK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8071EC0", Offset = "0x8070AC0", VA = "0x188071EC0")]
	public Guid OEGDBFDHPEO(Guid FHNOHJCOOKK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OIJNDPMJBOM
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LODHKLDKPDJ, [Out] Guid ALJHDEMNDNG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class JDMEHGMLPBN
{
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private static readonly HashSet<Guid> LDGGDLJLFKB;

	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private static readonly ProfilerMarker AMDIMOMJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly HashSet<string> LJNOMLAEAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly Dictionary<long, int> LEKFECIBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly HashSet<Guid> DMEADHCAIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private readonly HashSet<Guid> NCPDPHENFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly HashSet<Guid> MGBJGFOLGIE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> CBNBCIEKBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> EPEMLMNJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> BPCKDENFKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> HDIGIFCICKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x806FB40", Offset = "0x806E740", VA = "0x18806FB40")]
	public static void KBKFGEBABHO(MEEBHFOCAAH ONCCIKIMAAO, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x806E8F0", Offset = "0x806D4F0", VA = "0x18806E8F0")]
	public static JDMEHGMLPBN DHDLIELIBLP(HEBHGEKOEHP NBKNOAMHHFE, DPEFDBNMJNB? FCEAMOCFIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8070540", Offset = "0x806F140", VA = "0x188070540")]
	public static JDMEHGMLPBN KIDMHKKAEKB(MEEBHFOCAAH JKAFFEBLGGN, DPEFDBNMJNB? FCEAMOCFIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x806E1F0", Offset = "0x806CDF0", VA = "0x18806E1F0")]
	public static JDMEHGMLPBN BBEDLDNHJNC(OOFAOGBOCBE ACNGBGDDKFB, GBCAOKCHDGO ADEOCFOIFAB, DPEFDBNMJNB? FCEAMOCFIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x806E970", Offset = "0x806D570", VA = "0x18806E970")]
	public static JDMEHGMLPBN KBJGMFIGHKG(IEnumerable<string> LJNOMLAEAFG, IReadOnlyDictionary<long, int> FEMOCKIPIKJ, IReadOnlyCollection<Guid> MGBJGFOLGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8071D30", Offset = "0x8070930", VA = "0x188071D30")]
	private JDMEHGMLPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8071B30", Offset = "0x8070730", VA = "0x188071B30")]
	private JDMEHGMLPBN(IEnumerable<string> LJNOMLAEAFG, IReadOnlyDictionary<long, int> FEMOCKIPIKJ, IReadOnlyCollection<Guid> MGBJGFOLGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8071710", Offset = "0x8070310", VA = "0x188071710")]
	private void MPGHBFLJAPL(HEBHGEKOEHP NBKNOAMHHFE, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8071080", Offset = "0x806FC80", VA = "0x188071080")]
	private void MPGHBFLJAPL(MEEBHFOCAAH JKAFFEBLGGN, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x806E2B0", Offset = "0x806CEB0", VA = "0x18806E2B0")]
	private void BMDPDIBEJJJ(ByteString? AGMGLAJABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80708C0", Offset = "0x806F4C0", VA = "0x1880708C0")]
	private void MPGHBFLJAPL(OOFAOGBOCBE? OLIIIAEGOLD, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8070840", Offset = "0x806F440", VA = "0x188070840")]
	private void MPGHBFLJAPL(GBCAOKCHDGO? ADEOCFOIFAB, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8070C20", Offset = "0x806F820", VA = "0x188070C20")]
	private void MPGHBFLJAPL(GOBIDPAGOKN? HMOMOIIFGAO, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x806DE30", Offset = "0x806CA30", VA = "0x18806DE30")]
	private static bool ACBMBNKEADO(GOBIDPAGOKN HMOMOIIFGAO, int NKPGOBBGNMI, [Out] Guid JHCMDHOBALE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x806F830", Offset = "0x806E430", VA = "0x18806F830")]
	private static void KBKFGEBABHO(GBCAOKCHDGO? OLIIIAEGOLD, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x806F900", Offset = "0x806E500", VA = "0x18806F900")]
	private static void KBKFGEBABHO(GOBIDPAGOKN? HMOMOIIFGAO, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x806F050", Offset = "0x806DC50", VA = "0x18806F050")]
	private static void KBKFGEBABHO(OOFAOGBOCBE? OLIIIAEGOLD, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x806EA00", Offset = "0x806D600", VA = "0x18806EA00")]
	private static void KBKFGEBABHO(JLNKGAAEJII? PBBEMEGKFPO, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8070D60", Offset = "0x806F960", VA = "0x188070D60")]
	private void MPGHBFLJAPL(JLNKGAAEJII? PBBEMEGKFPO, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8070630", Offset = "0x806F230", VA = "0x188070630")]
	private void LOPHKDDANBK(Guid? FHNOHJCOOKK, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8071310", Offset = "0x806FF10", VA = "0x188071310")]
	private void MPGHBFLJAPL(CMPHAOCHJPD? JFKNJMNMLKG, DPEFDBNMJNB? FCEAMOCFIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x806F3E0", Offset = "0x806DFE0", VA = "0x18806F3E0")]
	private static void KBKFGEBABHO(CMPHAOCHJPD? JFKNJMNMLKG, DPEFDBNMJNB FCEAMOCFIKA, KMDPEJAOLPJ MIAMBKAOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80705C0", Offset = "0x806F1C0", VA = "0x1880705C0")]
	private void KPEJONILPIN(string? NPFFJCFENIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x806E120", Offset = "0x806CD20", VA = "0x18806E120")]
	private void ADGBMFAKEDF(long JOAHMDCKGCK, Guid JLIPGILNIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x806E0D0", Offset = "0x806CCD0", VA = "0x18806E0D0")]
	private void ADGBMFAKEDF(EGHDPKGBFPL? DFBANLGPNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x806E070", Offset = "0x806CC70", VA = "0x18806E070")]
	private void ADGBMFAKEDF(KLBCFNDKJIM? DFBANLGPNBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct FAHJKBHIOEC
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FNMPAPCPJML : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private readonly IEnumerator<DictionaryEntry> MBBNOHOAAJD;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry MJFGHOFLDED
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x806B6A0", Offset = "0x806A2A0", VA = "0x18806B6A0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object DICGCMOFCOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x806B770", Offset = "0x806A370", VA = "0x18806B770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object AHLMJDKCEID
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x806B820", Offset = "0x806A420", VA = "0x18806B820", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object ALGELFNIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x806B5C0", Offset = "0x806A1C0", VA = "0x18806B5C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
		public FNMPAPCPJML(IEnumerator<DictionaryEntry> MBBNOHOAAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x806B520", Offset = "0x806A120", VA = "0x18806B520", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x806B570", Offset = "0x806A170", VA = "0x18806B570", Slot = "9")]
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
		private sealed class NPOHCIGDOLO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x80732B0", Offset = "0x8071EB0", VA = "0x1880732B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public NPOHCIGDOLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8073160", Offset = "0x8071D60", VA = "0x188073160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8073260", Offset = "0x8071E60", VA = "0x188073260", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8079A90", Offset = "0x8078690", VA = "0x188079A90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object DHCHBFGMFFD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x80799A0", Offset = "0x80785A0", VA = "0x1880799A0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8079B80", Offset = "0x8078780", VA = "0x188079B80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x80798E0", Offset = "0x80784E0", VA = "0x1880798E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8079940", Offset = "0x8078540", VA = "0x188079940", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8079B20", Offset = "0x8078720", VA = "0x188079B20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x80795A0", Offset = "0x80781A0", VA = "0x1880795A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8079600", Offset = "0x8078200", VA = "0x188079600", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8079660", Offset = "0x8078260", VA = "0x188079660", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
		public RoomObjectCounts(Dictionary<int, int> OPIAIHKIJND, [Optional] Dictionary<int, int> GBGNPJLHBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80794C0", Offset = "0x80780C0", VA = "0x1880794C0")]
		[IteratorStateMachine(typeof(NPOHCIGDOLO))]
		private IEnumerator<DictionaryEntry> PEKCLBDBPBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8079BD0", Offset = "0x80787D0", VA = "0x188079BD0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x80797E0", Offset = "0x80783E0", VA = "0x1880797E0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80796C0", Offset = "0x80782C0", VA = "0x1880796C0", Slot = "9")]
		void IDictionary.Add(object DHCHBFGMFFD, object BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8079720", Offset = "0x8078320", VA = "0x188079720", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8079780", Offset = "0x8078380", VA = "0x188079780", Slot = "8")]
		bool IDictionary.Contains(object DHCHBFGMFFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8079880", Offset = "0x8078480", VA = "0x188079880", Slot = "14")]
		void IDictionary.Remove(object DHCHBFGMFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8079540", Offset = "0x8078140", VA = "0x188079540", Slot = "15")]
		void ICollection.CopyTo(Array COJHNLDFDFB, int LCCBBMBENOH)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class BBKEGPPIPMP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xD1C5C0", Offset = "0xD1B1C0", VA = "0x180D1C5C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8069380", Offset = "0x8067F80", VA = "0x188069380", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public BBKEGPPIPMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x80691F0", Offset = "0x8067DF0", VA = "0x1880691F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8069330", Offset = "0x8067F30", VA = "0x188069330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x806DB40", Offset = "0x806C740", VA = "0x18806DB40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object DHCHBFGMFFD]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x806DA10", Offset = "0x806C610", VA = "0x18806DA10", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x806DBF0", Offset = "0x806C7F0", VA = "0x18806DBF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x806D950", Offset = "0x806C550", VA = "0x18806D950", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x806D9B0", Offset = "0x806C5B0", VA = "0x18806D9B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x806DB90", Offset = "0x806C790", VA = "0x18806DB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x806D5D0", Offset = "0x806C1D0", VA = "0x18806D5D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x806D630", Offset = "0x806C230", VA = "0x18806D630", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x806D690", Offset = "0x806C290", VA = "0x18806D690", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x29FCD20", Offset = "0x29FB920", VA = "0x1829FCD20")]
		public Invention(long OIBGADINDDP, int NKGPOLKDIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x806D500", Offset = "0x806C100", VA = "0x18806D500")]
		[IteratorStateMachine(typeof(BBKEGPPIPMP))]
		private IEnumerator<DictionaryEntry> PEKCLBDBPBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x806DC40", Offset = "0x806C840", VA = "0x18806DC40", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x806D810", Offset = "0x806C410", VA = "0x18806D810", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x806D6F0", Offset = "0x806C2F0", VA = "0x18806D6F0", Slot = "9")]
		void IDictionary.Add(object DHCHBFGMFFD, object BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x806D750", Offset = "0x806C350", VA = "0x18806D750", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x806D7B0", Offset = "0x806C3B0", VA = "0x18806D7B0", Slot = "8")]
		bool IDictionary.Contains(object DHCHBFGMFFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x806D8F0", Offset = "0x806C4F0", VA = "0x18806D8F0", Slot = "14")]
		void IDictionary.Remove(object DHCHBFGMFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x806D570", Offset = "0x806C170", VA = "0x18806D570", Slot = "15")]
		void ICollection.CopyTo(Array COJHNLDFDFB, int LCCBBMBENOH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> BDMAIMNCANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	public readonly IReadOnlyList<Invention> LNPKIFEHOPM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	public FAHJKBHIOEC(IReadOnlyDictionary<Guid, RoomObjectCounts> HCGAHAKMHCC, IReadOnlyList<Invention> AABCCFPGHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x806A9F0", Offset = "0x80695F0", VA = "0x18806A9F0")]
	public static FAHJKBHIOEC DHDLIELIBLP(HEBHGEKOEHP NBKNOAMHHFE)
	{
		return default(FAHJKBHIOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x806B400", Offset = "0x806A000", VA = "0x18806B400")]
	[CompilerGenerated]
	internal static int OIOMFIGINJP([In] IReadOnlyDictionary<long, int> KAFAAFDPGGE, long? JOAHMDCKGCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x806A330", Offset = "0x8068F30", VA = "0x18806A330")]
	[CompilerGenerated]
	internal static void CBDHMPLAOHI(int DHLLDGOHMJJ, [In] OOFAOGBOCBE KDGIHOGLJDP, [In] Dictionary<long, int> KAFAAFDPGGE, [In] Dictionary<Guid, RoomObjectCounts> HCGAHAKMHCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LNHIPHCFHMN
{
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class DPEFDBNMJNB
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class IMONKPFDKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public readonly Guid DCJPDBCDDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public readonly IReadOnlyList<Guid> EPEMLMNJDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public readonly LNHIPHCFHMN FHBGENBBKBN;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x806D4A0", Offset = "0x806C0A0", VA = "0x18806D4A0")]
		public IMONKPFDKPF(Guid LKJCKECDKCG, IReadOnlyList<Guid> MGBJGFOLGIE, LNHIPHCFHMN MEGBHLJHDNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	private readonly KMDPEJAOLPJ CJPGFKLBFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	private readonly Dictionary<Guid, IMONKPFDKPF> FHJCOMINGGI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KMDPEJAOLPJ GDPCGOBOIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8069750", Offset = "0x8068350", VA = "0x188069750")]
	public void NDGLNAHKHEG(Guid ACLLIJHIKKA, Guid KBLBHNANFLH, IReadOnlyList<Guid> OAHLDFHFGDK, LNHIPHCFHMN MEGBHLJHDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8069660", Offset = "0x8068260", VA = "0x188069660")]
	public bool AMBACNCJAMM(Guid CICCKHODDJG, [Out] IMONKPFDKPF HCPIIDJAMFD, [Out] bool AFCCLBCMAPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8069960", Offset = "0x8068560", VA = "0x188069960")]
	public DPEFDBNMJNB()
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
