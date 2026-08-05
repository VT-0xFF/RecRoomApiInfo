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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D791B0", Offset = "0x6D77BB0", VA = "0x186D791B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PCFDHACGDGL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PHEBGEHAKOE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> LCICCNPIAHN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DNPFLDIGMLD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> DJDHKDGNKIP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JOBGOAGOALM;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string IHJMHEKJPEC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string JAJDHIFOGAK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C990", Offset = "0x6D7B390", VA = "0x186D7C990")]
	public static bool KIBIELNKLAK(Guid DNBEPGMDMFB, int HGHFJKDEIMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C900", Offset = "0x6D7B300", VA = "0x186D7C900")]
	public static bool DCOCKCFNMPC(Guid DNBEPGMDMFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D7CA90", Offset = "0x6D7B490", VA = "0x186D7CA90")]
	public static string OFICJBPIFOK(Guid MMGMNLELLKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PCKJHKDEMDM]
public enum AHDKLIHEKFK
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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D649D0", Offset = "0x6D633D0", VA = "0x186D649D0", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LKKCBBKKALK
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HECPMJFHCKN;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid CDAIIDEHOIJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid AIMLNHOJLJP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid MPDLMIFIAAL;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LGEPFNPHJLN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid LKNPODNCOBN;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid ALLMHPMGCGN;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid BCHCDCEBHFK;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid OMJBMKPLJOC;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ANBACMDFKPP;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DCONFEGJKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid MJHAHPGKDMF;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid CDNEPMBEPHO;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid FLMGLEDDCHJ;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid OIPADGJKDAG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KGKDOENHLGF;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KCJACFCJMDG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid NKGCLOIPDFB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid LDHGLCIAJIG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BGOABBGODFF;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid ODAGHHGFFEG;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NNMNJBHMNCD;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid EDPMEOAPMND;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid KBNPHPNNALD;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid GLDNGBELIJB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid LKNINBPDCAC;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MHDADIMKHNN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JAMPOAEIHJL;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid MGIEBLEJFIG;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CIDIBAMGPLL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid KLKICLEIJGH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid FABJEABLBOC;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LMDCGNHLHHF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid NHDJJFODCAB;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ONOLDMIJGFB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid JGEAELMDFON;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid GBBDPGGJPBN;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PMNDEIHDFOA;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NHGNDJNFFKE;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid FFLKMPAAGJC;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid AEDLFANOFLO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid MHADJAJLPBC;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GMKJPCDFAGP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid IMCINBLNFPJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid GICJJBMNKMK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JJEMKAKKMIC;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid OLKEDFAAFNN;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid NMAHLHNOLAJ;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DDGAPHBMKOI;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid BBBMDJAONAC;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PHNLAJKHHHF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid MDIIJJNHFMM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid EKPCFJLBEEH;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid HDCNEOOLOLG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid EKNPFCBCBKA;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BKJFFEAPHEE;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid MECHBJPPCEB;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CHIBIGNBLPD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid NHOIJGHMCMB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid OLOLFACPGDI;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LBLGGNHPDMB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid HHPPDNLFCKD;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid BLPKKJNELOE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid BDHKAMOMAFK;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HJCHMPPNNJH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NFFIAKAGPOD;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PGGGJKPKMCK;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid JOOKEBDFDPH;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid BMIJBJJLECC;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LEHDPLDIFGH;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OCANPPJEFEC;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid HIJJHPLAANO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CCIOLFKIGGN;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid ILHEMNLEEBK;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BIKIDMAADPB;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BFGDHIBEPJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid AGNKJELCOJE;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid OCELNGNMEJG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid MNDOIFMBKKC;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid CBOFEBKKCGL;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid FFOCAJGKLAA;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid DDFOBHGJNCG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GAJINDFNEHK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid CNMAHMHGDJG;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OEMJICGMDPJ;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ILAEFACICBH;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid LLPMBMOBOPO;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KCPCGGAGCED;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid MINMJMLCMFD;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid IBGDEPPKMOK;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid POGILBNOHFM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MJJAGHIMCPF;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid GHBJGEPOFBH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid PMABHBPFCGG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid CMMIKGPNBCM;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FLBANDGNMGJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid MKBNHGODPLL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid GMFDHFFPDHK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid MOMEJEECOGC;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid MCDJKJMEFBL;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EPHAFLBNDAJ;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid HKOGIPKMHAK;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid IEGHEDPAPFL;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid HNCLDGINMDF;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LCDEICAFIEF;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid DOBPMABIBML;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid NEKOKPDEDBM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PJGBJKOOHJL;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid NGDPAGLNNAF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid LAONHJFGKEB;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GCFIHLMKBGD;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid CPNKGMDHGFK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OHHBIEMDLDL;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BKLDGJPCKEG;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid AECMFHGKCFA;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HOCCIKADJNB;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IDHLLEOELGF;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NHDFMLPCIEG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid EMFKHFGGDLM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CEGOOBOKNBG;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PKAGPANCCAM;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid EHJMDOCKPAF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid CAHACLEHGMN;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GIFEOCKOBID;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DNPJOFLGALP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid FNMJBHLONCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid CDCGGPNLLFE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid DBGPMLGOEMM;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FAGGGGELOFF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid EIIFPPFCLLJ;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid DOHNFALCACC;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid BAOALIBOBNE;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid CBBHEGOPBMK;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid HAMNBLFIGEB;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PANOILNOICC;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid ADCJDMGLMBI;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DPLADKNOMGL;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid HMHJFPGFBGE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid EPAIEGAOBAG;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JBHFNMAJLAB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid BBINFEPGEGC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid HMGENIJLJLP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid ICGMMMKKAMI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DHBHIMNEIFA;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid DALFPJFKHEH;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid FNMCFEKDBNM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid LIMEDJBLDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HDFKKNNGBKG;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid NMJBLCBGFID;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid MNOJHIEEKML;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IMMLFDLNLJD;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid LAPBEFIFKOF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid KLGHEBNMEAK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid CHOGEDHPIAH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid CEILKCJCBCB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MNDLHGGFNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid KGEMCPGHMHO;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid KKPEEIIBDBD;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid GLHFEGHGKNN;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid INNGAKFLCJB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid GIMNAIBHPCN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FNKLCIIDPAJ;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid NOPDKFFMHBA;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BJBMEHGAMDM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HFEOJEOEFML;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DNCCEEDMBIM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid IPPPCMMKLPB;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IEGLFKHPNMK;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NAIEBFOKGII;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid JHKDBABGIGK;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid EBEFKGAJCNE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PEAILFPKJDC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid BLDPDHOGJFI;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid NNGMCHLFHOM;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid PMLCHHAODNG;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BEMCBNPMMMJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BEMPGJIBGEM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid HDMLMOOAMNF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid EJOOLCFGOJP;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HACNLOOEIDG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid HGOFKIFKIEO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid NAGIONAAMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid HJCMEOJCKAA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid IOIJHCJDNOA;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HEANBGGEPMA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid HLPFJJOMAEP;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid EPIBCDIIGDD;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HLKGCCPHPGC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DIEDMJJPDIP;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid LLMFIJEJCBE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid LKLAEIMAPCB;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid OCCBAMKOIBJ;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid POEIBOJLOBA;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid MBKPKMBLNNP;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DEDMPDCNHNM;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BNEOOELGHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid IFCFLCKOFNF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid IGCEAFGMMIG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid BAOEDAEBFPM;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid GALPMHHOBCF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid DJOIADOFALO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid NHMFEHBEKJH;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid CGCKHJHGCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PIIJODFMGEN;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid KCFKNMODCJB;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ADCEFCCNCDO;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FGCBOJMCPII;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DNAOJDGOLEP;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid FIOPGECCNEA;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid LDHLPJKDLHA;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PLEHPAFDJCC;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid GCCFKMKHCOL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JCCGOOPDKDB;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid PBLNOIJDENH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid DKJPMJAJLBI;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid KHDDMMLAFIA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid AFOJDHOEGFJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JLPGJBNACNB;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid BBICPALBJDO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid GGHLICELFEE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid NKEGGHHCEBL;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid FDBKIPFNJCG;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid MBFENHMNJCG;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid HHILFLDPEPE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid HPFBOOIJEJF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KPFLAAMGILO;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid LCNEFEFAGLF;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FAKEHKCIMII;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GHLGKFMGHJC;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid FBIHALKFHCE;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JFHGFCBEMOH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ABHJKAHEJLN;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid NHCHOOKICPB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid MAOPFLLIOEE;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid JCJLGMHLMOP;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid FFFMMBDNCNM;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JIJOLCLCOOC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid DDGGIFDAIKG;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DEDIFNLCODP;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid LBGILLEKMKP;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid HOIHKOGBCMM;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid DFHHIMFIMIP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid FKEMBNLCDOF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid PAPKMEAEAII;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IPPHOHAMGKL;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LNBNAJLGNMN;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid DIGEMBKJNOI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid IHIJDEPKLON;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid PEINBMDBNAB;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DBLOIPJJHPK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid OACEGOIDCEE;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid BANOLOFGCGK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PMDLLLKAOEP;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FNAAAHHKOIP;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid AFKHEDFIHEL;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PGKIMDBAMFI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid FIJJNJBJJNP;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid CCIIPAJMAPG;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid FFPCKKGEMMH;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DHJFKIBOLGM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid FJKHHAKEJAL;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PJIDJCNBHIH;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid IKNNOIMEIAD;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid ECKINPJBIIE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid ECNIGJHJNAN;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid NELCFCJMNKC;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HGJMDILENAG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid COCLJNLOLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid MIADGKBDFJH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid CNILKDCKEPN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid FALPLHGENMG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LPMHNKDBNAN;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MDMKPGHNILI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CCMIKMGOEGJ;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid HIOJDHAIDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid OHBBLJEEMAG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MMGBPLGOEHI;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CBDFLFOFCOB;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid ICPOIBFKLNC;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid MCKFOHIHAEP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid OPGPDNNCJEM;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid GCJJDMJHLFC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid GLLEEEAAHEG;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid JEBKMEDJPAN;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NBIGIPNFOGM;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NPCBAGCOADH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MEBJNBLJIOO;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid JOHFJLPHFGI;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid OPIGCOKGFCN;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid LJFHCJOEHIL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid EEDOLEBHKMF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid KEIHAGDINNP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KEFCPGNNCJA;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MOAMKFKEDFA;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JAABADCLIFD;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid KBBCPDFIPIG;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CNLLPGEAJHK;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid IKGEHAPMBNO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid AJPFKEEAKPI;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid OMEAMBNGCLA;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IBKEJGGBMNC;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PKMAKBNOCDF;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid EMKDAKCJBGG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GJBDNIKPAFB;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AJICKMGOLPC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NDMNBMGCFHF;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BMJAMKKGAOH;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NJOCIKICJBG;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid CHMMPAMNMJM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EEAJOACABID;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IMGLLKCBPNC;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid LPBMONDJIEE;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid BOCMBODHOHB;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid BHOFMCFHLCI;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid PCKFFCFDJDA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid KNFMDOIKIDB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid FIEGFKOBJPI;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid DKNOCGHEOMP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid CGKAGHLMECD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JNAKGKOOKNO;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid KNOPEHJOCDG;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid PICHLGDALDF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FMLGOLDAABB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KDMCEBMJDLN;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid GEANFILAHAC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LKBGOODCJCM;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GGLGGPEIOFP;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LHCJPBJHAAP;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PNKJKLDBFBE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid ILEOJPPMEFK;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid PGKEJNIGEGM;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid ICOIHJOHNFJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid JBOFECNGLIF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid PCBHNFLJFEC;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid LLDMPBMDFEP;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid BNAIDKMPCOB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EEBCIEOOKJB;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid OJMADOPMCLG;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JJNAFNNPLGP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid JHCEKFOFLMC;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid GAIBBAIFJDG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid ANPDNPBMAJM;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OBGONEENLDC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid IEILJKFOGNA;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid FFIKFAJPIKP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GFEILJMOICP;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OPJEAKEOBOB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid AJKNJLKABEN;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid DMPJIEBNFIA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BDFPKFFBHAA;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid MNFJCBBOKKP;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid DDENNBHJAFK;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid IKMPGGIADIL;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NPOGAFNMJHJ;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NMPDHOEDIEH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid CNKFOANEGBB;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid OKDKIFJCOHF;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OONLFKCGDEK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid OCHLENNEMIF;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid FPDCFAGMBIG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid MCPIJLJAJAJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BDMJMHCBGGC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid DLAPEOGLCGE;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid AMONDOIFGNP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JKOANFPKCBB;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid FFILGBOBALK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EBHOKFFDHJK;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid CACHBAKBNLO;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid DMLAABIDCJG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid EAKGEILHPJK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HPLMKNIDIHM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid MLCBBJJJEKP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid AAIJKPCCCNN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid OJDCKIMNEEC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid PKIDKPHEIKP;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MGECKIGMGOK;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CIENNNOGFAI;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid MIGEFLJHHOO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PPBFGGJPJKD;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid NMBPFKHKCNK;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JDGKBGNLJPP;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BNCJCHGKNDI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid IGJHLCAJFAP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HHNPKPMPFLL;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HKJFBAIGMDH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CLPOHKBFDHE;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid DHCDEIDHAAC;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DHJPBMEMEDO;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JHODABEDCLB;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid PEPBPFIBKLC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid GGHJDFLLHCP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KLPMJFPILAB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DHKCGJGBLKD;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PBIAHPEAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid LNNIDPOHLDK;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KPOCIDHFBLL;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PILLCNHMCFI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EHCPBEGNMMP;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid CDFENKOKOPD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid NFJAFBJEOOG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid AGIDFFFCLPO;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BOBBJFABBFJ;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid PEKOFECDNBF;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid JDELJENCPEE;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid NDKPCFIBPLE;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FIHBHLNCDBH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid LMBGPLOCPBH;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NFCPCGBBOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JJGFJFPDJNM;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid LPBCBGAOCHM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid DILJHJMNBGE;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid FKOPAFGHNAO;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AMGFNHNHLHK;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GMNKDDBPDMM;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid PLNCEOFHKLN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid HHCLAIECNBD;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid HENBCAGBCIL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KPMONNNKBNC;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LLIAPNBMFNI;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid GKHBIAGNIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JMHNNDLFCIC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid DLEIKEIHFBH;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid AFOJOIOIFEC;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MCPGHCPCLKE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FBIIAKNOHKP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid BDAPNFBEGBK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LDFACHLJHNA;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid HLMFHIINCNK;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid CFLBLLNGJHI;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid KOGAHJHNGDA;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid PFCFJAGCNBI;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid KBKAIFOKFDM;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid OOENKLABAAI;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DLKPCCFOLMD;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid ANJALGAHLJK;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid MIHONHMKNJJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid PFJLONKEOGM;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GIACGBDKEJE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid KDGIIBHOFIL;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid MHBLMAGGIFA;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OFOMFPAMBJA;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid ALENCOONLAH;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KJCFMGLEAFO;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid FBKDADCBBKL;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CDJDPOLBDAP;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid EHJCCNDFFFM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OLCDLLECFMG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid BCMGMJPDPHC;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid EAOJCCJGCHA;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PLMFNIHMAEO;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid FFAIPAODDMD;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid EGDGMGMEKND;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid FIOKEJFHMOA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid EIGKHPPGDGF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IAHPICHDMDE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PODPNAPBLNH;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid MIAPKDEDKKE;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid HMLDAPIAOMB;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CKPGFGMLMOB;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DACALIJJHNF;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid IAHDLECMLMB;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid OCNMNJEBLNI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid PMKPKBEECPJ;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GFALHLCNONH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid DNMCLHAJFCN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OIKNKKLCCBD;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MBCBBNBCGEK;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid LNOBFIJMIMF;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PGGMJBFFFKA;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid PALEHOODMGH;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid PBNEJCFBCLH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid BDECOBFCPAB;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AHDBHJBACCH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid LFJBKKOMGHA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OLBFDJMAKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HIJHDCLDGDK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid ILDIDABAAHK;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GHNIKLGEAPC;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DGDOLEDLKLN;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid ILHHPPNGIHN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid IBHAMEIIDEH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JEFBODOPOCL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CNBLHJGCKOA;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid DNPIHCOGKGI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IDBBOFCDEBD;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid FCEEPBLBMNC;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid GPGFNFDPPGA;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid NIDPCJJBOOA;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FOBJMAKFDCG;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid FKDAFKAEPEA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid NIAPEMJEHFC;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid IAFDIKFANKO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid JPCBBDDLHFA;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid GAFLJDEOJNA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid CMINOECJHGG;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NFDHEIEHPMA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid GABFLHCEDMN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid IFDBOJFKHFA;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid AFHJJKANHHP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MNAMPGOGEBK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GEIHHMHLKOL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid ALNDKEKBLJN;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GBCANIHMKPF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IHMAEGIPEPL;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ELAPMOJEBOC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid HMFOPAGKOFL;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HCAJHKNGPJC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BAGCPCHNFPH;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid AIHODMEMLND;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid LDCHLIMLMAG;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid EBALBCBHAOI;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PMKBHGHMFJA;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid KGHCMFDKJCO;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid OIBLNBGLLFF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid CGIACADJJPM;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KFNNABFDBIB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid DCFNKPHMNLN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PCBGFKNJFCB;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid CPFMNDGEDDN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid JDFOJOLLCPL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid NKOHPKHMDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JILJDHHCLLC;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid OKBOGCCKHLM;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid MPHCJEHPLEO;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NCFPMFNMGDM;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid ICMMJBGIGIL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid OJAMBLHGMHJ;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid ILICMHPGFPP;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LHMBAEMHPCB;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid IMLHNKLECLJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EOONAJAFHMK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid GBHJJEPPJDM;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BICNOIFHKLN;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid KHEIPFHKBNG;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FDDGBGPFBFE;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid BGCNMIJOOEN;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JJLNKAGMFKG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HNGGJBKFBMA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid FOGFPDAJBHI;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid JFIOBLPGLJI;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HIPDONMEGEF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid ACONAMFHFEH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid EICMOKGIIBG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid OJCOEPFHGAL;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid BMJAAAGHAFM;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid AMDFIAPDAHB;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GHDFMHJLOLO;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid HFFOFHJMHBG;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OMAOFMHAEGD;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid LOFOGHPPJDN;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid GDCKFLGAOEH;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid IDDNKFIELIE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HIKAALKKANO;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid EKHKMBHNICM;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid LGBMKAOHNLI;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid FJBDMIFCBIP;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid GDLGMOKDNCC;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IHHPMLNEKMG;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid MFNNAJCLNBO;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid OCHLKBLCHGO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid JKFOEGHEDFF;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid ADAJHBOFKAI;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid KCNBFHGMOBP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid BHLPKGELPIO;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid INBJJINDBMC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PAKMCPKGLEG;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid BHPOAFEEJDN;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid HMOACNDPKBH;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid MDPGHNPNLPE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid IPMPGPGBPKB;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid CFMNDDKBDOD;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid ODPOLDCHLID;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid BCICEMEIAMK;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid IDBBDPPPHGB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid NKJACLIHHDA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid PHPAGHLBNMI;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid NFEONNECPLA;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DHDDBPJAKCI;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid ECPLHMBKBBM;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid LPHJKINBGMO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid HIMLCOCDPGK;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid EMKPHDLBPGD;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid NKPBABEEJHL;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid EFGCCBJLAOP;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid KBNKHDEABKJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid FOIGFIJEKGN;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid GCJBIKDLPDH;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid GHIOLDCDHCI;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid EOIBBFHAIEJ;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid ECOHNHLHFME;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid CLCMPDNLEJD;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid PPBBNDEBJKM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid AABOBADLMKF;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IIIAIHAIAJG;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid EAJECAPABHH;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid MEOLLHGNEGC;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid EKFAFJPKOKN;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid KDGPGPFNOGD;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid BBJLOCBKEHL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid NCKEDEPMIGE;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid KMPBKDBNJNL;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid AMDONPCCJAA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid PMAPGCLMLBI;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid KIOMCGDMIKA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid IKMMCPJEIBK;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid LJFODJFBMED;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid PJHDAFDDIOM;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid NCNBPMELHIK;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid MEPJHOHIEGA;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid DKAJBEACDCP;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid LNALOFPIGON;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DCIGKIEPCFE;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DBMGODAAEGB;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid CCLILBIMOIE;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FIGJDFNAIMI;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid AFCPIPPCMLN;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid NAOHHMKELPC;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FAOMDEPOEOL;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid EFEFCCJHKKA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid PEMCIIOCHNM;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid FGJGEDPDKIE;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid DMELIDFCFKM;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid JJPDEDPBEDM;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MFAMOJMECCM;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid KOFAGCMBKAF;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid LKKLBFIGBDH;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, AHDKLIHEKFK> PJPMLBMBNEO;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<AHDKLIHEKFK, Guid> OKPKHFFOIDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, AHDKLIHEKFK> AAIHCNEPCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D64930", Offset = "0x6D63330", VA = "0x186D64930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<AHDKLIHEKFK, Guid> MMCBBFOPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D64980", Offset = "0x6D63380", VA = "0x186D64980")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NKHHEDBHJFH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D78DD0", Offset = "0x6D777D0", VA = "0x186D78DD0")]
	public static bool LLBOMIEPKHJ(LJNPLKPDMPF DPIKOJKOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D78E00", Offset = "0x6D77800", VA = "0x186D78E00")]
	private static bool LLBOMIEPKHJ(PLLLBFGFLFO KENDFLINCBC, LJNPLKPDMPF DPIKOJKOGJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JBCDHFCMJID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly PJMLECBJJNJ ONMJDJJNHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<INNJJHKNLDI> KGJDHKOMKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<INNJJHKNLDI> GOEAENIEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly NOPFJADADBI<AEAAGMJLLLI> AMHKNOBMDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<LNNCPMKFMDI<HAPKHKKGAFF>> EELGKPDOHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString AKKECCGFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly COIPMGFHIMP BLPFADHCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool IENKJNCEMAO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D64000", Offset = "0x6D62A00", VA = "0x186D64000")]
	public JBCDHFCMJID(PJMLECBJJNJ PPGJNAJBJGF, IEnumerable<INNJJHKNLDI> JNFLHLMGFNO, IReadOnlyList<INNJJHKNLDI> FEEDCFKOLPP, NOPFJADADBI<AEAAGMJLLLI> HFHKIIBCJGO, IReadOnlyList<LNNCPMKFMDI<HAPKHKKGAFF>> AFFGADFCCNL, ByteString LNBKODDDJOO, COIPMGFHIMP GOPIFLFLIBE, bool APKJIOFBAFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IDGJKAELPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KKFGLFJNBLP GGEMPJLCHFC, [Out] Dictionary<int, int> LGGAAMJPMBI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CAMCIKNBNLL LDAJOCPFHNE, JFEEOCMBLNE GEOGMPPFPJO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IOPBHMLCBFD : NBGELMDBHBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid ILPCGKLBKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> ECEIFNGKMFA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> CKCAKPEMIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA850", Offset = "0x3DF9250", VA = "0x183DFA850")]
	private IOPBHMLCBFD([In] Guid FMJOHAMECLJ, Dictionary<Guid, Guid> KOPPICAKKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D63730", Offset = "0x6D62130", VA = "0x186D63730")]
	public static IOPBHMLCBFD AELHPDENENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D63C10", Offset = "0x6D62610", VA = "0x186D63C10")]
	public static IOPBHMLCBFD EDJAAMPFMBA(IReadOnlyDictionary<Guid, Guid> PHLCHGGOCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D637C0", Offset = "0x6D621C0", VA = "0x186D637C0")]
	public static IOPBHMLCBFD AIACAMCBCBG(IEnumerable<KeyValuePair<Guid, Guid>> PHLCHGGOCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D63B60", Offset = "0x6D62560", VA = "0x186D63B60")]
	private static Dictionary<Guid, Guid> CGEANOLEAJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D63D80", Offset = "0x6D62780", VA = "0x186D63D80")]
	public void MGLOFCAPANC(IReadOnlyDictionary<Guid, Guid> PHLCHGGOCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D63C20", Offset = "0x6D62620", VA = "0x186D63C20")]
	public Guid JGBMEHKMCDE([In] Guid MMGMNLELLKG, bool JAAPHEAMCLL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D63AF0", Offset = "0x6D624F0", VA = "0x186D63AF0")]
	public bool BDICBAIGCGJ([In] Guid CMEADPACGME, [Out] Guid MBJODHONPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D63AF0", Offset = "0x6D624F0", VA = "0x186D63AF0", Slot = "4")]
	private bool LDDCCCIOBDM(Guid GOJOFOOEGJK, [Out] Guid CPODOKHNLFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IGPLHLMGOMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PEPIFPBONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLDAMIHNNNK(ByteString KMCEMFDDGGH, IOPBHMLCBFD POLFICAHHMK, [In] UniformTRS JEPBICGHCAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LKAFHFFHFAE
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
public class GNNGMFLNFDK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9C9330", Offset = "0x9C7D30", VA = "0x1809C9330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BALFDLBACMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13920B0", Offset = "0x1390AB0", VA = "0x1813920B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long AELAOMKCLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D631B0", Offset = "0x6D61BB0", VA = "0x186D631B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B240", Offset = "0x6A29C40", VA = "0x186A2B240")]
	public GNNGMFLNFDK(long FPDJICFHLGM, long BELJMEGIHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MAOGOMHGBBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, GNNGMFLNFDK> FAOAILHOJAE;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> CJIMKDCIHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long OOHFJCLAPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13920B0", Offset = "0x1390AB0", VA = "0x1813920B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DKDCKAOODKD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA001E0", Offset = "0x9FEBE0", VA = "0x180A001E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D64D30", Offset = "0x6D63730", VA = "0x186D64D30")]
	public static MAOGOMHGBBP IILLPHBIHME(PJMLECBJJNJ LMBDHHCCILP, LNNCPMKFMDI<AEAAGMJLLLI> POFGGIGIFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D64A60", Offset = "0x6D63460", VA = "0x186D64A60")]
	private void CKFJNHOONAN(FGJHFGGJHDK OFGAFPGJIKO, long CACKMGNMINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D78D40", Offset = "0x6D77740", VA = "0x186D78D40")]
	public MAOGOMHGBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IJJLGEKIMHC
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<AHDKLIHEKFK> JFDJCDBEDFA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class GHDNLHHNJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> CHJOCOOMCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> CCCGBKFFLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public GHDNLHHNJNC(IReadOnlyDictionary<Guid, Guid> JJJGBCJGLIB, IReadOnlyDictionary<Guid, Guid> FNKEBJGDLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OLKAOCLIDJC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HJLOEAKMBLC : IEnumerable<INNJJHKNLDI>, IEnumerable, IEnumerator<INNJJHKNLDI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private INNJJHKNLDI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private JABAGAPCNLD spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public JABAGAPCNLD <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private INOCMGLEKEG spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public INOCMGLEKEG <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private INNJJHKNLDI System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public HJLOEAKMBLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D631D0", Offset = "0x6D61BD0", VA = "0x186D631D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D63480", Offset = "0x6D61E80", VA = "0x186D63480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D632E0", Offset = "0x6D61CE0", VA = "0x186D632E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INNJJHKNLDI> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D632E0", Offset = "0x6D61CE0", VA = "0x186D632E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D79850", Offset = "0x6D78250", VA = "0x186D79850")]
	public static JABAGAPCNLD GMACIFDHCEF([In] JBCDHFCMJID IAGAIANCBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B2B0", Offset = "0x6D79CB0", VA = "0x186D7B2B0")]
	private static void JCPJFHHDJDP(JABAGAPCNLD PFAEIBBPHKA, [In] JBCDHFCMJID OMIGEFEJLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D799D0", Offset = "0x6D783D0", VA = "0x186D799D0")]
	public static OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK> GOBNHNKDCNA(JABAGAPCNLD PFAEIBBPHKA, INOCMGLEKEG BPDJHNPJOAF, IOPBHMLCBFD? FLKAFFFGLFJ)
	{
		return default(OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D79750", Offset = "0x6D78150", VA = "0x186D79750")]
	[IteratorStateMachine(typeof(HJLOEAKMBLC))]
	private static IEnumerable<INNJJHKNLDI> GCNOHDEJDKA(JABAGAPCNLD PFAEIBBPHKA, INOCMGLEKEG BPDJHNPJOAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B910", Offset = "0x6D7A310", VA = "0x186D7B910")]
	private static void KGFMGNFFJCN(JABAGAPCNLD PFAEIBBPHKA, IOPBHMLCBFD? FLKAFFFGLFJ, INOCMGLEKEG BPDJHNPJOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D79230", Offset = "0x6D77C30", VA = "0x186D79230")]
	private static void CLCOKPKILCC(JABAGAPCNLD PFAEIBBPHKA, INOCMGLEKEG BPDJHNPJOAF, IReadOnlyCollection<ByteString>? CNIANPBIDEO, IReadOnlyCollection<ByteString>? CBFCMEIEKGH, IReadOnlyCollection<ByteString>? CMFHELMNHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C260", Offset = "0x6D7AC60", VA = "0x186D7C260")]
	private static bool PMJCIAAHDAC(JABAGAPCNLD PFAEIBBPHKA, CAMCIKNBNLL LDAJOCPFHNE, INOCMGLEKEG BPDJHNPJOAF, [Out][NotNullWhen(false)] string? BHAOKKINJPA, [Out] Dictionary<int, int> LGGAAMJPMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BEE0", Offset = "0x6D7A8E0", VA = "0x186D7BEE0")]
	private static Dictionary<Guid, PLLLBFGFLFO> MCCPHEKJFAJ(JABAGAPCNLD PFAEIBBPHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7C1C0", Offset = "0x6D7ABC0", VA = "0x186D7C1C0")]
	private static void OCBFCJKJEAK(bool AGOPEKLJCKG, INNJJHKNLDI MDLHGFCNBNN, Dictionary<Guid, Guid> CMBKIFEBEIM, IOPBHMLCBFD FLKAFFFGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BBA0", Offset = "0x6D7A5A0", VA = "0x186D7BBA0")]
	private static void LOPIMEADAPC(INNJJHKNLDI MDLHGFCNBNN, Guid ECEAOGOFGJH, JDLDJMJAAGG? OPAMJJOLDJD, Dictionary<Guid, PLLLBFGFLFO> GCCGGNKIFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D792A0", Offset = "0x6D77CA0", VA = "0x186D792A0")]
	private static void FPDIAFJPJPF(IEnumerable<INNJJHKNLDI> GJOENHJAJIK, IReadOnlyCollection<ByteString> CNIANPBIDEO, IReadOnlyCollection<ByteString> CBFCMEIEKGH, IReadOnlyCollection<ByteString> CMFHELMNHIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct INOCMGLEKEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool AGOPEKLJCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public COIPMGFHIMP GOPIFLFLIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public JDLDJMJAAGG? OPAMJJOLDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public JDLDJMJAAGG? DFENHGGNFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public PJMLECBJJNJ PONDJHKMEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public LKAFHFFHFAE AGDNAICIKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public IDGJKAELPFC ANDOBFHAFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public IGPLHLMGOMJ NEKNBKHBBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public LNNCPMKFMDI<AEAAGMJLLLI> BNGFAFLHICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public KJCBGHAGEHM BHHPKKMDPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<INNJJHKNLDI> MOAPBELPAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> IMGPFHIKMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public INDMJPCGMID CBBIGIJPHMD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LJGIKMIBKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D636E0", Offset = "0x6D620E0", VA = "0x186D636E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JDLDJMJAAGG
{
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private const float EDFOHAEGAEJ = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public Vector3 PCPIJKGKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Quaternion MHLCHCEFDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float ECGPBBOMOPD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 HILJPDODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D642B0", Offset = "0x6D62CB0", VA = "0x186D642B0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS LOHBMBPDMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D64200", Offset = "0x6D62C00", VA = "0x186D64200")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE9B8E0", Offset = "0xE9A2E0", VA = "0x180E9B8E0")]
	public JDLDJMJAAGG(Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float ECGPBBOMOPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D64860", Offset = "0x6D63260", VA = "0x186D64860")]
	public JDLDJMJAAGG(UniformTRS GCICJDONEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D643B0", Offset = "0x6D62DB0", VA = "0x186D643B0")]
	public static JDLDJMJAAGG LFOJOJKGINI(JDLDJMJAAGG NNFBEGDDJKL, JDLDJMJAAGG MGACBJADNDA)
	{
		return default(JDLDJMJAAGG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D647B0", Offset = "0x6D631B0", VA = "0x186D647B0")]
	public static JDLDJMJAAGG OLKJPEKNNFN((Vector3, Quaternion, float) GGEMPJLCHFC)
	{
		return default(JDLDJMJAAGG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D64630", Offset = "0x6D63030", VA = "0x186D64630")]
	public static JDLDJMJAAGG OLKJPEKNNFN(Matrix4x4 IJNFIHFPDND)
	{
		return default(JDLDJMJAAGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D647D0", Offset = "0x6D631D0", VA = "0x186D647D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D64120", Offset = "0x6D62B20", VA = "0x186D64120")]
	public JDLDJMJAAGG DILJEOMOHNJ(Matrix4x4 FOBEMKFOBOH)
	{
		return default(JDLDJMJAAGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D64240", Offset = "0x6D62C40", VA = "0x186D64240")]
	public static JDLDJMJAAGG FGDKDPLDJCH(Vector3 PCPIJKGKPCE)
	{
		return default(JDLDJMJAAGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D64090", Offset = "0x6D62A90", VA = "0x186D64090")]
	public readonly IPKEGCJHFGM BNEKCAFEBHB()
	{
		return default(IPKEGCJHFGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum JNOMPKFBNCE
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NJMHLPKGJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly EKFEOLBEJFM AELIKNGBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private readonly FMGMBNHPFJE JHFIMPMLIMI;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1116530", Offset = "0x1114F30", VA = "0x181116530")]
	private NJMHLPKGJIK(EKFEOLBEJFM CLPBJKNGJBH, FMGMBNHPFJE PFAMOOEEFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6D86830", Offset = "0x6D85230", VA = "0x186D86830")]
	public ABPICNIEEFO AGMBOADFJMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D86780", Offset = "0x6D85180", VA = "0x186D86780")]
	public static OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK> AELHPDENENI(GLFMNJFBJNJ<NEDLODCHJKB> PFAMOOEEFKM)
	{
		return default(OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D866D0", Offset = "0x6D850D0", VA = "0x186D866D0")]
	public static OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK> AELHPDENENI(ABPICNIEEFO PFAMOOEEFKM)
	{
		return default(OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D86610", Offset = "0x6D85010", VA = "0x186D86610")]
	public static OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK> AELHPDENENI(string KLAOFEGHCDM)
	{
		return default(OKPKCEBGDLD<GHDNLHHNJNC, NJMHLPKGJIK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EKFEOLBEJFM
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CIKHHMEJHJA : IDisposable, CLCMJJDMDMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private NativeList<GAJGCAGDBEH> AKGFEKCDEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private float ELHHNFDCHGL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DMGCPCFOJCI IIHGPOHOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0")]
		[CompilerGenerated]
		get
		{
			return default(DMGCPCFOJCI);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF750", Offset = "0x8AE150", VA = "0x1808AF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PJAAHLOOCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7E770", Offset = "0x6D7D170", VA = "0x186D7E770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OLBJLFGLHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7EFE0", Offset = "0x6D7D9E0", VA = "0x186D7EFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<MHANGNKBJDK> MNDGICJOKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EGLEBMMCFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D7F1A0", Offset = "0x6D7DBA0", VA = "0x186D7F1A0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float FIOFFMJDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D802B0", Offset = "0x6D7ECB0", VA = "0x186D802B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D80CE0", Offset = "0x6D7F6E0", VA = "0x186D80CE0")]
	public CIKHHMEJHJA(DMGCPCFOJCI DDACCEBMBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EF80", Offset = "0x6D7D980", VA = "0x186D7EF80", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F310", Offset = "0x6D7DD10", VA = "0x186D7F310")]
	public Vector3 ICNHOABIFCG(int DLAFBLPELJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F1E0", Offset = "0x6D7DBE0", VA = "0x186D7F1E0", Slot = "6")]
	public Quaternion HHCAOJJDPDA(int DLAFBLPELJG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D80A20", Offset = "0x6D7F420", VA = "0x186D80A20", Slot = "5")]
	public Vector3 OLMPMJPIDEG(int DLAFBLPELJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F140", Offset = "0x6D7DB40", VA = "0x186D7F140", Slot = "7")]
	public float HBOPEIFBIBA(int DLAFBLPELJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D7F7E0", Offset = "0x6D7E1E0", VA = "0x186D7F7E0")]
	public void IGPKPDFJKMA(Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD, bool PCPPAHCGNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D80250", Offset = "0x6D7EC50", VA = "0x186D80250")]
	private bool MAPIJFLAOEJ(int MPEJCGFCHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E5F0", Offset = "0x6D7CFF0", VA = "0x186D7E5F0")]
	public void CHFJNNAGHBE(Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D800F0", Offset = "0x6D7EAF0", VA = "0x186D800F0")]
	public void INGGNMJENLB(int MPEJCGFCHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D808D0", Offset = "0x6D7F2D0", VA = "0x186D808D0")]
	public void OFCLJFMEFMI(int MPEJCGFCHKN, Vector3 PCPIJKGKPCE, Quaternion MHLCHCEFDAI, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D80AC0", Offset = "0x6D7F4C0", VA = "0x186D80AC0")]
	public void PBNPCOKCEGB(int MPEJCGFCHKN, float3 PCPIJKGKPCE, quaternion MHLCHCEFDAI, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7EFF0", Offset = "0x6D7D9F0", VA = "0x186D7EFF0")]
	public void EKNLDHBBLBA(int MPEJCGFCHKN, Vector3 PCPIJKGKPCE, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E490", Offset = "0x6D7CE90", VA = "0x186D7E490")]
	public void BKMFACBEPKA(int MPEJCGFCHKN, Vector3 LIGJJEDBJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E780", Offset = "0x6D7D180", VA = "0x186D7E780")]
	public static Quaternion DOFJJNNNPLL(Quaternion LLGOJPDGOGO, int MPEJCGFCHKN, float PMHOHEJGMOA, CLCMJJDMDMJ FCIFPLNDEBP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D80440", Offset = "0x6D7EE40", VA = "0x186D80440")]
	public Bounds NKPLCPMCPFA(Transform FOBEMKFOBOH)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D80C70", Offset = "0x6D7F670", VA = "0x186D80C70", Slot = "10")]
	public virtual void PIGPPCAGGAN(bool GIADDJNNEHI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D80180", Offset = "0x6D7EB80", VA = "0x186D80180")]
	public NativeList<GAJGCAGDBEH> JGCDNAJFDCL(float AKDENJIMFDH = 1f)
	{
		return default(NativeList<GAJGCAGDBEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MHANGNKBJDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public float3 CNDDIEKMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float BMOOOPPEKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public quaternion CDOFCDKCNHH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D86590", Offset = "0x6D84F90", VA = "0x186D86590")]
	public MHANGNKBJDK(Vector3 BODEELBOMLJ, Quaternion LLGOJPDGOGO, float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D86040", Offset = "0x6D84A40", VA = "0x186D86040")]
	public Quaternion HDBAGEIJKNF(Vector3 GPCBHKJPHLL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D86100", Offset = "0x6D84B00", VA = "0x186D86100")]
	public MHANGNKBJDK IDLKKIHGNOM(Vector3 DCPKMNNJOKK, Vector3 KEHJMIIFKLI, Vector3 KPOJLKGFDNP)
	{
		return default(MHANGNKBJDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D863F0", Offset = "0x6D84DF0", VA = "0x186D863F0")]
	public KJCHLEPAEDN IJMLHHAAFIO(Vector3 GPCBHKJPHLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PDGPIPLOCLG : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D876F0", Offset = "0x6D860F0", VA = "0x186D876F0", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D87110", Offset = "0x6D85B10", VA = "0x186D87110")]
	private void BFHGIMGIMGE(Dictionary<Guid, Guid> LGIILCGHCHH, PJCBFEBOACF ANAPPPINHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D870B0", Offset = "0x6D85AB0", VA = "0x186D870B0")]
	private void BFHGIMGIMGE(Dictionary<Guid, Guid> LGIILCGHCHH, LPFOCBMJGPD GLJBELIMMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D86E30", Offset = "0x6D85830", VA = "0x186D86E30")]
	private void BFHGIMGIMGE(Dictionary<Guid, Guid> LGIILCGHCHH, BCMCPGOHBGG FBOEJFPIMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public PDGPIPLOCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HBGPFJLKPJI : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D82DD0", Offset = "0x6D817D0", VA = "0x186D82DD0", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public HBGPFJLKPJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KKNHFAKPDEK : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D84DA0", Offset = "0x6D837A0", VA = "0x186D84DA0", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KKNHFAKPDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HMJCCMEPFMO : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D82E80", Offset = "0x6D81880", VA = "0x186D82E80", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public HMJCCMEPFMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class EFDFIBCCLBH : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D80E10", Offset = "0x6D7F810", VA = "0x186D80E10", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public EFDFIBCCLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KIPLFBMBFMH : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D84C60", Offset = "0x6D83660", VA = "0x186D84C60", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KIPLFBMBFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GJEHEIABDFD : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D82C40", Offset = "0x6D81640", VA = "0x186D82C40", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GJEHEIABDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AELGILFMBBG : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E0C0", Offset = "0x6D7CAC0", VA = "0x186D7E0C0", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public AELGILFMBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BDHHICINMGJ : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E1B0", Offset = "0x6D7CBB0", VA = "0x186D7E1B0", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public BDHHICINMGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FLKCPGOMFLO : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6D82990", Offset = "0x6D81390", VA = "0x186D82990", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FLKCPGOMFLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GGCNGCMCIEC : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D82B40", Offset = "0x6D81540", VA = "0x186D82B40", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GGCNGCMCIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CAKGBEJFEJG : CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public static readonly GMIPEFOPAAB GEOFENBBDMI;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D7E360", Offset = "0x6D7CD60", VA = "0x186D7E360", Slot = "4")]
	public void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public CAKGBEJFEJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LJNPLKPDMPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public CAMCIKNBNLL OCMGGEGAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public PMCFCEKPJLA JLAKODDBMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public Dictionary<int, int> JLNCPNJMNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<Guid, Guid> MFFIOLNAONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public INDMJPCGMID CBBIGIJPHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool EPAHAMBEDDO;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CHOMAFALJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENNLGEOJPJI(DIOOEMICCCJ DDMOBDEICGN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LNKAECLFGKG
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private static readonly CHOMAFALJPO[] NEJOFCOCLIH;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D84F00", Offset = "0x6D83900", VA = "0x186D84F00")]
	public static void CDGADFLPFLL(INNJJHKNLDI GGEMPJLCHFC, Dictionary<Guid, Guid> FEEOKKNALJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D85190", Offset = "0x6D83B90", VA = "0x186D85190")]
	public static void DPIMGFEBOJB(INNJJHKNLDI? GGEMPJLCHFC, IOPBHMLCBFD FCMELGJMKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D85420", Offset = "0x6D83E20", VA = "0x186D85420")]
	public static void KJNFMHPIHGN(INNJJHKNLDI? GGEMPJLCHFC, IOPBHMLCBFD FLKAFFFGLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D856A0", Offset = "0x6D840A0", VA = "0x186D856A0")]
	public static void LLBOMIEPKHJ(DIOOEMICCCJ DDMOBDEICGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DIOOEMICCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public CAMCIKNBNLL IGOAMGLLJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public INNJJHKNLDI MDLHGFCNBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Dictionary<int, int> JLNCPNJMNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<Guid, Guid> MFFIOLNAONH;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D80D70", Offset = "0x6D7F770", VA = "0x186D80D70")]
	public Guid DCIMGIFGDJG(Guid MMGMNLELLKG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface INDMJPCGMID
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LEBGEDDPMGE, [Out] Guid FIBHILGFFHA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class FJAFJJHPBFH
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly ProfilerMarker OMIEKPEGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<string> OKKPMLHKGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly Dictionary<long, int> PCJMJKJNNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly HashSet<Guid> HKHEBKDKIPE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> DFAEMADINAH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> MEEBAABACDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D81030", Offset = "0x6D7FA30", VA = "0x186D81030")]
	public static FJAFJJHPBFH ELDCGDEEIKE(FNEPJCIGLHI GJLDCFIFFGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D81560", Offset = "0x6D7FF60", VA = "0x186D81560")]
	public static FJAFJJHPBFH GFINAJBKNCJ(JABAGAPCNLD HLNIOCAPHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D815D0", Offset = "0x6D7FFD0", VA = "0x186D815D0")]
	public static FJAFJJHPBFH HJPBIGLJBBH(IEnumerable<string> OKKPMLHKGNK, IDictionary<long, int> KBOKOLCIHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D82730", Offset = "0x6D81130", VA = "0x186D82730")]
	private FJAFJJHPBFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D82850", Offset = "0x6D81250", VA = "0x186D82850")]
	private FJAFJJHPBFH(IEnumerable<string> OKKPMLHKGNK, IDictionary<long, int> KBOKOLCIHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D82460", Offset = "0x6D80E60", VA = "0x186D82460")]
	private void JNCOLKNFLLL(FNEPJCIGLHI GJLDCFIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D81A80", Offset = "0x6D80480", VA = "0x186D81A80")]
	private void JNCOLKNFLLL(JABAGAPCNLD HLNIOCAPHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D810A0", Offset = "0x6D7FAA0", VA = "0x186D810A0")]
	private void FGEBMIHFEDL(ByteString? LNBKODDDJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D81FE0", Offset = "0x6D809E0", VA = "0x186D81FE0")]
	private void JNCOLKNFLLL(DPKHFJKOHKM? ELFANOAFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D81940", Offset = "0x6D80340", VA = "0x186D81940")]
	private void JNCOLKNFLLL(LADKILKBGME? OFGAFPGJIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D81C80", Offset = "0x6D80680", VA = "0x186D81C80")]
	private void JNCOLKNFLLL(INNJJHKNLDI? MDLHGFCNBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D818D0", Offset = "0x6D802D0", VA = "0x186D818D0")]
	private void JMKDJOKJJIN(string? GCGMNMGMJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D81800", Offset = "0x6D80200", VA = "0x186D81800")]
	private void JKAMEGOOMEG(long EKOHLNPLPMK, Guid GGCCOODCEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D817B0", Offset = "0x6D801B0", VA = "0x186D817B0")]
	private void JKAMEGOOMEG(DADKEMBAEJD? IANIBAEBHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D81750", Offset = "0x6D80150", VA = "0x186D81750")]
	private void JKAMEGOOMEG(JPAJFMEFEKA? IANIBAEBHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct ILPMJCJHABN
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class OHBPLNEAACC : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private readonly IEnumerator<DictionaryEntry> JLNFMCJGDKH;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry NHNAKDKLBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6D86A20", Offset = "0x6D85420", VA = "0x186D86A20", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object HPAJNDJICEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D86AF0", Offset = "0x6D854F0", VA = "0x186D86AF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object IPHIEALFCML
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6D86BA0", Offset = "0x6D855A0", VA = "0x186D86BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D86940", Offset = "0x6D85340", VA = "0x186D86940", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
		public OHBPLNEAACC(IEnumerator<DictionaryEntry> JLNFMCJGDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D868A0", Offset = "0x6D852A0", VA = "0x186D868A0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D868F0", Offset = "0x6D852F0", VA = "0x186D868F0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class IMHOEOBHHGF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x97E910", Offset = "0x97D310", VA = "0x18097E910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x6D842F0", Offset = "0x6D82CF0", VA = "0x186D842F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public IMHOEOBHHGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6D841A0", Offset = "0x6D82BA0", VA = "0x186D841A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6D842A0", Offset = "0x6D82CA0", VA = "0x186D842A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6D87D40", Offset = "0x6D86740", VA = "0x186D87D40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object PNABAFEIDND]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D87C50", Offset = "0x6D86650", VA = "0x186D87C50", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6D87E20", Offset = "0x6D86820", VA = "0x186D87E20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6D87B90", Offset = "0x6D86590", VA = "0x186D87B90", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6D87BF0", Offset = "0x6D865F0", VA = "0x186D87BF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D87DC0", Offset = "0x6D867C0", VA = "0x186D87DC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D87850", Offset = "0x6D86250", VA = "0x186D87850", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D878B0", Offset = "0x6D862B0", VA = "0x186D878B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D87910", Offset = "0x6D86310", VA = "0x186D87910", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
		public RoomObjectCounts(Dictionary<int, int> MBEODBAPMPH, [Optional] Dictionary<int, int> IJKJFNNKANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D87770", Offset = "0x6D86170", VA = "0x186D87770")]
		[IteratorStateMachine(typeof(IMHOEOBHHGF))]
		private IEnumerator<DictionaryEntry> MELOGLGGLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D87E70", Offset = "0x6D86870", VA = "0x186D87E70", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D87A90", Offset = "0x6D86490", VA = "0x186D87A90", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D87970", Offset = "0x6D86370", VA = "0x186D87970", Slot = "9")]
		void IDictionary.Add(object PNABAFEIDND, object PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D879D0", Offset = "0x6D863D0", VA = "0x186D879D0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D87A30", Offset = "0x6D86430", VA = "0x186D87A30", Slot = "8")]
		bool IDictionary.Contains(object PNABAFEIDND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D87B30", Offset = "0x6D86530", VA = "0x186D87B30", Slot = "14")]
		void IDictionary.Remove(object PNABAFEIDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D877F0", Offset = "0x6D861F0", VA = "0x186D877F0", Slot = "15")]
		void ICollection.CopyTo(Array LOCJOHPCANM, int GCBONJOGHCD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class OKCAAJAHIJL : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x97E910", Offset = "0x97D310", VA = "0x18097E910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x6D86DE0", Offset = "0x6D857E0", VA = "0x186D86DE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public OKCAAJAHIJL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6D86C50", Offset = "0x6D85650", VA = "0x186D86C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6D86D90", Offset = "0x6D85790", VA = "0x186D86D90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6D84980", Offset = "0x6D83380", VA = "0x186D84980", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object PNABAFEIDND]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6D84850", Offset = "0x6D83250", VA = "0x186D84850", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6D84A30", Offset = "0x6D83430", VA = "0x186D84A30", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6D84790", Offset = "0x6D83190", VA = "0x186D84790", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6D847F0", Offset = "0x6D831F0", VA = "0x186D847F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D849D0", Offset = "0x6D833D0", VA = "0x186D849D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D84410", Offset = "0x6D82E10", VA = "0x186D84410", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D84470", Offset = "0x6D82E70", VA = "0x186D84470", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D844D0", Offset = "0x6D82ED0", VA = "0x186D844D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x227C9F0", Offset = "0x227B3F0", VA = "0x18227C9F0")]
		public Invention(long CMEADPACGME, int FPDJICFHLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D84340", Offset = "0x6D82D40", VA = "0x186D84340")]
		[IteratorStateMachine(typeof(OKCAAJAHIJL))]
		private IEnumerator<DictionaryEntry> MELOGLGGLOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D84A80", Offset = "0x6D83480", VA = "0x186D84A80", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D84650", Offset = "0x6D83050", VA = "0x186D84650", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D84530", Offset = "0x6D82F30", VA = "0x186D84530", Slot = "9")]
		void IDictionary.Add(object PNABAFEIDND, object PKCLPFEIPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D84590", Offset = "0x6D82F90", VA = "0x186D84590", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D845F0", Offset = "0x6D82FF0", VA = "0x186D845F0", Slot = "8")]
		bool IDictionary.Contains(object PNABAFEIDND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D84730", Offset = "0x6D83130", VA = "0x186D84730", Slot = "14")]
		void IDictionary.Remove(object PNABAFEIDND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D843B0", Offset = "0x6D82DB0", VA = "0x186D843B0", Slot = "15")]
		void ICollection.CopyTo(Array LOCJOHPCANM, int GCBONJOGHCD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GLLKOBOJGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyList<Invention> EJIDHOCAJCJ;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
	public ILPMJCJHABN(IReadOnlyDictionary<Guid, RoomObjectCounts> DGDPGFPOBBE, IReadOnlyList<Invention> IFMJFLLHBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D83100", Offset = "0x6D81B00", VA = "0x186D83100")]
	public static ILPMJCJHABN ELDCGDEEIKE(FNEPJCIGLHI GJLDCFIFFGA)
	{
		return default(ILPMJCJHABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D82FE0", Offset = "0x6D819E0", VA = "0x186D82FE0")]
	[CompilerGenerated]
	internal static int AOGFJLCKNHJ([In] IReadOnlyDictionary<long, int> LJLMBDAHLII, long? EKOHLNPLPMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D83AE0", Offset = "0x6D824E0", VA = "0x186D83AE0")]
	[CompilerGenerated]
	internal static void NLHCLCHNKBB(int MMGAOGELBIG, [In] DPKHFJKOHKM DILKOBCFNBA, [In] Dictionary<long, int> LJLMBDAHLII, [In] Dictionary<Guid, RoomObjectCounts> DGDPGFPOBBE)
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
