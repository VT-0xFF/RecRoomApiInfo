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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BCE5C0", Offset = "0x6BCD1C0", VA = "0x186BCE5C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIKMMBIDNOH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> OOKBJJFDKEN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> NMMHAKBDDPC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DBEJFFAMOPA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> APKAMMFOMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MGBDFMHNCHP;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string OJJHPKMPFLD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string GJKONDDJHHE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8580", Offset = "0x6BB7180", VA = "0x186BB8580")]
	public static bool KHDGAFFNFPA(Guid ANDKEFDBCFG, int KBKNDNPIFAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BB84F0", Offset = "0x6BB70F0", VA = "0x186BB84F0")]
	public static bool GINOKIIGFNE(Guid ANDKEFDBCFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7E70", Offset = "0x6BB6A70", VA = "0x186BB7E70")]
	public static string GADJLKNPJBN(Guid OCIHAODAEFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DFPPDPPNNOL]
public enum MLEJLIDKOIK
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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9FB0", Offset = "0x6BB8BB0", VA = "0x186BB9FB0", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KHPIBIMCEIO
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid MPBOKLONALG;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid GOFIAGOHCMB;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid NLIBFFLFKAN;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid MLIFLOHHAKK;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid OGMOIMGJABA;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid KDOFJPAPANF;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid FKECJEGENLI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid LAGEDPFMBKF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HALEJPHALEN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid NLFCCFHGCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid AOILPGBJBGA;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid COMNDGHBPJN;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid OFJNOBHFBKG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid IEFFNFPEJKA;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid GEDPHBCLJGH;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EONMLOKBMBG;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid GLFFLAKMKMM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid JEDHKHLEJIM;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ONMGGDLBCBM;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid GMKDNGEDDCL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid JEICEELIKJA;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid MLNHEMGKLBN;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid PGKEBHCBHPK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid BJPDKMHMIJD;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HFCOEACLILP;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid AEAOBCEMBKI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid EBBFDLOPALB;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid MCGPODPHPJL;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HPGHAFDGDNA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid IMIMMOJNJLO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid IANEPNJKMKN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KGNGIAAPMPO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IGCLKKDGJFG;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid OPHDJCLAPOJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LFIMCLPAHLO;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid NDIBLOIFJCG;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid PMGMOHLBGCJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid OEIDMFCHEJD;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid HINNGNDIGND;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid EIPNFHFEPBE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid CLGNLFBEGFA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid LAFFNDPLHDL;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid PAMFIFHPBAI;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid MOKAJPGFLFB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid IKDFCIBLPLI;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EBBNEGEHDHE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid IKJKFGOJBMG;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KJAHFKMBDPM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid AMJEABJOOJH;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GAHNPLAGGBL;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid BBJCILDMDDK;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HGNFJOLFAJJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CMKEMAJMKEO;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid POJGKDFLHEA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid AHKCAPFMOPC;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid PMKMAPAMOHJ;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GKAJLNODLKP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DOOPICJMKCF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JNPAMHPLPJM;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid AMIBHHEHIJJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FJJDHFDNIAA;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid EJFHADLPAPO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CIBCEAEOCFJ;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LAMLCIGEABF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JFFEPGPFEIP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MFDLMICDIEN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JNJMJIPLOFM;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid KPAMAPGHDKJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid APENFHGNJAD;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid NLFEAFOEFPI;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid AIIBIIMGLIF;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid COKEFFLHPCM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid MOALAICLDDG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid JOFALANOHNI;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid DCMDEFFELAJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid CHACMOJJNII;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CABKICMOMGO;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FGHBPOHEKBL;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BFMFPDAHNAK;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid KHEPAGEKLDG;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid AFIDANIFNMO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid GIMNABOLKGK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KFBPDDEGGMD;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GABIFKIDEGE;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KLFDHOBIDGA;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid FFFGMJBHPAM;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HNNPCAFCCIB;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid JGBJJEBFNBF;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid DGOJLDHIBFE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid LCCCMHPHEHL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HNKACCHJDON;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ACIBAIJAJKM;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LJDCOPIILIC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid PDFFCLBBCGL;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid NKKMMKAPMGC;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid EGNCKBGGAAC;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid AGPGMAFGNFP;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid FLCPDDKINJJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EIFLEHJIDFM;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid NHCMPFIHPEA;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid BLNNDOOIAAL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid PPFEOLCEMAJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid ODGMGDILHDB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid AGPJPALDDGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GPPBJHJAGBH;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JLCFEHJNGHL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid EFJBNOFEICG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IPKDKEBDNIJ;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid ODNIDOKDOLE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HFJLEPHDOOD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GKOHJJNABOM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid IOCMHAKDAMN;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PMDJKGHAMJM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DADMBNCHEMA;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OGKLMIIMEOL;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid AGGJLPNHNFI;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid JLMICFAPEIF;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid COGCAIHMFFG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FMICGFNCKEF;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid ADJFHFLNBGE;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid AIKDDHCOIML;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid IPHCABNAEKK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LJCLHDOCLOL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DGNIHEIOKMK;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid FLONJJAMCIK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid GNNOBMBFNMC;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid HNDJGOCMJOE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid BLPEJLENONB;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid BIHFJPAOCPL;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BBEELGKICFI;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EMEJCIGDDNE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MIJOFEHMOEH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LLNMBNBGMAF;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid ACCIGOIOMDI;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GBCKMCKKPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid PDJHKACHIDM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DJMAJFFNKBP;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GOHEDCPJDNM;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HIADGHDCCDO;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid OIDHCHLPPND;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid KFJNNPCEGEF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid COCAOFLGDPB;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid ADJOEBDEIAA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid PLBLOLOIIII;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid HOBNLBGOJME;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid NBOCFDLIPLJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BAOAIEEFMFH;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid LGCPBKHEEGM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid AEJCGEMLGOB;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid NDLFKGKNIBM;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IKFJNKCGKFC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid NKPJFBFKEPK;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid AMBHAKONANB;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid ANNCEHBLNPG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KKPIHKJACBA;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BIFKFHHPGMC;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid IBEGIIOKFFB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HHHGLAKGNEF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid BKDIMDBCPIK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid OLLBKOPBJAI;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid MHIBGOPBBAO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DLIFLHDFOKP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid EBFABHLBFPA;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid CFKKEFCBNHP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid NIOBGAFJGIM;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GEIDKGPAOMC;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid JFHNNGJDMDG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid OKDNHICFEGO;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid BPGHMIAMCIG;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid NGNJKAJBCME;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid GDJDHONFFKC;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid HPNANLBHCFK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IOAJMINDCOJ;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FLNCBFLONOB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MEALBCLHGFD;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid DLLJICHENNN;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NCILLMCBPDN;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid FMDECCFDOBE;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid NJDGDAHMOOD;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DDAPGAPLAGN;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid PHOJEIBOHIC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JHMDJPJJOOK;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid COLCIHHLGKK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid DMNLPMNDGDG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid JAHCJADDLPN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid IFBJCMHMPAD;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid CIEPFMODKED;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid PGPKFNMIMDG;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid EIAALJDJANO;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid OJHKKGEBLKM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GONGBOMEDED;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid CHEGIHBBLGB;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PHEILAMPPGH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid HDILKGJBIOO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid KLANIGIHFNA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JBCJFKLNFNC;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid JKNEBENKIDO;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DGBKHBGPFMB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DKKPEHEEELH;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DJEDEMFIKKP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid IICMNOKOPLD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FNBFEEDPEFE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid AMBDIIFANKI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid BNGNCHEAICH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid HIDPAOJGOCO;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid NKONDJKIPNO;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid BABLHKLOFDK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DHBGHMLGDOC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid HNJKPPDMCEP;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid ELHEIIFHMIN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PFMGADNIENG;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DKEGFHBCMOK;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid MLBFACKELHO;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid DFHENBOKMPE;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid NNDKLBGAEPG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AOAIFBPLJIC;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IFANHKCIINE;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid LOKCBFCKBKA;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AFNAICBGFAE;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PBHOEBJPICO;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GJEJBIAEGLD;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MIOBLIKONKB;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid CIHDKECKNMB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid FDFMMNHFGJC;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PGDLNBGDDOA;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid EFICJGEIFDI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid MBIJHKLLFOD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid MGFBJNGLNIE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid LFHGFHGAIIE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid FGLJLJFHPCK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HDHHGDGOIGA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid JPANAHHHCJP;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid EAFMLEBFMFE;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid NPCEKHDAGLB;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GGDMBNPEIEM;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid HMBPJDFDNNE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid HDEBMEOMBCP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid DABEEOENJOC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid BEBAILBLOJJ;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid IPONNOJPCOL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KNIIDBNBOIA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OMOMCNDBOOH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid CHHKDAKFHOG;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid MOCPBEGLMAF;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid FMFJFNJJDGE;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid JOHBECHILFP;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid HMHOIFEPAHC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid LNDGNCHEDBN;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GAMEMFNPDAH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid OMMMKLPPLNF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid IJAAIDPIFII;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid DJKKEJLABBF;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid JLBABCLPLEN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KKLFAGNCKJM;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid ANOBGDAHIOH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PAJCPGBMKEN;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JAJHAEMOLEB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid IOKDCDAALHF;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid FJCCPOOLMKF;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid MMNKJNLBINK;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MPAEMGIHGCE;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid OABIGFJKEMM;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PJGKNHOHMPL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid MHKFNLMMGLL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid OHBIEFFNHNI;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FNPEFLAAECG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ENBDPFHOEMN;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AJHFGPJFJCL;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FJEIENDKDDJ;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid IFPEFBEEALI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KAAKAGNLGMM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LJOALAALNNN;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BEHBBHDGGEA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MMHMBGLEMEC;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid OBBBAOGKJEO;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid CEBEODBBBGK;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid OIJMDCIPJIG;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid EEHCILDDGFP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AOIBIEAMBOF;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OJAFJFFEGHI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HJGNIDCEAGN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid IBDFFNAFEPC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid MMCAKIPMLFI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid ILAHFMJLECF;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid ACDFAHOBPGF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NOJCMDCCNGD;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid HIHNBFHABEC;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DNMJCMNGFAE;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid PINKGEBFHED;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid ABFIMEACFHM;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid KEOIIJCPNMD;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LLMIGAGKHPB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EADCMACEMAD;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EFEAEPLMIEN;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LNHGNFNMJKL;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid BPEODFNLLDF;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid NGJIJOPEBAP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid IDPDJLIKBCO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OLAEABDOPJD;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NLILCIGHMGN;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FPFJHMBAEPO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid OALJHAKJENJ;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IBEJMJIEADD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid LOLDGMHPKAO;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HHCFKEPFNPG;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NDEIEAEFEOH;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid IHCBEKGPANE;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid IMCALCHLAJL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NDLJFOBDKBD;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PAGAPDJEKGH;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid MMNJNHNJLPF;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid FPGGCBBBAHF;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MADLJEMFPBM;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid PBDDHBMFDFK;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid ICFOMFPDEHN;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid CGOHINBMENF;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JLOBBCDDMND;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid HDIIJELHLLP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid DDJMFKLLAFD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FKIJJAAGNMF;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid OGAODGPIGCB;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid HAIEKCEAGCM;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JKOHFAFDDGG;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AJEHDLBNDCO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid GEIIFFEGNKC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid FLDGICLGBJM;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid JPMGFNEHBCC;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid PIECGPKGJBK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JIOHCOGCOAC;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid LPPCFJPMLOO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid HNKNADHHLOK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BGPAOFIAJFO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OIPKJJJGKGO;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid PPHPHBGMMJF;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid MKBMPBMLPGD;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IPKEJCFBMCP;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid GNDPMLOLMNN;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid NPFGMHBFCLH;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JEPHOJMAFHI;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid PMEDFJNHKBP;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid ECCOHDODEJA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid FODPCHAALLP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid BOMCKLDNBMM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid PKAAMGAJNDM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LDCDHPMANLP;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid AIJJPGJKMOI;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid PDENIAJJAPL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CAJMDGEKKAL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid LHBPBLOFJMG;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CPCPDMEJPNH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PKPCJELNKBC;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PDPNKPMNIHO;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FNODJONPNBA;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LLHIHHDDEBG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid EFNNCCGAJHM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid ONAKGBAKBLH;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IMFEALCEKJJ;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid BAIIEGOLMOO;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NANCMNCNDAD;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EBKLMAKJAPN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JKOBGJDGLPH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid BNAGHPGCENB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IIIAKJPHDDN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid OIOGNFCOPFF;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JLCICNFEFMO;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid JBCLKPLEKJP;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HAFIEBFDMPC;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KHOFDAMCBNA;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AHMGJIEIJOF;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FJENKAFFMDN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid GADPHIOGLJD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid IEBJKKKOCKP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid EENEKIHCPEM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid BFIDNGINKND;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid OBLDOKNCCDM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid NLLNFEDCBPP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid HAECPOGNLHB;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid MBOCACNGAGG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PKHGCLJCNBD;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid DLBPNOKCGPI;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid OCAPFAMJIFN;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BLHDHPDLNFD;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid AAAJMNICHNG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid GPMFHMNEMAH;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LGPCGLBIBKN;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DGNKLCGELOP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LIGFHBNJNPA;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid GEILNINNMAL;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MEEEMJHCKDO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid NPBKDLEABOO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid OKAHBFEJADN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GNPMMLHCBAM;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FDKAOOABKDI;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LCCNNBOLMGB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid IBHIFOMOJDA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid JJAPFLHPJHK;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid JMPKAFEDIHA;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DOENFFNOHHN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid NMHEDPHFHPK;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid JGNJIKEHMJF;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid PGNKGLFJHKM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid HDIDFAKIFNE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid EOEMKOMEBIJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid NAIFBFHGPLL;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid BMGHGPFIPCD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid PFJJPGHJDEO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid INNJNFEFEGL;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid FBAPNFPEPCH;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid GLPKDNLJMGA;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid MNGHFCBMFNK;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BPIGNAPOIHM;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid GNMJIHMLMKN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid BPJEADKKHDF;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid ICAKJGAAFMJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BBMIPJFFNOC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid PHCLKIOEKID;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid MLLFDBCFJJI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KAMCNLDLEBH;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid BAMBHOKOANH;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid MPDFNBGFIDK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid CKAPPGLPFMP;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid JCEGHPLALMD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DPFFGKFNDDI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid PNGEDPMIEPD;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid IEHNECMCGKM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid CDPKCEMKDEL;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GKJNLMKNCJK;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KNDHCKILHJO;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BDPIHMKNDPF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid LJFAKPKOHKB;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid KCMPFDGIIBB;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CMECLOHNLPK;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid JAHHLCLHOJE;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid CGENOIBBIGO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid EELMBOOBBJI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid KGKDBPDFNCK;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid MFKMFEPJPAG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid ODGECGCPKBO;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid JGNKOPFACML;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid FMFPJDPMODK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid KHNEBHKIEGE;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid MBGOJOMGHAH;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid HEKNIDGJABC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid FACONDFHENI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GDADLFJJFJD;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MCEMJBCOJDE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DLNGPBAHONL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JAGGLODKOME;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid AJIGBAOOFMK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid HDDEKOLEKOO;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid AHHMGCHOCDM;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid KKFNLNCNMHC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid OANFOFIJOCK;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MDMOJEKEECG;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid LGKIGICPJMP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LKMDAFBIECL;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid FHCBMLOJDBB;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid DMOLDDJHKBN;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid DHGGNODGEOC;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid PHCGMLIILHC;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GOFGCMDMAFJ;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid JMOBMNKNEPH;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HFCPAJCIJDC;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid CADNHGMMNFN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CKGINODIJAN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid EFGMECIDLHA;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid PIEBENPAIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid IOEBHMMGAMH;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid NPEEADPCPEI;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EGIDFCBLLHD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid HODANCGOONH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid DFJHLKNFDLE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid LIDKKJEHLIE;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid MNIMGBDEDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid LFJCEJHPJIH;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid FPLABFOFCBC;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DEPPLCJLFPG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GKDLNOCOLOE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid CFDEELHBNOG;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid LGMDPDCMKIP;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JGEPCEKAEHA;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid GIOPHIKCLJH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid PAACKGGKNHE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid IPOPPJHMJKC;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ONLLNJDPPIL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MMPFFCIEEPN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid FMFOOKGDOCC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid PFOMOHJLJED;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid NAGOIIIKOMD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid NPNEMMLCLKF;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LBJCAPPDAKB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid BHEEEGNCMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid LBLLLFLJFKN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid ONIPFAMPIOE;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DIMLKGHHIJO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid KJCOCDDKEPE;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NKENHHIHNHI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid NAINAAMHKMH;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid JBNJIFGGIID;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MOCHIHDEDKN;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid KLCKLFJBJJI;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid GKNHPKPJDHP;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid OGEFHHDOGHH;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid AIABGMIPCKC;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid KFMEHGMCIPI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid KEKDFOJEPAM;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid OCAMNAKPCMM;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BNDFBDPKJOL;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid PBJMDJPIDLD;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid MNMIADMOCPB;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid PCDDHNBDKDD;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid AOGFIFKEMJN;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid BMEMOEFANNJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid BLLOHGMJPOP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid NMMEEOEDJND;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid AFMHOEDFNEF;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BOAOPJOKNDA;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OMFNFDNEGMF;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid FBJCOFAHKAM;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid KILKBMDPPGF;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid COIFNLDEOCL;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid OMIMMHGPEDH;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid KPGCCHEBGJL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid PEMGHDKLMHE;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid AIACJGPDBAN;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid KNDEDHKEAGD;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid HFKDCPCLFGI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid GFBPGFENJLL;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid IPFINFAHNJF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FPGCMKFPBFO;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EJJAKICEBKK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MELCFDHFDEB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid LJDHFOBEJCM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid DPMBGCBBONM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KGPFKFMOGKO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid KLMDCONGKHI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MBHBKHOCCJH;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid KEIMMKLHNHI;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MBEIJLJDLIC;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CNMOBMLFIKB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid DDPMMKLBGBM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid EGLPPGPCCHE;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid DJMPJJIGMNG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid FHAMPPPJFAC;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid MEBDPPAKEGL;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid MAEDPGMIBJP;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid NODDBPKOKFF;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid DFGOGCDDPLD;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OLPOIFNPNAO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid JIPFLHKICEC;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid DKPEDLIHPCK;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid JDKDKBMMIIN;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid JLPFCGODACC;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LDCIIFBDEFJ;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid NOMCBPDPJDF;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid FGAGNBIKEEI;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid FPLNCGGGGBL;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid EFCDHJAKFJP;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CDBLDNIDMIA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid GLHHACLJCIE;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid JKGPPAPJKEA;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NEFPPBIBCAA;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid PDPPOMHBJCP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid DOLADHEPNEJ;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid KJNMMJGEFLE;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DAAFPFHHEPP;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid LJCCDNBENII;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JICIFFCLAPK;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid NACPLGNHPDP;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid NFKONHFKAEP;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DFHGBAKKKOG;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid FNGDHNAECAL;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid HFJNNNDGDHB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid IKAOPPOGNGE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid DBBJDPGOKKA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GINPECELAKF;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid BBMJIACFBBG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid FMFBKFDKHBN;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid JBECIJHGEBM;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid JMPEPBAOENG;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid MDEIOGHKCCH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid NCJCDCEJDAM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid KJLPOLNMMNL;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid FEGMADIECKB;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JJJGDMDJGDJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid ADJENIOPIOM;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid AJONFPFKPKA;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JGLAEIOFHAD;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid JGILOIEKJFK;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid LHILAPBHNOM;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid EPCECNGJHIF;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LOIABDCCLEN;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid IDMBAHFAHFA;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid KHCJHFHBEPK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid JNBKEHKDLIG;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid AAJFOLLODLL;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid CHBHHPEMCLI;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid IFKHPOOLFKL;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid EIJANELOLMG;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BDFNIJGPJOL;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NAPODEGNEHB;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid OBEGPNMKCLH;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid INGNAJAANBP;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid MDEDCJJIPDL;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid ILAFAENCMJI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid CCAEEDHHEED;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid AGFMFOEPJJN;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid IAIABFFHHJM;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid MGMHDFIBOCB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid LLONDOPFDCC;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid IJIKCOHJPEE;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid PAILEEIFING;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid OJFOBAMIIKB;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid GJEBEDNKEAP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FIHCLOAPNPG;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid PCIBKLMFDJJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid CFBLKPBEDFG;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid CABGIPLMACM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid LFDOGAJIPPC;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MJBLPLMFKBB;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid BDOGCGPKHDO;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid FEJJHNLBIIC;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid FBIEMOHAICI;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid JNAOFHOMCCE;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid LAONHIMFNDC;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid ANAOHAKBFKE;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, MLEJLIDKOIK> GFCOAAPOMGE;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<MLEJLIDKOIK, Guid> KCNFKBLECHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MLEJLIDKOIK> ELJNPAPDONL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9620", Offset = "0x6BB8220", VA = "0x186BB9620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MLEJLIDKOIK, Guid> PFHEJBMGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9670", Offset = "0x6BB8270", VA = "0x186BB9670")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OJAGPNILBLN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD20C0", Offset = "0x6BD0CC0", VA = "0x186BD20C0")]
	public static bool BOCFBFGJEGL(LCOLMPHPMDC BOKNBEPKMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1D10", Offset = "0x6BD0910", VA = "0x186BD1D10")]
	private static bool BOCFBFGJEGL(IAFKMCJGOCF NEMFFPFIOFE, LCOLMPHPMDC BOKNBEPKMLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct JPFEOHCBOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly DCMDDGDMJKM MLOKBPPHBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<GLOMMFEJNDK> JBCMOLBIPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<GLOMMFEJNDK> BCDKHBNMNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly FANMFDLLPNO<LNEKKJBHBEC> JAPEOBEEGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<DBMOGKNBCFK<LOCKFIIFIFD>> DLJPKDDHCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString EGJAEGAFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly FOMGGLLCFOD FKFFDHHMONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool OOFAIHKOFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9590", Offset = "0x6BB8190", VA = "0x186BB9590")]
	public JPFEOHCBOBA(DCMDDGDMJKM JPJOIBILBKP, IEnumerable<GLOMMFEJNDK> PJJJPLDPJEK, IReadOnlyList<GLOMMFEJNDK> IEBBPGLGAMJ, FANMFDLLPNO<LNEKKJBHBEC> NPNCGDOKAPJ, IReadOnlyList<DBMOGKNBCFK<LOCKFIIFIFD>> OLEBNCHDDBM, ByteString LEIDMPPODJA, FOMGGLLCFOD JILGGDBLMLN, bool NOCHPOGIPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BPCNHJBKGHE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(DIPPOCBPGPB BFLLAIFBMAJ, [Out] Dictionary<int, int> BEOHFNFFDJB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(EIJEJLMCJCI OCKLMHINCPC, EMDLLLOHIFC PBGCAJEJAAO);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LFPCHJKFKHB : IFLIHGJFOLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid KPDLGDCKBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> EFCKBNPACGB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> ABJLKPLCPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D64930", Offset = "0x3D63530", VA = "0x183D64930")]
	private LFPCHJKFKHB([In] Guid NBDIHIBFNMI, Dictionary<Guid, Guid> GBELOHJKJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9EF0", Offset = "0x6BB8AF0", VA = "0x186BB9EF0")]
	public static LFPCHJKFKHB LMDPPDEOAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9F80", Offset = "0x6BB8B80", VA = "0x186BB9F80")]
	public static LFPCHJKFKHB PIPKGFOIOEE(IReadOnlyDictionary<Guid, Guid> ODLMKJDIDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9AA0", Offset = "0x6BB86A0", VA = "0x186BB9AA0")]
	public static LFPCHJKFKHB HBBADIICGAK(IEnumerable<KeyValuePair<Guid, Guid>> ODLMKJDIDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9E40", Offset = "0x6BB8A40", VA = "0x186BB9E40")]
	private static Dictionary<Guid, Guid> IGLCHIMBJDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BB96C0", Offset = "0x6BB82C0", VA = "0x186BB96C0")]
	public void ANPPECLIBGM(IReadOnlyDictionary<Guid, Guid> ODLMKJDIDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9940", Offset = "0x6BB8540", VA = "0x186BB9940")]
	public Guid BDDDFNCEDAN([In] Guid OCIHAODAEFD, bool DPJFDGHHFHK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9DD0", Offset = "0x6BB89D0", VA = "0x186BB9DD0")]
	public bool HHEAJLNGMBI([In] Guid MJDOIIBKEKN, [Out] Guid DHGADNMDKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9DD0", Offset = "0x6BB89D0", VA = "0x186BB9DD0", Slot = "4")]
	private bool IHGGNOMILDK(Guid FCAIJJGOPCC, [Out] Guid LMJFOHKAJHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IFNGOBOEDDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ONEKHMHADID
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICHKPGLOBMP(ByteString JOFDKJOIAEP, LFPCHJKFKHB KMCDMFNOFHA, [In] UniformTRS EAKMPNHJEOD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CDCMBNPCDDE
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
public class LPIMJKHIJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB71B80", Offset = "0xB70780", VA = "0x180B71B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LANJGKHLENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x121C1D0", Offset = "0x121ADD0", VA = "0x18121C1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long NLFCJJHJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BB9F90", Offset = "0x6BB8B90", VA = "0x186BB9F90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6860DB0", Offset = "0x685F9B0", VA = "0x186860DB0")]
	public LPIMJKHIJIO(long KNHHBEFLJAF, long IEDEHBEBJMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MOHNFNGIAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, LPIMJKHIJIO> CPGCPMKNHBC;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> INEGAAHPHOP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long ODPAGPPOIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x121C1D0", Offset = "0x121ADD0", VA = "0x18121C1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long MFPBBMLBJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1256DD0", Offset = "0x12559D0", VA = "0x181256DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA250", Offset = "0x6BB8E50", VA = "0x186BBA250")]
	public static MOHNFNGIAFD AOCEEBACOII(DCMDDGDMJKM GFEKMEBHFKL, DBMOGKNBCFK<LNEKKJBHBEC> DPHLKAEABMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA8C0", Offset = "0x6BB94C0", VA = "0x186BBA8C0")]
	private void JLDPEEJOPMB(OCABIDKCHNK HNCCPGMBLOD, long CHNIOJIMKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE530", Offset = "0x6BCD130", VA = "0x186BCE530")]
	public MOHNFNGIAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MGCIHGJONIG
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<MLEJLIDKOIK> LDHDNBEALBO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CGLCGMNCJJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> GLDCCEJIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> NHPMNBOLEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	public CGLCGMNCJJD(IReadOnlyDictionary<Guid, Guid> FHKIGKGBOBF, IReadOnlyDictionary<Guid, Guid> NCGOBJPOJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OBPDEMEGADH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GBEEAHEMBJH : IEnumerable<GLOMMFEJNDK>, IEnumerable, IEnumerator<GLOMMFEJNDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GLOMMFEJNDK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private ECOADAOAAGE spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public ECOADAOAAGE <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private EMLAOMLEKBO spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public EMLAOMLEKBO <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GLOMMFEJNDK System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public GBEEAHEMBJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BB72D0", Offset = "0x6BB5ED0", VA = "0x186BB72D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7580", Offset = "0x6BB6180", VA = "0x186BB7580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BB73E0", Offset = "0x6BB5FE0", VA = "0x186BB73E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GLOMMFEJNDK> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BB73E0", Offset = "0x6BB5FE0", VA = "0x186BB73E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF230", Offset = "0x6BCDE30", VA = "0x186BCF230")]
	public static ECOADAOAAGE EJPNAECFIEG([In] JPFEOHCBOBA DDJGKDOECAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1140", Offset = "0x6BCFD40", VA = "0x186BD1140")]
	private static void KJLOFPCAKFK(ECOADAOAAGE JAEPDPGEJIM, [In] JPFEOHCBOBA KFNHIKADAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF4B0", Offset = "0x6BCE0B0", VA = "0x186BCF4B0")]
	public static OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP> FKNPLOJIJNP(ECOADAOAAGE JAEPDPGEJIM, EMLAOMLEKBO OJOLBLMLPBA, LFPCHJKFKHB? CFPIMBIPMMP)
	{
		return default(OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF3B0", Offset = "0x6BCDFB0", VA = "0x186BCF3B0")]
	[IteratorStateMachine(typeof(GBEEAHEMBJH))]
	private static IEnumerable<GLOMMFEJNDK> FHJJLPDJEND(ECOADAOAAGE JAEPDPGEJIM, EMLAOMLEKBO OJOLBLMLPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BD17A0", Offset = "0x6BD03A0", VA = "0x186BD17A0")]
	private static void MENGMAPIELK(ECOADAOAAGE JAEPDPGEJIM, LFPCHJKFKHB? CFPIMBIPMMP, EMLAOMLEKBO OJOLBLMLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0D90", Offset = "0x6BCF990", VA = "0x186BD0D90")]
	private static void GPMIDMLLIGO(ECOADAOAAGE JAEPDPGEJIM, EMLAOMLEKBO OJOLBLMLPBA, IReadOnlyCollection<ByteString>? ANHLDHJAJPA, IReadOnlyCollection<ByteString>? HPMPIDLKDEI, IReadOnlyCollection<ByteString>? FBEHMJABLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE6E0", Offset = "0x6BCD2E0", VA = "0x186BCE6E0")]
	private static bool DLKFCOKHNOL(ECOADAOAAGE JAEPDPGEJIM, EIJEJLMCJCI OCKLMHINCPC, EMLAOMLEKBO OJOLBLMLPBA, [Out][NotNullWhen(false)] string? IHNODDPNJFM, [Out] Dictionary<int, int> BEOHFNFFDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1A30", Offset = "0x6BD0630", VA = "0x186BD1A30")]
	private static Dictionary<Guid, IAFKMCJGOCF> OKLNNOPHOJN(ECOADAOAAGE JAEPDPGEJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE640", Offset = "0x6BCD240", VA = "0x186BCE640")]
	private static void CBCKDPGDIHK(bool FHHDFEHKFIF, GLOMMFEJNDK GJMLLIMGMPK, Dictionary<Guid, Guid> MNGKFLNNPDE, LFPCHJKFKHB CFPIMBIPMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0E00", Offset = "0x6BCFA00", VA = "0x186BD0E00")]
	private static void HNDKFAJCJIO(GLOMMFEJNDK GJMLLIMGMPK, Guid EFCDLMBDPAA, HMJDLAKFCAF? DBHCNALHAMG, Dictionary<Guid, IAFKMCJGOCF> LDEFFLBPGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCED80", Offset = "0x6BCD980", VA = "0x186BCED80")]
	private static void DNHICLGIMMC(IEnumerable<GLOMMFEJNDK> OFJNNDAKMLD, IReadOnlyCollection<ByteString> ANHLDHJAJPA, IReadOnlyCollection<ByteString> HPMPIDLKDEI, IReadOnlyCollection<ByteString> FBEHMJABLNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EMLAOMLEKBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool FHHDFEHKFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public FOMGGLLCFOD JILGGDBLMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public HMJDLAKFCAF? DBHCNALHAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public HMJDLAKFCAF? LFPLCHCIALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public DCMDDGDMJKM ECEFMIBGLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public CDCMBNPCDDE APPKKAINDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public BPCNHJBKGHE IAMEDGIGKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public IFNGOBOEDDC KCDPBDKNNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public DBMOGKNBCFK<LNEKKJBHBEC> PNIKNBAPACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public OCLFDLEPGCC LCKEAFGJHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<GLOMMFEJNDK> LJAELFDJCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> GJAGKKGGBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public LMCDLOGIMMC KNMIOMOOACJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JPIKOFJMCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7280", Offset = "0x6BB5E80", VA = "0x186BB7280")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HMJDLAKFCAF
{
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private const float KECMGFCDBKD = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public Vector3 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float IMPGFCOPLND;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 GKIDJPKNBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7B40", Offset = "0x6BB6740", VA = "0x186BB7B40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS IGOFFDMNMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7C40", Offset = "0x6BB6840", VA = "0x186BB7C40")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF3A00", VA = "0x180CF4E00")]
	public HMJDLAKFCAF(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float IMPGFCOPLND = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7DA0", Offset = "0x6BB69A0", VA = "0x186BB7DA0")]
	public HMJDLAKFCAF(UniformTRS PLPPHOIFMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB75D0", Offset = "0x6BB61D0", VA = "0x186BB75D0")]
	public static HMJDLAKFCAF COJKACHABCM(HMJDLAKFCAF CDBGCEIGNJC, HMJDLAKFCAF BOFFBDKANEM)
	{
		return default(HMJDLAKFCAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7850", Offset = "0x6BB6450", VA = "0x186BB7850")]
	public static HMJDLAKFCAF FGDKAMMLLCN((Vector3, Quaternion, float) BFLLAIFBMAJ)
	{
		return default(HMJDLAKFCAF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7870", Offset = "0x6BB6470", VA = "0x186BB7870")]
	public static HMJDLAKFCAF FGDKAMMLLCN(Matrix4x4 PJOMAIBFBFN)
	{
		return default(HMJDLAKFCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7D10", Offset = "0x6BB6910", VA = "0x186BB7D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BB79F0", Offset = "0x6BB65F0", VA = "0x186BB79F0")]
	public HMJDLAKFCAF HBGMGKJONGF(Matrix4x4 OHCKGBMFMEE)
	{
		return default(HMJDLAKFCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7AD0", Offset = "0x6BB66D0", VA = "0x186BB7AD0")]
	public static HMJDLAKFCAF JCDALIFAKOP(Vector3 GKJAMFFKDLE)
	{
		return default(HMJDLAKFCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7C80", Offset = "0x6BB6880", VA = "0x186BB7C80")]
	public readonly IKICHIOGDGB OGNOBAEBBHE()
	{
		return default(IKICHIOGDGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum ADJGODIHILG
{
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NCBFEBAFCJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly NAKBOEMGMPK OIFCJBLJAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private readonly OILOBAEJEDE HCNLKCFICEB;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xF963E0", Offset = "0xF94FE0", VA = "0x180F963E0")]
	private NCBFEBAFCJP(NAKBOEMGMPK CHCPEAEKFEB, OILOBAEJEDE KDGACCIDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8550", Offset = "0x6BD7150", VA = "0x186BD8550")]
	public HAJPGIFDCBG NDILLIMMIKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BD83E0", Offset = "0x6BD6FE0", VA = "0x186BD83E0")]
	public static OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP> LMDPPDEOAIA(AFNKNFFEACM<FKMCALNFICP> KDGACCIDPDN)
	{
		return default(OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8330", Offset = "0x6BD6F30", VA = "0x186BD8330")]
	public static OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP> LMDPPDEOAIA(HAJPGIFDCBG KDGACCIDPDN)
	{
		return default(OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8490", Offset = "0x6BD7090", VA = "0x186BD8490")]
	public static OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP> LMDPPDEOAIA(string CKMGJGHEGKO)
	{
		return default(OAMIPODNNBO<CGLCGMNCJJD, NCBFEBAFCJP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NAKBOEMGMPK
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KKMILDBCHCE : IDisposable, CHOMKALJNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private NativeList<BKCAPMPDKDN> MDFOPCMGEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private float EBGCOAJNNAL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BBKOFHLHEBG EEINCCIOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
		[CompilerGenerated]
		get
		{
			return default(BBKOFHLHEBG);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool OPIDKICFENL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7E40", Offset = "0x6BD6A40", VA = "0x186BD7E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FIBGCPEEDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5770", Offset = "0x6BD4370", VA = "0x186BD5770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<ICEPNHDHAMO> MNLGELEFFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JHHPJOKHEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6CF0", Offset = "0x6BD58F0", VA = "0x186BD6CF0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float KIGPIJGBDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5A60", Offset = "0x6BD4660", VA = "0x186BD5A60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7E50", Offset = "0x6BD6A50", VA = "0x186BD7E50")]
	public KKMILDBCHCE(BBKOFHLHEBG KCDIMIFJDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BD58B0", Offset = "0x6BD44B0", VA = "0x186BD58B0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6820", Offset = "0x6BD5420", VA = "0x186BD6820")]
	public Vector3 JLPKDLCIALO(int MCPGGPJAKIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5780", Offset = "0x6BD4380", VA = "0x186BD5780", Slot = "6")]
	public Quaternion CPHDCDLAPCI(int MCPGGPJAKIM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BD56D0", Offset = "0x6BD42D0", VA = "0x186BD56D0", Slot = "5")]
	public Vector3 BKIIKGKAMPJ(int MCPGGPJAKIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5BF0", Offset = "0x6BD47F0", VA = "0x186BD5BF0", Slot = "7")]
	public float EOINBNMCDJK(int MCPGGPJAKIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6D30", Offset = "0x6BD5930", VA = "0x186BD6D30")]
	public void MKCKLHBHBFL(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC, bool AKIKHGAEOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6230", Offset = "0x6BD4E30", VA = "0x186BD6230")]
	private bool GBGPKCIMALI(int EOANMNLKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6460", Offset = "0x6BD5060", VA = "0x186BD6460")]
	public void IOHOACBAEJH(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6790", Offset = "0x6BD5390", VA = "0x186BD6790")]
	public void JJMMFKJJDEB(int EOANMNLKHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5C50", Offset = "0x6BD4850", VA = "0x186BD5C50")]
	public void EPNNFLIAKOG(int EOANMNLKHIK, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD65E0", Offset = "0x6BD51E0", VA = "0x186BD65E0")]
	public void JANCGNEEFBO(int EOANMNLKHIK, float3 GKJAMFFKDLE, quaternion EAGKGJHHIJH, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5910", Offset = "0x6BD4510", VA = "0x186BD5910")]
	public void EECPLKAAJNN(int EOANMNLKHIK, Vector3 GKJAMFFKDLE, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6300", Offset = "0x6BD4F00", VA = "0x186BD6300")]
	public void GPNJOABHHLP(int EOANMNLKHIK, Vector3 DJCDKMIHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7640", Offset = "0x6BD6240", VA = "0x186BD7640")]
	public static Quaternion OIDADHIODDN(Quaternion LBFFEMIAIMM, int EOANMNLKHIK, float KHLBPLLIIDJ, CHOMKALJNDJ FBBOGONGIGH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5DA0", Offset = "0x6BD49A0", VA = "0x186BD5DA0")]
	public Bounds FNOJCPPKDIH(Transform OHCKGBMFMEE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6290", Offset = "0x6BD4E90", VA = "0x186BD6290", Slot = "10")]
	public virtual void GCCBMLIAHME(bool HIEJHFCJPMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5600", Offset = "0x6BD4200", VA = "0x186BD5600")]
	public NativeList<BKCAPMPDKDN> AKPOMDGLEEP(float AEGNBMLFGNM = 1f)
	{
		return default(NativeList<BKCAPMPDKDN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ICEPNHDHAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public float3 FIKECJKJAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float CGGKMNAGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public quaternion FGFEOCGPDAB;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4770", Offset = "0x6BD3370", VA = "0x186BD4770")]
	public ICEPNHDHAMO(Vector3 KDELOFLMOME, Quaternion LBFFEMIAIMM, float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BD43C0", Offset = "0x6BD2FC0", VA = "0x186BD43C0")]
	public Quaternion POLPOLJOLFH(Vector3 EJOHIEANBFL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4480", Offset = "0x6BD3080", VA = "0x186BD4480")]
	public ICEPNHDHAMO POOKGMAFMCG(Vector3 NMBGHBJHHOJ, Vector3 JLCFGKBKCOJ, Vector3 KFOLMKDNOAH)
	{
		return default(ICEPNHDHAMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4220", Offset = "0x6BD2E20", VA = "0x186BD4220")]
	public CLLEEKIBGDJ HLFPLOIBAPA(Vector3 EJOHIEANBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EHCJOPPNBGP : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2E40", Offset = "0x6BD1A40", VA = "0x186BD2E40", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2860", Offset = "0x6BD1460", VA = "0x186BD2860")]
	private void PENINNFLHOB(Dictionary<Guid, Guid> CIOIPFGHNDN, AHGMOIFCMLH MBLMFJBFAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2800", Offset = "0x6BD1400", VA = "0x186BD2800")]
	private void PENINNFLHOB(Dictionary<Guid, Guid> CIOIPFGHNDN, FOCEBKPPAAA PGEJDDHJNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2580", Offset = "0x6BD1180", VA = "0x186BD2580")]
	private void PENINNFLHOB(Dictionary<Guid, Guid> CIOIPFGHNDN, HIIGIOJEOAI FGLIPAGHHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public EHCJOPPNBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class MFJBAIKHDEE : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8180", Offset = "0x6BD6D80", VA = "0x186BD8180", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public MFJBAIKHDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KKABDPCENAL : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BD54A0", Offset = "0x6BD40A0", VA = "0x186BD54A0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public KKABDPCENAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MFBMICHNGDH : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8020", Offset = "0x6BD6C20", VA = "0x186BD8020", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public MFBMICHNGDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class ALDDGCNFDPJ : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2190", Offset = "0x6BD0D90", VA = "0x186BD2190", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public ALDDGCNFDPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LJLPBDDFEIN : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7EE0", Offset = "0x6BD6AE0", VA = "0x186BD7EE0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public LJLPBDDFEIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OOGJGAGNGIA : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB6B0", Offset = "0x6BDA2B0", VA = "0x186BDB6B0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OOGJGAGNGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NLPMFOONBMC : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD85C0", Offset = "0x6BD71C0", VA = "0x186BD85C0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public NLPMFOONBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OEEPHKHPBCG : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8A60", Offset = "0x6BD7660", VA = "0x186BD8A60", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public OEEPHKHPBCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KHPPOCLGFMB : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD52F0", Offset = "0x6BD3EF0", VA = "0x186BD52F0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public KHPPOCLGFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MGCLNELDNMM : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8230", Offset = "0x6BD6E30", VA = "0x186BD8230", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public MGCLNELDNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class DDBOILLEOJP : DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public static readonly GIJNNINKEBH FKIMGNEOHMB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6BD23B0", Offset = "0x6BD0FB0", VA = "0x186BD23B0", Slot = "4")]
	public void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public DDBOILLEOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LCOLMPHPMDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public EIJEJLMCJCI OGMJKGKJANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public HPOPPJJILEF PPCFGDADGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public Dictionary<int, int> LMICPLONKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<Guid, Guid> MEIIPPKJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public LMCDLOGIMMC KNMIOMOOACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool KPPPCHNHKMA;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DPGEHDPMFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLEFBMGFIBE(DOPHJGDBODJ JMAONABKOOH);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OLEENBPLKIK
{
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private static readonly DPGEHDPMFHL[] IEFOGOAECKB;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6BDAE50", Offset = "0x6BD9A50", VA = "0x186BDAE50")]
	public static void NCFLPHFCFKD(GLOMMFEJNDK BFLLAIFBMAJ, Dictionary<Guid, Guid> LLMFEMNJILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BDABC0", Offset = "0x6BD97C0", VA = "0x186BDABC0")]
	public static void MPJPONPKNJP(GLOMMFEJNDK? BFLLAIFBMAJ, LFPCHJKFKHB OEJCGPNGOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA940", Offset = "0x6BD9540", VA = "0x186BDA940")]
	public static void KIOOOLHDJOH(GLOMMFEJNDK? BFLLAIFBMAJ, LFPCHJKFKHB CFPIMBIPMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA570", Offset = "0x6BD9170", VA = "0x186BDA570")]
	public static void BOCFBFGJEGL(DOPHJGDBODJ JMAONABKOOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DOPHJGDBODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public EIJEJLMCJCI LHGDPHMDEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public GLOMMFEJNDK GJMLLIMGMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public Dictionary<int, int> LMICPLONKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<Guid, Guid> MEIIPPKJOOK;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD24E0", Offset = "0x6BD10E0", VA = "0x186BD24E0")]
	public Guid ODFBDEGBFPG(Guid OCIHAODAEFD)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LMCDLOGIMMC
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MEPBLMJCDPF, [Out] Guid FFGMPNLIDKF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class OKKLJHOIIKO
{
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private static readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly ProfilerMarker LPFNBFKHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<string> JFKEJDBPHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly Dictionary<long, int> HAPHHJGBOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly HashSet<Guid> EKNDAIMMFAN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> KMNEHBJBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> IAHOPPDBDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8C10", Offset = "0x6BD7810", VA = "0x186BD8C10")]
	public static OKKLJHOIIKO AMNFJCJKPIO(NJKJANBEOPF DJNINBEOIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA1E0", Offset = "0x6BD8DE0", VA = "0x186BDA1E0")]
	public static OKKLJHOIIKO PDGEMCNGMML(ECOADAOAAGE HKBHLPBKAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9EE0", Offset = "0x6BD8AE0", VA = "0x186BD9EE0")]
	public static OKKLJHOIIKO LHEHNOEFHOB(IEnumerable<string> JFKEJDBPHNO, IDictionary<long, int> JNCMKDCLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA450", Offset = "0x6BD9050", VA = "0x186BDA450")]
	private OKKLJHOIIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA310", Offset = "0x6BD8F10", VA = "0x186BDA310")]
	private OKKLJHOIIKO(IEnumerable<string> JFKEJDBPHNO, IDictionary<long, int> JNCMKDCLEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8C80", Offset = "0x6BD7880", VA = "0x186BD8C80")]
	private void BMLLOPDEMCH(NJKJANBEOPF DJNINBEOIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9330", Offset = "0x6BD7F30", VA = "0x186BD9330")]
	private void BMLLOPDEMCH(ECOADAOAAGE HKBHLPBKAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9A20", Offset = "0x6BD8620", VA = "0x186BD9A20")]
	private void HKPOCPCKFLI(ByteString? LEIDMPPODJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9530", Offset = "0x6BD8130", VA = "0x186BD9530")]
	private void BMLLOPDEMCH(LHJBGJCFBFG? AHFIDHNOIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BD91F0", Offset = "0x6BD7DF0", VA = "0x186BD91F0")]
	private void BMLLOPDEMCH(GBHIAPPIACM? HNCCPGMBLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8E90", Offset = "0x6BD7A90", VA = "0x186BD8E90")]
	private void BMLLOPDEMCH(GLOMMFEJNDK? GJMLLIMGMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BD99B0", Offset = "0x6BD85B0", VA = "0x186BD99B0")]
	private void GIMCMEMMHIO(string? DLMJFDPHMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA0C0", Offset = "0x6BD8CC0", VA = "0x186BDA0C0")]
	private void LKOHNKOLBCF(long KHOKECHLBJO, Guid NOAGHKAPOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA190", Offset = "0x6BD8D90", VA = "0x186BDA190")]
	private void LKOHNKOLBCF(LNBDJBCFAJI? CBOLHNNAIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA060", Offset = "0x6BD8C60", VA = "0x186BDA060")]
	private void LKOHNKOLBCF(PNMIAEPLHEE? CBOLHNNAIMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FOEHPEBAPLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NNNKNAPDEAP : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private readonly IEnumerator<DictionaryEntry> LLKKIBMDGDK;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry PJEFJHLHLOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6BD8830", Offset = "0x6BD7430", VA = "0x186BD8830", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6BD8900", Offset = "0x6BD7500", VA = "0x186BD8900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6BD89B0", Offset = "0x6BD75B0", VA = "0x186BD89B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6BD8750", Offset = "0x6BD7350", VA = "0x186BD8750", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
		public NNNKNAPDEAP(IEnumerator<DictionaryEntry> LLKKIBMDGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6BD86B0", Offset = "0x6BD72B0", VA = "0x186BD86B0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8700", Offset = "0x6BD7300", VA = "0x186BD8700", Slot = "9")]
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
		private sealed class FJCILGOIFFJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDF95E0", Offset = "0xDF81E0", VA = "0x180DF95E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6BD3010", Offset = "0x6BD1C10", VA = "0x186BD3010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public FJCILGOIFFJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6BD2EC0", Offset = "0x6BD1AC0", VA = "0x186BD2EC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6BD2FC0", Offset = "0x6BD1BC0", VA = "0x186BD2FC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BDBE10", Offset = "0x6BDAA10", VA = "0x186BDBE10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object NONKDEOLPHL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6BDBD20", Offset = "0x6BDA920", VA = "0x186BDBD20", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6BDBEF0", Offset = "0x6BDAAF0", VA = "0x186BDBEF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6BDBC60", Offset = "0x6BDA860", VA = "0x186BDBC60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6BDBCC0", Offset = "0x6BDA8C0", VA = "0x186BDBCC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6BDBE90", Offset = "0x6BDAA90", VA = "0x186BDBE90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6BDB920", Offset = "0x6BDA520", VA = "0x186BDB920", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6BDB980", Offset = "0x6BDA580", VA = "0x186BDB980", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6BDB9E0", Offset = "0x6BDA5E0", VA = "0x186BDB9E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
		public RoomObjectCounts(Dictionary<int, int> EFIOKJOGNBD, [Optional] Dictionary<int, int> DAKANAAENNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB840", Offset = "0x6BDA440", VA = "0x186BDB840")]
		[IteratorStateMachine(typeof(FJCILGOIFFJ))]
		private IEnumerator<DictionaryEntry> BFOJFBFKFPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBF40", Offset = "0x6BDAB40", VA = "0x186BDBF40", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBB60", Offset = "0x6BDA760", VA = "0x186BDBB60", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBA40", Offset = "0x6BDA640", VA = "0x186BDBA40", Slot = "9")]
		void IDictionary.Add(object NONKDEOLPHL, object CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBAA0", Offset = "0x6BDA6A0", VA = "0x186BDBAA0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBB00", Offset = "0x6BDA700", VA = "0x186BDBB00", Slot = "8")]
		bool IDictionary.Contains(object NONKDEOLPHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BDBC00", Offset = "0x6BDA800", VA = "0x186BDBC00", Slot = "14")]
		void IDictionary.Remove(object NONKDEOLPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB8C0", Offset = "0x6BDA4C0", VA = "0x186BDB8C0", Slot = "15")]
		void ICollection.CopyTo(Array BFDOCKABCPN, int MFJLAMOCOBC)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class KEIIFPJAOON : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDF95E0", Offset = "0xDF81E0", VA = "0x180DF95E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6BD52A0", Offset = "0x6BD3EA0", VA = "0x186BD52A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public KEIIFPJAOON(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6BD5110", Offset = "0x6BD3D10", VA = "0x186BD5110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6BD5250", Offset = "0x6BD3E50", VA = "0x186BD5250", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BD4E30", Offset = "0x6BD3A30", VA = "0x186BD4E30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object NONKDEOLPHL]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4D00", Offset = "0x6BD3900", VA = "0x186BD4D00", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4EE0", Offset = "0x6BD3AE0", VA = "0x186BD4EE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4C40", Offset = "0x6BD3840", VA = "0x186BD4C40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4CA0", Offset = "0x6BD38A0", VA = "0x186BD4CA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4E80", Offset = "0x6BD3A80", VA = "0x186BD4E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6BD48C0", Offset = "0x6BD34C0", VA = "0x186BD48C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4920", Offset = "0x6BD3520", VA = "0x186BD4920", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6BD4980", Offset = "0x6BD3580", VA = "0x186BD4980", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2151A10", Offset = "0x2150610", VA = "0x182151A10")]
		public Invention(long MJDOIIBKEKN, int KNHHBEFLJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6BD47F0", Offset = "0x6BD33F0", VA = "0x186BD47F0")]
		[IteratorStateMachine(typeof(KEIIFPJAOON))]
		private IEnumerator<DictionaryEntry> BFOJFBFKFPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4F30", Offset = "0x6BD3B30", VA = "0x186BD4F30", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4B00", Offset = "0x6BD3700", VA = "0x186BD4B00", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BD49E0", Offset = "0x6BD35E0", VA = "0x186BD49E0", Slot = "9")]
		void IDictionary.Add(object NONKDEOLPHL, object CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4A40", Offset = "0x6BD3640", VA = "0x186BD4A40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4AA0", Offset = "0x6BD36A0", VA = "0x186BD4AA0", Slot = "8")]
		bool IDictionary.Contains(object NONKDEOLPHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4BE0", Offset = "0x6BD37E0", VA = "0x186BD4BE0", Slot = "14")]
		void IDictionary.Remove(object NONKDEOLPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BD4860", Offset = "0x6BD3460", VA = "0x186BD4860", Slot = "15")]
		void ICollection.CopyTo(Array BFDOCKABCPN, int MFJLAMOCOBC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> OKPJOBNAFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyList<Invention> DJHHPENBDHC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	public FOEHPEBAPLJ(IReadOnlyDictionary<Guid, RoomObjectCounts> NHPJGGBOJCD, IReadOnlyList<Invention> AAHLIAFCDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3060", Offset = "0x6BD1C60", VA = "0x186BD3060")]
	public static FOEHPEBAPLJ AMNFJCJKPIO(NJKJANBEOPF DJNINBEOIHC)
	{
		return default(FOEHPEBAPLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4100", Offset = "0x6BD2D00", VA = "0x186BD4100")]
	[CompilerGenerated]
	internal static int PALBFGIGDGC([In] IReadOnlyDictionary<long, int> GMMKBMPNLKD, long? KHOKECHLBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3A40", Offset = "0x6BD2640", VA = "0x186BD3A40")]
	[CompilerGenerated]
	internal static void FOEMCBPFKHG(int GLIOKMBEOHK, [In] LHJBGJCFBFG FEOLNLEPCGI, [In] Dictionary<long, int> GMMKBMPNLKD, [In] Dictionary<Guid, RoomObjectCounts> NHPJGGBOJCD)
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
