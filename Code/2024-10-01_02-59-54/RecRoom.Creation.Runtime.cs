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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CF70", Offset = "0x6D6C370", VA = "0x186D6CF70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNPPAKICLLI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LMAKPDNFIGG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GHPGJFFJGHB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> HFCGAJFEICO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> KBIFMICJGGA;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string OAMGOGKMFEK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string KFHJDHNIAMG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string LFNBAMMEFLH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D56F00", Offset = "0x6D56300", VA = "0x186D56F00")]
	public static bool PEAMLOKPJPH(Guid BDHFIGHLNAD, int DBJNPOMGPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D56E70", Offset = "0x6D56270", VA = "0x186D56E70")]
	public static bool HFMOGHHNIGO(Guid BDHFIGHLNAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D567F0", Offset = "0x6D55BF0", VA = "0x186D567F0")]
	public static string FIELJBPFDLD(Guid FDANKBMKMCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LPDJILJKCIH]
public enum CMKJLEFOKPO
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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CE50", Offset = "0x6D6C250", VA = "0x186D6CE50", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KNMMHPJOMMM
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid ODMFDICDHNI;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid FDIJNDMCCEK;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KJOIMOJBCON;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid AHACFOOHHAA;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LOBCODJJAEH;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FEDFFMNIPHA;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid DAHPPPNIONB;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid CFEFPKNNOPF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid GKKALCBAIHH;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid LGELDJEMPPL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid LPIDPCHDMHG;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid FACLMOFOOAB;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid OMPKELEIMOI;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid KOEDDPLDDAK;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid BCHHCKBKMHG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid JFPHIMADKGN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid GMCIHLJFBJG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid NCKBJCIEFJL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid JIAABLPCEOE;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid GEEKBIGCAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid IDKHPDNCBAO;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OJGFLFHJAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AFDGKKDJJKL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid MMCJLGFIMMO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NJABOGJHPBF;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid DMAFNPJCJBC;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid HBJAHDCCBBK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JJHFNNNANFG;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid LIEOMHEEFKG;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid BIMHNCEJDCC;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CAEMAJHLFIO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid OOAMFGNDMOD;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid PNPECFGNNBL;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MKIJMPDGDMF;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid EDLOOCPJFDH;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid IOIJAADPIKF;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LHKGKFJPPKB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid PEKIDDIELAD;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GDKCPJNLMEO;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ODIELOAJKNI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid AOHPPKCMKOC;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid CFODGDHBBFA;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid MBKKDJJFBIH;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OBDKIPOLKIH;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid MFNGOELNPFK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid AGANALCFBOM;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NPKCMMHOMLA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid AENDCIMODAC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid IAPJABEGEME;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CGNJHFGAOLI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid MIPAAKEIBOL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid IJLILGIOAGI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid KPAAKHOFHBD;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid HBMJCPEBEAP;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid MLHNHPHLHLN;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid MFONHFANCHG;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BGIBHDBMHME;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid KNGKPICJDII;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid BFJHBOBMOJJ;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid BJCHJBNNHIM;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid FIAKGGMMFOH;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid PMDLKFCPNME;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CECMBJCIIOM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid HNBLBICADBI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid PPDHAFKAHCK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MHNKNFJHOHD;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PEKKADOFFFF;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid FLHFLFPDEJM;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PBGHLBMLIJG;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid PDFIAAHECBF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid GBCFEMFGIEM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid AKLJMNDKHPJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JHPBPGOCEIK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LLLJOCGINOF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KHECEFJLIGG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid JALFHCPJEPG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CJODFOEKHMK;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid KGIIIDABPDF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid ENEDMDIHOHL;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid AGAOIIHFKHJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MLLDFACPENK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid INOIGIDNGFB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid LLJFJJIMGPG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid DIMEPODONLK;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid DNCMEOBNDIC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid EJMCMEKDIJK;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HFPMLHAIHGI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid AMGLIJBHPDC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid OJBDMEIPBGN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid ICIPJONKKIA;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HMJCBMFEGCM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ELIJCBGPCAA;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LOKDPABFEBP;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid ODMCCFFFBAB;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid AFAJCDBCLLJ;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IGJLNKOEPKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KIIALELGNMB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid HCHEABJDBGL;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid DLNNBHBIEBI;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid FNHNDPOIFDI;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CHBBCEPINFJ;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid NKNFPEONFJL;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid HKKFLFHMEHF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PLIIHJFKECN;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LJBACDGCMIO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HONLEKHALKE;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid NBOICHEHHEM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid ONNCPEJMCKF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid MKGPJJECENP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid IBLDOCMDNBM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid HLHCADILDNM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid DLMNHDOFDJE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PMEBEPHJGAI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LGHMIPNFADB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid ILPAAHEDHDN;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid NAIIKFDKLMJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid JPHEIKIOBJP;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GKDLFFIIEHP;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FMAHJDMIJBL;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid MFNFAFLFOCN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid JPBDGIMBJEB;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid DDPAKGAEAAD;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid IHDOPLLNHLP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid AFLHELFLKDI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid AKNAGOFCEPJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HBAIMDIPEBI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid LNPJBIMNGEP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid MJOCJHIDFEI;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid GBIIDBHBCCB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KAKEJMJNEOP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GDPBIEEFDJA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid JCMLHLCGMOH;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LEKBMIPFEHN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DMILKEHDGEK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid BOJOFFFKEIP;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid BNLBKIJLAKE;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HDLBCFDLBOA;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid KLFLBEFCJFF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid ALLEKEIPOKA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JLMJOFFEMPL;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid JNEIKMPJFKP;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid GJIMEEDNHKF;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid EOBAIJELINI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DOBFFPECKLI;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid HCFDHGDDCED;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid OAOMJDCEKJO;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid LFKPOLHPFPD;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HNCJMJPPHMP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LMEMNKNCANA;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid IPPKFLOIMML;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid MMGPGOPNEHA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid NIIGNPDKOGH;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NMGOBOPHFGK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid OCJPDKMHDNN;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid LAADDAPEOAE;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KNHHABPFEDM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LKFAPLFDHAJ;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid EGNBLEIIPAN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid JFIOOFOBMMP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NNLKNFJADFC;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FFMPPAAJJNP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid CENMNNMCFPJ;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid KPBOLNKLELN;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid DDNHGOCNJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FKKDEINPPPF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid JOJOFHPKKBF;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid CFNCDCFBIFA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IOOOOOABCED;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid CKBAMLCFCKK;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid JGLEHJINAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid DKFMDLFHJLM;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DKDIJMHCJFA;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid JDGFKNMOOLF;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FINAABDBLFH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid GOOPENAHAOK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid IHHGAAIDMLO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid OLABFCMOCJE;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid NCBFLDJEFOC;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid MIGFKJDPCIB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid FNEEODDFFKC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid GCEEDDOEILO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LMKDJBJLMDO;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid IBPDKDJDNIH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid OHEKENGJNFK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FCKEAPHOOKK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MCFFJNAKCGK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid ALGKNNJHIMB;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid KLABOMCMFBH;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid JLCOPMNBKFN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid IIDBMABOPBP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid NALIJPLAOMG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid MBNKHPLLEFP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid KCINOGCLHJP;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LOMEKAMMFKO;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LBLHCFPLIIA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid NEMKNDFGGOP;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid POBELMKBAHI;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid EPPGBHGEJBB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid BDBNCHHFJKG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid JKKNHDLDGKP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid NMIAPAKMIMC;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PGJMOFOKAKE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JPKAPMOPDPI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PDKCFHMHLHO;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid DNAJCLPHIOD;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BHLBMOINHHM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid PEIKOALOKGK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid EJFNEPOFEEN;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DLFKDPIMPDH;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid PNALDAKGNDF;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid BJBEKJFHOCD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MJDJKAFPDGI;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid ICEKGNKFKCI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid FCALMOMHCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid FAJIIJEPIGO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid GCAONHOEEEO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid GNOKJMCGGAO;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid FKAKDNKNPDO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid PDAFLKFFANN;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid LKCCJJCCGIN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid DODJBHHKKGE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid IKIHHJDBOEC;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EMIBKCMBDFP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LDDEJGPFANE;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid NGDBIGPPCBP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid PBCOEPFJKJA;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid HOAMEAHIBAC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid CECKOFGBOAN;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid BHIIGOIJILJ;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid OIBKDEJBEHD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid KEHLLEGFDND;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid CEMPJKJJAAC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid AAGKJFFABFF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LEIHIHEDDLA;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid BMNIFAOPANO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid HLEOKIMDBGG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid GLBNLEHEIBO;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid EBGDGCGGHLB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid EMCOFHBBJKM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid INCLCBOFEDN;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid CLALPAKPHHO;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid NCNCOGMGOID;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid LMDMGJHEHFE;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid AAAFNJCMHMB;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid PEHNINOMBDA;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid OLKADMAFJPG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid NGCELEIPCBE;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid CFIKFDPGHGF;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid ACHPEOFCEFD;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid LJNNNALCHNN;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BCMLEOIDMPB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid HBGFHKCHFFN;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid MMNCKHILBAM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid JLANMPCDBDL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid LAHKMLMADMH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid MFGBBJFNAJB;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid OLFODDCIMMK;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HEIGHKGGGAC;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid PIMELPOLELC;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid MNGEDFPEIPL;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid IEGLDHBEPHI;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid KFLJFPMAKDL;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid LBLFEMHJDFA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid ADFJGEKHIBL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GHNIMHODJAM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid PLFMHKDHBGO;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid AGCOPHLIALJ;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid LDKPBODKLAO;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NEJBGLPADDF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DKJDOEGBCDO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid GMDLKFJNICE;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LOPIDFIPJHI;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HPCLIBAKFFF;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CIBBHIKLLHF;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DBGGNMJPOCF;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid AMGFEJNEAPI;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KNKFPFAGNBE;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KECBEDAAMFC;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AOPNKBMKDID;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid HDCOMBHMLJN;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid KOBHIDMJPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KHGFOMCGNBN;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid FDCIOGHEAFD;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OEDKMHJIFFH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid MPKAKGHJIPB;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HPOHLNJJHMM;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid ALHKPDPPDGO;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid PNGFCNABDMG;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid NKECPNMBELM;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid GGHDCHFPFEL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid MBEAIHIHHEJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BFMOMGPODKH;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid OMLMOIKEGAL;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AIMPCFFOLGP;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CAGFCJEOBGE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid EJIKEDJGOHE;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid DDMBGNCNDIC;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid DIKDGHPOJDK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid BNGPNBAEIOF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid ILMMAMIKCNG;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid CNADGGNFHHL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EANOFNACFID;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IFHGIJHGGPO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OGCGIPMFEIE;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AKALHOGGLEP;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid GACPGFEADAO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid ICJMIMGIHNI;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid BKJGJNNHOED;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid DJNGHMCCMAG;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KLANBLBGNLB;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IMPEDKJLLLA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid JLOIAOAACDK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid PAKLKPMBHGG;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid AALIOALDFLL;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GKOKMANCFNF;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid AOLPFDNCIME;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid CDMCINMKGBM;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid MEKOFLKCOCF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PJCKDLLANMD;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid ACPFIGMKKEA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HEHKGBOEBEA;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EOBKNJMAOLK;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DKFEIMPJFPA;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AFOCDHFIDOO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid MDJPFNKCHBG;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid JJFGILFNPHA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid LIGLCKHADGH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid ECPMBOMMAEF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid NELAIJBKMCA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AELILBBDNHF;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid KKBOJDJAFGC;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BNDPBFMIOEL;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid NLHMJOLDGJG;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LMAKMOMJNML;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid IAMFJNBFCBL;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid EIPFPEHPLPN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid NMFAFGGPKHJ;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JKAJHDNOELI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid GNIPDCAMKNP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid PAKLGGNOMCN;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KJGGCAKFFPK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HKEGFNLIIGF;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid FOGBIIGDNEP;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ANDDBPAHAKD;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid ABCBLIGAOPO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid JCEJPKPCKJM;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid AODPDGCCMMM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid KPADGHPFFHO;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid BHOAIGGLEMC;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid ALJDDKLFMDB;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NIKKINHNDFL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FAHDAPAGNDH;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GECIHFEICOA;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid OHMGAEMECJH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid IFLOLHDFMFK;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid DJICICCABFO;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid LHILOGALIGI;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid GAOEIJNAPMD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KEHIBEIIFOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid PGJLAJGBLDM;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CLCIEGKNPDA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid GKGKDOEKKHP;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FCJLCLGCPFP;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid INFOPAEDEOE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid FPOFGABBPHE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid ALLNMHEEGEA;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JGANKJNOPNA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid DGNKMLKNAMH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid PIPOGCNOFLA;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid KNPPIMGJDHK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid BGDJFDMFHIL;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CEFNMIFOLEG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid MLDDJNGFJGP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid AMFEEMFGLBG;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid FLCCLOEAGBN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid BKNJDAGJDNJ;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CBOPNNOPONG;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid JPMCGBKFLCL;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid BMEODHKILBK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EPOGHKBDJAD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid NHNJEPFJJKM;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid KOMDEJJMHNM;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid MEOFKNPHIPL;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid NMLLLCBDIAF;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid BIPDICHJOJP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid AIMLMBMENBM;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid LIAGNDOIGGG;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DJGFGNPGHJG;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid EEGOOOAGPMM;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LMGLOHEEKIN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid OJCGBJGGEPD;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KCPNDKHDCAH;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid JHOIBEFDDBM;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FGJBINBCFMD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid LLBLHDLPFFB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid AGFBCKHILNI;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid OAJMGPIIDDB;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid NCIGICINKPB;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid CHGHCHBIFLH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid IIBDIFKIIHL;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GCGJNIHGOJM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid JLELAFECDJO;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FNLEOPLFFCN;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid ANAFGMHAIOA;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid IMLBBDMKMNB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid OAFHJEMPNDK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HHJKAOOIELC;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MPFEJKELONC;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DOOJHNKEIPC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid HFJGGJFCEOO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid HGJBLDCFFLL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IMBAKDNJAKM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AENFMOGOIKO;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid BFAMONNFKPI;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FAPLJAODBOI;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid KLLKKHIKPIL;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid CFNHFBPIGEA;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid DIMLCCFFDEN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid OHEAMAGJMMF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LEMHOCDENAJ;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid MHIGBHPBGIC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid OHHCLJJPKCL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid NJENLDDOKLA;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MHJBHNGBJNE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid EAJHABMIPFF;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NJLOIPJDPBN;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LKABJCBIDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid HALCHLMALMP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid POIFKHEABCP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid FHCNCOECJNA;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid EFGBDPBCCBH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid JGBHLPJNLBC;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid EHGIIFLMKFA;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HEOGDPGLODL;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid BGHMOFLDHFH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid HJPLGHMFGOH;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NHNLBOPPGOF;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid LNBCLDANEKA;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid DGMJKLLBKBM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid NDGHFAAFIOI;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid KLDKDAIEEHM;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid JKMGJOCOGOD;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BBJBGMFEGDD;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid GDJELCPOENB;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid OFIDOADCBOM;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid MJDJDPNIFMO;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid JMMIOCGANNI;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JMEKIMFJPLA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid OJIGABODOII;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid DHNCDCDIAKE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LCAIODOOICG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid NBICEKKABAF;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid MMHOKJDBLHG;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DJJLHGCNGEI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid KLGEKJGPAHE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid GAFLNPIGFNE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid HADKIJNGLMA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid BHOOMFLEKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid MMKGDOMOCMG;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid AIFAAMCGHOA;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BLNMKNNHBEG;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KDGKHBADLAE;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HMKMIGNLHKF;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MCHKPDDHGOO;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EGHOHLCFAOD;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid FELJEMOPNJB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid IPHOENLDBCO;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid AMLEPMKBHLI;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid MMFOLKMLIOC;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid BAMPNCDMLHK;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KIMGBFDBILN;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid JACGDIABHLN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PNOMFKGJKJB;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid CLDAKKEFGEE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PIENHBJEJCI;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid INLIJHEJKEH;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CJLEHKNKDLB;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid LJPKCPGPEKE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid BFEFEKNPDAL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid OLHICCLPCOG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid FJOEFPHNOMN;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid ELHNGMLIGHE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid LBHBHNHCHGB;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid EIEOPGNDDNE;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid OCNMJGGPMLB;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid IELACJLGEFK;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid GFDBOIFCOBK;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid MHKGAPIEHPC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid EBHHFBBIBJA;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid KBHCEILMKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid NEIPOCJECBN;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid AINCPLPJJID;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid NKFMIAFGGDP;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid HEHLMOJAOOC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid NALJPLIJMFF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid OEEMHGBOFDA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid IPMPOILDBAD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid IAPFMONMIKF;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid BOBFPBHJDGH;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KHMINDJILEA;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid LDAKOKKOEKG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BCHDKOIPNIG;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FGLHBHJHHBK;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BIGFINPKFNN;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid GFGILLPIKCM;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid NOABFFHABNE;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FIPKCDNEABO;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid HMGAMADOHGG;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid PCINDPPMIBB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HLMDJHEGEFN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid MHBMEECOGCG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid CODGFGFIMGO;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid NCGNCIFAEBG;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CKIKMDPJOBM;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HJKDEOOIEDA;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid JJMOJLMGFMP;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid GNKEGJJEHEL;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid BOPJFKGCELN;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MDNOGHPFGKI;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LIBIMNJEDJP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid JHCLMAPECMA;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AHBCBKDKBJB;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid CFGKPFILFDC;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FIBOADEANDC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid ELCJCPMLCMN;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid GPNNBHGOMEL;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MFGPFJMHHGF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid BCFHKCGJIIJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid OHPGMKODDHH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid AGGFBKKDGKJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid EGAKPIOLIOA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MMKEJFOMDDI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid ADMGFBFLNNF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid MMAPLDACAAK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LKKGAANEDGD;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid BLJNPCPJJCE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MHHNLHJANDM;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OCOOICJPCBA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JINOBMHHNJH;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid KIKDFBPGKPL;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KMNOFAHLKGO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid AFFADKJDJEJ;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid FNAAEAKGCFK;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid POJOINIKKGO;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid PGGMGECACOJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OEEMGOENMDP;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid JIACEJABJMG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid KOGFCGLICKN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid LHKHGIINJDB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid OKPEALKLDED;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LLJOOGAMJBM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid GPNKLIGNBGH;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid MACBPHIDNMK;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid BJLMLOAJKFO;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid KALBNOPLFLA;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid LOAMGEKFGFG;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid FAMEILNGHML;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid HJLOBJFEDIO;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid LPAGJPGNFOM;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid CDJFIDLDJPF;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid CIDICNPJKGF;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid PAMJCENFEDM;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DLHGLLPPBCI;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid JONDKMMDEAM;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid FIPCMMHLDMK;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid GOIOBDHODOA;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GBKBDIPODHG;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid BMEGGIAIFEN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid ABEKLBKDHDO;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid OHHHGAOCAEK;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid KHEALLDMFHB;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid BLHFIINAFCN;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid HLIHKNHFJBC;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid CAOOKEMDGJA;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid FMKIMDLLOND;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid LCDLEJMBNEL;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid ANFCNBJGADH;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid BBLJKFHCMNF;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid DLDPJEDHBHB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid NIKCBKJFEBM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid BAMOOAMHPJA;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid BNAKOMBFCCH;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid MAGNKKHDLHC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OOPDFAEOEIH;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid MJAOPIFPMGG;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid MIJBCDJKLGO;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid CGHODPCONIK;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid CBCIJEDPNKE;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid CLJDIHIDHOL;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid OCLKJPHAPJG;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid APBIKKJICOJ;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CICEFDPPHMD;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid JNBBMFJLPGM;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid BFFEEJHDADD;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid DCGGMGIEGCG;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid MMFAIMJKFAJ;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid OIKLFMMMPJP;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid AJNAPKDJLDM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GFCCDGLJILB;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid HPEJHJKIKIE;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid BJOFFHCIJBO;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BJGMDFNMHGM;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid BPNGKDPJKBH;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid AFDOOLJKDBC;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid OOABPKCJEBJ;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid OEAJCNFKBFJ;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid MADANJICNLA;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid AJMFBBDHGGM;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid BNLKIDCEHOG;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid MNCCPJLJANO;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid IABAPNJDJBM;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid BDEDBNELGNA;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid HFGPLNDEJOH;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid JADIFCCDKGI;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid BOIBEEPMOFE;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid FOFONJDHJDN;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid CMNOJFDMIEI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid IHLKJGONIGC;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid FDAJMHBDLOH;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid MOCHEADKFAN;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NCLNIIMCNIK;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid IPEAIJPCKCD;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid LJGJBKIJMMD;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid BBEGGKDKKID;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid PNLEGAJEHDO;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid MJMCBHHEAGN;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, CMKJLEFOKPO> MLEDMLBFKGJ;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<CMKJLEFOKPO, Guid> BHEKILFJIKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, CMKJLEFOKPO> NNIOAIGKJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CE00", Offset = "0x6D6C200", VA = "0x186D6CE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<CMKJLEFOKPO, Guid> LMFCHHHCFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CDB0", Offset = "0x6D6C1B0", VA = "0x186D6CDB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HAPHOHHPIPH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D56770", Offset = "0x6D55B70", VA = "0x186D56770")]
	public static bool IGLHHMGHOII(JJAMIHONDLF DJFEDGNPBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D563C0", Offset = "0x6D557C0", VA = "0x186D563C0")]
	private static bool IGLHHMGHOII(AFLNLKDBMAP KFGHKJHEFCL, JJAMIHONDLF DJFEDGNPBDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NKPEMAKHMIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly DCDABDCPDPJ BOLEBHNLPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<FGFJJKFMCDJ> HBNGDIMCGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<FGFJJKFMCDJ> PDDGAEOLDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly FGLBFCBPBCD<PKMIDGFKCAI> BDJCLCIDIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<JABLMADMPHA<EPJMFNGLNNN>> ELECCFIKIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString CBGAACLMNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly OFBIHDMHFPE PPJCPDJDGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool GGPCCPACDCI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CEE0", Offset = "0x6D6C2E0", VA = "0x186D6CEE0")]
	public NKPEMAKHMIA(DCDABDCPDPJ KGEGFAPDDAJ, IEnumerable<FGFJJKFMCDJ> DPLFPHNCENJ, IReadOnlyList<FGFJJKFMCDJ> KKMGJMJOANL, FGLBFCBPBCD<PKMIDGFKCAI> FCOGLBEJEHH, IReadOnlyList<JABLMADMPHA<EPJMFNGLNNN>> NNCHJOIIDNJ, ByteString DBLJPLHJMPP, OFBIHDMHFPE GDHKANAEBFB, bool OFBJIHNMEGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KMONKFGHENI
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(BOBIONHMGIA MPMEGOKIEPF, [Out] Dictionary<int, int> HOCJLBFGHIF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NHKMAHFIMNB CGLKJFAJFIF, LAAHGFLNOGP IAIIPBPBKOM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDMELANKOLF : HMIHHPCOCIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid JMFCLFBDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> LHFNJAACIDL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> LNKJCLLEIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F870", Offset = "0x3C6EC70", VA = "0x183C6F870")]
	private IDMELANKOLF([In] Guid GNBPMMBKNMD, Dictionary<Guid, Guid> ELAIAODPDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D57EC0", Offset = "0x6D572C0", VA = "0x186D57EC0")]
	public static IDMELANKOLF AALKPJMFIHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D58720", Offset = "0x6D57B20", VA = "0x186D58720")]
	public static IDMELANKOLF PCAIMHNMJLG(IReadOnlyDictionary<Guid, Guid> FANLJIDIIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D58390", Offset = "0x6D57790", VA = "0x186D58390")]
	public static IDMELANKOLF HNCMFBENJEB(IEnumerable<KeyValuePair<Guid, Guid>> FANLJIDIIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D58060", Offset = "0x6D57460", VA = "0x186D58060")]
	private static Dictionary<Guid, Guid> FINEFONIPIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D58110", Offset = "0x6D57510", VA = "0x186D58110")]
	public void FLALJGNPMDN(IReadOnlyDictionary<Guid, Guid> FANLJIDIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D57F50", Offset = "0x6D57350", VA = "0x186D57F50")]
	public Guid FGKAGIPPDMP([In] Guid FDANKBMKMCE, bool CMBGCDJJILP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D586B0", Offset = "0x6D57AB0", VA = "0x186D586B0")]
	public bool KEGFPCOIJCP([In] Guid IHELCOHOCAM, [Out] Guid POLFKBGOBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D586B0", Offset = "0x6D57AB0", VA = "0x186D586B0", Slot = "4")]
	private bool PJPEDBNJOGP(Guid CAAJFPBAGHE, [Out] Guid EDLJDADHMAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NNNKLKIGNOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KKDBELDOFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEBAPMNFHGF(ByteString CJEECDKOBOI, IDMELANKOLF LPNKGHPJCJN, [In] UniformTRS NFMMFKDKFBP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HOMLFNEINEJ
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
public class OCLDJEPNDMH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AA360", Offset = "0x9A9760", VA = "0x1809AA360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long KCAKMHLMJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13688A0", Offset = "0x1367CA0", VA = "0x1813688A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long NGMMPEAJAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CFF0", Offset = "0x6D6C3F0", VA = "0x186D6CFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F980", Offset = "0x6A3ED80", VA = "0x186A3F980")]
	public OCLDJEPNDMH(long MGEMHICLKEP, long PINCMEJPPAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JEBMHEDGJEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, OCLDJEPNDMH> JMFLAIMHNED;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> OFCAFLHEMHH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long KMCFPNMMDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13688A0", Offset = "0x1367CA0", VA = "0x1813688A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long FKNEKCHBNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB870", Offset = "0x9EAC70", VA = "0x1809EB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D58A00", Offset = "0x6D57E00", VA = "0x186D58A00")]
	public static JEBMHEDGJEN PNLEOGBHBOA(DCDABDCPDPJ HJBHPKNIFKI, JABLMADMPHA<PKMIDGFKCAI> EJBBKCELHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D58730", Offset = "0x6D57B30", VA = "0x186D58730")]
	private void DOOMFGEAGIG(PDOBBIKMPEL ABBPLCKDHFH, long KKCLODGDDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CA00", Offset = "0x6D6BE00", VA = "0x186D6CA00")]
	public JEBMHEDGJEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DPHHAMGLKOF
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<CMKJLEFOKPO> JCIJJBBACBK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DIPLFLFEDIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> GOEOJFEFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> AIAFOOGHCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public DIPLFLFEDIA(IReadOnlyDictionary<Guid, Guid> BLDGOJFHPGI, IReadOnlyDictionary<Guid, Guid> PLCKPJNNEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AMKLLDLPEBN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JJEMHOCMLIL : IEnumerable<FGFJJKFMCDJ>, IEnumerable, IEnumerator<FGFJJKFMCDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private FGFJJKFMCDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private IGEIJDOEAEO spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public IGEIJDOEAEO <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private HBPGOJBHACA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public HBPGOJBHACA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private FGFJJKFMCDJ System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public JJEMHOCMLIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CA90", Offset = "0x6D6BE90", VA = "0x186D6CA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD60", Offset = "0x6D6C160", VA = "0x186D6CD60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CBA0", Offset = "0x6D6BFA0", VA = "0x186D6CBA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FGFJJKFMCDJ> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CBA0", Offset = "0x6D6BFA0", VA = "0x186D6CBA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D52A40", Offset = "0x6D51E40", VA = "0x186D52A40")]
	public static IGEIJDOEAEO GKADNJEKJND([In] NKPEMAKHMIA JOOFOOOOHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D545F0", Offset = "0x6D539F0", VA = "0x186D545F0")]
	private static void JHHGMGIHJDH(IGEIJDOEAEO LIMIFENDLDG, [In] NKPEMAKHMIA EHBLDHMIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D52BC0", Offset = "0x6D51FC0", VA = "0x186D52BC0")]
	public static MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ> IMIIIFLHGBM(IGEIJDOEAEO LIMIFENDLDG, HBPGOJBHACA BHBNFIEDCKB, IDMELANKOLF? AIKONDIHCAK)
	{
		return default(MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D55350", Offset = "0x6D54750", VA = "0x186D55350")]
	[IteratorStateMachine(typeof(JJEMHOCMLIL))]
	private static IEnumerable<FGFJJKFMCDJ> LIOCIGEOHAM(IGEIJDOEAEO LIMIFENDLDG, HBPGOJBHACA BHBNFIEDCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D520E0", Offset = "0x6D514E0", VA = "0x186D520E0")]
	private static void BLEDNKOMOFG(IGEIJDOEAEO LIMIFENDLDG, IDMELANKOLF? AIKONDIHCAK, HBPGOJBHACA BHBNFIEDCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D54C50", Offset = "0x6D54050", VA = "0x186D54C50")]
	private static void JHKEPICBJHN(IGEIJDOEAEO LIMIFENDLDG, HBPGOJBHACA BHBNFIEDCKB, IReadOnlyCollection<ByteString>? GFJDLOLKBGG, IReadOnlyCollection<ByteString>? FDKBIEHFFGN, IReadOnlyCollection<ByteString>? LAFIEJMLIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D54CC0", Offset = "0x6D540C0", VA = "0x186D54CC0")]
	private static bool KFFPJOGJHJF(IGEIJDOEAEO LIMIFENDLDG, NHKMAHFIMNB CGLKJFAJFIF, HBPGOJBHACA BHBNFIEDCKB, [Out][NotNullWhen(false)] string? GJAHCEMFFMA, [Out] Dictionary<int, int> HOCJLBFGHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D52760", Offset = "0x6D51B60", VA = "0x186D52760")]
	private static Dictionary<Guid, AFLNLKDBMAP> DKMBBLFMNFD(IGEIJDOEAEO LIMIFENDLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D52380", Offset = "0x6D51780", VA = "0x186D52380")]
	private static void BMCDNNEMCEG(bool MFHNAPMHLHE, FGFJJKFMCDJ BLFEKFIMKCH, Dictionary<Guid, Guid> GJMALKBCBIB, IDMELANKOLF AIKONDIHCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D52420", Offset = "0x6D51820", VA = "0x186D52420")]
	private static void BNONIFFAHOC(FGFJJKFMCDJ BLFEKFIMKCH, Guid HJHGEIKMJIL, FLOOECLMCCH? AINHFICNAIL, Dictionary<Guid, AFLNLKDBMAP> LLDDNGBBBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D55460", Offset = "0x6D54860", VA = "0x186D55460")]
	private static void PFLPDPHOBBL(IEnumerable<FGFJJKFMCDJ> CBEMJCDGGLE, IReadOnlyCollection<ByteString> GFJDLOLKBGG, IReadOnlyCollection<ByteString> FDKBIEHFFGN, IReadOnlyCollection<ByteString> LAFIEJMLIMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HBPGOJBHACA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool MFHNAPMHLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public OFBIHDMHFPE GDHKANAEBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public FLOOECLMCCH? AINHFICNAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public FLOOECLMCCH? IPILABGNDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public DCDABDCPDPJ KMCCMAAGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public HOMLFNEINEJ LADGEKOEMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public KMONKFGHENI MKEFMNPKHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public NNNKLKIGNOJ INEBCCJCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public JABLMADMPHA<PKMIDGFKCAI> LECMECBNCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public CIPHLFPOECO ENEABKEHGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<FGFJJKFMCDJ> KCEFFJGLALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> KKHPNEIBHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public PJPJBPBBEMJ FIIHMNONKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool CIFFKOGJFIO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool NACBJKMJHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D567A0", Offset = "0x6D55BA0", VA = "0x186D567A0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FLOOECLMCCH
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float NDCKBBNGIGH = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion EFFHGIJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float BJGGPAGHNPO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 DDHJIFNIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6D55FB0", Offset = "0x6D553B0", VA = "0x186D55FB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS IJKEGKIPPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D56190", Offset = "0x6D55590", VA = "0x186D56190")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xE45B40", Offset = "0xE44F40", VA = "0x180E45B40")]
	public FLOOECLMCCH(Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float BJGGPAGHNPO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D562F0", Offset = "0x6D556F0", VA = "0x186D562F0")]
	public FLOOECLMCCH(UniformTRS BPNAHKDEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D55B20", Offset = "0x6D54F20", VA = "0x186D55B20")]
	public static FLOOECLMCCH HNAJCFJDBHI(FLOOECLMCCH IIOPLDELPHL, FLOOECLMCCH GDKJIANFPJB)
	{
		return default(FLOOECLMCCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D55F20", Offset = "0x6D55320", VA = "0x186D55F20")]
	public static FLOOECLMCCH ICFKEBCLOFF((Vector3, Quaternion, float) MPMEGOKIEPF)
	{
		return default(FLOOECLMCCH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6D55DA0", Offset = "0x6D551A0", VA = "0x186D55DA0")]
	public static FLOOECLMCCH ICFKEBCLOFF(Matrix4x4 GPKJLCOGDNA)
	{
		return default(FLOOECLMCCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D56260", Offset = "0x6D55660", VA = "0x186D56260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D560B0", Offset = "0x6D554B0", VA = "0x186D560B0")]
	public FLOOECLMCCH JMJPOJLAJPG(Matrix4x4 ADJOLMKPBJM)
	{
		return default(FLOOECLMCCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D55F40", Offset = "0x6D55340", VA = "0x186D55F40")]
	public static FLOOECLMCCH ICPILAGEAPH(Vector3 MBJNFCDOKCE)
	{
		return default(FLOOECLMCCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6D561D0", Offset = "0x6D555D0", VA = "0x186D561D0")]
	public readonly LGKLMGHGDKJ NNMGKNNMKMI()
	{
		return default(LGKLMGHGDKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FDJOPHIMJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E7C0", Offset = "0x6D6DBC0", VA = "0x186D6E7C0")]
	public static FLOOECLMCCH JOAOBCMHAKL([In] this LGKLMGHGDKJ MBGHIKEGJAA)
	{
		return default(FLOOECLMCCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LAOPHBHACIG
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PNKHBCGCBEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly NGPPCLKPJGD EJFPBPAJBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly JPHFAKFKMJL BGHMAJAGPIO;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10CA180", Offset = "0x10C9580", VA = "0x1810CA180")]
	private PNKHBCGCBEJ(NGPPCLKPJGD DDBAKACFGMN, JPHFAKFKMJL NDBFKHGMELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D76700", Offset = "0x6D75B00", VA = "0x186D76700")]
	public FEGHIOJFDLM PNHOGOPEGFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D76650", Offset = "0x6D75A50", VA = "0x186D76650")]
	public static MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ> AALKPJMFIHM(LFGPIALNGOL<OKFEIOHLOGM> NDBFKHGMELA)
	{
		return default(MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6D765A0", Offset = "0x6D759A0", VA = "0x186D765A0")]
	public static MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ> AALKPJMFIHM(FEGHIOJFDLM NDBFKHGMELA)
	{
		return default(MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D764E0", Offset = "0x6D758E0", VA = "0x186D764E0")]
	public static MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ> AALKPJMFIHM(string IOCOIEEJIIF)
	{
		return default(MLIDCCDLMIE<DIPLFLFEDIA, PNKHBCGCBEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NGPPCLKPJGD
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MAJGLIPFJEJ : IDisposable, BNCLDONCACN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<HIKPHCIMFOK> FPIPIBFJNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float FNDBOJKCJNK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NOPFFDAOKNH AIKNJJJIEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0")]
		[CompilerGenerated]
		get
		{
			return default(NOPFFDAOKNH);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4C00", VA = "0x1808B5800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool JJNAEONDMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D73A20", Offset = "0x6D72E20", VA = "0x186D73A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool ENNEEBCJLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D73290", Offset = "0x6D72690", VA = "0x186D73290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<CPFBKLNOEBI> DIIJIKIBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CFHLNOANINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D73400", Offset = "0x6D72800", VA = "0x186D73400", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float LNMLNIOMKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D728E0", Offset = "0x6D71CE0", VA = "0x186D728E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D74F50", Offset = "0x6D74350", VA = "0x186D74F50")]
	public MAJGLIPFJEJ(NOPFFDAOKNH MLLKMCGEGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D73120", Offset = "0x6D72520", VA = "0x186D73120", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D72A70", Offset = "0x6D71E70", VA = "0x186D72A70")]
	public Vector3 BHAOPJGMLBJ(int HOEIKPCADHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D73A30", Offset = "0x6D72E30", VA = "0x186D73A30", Slot = "6")]
	public Quaternion KIKCHEFJELP(int HOEIKPCADHN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D731F0", Offset = "0x6D725F0", VA = "0x186D731F0", Slot = "5")]
	public Vector3 EOHENCJPELF(int HOEIKPCADHN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D730C0", Offset = "0x6D724C0", VA = "0x186D730C0", Slot = "7")]
	public float DPLHFNGOJCH(int HOEIKPCADHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D74570", Offset = "0x6D73970", VA = "0x186D74570")]
	public void OGMDDOPPGAM(Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float MINBCCGNENH, bool ACGOAAODBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D73D10", Offset = "0x6D73110", VA = "0x186D73D10")]
	private bool NCMALPCFKJP(int GHJBCPLAKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D72F40", Offset = "0x6D72340", VA = "0x186D72F40")]
	public void DKDGJIBGBJM(Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D72850", Offset = "0x6D71C50", VA = "0x186D72850")]
	public void AMHFBOGAKKH(int GHJBCPLAKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D72700", Offset = "0x6D71B00", VA = "0x186D72700")]
	public void AJEJCPNAAAN(int GHJBCPLAKCK, Vector3 MBJNFCDOKCE, Quaternion EFFHGIJAIIE, float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D73B60", Offset = "0x6D72F60", VA = "0x186D73B60")]
	public void LGBGCOIJFFP(int GHJBCPLAKCK, float3 MBJNFCDOKCE, quaternion EFFHGIJAIIE, float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D738D0", Offset = "0x6D72CD0", VA = "0x186D738D0")]
	public void JBEJLPPNDFD(int GHJBCPLAKCK, Vector3 MBJNFCDOKCE, float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D732A0", Offset = "0x6D726A0", VA = "0x186D732A0")]
	public void GNJGHFHABML(int GHJBCPLAKCK, Vector3 JNKEFPKOLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D73D70", Offset = "0x6D73170", VA = "0x186D73D70")]
	public static Quaternion NDOPIDIPMBG(Quaternion NDIDLOHFNJO, int GHJBCPLAKCK, float MIBPAFOJIBG, BNCLDONCACN HAPLABELDEB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6D73440", Offset = "0x6D72840", VA = "0x186D73440")]
	public Bounds HGOLLFCMFIH(Transform ADJOLMKPBJM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6D73180", Offset = "0x6D72580", VA = "0x186D73180", Slot = "10")]
	public virtual void EBMMIKDGLGJ(bool MILBOJLNJFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D74E80", Offset = "0x6D74280", VA = "0x186D74E80")]
	public NativeList<HIKPHCIMFOK> PECDJDBIDNB(float IFPCPBFFDEM = 1f)
	{
		return default(NativeList<HIKPHCIMFOK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CPFBKLNOEBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 KHBHMHPABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float HDKACKFHKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion MBBJALOICIN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E470", Offset = "0x6D6D870", VA = "0x186D6E470")]
	public CPFBKLNOEBI(Vector3 JMOAHJJIPDJ, Quaternion NDIDLOHFNJO, float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DF20", Offset = "0x6D6D320", VA = "0x186D6DF20")]
	public Quaternion FMLOAKKAIEO(Vector3 NLEBNOPPEID)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DFE0", Offset = "0x6D6D3E0", VA = "0x186D6DFE0")]
	public CPFBKLNOEBI OPGKIJOHJPP(Vector3 GMNMGMPPONG, Vector3 HGBDMPMNKDL, Vector3 FONOLPHKHNM)
	{
		return default(CPFBKLNOEBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E2D0", Offset = "0x6D6D6D0", VA = "0x186D6E2D0")]
	public OBPDEOPIEGI PLKFIKMJIJC(Vector3 NLEBNOPPEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class APKMONJPGPE : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D5F0", Offset = "0x6D6C9F0", VA = "0x186D6D5F0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D8F0", Offset = "0x6D6CCF0", VA = "0x186D6D8F0")]
	private void NICKFPAIMLL(Dictionary<Guid, Guid> AIACKFDDNJN, NIJGJHPLGAG CPBEONPDLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DEC0", Offset = "0x6D6D2C0", VA = "0x186D6DEC0")]
	private void NICKFPAIMLL(Dictionary<Guid, Guid> AIACKFDDNJN, JEAOBAKHAMA PKAPKIDGENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D670", Offset = "0x6D6CA70", VA = "0x186D6D670")]
	private void NICKFPAIMLL(Dictionary<Guid, Guid> AIACKFDDNJN, KFGAIEIJENC IBCKBHDMGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public APKMONJPGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DEBCECPFKJI : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E5E0", Offset = "0x6D6D9E0", VA = "0x186D6E5E0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public DEBCECPFKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LPBPPJJKFMM : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D725A0", Offset = "0x6D719A0", VA = "0x186D725A0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LPBPPJJKFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MPKGMPIHKFB : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D76140", Offset = "0x6D75540", VA = "0x186D76140", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public MPKGMPIHKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JHNHAKHCOID : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6D721A0", Offset = "0x6D715A0", VA = "0x186D721A0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public JHNHAKHCOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OEMHMHNKKIE : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D762A0", Offset = "0x6D756A0", VA = "0x186D762A0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public OEMHMHNKKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AOGFJMCPNLP : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D0B0", Offset = "0x6D6C4B0", VA = "0x186D6D0B0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public AOGFJMCPNLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DEAJCIKAJBM : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E4F0", Offset = "0x6D6D8F0", VA = "0x186D6E4F0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public DEAJCIKAJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FPKONNOAHJB : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E880", Offset = "0x6D6DC80", VA = "0x186D6E880", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public FPKONNOAHJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GDBNOJHMGCA : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EA30", Offset = "0x6D6DE30", VA = "0x186D6EA30", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public GDBNOJHMGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class OHHLNANAFPB : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D763E0", Offset = "0x6D757E0", VA = "0x186D763E0", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public OHHLNANAFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FBPMHGHGDLE : LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly OFOFLPBHBIO GHAAIFFCBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E690", Offset = "0x6D6DA90", VA = "0x186D6E690", Slot = "4")]
	public void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public FBPMHGHGDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JJAMIHONDLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public NHKMAHFIMNB DMDALLEEEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public DHNLHLMGAND ACDIDBKNCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> IHIGDMOPKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> ALKDLFLJBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public PJPJBPBBEMJ FIIHMNONKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool KLBPBADFKHP;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LDHPNBBMOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOICPDMNBCH(PPIJCNOPCMK CDCBDKOBDME);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MBIEHBGEGIH
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly LDHPNBBMOGH[] EDEGBICBPIO;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D754F0", Offset = "0x6D748F0", VA = "0x186D754F0")]
	public static void FOOIHPMLOIA(FGFJJKFMCDJ MPMEGOKIEPF, Dictionary<Guid, Guid> BAHADBHPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D75260", Offset = "0x6D74660", VA = "0x186D75260")]
	public static void DBKOCBPKMEP(FGFJJKFMCDJ? MPMEGOKIEPF, IDMELANKOLF JLHEGJALDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D74FE0", Offset = "0x6D743E0", VA = "0x186D74FE0")]
	public static void CPGNDFMCDEI(FGFJJKFMCDJ? MPMEGOKIEPF, IDMELANKOLF AIKONDIHCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D75780", Offset = "0x6D74B80", VA = "0x186D75780")]
	public static void IGLHHMGHOII(PPIJCNOPCMK CDCBDKOBDME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct PPIJCNOPCMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public NHKMAHFIMNB BIFDHLLMONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public FGFJJKFMCDJ BLFEKFIMKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> IHIGDMOPKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> ALKDLFLJBLM;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D76770", Offset = "0x6D75B70", VA = "0x186D76770")]
	public Guid MNAPKBOFOFH(Guid FDANKBMKMCE)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PJPJBPBBEMJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int CGNAJJFLOLA, [Out] Guid DOPHPOGAEIP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GPKGCOMPHAG
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker GFJCAHAJPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> MEHDMKEAGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> BKNNGJAHDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> CCHMDBKNGPD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> FNJJPDKOOJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> GEGOGDNGBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F110", Offset = "0x6D6E510", VA = "0x186D6F110")]
	public static GPKGCOMPHAG CDPJGHPIANN(GBHFJBFIHDK CAAMOPOAIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D70010", Offset = "0x6D6F410", VA = "0x186D70010")]
	public static GPKGCOMPHAG ILLNGKKGPBN(IGEIJDOEAEO NBGEHENGLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D70080", Offset = "0x6D6F480", VA = "0x186D70080")]
	public static GPKGCOMPHAG OKHDDFENCDJ(IEnumerable<string> MEHDMKEAGOJ, IDictionary<long, int> IIIGKNEJJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D70400", Offset = "0x6D6F800", VA = "0x186D70400")]
	private GPKGCOMPHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D702C0", Offset = "0x6D6F6C0", VA = "0x186D702C0")]
	private GPKGCOMPHAG(IEnumerable<string> MEHDMKEAGOJ, IDictionary<long, int> IIIGKNEJJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F950", Offset = "0x6D6ED50", VA = "0x186D6F950")]
	private void DJDJBDBHNGO(GBHFJBFIHDK CAAMOPOAIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FC90", Offset = "0x6D6F090", VA = "0x186D6FC90")]
	private void DJDJBDBHNGO(IGEIJDOEAEO NBGEHENGLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EC50", Offset = "0x6D6E050", VA = "0x186D6EC50")]
	private void BOEFPNNOMHE(ByteString? DBLJPLHJMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F4E0", Offset = "0x6D6E8E0", VA = "0x186D6F4E0")]
	private void DJDJBDBHNGO(CLMGCABGNKJ? FINELPFBLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FB50", Offset = "0x6D6EF50", VA = "0x186D6FB50")]
	private void DJDJBDBHNGO(BOAKPOGKLFL? ABBPLCKDHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F180", Offset = "0x6D6E580", VA = "0x186D6F180")]
	private void DJDJBDBHNGO(FGFJJKFMCDJ? BLFEKFIMKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EBE0", Offset = "0x6D6DFE0", VA = "0x186D6EBE0")]
	private void BJPBCNAPGDM(string? NMDFIPGNKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FF40", Offset = "0x6D6F340", VA = "0x186D6FF40")]
	private void HBECOPDCDPN(long EAAANOFDHEP, Guid MMAAEHJNAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FE90", Offset = "0x6D6F290", VA = "0x186D6FE90")]
	private void HBECOPDCDPN(EJHNDLAMIBF? GHJCBEPCCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FEE0", Offset = "0x6D6F2E0", VA = "0x186D6FEE0")]
	private void HBECOPDCDPN(BNONBCLEBEK? GHJCBEPCCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct IBIPOBFDLFD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class APBCCEBFEEC : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> GFMJPAEEPBE;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry NJNHNLEJBOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D3C0", Offset = "0x6D6C7C0", VA = "0x186D6D3C0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D490", Offset = "0x6D6C890", VA = "0x186D6D490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D540", Offset = "0x6D6C940", VA = "0x186D6D540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D2E0", Offset = "0x6D6C6E0", VA = "0x186D6D2E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
		public APBCCEBFEEC(IEnumerator<DictionaryEntry> GFMJPAEEPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D240", Offset = "0x6D6C640", VA = "0x186D6D240", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D290", Offset = "0x6D6C690", VA = "0x186D6D290", Slot = "9")]
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
		private sealed class HGFFICHJJFF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D70670", Offset = "0x6D6FA70", VA = "0x186D70670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
			[DebuggerHidden]
			public HGFFICHJJFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6D70520", Offset = "0x6D6F920", VA = "0x186D70520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6D70620", Offset = "0x6D6FA20", VA = "0x186D70620", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D76DE0", Offset = "0x6D761E0", VA = "0x186D76DE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object GMJINMLEEAC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6D76CF0", Offset = "0x6D760F0", VA = "0x186D76CF0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D76EC0", Offset = "0x6D762C0", VA = "0x186D76EC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6D76C30", Offset = "0x6D76030", VA = "0x186D76C30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D76C90", Offset = "0x6D76090", VA = "0x186D76C90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6D76E60", Offset = "0x6D76260", VA = "0x186D76E60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6D768F0", Offset = "0x6D75CF0", VA = "0x186D768F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6D76950", Offset = "0x6D75D50", VA = "0x186D76950", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D769B0", Offset = "0x6D75DB0", VA = "0x186D769B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
		public RoomObjectCounts(Dictionary<int, int> GDLDAFHBCBP, [Optional] Dictionary<int, int> NFAPIDENADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D76810", Offset = "0x6D75C10", VA = "0x186D76810")]
		[IteratorStateMachine(typeof(HGFFICHJJFF))]
		private IEnumerator<DictionaryEntry> IHLPDDMNGJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F10", Offset = "0x6D76310", VA = "0x186D76F10", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D76B30", Offset = "0x6D75F30", VA = "0x186D76B30", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D76A10", Offset = "0x6D75E10", VA = "0x186D76A10", Slot = "9")]
		void IDictionary.Add(object GMJINMLEEAC, object LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D76A70", Offset = "0x6D75E70", VA = "0x186D76A70", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D76AD0", Offset = "0x6D75ED0", VA = "0x186D76AD0", Slot = "8")]
		bool IDictionary.Contains(object GMJINMLEEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D76BD0", Offset = "0x6D75FD0", VA = "0x186D76BD0", Slot = "14")]
		void IDictionary.Remove(object GMJINMLEEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D76890", Offset = "0x6D75C90", VA = "0x186D76890", Slot = "15")]
		void ICollection.CopyTo(Array AFBDFGIDJPF, int AEAHMAMPNLO)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class JOBAADNGHNE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D72550", Offset = "0x6D71950", VA = "0x186D72550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
			[DebuggerHidden]
			public JOBAADNGHNE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6D723C0", Offset = "0x6D717C0", VA = "0x186D723C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D72500", Offset = "0x6D71900", VA = "0x186D72500", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D71EC0", Offset = "0x6D712C0", VA = "0x186D71EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object GMJINMLEEAC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6D71D90", Offset = "0x6D71190", VA = "0x186D71D90", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6D71F70", Offset = "0x6D71370", VA = "0x186D71F70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6D71CD0", Offset = "0x6D710D0", VA = "0x186D71CD0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D71D30", Offset = "0x6D71130", VA = "0x186D71D30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D71F10", Offset = "0x6D71310", VA = "0x186D71F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D71950", Offset = "0x6D70D50", VA = "0x186D71950", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D719B0", Offset = "0x6D70DB0", VA = "0x186D719B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6D71A10", Offset = "0x6D70E10", VA = "0x186D71A10", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x221ABF0", Offset = "0x2219FF0", VA = "0x18221ABF0")]
		public Invention(long IHELCOHOCAM, int MGEMHICLKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D71880", Offset = "0x6D70C80", VA = "0x186D71880")]
		[IteratorStateMachine(typeof(JOBAADNGHNE))]
		private IEnumerator<DictionaryEntry> IHLPDDMNGJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D71FC0", Offset = "0x6D713C0", VA = "0x186D71FC0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D71B90", Offset = "0x6D70F90", VA = "0x186D71B90", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D71A70", Offset = "0x6D70E70", VA = "0x186D71A70", Slot = "9")]
		void IDictionary.Add(object GMJINMLEEAC, object LIHHDPOHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D71AD0", Offset = "0x6D70ED0", VA = "0x186D71AD0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D71B30", Offset = "0x6D70F30", VA = "0x186D71B30", Slot = "8")]
		bool IDictionary.Contains(object GMJINMLEEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D71C70", Offset = "0x6D71070", VA = "0x186D71C70", Slot = "14")]
		void IDictionary.Remove(object GMJINMLEEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D718F0", Offset = "0x6D70CF0", VA = "0x186D718F0", Slot = "15")]
		void ICollection.CopyTo(Array AFBDFGIDJPF, int AEAHMAMPNLO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> BODLLJLFKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> IBCCBCDPDEM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public IBIPOBFDLFD(IReadOnlyDictionary<Guid, RoomObjectCounts> GMCNPCEALBF, IReadOnlyList<Invention> KDLHHPBNAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D706C0", Offset = "0x6D6FAC0", VA = "0x186D706C0")]
	public static IBIPOBFDLFD CDPJGHPIANN(GBHFJBFIHDK CAAMOPOAIJO)
	{
		return default(IBIPOBFDLFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D71760", Offset = "0x6D70B60", VA = "0x186D71760")]
	[CompilerGenerated]
	internal static int MMGINBNFKPG([In] IReadOnlyDictionary<long, int> BMJPLAOLAPJ, long? EAAANOFDHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D710A0", Offset = "0x6D704A0", VA = "0x186D710A0")]
	[CompilerGenerated]
	internal static void DGKPCLMEHNB(int ONHNPNAKJIB, [In] CLMGCABGNKJ LGAELPJHPCC, [In] Dictionary<long, int> BMJPLAOLAPJ, [In] Dictionary<Guid, RoomObjectCounts> GMCNPCEALBF)
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
