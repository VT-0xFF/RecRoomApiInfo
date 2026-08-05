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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE130", Offset = "0x7CBCB30", VA = "0x187CBE130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AMCJIMJHMKD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PBMPCFKDLFA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JEMOIDMJIAF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> MIOBHBADHGN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LEKNMOJDMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NPLICBPGNEC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string MDBCINOIAEC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string DDOLPEOHJBA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB2F0", Offset = "0x7CA9CF0", VA = "0x187CAB2F0")]
	public static bool EJIDLGAKGHK(Guid KLJDBJBDNCN, int KGNNJEAEBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB3F0", Offset = "0x7CA9DF0", VA = "0x187CAB3F0")]
	public static bool KEOOIMKIPEO(Guid KLJDBJBDNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7CAB480", Offset = "0x7CA9E80", VA = "0x187CAB480")]
	public static string PBODODDEPML(Guid FNKCCICOAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OJFLIIHNHDJ]
public enum OGMGBICEEJJ
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
	GAME_AI,
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
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDFF0", Offset = "0x7CBC9F0", VA = "0x187CBDFF0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CLOEFNONIED
{
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid FBFBMNHIGAA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid AIDDGHBKLOA;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BHGBHEOMNDM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid ONBPOEADFEN;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid IGMEEEDGMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AMNKBINGPGD;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid MLCOBIEIDIO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NCIOGFHCBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid PAGEILDPBFI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LLAOGOHKANB;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid BEGIPNOIJFM;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HMPGKGLCAEL;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid HBMPFMMPAJI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid JKKEKEGLDKN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid JLCPJMJOCGO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid CAEHAPGINOP;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid GGDOHNCFAGN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PNABJIGKGHK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CGOMKLOEDKA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JMKJCBAJLPH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IMNNKJJJELN;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid EFOACICILDG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid PKOLBDHHEHK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid LHMLIOCPLEO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid EBHGOJEKCFH;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid LPKAENBNNGN;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid APLNACLAIMA;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HPLJHDDEGKJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid DMKJJLGIBAJ;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid ELBNKDPEPDD;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid FKHMONANIGC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CFKIOOIJFAL;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid PMIILLAINGH;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PANEJMFEDFJ;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid ONKCFPAALKI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid BJJFBBKBIPI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid FGDOCBOCACN;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OLKBPBBMDPO;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BMHAFAEHNAB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid MFDBCGHFABO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid LPPMEKACJJP;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JPLMENHICJM;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid BHDNLCFHDIP;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid GMGKGANIMOL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid GPCBCJNCFLO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid KPGMPCACIAO;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid OJJKDODMHEO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid FDMBCNPDPKF;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JOBCHIGGOGB;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JEILKOACDNM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DJDOOHHJNPG;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid MBFFGGLLNMC;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LCLILJNJBHA;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MOGLDIGCKKN;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid ELLDOGDFJPO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid EIHPOMLEPEH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LHEHNJGKNHD;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PCFLBNKHDNF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PKLNHPFHJND;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid AJKHKAKCPPI;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid AIHNHIABEOO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid FIFLECGOINF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid PBMLDBMDLNC;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MGGICPOIEKN;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BLCDNIHDGLG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KAJBABCCPAI;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JMCKFANABJH;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FFGKGFOEIIH;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid CCNBMLNGJMC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid EADEAOPPJIB;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid ACJFBKEOELF;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NBNGGLCGDHD;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid KAMACBJDOJB;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid LCONKGNIILI;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid IBOPKIMPNLK;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JCIPLKGELML;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid HEOGAALBCOB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid OLFKGMOEAEJ;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid KADAJKCOMEJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KIEDNGDBLBA;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid FPLEHKGHKKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid LAAMDKHNOIO;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid GLKNMGLDEAB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NCEFFLAIPEO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MEDJOJCMECE;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KBNEOJPCACE;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OLJDGOLNCAO;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CLCIGLJLACA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NANOPCHIFMG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid CNHPELOMEEB;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid COKKKOGJJJE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid BCIHMFODJCM;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid BNOIPBIHELH;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid AOHHNJILKOB;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid MJBGPBDBDOP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JBJINMLHINE;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HPJKDLEHCCB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LILMJIDHKPM;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid CNENHILOKCK;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NOAGCEICAJI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid IDIMLLKHCFN;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid LCMHAOOLNKO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid BOPFPGFHKMG;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LOJMAFNKNBA;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid AHBDHICPKIK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LMFJHCGIFIL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DLABGANHMBK;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GKNOEAEDEGI;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid GHFPIDEEONP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid KMLFIGPMMED;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EFIDDLPPGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid JJIGAIDBPKC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OKNIJONDFNP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GCFPBJBMIGC;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DFOKJLDBKIC;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid DBHCNKKDCPD;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JNDNJLPGNDG;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid LNCHMKJIBIH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid DPAIAMGPJDI;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid EFIJEKIKEOD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GGFFJBODNNG;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid POCENMHBEJC;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HOMLBDIAGEN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NBJOPKPOLCO;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid EELDBGEJPBB;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NPIKMLKEBCC;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CJBLKNBNEIC;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid GKKNGLCPFPE;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid BCOBCCOCIOL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BPHIAGKFHGM;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FPJNKNFJKJP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid PMPFFJMCMKO;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EENMHLLMEMI;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KPKJFCCDDKL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid OEGCDCKIDFG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NAIOGILEBKC;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid LMAHKHDKEJM;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid GLDCCMJPNHH;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid GNOLGJIOHNG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LEHGHJLCIGN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid FMGAPLNFBID;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid BOJKMIINEJP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid JADBNNHCKHK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid IFGEBHOIIPN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BAKHFPPHGCL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid DDNNFMCPIBA;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid AFKEDLEFMDA;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MCOOKJHGBJN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid PNOABANEBCK;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DIIPBEEFMLC;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid CMOPNJCJNGP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid PPGFEIFGIMB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LCGJEACEKKN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid BGICADJKJFF;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NFDNFEGBEPN;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DDNEJBFAJOC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid HMGNLMPMIHC;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DBADBHIJKEC;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid IEMANMLIMLI;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid HFJIKKJIIAG;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BEDMHEPMLNF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KAPAPLABCNM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DOGAILAIIFA;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid PHJNPDLDFGI;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid CHHPGAOIFGD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LPCEPLPCAOB;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EFAFHJMJCPI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid OGALDHIGEMO;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OGIDEJFOGNO;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid IIMABDJPBGG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid JGEKIABHKNO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid AOCLOKNEDOD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GCBCBJMNPHD;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid ICMBJNJFOKI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid DLJHPAKCKFM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid AGJGFJHLHEM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid IAPKJKNNBMM;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid ABLHFKMJMNF;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MCGJBLNAMEC;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid EGFMILJHEFN;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CPBKNPFDBFI;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MJHILEPCCNK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid CKEFOOGFKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid MBJMKMOJAPN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FDIEJKELBNH;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid MBMBLFKOPJP;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AMFOPEBGONJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid BLINEIBOLJL;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid NNDGAFFKNCM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EAIPAIAIEBI;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid OAKLEBMBOOE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LGEINOLFFMG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid OMGGPFNACHH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid INKGHEOENJA;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid ALELBFJMHPC;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PLFOEEICKGC;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid IKJLOFMMDOA;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CFHBKAGMBAA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid HLIBNIDLMAH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KLAFDALEFPI;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GHIMEFBOKKM;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid CGPALCMJOEL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid LJBNHGPJNJA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid LMMOHINAFJI;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MNBAOPGCDMN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LPIHDBOIJJJ;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ILKJDKLAMFI;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid NGIGCLCKBMG;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PHNLNCGFPJF;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid LMKOEOBLMIE;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DECPOJNAPNG;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid DAHLGIPAFOG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid KDONIAHODLH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid GEMJNLNOAJA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid KIALLNNMEFP;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid OEDOCNFNNMG;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid BPHCCMEPBIF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid JCOLKHBAEKA;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid AKPFEAFDNMD;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid FEEKJDAPEBM;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid NOCCMNFIHHJ;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid KIHKNFHLAMF;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid EMIBMJKGNGK;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid CMMPOICNEOB;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid CKBFMIDDICI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid OCCONOONFBH;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid KLHEPNFLIDP;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IBCFADKEAJP;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NMHNCKBCNKA;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid NHEGFAOJFJC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid JOLOEICKGDP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid ANKGCKBKIMP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid EFGGGLFEHAI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid AELOKFEEAFK;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JFBDIBOHMBD;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid IAKBKDNCKCP;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JFKKMICNJOH;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid EMELJEPKFBC;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid DLOMNJEANDM;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid CEPPBFEJDHI;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid MICFELEGPFI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid BOKLDKALIIP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid PNDPMIKJFDN;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid KOKMGBFGPIO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PGJKOFACGPI;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid IHLPGBJEDKL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid PCPJPODNEKF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid CDPCCGOKMJP;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid PLCJDCGNCJP;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NMNIMBGBJBF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid FEFOMCDFKAG;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid ENDKKHPFCBK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DLPKHBOLMGN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BGKHOILEIIA;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FKMOPEANLIG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GEBDKEFGPBN;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid AHFBGPEPBFE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid IPNDIDMBKLP;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid IPOPLGDJKBG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid EPCNGAEBCIC;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CAMEODFDCOH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AGCOOKIJJNM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid CPHPEKGLMDM;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid MEHOBOBHCOM;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid NBPNKGBOAKE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid AAHCKAFCAOE;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid DJFDEOAOMEI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid KNNCGECNCAJ;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid OCCKCMKGEPN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CMEDENEJHBC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid CJOHMEOPIPG;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid KMMCMFGKLMB;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HGECEBBFHFB;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid HBMICAGGJBB;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid CHCFCOIOFMJ;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NKIIAAFPKIK;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid KIDFMDFAPGD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid BAOPMJMGHDE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid IBELGDOKIFM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid PLFIJHGDPNE;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid MDILGFDLIJL;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NGCJGJEGFGF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JJLCABGFLLO;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JINFBPMHEFJ;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EJOCPDPMJJN;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid PBJKOMFFEFG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid HHNKKKMPMPM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AJNGJHGEANK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MKPNOJGCBDJ;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid MLBKJJCBHFI;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid DLCLIPHMNPO;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid KNKKABHAGBP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid GFBOJNMLFNM;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CHOCLLMDBMP;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid AOKLCEGHJKK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LGIJICIIKCC;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid MCMKONINIJO;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MGIKHMBOGLH;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid EDKAEIHLHLN;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid KOFOADLLMCD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid KHLLFMKALPD;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MGHAHCIMNPA;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid KMCJPPLIHIK;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid CAFABKMECBE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KILLFAHFFGG;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid HFAIFONMHGO;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid CPMDGHDIHPK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid MOLKJDCDCGM;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FCFHONBMNNO;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GGPNLFLCIJD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BJCOJMNLHLA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid DJOMGLJJODD;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid IMKNEBKMFCP;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid NKCBFADCIHF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid FDMJDBMALGC;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid JMDHAPAKBLC;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid DBOIBBKICGG;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CGBFCHIBMOJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid PJDJBEGGMIM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LMKNMBNKLME;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LCMPJMJFKEF;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid LKENOEKCFAH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NLDOEDGPCCB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid IAJKLHDFNDJ;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid PBOLFFNHELO;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OIEHGAKHFDE;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid DBNCONFOIOG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid GPCAJKNEENC;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid OIOAGBPGBHJ;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid KJNBLKBEDIH;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid OKLIMLHLJPI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid NLFPHICGFAA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DDMOFOKDGIF;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid DIJLGLEKPHF;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid JDFLNPLJDNG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid OPPNLAHGCAO;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NGOEHDPOHGM;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid HAEFPDFEEMJ;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid FLHEGLINEKH;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DBCLGPGGOMA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LKPGMJDBHLB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid JHEMEPDEFNG;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid MKBGAOMNPNO;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid OJACPHLCKFO;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BHBKPAFCBAD;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid KJACBHNKIIB;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid DGNPOFEPDEP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid LDLADEDGOMM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid PKIJADOAKAN;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid KHPNKLJPKEJ;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid EJAPBMBLEJD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid MMJOCOLGBIK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid EPDMAFMAHFE;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JCBIDFHMNAC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ACACMPDPNGM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid AJPGBIJOFFG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IFCHMNCEONG;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid FIELPPBJNGG;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid CBNAIACEJJE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CPDDPBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid GGGPGHAIFFF;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid JNCEKKCJECP;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid BFAHPIEFJKB;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JNFCCICLHEO;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid PLDMGHLPLMP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid KMOOHCDNNJN;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HOPEAGOMHPO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid GAFMFBMEMNN;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid LCKDAKKPDGF;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FBNLBOCOBBM;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid EOBFLNLELIB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ACPADBAJCEB;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid OMEJDHHHAHN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid FBPJMCHFCKI;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid BMFMGJJFMBA;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid AMKKODHNJAO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GLPDDIDKNAM;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid PDHBNICINDM;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid NHAEJDKPAPL;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid IBKOCJMLAOC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid GHLHCFNOAMF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid CJCPCADAFGK;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OAPCFOADIEO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CPMCMEOEFDA;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ANFLEMGOJIJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid PJEBHAALLIP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid LGHJLJFINGJ;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid MLDLAHIJGJE;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid HBEMGHOFONI;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid PICCPLCOJMI;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid EFMLJPJGGPO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HEGHAKPMACN;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid HBMOFEOPLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid PBDMKCHJBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid MOLBFOHLKAA;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid CJGHGFLHGMN;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IGCJMACCJHF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid NOIDNHONKFC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid CGBJHGKHFHJ;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JOFAMBANBDC;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PLHMGPOKEOM;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FJEHFONNAAM;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid GFNMPINFKOG;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid OBNPNODKHBD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid IIPNHNFIJGL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KKPIKNNBCNB;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JHMALKDNNCO;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid GFFPCEFBOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid GEELBEOFNIA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid EIKBFMCOBBG;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BCFOLBPHDCL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid DHAENOHCJPF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PELMMEPPFFC;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OEBFGJDELOF;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid NNMHLPMCOND;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid HKCHGOEIMKA;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid JNCIBAHDFJK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JOFHMHMFKCE;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JMDDFHFEJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid OENOCKEJGAH;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid PMONAHJDAAC;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MMFIPECHJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid KOECKLJKCAJ;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid EAJMHFFALNF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid MGMLMCGBAIM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid DIDHNMNGHPH;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid HGAIEPNHMHM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid KPJDLLFKFDE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CJFEMHLCLAP;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GMNOBIJIAAN;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JFHKNIMFICC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid KDLFINJNCCH;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid JBMNBFMEMKM;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DHPBCNHENBI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid GLFADKMMACE;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid PJKNECEGEGK;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid NPEADLNCFAP;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid EICOOONDNFL;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid HCCDJJDGKHH;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid CJCNNEDPNIO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid FLGOHCIHIME;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PEHLCNIIOBM;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MFMKLNKCGED;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid PMPMFJCGGFP;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HKKFCLPCEGE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MLOGIIOBFNP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid BNGBEKKDJCC;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid BOOCHKMKFMK;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OICOLOIJADE;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MDHAFMAKFDA;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid EJOJEMKMLHL;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid MLIIBCHIMFE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid FBEEELJGLPD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid CAMJPJNFPPK;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MIAOONGMEFN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid EOABAMKPCBE;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid AICJDFGOGEC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid EICDHNKDIJM;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid NAJKGJHJAJK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GEMFPCBJJNP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JNFKFKCLJOO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DOKNEMGHBON;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CAAOHLCLIKI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid IOEDLPDDEJI;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MFMNBOJHDLH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NGLIIBAJHAE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid DDILINDKHAP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FCCELNKDECL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MEMJOLMPGGC;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid NBKEEPEBGGH;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid LNADPHPDIPC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HEECBCCKOEP;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OHMONOLKPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid OAELMGCMLIF;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid IMAOLCMPICE;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FNKBLPGNPIB;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PGHNPKCHOAF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid BJPOAOJKOAB;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MMIEGHEFPMP;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid DNIIGFHDAHB;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid MCAMHIDGJIC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid GIEMFBGHOFI;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid IGLEGHNHFGO;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FBKEIPEMFBB;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OAEIOOEAEPO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid EEKELGGCKAB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LGGKLLEGLIN;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IEKCFAOLENC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid CDFOJLJENHH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid AHLBPIEOGPA;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FHJLLKLPDHD;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MCFKPKMEEAN;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PBDMNPJOMIP;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid CLJKLGPGNBJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid CIGGLFACOAJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid OECGBHAPCDC;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid AGHIDKJCKIL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid NPIGIFDEEOJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MPILKGNIMLL;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid EOPLBGJLNEA;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid GJJOAJJABAK;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MFKFOGCGJHM;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid NNOEKMMACFD;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid LDPGBGHGNLC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid HEEJMEEPJPK;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid HCJABMNDLLG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CNEBJKINBPD;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JAAEBDPKPGB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KGFPDPNKHGH;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MEGBDMIDHOO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid CGHLFDEIMGD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid KHFBKELDELL;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NLACLEIBHLC;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EANDOIJPBMP;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid OONPICHNBNO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid GMANJNAJKFE;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid IMCFMLFPGCF;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid IIHBFALKCDI;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid JMBDNKGFDIB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MNELCAFMGEG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid GGKLHLDMOOA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid BIJEFIKKLMM;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid OHDBFOMEAIF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid FPJDLINJBDH;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid GLBNNNPCFHB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid EHAOBKFEGDB;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EMFNIAIIBJM;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid CGMLIEJNCDH;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid NECLFDEKFDA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MAOLEBHBCPG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid KIFPPGAEHCG;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid FABGINGGLGB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid IECLMAOCAHB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid HBGJLOANCJK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid PKNEIDMGEBD;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid ACFKHOBEABL;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid CJDMKJLFJAD;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid FLKIFNLFPKB;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid CBFPAEBMCHH;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid AJIEDBBJNDE;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid FIBIPAJNHLE;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid BIBGMGGEJJM;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PIBKJPMGIIH;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid ALBDODLOFGJ;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid JJDHGFCMJNG;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid MKFKMDLCCIL;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid AINNAFHEJOK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid ELKLLMPMHEH;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid IPEEDEABMJM;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid OLAKJKLEEJG;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid OCNGKLAPGLE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid FADLJBCDNPP;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid MPIFHBLIEHA;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid NEAMLJGDFEH;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid FJKJPKLILML;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid PLIMDPJIDCH;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MIBCDLCLLGH;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid CLDGHOIBLPN;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GPADOMPJLEE;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid IGAPMJFDOJG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid CMDCFOEEFNH;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid IGHAPGGINAJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid DDHGLIAAIKL;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid AOAFJOGNLBH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid BPHCHBCLPNA;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DCHMJEDDOFJ;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid DAPHFCMLCCH;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid EJECNKMGCPE;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid LEGAFPIONFO;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid KAFECBCDJGL;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IIPKPFEGNCF;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid AGKPODOFKLF;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid IFOGBGIJKDB;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid IFGHEJMKJHA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid KHDMOAIJBMA;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid LKACNADELII;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid GCHGEOMHECF;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid IPJINPOMCEO;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid CACCINIOMPG;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid LPPJGCBEIEK;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid JDIMKNMMICH;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GGAEGANKLDH;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid OJMKPEMBCON;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid EEEAHCCGALJ;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OEOKKJACKJA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JFEOIFGLLPJ;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid OCKALPOHHKB;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CHCMNAOGAGJ;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid FLABLFNGFPC;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid IEBHNBBHHEP;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LPOHIMKDBDC;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FBOIDBBILIK;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid HJPKEHIKHML;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid LDKOOOIJECL;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid ELPEIBNNNLK;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid PCNPJPKJJMO;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid JMPAHBLBIFJ;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FCLILKIGIDI;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid AANLJINMELL;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid HMPCNMNFFPI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid HOOBLMPAIHB;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid FAMNGCIEDOO;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid FPPKGPCPEPG;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LEBLKOBKPNP;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid HGICJAOPDJP;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid ACNDMHEIBHC;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid KPGEAGNFKFJ;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid GODAFPMALEP;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid EEGHEOHBECE;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid GMPKCAOHEEF;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid LMHEIPNBGLM;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid NGBNFLDMMAK;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid PFELLFDGEIB;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid OKGNCMGIFJB;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid ANCNJKGOGLB;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid DDCBBKLMNJF;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid NLKGNFBCDFK;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid JNKGBGIALNM;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid ACPBGFECKMP;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid CJBEMMNGKLB;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid KFGDKIDNMOA;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid MCEAKMCMOED;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid IDGHKNFFDMJ;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid CGMNJLNELAN;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid NMMIGHELGOM;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid JGDFHBCHHBD;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid BECLJHBOHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid HOMBJFHIKIL;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid ONNOCGNCEHM;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid OAGNPILABHJ;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid IBMMIMEPFNL;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid AKKJMHEELBD;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid EIOGFNKHDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid LMHBHJIEBDM;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid HJCOPCPBHEC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid BLAHJPKGPBL;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid EKCIHMPEJCL;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid GNEKKFBAPGH;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid PODNPNMCEPN;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid OCCKNLCNJCB;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid ANGLMHOGLBB;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid NDHHBGPNCNC;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid MPBDMAGAJLB;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private static readonly Dictionary<Guid, OGMGBICEEJJ> BIHPKHMLGBK;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly Dictionary<OGMGBICEEJJ, Guid> KBFOLKLHOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OGMGBICEEJJ> EJPPOLGCJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF8B0", Offset = "0x7CAE2B0", VA = "0x187CAF8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OGMGBICEEJJ, Guid> FKLBGNGHFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF900", Offset = "0x7CAE300", VA = "0x187CAF900")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HMGGEOFDILH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJCMCPBFNON(Guid FNKCCICOAII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LMNDHEAKLCG(Guid FNKCCICOAII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class KGHPCPHMJGL : HMGGEOFDILH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CNJJIAEHFHH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public CNJJIAEHFHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF950", Offset = "0x7CAE350", VA = "0x187CAF950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFAB0", Offset = "0x7CAE4B0", VA = "0x187CAFAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFA10", Offset = "0x7CAE410", VA = "0x187CAFA10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7CAFA10", Offset = "0x7CAE410", VA = "0x187CAFA10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HDNAFGKNKFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public KGHPCPHMJGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD280", Offset = "0x7CBBC80", VA = "0x187CBD280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD990", Offset = "0x7CBC390", VA = "0x187CBD990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private Dictionary<string, HashSet<Guid>>? NFINGNIONNL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static IEnumerable<string> DDHLBKDNBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CBDE40", Offset = "0x7CBC840", VA = "0x187CBDE40")]
		[IteratorStateMachine(typeof(CNJJIAEHFHH))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract IReadOnlyCollection<string>? ICOHOEHPMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract bool NIJLKGIGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool EFACLMCGJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> MKNPCKFFFDC(string OJBDIJENLCO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD9F0", Offset = "0x7CBC3F0", VA = "0x187CBD9F0")]
	[AsyncStateMachine(typeof(HDNAFGKNKFP))]
	public Task DKCLDMJDDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x11DFC50", Offset = "0x11DE650", VA = "0x1811DFC50")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDAD0", Offset = "0x7CBC4D0", VA = "0x187CBDAD0", Slot = "4")]
	public bool HJCMCPBFNON(Guid FNKCCICOAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDEA0", Offset = "0x7CBC8A0", VA = "0x187CBDEA0", Slot = "5")]
	public bool LMNDHEAKLCG(Guid FNKCCICOAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CBDD80", Offset = "0x7CBC780", VA = "0x187CBDD80")]
	private bool HKLJFCFGDJI(string KEBHNGLJHHN, Guid FNKCCICOAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected KGHPCPHMJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AKHMKGPAOKE
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAEA0", Offset = "0x7CA98A0", VA = "0x187CAAEA0")]
	public static bool BIIJPNCLINP(PCCGMDMAJIE LGDDAHMAMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CAAED0", Offset = "0x7CA98D0", VA = "0x187CAAED0")]
	private static bool BIIJPNCLINP(INHHIPBBNEG FENDIEDGFFH, PCCGMDMAJIE LGDDAHMAMMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NJCICNADLJP
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CBBNPFNFDII HPGIDELCODH, [Out] Dictionary<int, int> FIEKLBMPBMC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OGEHLNKGNIL NFMFAEBKEHO, AFAGGELKOLL PPJANGMKLBE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DBKGBCPDOKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly DDHFPHCGNKP KIFBMAJAOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly IEnumerable<CEIEJPOFNOJ> IOFAJAFBNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly IReadOnlyList<CEIEJPOFNOJ> FKLLKNFOPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly EHLNDDDNIPO<JIFLPHMJMBF> OJIACADNFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly IReadOnlyList<HMILHODHBAC<FMDMBPGDGPO>> JCPFKEMBEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly JCCNJNLJDCB KMINLIBAKDC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BNMJIKEIFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFB00", Offset = "0x7CAE500", VA = "0x187CAFB00")]
	public DBKGBCPDOKB(DDHFPHCGNKP GLAIAEOPOKE, IEnumerable<CEIEJPOFNOJ> NEPADDKILLB, IReadOnlyList<CEIEJPOFNOJ> OPJCBLFPBGG, EHLNDDDNIPO<JIFLPHMJMBF> NIAFGOHDHED, IReadOnlyList<HMILHODHBAC<FMDMBPGDGPO>> DKBLANCPELB, JCCNJNLJDCB KAAOFLBGIKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct MHCICOFKGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly DDHFPHCGNKP KIFBMAJAOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly IReadOnlyList<CEIEJPOFNOJ> KFJBIADANFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly EHLNDDDNIPO<JIFLPHMJMBF> OJIACADNFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public readonly IReadOnlyList<HMILHODHBAC<FMDMBPGDGPO>> JCPFKEMBEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public readonly ByteString MDCFPFBJEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public readonly JCCNJNLJDCB KMINLIBAKDC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE0C0", Offset = "0x7CBCAC0", VA = "0x187CBE0C0")]
	public MHCICOFKGME(DDHFPHCGNKP GLAIAEOPOKE, EHLNDDDNIPO<JIFLPHMJMBF> NIAFGOHDHED, IReadOnlyList<HMILHODHBAC<FMDMBPGDGPO>> DKBLANCPELB, ByteString EDMANCBPIBF, IReadOnlyList<CEIEJPOFNOJ> CICHKKLPFKD, JCCNJNLJDCB KAAOFLBGIKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CILOKBIOANF : OGNBHGBADFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public readonly Guid KIGCBDGMBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private readonly Dictionary<Guid, Guid> ICFOMKCGHDA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDA050", Offset = "0x4BD8A50", VA = "0x184BDA050")]
	private CILOKBIOANF(Guid ILOOGEJPAOM, Dictionary<Guid, Guid> ICFOMKCGHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF180", Offset = "0x7CADB80", VA = "0x187CAF180")]
	public static CILOKBIOANF FMDOFBCLPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEF80", Offset = "0x7CAD980", VA = "0x187CAEF80")]
	private static Dictionary<Guid, Guid> FJJBMFHMFBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF210", Offset = "0x7CADC10", VA = "0x187CAF210")]
	public static CILOKBIOANF IINFENBDBIN(IReadOnlyDictionary<Guid, Guid> AJHCLHGHINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF5C0", Offset = "0x7CADFC0", VA = "0x187CAF5C0")]
	public static CILOKBIOANF PMDEDLIBJHO(IEnumerable<KeyValuePair<Guid, Guid>> AJHCLHGHINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEF00", Offset = "0x7CAD900", VA = "0x187CAEF00")]
	public Dictionary<Guid, Guid> EICAOPCIBAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
	public Dictionary<Guid, Guid> KLIKNCCBDDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF540", Offset = "0x7CADF40", VA = "0x187CAF540")]
	public void PBDMKLNODMP(Guid AJHCLHGHINB, Guid GMGNNFDOICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF220", Offset = "0x7CADC20", VA = "0x187CAF220")]
	public void IJCFEPFJNKC(IReadOnlyDictionary<Guid, Guid> IGMLPEDOBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF030", Offset = "0x7CADA30", VA = "0x187CAF030")]
	public Guid FMDBIKCPJGL([In] Guid AJHCLHGHINB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF4A0", Offset = "0x7CADEA0", VA = "0x187CAF4A0")]
	public Guid LENIEODPCKJ([In] Guid AJHCLHGHINB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE90", Offset = "0x7CAD890", VA = "0x187CAEE90")]
	public bool APFDCBHHFNG([In] Guid AJHCLHGHINB, [Out] Guid GMGNNFDOICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE90", Offset = "0x7CAD890", VA = "0x187CAEE90", Slot = "4")]
	private bool MNHINBINIDC([In] Guid AJHCLHGHINB, [Out] Guid GMGNNFDOICN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IBBJHDHHDKP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ECHGBJDFNEB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AOIIOPAKMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public DDHFPHCGNKP staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AOIIOPAKMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE440", Offset = "0x7CBCE40", VA = "0x187CBE440")]
		internal EHLNDDDNIPO<HELECHEHDAD> EKGBNCNPIDI((EHLNDDDNIPO<JIFLPHMJMBF> GraphId, EHLNDDDNIPO<FMDMBPGDGPO> NodeId) i)
		{
			return default(EHLNDDDNIPO<HELECHEHDAD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private static readonly MAHLJAIOJIO<HELECHEHDAD, int?> LGPFHIIDOLO;

	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private static readonly long NJNENCHDMOP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFC90", Offset = "0x7CAE690", VA = "0x187CAFC90")]
	public static (long, long) LKNIHFLBGAG(DDHFPHCGNKP GMOHBLHJBOH, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7CB0130", Offset = "0x7CAEB30", VA = "0x187CB0130")]
	public static long PHBEDGCCMJK([In] ReadOnlySpan<EHLNDDDNIPO<HELECHEHDAD>> AFNGOMGLCFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CAFB70", Offset = "0x7CAE570", VA = "0x187CAFB70")]
	private static long GCHGHDLMEOO()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DMAKOPFKENE
{
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public static readonly HashSet<OGMGBICEEJJ> CCOBLFBIHEC;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EAJJIINHBAE
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class ODKOGHCCKKD : IEnumerable<CEIEJPOFNOJ>, IEnumerable, IEnumerator<CEIEJPOFNOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private CEIEJPOFNOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private DNIFFLNPKOK spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public DNIFFLNPKOK <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private BOPBEMJOHNP spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public BOPBEMJOHNP <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private CEIEJPOFNOJ System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public ODKOGHCCKKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD0D0", Offset = "0x7CCBAD0", VA = "0x187CCD0D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD350", Offset = "0x7CCBD50", VA = "0x187CCD350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD1E0", Offset = "0x7CCBBE0", VA = "0x187CCD1E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CEIEJPOFNOJ> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD1E0", Offset = "0x7CCBBE0", VA = "0x187CCD1E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2230", Offset = "0x7CC0C30", VA = "0x187CC2230")]
	public static DNIFFLNPKOK PGDMGJLLDFE([In] MHCICOFKGME AFDMIJCJPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7CC23A0", Offset = "0x7CC0DA0", VA = "0x187CC23A0")]
	public static DNIFFLNPKOK PGDMGJLLDFE([In] DBKGBCPDOKB AFDMIJCJPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7CC10A0", Offset = "0x7CBFAA0", VA = "0x187CC10A0")]
	private static HashSet<HMILHODHBAC<EIIGMMECKPB>> MBMFEJGPHCI(IReadOnlyList<CEIEJPOFNOJ> FHGEBGHKCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1BD0", Offset = "0x7CC05D0", VA = "0x187CC1BD0")]
	private static void OEPOIFHBAMJ(DNIFFLNPKOK HHAMIICKBDJ, [In] DBKGBCPDOKB EDLLOPNBAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFAE0", Offset = "0x7CBE4E0", VA = "0x187CBFAE0")]
	public static KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA> ICMDPHEKAKL(DNIFFLNPKOK HHAMIICKBDJ, BOPBEMJOHNP POMFGMAFNAP, CILOKBIOANF? JNEEJKCMLAP, bool MFJLJCAHHGG)
	{
		return default(KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF2A0", Offset = "0x7CBDCA0", VA = "0x187CBF2A0")]
	[IteratorStateMachine(typeof(ODKOGHCCKKD))]
	private static IEnumerable<CEIEJPOFNOJ> DGHIBOBLGJK(DNIFFLNPKOK HHAMIICKBDJ, BOPBEMJOHNP POMFGMAFNAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1030", Offset = "0x7CBFA30", VA = "0x187CC1030")]
	private static void ILJPGBFCFGI(DNIFFLNPKOK HHAMIICKBDJ, BOPBEMJOHNP POMFGMAFNAP, IReadOnlyCollection<ByteString>? JJPEHCOOPGK, IReadOnlyCollection<ByteString>? FFBJOBHKICC, IReadOnlyCollection<ByteString>? ICKPFIDEAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF3B0", Offset = "0x7CBDDB0", VA = "0x187CBF3B0")]
	private static bool GLFJANMPDEK(DNIFFLNPKOK HHAMIICKBDJ, OGEHLNKGNIL NFMFAEBKEHO, BOPBEMJOHNP POMFGMAFNAP, [Out][NotNullWhen(false)] string? OLIGKIPGKGK, [Out] Dictionary<int, int> FIEKLBMPBMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1440", Offset = "0x7CBFE40", VA = "0x187CC1440")]
	private static Dictionary<Guid, INHHIPBBNEG> MIPJDEKNNPD(DNIFFLNPKOK HHAMIICKBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBFA50", Offset = "0x7CBE450", VA = "0x187CBFA50")]
	private static void GOFIJCJGIKN(bool KMFKAEJDDOP, CEIEJPOFNOJ IMNAAJEOHCB, CILOKBIOANF LBCMLAJPILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF010", Offset = "0x7CBDA10", VA = "0x187CBF010")]
	private static void BLAJIIHPEKG(CEIEJPOFNOJ IMNAAJEOHCB, Guid OIEHHJHKJEF, OHBOAJDBDJD? LEJAPFFONPJ, Dictionary<Guid, INHHIPBBNEG> GIPNFAJBIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7CC1720", Offset = "0x7CC0120", VA = "0x187CC1720")]
	private static void MNDOPIBGBHB(IEnumerable<CEIEJPOFNOJ> HLBLNFKKMGD, IReadOnlyCollection<ByteString> JJPEHCOOPGK, IReadOnlyCollection<ByteString> FFBJOBHKICC, IReadOnlyCollection<ByteString> ICKPFIDEAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BOPBEMJOHNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	public bool KMFKAEJDDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public JCCNJNLJDCB KAAOFLBGIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public OHBOAJDBDJD? LEJAPFFONPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public OHBOAJDBDJD? NICCIEBDIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public DDHFPHCGNKP JIHJIEFDIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public IBBJHDHHDKP CFCOPOJNCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public NJCICNADLJP EEJCOJGODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public HMILHODHBAC<JIFLPHMJMBF> KGMJPHBJPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ADIKDEHFBIF EENKNHDIHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public List<CEIEJPOFNOJ> IJANKLCIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public HFLODILPGJG ADMDDIMPGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public MIMGJKALBJC HHEBCCGPMAK;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OHBOAJDBDJD
{
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private const float DPBEHDNFJNF = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public Vector3 JFMEMBGKAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public Quaternion NGPACIMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public float JAHHKOMJJAE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 KKBCDPCNCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD830", Offset = "0x7CCC230", VA = "0x187CCD830")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS JPBDCLAAOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7CCDD60", Offset = "0x7CCC760", VA = "0x187CCDD60")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x14F4B70", Offset = "0x14F3570", VA = "0x1814F4B70")]
	public OHBOAJDBDJD(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float JAHHKOMJJAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDE30", Offset = "0x7CCC830", VA = "0x187CCDE30")]
	public OHBOAJDBDJD(UniformTRS DICAPHDMDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD5B0", Offset = "0x7CCBFB0", VA = "0x187CCD5B0")]
	public static OHBOAJDBDJD DIGBIBBHMJL(OHBOAJDBDJD EAGGHBKHKHF, OHBOAJDBDJD NBEMBHFIEKE)
	{
		return default(OHBOAJDBDJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD930", Offset = "0x7CCC330", VA = "0x187CCD930")]
	public static OHBOAJDBDJD HNONLACFBHP((Vector3, Quaternion, float) HPGIDELCODH)
	{
		return default(OHBOAJDBDJD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD950", Offset = "0x7CCC350", VA = "0x187CCD950")]
	public static OHBOAJDBDJD HNONLACFBHP(Matrix4x4 NKPLDEJJMNA)
	{
		return default(OHBOAJDBDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDDA0", Offset = "0x7CCC7A0", VA = "0x187CCDDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDB40", Offset = "0x7CCC540", VA = "0x187CCDB40")]
	public OHBOAJDBDJD NHEBFMFKHHG(Matrix4x4 MNINMACDPEC)
	{
		return default(OHBOAJDBDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD540", Offset = "0x7CCBF40", VA = "0x187CCD540")]
	public static OHBOAJDBDJD AKEEBCBNANK(Vector3 JFMEMBGKAOB)
	{
		return default(OHBOAJDBDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CCDAB0", Offset = "0x7CCC4B0", VA = "0x187CCDAB0")]
	public readonly BKAGGFBCLNE IDDGIBBHKPF()
	{
		return default(BKAGGFBCLNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OBAEPOIMEPO
{
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AFOFEMOKKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public readonly KFNGNHEDJNK LFLJOOKMLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private readonly NCGHLGNIAEG HENLMLFLJEK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x17A0610", Offset = "0x179F010", VA = "0x1817A0610")]
	private AFOFEMOKKFA(KFNGNHEDJNK GGGOHEOOHCH, NCGHLGNIAEG LKNBDIDNHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE3D0", Offset = "0x7CBCDD0", VA = "0x187CBE3D0")]
	public IBGKMJHFOCE MOHPIJMBGGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE260", Offset = "0x7CBCC60", VA = "0x187CBE260")]
	public static KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA> FMDOFBCLPJB(EPDNBKHJEFH<NOHGHNIBNOG> LKNBDIDNHOE)
	{
		return default(KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE1B0", Offset = "0x7CBCBB0", VA = "0x187CBE1B0")]
	public static KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA> FMDOFBCLPJB(IBGKMJHFOCE LKNBDIDNHOE)
	{
		return default(KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE310", Offset = "0x7CBCD10", VA = "0x187CBE310")]
	public static KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA> FMDOFBCLPJB(string JKGNPLPOKPM)
	{
		return default(KAFLOHEKGBO<CILOKBIOANF, AFOFEMOKKFA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KFNGNHEDJNK
{
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IGFFECIDBFM : IDisposable, GFBHNCCBMLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private NativeList<PLLACCJJPHF> EKBEICAOOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private float IGDOFDBAHMC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JBJNHLKNCIO ANLJNGGGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
		[CompilerGenerated]
		get
		{
			return default(JBJNHLKNCIO);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KMFJPAKOPBA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA990", Offset = "0x6BC9390", VA = "0x186BCA990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BGACOBABMHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA9A0", Offset = "0x6BC93A0", VA = "0x186BCA9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<PIGHEILJJEK> AGOOKMHEMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HBCOAOLAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CC8FF0", Offset = "0x7CC79F0", VA = "0x187CC8FF0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float IKCDGINNAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CC83B0", Offset = "0x7CC6DB0", VA = "0x187CC83B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CCAB40", Offset = "0x7CC9540", VA = "0x187CCAB40")]
	public IGFFECIDBFM(JBJNHLKNCIO FIKPCOCNDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8F90", Offset = "0x7CC7990", VA = "0x187CC8F90", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CC93A0", Offset = "0x7CC7DA0", VA = "0x187CC93A0")]
	public Vector3 JHKDINJOKHA(int IDANDMAPNBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA320", Offset = "0x7CC8D20", VA = "0x187CCA320", Slot = "6")]
	public Quaternion LDJEALGHHMF(int IDANDMAPNBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA450", Offset = "0x7CC8E50", VA = "0x187CCA450", Slot = "5")]
	public Vector3 MEJMBKGOOEC(int IDANDMAPNBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9190", Offset = "0x7CC7B90", VA = "0x187CC9190", Slot = "7")]
	public float HNJKLPNBKBF(int IDANDMAPNBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CC84F0", Offset = "0x7CC6EF0", VA = "0x187CC84F0")]
	public void CDLKLBFOFFL(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC, bool EPKBBGMNGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8DD0", Offset = "0x7CC77D0", VA = "0x187CC8DD0")]
	private bool CKAFMBNFHGK(int MEHDHBDDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9030", Offset = "0x7CC7A30", VA = "0x187CC9030")]
	public void GHLKBDBCDLE(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8F00", Offset = "0x7CC7900", VA = "0x187CC8F00")]
	public void DOMNGFMCEGI(int MEHDHBDDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9870", Offset = "0x7CC8270", VA = "0x187CC9870")]
	public void JIGGAODAGBD(int MEHDHBDDGLC, Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC91F0", Offset = "0x7CC7BF0", VA = "0x187CC91F0")]
	public void IENEKPCFGGG(int MEHDHBDDGLC, float3 JFMEMBGKAOB, quaternion NGPACIMGGNA, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA9F0", Offset = "0x7CC93F0", VA = "0x187CCA9F0")]
	public void PBMNEICHACI(int MEHDHBDDGLC, Vector3 JFMEMBGKAOB, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CC99C0", Offset = "0x7CC83C0", VA = "0x187CC99C0")]
	public void KCOOAICOHEH(int MEHDHBDDGLC, Vector3 ODJALHAEEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CC9B20", Offset = "0x7CC8520", VA = "0x187CC9B20")]
	public static Quaternion KDPILOJNAAD(Quaternion NOEMAMNIFJJ, int MEHDHBDDGLC, float OKOCFBCBMJO, GFBHNCCBMLF IPFPKOEJOJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA560", Offset = "0x7CC8F60", VA = "0x187CCA560")]
	public Bounds NMGGGAAIHGB(Transform MNINMACDPEC)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7CCA4F0", Offset = "0x7CC8EF0", VA = "0x187CCA4F0", Slot = "10")]
	public virtual void MGOKHKOGPFL(bool NNNCCJHMCEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8E30", Offset = "0x7CC7830", VA = "0x187CC8E30")]
	public NativeList<PLLACCJJPHF> DDBKFEOOEKH(float JMHEKPOCECE = 1f)
	{
		return default(NativeList<PLLACCJJPHF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PIGHEILJJEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public float3 ICJIGFAHILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public float NGEMMPELKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public quaternion OFOOGDIPMFO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE630", Offset = "0x7CCD030", VA = "0x187CCE630")]
	public PIGHEILJJEK(Vector3 NHKLJJMEOLP, Quaternion NOEMAMNIFJJ, float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE570", Offset = "0x7CCCF70", VA = "0x187CCE570")]
	public Quaternion JJLJJNCGKMC(Vector3 HPCBBMBEKNN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE280", Offset = "0x7CCCC80", VA = "0x187CCE280")]
	public PIGHEILJJEK IGGHFANPLBP(Vector3 OKBOOFOBANH, Vector3 BFEDFIKEAED, Vector3 EENEEEKLDLM)
	{
		return default(PIGHEILJJEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7CCE0E0", Offset = "0x7CCCAE0", VA = "0x187CCE0E0")]
	public AAOKEHOMCLM HPBJLIHBPHH(Vector3 HPCBBMBEKNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GNDOPFJLDMP : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3930", Offset = "0x7CC2330", VA = "0x187CC3930", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3C90", Offset = "0x7CC2690", VA = "0x187CC3C90")]
	private void OCMCOLEAKJK(Dictionary<Guid, Guid> KMPBHLLNCBN, NPOHHHKKOBA ELPGBADGCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7CC39B0", Offset = "0x7CC23B0", VA = "0x187CC39B0")]
	private void OCMCOLEAKJK(Dictionary<Guid, Guid> KMPBHLLNCBN, HBEDGOJIPPA OILDOBILAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3A10", Offset = "0x7CC2410", VA = "0x187CC3A10")]
	private void OCMCOLEAKJK(Dictionary<Guid, Guid> KMPBHLLNCBN, MEHAGDOHNMK DPGKIGICJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GNDOPFJLDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class FNICBFBDJFH : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2590", Offset = "0x7CC0F90", VA = "0x187CC2590", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public FNICBFBDJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JINFJNJAJKA : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB4F0", Offset = "0x7CC9EF0", VA = "0x187CCB4F0", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JINFJNJAJKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MOCJJFDGNKE : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBA20", Offset = "0x7CCA420", VA = "0x187CCBA20", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MOCJJFDGNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BAPNCDGMJKN : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CBE510", Offset = "0x7CBCF10", VA = "0x187CBE510", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public BAPNCDGMJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HFLENBJPOLP : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8270", Offset = "0x7CC6C70", VA = "0x187CC8270", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public HFLENBJPOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DGNPLPONOFE : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEB70", Offset = "0x7CBD570", VA = "0x187CBEB70", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DGNPLPONOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MGMKBAOBGIG : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB930", Offset = "0x7CCA330", VA = "0x187CCB930", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MGMKBAOBGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class KNFEIPLMEHH : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB650", Offset = "0x7CCA050", VA = "0x187CCB650", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public KNFEIPLMEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class GCEPGONMDKI : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7CC3780", Offset = "0x7CC2180", VA = "0x187CC3780", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GCEPGONMDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class DKDMENJNEBD : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBED00", Offset = "0x7CBD700", VA = "0x187CBED00", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public DKDMENJNEBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class KPKAPJGOFGI : IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public static readonly LJGHPJFBPPL FAGMGKEGAPN;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7CCB800", Offset = "0x7CCA200", VA = "0x187CCB800", Slot = "4")]
	public void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public KPKAPJGOFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PCCGMDMAJIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public OGEHLNKGNIL GPMAOGCPKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public HCKEKAGNNBL EKPEKAFBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public Dictionary<int, int> HLAJHOHGNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public Dictionary<Guid, Guid> PIEOBPPNFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public MIMGJKALBJC HHEBCCGPMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public bool MFJLJCAHHGG;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IPADCDGGOMN
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCMCKHMFJKN(DGCMLKHBABC JFAKCPPFDFN);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FPJCGBDFBIL
{
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	private static readonly IPADCDGGOMN[] MCODJMPCOLM;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2F10", Offset = "0x7CC1910", VA = "0x187CC2F10")]
	public static void MPHOCEMHDEP(CEIEJPOFNOJ HPGIDELCODH, CILOKBIOANF FEIEADIGGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2A10", Offset = "0x7CC1410", VA = "0x187CC2A10")]
	public static void ENHGEJHFAAM(CEIEJPOFNOJ? HPGIDELCODH, CILOKBIOANF MIGJNJHMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2CA0", Offset = "0x7CC16A0", VA = "0x187CC2CA0")]
	public static void EOOKOKABOIA(CEIEJPOFNOJ? HPGIDELCODH, CILOKBIOANF LBCMLAJPILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7CC2640", Offset = "0x7CC1040", VA = "0x187CC2640")]
	public static void BIIJPNCLINP(DGCMLKHBABC JFAKCPPFDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DGCMLKHBABC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public OGEHLNKGNIL HBMKKDHLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	public CEIEJPOFNOJ IMNAAJEOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public Dictionary<int, int> HLAJHOHGNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public Dictionary<Guid, Guid> PIEOBPPNFOP;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7CBEAD0", Offset = "0x7CBD4D0", VA = "0x187CBEAD0")]
	public Guid KKHKEFDKBPF(Guid FNKCCICOAII)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface MIMGJKALBJC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EKENJLJPGDD, [Out] Guid AHLCCOMGFDP);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GPGFEFKONNI
{
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	private static readonly HashSet<Guid> JELLECDIELD;

	[Cpp2IlInjected.Token(Token = "0x4000567")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private static readonly ProfilerMarker DLDNMGDEJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private readonly HashSet<string> CAMELILGKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private readonly Dictionary<long, int> PAIFJDDEEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private readonly HashSet<Guid> JAANNNBIGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private readonly HashSet<Guid> GKIHLDLEIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly HashSet<Guid> EDOKJLEBIOO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> AHAOOPNGACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> GFNPLGLANDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> FOHHIMOBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> IBKGNILIKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6190", Offset = "0x7CC4B90", VA = "0x187CC6190")]
	public static void OGHPCKHFMNL(DNIFFLNPKOK AJPABJFPONN, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7CE0", Offset = "0x7CC66E0", VA = "0x187CC7CE0")]
	public static GPGFEFKONNI PGEINBOOLFF(BGHEHCDAEKD NIAPBNPEIPM, OBMOIIKAPLI? FKIMNCFEPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5880", Offset = "0x7CC4280", VA = "0x187CC5880")]
	public static GPGFEFKONNI LOOPBCEMGDK(DNIFFLNPKOK AFPBFJEOLMO, OBMOIIKAPLI? FKIMNCFEPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7CC53C0", Offset = "0x7CC3DC0", VA = "0x187CC53C0")]
	public static GPGFEFKONNI FAPHMNIPKPG(PEOGAOHNHMC PPJANGMKLBE, IBLGPLNODHF OBKJONELPMG, OBMOIIKAPLI? FKIMNCFEPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7650", Offset = "0x7CC6050", VA = "0x187CC7650")]
	public static GPGFEFKONNI OIGDBGGBEOL(IEnumerable<string> CAMELILGKFM, IReadOnlyDictionary<long, int> BKNKIPOLPFJ, IReadOnlyCollection<Guid> EDOKJLEBIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7EE0", Offset = "0x7CC68E0", VA = "0x187CC7EE0")]
	private GPGFEFKONNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7CC8070", Offset = "0x7CC6A70", VA = "0x187CC8070")]
	private GPGFEFKONNI(IEnumerable<string> CAMELILGKFM, IReadOnlyDictionary<long, int> BKNKIPOLPFJ, IReadOnlyCollection<Guid> EDOKJLEBIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4270", Offset = "0x7CC2C70", VA = "0x187CC4270")]
	private void BDLJGGJMKOE(BGHEHCDAEKD NIAPBNPEIPM, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5130", Offset = "0x7CC3B30", VA = "0x187CC5130")]
	private void BDLJGGJMKOE(DNIFFLNPKOK AFPBFJEOLMO, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7CC76E0", Offset = "0x7CC60E0", VA = "0x187CC76E0")]
	private void OLPLKBEPGPD(ByteString? EDMANCBPIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7CC46D0", Offset = "0x7CC30D0", VA = "0x187CC46D0")]
	private void BDLJGGJMKOE(PEOGAOHNHMC? ALPBGLGCPNB, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4650", Offset = "0x7CC3050", VA = "0x187CC4650")]
	private void BDLJGGJMKOE(IBLGPLNODHF? OBKJONELPMG, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4510", Offset = "0x7CC2F10", VA = "0x187CC4510")]
	private void BDLJGGJMKOE(MLJKNJJCIGM? ANBJKBNFJGN, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5900", Offset = "0x7CC4300", VA = "0x187CC5900")]
	private static bool MGNGELKJNKL(MLJKNJJCIGM ANBJKBNFJGN, int FLLOKNCEIKK, [Out] Guid LNHOJHMHDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7580", Offset = "0x7CC5F80", VA = "0x187CC7580")]
	private static void OGHPCKHFMNL(IBLGPLNODHF? ALPBGLGCPNB, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6FC0", Offset = "0x7CC59C0", VA = "0x187CC6FC0")]
	private static void OGHPCKHFMNL(MLJKNJJCIGM? ANBJKBNFJGN, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7CC7200", Offset = "0x7CC5C00", VA = "0x187CC7200")]
	private static void OGHPCKHFMNL(PEOGAOHNHMC? ALPBGLGCPNB, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5B40", Offset = "0x7CC4540", VA = "0x187CC5B40")]
	private static void OGHPCKHFMNL(IODNCJJAGNO? DGGBJNBEMBF, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4A10", Offset = "0x7CC3410", VA = "0x187CC4A10")]
	private void BDLJGGJMKOE(IODNCJJAGNO? DGGBJNBEMBF, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CC54F0", Offset = "0x7CC3EF0", VA = "0x187CC54F0")]
	private void IIFDOKMAADE(Guid? FNKCCICOAII, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CC4D30", Offset = "0x7CC3730", VA = "0x187CC4D30")]
	private void BDLJGGJMKOE(CEIEJPOFNOJ? IMNAAJEOHCB, OBMOIIKAPLI? FKIMNCFEPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6B80", Offset = "0x7CC5580", VA = "0x187CC6B80")]
	private static void OGHPCKHFMNL(CEIEJPOFNOJ? IMNAAJEOHCB, OBMOIIKAPLI FKIMNCFEPLI, CILOKBIOANF LPPCNJOMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5480", Offset = "0x7CC3E80", VA = "0x187CC5480")]
	private void FMGCFDMMGOK(string? FMKLFPFHIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5750", Offset = "0x7CC4150", VA = "0x187CC5750")]
	private void LBAIIHMGMNP(long DINAHPFAGDC, Guid KALBDAKMCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5700", Offset = "0x7CC4100", VA = "0x187CC5700")]
	private void LBAIIHMGMNP(KDGHKBMLMLP? LFGNNNJBAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CC5820", Offset = "0x7CC4220", VA = "0x187CC5820")]
	private void LBAIIHMGMNP(LHMAKAGEOMA? LFGNNNJBAAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct OABJAIEAAEF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class BKCGDIFONFL : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private readonly IEnumerator<DictionaryEntry> EJDGCMPDMMB;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry EFHCDDHAFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7CBE8B0", Offset = "0x7CBD2B0", VA = "0x187CBE8B0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object PKHCDEJLLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7CBE970", Offset = "0x7CBD370", VA = "0x187CBE970", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7CBEA20", Offset = "0x7CBD420", VA = "0x187CBEA20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7CBE7D0", Offset = "0x7CBD1D0", VA = "0x187CBE7D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
		public BKCGDIFONFL(IEnumerator<DictionaryEntry> EJDGCMPDMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE730", Offset = "0x7CBD130", VA = "0x187CBE730", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBE780", Offset = "0x7CBD180", VA = "0x187CBE780", Slot = "9")]
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
		private sealed class OFDGGKGCHFK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CCD4F0", Offset = "0x7CCBEF0", VA = "0x187CCD4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public OFDGGKGCHFK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7CCD3A0", Offset = "0x7CCBDA0", VA = "0x187CCD3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7CCD4A0", Offset = "0x7CCBEA0", VA = "0x187CCD4A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7CCEC80", Offset = "0x7CCD680", VA = "0x187CCEC80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object KJNEHANBOBO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7CCEB90", Offset = "0x7CCD590", VA = "0x187CCEB90", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7CCED60", Offset = "0x7CCD760", VA = "0x187CCED60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7CCEAD0", Offset = "0x7CCD4D0", VA = "0x187CCEAD0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7CCEB30", Offset = "0x7CCD530", VA = "0x187CCEB30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7CCED00", Offset = "0x7CCD700", VA = "0x187CCED00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7CCE790", Offset = "0x7CCD190", VA = "0x187CCE790", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7CCE7F0", Offset = "0x7CCD1F0", VA = "0x187CCE7F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7CCE850", Offset = "0x7CCD250", VA = "0x187CCE850", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public RoomObjectCounts(Dictionary<int, int> KIGGAAFLPPO, [Optional] Dictionary<int, int> JOJGNIGIFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE6B0", Offset = "0x7CCD0B0", VA = "0x187CCE6B0")]
		[IteratorStateMachine(typeof(OFDGGKGCHFK))]
		private IEnumerator<DictionaryEntry> JLFFOOGDCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEDB0", Offset = "0x7CCD7B0", VA = "0x187CCEDB0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE9D0", Offset = "0x7CCD3D0", VA = "0x187CCE9D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE8B0", Offset = "0x7CCD2B0", VA = "0x187CCE8B0", Slot = "9")]
		void IDictionary.Add(object KJNEHANBOBO, object PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE910", Offset = "0x7CCD310", VA = "0x187CCE910", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE970", Offset = "0x7CCD370", VA = "0x187CCE970", Slot = "8")]
		bool IDictionary.Contains(object KJNEHANBOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEA70", Offset = "0x7CCD470", VA = "0x187CCEA70", Slot = "14")]
		void IDictionary.Remove(object KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CCE730", Offset = "0x7CCD130", VA = "0x187CCE730", Slot = "15")]
		void ICollection.CopyTo(Array KLDOGKPLNJA, int MNFHMLCLFEB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class OJBKGGCGHNB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CCE090", Offset = "0x7CCCA90", VA = "0x187CCE090", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public OJBKGGCGHNB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7CCDF00", Offset = "0x7CCC900", VA = "0x187CCDF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7CCE040", Offset = "0x7CCCA40", VA = "0x187CCE040", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB210", Offset = "0x7CC9C10", VA = "0x187CCB210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object KJNEHANBOBO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB0E0", Offset = "0x7CC9AE0", VA = "0x187CCB0E0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB2C0", Offset = "0x7CC9CC0", VA = "0x187CCB2C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB020", Offset = "0x7CC9A20", VA = "0x187CCB020", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB080", Offset = "0x7CC9A80", VA = "0x187CCB080", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7CCB260", Offset = "0x7CC9C60", VA = "0x187CCB260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7CCACA0", Offset = "0x7CC96A0", VA = "0x187CCACA0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7CCAD00", Offset = "0x7CC9700", VA = "0x187CCAD00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7CCAD60", Offset = "0x7CC9760", VA = "0x187CCAD60", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x28D7850", Offset = "0x28D6250", VA = "0x1828D7850")]
		public Invention(long KHNIMGKFPOO, int IMCIONKBBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CCABD0", Offset = "0x7CC95D0", VA = "0x187CCABD0")]
		[IteratorStateMachine(typeof(OJBKGGCGHNB))]
		private IEnumerator<DictionaryEntry> JLFFOOGDCHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CCB310", Offset = "0x7CC9D10", VA = "0x187CCB310", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAEE0", Offset = "0x7CC98E0", VA = "0x187CCAEE0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CCADC0", Offset = "0x7CC97C0", VA = "0x187CCADC0", Slot = "9")]
		void IDictionary.Add(object KJNEHANBOBO, object PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAE20", Offset = "0x7CC9820", VA = "0x187CCAE20", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAE80", Offset = "0x7CC9880", VA = "0x187CCAE80", Slot = "8")]
		bool IDictionary.Contains(object KJNEHANBOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAFC0", Offset = "0x7CC99C0", VA = "0x187CCAFC0", Slot = "14")]
		void IDictionary.Remove(object KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7CCAC40", Offset = "0x7CC9640", VA = "0x187CCAC40", Slot = "15")]
		void ICollection.CopyTo(Array KLDOGKPLNJA, int MNFHMLCLFEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> CABLMKOMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	public readonly IReadOnlyList<Invention> OMFBAFDELFB;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	public OABJAIEAAEF(IReadOnlyDictionary<Guid, RoomObjectCounts> OEMBIEOAHCH, IReadOnlyList<Invention> NFHJHCCNEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7CCC350", Offset = "0x7CCAD50", VA = "0x187CCC350")]
	public static OABJAIEAAEF PGEINBOOLFF(BGHEHCDAEKD NIAPBNPEIPM)
	{
		return default(OABJAIEAAEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBB80", Offset = "0x7CCA580", VA = "0x187CCBB80")]
	[CompilerGenerated]
	internal static int CLBCOECCHJL([In] IReadOnlyDictionary<long, int> JJDLCEKEGLN, long? DINAHPFAGDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7CCBCA0", Offset = "0x7CCA6A0", VA = "0x187CCBCA0")]
	[CompilerGenerated]
	internal static void EPPAODDLMDO(int KAGIIBHKLKD, [In] PEOGAOHNHMC EHNACAKKDHP, [In] Dictionary<long, int> JJDLCEKEGLN, [In] Dictionary<Guid, RoomObjectCounts> OEMBIEOAHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum MNGONHMLOON
{
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class OBMOIIKAPLI
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FBEKCNILJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public readonly Guid PJGFMPKJDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public readonly IReadOnlyList<Guid> GFNPLGLANDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public readonly MNGONHMLOON LFLJOOKMLKH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7CC2530", Offset = "0x7CC0F30", VA = "0x187CC2530")]
		public FBEKCNILJGD(Guid GJEEKGJKBGO, IReadOnlyList<Guid> EDOKJLEBIOO, MNGONHMLOON GGGOHEOOHCH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private readonly CILOKBIOANF JGJCJNAGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private readonly Dictionary<Guid, FBEKCNILJGD> HEOFKAOPKBP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CILOKBIOANF CCIDOGBMJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCE20", Offset = "0x7CCB820", VA = "0x187CCCE20")]
	public void PBDMKLNODMP(Guid PKCPFIODDIO, Guid EBHFKIBNJHI, IReadOnlyList<Guid> CPHOALCCELM, MNGONHMLOON GGGOHEOOHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7CCCD30", Offset = "0x7CCB730", VA = "0x187CCCD30")]
	public bool IEFDAIFMFOA(Guid CBLIFPFEHPH, [Out] FBEKCNILJGD JMPPDEJDBOE, [Out] bool KDILIKNIFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7CCD030", Offset = "0x7CCBA30", VA = "0x187CCD030")]
	public OBMOIIKAPLI()
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
