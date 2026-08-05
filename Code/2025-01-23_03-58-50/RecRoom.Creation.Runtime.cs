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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ED8940", Offset = "0x6ED7140", VA = "0x186ED8940")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KALGCAAOFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LIBKOKFEMEK;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OGCOABHNDBG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> FHPHGGABGBG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> FFCOMFIELJO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string FCAFJCMCEMD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string NBKMMADDMIP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string PFMGIKLAOCL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3370", Offset = "0x6ED1B70", VA = "0x186ED3370")]
	public static bool AGJEEHEBFDM(Guid FGHPPKDKBAK, int IAPLAMBDEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3B40", Offset = "0x6ED2340", VA = "0x186ED3B40")]
	public static bool LBFGMDGMMIC(Guid FGHPPKDKBAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6ED3470", Offset = "0x6ED1C70", VA = "0x186ED3470")]
	public static string GGPEPMLDFHI(Guid PLMJELCKKDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PDNGFFOENFP]
public enum OLOCIKCIHNM
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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ED83A0", Offset = "0x6ED6BA0", VA = "0x186ED83A0", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HEMFCNAAPDE
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid IFBCNOLJMJB;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid NPLPAGCIEEI;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid EMCOOMENKIN;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid OAHDHEPMCHP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid CEFGOJBOGGO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid HFIINNHELMF;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid MADBBFDCNJP;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid POONHOGBGHB;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid KPGFNNHCBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid CEMADODJOAM;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid OGCEDJIFOKP;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid EHJEAADMAHL;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DHAKCELNPOJ;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid FFJLHBDFHKC;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid OHAIKEMJMME;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid GHADEHCFGDB;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid DJIIMPPFKNG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid APMEALGHPDL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid PBIAJMAALPJ;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JGDLIEPKEJL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid CBOBGBHFLJN;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid IEKBFCCACOI;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AIGLFMNJGDN;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HLOMMELGHNI;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid OPGOJGPBFNL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid BCCODBPBLLI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid GFKEPMJAIKK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid LKLMAKNBCOO;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ECAEHPDJOCM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid MPFLLENEEDP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MKKMPMGLHHP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid AEPLEFIEDIN;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LFBJFEAIFCN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid KLMNCFFMDMI;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PLJHEPLABAC;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CGNFFFKIILA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid HHFPIKMBHHF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid DIDMBDDNHCP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid BHIJFDDLOMN;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid NHPFEHADNHF;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HDOBMHAAKIE;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid CMGCGDGCNMM;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FNHKEIGPBPP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid PHJKBJCHHDJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid EFABKCFOMIO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid EKEPBHJKEAL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NJKGFFGKHNB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid BPOGOBNMPJG;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid BFAGJDBHCAF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid NJAGFLCJAJP;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid CNBLCDHLDAD;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid MBIPLCHHOBC;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid BLGLDEFIKPB;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid FAJJFCJDALE;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid KHMNFHAGJBP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid BGIAKKGBEMA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid PMKGBJDCKIO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid KDHOIPICCFE;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid CEEIIPMICOH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HGONKAGKHPH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid OAHOAJPEKBE;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid OECNGCHJADA;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid DPKHCPCKCNI;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IPOGIKLJNHE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DGLGEABHDBN;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MHIHAKHALBO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid EPBMGMIPAGN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid LJBJPPHEBJC;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NBBNKNFNMIA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid PJHBHODPMJA;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid EIAGGLIALEG;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid OKFHMJDAMNG;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CAJKHFOGEKC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid AOOKMKKJLOP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid DLLFFGJNICH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HDHDIPJLGAB;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JAOOHGOLLML;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NKBIOAMNDFI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid LMLELAKOLLG;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid LMLKEMDLIGP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid DILHMICAKDC;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid ENANGEAAFAD;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid BNOCKAMAOCJ;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid ONNDJHHJMAD;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid IFCPIBEODPD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid IPDIPOHNKKF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid PGKHDCMACDG;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NFDKJHEIKIL;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid ECNKJAMMAEB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DHAKCJDCCDN;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid OGIBLLNBIFH;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid DNGPKNKLDDO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JHCOLMCLAFH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid PIICCBLFMJH;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid CAHPPIMNNPE;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid PAKPEDLJINP;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JOMGFBBKJOK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid COIGOEDNPPG;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid ODBJEEBOPHP;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid AENOPJEJAHO;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid IPHIBLHEJMB;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid EOJABOKCAFL;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid EOIAIHJGDHK;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OBDGKHMEGED;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid AJCPONKGFNL;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid EGLLDAGGPHA;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid MFDNOJDBDLN;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid FGFOFNHGPAO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HMPMPKJHBCB;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid EJBCOPBJJEM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PHPEFCLEFOA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NFGEGCMNACC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid HJGIGBNCMFM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BIMBPJKFOKB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid AEKEIPDBJGF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid INJDHANPOJF;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GLBOHIHNPFC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid APOAPLIIFKK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid EMHBAJCELII;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid JFPAJHANJMI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid DLFOFLGCDNC;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid IEGILIIBJIG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NNCMADLGCCC;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid CFLGGBNNNGH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid EKDDGBENFJF;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DJHDPMKCJCE;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MNEAFJJADDC;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid BEIMBBOKKPG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PLKDAIAEFME;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid DADGFMCIAHI;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid IFAANOAEMDK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid FCKNJNMACBJ;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid HDMCLMFHGMK;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid LHMECONIGFF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PNCOGDPLCLD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid FFPMDIDEOAN;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NPFPCKBFLFD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid KEHCNGOEONM;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid IMKAIHMLMLH;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid KPEBOKHICIG;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid HAHLBKENOLB;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid NFLAJNMHKHH;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NJPIEANMHIP;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid JMHECHCHMHC;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid OHFJJPJGCMM;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid AMOFNHOKMFM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ODDGEMLHMEE;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid AHKGGOEKEOL;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid AAKJGIEBNOE;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid FJEALHNHGNB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CPGFKHENJAE;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid BILGJGMNLKG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid ADAADGCHNFA;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BGGGLMOGLGF;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid DNHBGGDNCJB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LDPBAOPKGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid AEEIEJOEPLL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IGNCAJLAMIO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid CDJBONEKGEP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PBAJKCBPIOG;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid GINIALOAEBP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DFANCJHJNHC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid GOGFHONBDPI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid IGHDGIBKBJA;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BBJCEILJCDN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid KFPMKKLNOMN;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid DJNIGENICHE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid HMLKOMKOAFP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid ELFCHKFIMLO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid APMCILDMGPI;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid LEGCKDOIDBG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NOABOOCGFEC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid INCOJIPKKAF;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid BOECHHKJHCB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid DPDOOIONKLL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid OAFHCAODFBF;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid MBEFFJNODMO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid EKNOHAOBGPI;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid HEAPOPDMGHJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ILAPNAGGKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid MMFJEFCGOPH;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid NPIIJCJCILI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid DLBHHAJPECE;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid EGLDPDANIIN;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BEEIEEEPDLK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FALBDKPOAAG;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid GCBDAHBPDOE;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GJANGPAJIHL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid CMHMIKJNIEO;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid PPJOFBKJEJF;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid KLDOCNMAFJE;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid NELJLGOLKBB;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid KODMFAMIFEN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid MGBMEEBKKND;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid PNOADIPKKAA;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid AJOPCBHDEDH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OBIEHAAFIGD;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid MJBLOJPBKGP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MMBHIEGGMDL;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid EFHDCIECJPO;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid LGMMOIHDBEG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid OHMJMIJJLEM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DHLNADPNMDF;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PIDBLLHDGOI;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid LPKEAHDHGFJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid PELFGLHIHEM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid PLKJABPEJFG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid LFPJIMALGEL;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DBGDGLLECJO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid HLMFIJHAKMB;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DBDPIALFPCC;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid FOODLCMMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JEMOIEKABBF;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OGCEKBCAHLH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JDNDFDLOFCK;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid CKGBEDGEJOK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IJIDCKEDGAA;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BEAJPCLMBCI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid MOBOKEADANP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid MMILJEEGCBL;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EOKDBKGLIDP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid CLCEGECDDPA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KGCBKLGDOGO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid JCIDJJNHIJP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid GMPOBHHDCME;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BMCIFKBGKBP;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid KBMMKBJDEGD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DHDKDPELMGK;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid IFBJKOJPPFD;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid OKFGMMFLGKH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LIECPFALPAN;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid PLKOPFJHBLE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FNNKNFGPAGD;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid ODKNDGBGGEN;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid OFHKLDPJDCB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MLIJAEJFBJI;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid EMLGIFPEONH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KDLNDMKOHOA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DHADDFJMOJB;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JLDLBDCLGJG;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NCLJFJJOEPE;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IHICCMACFCM;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid NALEDBBOJAM;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid MMFGFALALEE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JPPKDJBJJLC;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid CILPGOOGOIE;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JKEFADOCHKP;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid NFJCPEAEMHD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HGBDPHIMCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid HCIGPFIGCMI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GEGPAJNGEPH;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IMMLAJEDHKG;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid NLCCABJFKKN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid DGMHCJMCIPI;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid MBJKNBBLAAE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NMFECLLDEII;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid ODAIFGLNFHK;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HDKLHNGJIEP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid BFKFJCCMKJM;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid BNHNJOAGNDI;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MDFLFJFIPIB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid IFDAMBNFPLO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid PGCAPDCBNJG;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid LIDENDJKNGL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GMIKPHIKHLB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BCJBIBDDKBM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid OPMIIEIBDLH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid LANLIDPGGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LBCGNLEJGKN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DBAEEPEJDMI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KDCEKAGOLGP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid ENFEDOGJFGO;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid OMJMBHEDEMM;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MPFMDAEDKHA;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid IMGIHPGEFLI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid CBKEJNODBLF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MJBIKICAJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CDDCIFJLOFN;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid OBABBNEFJJH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DDHNAAEOPDK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FIDINPCKHKA;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DBNIOFGOPIE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid KPFOBJJCCLI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MLLELLNGMAM;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid PMNOOHGIMFA;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid MMKKNKDALMC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid GNCMLENILAI;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IDIOFMIHANE;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HEFFEMAODEM;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid EEGDCHHFLKL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CANMGJMNNAI;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid OACDABLLBPP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NLCGIEODIND;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GDACHHEJFPK;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid HGPLIFMEBOF;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid PBIGNDLLNEK;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid HCIHHOJMKCI;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid MCGLLHKKBGB;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid AJEAHPCFBHE;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LBEHGIHMAFH;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid GICJOCMDMBG;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid NFIJKDPMGLL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid OACDEGGPBGL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid AKFKFKLFDHH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BJPODOIGHAN;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid CGHNKPDHLAO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PEHOOCCMJEI;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EDEFEGNFGOB;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid PMGLCPJPCEF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LFHNKGABEIJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CBILAHJDNLK;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DMJEJHKILDN;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid KODOAFKAIHJ;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid LHPDNKMFJFC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid DGPGGOKAENK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid LIHEAPLICDB;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid CBGPDKEHBOG;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid FONJEOJPFNP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid INELMAPJAHP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid AKNJIILPFHO;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JKNFNCMDEAP;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NEEMIIOEGDB;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LFGFGEBHLCF;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MEOCPJHNPJP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BADOOPINEFD;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid OKIJOAPNEPB;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KJOCIPMDDPH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid OIDOCLFHEAH;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CANDKONMLML;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KEKLDMINDEN;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid CDJANDGALMM;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JGCMPDMAHID;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid IHGDKIHLINA;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HNLMONDGGBE;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CLKDEBKFPIJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid LKHNNHDAJHK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid CLMIEHICKAO;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid FEDMBIELNMI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid DCCFHNENCHF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid LBCDNONJJAN;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid LFOAIPOKHEG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid AIPKKAAFDON;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid MMCPGPMIGPB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid BMBOLAFDEBH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LGGIDCCABJI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid LMMEKEBBFAA;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DOBLMFJFIIM;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid JLDACOKNCNN;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid NPGEFBMKJCC;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DEEJCBCIMOD;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid JDCFBHJIDIC;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid LIBJAGEANHP;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DMDNAEKJOBK;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid POKGCOIEPLL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CCACAJFHLHH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HOLDNPGCBNE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid HLHHNBHCPKE;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OANGCGFJJEB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KENJEFGLOAE;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid IOFNFHGNKFM;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid GDGLDHIGCBH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid DLEGLHOHMPN;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid MPCPLJDJKFH;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid LAJINDHAOON;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid JLODHCJKJPN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid JPCMBPOPEIA;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EEMODCLBFEB;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ADEFOPAAHJB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid FIOLEAGEFDC;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MBJNACKFKJK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid BOALDKPMCJC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid ABICPLILCPB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid BHFHAFMDKPI;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid KPKANEKIECL;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid KHIAAPDEMBJ;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid FCJPLOAHADA;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid PKLJFBKJEOL;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BFAJHKDABLH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PLOIGCIOFLB;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid BIDIPNMCAGC;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid BPGAOAOAHBB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid GMAGGADOOMP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid DEPEAMAALCJ;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid FLIJFEHNKPJ;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid MFJNNAGAJEM;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FAIKCOADDFO;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid GFMNOEBDFMK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid JEJCMOAHDFL;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JLMHBNBGMHD;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid OCIGFKGMIFO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid PAIDLBKHNIP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid PJNLKAIODPL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FACOAAJNJNN;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PFKNMCCNGBA;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid AMAOMBOCCIJ;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DCNELDOPHKO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ABCCIOPHAIC;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid KCJIHNOEGAO;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid NGPJMMNCDPL;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid MIPMJIAEECO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid KIPPCGCAACH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid LCLPNHFODDD;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid GMBEMEKBNLC;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid MJEIAHMJCIK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid KIIODEOPCMN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FJJMDOECFIF;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NBNBOCENNJD;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DAGNLAMDGHB;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid GMKOLOBDJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CLMJFJLCHFE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NOBBCAGOBBH;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BCCJFHHPNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DEIONBJPCDA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid DIMJHAFBBHC;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BEIGNHKKLDH;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid JMOBDJLGHOL;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JPDKGACHIDE;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid BACBKGAOCPO;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid KKHDDNMNDBK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JKFOCCNBOEC;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid EMEJNPMLPPO;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid BFIPPOBKLOK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid EALKMLBGNDK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid IGJLODIMNHN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FLJPDEAHAEE;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid CFFGHJIMKJL;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid OPFPLFJKAIM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EBDHEFFKKBA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid DGIPCNFPJPK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid AFJDKMNMPBG;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid GLMDIEACIEP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid IMPPMKIEAOI;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid EADCCFAAOOK;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MOCLMAKAEBG;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid GFOHABNLKJF;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid DHDDNNNDBJF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NIBFOKKAHBD;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid ANFMMMLGMLF;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid EMFLFIEKLEP;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid CGEMNPOKFAK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid FKGNFANDBMH;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid EMMPCKAJGFM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid NKMGCJBABEK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OLNMHPONGEC;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid FFNBDABGJBJ;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid NHEBEOEPDMA;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid KKJPGJDHCHH;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid NHMMOOIAPDE;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid NPLLDNMCBDJ;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NNFHEFDEFOP;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MEKJAPJJNCE;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid EGIPGPOCEDF;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KPCOMDGEMGI;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CMFACHOEMPC;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid FFAPIJIHMDH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid FKPNKOFDCEM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LDIOHMNLPEC;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid LPNIIKLBMCI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid PDDHLFNIJAE;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid GAPOMIBIHMF;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid OKMMIAKKGDB;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HJBMKKJOLEP;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MKAGJHCMPHH;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid EEEOIFFNNKI;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid KOFJPKAMNKH;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid IMHLENILIGE;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid LBPGHPIEGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PAIHDCIJEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JNKFNCEFOCD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EIMHIBHMODD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid LCKPIEKGBIK;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid CNKPFNOBOOC;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid AEAKMHHHDLL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid NKNFOLJMHPI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid GHBKBDJKKEC;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid IDJLOODMGOI;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid IDKKBAGIBEK;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid OPPFJIJLLGP;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid OBGMBNNKCLM;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JOFOLCGFMGD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CCLLCDCGBLN;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid IIAJACFAMGK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid OLJLMGEGEGC;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BHPDLEDONIK;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid BIJFFLCDAHH;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid FKJPEDAAIAM;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid PDHBKFACKJF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EMLENPCLNFI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid AHEBAJMOONN;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid GILHKKPCNAL;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid DDKELHPCLBD;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid LDNKAFJCNFF;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid PNGEFKFNHKO;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid GOGKKIFJKNC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid ELBCOJMAOLK;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid DMHEHFNEKPK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KKDLCFDODBA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid AGJJKKFCBJP;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid GHCFBABLJNP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MEFODJGDKPI;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid DPBECFCDGGA;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid LGEAADCDMLG;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid HBDNDAPNAPN;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid DNOHACADDCM;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IHOEBMKMMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid FCDMKBGNOAF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid NIABEKJJGDI;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BONMDKLHPEO;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BANPLDANEEI;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid KINMABJBOFP;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid JCDLCNKEKAC;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PPPNDDDHPIM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid NENHBMKJJFE;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid LDBKPAFKEKL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid DDDBCIJPHOA;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid NNJDJKHLOLB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid CBGFAPJPOAC;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid JODBJJIPPJN;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EBGLDILNOFK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid FEOJGIGKOID;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid OAEKIDPGHPE;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AMMJOLJJEIE;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid AFEGNFPNKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid GJFKANHEBMK;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid AAKAMBKFMGH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LHKLEJEPAAK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid FDBBMNLCOOO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid LDKDJGEHPLE;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid IIKCCGACINE;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FDPFGKDFHHH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FDFNACPCOMD;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid BCJAFIEKKNN;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid NJCACJLIBEA;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid DNPANOAMJGH;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FBLLKHEMGOH;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid GKBNGBJIJKP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DNBOGLOMPND;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid EBKDCHBADKP;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GGKPBPCOEII;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid NPECIEMEGGO;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid GOPCDIHKIAF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid KCBFLHNDPHH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid HHCCGHFJHLD;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid CGFFHPLGDFN;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid ANGLIIDFNKD;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid DIJFKGCCOOO;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IKHAINPGDDE;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid JECNMGNICFL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GMBBOKGCEJB;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid NAFLKGLKFBK;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid IHMPNHDPIJB;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid ENOGJDLKCMK;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid GABIMJANHLP;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid FMFOPMOOFDK;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid GENMAGELJHF;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid HGBGMKCBMJD;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OMALDKKJJIL;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid IHICDNIBJIB;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid MDABDIAIJDL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid KBGHEONFOFG;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid NINIFKCPJND;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid DOIBICOGHIO;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid COHEEONKCHF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid GMAPLCCMDBE;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid JIHGAFECDOJ;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid CICNGFBJGCD;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KLCEDBDALML;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid NAMFDBJINBF;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid PGPDNFHLEAM;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid GHHIGFABPLJ;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid OCNOLFBPPID;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid EANGBGIOEKP;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid AJFMCHNGJFM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid GGFFBMNMEMF;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EFHJKMABKJN;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid HPDBJOKINJI;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid HMONLJDMIID;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DLOJKKPGIFE;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid ICEDBKNEHHP;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid MPNOCBCFOBM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid DPHCPJOJBDB;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PDELJJHIEGA;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid NLIKCAINNGJ;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid JEIOFEELLML;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid EOHBMJCJOCO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid IBKPNNEHDJK;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid EBBIMFEKHMF;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid PFNLIOFIAAB;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid PENNMGMFPKA;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid MGKEKAAECKN;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid AFCHAHCLIHL;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LFGCAHANCFC;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid IHDJALOBGFO;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid DBILCAONIIJ;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid AAKOIDAAHDN;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid ACPEGEFBJKN;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MLKKFMMPCMP;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid JKDJAHHDKLK;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid ABAPLPONAJP;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid FHMIFJGKBIG;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid MGOPEOAMPKF;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid NMKBPHFCCFB;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid JOEPOCLCBIO;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GBDEGFAHPCO;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid JLIDPDMCPGB;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid KDEEEEJBNFN;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid JLLCLBCMLEH;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid MKDJCNLILAB;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid CBLAJKPNKLB;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid MBDKPOFPLMO;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid EHDIGBPEINE;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DLANFHGOGMG;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid EPPCEJHJJBF;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid KJFOAHMBDIB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NCNAMGECFPD;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid JDBDEIAENPF;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid LOJOLPAOAMI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DCCAOCDPELD;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AHJPEKJPGKB;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid LJCONGMIPMO;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid POBJOCLOKPP;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid CCICMNIIOJG;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid OBGGKPNFIMC;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MMLHKGJEMLO;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid BIHLFOOLMKH;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid CHGEOALLGKK;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, OLOCIKCIHNM> NJEPLJKNBOF;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<OLOCIKCIHNM, Guid> JNIHACGIMDG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, OLOCIKCIHNM> PCNOAFIALIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED32B0", Offset = "0x6ED1AB0", VA = "0x186ED32B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<OLOCIKCIHNM, Guid> OLJEIHDEIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3310", Offset = "0x6ED1B10", VA = "0x186ED3310")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OLEBEKMGFFN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED89C0", Offset = "0x6ED71C0", VA = "0x186ED89C0")]
	public static bool LLKGDIGMJMA(HCNBGDGKNBN IHJIEPAKGAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED89F0", Offset = "0x6ED71F0", VA = "0x186ED89F0")]
	private static bool LLKGDIGMJMA(KMFGANKOFJA JLMLAIIAOPK, HCNBGDGKNBN IHJIEPAKGAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct CAIKCGKAKLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly LPEPBMDCHIC PPPJOCNOPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<MAAAODAGNHE> AIMNCKBDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<MAAAODAGNHE> FLDKJOLBOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MFKBDIPIOIA<JFDGELHFKII> IONDAIFDNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<JOEFEFGKPAB<BAFEGHIGBOE>> AMAOEGBCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString EMBGAHHHIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly JJLHMKLCHPL LAKLDPNOGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool JCLKIBLHAAF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFE70", Offset = "0x6ECE670", VA = "0x186ECFE70")]
	public CAIKCGKAKLE(LPEPBMDCHIC GFPCJBEICHL, IEnumerable<MAAAODAGNHE> CMEOFAPCKNI, IReadOnlyList<MAAAODAGNHE> DELDELDMGCL, MFKBDIPIOIA<JFDGELHFKII> BBIEJEFKCIE, IReadOnlyList<JOEFEFGKPAB<BAFEGHIGBOE>> JBIOOMBNEOJ, ByteString NEAAPOPHHNN, JJLHMKLCHPL KOKCBHFCCNM, bool PIPCLCALDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KNNPOBILIEB
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(HLFFMIHPMJN EBNFOODJNOB, [Out] Dictionary<int, int> CJFMBOLPCHH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(BIDADGNHDHM JEDBALFIHKI, BBLGCEAIEGG CLOICOGIMGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CHEGHMILOMA : BKOMOBLAELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid EDDNBPCHLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> DPLIADKCMAL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KAFNKJLIMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F92B30", Offset = "0x3F91330", VA = "0x183F92B30")]
	private CHEGHMILOMA([In] Guid JNNAFPIEPIN, Dictionary<Guid, Guid> OHDEIEAKEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2C30", Offset = "0x6ED1430", VA = "0x186ED2C30")]
	public static CHEGHMILOMA DFLBOLBHLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2C20", Offset = "0x6ED1420", VA = "0x186ED2C20")]
	public static CHEGHMILOMA CBNNJGBOABH(IReadOnlyDictionary<Guid, Guid> NHDIHLIFOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2E90", Offset = "0x6ED1690", VA = "0x186ED2E90")]
	public static CHEGHMILOMA MFKHMIOBCLH(IEnumerable<KeyValuePair<Guid, Guid>> NHDIHLIFOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6ED31B0", Offset = "0x6ED19B0", VA = "0x186ED31B0")]
	private static Dictionary<Guid, Guid> OBKNCJCMJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6ED29A0", Offset = "0x6ED11A0", VA = "0x186ED29A0")]
	public void ALDINBOKJCE(IReadOnlyDictionary<Guid, Guid> NHDIHLIFOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2D30", Offset = "0x6ED1530", VA = "0x186ED2D30")]
	public Guid HPJHDMBIPGB([In] Guid PLMJELCKKDA, bool FOFBANCDGNF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2CC0", Offset = "0x6ED14C0", VA = "0x186ED2CC0")]
	public bool IJJMGJJCAKP([In] Guid DOBPKLNCBDO, [Out] Guid HAPKGJEJNBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2CC0", Offset = "0x6ED14C0", VA = "0x186ED2CC0", Slot = "4")]
	private bool EJBOHHLJOAI(Guid HJDPFHBMCGB, [Out] Guid CMEODCENMPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOIODLDNLFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LABKLDNMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDFBDMHOPOO(ByteString AHCJGDGJNCB, CHEGHMILOMA PCLHFNIALDB, [In] UniformTRS MIGLDDCCOPE, Space DOOIIGFLCLB = Space.World);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPBJMMLFIGL
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
public sealed class BONFBEEPBCA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OPIEMEPPHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public LPEPBMDCHIC staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public OPIEMEPPHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8DA0", Offset = "0x6ED75A0", VA = "0x186ED8DA0")]
		internal MFKBDIPIOIA<CIOMHJNJFLM> HLJJPEKNMJB((MFKBDIPIOIA<JFDGELHFKII> GraphId, MFKBDIPIOIA<BAFEGHIGBOE> NodeId) i)
		{
			return default(MFKBDIPIOIA<CIOMHJNJFLM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private static readonly PPJAPCKACCF<CIOMHJNJFLM, int?> KJCODNGIIAB;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static readonly long JOBINLHMLPG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EC27C0", Offset = "0x6EC0FC0", VA = "0x186EC27C0")]
	public static (long, long) AMGOBHIEICN(LPEPBMDCHIC AGHBKNCLHGN, MFKBDIPIOIA<JFDGELHFKII> JJFBINJJNLK, MFKBDIPIOIA<BAFEGHIGBOE> FJIFOJCFNEO)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2D10", Offset = "0x6EC1510", VA = "0x186EC2D10")]
	public static long POJNCAPAMPM([In] ReadOnlySpan<MFKBDIPIOIA<CIOMHJNJFLM>> PCCGEHDLONO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2BF0", Offset = "0x6EC13F0", VA = "0x186EC2BF0")]
	private static long BPHDGPICGKG()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NPMKKOIPFAA
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<OLOCIKCIHNM> MIBMONMFMJK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class IGKOCMLOAFB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> PAHBKJDAHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> MBHELBJNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5E90", Offset = "0x8C4690", VA = "0x1808C5E90")]
	public IGKOCMLOAFB(IReadOnlyDictionary<Guid, Guid> OAAAGKLCNIL, IReadOnlyDictionary<Guid, Guid> DGECLBGGMEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LDJANOJMEJK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NAGCCNAIEHC : IEnumerable<MAAAODAGNHE>, IEnumerable, IEnumerator<MAAAODAGNHE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private MAAAODAGNHE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private EGMAANLLBKA spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public EGMAANLLBKA <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private DAHLFFKCNCJ spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public DAHLFFKCNCJ <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private MAAAODAGNHE System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAC8700", Offset = "0xAC6F00", VA = "0x180AC8700")]
		[DebuggerHidden]
		public NAGCCNAIEHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8430", Offset = "0x6ED6C30", VA = "0x186ED8430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED86E0", Offset = "0x6ED6EE0", VA = "0x186ED86E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8540", Offset = "0x6ED6D40", VA = "0x186ED8540", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MAAAODAGNHE> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8540", Offset = "0x6ED6D40", VA = "0x186ED8540", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4C20", Offset = "0x6ED3420", VA = "0x186ED4C20")]
	public static EGMAANLLBKA AFCABFLACKK([In] CAIKCGKAKLE FNHCCDILLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6AE0", Offset = "0x6ED52E0", VA = "0x186ED6AE0")]
	private static void FLFIJOGCCBG(EGMAANLLBKA OPGBNNPPKKG, [In] CAIKCGKAKLE BMOHKDMPBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5040", Offset = "0x6ED3840", VA = "0x186ED5040")]
	public static DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL> DGBNCEGOBGD(EGMAANLLBKA OPGBNNPPKKG, DAHLFFKCNCJ CMPKOBPNDLH, CHEGHMILOMA? MPHAMMBEGOJ)
	{
		return default(DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7140", Offset = "0x6ED5940", VA = "0x186ED7140")]
	[IteratorStateMachine(typeof(NAGCCNAIEHC))]
	private static IEnumerable<MAAAODAGNHE> IGOGPBKADBE(EGMAANLLBKA OPGBNNPPKKG, DAHLFFKCNCJ CMPKOBPNDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4D90", Offset = "0x6ED3590", VA = "0x186ED4D90")]
	private static void AHFAEBGNLDJ(EGMAANLLBKA OPGBNNPPKKG, CHEGHMILOMA? MPHAMMBEGOJ, DAHLFFKCNCJ CMPKOBPNDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4FD0", Offset = "0x6ED37D0", VA = "0x186ED4FD0")]
	private static void COCJKGBIGIJ(EGMAANLLBKA OPGBNNPPKKG, DAHLFFKCNCJ CMPKOBPNDLH, IReadOnlyCollection<ByteString>? PBICCICFHIB, IReadOnlyCollection<ByteString>? FMHALBEMFEN, IReadOnlyCollection<ByteString>? HGLBEKLPOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7D10", Offset = "0x6ED6510", VA = "0x186ED7D10")]
	private static bool PMECEGOHFFI(EGMAANLLBKA OPGBNNPPKKG, BIDADGNHDHM JEDBALFIHKI, DAHLFFKCNCJ CMPKOBPNDLH, [Out][NotNullWhen(false)] string? JBBHONJKFOI, [Out] Dictionary<int, int> CJFMBOLPCHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6ED76F0", Offset = "0x6ED5EF0", VA = "0x186ED76F0")]
	private static Dictionary<Guid, KMFGANKOFJA> JOLFLOLLMOD(EGMAANLLBKA OPGBNNPPKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6A40", Offset = "0x6ED5240", VA = "0x186ED6A40")]
	private static void EGFBDCBIKHE(bool BACAGMCDLGF, MAAAODAGNHE EJLNBEBPJEL, Dictionary<Guid, Guid> MNCIGFOJCEJ, CHEGHMILOMA MPHAMMBEGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6ED79D0", Offset = "0x6ED61D0", VA = "0x186ED79D0")]
	private static void LLDIKCFNBFI(MAAAODAGNHE EJLNBEBPJEL, Guid HHGNDGOIHEP, AHCCCIIDFHJ? NHIDICOEAIB, Dictionary<Guid, KMFGANKOFJA> MCAKOPCILNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7240", Offset = "0x6ED5A40", VA = "0x186ED7240")]
	private static void JCKODEOMEJJ(IEnumerable<MAAAODAGNHE> HFOPJPGHNEB, IReadOnlyCollection<ByteString> PBICCICFHIB, IReadOnlyCollection<ByteString> FMHALBEMFEN, IReadOnlyCollection<ByteString> HGLBEKLPOAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DAHLFFKCNCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public bool BACAGMCDLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public JJLHMKLCHPL KOKCBHFCCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public AHCCCIIDFHJ? NHIDICOEAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public AHCCCIIDFHJ? PACKKPNEKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public LPEPBMDCHIC DJFDAODOFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public DPBJMMLFIGL HFAGNGOCNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public KNNPOBILIEB NPFHCKPDPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public OOIODLDNLFC IEKGEKAGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public JOEFEFGKPAB<JFDGELHFKII> NFIEMNLGPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public HBOPAPPEAPD NJELGGJAEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public List<MAAAODAGNHE> PEPJCPMBFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<string, object> EEOAIAPPFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public AAKHMGMPNHC NACCGOCBGGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CADOJKHFNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3260", Offset = "0x6ED1A60", VA = "0x186ED3260")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AHCCCIIDFHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private const float BCCGGCHMCCM = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Vector3 BALIIBCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public float FKICLIIJEHG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Matrix4x4 NANBCPJMPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1F10", Offset = "0x6EC0710", VA = "0x186EC1F10")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public UniformTRS KCFPPNIKJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC24D0", Offset = "0x6EC0CD0", VA = "0x186EC24D0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xF21B40", Offset = "0xF20340", VA = "0x180F21B40")]
	public AHCCCIIDFHJ(Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float FKICLIIJEHG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EC26F0", Offset = "0x6EC0EF0", VA = "0x186EC26F0")]
	public AHCCCIIDFHJ(UniformTRS GCPDBLOGHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EC21C0", Offset = "0x6EC09C0", VA = "0x186EC21C0")]
	public static AHCCCIIDFHJ GMBJHJFFGJN(AHCCCIIDFHJ NCCLECGLDAO, AHCCCIIDFHJ CPHMHBPFFFJ)
	{
		return default(AHCCCIIDFHJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EC21A0", Offset = "0x6EC09A0", VA = "0x186EC21A0")]
	public static AHCCCIIDFHJ FMEIMHFCNHG((Vector3, Quaternion, float) EBNFOODJNOB)
	{
		return default(AHCCCIIDFHJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2020", Offset = "0x6EC0820", VA = "0x186EC2020")]
	public static AHCCCIIDFHJ FMEIMHFCNHG(Matrix4x4 HGECNDEDPAG)
	{
		return default(AHCCCIIDFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2660", Offset = "0x6EC0E60", VA = "0x186EC2660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2510", Offset = "0x6EC0D10", VA = "0x186EC2510")]
	public AHCCCIIDFHJ OIEDIOGLAMK(Matrix4x4 NBEDBEKEEBM)
	{
		return default(AHCCCIIDFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC25F0", Offset = "0x6EC0DF0", VA = "0x186EC25F0")]
	public static AHCCCIIDFHJ PGLCBPMHDPE(Vector3 BALIIBCILHH)
	{
		return default(AHCCCIIDFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2440", Offset = "0x6EC0C40", VA = "0x186EC2440")]
	public readonly EBOIACDJEEB HCLDDDFFMHJ()
	{
		return default(EBOIACDJEEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum EHJIHGFBNEH
{
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct CDLOAPMEAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly JFOFDIGGDKD IGPNDDGNGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly EPICLACHOCO BBIKDCBMONE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x11A2B30", Offset = "0x11A1330", VA = "0x1811A2B30")]
	private CDLOAPMEAEL(JFOFDIGGDKD NNGPPKEHFMP, EPICLACHOCO GOOEKLHGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFF00", Offset = "0x6ECE700", VA = "0x186ECFF00")]
	public PKCOADCNKKN AKIBIBPGICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6ECFF70", Offset = "0x6ECE770", VA = "0x186ECFF70")]
	public static DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL> DFLBOLBHLFN(OOODEMCEFAA<DOPPLCFNMND> GOOEKLHGPDP)
	{
		return default(DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0020", Offset = "0x6ECE820", VA = "0x186ED0020")]
	public static DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL> DFLBOLBHLFN(PKCOADCNKKN GOOEKLHGPDP)
	{
		return default(DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6ED00D0", Offset = "0x6ECE8D0", VA = "0x186ED00D0")]
	public static DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL> DFLBOLBHLFN(string EPPNPHGPNLN)
	{
		return default(DNFCNMKAMCE<IGKOCMLOAFB, CDLOAPMEAEL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JFOFDIGGDKD
{
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CEGDFIKBKFL : IDisposable, HEPANMFIAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private NativeList<JIKFLLDMDJN> KLOCPDOODFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private float JFPAOBNNNGI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JIKEHJJLJAI CLAPJGNLABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
		[CompilerGenerated]
		get
		{
			return default(JIKEHJJLJAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DLPAJLPKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1B40", Offset = "0x6ED0340", VA = "0x186ED1B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EEMHJFFDCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1990", Offset = "0x6ED0190", VA = "0x186ED1990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public List<NEMAMHLGMNI> JKBLHMNCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FKJMGEKDHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1B00", Offset = "0x6ED0300", VA = "0x186ED1B00", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float KOHMMBJHMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED1B50", Offset = "0x6ED0350", VA = "0x186ED1B50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2910", Offset = "0x6ED1110", VA = "0x186ED2910")]
	public CEGDFIKBKFL(JIKEHJJLJAI NHJAJPHALPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED06A0", Offset = "0x6ECEEA0", VA = "0x186ED06A0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1C90", Offset = "0x6ED0490", VA = "0x186ED1C90")]
	public Vector3 KGIDMLLLMOM(int JAIJLDENOAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0760", Offset = "0x6ECEF60", VA = "0x186ED0760", Slot = "6")]
	public Quaternion GBGJMOGCPCA(int JAIJLDENOAK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0600", Offset = "0x6ECEE00", VA = "0x186ED0600", Slot = "5")]
	public Vector3 DOMCPIAFOKH(int JAIJLDENOAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1120", Offset = "0x6ECF920", VA = "0x186ED1120", Slot = "7")]
	public float HEBDBJNOJBA(int JAIJLDENOAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0830", Offset = "0x6ECF030", VA = "0x186ED0830")]
	public void GCMGKFOJAHK(Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF, bool BDMBDNCNPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0700", Offset = "0x6ECEF00", VA = "0x186ED0700")]
	private bool FHLMNKPDJFO(int AAFJDEGIHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6ED19A0", Offset = "0x6ED01A0", VA = "0x186ED19A0")]
	public void HMCBAHNDCGH(Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0190", Offset = "0x6ECE990", VA = "0x186ED0190")]
	public void AKHMFIKEHOC(int AAFJDEGIHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2750", Offset = "0x6ED0F50", VA = "0x186ED2750")]
	public void OLEKGHIIPCK(int AAFJDEGIHGC, Vector3 BALIIBCILHH, Quaternion OJEGGOKKPLF, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0450", Offset = "0x6ECEC50", VA = "0x186ED0450")]
	public void DNEMPMIKGIF(int AAFJDEGIHGC, float3 BALIIBCILHH, quaternion OJEGGOKKPLF, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2600", Offset = "0x6ED0E00", VA = "0x186ED2600")]
	public void MDOKCOKNMJF(int AAFJDEGIHGC, Vector3 BALIIBCILHH, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0220", Offset = "0x6ECEA20", VA = "0x186ED0220")]
	public void ANIMEBBIKII(int AAFJDEGIHGC, Vector3 LHHMNOGMEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6ED1180", Offset = "0x6ECF980", VA = "0x186ED1180")]
	public static Quaternion HJMIHFLNEGG(Quaternion FCCAJAMDPOO, int AAFJDEGIHGC, float LNCCGHEIMGH, HEPANMFIAGC CPHNEDMPENG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED2160", Offset = "0x6ED0960", VA = "0x186ED2160")]
	public Bounds LEALFNEFBHP(Transform NBEDBEKEEBM)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED28A0", Offset = "0x6ED10A0", VA = "0x186ED28A0", Slot = "10")]
	public virtual void PFOGNLIKBEI(bool NLHOGDCPOFN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0380", Offset = "0x6ECEB80", VA = "0x186ED0380")]
	public NativeList<JIKFLLDMDJN> DFNMCHAPNPE(float AGIDHGDBJPG = 1f)
	{
		return default(NativeList<JIKFLLDMDJN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NEMAMHLGMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public float3 CMIONGHAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float FBKOADJLGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public quaternion ABFDAKCFMBP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE4C0", Offset = "0x6EDCCC0", VA = "0x186EDE4C0")]
	public NEMAMHLGMNI(Vector3 BJACFEPLELN, Quaternion FCCAJAMDPOO, float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE260", Offset = "0x6EDCA60", VA = "0x186EDE260")]
	public Quaternion IGCMHGNDFNA(Vector3 NGBCGJCGHJG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDF70", Offset = "0x6EDC770", VA = "0x186EDDF70")]
	public NEMAMHLGMNI GDFOJPLPHHB(Vector3 FBIEGKPAFMO, Vector3 IDFOAAGAICE, Vector3 AJPEJMNEDOD)
	{
		return default(NEMAMHLGMNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE320", Offset = "0x6EDCB20", VA = "0x186EDE320")]
	public FEGKKANIOEF LMLLIOPPBEJ(Vector3 NGBCGJCGHJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EKDOPPPALON : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC390", Offset = "0x6EDAB90", VA = "0x186EDC390", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC410", Offset = "0x6EDAC10", VA = "0x186EDC410")]
	private void AMOHHADLOOL(Dictionary<Guid, Guid> KAONCCLNEPN, GJJDBDIPNHL BPGKNDHMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EDCC60", Offset = "0x6EDB460", VA = "0x186EDCC60")]
	private void AMOHHADLOOL(Dictionary<Guid, Guid> KAONCCLNEPN, KEIGPMIGJMN JOMHBNPGKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC9E0", Offset = "0x6EDB1E0", VA = "0x186EDC9E0")]
	private void AMOHHADLOOL(Dictionary<Guid, Guid> KAONCCLNEPN, PECNOIOBHML FGOOEPAPHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public EKDOPPPALON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class DJAAGHPKHLL : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB100", Offset = "0x6ED9900", VA = "0x186EDB100", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public DJAAGHPKHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GCOLMBJCANI : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EDCCC0", Offset = "0x6EDB4C0", VA = "0x186EDCCC0", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public GCOLMBJCANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BMIMHCKGHOG : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAB40", Offset = "0x6ED9340", VA = "0x186EDAB40", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BMIMHCKGHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OPHPABCBPAN : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF7C0", Offset = "0x6EDDFC0", VA = "0x186EDF7C0", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OPHPABCBPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class NOBADICJLDA : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE540", Offset = "0x6EDCD40", VA = "0x186EDE540", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public NOBADICJLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AEBIDJGCCIO : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8EC0", Offset = "0x6ED76C0", VA = "0x186ED8EC0", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AEBIDJGCCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KOIBGFGBAKE : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDAE0", Offset = "0x6EDC2E0", VA = "0x186EDDAE0", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public KOIBGFGBAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MDJPAMNOJEG : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDC80", Offset = "0x6EDC480", VA = "0x186EDDC80", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MDJPAMNOJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CBAGIIHANJB : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6EDACA0", Offset = "0x6ED94A0", VA = "0x186EDACA0", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CBAGIIHANJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DGCHJPEFHNP : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB000", Offset = "0x6ED9800", VA = "0x186EDB000", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public DGCHJPEFHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class MNBPEHNEPOB : LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public static readonly OMACBBADFJJ LOHJAJLHAOG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDE40", Offset = "0x6EDC640", VA = "0x186EDDE40", Slot = "4")]
	public void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MNBPEHNEPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HCNBGDGKNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public BIDADGNHDHM MAAOIFPNGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public DEEAMLJIMEG KJNMBDJADBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> BEPMGHNPMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> APOIFDNIPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public AAKHMGMPNHC NACCGOCBGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public bool DDPODIECNPH;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LKKKLFAJGGI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEMMHKDCGNP(LAIGNHPFJCI OABGIDKFODD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OCPDKFOHEJN
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly LKKKLFAJGGI[] OJNCGDMAOFC;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEF60", Offset = "0x6EDD760", VA = "0x186EDEF60")]
	public static void NPLJODEIKBB(MAAAODAGNHE EBNFOODJNOB, Dictionary<Guid, Guid> FHEIBLLHPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE680", Offset = "0x6EDCE80", VA = "0x186EDE680")]
	public static void CHDGMBPIKNP(MAAAODAGNHE? EBNFOODJNOB, CHEGHMILOMA NHABFHKEBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE910", Offset = "0x6EDD110", VA = "0x186EDE910")]
	public static void KCLKFEBCPNM(MAAAODAGNHE? EBNFOODJNOB, CHEGHMILOMA MPHAMMBEGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEB90", Offset = "0x6EDD390", VA = "0x186EDEB90")]
	public static void LLKGDIGMJMA(LAIGNHPFJCI OABGIDKFODD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LAIGNHPFJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public BIDADGNHDHM NAMEJILFCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public MAAAODAGNHE EJLNBEBPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Dictionary<int, int> BEPMGHNPMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<Guid, Guid> APOIFDNIPBB;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDBD0", Offset = "0x6EDC3D0", VA = "0x186EDDBD0")]
	public Guid OFHEOKJLNDE(Guid PLMJELCKKDA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AAKHMGMPNHC
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int NDLPIBBIODB, [Out] Guid JFOEJLABIMA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BFKJLHPIJMG
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly ProfilerMarker JDHFLKNCFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private readonly HashSet<string> BEHALDCKMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly Dictionary<long, int> KBFJAPEIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly HashSet<Guid> KAELKJHBOND;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IReadOnlyCollection<string> KDDIGCFNIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyDictionary<long, int> LOJMDLCCGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6ED95D0", Offset = "0x6ED7DD0", VA = "0x186ED95D0")]
	public static BFKJLHPIJMG ILINIMFMBHH(LAENOPFABFD NKIGLKBMOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6ED90D0", Offset = "0x6ED78D0", VA = "0x186ED90D0")]
	public static BFKJLHPIJMG GBIHCJIDHHH(EGMAANLLBKA DBBLJGILJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA4C0", Offset = "0x6ED8CC0", VA = "0x186EDA4C0")]
	public static BFKJLHPIJMG PGCOHCKIJHG(IEnumerable<string> BEHALDCKMMG, IDictionary<long, int> FNBDCCHGOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA700", Offset = "0x6ED8F00", VA = "0x186EDA700")]
	private BFKJLHPIJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA820", Offset = "0x6ED9020", VA = "0x186EDA820")]
	private BFKJLHPIJMG(IEnumerable<string> BEHALDCKMMG, IDictionary<long, int> FNBDCCHGOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9E20", Offset = "0x6ED8620", VA = "0x186ED9E20")]
	private void LLOHINJMENE(LAENOPFABFD NKIGLKBMOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9C20", Offset = "0x6ED8420", VA = "0x186ED9C20")]
	private void LLOHINJMENE(EGMAANLLBKA DBBLJGILJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9140", Offset = "0x6ED7940", VA = "0x186ED9140")]
	private void HKELOBBGGFL(ByteString? NEAAPOPHHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED97C0", Offset = "0x6ED7FC0", VA = "0x186ED97C0")]
	private void LLOHINJMENE(IOCFMLAJICE? KAMAKIBPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA380", Offset = "0x6ED8B80", VA = "0x186EDA380")]
	private void LLOHINJMENE(NBDGNDNMGDB? JLFLGGOOAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA020", Offset = "0x6ED8820", VA = "0x186EDA020")]
	private void LLOHINJMENE(MAAAODAGNHE? EJLNBEBPJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9060", Offset = "0x6ED7860", VA = "0x186ED9060")]
	private void FKMJPBDFNDL(string? FLJCCBBMJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9640", Offset = "0x6ED7E40", VA = "0x186ED9640")]
	private void LIGCHFOHNLJ(long JKPHJHLMDIJ, Guid JJFIFIMDJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9770", Offset = "0x6ED7F70", VA = "0x186ED9770")]
	private void LIGCHFOHNLJ(NFEBMLEPMAN? BFFEFEJMBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9710", Offset = "0x6ED7F10", VA = "0x186ED9710")]
	private void LIGCHFOHNLJ(JFOJHLGDJPI? BFFEFEJMBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct EGFPLIAMDJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GMKGCDOIILH : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private readonly IEnumerator<DictionaryEntry> DDLDHCJHPPE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public DictionaryEntry PJJHHFGANKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6EDCFA0", Offset = "0x6EDB7A0", VA = "0x186EDCFA0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object GCHHHJJPOEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD060", Offset = "0x6EDB860", VA = "0x186EDD060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object MHFLHGKPHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD110", Offset = "0x6EDB910", VA = "0x186EDD110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public object NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6EDCEC0", Offset = "0x6EDB6C0", VA = "0x186EDCEC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
		public GMKGCDOIILH(IEnumerator<DictionaryEntry> DDLDHCJHPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCE20", Offset = "0x6EDB620", VA = "0x186EDCE20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCE70", Offset = "0x6EDB670", VA = "0x186EDCE70", Slot = "9")]
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
		private sealed class CIENCIGCDIA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6EDAFB0", Offset = "0x6ED97B0", VA = "0x186EDAFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public CIENCIGCDIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6EDAE60", Offset = "0x6ED9660", VA = "0x186EDAE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EDAF60", Offset = "0x6ED9760", VA = "0x186EDAF60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFFB0", Offset = "0x6EDE7B0", VA = "0x186EDFFB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IDictionary.this[object KCGKBDGKIOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFEC0", Offset = "0x6EDE6C0", VA = "0x186EDFEC0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6EE00A0", Offset = "0x6EDE8A0", VA = "0x186EE00A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFE00", Offset = "0x6EDE600", VA = "0x186EDFE00", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFE60", Offset = "0x6EDE660", VA = "0x186EDFE60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6EE0040", Offset = "0x6EDE840", VA = "0x186EE0040", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFAC0", Offset = "0x6EDE2C0", VA = "0x186EDFAC0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFB20", Offset = "0x6EDE320", VA = "0x186EDFB20", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6EDFB80", Offset = "0x6EDE380", VA = "0x186EDFB80", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
		public RoomObjectCounts(Dictionary<int, int> EKACOBDIIPA, [Optional] Dictionary<int, int> NOPAMLFGLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF9E0", Offset = "0x6EDE1E0", VA = "0x186EDF9E0")]
		[IteratorStateMachine(typeof(CIENCIGCDIA))]
		private IEnumerator<DictionaryEntry> GKGNJLGPMLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE00F0", Offset = "0x6EDE8F0", VA = "0x186EE00F0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFD00", Offset = "0x6EDE500", VA = "0x186EDFD00", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFBE0", Offset = "0x6EDE3E0", VA = "0x186EDFBE0", Slot = "9")]
		void IDictionary.Add(object KCGKBDGKIOP, object INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFC40", Offset = "0x6EDE440", VA = "0x186EDFC40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFCA0", Offset = "0x6EDE4A0", VA = "0x186EDFCA0", Slot = "8")]
		bool IDictionary.Contains(object KCGKBDGKIOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFDA0", Offset = "0x6EDE5A0", VA = "0x186EDFDA0", Slot = "14")]
		void IDictionary.Remove(object KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFA60", Offset = "0x6EDE260", VA = "0x186EDFA60", Slot = "15")]
		void ICollection.CopyTo(Array GHAIAFELBIF, int ECDOOAABOPD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class BLHHIFPJGCH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x6EDAAF0", Offset = "0x6ED92F0", VA = "0x186EDAAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public BLHHIFPJGCH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6EDA960", Offset = "0x6ED9160", VA = "0x186EDA960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6EDAAA0", Offset = "0x6ED92A0", VA = "0x186EDAAA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD800", Offset = "0x6EDC000", VA = "0x186EDD800", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IDictionary.this[object KCGKBDGKIOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD6D0", Offset = "0x6EDBED0", VA = "0x186EDD6D0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD8B0", Offset = "0x6EDC0B0", VA = "0x186EDD8B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD610", Offset = "0x6EDBE10", VA = "0x186EDD610", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD670", Offset = "0x6EDBE70", VA = "0x186EDD670", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD850", Offset = "0x6EDC050", VA = "0x186EDD850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD290", Offset = "0x6EDBA90", VA = "0x186EDD290", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD2F0", Offset = "0x6EDBAF0", VA = "0x186EDD2F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6EDD350", Offset = "0x6EDBB50", VA = "0x186EDD350", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x230E2C0", Offset = "0x230CAC0", VA = "0x18230E2C0")]
		public Invention(long DOBPKLNCBDO, int NELOIEKKMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD1C0", Offset = "0x6EDB9C0", VA = "0x186EDD1C0")]
		[IteratorStateMachine(typeof(BLHHIFPJGCH))]
		private IEnumerator<DictionaryEntry> GKGNJLGPMLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD900", Offset = "0x6EDC100", VA = "0x186EDD900", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD4D0", Offset = "0x6EDBCD0", VA = "0x186EDD4D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD3B0", Offset = "0x6EDBBB0", VA = "0x186EDD3B0", Slot = "9")]
		void IDictionary.Add(object KCGKBDGKIOP, object INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD410", Offset = "0x6EDBC10", VA = "0x186EDD410", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD470", Offset = "0x6EDBC70", VA = "0x186EDD470", Slot = "8")]
		bool IDictionary.Contains(object KCGKBDGKIOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD5B0", Offset = "0x6EDBDB0", VA = "0x186EDD5B0", Slot = "14")]
		void IDictionary.Remove(object KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EDD230", Offset = "0x6EDBA30", VA = "0x186EDD230", Slot = "15")]
		void ICollection.CopyTo(Array GHAIAFELBIF, int ECDOOAABOPD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> HMELMPBACKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyList<Invention> PPNLFAAAPFO;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xE64E60", Offset = "0xE63660", VA = "0x180E64E60")]
	public EGFPLIAMDJJ(IReadOnlyDictionary<Guid, RoomObjectCounts> CAEDLOJEJJD, IReadOnlyList<Invention> NGOLKDFBOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB1B0", Offset = "0x6ED99B0", VA = "0x186EDB1B0")]
	public static EGFPLIAMDJJ ILINIMFMBHH(LAENOPFABFD NKIGLKBMOAI)
	{
		return default(EGFPLIAMDJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBBC0", Offset = "0x6EDA3C0", VA = "0x186EDBBC0")]
	[CompilerGenerated]
	internal static int IOGECNBHFFF([In] IReadOnlyDictionary<long, int> OFIMEJLFJAH, long? JKPHJHLMDIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBCE0", Offset = "0x6EDA4E0", VA = "0x186EDBCE0")]
	[CompilerGenerated]
	internal static void LHEDAEGLALI(int ELOBGGMEBAG, [In] IOCFMLAJICE NKOAOFFBAPB, [In] Dictionary<long, int> OFIMEJLFJAH, [In] Dictionary<Guid, RoomObjectCounts> CAEDLOJEJJD)
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
