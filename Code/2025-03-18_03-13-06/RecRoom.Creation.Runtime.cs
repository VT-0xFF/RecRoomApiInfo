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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7578DF0", Offset = "0x7577FF0", VA = "0x187578DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CEKNBMHFEOL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> ELLEBIOJNHB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> DBBDFFIGOKC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GHILDANGNBI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> JAODJCDLBOD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string FEOLHEGGHHK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string FFELCPBBFBC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string IGGAEHIDIIC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7565800", Offset = "0x7564A00", VA = "0x187565800")]
	public static bool MFKOCDBJAMF(Guid MACLHLJOEGK, int JNOGEOLDFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7565770", Offset = "0x7564970", VA = "0x187565770")]
	public static bool DLGDEAOKMAJ(Guid MACLHLJOEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7565900", Offset = "0x7564B00", VA = "0x187565900")]
	public static string PDCJJAIIBIF(Guid FGPNICIMMFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLBPOAABFBO]
public enum FBPOCOBABHC
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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7578340", Offset = "0x7577540", VA = "0x187578340", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KIHKCCHGPDE
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid JNJPAGDILJO;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid MPGNOLDGLEO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DAELHOBCDCB;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid GMBIJDNDOMC;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid OOIDDICEIBI;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid KHNDGKFIFMM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JIEMHJBCDHB;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid DGMFBNDPJGF;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid CNECFDOEOGJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid MLJEMPFJGJP;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DDLOGBKAOMD;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid IFLHGMNGBEB;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FGHACNGIJFI;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid KDFINHCKNAO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid CCHNHEDBEJJ;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid EEKHGAHPOKJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid HKFEIOIIBPG;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid EABNNNEMOIN;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid DJGPDIJOAKP;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JMNALFGLAOK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid LALPEJNKNDJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid IHCGOAHMCAN;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid DAMOJDDJLEI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GHPNPLJHMAM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BHPMGDCCPGH;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid IOPONFFNCEA;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid IFNJEFENLMH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid NNJKJLGDJFE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GMEOBILCBIB;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid JOKFOKIJEFE;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid LHOECEECKCJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid ODFHOBFCOBG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BAGPHOPLEOI;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid CCFHKONFGEJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ELHMPKGJBFJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid ELJDIMJIBGM;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LLGHCMGMEHB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid MDKHELODBOK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid ECFJHBAEDNP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid CIKNJFOPCJG;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid JDGJAKPIGLK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid NJLJOILPLAP;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CANGECGPDMM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BNCEHLPLJJE;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid ALJCINFIPMG;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GLPMJLDFMMN;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid COPEFKLEBJL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid AOHMBLCGHML;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid IIJDHDKLDEM;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CNLGNPJEDLF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid IEJADGECHDG;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PJLNHCLMAEM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GCCIGJDAMAM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LOOLOEHIECN;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NNJDGAIKFBO;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid IMKFCJOMMKO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid DGOPIENPHLK;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid COEGCMPBEIM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid PMHHLODELED;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid GAJLDFAHFIA;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid HMELMJJBKEM;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid CFHCFFFPLOF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OELGIBNOHEE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid NAMJNMHOJGM;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid OIHFBPCHJOJ;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MKLDNHMDKKF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GJMEFOFLEDI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EHIGDDEAFHA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JDMJMDAFFOF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid OFKANHFKPMB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid LMLJDEBMIOI;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid CHKLMICJAAH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JAPENCGFKHH;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid OMHAIFKFNJP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BBMJEOKLCLP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HMIDHBCKGCA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid AMEEOEPGJAC;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid AALHIOHNJMG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid CGAEFJHNNOM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid DKCDGCIBJKP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid LAGOKMFJPIK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AILGDMNDPJG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid BMMIJINIEMO;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FLKCBGBOKLI;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid HHCIPHNNGJD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid MPKAFLPIIIC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid APFNBJLAOBN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid JCIAPMIECDJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LEOLKECAMFN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid GAKEAOJAGGE;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid ALJLEKNGAEG;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid IKHJKICOMOO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid EBPCNOCHPGA;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid NIDEEMCCKFL;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid AFNIGGBDACK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid BJPNKBDPLFB;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid OGBOCGHNBKI;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid JCHAOAKALOC;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid BFCIAENILPH;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JCGJLAJECJB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid CJIKFHADHBB;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid AHAPHJALGJM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid DDCFAGHDHKO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OJLDIGGOINE;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BEOMPJCAOFI;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid PAMHBEPKLAP;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GKOKCDHEGHF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid LOHEOIMOPNG;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KGKJJJPPMGO;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HBBFOHPHOIH;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GLIKDPLIOBJ;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid OAAFDJPNAJL;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid HPGGOGCMGND;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid AOJNGHOBBDP;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid EPBPPNPOOCG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid ECFNENLPMHD;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IBGEJKFHGJJ;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GGAGDBDEALD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GDIGEEILEEM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid FIEDHGNOCAL;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid JPFBEPNHGLK;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GDHNPBILMFA;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid DGHPDADHGEN;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GIKPPBFHHKJ;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid AMEDLAOOPNF;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid GFEAPOAPJAI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid APHNCHGOADL;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FIEJPGPDIOG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid DPGFCIKLEBH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid MKCIHCMCKJA;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid KNKOEDABJDD;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid FKOABKLGEJD;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid BCMNBLFOFJE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DMBODNDGKOI;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid KLFAKEMIIED;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid FCNCLJIOIFA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid LEBJOMABFFO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid JKOHHEECNCK;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PLMEFJGKFIK;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid FIKODJCFAMM;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid KFGGIDNAOIK;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JJHMCGLOMKG;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid GNMPHOKKLEH;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid KFHNJIBKPDL;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid FPHHAPLKKLF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid EBPLAPAFNBJ;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid FJALBFLJIBD;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid AJOPPBGOBPC;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BPJHKLOOGGE;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JPAJBODCPFB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid AFOKJNDDFHH;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ECKLEFMAMKA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PMOGDGGKEBP;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid LFMNKDEAHOL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EGFGCGLFONI;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OFCDGJCPLCG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid FHAOCLHHFKA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid LOOJFKFBPPJ;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid DLOBELENHJG;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid ADGJCKPDCDJ;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid FILFGPMFCNE;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid PEOAHECGHOP;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AFJCBBOAOKO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid PNBPHAMNHPP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MHBHBLJCFEB;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid AHNJCDFAAPH;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid GAKFFFNOKME;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GCKCGFJOKLE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid MFDJAIDIKGO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid NOMJBBIENEO;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid BKNPANAEGCO;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid PADNLKBGBAK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid AJKLIJCAHGG;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid BCHNMIFMBAD;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid ENHPFNFCKCO;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid PCFHHNHPNGO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KEIBPNHOFCM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OLMCABAPOAF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid BFKALGEICDE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid LJJMLKBDAEB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid LDNNFPALCJL;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid HHHDALODMMD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BHBGOCINECI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid LPAEJPGCGOE;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid NEFFEGMHFIP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid LFIMPDEIOCG;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OCDIMLMDKGK;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NFDBPEOECEN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid IFEALJLLOOD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid NAAFPBNEIAB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid EMHJKAMDFAO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid KEJEGLDHBOI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid NCJGALPHEHJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid NGEJEOIDLNF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid FJBDHCEPOND;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BIMBALNBEJH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid IHKIALLNCDC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid IJLHNLHIDMA;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid APEJEKCCIGA;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid HINACLBIGHP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid OBDMKGCPDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid EKJHIOKLFCA;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid GBBBHBCHBFP;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid MMOGNMDILPJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FOPADPPMKFF;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ACBGOIFPFMG;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid HKLLKPPHFOM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MIPHJCMKNPE;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid ACGEIFHEEIH;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid EJBKKBLHKHH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DHCAEAAICDD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CIOOJEBCCKM;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid NHOOGMMDCBH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid HHEOMDBEPAF;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid HGOCDKEDHFL;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid GABFJDHLCLO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DGBFJGPBNDF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BONGPFMDJJD;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid NMLEJEHPDON;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid AKCICLINOPP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid MHPNKCHKGML;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NHECMPDIOJO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid IAAGDAKPOAG;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid MPBHDCJPFLO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LDBMCAECLKB;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid LMFHOEAEFMK;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JDAHJABPBJP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FHBFLPMPHFO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid OOOOOOIFMFF;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EGANDOLCGIC;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid FBJNMMOMKHL;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ABLBJAOFGJA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DFGIABHKJLB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DKABAECGGIK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid CICNLCLIGKO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CKMEBOKBBDL;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid IKCLGMEIINH;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid IBLOBKCHFMJ;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid KMFHHKHPDOA;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid GOMPMDNFGOM;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid COMMDAEOBNO;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid DEKEBLLMMJK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid GHNHEIJKEKG;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid HNKDDGBLKJG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CEEGPMFNLNM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LOKLCAEJAKG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid LDHKLPOFFBC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid CIEMFKMFEKM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid NBOEKMJBMMA;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid EHCNAIFHCKF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid MGBFGCFPBMG;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid MDJPLOHKENO;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid JCIHGKDEEIB;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid BIGCJCPDJAH;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid DFLJJOAILFC;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid GLALIEGMFPO;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid GDLODPIJHNN;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GINHGDJLAPK;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid AFBHPCNLODD;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ANAFCMGIBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid HOIFGLBFNGA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid EEJFENGBIEE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid OKBLMHANPOD;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid KIIDJCEFEIF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid LFEMOMDBOND;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid DAGHFJEPCNM;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid AMAOHKDJPJG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid HEFIBJCKOLI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid DJKBIIJDLCP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MHBOJPNNPGO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid JEKIDEOHFEP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid ACBJIIGFBBK;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GOHBIBJGKNL;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid JPIACDIKHIE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GMPMFFJDHBK;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid CMJODKOBKGK;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid ABMJKKJDLAL;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid DBEGHPDKCOP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid GFKPHEJKGJE;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OBOAIMDEGEN;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LGDKKHNEFLM;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KKBKPJBFCCF;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IEOCECEGPCM;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid IFNAOHJNCCF;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HJBKOPFDNEF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HCFHCNGHPON;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JMMPCLGEJCP;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid AAEAFFHJMJF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid ILBPGOGFLKN;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JNAIEGHOEHC;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid GAJDKDKGBNL;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid JNOPCALFDOO;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid ANHJJOHIJFP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MLGBBDMJFFG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CJINNNFPMLI;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid DEMOIBIIPOD;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JGBOEHEGHPD;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid LLDDDNFEKFE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OCCCNEMMAFA;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid BOCLGODFGIC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HKPFNKHLIDO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid LBFOMDJAHOK;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IKDPMIKMKPA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid NBCLEBOCHMJ;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid KFABFHHLDDG;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid HFJKEIFMHKJ;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid IIBNHECIPMP;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid KNGMIDCDOFB;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid JIPNBHMHBHC;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid GHFAGAMNJEJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid CAEBBPKKKGO;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid HJEKGILADEK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid CLKHLACBIKI;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid MACAMCNPJIA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid HDDJLFEKBHJ;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid MCGNHOIGJCP;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid EHAPODOABED;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid KKDEODDKBAP;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid AFCMCDNEFIC;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid HKENDNHKKHA;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid PNDFDOMPPGC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid PGBEOFHLLCP;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid HMPAHEBHGDI;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid EDHGGMMDEPD;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LBOEPKGGOPP;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid BHLOMMGNAKM;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid ACKAMKHNKHE;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MDKMENNNJPI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid LFGIFIOACCK;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid EMANLDHODFP;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid FOEPBAGMLII;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JDDJHCDGGKM;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BOMNEPPLHEO;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid PKAFCBKJHFG;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid JEODLFJAILM;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid AIGKBOMGIPH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid OAFFOPFHCKH;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HAHPOJJNBPP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MIEADKNJGDP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid FJEJBHJHFGE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid EGAKFIPHCHO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid DNAAEMBGAMG;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid GINJIDJIOJK;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NANEAMIJJKJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LDPCOBBFBDD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid KGLGPMCDKFI;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid MLOLJDKPNAG;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid PDBJPKAHHBA;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid FPFCKDDGPNM;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid MGAFPNEDNMO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid ELPEDJHOEJN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid CIPBAPJADEI;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid PGCCFNNOAFD;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid MBAKOIPODOA;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DDLAKKPFOGE;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid NDIIKOLFGBM;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DAHPOFKNPNL;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CAGBJOHOGAO;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid OFBNNNOFOLP;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid OLPBJHDPHJD;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FCEKGEHDHIH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid NFFIKKMDCAB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid PJLMPINABMJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid LLEANEKLLPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DKGPMKHGCKL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NKHLDBMMGGD;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JLCAPMDLNFO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid DMPNFOGDAEJ;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JDHGKPKINMD;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid KCKJOFNONII;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid PLCHLEFBCBD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid EOBHCAFPEGO;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid MIHDCNFAKLI;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PALOEEEACDJ;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JIONHGACCGE;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid OBBOIFHMHJN;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid APMFIPMBBPP;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid HOOGPJGMOKE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid KENFEFMALNA;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EIFNOJDEIGF;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EFCHFNGOECD;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid FJHPMGACPFH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid NMOCHCONDBA;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HAIIGAEBMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LHKLLFIJELF;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KKIIIMOCHLC;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid PBJNFEPOHPN;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid FJJPEIAPIJB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MAGAPJPOCMF;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BNGHPLECCLG;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MAJPKMEKFHE;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid INJIFIFENIE;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid PKKIOFBPOKM;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JKJFAHNGGJA;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid FPGDEMKFIOA;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid BGFCEGJEODJ;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid KJNGGLDLFOF;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid OEDGIILEAOJ;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid IINGEPKLFCB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid FEJFMJJGJMF;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid PADICOAGFCD;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BMLOFEBDOCB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ADHEMJDPFLL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid NGLNGGBPIPD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid AHAAKDDBJEG;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid EMINMIICNPD;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OJFDCHDLCKB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid FNKOKLFLCFB;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid LMDJDFJMMHJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JLNEJFBAELD;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid MAGAACOMHFN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IHJFOFDLPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HNPFPNLCHKL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid AJHNEHDCFLJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IJBMJLIPFBJ;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid DDMIBEMDEHD;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LCPEGFKPGLK;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IPAAOIPBAKD;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid PECAEHMFJCN;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid PHAGOHCAEKG;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BCEPGFJOJLF;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid CLMFANEHNCC;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FNIIJHLDOME;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid HNEEDIKLNKD;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FICBCLEDMAN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid IFIDPEBOHIJ;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid MIHOOMBIBEP;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KNOAAKDMILE;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NNAFHMKPEGM;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IGJCMNOPJPE;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid PCCNJBJLILD;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid HPLONGKDLAD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid MHMHJONFGEC;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid EGLEPLNJAHE;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid DDPDKIDCEDI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid HIAPCOPNEOD;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid FGJFKNEPNIC;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid DJCCHLPMKEI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid AEIECHEGFIM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid CEJJMBKKAJK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OMGPNNIBEIP;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FEADIJFPBKL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid POBFKNGMMND;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PHNMCEJBCFB;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid LGMKLLDHODH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid HNOAFMOFBEE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid NEKAPDMGKKD;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LJCANDEEDHB;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BOBIMGOLMBI;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GIPOCJPPDOK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid KOOOCICJKFG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid FGGICCNHLEG;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid LIKPMOOIBOM;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DEHMABAFMMH;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid HFNAAMECNHA;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid KKPBIGEHMDE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid AJLMMFNNKMA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid BDBHAHLCKPL;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid BMKIDOLOIDE;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid LMKAOBAGHOB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid LAMFPIOANNN;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GCKHANBFDCG;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid JCHDCCGIBDN;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid HLOODDHDFHM;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EOEHJPIJCIN;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid MEFLACBLDNH;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MJOPEIIOELE;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid NBCCNFLDNEE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JDGDDOJLNAL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid PDCFPBHIFPM;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid PFHPDDGANHM;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid BODNJKNCFMA;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid EIFHNLLPDJH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid MKICOAMFALD;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OODDJLNOACA;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid CPJIAMAPAMH;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DHLDLHKNNKI;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid PPGGBAALICP;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid BHKFNJAIEDL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid JCHJLAMJMJA;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CPFAGIAPAAB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BDDGLHKDBFL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CKOBLGLKGLF;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid COCNKCJNNFN;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid POJPLANDALL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid PMAFGLBBFFD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid KGAPMENEHIB;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid LKPFAKOOCPC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid PGIFMJDOEJD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BAOLAPLMAHI;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid NLMPPPECCKB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid BBBEMHDOLOA;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid HLNMCECOMIA;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid NIBOIGBKLBA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PGGOECMJMOD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AKCBPLHNMBF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid KMCFBBCOHEL;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid OFIBLOPOJII;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DGLDBBENGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MFOLHNJAPPK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CHKDKNPLKGO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid IENLJPCJJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KLPIAMFIIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid HDLPIAAGPEG;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid FAIOOBNHBAB;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid PHFOHPNNKGC;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid IMODPMAGBLA;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid MOCJHIPNKJB;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid CFKHKHCOGBE;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HENFFEGPMOI;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid GCJDEPJIPPB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid HJGELNAMKAG;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid NNJOAPHBEEM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CAJLCDFLLAI;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid HMGKGDMOOBK;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid DBECLKCFCOK;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid PAJLGCECAEC;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid JLEMIEMBBBO;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid JHLFFAEJEBH;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid PLJPEIHEBNC;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AGEKPIOEFGK;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid BJMKNNMGPGB;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid MIFOGDOPDBL;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid EEKHHEBIPBL;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KCPLLBGBJCO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid MCJPLFCINPK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid KGDKEILNNLD;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid PBEFKGAAMOB;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CKLCHALCAON;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NCKGNJJFPAA;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid AEELDOOENJN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid IDMNOIAJJIC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EOPEDOCJCHM;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid OJAOBCFKPJF;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid JNPFMLDEKOC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OIDOJAAJNDI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IBFOMHKDEJL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid PPJFIAKBMGO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid JFEKONDBDBP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EKDAMKDFBIL;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid KFNPPPFBGLO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OOMLEFMGCCL;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid GNKIIACMHOC;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid LOCHPIEJOEG;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid IENOFAMLHLD;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid ENNMLPHEAPN;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GFENDIIKJDB;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid HLDDDKDKDMA;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GBAPEBLKMMM;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GHPHGIOCBBH;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid BJJLADFKLLD;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HGBKBBDCHGE;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid GEDPICNGOKH;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid CFBGPFBMCDK;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid KKEMFDMLOPH;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid HGPGDNDNFPA;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid NKOPJLGLHIN;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LCCCFBIEKLL;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid BKPEOMJNBEI;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid KKLLOLLHOCO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid IFGOKGPOMKM;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid JHFIOLNOMEL;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid CNILAHCLDGA;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid HNJOCDOILBC;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid MKDNKFNEIIB;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid MDNIMLIGLMI;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid LOCLKEHPFBH;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid DGPHIPMHDBE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CGFNDLAKFMJ;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid ALMNIKAMHJF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid BPKFENJBPPM;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid ILGLAFODIDI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IBEPDOKKFJJ;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid LAEMHLFDDAH;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid MPHCGLLOHOB;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid PMDNLBCOPIB;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid JANMBFLPLBH;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid KCDFKNBHOOM;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid GIPIFHCBOAH;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid GHDJLOAOCDM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KDCLEOKBELA;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid OFAMHPPJGLA;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid LGCKKBDMLJP;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid HBPHCGMNJCG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid IMEBLMIPEHN;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid IGBMONKJFAF;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JCDHJPDICDO;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid PPINHPPLNFP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid EEKMBPNDBCP;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid HAKGBIHMLLG;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid EBKEICPFKDB;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid HAGDIGMAHHA;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid MHAEEHDOCMP;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid BMEHOAHDCDO;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid JIFACAFAGNL;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid MGGNDLMOGDP;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid GDEEAEJMBNJ;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NEPPIDHGGLM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid AAGMFCMEMKI;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid JEPMEJIGKPE;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NHIJMFBAJAM;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid LPCPMLMLKLN;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid GFIKEMGCGOG;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid IGKAMCIAFHF;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid BHHAJHNHIPF;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DAGKOODCIPJ;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid ACMOGLMHFIF;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid LKGKEACHPJN;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FDLMLEAJBBP;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid FOFNNGFLMPH;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid DKGPOFAFKKD;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid KBJACEKNNOK;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DABJALFFHOF;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MNGIKHPFBKM;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid GJFCFOOCLNO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid OFGDGEHMDGA;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid LHGHDMALCGB;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid KGHFEHHDHMJ;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid POPLJCMPCJD;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid CEFPHHOILGP;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid POLBFHKKLII;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid LCKDKBHKJAG;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid JDBIHHAMJAI;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid JAAOBJOEKHD;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid DCKGJHAIAME;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid EGCBPEDDKJI;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, FBPOCOBABHC> PMNHMHODMNL;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<FBPOCOBABHC, Guid> PEBBGFACALG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FBPOCOBABHC> DNMJCLJMBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x756AA40", Offset = "0x7569C40", VA = "0x18756AA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FBPOCOBABHC, Guid> KNPKPAOGLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x756A9F0", Offset = "0x7569BF0", VA = "0x18756A9F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IFMIMDCJDEB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x756A610", Offset = "0x7569810", VA = "0x18756A610")]
	public static bool MNFNAJBGNDH(JPLBBGKCEJL DDBPHIEPLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x756A640", Offset = "0x7569840", VA = "0x18756A640")]
	private static bool MNFNAJBGNDH(PIHNKOIIPAF CPHOLCKELIL, JPLBBGKCEJL DDBPHIEPLOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BOALPFIAPBB
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JNHOGNGNOEF LJELDKAOCJM, [Out] Dictionary<int, int> COFLKHLFHJE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(EGINAFIELCE BONEAJCOHEB, JHEPNOJHOFC OBGOFLIFJPI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FEEJOOKOJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly IFDOEKNOLCN BFAGKHNIAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<KAGCABDCBHB> JGIGJBIFGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<KAGCABDCBHB> CLIFGBHIDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly LNNKJBCILDK<CNEDJNAJINH> GEAMAMMCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> NNCKACCOMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly HMNNAOHNJEK CMKKAOMFOOA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GBENFGKJCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7567D60", Offset = "0x7566F60", VA = "0x187567D60")]
	public FEEJOOKOJNF(IFDOEKNOLCN MOIFBHDFFNP, IEnumerable<KAGCABDCBHB> FILBIOEHLBF, IReadOnlyList<KAGCABDCBHB> GDMNBMCAOIM, LNNKJBCILDK<CNEDJNAJINH> LCLLCOEBDPG, IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> NGENGCNCAGC, HMNNAOHNJEK KLMIAFIAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OOAHPNALACN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly IFDOEKNOLCN BFAGKHNIAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly IReadOnlyList<KAGCABDCBHB> PAKNGIEMFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly LNNKJBCILDK<CNEDJNAJINH> GEAMAMMCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public readonly IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> NNCKACCOMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public readonly ByteString DFOOGABANEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public readonly HMNNAOHNJEK CMKKAOMFOOA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x757C480", Offset = "0x757B680", VA = "0x18757C480")]
	public OOAHPNALACN(IFDOEKNOLCN MOIFBHDFFNP, LNNKJBCILDK<CNEDJNAJINH> LCLLCOEBDPG, IReadOnlyList<OCNKEONCIMK<GKCBGNOMKNK>> NGENGCNCAGC, ByteString CFDBCKAECOJ, IReadOnlyList<KAGCABDCBHB> CHOLAOBGOIP, HMNNAOHNJEK KLMIAFIAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MDJPPJBIIMK : PPNHFPGEBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public readonly Guid OHKPHDJPHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly Dictionary<Guid, Guid> INMHGMBPIOL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4597250", Offset = "0x4596450", VA = "0x184597250")]
	private MDJPPJBIIMK(Guid NMGDMPNJEMC, Dictionary<Guid, Guid> INMHGMBPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7578D60", Offset = "0x7577F60", VA = "0x187578D60")]
	public static MDJPPJBIIMK PEFMILKIAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7578650", Offset = "0x7577850", VA = "0x187578650")]
	private static Dictionary<Guid, Guid> DDMMKBJCIIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7578A60", Offset = "0x7577C60", VA = "0x187578A60")]
	public static MDJPPJBIIMK DKAJLMHCMDO(IReadOnlyDictionary<Guid, Guid> HDPIMFNJLMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7578700", Offset = "0x7577900", VA = "0x187578700")]
	public static MDJPPJBIIMK DHLMKMPGKCG(IEnumerable<KeyValuePair<Guid, Guid>> HDPIMFNJLMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7578A70", Offset = "0x7577C70", VA = "0x187578A70")]
	public Dictionary<Guid, Guid> IAAFAHHMPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
	public Dictionary<Guid, Guid> NGGJOECFALM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7578CE0", Offset = "0x7577EE0", VA = "0x187578CE0")]
	public void OFEFHMDJLMD(Guid HDPIMFNJLMN, Guid NHGKIMEFJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75783D0", Offset = "0x75775D0", VA = "0x1875783D0")]
	public void BAADKEILANF(IReadOnlyDictionary<Guid, Guid> DHBDDDDLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7578B90", Offset = "0x7577D90", VA = "0x187578B90")]
	public Guid IMEEECGKHDL([In] Guid HDPIMFNJLMN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7578AF0", Offset = "0x7577CF0", VA = "0x187578AF0")]
	public Guid IBKDJAFECPK([In] Guid HDPIMFNJLMN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75789F0", Offset = "0x7577BF0", VA = "0x1875789F0")]
	public bool MMMBGOMLADP([In] Guid HDPIMFNJLMN, [Out] Guid NHGKIMEFJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75789F0", Offset = "0x7577BF0", VA = "0x1875789F0", Slot = "4")]
	private bool DJKENDAHNDI([In] Guid HDPIMFNJLMN, [Out] Guid NHGKIMEFJKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OPANOLJBMKN
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
public sealed class LHNPMCNMIAP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class HKJGLAAGHGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public IFDOEKNOLCN staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HKJGLAAGHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x756A5A0", Offset = "0x75697A0", VA = "0x18756A5A0")]
		internal LNNKJBCILDK<KEMINLKAPEB> DHKMNBNEEMK((LNNKJBCILDK<CNEDJNAJINH> GraphId, LNNKJBCILDK<GKCBGNOMKNK> NodeId) i)
		{
			return default(LNNKJBCILDK<KEMINLKAPEB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private static readonly GGAILCJBJGL<KEMINLKAPEB, int?> EHFPJBEJHCF;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private static readonly long BADLEKPABAJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x756ABB0", Offset = "0x7569DB0", VA = "0x18756ABB0")]
	public static (long, long) NOPFIPHAKKH(IFDOEKNOLCN MKDOJEIJMDI, LNNKJBCILDK<CNEDJNAJINH> BAELGIBBJFA, LNNKJBCILDK<GKCBGNOMKNK> JACMIDKJGCD)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x756AFE0", Offset = "0x756A1E0", VA = "0x18756AFE0")]
	public static long PHPKOHHLOGH([In] ReadOnlySpan<LNNKJBCILDK<KEMINLKAPEB>> PPDCNNLIPMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x756AA90", Offset = "0x7569C90", VA = "0x18756AA90")]
	private static long LOGAEEPINHM()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LLOLCEACLLD
{
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly HashSet<FBPOCOBABHC> MFDJJAEIGFH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OEABGEPCHDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DOIKPMKHEMG : IEnumerable<KAGCABDCBHB>, IEnumerable, IEnumerator<KAGCABDCBHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private KAGCABDCBHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private IKCPEAKMEJP spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public IKCPEAKMEJP <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private APELNJDELGO spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public APELNJDELGO <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KAGCABDCBHB System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
		[DebuggerHidden]
		public DOIKPMKHEMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7567A90", Offset = "0x7566C90", VA = "0x187567A90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7567D10", Offset = "0x7566F10", VA = "0x187567D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7567BA0", Offset = "0x7566DA0", VA = "0x187567BA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KAGCABDCBHB> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7567BA0", Offset = "0x7566DA0", VA = "0x187567BA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x757BE60", Offset = "0x757B060", VA = "0x18757BE60")]
	public static IKCPEAKMEJP NPENOFPFBIF([In] OOAHPNALACN DPPOCDFPGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x757BCE0", Offset = "0x757AEE0", VA = "0x18757BCE0")]
	public static IKCPEAKMEJP NPENOFPFBIF([In] FEEJOOKOJNF DPPOCDFPGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x757BFD0", Offset = "0x757B1D0", VA = "0x18757BFD0")]
	private static HashSet<OCNKEONCIMK<MDFJGNPMNHF>> OCOBEIPBBFO(IReadOnlyList<KAGCABDCBHB> PNMPINBPHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7578F00", Offset = "0x7578100", VA = "0x187578F00")]
	private static void AGDJGCOAFJL(IKCPEAKMEJP ALJEGHEBAEH, [In] FEEJOOKOJNF OMAABDBPHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x757A6C0", Offset = "0x75798C0", VA = "0x18757A6C0")]
	public static CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM> MIIEBONAKOJ(IKCPEAKMEJP ALJEGHEBAEH, APELNJDELGO LGINEJGKIJA, MDJPPJBIIMK? KKGEBHFHBDK, bool KMCGMDFMHGD)
	{
		return default(CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x757C370", Offset = "0x757B570", VA = "0x18757C370")]
	[IteratorStateMachine(typeof(DOIKPMKHEMG))]
	private static IEnumerable<KAGCABDCBHB> OHAAMBOIPML(IKCPEAKMEJP ALJEGHEBAEH, APELNJDELGO LGINEJGKIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x757BC70", Offset = "0x757AE70", VA = "0x18757BC70")]
	private static void NEHOBMPCIBB(IKCPEAKMEJP ALJEGHEBAEH, APELNJDELGO LGINEJGKIJA, IReadOnlyCollection<ByteString>? NFIILOJHIIH, IReadOnlyCollection<ByteString>? DGHKBILMNCO, IReadOnlyCollection<ByteString>? FAIKLHLPCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7579560", Offset = "0x7578760", VA = "0x187579560")]
	private static bool BPKPCKNHJDF(IKCPEAKMEJP ALJEGHEBAEH, EGINAFIELCE BONEAJCOHEB, APELNJDELGO LGINEJGKIJA, [Out][NotNullWhen(false)] string? HHOJHACJLGI, [Out] Dictionary<int, int> COFLKHLFHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x757A3E0", Offset = "0x75795E0", VA = "0x18757A3E0")]
	private static Dictionary<Guid, PIHNKOIIPAF> LHGAJFOFHKI(IKCPEAKMEJP ALJEGHEBAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7578E70", Offset = "0x7578070", VA = "0x187578E70")]
	private static void ABKOAIBAGLA(bool KGJHPDJFMMM, KAGCABDCBHB CPOBHMMPOAL, MDJPPJBIIMK AKJKKDHFFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7579BF0", Offset = "0x7578DF0", VA = "0x187579BF0")]
	private static void HFKGNPLDIII(KAGCABDCBHB CPOBHMMPOAL, Guid NDFBNLGMNMN, CPDFBKEEICE? PDNPMJIGPCN, Dictionary<Guid, PIHNKOIIPAF> KPNKEHFCMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7579F30", Offset = "0x7579130", VA = "0x187579F30")]
	private static void IFLJKAONOOE(IEnumerable<KAGCABDCBHB> NBMKBJDCIKL, IReadOnlyCollection<ByteString> NFIILOJHIIH, IReadOnlyCollection<ByteString> DGHKBILMNCO, IReadOnlyCollection<ByteString> FAIKLHLPCHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct APELNJDELGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public bool KGJHPDJFMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public HMNNAOHNJEK KLMIAFIAHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public CPDFBKEEICE? PDNPMJIGPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public CPDFBKEEICE? FDCMOGHBBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public IFDOEKNOLCN FNAGLOOLODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public OPANOLJBMKN DPJDNHFHCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public BOALPFIAPBB NBEPJPBGMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public OCNKEONCIMK<CNEDJNAJINH> MKDOHELGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public BLDFJNNMNGI IBOKHBCGMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public List<KAGCABDCBHB> HMLPINEHMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public BNLAMAEAGEL PJMHPMIHJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public OGAAOEGMCCP BILCLGABHHO;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CPDFBKEEICE
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private const float PADKKHKKPEL = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Vector3 LBPAIJGCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public float DIOKPOCPBHH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 MKPGOLGLAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7567830", Offset = "0x7566A30", VA = "0x187567830")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS FGBGONBBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75677F0", Offset = "0x75669F0", VA = "0x1875677F0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1210B60", Offset = "0x120FD60", VA = "0x181210B60")]
	public CPDFBKEEICE(Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float DIOKPOCPBHH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x75679C0", Offset = "0x7566BC0", VA = "0x1875679C0")]
	public CPDFBKEEICE(UniformTRS NIENJEAIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7567390", Offset = "0x7566590", VA = "0x187567390")]
	public static CPDFBKEEICE DIHCKGFAIDN(CPDFBKEEICE JNGEIJHHFEP, CPDFBKEEICE IJIBIPABEHO)
	{
		return default(CPDFBKEEICE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x75671F0", Offset = "0x75663F0", VA = "0x1875671F0")]
	public static CPDFBKEEICE AJAOLMPMCKD((Vector3, Quaternion, float) LJELDKAOCJM)
	{
		return default(CPDFBKEEICE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7567210", Offset = "0x7566410", VA = "0x187567210")]
	public static CPDFBKEEICE AJAOLMPMCKD(Matrix4x4 BBPNNAKGCPG)
	{
		return default(CPDFBKEEICE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7567930", Offset = "0x7566B30", VA = "0x187567930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7567610", Offset = "0x7566810", VA = "0x187567610")]
	public CPDFBKEEICE EGALFBIJCOI(Matrix4x4 LBAHEDDLOKA)
	{
		return default(CPDFBKEEICE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7567780", Offset = "0x7566980", VA = "0x187567780")]
	public static CPDFBKEEICE GOBMAJPBOHG(Vector3 LBPAIJGCICL)
	{
		return default(CPDFBKEEICE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75676F0", Offset = "0x75668F0", VA = "0x1875676F0")]
	public readonly JKEOENNCIKK GNKPNIBPOAM()
	{
		return default(JKEOENNCIKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KNEKDPIANPP
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CHCIFGDJADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly PFEEFPPOMHP CEOLNCDFLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly GNOCHPEDIKN KDNGHEPMMOL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x148D4D0", Offset = "0x148C6D0", VA = "0x18148D4D0")]
	private CHCIFGDJADM(PFEEFPPOMHP HFOOBLKJDEM, GNOCHPEDIKN DJOFEIHDJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7566F60", Offset = "0x7566160", VA = "0x187566F60")]
	public IGPJANICJIA HOPKPLCAMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7566FD0", Offset = "0x75661D0", VA = "0x187566FD0")]
	public static CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM> PEFMILKIAFF(GEIDKIHPJPA<OJADAPCHIGK> DJOFEIHDJPP)
	{
		return default(CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7567080", Offset = "0x7566280", VA = "0x187567080")]
	public static CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM> PEFMILKIAFF(IGPJANICJIA DJOFEIHDJPP)
	{
		return default(CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7567130", Offset = "0x7566330", VA = "0x187567130")]
	public static CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM> PEFMILKIAFF(string AHBCIFBCKNI)
	{
		return default(CPEANPEHCAG<MDJPPJBIIMK, CHCIFGDJADM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PFEEFPPOMHP
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GOGLHEGFDEK : IDisposable, PMNGINNALJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private NativeList<FACMCBMMKCI> FGCDOLGLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private float CKEAMCNBDNJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HLJNCAAHCPJ CFHHIFLHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
		[CompilerGenerated]
		get
		{
			return default(HLJNCAAHCPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PNDNBOJGBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6558840", Offset = "0x6557A40", VA = "0x186558840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HOLGPPIHCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6558850", Offset = "0x6557A50", VA = "0x186558850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<ANJIOGOKEAJ> GMPALGHPGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AADAGMNJPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7569780", Offset = "0x7568980", VA = "0x187569780", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float ADHKHACBPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x756A3D0", Offset = "0x75695D0", VA = "0x18756A3D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x756A510", Offset = "0x7569710", VA = "0x18756A510")]
	public GOGLHEGFDEK(HLJNCAAHCPJ BCFKGGKKKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7569650", Offset = "0x7568850", VA = "0x187569650", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7569920", Offset = "0x7568B20", VA = "0x187569920")]
	public Vector3 GOGJIGNCFOG(int EFNCIOCDOKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x75696B0", Offset = "0x75688B0", VA = "0x1875696B0", Slot = "6")]
	public Quaternion EDKPBINGINI(int EFNCIOCDOKE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x756A000", Offset = "0x7569200", VA = "0x18756A000", Slot = "5")]
	public Vector3 JPFOIKEEDAG(int EFNCIOCDOKE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7567F20", Offset = "0x7567120", VA = "0x187567F20", Slot = "7")]
	public float AEJLLIICEMI(int EFNCIOCDOKE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7568D60", Offset = "0x7567F60", VA = "0x187568D60")]
	public void DGNHBEFJMEN(Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD, bool OMJCHCJNHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7569DF0", Offset = "0x7568FF0", VA = "0x187569DF0")]
	private bool GPIBLEAPCGJ(int CJMJOFLLFLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x75697C0", Offset = "0x75689C0", VA = "0x1875697C0")]
	public void GGHGAMGJLNJ(Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x756A340", Offset = "0x7569540", VA = "0x18756A340")]
	public void NICAMMGCODC(int CJMJOFLLFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7568C10", Offset = "0x7567E10", VA = "0x187568C10")]
	public void BIMAGBGEAMD(int CJMJOFLLFLH, Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7569E50", Offset = "0x7569050", VA = "0x187569E50")]
	public void IKHKNFJEJOK(int CJMJOFLLFLH, float3 LBPAIJGCICL, quaternion GLMEOLPKLCA, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7567DD0", Offset = "0x7566FD0", VA = "0x187567DD0")]
	public void AAEMPLKIEHH(int CJMJOFLLFLH, Vector3 LBPAIJGCICL, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x756A170", Offset = "0x7569370", VA = "0x18756A170")]
	public void LDJAFLOGMME(int CJMJOFLLFLH, Vector3 HFFGEMAKAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7568410", Offset = "0x7567610", VA = "0x187568410")]
	public static Quaternion BAJFLBLOKIM(Quaternion PKJLMNOFIIE, int CJMJOFLLFLH, float FIEBGMDNELM, PMNGINNALJG OEFACHFNBFD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7567F80", Offset = "0x7567180", VA = "0x187567F80")]
	public Bounds AJJALDMGHMH(Transform LBAHEDDLOKA)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x756A2D0", Offset = "0x75694D0", VA = "0x18756A2D0", Slot = "10")]
	public virtual void LJINPCOBLLF(bool JONHNBKLDMJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x756A0A0", Offset = "0x75692A0", VA = "0x18756A0A0")]
	public NativeList<FACMCBMMKCI> LDEFECDCMCP(float EEHHNFJIKFP = 1f)
	{
		return default(NativeList<FACMCBMMKCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ANJIOGOKEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float3 LAHGFMKGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public float MOHEKKJJHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public quaternion KMJNHNAHBOG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x757CAE0", Offset = "0x757BCE0", VA = "0x18757CAE0")]
	public ANJIOGOKEAJ(Vector3 GENKBFNNJCB, Quaternion PKJLMNOFIIE, float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x757C730", Offset = "0x757B930", VA = "0x18757C730")]
	public Quaternion MJMJNMBIGBF(Vector3 FOKNLDGGKBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x757C7F0", Offset = "0x757B9F0", VA = "0x18757C7F0")]
	public ANJIOGOKEAJ ONAPMJBPGCL(Vector3 BMAGOEKBPLJ, Vector3 IELKHKPFNDG, Vector3 GCFOJLKJAKL)
	{
		return default(ANJIOGOKEAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x757C590", Offset = "0x757B790", VA = "0x18757C590")]
	public AGJCIDPFBDA JHLHGHMFKNF(Vector3 FOKNLDGGKBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KMCEPMIJEBK : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7581790", Offset = "0x7580990", VA = "0x187581790", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75811C0", Offset = "0x75803C0", VA = "0x1875811C0")]
	private void CGHHANFPCGJ(Dictionary<Guid, Guid> LJKPCKEJDCC, FOAOCECKAID KBINNBPDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7580EE0", Offset = "0x75800E0", VA = "0x187580EE0")]
	private void CGHHANFPCGJ(Dictionary<Guid, Guid> LJKPCKEJDCC, FOONNOIHFCP OKBKAOMPPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7580F40", Offset = "0x7580140", VA = "0x187580F40")]
	private void CGHHANFPCGJ(Dictionary<Guid, Guid> LJKPCKEJDCC, AKHCIKOGKDL LKDBBKEEOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public KMCEPMIJEBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DMNEBBGDAKD : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x757CDA0", Offset = "0x757BFA0", VA = "0x18757CDA0", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DMNEBBGDAKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class PABPCCHHKKB : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7582140", Offset = "0x7581340", VA = "0x187582140", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public PABPCCHHKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class LJPIHGGIJGK : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7581810", Offset = "0x7580A10", VA = "0x187581810", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LJPIHGGIJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OCHCAMOMNHK : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7581D80", Offset = "0x7580F80", VA = "0x187581D80", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public OCHCAMOMNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DLBEOJIJFEF : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x757CC60", Offset = "0x757BE60", VA = "0x18757CC60", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DLBEOJIJFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MLFFDKOPDGN : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7581970", Offset = "0x7580B70", VA = "0x187581970", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MLFFDKOPDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EKCIHOAGHCL : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x757FDC0", Offset = "0x757EFC0", VA = "0x18757FDC0", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EKCIHOAGHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JDNKOHCDKBK : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7580B80", Offset = "0x757FD80", VA = "0x187580B80", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public JDNKOHCDKBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JEPIIDHAFDG : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7580D30", Offset = "0x757FF30", VA = "0x187580D30", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public JEPIIDHAFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CNIOGENNJMI : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x757CB60", Offset = "0x757BD60", VA = "0x18757CB60", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public CNIOGENNJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class EDCONNLCPIP : OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public static readonly CDEPIOJLEBL OKGPKBGJMLG;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x757FC90", Offset = "0x757EE90", VA = "0x18757FC90", Slot = "4")]
	public void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EDCONNLCPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JPLBBGKCEJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public EGINAFIELCE LCLBPLEFKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public MAFLPNHIGMP KBFFDFKOHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<int, int> CLFDHMNFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public Dictionary<Guid, Guid> NEBONIOMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public OGAAOEGMCCP BILCLGABHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public bool KMCGMDFMHGD;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OEKCKHBHHAL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGCAMKDKOGA(OAJEACFNMNK DLIGLJCDJPK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PEFFIKNPMLB
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static readonly OEKCKHBHHAL[] CAFOFGCNELI;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x75836D0", Offset = "0x75828D0", VA = "0x1875836D0")]
	public static void CIBCGMFDCAK(KAGCABDCBHB LJELDKAOCJM, MDJPPJBIIMK LEKCNOAHAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7583950", Offset = "0x7582B50", VA = "0x187583950")]
	public static void HHAMGLOCJOA(KAGCABDCBHB? LJELDKAOCJM, MDJPPJBIIMK EOAJDBGFLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7583460", Offset = "0x7582660", VA = "0x187583460")]
	public static void BPPOBCCBBBI(KAGCABDCBHB? LJELDKAOCJM, MDJPPJBIIMK AKJKKDHFFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7583BE0", Offset = "0x7582DE0", VA = "0x187583BE0")]
	public static void MNFNAJBGNDH(OAJEACFNMNK DLIGLJCDJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OAJEACFNMNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public EGINAFIELCE OEMBFFFNHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public KAGCABDCBHB CPOBHMMPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<int, int> CLFDHMNFFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Dictionary<Guid, Guid> NEBONIOMEEP;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7581CE0", Offset = "0x7580EE0", VA = "0x187581CE0")]
	public Guid GOAEJDMHNNK(Guid FGPNICIMMFP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OGAAOEGMCCP
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int AFMJNACDNMH, [Out] Guid NAGHINJINLK);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class DOLMOJEFJCO
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly ProfilerMarker IMGJDGECPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly HashSet<string> DBMDEODFLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly Dictionary<long, int> OPAHGDNADIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<Guid> NLHKFJEIOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<Guid> FPMOHCFJHEH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> NACLFILKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> HCCJMDHLJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> LOFODBGGMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x757DF10", Offset = "0x757D110", VA = "0x18757DF10")]
	public static void LEPDIEFOMDC(IKCPEAKMEJP PGPDDAIBPIJ, PJPNKJFDJAD BKBCAFKJIDC, MDJPPJBIIMK JPNENIPGIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x757D030", Offset = "0x757C230", VA = "0x18757D030")]
	public static DOLMOJEFJCO EJDACKMHGPC(HKFACLJBOKN JEICPGHJIDH, [Optional] PJPNKJFDJAD? BKBCAFKJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x757EA00", Offset = "0x757DC00", VA = "0x18757EA00")]
	public static DOLMOJEFJCO LOBGGIJFJBG(IKCPEAKMEJP HIGFKJNHOGE, [Optional] PJPNKJFDJAD? BKBCAFKJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x757D710", Offset = "0x757C910", VA = "0x18757D710")]
	public static DOLMOJEFJCO KGMNLFMOMIO(IEnumerable<string> DBMDEODFLLH, IDictionary<long, int> NKHPNMLFDEK, IReadOnlyCollection<Guid> FPMOHCFJHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x757F960", Offset = "0x757EB60", VA = "0x18757F960")]
	private DOLMOJEFJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x757FAC0", Offset = "0x757ECC0", VA = "0x18757FAC0")]
	private DOLMOJEFJCO(IEnumerable<string> DBMDEODFLLH, IDictionary<long, int> NKHPNMLFDEK, IReadOnlyCollection<Guid> FPMOHCFJHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x757F610", Offset = "0x757E810", VA = "0x18757F610")]
	private void PDIIGIDAGGG(HKFACLJBOKN JEICPGHJIDH, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x757EE80", Offset = "0x757E080", VA = "0x18757EE80")]
	private void PDIIGIDAGGG(IKCPEAKMEJP HIGFKJNHOGE, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x757D230", Offset = "0x757C430", VA = "0x18757D230")]
	private void HBBMAOBGFPF(ByteString? CFDBCKAECOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x757F0A0", Offset = "0x757E2A0", VA = "0x18757F0A0")]
	private void PDIIGIDAGGG(HCHIBKIPCKC? BFPPPKIAFBG, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x757DB80", Offset = "0x757CD80", VA = "0x18757DB80")]
	private static void LEPDIEFOMDC(HCHIBKIPCKC? BFPPPKIAFBG, PJPNKJFDJAD BKBCAFKJIDC, MDJPPJBIIMK JPNENIPGIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x757D910", Offset = "0x757CB10", VA = "0x18757D910")]
	private static void LEPDIEFOMDC(ILGJCNIKJJH? ILLDGNOPAEF, PJPNKJFDJAD BKBCAFKJIDC, MDJPPJBIIMK JPNENIPGIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x757F400", Offset = "0x757E600", VA = "0x18757F400")]
	private void PDIIGIDAGGG(ILGJCNIKJJH? ILLDGNOPAEF, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x757CE50", Offset = "0x757C050", VA = "0x18757CE50")]
	private void AGFADMIGLML(Guid? FGPNICIMMFP, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x757EA80", Offset = "0x757DC80", VA = "0x18757EA80")]
	private void PDIIGIDAGGG(KAGCABDCBHB? CPOBHMMPOAL, PJPNKJFDJAD? BKBCAFKJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x757E5C0", Offset = "0x757D7C0", VA = "0x18757E5C0")]
	private static void LEPDIEFOMDC(KAGCABDCBHB? CPOBHMMPOAL, PJPNKJFDJAD BKBCAFKJIDC, MDJPPJBIIMK JPNENIPGIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x757F830", Offset = "0x757EA30", VA = "0x18757F830")]
	private void PIPNOKCDAGG(string? MONOCJJJINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x757D100", Offset = "0x757C300", VA = "0x18757D100")]
	private void GNLDNCKIJPM(long GBDFEEGIIDF, Guid BNDFFODAMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x757D0B0", Offset = "0x757C2B0", VA = "0x18757D0B0")]
	private void GNLDNCKIJPM(BEEJLODIFCO? APODPNFNBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x757D1D0", Offset = "0x757C3D0", VA = "0x18757D1D0")]
	private void GNLDNCKIJPM(OKPPIEJGMNF? APODPNFNBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PBIHDPCMJDE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FKFHEHLHDLD : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private readonly IEnumerator<DictionaryEntry> IAHCPHAJMBH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry EFBOAKNFFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7580030", Offset = "0x757F230", VA = "0x187580030", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object MPHEPKMCCCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7580100", Offset = "0x757F300", VA = "0x187580100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object CADNOMLIGCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x75801B0", Offset = "0x757F3B0", VA = "0x1875801B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x757FF50", Offset = "0x757F150", VA = "0x18757FF50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
		public FKFHEHLHDLD(IEnumerator<DictionaryEntry> IAHCPHAJMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x757FEB0", Offset = "0x757F0B0", VA = "0x18757FEB0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x757FF00", Offset = "0x757F100", VA = "0x18757FF00", Slot = "9")]
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
		private sealed class OJMHDBFDLEA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xAF8440", Offset = "0xAF7640", VA = "0x180AF8440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x75820F0", Offset = "0x75812F0", VA = "0x1875820F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public OJMHDBFDLEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7581FA0", Offset = "0x75811A0", VA = "0x187581FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x75820A0", Offset = "0x75812A0", VA = "0x1875820A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7584DB0", Offset = "0x7583FB0", VA = "0x187584DB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object MBDBONINAPC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7584CC0", Offset = "0x7583EC0", VA = "0x187584CC0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7584E90", Offset = "0x7584090", VA = "0x187584E90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7584C00", Offset = "0x7583E00", VA = "0x187584C00", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7584C60", Offset = "0x7583E60", VA = "0x187584C60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7584E30", Offset = "0x7584030", VA = "0x187584E30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x75848C0", Offset = "0x7583AC0", VA = "0x1875848C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7584920", Offset = "0x7583B20", VA = "0x187584920", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7584980", Offset = "0x7583B80", VA = "0x187584980", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
		public RoomObjectCounts(Dictionary<int, int> LMMIMAFDDFF, [Optional] Dictionary<int, int> DMJDKFNGBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75847E0", Offset = "0x75839E0", VA = "0x1875847E0")]
		[IteratorStateMachine(typeof(OJMHDBFDLEA))]
		private IEnumerator<DictionaryEntry> FAKGEDMOICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7584EE0", Offset = "0x75840E0", VA = "0x187584EE0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7584B00", Offset = "0x7583D00", VA = "0x187584B00", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75849E0", Offset = "0x7583BE0", VA = "0x1875849E0", Slot = "9")]
		void IDictionary.Add(object MBDBONINAPC, object OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7584A40", Offset = "0x7583C40", VA = "0x187584A40", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7584AA0", Offset = "0x7583CA0", VA = "0x187584AA0", Slot = "8")]
		bool IDictionary.Contains(object MBDBONINAPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7584BA0", Offset = "0x7583DA0", VA = "0x187584BA0", Slot = "14")]
		void IDictionary.Remove(object MBDBONINAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7584860", Offset = "0x7583A60", VA = "0x187584860", Slot = "15")]
		void ICollection.CopyTo(Array LGLFHJLCKKH, int KOOLKCPAFBB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class NDEKPFFIFDC : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xAF8440", Offset = "0xAF7640", VA = "0x180AF8440", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x7581C90", Offset = "0x7580E90", VA = "0x187581C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public NDEKPFFIFDC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7581B00", Offset = "0x7580D00", VA = "0x187581B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7581C40", Offset = "0x7580E40", VA = "0x187581C40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x75808A0", Offset = "0x757FAA0", VA = "0x1875808A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object MBDBONINAPC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7580770", Offset = "0x757F970", VA = "0x187580770", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7580950", Offset = "0x757FB50", VA = "0x187580950", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x75806B0", Offset = "0x757F8B0", VA = "0x1875806B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7580710", Offset = "0x757F910", VA = "0x187580710", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x75808F0", Offset = "0x757FAF0", VA = "0x1875808F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7580330", Offset = "0x757F530", VA = "0x187580330", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7580390", Offset = "0x757F590", VA = "0x187580390", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x75803F0", Offset = "0x757F5F0", VA = "0x1875803F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x25AD490", Offset = "0x25AC690", VA = "0x1825AD490")]
		public Invention(long JDNOHHGIHEO, int IPBKHOJKHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7580260", Offset = "0x757F460", VA = "0x187580260")]
		[IteratorStateMachine(typeof(NDEKPFFIFDC))]
		private IEnumerator<DictionaryEntry> FAKGEDMOICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75809A0", Offset = "0x757FBA0", VA = "0x1875809A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7580570", Offset = "0x757F770", VA = "0x187580570", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7580450", Offset = "0x757F650", VA = "0x187580450", Slot = "9")]
		void IDictionary.Add(object MBDBONINAPC, object OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75804B0", Offset = "0x757F6B0", VA = "0x1875804B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7580510", Offset = "0x757F710", VA = "0x187580510", Slot = "8")]
		bool IDictionary.Contains(object MBDBONINAPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7580650", Offset = "0x757F850", VA = "0x187580650", Slot = "14")]
		void IDictionary.Remove(object MBDBONINAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x75802D0", Offset = "0x757F4D0", VA = "0x1875802D0", Slot = "15")]
		void ICollection.CopyTo(Array LGLFHJLCKKH, int KOOLKCPAFBB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> PLIHFAMGLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public readonly IReadOnlyList<Invention> EOJNFDJOLBM;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	public PBIHDPCMJDE(IReadOnlyDictionary<Guid, RoomObjectCounts> DCGEHEBKCAL, IReadOnlyList<Invention> OAPFGEPEHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75823C0", Offset = "0x75815C0", VA = "0x1875823C0")]
	public static PBIHDPCMJDE EJDACKMHGPC(HKFACLJBOKN JEICPGHJIDH)
	{
		return default(PBIHDPCMJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x75822A0", Offset = "0x75814A0", VA = "0x1875822A0")]
	[CompilerGenerated]
	internal static int AEEKGPPAGEF([In] IReadOnlyDictionary<long, int> AODMJEPFCML, long? GBDFEEGIIDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7582DA0", Offset = "0x7581FA0", VA = "0x187582DA0")]
	[CompilerGenerated]
	internal static void FIAMCEODNEG(int KMGHPPGFOLG, [In] HCHIBKIPCKC HKFDKLNMJEC, [In] Dictionary<long, int> AODMJEPFCML, [In] Dictionary<Guid, RoomObjectCounts> DCGEHEBKCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class PJPNKJFDJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private readonly MDJPPJBIIMK GKEFGHDEJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> EHCOJPOGGPO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public MDJPPJBIIMK CBBHMEHOPED
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7584690", Offset = "0x7583890", VA = "0x187584690")]
	public void OFEFHMDJLMD(Guid LIBJCJMOOLN, Guid KOCFPHGPJPH, IReadOnlyList<Guid> AAPLHBNNKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x75845A0", Offset = "0x75837A0", VA = "0x1875845A0")]
	public bool KCLBMBKLJPI(Guid PLIKMCAAKBK, [Out] IReadOnlyList<Guid> FPMOHCFJHEH, [Out] bool GCOJPGMCOIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7584740", Offset = "0x7583940", VA = "0x187584740")]
	public PJPNKJFDJAD()
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
