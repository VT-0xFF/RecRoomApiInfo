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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7430EA0", Offset = "0x742FAA0", VA = "0x187430EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DGHDOGHJNFE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> NIGKILDLLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> BMHMCONFLPP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> ENBALJBNGPD;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LADNJOIGIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BBGGIAAOBEC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string PMGBCLPHCCE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string OCHIBHPCAMH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x741BCB0", Offset = "0x741A8B0", VA = "0x18741BCB0")]
	public static bool PBDBNNMLBAK(Guid IMGMBBELLBE, int ECAIOFKILCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x741BC20", Offset = "0x741A820", VA = "0x18741BC20")]
	public static bool KLJECJOIOBL(Guid IMGMBBELLBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x741B5A0", Offset = "0x741A1A0", VA = "0x18741B5A0")]
	public static string EKDILKHCFNN(Guid IEIMOIIMGDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BALEJJMDFEO]
public enum FKOABPJJACI
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
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7430570", Offset = "0x742F170", VA = "0x187430570", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CKOPFOBGFKH
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid NCGBOPMMHKB;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid GEEHMBGGMKO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid NAOEMBHCNMH;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid GMKCDNFLCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid KIBIGEPJBPL;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid DDKGGABOFFP;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid CFIKIJPEMFO;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid EMMFKNGMILO;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid PPFPIPHOOPB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid ENJOKPCFNND;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid JLJGPHOLPHI;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid KFFLAGFPBAJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid BIFBCOOOHFK;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid BIIKCNBINIP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NGDFELNEDCG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid PCMCDGEIMDM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid CLMGFKJABGF;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid KLJJFNNAGDA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid AINDMAFJNEP;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid HLIMDCAGAPD;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DGHHKMFNNCC;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid APOIJFMEGCI;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid NJANJDLAPPB;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid OMGBFAMDCAI;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid FADCLNPLLKK;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid IPGGMPHGABA;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid IBCEFNLDMED;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid INCFBDAFKDM;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HMNKCNLHJKO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid GDCPOOABOOE;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid LANLELDJBMC;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EALLJDIAEKA;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LDGAAGKIGKN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid NCKMIPKGGLN;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid EOKMDHMAFID;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid AEHAFJCAEIA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid GCINNJDBFBH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid LODENDBKLBL;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NHCNCCKDBJA;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid APONJBHADMN;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid ALBAPIKNEOF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DGKFDEBFFPI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid LBAOBCFHPCJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid IBKCCKLFBMD;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HIMEAEHJFFM;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NHFOOHOOGJF;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid KNIKJFAPFLP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GMIKOLHFMJK;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid FJCBIAKFMOA;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ILNBAHBAAEK;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid DBIMNCLDDBO;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HJNLKOKCOKI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CCOIJOAABMB;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BKPMDCIPDPK;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid PAJPMOBCIGC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid OMHHNEFDDFH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid ADHFEHIKAMP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DNBNJHBDOCN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid CCKKLMCGCPA;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid GPJDBADIAID;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid COEDHOKPJPE;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid IBECBJLDNKJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LBDAOFFKDCA;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IPNLDLNOEEO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BKBLLEFOKAD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid EELJMDABCHP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid DNNAJKPEKND;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PHKEHMIGEPB;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid OELDGHGAKBA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JBJFAHJMDCG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid IIOLKGHIHHM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EMGHDAAIGGH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DAHGJBPJKIP;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GDFGJHNEFJB;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid JPHAOBMJJFM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NGIFPFGNEEI;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid ODCLKNGIMNL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid DJOGPGOGIOC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OEIBMFKIBAI;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MCNLFCABODK;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DMPMPMKDOBO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AAAFPBCHLFJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid JJCFNJNLBNC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FDAABFMAFAN;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid ODKPOJLEAMG;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid IFKICFDMNEA;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AGEHFGIGPID;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid HDIBPKLGOEN;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid ADKDFPNDMPJ;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid OFDGKFCFMNJ;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid AOBKLGEPJNH;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid LEBJCHKKKHG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid ODPLIOGHKKM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid CCIBHHMNELN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid PLCOBGAMDKE;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid KOOBEEPMPHO;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid IFPICFPLHBK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid HMHEEJCBLIE;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EMNGJGONAFN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid OJIOHLFCMHF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid AFOJFMMELLL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid ODAMGJIMMEF;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KICNKBIHAHK;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid HCDNLINAHEL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid JPDGIMAACFA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid ADFCPKAECIG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid LNGHKMJLPLN;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid OGKIIEJPNEJ;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HJJBCBEILPD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid KKFMDGONBNG;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid AKICAGFNPBM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JMGMBEAKNNA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid AMIFBMNEMDH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HGKJGNCNACJ;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OMCLOMJIOCO;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid EDIIHJDCFIK;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NFDOIPGMAHO;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FOKNIOLENBC;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OINJNODCIED;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CHKJBICOCEI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PJCIOOOBCEL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JDMDICGJPKD;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid MADAGAFGLOD;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid PFDCOIIKGPJ;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid AFHEBEDJCHL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid KILBGOAALGB;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid OOCGLOFNIJG;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid OAIHLPLJLPF;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid LJJHAABBCGB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KNHBJPEDMKF;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GIIFOPEGJEE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid LEBAIJLHPAK;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid IHCPFHKOMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid BKIIOFCECKK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid OFJELNPIHJB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid OFOAOKHODBA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IJHJPFBEBCB;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid LKLMJJEIELM;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid NJPEMONNOLL;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid AEFKLCODCOO;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid AKFFHJCBOIN;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ILANJHNPPHD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NLBOBJAFJDH;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid PDDIPHIMJNF;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid DMFIJDNCBPO;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid DNGHNCHHJOP;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid INNDEOCPJOK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid OGECGPCHECI;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid PDCDBPHHAIM;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid GDFFJLNEEEE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LCHFCDGHMKA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid CDNFODPGKOP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HEGEDBKBDIM;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid NMJLCNEPHGA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MNIKJGMBFJP;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid IDPIOCCJDPM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid NFBGEFOLJGF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IBJNGOJAMAF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid ODEAKDFPLBL;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NGCEOMBAAOL;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid KJNIIMGEHAE;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BONEMPDBBBE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FNHFOGLLMGE;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KDGBIOHOJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid OLIFPONCAGO;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HHDMPEDJBCE;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid ONGBLKKIHNA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JOEMBCHNHLL;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid CEJEIBEDFNI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid FJKOCFILOEG;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HOMKHCHHGCB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid HPAABMMDJMO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DNADIECGNML;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid DGKGBNOEGCB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DGNFKDCOOIM;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid ILKODDKDDGO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid CEFAPBLKGBC;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PONNKGLPLCL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KAAPIDHINCG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid BICDIBCPFBD;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid AOMLMEBCGAC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid AHDBHBNBJHD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid AJLLMLHBDJE;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid FLDDBGONMFD;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid MCAGBGADNBG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FJNMLPFKCMM;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid BHFLDOGMEMF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid FPDABCCEGJC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid GPEMNPAACON;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid HNADPLOPODD;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid BKINIFPMHPH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid PBNBGPLAKIO;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid APPCADOHFAB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid JBIFJAKAOFM;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid NFEOPJMOMFA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BBDFHJCEBOC;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid JCJPEJICENA;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid AMLADBNDHLG;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid ECGKONAMFPM;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FIFMNEGDHLK;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NDONAJEHLCK;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FEJDLEJOHLC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid MGDEOEMMFBO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DCFAEECNCBK;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid LHDDGIDFNFN;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid MHCCFJAHIDL;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid DIKBHAHFGDD;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid ADIGEDIDGFJ;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid BPPCFMPHBFF;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JAFKBFEBGBC;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid KNDMOMJCIOH;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid LMGHKLKCMGE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PEPMHBAEDLN;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid LFEAIDLPOOD;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AGDIFJKNCJP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AIBIPFIBAFC;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid EPOGLHJFLOA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GFJIAHNOKPO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid EJDMFOPKHAM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CJHDIPHIMIP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GGIEIEIEHKH;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid ODLJCPKMODN;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LHCCAKBPOMF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NCBDKJLHAIA;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LIIIHLKJJCP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KAFNGCOABBC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid KBBJFMPNFHN;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KCLOAONMHEF;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid BGHPGPEJJMI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JENODHIJDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid BBLJIAAODJA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid CEAMMEFPONK;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DGHOGCOCBCL;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid EBBLGCFNMBL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid IOLJIJDGMPH;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid OFMCBAPAHNL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OFJDFJDLBPB;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid HDODJMNNDKC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid NPELIEKHABI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CIGPCJINMGE;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid ANLDBHPAADF;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PAFPJCIBKJA;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid CNMEEODHILK;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DFEJDNCECNM;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid GOPKGJNOIAG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid EBAILECKIJK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FIKEFBBBBPK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PDIEKBNALLB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid APOIMAJJNLA;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PCBAPDEMBFM;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid JBPJBOLOGAN;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IFEBGDIAABP;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid HGJIDPPMGFA;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid HNHJGHLJEGG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OMHJAJJDKBO;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid BODHHDLLJOL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid BNOFFKNHEAF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid ICEODMCMCAL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid ONINPBBODGB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid NHHDKGDLMMM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MFNNANFEDBP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid MHCNBDBDNDF;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PFLHKAENPON;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid ECHJPLMELGF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid LHPHLENDPKI;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BHAPJCPALJE;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid CNBPAKLBODD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid BDAIIJILHGB;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid DLAGHLMIAIC;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid OJOCIGIIEKJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid OHGPHDHJOKH;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid CMEOHAELEBC;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HIFIHOOGHLB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid AILMOBBGEFL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid FLMPKCANMIG;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid PABMHKOMKML;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GOJECDOJBMH;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LMKNPJHGBHE;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid PCFJLJKFBAM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GEHNBJJHJMH;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid MOAKHOEDHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid PCBGOMNKKCC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OPLIEFKDMGA;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid HKEMIILMLDM;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NDJHPNHKMJF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NPOKEGFAHKJ;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid FKOJDDDJAOF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid BNKLHGBCKGJ;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CDLLOEJFMOF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid OPIJBEJNAGF;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid OAADEHLIALH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid KLKGJPPFOMP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HICMIDPAEDM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid CEKMMMCLHJJ;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JGAOFMIJKMM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HGEKMKHIMEM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid LLKHIEENJIK;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid GFHPPMKLJEC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FJKJLBNFIAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid PCMEPDFODMN;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid IOLCINCNEPA;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MJPHGAHNKGL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JEBKLCFDGBL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GPOLGBMHIKA;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid IHJHOMKCOLO;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AMFPEADOLDG;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DGJANMNHDHF;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid FOOFJACOLFA;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid CGNFHMFFPKF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EDDFMODFEOH;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid KMGMJHLFIFP;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ACCNLAMJDLJ;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid LAAJHPMIPJA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FLKHCHOAKCF;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JIGGEAAKLDI;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid EGKJNONDLKL;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid OCKHMFKKMKN;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid LHCLJPPNCHI;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BGBKEPCPKJJ;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid OKBHPPKKNFI;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid PLKJHAPPIJA;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EFNHPMFCLGM;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid CONPDGLGLAA;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid OMJEMHDPJAO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LMAFDOAAKOD;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid BGOIOLCODFL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid GOIEOJKMAIH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid NNMOEIPDANN;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CNGGHACJNFP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid CAABDNGPAOD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid HPNFKKFPLNI;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid OCEGFIGKBIK;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid NBJMNHNOCGH;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid IMNLJOHJMFM;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid HAEEKEDNHEM;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid EFKMLNGMMGH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid IICKAGOBBDD;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid FGOCJIMNJOA;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid BHOGLLIJNHC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NGNBBHNFLKM;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid CHJBHBBHFOK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HEKIIFNCMMN;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid EHHBBLFNGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CINDFIJDOMA;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid NGONGDJGIHP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid PKANAKCMENI;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid LMJCMPOMLIA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid EJNCLMHDDDC;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AOCIMECKDLO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NJKLFCLBHID;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid HNHGBDDMDJH;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid POBNBDCJIOL;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid PKFBDAKCHFP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid GMMHKMCKAAB;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid OBKGNJDBHEC;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid KGFPNBPKMLG;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid AOHPLNGEABO;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OCJMHIMNMEI;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid ALFLDHIBPKG;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid KACOOAKBPFC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid NEILLOKEKBC;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid HGMGDDLNNOA;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FIMCPNKHEFC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid DOGFAGMICMG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PBABLANHNCD;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid ELNMHIIIJFC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid ACCEEPDFBKA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid GBEOPAENOFG;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid BMNDOJMOIDO;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GCJFHBCAFMC;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid IEAKFDPNFIC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ANPGAPEOIIG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid BCNPEBBDBED;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid OBEMBMGEHJM;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GPINAHMBDJN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid IDLJJABOAMF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid AMMBFIJNBIK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid NFJMGLFLEAE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid POMIEHICGKN;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid HLCLEEICIBA;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid DADAFFEEEFG;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid AGNBAMACKNC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid PICHMPIDLFG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid LICHHLOLJJH;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PCMGNJMFEFN;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid ICIFGJKAEAP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KPGEJGLMIFC;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid KLEEJJGCKLD;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MKIBDKJCKBP;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid KDOBPHFPLMA;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid FLJJEIMCOIL;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid NCCDFCPPDEC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid IJDGCKNENKD;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid HGNNALKFGNB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid JNAFGJNDHNA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DKNGAABDDLC;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid CDMHGDIHMOO;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid JOGKNLHGECH;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FJMKOBCNJPD;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EJAGPMNAMLG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid LJANKFNPJAP;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DGBNCCDANJP;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ELOFHOLGKLD;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid FCDJGLEAAGN;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid NHGHONMBDOH;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid DKPMAGLNPOH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GCINLMCADHM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid FCKDELANONK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid EEHCMFPJOOA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid PBCOEGNKFCP;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid HLBMPNHFFLK;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid ACHDIELJKJD;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HOKBFHEIKKI;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KNNFGBAOBAP;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid OJCLGIBCONA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid ONLNLDANGLI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LHOKLMEPENE;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid MGOMCBCHGGJ;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NDNBHPPHGDE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CMEMAMFEDIE;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid PAFMBNNANGK;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PEKBIGNFPKP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KCONOJCKBJE;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MEOOAGJOJHE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FLLEFJIIBCP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid PNIKPEODKGL;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid NDFBHKKEEGB;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FMFMMIKGOAC;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NNBJPDAEDNK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HJMMAMGFIOK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid NANLBMAODII;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid IJBGOLHDIBA;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid MOMEKMGLDEN;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AOEGEFGECPP;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DAGMHINCNJM;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JMBNBMPFNFP;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid FGCDCHIICEG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid KIMBLOGHHKI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid DGNGHOFFJJH;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid EJJGKAJAMDB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BBLDDAJBFNF;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BBDLMKFACDM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid GJOBCKDMPFB;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid GLPEBAKHBII;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IIIBGPLMBKI;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid BLDAKAPCIGB;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid EBILNAMODFC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid PKLJOFAEJCL;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid PGLEGKPKNCK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EAGKODHFKEE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PNEKCLDINME;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid DMJHKFLHMMP;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid FMIHNKEKHJD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid GJCOBLIMDPH;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid GBAJOFLGKGD;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid EIMMOOJHLCM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid JLBCAJDFDPP;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid NIOGPNMKKOI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FKGCAEGENDL;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid NKDEGHMCFDG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NJJFPMDJHMO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid OAFNENCOOGE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid CBHGJEAIGDK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid HEAAOAMLMDD;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CLFGKMCPHLO;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PACHJEDOKIM;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid HJOFPIKLCDL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MPFIIEEMBFC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid LPNINEKHIBA;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EGFMMKKAKAD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KMFFJHGGHIH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid ADLBNONMMNM;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid LGBACBJFOIB;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid KCALJKLKCEI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid GGJDJAOOPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HOJIHMOAHEF;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid HFEBNPKHGME;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MGGPFKDAJKN;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid AIKLGGDDFKG;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid GKMCHGBLBOI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CNDDNPNAINN;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid CBFIAJDFCDI;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid OCKNIOFBPLP;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CKBCALOKIHL;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid LHHDJABFJGA;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LGPHKIPCLMG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid PGMHAHJHNNF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PHOEEOICNCI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HMCGFDOIOKC;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid CHHKFOAIKFL;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid BAHCFNJBMBM;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CMGHKEHOMNN;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid AFFBDJEONAD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PPHODHDBBKF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JMPGLLKBAIH;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid CANBPIJPEGF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid IDCAIAOAAMP;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GOLMNFDKFGE;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid KDGHCBLHIOH;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid JCLEMDMGOJB;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CJDPHECEFJD;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid FAGNLPJKMPB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KLAEPCIGIPI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid PBKCKOMAPNA;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid FGCIEPKHKOE;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid KGBECFCFNII;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FBBGHJABKED;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid NJHAEIGGNIA;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid GDLMFKIHEKI;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid NHFGJIMGAKN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid CNOBGLEGMEI;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PJKCCKMPODL;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid OBICPPFAOPK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid LBEKDFIFPCE;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid BLBBOIHNMFE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HHEJHNDJJBB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid JFIDEHDAPOB;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CABGFCOFCCI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EABLPPOAFCO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FJNIJHPLHLO;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid FEOOOFBAHGA;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JOABDHKCCBD;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DFKKBELLNJL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid DHNHFMMGFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid DHOLGFCMEDD;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KKAMLOMHPMC;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MJAMFOKKOHE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JDJKNPOBIHJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid BPNACLIJMAM;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid OIOKADFFBFO;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FMMPFCNJKJN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MIAHPJAONJO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid OMDGIDNAANM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid DHODLJJDMAO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid JABKOJHONMP;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OFHNEJNECPE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BMEJGKFPOFE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HFCNCAEDNCL;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid OMFIHJPIBNN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CKJGEONPMOO;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MCHKIHFAHBM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid CAGEBPCMFGB;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid LEJLDIGEOIP;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid APLBAIGLKJF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid IBPMFMBBLOO;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid PFJNAAAACHE;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GBEBMCHFJIM;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid JIABFDALBHC;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid DBGMJHEIMBG;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid NCHJBEDGMLE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid MCNJFNPPEHE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid OEJAOKDAGEA;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid MFKFHMPKGMF;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid OCLPKFKIMNA;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid BBFLCNGJDDJ;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GEPGJDLBACP;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid LLENPOKBHIB;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid KPNEFLFHOMI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid BJIJGHPMBLO;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid GIHOLJANABB;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid JNBOHCEHLHK;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid CNCGGLGDEBK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid KLDGDIMIEIN;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GAODINALMPP;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid MBLIBMMCFAO;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid GKHMPPLAICH;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid AEJHPGHNEHM;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid FDNMNDILFNO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DJLPABAPHNK;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid MKDMHECCNFK;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid CMBPBBNCCCG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid HGPBBKOEJMC;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid ICCHKPFIHEF;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid OFMJILBCIEJ;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid OFJCECPGLMP;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid FDDFBBLABCE;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid OKKFMCHDBLO;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DAAMPAGKPFH;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid KEOLOGNGCAJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid EKLKEBICOPD;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid GMMHBABEBAL;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid MOOKMPLKOME;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid OKPPPABKPOJ;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OBDDMMNKHKL;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid CKPCNHOFDPK;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid HKNPPCJFKCM;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid FIDJIOBNPGG;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IGEOGNGJEEI;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid IAAPDBLBCCC;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid GEAIDGNPJOH;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid NMCDDIAADBD;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid EEHLNLFBLCF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid OKPFHHACGEH;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid KHJMBMELHOM;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid JIPHDOBNMNI;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid GJKKCBBEALN;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid OIAHCCFNGAP;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid DEJPIDCHPJN;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid CBBBMBHAEON;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid PDNOKJPGGEN;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid FEGMBLKKAHD;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid ILKCGCDJOAF;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DGNNJBNBPLO;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid EDOEICDKCPB;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid FONNLGBBPBO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid IONLNGDOJPD;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid HOFMAFKJOEO;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid BDJCOOKGKAO;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid GAINODABIAK;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid NDHBALBMCHL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid PDMJGFCJKHE;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid IBBPFBPJCPI;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid AJFICFEOCIG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid CKLILDLBFAD;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid HBCKCCKFFIH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid EBIONOFDLEH;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid HFAOPAINMGD;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid JLFKCPAHEDD;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid DKIFBGCFIOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid EJLPPDENBNO;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid CLOFFIKLFMN;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid AEMNGCJONJM;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid KMEBNOELCCO;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MPFAEBGENNO;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid BBGHHPFOFDH;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid HNDPFFPBPAG;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, FKOABPJJACI> MEJNBJMBBKH;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<FKOABPJJACI, Guid> GJJAKCCIDOP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FKOABPJJACI> BLDAMOHBJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x741B0B0", Offset = "0x7419CB0", VA = "0x18741B0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FKOABPJJACI, Guid> BHGGHFDIDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x741B100", Offset = "0x7419D00", VA = "0x18741B100")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CMAFEPMGJDE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x741B500", Offset = "0x741A100", VA = "0x18741B500")]
	public static bool EGHGEOIGMFO(JKKNKENIIMD AHKKDJFABOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x741B150", Offset = "0x7419D50", VA = "0x18741B150")]
	private static bool EGHGEOIGMFO(CBPBFKPJEMN HDBPBMNJNAE, JKKNKENIIMD AHKKDJFABOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AAEHJCEIOPK
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CMFKIPEKNHA LLDJIJICLJF, [Out] Dictionary<int, int> ONNABKIDLNA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(LFHJKKOJGDF LDFCHIDCOJO, EJJEPLPJLHC HBLPELFEFFE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EKPGMMCOMAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly OHBPKAHMOIH FFFFPBPFGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<IJKLPCMEAKO> DBEEOHAKMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<IJKLPCMEAKO> IALLGHDEDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly ENBGACDEBPI<DGPIFHHHHCH> FOBAMAPMJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> EKGDJMIJJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly KAPFOGFENJP GMKAPENBLDP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LGEEPCNIBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x741FE90", Offset = "0x741EA90", VA = "0x18741FE90")]
	public EKPGMMCOMAM(OHBPKAHMOIH IAMPAJLOAAN, IEnumerable<IJKLPCMEAKO> BDMCKILHPML, IReadOnlyList<IJKLPCMEAKO> MNHGHCBLPOO, ENBGACDEBPI<DGPIFHHHHCH> NFHEPCKJDMF, IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> AOAAFBPPKAI, KAPFOGFENJP CLNNLNNPLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DFKHJIHJHMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly OHBPKAHMOIH FFFFPBPFGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly IReadOnlyList<IJKLPCMEAKO> LHKKIHIIODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly ENBGACDEBPI<DGPIFHHHHCH> FOBAMAPMJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public readonly IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> EKGDJMIJJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public readonly ByteString KLEFIGFDOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public readonly KAPFOGFENJP GMKAPENBLDP;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x741B530", Offset = "0x741A130", VA = "0x18741B530")]
	public DFKHJIHJHMG(OHBPKAHMOIH IAMPAJLOAAN, ENBGACDEBPI<DGPIFHHHHCH> NFHEPCKJDMF, IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> AOAAFBPPKAI, ByteString GMNDLLOLLKK, IReadOnlyList<IJKLPCMEAKO> JJALGDAMGFN, KAPFOGFENJP CLNNLNNPLFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PNAILKKAMPJ : OCFNHOBIMFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public readonly Guid ABKGFDPNJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly Dictionary<Guid, Guid> LIJANAIJBCD;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x445C670", Offset = "0x445B270", VA = "0x18445C670")]
	private PNAILKKAMPJ(Guid BKOKKPFHGPJ, Dictionary<Guid, Guid> LIJANAIJBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7431460", Offset = "0x7430060", VA = "0x187431460")]
	public static PNAILKKAMPJ JPHABLICNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7431320", Offset = "0x742FF20", VA = "0x187431320")]
	private static Dictionary<Guid, Guid> FCMKHNHJICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7431450", Offset = "0x7430050", VA = "0x187431450")]
	public static PNAILKKAMPJ IJBCCIPBABC(IReadOnlyDictionary<Guid, Guid> CGPMLCFDDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7430F90", Offset = "0x742FB90", VA = "0x187430F90")]
	public static PNAILKKAMPJ EPLBPPJONOB(IEnumerable<KeyValuePair<Guid, Guid>> CGPMLCFDDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74318C0", Offset = "0x74304C0", VA = "0x1874318C0")]
	public Dictionary<Guid, Guid> NFJENOPLHLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
	public Dictionary<Guid, Guid> IIBFEOLHBOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74313D0", Offset = "0x742FFD0", VA = "0x1874313D0")]
	public void GFCJDEIJPEO(Guid CGPMLCFDDHA, Guid DNBDCKCECAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7431640", Offset = "0x7430240", VA = "0x187431640")]
	public void NBCCGHKLHNG(IReadOnlyDictionary<Guid, Guid> DMGDEBCOOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74314F0", Offset = "0x74300F0", VA = "0x1874314F0")]
	public Guid LHABBFCFGEM([In] Guid CGPMLCFDDHA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7431280", Offset = "0x742FE80", VA = "0x187431280")]
	public Guid FBEBPKAKPHB([In] Guid CGPMLCFDDHA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7430F20", Offset = "0x742FB20", VA = "0x187430F20")]
	public bool EECDKGABNNN([In] Guid CGPMLCFDDHA, [Out] Guid DNBDCKCECAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7430F20", Offset = "0x742FB20", VA = "0x187430F20", Slot = "4")]
	private bool KNOMFMIHKHD([In] Guid CGPMLCFDDHA, [Out] Guid DNBDCKCECAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DMBMDGFBIGM
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
public sealed class FJBCAGEHKMC
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GHEIDFBEFHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public OHBPKAHMOIH staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GHEIDFBEFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x742FD90", Offset = "0x742E990", VA = "0x18742FD90")]
		internal ENBGACDEBPI<FBBBJKCECFN> LNBKHFHNOGI((ENBGACDEBPI<DGPIFHHHHCH> GraphId, ENBGACDEBPI<CALHCHFEDII> NodeId) i)
		{
			return default(ENBGACDEBPI<FBBBJKCECFN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private static readonly EMOAAMIFIJJ<FBBBJKCECFN, int?> OJIKOACJKGB;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private static readonly long PJNGKBNFKKB;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7420140", Offset = "0x741ED40", VA = "0x187420140")]
	public static (long, long) HEDIFLCJNGM(OHBPKAHMOIH FKLOBKAIMOF, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x741FF00", Offset = "0x741EB00", VA = "0x18741FF00")]
	public static long CBFBMLIBIJH([In] ReadOnlySpan<ENBGACDEBPI<FBBBJKCECFN>> NOKMEDDPMKP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7420020", Offset = "0x741EC20", VA = "0x187420020")]
	private static long EEGEGGKBFMK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LCAOHFFOKOC
{
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly HashSet<FKOABPJJACI> IOGGGABDJDM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DOBNDCPJDPA
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KOMIGDLFBCG : IEnumerable<IJKLPCMEAKO>, IEnumerable, IEnumerator<IJKLPCMEAKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private IJKLPCMEAKO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private KPBMHFMNIMG spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public KPBMHFMNIMG <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private IAPMEHDOJEA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public IAPMEHDOJEA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IJKLPCMEAKO System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public KOMIGDLFBCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x742FE00", Offset = "0x742EA00", VA = "0x18742FE00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7430080", Offset = "0x742EC80", VA = "0x187430080", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x742FF10", Offset = "0x742EB10", VA = "0x18742FF10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IJKLPCMEAKO> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x742FF10", Offset = "0x742EB10", VA = "0x18742FF10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x741CDD0", Offset = "0x741B9D0", VA = "0x18741CDD0")]
	public static KPBMHFMNIMG CAHCGNEBOJP([In] DFKHJIHJHMG HOCGGFEBNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x741CC90", Offset = "0x741B890", VA = "0x18741CC90")]
	public static KPBMHFMNIMG CAHCGNEBOJP([In] EKPGMMCOMAM HOCGGFEBNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x741DBC0", Offset = "0x741C7C0", VA = "0x18741DBC0")]
	private static void HAHHIAOICFA(KPBMHFMNIMG ECIDAACMOEO, [In] EKPGMMCOMAM IMDHLNEGPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x741E290", Offset = "0x741CE90", VA = "0x18741E290")]
	public static PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG> LDMMAHKLMED(KPBMHFMNIMG ECIDAACMOEO, IAPMEHDOJEA HICNPFMJNCK, PNAILKKAMPJ? CKBGBPOJOEI, bool PJMIOFIBCEK)
	{
		return default(PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x741FD80", Offset = "0x741E980", VA = "0x18741FD80")]
	[IteratorStateMachine(typeof(KOMIGDLFBCG))]
	private static IEnumerable<IJKLPCMEAKO> ONEKCINHDEG(KPBMHFMNIMG ECIDAACMOEO, IAPMEHDOJEA HICNPFMJNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x741E220", Offset = "0x741CE20", VA = "0x18741E220")]
	private static void IABEBIKGPPJ(KPBMHFMNIMG ECIDAACMOEO, IAPMEHDOJEA HICNPFMJNCK, IReadOnlyCollection<ByteString>? OCMBPMOHCKG, IReadOnlyCollection<ByteString>? HMJKMKIMBDN, IReadOnlyCollection<ByteString>? ENGHLAJIBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x741D530", Offset = "0x741C130", VA = "0x18741D530")]
	private static bool GNENGJAEOFP(KPBMHFMNIMG ECIDAACMOEO, LFHJKKOJGDF LDFCHIDCOJO, IAPMEHDOJEA HICNPFMJNCK, [Out][NotNullWhen(false)] string? AHPAHIHOBBE, [Out] Dictionary<int, int> ONNABKIDLNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x741CF10", Offset = "0x741BB10", VA = "0x18741CF10")]
	private static Dictionary<Guid, CBPBFKPJEMN> FBKGINAHEPE(KPBMHFMNIMG ECIDAACMOEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x741FCF0", Offset = "0x741E8F0", VA = "0x18741FCF0")]
	private static void MOFNIKLOLMI(bool MMHHGCPEPKO, IJKLPCMEAKO AIINMDJLKBF, PNAILKKAMPJ DALIJOFADKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x741D1F0", Offset = "0x741BDF0", VA = "0x18741D1F0")]
	private static void FILFHGBPGAP(IJKLPCMEAKO AIINMDJLKBF, Guid DIDCADGGMMP, MNLCFMIOFJN? KGPANHKJHDM, Dictionary<Guid, CBPBFKPJEMN> NNBJDOOCPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x741F840", Offset = "0x741E440", VA = "0x18741F840")]
	private static void MFMDANOMJDA(IEnumerable<IJKLPCMEAKO> AIEPILJGPPH, IReadOnlyCollection<ByteString> OCMBPMOHCKG, IReadOnlyCollection<ByteString> HMJKMKIMBDN, IReadOnlyCollection<ByteString> ENGHLAJIBFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IAPMEHDOJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public bool MMHHGCPEPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public KAPFOGFENJP CLNNLNNPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public MNLCFMIOFJN? KGPANHKJHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public MNLCFMIOFJN? CCNJIMDNGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public OHBPKAHMOIH EHJPNHIKACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public DMBMDGFBIGM IEBJCKIBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public AAEHJCEIOPK EELDPIJOIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public LFHLJBHJLKP<DGPIFHHHHCH> GKILPDBCBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public PFLINFPPFJG HAMNMHFILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public List<IJKLPCMEAKO> PIPJPFDLDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public JLHPGPMALFI DCAEKEILAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public EHHLICFHPIH NPOILLPGGMC;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MNLCFMIOFJN
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private const float KLNCMLGGOGE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Vector3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public float PCNANBOKIPD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 NNEHAKOPACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7430BB0", Offset = "0x742F7B0", VA = "0x187430BB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS MPOEJABJDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74308F0", Offset = "0x742F4F0", VA = "0x1874308F0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x11A8E60", Offset = "0x11A7A60", VA = "0x1811A8E60")]
	public MNLCFMIOFJN(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float PCNANBOKIPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7430DD0", Offset = "0x742F9D0", VA = "0x187430DD0")]
	public MNLCFMIOFJN(UniformTRS IEOLKDOINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7430930", Offset = "0x742F530", VA = "0x187430930")]
	public static MNLCFMIOFJN NJOJIBDCPCO(MNLCFMIOFJN KOIBCEOILEL, MNLCFMIOFJN AMKKKNDBMLI)
	{
		return default(MNLCFMIOFJN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x74308D0", Offset = "0x742F4D0", VA = "0x1874308D0")]
	public static MNLCFMIOFJN NIBCGLOMJGK((Vector3, Quaternion, float) LLDJIJICLJF)
	{
		return default(MNLCFMIOFJN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7430750", Offset = "0x742F350", VA = "0x187430750")]
	public static MNLCFMIOFJN NIBCGLOMJGK(Matrix4x4 INKHLKDOLGB)
	{
		return default(MNLCFMIOFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7430D40", Offset = "0x742F940", VA = "0x187430D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7430670", Offset = "0x742F270", VA = "0x187430670")]
	public MNLCFMIOFJN DKGFHOBNMDA(Matrix4x4 FDCDPIOJPOG)
	{
		return default(MNLCFMIOFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7430600", Offset = "0x742F200", VA = "0x187430600")]
	public static MNLCFMIOFJN BNECCOFHANO(Vector3 FCININPMBGJ)
	{
		return default(MNLCFMIOFJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7430CB0", Offset = "0x742F8B0", VA = "0x187430CB0")]
	public readonly OJLANLIGMEM ODNOEMHMOFA()
	{
		return default(OJLANLIGMEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum JOGKCNJOCFG
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct LMPLNLANAGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly PFJMEDFDHJA NMBGIIICMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly PKJJHJMDMCJ PEPFKPIFNDI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x142BCA0", Offset = "0x142A8A0", VA = "0x18142BCA0")]
	private LMPLNLANAGG(PFJMEDFDHJA KMMNOOJNABL, PKJJHJMDMCJ JOEINONLOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7430500", Offset = "0x742F100", VA = "0x187430500")]
	public LEALKEHEBGH PDHKHMNBBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7430450", Offset = "0x742F050", VA = "0x187430450")]
	public static PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG> JPHABLICNHB(EOOPJDAPPNP<BODKGJBCKHC> JOEINONLOPA)
	{
		return default(PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74303A0", Offset = "0x742EFA0", VA = "0x1874303A0")]
	public static PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG> JPHABLICNHB(LEALKEHEBGH JOEINONLOPA)
	{
		return default(PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74302E0", Offset = "0x742EEE0", VA = "0x1874302E0")]
	public static PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG> JPHABLICNHB(string KALBEMGDPNL)
	{
		return default(PNJEPLMEKHI<PNAILKKAMPJ, LMPLNLANAGG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PFJMEDFDHJA
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FMCLECAPJDP : IDisposable, EHHMHNLIKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private NativeList<DPNIHIHALMF> JCJAIFCCLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private float MPBOIPOFPID;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AELPFFMHMMC HPHKIBIIDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0")]
		[CompilerGenerated]
		get
		{
			return default(AELPFFMHMMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MOFBNKGCGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x742F9F0", Offset = "0x742E5F0", VA = "0x18742F9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool GBGAHBMPFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x742FC80", Offset = "0x742E880", VA = "0x18742FC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<KEONOEIAPHE> BKEDJHFHKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FPKDIECOOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x742F200", Offset = "0x742DE00", VA = "0x18742F200", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float DFGFIHGICPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x742F060", Offset = "0x742DC60", VA = "0x18742F060")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x742FD00", Offset = "0x742E900", VA = "0x18742FD00")]
	public FMCLECAPJDP(AELPFFMHMMC HOHMEIEFKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x742F1A0", Offset = "0x742DDA0", VA = "0x18742F1A0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x742EB90", Offset = "0x742D790", VA = "0x18742EB90")]
	public Vector3 DDJHOJPMENG(int MGPCONLELFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x742FA60", Offset = "0x742E660", VA = "0x18742FA60", Slot = "6")]
	public Quaternion MNGJGDGLKPC(int MGPCONLELFP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x742EA60", Offset = "0x742D660", VA = "0x18742EA60", Slot = "5")]
	public Vector3 CBFFLDADLPJ(int MGPCONLELFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x742F3A0", Offset = "0x742DFA0", VA = "0x18742F3A0", Slot = "7")]
	public float GMBGJMMACGK(int MGPCONLELFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x742DEF0", Offset = "0x742CAF0", VA = "0x18742DEF0")]
	public void BCEIIDCEPEP(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL, bool NBMGGGEBHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x742FA00", Offset = "0x742E600", VA = "0x18742FA00")]
	private bool LOEFAPIJHJO(int ODCBCCAPCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x742F400", Offset = "0x742E000", VA = "0x18742F400")]
	public void JCGHPIMPPHP(Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x742EB00", Offset = "0x742D700", VA = "0x18742EB00")]
	public void CNCPCFKJGPI(int ODCBCCAPCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x742D5A0", Offset = "0x742C1A0", VA = "0x18742D5A0")]
	public void ABEJGNCOBCA(int ODCBCCAPCPI, Vector3 FCININPMBGJ, Quaternion APLHHNGOEFP, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x742E7E0", Offset = "0x742D3E0", VA = "0x18742E7E0")]
	public void BCJDPOOGJDJ(int ODCBCCAPCPI, float3 FCININPMBGJ, quaternion APLHHNGOEFP, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x742FB30", Offset = "0x742E730", VA = "0x18742FB30")]
	public void MPFCOEGIOGH(int ODCBCCAPCPI, Vector3 FCININPMBGJ, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x742F240", Offset = "0x742DE40", VA = "0x18742F240")]
	public void EKCMHKMFFMP(int ODCBCCAPCPI, Vector3 HKFKAONALCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x742D6F0", Offset = "0x742C2F0", VA = "0x18742D6F0")]
	public static Quaternion BBENJLABAJA(Quaternion PHEHLBBHLCL, int ODCBCCAPCPI, float GGHIDGLOOFM, EHHMHNLIKNI BMAODIIHJOI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x742F560", Offset = "0x742E160", VA = "0x18742F560")]
	public Bounds JDCJJJLMBKC(Transform FDCDPIOJPOG)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x742FC90", Offset = "0x742E890", VA = "0x18742FC90", Slot = "10")]
	public virtual void OIGOGOGMJKC(bool GGGNLBKFDHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x742E990", Offset = "0x742D590", VA = "0x18742E990")]
	public NativeList<DPNIHIHALMF> BEODJCDJBPN(float KFNEAMPEIHO = 1f)
	{
		return default(NativeList<DPNIHIHALMF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KEONOEIAPHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float3 JCCKFLFINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public float FCKKJPHCMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public quaternion HIDIBEBBBIK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7436A90", Offset = "0x7435690", VA = "0x187436A90")]
	public KEONOEIAPHE(Vector3 CHHMDBOKADH, Quaternion PHEHLBBHLCL, float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74369D0", Offset = "0x74355D0", VA = "0x1874369D0")]
	public Quaternion NLJJBLMAJPK(Vector3 JJPEELBONAL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7436540", Offset = "0x7435140", VA = "0x187436540")]
	public KEONOEIAPHE HDPJEBLIIMJ(Vector3 PAHKAOONLBH, Vector3 HEPGPEPNOEM, Vector3 KLGJLGFOOAA)
	{
		return default(KEONOEIAPHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7436830", Offset = "0x7435430", VA = "0x187436830")]
	public BFKMNMNILGP MGLBGMAKCIH(Vector3 JJPEELBONAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class AMLCMOKOIIL : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74324E0", Offset = "0x74310E0", VA = "0x1874324E0", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7431F10", Offset = "0x7430B10", VA = "0x187431F10")]
	private void FPCOIMNEDFC(Dictionary<Guid, Guid> OLEJNLFGMKK, AHGDDMENMKG BEJLDCDPECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7431EB0", Offset = "0x7430AB0", VA = "0x187431EB0")]
	private void FPCOIMNEDFC(Dictionary<Guid, Guid> OLEJNLFGMKK, EHEIKAPMFHF KKPFCDGAFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7431C30", Offset = "0x7430830", VA = "0x187431C30")]
	private void FPCOIMNEDFC(Dictionary<Guid, Guid> OLEJNLFGMKK, DHACNKEBBBP CGHGBBIEEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public AMLCMOKOIIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class MDNNAEAEKOB : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7437D80", Offset = "0x7436980", VA = "0x187437D80", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MDNNAEAEKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class NCHKNCMHHLC : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7437E30", Offset = "0x7436A30", VA = "0x187437E30", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NCHKNCMHHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class OBBLCPBAKCD : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7437F90", Offset = "0x7436B90", VA = "0x187437F90", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public OBBLCPBAKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DAGBKKPBEEL : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7433CB0", Offset = "0x74328B0", VA = "0x187433CB0", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DAGBKKPBEEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DIIJOPOFACF : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7433ED0", Offset = "0x7432AD0", VA = "0x187433ED0", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DIIJOPOFACF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OKJGIPPKOMM : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74380F0", Offset = "0x7436CF0", VA = "0x1874380F0", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public OKJGIPPKOMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PPELBKEDDJH : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7438420", Offset = "0x7437020", VA = "0x187438420", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public PPELBKEDDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JKNMIAEFPHD : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7436390", Offset = "0x7434F90", VA = "0x187436390", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JKNMIAEFPHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AIIMLLEPOGH : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7431A80", Offset = "0x7430680", VA = "0x187431A80", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public AIIMLLEPOGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class HAHAEHMGDIG : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7434010", Offset = "0x7432C10", VA = "0x187434010", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HAHAEHMGDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MAHLCEOCJLA : DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public static readonly ABDBKMGLNJE CHBPDKBKJFP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7437C50", Offset = "0x7436850", VA = "0x187437C50", Slot = "4")]
	public void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public MAHLCEOCJLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JKKNKENIIMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public LFHJKKOJGDF HBIBCNEICNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public MBJGAHEFDMD FBFKFDNKPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<int, int> HKLONHOPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public Dictionary<Guid, Guid> OMIDJEJLGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public EHHLICFHPIH NPOILLPGGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public bool PJMIOFIBCEK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DEBFICMEPCC
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHNPFDEIILF(AAEGJBKBCOL DHGCEHEJGAO);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LGFHJBJPPPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static readonly DEBFICMEPCC[] HHMCHHELNDB;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74373E0", Offset = "0x7435FE0", VA = "0x1874373E0")]
	public static void OCKEGLLBBJB(IJKLPCMEAKO LLDJIJICLJF, PNAILKKAMPJ JLKHLKEBBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7437150", Offset = "0x7435D50", VA = "0x187437150")]
	public static void HOLPBHPABAB(IJKLPCMEAKO? LLDJIJICLJF, PNAILKKAMPJ OGJNJOKDOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7436EE0", Offset = "0x7435AE0", VA = "0x187436EE0")]
	public static void GGJGHJBLKPJ(IJKLPCMEAKO? LLDJIJICLJF, PNAILKKAMPJ DALIJOFADKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7436B10", Offset = "0x7435710", VA = "0x187436B10")]
	public static void EGHGEOIGMFO(AAEGJBKBCOL DHGCEHEJGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AAEGJBKBCOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public LFHJKKOJGDF MHFFOINGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public IJKLPCMEAKO AIINMDJLKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<int, int> HKLONHOPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Dictionary<Guid, Guid> OMIDJEJLGAF;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74319E0", Offset = "0x74305E0", VA = "0x1874319E0")]
	public Guid MHJAILLLLDF(Guid IEIMOIIMGDN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EHHLICFHPIH
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FOIDGOHENEH, [Out] Guid HMFMCENPKAI);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class IBODDJGEHIP
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly ProfilerMarker FHHLKJJGPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly HashSet<string> IPCAIPACAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly Dictionary<long, int> GGBGIHPDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<Guid> PBGGDFBAHIN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> DALMHOFPEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyDictionary<long, int> CDBBHGGKKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7434110", Offset = "0x7432D10", VA = "0x187434110")]
	public static IBODDJGEHIP AHIKBLIPCLJ(OFOCKDHGIHJ FDFFMDBCAPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74356E0", Offset = "0x74342E0", VA = "0x1874356E0")]
	public static IBODDJGEHIP MGFIDMFHKBM(KPBMHFMNIMG APIIEDFENEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74354F0", Offset = "0x74340F0", VA = "0x1874354F0")]
	public static IBODDJGEHIP HNGGPLDODBM(IEnumerable<string> IPCAIPACAEK, IDictionary<long, int> CIPJDFMOMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7435950", Offset = "0x7434550", VA = "0x187435950")]
	private IBODDJGEHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7435810", Offset = "0x7434410", VA = "0x187435810")]
	private IBODDJGEHIP(IEnumerable<string> IPCAIPACAEK, IDictionary<long, int> CIPJDFMOMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7434D90", Offset = "0x7433990", VA = "0x187434D90")]
	private void HMDNOOCOKPF(OFOCKDHGIHJ FDFFMDBCAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7434F90", Offset = "0x7433B90", VA = "0x187434F90")]
	private void HMDNOOCOKPF(KPBMHFMNIMG APIIEDFENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7434300", Offset = "0x7432F00", VA = "0x187434300")]
	private void FEFPMDBELDP(ByteString? GMNDLLOLLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74347E0", Offset = "0x74333E0", VA = "0x1874347E0")]
	private void HMDNOOCOKPF(KDJKOMDCFOO? EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7434C50", Offset = "0x7433850", VA = "0x187434C50")]
	private void HMDNOOCOKPF(JECOFFIBOIC? PCMPEACCDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7435190", Offset = "0x7433D90", VA = "0x187435190")]
	private void HMDNOOCOKPF(IJKLPCMEAKO? AIINMDJLKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7435670", Offset = "0x7434270", VA = "0x187435670")]
	private void LFFBCPEHELF(string? KBPKHEHMOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7434180", Offset = "0x7432D80", VA = "0x187434180")]
	private void BBCBPGLMFNE(long OOEDOCIBMMO, Guid KEBCHNMAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74342B0", Offset = "0x7432EB0", VA = "0x1874342B0")]
	private void BBCBPGLMFNE(DFKNNJOILJK? NLJLIIABPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7434250", Offset = "0x7432E50", VA = "0x187434250")]
	private void BBCBPGLMFNE(JPKPFAKDMEJ? NLJLIIABPON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AONKHBKKCDA
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class BNPKBKLKJKF : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private readonly IEnumerator<DictionaryEntry> JOPPOBNNBDD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DictionaryEntry DKMAMPICOCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7433A80", Offset = "0x7432680", VA = "0x187433A80", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public object JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7433B50", Offset = "0x7432750", VA = "0x187433B50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object GNLOKINMAMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7433C00", Offset = "0x7432800", VA = "0x187433C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object OAKKBGDNIKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x74339A0", Offset = "0x74325A0", VA = "0x1874339A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
		public BNPKBKLKJKF(IEnumerator<DictionaryEntry> JOPPOBNNBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7433900", Offset = "0x7432500", VA = "0x187433900", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7433950", Offset = "0x7432550", VA = "0x187433950", Slot = "9")]
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
		private sealed class OONHFLNNIBC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x74383D0", Offset = "0x7436FD0", VA = "0x1874383D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public OONHFLNNIBC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7438280", Offset = "0x7436E80", VA = "0x187438280", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7438380", Offset = "0x7436F80", VA = "0x187438380", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7438AE0", Offset = "0x74376E0", VA = "0x187438AE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IDictionary.this[object NKANGPLHEGE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x74389F0", Offset = "0x74375F0", VA = "0x1874389F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7438BC0", Offset = "0x74377C0", VA = "0x187438BC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7438930", Offset = "0x7437530", VA = "0x187438930", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7438990", Offset = "0x7437590", VA = "0x187438990", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7438B60", Offset = "0x7437760", VA = "0x187438B60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x74385F0", Offset = "0x74371F0", VA = "0x1874385F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7438650", Offset = "0x7437250", VA = "0x187438650", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x74386B0", Offset = "0x74372B0", VA = "0x1874386B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
		public RoomObjectCounts(Dictionary<int, int> OMOMKICEODK, [Optional] Dictionary<int, int> FEHIAFIEFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7438510", Offset = "0x7437110", VA = "0x187438510")]
		[IteratorStateMachine(typeof(OONHFLNNIBC))]
		private IEnumerator<DictionaryEntry> GDCINFDCPME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7438C10", Offset = "0x7437810", VA = "0x187438C10", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7438830", Offset = "0x7437430", VA = "0x187438830", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7438710", Offset = "0x7437310", VA = "0x187438710", Slot = "9")]
		void IDictionary.Add(object NKANGPLHEGE, object MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7438770", Offset = "0x7437370", VA = "0x187438770", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x74387D0", Offset = "0x74373D0", VA = "0x1874387D0", Slot = "8")]
		bool IDictionary.Contains(object NKANGPLHEGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x74388D0", Offset = "0x74374D0", VA = "0x1874388D0", Slot = "14")]
		void IDictionary.Remove(object NKANGPLHEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7438590", Offset = "0x7437190", VA = "0x187438590", Slot = "15")]
		void ICollection.CopyTo(Array CPOMPIIIEGC, int BIEEMEKMINN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class BKNNEAOAPBN : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xAA6F30", Offset = "0xAA5B30", VA = "0x180AA6F30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x74338B0", Offset = "0x74324B0", VA = "0x1874338B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public BKNNEAOAPBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7433720", Offset = "0x7432320", VA = "0x187433720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7433860", Offset = "0x7432460", VA = "0x187433860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x74360B0", Offset = "0x7434CB0", VA = "0x1874360B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IDictionary.this[object NKANGPLHEGE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7435F80", Offset = "0x7434B80", VA = "0x187435F80", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7436160", Offset = "0x7434D60", VA = "0x187436160", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7435EC0", Offset = "0x7434AC0", VA = "0x187435EC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7435F20", Offset = "0x7434B20", VA = "0x187435F20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7436100", Offset = "0x7434D00", VA = "0x187436100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7435B40", Offset = "0x7434740", VA = "0x187435B40", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7435BA0", Offset = "0x74347A0", VA = "0x187435BA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7435C00", Offset = "0x7434800", VA = "0x187435C00", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x25280F0", Offset = "0x2526CF0", VA = "0x1825280F0")]
		public Invention(long HGEMPDBGGBJ, int EBDKDADIOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7435A70", Offset = "0x7434670", VA = "0x187435A70")]
		[IteratorStateMachine(typeof(BKNNEAOAPBN))]
		private IEnumerator<DictionaryEntry> GDCINFDCPME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74361B0", Offset = "0x7434DB0", VA = "0x1874361B0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7435D80", Offset = "0x7434980", VA = "0x187435D80", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7435C60", Offset = "0x7434860", VA = "0x187435C60", Slot = "9")]
		void IDictionary.Add(object NKANGPLHEGE, object MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7435CC0", Offset = "0x74348C0", VA = "0x187435CC0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7435D20", Offset = "0x7434920", VA = "0x187435D20", Slot = "8")]
		bool IDictionary.Contains(object NKANGPLHEGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7435E60", Offset = "0x7434A60", VA = "0x187435E60", Slot = "14")]
		void IDictionary.Remove(object NKANGPLHEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7435AE0", Offset = "0x74346E0", VA = "0x187435AE0", Slot = "15")]
		void ICollection.CopyTo(Array CPOMPIIIEGC, int BIEEMEKMINN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HMHEOEBHCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly IReadOnlyList<Invention> JDHACGMNLAI;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	public AONKHBKKCDA(IReadOnlyDictionary<Guid, RoomObjectCounts> GHMLNIHONEE, IReadOnlyList<Invention> JJBBHCEPEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7432560", Offset = "0x7431160", VA = "0x187432560")]
	public static AONKHBKKCDA AHIKBLIPCLJ(OFOCKDHGIHJ FDFFMDBCAPG)
	{
		return default(AONKHBKKCDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7433600", Offset = "0x7432200", VA = "0x187433600")]
	[CompilerGenerated]
	internal static int NKLIAINFBLM([In] IReadOnlyDictionary<long, int> IGIFNABENPL, long? OOEDOCIBMMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7432F40", Offset = "0x7431B40", VA = "0x187432F40")]
	[CompilerGenerated]
	internal static void LOHOLHBNEFM(int GNAOHBJHHII, [In] KDJKOMDCFOO EAFFKCEOACB, [In] Dictionary<long, int> IGIFNABENPL, [In] Dictionary<Guid, RoomObjectCounts> GHMLNIHONEE)
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
