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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D5C1E0", Offset = "0x6D5B5E0", VA = "0x186D5C1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NIHLGJFNCDO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> NEHCBMBBANE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> JLLNNJCGDNM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> DLKLGNCHNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> MDGKPBLKIDA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ONHABBEJDHC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LPMDECAKJAF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string FEIFPFOIKMB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B200", Offset = "0x6D5A600", VA = "0x186D5B200")]
	public static bool OJJIANEOIOA(Guid CDGIEFEGCKA, int HEFPCGKMHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B170", Offset = "0x6D5A570", VA = "0x186D5B170")]
	public static bool MDLGPCKOFPC(Guid CDGIEFEGCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AAF0", Offset = "0x6D59EF0", VA = "0x186D5AAF0")]
	public static string FKNLAKHPFDE(Guid GPJCGLBMIBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KBOFAMIBLFL]
public enum OOOOHPLGEID
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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A680", Offset = "0x6D59A80", VA = "0x186D5A680", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EMJCFLFMAPN
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid BEOFOKPEGKE;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid IDGMHGEEMIG;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid JLIHKGAPOND;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid KGPMMHBFCPI;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LPOEDIGFING;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FOIAPEHBIFJ;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid NJGKMNHGNDN;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid JKFIDJPOONA;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid MPDDEODGAJA;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid MKKJKMIICOH;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid IBCCIHKNKNE;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid BCLGEFPDNCL;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid BOMHHGCKLBG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid BPDENAHIHIC;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid BKMPCFIHOAO;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid IHIBMGMCJPF;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid IKNPFODBMDE;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid HEEFMEKIKHM;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid NMKMCBIFNLE;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid CGAIKDIGCKH;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MAIEGLGAMBL;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid GPHEKPHKBCB;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CDMICGKNMPG;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid CGNHCOBGABM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MDAOJFLBKFB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid HNBOJLLDKHF;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BOCBLPADFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EJLNEKCDGFP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid JKLFIMMACPE;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid ECPHHKCEEGL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CKBMJEKIOAP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid MPONOMFKAHJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid NENNKOJLFAJ;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid OPIBDNEAEGL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid KKCDPOCKKOL;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid MFPJJDEGDLK;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OIKGEKHJIML;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid FBGJAAPLAHE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DCCNAMEDOJK;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid IIFODMBNLID;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid DFEBPLHPACP;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid NLEPJJHOBBO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GGNJCIPEFJE;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BBJGBHLOOFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid FLLHIOEOOBH;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid NMLFPKPCKHA;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid PIGFOMJKCPH;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid EHOEFJIJILE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DJLBDDBODOH;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LKBCFGJMHCG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JKJJOJJCGEB;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid LJKPAAMHFMO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid OMBABHBGDCN;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid EGNIBEKOBJG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid ANLOKGJIIDP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid MCGLAJICNKD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LHFENHAPLBO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid BEGEMAKKGGN;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid NLDPJBIIIOP;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid POLEIOCDDFH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid CMBOJHLHOID;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid NFJBNAJOCDK;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid NLKAKHHOPLN;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GLFCCHIMLGJ;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid POBAIIKDAIE;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid BPKAHDFECEE;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid IFLDMNGMJKE;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid GKDPCMGEONP;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PGJPJOKCMLP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GCEPJOPDNML;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid GMHGOHKCKGM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid DEAMIPMABCB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid IEKGAMPLDJE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid KJHAJCOEBGN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KAMMAMBOKIA;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BPDJCIKNIAO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid DFMCEDJKLIK;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid CFFJINPFPGC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid DGEMACDAKBD;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid EBKMHCOPNEH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DGEOPCKGILO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid EBNAOBIIOAH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GOIKBOKHGPD;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid KODJJMAHIJL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid EAKPOKICFAA;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid ICOKINEAJCN;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HPGLKADABCN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FPNAGFHFOLP;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid KIFFDBIAIAK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid HIFOMAJBAFD;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HCHHNLOJKKN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ANDLFBOFHNG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HIGACBHEOKM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid GKIGNAHOBMF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid LNLAJONOKFD;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid NFIFLFKOLAG;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KLPLCKFBCII;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid FBBIJNBEKEG;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EFDNNBBBFMA;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LOFEOOEPOIH;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EGEALCACBNM;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid PPGGDGDODLO;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid MKOAEKALODG;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GPHEAODGNGA;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DDNHJAIEHOK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HDGIFDDJFLB;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PFOBBLNECAG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JLFAJGGJPJI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid BBLOHDOGKEJ;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid CLACLCAFHNJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DIEGCJCEAIJ;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JFLLLLLPIDN;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid EJLOAMCCPAA;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LMOEPMKPEGE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid OHMHLLPFBGF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid GGMHBFDGFGB;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid KDPLAICPPCJ;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HHBFNNFPIMB;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid AEDMBMMIKIG;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HEMEFABBILI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid EDKGBHGPLPL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OCGJLCBFAAB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid PLPGDNJKHHH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid JHNBNJFLNOO;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid ABJMBAFBJCK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IDEEAKCCOJL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid DCCHBBFPMPE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid AJMFFMLFDHM;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid LILFNLDFKFF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FOPGIABIPLA;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid NEKIIDMNMOL;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GLGEFJFJANL;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid MNAEPHBDKBC;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DHJMPPMIGCK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GCBLPIFJFCK;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MOIJCFCFABJ;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid MIAIMEJHMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PFMMBMDNCME;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FJACJHAJBOE;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid PBENHGIMPJB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid ALHLGMGBJNJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid BFOMCINPHPK;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NAMLFKEIFJN;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid OEMNGGDFKMJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid JGAGFAAKKFP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid GOGJFGBPLAM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid NKHIEDFBCGD;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PCMJMGBMFKP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OGIEJDOJKAN;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid ODGPMEMCMPB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid ELNCMMGGBDG;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ODLEONNNHFG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid BBMJFNFIIGB;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid EGEANCCLAKL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MJMCFCFFHFM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OLBOFAEPLNI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid DKHKDHNDOGN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HFDEDPECBEF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid CDNJMAADCNK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid OKCEEMDMJKB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid KLDGCCEDNJP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid PJCKAKJOEFD;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid JNGLBCNKCNI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OPJIAFMJPFB;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MGMFDKBJDLL;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid AEJAMIDLIIN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid BLOAPNBHOHI;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid MFNJBKBICCD;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LMEMJIKEIOA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid IENEFIKGPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid MLFIEPMPONF;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid CJGKKLONFOK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IBDHGNDKPHC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid POILKDOOOGD;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MAOEIONNNIE;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KAOKOCEBMFE;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid BMOBCEPBNHD;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PPPENLAAIPH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid EIFKABDHNEB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HAHMEHOIPOG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid AJOLGCJLGOH;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid AFOFGAKBKAO;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid MNCOAHLPGJF;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EKKMLMKGIAE;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LHPCILIAKMF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid AKIKCPPDFOA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FCNOJIDIMBG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GOHOOAHDALF;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid LGHPFOFNHJN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid LOINCANKCPM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid NKPHHPAGNCN;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid GAEAELAJALM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid OFFOPOCFMMF;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid ACPGEOACMOK;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid CNMLCHDHAFO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KANEBKDKCAH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid LPOPONLAIME;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CDGIBNBKMJC;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid IMJOEIMLMGH;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid NDPGNBMHHAE;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NCLBFEAGPOD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PBBFHAHFDAL;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FNCLGJDNJKM;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid JLOHDFLJENJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ELCMCPNCFDK;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid EBEJKLKNHBA;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FNDDIBFFAKG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid FMAMPLCLNHI;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid BONIAKOMCLN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid CGIMIEOFBLP;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GCLNICHFBLG;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid EHDDKMDBOAO;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid FFHAMLGGADI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid HIHDNEDKPGI;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid NGDMLPLMHCE;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid LMHOOKOBNPH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DDLHFKAACPA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid EAHGNCHJNFO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LDBHINNAEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid GONHCAEPMPE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid OACDNADEMNG;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NAMFMNKANHG;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid FIFPICBGGLH;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ICMGLMHNMAO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid EDGJNLINPGB;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid OIHGEFNMJNE;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid MCPJPCBJNNN;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid PENHKNCAPDL;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid IMGEMJEELGI;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid IJACBPKGCBB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid CPIELKEDDJI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid OAEDLALLFFM;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid HMJCJOBAFJI;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid BJNBGMEGODF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid FBJLNLKJAOO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid IDPKAOAGLJL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OGLHMNJBENM;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid JELGAJPHLMA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid MNGBIMHPHLM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid MAJFALEPFCD;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid JGGCKDKBBGJ;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OMFILIJFDJB;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid MOKFHGFGBII;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid AECOKBBKHHG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid AABAKIAGIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid MIJGEFEAOGE;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid LGIHMMLCDFG;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid OLFAGHKPEND;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid PADEKOJJFJH;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DMPFGANAFEG;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LEHKBMBKBEL;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid KJIHOJJBJJL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FGLMLBMKGHJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NFHLBCNBGIO;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid LGIODLNMKDA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid GIBDMBGIEBF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid AGMJGOEJFGB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid CNMKGBAOLEP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid LEPFHCMEMCB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid LPLCOPPEEMN;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid FLLOPIKAFFO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid LGBOMDCBKFA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid IJGKPKEGOJK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AOAFGDDHEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid MMBEEEGGNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JNKAILBECIL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid FMDHMPAPGKH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid NCIIPCANMDH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid POAFDFFIJIG;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FGHPNGAAJLL;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid EAPPKPDPDFP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid IPMKKFHMFHE;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid KEONLPJNFMH;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid KGPHKFHNKCE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MMHPGHBBNCG;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid EJIPKCBIPMC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MNFMLJEFLIC;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PHGAHJBCKJB;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid PCDNHKNBAKG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid NPKBINKHOGI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NJOIKJMGOOD;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid NNBHHOGKAIL;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid BKNIJNFPAEI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid IJGKGHHDBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid POGKMGIJMED;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid KHDJKHHPOLB;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MPBCMHEBNPI;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DCAHBBIOKJD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid IMPNBIENLLJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid DEPLAKDGALD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid LOCHDJHLGGL;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LDECLGIJEBG;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid DBLNIFIBDAE;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid FDBFDDDCALD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid BPOIKLIHIEH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GAHCHJNPMDI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid LFGLIJOJCAP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CJOLJNDNGFB;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FPDFMMKCBLH;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid OOOOBALFCLP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PBLFJDJEAME;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid OMMJCFGLAFG;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IMIALOAKGDI;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid HOJNFINOKCE;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NDBKHMLCOKD;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid JCONKPFAFJO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid NMHPKCOGLBH;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid AHFLDFFALBK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid EONMGDAJADB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid MMLNJJDLFFP;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid BOMABJHJPDH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ADNEHJPPMDH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid AEBIFOELIGK;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid MMDJEPKKNEN;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid LNLFGLEBPHK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JDPFBCDNFBN;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid LHMAAKDNDLL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid MKCAHDOBJEF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid JCOBJKBMFBD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid BAKEBOBLPIE;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DBFMPDEIFBH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid MGNKIOKFPEN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid IFMOJNIEHFJ;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FNEMHLBCDOL;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BMGHHEDNHKH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid OGBDIAMPCPN;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid PGDIMNLFOIO;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid IJGBPOBLPDI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JNPJGFLPFLP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AHLBPCKFLNL;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid HNINMLPBPGK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid IEJFGALEBAG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid CDKIPJGCOBG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid KKMBALOHHBP;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid JHDGEDFGCHK;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid JNBKEMNHNCK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MLBHJFOLLLA;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid EHIBBNCHPDE;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PJHECJCPGBD;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid CMEILGALJEE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JKBNLHCCLGA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid ACGLFHMKEFD;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid PBONKNMIJOH;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid EIJHCJOLEJE;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid JADFBAEHBFE;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid CGHAECMLIMG;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OLLCHOCKNDB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid BOPBHEOHDGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid MKGHPBAPMPI;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NJDCDBIAKGE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LAKBEHLAAAL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid BJHDOHKINCN;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DNIDHLAKOME;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid AIMHNNOFNML;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid EBIDJNMAPLH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid FGLFMKPLFIC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MMNBHDHHIGM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid HEOBBGEJMGH;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid DBNGKLNPAAB;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid FFEPBCNEBIN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JLHHLFFKCJE;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid AFJABDKGDKE;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HKGMOKHBGFM;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid JECPPFCEPGD;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DLDGBFEIBCE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid MABGLBPFBJG;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid FCCBKPCIIAP;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FLGAOIKOONH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid GGNAOMHKPDH;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid GLJFABBBKAP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PMLEDNHDPLC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid JPHNDEJBLAO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid COKJEMBLIBD;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid GAMABENKDHO;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid MJFAPLHPAAB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid PADLJBIGCEE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid LGDJDKIGOEM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid JEHLKPFFLPO;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IGDALIGICAK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KNDIOOMPAMD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid FHJCMKMOCDH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid BOCNFAIMCAC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid FKGNFKGELKP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid COPGCGGACBP;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid GAANIMOLHKF;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CIKOMOFLFMD;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid MKEPFKBBMMN;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DAPJCHONADI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid HFAIEIIAINO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid HMAPDAAGKEH;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid FGFOIGPLCBO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GCEDKJKEDJF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid PJJMEIIPLGF;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid HPHLKEMAJHG;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid ABAAALMKCNL;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LFHEBFIAMAG;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid EIEKNPAHMML;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EKJGKOHDHGC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DNAAEEJGNJF;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid ILMPBFPPPJH;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CFDGBENPBIJ;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ONIKOKPGFFH;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid BAILLFAEFHP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid NGIHJHKANDA;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid ICMEKEIOALN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GBFGDEEOOFG;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NPCLKGPMBLF;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MICGPGKPHDM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid CDAEEAPCCBF;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JKHGBNKBNIH;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid OABKKEOMEIP;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid MDKPMEDPGOK;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid JMCKKJHJEDF;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid FKIJCIFHIPH;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid GLDOLMLPMJH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid JPBOLAGEOAK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FACOPGKELEP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid BBLCAKCLAJG;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LHMFIAKFBCD;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JHPEPDEILKF;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid IAMFNOGKCGK;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid IGGCCJNLLPK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FBLMNOODKFA;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid FAOCEEOKMJK;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid IFOCKFCOOPA;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FFKBDDDOPNM;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid DGIGMEHACFN;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid MLNMNDBAONO;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ODALBDEGLPA;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid DACMABOAEGD;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid NIDPDGLCMJE;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid JLIJCDPBKBD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid GANDNPKHAEA;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HDAPFBDBMJA;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DKMPJEIOOFP;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid FLJIEMAJPKI;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JLPGJDBDMIG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid OJHMNHEBJEM;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid EELHDOPIEHL;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid CJJEAFJDMOK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid IKIFCIENMOD;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid OKDJHLGPKMB;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid GDNFAEDFCNG;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid IOFIPFAOHBG;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CNPLAKEEODK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid NOGLHGMGHLE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid HDEAJPNPMNM;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid HKAPONAPGHJ;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid MIDOIKFCBDG;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid HLOLBKMDNKA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid JAIIFJNDGDD;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NJCLDKDOGLO;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DIDDHBHFIIN;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MKDIPNPLCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid KDPHFIFLPHL;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IEABCJBKMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid FNAMNOLFHKC;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid DKNBPINJAFK;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FGBLFBFFHGB;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid BLLOHKEKDGL;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CAOFKEJGIPL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid ADNHMABPGEJ;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid IDGEDPNAMAP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid KKOOANLONPK;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid JGNDNEENHEO;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid JCGALGFJPDB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid KPNIBJDFKDD;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid FBJONHMLGNK;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid ILLDBFBHEHL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KFDIFNLGANM;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid PEPECLMBNLI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GOLJFKAOLHK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid ELOMMPBGGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid EOJPOGOFDCP;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid FPACLHICABJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid MKCEABMKKLK;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid PNMHNBHIBMG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid HPFHELKEFAI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JJJLGCLPNGA;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CHJOADPNBDN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid JGDJJGLPPEG;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid EGKIBMKJBEM;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid JCMNAHDMFCK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid LBELKEEAEJG;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid CCMHGJIIPNL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid AOLBHDIFKMM;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CIGHMAHIFFP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid FDKPCNHBKMF;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HGFAHNEIFCE;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid ODOOAOCKCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid DEFMADJKGIG;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid BGJJKFAGMFB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid KICNIDMIAFF;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DHCPNFNPKND;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DILFNOLLEBK;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MJEJMAIGCHJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid AGBDMOEADBH;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid DOHMPCMEGFC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid ODGPGGALJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid JPOHGEJPFNI;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid JEGPFCBEBAN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid AKANGNPHKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CFGOKOPCHBF;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LNMIEGAFPMB;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid GGAKCJENFCB;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid LHGJIOFBDOF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid JNENCOLMNDN;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid FKLHDCGGJGJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid JMJGKLIEMHO;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid GMOAEKCICAF;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid ELPKOMMCGAM;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid GMHAEDBHFAO;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid KACOMBHDPFB;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CCABBABLHFI;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid ICLOAFEMNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid ILOKJBCKDDE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KOJAIOOCMME;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PEOPNDOKIHD;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid IFNCFDJOFDK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid JELIJHNKNGN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid IFAMLPBLGKP;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid HBCNMNEFHAN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid CFPPFFNDJLO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid LBAPPIFGIBN;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid LOOBIEJEOIN;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid GKHEADPOINH;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid AEOGIDEBAPE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JKKOFEKODAE;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ICHCLIOHBOK;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid LJCEHGBMPHB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid IKMAPFKNNNA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid GEIOHPKBLGG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid FMLEHCLCLFK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JHFJGPGCEBF;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KLMBFENAKEE;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GEBFEDADDKC;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid HNKPBGLBFOM;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid BEOOLBPALEJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JKADLOPINJI;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BNCNDCGDHAP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KKPCKKOPMNF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid MHCGPLIJENM;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ANJNHECDKMN;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid ECECNBCDJKH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid NBNJDLNIFAG;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid JHKKNPHGKPC;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid CPLMFMNHFAC;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid FFGAMPHHLCE;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GHFDCKAKMKF;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid OAAHAMKKPMM;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid NPKIALBJMIC;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid CBOMAHMFGIE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid OHDBKKIFMIL;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LKGOGEKNCGE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid GDMBKJLGHGH;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid DGMJKHHDJPF;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid CNGJBEHBFKN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid DFAPGKBEJFJ;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid BJODKPMGOIM;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid CONKKKGBMPP;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid HOKANGIDLNO;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid JCCCAGCFBHA;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DCOOPJBANJE;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GAKJJPBFGLB;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid ELKEEDGLDEA;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid FDOFMODDCBC;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid LNCKNFDLJAL;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid PPMHCIDLNND;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CGDGJIGGFHL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid NEJMAONIAKG;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid FKKIHMPAFKP;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid KEIJDBIIEAG;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid OJDJPLPAPFK;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid JKLCCBEFHGD;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid DMBFBGIMAOC;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid FDGAEMECPAM;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid FKANDLIFNON;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid MIIENKPKHGJ;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid PLPCBLPJEBG;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid PELGDDCHIBO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid FOCKBPOPNPF;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PCOOOOCNIFO;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid NJHCFHGICNK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid LPIJFOGKIFO;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid FACNBFDBJAM;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PHIAECIIKMB;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid GJIOEBGJBEI;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid PPACMGCDJPG;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid MHLPGENHKIJ;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid AKIEKCGHKEB;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid ODGDEMCMKAA;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid POGEIBGELDA;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid PFHADMKHAOI;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PJEHONFEGDG;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid NBMDHFHGIDK;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid DMCNIODODFI;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid IIPFGBHHMBO;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid GBKMJLCJIAF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid BCPHPLJPEEH;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BCPIAOABNJC;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid DGKEHDDNCHA;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid MJFNEKEMKOF;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid DOEIEOCFBCG;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid HEGJJHAHMBK;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid KECMPEIHFDO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid JAMLOOLNKAA;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid FDFMGILMNJP;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid BIEBHDLGIAL;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid CIBDHMGOPIG;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid OMDBDADMCOA;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid FHFHMBCNNJA;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid APGIKOBJDEK;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid NOIOFMDJJME;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid LLADLBKHPLG;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid KJJEJBMCABG;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JFGMICHDFKN;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid PHDBMBJILHM;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid IGBNABMLPLF;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid JKKDMCGALKL;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid AJCMPMKAPIH;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NLPIAAEKLNH;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid DJGOGLHOICP;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid KGNHABGLAJK;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid PFIDDAOIABC;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid PCGIELAPGFM;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid NANNCINEPMA;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, OOOOHPLGEID> IGLGDBIIHGJ;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<OOOOHPLGEID, Guid> GHLHOBPGLMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OOOOHPLGEID> EAILCILHDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D45480", Offset = "0x6D44880", VA = "0x186D45480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OOOOHPLGEID, Guid> KNDPEMBEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D45430", Offset = "0x6D44830", VA = "0x186D45430")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MOEGGKLKHCG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A710", Offset = "0x6D59B10", VA = "0x186D5A710")]
	public static bool CICJGLJGIGO(GGEHIJCFOJL ABMLFBAOJMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A740", Offset = "0x6D59B40", VA = "0x186D5A740")]
	private static bool CICJGLJGIGO(MHHNEENHAHF BDAAIBDOCNE, GGEHIJCFOJL ABMLFBAOJMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct INIHLNKFMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly NNEPGCMMILH NOLOBHFLPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<DHPBNJJBAKM> JAMIKAEBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<DHPBNJJBAKM> ADFLAJKHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> LBNJHNADENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<OCPIDHFODDG<LKDNFLJFHHO>> ALNCCLDBJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString CGCPLCNDCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly NFMHLDIGCHK NLIDHBMPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool ADOJBLMGPOE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A0C0", Offset = "0x6D594C0", VA = "0x186D5A0C0")]
	public INIHLNKFMHM(NNEPGCMMILH HMJBIBCMEJC, IEnumerable<DHPBNJJBAKM> NJOPDIAIDJN, IReadOnlyList<DHPBNJJBAKM> FOHENBINONB, MIEEFIOIIBN<ABNDNCLMDPA> FKCNCBNHLBE, IReadOnlyList<OCPIDHFODDG<LKDNFLJFHHO>> KEIDKPBKMCN, ByteString BALKGNIIENM, NFMHLDIGCHK CJJFAEPFNLH, bool IGNNHFEODME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IJHCBOIGJDH
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(OMKCHNAONHH AIKOCCMKKAE, [Out] Dictionary<int, int> FLIEPMAMGOK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JMININFAJOG KJHCCCHPGBL, NHAFJHKPAPM JDNPMMGGLCP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HIMFPGJEMNB : IDNINBPMECK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid DBGHIALOJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> CFMNHKPMKFH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> JNIGPHJLDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D50350", Offset = "0x3D4F750", VA = "0x183D50350")]
	private HIMFPGJEMNB([In] Guid CKFGFOPHBKG, Dictionary<Guid, Guid> GGHNEGGOADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D59840", Offset = "0x6D58C40", VA = "0x186D59840")]
	public static HIMFPGJEMNB AHLALEPNKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A0B0", Offset = "0x6D594B0", VA = "0x186D5A0B0")]
	public static HIMFPGJEMNB OKENCKHFIJM(IReadOnlyDictionary<Guid, Guid> NMNIACEKAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D599E0", Offset = "0x6D58DE0", VA = "0x186D599E0")]
	public static HIMFPGJEMNB DNPOCNHKFKH(IEnumerable<KeyValuePair<Guid, Guid>> NMNIACEKAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D59F90", Offset = "0x6D59390", VA = "0x186D59F90")]
	private static Dictionary<Guid, Guid> GCDEAJGGCJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D59D10", Offset = "0x6D59110", VA = "0x186D59D10")]
	public void ECBGIOPNKDF(IReadOnlyDictionary<Guid, Guid> NMNIACEKAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D598D0", Offset = "0x6D58CD0", VA = "0x186D598D0")]
	public Guid DNHPHIFKALA([In] Guid GPJCGLBMIBA, bool NBBOBCIEEMB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A040", Offset = "0x6D59440", VA = "0x186D5A040")]
	public bool NNBKCIJLOIM([In] Guid NKPCGMJMEIE, [Out] Guid AKFLCAMNLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5A040", Offset = "0x6D59440", VA = "0x186D5A040", Slot = "4")]
	private bool LGFCDICKBFM(Guid CEMFCPJEKHI, [Out] Guid CJFFIHKDKOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOBIBDCMNIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MJGGKOLDCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJCCBGLJAMD(ByteString GNHHNHJOMCE, HIMFPGJEMNB NNPHBMGIOAB, [In] UniformTRS LLIDEKBBADP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PNLJFLDDGCD
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
public class NPCAHFNDLGO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CKFEEOAPFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13315A0", Offset = "0x13309A0", VA = "0x1813315A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long CJACHAMJBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C1C0", Offset = "0x6D5B5C0", VA = "0x186D5C1C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A2B4F0", Offset = "0x6A2A8F0", VA = "0x186A2B4F0")]
	public NPCAHFNDLGO(long HMELIAGANNM, long BMJGDOOFCJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EOPJNHEBEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, NPCAHFNDLGO> PAEFLEMDDOH;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> AOFHHFKKOBG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long OEHLDHCJKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13315A0", Offset = "0x13309A0", VA = "0x1813315A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long AMJOBCLFGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B50", Offset = "0x9A1F50", VA = "0x1809A2B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D454D0", Offset = "0x6D448D0", VA = "0x186D454D0")]
	public static EOPJNHEBEON HFCFDINGJKB(NNEPGCMMILH LBCLIMIAGFB, OCPIDHFODDG<ABNDNCLMDPA> FDFGBMLFNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D45B40", Offset = "0x6D44F40", VA = "0x186D45B40")]
	private void NPBOIOKJALH(FCOBIPBEMPJ EKHCANKHNFM, long BMNIGOKADIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D597B0", Offset = "0x6D58BB0", VA = "0x186D597B0")]
	public EOPJNHEBEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LIIAAPGDDNA
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<OOOOHPLGEID> ICMIHFDOPBI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class BHJLNBBMCCD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> MPEEJMKJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> OPBENEAANJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B40", Offset = "0x8B6F40", VA = "0x1808B7B40")]
	public BHJLNBBMCCD(IReadOnlyDictionary<Guid, Guid> ILFOPKPDJKO, IReadOnlyDictionary<Guid, Guid> LEMJELLGFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BCDADAAJJFL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KJJGAKLKOEP : IEnumerable<DHPBNJJBAKM>, IEnumerable, IEnumerator<DHPBNJJBAKM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private DHPBNJJBAKM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private NMHBDAGKJGP spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public NMHBDAGKJGP <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private BOBACPMEFBI spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public BOBACPMEFBI <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private DHPBNJJBAKM System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public KJJGAKLKOEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A150", Offset = "0x6D59550", VA = "0x186D5A150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A420", Offset = "0x6D59820", VA = "0x186D5A420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A260", Offset = "0x6D59660", VA = "0x186D5A260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DHPBNJJBAKM> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A260", Offset = "0x6D59660", VA = "0x186D5A260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D434A0", Offset = "0x6D428A0", VA = "0x186D434A0")]
	public static NMHBDAGKJGP NNLAMILIJNA([In] INIHLNKFMHM KCNPLPMKEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D42640", Offset = "0x6D41A40", VA = "0x186D42640")]
	private static void IFPMFMJMAEJ(NMHBDAGKJGP PDMCCCCKPND, [In] INIHLNKFMHM JOKIMPABENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D439B0", Offset = "0x6D42DB0", VA = "0x186D439B0")]
	public static LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI> POANIBONFDK(NMHBDAGKJGP PDMCCCCKPND, BOBACPMEFBI DFFMFEIACNF, HIMFPGJEMNB? HNBPOGDKAFM)
	{
		return default(LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D438A0", Offset = "0x6D42CA0", VA = "0x186D438A0")]
	[IteratorStateMachine(typeof(KJJGAKLKOEP))]
	private static IEnumerable<DHPBNJJBAKM> PGDAFNMIBED(NMHBDAGKJGP PDMCCCCKPND, BOBACPMEFBI DFFMFEIACNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D43610", Offset = "0x6D42A10", VA = "0x186D43610")]
	private static void OBEMONGKCGJ(NMHBDAGKJGP PDMCCCCKPND, HIMFPGJEMNB? HNBPOGDKAFM, BOBACPMEFBI DFFMFEIACNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D43430", Offset = "0x6D42830", VA = "0x186D43430")]
	private static void MDCHIFAHHGE(NMHBDAGKJGP PDMCCCCKPND, BOBACPMEFBI DFFMFEIACNF, IReadOnlyCollection<ByteString>? CPAIGPBNDKF, IReadOnlyCollection<ByteString>? IOOKGGHIHJB, IReadOnlyCollection<ByteString>? HBCFJJOOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D41F00", Offset = "0x6D41300", VA = "0x186D41F00")]
	private static bool DIMLJLIPFCD(NMHBDAGKJGP PDMCCCCKPND, JMININFAJOG KJHCCCHPGBL, BOBACPMEFBI DFFMFEIACNF, [Out][NotNullWhen(false)] string? MEDJAOOGFHP, [Out] Dictionary<int, int> FLIEPMAMGOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D42CA0", Offset = "0x6D420A0", VA = "0x186D42CA0")]
	private static Dictionary<Guid, MHHNEENHAHF> KEFNOANKKNK(NMHBDAGKJGP PDMCCCCKPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D425A0", Offset = "0x6D419A0", VA = "0x186D425A0")]
	private static void GMCBJFPLIGN(bool MLMPIBDJAHN, DHPBNJJBAKM OHJDHAOMKKE, Dictionary<Guid, Guid> KIKCMBNDAAO, HIMFPGJEMNB HNBPOGDKAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D41BC0", Offset = "0x6D40FC0", VA = "0x186D41BC0")]
	private static void BACPMMKGPIC(DHPBNJJBAKM OHJDHAOMKKE, Guid COHJIHMFNCH, PCKLBDCMINP? IOBDJJNAGAL, Dictionary<Guid, MHHNEENHAHF> GMNJJDFHMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D42F80", Offset = "0x6D42380", VA = "0x186D42F80")]
	private static void LEHELGAHKII(IEnumerable<DHPBNJJBAKM> CCBLPKEEGHP, IReadOnlyCollection<ByteString> CPAIGPBNDKF, IReadOnlyCollection<ByteString> IOOKGGHIHJB, IReadOnlyCollection<ByteString> HBCFJJOOCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BOBACPMEFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool MLMPIBDJAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public NFMHLDIGCHK CJJFAEPFNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public PCKLBDCMINP? IOBDJJNAGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public PCKLBDCMINP? FBIKCKCIPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public NNEPGCMMILH FCGKADONHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public PNLJFLDDGCD EEPMLBPPJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public IJHCBOIGJDH OLGNLMKBDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public OOBIBDCMNIC DNDBJLLKKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public OCPIDHFODDG<ABNDNCLMDPA> ALKLJLCLFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public MJPDFIFLFHA DCHHJAIFBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<DHPBNJJBAKM> MLCMIGHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> PMCOPNHPLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public BCPAADGFNNC ABKMOIMJEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool AKNLFMPLAPO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IMOMDINIDJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D453E0", Offset = "0x6D447E0", VA = "0x186D453E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PCKLBDCMINP
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float CAGKKEKAAFN = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 CLHMEGFDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float KFNOLBCIBOH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 AJHHNKOFPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C2D0", Offset = "0x6D5B6D0", VA = "0x186D5C2D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS FGELKNGNABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C960", Offset = "0x6D5BD60", VA = "0x186D5C960")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE1B650", Offset = "0xE1AA50", VA = "0x180E1B650")]
	public PCKLBDCMINP(Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float KFNOLBCIBOH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CA30", Offset = "0x6D5BE30", VA = "0x186D5CA30")]
	public PCKLBDCMINP(UniformTRS KACBKPNPGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C600", Offset = "0x6D5BA00", VA = "0x186D5C600")]
	public static PCKLBDCMINP HLDOOKPIDJC(PCKLBDCMINP DEDHJMDEEIE, PCKLBDCMINP DGGAPKNLNGG)
	{
		return default(PCKLBDCMINP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C550", Offset = "0x6D5B950", VA = "0x186D5C550")]
	public static PCKLBDCMINP EGFECENGKHG((Vector3, Quaternion, float) AIKOCCMKKAE)
	{
		return default(PCKLBDCMINP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C3D0", Offset = "0x6D5B7D0", VA = "0x186D5C3D0")]
	public static PCKLBDCMINP EGFECENGKHG(Matrix4x4 BFPPKFHCKIG)
	{
		return default(PCKLBDCMINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C9A0", Offset = "0x6D5BDA0", VA = "0x186D5C9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C880", Offset = "0x6D5BC80", VA = "0x186D5C880")]
	public PCKLBDCMINP JGOFAGELHLG(Matrix4x4 HGENDDPKHHK)
	{
		return default(PCKLBDCMINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C260", Offset = "0x6D5B660", VA = "0x186D5C260")]
	public static PCKLBDCMINP AFFBELHHKLP(Vector3 CLHMEGFDOKF)
	{
		return default(PCKLBDCMINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C570", Offset = "0x6D5B970", VA = "0x186D5C570")]
	public readonly MOAGCKPEMJL HHEDFNLALHK()
	{
		return default(MOAGCKPEMJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KNLJDKFPFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D62FC0", Offset = "0x6D623C0", VA = "0x186D62FC0")]
	public static PCKLBDCMINP DOBEABCAOGN([In] this MOAGCKPEMJL MCPMOAEEEOJ)
	{
		return default(PCKLBDCMINP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MMDENDPHEFH
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JBNPMDGBGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly BEDIGHFIPHL GAOCPHLBIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly HGFLKMEKLGL ILLNDAHDFAO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10957B0", Offset = "0x1094BB0", VA = "0x1810957B0")]
	private JBNPMDGBGCI(BEDIGHFIPHL KEKHLMMPMLO, HGFLKMEKLGL JDBBCDKCMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D62430", Offset = "0x6D61830", VA = "0x186D62430")]
	public BAPAKJBJLEK OKJNPOHFCBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D622D0", Offset = "0x6D616D0", VA = "0x186D622D0")]
	public static LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI> AHLALEPNKFA(GOMBJPOKDFF<IOADHBFKJOJ> JDBBCDKCMLJ)
	{
		return default(LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D62380", Offset = "0x6D61780", VA = "0x186D62380")]
	public static LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI> AHLALEPNKFA(BAPAKJBJLEK JDBBCDKCMLJ)
	{
		return default(LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D62210", Offset = "0x6D61610", VA = "0x186D62210")]
	public static LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI> AHLALEPNKFA(string KNJDFIACELN)
	{
		return default(LMFFMMPMNDB<BHJLNBBMCCD, JBNPMDGBGCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum BEDIGHFIPHL
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IDMAHIMAFFK : IDisposable, CAAKIDFMCNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<JCEELACLMMK> CKOCOCKGFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float NGHEALADDHJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public CGGBFCFFEOG KNBDODCCBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		[CompilerGenerated]
		get
		{
			return default(CGGBFCFFEOG);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GLEKBFONNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F160", Offset = "0x6D5E560", VA = "0x186D5F160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GCMMDCIBDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F170", Offset = "0x6D5E570", VA = "0x186D5F170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<DBMADEEOGCH> MBOLLNIEGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BLAEDBBFCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D602B0", Offset = "0x6D5F6B0", VA = "0x186D602B0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float MCHLFIKAMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F180", Offset = "0x6D5E580", VA = "0x186D5F180")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D61860", Offset = "0x6D60C60", VA = "0x186D61860")]
	public IDMAHIMAFFK(CGGBFCFFEOG MOPHLBHNAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F310", Offset = "0x6D5E710", VA = "0x186D5F310", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FC70", Offset = "0x6D5F070", VA = "0x186D5FC70")]
	public Vector3 IHMBJHCKBOI(int JJOEPDKNLJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D60E20", Offset = "0x6D60220", VA = "0x186D60E20", Slot = "6")]
	public Quaternion NABGFMKKHMJ(int JJOEPDKNLJF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D60140", Offset = "0x6D5F540", VA = "0x186D60140", Slot = "5")]
	public Vector3 IKFFMNKDIPE(int JJOEPDKNLJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F470", Offset = "0x6D5E870", VA = "0x186D5F470", Slot = "7")]
	public float FIAOEHCEOID(int JJOEPDKNLJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D60F50", Offset = "0x6D60350", VA = "0x186D60F50")]
	public void NEFFBNNHCKA(Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float CBOFEOAGGML, bool EEBPMLOCLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FC10", Offset = "0x6D5F010", VA = "0x186D5FC10")]
	private bool IBLMAIFNMCC(int MFGNOEDHEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D604A0", Offset = "0x6D5F8A0", VA = "0x186D604A0")]
	public void LKOJHNDBAJF(Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F3E0", Offset = "0x6D5E7E0", VA = "0x186D5F3E0")]
	public void FHGFOAHEFFB(int MFGNOEDHEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F010", Offset = "0x6D5E410", VA = "0x186D5F010")]
	public void AKFKMOEMOPP(int MFGNOEDHEGK, Vector3 CLHMEGFDOKF, Quaternion MDJOMEFJFHD, float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D602F0", Offset = "0x6D5F6F0", VA = "0x186D602F0")]
	public void LBPBMGHHCJI(int MFGNOEDHEGK, float3 CLHMEGFDOKF, quaternion MDJOMEFJFHD, float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D5FAC0", Offset = "0x6D5EEC0", VA = "0x186D5FAC0")]
	public void HADCKENACCC(int MFGNOEDHEGK, Vector3 CLHMEGFDOKF, float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F960", Offset = "0x6D5ED60", VA = "0x186D5F960")]
	public void GDOEBBLNAOA(int MFGNOEDHEGK, Vector3 KENGOPLODLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D60620", Offset = "0x6D5FA20", VA = "0x186D60620")]
	public static Quaternion LLBHGPELFNF(Quaternion JKEFKNOEELB, int MFGNOEDHEGK, float NACDPKGKDED, CAAKIDFMCNL DPLEFOMBLAK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F4D0", Offset = "0x6D5E8D0", VA = "0x186D5F4D0")]
	public Bounds FOPHLGPJHNH(Transform HGENDDPKHHK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F370", Offset = "0x6D5E770", VA = "0x186D5F370", Slot = "10")]
	public virtual void EKGOGDCLOCK(bool LNILKKDDOFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D601E0", Offset = "0x6D5F5E0", VA = "0x186D601E0")]
	public NativeList<JCEELACLMMK> JNNLGNPCCEM(float GBDKNCFAJKC = 1f)
	{
		return default(NativeList<JCEELACLMMK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DBMADEEOGCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 DPFKDMMBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float NPDODIJAKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion HEAKGBPNCFI;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EA90", Offset = "0x6D5DE90", VA = "0x186D5EA90")]
	public DBMADEEOGCH(Vector3 GOGKCFACHGD, Quaternion JKEFKNOEELB, float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E9D0", Offset = "0x6D5DDD0", VA = "0x186D5E9D0")]
	public Quaternion NLNAHAADMKN(Vector3 PAAGAJJEHGO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E6E0", Offset = "0x6D5DAE0", VA = "0x186D5E6E0")]
	public DBMADEEOGCH NLBMMNBAICH(Vector3 AIOKAMLKOEJ, Vector3 EKGEMLEJHHI, Vector3 EEBHFMEDNIE)
	{
		return default(DBMADEEOGCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E540", Offset = "0x6D5D940", VA = "0x186D5E540")]
	public OPKJMCEECMN FLDCLAKNDKB(Vector3 PAAGAJJEHGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class JJHOACGPEDM : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D624A0", Offset = "0x6D618A0", VA = "0x186D624A0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D62580", Offset = "0x6D61980", VA = "0x186D62580")]
	private void OOHMMNKIGJB(Dictionary<Guid, Guid> IKAMLFGKADO, AHBJILCNANH NJPPEHALGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D62520", Offset = "0x6D61920", VA = "0x186D62520")]
	private void OOHMMNKIGJB(Dictionary<Guid, Guid> IKAMLFGKADO, FIKDHPBGKGK CKDLPOAGOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D62B60", Offset = "0x6D61F60", VA = "0x186D62B60")]
	private void OOHMMNKIGJB(Dictionary<Guid, Guid> IKAMLFGKADO, DPCJBLBOPFL HBAIILCJNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JJHOACGPEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NHEDGBGJLDP : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D64FB0", Offset = "0x6D643B0", VA = "0x186D64FB0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public NHEDGBGJLDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MMGJJNJDHNK : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D63500", Offset = "0x6D62900", VA = "0x186D63500", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MMGJJNJDHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LJLBMIDBKGG : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D633A0", Offset = "0x6D627A0", VA = "0x186D633A0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LJLBMIDBKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LEGDIHHPMBA : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D63080", Offset = "0x6D62480", VA = "0x186D63080", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LEGDIHHPMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OOCDAOJPNOF : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D65060", Offset = "0x6D64460", VA = "0x186D65060", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OOCDAOJPNOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FINHPOFMOEP : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EC40", Offset = "0x6D5E040", VA = "0x186D5EC40", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public FINHPOFMOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CLPGLBPKLBF : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E450", Offset = "0x6D5D850", VA = "0x186D5E450", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CLPGLBPKLBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class AACBKCAENMH : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5CBA0", Offset = "0x6D5BFA0", VA = "0x186D5CBA0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public AACBKCAENMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class CDGIEGBOMNA : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5E2A0", Offset = "0x6D5D6A0", VA = "0x186D5E2A0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CDGIEGBOMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LGIHFLHCJLB : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D632A0", Offset = "0x6D626A0", VA = "0x186D632A0", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LGIHFLHCJLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EBONELFMGDN : CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly COOACKHNEND GFEEKDEIJHH;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EB10", Offset = "0x6D5DF10", VA = "0x186D5EB10", Slot = "4")]
	public void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public EBONELFMGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GGEHIJCFOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public JMININFAJOG ABNEAOFINHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public NIAGJEFLEEM GHJMLMBCGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> JMOCJBHAEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> ONLNBMFJBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public BCPAADGFNNC ABKMOIMJEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool JAEGMFGHGGA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CCOPKFGDGFE
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCGNLFFCANJ(GONNFEMCMKC LJOCLIHBALA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PCIIDIFKMAH
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly CCOPKFGDGFE[] HDINHEPLHMP;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D65800", Offset = "0x6D64C00", VA = "0x186D65800")]
	public static void LLCENNAPMFO(DHPBNJJBAKM AIKOCCMKKAE, Dictionary<Guid, Guid> KILAIPLNOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D651A0", Offset = "0x6D645A0", VA = "0x186D651A0")]
	public static void ADLBFGOIJHH(DHPBNJJBAKM? AIKOCCMKKAE, HIMFPGJEMNB NOJFACNPOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D65A90", Offset = "0x6D64E90", VA = "0x186D65A90")]
	public static void OMLHDHNJNFJ(DHPBNJJBAKM? AIKOCCMKKAE, HIMFPGJEMNB HNBPOGDKAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D65430", Offset = "0x6D64830", VA = "0x186D65430")]
	public static void CICJGLJGIGO(GONNFEMCMKC LJOCLIHBALA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GONNFEMCMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public JMININFAJOG FJINNODNOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public DHPBNJJBAKM OHJDHAOMKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> JMOCJBHAEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> ONLNBMFJBLJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EF70", Offset = "0x6D5E370", VA = "0x186D5EF70")]
	public Guid KCDLCJCIIIA(Guid GPJCGLBMIBA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BCPAADGFNNC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KKFLCOAGHIL, [Out] Guid FBMFBHHHBBI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class NALCBJJMBEM
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker MHKHEFDKHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> CLADBDIHKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> HEIAKHDNDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> HHFKCKGJPGI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> LLDFBNADGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> OMOBPOGKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D645E0", Offset = "0x6D639E0", VA = "0x186D645E0")]
	public static NALCBJJMBEM LNLKPJNPPKK(CALEDHBDGGG AAAHDHHHHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D63660", Offset = "0x6D62A60", VA = "0x186D63660")]
	public static NALCBJJMBEM HBNNDHGJFJC(NMHBDAGKJGP FGCMPGPIMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D64460", Offset = "0x6D63860", VA = "0x186D64460")]
	public static NALCBJJMBEM JJIMDFGIHKP(IEnumerable<string> CLADBDIHKGE, IDictionary<long, int> IBHBPPLACCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D64D50", Offset = "0x6D64150", VA = "0x186D64D50")]
	private NALCBJJMBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D64E70", Offset = "0x6D64270", VA = "0x186D64E70")]
	private NALCBJJMBEM(IEnumerable<string> CLADBDIHKGE, IDictionary<long, int> IBHBPPLACCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D63EF0", Offset = "0x6D632F0", VA = "0x186D63EF0")]
	private void INJACOEDAOD(CALEDHBDGGG AAAHDHHHHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D63740", Offset = "0x6D62B40", VA = "0x186D63740")]
	private void INJACOEDAOD(NMHBDAGKJGP FGCMPGPIMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D647D0", Offset = "0x6D63BD0", VA = "0x186D647D0")]
	private void OLOPKIDBFJA(ByteString? BALKGNIIENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D63A80", Offset = "0x6D62E80", VA = "0x186D63A80")]
	private void INJACOEDAOD(GBGNGFHNOCN? KCFGMPGPMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D63940", Offset = "0x6D62D40", VA = "0x186D63940")]
	private void INJACOEDAOD(NCNACGGIKBD? EKHCANKHNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D64100", Offset = "0x6D63500", VA = "0x186D64100")]
	private void INJACOEDAOD(DHPBNJJBAKM? OHJDHAOMKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D636D0", Offset = "0x6D62AD0", VA = "0x186D636D0")]
	private void IJAIGHOGIPK(string? EOCJHCCHKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D64650", Offset = "0x6D63A50", VA = "0x186D64650")]
	private void MJPKMKDJJJN(long PPKJKMEBCON, Guid NLBFNLAGHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D64720", Offset = "0x6D63B20", VA = "0x186D64720")]
	private void MJPKMKDJJJN(PAHPENMCHGG? CFCKAHNPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D64770", Offset = "0x6D63B70", VA = "0x186D64770")]
	private void MJPKMKDJJJN(GCJMGAFLHHO? CFCKAHNPPBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct BJFAJCAFKNB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class APPOFKDKLKH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> ADGILLNPFAM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry JDGIMBMBKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CED0", Offset = "0x6D5C2D0", VA = "0x186D5CED0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object KJHFJLCNKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CF90", Offset = "0x6D5C390", VA = "0x186D5CF90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object EEMLDMGPOLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D040", Offset = "0x6D5C440", VA = "0x186D5D040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CDF0", Offset = "0x6D5C1F0", VA = "0x186D5CDF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
		public APPOFKDKLKH(IEnumerator<DictionaryEntry> ADGILLNPFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CD50", Offset = "0x6D5C150", VA = "0x186D5CD50", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CDA0", Offset = "0x6D5C1A0", VA = "0x186D5CDA0", Slot = "9")]
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
		private sealed class GLIFMGNPNKP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D5EF20", Offset = "0x6D5E320", VA = "0x186D5EF20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
			[DebuggerHidden]
			public GLIFMGNPNKP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6D5EDD0", Offset = "0x6D5E1D0", VA = "0x186D5EDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6D5EED0", Offset = "0x6D5E2D0", VA = "0x186D5EED0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D668D0", Offset = "0x6D65CD0", VA = "0x186D668D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object OEOMDKHBDFI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6D667E0", Offset = "0x6D65BE0", VA = "0x186D667E0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D669B0", Offset = "0x6D65DB0", VA = "0x186D669B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6D66720", Offset = "0x6D65B20", VA = "0x186D66720", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D66780", Offset = "0x6D65B80", VA = "0x186D66780", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D66950", Offset = "0x6D65D50", VA = "0x186D66950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D663E0", Offset = "0x6D657E0", VA = "0x186D663E0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D66440", Offset = "0x6D65840", VA = "0x186D66440", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D664A0", Offset = "0x6D658A0", VA = "0x186D664A0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
		public RoomObjectCounts(Dictionary<int, int> DDFMJDMKGLG, [Optional] Dictionary<int, int> NFKCMEEIFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D66300", Offset = "0x6D65700", VA = "0x186D66300")]
		[IteratorStateMachine(typeof(GLIFMGNPNKP))]
		private IEnumerator<DictionaryEntry> KHAJDNMLEAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D66A00", Offset = "0x6D65E00", VA = "0x186D66A00", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D66620", Offset = "0x6D65A20", VA = "0x186D66620", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D66500", Offset = "0x6D65900", VA = "0x186D66500", Slot = "9")]
		void IDictionary.Add(object OEOMDKHBDFI, object EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D66560", Offset = "0x6D65960", VA = "0x186D66560", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D665C0", Offset = "0x6D659C0", VA = "0x186D665C0", Slot = "8")]
		bool IDictionary.Contains(object OEOMDKHBDFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D666C0", Offset = "0x6D65AC0", VA = "0x186D666C0", Slot = "14")]
		void IDictionary.Remove(object OEOMDKHBDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D66380", Offset = "0x6D65780", VA = "0x186D66380", Slot = "15")]
		void ICollection.CopyTo(Array IGGIDMIPNHL, int HAJICDLBEKC)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class KCMIPGIJBGL : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D62F70", Offset = "0x6D62370", VA = "0x186D62F70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
			[DebuggerHidden]
			public KCMIPGIJBGL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6D62DE0", Offset = "0x6D621E0", VA = "0x186D62DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D62F20", Offset = "0x6D62320", VA = "0x186D62F20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D61F30", Offset = "0x6D61330", VA = "0x186D61F30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object OEOMDKHBDFI]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6D61E00", Offset = "0x6D61200", VA = "0x186D61E00", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6D61FE0", Offset = "0x6D613E0", VA = "0x186D61FE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6D61D40", Offset = "0x6D61140", VA = "0x186D61D40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D61DA0", Offset = "0x6D611A0", VA = "0x186D61DA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D61F80", Offset = "0x6D61380", VA = "0x186D61F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D619C0", Offset = "0x6D60DC0", VA = "0x186D619C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D61A20", Offset = "0x6D60E20", VA = "0x186D61A20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6D61A80", Offset = "0x6D60E80", VA = "0x186D61A80", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x22130A0", Offset = "0x22124A0", VA = "0x1822130A0")]
		public Invention(long NKPCGMJMEIE, int HMELIAGANNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D618F0", Offset = "0x6D60CF0", VA = "0x186D618F0")]
		[IteratorStateMachine(typeof(KCMIPGIJBGL))]
		private IEnumerator<DictionaryEntry> KHAJDNMLEAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D62030", Offset = "0x6D61430", VA = "0x186D62030", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D61C00", Offset = "0x6D61000", VA = "0x186D61C00", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D61AE0", Offset = "0x6D60EE0", VA = "0x186D61AE0", Slot = "9")]
		void IDictionary.Add(object OEOMDKHBDFI, object EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D61B40", Offset = "0x6D60F40", VA = "0x186D61B40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D61BA0", Offset = "0x6D60FA0", VA = "0x186D61BA0", Slot = "8")]
		bool IDictionary.Contains(object OEOMDKHBDFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D61CE0", Offset = "0x6D610E0", VA = "0x186D61CE0", Slot = "14")]
		void IDictionary.Remove(object OEOMDKHBDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D61960", Offset = "0x6D60D60", VA = "0x186D61960", Slot = "15")]
		void ICollection.CopyTo(Array IGGIDMIPNHL, int HAJICDLBEKC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GDBADKELMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> GJMOOFODEGD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public BJFAJCAFKNB(IReadOnlyDictionary<Guid, RoomObjectCounts> CLAABPHGHPG, IReadOnlyList<Invention> LDHOALNGNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D8C0", Offset = "0x6D5CCC0", VA = "0x186D5D8C0")]
	public static BJFAJCAFKNB LNLKPJNPPKK(CALEDHBDGGG AAAHDHHHHGN)
	{
		return default(BJFAJCAFKNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D0F0", Offset = "0x6D5C4F0", VA = "0x186D5D0F0")]
	[CompilerGenerated]
	internal static int CPOKFODIFAK([In] IReadOnlyDictionary<long, int> MDMEAGNIEKG, long? PPKJKMEBCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D5D210", Offset = "0x6D5C610", VA = "0x186D5D210")]
	[CompilerGenerated]
	internal static void KBCCAMPPAFN(int EEGBKMMLJGL, [In] GBGNGFHNOCN LCLICNNKDDL, [In] Dictionary<long, int> MDMEAGNIEKG, [In] Dictionary<Guid, RoomObjectCounts> CLAABPHGHPG)
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
