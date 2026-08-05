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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x82F1670", Offset = "0x82F0470", VA = "0x1882F1670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LHGIHJGAFML
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> IIKHGAICJOA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> KHCOAGEDHGG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> EKLABDNBGHJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> HIMEKLBLEEP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ADJGDCNFFGA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string BEENNKGOPCP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string AOLPBNODOGE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82DFBF0", Offset = "0x82DE9F0", VA = "0x1882DFBF0")]
	public static bool HBFBJBDGIBK(Guid EMGGHKJIDDO, int MOGBFMFKHLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82E0370", Offset = "0x82DF170", VA = "0x1882E0370")]
	public static bool PKMENOJGHJK(Guid EMGGHKJIDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82DFCF0", Offset = "0x82DEAF0", VA = "0x1882DFCF0")]
	public static string IHAFHOKCJHE(Guid NMEMPCKPCOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MDLMCBIIKPC]
public enum OJHLNMBOBOF
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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82E3890", Offset = "0x82E2690", VA = "0x1882E3890", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BKOEHOBGAPM
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid CHDODLKNEKP;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JLNOENCDJIE;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FKOHJFNEGJO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid IECDEEDLOFD;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid DEBNEDGKANG;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MKGGEBDMIIH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid KJFBPCCOANP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GNEFGKJJMKM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid LOEEBLMLIAC;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid NPPCJPAJPIM;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GBJLJMCNCPN;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MDAHNJPKKJM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid EFOEAMGMMAK;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid HNGLJPMMLKM;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HHOHCODDNPJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OHHIIDIIAAB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid HFHEFLCMBKF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid OBKAFDNCDGP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid AJKDEDIGGAC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HNNCAPLEIPA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid BPOKNEILMOK;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid DKBLOPCGOMO;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid PJMEHLMAGDP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid MOKBAKJPNAC;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid KLCGFIGPFGM;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GOLBIPHMAMF;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid BMECPGDGCJP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DDDFHMAGHGJ;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid DIAKIAEHFAJ;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid DOGHEEGECEM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid KLFKKBFCONG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid IEAANKELOML;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KFDAKHMCBBA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid MGBIIEHDNEC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid MDLCDIIFLBC;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LCCDBECGLGF;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid ILHCCCPFAAM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LFINKHACNFF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid MBHJLPFFACI;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid BHGBMKDCBMM;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid JIFKGPGBFCH;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid JBGGCMKPFGB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GGOEGNDJION;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DADCAKOLJKD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid DIJKHMNEBPM;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid CNCNAFGLLJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid DPILBECGNBE;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JLNDDEPPPAH;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BMPKCBBNMMO;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid ALJJKGNGCCF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid JHOJPIHNBII;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JBMJKNODAFF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid HEEEFCEOPHG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid HOKMKHFCPNN;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid JBEICOGMCIE;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid POIFMPBOBHA;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid BABNHJLMGOI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid NEEMCDLOLBM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NINNDAFDHKE;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GJINGMFFNCC;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid CBLHEBILGML;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid LEFMBCOIFIB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FKJOKGCAHDL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MOKOEKHNBKK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid DFFEMIGKCJI;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid IKKEKLKPAIN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid MIADNFKILFM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HBOOCIACCNJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid BBDIOBIFGGN;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid CPFDJLMENON;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid IMGONOEHCCK;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid KIFNPJBBPCP;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid MOJMOHHIMKM;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HDMBHAOCMLB;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid BAACNAFGGIA;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NFAEFNPIHDP;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid OCPDMPIGFFB;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid AOOMOEFIHNI;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid DDGOBIBIOJP;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid PPFPPECDFDF;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DNGIIPLNOHK;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid CKOJLOGKEED;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid BHLIEAIKKKC;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FFPKCOMJLHC;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid GIBOKINCJAE;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid CKECCMJOCOB;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid DLPNIPBPELD;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid NIIEIOEOKAD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid ACMAFIAHGOB;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid FOOBMODFCIA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid CIFPNNKLCCM;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid CLEOKNABANM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DIGHGKDCPAB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OBBELPAGBFG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid ANCHBCPFJAE;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid EHPJHFNMOON;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid EFKMLKBNBCO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid DAEBGFNILAN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid NMCOHEHDPMB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid FGPKNIDFAKF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid PCOOAPMJBOP;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid ECGAJMOIMCD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GJAFFLKGNNH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid MGLBMNKNKCA;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid AAGJNCMNPOH;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IGCDIDLGDIB;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IFNFCPNNDFA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FBCCNAGLCCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid MCDNGACOFKG;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid OIBDFDPHHHA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid JLFMAMFPMBM;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid IMDFLOICOIM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid NINIIBLBDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid AJDLLPFLEPD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CLCKCOPLEAF;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HMEDHEDBPBH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid OIMECJHPHKH;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JJJFPPADGEM;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid AIAOAFDAEBK;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid IDDMBOAHEAG;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid COGKAICCFGL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid EIKNOLDCKCN;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CPELPDLCOBJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid AJIOLBHIIMP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ANOMPDGGOEP;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid GAEFDCECCMP;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid LPNANGDMPMC;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LLFNDBEEKMP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid IJFMLDOIDIB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KCAMPFHAPCB;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid JDDBKEEAHND;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid OIJMCJEPJNK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid EGIDGKPLKLE;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EHHNMJKOIJP;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid HKPMHMPMKJF;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BPLOFAAPODP;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HMLPPANKAGD;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid EPPGILJNBOK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid BOEAHJLICGP;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid NLDAEALODEB;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid EEOHDFIJDKP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid KGMLGHGEPOO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KAJAPNGEHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FNAMFBODKJN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DEPFGKKKJMG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid CONJLAGLKMO;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid LJDHNFEBKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid FENDNOEDCNO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid GKFKLJABOLK;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MOPKCBLEEPD;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PJFOOPIANBM;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DGNHLLFMCNC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IABDDPHMEAB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid OFLFLBLDNPL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid MEMCKCCOHNL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid GBFMBJKMAFF;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid DGMMKHDNAGE;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KMIJDACKPJP;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HJHHNDONIPC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid COKIJPKFHOP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BGKNJAPPEHK;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NHALOMAKKEG;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid LGKLBIJEAJO;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid GCKPLONOLNP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OILPFDDLKAE;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid PCLHBFCOKCL;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid PEEEGCGMHCO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid CBMFCFNJLDE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid HCCGHCNNMIC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid AKDJNIGKFMA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LOONEECDNBP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid ADJKKONOJFP;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid CAMNIEADBIK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IANPHMJIINI;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid AFNPAKECNOP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid HJFMDMKAEIO;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid BGHBAIGIEDF;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid CIKNBKFICDP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IPPDAJDMCIL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid LMDODMPNCCB;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid JDBOJMNFHBM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid LKFNKOEFBBA;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid EOENLHPCGHM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid CJCGLDCBOKA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BHFGKDCPIKO;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid PHEGFNAEADP;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid HGGJDLOPKMA;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid NHKFBEHOHFA;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid HGOHGCOPPKF;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid ALIABEBNIBD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid FAPLILDDJIK;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid BGGKJKOIGEF;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GIAADACKMOL;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid PKAEFFDDKCK;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid ANJLLEHLNHF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid ICKBJCJEAJE;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GNLKBLHHAGM;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid NKILAMEHBLO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid POHIKEOENPL;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid DLBOPHOCJFH;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DJFNBIBIGON;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BDALDHNLEIA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid HMPBBDOGOKE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FONPOADIEOD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GCMDHJJCHEC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid HPLIMFGCBDK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid JDJJIKKEDKP;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LMAMALFBKGG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid PJCPBIJENBF;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid DLLDJLPAKDG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HGEKBIJDIAE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid ECLPBMGCIPM;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid MPBFMLBHLEB;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid HPOKOJGNGJD;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GHLKJLAOLJD;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid KFKOEILNPNH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid IKKPLKPNKEK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid NCFNFLGFKEC;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid GGMFEEOEFFJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid HNGPJJHGHDI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OKMNCANGMBC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid JKLGOMJCBNK;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DMLDJHBDGGA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NAPIHDDKCHK;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LONJEHLFBGD;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid OADJMCKHMLD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid HMNDNFNNACD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GHENAPAGMHF;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid LKHJCPPPJJE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid FNHPHMBPANE;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid COIAFFDCIAD;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid LLCHNLEDPGM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid CHBNFGGALMB;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid BGHHOMKFCOA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid IOGFJCKEKBJ;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LJMMCCEAHLH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid NCLEICDCNBI;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid GIPPMHHODOF;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CEHHHDNFIMK;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid DBIOGKJIKBD;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PHDNEPFFNBN;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid CPPDJFIELAL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid IMNAHLIPCGM;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid BENCGHPLBIH;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FAENFDJKCMO;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid FFFINDGGDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid EPGHBLFFCKO;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LOMPIFLBGOF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CGMLBAJPJBC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid LIPCLNFCAEK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid KDJJIKBENGL;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HHDLIKPCJAF;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid NOPMGGCNEBH;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid BJHMCMJHFOG;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HIGPNEMOJOE;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid EEEIPPKEAFD;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CFOEKGCMELJ;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AHGADDBALBJ;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MHAHPCDCDAB;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid BIFHDHAEBGK;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LNABAOCGOFB;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid EDGDOJDAMGP;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid FJFBLPOMGKF;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid FJHOGFBHIKF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid BBAGDJNOKMI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid HHKIIGCBMBL;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid OKNNCMEHCJC;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GNLPEIPJBPL;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PPAOMGGBJBN;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid EADKEOLKHDP;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LCHEPHANECD;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid MEHDMEANFLK;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid NODPCNHEHCI;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CCJDAMOCONC;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid ACFAOOLJANB;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CCNFIDNABCI;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EDJLOHBHICB;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid HHJLAJGIONN;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid ACLGDKLLNEL;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid GBJACGHOOCE;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid HDKJHLKKNFH;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KCPJJDGMCKC;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid PFDBJNONCGH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid OHGLKNFHOEK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MNPOCEPHOPH;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid AHLOKKIJPIC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid LCLIMJMJJGL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid ELOEDOCFAFI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid IOMCJKLDMFO;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OLDPKKPOCGL;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid EMMCKGHHHDH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid HECBKGMHPFK;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid OPKNFALGPOO;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid ONGBIMDGFLC;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid IHPKMDCGGBG;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid DADIGGKAJDO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid FAEHCPCGFFG;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid FNKKINFBBKG;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid ACBMCBLIOFD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid MHKIDFLGNOK;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid CICGHLJMPEN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DNIIOEHGFJB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid OKFOEBKCCEE;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid IKHLJNGAKAI;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid GJGHBCHACCH;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid HDPAPKEFDPH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BJHFHKJCLCC;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid IJJEDIFOEDF;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KGHEHAIKCCJ;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid GGGENDIJHFL;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid KJNPFGANFON;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BDIBOLNEKGJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid KKPIEDLLHGN;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid APECOGGAEHJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid PDOAMIIAHGM;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LKMDMBIBAAL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid COOFAJIFLIP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PIKMHOPDEKM;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HOIPKHFAOGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FADMKMLIGKL;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid NDDOKDIONME;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid EDDDNGFJEAG;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CKHKBJAAPJL;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid EFPJDEHLALI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid LFILMNGFFBE;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DMFFOHCBGEN;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid JAECKMLMNOE;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid POIMFCOEPCP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid OAHJHMFANMM;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GCINMFMMLCJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid GBHPGHLBHCH;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid KFCALLLNPJP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid DFJJPLCIBBK;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid JIFIJAHALJI;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid IIBIBLHAKCG;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid FFHMDHOCEHC;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid DAFOGMONPGM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid MAGICJNGKLL;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid GAIKGNEOLFG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FCOEAKCKOHB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JJFFKGFFBNO;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid EAEOBMAFNNL;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NODDMCEBIMM;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NHJNLKENOPK;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EALBPLNJNHD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JMPGOCJLBHP;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid PKFMDCMEGMI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AJEFBKOEPPG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FBCODCBNNNF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HEGJCIOBDMB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid HOAAMCJOMOP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KLHENAFKBDN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IJEIPHGMKFP;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NLIKLGKHGLM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MFFBAPGEGDK;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid FDNOOKGOPII;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid FDCBHDHCHBI;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid NNGFOAOHPEM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid LMNBJDPMPLA;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GJHBCCEBNFE;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JBFPKDGKNAC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid AOAFHDHHLFG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DMGFIINEOCM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CGFOMOGKALP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid AAJGOMCMFJB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid BBGLGJGIDHF;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid COFHOELKBOH;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid CEGCMDIHOKO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid HDBPDABLAKN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KAOGOFPHHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GDPBGOFDJFF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DEMLJFBACFB;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid OJMHJFAHCJF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid GEDLLLJHBOL;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid IEFLGNPGJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid CLFCOPKHGHJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid FMMDJAOCEID;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid LLJMBBMMBEC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid BLICODHPEKO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid OHBLBHGEMII;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PHLAELOPAJO;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid CNCNLCCKLBF;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FBJJKNPFGIM;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid PPDFPMAHBME;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BGNEOKAGBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid KEIMKEAJMEO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BHDBMCGENKM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid PCNIJFMLMLA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid GOJJJNAINLK;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid EKIJNHFMIEI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid DBOIGAAIADP;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AAHJPNLHEAC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DDCPNLKAJBK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid KFJFHODPJOF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FKMDKFLFJCG;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid BNEANMOACHA;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CAPGMOIAJML;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LGCEAJLDLCN;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid DJJJEFJPHPN;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PJLKGKJMEKC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid DACDKHKPILL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid OBPOKCCPGOL;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JKIBALLGIJJ;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid BCIFPCKBKPK;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FNJFKKNMBDE;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid ICMIHJGHFKL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid GAIOBFNFMBF;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid EFCGHDKDHHF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GDMFOJKLGNB;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid ALBOMKBNAOG;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid ADDLNKLCNGP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid FFAFCGCCOJM;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AHFFAIKBLIL;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid ENAGCDPLHHA;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid LFIELGFKIHL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid IAPEIJKDCCE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid OKILKFFGLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IDOCOPDOBHF;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MMFMBCBAMCI;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid FFJKAGCNOJC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid OKFIOLLKPEM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OLGDHONMBMJ;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DBLOLONAJIH;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid ALPONEKJFFE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid KLDBPCKMJLI;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GAIBFLENFEK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid FBJLHNGHGMM;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid HOHIGANCONL;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NOBEBNHICKB;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MPEDFPDCDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NBKJCHDGKDI;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid EKMNPDGIMDD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid OGACMCNIJKO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IBJGHGKDJCE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DBLLFFCOKDM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid CPLPOBMFHLE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KBKNJJOBFBH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid LKEPCHHMHEB;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid OEGNAABNLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid FGJALBJMCDL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DAACAIFINCP;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid JONEEEJLKOM;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid EMGKMOEAOLN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid LEPOEJNGPDO;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OOJMADOJBJN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid CMBKFIJDIMM;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid KFKEKPFEOAC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid EEJKHCMDDAM;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid NDGINBEGCDE;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OOIEBEDICHL;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid OBMOHDAJCPE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AIAGHAHICOO;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid AMGBFBKMBNE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid EOPJKLCEOFM;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid LDPCOIDAMMA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KGENNIAGAEP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MBKOEHFBNEL;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid NEDFELFNHNN;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid HJKMPIKLBHC;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid AFCNHLENNKJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid PMHMOCHHHDC;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid BFEFBEMGHOE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid KENNIJMFHLH;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid DPDAFHEJMLC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BJDOFDNHFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LLNKBOKEIKN;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MMJNADMMDKN;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid AMMNANFCJKM;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid HBGLJLIGIOO;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KBENKMDCMFO;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid OHFKBBLAPGF;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid CKNDKDBBMGE;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid AACIHMJGFJE;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid LHKLMNFHFCJ;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid KHFJOKAMPEJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid GHPILPCGNBJ;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid MGMAHEDLPPK;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid EKMGLAAIEFO;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MGNHNNCBHKM;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CLJFKEBFEMA;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FHCAELEALNA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OMADJJKDJFL;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IJNFHKCHNLC;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KPMEMBHFPPI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid MKBLNDOEAHF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid IOMJPBEKEBB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DOJMNIJNLGN;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid JEEDAMGOHML;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid KGGHAEFKJBE;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid PODKLGINKID;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EHDAPNBOKED;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid LDFAEECGFKG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid PJKEGCNJFAP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid GOBGFBOOGAK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid CBECBAGPDDE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid EBPIPBMLIOH;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CPLDBNGNENE;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid FDPAMEHEHLK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HLNKOHPOIMO;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid ILNKFEGOCEN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid LALEEBHLDPA;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid HOCJAKGCHFO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid ADBCEMDHCDN;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KFFNEKAFPHK;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KLNIBCLNBDJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid OPGHMPHDAGM;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid DBKBPPIBBCM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ECLEFAIDLKC;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NBIHDBPNOAN;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid HJIJJKLCOPM;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid CIPCEAMFBEP;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CKMGEDPGNFH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PFPPLINFDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FNHEEEAGFLN;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GKEMAAACOFP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid HLKLKHAOMKN;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid NPMLNAHLMBN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JMNMAKJKBKD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid PBIEJGHEHLB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid LDABLIHPFEK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid EJIMEFMNKFG;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid JPPKFCABHHJ;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EPKBACAAFDI;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LNHIKFDGLIJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid HFGDHPKLHBD;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid AOIBLGBNLDP;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid MOEKMGPCBII;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OMFJDDPFDHB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid LLGNBLLLFIE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid OJNCOJONJOL;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid KCPFJPMOEFD;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid DGOGHGNHEBC;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid KBEMGCEANOM;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid JFGNBKCHEBN;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid DGCMEJKKCFL;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid MODBOPKMOHI;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid MJMHPFLAODI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid JAJBHDKOKPC;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OBEHGKDHNDB;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid NOFBIJLHMMD;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid JFBGMNGKLGK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DNPIBLCPLIF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid FFBJGILPJNM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JEMMGFIBGID;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid IFBNBOGINGO;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid HMLIGCAAHPN;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid AOIILEBNHNM;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid JMDBCJIJBMO;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid FIKPJLAJAOE;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid GHMCBGEDJNG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CNJLEGPDPDC;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NBGAAONOOAG;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid FCOCKHCGBAF;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EBCANKLPDJG;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid FPGACCNLPBJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid FFJBGIFKHIP;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MAFMJKDOIFB;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid BCIBDMENONA;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IFGFBMGNJIB;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IKPLLFLHFAG;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid EMLPHHCHOON;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid CMLICONJIIN;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid FAGKNJMMFJG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid LMELEIJNCPH;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid MPMPOPCDAEI;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid HKJCEOEKNOD;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JAPCHJNEEBK;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid IGFDAMLNPJG;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid LKOGFGODCDB;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid HFKPEEICPHH;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid NMHIGCDKADG;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid NFENDPJMPGA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PIEMGBPIPLN;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid EEHNANEHOFH;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid KMJOFHAIJBG;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid HEJDHGBMAGN;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid PGKPIFKOELF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid PLIBPNPLLIP;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid MADEJFAMDGP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LBBOOAAFGJI;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid AMJOFOHADGO;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid ALMCJFCKIMH;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GCIPBNGAIFM;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid BHGCCPJFHPE;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid MGGADKGIGIC;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GMOPMDMJLNG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LIEMAIOCOAN;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid MAJAMGIKCKF;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid JGCCIDMLLMO;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid KKMHCMNBLIP;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid IPHJAIDLFGL;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DCLACAINPLE;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid OIMJPCFCECG;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NEFKLHOIOII;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid LAHPCLMJBCN;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid LMCEFLKPBAH;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid JLOALOJDGNM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid JILJCNPBEJO;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid JMEBBEHBDEF;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid GAHHKIAODOD;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid CKIKOJDEBLA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid HKMJODGOLFM;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid KEPCFHJMIDE;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LHGAHJGIDEN;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid HGNNELHDCNE;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid NLJMOJPBJNE;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid MLLPILAILBJ;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid LBPMMGKJJAD;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid KDLOCDODAEF;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid LKEAAHHENLJ;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid OCNCCOKJAHJ;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid JEAIPHNPLFM;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid FDKMCBAAJJL;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid LNKCPFBEBDG;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid DLOCCPJMLAB;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid AKIFLKNHMHK;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid AJHNFJGOHAN;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid EECIDDCFADP;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid PIDIBDFIJKL;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid OOHDOIHEAED;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid NPJCKJCLIOI;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid CHEGJKIKOHP;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid KEFNHAJPNFO;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid GOGLDBBGDMI;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid GKLGNEHLCBP;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid GINFLMKBHDA;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid DKGICKCJOKK;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid CPKCMPIKLIO;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid BPJKEBPENKJ;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid IPALEKIBGMA;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid CINFEDKLPMM;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid MEGMNDGENJN;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid CKAAHKBDGJF;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid FPLJAIEDEHP;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid MMAHCFODACL;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid KOMDGLLPEMI;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid MOPMHKEJKAN;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid NFJCGCKFLOL;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid FEKGJLAHAEI;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid LDEMLPCDFLN;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid BIJJMJECFKH;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public static readonly Guid DHIBEBAJAPP;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public static readonly Guid LMOCEMEJAHN;

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public static readonly Guid BFLINFCKMKB;

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public static readonly Guid MEBNLGDLGGC;

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public static readonly Guid GEIJIFAJGIH;

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public static readonly Guid BBJFKOJBGFE;

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly Dictionary<Guid, OJHLNMBOBOF> PHPHJNECLDC;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly Dictionary<OJHLNMBOBOF, Guid> HOFPODIIOBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OJHLNMBOBOF> FNONDDIIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82DE450", Offset = "0x82DD250", VA = "0x1882DE450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OJHLNMBOBOF, Guid> PMODIIFKLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82DE4A0", Offset = "0x82DD2A0", VA = "0x1882DE4A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IPBOBHELLAD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82DFBC0", Offset = "0x82DE9C0", VA = "0x1882DFBC0")]
	public static bool HIPDCOOBHLL(BLJOALEIKJC JPPOHLEEEGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82DF7A0", Offset = "0x82DE5A0", VA = "0x1882DF7A0")]
	private static bool HIPDCOOBHLL(GOKMFNHMGAG ILCELEMMMGJ, BLJOALEIKJC JPPOHLEEEGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BAKDOIHHHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(EIGEBJBABLF KANAIIDGHCH, [Out] Dictionary<int, int> MAPPIPLCAIE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(OENCDFMFFLF CNCOHCDOKJG, HLJOOJEBHLC MEOKJFEHCHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FNNGAEDPDJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly GACGLPEJCPJ PKJDKHCGBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IEnumerable<NBHBELOMHAF> GFHIHKBEAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly IReadOnlyList<NBHBELOMHAF> PINHONGLEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly PFJMKELOBBL<FGBJJIEAJJD> IEBCHALCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly IReadOnlyList<MOKHKMALOIP<OAPHEJLBOJB>> CICNINMJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly GLNKMMNDKID KDMNGFOIBLH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MOMBDGKCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82DEF80", Offset = "0x82DDD80", VA = "0x1882DEF80")]
	public FNNGAEDPDJE(GACGLPEJCPJ PFNNNPIGKGD, IEnumerable<NBHBELOMHAF> JAEOGFCKMJC, IReadOnlyList<NBHBELOMHAF> GLEMJJNFFFK, PFJMKELOBBL<FGBJJIEAJJD> EPOGDNMGDKN, IReadOnlyList<MOKHKMALOIP<OAPHEJLBOJB>> APCHDJGICNE, GLNKMMNDKID FGIBJLKFCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CLNIBGJHBCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly GACGLPEJCPJ PKJDKHCGBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IReadOnlyList<NBHBELOMHAF> APCHKPOAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly PFJMKELOBBL<FGBJJIEAJJD> IEBCHALCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IReadOnlyList<MOKHKMALOIP<OAPHEJLBOJB>> CICNINMJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly ByteString NFNNHKMDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly GLNKMMNDKID KDMNGFOIBLH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82DE4F0", Offset = "0x82DD2F0", VA = "0x1882DE4F0")]
	public CLNIBGJHBCM(GACGLPEJCPJ PFNNNPIGKGD, PFJMKELOBBL<FGBJJIEAJJD> EPOGDNMGDKN, IReadOnlyList<MOKHKMALOIP<OAPHEJLBOJB>> APCHDJGICNE, ByteString CCFGNDPBIOF, IReadOnlyList<NBHBELOMHAF> OMKMHMKADBG, GLNKMMNDKID FGIBJLKFCIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FFHBAGKHKLF : MLFKDKMIKON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly Guid DBGGGHAHFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly Dictionary<Guid, Guid> OKBODOGBGNF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FFC0", Offset = "0x4F7EDC0", VA = "0x184F7FFC0")]
	private FFHBAGKHKLF(Guid BJIHNOOIOMJ, Dictionary<Guid, Guid> OKBODOGBGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82DEA20", Offset = "0x82DD820", VA = "0x1882DEA20")]
	public static FFHBAGKHKLF ELDPFIHNJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82DEED0", Offset = "0x82DDCD0", VA = "0x1882DEED0")]
	private static Dictionary<Guid, Guid> ONCIDDHDJLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82DEEC0", Offset = "0x82DDCC0", VA = "0x1882DEEC0")]
	public static FFHBAGKHKLF MLCFPOEOIJJ(IReadOnlyDictionary<Guid, Guid> HNLFFLNNKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82DE560", Offset = "0x82DD360", VA = "0x1882DE560")]
	public static FFHBAGKHKLF BOKHJBBCEGK(IEnumerable<KeyValuePair<Guid, Guid>> HNLFFLNNKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82DEB50", Offset = "0x82DD950", VA = "0x1882DEB50")]
	public Dictionary<Guid, Guid> HNCOOPOGNOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
	public Dictionary<Guid, Guid> IEMJAKKMGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82DE9A0", Offset = "0x82DD7A0", VA = "0x1882DE9A0")]
	public void DPHJBDIDPOG(Guid HNLFFLNNKGK, Guid AGEFPDLPNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82DEBD0", Offset = "0x82DD9D0", VA = "0x1882DEBD0")]
	public void IAMNOAMNEBH(IReadOnlyDictionary<Guid, Guid> FBAIFBBFIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82DE850", Offset = "0x82DD650", VA = "0x1882DE850")]
	public Guid DCFAHCNOCAH([In] Guid HNLFFLNNKGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x82DEAB0", Offset = "0x82DD8B0", VA = "0x1882DEAB0")]
	public Guid FEGMOCEGDME([In] Guid HNLFFLNNKGK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x82DEE50", Offset = "0x82DDC50", VA = "0x1882DEE50")]
	public bool OOPEAKLEHAB([In] Guid HNLFFLNNKGK, [Out] Guid AGEFPDLPNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82DEE50", Offset = "0x82DDC50", VA = "0x1882DEE50", Slot = "4")]
	private bool MJEHCDPKHFI([In] Guid HNLFFLNNKGK, [Out] Guid AGEFPDLPNLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IMLGDLDIBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJELAKGBJLA(Guid NMEMPCKPCOG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBHOMFJLIMO(Guid NMEMPCKPCOG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CLGMCFCMNHJ
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
public abstract class IIBDJEOMLFD : IMLGDLDIBPK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GMIBHCLIPKI : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public GMIBHCLIPKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82DEFF0", Offset = "0x82DDDF0", VA = "0x1882DEFF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82DF150", Offset = "0x82DDF50", VA = "0x1882DF150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82DF0B0", Offset = "0x82DDEB0", VA = "0x1882DF0B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82DF0B0", Offset = "0x82DDEB0", VA = "0x1882DF0B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PKKGFMJIDLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public IIBDJEOMLFD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x82F16F0", Offset = "0x82F04F0", VA = "0x1882F16F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82F1E00", Offset = "0x82F0C00", VA = "0x1882F1E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private Dictionary<string, HashSet<Guid>>? PGKJONJNBAI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> FGNEGECCDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82DF340", Offset = "0x82DE140", VA = "0x1882DF340")]
		[IteratorStateMachine(typeof(GMIBHCLIPKI))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? NDFPOGIBLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool IEKDCKIDGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool AOFMGIIDPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> ONIKLMJDIJG(string ECNKEACBBKA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x82DF260", Offset = "0x82DE060", VA = "0x1882DF260")]
	[AsyncStateMachine(typeof(PKKGFMJIDLH))]
	public Task CCHDGHCOLNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x130AE30", Offset = "0x1309C30", VA = "0x18130AE30")]
	public void FMJEOCFJDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82DF3A0", Offset = "0x82DE1A0", VA = "0x1882DF3A0", Slot = "4")]
	public bool FJELAKGBJLA(Guid NMEMPCKPCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x82DF650", Offset = "0x82DE450", VA = "0x1882DF650", Slot = "5")]
	public bool GBHOMFJLIMO(Guid NMEMPCKPCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82DF1A0", Offset = "0x82DDFA0", VA = "0x1882DF1A0")]
	private bool AADKFBCPNFO(string CLIHPJHIFKB, Guid NMEMPCKPCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	protected IIBDJEOMLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MLLDGFNDOKP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AKMJMOIOOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public GACGLPEJCPJ staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AKMJMOIOOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82F1E60", Offset = "0x82F0C60", VA = "0x1882F1E60")]
		internal PFJMKELOBBL<PFIGEOEDKME> PBHDJGBJOJP((PFJMKELOBBL<FGBJJIEAJJD> GraphId, PFJMKELOBBL<OAPHEJLBOJB> NodeId) i)
		{
			return default(PFJMKELOBBL<PFIGEOEDKME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private const int NOHNAKIOKLI = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private readonly Dictionary<PFJMKELOBBL<PFIGEOEDKME>, LNCBDDCMNHA> JALEMJFGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private long FOFDDKCGLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private long PEMKLAMKEJK;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly FMPMKNPPLMC<PFIGEOEDKME, int?> JJGKMHNKHMN;

	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly long DDBIBNBCDJM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long EIFMCIJJEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82E3960", Offset = "0x82E2760", VA = "0x1882E3960")]
	public static MLLDGFNDOKP CDDKHKDHGLF(GACGLPEJCPJ OBCGBIMKDFN, MOKHKMALOIP<FGBJJIEAJJD> HBIFMJGPLID, [Optional] MLLDGFNDOKP OAADEBDFLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82E3ED0", Offset = "0x82E2CD0", VA = "0x1882E3ED0")]
	public static (long, long) CNOLMGNJLHN(GACGLPEJCPJ OBCGBIMKDFN, PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82E4370", Offset = "0x82E3170", VA = "0x1882E4370")]
	public static long GGHCLJKNEMK([In] ReadOnlySpan<PFJMKELOBBL<PFIGEOEDKME>> FNMPFDCGDBK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82E4490", Offset = "0x82E3290", VA = "0x1882E4490")]
	private static long PCGIMJGMGDC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x82F15E0", Offset = "0x82F03E0", VA = "0x1882F15E0")]
	public MLLDGFNDOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LNCBDDCMNHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long CBFEKHINNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E697D0", Offset = "0x7E685D0", VA = "0x187E697D0")]
	public LNCBDDCMNHA(long FFKCBONKOOM, long NNKOPODLKLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IKGLPDOLBIG
{
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public static readonly HashSet<OJHLNMBOBOF> EKECIEKFLCL;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NEAHIANEBGD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GMPOMPNOPOD : IEnumerable<NBHBELOMHAF>, IEnumerable, IEnumerator<NBHBELOMHAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private NBHBELOMHAF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private GIHLGICFDGM spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public GIHLGICFDGM <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private KMIGLLLIDFF spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public KMIGLLLIDFF <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private NBHBELOMHAF System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public GMPOMPNOPOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82F4690", Offset = "0x82F3490", VA = "0x1882F4690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82F4910", Offset = "0x82F3710", VA = "0x1882F4910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82F47A0", Offset = "0x82F35A0", VA = "0x1882F47A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NBHBELOMHAF> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82F47A0", Offset = "0x82F35A0", VA = "0x1882F47A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x82FB3F0", Offset = "0x82FA1F0", VA = "0x1882FB3F0")]
	public static GIHLGICFDGM ALFOOILPJIM([In] CLNIBGJHBCM APBMLFJBGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82FB260", Offset = "0x82FA060", VA = "0x1882FB260")]
	public static GIHLGICFDGM ALFOOILPJIM([In] FNNGAEDPDJE APBMLFJBGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82FB770", Offset = "0x82FA570", VA = "0x1882FB770")]
	private static HashSet<MOKHKMALOIP<MOJNABDNKON>> HCLBNHMOGCA(IReadOnlyList<NBHBELOMHAF> IFJJIKHPOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x82FBB10", Offset = "0x82FA910", VA = "0x1882FBB10")]
	private static void ILHMGKLCEEP(GIHLGICFDGM JDEGILPICDB, [In] FNNGAEDPDJE AFGKBOACJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82FCB90", Offset = "0x82FB990", VA = "0x1882FCB90")]
	public static GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI> PBJKAKKDOBH(GIHLGICFDGM JDEGILPICDB, KMIGLLLIDFF AFKEEGFIGOL, FFHBAGKHKLF? CKCGLNEMOEF, bool EAMJDLHKFFI)
	{
		return default(GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x82FB660", Offset = "0x82FA460", VA = "0x1882FB660")]
	[IteratorStateMachine(typeof(GMPOMPNOPOD))]
	private static IEnumerable<NBHBELOMHAF> EAOMAIIIBBL(GIHLGICFDGM JDEGILPICDB, KMIGLLLIDFF AFKEEGFIGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82FB5F0", Offset = "0x82FA3F0", VA = "0x1882FB5F0")]
	private static void CPKMOFJCMCF(GIHLGICFDGM JDEGILPICDB, KMIGLLLIDFF AFKEEGFIGOL, IReadOnlyCollection<ByteString>? NPPDKDFGPCH, IReadOnlyCollection<ByteString>? FPFGHPMJLPP, IReadOnlyCollection<ByteString>? NCKAIJNOEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x82FABC0", Offset = "0x82F99C0", VA = "0x1882FABC0")]
	private static bool AJCLMHNLOJC(GIHLGICFDGM JDEGILPICDB, OENCDFMFFLF CNCOHCDOKJG, KMIGLLLIDFF AFKEEGFIGOL, [Out][NotNullWhen(false)] string? DFOJBJDIKPM, [Out] Dictionary<int, int> MAPPIPLCAIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82FC170", Offset = "0x82FAF70", VA = "0x1882FC170")]
	private static Dictionary<Guid, GOKMFNHMGAG> JDAGEFDIBKC(GIHLGICFDGM JDEGILPICDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82FB560", Offset = "0x82FA360", VA = "0x1882FB560")]
	private static void CEEEKHFCMED(bool EDMOHGHIHJD, NBHBELOMHAF MLOICMPKKEC, FFHBAGKHKLF LMECDMOBOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82FC450", Offset = "0x82FB250", VA = "0x1882FC450")]
	private static void MMIFOAEKFLO(NBHBELOMHAF MLOICMPKKEC, Guid GIFNCLMKCEA, DJMOOLFALLP? OKKBLCFAHLA, Dictionary<Guid, GOKMFNHMGAG> EEONDOEDJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82FC6E0", Offset = "0x82FB4E0", VA = "0x1882FC6E0")]
	private static void NKCKIFKJPDH(IEnumerable<NBHBELOMHAF> HFNJHIAMAAM, IReadOnlyCollection<ByteString> NPPDKDFGPCH, IReadOnlyCollection<ByteString> FPFGHPMJLPP, IReadOnlyCollection<ByteString> NCKAIJNOEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KMIGLLLIDFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public bool EDMOHGHIHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public GLNKMMNDKID FGIBJLKFCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public DJMOOLFALLP? OKKBLCFAHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public DJMOOLFALLP? GNJMELFAMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	public GACGLPEJCPJ MLJDHIIFBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public CLGMCFCMNHJ ILABFMFAFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public BAKDOIHHHIN FDMHINMCFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public MOKHKMALOIP<FGBJJIEAJJD> LJBCFMLIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public KOGKHPBLEAO DJKDJBCOAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	public List<NBHBELOMHAF> MHKPEFMHGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	public BFDLJFNDJKD IDMGOALPCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public GKOAJCLIKAL JIMICGNCPDJ;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DJMOOLFALLP
{
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private const float CNIMAIOFGGD = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public Vector3 FLAPAOJCDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	public Quaternion GKEKGHNHKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public float KBAEKIALOKB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 PJJJADABCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82F23F0", Offset = "0x82F11F0", VA = "0x1882F23F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS DICPBFBAJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82F24F0", Offset = "0x82F12F0", VA = "0x1882F24F0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x165A770", Offset = "0x1659570", VA = "0x18165A770")]
	public DJMOOLFALLP(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float KBAEKIALOKB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82F2A60", Offset = "0x82F1860", VA = "0x1882F2A60")]
	public DJMOOLFALLP(UniformTRS CJBCJKBBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82F2530", Offset = "0x82F1330", VA = "0x1882F2530")]
	public static DJMOOLFALLP OEGICKHCBGM(DJMOOLFALLP PJGOIMBEKPK, DJMOOLFALLP DEAOKHMGAPI)
	{
		return default(DJMOOLFALLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82F2270", Offset = "0x82F1070", VA = "0x1882F2270")]
	public static DJMOOLFALLP MIDAFINGFAP((Vector3, Quaternion, float) KANAIIDGHCH)
	{
		return default(DJMOOLFALLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x82F2290", Offset = "0x82F1090", VA = "0x1882F2290")]
	public static DJMOOLFALLP MIDAFINGFAP(Matrix4x4 FBFHKGMBACD)
	{
		return default(DJMOOLFALLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82F29D0", Offset = "0x82F17D0", VA = "0x1882F29D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x82F27B0", Offset = "0x82F15B0", VA = "0x1882F27B0")]
	public DJMOOLFALLP PLBLBKDJMBK(Matrix4x4 DNNOOFELIOA)
	{
		return default(DJMOOLFALLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82F2170", Offset = "0x82F0F70", VA = "0x1882F2170")]
	public static DJMOOLFALLP DCFINJCAFCP(Vector3 FLAPAOJCDCM)
	{
		return default(DJMOOLFALLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x82F21E0", Offset = "0x82F0FE0", VA = "0x1882F21E0")]
	public readonly JEBMEJLOIBJ FBEFBJIIDHM()
	{
		return default(JEBMEJLOIBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum PFEIIFADHID
{
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct HOOMINFIIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly HCNPOABEHDP OIOHOMADGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private readonly FHNKPFADLOA GIFICCIBEKO;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1942DD0", Offset = "0x1941BD0", VA = "0x181942DD0")]
	private HOOMINFIIDI(HCNPOABEHDP PFAGOGPEPDI, FHNKPFADLOA HLIDNHALMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82F4B10", Offset = "0x82F3910", VA = "0x1882F4B10")]
	public AJOABFOKHHA DIEBODNEMLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82F4C40", Offset = "0x82F3A40", VA = "0x1882F4C40")]
	public static GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI> ELDPFIHNJDG(ENGOFMNMOBM<GFJAPJIFDGB> HLIDNHALMPD)
	{
		return default(GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x82F4CF0", Offset = "0x82F3AF0", VA = "0x1882F4CF0")]
	public static GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI> ELDPFIHNJDG(AJOABFOKHHA HLIDNHALMPD)
	{
		return default(GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82F4B80", Offset = "0x82F3980", VA = "0x1882F4B80")]
	public static GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI> ELDPFIHNJDG(string LLCJFAKNMDL)
	{
		return default(GECIHKBMECG<FFHBAGKHKLF, HOOMINFIIDI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HCNPOABEHDP
{
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KBPEENCHKLN : IDisposable, FKOGGCMOAEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private NativeList<BPLOOPPGBOJ> NNLFKKEKIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private float DPCBKECJIFP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HACLILBGPLE LJIBBLJOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(HACLILBGPLE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ELLEPJFIJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71BB8E0", Offset = "0x71BA6E0", VA = "0x1871BB8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PONIMOPDDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71BB8F0", Offset = "0x71BA6F0", VA = "0x1871BB8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<NAKCKBMAIPG> HMBJFHOBHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DHHCGIIAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82F8180", Offset = "0x82F6F80", VA = "0x1882F8180", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float MDFMCMFAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82F74E0", Offset = "0x82F62E0", VA = "0x1882F74E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x82F9360", Offset = "0x82F8160", VA = "0x1882F9360")]
	public KBPEENCHKLN(HACLILBGPLE AEDIGFLCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82F7320", Offset = "0x82F6120", VA = "0x1882F7320", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x82F6D00", Offset = "0x82F5B00", VA = "0x1882F6D00")]
	public Vector3 DDGKPGILECO(int ENMBFMACLBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82F6BD0", Offset = "0x82F59D0", VA = "0x1882F6BD0", Slot = "6")]
	public Quaternion BIACCLOOCPB(int ENMBFMACLBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82F8290", Offset = "0x82F7090", VA = "0x1882F8290", Slot = "5")]
	public Vector3 NOCDEKHCDBD(int ENMBFMACLBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x82F8120", Offset = "0x82F6F20", VA = "0x1882F8120", Slot = "7")]
	public float LMOCCLDMNMH(int ENMBFMACLBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x82F85F0", Offset = "0x82F73F0", VA = "0x1882F85F0")]
	public void PHKAOBJOLHB(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL, bool GMFFMGHMBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x82F8230", Offset = "0x82F7030", VA = "0x1882F8230")]
	private bool NIPELHJJOMG(int GDJEEFAOONE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82F8330", Offset = "0x82F7130", VA = "0x1882F8330")]
	public void OHFOMDGAJHI(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82F7380", Offset = "0x82F6180", VA = "0x1882F7380")]
	public void EJFLDEDLDOK(int GDJEEFAOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82F71D0", Offset = "0x82F5FD0", VA = "0x1882F71D0")]
	public void DKICLDFCHAB(int GDJEEFAOONE, Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82F7E20", Offset = "0x82F6C20", VA = "0x1882F7E20")]
	public void IFFGJMGNEBP(int GDJEEFAOONE, float3 FLAPAOJCDCM, quaternion GKEKGHNHKDP, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x82F7FD0", Offset = "0x82F6DD0", VA = "0x1882F7FD0")]
	public void JMGAGPKGDJL(int GDJEEFAOONE, Vector3 FLAPAOJCDCM, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x82F8490", Offset = "0x82F7290", VA = "0x1882F8490")]
	public void OLPIKHFMJDF(int GDJEEFAOONE, Vector3 INIBGDOOLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82F7620", Offset = "0x82F6420", VA = "0x1882F7620")]
	public static Quaternion GBHAEMHCCND(Quaternion MIKLOIFFBNA, int GDJEEFAOONE, float GMIPPAHJEPJ, FKOGGCMOAEH LNCBLGCJBKL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x82F8ED0", Offset = "0x82F7CD0", VA = "0x1882F8ED0")]
	public Bounds PMNAMPAAIOF(Transform DNNOOFELIOA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82F81C0", Offset = "0x82F6FC0", VA = "0x1882F81C0", Slot = "10")]
	public virtual void MCJOKCDIGJO(bool JCFMPJEDBGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82F7410", Offset = "0x82F6210", VA = "0x1882F7410")]
	public NativeList<BPLOOPPGBOJ> EJLPILLMCBB(float HMCLNEMGELD = 1f)
	{
		return default(NativeList<BPLOOPPGBOJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NAKCKBMAIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public float3 FEDKKAIHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public float OMNLGPDGNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public quaternion MKHLALIBFED;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82FA790", Offset = "0x82F9590", VA = "0x1882FA790")]
	public NAKCKBMAIPG(Vector3 EEIHHMMODIJ, Quaternion MIKLOIFFBNA, float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x82FA240", Offset = "0x82F9040", VA = "0x1882FA240")]
	public Quaternion DIHCCLFHGAD(Vector3 GHKIAFFJCCO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82FA300", Offset = "0x82F9100", VA = "0x1882FA300")]
	public NAKCKBMAIPG NMPJMDJELAG(Vector3 DCIKMHCLBOJ, Vector3 MBIMPGGLAOF, Vector3 DHNAPPDKADC)
	{
		return default(NAKCKBMAIPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x82FA5F0", Offset = "0x82F93F0", VA = "0x1882FA5F0")]
	public FAKMMMCHIFJ ODKFBOACELE(Vector3 GHKIAFFJCCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MDMGNKLKPCM : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82FA030", Offset = "0x82F8E30", VA = "0x1882FA030", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82F9770", Offset = "0x82F8570", VA = "0x1882F9770")]
	private void LENHCPMANKB(Dictionary<Guid, Guid> JNEOLPPJECF, NEEMLHNLMDP EFOMDOBIJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x82F9FD0", Offset = "0x82F8DD0", VA = "0x1882F9FD0")]
	private void LENHCPMANKB(Dictionary<Guid, Guid> JNEOLPPJECF, NABCJFCDABG EMMAJNKPHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x82F9D50", Offset = "0x82F8B50", VA = "0x1882F9D50")]
	private void LENHCPMANKB(Dictionary<Guid, Guid> JNEOLPPJECF, JCLKLOJMENA PNADBMINGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MDMGNKLKPCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class NHOCFAMANLE : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x82FE0E0", Offset = "0x82FCEE0", VA = "0x1882FE0E0", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NHOCFAMANLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LCJAECFPBKM : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x82F9610", Offset = "0x82F8410", VA = "0x1882F9610", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public LCJAECFPBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JINCHPNEJPD : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x82F6A70", Offset = "0x82F5870", VA = "0x1882F6A70", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public JINCHPNEJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KMJCNIANMCK : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x82F93F0", Offset = "0x82F81F0", VA = "0x1882F93F0", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KMJCNIANMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GAICFONGBMI : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x82F3390", Offset = "0x82F2190", VA = "0x1882F3390", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GAICFONGBMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MIEEJFCAKFM : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x82FA0B0", Offset = "0x82F8EB0", VA = "0x1882FA0B0", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MIEEJFCAKFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class NPKLKNOKPAA : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82FE190", Offset = "0x82FCF90", VA = "0x1882FE190", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public NPKLKNOKPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class GPCOLAECEGD : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x82F4960", Offset = "0x82F3760", VA = "0x1882F4960", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GPCOLAECEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class FMKLPGDIPCE : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82F31E0", Offset = "0x82F1FE0", VA = "0x1882F31E0", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FMKLPGDIPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class OKNJJHPPHJO : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8302E80", Offset = "0x8301C80", VA = "0x188302E80", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OKNJJHPPHJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class EPFDDKNJHPF : CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public static readonly OCDMPKNGAAI MFJPLMHMCLF;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82F2ED0", Offset = "0x82F1CD0", VA = "0x1882F2ED0", Slot = "4")]
	public void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EPFDDKNJHPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BLJOALEIKJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	public OENCDFMFFLF HNEGIKALKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	public KGNLCKIHNBM JDEDIKDLLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	public Dictionary<int, int> FMMGEGMCHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	public Dictionary<Guid, Guid> BFBNOOPGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	public GKOAJCLIKAL JIMICGNCPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	public bool EAMJDLHKFFI;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CMBAIGINNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCIEOAHFEDD(AMPEGFHFHEC OKNPADBCHFP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ICFDBCPIPIE
{
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private static readonly CMBAIGINNMP[] DMFPOFGBGGI;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82F5040", Offset = "0x82F3E40", VA = "0x1882F5040")]
	public static void FHOEJNOJPPB(NBHBELOMHAF KANAIIDGHCH, FFHBAGKHKLF PNECBANKHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x82F4DA0", Offset = "0x82F3BA0", VA = "0x1882F4DA0")]
	public static void EIJCIOPJGPG(NBHBELOMHAF? KANAIIDGHCH, FFHBAGKHKLF HJBHEBMMPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x82F5690", Offset = "0x82F4490", VA = "0x1882F5690")]
	public static void OPHCFEDJELA(NBHBELOMHAF? KANAIIDGHCH, FFHBAGKHKLF LMECDMOBOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x82F52C0", Offset = "0x82F40C0", VA = "0x1882F52C0")]
	public static void HIPDCOOBHLL(AMPEGFHFHEC OKNPADBCHFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct AMPEGFHFHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public OENCDFMFFLF MJEPOGFPEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public NBHBELOMHAF MLOICMPKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	public Dictionary<int, int> FMMGEGMCHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	public Dictionary<Guid, Guid> BFBNOOPGOFM;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x82F1F30", Offset = "0x82F0D30", VA = "0x1882F1F30")]
	public Guid DDALIMIHLHH(Guid NMEMPCKPCOG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GKOAJCLIKAL
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FNFDIECIKMG, [Out] Guid GCIMMDJPDEH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class OIKODFOEFPF
{
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	private static readonly HashSet<Guid> PPGEJCGKEHK;

	[Cpp2IlInjected.Token(Token = "0x4000575")]
	private static readonly HashSet<Guid> OOGIFCAABAJ;

	[Cpp2IlInjected.Token(Token = "0x4000576")]
	private static readonly HashSet<Guid> IDDAFDFEEME;

	[Cpp2IlInjected.Token(Token = "0x4000577")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.Token(Token = "0x4000578")]
	private static readonly ProfilerMarker CHFDGPPMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000579")]
	private readonly HashSet<string> CIFKKJPMMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057A")]
	private readonly Dictionary<long, int> DAKCMPFFPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private readonly HashSet<Guid> ICDCEDKDDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private readonly HashSet<Guid> FGJFCAOLNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private readonly HashSet<Guid> NGPMAHCGJGA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> BJGNEEJCMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyCollection<Guid> OFLHKKCCCPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<Guid> DNNFMLKCOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IReadOnlyDictionary<long, int> PJIHNEPPDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8301BB0", Offset = "0x83009B0", VA = "0x188301BB0")]
	public static void ICHLENBKDJA(GIHLGICFDGM LHPNCPNMIAI, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82FE510", Offset = "0x82FD310", VA = "0x1882FE510")]
	public static OIKODFOEFPF DKFKDNGFEGO(GJJFFFDCKLI OEACCCPPJMI, ECLDCOKKIMI? CPJBKAJGBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82FE490", Offset = "0x82FD290", VA = "0x1882FE490")]
	public static OIKODFOEFPF CNEBLFAMPJI(GIHLGICFDGM MHAPIKBBKCL, ECLDCOKKIMI? CPJBKAJGBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8300960", Offset = "0x82FF760", VA = "0x188300960")]
	public static OIKODFOEFPF HGNCJHBJJMB(PIMEBDABBBF MEOKJFEHCHJ, NGBGKOOFIPP ALJPELHALEH, ECLDCOKKIMI? CPJBKAJGBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82FE280", Offset = "0x82FD080", VA = "0x1882FE280")]
	public static OIKODFOEFPF AHDGOMMDAKF(IEnumerable<string> CIFKKJPMMPM, IReadOnlyDictionary<long, int> HNLMADDCNIG, IReadOnlyCollection<Guid> NGPMAHCGJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8302CF0", Offset = "0x8301AF0", VA = "0x188302CF0")]
	private OIKODFOEFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8302AF0", Offset = "0x83018F0", VA = "0x188302AF0")]
	private OIKODFOEFPF(IEnumerable<string> CIFKKJPMMPM, IReadOnlyDictionary<long, int> HNLMADDCNIG, IReadOnlyCollection<Guid> NGPMAHCGJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82FFCB0", Offset = "0x82FEAB0", VA = "0x1882FFCB0")]
	private void HAACICOAOBG(GJJFFFDCKLI OEACCCPPJMI, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x83002D0", Offset = "0x82FF0D0", VA = "0x1883002D0")]
	private void HAACICOAOBG(GIHLGICFDGM MHAPIKBBKCL, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82FEA40", Offset = "0x82FD840", VA = "0x1882FEA40")]
	private void GKHBIGMEMLJ(ByteString? CCFGNDPBIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82FF070", Offset = "0x82FDE70", VA = "0x1882FF070")]
	private void HAACICOAOBG(PIMEBDABBBF? MMENCBNBOBJ, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82FFA50", Offset = "0x82FE850", VA = "0x1882FFA50")]
	private void HAACICOAOBG(NGBGKOOFIPP? ALJPELHALEH, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82FFAD0", Offset = "0x82FE8D0", VA = "0x1882FFAD0")]
	private void HAACICOAOBG(CIDAONDIKBG? JHPKFMLEBCI, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82FE840", Offset = "0x82FD640", VA = "0x1882FE840")]
	private static bool FPAGDKPCPHC(CIDAONDIKBG JHPKFMLEBCI, int PACDDEBLPPI, [Out] string? CFCPJBIBCAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82FE600", Offset = "0x82FD400", VA = "0x1882FE600")]
	private static bool EEEOJCOMFAC(CIDAONDIKBG JHPKFMLEBCI, int PACDDEBLPPI, [Out] Guid NOOFELOCAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8301AE0", Offset = "0x83008E0", VA = "0x188301AE0")]
	private static void ICHLENBKDJA(NGBGKOOFIPP? MMENCBNBOBJ, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8301850", Offset = "0x8300650", VA = "0x188301850")]
	private static void ICHLENBKDJA(CIDAONDIKBG? JHPKFMLEBCI, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8301070", Offset = "0x82FFE70", VA = "0x188301070")]
	private static void ICHLENBKDJA(PIMEBDABBBF? MMENCBNBOBJ, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8300A20", Offset = "0x82FF820", VA = "0x188300A20")]
	private static void ICHLENBKDJA(IBCNDKHKHKE? DFHOHFFNCIJ, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82FFF50", Offset = "0x82FED50", VA = "0x1882FFF50")]
	private void HAACICOAOBG(IBCNDKHKHKE? DFHOHFFNCIJ, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83025B0", Offset = "0x83013B0", VA = "0x1883025B0")]
	private void JGPCKOEJHMO(Guid? NMEMPCKPCOG, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8300560", Offset = "0x82FF360", VA = "0x188300560")]
	private void HAACICOAOBG(NBHBELOMHAF? MLOICMPKKEC, ECLDCOKKIMI? CPJBKAJGBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8301410", Offset = "0x8300210", VA = "0x188301410")]
	private static void ICHLENBKDJA(NBHBELOMHAF? MLOICMPKKEC, ECLDCOKKIMI CPJBKAJGBMB, FFHBAGKHKLF NDHHMKJEHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82FE590", Offset = "0x82FD390", VA = "0x1882FE590")]
	private void EDDDCAFHGFJ(string? DHHHMLLMOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82FE310", Offset = "0x82FD110", VA = "0x1882FE310")]
	private void ALBLNOOLOFI(long FGABFPCMAHA, Guid FPIFCBCKHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x82FE440", Offset = "0x82FD240", VA = "0x1882FE440")]
	private void ALBLNOOLOFI(EIDJMKBFCKP? LPNFBOFPCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x82FE3E0", Offset = "0x82FD1E0", VA = "0x1882FE3E0")]
	private void ALBLNOOLOFI(CGBLBCBLIOJ? LPNFBOFPCOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct GENGCNKFAHK
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class NDLNLCDCEFI : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private readonly IEnumerator<DictionaryEntry> IFLDEFEGGME;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public DictionaryEntry DAEDDNECOGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x82FA990", Offset = "0x82F9790", VA = "0x1882FA990", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object DIHMBOJAPGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x82FAA60", Offset = "0x82F9860", VA = "0x1882FAA60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public object DDHBFJGPDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x82FAB10", Offset = "0x82F9910", VA = "0x1882FAB10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public object BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x82FA8B0", Offset = "0x82F96B0", VA = "0x1882FA8B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
		public NDLNLCDCEFI(IEnumerator<DictionaryEntry> IFLDEFEGGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x82FA810", Offset = "0x82F9610", VA = "0x1882FA810", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x82FA860", Offset = "0x82F9660", VA = "0x1882FA860", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class CEFEDBNEJKF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x82F2120", Offset = "0x82F0F20", VA = "0x1882F2120", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public CEFEDBNEJKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x82F1FD0", Offset = "0x82F0DD0", VA = "0x1882F1FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x82F20D0", Offset = "0x82F0ED0", VA = "0x1882F20D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8303550", Offset = "0x8302350", VA = "0x188303550", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object OPGJHIOADCK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8303460", Offset = "0x8302260", VA = "0x188303460", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8303630", Offset = "0x8302430", VA = "0x188303630", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x83033A0", Offset = "0x83021A0", VA = "0x1883033A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8303400", Offset = "0x8302200", VA = "0x188303400", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x83035D0", Offset = "0x83023D0", VA = "0x1883035D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8303060", Offset = "0x8301E60", VA = "0x188303060", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x83030C0", Offset = "0x8301EC0", VA = "0x1883030C0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8303120", Offset = "0x8301F20", VA = "0x188303120", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public RoomObjectCounts(Dictionary<int, int> LKPMFPAPNFO, [Optional] Dictionary<int, int> CGLFBJLBLLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8302F80", Offset = "0x8301D80", VA = "0x188302F80")]
		[IteratorStateMachine(typeof(CEFEDBNEJKF))]
		private IEnumerator<DictionaryEntry> DCOHBKNKEBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8303680", Offset = "0x8302480", VA = "0x188303680", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83032A0", Offset = "0x83020A0", VA = "0x1883032A0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8303180", Offset = "0x8301F80", VA = "0x188303180", Slot = "9")]
		void IDictionary.Add(object OPGJHIOADCK, object HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83031E0", Offset = "0x8301FE0", VA = "0x1883031E0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8303240", Offset = "0x8302040", VA = "0x188303240", Slot = "8")]
		bool IDictionary.Contains(object OPGJHIOADCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8303340", Offset = "0x8302140", VA = "0x188303340", Slot = "14")]
		void IDictionary.Remove(object OPGJHIOADCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8303000", Offset = "0x8301E00", VA = "0x188303000", Slot = "15")]
		void ICollection.CopyTo(Array ELLFIONNNHC, int JJJJBEGKNIN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class FLMBNAHDMIG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x82F3190", Offset = "0x82F1F90", VA = "0x1882F3190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public FLMBNAHDMIG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x82F3000", Offset = "0x82F1E00", VA = "0x1882F3000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x82F3140", Offset = "0x82F1F40", VA = "0x1882F3140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x82F6730", Offset = "0x82F5530", VA = "0x1882F6730", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		object IDictionary.this[object OPGJHIOADCK]
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x82F6600", Offset = "0x82F5400", VA = "0x1882F6600", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x82F67E0", Offset = "0x82F55E0", VA = "0x1882F67E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x82F6540", Offset = "0x82F5340", VA = "0x1882F6540", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x82F65A0", Offset = "0x82F53A0", VA = "0x1882F65A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x82F6780", Offset = "0x82F5580", VA = "0x1882F6780", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x82F61C0", Offset = "0x82F4FC0", VA = "0x1882F61C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x82F6220", Offset = "0x82F5020", VA = "0x1882F6220", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x82F6280", Offset = "0x82F5080", VA = "0x1882F6280", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA390", Offset = "0x2AB9190", VA = "0x182ABA390")]
		public Invention(long FMFDAFLDAAK, int FFKCBONKOOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x82F60F0", Offset = "0x82F4EF0", VA = "0x1882F60F0")]
		[IteratorStateMachine(typeof(FLMBNAHDMIG))]
		private IEnumerator<DictionaryEntry> DCOHBKNKEBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x82F6830", Offset = "0x82F5630", VA = "0x1882F6830", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x82F6400", Offset = "0x82F5200", VA = "0x1882F6400", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x82F62E0", Offset = "0x82F50E0", VA = "0x1882F62E0", Slot = "9")]
		void IDictionary.Add(object OPGJHIOADCK, object HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x82F6340", Offset = "0x82F5140", VA = "0x1882F6340", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82F63A0", Offset = "0x82F51A0", VA = "0x1882F63A0", Slot = "8")]
		bool IDictionary.Contains(object OPGJHIOADCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x82F64E0", Offset = "0x82F52E0", VA = "0x1882F64E0", Slot = "14")]
		void IDictionary.Remove(object OPGJHIOADCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82F6160", Offset = "0x82F4F60", VA = "0x1882F6160", Slot = "15")]
		void ICollection.CopyTo(Array ELLFIONNNHC, int JJJJBEGKNIN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> MPPBEMNDIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	public readonly IReadOnlyList<Invention> IHHHAAJCPAI;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	public GENGCNKFAHK(IReadOnlyDictionary<Guid, RoomObjectCounts> PPCIMFDKHFL, IReadOnlyList<Invention> PIECPHFPFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x82F34D0", Offset = "0x82F22D0", VA = "0x1882F34D0")]
	public static GENGCNKFAHK DKFKDNGFEGO(GJJFFFDCKLI OEACCCPPJMI)
	{
		return default(GENGCNKFAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82F4570", Offset = "0x82F3370", VA = "0x1882F4570")]
	[CompilerGenerated]
	internal static int KGLKMHFAFGJ([In] IReadOnlyDictionary<long, int> NPGEBGAFLFK, long? FGABFPCMAHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82F3EB0", Offset = "0x82F2CB0", VA = "0x1882F3EB0")]
	[CompilerGenerated]
	internal static void JPOLFFEGBMM(int EGAIGKGPDOH, [In] PIMEBDABBBF IJDKLGEHBLE, [In] Dictionary<long, int> NPGEBGAFLFK, [In] Dictionary<Guid, RoomObjectCounts> PPCIMFDKHFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum DNCCPNAJGCH
{
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class ECLDCOKKIMI
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class JEEPNEEAPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public readonly Guid EJDIBFPKOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public readonly IReadOnlyList<Guid> OFLHKKCCCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public readonly DNCCPNAJGCH OIOHOMADGKP;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x82F6A10", Offset = "0x82F5810", VA = "0x1882F6A10")]
		public JEEPNEEAPFC(Guid KBIMFOALPIJ, IReadOnlyList<Guid> NGPMAHCGJGA, DNCCPNAJGCH PFAGOGPEPDI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private readonly FFHBAGKHKLF HKKCGBKAKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private readonly Dictionary<Guid, JEEPNEEAPFC> OIPOOOFCIAG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FFHBAGKHKLF MBLOPGBOJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x82F2B30", Offset = "0x82F1930", VA = "0x1882F2B30")]
	public void DPHJBDIDPOG(Guid CMKEDLJBGOL, Guid LPCMIGGOKAO, IReadOnlyList<Guid> POLLLJJFBHL, DNCCPNAJGCH PFAGOGPEPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x82F2D40", Offset = "0x82F1B40", VA = "0x1882F2D40")]
	public bool PGIAIFOINFP(Guid ELHAIHNOIOH, [Out] JEEPNEEAPFC HIJPKJDNJCE, [Out] bool AOCANHPBODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x82F2E30", Offset = "0x82F1C30", VA = "0x1882F2E30")]
	public ECLDCOKKIMI()
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
