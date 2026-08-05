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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8214590", Offset = "0x8213990", VA = "0x188214590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCINNGMIHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> GCFEOOLBIFP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> KLBJKPMDNKM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> IHAHEIPLDLP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> DGPINNBCAKM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KOKNFCOPKKH;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string GAOOJJOJLHP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string GAEEJCPCDKH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8200FE0", Offset = "0x82003E0", VA = "0x188200FE0")]
	public static bool BJOMKIPFNHN(Guid CKIMLJLPPPD, int NDGEEFLLJFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82010E0", Offset = "0x82004E0", VA = "0x1882010E0")]
	public static bool EEGPAGEFGPP(Guid CKIMLJLPPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8201170", Offset = "0x8200570", VA = "0x188201170")]
	public static string EFCFDNHENHE(Guid OOOANFDGEED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NIMCOHHJBIK]
public enum PFOJAAOLAJJ
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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8206DA0", Offset = "0x82061A0", VA = "0x188206DA0", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OEHAMLFMJLA
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid DALBEGNJLKI;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JNEALMMELBD;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GABGJGCEPMK;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid ODPOHPHEKFH;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid FKGPIOGFOKB;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid EKKABCCHDJE;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid BKJBMOHFNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IGCCPEJKIIN;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid IENGECLGMJE;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid FOEHGDOJPCH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid IMMMHABNEFE;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid JPLEAOOIOPE;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid EHINGBLJGBB;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LKNDNJKLHDB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid KLAIPOMFCGE;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LOBOBECHCFH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid GKOOLOHMJIO;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid COHIAJFFLOL;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ALGOKBNBNBB;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid LJCKLGCIOJP;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GKFKJNMAGPI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid LJHDNDKCIHA;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid PPEPCILDKOC;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CMGCNEDIAGA;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NGNCACMNCAJ;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid ILDJAOMLBFM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CMFNDOGOMEM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CMBNGKGEHBF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid NJNEFBMAMBK;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JMMCHJEOGCG;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NLIEKFLIDBL;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid JMDNEKHOPNN;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BDOLCJAJOJN;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NPBOGLNOCBM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid GKPMDAIALPD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GIDGFICJONN;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid FADPHFKLNKD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid KIBNDPJHOOD;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid DMAINADAOJD;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EGBFHEJELJP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid KMACMBBGPKH;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OAMLPEALILC;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid AFCNAHBEJGJ;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JFOOIFLINOJ;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NFIHHEOMLEI;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid LFOGNCMOONE;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid AGNAKKNCHJB;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GPLJJKEPAMC;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JELFMLCNIOE;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OODGDHKAFLF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid JMLKNGKCMLB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid EKFKMOMMLDO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid IBEPBIINCMO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PHLJJDFFBCI;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HGIMDFGDDOA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid GDJKPDHDGGL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NHGCPABAGHF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MFJANKKCBGB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid FFEPCIJJFMB;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DBACHADEBGK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid JIDAPHCIGDK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid BDICCIBOIBJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid MMGHGPJDHJP;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BNNLEIJHCOM;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ILJKMDIDFEP;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid JNBLGCPLIFJ;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KJNKEIAFLLC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid FNJBJHILPIM;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid EAAFMNPNDPO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid BAJNJGMABHD;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ACCCKACEMJD;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid EABPFBAJDHH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid GPABLJOKEGB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid BHNGBPHPBMD;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid AIBFKNEEMGK;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid CHJBJHNLDGA;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid EKMNJFPPLMK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid HEPEMPOEGAL;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid DPNONONGKAA;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CIMLGPINBBO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid AJBCLLMFGAD;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KKGBKNOPECA;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid DJLJMAMAFHB;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DINEELBEKFK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid GCGIOAAFBFO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KNHNHBEHBHN;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GLLAHPNONHF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FEJJJMBAOMD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid NEFCFCGANBH;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid MIIKBKIKDGL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NKKOBBICBPO;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid KABJDEIJFLJ;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid JPNDDKMMJGF;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KKMKNPKDNBB;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid EJGFFIIGBMK;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid EHGCAHDCAHO;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid COIFOHKEPLE;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid LPJOFIENIMD;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid GBEGHHOFBPD;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid MIPLBMCLMCH;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid NNNGCNKOMFI;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid CBLPILGGBOI;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DKFGGCCAEFI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid AEIGFDFFBFM;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MEGPOGDOMCE;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid KHJBNKEIDDA;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid PAODLEAPMCD;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid KLJKPLEFOEA;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid EGBLALKPPIC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EPHIHJGGLCL;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid KOMKKBNKFPE;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid CBFIAOHNDPH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid MNEDENDNKFO;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid KAOJMKLBJMG;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid AHAEPKKGNFH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IFENLKOEBOC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PHBKGFOGCJD;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FGLNKKKDCCA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid DKKEBJOACPD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid HPGGCAEBOAI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid KHMJOGLLJEL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid IOLBOEKMACI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid NJBBLOHPKKM;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid NCIPGBGJMFO;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid NAOPINJCANE;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid NMJGCHBDHEC;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PPKJHBDKIIP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BAPJIMGPLDM;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PHHGBEHIIDB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CGIECHPIBJO;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FAFKJHFCAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid KKJCEJDABHI;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid NFFDOCINCKF;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid HGJHJLJMLDA;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BNLBDEHFABK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PNFOCOHBKBL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid DBDCDBAIGJN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid AGAKKLCNJHJ;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid FPILCCIGLJN;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid OCIKPCJGCNJ;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid CAKIFKICHMC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FONNNFPEKNL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid GAIMGNOBCOL;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid DBNDKNCIHOO;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid EBMOFLACOPB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid FAFOIFNBDFH;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GEKPBOPBGPI;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OFIIDJPFABN;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid GILJLMHFKHE;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid AIEAJECBGFB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LEGAPJJGNJC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid PPDJEHODPCK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid CMNAFJEMJLJ;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MOBLHLFJJLM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LBDAHDOLEMJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid PBDFDNIHJFK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid HAHEGDGBNBL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid CPPOHOGFIIC;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid OAEMFBAJAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DEFBBHPODPN;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid MGGJDDDMAIB;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid JFMMGCHALGB;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MMGKKJOPAAB;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid COLOAOHFKLA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FOCNMBPLPJA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KAKFMLEKAGD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HMEBAHIBPLN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid AEFAFGIHPFE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid EGFPGMGCDEB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GLMGBMOHEJG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid FOLODLAFCOI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MNMFDKFHIDC;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid MMICHJFOFFE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid HJOPIFFOEGH;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid HIKDJGDFDMF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid DDFLENBGPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CKCNKLLAFDK;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HEIDONBMLHK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MOLKKHBPPAK;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid OBIMNKGEEBL;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PCNLBIJJLJJ;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FIJJAAKDEPN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid BJDPIKBHIND;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid KLPDGJADNBB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DKGJNEAAPMI;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid LDMOMCJDKBF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid HLCOHNMHBCA;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PBODFGPFGJN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid GOLACFBHCOM;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CJGDGIBCMCI;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid KHOFLALOLDE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid KHHPJOLJMPO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid DJBHIDFILMP;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid PJKHMBIPJCL;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid ACBDPNDMBHC;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BEFLFAOAAHL;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NGPHCJFBJLD;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid DIFBCJJBJDM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DIAGOELKPOM;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid ONKEGEFHEDB;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid HNJDJOCLBFD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LACNPGNLHCN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KPOFIPDCBIK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FLINDLFIDLH;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid MGGIIDBCDFJ;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid HPPHLBIAFDL;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid PCOMFJAGDKC;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid CNBJJPONEFF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid BPKPHNFEAGI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HNLHMFJOAEK;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PMAFFKBAENB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FOLAHKFALCB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid NGHGBDCIAGL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CFKEFPGHHHP;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KOEDMNOJJKL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid NEOMIJAKMLH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid AHIDHOGNIII;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid EFDNAEBOMFE;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HICLINGHFED;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid HJDDLCCMBGE;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HMMOPKAPJGB;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid OGOHOKNAAKL;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid JBLEMNFLNJA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid LPMGPEPAICN;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HMKAGBBJJHL;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FIFNANHNENM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid DOOBLJCJFFK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GLPKHCKDKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CMBHNNEJCGA;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid IBFMBDALLIG;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GJAMLEMIHLF;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid MIBNEHHCEMF;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid IBEDLNGJLKJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid GEBCBPBNOAF;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KBECGAJHLJI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid AHKHKCHALOE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid NJFNNECOAFH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid LPDMDIBJACL;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid HAMHKBEGDHI;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid LKCAHKKFDHK;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid ADPGFJINMDO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid GGNCJGINOCL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JAOOLGOGBPF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid OBFEAHFHMFP;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FCFIBKEAJOG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid KHELHKKFOOD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid OHKPGNMNBGH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BJIEDFIMPMF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FPPDJMENDHJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MKOBBAIDMMH;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid POBAGFPNKFF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GDAKFAJDBBG;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JDLHMELCFHL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MHBDIAIOMDO;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid JFLAEFCGDCC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid LIGDJOPDKMM;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid MKBBMBGMODP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid CBMJAFJOAKB;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid LAFIBPAFCMF;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LFLENNGPIIG;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid MMDPNMPEKBD;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid JPFMHJCLGJF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid DMEEKBNJMBG;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid PDMKJLALNOF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid BKFBLJMLEEA;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LIEBMGHOEMP;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid BLMIGHCPNGB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GIADDIFLIFJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid GDGPCLLCAJO;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid ABJHMBIGPMF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NAMEACAJEFC;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EGLMDKJFMHP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid KEAFKDDEPBN;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid DBHFGBEJBEK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HFECBGHOFAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CLANOIBEEME;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PPLDGACPKOB;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FDEHKFOBODJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JBDOOMAJBHP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FHGKJBBEKME;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EENKNDGLKLC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KFLEKCLIBNC;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GDOPFPBMKGK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid FDHPEIEJLOJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid BJENBEONDFM;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid ADGFOHOJKLD;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid DFDBEOJOEAK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NEEFIHPOBEA;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid AOPLKFOENBJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid JMALDHPAGID;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid KNBBIHBBOID;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid NLEINMFBNAJ;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HNBCFAHOKDB;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid IBNCGEMEGHP;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid EDPJABDDNAI;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid EPAEAKHPAOJ;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid LBNCFCLICFH;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PDHFHECDPDF;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GLGBMNFJBBD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid LLPOJKFHICM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NJJJNFDJEGL;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid EABGGBGKKBO;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KJIKMNILMDK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LGAFHMJPEIN;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid JOHLBHNAMPC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid BBFILIMHJDD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid OEKDLHCJPKL;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JJHJFAOLBPN;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid NAPJMKIMMOG;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid PHDPEEMOKCF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid GLKNKFHEBCD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FEGFPHJNJGB;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LNBLABPCIMB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid APMDAEKJOPO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid CFACMMBBFCM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid COLDCNMPEEL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid PEIAPHBOGFL;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MFEJEOANFOO;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid JLBOPHHKCKL;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FNGHFGEDPCK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid FDOLGOBELJJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OPKDKJMNPEL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KEJOBEMMDKN;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AMFNPNBDPFI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid KDEHOFCBLMO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LGAJFBLBGMH;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HDJJFBMAPOF;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid FAODDKDDHCH;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CMLBLOIAIIG;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid OJHNGPJLBJH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid ILPIBHHBLOF;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid OHBOOOOPHHM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid BMANMOJBGEG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid IDCBBGCEDOH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid JNOHNJNLGNJ;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GKOCAKEKGOL;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid KGDJHDMMMMM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FEKFOIGCLJM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid LECHJHJJDMI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CJJMMOOEFPH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid NCCGKEFAHDC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid CBKLBGMOOOI;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NDFNFGLJKEE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NCKPMHLKPIE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid DMCALIGIJIF;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid NEIFMAFLBMN;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid GONHGJEBAGC;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid CKACFMIKGHI;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MABKJPKIHJL;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LJJMADFKCGC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ENFFBENGFOH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid DODCKMOFOKP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid CIADBGPKIEC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AFJPGFEKNKO;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid HJEOGMOJDED;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid HIDFFGACJJH;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid INACANGGPOH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PMDKNBLJMBK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid LBNAHFCBMEH;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid ENNBLEMLIJI;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid NGEEJMMPGHP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid JCGKNBPHGGJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid PAHLDDIJEJN;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid ICOOPHFAKFK;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid ACHEIFHJGBM;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FDBIALOGBAN;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OKEKLNGDCFD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid KMBDICBLJID;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid IGEDBCPLCEK;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid BDCDMGGIKKP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid PABFNLGCCKK;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid CHNEMFMJONK;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GMJABIKONCK;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OPIAOAMIDNK;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LALNGGMAHGG;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid BGPCLJOPNIC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid KBLIKDKDHAH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FOHEMJIBMDI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid DOPHFPKACFN;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid JCKCNAOLFAP;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DIAMCGFAKPE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid DLKKBHFJPKI;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KAMFKPFNBJK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid FKILNFHLMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid CNKNBIKJHKP;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JFLJMFCLONG;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HELLBCAIJLF;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HGKPDDIADJA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid APJDHEPOCEN;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid JAJHEBLEHBB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BPMABJMHKML;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid ALAEIFGMKEP;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid OGFKGKGCIKD;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IMHPJIIHFNF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid EPMCBBNEDOO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid AGKLFLLEIOD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid HCCJGFKLLKH;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid CMNLBINMDKK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid PJBMJHMLENP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BCHOEGGOKFE;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KKBICNFLOIK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid GLKKEKHCOND;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid ODBBEDGPPAN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CDPIAFDGIHO;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid MNLMKHFCGMD;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid BOHDKGNMKAM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid JGJFKCJIMHC;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OENHFCDDGDK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid CBHADPPCMEK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid CKOPDLABNCC;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MFKJBEIBGCL;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DCICLFFFNNE;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HMAALJNANMB;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid HGMGMFJFJBK;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid FECFJKMMGMH;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid KPPKOEKBFIG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid KGNPGHIAKJO;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MHMLIEMCAGG;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid GOGBGOEFKPL;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid AGNAEJCAMPK;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid EBLNNOBPGMF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid NFOENALKLFO;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PGBHFHDDMJN;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GCMCMCHFGHC;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid JJBABNPOFOA;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid LGFFNPJHIBJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JGMAOOJKLGK;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid CKJAMACKJLE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid MOCGNMHOIHK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LPCPDBKGFEB;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid OAOHJHCGBHO;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JCIECGNDJJC;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MIBFJOAAIOO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid BIKINHEKECI;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid HNCNNNFFPGF;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid MICDMCDHEKD;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid NNOLGPOFDPD;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KCPNNKFICIC;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DMAGANKDCEG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BPKCLHOABGF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HCCOLHIGKEC;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid CKOODCMPMON;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JMPKHODNCGG;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid GJBJIPPIMMF;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid EJGPMMDFHCK;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid PEPPEJBFBEG;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid OCCHLOLHMFL;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JNFLEPFCGFG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid OMBOOPHFCLP;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid FJNENDLBFOI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid CALFKEJLJDD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DFFJJLAOGCH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid DNCLOFIKMAF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PALNMIBHBHP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HCCJFAPGFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid BFJLMKHMOIP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JBFENAFIKHA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JNMBMGKFGGB;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid OABHCLOBOJK;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CNGPGBGFEDF;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid ODLHCOEJFFG;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid FBBEGDHFJKK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid DNAFEBDHIDM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid CPDENOOOKNN;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BBGCEPOFAIC;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid FOAFCLOMBOM;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid HJHGJLEDGGA;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid PNILFNKKFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid EFICBMGMKJE;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid GPNPKAKHACJ;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid LPKFLMJOCHB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid CNCNFNKBJLB;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PNCFENGEFJL;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid ODAMLCFGPDG;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid IPIMKCONLHL;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid JCFHEDALBPF;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JIDJIFHPNMP;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid KHKNPNBAANI;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid IKLAGCIGLGH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid EADKHNPKMJD;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid APIJMOKAAPA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid MPFGMBBOHGL;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BHKJLNKDEDA;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OJPKAHOKMHG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid FDIJAHKEJFK;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FJECKBACPMG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid ICDFDEHEDEB;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid LOBKODKAHLG;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid AHIPMMHCDLM;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HABOMPMHNLL;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid KDGGJLDDGCK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid IFPOLHAMJHJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid LLBNFGIENEN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid FIHAAJOBPLK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid BBBOIOCBOBG;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid LCBAOCOIPDM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid AIEHLAACIPD;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MHNMFEDAHPO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MIPJAAOBFIE;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AANGPDNDPJC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid PJPDOKIIKJK;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid EGOICHKGGJE;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KMAMAHAIPBB;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid DKANDOPENBO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid NGFOJDNEFJM;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MJDHPFFOJHN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EMIPEMILKHD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid DHNLKDIIJAN;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FBNPBNGJBNP;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BJDKHCGBMOG;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid NIGILGGFAIN;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid ODMLDPMCNND;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid LFPAHGCBDFP;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FDDEBAFIGHG;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid DJLCPONIAOE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JFDCJKLOLPF;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid NGGONLADKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KPIOLKHBHLE;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid HHGGOKLAHEE;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MAFBEHOIHDH;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JPNDOGKEMJJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid GMIFAGEIAEM;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid AKFBNNNPHFM;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JMBGGLMLCNA;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid PNPEFLPKFNN;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid KOPOPPMLMDH;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid AMGJGNGMCAB;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid AAMGCMMCHBN;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid DHKANLFBFNF;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid AOENIGIGFFJ;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid CBDONILEFEF;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HOBGOEAHANG;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid PBDGKJOJBPN;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid EEEBNFKAAFA;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid CMNOCMPBLEL;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid BNFAADAPDPK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid KKBMPPJNMHJ;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CIGABNCEBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid GJGJCBKBKJA;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid FNJPBPPONLD;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid DFMOIOCCKIL;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BIKKIPNJINM;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GIMOAMHLNLM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JDBCKIECCIB;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid ICHDDKCHNEA;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KGLKBCHDDLB;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid ONLPODEDOOI;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DHLDBEKBGLK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid FAAFNHKNPFN;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid AJMEMPFEHGI;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid FFFCALALBKA;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid PGLIGENGFJB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid NKDBDFILIII;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid KJOMPHCBGEJ;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid PNEPIMPDKOK;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid EOKPGNJAPMA;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid BEPOBPCEOIP;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid NONJBKGBMCN;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid PIINDKOMKAH;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IFLNENEFBCB;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid DBCLGCHFNHN;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid JLDJCIFOHMN;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid IFKDCNBIEAA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid LCFKPAALALB;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid JCEDHGCLGIB;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid OGILIPDDGNK;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid GHLBLEEDGDI;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid NBFAEMPPHNE;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid LOFFCGOLLAO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid MHCCDBBNPEI;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LJJDDHHKLCF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid GFEAEGDIIMA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid AMBAIKIDFAH;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid PCPEOJKLFCK;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid ADDGNOGFKJI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid BOBCMNBIIDI;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid DBCNCAGJJCM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid BFIJJLKHIHP;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid CEPFFIAABLC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid POPDOGCABFP;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid FINMLACEIAM;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid HLNJIPMGGPL;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid IEDKCAGOEJP;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid LLOLPHNDBJE;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid GKMIJAOIHCJ;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid FIAFPMNLJIG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid ACDPJMAOLNG;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid HNNFFNBBKLD;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid FJAKCLBLOIA;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid EALPLGFHOIH;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid OAGIADBFIDO;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid EAEBFBENPHB;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MOIOLGPJBJB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid HACJHGJJMIG;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid ANJHBGMEKPG;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid OJCDGDCDKPG;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid MMNHKDDCINO;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid PIGMFAIOPNP;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid BPHANDPJIJI;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid HPKPNNNGEAK;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid JNKEONBOMND;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid NLEBDGDFOGK;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MNBPDCLDCKH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid PMIAKNJEIHD;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid ADJFPPECDPC;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid LOCPBJECJKJ;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid FMPLJEHCIBA;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid KCEDLFHDEHD;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid ALKFDCLPKBO;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid IAGKCPMCPDI;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid FNHKPLNMOKK;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid KOELLPOPKOA;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid KHNHMKGDJBO;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid HODDDIJMHIN;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid AKKLGLOJCKK;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid IDAPMAEDADC;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid EEJJFFDCBLJ;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid LMIJIIAAMHJ;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid PDOEDMAFLNF;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid GKFBEPOFKHB;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid JFMBAOIMIJB;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid FMHOEDHJCGO;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid KPAAJLCEPPN;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid NHDLDNPPNKJ;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid OALAJPIICJJ;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid NFCFGABOMMH;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid AJKEIAGCJPF;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid HJPBFIILBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid NDOMJLNFFHF;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid PHAIGKHBAAN;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid CKEMOMHPACC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid NKPOCGPHCFH;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid KGCAGKONFFH;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid FOHGFMICFPE;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid BLHJLDDEHOI;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid PHCCFAOHEEC;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid BBMBGDLJBGN;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid PHJJLPFLFJA;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid NICPFMLGCDH;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid DFEBKCMEFCC;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid HCNOLMOCBMC;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid LFFJKEGBNGI;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid BLAFIDCLANC;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid DOAMECHCLLB;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid KNEOJHMGFCB;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid AELJHCLMACD;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid HNNOKILFIOO;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly Dictionary<Guid, PFOJAAOLAJJ> IEDBPGACODM;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly Dictionary<PFOJAAOLAJJ, Guid> JJOACKPAEBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PFOJAAOLAJJ> DBGHDHBAKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8214610", Offset = "0x8213A10", VA = "0x188214610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PFOJAAOLAJJ, Guid> DGGKIABPIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8214670", Offset = "0x8213A70", VA = "0x188214670")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EJLNEGIKMJE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8205B70", Offset = "0x8204F70", VA = "0x188205B70")]
	public static bool NOAIHFINDLN(FFNHDOBJOOA JAAIHENLAKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8205750", Offset = "0x8204B50", VA = "0x188205750")]
	private static bool NOAIHFINDLN(KINKPINACFL CMHOGPBPNOC, FFNHDOBJOOA JAAIHENLAKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HAOABILPFBK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JCEFGCIHLOA NGIAGNLBILI, [Out] Dictionary<int, int> DGJHODMKDPM);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(ICHMBANNAMC LCJIBPKCPDE, NPMJFKLGDLK BCNIPJKOFEM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CFNAMJGKFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly KOPAHOCLLKC NFFOGDCDMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IEnumerable<MGLJJACBNLF> DOELDHDEIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<MGLJJACBNLF> OFMFCEAOHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly JGDCCHDHIKG<BLBKEFIFJJH> MGKOIBNCDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly IReadOnlyList<JHAEJGCLILE<HEGDLLCPNGA>> DMKOLAEKNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly BNCNPMJAKKG BOIOAJIMDHL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MHFDNELCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82050D0", Offset = "0x82044D0", VA = "0x1882050D0")]
	public CFNAMJGKFJH(KOPAHOCLLKC EMMCOFKMDEN, IEnumerable<MGLJJACBNLF> NGAOMDMPJJJ, IReadOnlyList<MGLJJACBNLF> IDDJCMJDGAF, JGDCCHDHIKG<BLBKEFIFJJH> LIKDDKMGILA, IReadOnlyList<JHAEJGCLILE<HEGDLLCPNGA>> DGKNNAFLFFN, BNCNPMJAKKG GBEAKAGKBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GMOFAKELLHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly KOPAHOCLLKC NFFOGDCDMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<MGLJJACBNLF> DLABHBKDGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly JGDCCHDHIKG<BLBKEFIFJJH> MGKOIBNCDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyList<JHAEJGCLILE<HEGDLLCPNGA>> DMKOLAEKNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ByteString BPBLNLPCHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly BNCNPMJAKKG BOIOAJIMDHL;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82065C0", Offset = "0x82059C0", VA = "0x1882065C0")]
	public GMOFAKELLHE(KOPAHOCLLKC EMMCOFKMDEN, JGDCCHDHIKG<BLBKEFIFJJH> LIKDDKMGILA, IReadOnlyList<JHAEJGCLILE<HEGDLLCPNGA>> DGKNNAFLFFN, ByteString PGJMPOIJALC, IReadOnlyList<MGLJJACBNLF> EBBNDDJAAGE, BNCNPMJAKKG GBEAKAGKBOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EPFEIALDGIA : KGPKHFIDLJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly Guid ODDDAFFLDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly Dictionary<Guid, Guid> FKMIOCNPCCJ;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EFEB90", Offset = "0x4EFDF90", VA = "0x184EFEB90")]
	private EPFEIALDGIA(Guid APJGMGBLHNP, Dictionary<Guid, Guid> FKMIOCNPCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8205C10", Offset = "0x8205010", VA = "0x188205C10")]
	public static EPFEIALDGIA EJOLKNBPCJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8205D40", Offset = "0x8205140", VA = "0x188205D40")]
	private static Dictionary<Guid, Guid> FGGALIALIMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8205DF0", Offset = "0x82051F0", VA = "0x188205DF0")]
	public static EPFEIALDGIA FOGJCPJKPJA(IReadOnlyDictionary<Guid, Guid> BEOBAPANJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82062D0", Offset = "0x82056D0", VA = "0x1882062D0")]
	public static EPFEIALDGIA OMEGGAJFKFP(IEnumerable<KeyValuePair<Guid, Guid>> BEOBAPANJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8205E80", Offset = "0x8205280", VA = "0x188205E80")]
	public Dictionary<Guid, Guid> LBGMBEFKOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
	public Dictionary<Guid, Guid> AHCAMOOKEEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8205E00", Offset = "0x8205200", VA = "0x188205E00")]
	public void KOBMLIBBKBO(Guid BEOBAPANJHO, Guid MBAOOPBKPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8206050", Offset = "0x8205450", VA = "0x188206050")]
	public void OAALEGOFLKA(IReadOnlyDictionary<Guid, Guid> GFBIHDLFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8205F00", Offset = "0x8205300", VA = "0x188205F00")]
	public Guid LFEFBPOONLI([In] Guid BEOBAPANJHO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8205CA0", Offset = "0x82050A0", VA = "0x188205CA0")]
	public Guid FCPHGDHFOCH([In] Guid BEOBAPANJHO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8205BA0", Offset = "0x8204FA0", VA = "0x188205BA0")]
	public bool ALMEBOPAJEC([In] Guid BEOBAPANJHO, [Out] Guid MBAOOPBKPLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8205BA0", Offset = "0x8204FA0", VA = "0x188205BA0", Slot = "4")]
	private bool FOBOCKJOACC([In] Guid BEOBAPANJHO, [Out] Guid MBAOOPBKPLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OLKPLGEBGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JOPHIIAHNCD(Guid OOOANFDGEED);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BKPGNNOHEEB(Guid OOOANFDGEED);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MMPICJIBFBA
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
public abstract class DPFFJCAIKAI : OLKPLGEBGPM
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OIHFOLJPJOB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public OIHFOLJPJOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82146D0", Offset = "0x8213AD0", VA = "0x1882146D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8214830", Offset = "0x8213C30", VA = "0x188214830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8214790", Offset = "0x8213B90", VA = "0x188214790", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8214790", Offset = "0x8213B90", VA = "0x188214790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JJKIGNHNKLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public DPFFJCAIKAI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8206630", Offset = "0x8205A30", VA = "0x188206630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8206D40", Offset = "0x8206140", VA = "0x188206D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private Dictionary<string, HashSet<Guid>>? MKPOFDFIDAF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> GKFHDBCLGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82055A0", Offset = "0x82049A0", VA = "0x1882055A0")]
		[IteratorStateMachine(typeof(OIHFOLJPJOB))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? BGJJIAKOGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool APJKHDBPGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool IJOHFOLJJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> NIGMEMMAEGA(string PIOIKDBGPHD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8205140", Offset = "0x8204540", VA = "0x188205140")]
	[AsyncStateMachine(typeof(JJKIGNHNKLP))]
	public Task BCPGINODAHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x12EF0D0", Offset = "0x12EE4D0", VA = "0x1812EF0D0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82052F0", Offset = "0x82046F0", VA = "0x1882052F0", Slot = "4")]
	public bool JOPHIIAHNCD(Guid OOOANFDGEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8205220", Offset = "0x8204620", VA = "0x188205220", Slot = "5")]
	public bool BKPGNNOHEEB(Guid OOOANFDGEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8205600", Offset = "0x8204A00", VA = "0x188205600")]
	private bool OMCANMCNCEK(string IFGBALAINIK, Guid OOOANFDGEED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected DPFFJCAIKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MIFAHCIHBPM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DGGAJCHCCND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public KOPAHOCLLKC staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DGGAJCHCCND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82188E0", Offset = "0x8217CE0", VA = "0x1882188E0")]
		internal JGDCCHDHIKG<NABBOOMEFHH> AGKPAHLOEIN((JGDCCHDHIKG<BLBKEFIFJJH> GraphId, JGDCCHDHIKG<HEGDLLCPNGA> NodeId) i)
		{
			return default(JGDCCHDHIKG<NABBOOMEFHH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private static readonly LHABNBDCIPF<NABBOOMEFHH, int?> LAPBGLGNODA;

	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly long JJJPPKLJAFP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8206FA0", Offset = "0x82063A0", VA = "0x188206FA0")]
	public static (long, long) GEEOJJCOGPG(KOPAHOCLLKC HDEHDMCEFJL, JGDCCHDHIKG<BLBKEFIFJJH> LAGHGCFFPCD, JGDCCHDHIKG<HEGDLLCPNGA> BBEBJBEHHMM)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8206E70", Offset = "0x8206270", VA = "0x188206E70")]
	public static long EHCIMANCABE([In] ReadOnlySpan<JGDCCHDHIKG<NABBOOMEFHH>> KBNKMABGMCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8207440", Offset = "0x8206840", VA = "0x188207440")]
	private static long LHGEDPKPMCA()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JFIKIAJHCDI
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public static readonly HashSet<PFOJAAOLAJJ> PENLBDEIKPM;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OGIIMBMHNAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GNKAHEPPFFP : IEnumerable<MGLJJACBNLF>, IEnumerable, IEnumerator<MGLJJACBNLF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private MGLJJACBNLF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private ENAGKOIEJEI spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public ENAGKOIEJEI <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private JNNEFDPGIDB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public JNNEFDPGIDB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private MGLJJACBNLF System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public GNKAHEPPFFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x821DFD0", Offset = "0x821D3D0", VA = "0x18821DFD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x821E250", Offset = "0x821D650", VA = "0x18821E250", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x821E0E0", Offset = "0x821D4E0", VA = "0x18821E0E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MGLJJACBNLF> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x821E0E0", Offset = "0x821D4E0", VA = "0x18821E0E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8224320", Offset = "0x8223720", VA = "0x188224320")]
	public static ENAGKOIEJEI LLOBLKNPFAP([In] GMOFAKELLHE BALPCJLJPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82244A0", Offset = "0x82238A0", VA = "0x1882244A0")]
	public static ENAGKOIEJEI LLOBLKNPFAP([In] CFNAMJGKFJH BALPCJLJPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8223DE0", Offset = "0x82231E0", VA = "0x188223DE0")]
	private static HashSet<JHAEJGCLILE<PBMMKLEMKIB>> IDJKLCHDPCA(IReadOnlyList<MGLJJACBNLF> DIGJPFPJOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8224CC0", Offset = "0x82240C0", VA = "0x188224CC0")]
	private static void PMLIFNGANPJ(ENAGKOIEJEI GDGHOCLIDEP, [In] CFNAMJGKFJH CNGBOMDEKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8222370", Offset = "0x8221770", VA = "0x188222370")]
	public static DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE> DCBNMJCGBKC(ENAGKOIEJEI GDGHOCLIDEP, JNNEFDPGIDB NFOGHLHHNDO, EPFEIALDGIA? KBFMNAELIFP, bool DGNMEMCDCIJ)
	{
		return default(DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8224180", Offset = "0x8223580", VA = "0x188224180")]
	[IteratorStateMachine(typeof(GNKAHEPPFFP))]
	private static IEnumerable<MGLJJACBNLF> IJGKKKEBCMH(ENAGKOIEJEI GDGHOCLIDEP, JNNEFDPGIDB NFOGHLHHNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82238C0", Offset = "0x8222CC0", VA = "0x1882238C0")]
	private static void HCGDCIHPFJG(ENAGKOIEJEI GDGHOCLIDEP, JNNEFDPGIDB NFOGHLHHNDO, IReadOnlyCollection<ByteString>? AMOMBAODLDK, IReadOnlyCollection<ByteString>? JNNANNLDAMM, IReadOnlyCollection<ByteString>? EJKMOMHDANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8224630", Offset = "0x8223A30", VA = "0x188224630")]
	private static bool OMHEFLOENMI(ENAGKOIEJEI GDGHOCLIDEP, ICHMBANNAMC LCJIBPKCPDE, JNNEFDPGIDB NFOGHLHHNDO, [Out][NotNullWhen(false)] string? FKPCAPOIAIK, [Out] Dictionary<int, int> DGJHODMKDPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8222090", Offset = "0x8221490", VA = "0x188222090")]
	private static Dictionary<Guid, KINKPINACFL> COGNEMFNELA(ENAGKOIEJEI GDGHOCLIDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8224290", Offset = "0x8223690", VA = "0x188224290")]
	private static void JMHAKAAHDJL(bool FMGBMKGEBMC, MGLJJACBNLF EGAMMPAFFJK, EPFEIALDGIA MJDEEFLELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8221E00", Offset = "0x8221200", VA = "0x188221E00")]
	private static void BCJAIDGFJDI(MGLJJACBNLF EGAMMPAFFJK, Guid KBCJANMKKCN, HCNDPBCEHIK? NHHFKIILIEJ, Dictionary<Guid, KINKPINACFL> KODAKJPBLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8223930", Offset = "0x8222D30", VA = "0x188223930")]
	private static void IBHCODPICGJ(IEnumerable<MGLJJACBNLF> JCHEMHKJHLF, IReadOnlyCollection<ByteString> AMOMBAODLDK, IReadOnlyCollection<ByteString> JNNANNLDAMM, IReadOnlyCollection<ByteString> EJKMOMHDANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JNNEFDPGIDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public bool FMGBMKGEBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public BNCNPMJAKKG GBEAKAGKBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public HCNDPBCEHIK? NHHFKIILIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public HCNDPBCEHIK? JFLMIKLLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public KOPAHOCLLKC HKGFOJEBGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public MMPICJIBFBA NKPNKCBHJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public HAOABILPFBK PIDBNJBGNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public JHAEJGCLILE<BLBKEFIFJJH> FCEIKCEGPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public JCFDCOJJKGD CHEMHIFCBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public List<MGLJJACBNLF> AOANDLILAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public NALOKHDCBNN MIJOFKBHCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public JEIMDIBHPFB IPPJLMHJIOL;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HCNDPBCEHIK
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private const float KCNKKJONANL = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public Vector3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public Quaternion EMLGDFFEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public float MJHAIBCGLLD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 BFOIHGBLLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x821ED60", Offset = "0x821E160", VA = "0x18821ED60")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS IJHJLFBFPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x821EE70", Offset = "0x821E270", VA = "0x18821EE70")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1618F60", Offset = "0x1618360", VA = "0x181618F60")]
	public HCNDPBCEHIK(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float MJHAIBCGLLD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x821EF40", Offset = "0x821E340", VA = "0x18821EF40")]
	public HCNDPBCEHIK(UniformTRS BLFKKLOBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x821EAE0", Offset = "0x821DEE0", VA = "0x18821EAE0")]
	public static HCNDPBCEHIK IEIFBGPKCIG(HCNDPBCEHIK JIECBJMGMAC, HCNDPBCEHIK PBENEMFBONO)
	{
		return default(HCNDPBCEHIK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x821EAC0", Offset = "0x821DEC0", VA = "0x18821EAC0")]
	public static HCNDPBCEHIK GKKMDDPCKIG((Vector3, Quaternion, float) NGIAGNLBILI)
	{
		return default(HCNDPBCEHIK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x821E960", Offset = "0x821DD60", VA = "0x18821E960")]
	public static HCNDPBCEHIK GKKMDDPCKIG(Matrix4x4 ENOKDGAKMLE)
	{
		return default(HCNDPBCEHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x821EEB0", Offset = "0x821E2B0", VA = "0x18821EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x821E640", Offset = "0x821DA40", VA = "0x18821E640")]
	public HCNDPBCEHIK APHBFMCBCLI(Matrix4x4 GANAIKEBLIG)
	{
		return default(HCNDPBCEHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x821E8F0", Offset = "0x821DCF0", VA = "0x18821E8F0")]
	public static HCNDPBCEHIK EICCMFJIBKL(Vector3 LBCFHLNAPLC)
	{
		return default(HCNDPBCEHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x821E860", Offset = "0x821DC60", VA = "0x18821E860")]
	public readonly KHKFPNJDFAC BJGDPDCIHBP()
	{
		return default(KHKFPNJDFAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GOAKIKONEAL
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DBKAJLMDAHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly LHBAOHCJNOC BEBCKMMIOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly HJLGPDLCPGE AMEGCDNDJHI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x18FE520", Offset = "0x18FD920", VA = "0x1818FE520")]
	private DBKAJLMDAHE(LHBAOHCJNOC OBGGAHJDHFG, HJLGPDLCPGE DEPCJENBGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8216030", Offset = "0x8215430", VA = "0x188216030")]
	public LLJNADLGOCO JCCNOENEIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8215E10", Offset = "0x8215210", VA = "0x188215E10")]
	public static DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE> EJOLKNBPCJB(MLJMIKJLFCC<EPILOLMBDMK> DEPCJENBGBG)
	{
		return default(DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8215EC0", Offset = "0x82152C0", VA = "0x188215EC0")]
	public static DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE> EJOLKNBPCJB(LLJNADLGOCO DEPCJENBGBG)
	{
		return default(DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8215F70", Offset = "0x8215370", VA = "0x188215F70")]
	public static DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE> EJOLKNBPCJB(string GCPEDFJBDBH)
	{
		return default(DGHPMJAIBNO<EPFEIALDGIA, DBKAJLMDAHE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LHBAOHCJNOC
{
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DFKBEMMBHEI : IDisposable, BNGPGNBMHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private NativeList<ABIKCOMHDNG> FKGKCFLIBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private float EHPBOBPHLDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public HNPEOKBOCPL HHPKHHAHCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		[CompilerGenerated]
		get
		{
			return default(HNPEOKBOCPL);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GEEEFLDIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x70C41D0", Offset = "0x70C35D0", VA = "0x1870C41D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DBBDHPJEIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x70C41E0", Offset = "0x70C35E0", VA = "0x1870C41E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<JHLEIOIJPMP> PBPFANIPOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NAKDCOGPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82180B0", Offset = "0x82174B0", VA = "0x1882180B0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MECMNBGPJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82160A0", Offset = "0x82154A0", VA = "0x1882160A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8218850", Offset = "0x8217C50", VA = "0x188218850")]
	public DFKBEMMBHEI(HNPEOKBOCPL DPALHGCDOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8216AF0", Offset = "0x8215EF0", VA = "0x188216AF0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8217A30", Offset = "0x8216E30", VA = "0x188217A30")]
	public Vector3 ILJADCNDIGI(int PFKMHLGKANI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82185D0", Offset = "0x82179D0", VA = "0x1882185D0", Slot = "6")]
	public Quaternion PJAGBCADLFH(int PFKMHLGKANI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8218300", Offset = "0x8217700", VA = "0x188218300", Slot = "5")]
	public Vector3 NDLNKFKIFCC(int PFKMHLGKANI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82180F0", Offset = "0x82174F0", VA = "0x1882180F0", Slot = "7")]
	public float KMDGNMMFJCA(int PFKMHLGKANI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8216CB0", Offset = "0x82160B0", VA = "0x188216CB0")]
	public void EEBBFAHHKNI(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO, bool FKDJNOALHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8218050", Offset = "0x8217450", VA = "0x188218050")]
	private bool KADGAIHABBL(int KMAOPBJDNNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82183A0", Offset = "0x82177A0", VA = "0x1882183A0")]
	public void NNEJGHABHOP(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8216250", Offset = "0x8215650", VA = "0x188216250")]
	public void CECDGLFFMNN(int KMAOPBJDNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8217F00", Offset = "0x8217300", VA = "0x188217F00")]
	public void IOLFDAFAKHN(int KMAOPBJDNNO, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8218150", Offset = "0x8217550", VA = "0x188218150")]
	public void MCGDHDOGJOO(int KMAOPBJDNNO, float3 LBCFHLNAPLC, quaternion EMLGDFFEJED, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8218700", Offset = "0x8217B00", VA = "0x188218700")]
	public void PNOIBBOLNFC(int KMAOPBJDNNO, Vector3 LBCFHLNAPLC, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8216B50", Offset = "0x8215F50", VA = "0x188216B50")]
	public void EALKJFMJGAN(int KMAOPBJDNNO, Vector3 KIAHAFCJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82162E0", Offset = "0x82156E0", VA = "0x1882162E0")]
	public static Quaternion DNBEDALBNDK(Quaternion AOLCBAKAICF, int KMAOPBJDNNO, float EMPOEBABDBN, BNGPGNBMHDI LGMBKMGAIMJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8217590", Offset = "0x8216990", VA = "0x188217590")]
	public Bounds ELAPDINOAOP(Transform GANAIKEBLIG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82161E0", Offset = "0x82155E0", VA = "0x1882161E0", Slot = "10")]
	public virtual void BIFGIJMGBMJ(bool LGNAMOCOFDB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8218500", Offset = "0x8217900", VA = "0x188218500")]
	public NativeList<ABIKCOMHDNG> OIBJDDOFKEJ(float LMPEIAFEMIK = 1f)
	{
		return default(NativeList<ABIKCOMHDNG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JHLEIOIJPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public float3 BKPAIEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public float LOJLBBEMLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public quaternion HCOGJLABKCM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8220400", Offset = "0x821F800", VA = "0x188220400")]
	public JHLEIOIJPMP(Vector3 DPIFCOHCFGC, Quaternion AOLCBAKAICF, float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8220050", Offset = "0x821F450", VA = "0x188220050")]
	public Quaternion IALFNCGKHFA(Vector3 NLDMHMFAEEN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8220110", Offset = "0x821F510", VA = "0x188220110")]
	public JHLEIOIJPMP KLPKNMGLCJC(Vector3 FEIBGEABOFB, Vector3 ANDJNNIHKPK, Vector3 LMABPCHCBOK)
	{
		return default(JHLEIOIJPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x821FEB0", Offset = "0x821F2B0", VA = "0x18821FEB0")]
	public LIFBHCIBBJH DPCPHJFCJCJ(Vector3 NLDMHMFAEEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DKKBEDJOJBE : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8219260", Offset = "0x8218660", VA = "0x188219260", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8218A10", Offset = "0x8217E10", VA = "0x188218A10")]
	private void FEGLIBFPJEO(Dictionary<Guid, Guid> MDOCHJPEJDI, CEAEGHMJFEI FAAEBNKGCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82189B0", Offset = "0x8217DB0", VA = "0x1882189B0")]
	private void FEGLIBFPJEO(Dictionary<Guid, Guid> MDOCHJPEJDI, HECJAAGOONK CLNHOPIOEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8218FE0", Offset = "0x82183E0", VA = "0x188218FE0")]
	private void FEGLIBFPJEO(Dictionary<Guid, Guid> MDOCHJPEJDI, DMFKBJCAMMC GPEJGKHIFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DKKBEDJOJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EFPLIIHIPPM : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x82192E0", Offset = "0x82186E0", VA = "0x1882192E0", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EFPLIIHIPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OALAECHKOJE : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8221CA0", Offset = "0x82210A0", VA = "0x188221CA0", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OALAECHKOJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ELKMOEPCMIL : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8219390", Offset = "0x8218790", VA = "0x188219390", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ELKMOEPCMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CADMDIAODCE : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8214A10", Offset = "0x8213E10", VA = "0x188214A10", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public CADMDIAODCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GEMHIINKMOF : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x821DAF0", Offset = "0x821CEF0", VA = "0x18821DAF0", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GEMHIINKMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MIGJIDHMNNC : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8221890", Offset = "0x8220C90", VA = "0x188221890", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MIGJIDHMNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KLGPFKPMNDB : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82217A0", Offset = "0x8220BA0", VA = "0x1882217A0", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KLGPFKPMNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class MKNCPLLKJHF : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8221A30", Offset = "0x8220E30", VA = "0x188221A30", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MKNCPLLKJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class IOPNBMLBJBP : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x821F010", Offset = "0x821E410", VA = "0x18821F010", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IOPNBMLBJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class FKIJIEOBGMP : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x821D9F0", Offset = "0x821CDF0", VA = "0x18821D9F0", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FKIJIEOBGMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class AMIKOLACAMD : GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public static readonly MMDFPPMOBLA CHBMAMLCJAG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8214880", Offset = "0x8213C80", VA = "0x188214880", Slot = "4")]
	public void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AMIKOLACAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FFNHDOBJOOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public ICHMBANNAMC CDBBOGJDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public LFHAHGOLIPJ JGBHCIGLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public Dictionary<int, int> BJBEDOIPHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public Dictionary<Guid, Guid> ABALLNBJHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public JEIMDIBHPFB IPPJLMHJIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public bool DGNMEMCDCIJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GCMFFNPDDEM
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEOFCDFEOPL(NHLDHLHFGHI HEKCFFAFFEG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class KFNJAALKLAE
{
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private static readonly GCMFFNPDDEM[] OMPJNPAJKCM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82208F0", Offset = "0x821FCF0", VA = "0x1882208F0")]
	public static void DLFIKAHGLEO(MGLJJACBNLF NGIAGNLBILI, EPFEIALDGIA NENANPBKOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8220660", Offset = "0x821FA60", VA = "0x188220660")]
	public static void BEIOPHDCMPP(MGLJJACBNLF? NGIAGNLBILI, EPFEIALDGIA IJMCANKJLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8220B70", Offset = "0x821FF70", VA = "0x188220B70")]
	public static void FEOMIAJIMAA(MGLJJACBNLF? NGIAGNLBILI, EPFEIALDGIA MJDEEFLELFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8220DE0", Offset = "0x82201E0", VA = "0x188220DE0")]
	public static void NOAIHFINDLN(NHLDHLHFGHI HEKCFFAFFEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NHLDHLHFGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public ICHMBANNAMC DJANFGKKFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public MGLJJACBNLF EGAMMPAFFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public Dictionary<int, int> BJBEDOIPHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	public Dictionary<Guid, Guid> ABALLNBJHGJ;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8221BF0", Offset = "0x8220FF0", VA = "0x188221BF0")]
	public Guid PEBKDHGDALO(Guid OOOANFDGEED)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface JEIMDIBHPFB
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FHKBJDEJDLG, [Out] Guid KBHIEODGNBG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FEAHLBPNAJF
{
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private static readonly HashSet<Guid> KJHKEONGKJD;

	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly HashSet<Guid> JMJGJNAPIGF;

	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private static readonly HashSet<Guid> IIJFIMKMOJM;

	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private static readonly ProfilerMarker JBHPIEJOBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly HashSet<string> DNKLKCDDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private readonly Dictionary<long, int> KBJLJBAANOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly HashSet<Guid> MLNOMFKIFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private readonly HashSet<Guid> CLEFDEHDGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private readonly HashSet<Guid> PGAMNOFCLGP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> BCHOHMDMPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> HIDKNNPMLJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> HPECFFJBGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> DCJGOBLBMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x821C050", Offset = "0x821B450", VA = "0x18821C050")]
	public static void MGDCDHLHAPG(ENAGKOIEJEI JNGPDCGIIBA, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x821AE50", Offset = "0x821A250", VA = "0x18821AE50")]
	public static FEAHLBPNAJF JOIILMPDJPM(LCCHGCBPFIP PHIIDLOGBDN, HBEOILABBHN? LNPEEIGPFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x821AED0", Offset = "0x821A2D0", VA = "0x18821AED0")]
	public static FEAHLBPNAJF LJNCLABNONN(ENAGKOIEJEI BDDHPBKBJLH, HBEOILABBHN? LNPEEIGPFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x821AD90", Offset = "0x821A190", VA = "0x18821AD90")]
	public static FEAHLBPNAJF IGPGNKGIPGG(GKEAFKFKOAP BCNIPJKOFEM, PGHBNMOLPEG FGABDCIOGLK, HBEOILABBHN? LNPEEIGPFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x821A8C0", Offset = "0x8219CC0", VA = "0x18821A8C0")]
	public static FEAHLBPNAJF DBOOCOKNDCD(IEnumerable<string> DNKLKCDDPGN, IReadOnlyDictionary<long, int> PLNAHLMJJOD, IReadOnlyCollection<Guid> PGAMNOFCLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x821D660", Offset = "0x821CA60", VA = "0x18821D660")]
	private FEAHLBPNAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x821D7F0", Offset = "0x821CBF0", VA = "0x18821D7F0")]
	private FEAHLBPNAJF(IEnumerable<string> DNKLKCDDPGN, IReadOnlyDictionary<long, int> PLNAHLMJJOD, IReadOnlyCollection<Guid> PGAMNOFCLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x821A210", Offset = "0x8219610", VA = "0x18821A210")]
	private void AGBCKKJAFFF(LCCHGCBPFIP PHIIDLOGBDN, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x821A4B0", Offset = "0x82198B0", VA = "0x18821A4B0")]
	private void AGBCKKJAFFF(ENAGKOIEJEI BDDHPBKBJLH, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x821AF50", Offset = "0x821A350", VA = "0x18821AF50")]
	private void LKHMMOFOOAP(ByteString? PGJMPOIJALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8219E50", Offset = "0x8219250", VA = "0x188219E50")]
	private void AGBCKKJAFFF(GKEAFKFKOAP? LDEPDDDHLLO, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x821A190", Offset = "0x8219590", VA = "0x18821A190")]
	private void AGBCKKJAFFF(PGHBNMOLPEG? FGABDCIOGLK, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8219870", Offset = "0x8218C70", VA = "0x188219870")]
	private void AGBCKKJAFFF(JFMPHJMCHDA? EBBNGJFJAGG, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x821A950", Offset = "0x8219D50", VA = "0x18821A950")]
	private static bool DKMOIMKDFAB(JFMPHJMCHDA EBBNGJFJAGG, int PIJPGBHEHDM, [Out] string? OOEOBJPMJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x821AB50", Offset = "0x8219F50", VA = "0x18821AB50")]
	private static bool DOLFBACGOAD(JFMPHJMCHDA EBBNGJFJAGG, int PIJPGBHEHDM, [Out] Guid MPALCJHLPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x821B530", Offset = "0x821A930", VA = "0x18821B530")]
	private static void MGDCDHLHAPG(PGHBNMOLPEG? LDEPDDDHLLO, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x821BA50", Offset = "0x821AE50", VA = "0x18821BA50")]
	private static void MGDCDHLHAPG(JFMPHJMCHDA? EBBNGJFJAGG, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x821BCE0", Offset = "0x821B0E0", VA = "0x18821BCE0")]
	private static void MGDCDHLHAPG(GKEAFKFKOAP? LDEPDDDHLLO, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x821CA40", Offset = "0x821BE40", VA = "0x18821CA40")]
	private static void MGDCDHLHAPG(GPMJNJGPOFI? BLJBPFHLMML, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82194F0", Offset = "0x82188F0", VA = "0x1882194F0")]
	private void AGBCKKJAFFF(GPMJNJGPOFI? BLJBPFHLMML, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x821D100", Offset = "0x821C500", VA = "0x18821D100")]
	private void OFGGNAFJLBP(Guid? OOOANFDGEED, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8219A50", Offset = "0x8218E50", VA = "0x188219A50")]
	private void AGBCKKJAFFF(MGLJJACBNLF? EGAMMPAFFJK, HBEOILABBHN? LNPEEIGPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x821B600", Offset = "0x821AA00", VA = "0x18821B600")]
	private static void MGDCDHLHAPG(MGLJJACBNLF? EGAMMPAFFJK, HBEOILABBHN LNPEEIGPFBA, EPFEIALDGIA LHIIANOMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x821D090", Offset = "0x821C490", VA = "0x18821D090")]
	private void MHHPAFOCIEE(string? EOKBOLDJGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x821A7F0", Offset = "0x8219BF0", VA = "0x18821A7F0")]
	private void CLNKPDCFCFL(long FKKIDEOCEFM, Guid OIPFBFJKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x821A740", Offset = "0x8219B40", VA = "0x18821A740")]
	private void CLNKPDCFCFL(OJAGNKKJBDJ? HLEDFFEHGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x821A790", Offset = "0x8219B90", VA = "0x18821A790")]
	private void CLNKPDCFCFL(PMHONMBMIIE? HLEDFFEHGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct CPHMFOCFDHI
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class GFOIIIAEHFF : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private readonly IEnumerator<DictionaryEntry> DKMELEEAPAI;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry DNPHMMIJHNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x821DDB0", Offset = "0x821D1B0", VA = "0x18821DDB0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object BPKEMDDKCGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x821DE70", Offset = "0x821D270", VA = "0x18821DE70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x821DF20", Offset = "0x821D320", VA = "0x18821DF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x821DCD0", Offset = "0x821D0D0", VA = "0x18821DCD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
		public GFOIIIAEHFF(IEnumerator<DictionaryEntry> DKMELEEAPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x821DC30", Offset = "0x821D030", VA = "0x18821DC30", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x821DC80", Offset = "0x821D080", VA = "0x18821DC80", Slot = "9")]
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
		private sealed class JEFIPAFBNHN : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x821FC50", Offset = "0x821F050", VA = "0x18821FC50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public JEFIPAFBNHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x821FB00", Offset = "0x821EF00", VA = "0x18821FB00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x821FC00", Offset = "0x821F000", VA = "0x18821FC00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x82258F0", Offset = "0x8224CF0", VA = "0x1882258F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object PEENICAIFOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8225800", Offset = "0x8224C00", VA = "0x188225800", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x82259E0", Offset = "0x8224DE0", VA = "0x1882259E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8225740", Offset = "0x8224B40", VA = "0x188225740", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x82257A0", Offset = "0x8224BA0", VA = "0x1882257A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8225980", Offset = "0x8224D80", VA = "0x188225980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8225400", Offset = "0x8224800", VA = "0x188225400", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8225460", Offset = "0x8224860", VA = "0x188225460", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x82254C0", Offset = "0x82248C0", VA = "0x1882254C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
		public RoomObjectCounts(Dictionary<int, int> ELLPOGFCGEH, [Optional] Dictionary<int, int> KGKHLONAGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8225320", Offset = "0x8224720", VA = "0x188225320")]
		[IteratorStateMachine(typeof(JEFIPAFBNHN))]
		private IEnumerator<DictionaryEntry> MBCKBHBBGGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8225A30", Offset = "0x8224E30", VA = "0x188225A30", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8225640", Offset = "0x8224A40", VA = "0x188225640", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8225520", Offset = "0x8224920", VA = "0x188225520", Slot = "9")]
		void IDictionary.Add(object PEENICAIFOP, object CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8225580", Offset = "0x8224980", VA = "0x188225580", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x82255E0", Offset = "0x82249E0", VA = "0x1882255E0", Slot = "8")]
		bool IDictionary.Contains(object PEENICAIFOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x82256E0", Offset = "0x8224AE0", VA = "0x1882256E0", Slot = "14")]
		void IDictionary.Remove(object PEENICAIFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x82253A0", Offset = "0x82247A0", VA = "0x1882253A0", Slot = "15")]
		void ICollection.CopyTo(Array LMLCJEFLFMP, int NOEININIMIL)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class JPHGBPAEAGE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x8220610", Offset = "0x821FA10", VA = "0x188220610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public JPHGBPAEAGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8220480", Offset = "0x821F880", VA = "0x188220480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x82205C0", Offset = "0x821F9C0", VA = "0x1882205C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x821F810", Offset = "0x821EC10", VA = "0x18821F810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object PEENICAIFOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x821F6E0", Offset = "0x821EAE0", VA = "0x18821F6E0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x821F8C0", Offset = "0x821ECC0", VA = "0x18821F8C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x821F620", Offset = "0x821EA20", VA = "0x18821F620", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x821F680", Offset = "0x821EA80", VA = "0x18821F680", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x821F860", Offset = "0x821EC60", VA = "0x18821F860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x821F2A0", Offset = "0x821E6A0", VA = "0x18821F2A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x821F300", Offset = "0x821E700", VA = "0x18821F300", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x821F360", Offset = "0x821E760", VA = "0x18821F360", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A3B0", Offset = "0x2A697B0", VA = "0x182A6A3B0")]
		public Invention(long CLNGGGMIBPI, int PPNAGMANAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x821F1D0", Offset = "0x821E5D0", VA = "0x18821F1D0")]
		[IteratorStateMachine(typeof(JPHGBPAEAGE))]
		private IEnumerator<DictionaryEntry> MBCKBHBBGGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x821F910", Offset = "0x821ED10", VA = "0x18821F910", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x821F4E0", Offset = "0x821E8E0", VA = "0x18821F4E0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x821F3C0", Offset = "0x821E7C0", VA = "0x18821F3C0", Slot = "9")]
		void IDictionary.Add(object PEENICAIFOP, object CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x821F420", Offset = "0x821E820", VA = "0x18821F420", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x821F480", Offset = "0x821E880", VA = "0x18821F480", Slot = "8")]
		bool IDictionary.Contains(object PEENICAIFOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x821F5C0", Offset = "0x821E9C0", VA = "0x18821F5C0", Slot = "14")]
		void IDictionary.Remove(object PEENICAIFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x821F240", Offset = "0x821E640", VA = "0x18821F240", Slot = "15")]
		void ICollection.CopyTo(Array LMLCJEFLFMP, int NOEININIMIL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000578")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> BAAFEIKNAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	public readonly IReadOnlyList<Invention> AKAOCDEIJEI;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	public CPHMFOCFDHI(IReadOnlyDictionary<Guid, RoomObjectCounts> HOCJNMGJMLD, IReadOnlyList<Invention> AJJBFFLIFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8215400", Offset = "0x8214800", VA = "0x188215400")]
	public static CPHMFOCFDHI JOIILMPDJPM(LCCHGCBPFIP PHIIDLOGBDN)
	{
		return default(CPHMFOCFDHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82152E0", Offset = "0x82146E0", VA = "0x1882152E0")]
	[CompilerGenerated]
	internal static int IDCMKDHPMMJ([In] IReadOnlyDictionary<long, int> AJDHOPJOPFF, long? FKKIDEOCEFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8214C30", Offset = "0x8214030", VA = "0x188214C30")]
	[CompilerGenerated]
	internal static void BABFDCLFLDF(int CHILDGLIJON, [In] GKEAFKFKOAP JDGEADMBCOI, [In] Dictionary<long, int> AJDHOPJOPFF, [In] Dictionary<Guid, RoomObjectCounts> HOCJNMGJMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum JKBGGMHHGAL
{
	[Cpp2IlInjected.Token(Token = "0x400058D")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x400058E")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HBEOILABBHN
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class BBHIEDEBGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public readonly Guid EGENNPOMEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public readonly IReadOnlyList<Guid> HIDKNNPMLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public readonly JKBGGMHHGAL BEBCKMMIOKF;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82149B0", Offset = "0x8213DB0", VA = "0x1882149B0")]
		public BBHIEDEBGIL(Guid GCDGOJIGOMN, IReadOnlyList<Guid> PGAMNOFCLGP, JKBGGMHHGAL OBGGAHJDHFG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private readonly EPFEIALDGIA CPGELEPADCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly Dictionary<Guid, BBHIEDEBGIL> EOPPMBJLDHD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public EPFEIALDGIA JNLECNFBMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x821E390", Offset = "0x821D790", VA = "0x18821E390")]
	public void KOBMLIBBKBO(Guid POFABPNCILA, Guid NMJFLEOKJGC, IReadOnlyList<Guid> PLEICCICJPD, JKBGGMHHGAL OBGGAHJDHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x821E2A0", Offset = "0x821D6A0", VA = "0x18821E2A0")]
	public bool EJABOMEMICK(Guid LCLPNBCDBKI, [Out] BBHIEDEBGIL GPECOKGJBEB, [Out] bool CPNFHMDFCGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x821E5A0", Offset = "0x821D9A0", VA = "0x18821E5A0")]
	public HBEOILABBHN()
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
