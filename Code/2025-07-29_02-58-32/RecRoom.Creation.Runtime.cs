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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8269010", Offset = "0x8267A10", VA = "0x188269010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ODIKCPDNCBB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PLBBDNGHMPE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> PNDKACPANBH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> OCKEGMFLLLH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> AKKANHMPALC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BEDHOCKFONP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CHIPLDFEBKF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string JMDIIAOOHDD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82697F0", Offset = "0x82681F0", VA = "0x1882697F0")]
	public static bool MIENKKHLKAI(Guid JLLEGOOAGKJ, int JANCLMOJKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8269090", Offset = "0x8267A90", VA = "0x188269090")]
	public static bool JOIKGGPCGOB(Guid JLLEGOOAGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8269120", Offset = "0x8267B20", VA = "0x188269120")]
	public static string KKCCFCCGJIG(Guid DNLDANFOOJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ECBNLFMBINN]
public enum JGBOKEGINHB
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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8268F40", Offset = "0x8267940", VA = "0x188268F40", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OEPEMHJDAND
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid LJLPLDFPKCM;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CGPEDLNHDJA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid KJOKDBNCOGF;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid KEEBJJDHLND;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid ILNBKJAGFOE;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DNPBMHGCLDI;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid HMPDJNMHMAA;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IBODKENBILD;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KCJCNKLLMLN;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid GAPOMHLEIFD;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid HDGOKDPLNFN;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid FJLPGNHCDLE;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid IGHJAFNDEPM;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ALMDAJCBAIA;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HHDHOMAIEJI;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid ACLLIJMONND;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid LHOOAJGNFME;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid IJFEKNFNGAB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid FPLNCFIOIAI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid NMGFBBOMFLA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GFLLGJAIKKM;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid AGJKCLBIENH;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BOFGMIEIBCB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid BOMEPLNJHAI;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid ECMDEKLOBDN;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid FBGENLBBEGI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid CBHIDDKCFPM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid JFMMPENMNKE;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid KEHFOGLCPBI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid NGLDONMLMKG;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid IAGCHEDIOIM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid NLEIIGNIDKE;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid OCODAHAHEMG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid EOMIFDICHNM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NFAMPFGFAEH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid EAFJIIEPJNP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid FOECHGNMEEL;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid AEKHMAMIBLE;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid FPPEJMKDAAB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EAAAKFOGDHJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid IMABCKMCPJO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CCLPALLCADO;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LCDBGDFCLIM;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BIDFAEKCKHP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid ABEMAHGDOJA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GKPFGLDKEKF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PNICANHCOHM;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid KKPMHOJPCIK;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GHDMOEANIEG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid LLDMMGLAPFJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EJAOAHEEBFO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid GIHKNEBOKFP;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid MOHOELFOIGK;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid CICCLEKKODP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid EGPPJNEBDHB;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid OOLCMPMFELO;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FENLBAFONFF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OKFIBBPBCBN;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid GDDAAPOLCHH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JIDGALNLAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BKIELMBCDNA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid DPFONNBJHBJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid OCBPGOBEANL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid CFBOHOCBJMN;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ADAMJAHGEEI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid FAHIFLKBBAK;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KMGEABJEMPK;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid FINIHKHJHDL;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid KGLMBOEKJEC;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid MPGEBOAOPKJ;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid BNGOPEAEJBI;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid PHNHMLBIAKK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LHANNHHFDOF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid KCGCGOGNHGD;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid POPHCCAKCCL;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid MHMOJMKPHFK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid FOKNAPBGBBP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid BCHCGDNDACC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LALFPCBDBFB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NDBDKBHBKOO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid FKEEACPHKJN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PPKGNHBOIME;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid AGNOIOKOMCI;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CPKHLLOLBPL;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid ILOADOCKKLK;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DHGBFIBHCGK;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KGKCMELIEBL;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid PIJACKLJFOM;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid PHBBIPJMIKH;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid LHGDKAPHADI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid MBJLGCLEJCC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OLNKODNMBAG;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid APIEOCMCJJN;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid NPBMGCHFMIJ;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AJHPBDKEJLF;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid EEKFPGDMBLH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid PCLCJMLKBML;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FNAOLJAHNMD;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JALDFBMGJMN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid AOMIDHEPLPA;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid PLHNFFCFGOA;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid JFANAIFBFLH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid HBEFFEHECPJ;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid CNFMKAMJCBE;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid FIAIDOAJHAF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid AFGKMIDIKFC;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid BNKOJOFACGN;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DOMGMHHHAEH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid AMAKLFJEGHK;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid MOCNOLFFNKG;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DHLOMOOHCOE;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid MGBCOAGLCOA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EBJDACIDNJD;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid MJLJONIPCOB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MOLHFFMPOCN;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid EIINCGOENOH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DCGJMLKLAHN;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JHFPIPIONPO;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid KJPDCBDNPBF;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DHJPIKHMEAB;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid LCKBCJILLLC;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid APNPOKEJNHL;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid OKFCJOBGCIK;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid PNHJFMAOPLC;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MOOJIOAEFGD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PPHEBCHEPEF;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid CNIFDGEPHND;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid CHPFICFGAGP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid AAIFLLEJJKK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IIHKKCNJOOC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid NLKOIPMLMIC;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid BLIIKGHJLMM;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid NHMFHEFBBIB;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KPNCDJJMCOG;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KEAANDHBFID;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid AEJNNFMEEBF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IILABOFKIFC;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid GPKJEIIDCDG;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid GFONFBPBFGK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid AJFMGDIMIFJ;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid HOCOMHELNLK;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid HGHBPKPEKKO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HKOOFBACPGM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid GMMEOECHOFK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid MFCMGELOPFM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid IFJPDFFADPN;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid FFLEFMGANAK;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LJIAKDDKBAA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid EOIHLDBBJIC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid ABAMOKLGBKD;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid MABAJLDDHEG;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid KGGOBLDKEFK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PMOGNHAAGGH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid BEMHMHIBGHO;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid EHGCIDACDEB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KDEGBHNAKKK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid MPGBKIMONGI;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid OIPJHDHPMAD;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid JOJHBHMBENH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid ALBLIKDABOK;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LOICLLJGBGN;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BGBIGEBOJIH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid IHLLJPDCBOA;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid DCPPGCIAMBD;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MDKPMOLGIPK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FJFHMPIBECM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid BFFECNBCANF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid KPBMFJKCAMI;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid KLICMEODNIM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid NBKMJNFOMCK;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid FLBCNMMIDIA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid IDIGDKIGLNB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid KFFMFECNDKC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DMEBAJHKJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KBJJLCPJDOA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid PBLGKJGEJDC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid OALGFNMBIKE;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid LIEMMLEOHLE;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DBEHMGIMHJC;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid MDKJCJDNKCG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BAINCCNNOLM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FJMEMMEKIIO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid OIBLFIOLLFB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CEBLOBCFJHI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DDBGELNJNMF;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid NIKNBMMJCKK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid OLHPLBFDDLD;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DKNLLKFFCMJ;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid OKELNKMPKGH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PEKNNEIMLCM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid LENDOCLMOPA;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid HKJCBFDMFDH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid PIEEJJBHAMN;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CJKFAHNGMPM;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid BLAHFHEBNKF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BALKMFGGJNJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NAFONKOLGFN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid CEMCKADLDJB;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CEAGABOLMEA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid FCFOAHABDHC;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid LLNLOHPDFCK;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid CABGIFPIMLI;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DOPFDMNFPJI;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid IAHAALNKJLO;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BIELJJKMCCF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid LLEGDOHPBAC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid EEKMFMPLJCN;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GCEMIABKNKI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EMJIKBKCOIB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid BMJKNCPCMIO;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid CJFIMKEOLCC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid CMHIPLIFAJN;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LGMBANOMEPG;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid FFMPHAGBOFF;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid EJENBBFOACH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid BNAFIPMHOAA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid BMOJOCKCAKC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DPMBEBLPBFH;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid PCLCEOEKEJP;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KCLPPPNAPFP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MOKFAGELIKD;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid KKCLOMECKJN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid BAPCADHAKPI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid LOFOCLPLICL;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid PJFENJODNLC;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OBJGPKHOBKE;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid BBCPLHPBDIB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HLFGOBMOIGC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid HCAPAPBJOMO;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid NMJEJHAMEDK;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JDMHGFADGIH;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ALEABEPPNJF;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid CGNCAEADBLO;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid DHJOEMNOMJN;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NOOEGKBBPMH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LAFNPGLCEHB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HBHLADCBMFA;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid AIIHOOBJKIC;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CEHEOFLBMOG;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid NBCKGLPKMOL;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid FGCJDEKAINH;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FGFNGDKANLK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid FABLIOKDPDE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid MGKFBNOLPHO;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LCCEEPLKNAF;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid LHIABAMCDFF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid JCENDOBAMEE;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FOEFPKFFMGJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid IMCGLEAMGOO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid FGKGJLIECGN;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid NMINLHIDKDL;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BPFPFPIBEAC;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid KAPCIKBOMCO;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DEJEGKCDKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid ILIKDACDLLI;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GBKGMDKIGME;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LCJEGGCBEJI;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid DOBPACGABJO;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid ALKLKALFPLK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid AFHKDDHHBGB;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid NBJHIGAKPFN;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid FIFGKPCPAHF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GONLINFPEHA;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid FKDGEDGKMFE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid JOANLOBFHCN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid HOOIJPCJCMI;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MAKHEECMGDE;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid LGDPCADBAAE;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid LCGBLABLBNA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CBCDEDEMEEB;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid ANMALMDLBGI;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KPLPAEDMLFF;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid ENELCFCCCEG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KJGEECIKIKA;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid FICCCKOCKKD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid MBDKPILNEEG;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid FPNHHILFADI;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FONNFHAKJKM;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JGNOECKLEJC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid OMADLAIGKPF;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid ICPIBKCEPPC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid MFFGKILMILM;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid IDFELCLDGLC;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid JNDHCEMPOFL;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid BBPFAMEBONK;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BPANCMLGAFE;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NIHEKPIGPMM;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IHFNIHKIJIC;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid AEOLFKKKLOK;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid ONACFMAMHIO;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid NAAEPJLGPAP;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OENHHKDIANB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid PHOBLLCDMKN;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid IOHOGEBGMFE;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid DGIFMAKMBLA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid KHDAFPMBFBL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IBIPMELCKPP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GCHHILNMDLD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid IAONCPIOCOC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid ILMBABGMBAJ;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NEBDNDCIDAA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DHADIAIOLHP;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AJKOEIPNFJA;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid PIGNNKGLKDK;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid NLKKBPBNCGK;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid NMFDAEBNCLG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MBNINEPKIOM;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid LMHLBCIGAAA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BLHKKDLIABH;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid ENLDNACJAAC;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid PMJCIIKDOBD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid MAKHJEOBBHD;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid ADENFBFIPLF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid IIIJFMLMFKG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid NDNKGMJEHFM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LLAMFIEACCL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NMJLKCFBPGK;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid KKEEODIPBEP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid JDLHAKBKDAF;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid DFBGOBAFFFL;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid NJEBKMAMHPB;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OAFIHGNEDHM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid BMCFLIHHJGI;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid FMBEIGGIKNH;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid ELGHDBIHNNC;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OMGKHMLFLHM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid JIKEICLHMMN;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid FPACFEHOBGJ;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid KGKKFHFFGCL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid FHHOCIOMLDH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid AAFKKJFOPPA;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DBMGFDGAMEG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HPFGMLHDFJA;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid MPIMFIPCFGK;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid GDDMGMLHFLK;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid LEINBIBBHHO;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid JGKOJNDPBHD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KGHFJPIFKGO;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid JDOIPFAJICK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid AOAHJOJDOKI;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EEIKOFIJLIL;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid AMABEFBAGEC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid IIFGONBHNDA;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DACDANEIFKM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid JGOMAPCBHFL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid NKEMELBIHEL;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid HODJOGHBCBE;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KNCKGJCMACF;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FFADIDEAPPE;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PGELCEJPGLP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid GLBKLNCDOPP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid LBNOLLHAHGG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IODNEJINGMO;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid HNLLNNDCMIH;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid ALBDDNHKCHF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JKMOFCEHDHM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BFOCAHCPLKE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid OLGECLKLPIP;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid ADLKDDEOAFJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DGGONEBPJBC;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid CCLBCNOJNPH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HAJALJNPHAF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid GDNLAFKAFAD;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BABMPGOHBLK;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid JHFMOOPKMNL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid ADIKDFBMCEN;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid LKFPHKPIDMK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid IOMPBDJMDDG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid GGJJHPOGFDK;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MLMILBIPBHK;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid COEFGCEMLEG;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid JFOJCBAKOIP;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid OKLCCCFOPAO;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OLNOKKFCPGC;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KKKDBLOOEDK;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid EOFFJHMJHKG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid BABCKIKCNAO;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid MEGOFOPIHPL;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CKEAAHMBDON;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NDOMDLHNPJB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid JNEDEDIBJAE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MBAIJPKBNKL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FMNOAOOFGMA;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid GBBNBGJFHLN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid ONDBJICDDJA;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid BKDKABHIMJI;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DOKKFIIKADP;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JIJANGJBOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CINKJLKJBCI;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid JKIMOKJFLPB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PGNDEJKPEDC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DPHOAPGDGBG;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JOMIBLLAIJI;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BPNCMFJLLHJ;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid KMDPOIJGOCK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LGPLGEEFAGL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid LECENNHDBMF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IDLENIGJJHF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid HHOPAOALECI;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid FJJKIAHEFPH;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HCKOJCGIIBN;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid HGGOOHJNHCL;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid GBBLADMPHHF;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid INCDLGGFEGN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GPBMMLONNGP;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid JLAMIBHMBHB;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KALFPMBFCDO;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BBGIMFPJCMP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid EDKLJJPNNFP;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid AKIJNICMJPC;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HCDEICMLHFP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid FHPBMMOBJHP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid LJIAOPDCKAJ;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AMDOKKLBBKI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CPGCJFDNPJN;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AGNNLOHEDED;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GLDBAFDAHOD;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid FDEHMDHNKBG;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid EFOEEFBMPIC;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid KIIPINDGEMM;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid ENNPPJJJDJO;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BADCDIABKCM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DNEGCMENBMA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid JAPGCDPAMMM;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid OFPMPILMPJF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OMCEJBOCNML;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid HBAKIKONOCC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid KMMODPJDGPK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CCBMDALGCFG;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid NLHFBCDBGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid IDJICDEMEEI;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid AAGHDPMJPHG;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CODLININKOI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PDJMJMNKNCI;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MLHCIEHCKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid DGHPFFJKKAP;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid FBIKMHMHCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid LEFIGFAOOJA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid KIMONECCBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GJBAPJILELN;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid MKNGJFEAAIK;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NBKPNHOJDFE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid ADLJLNAFHIH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CCEJHEKIFOI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid ABPLMGNAGAP;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid DDIHJPLDKKL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid OFOGOAOGOFB;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid GFIKBDPEKMH;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid MLHHCBFEPLO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid CNAJAJHNLJH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid IJCAKGKMCBO;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid GAGGPBKIBGD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid LFFELGFLOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PCOCMKNKEBO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid BAPNHBBDJFM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid FLKAKOHMNAN;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid NFGMDJCNMPA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GFGGEOMJDNO;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid HFKBODKDHOI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid ODLJMLHEACH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid FMKEGMOGNIE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid PHFHNAPEHDP;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid MDHPLDCOMMI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid PBBNPBIFLMA;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid CBMPGIDBBBG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LPDIBFLIMJP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BFHNECBDAFM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid KBDDKHHNNBE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid GFELKBKLBBP;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HMIBDDPGAJD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid AFCLHDGAOEB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FPMAGPMOBJE;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BLHGAAABGBA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid OPEPGAJABLF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GGBPGIODCNK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KBBAGJJAFJN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid PPCAELPPFCO;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid PHIOFPKEFGF;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MLFHGPDDHHE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid PPMIFCCNIBG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OJOAIHBKMKO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid COGNIBPBEDF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid FPEJIAOHGDM;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid DNCBFJELPKA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid CAMHMCDHFDI;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid MCGMPKHPGKN;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid KEPLMKBJBHN;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MMKMGLBPABG;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid JHJPNACIGJD;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NNEIAOLFGIJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid IIGBNKHFEPD;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JMMPLKOHPKJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JBHFLEKBKJF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid PCKEBFGBLGP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid CGEFDMALBBC;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BCIFDFAPEJF;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid LBGJIMKMHJE;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid AEDJCCEKGGI;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LCDALOHFJIL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid MEAFCJNIMJN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MIEDOAHCGHL;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DMBBALICEOK;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HFHJDKDOAOC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid PNHEDDAMBCP;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LHCBDNDEKEO;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid NHEOCBPIFCL;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid HNOPJJFNCJD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid DACFNPJLDJL;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PLOCOOFJEEB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid GJNNAAMIPKM;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid KLBFDDGILMO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid NLJJLNNPMMF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid NPIHILPCNIK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid BODBNDIMOJF;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OBEFGMOHMCN;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid ADEGGKBOKLF;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HIHBBDAMPAA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MLNPPKAAJMK;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EAPOOFBMBGG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid BONPNDDKBAL;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid PNHOJGPLCCO;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MNAMFMKIGHM;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid CAHMNNAFAOP;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid KIAKGIMPKGC;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid PIFGNOLIOML;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid FDDIPDOAPBG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid HJBELNNBKLF;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid IDEMFDMJOFE;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid HKHMLELABGN;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid PIGIECGJKJD;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid MEFOIIODCMI;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid FKHMHACKKPD;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid POELMIKEHOJ;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid OAHPAMJHGHP;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid BFMLGBMAOMD;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OIDIJFCOKEJ;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid CNPOHMGFFBF;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid JMGGAHBOLJD;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DOOIEBNMLMH;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid DPOBDCDOHNM;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid LCDNKFAHLPI;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid MGHGBBICMFK;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid JCPFOFJFKII;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid HMDLHLAKOPO;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PBGDDFGJFCI;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid NKNBFNJOHDH;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid COKEKEFIDBD;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid OEFFKHHJLMK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid OFCGCFNGOML;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid CMKHAMHHANG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid OENJDNJAFHD;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid BAKDKCLDHJL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid PAKHOLHAMAB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EAEFHBIBEKM;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid AAMMCIAHFMO;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid HKJBGIHFDGI;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DKGAJAJBMBE;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid PEINBKLIPEM;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid KCLHFKJOLJN;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid JCCLLPOOBNH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid HDHNCHLOBHJ;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid OPOGGAIDCIC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OAHBEPEOKHI;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid LCCPGPPFNAO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid BNPGEBOHLFJ;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid LAICIJJPJGB;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IGAAJIIFDOB;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid BLIJKPPFKCM;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid MCJEOFEAIDB;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid APPKGGDJPOF;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid KLEAAPDLPFA;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid AKNOPINFKEH;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid MHPJMGMKLMK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid NNIPDAAABIF;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid NDFDDHEJNJI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid GIAENHPCDII;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid JMDAALOFPKJ;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid KNONOPLFENL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BKHHLOOGNJM;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid BDHGCPEHKGB;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid JEIFDNIGNFI;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid KKBNDNDBIAI;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid JAHKMDDPEOK;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid ICHPKJDBEEM;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid PCBMNHPCLBL;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid AGAABNHHIKL;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IOONNAIDCFA;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GDPMCNOBONP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid IGAFFECPLBK;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid OPMAIIDIKDF;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid GEOKDNLNAGH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid FFEKKFODFPI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid PJKOPPBEAFH;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid CJOBAOBLBIG;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JJLGOICCAAD;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid ILMFKFGEKPH;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid LAGNGDEIFEE;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LPAGFCNEFKH;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MGCMACABIGJ;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid MLADCPECHCG;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid EJOGBNONGOG;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid GOAEMNIJEDH;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid CNOLHICMKOE;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LPHOMPLKPMJ;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid CCOBJCEKIHG;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid JEDKDCAGPIK;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid IJGGNIPDHGK;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid NHHMJLLBOEJ;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid FGHFODMJLBG;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid DKMMIIMMODC;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid LOHKGHMAAHM;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid DBLFAEBOBAN;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid HLKAPNFGMGE;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid CPINGJFACMM;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid GEDBJKEBNCO;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid OLMNFDMIHOI;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid BPICFDEMHNC;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid MOMKNPLOJLE;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid GKFBNLBNNOP;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid JPBKNLJEDBC;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid ELIALKHJNFD;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid BLJGHHDEPPE;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid LMHKMKKPOFA;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid FMHMLKIPPPG;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid PNBGLKOJFBB;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid MMICBDMCOJE;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid GINHFNGBEKL;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid GGBCLEKJHGN;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid INKGFMOFBCO;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid FIPHLMFOLFN;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid CNKEFCEHBKP;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid BGFHDIJKNLO;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid HHANMCEPMGL;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid CGHAGFCGOKJ;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid MMCBAEGCAFP;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid PHLEEIDDJBG;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid JBPJGBMGOKF;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid HDDBKJNECBC;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid LJJPHGKPBLF;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid ELPDJFOMFOM;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid DBOFEGCIMJP;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid ANIBOPMOJFF;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid EALMLLKPOKN;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid CECCPPIONDG;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid JIDLPABCMDL;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid FCPPKIKCOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid GCMODCKHHAK;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly Dictionary<Guid, JGBOKEGINHB> BGJIENGEPCA;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly Dictionary<JGBOKEGINHB, Guid> DNLINDLPIKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, JGBOKEGINHB> NMCODPIADMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x826D180", Offset = "0x826BB80", VA = "0x18826D180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<JGBOKEGINHB, Guid> CNLMEFCHKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x826D1E0", Offset = "0x826BBE0", VA = "0x18826D1E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GDLLCEEJHKK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8268730", Offset = "0x8267130", VA = "0x188268730")]
	public static bool LCOLJIBPOKM(PHIPOPCCIBI KCDFBOHDCEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8268310", Offset = "0x8266D10", VA = "0x188268310")]
	private static bool LCOLJIBPOKM(CCELPEKIHEB BFDHJGKAFLJ, PHIPOPCCIBI KCDFBOHDCEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDBMNGLFGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MCILLGCFOBJ GPCDCFCPGFK, [Out] Dictionary<int, int> OICAOOGJBKG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(BKLAHIHKKHK EBCDGLPCMDC, IIMGHDGFECA IAFDPFAOMOP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct ALJLKHMAIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly EJNECJPDDHA LFBCMJNMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IEnumerable<BHOPKDGDEFN> ENOPCFFAPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<BHOPKDGDEFN> AHOHICCAFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly COBPPOBACAG<JNIKNMAMHFM> PBNOCGJMELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly IReadOnlyList<MBHMHHMOEDL<CFJBLOCLLGM>> ABPPDBCLHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly DOGKMNCDBNN LFDKFGOJAKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FBAMHJKAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82676D0", Offset = "0x82660D0", VA = "0x1882676D0")]
	public ALJLKHMAIOE(EJNECJPDDHA CHMEIMFBPHJ, IEnumerable<BHOPKDGDEFN> MLEOHCPNBJG, IReadOnlyList<BHOPKDGDEFN> DNEGILLGIAN, COBPPOBACAG<JNIKNMAMHFM> CAIKMEDBDNE, IReadOnlyList<MBHMHHMOEDL<CFJBLOCLLGM>> NNPDAOICJKD, DOGKMNCDBNN DHNPBBCELMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HCIDCKLHMHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly EJNECJPDDHA LFBCMJNMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<BHOPKDGDEFN> OACFFMKMMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly COBPPOBACAG<JNIKNMAMHFM> PBNOCGJMELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyList<MBHMHHMOEDL<CFJBLOCLLGM>> ABPPDBCLHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ByteString BMBKGIKPLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly DOGKMNCDBNN LFDKFGOJAKE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8268760", Offset = "0x8267160", VA = "0x188268760")]
	public HCIDCKLHMHG(EJNECJPDDHA CHMEIMFBPHJ, COBPPOBACAG<JNIKNMAMHFM> CAIKMEDBDNE, IReadOnlyList<MBHMHHMOEDL<CFJBLOCLLGM>> NNPDAOICJKD, ByteString KGGIDIKOJFG, IReadOnlyList<BHOPKDGDEFN> FPGLLEBJLPN, DOGKMNCDBNN DHNPBBCELMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EPNCHHHPNKA : OEGLEFCJPOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly Guid PGJDAKMOBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly Dictionary<Guid, Guid> EKGECJENMCF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7650", Offset = "0x4EA6050", VA = "0x184EA7650")]
	private EPNCHHHPNKA(Guid NGIMNFKBNNI, Dictionary<Guid, Guid> EKGECJENMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8267C80", Offset = "0x8266680", VA = "0x188267C80")]
	public static EPNCHHHPNKA MDDJOGPLAFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8267860", Offset = "0x8266260", VA = "0x188267860")]
	private static Dictionary<Guid, Guid> CLKIGGMEACL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82677B0", Offset = "0x82661B0", VA = "0x1882677B0")]
	public static EPNCHHHPNKA CIGEPNIODOB(IReadOnlyDictionary<Guid, Guid> GJFINIAHPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8267910", Offset = "0x8266310", VA = "0x188267910")]
	public static EPNCHHHPNKA JDNGCBBHMKI(IEnumerable<KeyValuePair<Guid, Guid>> GJFINIAHPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8267C00", Offset = "0x8266600", VA = "0x188267C00")]
	public Dictionary<Guid, Guid> JGIBFLEABLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
	public Dictionary<Guid, Guid> LEKDNBNBMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8267E60", Offset = "0x8266860", VA = "0x188267E60")]
	public void MJGPLOFFIKO(Guid GJFINIAHPMG, Guid ADMLFNMDFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8267EE0", Offset = "0x82668E0", VA = "0x188267EE0")]
	public void MKAPDLLIFOG(IReadOnlyDictionary<Guid, Guid> AFPDPMHLFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8267D10", Offset = "0x8266710", VA = "0x188267D10")]
	public Guid MHGFGOACPFM([In] Guid GJFINIAHPMG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82677C0", Offset = "0x82661C0", VA = "0x1882677C0")]
	public Guid CLAHDAOMABJ([In] Guid GJFINIAHPMG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8267740", Offset = "0x8266140", VA = "0x188267740")]
	public bool MMCNBMPLEJJ([In] Guid GJFINIAHPMG, [Out] Guid ADMLFNMDFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8267740", Offset = "0x8266140", VA = "0x188267740", Slot = "4")]
	private bool ANEIJDOFCHH([In] Guid GJFINIAHPMG, [Out] Guid ADMLFNMDFNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FKNCBNDNAAC
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAJFLBFDNMJ(Guid DNLDANFOOJK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GANKHGKGCEH(Guid DNLDANFOOJK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ECJMABNJAIB
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
public abstract class OLGIEDHMDJL : FKNCBNDNAAC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FOJMGCNGNDM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public FOJMGCNGNDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8268160", Offset = "0x8266B60", VA = "0x188268160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82682C0", Offset = "0x8266CC0", VA = "0x1882682C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8268220", Offset = "0x8266C20", VA = "0x188268220", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8268220", Offset = "0x8266C20", VA = "0x188268220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LOJLJNIOCML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public OLGIEDHMDJL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x82687D0", Offset = "0x82671D0", VA = "0x1882687D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8268EE0", Offset = "0x82678E0", VA = "0x188268EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private Dictionary<string, HashSet<Guid>>? PDNPBELAHAN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> OEPPNIMHGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x826D240", Offset = "0x826BC40", VA = "0x18826D240")]
		[IteratorStateMachine(typeof(FOJMGCNGNDM))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? EMIONLIEOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool BKCFAKFOEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool HJDMDMJMGNA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> MEGFIMDMNPC(string OCIOHGDBDKK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x826D550", Offset = "0x826BF50", VA = "0x18826D550")]
	[AsyncStateMachine(typeof(LOJLJNIOCML))]
	public Task EGMEIHMMGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x12E6830", Offset = "0x12E5230", VA = "0x1812E6830")]
	public void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x826D2A0", Offset = "0x826BCA0", VA = "0x18826D2A0", Slot = "4")]
	public bool CAJFLBFDNMJ(Guid DNLDANFOOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x826D6F0", Offset = "0x826C0F0", VA = "0x18826D6F0", Slot = "5")]
	public bool GANKHGKGCEH(Guid DNLDANFOOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x826D630", Offset = "0x826C030", VA = "0x18826D630")]
	private bool FALKDEPHBHL(string KPMJGBBEFFP, Guid DNLDANFOOJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	protected OLGIEDHMDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class AIBOEJFLIGO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GFCAHGJCHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public EJNECJPDDHA staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GFCAHGJCHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x826F790", Offset = "0x826E190", VA = "0x18826F790")]
		internal COBPPOBACAG<MFIFDNPCNAC> JHDJBLLDKDD((COBPPOBACAG<JNIKNMAMHFM> GraphId, COBPPOBACAG<CFJBLOCLLGM> NodeId) i)
		{
			return default(COBPPOBACAG<MFIFDNPCNAC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private static readonly DKFNNOJMGBI<MFIFDNPCNAC, int?> DFOBIBHNGFF;

	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly long OIAPBDBLHCK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x825A200", Offset = "0x8258C00", VA = "0x18825A200")]
	public static (long, long) OEIKMAIKHMJ(EJNECJPDDHA EIGICMDOGAP, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x825A0D0", Offset = "0x8258AD0", VA = "0x18825A0D0")]
	public static long HICOLLPFDNN([In] ReadOnlySpan<COBPPOBACAG<MFIFDNPCNAC>> OEDOOBIIFMD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8259FB0", Offset = "0x82589B0", VA = "0x188259FB0")]
	private static long EOACLGBGKBD()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MICPHGAEHCI
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public static readonly HashSet<JGBOKEGINHB> PAHKCKBMBBB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GKFJPHPIEHN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LOEKMELCPMH : IEnumerable<BHOPKDGDEFN>, IEnumerable, IEnumerator<BHOPKDGDEFN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private BHOPKDGDEFN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private FNNMMEDNKCL spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public FNNMMEDNKCL <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private AHPIENABBJA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public AHPIENABBJA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private BHOPKDGDEFN System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFEC320", Offset = "0xFEAD20", VA = "0x180FEC320")]
		[DebuggerHidden]
		public LOEKMELCPMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x827C1D0", Offset = "0x827ABD0", VA = "0x18827C1D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x827C450", Offset = "0x827AE50", VA = "0x18827C450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x827C2E0", Offset = "0x827ACE0", VA = "0x18827C2E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BHOPKDGDEFN> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x827C2E0", Offset = "0x827ACE0", VA = "0x18827C2E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8274920", Offset = "0x8273320", VA = "0x188274920")]
	public static FNNMMEDNKCL HKLECCLPIGI([In] HCIDCKLHMHG ALMHHJDEFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8274AA0", Offset = "0x82734A0", VA = "0x188274AA0")]
	public static FNNMMEDNKCL HKLECCLPIGI([In] ALJLKHMAIOE ALMHHJDEFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8274C30", Offset = "0x8273630", VA = "0x188274C30")]
	private static HashSet<MBHMHHMOEDL<LDAGNOIPPMF>> KFAEFFHEOOF(IReadOnlyList<BHOPKDGDEFN> OEKCFEHGHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8273B80", Offset = "0x8272580", VA = "0x188273B80")]
	private static void FBFBCGHGDGO(FNNMMEDNKCL HFKOAFAFOFA, [In] ALJLKHMAIOE CDJPMLECKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8275770", Offset = "0x8274170", VA = "0x188275770")]
	public static DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ> MIGPFCKKBBA(FNNMMEDNKCL HFKOAFAFOFA, AHPIENABBJA JBCGIALAOHG, EPNCHHHPNKA? EAJKHDFKIKE, bool AOABIFNBEPN)
	{
		return default(DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8275660", Offset = "0x8274060", VA = "0x188275660")]
	[IteratorStateMachine(typeof(LOEKMELCPMH))]
	private static IEnumerable<BHOPKDGDEFN> MGJODIADBCK(FNNMMEDNKCL HFKOAFAFOFA, AHPIENABBJA JBCGIALAOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8276CC0", Offset = "0x82756C0", VA = "0x188276CC0")]
	private static void NNAJGJBEAIM(FNNMMEDNKCL HFKOAFAFOFA, AHPIENABBJA JBCGIALAOHG, IReadOnlyCollection<ByteString>? PPCMNNNIKID, IReadOnlyCollection<ByteString>? OGHOHBDKMGG, IReadOnlyCollection<ByteString>? NEBEGDLHBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8274FD0", Offset = "0x82739D0", VA = "0x188274FD0")]
	private static bool KLKMKGDFDHA(FNNMMEDNKCL HFKOAFAFOFA, BKLAHIHKKHK EBCDGLPCMDC, AHPIENABBJA JBCGIALAOHG, [Out][NotNullWhen(false)] string? GFHOJCCMEDK, [Out] Dictionary<int, int> OICAOOGJBKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82738A0", Offset = "0x82722A0", VA = "0x1882738A0")]
	private static Dictionary<Guid, CCELPEKIHEB> EIHPIEGMKMN(FNNMMEDNKCL HFKOAFAFOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8276D30", Offset = "0x8275730", VA = "0x188276D30")]
	private static void PPHNBFNKDPJ(bool FLFEHJGDCFK, BHOPKDGDEFN HGCHPOBFDBI, EPNCHHHPNKA LJKIMKGBIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82741E0", Offset = "0x8272BE0", VA = "0x1882741E0")]
	private static void FGLFGGLKFCJ(BHOPKDGDEFN HGCHPOBFDBI, Guid FPCKBBHLCAF, BDDDGNMMBLL? BBNIJACLGJF, Dictionary<Guid, CCELPEKIHEB> NPCKOMJAIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8274470", Offset = "0x8272E70", VA = "0x188274470")]
	private static void FOPAAMOMNFI(IEnumerable<BHOPKDGDEFN> NGNAJEPKMIA, IReadOnlyCollection<ByteString> PPCMNNNIKID, IReadOnlyCollection<ByteString> OGHOHBDKMGG, IReadOnlyCollection<ByteString> NEBEGDLHBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AHPIENABBJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public bool FLFEHJGDCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public DOGKMNCDBNN DHNPBBCELMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public BDDDGNMMBLL? BBNIJACLGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public BDDDGNMMBLL? ANEPHHLBOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public EJNECJPDDHA PAEJBJKDLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public ECJMABNJAIB AJBECBMODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public FDBMNGLFGFD AHEKAHDFKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public MBHMHHMOEDL<JNIKNMAMHFM> GIJAAMEMCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public MLOJGBHDALB BDNFGMCLBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public List<BHOPKDGDEFN> DCNFIALEEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public PJGPPIKLFJC EJGIGJOCBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public DOBLDCEJMDE IFJKJJPNGDN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BDDDGNMMBLL
{
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private const float HPLHBBDFGNA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public Vector3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public Quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public float DILGPPEHCGK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 PIGEMEEFMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x826DB40", Offset = "0x826C540", VA = "0x18826DB40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS CEKANDAGIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x826DC50", Offset = "0x826C650", VA = "0x18826DC50")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1605B60", Offset = "0x1604560", VA = "0x181605B60")]
	public BDDDGNMMBLL(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DILGPPEHCGK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x826E1B0", Offset = "0x826CBB0", VA = "0x18826E1B0")]
	public BDDDGNMMBLL(UniformTRS NGKIOKMKCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x826DEA0", Offset = "0x826C8A0", VA = "0x18826DEA0")]
	public static BDDDGNMMBLL OMMHDOBLNJE(BDDDGNMMBLL DFKFFPKHNCH, BDDDGNMMBLL HBOAHIHPDGA)
	{
		return default(BDDDGNMMBLL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x826DDF0", Offset = "0x826C7F0", VA = "0x18826DDF0")]
	public static BDDDGNMMBLL LHJBCIIELME((Vector3, Quaternion, float) GPCDCFCPGFK)
	{
		return default(BDDDGNMMBLL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x826DC90", Offset = "0x826C690", VA = "0x18826DC90")]
	public static BDDDGNMMBLL LHJBCIIELME(Matrix4x4 PKIHAENIBJG)
	{
		return default(BDDDGNMMBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x826E120", Offset = "0x826CB20", VA = "0x18826E120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x826D920", Offset = "0x826C320", VA = "0x18826D920")]
	public BDDDGNMMBLL GBFKNJFLGGJ(Matrix4x4 EOBBLENOIHL)
	{
		return default(BDDDGNMMBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x826D8B0", Offset = "0x826C2B0", VA = "0x18826D8B0")]
	public static BDDDGNMMBLL FFOPPGJKGOI(Vector3 DDIHIBMHCDH)
	{
		return default(BDDDGNMMBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x826DE10", Offset = "0x826C810", VA = "0x18826DE10")]
	public readonly CIKGBHIALIN LPMNNIHKBEP()
	{
		return default(CIKGBHIALIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CGOFGCABFCG
{
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MMMLIOHNNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly AHDBDCIIAOL IMJCDFANLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly NHMKHEEENDM EFHDKJIFOIJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1900540", Offset = "0x18FEF40", VA = "0x181900540")]
	private MMMLIOHNNDJ(AHDBDCIIAOL DOFFGKPAKJD, NHMKHEEENDM ANMODPEFEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x827C6B0", Offset = "0x827B0B0", VA = "0x18827C6B0")]
	public IKKKABPKJNO BNDHMDEIKFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x827C890", Offset = "0x827B290", VA = "0x18827C890")]
	public static DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ> MDDJOGPLAFO(AMOFKAFEDJG<FAIGCFGAAKD> ANMODPEFEAK)
	{
		return default(DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x827C7E0", Offset = "0x827B1E0", VA = "0x18827C7E0")]
	public static DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ> MDDJOGPLAFO(IKKKABPKJNO ANMODPEFEAK)
	{
		return default(DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x827C720", Offset = "0x827B120", VA = "0x18827C720")]
	public static DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ> MDDJOGPLAFO(string KJHALCAMGFK)
	{
		return default(DOHEMIFBILP<EPNCHHHPNKA, MMMLIOHNNDJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum AHDBDCIIAOL
{
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JNNBILHGBFG : IDisposable, NPPEEAEEPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private NativeList<PKFMPNIDAMO> ABLACBGFIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private float NFGLADMONFN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EMGMCNDGCFG HBLIEDAFGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180")]
		[CompilerGenerated]
		get
		{
			return default(EMGMCNDGCFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DBPDEMNOFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x712F670", Offset = "0x712E070", VA = "0x18712F670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DLIMDCKBPPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x712F680", Offset = "0x712E080", VA = "0x18712F680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<JBOPDGPGIEI> HDDAOCMFNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PCOGDDNMMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8279220", Offset = "0x8277C20", VA = "0x188279220", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float KNKEAHBKDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x827AA10", Offset = "0x8279410", VA = "0x18827AA10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x827B970", Offset = "0x827A370", VA = "0x18827B970")]
	public JNNBILHGBFG(EMGMCNDGCFG DHGLMDLACKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x827A550", Offset = "0x8278F50", VA = "0x18827A550", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x827B1A0", Offset = "0x8279BA0", VA = "0x18827B1A0")]
	public Vector3 MPOIHFFLGEC(int LLLLOEKJOOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x827A8E0", Offset = "0x82792E0", VA = "0x18827A8E0", Slot = "6")]
	public Quaternion JAOPFKGCNEP(int LLLLOEKJOOH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x827A4B0", Offset = "0x8278EB0", VA = "0x18827A4B0", Slot = "5")]
	public Vector3 CMMHCDKECFH(int LLLLOEKJOOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82791C0", Offset = "0x8277BC0", VA = "0x1882791C0", Slot = "7")]
	public float ACJJEHIJEFG(int LLLLOEKJOOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8279BD0", Offset = "0x82785D0", VA = "0x188279BD0")]
	public void CJFOGMDDDJD(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DLJDKOFPIMN, bool LCAIEIKMMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x827B910", Offset = "0x827A310", VA = "0x18827B910")]
	private bool PDHEPGLHJKL(int JNHOONCEMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8279260", Offset = "0x8277C60", VA = "0x188279260")]
	public void APAOOGJNJFM(Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x827A5B0", Offset = "0x8278FB0", VA = "0x18827A5B0")]
	public void GEKFBGLAAGO(int JNHOONCEMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x827A790", Offset = "0x8279190", VA = "0x18827A790")]
	public void IECMJOPPAKE(int JNHOONCEMJE, Vector3 DDIHIBMHCDH, Quaternion JCDLBIBEGAF, float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x827AFF0", Offset = "0x82799F0", VA = "0x18827AFF0")]
	public void MLIIFHPIBOH(int JNHOONCEMJE, float3 DDIHIBMHCDH, quaternion JCDLBIBEGAF, float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x827A640", Offset = "0x8279040", VA = "0x18827A640")]
	public void GGBLBIIOBNL(int JNHOONCEMJE, Vector3 DDIHIBMHCDH, float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x827B670", Offset = "0x827A070", VA = "0x18827B670")]
	public void NMONIGCCKCO(int JNHOONCEMJE, Vector3 HKIFHFOHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82793C0", Offset = "0x8277DC0", VA = "0x1882793C0")]
	public static Quaternion CDMIBPKOKOB(Quaternion FDGBFBGBCCA, int JNHOONCEMJE, float NEFHNEDGNPM, NPPEEAEEPAM GACDMLEAKAP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x827AB50", Offset = "0x8279550", VA = "0x18827AB50")]
	public Bounds MAIJJPDDGNH(Transform EOBBLENOIHL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x827B8A0", Offset = "0x827A2A0", VA = "0x18827B8A0", Slot = "10")]
	public virtual void OHFIBAMNDFN(bool ABGOBLJCCKH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x827B7D0", Offset = "0x827A1D0", VA = "0x18827B7D0")]
	public NativeList<PKFMPNIDAMO> OFONLMFMIJH(float PEABKKKPEDJ = 1f)
	{
		return default(NativeList<PKFMPNIDAMO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JBOPDGPGIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public float3 FLMJNMGJKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public float JPIOKNBMLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public quaternion FGOLIENBCGA;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8277F50", Offset = "0x8276950", VA = "0x188277F50")]
	public JBOPDGPGIEI(Vector3 FBHMIIMHGKJ, Quaternion FDGBFBGBCCA, float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8277CF0", Offset = "0x82766F0", VA = "0x188277CF0")]
	public Quaternion NONILMMDMAL(Vector3 PNELABKCNPL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8277A00", Offset = "0x8276400", VA = "0x188277A00")]
	public JBOPDGPGIEI FNIACGJOHCN(Vector3 ODKEMNNOEIP, Vector3 EIOLBJBODCB, Vector3 FMAFHNLDKDG)
	{
		return default(JBOPDGPGIEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8277DB0", Offset = "0x82767B0", VA = "0x188277DB0")]
	public IKIJKGLHHPH PMEOOGMBDCB(Vector3 PNELABKCNPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class ENMGJJKOIBB : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x826EA50", Offset = "0x826D450", VA = "0x18826EA50", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x826EB30", Offset = "0x826D530", VA = "0x18826EB30")]
	private void KFKOLHKIKCN(Dictionary<Guid, Guid> EKIBDPICCKP, LJNGKPFHNKJ ODFOELECINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x826EAD0", Offset = "0x826D4D0", VA = "0x18826EAD0")]
	private void KFKOLHKIKCN(Dictionary<Guid, Guid> EKIBDPICCKP, DJLHCMLLBHH OCNGLDKCGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x826F100", Offset = "0x826DB00", VA = "0x18826F100")]
	private void KFKOLHKIKCN(Dictionary<Guid, Guid> EKIBDPICCKP, KNHCIJDHGFF NNKMDBGHJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public ENMGJJKOIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class GENCABFCFNB : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x826F6E0", Offset = "0x826E0E0", VA = "0x18826F6E0", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GENCABFCFNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EMHNCAADCAK : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x826E8F0", Offset = "0x826D2F0", VA = "0x18826E8F0", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EMHNCAADCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HDNBHJJOLND : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8276DC0", Offset = "0x82757C0", VA = "0x188276DC0", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HDNBHJJOLND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BOBGLNFEIOK : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x826E280", Offset = "0x826CC80", VA = "0x18826E280", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BOBGLNFEIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LGMNDILJIKE : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x827BF90", Offset = "0x827A990", VA = "0x18827BF90", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LGMNDILJIKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FIJHCOHEHMG : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x826F380", Offset = "0x826DD80", VA = "0x18826F380", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FIJHCOHEHMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class NKJJIHICBPN : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x827C940", Offset = "0x827B340", VA = "0x18827C940", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public NKJJIHICBPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IHAFFHCLPMG : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8276F20", Offset = "0x8275920", VA = "0x188276F20", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IHAFFHCLPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FJJIMEGDGLA : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x826F520", Offset = "0x826DF20", VA = "0x18826F520", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FJJIMEGDGLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class LMHGKJAEMJJ : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x827C0D0", Offset = "0x827AAD0", VA = "0x18827C0D0", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LMHGKJAEMJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class PCDOFBJCBDP : JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public static readonly MPHKADCDFOA IFKKKJCDGCO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x827DB50", Offset = "0x827C550", VA = "0x18827DB50", Slot = "4")]
	public void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PCDOFBJCBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PHIPOPCCIBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public BKLAHIHKKHK OHBCMIBMOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public JBNEINGIMJO OAMDNOCPKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public Dictionary<int, int> NAOPBMFKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public Dictionary<Guid, Guid> CBOGKFFGICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public DOBLDCEJMDE IFJKJJPNGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public bool AOABIFNBEPN;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface JJDAHAPJJMG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIODMOPFFFL(DAIFELKFLNM FJCNBMKJGJB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class ONJEEJEBFFO
{
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private static readonly JJDAHAPJJMG[] OLBLHOCIFHM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x827CA30", Offset = "0x827B430", VA = "0x18827CA30")]
	public static void KAHILOGDKNP(BHOPKDGDEFN GPCDCFCPGFK, EPNCHHHPNKA GJNEMNCHHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x827D080", Offset = "0x827BA80", VA = "0x18827D080")]
	public static void MOKBCENLNDG(BHOPKDGDEFN? GPCDCFCPGFK, EPNCHHHPNKA PCOGPOPGBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x827D310", Offset = "0x827BD10", VA = "0x18827D310")]
	public static void OBFBDLMHAFF(BHOPKDGDEFN? GPCDCFCPGFK, EPNCHHHPNKA LJKIMKGBIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x827CCB0", Offset = "0x827B6B0", VA = "0x18827CCB0")]
	public static void LCOLJIBPOKM(DAIFELKFLNM FJCNBMKJGJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DAIFELKFLNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public BKLAHIHKKHK BEIHJEJNGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public BHOPKDGDEFN HGCHPOBFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public Dictionary<int, int> NAOPBMFKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	public Dictionary<Guid, Guid> CBOGKFFGICH;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x826E840", Offset = "0x826D240", VA = "0x18826E840")]
	public Guid HGJEBHOIHGP(Guid DNLDANFOOJK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DOBLDCEJMDE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int ELLEHGDJHCE, [Out] Guid NJDGBKALFKN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GFIFJMJJLFA
{
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private static readonly HashSet<Guid> PHGAAPBBEAA;

	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private static readonly ProfilerMarker NBEAEDOKEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private readonly HashSet<string> AJEBGDGLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private readonly Dictionary<long, int> HDAKJGJEKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private readonly HashSet<Guid> HNKGDPJCJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private readonly HashSet<Guid> DHIEDEFJNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private readonly HashSet<Guid> DEOJLMJCNPF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> OLFAHAFLAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> FHLCICPAOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> EAOGBBBHJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> GGJHDIAMCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x82708A0", Offset = "0x826F2A0", VA = "0x1882708A0")]
	public static void KHDEMBICHCA(FNNMMEDNKCL ICODCJBGLNO, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x826FF70", Offset = "0x826E970", VA = "0x18826FF70")]
	public static GFIFJMJJLFA GJLBMOEHFOI(AJDHPEOBCFP OBPEHAFILEK, CALKCIIEGGI? FLJOCHBNMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x826FA70", Offset = "0x826E470", VA = "0x18826FA70")]
	public static GFIFJMJJLFA BEPDHKFDDOI(FNNMMEDNKCL LGKNNBLNEIA, CALKCIIEGGI? FLJOCHBNMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x826FAF0", Offset = "0x826E4F0", VA = "0x18826FAF0")]
	public static GFIFJMJJLFA BNKKOCLPNKI(BFKMPHBNLPN IAFDPFAOMOP, AHHPIHIILDM JGINDINMFKO, CALKCIIEGGI? FLJOCHBNMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8271B30", Offset = "0x8270530", VA = "0x188271B30")]
	public static GFIFJMJJLFA LEANMCCGIIO(IEnumerable<string> AJEBGDGLMHD, IReadOnlyDictionary<long, int> EAFDDIENMEO, IReadOnlyCollection<Guid> DEOJLMJCNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8273510", Offset = "0x8271F10", VA = "0x188273510")]
	private GFIFJMJJLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x82736A0", Offset = "0x82720A0", VA = "0x1882736A0")]
	private GFIFJMJJLFA(IEnumerable<string> AJEBGDGLMHD, IReadOnlyDictionary<long, int> EAFDDIENMEO, IReadOnlyCollection<Guid> DEOJLMJCNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8272390", Offset = "0x8270D90", VA = "0x188272390")]
	private void LNKFGPEKOJC(AJDHPEOBCFP OBPEHAFILEK, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8271FC0", Offset = "0x82709C0", VA = "0x188271FC0")]
	private void LNKFGPEKOJC(FNNMMEDNKCL LGKNNBLNEIA, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8272D30", Offset = "0x8271730", VA = "0x188272D30")]
	private void NJBAFDFPLPG(ByteString? KGGIDIKOJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82729D0", Offset = "0x82713D0", VA = "0x1882729D0")]
	private void LNKFGPEKOJC(BFKMPHBNLPN? PJFDNMGHMBL, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8272950", Offset = "0x8271350", VA = "0x188272950")]
	private void LNKFGPEKOJC(AHHPIHIILDM? JGINDINMFKO, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8272250", Offset = "0x8270C50", VA = "0x188272250")]
	private void LNKFGPEKOJC(BKOBHMHJBNI? ALABKGFJDGA, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x826FBB0", Offset = "0x826E5B0", VA = "0x18826FBB0")]
	private static bool FKMALFCKHFI(BKOBHMHJBNI ALABKGFJDGA, int MCNGGPGCEHO, [Out] Guid CKMHAEOIIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8270380", Offset = "0x826ED80", VA = "0x188270380")]
	private static void KHDEMBICHCA(AHHPIHIILDM? PJFDNMGHMBL, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82718F0", Offset = "0x82702F0", VA = "0x1882718F0")]
	private static void KHDEMBICHCA(BKOBHMHJBNI? ALABKGFJDGA, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x826FFF0", Offset = "0x826E9F0", VA = "0x18826FFF0")]
	private static void KHDEMBICHCA(BFKMPHBNLPN? PJFDNMGHMBL, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82712A0", Offset = "0x826FCA0", VA = "0x1882712A0")]
	private static void KHDEMBICHCA(DHHACOKGGCA? AAPGFEFGBOK, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8272630", Offset = "0x8271030", VA = "0x188272630")]
	private void LNKFGPEKOJC(DHHACOKGGCA? AAPGFEFGBOK, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x826F860", Offset = "0x826E260", VA = "0x18826F860")]
	private void AMKGIJKMCKN(Guid? DNLDANFOOJK, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8271BC0", Offset = "0x82705C0", VA = "0x188271BC0")]
	private void LNKFGPEKOJC(BHOPKDGDEFN? HGCHPOBFDBI, CALKCIIEGGI? FLJOCHBNMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8270450", Offset = "0x826EE50", VA = "0x188270450")]
	private static void KHDEMBICHCA(BHOPKDGDEFN? HGCHPOBFDBI, CALKCIIEGGI FLJOCHBNMHH, EPNCHHHPNKA DANHHHOPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8273320", Offset = "0x8271D20", VA = "0x188273320")]
	private void PGFLKKFDBGL(string? FALHOMCFDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x826FE40", Offset = "0x826E840", VA = "0x18826FE40")]
	private void GFIGMCNHABF(long AADBLGJCAAH, Guid BBFCPIAJNKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x826FDF0", Offset = "0x826E7F0", VA = "0x18826FDF0")]
	private void GFIGMCNHABF(LAMJKJKAKMH? HNMLOJDPNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x826FF10", Offset = "0x826E910", VA = "0x18826FF10")]
	private void GFIGMCNHABF(GKHOMAPGKAM? HNMLOJDPNHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct JHMGKLOCPMG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class KKIIKDGJCMD : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private readonly IEnumerator<DictionaryEntry> MEKDEFIHOEE;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry EIKCCBCGPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x827BB80", Offset = "0x827A580", VA = "0x18827BB80", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object OFFMBGPIJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x827BC50", Offset = "0x827A650", VA = "0x18827BC50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object BHKLFFIKDPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x827BD00", Offset = "0x827A700", VA = "0x18827BD00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x827BAA0", Offset = "0x827A4A0", VA = "0x18827BAA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
		public KKIIKDGJCMD(IEnumerator<DictionaryEntry> MEKDEFIHOEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x827BA00", Offset = "0x827A400", VA = "0x18827BA00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x827BA50", Offset = "0x827A450", VA = "0x18827BA50", Slot = "9")]
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
		private sealed class PEMCENHMIFH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x827DDD0", Offset = "0x827C7D0", VA = "0x18827DDD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public PEMCENHMIFH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x827DC80", Offset = "0x827C680", VA = "0x18827DC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x827DD80", Offset = "0x827C780", VA = "0x18827DD80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x827E3F0", Offset = "0x827CDF0", VA = "0x18827E3F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object LNBCHJPEENA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x827E300", Offset = "0x827CD00", VA = "0x18827E300", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x827E4E0", Offset = "0x827CEE0", VA = "0x18827E4E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x827E240", Offset = "0x827CC40", VA = "0x18827E240", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x827E2A0", Offset = "0x827CCA0", VA = "0x18827E2A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x827E480", Offset = "0x827CE80", VA = "0x18827E480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x827DF00", Offset = "0x827C900", VA = "0x18827DF00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x827DF60", Offset = "0x827C960", VA = "0x18827DF60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x827DFC0", Offset = "0x827C9C0", VA = "0x18827DFC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
		public RoomObjectCounts(Dictionary<int, int> KHDLGHIOOGD, [Optional] Dictionary<int, int> AKBIFHLPONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x827DE20", Offset = "0x827C820", VA = "0x18827DE20")]
		[IteratorStateMachine(typeof(PEMCENHMIFH))]
		private IEnumerator<DictionaryEntry> KBIICLGFGPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x827E530", Offset = "0x827CF30", VA = "0x18827E530", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x827E140", Offset = "0x827CB40", VA = "0x18827E140", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x827E020", Offset = "0x827CA20", VA = "0x18827E020", Slot = "9")]
		void IDictionary.Add(object LNBCHJPEENA, object PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x827E080", Offset = "0x827CA80", VA = "0x18827E080", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x827E0E0", Offset = "0x827CAE0", VA = "0x18827E0E0", Slot = "8")]
		bool IDictionary.Contains(object LNBCHJPEENA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x827E1E0", Offset = "0x827CBE0", VA = "0x18827E1E0", Slot = "14")]
		void IDictionary.Remove(object LNBCHJPEENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x827DEA0", Offset = "0x827C8A0", VA = "0x18827DEA0", Slot = "15")]
		void ICollection.CopyTo(Array JCEJMKLBKKB, int FILGHJLFKAL)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class LFFPLBKKAKO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x827BF40", Offset = "0x827A940", VA = "0x18827BF40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public LFFPLBKKAKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x827BDB0", Offset = "0x827A7B0", VA = "0x18827BDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x827BEF0", Offset = "0x827A8F0", VA = "0x18827BEF0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8277720", Offset = "0x8276120", VA = "0x188277720", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object LNBCHJPEENA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x82775F0", Offset = "0x8275FF0", VA = "0x1882775F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x82777D0", Offset = "0x82761D0", VA = "0x1882777D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8277530", Offset = "0x8275F30", VA = "0x188277530", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8277590", Offset = "0x8275F90", VA = "0x188277590", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8277770", Offset = "0x8276170", VA = "0x188277770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x82771B0", Offset = "0x8275BB0", VA = "0x1882771B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8277210", Offset = "0x8275C10", VA = "0x188277210", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8277270", Offset = "0x8275C70", VA = "0x188277270", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4EED0", Offset = "0x2A4D8D0", VA = "0x182A4EED0")]
		public Invention(long EGJGKBPPPFG, int CDCPIGCEABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82770E0", Offset = "0x8275AE0", VA = "0x1882770E0")]
		[IteratorStateMachine(typeof(LFFPLBKKAKO))]
		private IEnumerator<DictionaryEntry> KBIICLGFGPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8277820", Offset = "0x8276220", VA = "0x188277820", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82773F0", Offset = "0x8275DF0", VA = "0x1882773F0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x82772D0", Offset = "0x8275CD0", VA = "0x1882772D0", Slot = "9")]
		void IDictionary.Add(object LNBCHJPEENA, object PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8277330", Offset = "0x8275D30", VA = "0x188277330", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8277390", Offset = "0x8275D90", VA = "0x188277390", Slot = "8")]
		bool IDictionary.Contains(object LNBCHJPEENA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x82774D0", Offset = "0x8275ED0", VA = "0x1882774D0", Slot = "14")]
		void IDictionary.Remove(object LNBCHJPEENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8277150", Offset = "0x8275B50", VA = "0x188277150", Slot = "15")]
		void ICollection.CopyTo(Array JCEJMKLBKKB, int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000576")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> NOPAFHIEEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000577")]
	public readonly IReadOnlyList<Invention> GOCBECOPDEC;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	public JHMGKLOCPMG(IReadOnlyDictionary<Guid, RoomObjectCounts> AHINPNLBAMH, IReadOnlyList<Invention> GEKBOMOCNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8277FD0", Offset = "0x82769D0", VA = "0x188277FD0")]
	public static JHMGKLOCPMG GJLBMOEHFOI(AJDHPEOBCFP OBPEHAFILEK)
	{
		return default(JHMGKLOCPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82789E0", Offset = "0x82773E0", VA = "0x1882789E0")]
	[CompilerGenerated]
	internal static int GNCKOGJFLCF([In] IReadOnlyDictionary<long, int> GMMNGMILJAN, long? AADBLGJCAAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8278B00", Offset = "0x8277500", VA = "0x188278B00")]
	[CompilerGenerated]
	internal static void JNODBKLCBMB(int CLPOIEFPJNP, [In] BFKMPHBNLPN CMMGJNLDMOF, [In] Dictionary<long, int> GMMNGMILJAN, [In] Dictionary<Guid, RoomObjectCounts> AHINPNLBAMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LDHMONEBJMO
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
public sealed class CALKCIIEGGI
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class ACJIHPDFGNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public readonly Guid IAGHKHMHFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public readonly IReadOnlyList<Guid> FHLCICPAOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public readonly LDHMONEBJMO IMJCDFANLAI;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x826D850", Offset = "0x826C250", VA = "0x18826D850")]
		public ACJIHPDFGNN(Guid IDCJGBECDDM, IReadOnlyList<Guid> DEOJLMJCNPF, LDHMONEBJMO DOFFGKPAKJD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400058F")]
	private readonly EPNCHHHPNKA BIJMIJEMNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000590")]
	private readonly Dictionary<Guid, ACJIHPDFGNN> CLIBOMNCEDJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public EPNCHHHPNKA NHJKBGIIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x826E590", Offset = "0x826CF90", VA = "0x18826E590")]
	public void MJGPLOFFIKO(Guid CDHNGCLEMBN, Guid LOHALIPAPJH, IReadOnlyList<Guid> NEDLKCDPGOC, LDHMONEBJMO DOFFGKPAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x826E4A0", Offset = "0x826CEA0", VA = "0x18826E4A0")]
	public bool CAMANMLMOCP(Guid IFFEALHBDLO, [Out] ACJIHPDFGNN LMDHIJDNLMO, [Out] bool CEDKADCJFEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x826E7A0", Offset = "0x826D1A0", VA = "0x18826E7A0")]
	public CALKCIIEGGI()
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
