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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x802EA90", Offset = "0x802D890", VA = "0x18802EA90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DHOIDGPEBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> HCMKHJKAPJG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> CKBDJIGFHJH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DGCPCGOLFIC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> DAOABLIPAJP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string EGPMICDNMCN;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string MHCGPDAEKCM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string MACDLMCHFJI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x801BF20", Offset = "0x801AD20", VA = "0x18801BF20")]
	public static bool CAAOCDGJDDG(Guid BLPKMIMNMLB, int MMEJGEOKDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x801C020", Offset = "0x801AE20", VA = "0x18801C020")]
	public static bool LJCLNGKGHDE(Guid BLPKMIMNMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x801C0B0", Offset = "0x801AEB0", VA = "0x18801C0B0")]
	public static string NCFJFLPGAHK(Guid OKDHAOKOGCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ABMNIPLGMBM]
public enum KCFGGAFAADI
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
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x802E3B0", Offset = "0x802D1B0", VA = "0x18802E3B0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LEHHPMJMELF
{
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid HPGKKDINGMF;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DGAABMDFPNL;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OGGHPKPHLIA;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid MKNPFKOJHGO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FCOAJGKFIJA;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MMIAGPNJNFK;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid ACNDMJFDDMI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid OPFADCDNMNM;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid HANJHKBBEIF;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CLKGHNCFMID;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid EKPLADBEFEP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid OEMCLMKIDHA;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GBCEJLAIOOP;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HKHNOFPLDFA;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid NOEMBEMLMFG;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid JIPPOPBIPCI;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HAKCMMIANKK;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BJKDKLCMIKC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid ADNBDMMPHNG;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid FGNDPNFKBHP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PGCEAOHHCDL;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid NNCPLBFPMPH;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JHHOADDDDEL;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid BJNPEAHKCNK;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EDHFGPJNLCO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid BOPKNJKKHMO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EBIPBKKKBJE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NJLDNMIIEKO;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KKDHEHENEOK;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid PJEOKAFCACN;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid AHFDHLBGMBI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid BDDOBOMCJLI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid ODEAEJIAFGF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid ECLHFKGIAPA;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ECBGIFKCPGF;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BBMAKECKECB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid GGDCOBBFDKP;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GEFJAGELKBM;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid GHOIIMBBCPA;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid DDJHNMHMHAL;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CIBHGPKAIOK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid KLAPFBMNAED;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid HCBJHKJMIFF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid POCAFEAJGEK;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid EOMAPMHHECL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid GJPHABBANBO;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LHAGDDHCOOF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid HPLAABGIEBI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FPCHMNNGBOJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NICNINMJKDK;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid HPNMOBNLFDG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid NMGNOGHGNKO;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid LJDHNPHFGNM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid NLLPAPIGKNB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid CIKFINIFHKN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PLIPNNOOIND;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid IBNIDOCLMMC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid EABBFFCADKD;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid JAKIMDCJCGI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid PLJFPBMBDMK;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid JOPJCINFAPF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid NLGMEOHHDIK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid INPBEDCJIBI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GMAPENCNCKA;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BLNNKEHGILF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OJCADDPCBIF;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid EHCOAKOHNKH;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid FKLGDIJJHDI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid GPAEDCBECOP;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid IDNDAPKAKPD;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid CDCFFOJAEHM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid DFDCIBAFOPN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid EMMNJNPDLBE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BAHENFKGBDO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LOBEICANFBM;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MAOHCJMPFNA;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid LFEDFGNLIDF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid CEAOABFBALJ;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid OLGAFBHMIDE;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CHMFFDNKFGP;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid KEHOAMHKJDN;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid DFBGAJOPEAL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CBOCLCKEDBN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid HMLGBFEJJCG;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid EKJMMAEKLGK;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EMOBOKKAOFM;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NKEDIMJFICI;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid MAKJNEIKIPP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IBEIJKECKJL;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid LEFOMDLJMLB;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid EJKCAGLBHEF;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DAIDBDKPMHE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KECKAOICANI;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid AJKMILOEGIN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid JFGHGLOOIGB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid MKHIPJDGHFG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid BFMJNAAKIOG;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GPKEJFNKFKG;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GLLHMPJACEM;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GBFDOEFLPNJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CLANAIBPJLK;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid DHDPDAOAGBB;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid PLMMAKIHLCF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid AFKGHLBODNM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid IDDMDCKPGHP;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid PPPNEMHGOMI;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid NNPBAGDDDEJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid EMBPAMHJPHC;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid DPAGACEBBBC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PMKJNAEDGOK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OEOFNLMMLFO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EHLCDNMJIEK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid ANMOIBAKFPD;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid HFNBLCOHJJH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JALEJFJJAGO;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid MAJLJGNHKHA;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid AJMDEBNKEAM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NMBPPNEIADK;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid AAEBPGIPPDI;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid CHEFNOHKJNI;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid KKGGEPBHKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid CDKDMKNHJFB;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid COEOOHMBIAO;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid DHBNGICBBDM;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CJBMILBFAOA;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LAHJKOPFMDI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid GMBLHFOKPPC;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PHFLIMKBADO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid KECLPIMAAKM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid HBCGNNJDACB;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JJCPEPGCAGP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LOGAFIEFPFC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid LPCGJNEMFBG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid CAHANBIOCOH;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BIJNCIIADOA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid HCLMOMBNLJN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid NIBIILGOCMG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KEONDJAMPAL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid EGIHINABLNN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid DOEEPCNGJEB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid AADKMHLEOKH;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid BIBDIMPPEFE;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid OJJDBHICCCM;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid EBKNOCEMILA;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HCCEODDIACO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid PKFGMALJJON;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HBLIHNHKLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid EPCCKMMFNDN;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid KINGOKPHIDE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid ICAEDJHGBJM;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid HNECBNPEMGC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MHGPOIEIEEO;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid MICDGPLPDGK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LOBJJKAFKLJ;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid NGCOOGDPBME;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid LKIHAGFOJNE;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LPKGEHGKDLK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JNDJKPFBKCO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IEOFMJFKFPG;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid OHLIOGINPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid OCJBEGBFECP;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid EBFABAAFFCD;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid MGHAJDKLLCA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid CFDMJGEDNCB;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid GKLKDDACCHK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BJFHGAAOIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid EOHAGCENPAK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KHOEDEOEPOC;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NELNEEHEOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NEBNAPMGFGN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PNOEEFLFDBA;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid FHLEJMOMGBO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid APCAAPLIBBG;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid KNOHNAIGEHI;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid BLCHNFINHNN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DALGDGHLMPO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KFJPHFMIANM;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FCBGDBHJCMD;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid PAKMNCMEGCL;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid AODJGBENCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid HFJABCEODFG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid IBCMGBENKGC;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FMKCDGJOEII;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid AGMHMOGLAFC;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid EJADMODPOKB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid GJJBAKGOOJG;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid LJIFFAIHHOB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FFGKMFNOGOH;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid FGAPIBJHLEH;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FNDKFPIDPFK;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid LCNNNFNBODN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid ABDCPLGJLJC;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EGLNEAPMFHD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid KKLMIGFABFL;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OLBJADOCFPF;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GAICOKBGJFM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid POBNDICHNDF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid EAPCPHKEDGK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid ADKHIEAADLD;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AHFKFHBPLHP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PGDHFFKDAEI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid PAHOCFJLHCG;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid GAOMNNFIOOA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid OGNGPOJGLNA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KBKDIAKCEMN;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OCDJLACJHPN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid FMIJFCNANLO;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FFFGINGNCOA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FHNFDIPKLCK;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid BLEEOIEHFBP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid LPEIPNMALAJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MMCPHODDIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NHPIGBFNMOC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FPLBKGKOKMD;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid IDEHHIOILPK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GAIMDMNNIPF;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MCFEMAOBPIF;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid LBAGMINIHML;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid ENEIIGLKNAI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid NNLECCIGHAI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid DHCABMMAMBO;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid OAIAMIAFADI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid JBKFPCGFMCN;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid GKEDPACNEHL;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid HNHNGIIFIDC;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid MBJGDPPNPMI;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HPHBGDALPKP;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid LMIMBJANGKK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid ABFMFHGIMHD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid PLPPKIPBBOF;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid AJHLLCDJFMB;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KHGGCMMDFEP;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GKPENAECBHO;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid DPBEEFPDLDK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid OLKFHDHLPLO;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid MFAPPMOGDBB;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PKCPBJAENEO;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid GHFPALILDMJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid PNHOILDDNDC;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid EKKAPLEBHJC;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KDJCPLOCOPH;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid NFBFHMGOKMO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DNBLPODBLIB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid LJJLOIKMNGF;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BFABCMMHNEN;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid HGAEBCICMHD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid ANFBALMMAKM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid OOMLEEJABLC;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AFFDOIDPAEA;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid MNOCCCOBMLH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MHDMINKLFAP;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid EHEHDNBACAK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PHJFEHODHHL;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid IDACCEPPJIF;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid KCDNEAGNMHG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DCEOAMIGPNH;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DGCOAIHBAHF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid DKOEMPIHBII;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid FKKKOOEANGD;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid JHKKOPDHPMD;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PBDFPDJEFOB;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid CEBBCADDDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid MOCMKJPJJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NKIAFGHPFDB;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid INHBJELLELO;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid EGCGBMGDFHD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid BJAOCLLBNGB;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid EACGJEFFIMA;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid COKJEDFHDHM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GLGBDICLEIK;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PJJAENMPJIE;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid KOEAMHALCKH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid KNNKIMCJHMM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid OLOPAMOANPH;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LAAHDOLLEMF;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LCKNMMKGDFE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid PJNBKOIFKID;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid EJOJCFIKEDH;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KAPBLLAJEPD;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid AGDOGDLMOKH;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid EIABBCEKAHA;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid CELBAHFDGKM;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid POOIIDIGEJO;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JPHAJAIMDHA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid BFKELMFPPHD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NAHCLOBFHNB;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MMBBBOMIDMA;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DOLHBCNPBNF;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid MCBCBCLPKIA;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid KAGHLICNNGI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LJDGCIBGJAK;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid BHAILBAINED;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DBKKPGIGNDB;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NGNDBGKEJON;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid EHGHKCOMAJC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid ANKAKNOKBJK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid BDKNNBMFEJO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BFEPPACFHHG;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IPPCOMBBANA;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GODDLBIBDLD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid DEDLLGFCCHC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid CADFJPDFKNI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KJMNAJPBDOA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid EBPMCHJHJHK;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JFDNGDIFPPB;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid HOIMGNDKBJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid JBOKKKEGKLE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid OPGENBKDEEE;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MCBJPMOMJID;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JLLGLODFDJP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid JPJGCJBLCPP;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid OGBNIEDMHOC;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid LENKDJMDMHP;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FGEKBEIKCME;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JOICMCGNJMD;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid FCOGLNJIMCH;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ALPFJEBGJOA;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid NCDDLLDMJLO;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NPMCNAHDFAB;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid IGPDCPLLJGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HGDLILFAFGL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PBCCCEEKJDG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid NLLPCCGKDIK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid CJMMFMDDOKI;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KCNEENBJJDG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid MEGJLFIBKLE;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid AGAHMILJFDH;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EDMPEOPKLIC;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid DJJEAJHDDJM;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid PJPMDCNDPMD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid HJFONHPHDIC;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid CKDAHBJIIFL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid LFOKCEJMOKA;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid ADMOLAFLDKH;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid BMNJJICFBOF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NHBDLFAJHFM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid GDNMFPCODAA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid NLOHABNAJHP;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid COFOGHIEDLA;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NBAJKBOMNAK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid GHKMEGNPKGN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid AAKPDLFFDEB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid OMDNECOGLKH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid DBKLIODIOGF;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid FCCJKNNFAHE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid OKKHJFMFJFJ;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid CNNHKLKKPFK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid GKLEELEAFJJ;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FKAFHCLMMGD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JEHEEJACDHP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GPFAFHHJGCA;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PIKBEKMCBDK;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ODFMBMFOIBE;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid MPDHNALHOJN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FBHGOEBLJIK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid EMCMGEJOJJJ;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LFFEPACCJOA;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BHHOHKDGBKA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid HOJHNDFBLKH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid JMOGCCNPGPM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid FDEJHLAJIHP;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid OHNJBHPHFPF;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid PLOBPCKDMDF;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid LNDNKJHBIJO;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid ILNANIMCDHF;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid ILLFADJGBGO;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid MFDDFILKIOM;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid JAADJFINNOP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid AIPPCCACGID;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid BGDJDAMKEED;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid MBHFPHIBBDN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid BMDBGPEFJOK;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid ALDMNJNLJKH;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid KJDCBIKHHPE;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JLDGFKNLIDI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid KKAJFOEGLLJ;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid HADHMMCIECO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid IOALFOFFPAB;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid BMIFGLGABMK;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HDMMIABMNJC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid BOMGKCEIBBG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GIGCKAEALBI;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid JFHCLIOBBGJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid LPEAJFBNFLA;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DBNHCPBLHAE;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid AADOOLMJOAD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid KPONCIMEHOM;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FDCJNKLDFMN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MFEGOEJGBBJ;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid FHOEIMJNOEB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid HHEJDOLMKPA;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid HINIGDDDJNF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid CAPHKNGPJFO;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AGDDHFOPJCA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid OBGHKGNHOMN;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid LMJIBHNDNKA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid HEFOGJFDKKK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid ICDAMODNDLC;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid LDMFGGIAMBC;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FCBBGBGJPKF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CEGJPLPHKPE;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid LDNHCMDFOML;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid FMBKLLOCGEO;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid GPABEKABGAK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MOCDJEDCIOK;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid PHKAOFKINIO;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EHENCGDOGNF;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CGMPKBGGEKB;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid PJMEHBPDNIE;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid FJHOGKOBFCE;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid DFHOGOLMBBA;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid EDHAMONHLFO;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid ONIOMDANINK;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid MHOOJFONBBC;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NIFIOFDKJNJ;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid CPKCGDMBADB;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid ADILDBDCPNK;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JDNOEOMNGHO;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid DDCANHEGPHM;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IFKKINAFNDE;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DPHGMDDJAHM;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PDGAPFOJCKG;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BIGPILGELNM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid PAKHMHBALLK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid KJHKIDCEAGA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MJEPGKNOOCC;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid PECPIJHEILD;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid ANHIGCFBLAF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid FNJGAKNFJAG;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid MPDAIDGGNEO;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CDLEPLCFEHH;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PJKKHCPAKHA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CHKELEFNNIH;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid FPDAMCPEJPH;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid BNIBCNMHJJD;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid ODJMDDGGMGL;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid NGLPNMEJIDN;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BBDCBLDGKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KMPGBNCJMDH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid IENAFALJBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid OKPMNIFDCDN;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid AOICDEKMAMD;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid ECIBACIEOGP;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HPCIGMNNMOA;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LAHKDHGHMLL;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CLFLJEDPDFF;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GFCJJPOMCBJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NJCIDIDFLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid ABBFFFEJLKJ;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid POPKOOFDEKL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JHAFGCBLEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid EKIIINFKKFM;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MCGMIHIMOKF;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AHIDOLNGDIH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid HFIBKKIEHLN;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OCOACHMEBBD;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JJAOHGKIKMG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CBBGPODBIIF;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid EONIPGLJGKH;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GIINBFDDHHC;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DNPHIKFJBHO;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HFCKIKMMKDH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid LKINCGGEBDH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid DJFFHPOALEM;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BPDFEACBMBN;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid GJFGDDAJNCH;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid JAAMNOOLCMM;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LMKIPFCNJGF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid FLEECOOHOJH;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FJKKPAEEKFK;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid CALGILAPMLA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid DALJJCBANKP;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid OHKJIPLENFC;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid GAIGPAIIMPD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid LBAHGPENDJJ;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid KOOKOBAALCE;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NKPLGFOJFIB;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid IMBNKKFJDEA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GOGNPBPNHBO;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid NFPBKJCENHA;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid AJGGKIBIDHD;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid ENOBKFOPIIG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OHMDJPFONDG;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KOFEMECKEGO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BMECKDJDNKD;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KIAKKLJJKIN;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid APBMIMJOPFH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid NFLHLLPENCL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid EBFPKDBPLCF;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid IPHMAANDKDL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid BKOIKADLHGD;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid GELPODDDOIH;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EGGMNGIFPDK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FLGLAHNMJGE;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JMFEMFBBEPB;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LHIHLBAIAJJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KHJKGJBPFGA;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DIHGMJEAHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid NCLODFDOJHP;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MIHMGCPPEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid GMEPIPNJIGD;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid MLFLFBJNBGD;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JAMLKICNDMN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JINOLBNIEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CILBGHNPALN;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BPNAAGLKLCK;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CJKNBJLBJDK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GJDKBJCJFMA;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid OFHEGAMNKBG;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KBOEKOLICNC;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid IMCDAKEMBOB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid IBOJCJHEKIN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid PHDNJOEDNOG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid DIFEMDEKLFB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid BPOIFKFFBPN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KDOHEFBBPAL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GGHHALHFAHB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IHHPJPLOCOL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid MAMJIODHBPH;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MFNKLGBKGIG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LAHJLHIBGJP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid NLLFAGHGHLL;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid NPJNKEOLALN;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid NOJPKFCFCHN;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid JJPINGOLDPH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JDMPFEJMLCI;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid IOJKPMOANEH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid BPPLHIBELKJ;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid MHPBKNOPMBF;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid KFBAPGGAEOB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid MOKKFNDMKJK;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid EPBOLFEPEGL;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid BGMIJGNNHIE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid NGHIAIBCKDI;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LGECFMLILGL;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid CLJKLOAJLMH;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid ANJMEIDNDJL;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid KPNEEDMIFEO;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid CNHONJKICPJ;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid OKPOLHKHKMJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid ELOOGBKIDKO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid JBCHHIHMEGL;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid DGLCHIJKIPO;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid HPOOHINANIP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid HFDLOEIOBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid EBBBLLEKKPC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DAHLDGJPNNB;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid CEJEHPEGOAO;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid ECJPGNCKJMA;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GMALJECLJPC;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid DJFJDCENOLF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DDHKOHNDLIG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid OMGJHJOPOBO;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid LJNJLGJOIFB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid KFNJMKPKMHE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid AOIKAGFDGPB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HICEBOBAALN;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid HPPBNAPOGAP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid FGCHDLFABEE;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MAIBCHPOLEO;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid EBMBAPMCINE;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KMEMEKEGNFK;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid FMMAOODNHHP;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid JLNPILAGMML;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid BGAGJJMEDAK;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid OCAGCEHNDPP;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid DAGIOLBFKCL;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid DIFHDNCINJL;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid FGODADCBHBA;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid HCBBJKKNCGP;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid ODEICNCEEIP;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid NNGMBEHINEH;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid AHBOJGJEPEE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid HMJMGLBGNLN;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid BGNGOEDEEGM;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid MGKOHGDANKD;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid LKONBNMPGAI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid FKPCKEFIALK;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MMFDELNBFBF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid IIKKDFBEFNL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BJFAEJGIABH;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid HEINKINFDKD;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid HBDLBNIGDEL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid CBHHADFMKAI;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid LHINMCBCPKK;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid IHJNEEFBFDE;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid KPKBCDFMHNN;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid OAJJBOJAICA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IEIFDGOHJOC;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid CLENGPLJPMN;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid OBJOODCNAEG;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid PIJPLDAHPNK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid KNJEJEICGGG;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid GKGKFJBJCPJ;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MAMBFEHGHPN;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FLLJKFIIHAH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid CKHGCCGENHG;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid HPCPKJBJGBF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DEIOLPOJHKC;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid FEBPPLKOFFG;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid LDADNENLOPL;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid IJFGAJGDEDG;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid BBCAKEFEICM;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid MEBNBJANMCP;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid KDHIJCFECBL;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid BGKKLEADFBI;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid BJJHCCNKHBE;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid KHAKPAAPGJH;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid BNIBLGPLFBC;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid JADMLLAOFHA;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid PELLMJOJGLO;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid GHBGABJOFMN;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid CHGFONCEOMI;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid AMJBLONDIJI;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid LCMBNCLJHOG;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid NCJCBFMAHPI;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid CMCKODONHOD;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid DCONHNFIHDB;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid CMDGPIGFGBB;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid CFCCBKMAOOL;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid BIBAKDPKJEI;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid EOHMOKCPGCK;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid IDCHJNIINKL;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid NAMMNLEPFKN;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid MLHKODIDFGG;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid OHPDCOBEPHN;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid DPAGBJGLFJL;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid DNNKEJBMFEB;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid FOEENJPKDAL;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid BPLDBNNNHMN;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid GCKAHCBIHBN;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid AIFHBLBAECO;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid NLAMKEFPIPK;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid GLMHJFCCIPG;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid MLCLCHDCJOD;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid JLNGNGBHEDK;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid IKLLKOHBHCL;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid HKKLPPILFNC;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid KHBENNMFKBK;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid OGFMIJAAANM;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid COHMPBJMKJA;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid EJHKIICNLBF;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid FAOKKPDEDOF;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid BBCAIODAINF;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid BOBHELEHFFO;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private static readonly Dictionary<Guid, KCFGGAFAADI> IJGGFHNJFKH;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private static readonly Dictionary<KCFGGAFAADI, Guid> EEAGNADFHIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, KCFGGAFAADI> BPGFPGGJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x802E350", Offset = "0x802D150", VA = "0x18802E350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<KCFGGAFAADI, Guid> PLNCDALPJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x802E2F0", Offset = "0x802D0F0", VA = "0x18802E2F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AMHJIHICLHA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x801B710", Offset = "0x801A510", VA = "0x18801B710")]
	public static bool PMEIHMFEPAN(CNDLBJKPKBL OMDCGCGDCPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x801B2F0", Offset = "0x801A0F0", VA = "0x18801B2F0")]
	private static bool PMEIHMFEPAN(NJCFHFGHMNO JCEFHNCIHBC, CNDLBJKPKBL OMDCGCGDCPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IPCBHIFKEGI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IPDKECCGBNK BOIPFNOKGBJ, [Out] Dictionary<int, int> PLFIMLPKMMA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NPIADBPPJMB FLJBLLIMELF, PEPMHEBJOED GFAEDOOMMGI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EJNBJJGBKAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly KEBNPIDPHJO FGMMGKBADDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly IEnumerable<CDOFHMONKPD> KCEBGEIIPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly IReadOnlyList<CDOFHMONKPD> BPLIAGLLNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly HBBCPCNIOON<KDGLCMHKHGO> OPPBNOELKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly IReadOnlyList<LKGKFDNNFLL<KNPFHPANEIM>> LMLMGBIMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly EDHFELIHNAG CDCPHLHKCEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFNBKIGACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x801FF90", Offset = "0x801ED90", VA = "0x18801FF90")]
	public EJNBJJGBKAK(KEBNPIDPHJO PBGFIHMGIIB, IEnumerable<CDOFHMONKPD> DOEAAJHELBC, IReadOnlyList<CDOFHMONKPD> DABHHDNDPNJ, HBBCPCNIOON<KDGLCMHKHGO> BLOACKLMMCE, IReadOnlyList<LKGKFDNNFLL<KNPFHPANEIM>> LAFFPBOACLJ, EDHFELIHNAG HOENAEJMMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BMCLHHOOFGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly KEBNPIDPHJO FGMMGKBADDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly IReadOnlyList<CDOFHMONKPD> KAGBCKJONKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly HBBCPCNIOON<KDGLCMHKHGO> OPPBNOELKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly IReadOnlyList<LKGKFDNNFLL<KNPFHPANEIM>> LMLMGBIMNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly ByteString JFPJBMPECPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly EDHFELIHNAG CDCPHLHKCEC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x801B740", Offset = "0x801A540", VA = "0x18801B740")]
	public BMCLHHOOFGC(KEBNPIDPHJO PBGFIHMGIIB, HBBCPCNIOON<KDGLCMHKHGO> BLOACKLMMCE, IReadOnlyList<LKGKFDNNFLL<KNPFHPANEIM>> LAFFPBOACLJ, ByteString AGAEIFILLGE, IReadOnlyList<CDOFHMONKPD> OCIEFABHCAN, EDHFELIHNAG HOENAEJMMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HLLMGBGMJCC : IJDLIAPMMBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly Guid GCLFLNMKJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly Dictionary<Guid, Guid> NGHKKFKEBOC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D2EE70", Offset = "0x4D2DC70", VA = "0x184D2EE70")]
	private HLLMGBGMJCC(Guid MGJBHIPEDOA, Dictionary<Guid, Guid> NGHKKFKEBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8020910", Offset = "0x801F710", VA = "0x188020910")]
	public static HLLMGBGMJCC OGAKBGHEIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80204E0", Offset = "0x801F2E0", VA = "0x1880204E0")]
	private static Dictionary<Guid, Guid> HCKEOPFGNBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8020610", Offset = "0x801F410", VA = "0x188020610")]
	public static HLLMGBGMJCC JABIFLAKBIN(IReadOnlyDictionary<Guid, Guid> GGCHDPHENOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x80200A0", Offset = "0x801EEA0", VA = "0x1880200A0")]
	public static HLLMGBGMJCC EEGCEJOGLAI(IEnumerable<KeyValuePair<Guid, Guid>> GGCHDPHENOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8020590", Offset = "0x801F390", VA = "0x188020590")]
	public Dictionary<Guid, Guid> HDFJAJFPALG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
	public Dictionary<Guid, Guid> BMOJDHBMJMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80209A0", Offset = "0x801F7A0", VA = "0x1880209A0")]
	public void OLHPIGGMIDE(Guid GGCHDPHENOB, Guid KDLKIOAIFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8020620", Offset = "0x801F420", VA = "0x188020620")]
	public void NEHLOBPLGJK(IReadOnlyDictionary<Guid, Guid> GGINIMGHDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8020390", Offset = "0x801F190", VA = "0x188020390")]
	public Guid EOKDNCFHHFM([In] Guid GGCHDPHENOB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8020000", Offset = "0x801EE00", VA = "0x188020000")]
	public Guid BKCNAOEALPI([In] Guid GGCHDPHENOB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80208A0", Offset = "0x801F6A0", VA = "0x1880208A0")]
	public bool PKGEHFJFIBB([In] Guid GGCHDPHENOB, [Out] Guid KDLKIOAIFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80208A0", Offset = "0x801F6A0", VA = "0x1880208A0", Slot = "4")]
	private bool NKFPFHIKAHL([In] Guid GGCHDPHENOB, [Out] Guid KDLKIOAIFBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CLPBDDHMODJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDEFCFOBJPE(Guid OKDHAOKOGCM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ELDFNELEMKD(Guid OKDHAOKOGCM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OHAFNAHNPLE
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
public abstract class NHBKPHBAHEL : CLPBDDHMODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KAEIOHMNIAF : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public KAEIOHMNIAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8020A20", Offset = "0x801F820", VA = "0x188020A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8020B80", Offset = "0x801F980", VA = "0x188020B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8020AE0", Offset = "0x801F8E0", VA = "0x188020AE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8020AE0", Offset = "0x801F8E0", VA = "0x188020AE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CEOHLJHJLFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public NHBKPHBAHEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x801B7B0", Offset = "0x801A5B0", VA = "0x18801B7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x801BEC0", Offset = "0x801ACC0", VA = "0x18801BEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private Dictionary<string, HashSet<Guid>>? HKEMNBPPBBN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> EGMKHNBOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x802E630", Offset = "0x802D430", VA = "0x18802E630")]
		[IteratorStateMachine(typeof(KAEIOHMNIAF))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? NLDODIPKOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool MGCCOHOMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool BMLLFAAKDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> PPCGBOKKEEK(string IANIJJEIJNF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x802E550", Offset = "0x802D350", VA = "0x18802E550")]
	[AsyncStateMachine(typeof(CEOHLJHJLFO))]
	public Task FNKECJEOJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x128F760", Offset = "0x128E560", VA = "0x18128F760")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x802E750", Offset = "0x802D550", VA = "0x18802E750", Slot = "4")]
	public bool MDEFCFOBJPE(Guid OKDHAOKOGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x802E480", Offset = "0x802D280", VA = "0x18802E480", Slot = "5")]
	public bool ELDFNELEMKD(Guid OKDHAOKOGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x802E690", Offset = "0x802D490", VA = "0x18802E690")]
	private bool IPMOCBHOIKB(string AGLMCBBBANG, Guid OKDHAOKOGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	protected NHBKPHBAHEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KAPOFHEKOCG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FAEAGJKAHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public KEBNPIDPHJO staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FAEAGJKAHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8034A90", Offset = "0x8033890", VA = "0x188034A90")]
		internal HBBCPCNIOON<PPOKPJHALOH> MKJGAGILLEO((HBBCPCNIOON<KDGLCMHKHGO> GraphId, HBBCPCNIOON<KNPFHPANEIM> NodeId) i)
		{
			return default(HBBCPCNIOON<PPOKPJHALOH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private static readonly IBOHFPGOOJJ<PPOKPJHALOH, int?> EHBIFDFIADO;

	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly long DJOPMFNMJHK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8020D00", Offset = "0x801FB00", VA = "0x188020D00")]
	public static (long, long) LEJBGCPABEA(KEBNPIDPHJO PONICBMIIPE, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8020BD0", Offset = "0x801F9D0", VA = "0x188020BD0")]
	public static long KIGJOEAGDHN([In] ReadOnlySpan<HBBCPCNIOON<PPOKPJHALOH>> BEKDODDPELF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80211A0", Offset = "0x801FFA0", VA = "0x1880211A0")]
	private static long MHMFHFJMEBM()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NGMHBHMBMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public static readonly HashSet<KCFGGAFAADI> DFAGOAFLCMO;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PIAKFOMCOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AMDAJABNJEH : IEnumerable<CDOFHMONKPD>, IEnumerable, IEnumerator<CDOFHMONKPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private CDOFHMONKPD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private OBPMHNNDFCF spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public OBPMHNNDFCF <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private NLPHFIBGJOE spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public NLPHFIBGJOE <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private CDOFHMONKPD System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
		[DebuggerHidden]
		public AMDAJABNJEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8032E80", Offset = "0x8031C80", VA = "0x188032E80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8033100", Offset = "0x8031F00", VA = "0x188033100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8032F90", Offset = "0x8031D90", VA = "0x188032F90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CDOFHMONKPD> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8032F90", Offset = "0x8031D90", VA = "0x188032F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x803BD00", Offset = "0x803AB00", VA = "0x18803BD00")]
	public static OBPMHNNDFCF DNECPEPIKNO([In] BMCLHHOOFGC EDNGFNOENCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x803BB70", Offset = "0x803A970", VA = "0x18803BB70")]
	public static OBPMHNNDFCF DNECPEPIKNO([In] EJNBJJGBKAK EDNGFNOENCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x803D4B0", Offset = "0x803C2B0", VA = "0x18803D4B0")]
	private static HashSet<LKGKFDNNFLL<KNPPHJEMBDH>> JBKNDKNPKKK(IReadOnlyList<CDOFHMONKPD> LPAHBDJPCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x803C4D0", Offset = "0x803B2D0", VA = "0x18803C4D0")]
	private static void HHMKNAIGFKJ(OBPMHNNDFCF EKPFCNHJPAA, [In] EJNBJJGBKAK HOEOEPLAMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x803DB50", Offset = "0x803C950", VA = "0x18803DB50")]
	public static CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ> MPCCKDABPBC(OBPMHNNDFCF EKPFCNHJPAA, NLPHFIBGJOE NBDMKLLGIDO, HLLMGBGMJCC? PDKJKBMCOIJ, bool PAIJGDKGMLA)
	{
		return default(CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x803BF10", Offset = "0x803AD10", VA = "0x18803BF10")]
	[IteratorStateMachine(typeof(AMDAJABNJEH))]
	private static IEnumerable<CDOFHMONKPD> GOGNFNJBMGI(OBPMHNNDFCF EKPFCNHJPAA, NLPHFIBGJOE NBDMKLLGIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x803D850", Offset = "0x803C650", VA = "0x18803D850")]
	private static void JLMCMNINPLL(OBPMHNNDFCF EKPFCNHJPAA, NLPHFIBGJOE NBDMKLLGIDO, IReadOnlyCollection<ByteString>? CBLEGMJLNFO, IReadOnlyCollection<ByteString>? MNDBLFLJCMB, IReadOnlyCollection<ByteString>? EHHIBLBCIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x803CB30", Offset = "0x803B930", VA = "0x18803CB30")]
	private static bool HMLJCOPGBFC(OBPMHNNDFCF EKPFCNHJPAA, NPIADBPPJMB FLJBLLIMELF, NLPHFIBGJOE NBDMKLLGIDO, [Out][NotNullWhen(false)] string? BKBLOMKNEFC, [Out] Dictionary<int, int> PLFIMLPKMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x803D1D0", Offset = "0x803BFD0", VA = "0x18803D1D0")]
	private static Dictionary<Guid, NJCFHFGHMNO> IOIKJAIAMCJ(OBPMHNNDFCF EKPFCNHJPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x803BE80", Offset = "0x803AC80", VA = "0x18803BE80")]
	private static void FNAIDOIBKNF(bool ICMMEONOHDE, CDOFHMONKPD FKPLGDJFALO, HLLMGBGMJCC MOFOHEKPLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x803D8C0", Offset = "0x803C6C0", VA = "0x18803D8C0")]
	private static void KBBFBLNEGOA(CDOFHMONKPD FKPLGDJFALO, Guid ABICANLPDAM, EOFBAHHHPOI? MMIEEFKCCNO, Dictionary<Guid, NJCFHFGHMNO> MPDCCIAPPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x803C020", Offset = "0x803AE20", VA = "0x18803C020")]
	private static void HDEDNLDDEIF(IEnumerable<CDOFHMONKPD> NENPILJBGHM, IReadOnlyCollection<ByteString> CBLEGMJLNFO, IReadOnlyCollection<ByteString> MNDBLFLJCMB, IReadOnlyCollection<ByteString> EHHIBLBCIKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NLPHFIBGJOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public bool ICMMEONOHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public EDHFELIHNAG HOENAEJMMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public EOFBAHHHPOI? MMIEEFKCCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public EOFBAHHHPOI? PPFHOELNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public KEBNPIDPHJO JOKCGGPBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public OHAFNAHNPLE DIBOHBHJGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public IPCBHIFKEGI BFDNKBBCDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public LKGKFDNNFLL<KDGLCMHKHGO> KPDIOKOHPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public DGHNKIDIECG CGHADOEMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public List<CDOFHMONKPD> ABPJEBLHADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public PIFBFEKACLF HLGNKBGDBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public KBLDLLCAAED MLBOKBEGJFP;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EOFBAHHHPOI
{
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	private const float BCGHKFELDFI = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public Vector3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public Quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public float AMJKMJIBGNI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 FOADAFIEIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8034410", Offset = "0x8033210", VA = "0x188034410")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS ANEJDAGEGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80340C0", Offset = "0x8032EC0", VA = "0x1880340C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x158F260", Offset = "0x158E060", VA = "0x18158F260")]
	public EOFBAHHHPOI(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float AMJKMJIBGNI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80349C0", Offset = "0x80337C0", VA = "0x1880349C0")]
	public EOFBAHHHPOI(UniformTRS FOLAAEMKGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8034190", Offset = "0x8032F90", VA = "0x188034190")]
	public static EOFBAHHHPOI HJEFHGLDAGG(EOFBAHHHPOI CMDMCJGFCDK, EOFBAHHHPOI GKIBKEKEAHD)
	{
		return default(EOFBAHHHPOI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8034590", Offset = "0x8033390", VA = "0x188034590")]
	public static EOFBAHHHPOI JGGBAIGHKJA((Vector3, Quaternion, float) BOIPFNOKGBJ)
	{
		return default(EOFBAHHHPOI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80345B0", Offset = "0x80333B0", VA = "0x1880345B0")]
	public static EOFBAHHHPOI JGGBAIGHKJA(Matrix4x4 NIIKPFDJOJN)
	{
		return default(EOFBAHHHPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8034930", Offset = "0x8033730", VA = "0x188034930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8034710", Offset = "0x8033510", VA = "0x188034710")]
	public EOFBAHHHPOI KJMDNOIFBLJ(Matrix4x4 OLPMPAIMKPI)
	{
		return default(EOFBAHHHPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8034520", Offset = "0x8033320", VA = "0x188034520")]
	public static EOFBAHHHPOI IPKGEGDOAFC(Vector3 EMECBHNHILC)
	{
		return default(EOFBAHHHPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8034100", Offset = "0x8032F00", VA = "0x188034100")]
	public readonly PIDPGKMADJC FCEGAIFCIOJ()
	{
		return default(PIDPGKMADJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PMOAJNGHCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct KFIMMOAALHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public readonly FKGPGNKMBDI KPEBMAKAKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private readonly LJGAAONCGFM NMKKJIGGJHL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1860240", Offset = "0x185F040", VA = "0x181860240")]
	private KFIMMOAALHJ(FKGPGNKMBDI INALECHHMIH, LJGAAONCGFM LIGPFOPLJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8039D90", Offset = "0x8038B90", VA = "0x188039D90")]
	public OAADMPBKNOD IEOOGOOCFJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8039EC0", Offset = "0x8038CC0", VA = "0x188039EC0")]
	public static CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ> OGAKBGHEIKK(EDPKBFMPPII<CIEOHCAKAMM> LIGPFOPLJFA)
	{
		return default(CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8039F70", Offset = "0x8038D70", VA = "0x188039F70")]
	public static CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ> OGAKBGHEIKK(OAADMPBKNOD LIGPFOPLJFA)
	{
		return default(CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8039E00", Offset = "0x8038C00", VA = "0x188039E00")]
	public static CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ> OGAKBGHEIKK(string PGKKGLFIPNE)
	{
		return default(CKPFCFEHEPP<HLLMGBGMJCC, KFIMMOAALHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum FKGPGNKMBDI
{
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GAMMCAEGABJ : IDisposable, DEAKCBKIHCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private NativeList<FLPAONONIEF> FCEIEJMPBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	private float OHMDFEMMNBP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BKLCIIPAJGH JMIFPABPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(BKLCIIPAJGH);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MIJBJBIMLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F17FE0", Offset = "0x6F16DE0", VA = "0x186F17FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KAFLPNJDFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F17FF0", Offset = "0x6F16DF0", VA = "0x186F17FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<FEGABJCDLKI> GPNLNFLBIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KMCEJHPDDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8035570", Offset = "0x8034370", VA = "0x188035570", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JMHNAEDDLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8037260", Offset = "0x8036060", VA = "0x188037260")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8037A40", Offset = "0x8036840", VA = "0x188037A40")]
	public GAMMCAEGABJ(BKLCIIPAJGH AALJBKNKHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8035610", Offset = "0x8034410", VA = "0x188035610", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8036440", Offset = "0x8035240", VA = "0x188036440")]
	public Vector3 MKNAGHFBDGE(int BLFNDPNNLJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80357C0", Offset = "0x80345C0", VA = "0x1880357C0", Slot = "6")]
	public Quaternion GPAKHJFMOCE(int BLFNDPNNLJD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x80379A0", Offset = "0x80367A0", VA = "0x1880379A0", Slot = "5")]
	public Vector3 PLMAJLDGGPC(int BLFNDPNNLJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8035510", Offset = "0x8034310", VA = "0x188035510", Slot = "7")]
	public float CEIECHIHGHB(int BLFNDPNNLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8036910", Offset = "0x8035710", VA = "0x188036910")]
	public void MPIPILILLPD(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM, bool JILMNJOJJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80355B0", Offset = "0x80343B0", VA = "0x1880355B0")]
	private bool DIAPPPJHJKD(int FCHBJBCOAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8037840", Offset = "0x8036640", VA = "0x188037840")]
	public void PKPDLNPMCLK(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8035BA0", Offset = "0x80349A0", VA = "0x188035BA0")]
	public void LEECOEHLGKI(int FCHBJBCOAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8035670", Offset = "0x8034470", VA = "0x188035670")]
	public void GCBBPOPJPKE(int FCHBJBCOAKN, Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8035360", Offset = "0x8034160", VA = "0x188035360")]
	public void BJCPHPGFIBM(int FCHBJBCOAKN, float3 EMECBHNHILC, quaternion NOLDGDLLBBL, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8035A50", Offset = "0x8034850", VA = "0x188035A50")]
	public void KDIKDAMAMHH(int FCHBJBCOAKN, Vector3 EMECBHNHILC, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80358F0", Offset = "0x80346F0", VA = "0x1880358F0")]
	public void HEJNBHFFIJG(int FCHBJBCOAKN, Vector3 LCJFLGICHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8035C30", Offset = "0x8034A30", VA = "0x188035C30")]
	public static Quaternion MIELCFIPBBG(Quaternion EOMHGOPNFOC, int FCHBJBCOAKN, float EDJBJENLLGC, DEAKCBKIHCK NLNEAKEMABF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80373A0", Offset = "0x80361A0", VA = "0x1880373A0")]
	public Bounds OIFFKHOLIPP(Transform OLPMPAIMKPI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x80371F0", Offset = "0x8035FF0", VA = "0x1880371F0", Slot = "10")]
	public virtual void NDIEANLIDAL(bool BEFCBFJJNJI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8035290", Offset = "0x8034090", VA = "0x188035290")]
	public NativeList<FLPAONONIEF> ACGBBADNLGK(float EADMNEOBMNA = 1f)
	{
		return default(NativeList<FLPAONONIEF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FEGABJCDLKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public float3 BKNMJONCLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public float EPJCPHOJPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public quaternion BDPBOCIJJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80350B0", Offset = "0x8033EB0", VA = "0x1880350B0")]
	public FEGABJCDLKI(Vector3 MLCPBGGGOAK, Quaternion EOMHGOPNFOC, float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8034D00", Offset = "0x8033B00", VA = "0x188034D00")]
	public Quaternion HCPHGOEAIHL(Vector3 NCJMIJBPLIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8034DC0", Offset = "0x8033BC0", VA = "0x188034DC0")]
	public FEGABJCDLKI HJGKINEDIDL(Vector3 JBHBJLGEJKF, Vector3 EKOAGILLCFH, Vector3 ICFFAKBMEEJ)
	{
		return default(FEGABJCDLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8034B60", Offset = "0x8033960", VA = "0x188034B60")]
	public KBHAJOKCPKM FKHBJCLBKLO(Vector3 NCJMIJBPLIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EMPFNPDGBKE : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8034040", Offset = "0x8032E40", VA = "0x188034040", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8033780", Offset = "0x8032580", VA = "0x188033780")]
	private void CAKJHEMFOHP(Dictionary<Guid, Guid> CPLKHPPKPDB, NDJPPDGMICN NNKEMDDOBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8033D60", Offset = "0x8032B60", VA = "0x188033D60")]
	private void CAKJHEMFOHP(Dictionary<Guid, Guid> CPLKHPPKPDB, GGHKLBOMELM DPLNOIAFLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8033DC0", Offset = "0x8032BC0", VA = "0x188033DC0")]
	private void CAKJHEMFOHP(Dictionary<Guid, Guid> CPLKHPPKPDB, OGHGMDKFGDE NACBKLCLBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EMPFNPDGBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class GGDCALGMPLN : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8037C90", Offset = "0x8036A90", VA = "0x188037C90", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GGDCALGMPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JHNEDCOKGAL : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8039A50", Offset = "0x8038850", VA = "0x188039A50", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JHNEDCOKGAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FINJPGBCJBP : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8035130", Offset = "0x8033F30", VA = "0x188035130", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FINJPGBCJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PECMEIJCIAJ : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x803B950", Offset = "0x803A750", VA = "0x18803B950", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public PECMEIJCIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IKLFKNACINB : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8038FE0", Offset = "0x8037DE0", VA = "0x188038FE0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public IKLFKNACINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EFJEFFFIDPK : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x80335E0", Offset = "0x80323E0", VA = "0x1880335E0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EFJEFFFIDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ANAAMGIABBF : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8033150", Offset = "0x8031F50", VA = "0x188033150", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ANAAMGIABBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class NPOOFLOLGIB : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x803B6E0", Offset = "0x803A4E0", VA = "0x18803B6E0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NPOOFLOLGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class GBLMLCBMDCF : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8037AD0", Offset = "0x80368D0", VA = "0x188037AD0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GBLMLCBMDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class HINJPMKDKCO : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8038EE0", Offset = "0x8037CE0", VA = "0x188038EE0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public HINJPMKDKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class LIGDINJLCBO : NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public static readonly HIAJBKMBAGD OJDAKGAENMD;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x803A1C0", Offset = "0x8038FC0", VA = "0x18803A1C0", Slot = "4")]
	public void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public LIGDINJLCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CNDLBJKPKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public NPIADBPPJMB DMIBKIHBLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public JNIBGFPEKJC LPKFGMPLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public Dictionary<int, int> OAPNIPJBEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public Dictionary<Guid, Guid> OKGAMLFFNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public KBLDLLCAAED MLBOKBEGJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public bool PAIJGDKGMLA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NPKABHKPEIO
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHELAEJJLHI(OILLDAIBJNP CPBKJCLIOHM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GLAACBONBFC
{
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private static readonly NPKABHKPEIO[] FLDFDANIIHN;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8038240", Offset = "0x8037040", VA = "0x188038240")]
	public static void PIMOOABACBN(CDOFHMONKPD BOIPFNOKGBJ, HLLMGBGMJCC FCNNNJPEGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8037FB0", Offset = "0x8036DB0", VA = "0x188037FB0")]
	public static void HKJLJOIOBKL(CDOFHMONKPD? BOIPFNOKGBJ, HLLMGBGMJCC HLCMBJFKHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8037D40", Offset = "0x8036B40", VA = "0x188037D40")]
	public static void FDIOJBCNHGG(CDOFHMONKPD? BOIPFNOKGBJ, HLLMGBGMJCC MOFOHEKPLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x80384C0", Offset = "0x80372C0", VA = "0x1880384C0")]
	public static void PMEIHMFEPAN(OILLDAIBJNP CPBKJCLIOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OILLDAIBJNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public NPIADBPPJMB IHECFIMMEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public CDOFHMONKPD FKPLGDJFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public Dictionary<int, int> OAPNIPJBEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public Dictionary<Guid, Guid> OKGAMLFFNLE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x803B8A0", Offset = "0x803A6A0", VA = "0x18803B8A0")]
	public Guid FLDNLPALMPK(Guid OKDHAOKOGCM)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KBLDLLCAAED
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KHACKKEFMFI, [Out] Guid HFCFKHMFAEH);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class AJEJNDJABAI
{
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private static readonly HashSet<Guid> NIMBHHFKODL;

	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private static readonly ProfilerMarker IALBHLNBDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly HashSet<string> BOOLOKDINIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private readonly Dictionary<long, int> OFCFKPMKLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly HashSet<Guid> HENHHIJFGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private readonly HashSet<Guid> CJMJGAICJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly HashSet<Guid> HMLJEHBINGD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> PCMOADGLCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> LHDKPKBKPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> HILNEHBLMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> BHENDOKNLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x802FC60", Offset = "0x802EA60", VA = "0x18802FC60")]
	public static void ACMMPJIAHKD(OBPMHNNDFCF KMBNLHABJGO, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x80328F0", Offset = "0x80316F0", VA = "0x1880328F0")]
	public static AJEJNDJABAI NDJLIEALBLL(IMABAOJCLFC JBNEABKLADH, AIFEGLPMADP? KHOCDFEEGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8031D30", Offset = "0x8030B30", VA = "0x188031D30")]
	public static AJEJNDJABAI GCKNLHONJAI(OBPMHNNDFCF OIPMLNONLII, AIFEGLPMADP? KHOCDFEEGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8032270", Offset = "0x8031070", VA = "0x188032270")]
	public static AJEJNDJABAI LFPGMPFNKIO(AGBLNBMOMCG GFAEDOOMMGI, FFDDIIFJCDN DIDGDGLCMEE, AIFEGLPMADP? KHOCDFEEGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8031CA0", Offset = "0x8030AA0", VA = "0x188031CA0")]
	public static AJEJNDJABAI FEKKMNOMCPA(IEnumerable<string> BOOLOKDINIP, IReadOnlyDictionary<long, int> LDDIBAOBIBB, IReadOnlyCollection<Guid> HMLJEHBINGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8032AF0", Offset = "0x80318F0", VA = "0x188032AF0")]
	private AJEJNDJABAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8032C80", Offset = "0x8031A80", VA = "0x188032C80")]
	private AJEJNDJABAI(IEnumerable<string> BOOLOKDINIP, IReadOnlyDictionary<long, int> LDDIBAOBIBB, IReadOnlyCollection<Guid> HMLJEHBINGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8030E30", Offset = "0x802FC30", VA = "0x188030E30")]
	private void CHCHADNNFCJ(IMABAOJCLFC JBNEABKLADH, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8031550", Offset = "0x8030350", VA = "0x188031550")]
	private void CHCHADNNFCJ(OBPMHNNDFCF OIPMLNONLII, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8032330", Offset = "0x8031130", VA = "0x188032330")]
	private void LOFKNBAKFHA(ByteString? AGAEIFILLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80317E0", Offset = "0x80305E0", VA = "0x1880317E0")]
	private void CHCHADNNFCJ(AGBLNBMOMCG? EGPDFGOHLFM, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80314D0", Offset = "0x80302D0", VA = "0x1880314D0")]
	private void CHCHADNNFCJ(FFDDIIFJCDN? DIDGDGLCMEE, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8030CF0", Offset = "0x802FAF0", VA = "0x188030CF0")]
	private void CHCHADNNFCJ(EMDMKDLILEA? CIAHADHMFNP, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8031E20", Offset = "0x8030C20", VA = "0x188031E20")]
	private static bool ICLFGLGIBPO(EMDMKDLILEA CIAHADHMFNP, int NNOBIOLECMM, [Out] Guid BNKBELIFKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x802F740", Offset = "0x802E540", VA = "0x18802F740")]
	private static void ACMMPJIAHKD(FFDDIIFJCDN? EGPDFGOHLFM, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x802F500", Offset = "0x802E300", VA = "0x18802F500")]
	private static void ACMMPJIAHKD(EMDMKDLILEA? CIAHADHMFNP, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8030650", Offset = "0x802F450", VA = "0x188030650")]
	private static void ACMMPJIAHKD(AGBLNBMOMCG? EGPDFGOHLFM, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x802EEB0", Offset = "0x802DCB0", VA = "0x18802EEB0")]
	private static void ACMMPJIAHKD(FBLJPIGPJJO? FNINGPDJHMC, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80309D0", Offset = "0x802F7D0", VA = "0x1880309D0")]
	private void CHCHADNNFCJ(FBLJPIGPJJO? FNINGPDJHMC, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8032060", Offset = "0x8030E60", VA = "0x188032060")]
	private void JPMPIIKANLN(Guid? OKDHAOKOGCM, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80310D0", Offset = "0x802FED0", VA = "0x1880310D0")]
	private void CHCHADNNFCJ(CDOFHMONKPD? FKPLGDJFALO, AIFEGLPMADP? KHOCDFEEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x802F810", Offset = "0x802E610", VA = "0x18802F810")]
	private static void ACMMPJIAHKD(CDOFHMONKPD? FKPLGDJFALO, AIFEGLPMADP KHOCDFEEGID, HLLMGBGMJCC HOHNPPEBLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8031DB0", Offset = "0x8030BB0", VA = "0x188031DB0")]
	private void GCNDKHLMBFA(string? OBCMDOLDCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8031B80", Offset = "0x8030980", VA = "0x188031B80")]
	private void DMFCDPHEADE(long LBGELNIEBKI, Guid AMFMAOCJCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8031C50", Offset = "0x8030A50", VA = "0x188031C50")]
	private void DMFCDPHEADE(JEHNAAKDNGM? IKJMHGCPEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8031B20", Offset = "0x8030920", VA = "0x188031B20")]
	private void DMFCDPHEADE(IPDDGEKOGDJ? IKJMHGCPEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct MKBDLPAMKAE
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class BHHKGHHLHLH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private readonly IEnumerator<DictionaryEntry> DOHHLDONBML;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry FMKAHLKPHMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x80333C0", Offset = "0x80321C0", VA = "0x1880333C0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object PNDHCEECBFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8033480", Offset = "0x8032280", VA = "0x188033480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object HBDLGDLEPJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8033530", Offset = "0x8032330", VA = "0x188033530", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x80332E0", Offset = "0x80320E0", VA = "0x1880332E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
		public BHHKGHHLHLH(IEnumerator<DictionaryEntry> DOHHLDONBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8033240", Offset = "0x8032040", VA = "0x188033240", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8033290", Offset = "0x8032090", VA = "0x188033290", Slot = "9")]
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
		private sealed class KOMLIJBPNMK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x803A170", Offset = "0x8038F70", VA = "0x18803A170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public KOMLIJBPNMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x803A020", Offset = "0x8038E20", VA = "0x18803A020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x803A120", Offset = "0x8038F20", VA = "0x18803A120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x803F670", Offset = "0x803E470", VA = "0x18803F670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object MAHBBBBCDEL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x803F580", Offset = "0x803E380", VA = "0x18803F580", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x803F760", Offset = "0x803E560", VA = "0x18803F760", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x803F4C0", Offset = "0x803E2C0", VA = "0x18803F4C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x803F520", Offset = "0x803E320", VA = "0x18803F520", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x803F700", Offset = "0x803E500", VA = "0x18803F700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x803F180", Offset = "0x803DF80", VA = "0x18803F180", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x803F1E0", Offset = "0x803DFE0", VA = "0x18803F1E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x803F240", Offset = "0x803E040", VA = "0x18803F240", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
		public RoomObjectCounts(Dictionary<int, int> HANLELIOHLA, [Optional] Dictionary<int, int> ACDKHACJMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x803F0A0", Offset = "0x803DEA0", VA = "0x18803F0A0")]
		[IteratorStateMachine(typeof(KOMLIJBPNMK))]
		private IEnumerator<DictionaryEntry> DAIMMJOHPCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x803F7B0", Offset = "0x803E5B0", VA = "0x18803F7B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x803F3C0", Offset = "0x803E1C0", VA = "0x18803F3C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x803F2A0", Offset = "0x803E0A0", VA = "0x18803F2A0", Slot = "9")]
		void IDictionary.Add(object MAHBBBBCDEL, object BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x803F300", Offset = "0x803E100", VA = "0x18803F300", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x803F360", Offset = "0x803E160", VA = "0x18803F360", Slot = "8")]
		bool IDictionary.Contains(object MAHBBBBCDEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x803F460", Offset = "0x803E260", VA = "0x18803F460", Slot = "14")]
		void IDictionary.Remove(object MAHBBBBCDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x803F120", Offset = "0x803DF20", VA = "0x18803F120", Slot = "15")]
		void ICollection.CopyTo(Array COPOPHFGNFG, int CKFKPOAGPKN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class KAKGMOBAEBO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xD16990", Offset = "0xD15790", VA = "0x180D16990", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8039D40", Offset = "0x8038B40", VA = "0x188039D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public KAKGMOBAEBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8039BB0", Offset = "0x80389B0", VA = "0x188039BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8039CF0", Offset = "0x8038AF0", VA = "0x188039CF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8039760", Offset = "0x8038560", VA = "0x188039760", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object MAHBBBBCDEL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8039630", Offset = "0x8038430", VA = "0x188039630", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8039810", Offset = "0x8038610", VA = "0x188039810", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8039570", Offset = "0x8038370", VA = "0x188039570", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x80395D0", Offset = "0x80383D0", VA = "0x1880395D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x80397B0", Offset = "0x80385B0", VA = "0x1880397B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x80391F0", Offset = "0x8037FF0", VA = "0x1880391F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8039250", Offset = "0x8038050", VA = "0x188039250", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x80392B0", Offset = "0x80380B0", VA = "0x1880392B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x29B0B60", Offset = "0x29AF960", VA = "0x1829B0B60")]
		public Invention(long PPPFBKMGIMA, int LJEIHABMGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8039120", Offset = "0x8037F20", VA = "0x188039120")]
		[IteratorStateMachine(typeof(KAKGMOBAEBO))]
		private IEnumerator<DictionaryEntry> DAIMMJOHPCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8039860", Offset = "0x8038660", VA = "0x188039860", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8039430", Offset = "0x8038230", VA = "0x188039430", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8039310", Offset = "0x8038110", VA = "0x188039310", Slot = "9")]
		void IDictionary.Add(object MAHBBBBCDEL, object BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8039370", Offset = "0x8038170", VA = "0x188039370", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x80393D0", Offset = "0x80381D0", VA = "0x1880393D0", Slot = "8")]
		bool IDictionary.Contains(object MAHBBBBCDEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8039510", Offset = "0x8038310", VA = "0x188039510", Slot = "14")]
		void IDictionary.Remove(object MAHBBBBCDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8039190", Offset = "0x8037F90", VA = "0x188039190", Slot = "15")]
		void ICollection.CopyTo(Array COPOPHFGNFG, int CKFKPOAGPKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> AGLEJCLFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	public readonly IReadOnlyList<Invention> NFANCBIDBHP;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	public MKBDLPAMKAE(IReadOnlyDictionary<Guid, RoomObjectCounts> PMAGJINMLMA, IReadOnlyList<Invention> MPMPDAHLNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x803A410", Offset = "0x8039210", VA = "0x18803A410")]
	public static MKBDLPAMKAE NDJLIEALBLL(IMABAOJCLFC JBNEABKLADH)
	{
		return default(MKBDLPAMKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x803A2F0", Offset = "0x80390F0", VA = "0x18803A2F0")]
	[CompilerGenerated]
	internal static int JDNFJNBLBON([In] IReadOnlyDictionary<long, int> EBCDEMCDMLD, long? LBGELNIEBKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x803AE20", Offset = "0x8039C20", VA = "0x18803AE20")]
	[CompilerGenerated]
	internal static void PHJMGMPNEMJ(int MEMCHNMOMKN, [In] AGBLNBMOMCG DGMOHPHGINO, [In] Dictionary<long, int> EBCDEMCDMLD, [In] Dictionary<Guid, RoomObjectCounts> PMAGJINMLMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum PMCCBKDDIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class AIFEGLPMADP
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class GNGKNEBBCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly Guid IPLEJNECALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public readonly IReadOnlyList<Guid> LHDKPKBKPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public readonly PMCCBKDDIGM KPEBMAKAKKI;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8038E80", Offset = "0x8037C80", VA = "0x188038E80")]
		public GNGKNEBBCIM(Guid COBCHIDBIBM, IReadOnlyList<Guid> HMLJEHBINGD, PMCCBKDDIGM INALECHHMIH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058B")]
	private readonly HLLMGBGMJCC ODOEJECFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private readonly Dictionary<Guid, GNGKNEBBCIM> JBIGFPAEDLO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public HLLMGBGMJCC ILBMCNAILBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x802EC00", Offset = "0x802DA00", VA = "0x18802EC00")]
	public void OLHPIGGMIDE(Guid LAOHJAHCPFM, Guid KLJADOLFKEM, IReadOnlyList<Guid> NODFNCIAHMJ, PMCCBKDDIGM INALECHHMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x802EB10", Offset = "0x802D910", VA = "0x18802EB10")]
	public bool ABDPOMGCFFI(Guid KFFDBCEMGEC, [Out] GNGKNEBBCIM CJHGNEADCNN, [Out] bool LGJNNBMNEKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x802EE10", Offset = "0x802DC10", VA = "0x18802EE10")]
	public AIFEGLPMADP()
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
