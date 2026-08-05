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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6CD52A0", Offset = "0x6CD46A0", VA = "0x186CD52A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LBOIGAELIIN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> ODLKMADPFPA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> EBNBANJDEKP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> MENJAFJHHOC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> CHABMLKJDLO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BNMLJOCBKNL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JAKMDCJHMHE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string IFDPNBHAFLA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CD4140", Offset = "0x6CD3540", VA = "0x186CD4140")]
	public static bool PLNKJMBJHFM(Guid LMDBKCMNFLF, int APILKBKIPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6CD40B0", Offset = "0x6CD34B0", VA = "0x186CD40B0")]
	public static bool KNILFKICFEP(Guid LMDBKCMNFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CD39E0", Offset = "0x6CD2DE0", VA = "0x186CD39E0")]
	public static string AIGNFKJPODN(Guid MDOJFEIEAFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PNEOGNEDIHM]
public enum OIPOBLFDFGI
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
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5210", Offset = "0x6CD4610", VA = "0x186CD5210", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ENHEFJMEHII
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid FMHMALOCCFC;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid OLMJHJNLDOI;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid INFLFDPHMFB;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid POLAIOCMPGA;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid EEBLKMNLNCF;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid DKIGHCMEFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid LCBPGBOEDJL;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid OJHMALIIBJF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid AEEHAEDMKPK;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid CGMIPNGFPLH;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid PBGALOFBLOB;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid DLBBPJPMHFD;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid KMILIOMOJPP;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid JGMKLKLLOHD;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid KMHAMKDBIEN;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid FINMHIMMMBN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid BDCGPBLOAGH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid EIJMMJGMBIB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid BECFLKHNABG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid DHBMALLMDJD;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid KCJPJKBJMIL;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid EOLKBBPDBKN;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid FBMJHNAMJIL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PFKEAMKFEDH;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid OBNDFPKIGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid EBJJBKKIFPC;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid JOLMIDFOMJH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid KJMOAFNCKIF;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid KFIBPDCCDPA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid AOPJGIBBFOJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DDKFCCBOOLJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid MAFGJIBDKHA;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MPPFNHCACGB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid BGOJCGJPPGL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid HEDKBEINAOM;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid OOIOOAILNDP;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OBJMEAOIKGL;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid GOPABIILCNJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid JGKJOFJJNIN;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HDAKPOAHHGH;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid DKPLGEIDEGK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DKHNBMPKLKE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid HLCEFACGDAE;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid JJJOMANPNAG;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid MLFOLHEAEKA;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid LFMOOFJAEJE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid FPELMIGNOKD;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid NEPOOOBBCLE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CBCOFMGLEOL;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid MGMIAMCFDCM;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid ONBJLIGKGFJ;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid AKNGPONFFBE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid NEENHJAFHEI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BIFBLELFBGJ;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid GJACKPKLHOC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid PFDGGJKEGKE;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid JFGNOPFMLLC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid HGLBHMMFKBI;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid OFJILAKGLNI;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid FOAHFBDLJMJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid PCHJLDKIJPJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid CKDKFLMOPIN;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid HFJFJLCCCHJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GPALDCLFFKF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid OLHNCMAJDFK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid EPBPDIJJKAJ;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid BOGHBAGAAFF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid KMBFEDCOLGH;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid BBAEEDLDGGK;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid PGKMAGBFGIF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid BCANLCJMPJP;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid JLFBAMNGDGG;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid BMAJJJKOEMC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PFFPNNKLIGE;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid IDOKEMOJFOG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid AAJCECBBMKE;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid OKHIEDKIHEL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid CNDAAEMBANC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid LEPLCBBBNII;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid CDJIAKCBOKK;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid PCFJPCKIDOO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid MPHONFPAHIK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid AEIPBJADDPK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid ALDOMINHKAG;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KOANMIJDFOD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid DBNCDMJJBJA;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BICFPPJIHAF;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid HPKFEMJEJGA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid CFHENGKNMNJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid FGDGIHONBBI;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid DGCEHFJOAID;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GJJNDGHKCAH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid OHEKIIJJKBC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LBLMKOKMHCN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid EKMIEIMOMIE;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid DFEGJPPIKML;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid ABGCHKHGGOF;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid OEKCPEGGALO;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid LBBJJCLOLLD;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid HCLNDKLIHNH;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid DMDBEPIEFMK;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid LBGJEDODBDF;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid OOALHNPKBBF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid CBPPMFCKOLL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BIKCBJKKABN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid IDIGMMFEACO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid ADCGKMHFJMC;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid GPEDLIGNIHE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid GDJPGFHJPJC;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid CPNPGGELFKP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid MMNHLIEEPAN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JKBPFGKCOAC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid DNIFABAGEKE;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid MOKLIFNMHEH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid LFBECOOHBHP;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid IKFGPCCHJPP;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid MIIGIPOIEDL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid OCCLKGPNBLO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid JDGPAEFGEAO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid FBLJAIPKOCN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid HHIFCEFDIPG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OLJOKILIFKG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid IKFIEJKAMMH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid KLEOOMJMEOI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LLLKCKOGAAC;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid POPPLLGOAJL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid LEMAACAHBBO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HFHPBLGBAFA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid BLNNFJBEFJG;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KLONGBDFCMM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid HFBEDOANLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid PNNGBCBJIMC;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LGLPKGHGCLM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JMOKLJDJOPP;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid OFHBPGPFKGL;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid BCDDFCMHEEF;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid FKKAPNJDLMH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid APEJJMIGKKP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BHMEPBBEGDH;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NPBADGKHKDL;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid PGHINDOCPKI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid IEGMMMNCGMC;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid MNFBKOODINB;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DAEFJIGLJKL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MGDPMCKBJNF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid OHBJCKCMBAO;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ALILBNNABLL;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DFHABPNHICM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BGFCNPNFGNH;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JFKBOKNDBIP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid JLKAGBBCBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KILLBJOIEIN;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NKKNHEDCAKK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid INJELFBBLPL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MHPNIEKJNKP;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KNCICIKBKFI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid HKIJAIFCJBG;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JIBLADHGDFI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid IAPOCGOAHMJ;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CGLKGHCIKLH;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HIEAAHNEPAJ;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid HFHJHMCOGFK;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid BDOBJFAFAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OFLOPAAOFGB;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FOOBLJFEACM;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GNALJBLAFBI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid MKEALNBDDPG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JLHFDCIOPBM;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid GPPKLKPOOJG;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid ALALNKLBACI;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid IBLGPCMMABH;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid ANPKGGMLAKO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid GEEGCCEDEEK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FPDCOEHEHGP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MKPKAIAHEBK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GBLPIMPJKFJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid MDLAGLMPNIA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BHOHCANFKJK;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GPOOBEKCBHP;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PNOFGCABOGH;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid KBAHCFJDGIO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid NOMGEPEELGH;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NGKECEMFFFH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid AOIGCBEFMKI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid MIFGMNNLEPP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid OKJIIPMCABL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OAIKHACCLMA;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NFPOLAJGMCI;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid GHKAOFNCPGB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid IDFANCPBNJC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid IJKIMOGKKAH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid OLJFDMINLJC;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid KDFIMKIDCOM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid EOGNMAJMNDH;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid HFLDFELBHCP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid MGNNOCCCKPD;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid HEFJCBCEFHI;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DIOKHDOOIOO;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid FCONOELIGFH;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DOPJJHMIGOO;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid MHBEABINPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid POAOCEBOPPE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid HEOAFMIGMGB;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AOFKCBIKLBK;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid DOJFJFANNAA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid NAABCEEJFDO;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid OKBFCNHALJH;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JLJKLHDDDCC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid ANHEOOMJNGE;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid OEIOGHKEDFA;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CEAMOCJKOIK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid NDLBHLLKIDB;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid ADGHPBIOPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CIOJELOGBKA;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CIOFNCGIEME;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid DFHKJNGMDAB;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid GBPMOOCGENO;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JNNPAGHLNML;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid OMKJMGMDBEL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid KJDIIJJGOIE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid FEHDFLGAMFB;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid EHEKAHIMFGJ;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid GABGDICCIPO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KGNGBDJCPGD;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OBELPJJDGEN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid EPDOANBJMLH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid BPMJNEDOHPP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid NECCODOMOHP;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GLNCALKPCHP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HENKGLFNLBN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JIEHNGNMDLK;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid IDBGDNPOFIC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid KGMNCEBECDD;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid CMOKADLBAJL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NOFECIPBONF;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CFAIBCHCLGH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HIELLLCDAJA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid IMIHBPOPGKK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FJAPEBMJHBL;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CEPLPHODIFH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NBDNIBALELH;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MBCHHEMENDL;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid NEAGMDMKJPE;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FOILDKEKHOM;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CNKDLCMIDDP;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BNBJNBBPFFD;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid BFEHBFBHAEL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid EBBGJBDAADB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MFPCKDBNEDA;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CFLBKEALMBF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid JNKNGHJNIKL;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid BOFNNJJAOOL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid MHBBFNJBOKC;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GEGKHDKINAG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid KCHCNIMBBJN;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OKOHNBDNKNL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid DOMEFHLPLLH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BOININKGNOP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid DPPGKOCNMEI;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid HICLPBOOCME;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid APEEMBPOGHO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid KJKBOMKCBNC;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid KEKMFOMDCMO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AEMDLBPOGJI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid EENOHDGFNBL;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid IOHHLHJOICI;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HAGJAEOBJMN;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid HJJDNPJCKJA;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid JOJJIBCKIAJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid KEJGBFLMFPO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid GMIDLCGFJCF;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid DGJKLIIPOMF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MADAIBJMKPH;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid KGOOOPPKLHI;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid FCPFGFAIDNG;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid BMBJDHNFBHO;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid NDPEGEJOGNG;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid AANLOHAFODF;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LANGIBHLEGE;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid PPGGGJGODFJ;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid OBJAMOOHNCE;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KCLCIAACGLE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid KNOLMFCCPND;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid CLIBGKCKJJM;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid FENOOBDNJLH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid EAGAFNFCGMB;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid BODFDFCJGDC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid AAFPFOMOJGO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CIFLDKENGLG;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PALNDAJIDPH;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid HGLIAAHHMNO;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid AJBFJCLAEFA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid LDBCKHJHGFB;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MKBCNPJBCKA;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CFCLGJIHEBE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HPBNANJNJJA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid PFDBBEFOCEH;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid AODDPPMCDGJ;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NOBPGOCPLLC;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NLLLENGPPPM;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid BGPBEFJHONP;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid JJDEJJNKJCJ;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JGLJEIMCEIH;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid HDFAMIKJKAP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid PPMHNMDENIJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid CJIHMKJGHJJ;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PLBIFCDKHOG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid GEPGOLAHLFD;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NPIPDMLCKBI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid HMLDAPJKKKB;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LDIJKNOHLHC;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid FBEAFNFGGFM;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LHIBHMKCANH;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DHAHMEKFAPC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CKJBLOIDBNK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GBJAOPNAMCB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid INHABIKJAMB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid CGANPIJLLGM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid OMJOEPNBCBA;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid IEPMPICAJJD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid PFJGOAKFKGI;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid KMFAOMKKAAN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid INCCFDHDONI;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid IPDCCALHKHG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid HFFFMCNCNPO;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LPOBHHAPAPL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid PHEMKODHNDD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid IIHNFNMHABA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KKJPIDNLNPE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid PGOPGHOJFGK;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MIDGNIBFHNJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid IEMLFDCPOCM;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid HMAGEHOGJKF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid CKFGHOPAIGJ;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid FEJPPOHAMOG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LLCHDNFBEDK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid HELKAEBIBBL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LPPAKDHGGAH;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MHCILMJPFJP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid AHKJFKBAGEJ;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HGKAAMOCFDK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid CAGFDGPGKGP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid DLHDNMAADOP;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid LKKOIICCCOF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid ABBKFCMBFIN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid HAFCAOLIGEC;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LMNMNKOKOPL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid HAADJFGOOJO;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OIDPPMNNDFI;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid JMPFINALBBG;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IIEJEBBPAMJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid OKIIIAEEEEM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid CIGBGDFLPMJ;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HMHDGCCPLFH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid MFOEPHDIJHA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid JLHIPEMLIAO;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid AADHIKHDEBI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid PDGAJJGJHKG;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KCADKCCPPIE;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid PDBOKEPDPNL;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid DFIIODLDIGE;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid HHHNANNOJII;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HJCGHKMOHDH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid CPNMKIDDICJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid ANJDIGFIEFL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid CKKFAJLJEHM;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid BMICFGNNFOD;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FEBPKBDJHBH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AHHILDPCDBB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MEHJOKFCNBE;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid CCFKENOOCLE;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid MGGPAOGIHEE;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid JCNEPLKDAOG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid OBPJFLJKIPM;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JINAFLKPLOA;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid PLNFOKMMIEH;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CLIEELEHADA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BEAEIOFOLLL;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid DADKKLNIBHB;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid CFLLKKNDDAL;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid AMLKOFNBFLK;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid FPGHJFEOKIC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid DBIFDADLENJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid ADODDFLGCIM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid MMPMOEGCGEI;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid EEGMHKAIJLD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid PNBKOHDBBLG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid BHKBJBBFALB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid CIGIPMIBAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid OIMEAFGKLLF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid DPOMLECLEEE;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid ALBICBGOLLP;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IDHGENLNCIM;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid EJDIPHBLEFL;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid JPIJOIPFODM;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DDLMHMBFKGD;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ODBPLHMBGDA;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid IBEELHIBLLD;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GOEAMBCOPHE;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HECPPEIBFJG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NNKGKEEPIDN;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid GKGBPOGOLAJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid JDCILIIHEMF;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid KILPHBCAFPF;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid DMGHNIOHBFP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GGLNJNJDOND;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JBMMHMLNAOH;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HHPCONKMINF;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid BCFPCHNOKHC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid KGCAHEPFGKC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid ADDGKAGKNKH;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid GJHHAKBKGLA;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid ELKHMDBHLLK;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid HNCOLFIAPJC;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid DBIHLAOMNMK;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid CJBIHNGKNBO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LCHIFNACDFF;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid AFAKLLGDJFJ;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid AGCCMNNBJCA;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LALDJGCGJML;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid CMBHKAPBAGL;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid JOFOMFCNGJL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KKIDPFJGODJ;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid EDBBCKAMADH;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid DIFMKJEJOMF;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NJGOHDLLMMA;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DLLECOEOMOH;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid LENEAECAHHA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid FNDPLIJDGMH;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid MJCPBGGKAGH;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid LJFLDJPPJGC;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CHLPMDLFOLN;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DLENAOBMEAP;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DLIFOJLCBJN;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid LOJCKELJDJD;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CMFPHOMKIOI;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NIELPBGLDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NFOIDOMFMGA;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IGCJEDIHLOL;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid FEHMOMFJFHP;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid ENMIDDPPBMF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid NFPBLNBMMAC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid FPDHBAIAKJP;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DCOLNJPLJMM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid FBPIJGPDPNJ;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid JFIPEJMBHOA;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid HBPOLMFGPIF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DDPGGCKHGPK;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid MMDMPOPMIMK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid DKPMMBNMOEF;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DFGJIOINEBL;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid JJMDLMMNNCJ;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid PFPOAFJDJDB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid EMBFMGGIGLD;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid HNFBDPLPNOF;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid AENMJDFKIMM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid ENGHBCKCEOE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid GNMNGGCNCGI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PJDFGGJKOGK;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid OEFGCHLGMJC;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid JMLCHODALCN;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HADLCHNKDML;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NDGNJKJLPOB;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JPKOBMGAKFL;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid GEABLGGGPHE;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid EIDDHMGKLEM;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EPEILFBJHEA;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid KMBBJIOIGJF;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PFLICOKPPGN;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GNAGGFNJPBC;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid IFGJFHBEMDG;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid OBBPFKEBOCE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DAGAOPFFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid FANLJJMBEGK;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PKNMCMFNKME;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid OMDIBKHKHNM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JAMDJOGEBCC;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MKOHNEGIOGJ;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid KMDPCDCLGDP;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JOIBJOMEDNK;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid NFBBHJEIICN;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid LKEHAOPPNMK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HAGNEKLFLFA;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CLMNDDNCGHM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid MOLNFPHPADJ;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid OIAFBLHDDHE;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LHHEOMMCDDM;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid JPDJFGBEJBD;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid LBKGPPLIEGB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid PLHPCBLMOKK;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid OHFDNEPANLM;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HIMGFELKPCP;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid EBGDBJJPBIC;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid AEFBBKPCNKG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid KJCMGFODDFI;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid KMDJOKDBFLM;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid FJJDIOOCAGO;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GBKOBPNGMOB;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid PNEMDHOMGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid LKMKCBPHALH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid OGMABNPMIBG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HCLHAPANNLG;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LACFAKDBGCN;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid OBPOIPMELON;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid LMAPNNCENML;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GOHJFBNNCHO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid OHKCGKBMEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid GDGCODJGJNM;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid CNPKFJJOFKM;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HPBCIMAKPLK;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid FNDDPAKFKHF;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid LIHEHHNDNND;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JOCNNNDMGCI;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid MPAFGFJGBAP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid BHMGJFNKJCK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid GFEPIOELIPG;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid OCLNMMJNLJL;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid COAEFKPDGGF;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid JIMNMLONFAA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid DELHCIPMNLL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid NMGFCDPMBEE;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid EIANIEHGKDB;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JIOFHHBJENJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid BIPDFOLFIKI;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid AOEAFIPDKJB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LGODIEAKPON;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid OMEMDDGNIDH;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid EFMLIOJNFAG;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid MKPDHEJGOFG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KGHMELJMPME;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid CKHDDMIOOHA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid OCDGBDNEKCA;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CIFCIBCCOCK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid OBLPLICHOEC;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid NGBHJFKKPEC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid DKNJBADPMFK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JIJMODPFAHD;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid KOBHNLNDNNL;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid FJEPELPNDIG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid IKMHNHGLLFM;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KLEFAPLDHMC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid KDBJMNEIOIH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid KPGEIIIHKEN;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid BHFBKMGHPPA;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid FOLNMPEAODO;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid PAIEEFCDCDN;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IIDMMMMNPEM;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid GEMJBEHPPCC;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid PGFNDJFOKFK;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid BLMNFEMCBDJ;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid ICBJDAKGELC;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid MGKILJODAHA;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid ADGHDKPMEOI;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid GMMHCJHFLFE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid AHECBOFJFKO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid BANGEIINLPH;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid JJCABBNNOIJ;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LGEJPOLDELD;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid FAHNILNCKPA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid NCDKOPGPNJE;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid LKKLGBPNJGO;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid OFPDCFOBBFN;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid GHMPJCIAPMJ;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GPMPJJCMPPM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid HAKFPFEFLMM;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DNEFHFHHHON;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid JHMPGINJHKG;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid NJCMFNLLFGF;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DILMCPAEJEN;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid DMJKGONJDKI;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid NEOJMNGPEBC;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid KKBLJLHEGCA;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid PCKONELBGKD;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BAMAIIADMMM;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid ILKHHOECLIP;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid EJIODBLKPDP;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid MLEIKOJEGNL;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid IJAOMFHOGID;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid GGPEOMNMJJJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GLPLBLIKAIM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KIFCAEOAJFJ;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PPIICFHBLPG;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid HJHOJJLLAAK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid EBCKDCJIDPN;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid DLGMDKGIKGJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid HGFMBCHFKNL;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid OKHBFALKDJP;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid FDNOGBOONJF;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid NBMJJGBJJAH;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid NKOBFJHNMFC;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid BFDBIGJDEJB;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid GEPHKABIENC;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid PNAHPCAMMEE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PJNOJIFHDAN;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid BJIJDKCJIBG;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid AMEOANKKCPA;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MEHGPIELMIP;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid CCNHHFBEPCD;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EMFJLGAAPAL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid DGHJHMEJGMP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid LPLNNALJEOH;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid IOJMOGHMMGM;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid MNNHDAMMJIP;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid BAHIAOFDPDB;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid EACNFNEMPOG;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid PHFLPLCIDEL;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid EBHCHMHDPHM;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid PAKMNIEBGCA;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid NOBPCCNPCMJ;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid PDFJHPBLABD;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid PFGPMIFLFCL;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid LMFILKBPLFG;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid JJGELAIKGFK;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NGODMICAKCP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid MOBMKCKHFHC;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid KMLFGNLOIIH;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid HIMBNIAANKD;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid GLLLKCGPLAL;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid ODBCELAFJDI;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid FNOPPFKAEFK;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid KKNGHEKMGCB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid BOILDNEHDGL;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid CKENJIOBEHC;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid PDKBLIIMOJJ;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid GFLKOLALPNM;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid LIMJDBMNHHM;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, OIPOBLFDFGI> EEMODNCEFAD;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<OIPOBLFDFGI, Guid> FCOPJHOFMJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OIPOBLFDFGI> DBCFKGIPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAE70", Offset = "0x6CBA270", VA = "0x186CBAE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OIPOBLFDFGI, Guid> NCHLNDBHFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAE10", Offset = "0x6CBA210", VA = "0x186CBAE10")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ICOLLBFILLD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFEF0", Offset = "0x6CCF2F0", VA = "0x186CCFEF0")]
	public static bool APCJIDIBGCD(CODJLAOCKIB BMIDPGICMHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFB40", Offset = "0x6CCEF40", VA = "0x186CCFB40")]
	private static bool APCJIDIBGCD(DEEKNKHPCNB MKPJNGJDPAL, CODJLAOCKIB BMIDPGICMHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JHEFPGFIEJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly CHLHIIGLCHO ABPCNCPMPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<GCKACGBMEHC> KJMNDGGJCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<GCKACGBMEHC> PMMNMKPGKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly KENIFKLGBBB<HBIMBCKJJCB> DLHMEFCACML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<EKPAMDKNMJG<OJMKIAECBHB>> ACLIEHPDAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString HCMPCECHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly ELMCKEEIEPE HPGIJMPFIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool OANNPMGIOMO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CD3740", Offset = "0x6CD2B40", VA = "0x186CD3740")]
	public JHEFPGFIEJI(CHLHIIGLCHO AGMAKBJHIAA, IEnumerable<GCKACGBMEHC> MNLHLPJABEA, IReadOnlyList<GCKACGBMEHC> GLBCNFKPPDC, KENIFKLGBBB<HBIMBCKJJCB> MNEFPMEJNLM, IReadOnlyList<EKPAMDKNMJG<OJMKIAECBHB>> OIHLEENEFFD, ByteString JHJIIPHGCAM, ELMCKEEIEPE HAKDIDNIFLG, bool CCOAGPJFMBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CDLGHMNKGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(FPBPPEPMCEO EIFGKHNPLEK, [Out] Dictionary<int, int> BFACMCELKNC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(MJCHPKHBPBE MEEONIHJCEG, ICLEOAPJNOM OABCFCPADOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PPCEMKPIDIC : FAEJPBPCOFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid GBFJINNGEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> IHHPKLFBGMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> NCECFFODLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FB90", Offset = "0x3D8EF90", VA = "0x183D8FB90")]
	private PPCEMKPIDIC([In] Guid IEJKFFOGAEA, Dictionary<Guid, Guid> LJBFDOJCPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5A00", Offset = "0x6CD4E00", VA = "0x186CD5A00")]
	public static PPCEMKPIDIC GIIIFAJNKEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5B40", Offset = "0x6CD4F40", VA = "0x186CD5B40")]
	public static PPCEMKPIDIC JLGAIOACDDP(IReadOnlyDictionary<Guid, Guid> HOFPBMKJHJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5450", Offset = "0x6CD4850", VA = "0x186CD5450")]
	public static PPCEMKPIDIC EMFLHDAIGJD(IEnumerable<KeyValuePair<Guid, Guid>> HOFPBMKJHJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5A90", Offset = "0x6CD4E90", VA = "0x186CD5A90")]
	private static Dictionary<Guid, Guid> GPJMKBPECJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5780", Offset = "0x6CD4B80", VA = "0x186CD5780")]
	public void GCKAJKDJBCM(IReadOnlyDictionary<Guid, Guid> HOFPBMKJHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5340", Offset = "0x6CD4740", VA = "0x186CD5340")]
	public Guid APMOMNFLEGB([In] Guid MDOJFEIEAFI, bool HJOFBJABBMD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5B50", Offset = "0x6CD4F50", VA = "0x186CD5B50")]
	public bool LLKILPEKPIM([In] Guid HDCHKIOFILD, [Out] Guid PAANHFINBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5B50", Offset = "0x6CD4F50", VA = "0x186CD5B50", Slot = "4")]
	private bool LDBKGMDMOJB(Guid DPJCEEDGHJL, [Out] Guid AMPDFCKEJKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NPBEFMCIPPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MLOJNNLOHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIJBJHOEHGL(ByteString PKKEHCEFOIO, PPCEMKPIDIC JNFEKNKLECH, [In] UniformTRS HJHLJJGFHKE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CEEFCOIMHKL
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OICBECHOHJG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B90D0", Offset = "0x9B84D0", VA = "0x1809B90D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long MBFIGBMMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13800E0", Offset = "0x137F4E0", VA = "0x1813800E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long NNPPGFHHJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5320", Offset = "0x6CD4720", VA = "0x186CD5320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69A4930", Offset = "0x69A3D30", VA = "0x1869A4930")]
	public OICBECHOHJG(long GMOPHNCDIJO, long OAIHIHILANI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HDKEAPHMCPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, OICBECHOHJG> DBHLPCDJBOO;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> HOJMHBGOKPD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long PGGHEEMOFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13800E0", Offset = "0x137F4E0", VA = "0x1813800E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DPBIKHMCHAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1D90", Offset = "0x9F1190", VA = "0x1809F1D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAF20", Offset = "0x6CBA320", VA = "0x186CBAF20")]
	public static HDKEAPHMCPN FJLALNDLPGI(CHLHIIGLCHO MGBGOEBGBKA, EKPAMDKNMJG<HBIMBCKJJCB> HMGFJNBICJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB590", Offset = "0x6CBA990", VA = "0x186CBB590")]
	private void JKKAFFOFHII(OOJIJCAGPLP NAALEPHLNNP, long BDEGNIBFCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF200", Offset = "0x6CCE600", VA = "0x186CCF200")]
	public HDKEAPHMCPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KILIAEBLEEM
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<OIPOBLFDFGI> EDOEONMNCIF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PCAMBNCPPEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> JEHILHHNNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> NJOJLOGODLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8AA360", Offset = "0x8A9760", VA = "0x1808AA360")]
	public PCAMBNCPPEJ(IReadOnlyDictionary<Guid, Guid> HKPBFJCIOCO, IReadOnlyDictionary<Guid, Guid> IAPOEJDMGID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IOJBAOGHCLC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ABOLKGFJPOA : IEnumerable<GCKACGBMEHC>, IEnumerable, IEnumerator<GCKACGBMEHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GCKACGBMEHC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private HBODABLFKJF spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public HBODABLFKJF <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private FJKEINOHMKB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public FJKEINOHMKB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GCKACGBMEHC System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F0370", Offset = "0x8EF770", VA = "0x1808F0370")]
		[DebuggerHidden]
		public ABOLKGFJPOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAAF0", Offset = "0x6CB9EF0", VA = "0x186CBAAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6CBADC0", Offset = "0x6CBA1C0", VA = "0x186CBADC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAC00", Offset = "0x6CBA000", VA = "0x186CBAC00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GCKACGBMEHC> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAC00", Offset = "0x6CBA000", VA = "0x186CBAC00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2A00", Offset = "0x6CD1E00", VA = "0x186CD2A00")]
	public static HBODABLFKJF JPJCHAJPDBH([In] JHEFPGFIEJI BNIOOKFFCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CD30E0", Offset = "0x6CD24E0", VA = "0x186CD30E0")]
	private static void PPDHLEHHKBE(HBODABLFKJF DNIDBBJLAIA, [In] JHEFPGFIEJI DFKCBAINIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFF20", Offset = "0x6CCF320", VA = "0x186CCFF20")]
	public static BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO> AOFEBDNNLPM(HBODABLFKJF DNIDBBJLAIA, FJKEINOHMKB EFNOIGEKPNF, PPCEMKPIDIC? PAJJGHGHDJE)
	{
		return default(BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2880", Offset = "0x6CD1C80", VA = "0x186CD2880")]
	[IteratorStateMachine(typeof(ABOLKGFJPOA))]
	private static IEnumerable<GCKACGBMEHC> IBMDEBOMBCG(HBODABLFKJF DNIDBBJLAIA, FJKEINOHMKB EFNOIGEKPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2B70", Offset = "0x6CD1F70", VA = "0x186CD2B70")]
	private static void MBHGOJBMHCO(HBODABLFKJF DNIDBBJLAIA, PPCEMKPIDIC? PAJJGHGHDJE, FJKEINOHMKB EFNOIGEKPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2990", Offset = "0x6CD1D90", VA = "0x186CD2990")]
	private static void IKINHFCBKIA(HBODABLFKJF DNIDBBJLAIA, FJKEINOHMKB EFNOIGEKPNF, IReadOnlyCollection<ByteString>? MCPJLMBNJBE, IReadOnlyCollection<ByteString>? PONEBINJLMM, IReadOnlyCollection<ByteString>? NFJMMNCKKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD1D30", Offset = "0x6CD1130", VA = "0x186CD1D30")]
	private static bool CIAIOPJCGLC(HBODABLFKJF DNIDBBJLAIA, MJCHPKHBPBE MEEONIHJCEG, FJKEINOHMKB EFNOIGEKPNF, [Out][NotNullWhen(false)] string? IBDGAGPHJHE, [Out] Dictionary<int, int> BFACMCELKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD2E00", Offset = "0x6CD2200", VA = "0x186CD2E00")]
	private static Dictionary<Guid, DEEKNKHPCNB> MDPMCJNPPJA(HBODABLFKJF DNIDBBJLAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD1950", Offset = "0x6CD0D50", VA = "0x186CD1950")]
	private static void BDDGKKMENAJ(bool PIHPFPJEOGP, GCKACGBMEHC NDDDMIOEDEN, Dictionary<Guid, Guid> IDNNOJMJMCD, PPCEMKPIDIC PAJJGHGHDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD19F0", Offset = "0x6CD0DF0", VA = "0x186CD19F0")]
	private static void BPLEAKHDLHF(GCKACGBMEHC NDDDMIOEDEN, Guid OIFBADDAHOJ, IAJELJGLFAD? JCGENHJCECA, Dictionary<Guid, DEEKNKHPCNB> GCGGKBKFBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD23D0", Offset = "0x6CD17D0", VA = "0x186CD23D0")]
	private static void HIAKLHNOLDA(IEnumerable<GCKACGBMEHC> JLBCDNBIIBK, IReadOnlyCollection<ByteString> MCPJLMBNJBE, IReadOnlyCollection<ByteString> PONEBINJLMM, IReadOnlyCollection<ByteString> NFJMMNCKKNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FJKEINOHMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool PIHPFPJEOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public ELMCKEEIEPE HAKDIDNIFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public IAJELJGLFAD? JCGENHJCECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public IAJELJGLFAD? LBCIGJOLKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public CHLHIIGLCHO JCLOANNCKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public CEEFCOIMHKL KLCODFNDJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public CDLGHMNKGGK DEEDLJJALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public NPBEFMCIPPD PGPOLCNCLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public EKPAMDKNMJG<HBIMBCKJJCB> KCLHIMGLGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public LNJFLFAMJMD JGJNDFJINCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<GCKACGBMEHC> KIAGCECOOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> FADJNGBPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public PNNLOJAAMLJ BDOIJGLALIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool GKJKCHCOFLG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool FFJKKLBGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAED0", Offset = "0x6CBA2D0", VA = "0x186CBAED0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IAJELJGLFAD
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float HJMKODNEPFK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion GEMHEIIKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float EAEIAKHGPAC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 BIEDOKCLBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF6A0", Offset = "0x6CCEAA0", VA = "0x186CCF6A0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS MNCNCCMCKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF660", Offset = "0x6CCEA60", VA = "0x186CCF660")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE6E6F0", Offset = "0xE6DAF0", VA = "0x180E6E6F0")]
	public IAJELJGLFAD(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float EAEIAKHGPAC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFA70", Offset = "0x6CCEE70", VA = "0x186CCFA70")]
	public IAJELJGLFAD(UniformTRS BFHCLIFHLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF300", Offset = "0x6CCE700", VA = "0x186CCF300")]
	public static IAJELJGLFAD GOCONPEKKAA(IAJELJGLFAD EGIKLIBGODG, IAJELJGLFAD JHPBEMJKCHF)
	{
		return default(IAJELJGLFAD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF930", Offset = "0x6CCED30", VA = "0x186CCF930")]
	public static IAJELJGLFAD NMFIIIJGOAJ((Vector3, Quaternion, float) EIFGKHNPLEK)
	{
		return default(IAJELJGLFAD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF7B0", Offset = "0x6CCEBB0", VA = "0x186CCF7B0")]
	public static IAJELJGLFAD NMFIIIJGOAJ(Matrix4x4 KKJIJJGGLBF)
	{
		return default(IAJELJGLFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF9E0", Offset = "0x6CCEDE0", VA = "0x186CCF9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF580", Offset = "0x6CCE980", VA = "0x186CCF580")]
	public IAJELJGLFAD JCMLNICLCAL(Matrix4x4 JGDFNKEDOMO)
	{
		return default(IAJELJGLFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF290", Offset = "0x6CCE690", VA = "0x186CCF290")]
	public static IAJELJGLFAD COINDPPEJGF(Vector3 OGKCMCMHLOD)
	{
		return default(IAJELJGLFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6CCF950", Offset = "0x6CCED50", VA = "0x186CCF950")]
	public readonly GHEHLOPOPNH OFAKCABEMED()
	{
		return default(GHEHLOPOPNH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NCOIEOMPAGK
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB570", Offset = "0x6CDA970", VA = "0x186CDB570")]
	public static IAJELJGLFAD IFNIIBGNFLI([In] this GHEHLOPOPNH EAFEIEDNLNL)
	{
		return default(IAJELJGLFAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DAHKBILJMKP
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GPHMCHKMIIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly OPKDIFAKAMN MHFCAMFHEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly JPIHCAEEFCD PCNEDAEANFO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
	private GPHMCHKMIIO(OPKDIFAKAMN PMKDNKJPJKE, JPIHCAEEFCD CIPFDOOLGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9AA0", Offset = "0x6CD8EA0", VA = "0x186CD9AA0")]
	public BOMFIFNIFBO KIBOOJHEAEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CD99F0", Offset = "0x6CD8DF0", VA = "0x186CD99F0")]
	public static BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO> GIIIFAJNKEL(FHKCOEHLEBP<FHMPKELNMGN> CIPFDOOLGLO)
	{
		return default(BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9940", Offset = "0x6CD8D40", VA = "0x186CD9940")]
	public static BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO> GIIIFAJNKEL(BOMFIFNIFBO CIPFDOOLGLO)
	{
		return default(BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9880", Offset = "0x6CD8C80", VA = "0x186CD9880")]
	public static BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO> GIIIFAJNKEL(string MLBMANKEFDM)
	{
		return default(BMFECDODLAB<PCAMBNCPPEJ, GPHMCHKMIIO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OPKDIFAKAMN
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PCJIDNMPPHL : IDisposable, GOEEAKPDKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<HPBGCJLBAIH> FMALEAEMALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float OLGGCJDAFAH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EFAIFECABJF PDMGLONAJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		[CompilerGenerated]
		get
		{
			return default(EFAIFECABJF);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MBPECDPDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6CDE5B0", Offset = "0x6CDD9B0", VA = "0x186CDE5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NGKKMHDMMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6CDC770", Offset = "0x6CDBB70", VA = "0x186CDC770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<DKOGOAFFDGH> JDHNCEHHGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int LEIHNLBMKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6CDEE10", Offset = "0x6CDE210", VA = "0x186CDEE10", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float OFKOANDGLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6CDEE50", Offset = "0x6CDE250", VA = "0x186CDEE50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CDEFE0", Offset = "0x6CDE3E0", VA = "0x186CDEFE0")]
	public PCJIDNMPPHL(EFAIFECABJF JADACNGBBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD9F0", Offset = "0x6CDCDF0", VA = "0x186CDD9F0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE0E0", Offset = "0x6CDD4E0", VA = "0x186CDE0E0")]
	public Vector3 JIDMCPCKNAC(int CMANFNLPJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDC00", Offset = "0x6CDD000", VA = "0x186CDDC00", Slot = "6")]
	public Quaternion EGCGLIGBLEL(int CMANFNLPJKF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE780", Offset = "0x6CDDB80", VA = "0x186CDE780", Slot = "5")]
	public Vector3 NAOFIOGCNIM(int CMANFNLPJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDEB0", Offset = "0x6CDD2B0", VA = "0x186CDDEB0", Slot = "7")]
	public float FJPKBLHJFIP(int CMANFNLPJKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC8D0", Offset = "0x6CDBCD0", VA = "0x186CDC8D0")]
	public void CFBDLGCADNA(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float JBJFBPBLEOH, bool COMLBBIDINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE5C0", Offset = "0x6CDD9C0", VA = "0x186CDE5C0")]
	private bool LDAALIEACAK(int LCNFFGJKGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDD30", Offset = "0x6CDD130", VA = "0x186CDDD30")]
	public void EHMOKMCMADH(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE050", Offset = "0x6CDD450", VA = "0x186CDE050")]
	public void JCMFACLPIBE(int LCNFFGJKGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE820", Offset = "0x6CDDC20", VA = "0x186CDE820")]
	public void OJJFFKKDMFL(int LCNFFGJKGLM, Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD, float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDA50", Offset = "0x6CDCE50", VA = "0x186CDDA50")]
	public void EACCLPAJADO(int LCNFFGJKGLM, float3 OGKCMCMHLOD, quaternion GEMHEIIKJKD, float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC780", Offset = "0x6CDBB80", VA = "0x186CDC780")]
	public void BCOGFFBBFOJ(int LCNFFGJKGLM, Vector3 OGKCMCMHLOD, float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE620", Offset = "0x6CDDA20", VA = "0x186CDE620")]
	public void MFLKNBDGPAM(int LCNFFGJKGLM, Vector3 HAGCLANLPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD1E0", Offset = "0x6CDC5E0", VA = "0x186CDD1E0")]
	public static Quaternion DKDNONPBKDM(Quaternion FBOHIOHFFKI, int LCNFFGJKGLM, float GKDGENCBHCK, GOEEAKPDKOJ AHGIGEEKCGC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE970", Offset = "0x6CDDD70", VA = "0x186CDE970")]
	public Bounds OPAOEBCMJME(Transform JGDFNKEDOMO)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDF10", Offset = "0x6CDD310", VA = "0x186CDDF10", Slot = "10")]
	public virtual void FKHDNKAFEDB(bool BCDNBBFABHD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDF80", Offset = "0x6CDD380", VA = "0x186CDDF80")]
	public NativeList<HPBGCJLBAIH> IFCIFPPGHAD(float CFNLAEFFIBO = 1f)
	{
		return default(NativeList<HPBGCJLBAIH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DKOGOAFFDGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 NOBECIHIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float JOFDGLPGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion BJBBANHKIPJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6800", Offset = "0x6CD5C00", VA = "0x186CD6800")]
	public DKOGOAFFDGH(Vector3 MJEPAHGEEKO, Quaternion FBOHIOHFFKI, float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CD62B0", Offset = "0x6CD56B0", VA = "0x186CD62B0")]
	public Quaternion BOIGHLGIDOO(Vector3 KACCFANBELL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6510", Offset = "0x6CD5910", VA = "0x186CD6510")]
	public DKOGOAFFDGH LPNANCELBEH(Vector3 IHMOHKLKIJO, Vector3 NEADACIDPKA, Vector3 CCNMIDEAKHF)
	{
		return default(DKOGOAFFDGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6370", Offset = "0x6CD5770", VA = "0x186CD6370")]
	public LNCFJHICPKC HJEMJOGGBAK(Vector3 KACCFANBELL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class LMPLAKBHKCJ : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB190", Offset = "0x6CDA590", VA = "0x186CDB190", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDABB0", Offset = "0x6CD9FB0", VA = "0x186CDABB0")]
	private void DIJMAIHMMHI(Dictionary<Guid, Guid> AMGPBLAOLOF, JBAGJLEIGOA HPJDPFPHMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAB50", Offset = "0x6CD9F50", VA = "0x186CDAB50")]
	private void DIJMAIHMMHI(Dictionary<Guid, Guid> AMGPBLAOLOF, HHNLCPJNIOK KDNHPBDBAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA8D0", Offset = "0x6CD9CD0", VA = "0x186CDA8D0")]
	private void DIJMAIHMMHI(Dictionary<Guid, Guid> AMGPBLAOLOF, BLLCAOIDEKH FDLHGHLHPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LMPLAKBHKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JHFNGDHKICM : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA6C0", Offset = "0x6CD9AC0", VA = "0x186CDA6C0", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JHFNGDHKICM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BEFPCPNFKPI : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5E60", Offset = "0x6CD5260", VA = "0x186CD5E60", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public BEFPCPNFKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LIJOLBFBPKA : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA770", Offset = "0x6CD9B70", VA = "0x186CDA770", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LIJOLBFBPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DLKAEMBCGMA : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6880", Offset = "0x6CD5C80", VA = "0x186CD6880", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DLKAEMBCGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ABFLBILJEDD : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5C70", Offset = "0x6CD5070", VA = "0x186CD5C70", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public ABFLBILJEDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MGPIAEFMGDP : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB3D0", Offset = "0x6CDA7D0", VA = "0x186CDB3D0", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public MGPIAEFMGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IADKNICHBLB : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9B10", Offset = "0x6CD8F10", VA = "0x186CD9B10", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public IADKNICHBLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class LNBJDOHOFOJ : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB210", Offset = "0x6CDA610", VA = "0x186CDB210", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public LNBJDOHOFOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BOFCDGAAEMH : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5FC0", Offset = "0x6CD53C0", VA = "0x186CD5FC0", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public BOFCDGAAEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class FLBOHGIINOI : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7C80", Offset = "0x6CD7080", VA = "0x186CD7C80", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public FLBOHGIINOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DJJAMOGABIO : FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly DGFHFHHOCGM OJBDMEJHNKM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6180", Offset = "0x6CD5580", VA = "0x186CD6180", Slot = "4")]
	public void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DJJAMOGABIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CODJLAOCKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public MJCHPKHBPBE FCPMNBOKKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public KBHFACDNJEH FBONDHODMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> OJOAHNJCCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> KAFCGEEODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public PNNLOJAAMLJ BDOIJGLALIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool CCLCLDNFAOI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FPNIPNIIGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBDDOAOHFIJ(AGDCFEABKDI HNGOMNHFHHE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OCMFGHHOCGG
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly FPNIPNIIGOH[] CODGLBHNAAA;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBC80", Offset = "0x6CDB080", VA = "0x186CDBC80")]
	public static void CGAPKMACALF(GCKACGBMEHC EIFGKHNPLEK, Dictionary<Guid, Guid> PKNHEDCHCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBF10", Offset = "0x6CDB310", VA = "0x186CDBF10")]
	public static void EIBNFEPEJDF(GCKACGBMEHC? EIFGKHNPLEK, PPCEMKPIDIC AGIANKEOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBA00", Offset = "0x6CDAE00", VA = "0x186CDBA00")]
	public static void BPOLHOLFDGJ(GCKACGBMEHC? EIFGKHNPLEK, PPCEMKPIDIC PAJJGHGHDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB630", Offset = "0x6CDAA30", VA = "0x186CDB630")]
	public static void APCJIDIBGCD(AGDCFEABKDI HNGOMNHFHHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct AGDCFEABKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public MJCHPKHBPBE IKIHLMLABJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public GCKACGBMEHC NDDDMIOEDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> OJOAHNJCCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> KAFCGEEODAJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5DB0", Offset = "0x6CD51B0", VA = "0x186CD5DB0")]
	public Guid ODCOFECAMFI(Guid MDOJFEIEAFI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PNNLOJAAMLJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int ABIDKINDLIJ, [Out] Guid JMMKJGMBAJK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GJEGNMOFFHA
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker GALHGJPNHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> KKNHMPMBLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> GIGJBGGPNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> EGFOCICHGDI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> PGNBCBGGBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> CHGKKFCOJML
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8570", Offset = "0x6CD7970", VA = "0x186CD8570")]
	public static GJEGNMOFFHA EAGKHLBIDJB(CEGBHMDDAMC FKLCHFCGCOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CD94F0", Offset = "0x6CD88F0", VA = "0x186CD94F0")]
	public static GJEGNMOFFHA LBFAFDNLOJD(HBODABLFKJF MMCAADHDLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CD85E0", Offset = "0x6CD79E0", VA = "0x186CD85E0")]
	public static GJEGNMOFFHA FKNEEHEOAMB(IEnumerable<string> KKNHMPMBLPL, IDictionary<long, int> IHHFOECGGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9760", Offset = "0x6CD8B60", VA = "0x186CD9760")]
	private GJEGNMOFFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9620", Offset = "0x6CD8A20", VA = "0x186CD9620")]
	private GJEGNMOFFHA(IEnumerable<string> KKNHMPMBLPL, IDictionary<long, int> IHHFOECGGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8BD0", Offset = "0x6CD7FD0", VA = "0x186CD8BD0")]
	private void HBGDANFJBGB(CEGBHMDDAMC FKLCHFCGCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9280", Offset = "0x6CD8680", VA = "0x186CD9280")]
	private void HBGDANFJBGB(HBODABLFKJF MMCAADHDLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CD80E0", Offset = "0x6CD74E0", VA = "0x186CD80E0")]
	private void DKGELODECEM(ByteString? JHJIIPHGCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8760", Offset = "0x6CD7B60", VA = "0x186CD8760")]
	private void HBGDANFJBGB(CPAOBCLAMGG? DADDPLMNJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8DE0", Offset = "0x6CD81E0", VA = "0x186CD8DE0")]
	private void HBGDANFJBGB(JLFDLOCJPFF? NAALEPHLNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8F20", Offset = "0x6CD8320", VA = "0x186CD8F20")]
	private void HBGDANFJBGB(GCKACGBMEHC? NDDDMIOEDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9480", Offset = "0x6CD8880", VA = "0x186CD9480")]
	private void HDLMFJOBMPF(string? DPAJPKKEEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7F60", Offset = "0x6CD7360", VA = "0x186CD7F60")]
	private void DDCOKDAFDEA(long PIBODCDLNCG, Guid HJBGGFKHNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8090", Offset = "0x6CD7490", VA = "0x186CD8090")]
	private void DDCOKDAFDEA(IJGEIEKGMHB? FDFGKKPKAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8030", Offset = "0x6CD7430", VA = "0x186CD8030")]
	private void DDCOKDAFDEA(MIPHMCONFKE? FDFGKKPKAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct FJGJBFIMDPL
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class PFAONHCLLHK : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> JDBDGAKCPPH;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry KPCAIMFPEGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF1F0", Offset = "0x6CDE5F0", VA = "0x186CDF1F0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NOMMKAICFPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF2B0", Offset = "0x6CDE6B0", VA = "0x186CDF2B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object FDJCHKNOIDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF360", Offset = "0x6CDE760", VA = "0x186CDF360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF110", Offset = "0x6CDE510", VA = "0x186CDF110", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
		public PFAONHCLLHK(IEnumerator<DictionaryEntry> JDBDGAKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF070", Offset = "0x6CDE470", VA = "0x186CDF070", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF0C0", Offset = "0x6CDE4C0", VA = "0x186CDF0C0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IKHDJPMELGD : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x6CD9D50", Offset = "0x6CD9150", VA = "0x186CD9D50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public IKHDJPMELGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9C00", Offset = "0x6CD9000", VA = "0x186CD9C00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9D00", Offset = "0x6CD9100", VA = "0x186CD9D00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF9E0", Offset = "0x6CDEDE0", VA = "0x186CDF9E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object PBFBBOFLBNL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF8F0", Offset = "0x6CDECF0", VA = "0x186CDF8F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6CDFAD0", Offset = "0x6CDEED0", VA = "0x186CDFAD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF830", Offset = "0x6CDEC30", VA = "0x186CDF830", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF890", Offset = "0x6CDEC90", VA = "0x186CDF890", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6CDFA70", Offset = "0x6CDEE70", VA = "0x186CDFA70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF4F0", Offset = "0x6CDE8F0", VA = "0x186CDF4F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF550", Offset = "0x6CDE950", VA = "0x186CDF550", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6CDF5B0", Offset = "0x6CDE9B0", VA = "0x186CDF5B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
		public RoomObjectCounts(Dictionary<int, int> PKLFLBGOLPD, [Optional] Dictionary<int, int> LHDNBNKFPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF410", Offset = "0x6CDE810", VA = "0x186CDF410")]
		[IteratorStateMachine(typeof(IKHDJPMELGD))]
		private IEnumerator<DictionaryEntry> AILBDBPKELK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CDFB20", Offset = "0x6CDEF20", VA = "0x186CDFB20", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF730", Offset = "0x6CDEB30", VA = "0x186CDF730", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF610", Offset = "0x6CDEA10", VA = "0x186CDF610", Slot = "9")]
		void IDictionary.Add(object PBFBBOFLBNL, object PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF670", Offset = "0x6CDEA70", VA = "0x186CDF670", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF6D0", Offset = "0x6CDEAD0", VA = "0x186CDF6D0", Slot = "8")]
		bool IDictionary.Contains(object PBFBBOFLBNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF7D0", Offset = "0x6CDEBD0", VA = "0x186CDF7D0", Slot = "14")]
		void IDictionary.Remove(object PBFBBOFLBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CDF490", Offset = "0x6CDE890", VA = "0x186CDF490", Slot = "15")]
		void ICollection.CopyTo(Array EFKOIGFMOHD, int OBFJPFHENMC)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class FNAEEKGOJPG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x6CD7F10", Offset = "0x6CD7310", VA = "0x186CD7F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public FNAEEKGOJPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6CD7D80", Offset = "0x6CD7180", VA = "0x186CD7D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6CD7EC0", Offset = "0x6CD72C0", VA = "0x186CD7EC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA3E0", Offset = "0x6CD97E0", VA = "0x186CDA3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object PBFBBOFLBNL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA2B0", Offset = "0x6CD96B0", VA = "0x186CDA2B0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA490", Offset = "0x6CD9890", VA = "0x186CDA490", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA1F0", Offset = "0x6CD95F0", VA = "0x186CDA1F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA250", Offset = "0x6CD9650", VA = "0x186CDA250", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6CDA430", Offset = "0x6CD9830", VA = "0x186CDA430", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9E70", Offset = "0x6CD9270", VA = "0x186CD9E70", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9ED0", Offset = "0x6CD92D0", VA = "0x186CD9ED0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6CD9F30", Offset = "0x6CD9330", VA = "0x186CD9F30", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2261EC0", Offset = "0x22612C0", VA = "0x182261EC0")]
		public Invention(long HDCHKIOFILD, int GMOPHNCDIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9DA0", Offset = "0x6CD91A0", VA = "0x186CD9DA0")]
		[IteratorStateMachine(typeof(FNAEEKGOJPG))]
		private IEnumerator<DictionaryEntry> AILBDBPKELK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA4E0", Offset = "0x6CD98E0", VA = "0x186CDA4E0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA0B0", Offset = "0x6CD94B0", VA = "0x186CDA0B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9F90", Offset = "0x6CD9390", VA = "0x186CD9F90", Slot = "9")]
		void IDictionary.Add(object PBFBBOFLBNL, object PFKKDHPJFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9FF0", Offset = "0x6CD93F0", VA = "0x186CD9FF0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA050", Offset = "0x6CD9450", VA = "0x186CDA050", Slot = "8")]
		bool IDictionary.Contains(object PBFBBOFLBNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA190", Offset = "0x6CD9590", VA = "0x186CDA190", Slot = "14")]
		void IDictionary.Remove(object PBFBBOFLBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9E10", Offset = "0x6CD9210", VA = "0x186CD9E10", Slot = "15")]
		void ICollection.CopyTo(Array EFKOIGFMOHD, int OBFJPFHENMC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HAICJKPMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> NJAKLFKENOO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	public FJGJBFIMDPL(IReadOnlyDictionary<Guid, RoomObjectCounts> GDBGLFDFAIE, IReadOnlyList<Invention> LHKIHCBHAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7270", Offset = "0x6CD6670", VA = "0x186CD7270")]
	public static FJGJBFIMDPL EAGKHLBIDJB(CEGBHMDDAMC FKLCHFCGCOM)
	{
		return default(FJGJBFIMDPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6AA0", Offset = "0x6CD5EA0", VA = "0x186CD6AA0")]
	[CompilerGenerated]
	internal static int COICEEGPIHO([In] IReadOnlyDictionary<long, int> PBAGAIJLMEE, long? PIBODCDLNCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6BC0", Offset = "0x6CD5FC0", VA = "0x186CD6BC0")]
	[CompilerGenerated]
	internal static void DGHAAJCOGDC(int MMFMPIDKCAE, [In] CPAOBCLAMGG HOGMDCEGNDP, [In] Dictionary<long, int> PBAGAIJLMEE, [In] Dictionary<Guid, RoomObjectCounts> GDBGLFDFAIE)
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
