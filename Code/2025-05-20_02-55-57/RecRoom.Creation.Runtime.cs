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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C123C0", Offset = "0x7C115C0", VA = "0x187C123C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BFKJAGBGGBM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GGKAEEIIKCM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> EJAKHHEOCPL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GPPGONLHGHF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> ODDJHJCHGMB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string PALJPHMPFHB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string IMLLFOMKAPD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string FINPKBBKNDC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDA10", Offset = "0x7BFCC10", VA = "0x187BFDA10")]
	public static bool FMJOKBFLALL(Guid MGKIMHHCDHB, int OBGGCDIAFBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDB10", Offset = "0x7BFCD10", VA = "0x187BFDB10")]
	public static bool LDJDEIPFGOG(Guid MGKIMHHCDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD390", Offset = "0x7BFC590", VA = "0x187BFD390")]
	public static string DIEOICDJLFI(Guid DIHOLCNHIND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OFPMDHJEEGE]
public enum ANACAMFOHLA
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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C12330", Offset = "0x7C11530", VA = "0x187C12330", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EBMKIBEKKGA
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KEHEGFFPPEK;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid IDNJIGAPDCJ;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid DPCKOGKAFKF;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid DPCDDBKJMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid DPAIGIOJDON;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid ACEOCIIBJAI;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid HECBGKKPHOM;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid EJNKNAADNAC;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid MIAOIABHCNB;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MDDLBENANNO;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid FIJNFCAPKBM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FKKBOMEHMFI;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid HILCOBADAPH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HBCOPLFGCJD;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid GGJNIMGDJLJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DNEHENPELMD;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KKMOMJIFNHF;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid AENEFOHGLBA;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid IGALKGEABDI;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid IGJDJOPKEDK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid PPIPHNBDPKG;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid PFBIGNOALCA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PCCDDANMGJF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid EHBMCIDHNOP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid IDDHJCFMJCI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid FEDPFBCDHON;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid PJFINNIFCGD;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid NMHCBPEEOFL;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BKEECMOONLN;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid KPJNKCMDLKO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid KCBEEEGICNN;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid OIEDAAFBOCF;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid IHHLLOJMDJH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid KHADMLJCGJJ;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ACHMCLLMHDH;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FDDDGJEJLPP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NPDKBGKHFAN;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid DHNEGDLEKMI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid GGPEEGGIEAK;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OKPOMCGBAMM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid FONHHANFPIF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LBMKBNAKCLA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid IHAMEHLMMJN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HGBDACDMOMB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid IFPLKHPGHAB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid KDBGEHICJCK;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid NEFBGAMLHCI;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid PONLDODGAGJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid OPIAPFFEKNB;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MDCOHIGEHGK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid HJKCIOGMBJH;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid AAFMPIGFCLH;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid BGPCCLCDDJK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OHLIEMLENLF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DOLFHJOFGBP;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid IOKELANANGK;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid DCGJGCBLOLK;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid NAAIIEOEOMN;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid OCOHJNOGAKE;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid ODJLHKJBGLM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PFKMOIIBCMA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HFEHLPFEBFJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid ENKGNJFEBPL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid DENDDIMBDJP;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NMFDPNNIIMN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MKMHBHMIGEG;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BNEFMKPHMLB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KJBBIAIPDLB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid ALHFCJEHAON;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid JBMOJEMEFAI;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid JCEHJLFHHNP;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid MNJHIDKNIFO;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KIOJJHPIKMA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid DCFPADNCKJF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid KDOEPICCKMP;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EENENPEADIB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid LBEINMBBIOO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid IKCPLGENBON;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KELLCKNBOEB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid FLOPHIHPAFD;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IDKOMBOEOKF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid BOLCBBNMMCE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid CGKDGOOPNBE;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid FLDMEOPINOB;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid OAHEGGPFHNA;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid JODGEDFBJHP;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid INAHFDGGGAK;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid FEGCOFLEDIO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid CEIDIDAMBNL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid AFGKGBNFDPL;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JDHNDLEDICH;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid ALBDNFNIEMG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GJMNHHDCCIF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid APHLGBKOJFE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FOFHJKHHHGI;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DAOKBPIICMN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid OBCCEFCPAKJ;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid MDAEMJJCJPK;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid FGPACCNDLLO;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid BGMKGCHDLHC;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AFGOFBOHEDD;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid OLAMDAGGIIB;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid JIHPKALFPKF;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PLGDCPJAFBK;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid KJOGHACFMFE;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PJEMCPMHMDH;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OEHOLPEJKPE;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid KMEIEIFMPOJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid PHDGDKIMNFB;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid PMEEICACBOH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid PHPDHBMNJFG;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IJAEFIOPBID;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ICKEJGBIEAA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FADCOIPBLEK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NMFBNJFIJNP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid BAEMOBBJODN;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid NKOIGJPAHEC;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EPDAHHCHHCO;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid NKJLHEJKGLE;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid KINDICCALOH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid DHMJHHGIPDI;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DIOHOPGKIHD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid LCLNOFFAMEE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FDBEJNJOIBG;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid COFLMGJGNIJ;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MHDIKLAEDAC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MANBELCDFAP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid JJIONOGHLIK;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid HDMCMAMCJBB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid DGMPJIFBMOL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid EBFKLJDFDDG;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid OBIKIDMHHJK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid NFLNDIEAFBJ;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid AEOHFOKEPKL;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid NJFIEBCMCDG;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IDGLHBDHNDD;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MBMIENHKMHN;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MAHJFBCFHJP;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid LIEOLDKLECP;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid FCAMKNAIMDG;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LLMGEGJOPKB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid AJPJKIGHCMB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JIFLIEPMHAP;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid NELHOONIPOL;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid GGHKDKMGJJK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid JJGNLDDLAJE;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid KBNDKPNBJIN;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CKPCOBFFMOI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HHEOMKMJHCP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid NMBMGIJGIAP;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid KPMHONOHJNA;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid JPFOFIFDEIG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid FOJBLGMJIJN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid KAFINKOJHFB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DCIGMDBAGIN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid OJCPDIGAMGL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PBCGNIPMICM;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LKOGMJCMCBO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid HKNHLJKDCMN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DLLJLPDDIAA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HOKLJJEBBLF;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BFGILEBFNAB;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BMFFDKEJFHN;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid AHKJNJNCFJE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid INALIFNDDHO;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid JNPGONHGOON;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid FMDEPGMILOJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NCGAIMCAMCD;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid NFGICEFBHHD;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid MFLBHDKFKGP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid IHALGEIGCPH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid CEMOOIBDIDD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BMBLMAALBNK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid AGDCPHPMIGD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid NIBENOIINNG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid ECLKJAHAEHE;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid CAGONCEJGFO;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid DEOFJNENEDM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid PAFPLKHBHNB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid NGECJCJNLEA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid EHPLPLOEJHL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid NPBOJBHNKDA;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CDBMFBBMEBE;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid LJNPCOJIJAN;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid JIJAAFHEGKD;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HEAOLHCMOMM;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PCODEGENPAL;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid LMJOGBENPIL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid EDABCFKELFL;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid GGJMFADPHME;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid EBNJOCHNCDL;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid DBIOMOMAPPO;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JCIJEPLOMPB;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid IMHGINAGAIO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid ALNFBPAPNID;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid AFNIDOJDJGA;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid AJAJGJEMKDD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid IINPIEECHKP;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NJPGKPOGELK;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid PADOFMOCECN;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid LLPBABOPLND;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KGAKOPKJEDG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HDGBOKKENFJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HGICNJLPNMM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid GELFLKGGIOC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid HDLOKPDLEBB;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid LDJLCAIALHC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid NDHCDLOMDGI;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid IANMMOKGFBK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid GDBEMGGLEOP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid JLDPIJKCABC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid OJLGPMCAONJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid JDLABHBFHJE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GHPKGLJAKLF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid LDNAGKDLJNO;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid NONGNKPPPLG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DKPEMAOHDOG;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid APPCMHNLFCI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid CPJIKCBAMKP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid HKEDDNOLGEN;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid DMNKONLOBHH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DLFAGMHPNNI;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EJMPGDNMEOK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid IBEJAGPKOGM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HGDILKFEBDJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid MNIKHEODOKI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MOHOKBEMEAK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid PMMBKHNGIDD;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid EADPILNLMNN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid HAPALEHIBID;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid FFCMGGLOLCE;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid MBKLFPOHLLH;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid EGEGAMEJGCK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid NDCKHLHAONB;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PJBIODABDDC;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid HIOPDCNOCBD;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid ENDJHGECEOB;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ALAGPBGCMLK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid CNHMJBFLAAE;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HGPNDBOKBDA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OAOELNOECFI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid NJLFIFFPJMG;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid PGBPPNNPALC;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid NLEDEBAJPMK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ALLBNHFEACJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid GJGJLKNBPIB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid BIBFICIJGMF;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid LPBMOGGNPHI;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BJLKMEDMCKF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid EEGPGOAKAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IILIDIOEOPL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid KMLOHMKCAKP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid EMEOGBPJAEC;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NHHADBLNGMN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid ICHHAIDBNPF;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid EABIPBOLGOB;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid JGGFAIMPBEG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid KFIDHCFBEDJ;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid DKLCALIDPJE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LODBHEGGGGP;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FHGJHHIGOFA;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KIKLOEPIBOD;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KBOGJPKNHCA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid DJMBEJIPKFH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GKIMEAJPHDK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid CGFKNMPEODP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid GKNIKHIGNJF;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid HHLDMLJGEIH;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MMIMODLFBDM;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid GCFJHKCAAMH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid KCPLDNLLAIE;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid BJFABIJEEPJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IFINCLPMKEH;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid EHBNHNBBHKE;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid GBLALGEBOOD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid JBOFIGNPJMF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid FPBCNIBKPKE;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CCIMHDCIKHM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid APEMGFFLGEG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid DAOCFADEOPM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid KGAJAJDCIKE;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid GCLALJABDNA;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid GOFNAOHIHEN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FEDEPDAHDEG;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid GMNKJAEANDL;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PBPGJMEACDN;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid NMCAEEKFIJA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JDOFAIJKKLO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid MMMLDHIDPMF;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LBEIOLHCDPH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MOJAIKDPLJE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid IEBCNKDFAIJ;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid JJDGMDFNEJD;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid LKPCIAELIEG;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid BCKGCNKBHMJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid GOLNHOCGJEP;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid BCLJGJKPNOF;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NBHBGECKMHP;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FCCMOOOIBCL;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid AKAFDOAKKJM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid OGIFDLLIKCO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid AMHBEMGJMNK;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid NNEFPMNGJPK;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid DFIMFBNLOLN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FDMKDBPFLKN;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid MDIMJPPDJPN;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid FGBJDGPLDBC;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid AKKCNJJMLCC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid EGGMGAOAEHK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BBKMOLCDODM;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid MGJJKIAGCFN;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid AFDCGNBIKBP;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid EDLHOKFNOBA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid INKPJKHGIJM;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BBIAELFJLGG;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid AJOGMCCJGEB;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid NPDLADMAJPI;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid CKJKJFMAKPG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid PHPJFOKFGEP;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid HOEMPBCAMJF;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid FCJJHICMIBH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DFEHBEMBEJL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NOPAKCFECHP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid GFDOJPOCJFC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid CCECPGAPPEC;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid IAGDDIIPPPD;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid JBABEIIIJDH;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GGAICNLMNCJ;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid BFBHDIPDGNB;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid JEEMCPPHLFD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid JDCBMMABOON;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid ADHBLPIGDNN;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid FLPBEOMKMBD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid NOIOMGECCPO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid JHHBIGPHHHM;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IHAECKOPNAJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PEDDMOPFLPN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FHJJKJGCAON;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DLKMDEKGHIL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid POFMJPMKHCB;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HIMHLEGKMKA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid KNNFJNGDLDG;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid KHALMGDKBIE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid GEJEAIJEFPB;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid JDPLJGGGAFI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid PHNBLAJIADP;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid DLIMPAMIOOO;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid GKKCBFCCMEO;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NFKKOMKDMDG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid FBHNLOHPLCP;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid JNGDGIABJGK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid FIEJEFBAFCI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IBGOCMMJFFO;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JECGHNNFPLL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid IBFNBBNHKPO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid IPIGLMCEDHB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid LFAEHOFAHKF;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GMFNELEKEKM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid MEDHHPFCFOE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CNHIKNOCFJA;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FDABLNODPMG;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid AJIFAJOBCML;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid EGPKNCHFMOJ;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IIAFOEDLMIM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DHGJHIEKJBD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DOJPGHGCPEA;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid EEBLCLFGODC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid NAFDFJIIBFG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HDKDDAMDKOD;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid JHAHMPFKGAG;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid ACIFFDGKKCF;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid EAAAIMDDKDM;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid EKMANJHGJCD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid EEAOFDFNOBC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid PLNANIMMNBD;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid IPFDNJCNGBH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid CHOHHNKMIJF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FNLOPPJBCLH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KNGHHFJPHAO;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid FIFDFILAKGE;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid PDOIIKMIKGL;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid BDMMCDDMONO;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DFBJHOALDOB;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid PFEBCOAHHCD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid PFPMPMEOMCP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid PMPLFDFBCJF;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DLDGHBLKNLF;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid DGBLHLMJKGG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid ACLOLFEHKHP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid BJOKBGMAKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BEIHGFIPHHO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GKKBKBIGJGN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid GMOAKCFNMJN;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid KCCBGMOODLD;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid OHAKHAECOOM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid OPECJBCMDHF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid FEGJMOCKKIP;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid MCDGEDDNDKD;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid APHEEDDAEEP;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid HILEACCJFAO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid AKJABILPPNO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid KMKGIKAIENG;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IABNGDMFOJM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid DADFCBBJMHH;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BENJOEHKBBK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PFGKHEOAGDP;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid ODPOEOOEMAD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid ANEEOIBGCCD;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid IKPJLACEBKD;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ONDPOIBDNBF;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FNLNPCGFMBP;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DONNGGCDELL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EIFNHJCFAPO;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid INCLCIEPIBG;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid MMIMDJNHCEN;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid APGHBKOOHBH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid FJMLANNKMNG;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid CNKCJNHLHBB;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NBFDOOADOLD;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid CPFONNCOAOI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid NGFMOJOJKAI;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid GFECDEKFOED;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid HEBPHBGKDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HOGPENAEKEI;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid OKHHELMKNAP;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PNAFMALNKLC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid IPCAENODONJ;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid PMGAIAAJDKF;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NFBGKDINBDE;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MOEDOJIACJA;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid ELOMPONBBMI;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid AGECGLGCJOB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid ELDEDEGBAPF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid AHKNEMFNDBL;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PKBNCBMNGON;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MKNFILBOKMP;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid IBCCCLFGIJC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid HJMODPPLKDB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid LBDPKEMNKCB;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JEANPDOAIMN;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid KPGELDLMDHB;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid JILMMOOMDKO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid HDFJEEOFADK;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FANCGDGOEGK;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid EPKECKFDNEB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid ABKMCKGJJEO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid ELIMIOGPCAO;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid EJIJIHCMFDF;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid KFPIMBDAELA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid PNNDMJJCCKB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid HOBCMEOCLNP;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid LPEOOLALIPC;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid CKPLFAMBDAI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid MMEEKJGIPMH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid DEOAKDIBJKB;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AMDKJFOCJOH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MFCLGIAGHCD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid GBKIMJKKNJM;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JDCONMELBGA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid EJLMFCJGOCP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid IDMDBGAONJM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid LEHGMPAKBFP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid HJCHKNBPJGH;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid LLFMHMNMONB;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid MFDGOBIIBMD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid POKBCIDEEOM;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid LOPJEMMBGIP;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid FLLIBJHLKIN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FBKEBLJIACN;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FEMHGBIKHIE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid IFHHEIPDJEL;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid AELPFNBAFGH;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PFMMLMIMJLL;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HGFJIDAKCAK;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid NNENLLJCFPH;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid CDOKOCCLCDP;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HJABJOJNGCH;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid GDDDKCJCDGM;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid LHCIFKBCCNF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid LAJIJDJEPAG;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid KPCBAMBHNIM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OPIFGGAPPNE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid LCJABMBAGFI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IKKDMCEIAMM;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid NDPNDPBMCEH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FAGGCKMFKJK;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid JOCDHCKBBGN;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid DJJAODFMJPK;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IOOCKAJJLMB;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid EKAOGNIGGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GGJGFBOKFDG;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid CLBDCOPDHBC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JPAKHKBNNGP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid KNOOCPEAFKD;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid DLNJKKHKDHP;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid IJIOBFNGAKC;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BDPENAFCPBC;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid DPFAINEIIAA;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid IKKHICOGHGF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid OHKAFNBKPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid OFEJJHFIDDO;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid OAFFGPFNFDN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OAECLJEDADA;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OIOPBMJPIGG;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid POKGAPIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid MNGOOIPELPD;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid NAKJPNGLAFD;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid PEGFDLKPCMO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid BHAIHFCCDME;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BGCCCPKJNJG;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid DOKNEGIPPCA;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MOCABIHIENB;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid GLHIEFKHKFL;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PCFABNDJEOC;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid DKJKDPBFMGO;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid IDFBMGDLBDK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KELGFLLNAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HHMLLAIMFCG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid LDKLDDGEEGP;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EAHADDLHLHB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid BMFKAAJIOAG;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DOBADFMPGKB;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HBJNIOMNINA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid PKMJBBNAPEF;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid GHEKAAGEBPH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid CIGLFMCBDHB;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid ONJGGMBKJBM;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid OOBFMDNPGPD;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid MAFEDCHENHH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JIGDILGAJLF;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid FIBFMIELFLA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid NILAOPGIKHI;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid AFMJHJEMCCB;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid IPBFMKLMGMO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GNKHFOJFAEE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid DDENICHLKLE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HKADCBHDNED;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid AGNKCPEFMML;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid KIDMDHNPCHJ;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid DINJJJJJDDC;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid NCGPKPNLBPJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid JIIENDHCBKH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid OPJDBFFPLAK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid MIDOAOLHMLG;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DBKFDAMBNII;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid KIGMBDFMNEI;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid CEPAJODAIGI;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid KKDNBPABKON;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid KGDDHOJBBCI;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid LAKPNOODMHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid GMDDCJHAGFL;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GAFMCJIEEFD;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid ALHGDBFFHJB;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid NKBBGLEBHDM;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid PCOKPMPPIHG;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid AENENDPHLGJ;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid POCAGOBELHE;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IMAMOGLEJFO;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MOCBBIFEMLP;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid LNLOJJNMJCA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid OEKGMGFFLLC;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid LKIBLGIMMLO;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MIJFBJCDNNA;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid JFNEILFNJPG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid ONGCLCEONMP;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid BAGKKOANOKO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid NCKEHCNNKLB;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid AKNGODIGJJI;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid EALPIPELDDK;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid BDFODLNBOEG;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PGKBNMONILO;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid MNHKEKBNFJB;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IFANODPMGKL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid PHBJNOMJFFH;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid KMFANKDNDFI;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid CGDOOOHBPMM;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid BPKPNLGNLLK;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid GDIFLCLLHOA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid AHEGIAHBBDO;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid LMKACCGGOCB;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid EADIIPDHALG;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid OACPPHGNMDL;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid DIFDPPJCINF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid POKPHEDPMGD;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid NLIOOIPHDNI;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid KHONMIEOJKG;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid FPLJNKGLOIC;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid NDEKEIBGOKE;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BFCECCGCIAA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid DEHNKNJHBJN;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid BLHKLBINONN;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid DFAPOAKJHCB;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DOBOKALFEAG;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid KBGMLMIDDLP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid MHICBOPAPJB;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid ALAMJEJEPID;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid AEGBJPLFODL;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid CAFMLHEMPMB;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid ECCJDBCNEAP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid IGIBKHLNPFE;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid NGJFGGDPAKB;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid GAOBLCALHMF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid MBHINDMGFKD;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid KNLFOGGKKMD;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid PEJKFGNMNOE;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BLALJPGNEME;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JGGFHDKGGEK;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid LMEDHMHBJPO;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid LEBMMJHDGBA;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid BFEGKFGAMLB;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid NKEBFMOPMPA;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid COCGLIOEDLF;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid IFLKEHGGHCB;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid MCPFMMLEPME;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid GLAIHDAIHFC;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid GDOIFIOKCAF;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid EDJEKFIEEGO;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid KNILAGBAKFC;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid NLADBCAKFHD;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid PDOKADLOICG;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid BFFPKGHBAAC;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid OIPIKOHKBDP;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid JDOFNIMOKEA;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid IAMKLBDNKID;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid FEPFGBDOKNH;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid BMHIHFHLEGI;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid DIADAEJFKEC;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid OABDPPGLPLP;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid GCAGIELMIJA;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid OLLBGOJDAFL;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid DGBOGECEHIO;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid LCNBMFLKIEG;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid JIFFCNOGEAO;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JGLMOPKCCBC;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid LEPMJDLEFNI;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid AGLPNALFDPA;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid FBNKGHJJMHO;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid CJFKJPPLKKN;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid OBNKAILJHMO;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid CLOMOODLIHB;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid GCJEODMJKJN;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private static readonly Dictionary<Guid, ANACAMFOHLA> ALGGFODGKIN;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private static readonly Dictionary<ANACAMFOHLA, Guid> NPMEMDNNPMP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, ANACAMFOHLA> LBJFICKDNPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E3C0", Offset = "0x7C0D5C0", VA = "0x187C0E3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<ANACAMFOHLA, Guid> NOAFAGKBJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E410", Offset = "0x7C0D610", VA = "0x187C0E410")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OLMOJOOHKAF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C127F0", Offset = "0x7C119F0", VA = "0x187C127F0")]
	public static bool AGOBCNHLKJD(FJDOMGHCOPK CPKLKMEAOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C12440", Offset = "0x7C11640", VA = "0x187C12440")]
	private static bool AGOBCNHLKJD(KKLPCIGPLCO HHHCEJKIPDB, FJDOMGHCOPK CPKLKMEAOAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface POECMDKCPGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JJBJKECGOCF DHAOEHNLNON, [Out] Dictionary<int, int> MMBFJHNKHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(PHALJEJMFGJ IFGMDEPADLO, PKGLDEPIDCL JDEOMKNPHPI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LMPGELJPMCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly DJAFKPAFGEF HACLAOOGNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly IEnumerable<AOAEIBCNJOH> AILAECKEPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly IReadOnlyList<AOAEIBCNJOH> GNEHFALMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly JFIBBLJIDCN<JJGKIIIBOJJ> HDJCPMMNAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> EHFCOBMHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly PCFHIBGFAHG LMKFAEALPJF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JCPNDKEAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C122C0", Offset = "0x7C114C0", VA = "0x187C122C0")]
	public LMPGELJPMCH(DJAFKPAFGEF IKLABGOFMGK, IEnumerable<AOAEIBCNJOH> JLIIGFHECCJ, IReadOnlyList<AOAEIBCNJOH> ECKCMMMGBDO, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> CJHJIDCGEOP, PCFHIBGFAHG BPPEGJEBCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HKPIBBEGCKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly DJAFKPAFGEF HACLAOOGNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IReadOnlyList<AOAEIBCNJOH> PLFCNBGAMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly JFIBBLJIDCN<JJGKIIIBOJJ> HDJCPMMNAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> EHFCOBMHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly ByteString ABINJGJKGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly PCFHIBGFAHG LMKFAEALPJF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C121E0", Offset = "0x7C113E0", VA = "0x187C121E0")]
	public HKPIBBEGCKL(DJAFKPAFGEF IKLABGOFMGK, JFIBBLJIDCN<JJGKIIIBOJJ> NJPHHHODCEO, IReadOnlyList<NICODLFMDAJ<PKEJDDGKOJK>> CJHJIDCGEOP, ByteString DBPLBMLNFAK, IReadOnlyList<AOAEIBCNJOH> GIODNEHKDOF, PCFHIBGFAHG BPPEGJEBCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ELLHDKFFHGJ : AFLPOFHFKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly Guid OAKENBFPFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private readonly Dictionary<Guid, Guid> JPGJDFDDJJG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x492FCD0", Offset = "0x492EED0", VA = "0x18492FCD0")]
	private ELLHDKFFHGJ(Guid FMEDMHHBPEM, Dictionary<Guid, Guid> JPGJDFDDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E9E0", Offset = "0x7C0DBE0", VA = "0x187C0E9E0")]
	public static ELLHDKFFHGJ OIKMHICCLEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E8B0", Offset = "0x7C0DAB0", VA = "0x187C0E8B0")]
	private static Dictionary<Guid, Guid> HPOIDONBBLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E460", Offset = "0x7C0D660", VA = "0x187C0E460")]
	public static ELLHDKFFHGJ EEJCCEKCODG(IReadOnlyDictionary<Guid, Guid> JIJCOIBMMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EA70", Offset = "0x7C0DC70", VA = "0x187C0EA70")]
	public static ELLHDKFFHGJ OMAMMJMDHGE(IEnumerable<KeyValuePair<Guid, Guid>> JIJCOIBMMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E960", Offset = "0x7C0DB60", VA = "0x187C0E960")]
	public Dictionary<Guid, Guid> INKFFPNJFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
	public Dictionary<Guid, Guid> OBLAKMEGNML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0ED60", Offset = "0x7C0DF60", VA = "0x187C0ED60")]
	public void OOLDDNFEGEK(Guid JIJCOIBMMGK, Guid PDBEAHFDFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E630", Offset = "0x7C0D830", VA = "0x187C0E630")]
	public void GGMHIHILGME(IReadOnlyDictionary<Guid, Guid> OAKLECIEHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E4E0", Offset = "0x7C0D6E0", VA = "0x187C0E4E0")]
	public Guid GGEBFGJNMLN([In] Guid JIJCOIBMMGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EDE0", Offset = "0x7C0DFE0", VA = "0x187C0EDE0")]
	public Guid PBGOAKFJNDL([In] Guid JIJCOIBMMGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E470", Offset = "0x7C0D670", VA = "0x187C0E470")]
	public bool EJCDHICPGGF([In] Guid JIJCOIBMMGK, [Out] Guid PDBEAHFDFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E470", Offset = "0x7C0D670", VA = "0x187C0E470", Slot = "4")]
	private bool GBGDEFCIMIB([In] Guid JIJCOIBMMGK, [Out] Guid PDBEAHFDFJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OJGIIGFPAPF
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
public sealed class DHMIPBKNGOE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LCOHBCHPAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public DJAFKPAFGEF staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LCOHBCHPAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C12250", Offset = "0x7C11450", VA = "0x187C12250")]
		internal JFIBBLJIDCN<KLCJLFMFFFM> IFILIGMELIH((JFIBBLJIDCN<JJGKIIIBOJJ> GraphId, JFIBBLJIDCN<PKEJDDGKOJK> NodeId) i)
		{
			return default(JFIBBLJIDCN<KLCJLFMFFFM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private static readonly ONBCILOGPEM<KLCJLFMFFFM, int?> CLHEDJKNPKI;

	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private static readonly long JIHLNOFLLID;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F60", Offset = "0x7C00160", VA = "0x187C00F60")]
	public static (long, long) KAGAHOHHNAD(DJAFKPAFGEF JELPMNAKAJC, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C00D20", Offset = "0x7BFFF20", VA = "0x187C00D20")]
	public static long AAOOKPLPODG([In] ReadOnlySpan<JFIBBLJIDCN<KLCJLFMFFFM>> IBNOAEMABPF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C00E40", Offset = "0x7C00040", VA = "0x187C00E40")]
	private static long GMCPEOIDHBD()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class APNKAEOCAOA
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public static readonly HashSet<ANACAMFOHLA> PHGONFKANAO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ENFGCNKHGMA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FCDGMIPIMAL : IEnumerable<AOAEIBCNJOH>, IEnumerable, IEnumerator<AOAEIBCNJOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private AOAEIBCNJOH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private PFKNPCJPLJC spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public PFKNPCJPLJC <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private DFKLELELEDN spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public DFKLELELEDN <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private AOAEIBCNJOH System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public FCDGMIPIMAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C17B20", Offset = "0x7C16D20", VA = "0x187C17B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C17DA0", Offset = "0x7C16FA0", VA = "0x187C17DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C17C30", Offset = "0x7C16E30", VA = "0x187C17C30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AOAEIBCNJOH> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C17C30", Offset = "0x7C16E30", VA = "0x187C17C30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F000", Offset = "0x7C0E200", VA = "0x187C0F000")]
	public static PFKNPCJPLJC BOJCBMOKAGM([In] HKPIBBEGCKL AHNBACDGHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EE80", Offset = "0x7C0E080", VA = "0x187C0EE80")]
	public static PFKNPCJPLJC BOJCBMOKAGM([In] LMPGELJPMCH AHNBACDGHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C10E10", Offset = "0x7C10010", VA = "0x187C10E10")]
	private static HashSet<NICODLFMDAJ<LNBOIECBEGJ>> OJHOJFNPBKC(IReadOnlyList<AOAEIBCNJOH> JBDOMHNKPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C11220", Offset = "0x7C10420", VA = "0x187C11220")]
	private static void OMAPFJLJJCD(PFKNPCJPLJC BPDBNHDGPAK, [In] LMPGELJPMCH CPFLLIJOBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F5F0", Offset = "0x7C0E7F0", VA = "0x187C0F5F0")]
	public static LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO> LGKFIENGAHC(PFKNPCJPLJC BPDBNHDGPAK, DFKLELELEDN KCIOJJHONCC, ELLHDKFFHGJ? KBFJKMLHGPM, bool EEFPAKJGJLL)
	{
		return default(LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F450", Offset = "0x7C0E650", VA = "0x187C0F450")]
	[IteratorStateMachine(typeof(FCDGMIPIMAL))]
	private static IEnumerable<AOAEIBCNJOH> FNPMIBMCNBM(PFKNPCJPLJC BPDBNHDGPAK, DFKLELELEDN KCIOJJHONCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C111B0", Offset = "0x7C103B0", VA = "0x187C111B0")]
	private static void OKNJPJPAKDO(PFKNPCJPLJC BPDBNHDGPAK, DFKLELELEDN KCIOJJHONCC, IReadOnlyCollection<ByteString>? ODKKEGNNEMN, IReadOnlyCollection<ByteString>? FDALHINBHHE, IReadOnlyCollection<ByteString>? KEGOILLGOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C11880", Offset = "0x7C10A80", VA = "0x187C11880")]
	private static bool ONOFCJFDFNP(PFKNPCJPLJC BPDBNHDGPAK, PHALJEJMFGJ IFGMDEPADLO, DFKLELELEDN KCIOJJHONCC, [Out][NotNullWhen(false)] string? KOIHEPAFBFG, [Out] Dictionary<int, int> MMBFJHNKHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F170", Offset = "0x7C0E370", VA = "0x187C0F170")]
	private static Dictionary<Guid, KKLPCIGPLCO> DOKNKLDLKHJ(PFKNPCJPLJC BPDBNHDGPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F560", Offset = "0x7C0E760", VA = "0x187C0F560")]
	private static void IBNJDALGLGK(bool FCLFFPNGOKL, AOAEIBCNJOH COAOCPHILMM, ELLHDKFFHGJ CKLPHNHHHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C11F10", Offset = "0x7C11110", VA = "0x187C11F10")]
	private static void PJMLHIAPDDE(AOAEIBCNJOH COAOCPHILMM, Guid PGKMPKPKBOJ, IEDEKHCLIHG? LOGIMELKDGO, Dictionary<Guid, KKLPCIGPLCO> ONKBFJJJGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C10960", Offset = "0x7C0FB60", VA = "0x187C10960")]
	private static void LIKGIODOOCM(IEnumerable<AOAEIBCNJOH> IIFGPBMGDJM, IReadOnlyCollection<ByteString> ODKKEGNNEMN, IReadOnlyCollection<ByteString> FDALHINBHHE, IReadOnlyCollection<ByteString> KEGOILLGOFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DFKLELELEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public bool FCLFFPNGOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public PCFHIBGFAHG BPPEGJEBCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public IEDEKHCLIHG? LOGIMELKDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public IEDEKHCLIHG? GGGPHJLJAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public DJAFKPAFGEF NKCKNOOFDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public OJGIIGFPAPF OFDIGNDELDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public POECMDKCPGJ KDIJKNNNNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public NICODLFMDAJ<JJGKIIIBOJJ> FMMIMFOFPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public KLOPJCOPMLK BOIGPPKIFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public List<AOAEIBCNJOH> POCKLEPKEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public NPBKHGDHPBE JPFOGGDGANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public GODBMLCNAEH CENPGDEDJPK;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IEDEKHCLIHG
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private const float LBIDHEBLLCL = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Vector3 BJHAAAPCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Quaternion PANMBKPFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public float MMIJFAFPOOH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 NDHLGFHLLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C19990", Offset = "0x7C18B90", VA = "0x187C19990")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS KPJDJAJNLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C198C0", Offset = "0x7C18AC0", VA = "0x187C198C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x13BA160", Offset = "0x13B9360", VA = "0x1813BA160")]
	public IEDEKHCLIHG(Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float MMIJFAFPOOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C19E10", Offset = "0x7C19010", VA = "0x187C19E10")]
	public IEDEKHCLIHG(UniformTRS KKOKGENLDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C19640", Offset = "0x7C18840", VA = "0x187C19640")]
	public static IEDEKHCLIHG AABLMGMPELA(IEDEKHCLIHG NJHDJGHEICO, IEDEKHCLIHG GGPDCCKOBDN)
	{
		return default(IEDEKHCLIHG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B70", Offset = "0x7C18D70", VA = "0x187C19B70")]
	public static IEDEKHCLIHG NEKLFDMHCNA((Vector3, Quaternion, float) DHAOEHNLNON)
	{
		return default(IEDEKHCLIHG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B90", Offset = "0x7C18D90", VA = "0x187C19B90")]
	public static IEDEKHCLIHG NEKLFDMHCNA(Matrix4x4 IBAMCABMNOI)
	{
		return default(IEDEKHCLIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C19D80", Offset = "0x7C18F80", VA = "0x187C19D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C19A90", Offset = "0x7C18C90", VA = "0x187C19A90")]
	public IEDEKHCLIHG NDDBJIKIIED(Matrix4x4 PMPOHKBNMIB)
	{
		return default(IEDEKHCLIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C19D10", Offset = "0x7C18F10", VA = "0x187C19D10")]
	public static IEDEKHCLIHG ODELJCFPFPL(Vector3 BJHAAAPCKLC)
	{
		return default(IEDEKHCLIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C19900", Offset = "0x7C18B00", VA = "0x187C19900")]
	public readonly ELIDMAMFOFN FKNAAIJEIEG()
	{
		return default(ELIDMAMFOFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DBGINLAIJEL
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DFKFAMKPDHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly LGFHGAIDFDL PMDIHHMBMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly GEFBDEPLDON JDJKLGJCMJG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1661190", Offset = "0x1660390", VA = "0x181661190")]
	private DFKFAMKPDHO(LGFHGAIDFDL HFFFCKALIAN, GEFBDEPLDON HGOICHECNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14780", Offset = "0x7C13980", VA = "0x187C14780")]
	public GDJCDAEPMMG PFKCHMKDJBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C14560", Offset = "0x7C13760", VA = "0x187C14560")]
	public static LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO> OIKMHICCLEP(BJJBLOIKLDP<GKPOGNMPJHG> HGOICHECNMM)
	{
		return default(LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C146D0", Offset = "0x7C138D0", VA = "0x187C146D0")]
	public static LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO> OIKMHICCLEP(GDJCDAEPMMG HGOICHECNMM)
	{
		return default(LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C14610", Offset = "0x7C13810", VA = "0x187C14610")]
	public static LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO> OIKMHICCLEP(string FLNOLADOGDG)
	{
		return default(LOAMJJJEMNF<ELLHDKFFHGJ, DFKFAMKPDHO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LGFHGAIDFDL
{
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DJDIDGIIBCM : IDisposable, DEAIOHIJNMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	private NativeList<NOFEPGIGNGP> CIIMCAKPAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private float BCMPJIENEDA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OMNIHJEOLPK FGBHMDOHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(OMNIHJEOLPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HGIEFCKNJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B54B60", Offset = "0x6B53D60", VA = "0x186B54B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BCIEFCOPCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B54B70", Offset = "0x6B53D70", VA = "0x186B54B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<DCENFCJJIBO> JFPDGDIDBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HGNCNJONNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C16E10", Offset = "0x7C16010", VA = "0x187C16E10", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float IGIKFIMAEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C151A0", Offset = "0x7C143A0", VA = "0x187C151A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C16FD0", Offset = "0x7C161D0", VA = "0x187C16FD0")]
	public DJDIDGIIBCM(OMNIHJEOLPK MJJLCGKEEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C153D0", Offset = "0x7C145D0", VA = "0x187C153D0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C15820", Offset = "0x7C14A20", VA = "0x187C15820")]
	public Vector3 HHCPNMCHGGL(int DLMCFJOIHHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C15650", Offset = "0x7C14850", VA = "0x187C15650", Slot = "6")]
	public Quaternion FIMMLHFJMFJ(int DLMCFJOIHHD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C15780", Offset = "0x7C14980", VA = "0x187C15780", Slot = "5")]
	public Vector3 GHKBGHFPEIN(int DLMCFJOIHHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C152E0", Offset = "0x7C144E0", VA = "0x187C152E0", Slot = "7")]
	public float CKINAFAFHGE(int DLMCFJOIHHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C162D0", Offset = "0x7C154D0", VA = "0x187C162D0")]
	public void JBKJKIFCBLC(Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ, bool MCFMAGOLIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C16BE0", Offset = "0x7C15DE0", VA = "0x187C16BE0")]
	private bool JIJBFFGINNO(int AJFLLHMIBFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C16E50", Offset = "0x7C16050", VA = "0x187C16E50")]
	public void NBFMNPCKJKN(Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C15340", Offset = "0x7C14540", VA = "0x187C15340")]
	public void CNDLBBHGOGF(int AJFLLHMIBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C15CF0", Offset = "0x7C14EF0", VA = "0x187C15CF0")]
	public void HJOEDPBDNMF(int AJFLLHMIBFF, Vector3 BJHAAAPCKLC, Quaternion PANMBKPFLFA, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C147F0", Offset = "0x7C139F0", VA = "0x187C147F0")]
	public void BDPHKIOEEKO(int AJFLLHMIBFF, float3 BJHAAAPCKLC, quaternion PANMBKPFLFA, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C15430", Offset = "0x7C14630", VA = "0x187C15430")]
	public void ECCIMMOAOFM(int AJFLLHMIBFF, Vector3 BJHAAAPCKLC, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C16C40", Offset = "0x7C15E40", VA = "0x187C16C40")]
	public void KPGPFIGPILP(int AJFLLHMIBFF, Vector3 PLEIILPBIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C149A0", Offset = "0x7C13BA0", VA = "0x187C149A0")]
	public static Quaternion BGILBHJBAKE(Quaternion GKAAOLAMBLP, int AJFLLHMIBFF, float APKHNJAGLCG, DEAIOHIJNMA CPALCMBPKAE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C15E40", Offset = "0x7C15040", VA = "0x187C15E40")]
	public Bounds IEMEMOKFCBG(Transform PMPOHKBNMIB)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C16DA0", Offset = "0x7C15FA0", VA = "0x187C16DA0", Slot = "10")]
	public virtual void MEPCHENHKEH(bool CGJOJDBGAMF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C15580", Offset = "0x7C14780", VA = "0x187C15580")]
	public NativeList<NOFEPGIGNGP> FFNEFFKBLLM(float AGEFCABHDDA = 1f)
	{
		return default(NativeList<NOFEPGIGNGP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DCENFCJJIBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public float3 PHGICKGLDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public float AMBCENEAEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public quaternion KFPJPELDANM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C14330", Offset = "0x7C13530", VA = "0x187C14330")]
	public DCENFCJJIBO(Vector3 IOHMIDHCEGD, Quaternion GKAAOLAMBLP, float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C13DE0", Offset = "0x7C12FE0", VA = "0x187C13DE0")]
	public Quaternion GCOMKNMJAOL(Vector3 ACBMNMFGAEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C13EA0", Offset = "0x7C130A0", VA = "0x187C13EA0")]
	public DCENFCJJIBO JNEEGPJGHDG(Vector3 CEOBKNCHKJC, Vector3 KIFABPJMEOI, Vector3 IEMHBAJHFJE)
	{
		return default(DCENFCJJIBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C14190", Offset = "0x7C13390", VA = "0x187C14190")]
	public CANKABONALO PEJHBMHPAIM(Vector3 ACBMNMFGAEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class EKKJFKGEDBI : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C17AA0", Offset = "0x7C16CA0", VA = "0x187C17AA0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C171F0", Offset = "0x7C163F0", VA = "0x187C171F0")]
	private void DEHCHFEKINP(Dictionary<Guid, Guid> BBIEKBGDLFG, FNBHNANNBFK CEHENAPHMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C17A40", Offset = "0x7C16C40", VA = "0x187C17A40")]
	private void DEHCHFEKINP(Dictionary<Guid, Guid> BBIEKBGDLFG, KGFCNHODOEN OOCDNCHBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C177C0", Offset = "0x7C169C0", VA = "0x187C177C0")]
	private void DEHCHFEKINP(Dictionary<Guid, Guid> BBIEKBGDLFG, NDLHKOMJLIF NKFMGPGFGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EKKJFKGEDBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FFANMNOLGMC : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C17DF0", Offset = "0x7C16FF0", VA = "0x187C17DF0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FFANMNOLGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class KKELOEICNNN : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AF70", Offset = "0x7C1A170", VA = "0x187C1AF70", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KKELOEICNNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KLCEJPGMAOC : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B0D0", Offset = "0x7C1A2D0", VA = "0x187C1B0D0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KLCEJPGMAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class CGHCDFHNLPE : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C13BC0", Offset = "0x7C12DC0", VA = "0x187C13BC0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CGHCDFHNLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class FMIJBIMMOAN : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C17EA0", Offset = "0x7C170A0", VA = "0x187C17EA0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FMIJBIMMOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EFCAJKIIJLD : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C17060", Offset = "0x7C16260", VA = "0x187C17060", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EFCAJKIIJLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GBJDHCEFBOB : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C17FE0", Offset = "0x7C171E0", VA = "0x187C17FE0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GBJDHCEFBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KNDGMAPBNJN : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B230", Offset = "0x7C1A430", VA = "0x187C1B230", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KNDGMAPBNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DCENLKHINKL : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C143B0", Offset = "0x7C135B0", VA = "0x187C143B0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DCENLKHINKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JBCGECAKCIH : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A9A0", Offset = "0x7C19BA0", VA = "0x187C1A9A0", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JBCGECAKCIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class JGOLCABIANN : KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public static readonly NLBGJBCPFJK GNEBIGMAFMP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AE40", Offset = "0x7C1A040", VA = "0x187C1AE40", Slot = "4")]
	public void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JGOLCABIANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct FJDOMGHCOPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public PHALJEJMFGJ COBPGHDNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public NINHFMBNDNP JBMAEFJAELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public Dictionary<int, int> KIHFEIMJFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public Dictionary<Guid, Guid> NDBDMNKFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public GODBMLCNAEH CENPGDEDJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public bool EEFPAKJGJLL;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KDFFCNDGAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCHINIBCLCA(GGACLKAIFNG HAKBKGJFFFL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IBGJIJOGJFH
{
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private static readonly KDFFCNDGAEJ[] LKICAGKPHPL;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C18DF0", Offset = "0x7C17FF0", VA = "0x187C18DF0")]
	public static void NJLANIPPHIA(AOAEIBCNJOH DHAOEHNLNON, ELLHDKFFHGJ FMAFKGFJNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C18B60", Offset = "0x7C17D60", VA = "0x187C18B60")]
	public static void HENIJGDHKJJ(AOAEIBCNJOH? DHAOEHNLNON, ELLHDKFFHGJ PGMAPOKBDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C188F0", Offset = "0x7C17AF0", VA = "0x187C188F0")]
	public static void EOKEICFKBCO(AOAEIBCNJOH? DHAOEHNLNON, ELLHDKFFHGJ CKLPHNHHHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7C18520", Offset = "0x7C17720", VA = "0x187C18520")]
	public static void AGOBCNHLKJD(GGACLKAIFNG HAKBKGJFFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GGACLKAIFNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public PHALJEJMFGJ KIKLKPONMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public AOAEIBCNJOH COAOCPHILMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public Dictionary<int, int> KIHFEIMJFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public Dictionary<Guid, Guid> NDBDMNKFLIC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C180D0", Offset = "0x7C172D0", VA = "0x187C180D0")]
	public Guid ALMMHBAKCGH(Guid DIHOLCNHIND)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GODBMLCNAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int JEEOIOLKEGL, [Out] Guid HECNAMCNIBE);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LBBAHHNJLGB
{
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private static readonly ProfilerMarker LIKMLFEKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private readonly HashSet<string> OGOKDIIFKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private readonly Dictionary<long, int> MHNKIHJFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private readonly HashSet<Guid> LAONHFANPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private readonly HashSet<Guid> MHGJCMDHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private readonly HashSet<Guid> AHIDAAHILKM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> EBJMMHGKBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> DPKKCFCOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyCollection<Guid> HDIGODHPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<long, int> BGOCECMLFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B8F0", Offset = "0x7C1AAF0", VA = "0x187C1B8F0")]
	public static void DOOPCBACMOD(PFKNPCJPLJC BCGEDBKAFAN, JEEMOCELCPM HAOBHKHONFC, ELLHDKFFHGJ LEDEKAFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CE80", Offset = "0x7C1C080", VA = "0x187C1CE80")]
	public static LBBAHHNJLGB NDHLEIJCFGJ(CBMANFMCNIJ GIKGHELDAKC, [Optional] JEEMOCELCPM? HAOBHKHONFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E320", Offset = "0x7C1D520", VA = "0x187C1E320")]
	public static LBBAHHNJLGB OCLGHDBEGAM(PFKNPCJPLJC KCIAAGAALML, [Optional] JEEMOCELCPM? HAOBHKHONFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CD70", Offset = "0x7C1BF70", VA = "0x187C1CD70")]
	public static LBBAHHNJLGB IHIFIJFFIKE(MOKIDEKEKAD JDEOMKNPHPI, [Optional] JEEMOCELCPM? HAOBHKHONFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CDF0", Offset = "0x7C1BFF0", VA = "0x187C1CDF0")]
	public static LBBAHHNJLGB MLBLLCINJEE(IEnumerable<string> OGOKDIIFKAO, IDictionary<long, int> PBOMPFNPMFL, IReadOnlyCollection<Guid> AHIDAAHILKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E660", Offset = "0x7C1D860", VA = "0x187C1E660")]
	private LBBAHHNJLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E460", Offset = "0x7C1D660", VA = "0x187C1E460")]
	private LBBAHHNJLGB(IEnumerable<string> OGOKDIIFKAO, IDictionary<long, int> PBOMPFNPMFL, IReadOnlyCollection<Guid> AHIDAAHILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D4F0", Offset = "0x7C1C6F0", VA = "0x187C1D4F0")]
	private void NODIAPAHHAL(CBMANFMCNIJ GIKGHELDAKC, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DB10", Offset = "0x7C1CD10", VA = "0x187C1DB10")]
	private void NODIAPAHHAL(PFKNPCJPLJC KCIAAGAALML, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CF00", Offset = "0x7C1C100", VA = "0x187C1CF00")]
	private void NHMKMDPOGLC(ByteString? DBPLBMLNFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DD30", Offset = "0x7C1CF30", VA = "0x187C1DD30")]
	private void NODIAPAHHAL(MOKIDEKEKAD? FHPKLENNKKO, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B560", Offset = "0x7C1A760", VA = "0x187C1B560")]
	private static void DOOPCBACMOD(MOKIDEKEKAD? FHPKLENNKKO, JEEMOCELCPM HAOBHKHONFC, ELLHDKFFHGJ LEDEKAFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C690", Offset = "0x7C1B890", VA = "0x187C1C690")]
	private static void DOOPCBACMOD(KDCAAPPOJLF? GCEDHPINDAM, JEEMOCELCPM HAOBHKHONFC, ELLHDKFFHGJ LEDEKAFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E090", Offset = "0x7C1D290", VA = "0x187C1E090")]
	private void NODIAPAHHAL(KDCAAPPOJLF? GCEDHPINDAM, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CAF0", Offset = "0x7C1BCF0", VA = "0x187C1CAF0")]
	private void EKFEHEIDABH(Guid? DIHOLCNHIND, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D710", Offset = "0x7C1C910", VA = "0x187C1D710")]
	private void NODIAPAHHAL(AOAEIBCNJOH? COAOCPHILMM, JEEMOCELCPM? HAOBHKHONFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C250", Offset = "0x7C1B450", VA = "0x187C1C250")]
	private static void DOOPCBACMOD(AOAEIBCNJOH? COAOCPHILMM, JEEMOCELCPM HAOBHKHONFC, ELLHDKFFHGJ LEDEKAFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CD00", Offset = "0x7C1BF00", VA = "0x187C1CD00")]
	private void GCFBOKENJDB(string? CEAMLPJONNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B490", Offset = "0x7C1A690", VA = "0x187C1B490")]
	private void AGGHKGPNOAL(long HIBFKPNKEPG, Guid MBAJEJAKHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B3E0", Offset = "0x7C1A5E0", VA = "0x187C1B3E0")]
	private void AGGHKGPNOAL(OHPABNFLEFD? GAPMNLNILPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B430", Offset = "0x7C1A630", VA = "0x187C1B430")]
	private void AGGHKGPNOAL(NMIEDFMBPLM? GAPMNLNILPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct CCIBAOJDIKL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class GKCMKKCLDAI : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private readonly IEnumerator<DictionaryEntry> BGMKKIIPDPD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DictionaryEntry BNLJCJDGEAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C182F0", Offset = "0x7C174F0", VA = "0x187C182F0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object AFPMCDIFDOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C183C0", Offset = "0x7C175C0", VA = "0x187C183C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7C18470", Offset = "0x7C17670", VA = "0x187C18470", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7C18210", Offset = "0x7C17410", VA = "0x187C18210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
		public GKCMKKCLDAI(IEnumerator<DictionaryEntry> BGMKKIIPDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C18170", Offset = "0x7C17370", VA = "0x187C18170", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C181C0", Offset = "0x7C173C0", VA = "0x187C181C0", Slot = "9")]
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
		private sealed class IEMKJBCNPFK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x7C1A030", Offset = "0x7C19230", VA = "0x187C1A030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public IEMKJBCNPFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C19EE0", Offset = "0x7C190E0", VA = "0x187C19EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7C19FE0", Offset = "0x7C191E0", VA = "0x187C19FE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C1EE20", Offset = "0x7C1E020", VA = "0x187C1EE20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IDictionary.this[object AGBHGDFILGO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7C1ED30", Offset = "0x7C1DF30", VA = "0x187C1ED30", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7C1EF00", Offset = "0x7C1E100", VA = "0x187C1EF00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7C1EC70", Offset = "0x7C1DE70", VA = "0x187C1EC70", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7C1ECD0", Offset = "0x7C1DED0", VA = "0x187C1ECD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7C1EEA0", Offset = "0x7C1E0A0", VA = "0x187C1EEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E930", Offset = "0x7C1DB30", VA = "0x187C1E930", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E990", Offset = "0x7C1DB90", VA = "0x187C1E990", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E9F0", Offset = "0x7C1DBF0", VA = "0x187C1E9F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
		public RoomObjectCounts(Dictionary<int, int> MEHBNJJMHND, [Optional] Dictionary<int, int> HMAICBDAEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E850", Offset = "0x7C1DA50", VA = "0x187C1E850")]
		[IteratorStateMachine(typeof(IEMKJBCNPFK))]
		private IEnumerator<DictionaryEntry> LIFBMCBIDNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EF50", Offset = "0x7C1E150", VA = "0x187C1EF50", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB70", Offset = "0x7C1DD70", VA = "0x187C1EB70", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EA50", Offset = "0x7C1DC50", VA = "0x187C1EA50", Slot = "9")]
		void IDictionary.Add(object AGBHGDFILGO, object MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EAB0", Offset = "0x7C1DCB0", VA = "0x187C1EAB0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB10", Offset = "0x7C1DD10", VA = "0x187C1EB10", Slot = "8")]
		bool IDictionary.Contains(object AGBHGDFILGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EC10", Offset = "0x7C1DE10", VA = "0x187C1EC10", Slot = "14")]
		void IDictionary.Remove(object AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E8D0", Offset = "0x7C1DAD0", VA = "0x187C1E8D0", Slot = "15")]
		void ICollection.CopyTo(Array CABEAFGDMFF, int NIBICIJAIGM)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class CANAEEIMPJK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x7C129B0", Offset = "0x7C11BB0", VA = "0x187C129B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
			[DebuggerHidden]
			public CANAEEIMPJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7C12820", Offset = "0x7C11A20", VA = "0x187C12820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7C12960", Offset = "0x7C11B60", VA = "0x187C12960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A6C0", Offset = "0x7C198C0", VA = "0x187C1A6C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IDictionary.this[object AGBHGDFILGO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A590", Offset = "0x7C19790", VA = "0x187C1A590", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A770", Offset = "0x7C19970", VA = "0x187C1A770", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A4D0", Offset = "0x7C196D0", VA = "0x187C1A4D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A530", Offset = "0x7C19730", VA = "0x187C1A530", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A710", Offset = "0x7C19910", VA = "0x187C1A710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A150", Offset = "0x7C19350", VA = "0x187C1A150", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A1B0", Offset = "0x7C193B0", VA = "0x187C1A1B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7C1A210", Offset = "0x7C19410", VA = "0x187C1A210", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x27B00F0", Offset = "0x27AF2F0", VA = "0x1827B00F0")]
		public Invention(long MKHHKDJKLDN, int KIFHGDECLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A080", Offset = "0x7C19280", VA = "0x187C1A080")]
		[IteratorStateMachine(typeof(CANAEEIMPJK))]
		private IEnumerator<DictionaryEntry> LIFBMCBIDNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A7C0", Offset = "0x7C199C0", VA = "0x187C1A7C0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A390", Offset = "0x7C19590", VA = "0x187C1A390", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A270", Offset = "0x7C19470", VA = "0x187C1A270", Slot = "9")]
		void IDictionary.Add(object AGBHGDFILGO, object MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A2D0", Offset = "0x7C194D0", VA = "0x187C1A2D0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A330", Offset = "0x7C19530", VA = "0x187C1A330", Slot = "8")]
		bool IDictionary.Contains(object AGBHGDFILGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A470", Offset = "0x7C19670", VA = "0x187C1A470", Slot = "14")]
		void IDictionary.Remove(object AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A0F0", Offset = "0x7C192F0", VA = "0x187C1A0F0", Slot = "15")]
		void ICollection.CopyTo(Array CABEAFGDMFF, int NIBICIJAIGM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> JHEGAMOGEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public readonly IReadOnlyList<Invention> EEOGFIMGFGI;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	public CCIBAOJDIKL(IReadOnlyDictionary<Guid, RoomObjectCounts> FNEGGLBFFJO, IReadOnlyList<Invention> EGGJJEHBAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C12A00", Offset = "0x7C11C00", VA = "0x187C12A00")]
	public static CCIBAOJDIKL NDHLEIJCFGJ(CBMANFMCNIJ GIKGHELDAKC)
	{
		return default(CCIBAOJDIKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C133E0", Offset = "0x7C125E0", VA = "0x187C133E0")]
	[CompilerGenerated]
	internal static int OKOFNAMGOMO([In] IReadOnlyDictionary<long, int> IDOJKAAKFEI, long? HIBFKPNKEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C13500", Offset = "0x7C12700", VA = "0x187C13500")]
	[CompilerGenerated]
	internal static void PEIBOJILNJO(int LIILGNOELDJ, [In] MOKIDEKEKAD NEPDMCPJDFN, [In] Dictionary<long, int> IDOJKAAKFEI, [In] Dictionary<Guid, RoomObjectCounts> FNEGGLBFFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum EHEPJEAAANC
{
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	Projectile
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class JEEMOCELCPM
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class PCLBJMBOAMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public readonly Guid FMGNEFGHELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly IReadOnlyList<Guid> DPKKCFCOHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly EHEPJEAAANC PMDIHHMBMHP;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E7F0", Offset = "0x7C1D9F0", VA = "0x187C1E7F0")]
		public PCLBJMBOAMC(Guid LIPEAFABIEA, IReadOnlyList<Guid> AHIDAAHILKM, EHEPJEAAANC HFFFCKALIAN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly ELLHDKFFHGJ BEFEJHNLFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly Dictionary<Guid, PCLBJMBOAMC> JGIEHGNBHBO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ELLHDKFFHGJ GLPOPHGIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AB90", Offset = "0x7C19D90", VA = "0x187C1AB90")]
	public void OOLDDNFEGEK(Guid BNACELBCPNH, Guid GKNDDNHMJHJ, IReadOnlyList<Guid> OKHIONFEPNH, EHEPJEAAANC HFFFCKALIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C1AAA0", Offset = "0x7C19CA0", VA = "0x187C1AAA0")]
	public bool BHINEABDGKH(Guid EHBLCJBHMJH, [Out] PCLBJMBOAMC OHDECDNIJPD, [Out] bool IFMLGJEGMGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1ADA0", Offset = "0x7C19FA0", VA = "0x187C1ADA0")]
	public JEEMOCELCPM()
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
