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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1F7A0", Offset = "0x6E1E7A0", VA = "0x186E1F7A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EGGBEBHPNPF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PHGAJDKBGAH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GKFBFCFNEFD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> FNPAGKHLEIM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> KHBNNACJCID;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JFJNGBIHGHK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LMCIBGOMHHP;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string DPMMMLDLOMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E19CD0", Offset = "0x6E18CD0", VA = "0x186E19CD0")]
	public static bool LKNGIHMEBFJ(Guid JPIDHBIAICG, int HGPGMDBFCKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E195C0", Offset = "0x6E185C0", VA = "0x186E195C0")]
	public static bool CHLMDCGMGFH(Guid JPIDHBIAICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E19650", Offset = "0x6E18650", VA = "0x186E19650")]
	public static string HMGCGNEGEKH(Guid EEKOILIMLBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ILIKMHFHJBP]
public enum EJHHONKFEHP
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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F3F0", Offset = "0x6E1E3F0", VA = "0x186E1F3F0", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LEKOJAHNPPN
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid EABNKIAABHJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid GOKGDFFIMMD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid ANKNAOKCMEE;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid MNDNPKAJHJH;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BLCBOGNHNFG;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid NMADCEOAPNF;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid PMNILECFPID;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid NLAHMPAICHM;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid MNFONLABHDD;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid FJFHDNMOJGJ;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid IEPMDOPCAHK;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid EHIMAPONDLP;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid KEBNLGHIPLO;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LOJOIMKBDEE;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid BMCNIMFFMPI;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid OBOJPCPAKJE;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid JBIKENHPKAC;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid BKCBOMHMMCD;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid IHHPPJMFODF;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid DGDBGKGJAFD;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid IPMNEEGMAFH;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FJFNEFCBMNL;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid JIEPOHPOMJA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FHHDDAPHEHH;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LKEGLBOJPBG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid JJGMCNGKHDL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LDJOAJAFOPF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid AJNNCDIDFGA;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid BKFCPPKEHGB;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid FBCJMOJLIHG;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid HPBGNIGNPAO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid DBINFIEAMPK;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid IHNOOOBKONB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid DIOBMAOEMON;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid KHHNBNDGCHE;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid JGICJFCJNLJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JEBDBLKOPBO;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid HKOIHOAMDCD;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid AMMJHPFAHEP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid CNKKJOEKFHE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BFDHMHNMBHJ;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid FJLOAEDENCP;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid BJJCONLMNCA;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid FLLINPGKEDD;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid KGDOEHJMEBH;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GDEOFGDEODO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid DAEHNAMFOAL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid ADABKOPNCFO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GJAGFJEIDID;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid MOGHMEEEDOF;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid LPPBFPPIFAL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid JKDDPAJJKPO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CPNLPHHFKBM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ILEFPMCAKPA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BMINCPPMELO;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LPJGFLCPHAM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BMEGPOBCGFB;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CJKBOJIFJCE;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid BPBCAFHILEH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CJLIEIJCJKI;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid MNICAIBIGIE;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid OACICBBFMJJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FIKDIJDDDJH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MEEBKCPGOFP;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HMDGCPBLIGG;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid LHGLEAAFEOJ;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid OKGGPINFCLH;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid OCFAFINPICD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid ANEAIAJLDGB;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid KDNAIPDBCHC;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PHCOGLABAFA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid FHHBPPJAGEC;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid FNHAFONMLLK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid KNLPNLMPNNC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid GDJNACDDCDJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid ANACFJFBNPC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JJJCJDHKJPF;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MFJNNCPGDNE;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid DMHJOJFEMKJ;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid CMKACNLKAGP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GDDIFODOOHP;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid LAKGPKINEJJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid BAJLPIOINHE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid EAJIACICIBC;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid BNEHPJKJOKC;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid HDPFMIGLFDG;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid KMBGNHIDEOP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid LENKDKBCBDO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid DLHBLACNPGN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid LNGOCPFNCNL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid JLANLFBOCMI;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GGOFFCPCOCB;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid DFFFAGKNCGB;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid CFBNBELIKEP;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid EEEMCCIJJPO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IHEKGJMGKLI;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JBKFKOKJGEB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid DHBDOOOCEAH;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid CCEJIHPIGCN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JCBICJNABEK;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid BMEBAMFHCHE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DAFBLCBKAIF;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GGMJBFGGDIJ;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MHJBANMHIGC;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid PGJODGEIKOA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NEIIIPINJED;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DKMBPIJLHCF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid FIKJIFBFBOF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid NDFMNDPBIPF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HGNKJMAHPHK;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DHMBFLMAEMI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid PELLLEFLOAM;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PLAFHNGFCAN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid OCAKBOCKFBD;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FIEHHEAKOPH;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HONDMCGBKKN;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid DICNFILPJIH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid ACCEIPLGIFG;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid JACMJEGJBAO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CBJAPCKHEJE;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LFEBGOGOFKN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid CNADMEHCEKG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid DODCHCKLAAP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid CCALLAOLKBC;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid JAHMPCMMKLC;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DNKLIGBAPEI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid GMNCECOHDME;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ICNNJIPODBP;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid FJADHOMPEMB;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid GLGMAJJFOOK;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid IBEJMCPNJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid AOIABHEKKGI;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid NBKGHCEFODI;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PDMEFDNPIBB;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DOGFODOLHIH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NELNIPPBCHK;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CHLHJKOFOLD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PIOOOCFELBE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid EKOCCDOOHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JPGCGALCDBM;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NMCKLPOOPBF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JFJGLFAHIKJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid KLNHKKPEIGI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid IFAIAFGIGDN;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid LNNJGEEMMGD;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JDBGCOMIODK;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid EFGDCOCIHAG;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid BBIEDMJNBOF;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IHFPJKCLHIP;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BDMNCHMLHIE;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KNHAKAHPIOP;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MOEPFABMAOA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NEKJBGIIKMN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid OEDPGBCJPCK;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid EGOBFBDJFHI;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LBDFALDJKEI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LNEMONEOLOH;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid COIMADNPGFJ;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid MAEIDDMKIAA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid MKOPLOONGND;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid IJOPDGPAGED;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid ODGKPIAPOHL;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AHNKOBDIPBL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid OJNANJMLCLB;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid ANOBIMIFNBH;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid GICBADIPMDL;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid GJPNKAIHBFD;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IBNPGMAOIIC;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid GGKFDLGLPIF;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LEJLJPFAEJL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid NFIGEBNLPLL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DBIBDCJLKJD;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IODMKPDNJMK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid JJKIEJJLLMK;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid HCCCFPJDEJB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid EBMHGFMCACP;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KGCBGGJHOGO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid MAFBHPHHFGM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KOGHEOJJDPL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid CBEHNLCNJGL;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BHMFGLLJBHB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LHBJDGJIAOI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FEFGKMKPEMF;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid FCKJFDCLMIL;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FOBPIGGJAHM;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid NAPMAPNHFAC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid AJFIGLAOFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid LGDJIAGBCKL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid BAOEBMICPPB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid EPKPMFGMDND;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid HNJOOAIMLLA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid HIHJFNCFLLM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid BJCCIKFBPPK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid EDEANFMMPHA;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid JKJDOEFHBBL;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid ABGPJLCNNDK;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid NPBOBPJBHII;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid CMJNBHFFPEO;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HBJELLLHKHA;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid BEJINKNEOKF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid JANEGPHAMNP;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid HPLECPLJOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid KKKGHKNFKII;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DEPCPJMOALG;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid BHBHGBFLBKN;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid OFLBCKFLCJE;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FKEIPMBEEIL;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DDBLMMKPBDC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OJKOEIKBNBA;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid CCMINKFHBID;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DFLMAJOCINL;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HJKOJDKLBCD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid GELMCBKKDGJ;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid OCNJNKBGMLH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid HODJCCKGJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AMAEGIJNNHA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid INJIJKDFDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid PJIMFJLFDLE;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid ELJINGMKFHG;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DOGGOOGDBHC;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EPEGPCEBIIL;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MHEALMJCNBO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid ECODJOLEGDG;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LPMHJGIOLOL;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid IJEIHIDMOFN;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KPNJPJOBHHL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid AIHKLDLKNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid HKPENJAOKOK;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid ECLLMOFOLJL;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid MOOJBNONBNK;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HEHODCHGNFP;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid GMNNINPNFPO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid NLFEINDNDHP;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid KKJLHKHHFGP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DAIHLONMFJK;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KDHFGKKIMPH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid JGKKGKEGFGC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid AMCGGIIMPOA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid KBMCAELLCBF;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NKOJKKJJIBJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GAOPKHLEBEI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid MAFKDPLHAAL;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid BIAFAFJKJKN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OJPJLHCNMAH;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid AHENENMKJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid FENPHNLAGOK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid CPOGMNNDGLE;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PCAAGOEIEKC;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CMACJAFBCIO;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BBEFCEINPIK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LENKNDECGCB;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid KBKOJLLCMOM;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FEJAGLIKIDE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KJNOLKEHCAK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HHEPFBELKFH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CNMNCIOJMCJ;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid PDNKCFEBODB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid BAFNOMHNIDH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid MJECCEAAGOK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid CMCAIKIHOJF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid APOFOBFPLOK;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PEKILEPBBPI;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid OMIBOMIPAJA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid JFCMFOJBHBB;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid NMDMEJHENHB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LPNKDBPNPEG;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DCEPJDNIFID;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid PDNPANHPLKF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid PKJMLGMECAA;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MJFPMPBOPFE;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid GNHOOFLMILK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid OFLFDNLDLBI;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid FBEBNGAFNBL;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid NLHHFHHAOOI;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid IBGIHEEACCA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FAFANHJDHJE;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GLLDHACGIGA;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid ENHJEJCFEEA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid OABGOBGHDCB;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KOGCJEMOCHP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid KOKMKPFDLDK;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LFCPBBGAHJM;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid GNNJNMNDMNN;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NAHGNOMMHJA;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HEPDOABGPMH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GCBIFDJBGII;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid KPKODFBPFPM;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid FLKIBNGIOFD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid KGFGGHGCOME;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NAELFMADHAA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid ALGELANIICI;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid EBHBLKGBOMM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NEGJMOKGKOP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LFGPMLDIBIC;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid MJBFCKBNIHK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid CAGHMGMPEKG;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid BGKCBLEBNJH;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CCOIKFIGENA;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FJIBLMPOFKP;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid GEBJHIMOEPP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LNAJDFNIELO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MBAJEEPHNMB;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JDMOMAIOEBJ;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid JHKHINIICBN;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid PAGGOKIEIOE;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid JMOAFDEHLBC;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid IKPKDKKJHII;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EBECDPNBNPF;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid CECGFKJNLJB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid ACGPLDDIOIJ;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid KOEDDJFCJCE;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid HFBIPEIFOKB;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid JBMCCPHDBLJ;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ABNCGJJINLD;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid INMILBHAGHI;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid NLFDLBJFDJA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid FMPLOLDDJDO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid LNJKPCDFEKK;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid NMJPOPLHPHP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid NNEPKMIEAIL;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid EOJEMNNICEE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EFHDGKEOKAL;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FECODADNNLL;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AAOOHMNINHO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid PKIOHOEDPKO;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid BJEJNCLEPHA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid LPEBOBCIBFO;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid KMBKLNABJAN;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid ADDKCIJIHLJ;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid EGDKHJOMIOE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid CLGPHFPDGKK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid AMLNNCJKJHA;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid JNLJEAMCMJB;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid GLKMHJBCFPL;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid LPIPKOCNNPL;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ELDDLHPJMCF;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid PNEBOLGACJN;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LLOKDCGFIIG;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NHPBEOCBBLF;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid EAIAEAACBGA;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid EDCGFDFJCCK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid GODKEFFKNFP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KNPBDMNHCON;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid JGMMMFCMDOF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid HNJFFIOKOKI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FAMKIKFIFBN;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EKDMGBPJBHA;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid GMGOAGGFIDL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AFIJADBJPLN;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid GFHPOMOJNCD;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid ALPDKLPHOOB;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid IPGFBCFIICJ;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid PHGAJLEGHCG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid EAGCCKGFOCC;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BEMJLLOKJPI;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid PBMCGLKMEJD;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid ODPJAEMIBCB;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid IKBHBPBBEAM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KBLEMLHKHIJ;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AFOFPJDJCHF;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid KEELMJAKENB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EHNJPBGKFBI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid OBFGCMIJLLJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid OKAAEMBBCAH;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid LDIGIAEEPFH;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid GGHCDIADOPI;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid OCOAMKPKMHC;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LHBMOBCNDNO;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KAGAINNMELO;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid LDGMFCKAECE;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid EEILKJHBDFD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DDHKCMGCBAG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid JDCNILBGMHP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid HHEENIGMPEB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NJMFHLKNKOM;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid CJLCLFMACIJ;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid DJFGOPBMMNE;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid KEDBFJEHHDG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid CGLJLAHCPBN;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid FLLFLOMMLNI;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid HELCKKCBFFF;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid ADNIEICFCBC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid ELBPJPAENIO;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid MHEIBFLBDCK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CKJOAAPKJEN;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PAGMIOPECLB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid HLJPMBGPCGM;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid EGOKENLOAID;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PFHOIAEILHJ;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BNJOIFEPPNM;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid PBDCBMPMJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid MHIPAFFGFHO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid OIPAALKMILC;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FLILDPCCAJK;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid GPNNDNKAGAD;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid MNBFBBNDNNB;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid FCNEHICCMPE;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid JDBKFBONGIN;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid JCNLMNMODEI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid LILALFIGFON;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid DMJFIEDFPBG;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid MKFEKEEJAKO;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid LDGCFHBCBMP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid IDNIJJPHOCH;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid BLIEHMNDJCB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid DIGOBDKFKBN;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JELIDNJFBCB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BEEOJLDBIII;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid IPKJMDHJIPN;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JEDAMEMCGAA;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid GBAAOEBCAAO;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OHDDGAAIIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid ADJJMIMBMMB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GOLAPOFEKOJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid IIBFNHPICLL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid JKLCFLALBJO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid FDLMGHFNOBN;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid LIGEENJFJFI;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NDPOKCHJGOP;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid NNEOPPCEION;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid COPAFIIJCHL;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid KDMDJBAGNAA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid IBPMLFEPCOK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid DHNEAMHNDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid LJEGLPKOENG;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid AFLGOMLNLGB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid PLBPAJNMMMC;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EDOOHJCJOAF;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid LOOLMDLEJBK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid DKNHDHNPAMJ;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid IHGOOJPIBNJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid GNELOEKHCKP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid LHBCEBBNEKF;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid OJMDJKFHCBO;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AAPKMEJMDNO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid BHBKDHMPMLD;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JJDLAENHGAD;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid PAJNKOGDEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid ELLKEPLELJC;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid FEJFONNPHIB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NCGCKDNJLKE;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid HKOPLIPDNDN;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid IGBLLHEALNC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OCJEEANGFAI;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid NIBGCBNGGMK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid LEJICHKHPJK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid FFDNGNKPCCL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid JJJMKFEMPDL;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BOAFEIEMICE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CLKOCKNAFBI;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid AINPLJDPJPF;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid ACLFGBNKJFK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid FECOMHIFHAB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid KPDFAKPJNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid DHANPAAAPAH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LLHOPOMDJOH;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LLBKMDPJJMM;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid PMONBPDNPND;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid OBOCBMHGHDD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid PGPOONHMGFI;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid DKBBAFIMGMA;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid FGBMMFNBGCB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MMHAOONDMOK;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid PIGBLCJOEGJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid JBCAILPOIHC;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid LNIIANFAIDG;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid FBCHDMMLAHF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid ALCJGLOEAFP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid GFJKHOKCMDP;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GNKEGDPBGBI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MCDOCPFPGCB;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid DPGDCKDGBBC;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid GIKMGCLFOHB;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ODLHKJAJFNF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid DIOAIOCKGDB;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid KLNBJNBMDLN;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid IBDBDJNNGPN;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid NIDPNBHGALE;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid NMKHDCNFMJE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid NIJCIFDIHOF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid OMIOBHECHNI;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid NEOJEHGAEFO;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid AGPGNBFOGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FLFCNKBMLFI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ABACLJCKOLE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LEMKOHHICFJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid CKBMMEGMBHE;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EOOPGBAPEMP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid LPAOIHEOJKA;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid KLCEONHANMG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid AHMKDIAIIAK;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid ICMDIPMHDPC;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MOKDGFKMFJP;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DBHINJPAHOC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PFJLAPLDMMI;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid EGHNNHLEEKE;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid HFMPGJPHHDA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid JAPKJGMKBPG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid NCGOFFCMNLN;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid IKELFALJNEC;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid OPEMKDGANPE;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HCKCJJMLFBK;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid DIHCPICDLKG;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid ONEJBBIBNLM;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid MBHHKCAOIOG;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid LMMJMFNNFMB;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ACDFCHIGEHL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JHOHOJGJLKK;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FBFBPFLGGLE;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid ICMDIEGMADL;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid BLNFDEAIHGC;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid MJDFEOEEHJB;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid DLEMMLNLKLD;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NMIOFCADFMF;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid KGAABEPNAEE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HLLCGFCBJCK;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid HFCAHGJLCJN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid FIPIDEBGKLP;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EJMDHNMMHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HFCCNABPJPA;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid KHIFFLHPLKH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid EMPCIMHLHBH;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DMAKGLPDIJO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CNLLCEOEFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NBJFJIEHONC;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid FNOAEMEENFN;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid CGAIOGBLGEH;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid PBHKNOPODOB;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HKACEDCBABJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JHBAKIKEELE;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid OGBAJLNPCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid IIFPALOCJAB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid OOCHDPGHDJC;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid ELAICGPBBGI;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid COMJNDIFOIN;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid LLMJOKPDCHA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BJEPHNONCAP;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid JIDDBOEEHMA;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid GEDFMLAJDHF;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BMBFPJBMIKC;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid LJDHEMALOGG;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IFFCOENPNPH;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ICAEBEKKBNO;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid KKPGLBILCPE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid IDEOHMCEMFD;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid KOEHFPNBMGO;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid JACOLIAIKCL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PDHAGINBLCK;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid LMJNJLKOJBL;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid BKAKHFFKJNB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid DIKMFMJPMNL;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid APCCNLIDJAK;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid AODMAPHNLKE;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid DKMBGCKKIDP;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MMALMDIAMHO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid NDPOOOGBEFA;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid DLJOJILPHON;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid GJEIDIADDNH;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid ELFDHLFPEKB;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid EFHNNIKPLHO;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PJKGLCCNDHE;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid OIKBMALEFLH;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid IHLHEJBECHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid JFBBKFEBEKH;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid PJGFKLBKFAD;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid HCCKEJEKJCC;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid OFLEJFEFDGH;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid AIJDAKEOODN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid PPKNGPPPMLC;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid KLFDMADLKPD;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid ALOIHHBDEEO;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid JPPIDNHCKFJ;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid HMILGHALODB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid EPCDAKDNCDM;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid JEINOAENDMC;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid GJNGIBKHGCE;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid GCNJDDAIJAA;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid HIBNCAINPDD;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid LMPHIGNFDKJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid FICKCHHGCJO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid BKFECJPGJMN;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid LGGFBHMDGJG;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid KCLJHHMGKNO;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid JEGPDNCJEKA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid NCDOIOBPCKJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid MAHMBAFFPNO;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid NPMMBDIIMJE;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid PENCJLEDALL;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid IPJHLPCJCGE;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid CLHLPJOEHFJ;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid OKCFINMBOPO;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid BNGFFJHOEGF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid FKMAIJMOFPB;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid HPMBIDFPLEL;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid EOOPPPDOMHH;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IFHAOKBACIP;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid OLGKMNHHEAL;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NNCDJLOMKHO;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid FGJHPKLENAP;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid JIGAPNJGPKP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid AEJOKEMNAFL;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid CGEACOPCKHA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid ALAGPHCMLIC;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid OPNENMHNGNA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid LKCNOOPGBHM;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid BONJLEGLMNN;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid LJLBAOJAIDC;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DALBMFLJBNE;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid ANOEAIOCLBO;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid DAEFIAFOEAA;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid HFCAPCCEOKP;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid FGEMPCPIEOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid LMMBPIAINLP;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid NIFFELMPLGD;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NGLPOAKFAJI;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid PFKMDHFKEBE;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid BJNGGHBNBFE;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DOFFBKLPBNA;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid KJKGBINJHLH;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid FCHAOCJMEMJ;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid HCOGOAOBJPB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid IBCELMLBOOB;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid AADLLPNCCLN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid MJGPOGMMFPA;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid GCOOAMGIMLK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid OLAMBJNBOAO;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, EJHHONKFEHP> PLODIPBBECP;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<EJHHONKFEHP, Guid> GEHPMNODNKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, EJHHONKFEHP> LLACFPPHPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F350", Offset = "0x6E1E350", VA = "0x186E1F350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<EJHHONKFEHP, Guid> AMGMOKOLPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F3A0", Offset = "0x6E1E3A0", VA = "0x186E1F3A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JBIHDOPBFFO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BAF0", Offset = "0x6E1AAF0", VA = "0x186E1BAF0")]
	public static bool HHCGFMENJFC(IFFLOABKMEJ PHLMEALLAKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B740", Offset = "0x6E1A740", VA = "0x186E1B740")]
	private static bool HHCGFMENJFC(EJBDPDAMOIO CGLIBNPLPJF, IFFLOABKMEJ PHLMEALLAKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ECCMMDNGKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly GMNAMPPAFMB CGIOADKAGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<KGIKLNIIDMO> KKKGALNHMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<KGIKLNIIDMO> NDKJHIDMDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly FCEODKAEDJI<OMEMEDNNNNN> OLFFKNBFCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<GGKCCFNJFJC<IMDHLBELCNK>> FMNDHIIBJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString JHIDMAAEDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly PHBDFBFLGBL PHECLDPHCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool DIBFBJGGECI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E18CC0", Offset = "0x6E17CC0", VA = "0x186E18CC0")]
	public ECCMMDNGKEM(GMNAMPPAFMB HPCFOPLFCIF, IEnumerable<KGIKLNIIDMO> LEEIJCNMFOE, IReadOnlyList<KGIKLNIIDMO> HCIJMAKLBJN, FCEODKAEDJI<OMEMEDNNNNN> LDHIGPEHLAP, IReadOnlyList<GGKCCFNJFJC<IMDHLBELCNK>> IGCDJMFCGJO, ByteString POMKMCMIJGL, PHBDFBFLGBL IANLAEECIJK, bool PJGCNEHJLCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ABNIHMOMACO
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CHKLLDHGPOP CONAFKKIHKL, [Out] Dictionary<int, int> KFOAEIDKKEE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(PMEDDBIJCLE GLFECGFFAOA, LBKDAEJBEOC KMAPDKAAGHC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EGDKNPFJADD : HAANCDGBAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid GIFAHAGADCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> MIEJJOCKMBC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> ADNGHPNFJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAEA0", Offset = "0x3DF9EA0", VA = "0x183DFAEA0")]
	private EGDKNPFJADD([In] Guid NPFPKPIAKMO, Dictionary<Guid, Guid> HFIJDHMBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E19070", Offset = "0x6E18070", VA = "0x186E19070")]
	public static EGDKNPFJADD EJLELCHFLID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E19540", Offset = "0x6E18540", VA = "0x186E19540")]
	public static EGDKNPFJADD LFIEELBPMPF(IReadOnlyDictionary<Guid, Guid> KEJMBANPNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E18D50", Offset = "0x6E17D50", VA = "0x186E18D50")]
	public static EGDKNPFJADD ECKPHKKOPJO(IEnumerable<KeyValuePair<Guid, Guid>> KEJMBANPNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E19100", Offset = "0x6E18100", VA = "0x186E19100")]
	private static Dictionary<Guid, Guid> HADHCBOCKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E191B0", Offset = "0x6E181B0", VA = "0x186E191B0")]
	public void IDLHOFIPJOG(IReadOnlyDictionary<Guid, Guid> KEJMBANPNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E19430", Offset = "0x6E18430", VA = "0x186E19430")]
	public Guid IFKCMLGJODO([In] Guid EEKOILIMLBO, bool DLBOCLALFAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E19550", Offset = "0x6E18550", VA = "0x186E19550")]
	public bool NGCBKDLEFLO([In] Guid JHCIODFGPNM, [Out] Guid PBAPHFOKDDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E19550", Offset = "0x6E18550", VA = "0x186E19550", Slot = "4")]
	private bool MAIPMMKKLLD(Guid KBCCBGCMCIL, [Out] Guid EMIPIILANPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OFIMKOOAMIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PLIGKKFGJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCNNFLPKKP(ByteString AJDKCNCHBKO, EGDKNPFJADD MIMBMIGOMHO, [In] UniformTRS BNBOCACEGJG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DPINOAMDGJO
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
public class BFPBKAPANOF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x983FE0", Offset = "0x982FE0", VA = "0x180983FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CPNMMMDNLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x142F560", Offset = "0x142E560", VA = "0x18142F560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long PDIIPEHACEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E18CA0", Offset = "0x6E17CA0", VA = "0x186E18CA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B08B10", Offset = "0x6B07B10", VA = "0x186B08B10")]
	public BFPBKAPANOF(long DCEOMHJEBBP, long NEKBMJKHMAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PHCHHJMPMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, BFPBKAPANOF> MFKPEJNPJBF;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> NKNCJBALCIC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long CCACMEHGDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x142F560", Offset = "0x142E560", VA = "0x18142F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long HDKEOCCNMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x92B0E0", Offset = "0x92A0E0", VA = "0x18092B0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FB40", Offset = "0x6E1EB40", VA = "0x186E1FB40")]
	public static PHCHHJMPMLC IOMBEEPGEFB(GMNAMPPAFMB NJNFKGDGPMA, GGKCCFNJFJC<OMEMEDNNNNN> BBEFHPAGBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F870", Offset = "0x6E1E870", VA = "0x186E1F870")]
	private void BHNOOLKHDNF(NAOHBAGGJLN CHMIAHGMJKI, long EONFEGDBHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E33B40", Offset = "0x6E32B40", VA = "0x186E33B40")]
	public PHCHHJMPMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IGDBFHFOHJF
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<EJHHONKFEHP> GDCBMINFLJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DFHEIEGNIJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> CNDIFCNGHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> EHHDGGOOMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
	public DFHEIEGNIJL(IReadOnlyDictionary<Guid, Guid> FNFFGBPPLEA, IReadOnlyDictionary<Guid, Guid> ICBAHCHHHBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KCEPCNGGEKM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NLLPDFAHGHK : IEnumerable<KGIKLNIIDMO>, IEnumerable, IEnumerator<KGIKLNIIDMO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private KGIKLNIIDMO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private OOHGDDKPAKK spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public OOHGDDKPAKK <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private OGJHFCPMHBA spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public OGJHFCPMHBA <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private KGIKLNIIDMO System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x90ECF0", Offset = "0x90DCF0", VA = "0x18090ECF0")]
		[DebuggerHidden]
		public NLLPDFAHGHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F480", Offset = "0x6E1E480", VA = "0x186E1F480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F750", Offset = "0x6E1E750", VA = "0x186E1F750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F590", Offset = "0x6E1E590", VA = "0x186E1F590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KGIKLNIIDMO> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F590", Offset = "0x6E1E590", VA = "0x186E1F590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BB20", Offset = "0x6E1AB20", VA = "0x186E1BB20")]
	public static OOHGDDKPAKK AGGJNHLBBKB([In] ECCMMDNGKEM HDNGDHKFGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E550", Offset = "0x6E1D550", VA = "0x186E1E550")]
	private static void FMPEKANDAPJ(OOHGDDKPAKK OIIFMHOHFLL, [In] ECCMMDNGKEM EHJEFELIOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CB20", Offset = "0x6E1BB20", VA = "0x186E1CB20")]
	public static OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK> DNFOFHMJBCC(OOHGDDKPAKK OIIFMHOHFLL, OGJHFCPMHBA NMDPJLNBBGO, EGDKNPFJADD? MALFOLJCJIG)
	{
		return default(OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ECC0", Offset = "0x6E1DCC0", VA = "0x186E1ECC0")]
	[IteratorStateMachine(typeof(NLLPDFAHGHK))]
	private static IEnumerable<KGIKLNIIDMO> NAPBCIIPKBD(OOHGDDKPAKK OIIFMHOHFLL, OGJHFCPMHBA NMDPJLNBBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EDD0", Offset = "0x6E1DDD0", VA = "0x186E1EDD0")]
	private static void NCFJAGMAFIH(OOHGDDKPAKK OIIFMHOHFLL, EGDKNPFJADD? MALFOLJCJIG, OGJHFCPMHBA NMDPJLNBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC50", Offset = "0x6E1DC50", VA = "0x186E1EC50")]
	private static void JHKJNFFBPIF(OOHGDDKPAKK OIIFMHOHFLL, OGJHFCPMHBA NMDPJLNBBGO, IReadOnlyCollection<ByteString>? OFMLKJAHINA, IReadOnlyCollection<ByteString>? PPFIILNLHKB, IReadOnlyCollection<ByteString>? DOGLPAMEOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C490", Offset = "0x6E1B490", VA = "0x186E1C490")]
	private static bool CFEDEPJPFDN(OOHGDDKPAKK OIIFMHOHFLL, PMEDDBIJCLE GLFECGFFAOA, OGJHFCPMHBA NMDPJLNBBGO, [Out][NotNullWhen(false)] string? IPLILPPMPOG, [Out] Dictionary<int, int> KFOAEIDKKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F070", Offset = "0x6E1E070", VA = "0x186E1F070")]
	private static Dictionary<Guid, EJBDPDAMOIO> OBKOOPAOMHO(OOHGDDKPAKK OIIFMHOHFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EBB0", Offset = "0x6E1DBB0", VA = "0x186E1EBB0")]
	private static void GFIJKLDOIJK(bool HLALKKOCMBI, KGIKLNIIDMO DBMIMADNHFB, Dictionary<Guid, Guid> APHGHJCPADE, EGDKNPFJADD MALFOLJCJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C150", Offset = "0x6E1B150", VA = "0x186E1C150")]
	private static void CCLCBMLIFAC(KGIKLNIIDMO DBMIMADNHFB, Guid JBNAGLIFCFP, FECDIAHCLHF? FHIBGPHDDLH, Dictionary<Guid, EJBDPDAMOIO> EKPKGCNOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BCA0", Offset = "0x6E1ACA0", VA = "0x186E1BCA0")]
	private static void AKMAANCNOIK(IEnumerable<KGIKLNIIDMO> COAKGOOPGLN, IReadOnlyCollection<ByteString> OFMLKJAHINA, IReadOnlyCollection<ByteString> PPFIILNLHKB, IReadOnlyCollection<ByteString> DOGLPAMEOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OGJHFCPMHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool HLALKKOCMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public PHBDFBFLGBL IANLAEECIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public FECDIAHCLHF? FHIBGPHDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public FECDIAHCLHF? PACGBKOOJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public GMNAMPPAFMB LKLPANGKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public DPINOAMDGJO KABIABNHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public ABNIHMOMACO DLDCLIODDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public OFIMKOOAMIG MMMHHGFJKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public GGKCCFNJFJC<OMEMEDNNNNN> GNAKPJEGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public BOOIFAHNHOE MODKFABOPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<KGIKLNIIDMO> FIKAGIKEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> CKHJEOPAHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public FINBDONGODN LMPOHJJKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool INNCGDPINKB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PLHJMNJPEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F820", Offset = "0x6E1E820", VA = "0x186E1F820")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FECDIAHCLHF
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float LCPANOGICIP = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 PAMMLHPIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion JKJHCABJJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float KBGFEDJHNAE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 JPPIIPDOPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B2D0", Offset = "0x6E1A2D0", VA = "0x186E1B2D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS ELIHKIGKIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AF80", Offset = "0x6E19F80", VA = "0x186E1AF80")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xF2D220", Offset = "0xF2C220", VA = "0x180F2D220")]
	public FECDIAHCLHF(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float KBGFEDJHNAE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B460", Offset = "0x6E1A460", VA = "0x186E1B460")]
	public FECDIAHCLHF(UniformTRS FPJOBPOFMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AC90", Offset = "0x6E19C90", VA = "0x186E1AC90")]
	public static FECDIAHCLHF COLLILAGKKF(FECDIAHCLHF JNLBEALAMNB, FECDIAHCLHF DLFLNHBNNCP)
	{
		return default(FECDIAHCLHF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AFC0", Offset = "0x6E19FC0", VA = "0x186E1AFC0")]
	public static FECDIAHCLHF ILBKFABDDDI((Vector3, Quaternion, float) CONAFKKIHKL)
	{
		return default(FECDIAHCLHF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AFE0", Offset = "0x6E19FE0", VA = "0x186E1AFE0")]
	public static FECDIAHCLHF ILBKFABDDDI(Matrix4x4 OABPNFBGCEA)
	{
		return default(FECDIAHCLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B3D0", Offset = "0x6E1A3D0", VA = "0x186E1B3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B1F0", Offset = "0x6E1A1F0", VA = "0x186E1B1F0")]
	public FECDIAHCLHF KMOMNMHEHAL(Matrix4x4 IMCFIOFNLHP)
	{
		return default(FECDIAHCLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AF10", Offset = "0x6E19F10", VA = "0x186E1AF10")]
	public static FECDIAHCLHF DPBDJLEDHGA(Vector3 PAMMLHPIJIB)
	{
		return default(FECDIAHCLHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B160", Offset = "0x6E1A160", VA = "0x186E1B160")]
	public readonly AMGGLIGKMHC KEJNMAGGNOB()
	{
		return default(AMGGLIGKMHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IGJHDPNFDAN
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E37C00", Offset = "0x6E36C00", VA = "0x186E37C00")]
	public static FECDIAHCLHF HOKIABIAOGD([In] this AMGGLIGKMHC GFJPFDOHONG)
	{
		return default(FECDIAHCLHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ACMLHHAODHA
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JAMACNPKBDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly PDMPEBKNJAG BMBBEAGMMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly HJOFKELFHOB LIPNPEJGPKL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x11B3E40", Offset = "0x11B2E40", VA = "0x1811B3E40")]
	private JAMACNPKBDK(PDMPEBKNJAG LLLGBHDHFFG, HJOFKELFHOB FHNLMABBGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E389E0", Offset = "0x6E379E0", VA = "0x186E389E0")]
	public EOAIFLFPKCG NDPIJCFAIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E38870", Offset = "0x6E37870", VA = "0x186E38870")]
	public static OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK> EJLELCHFLID(DAGAPCOEPEC<MKHCENILMPB> FHNLMABBGIG)
	{
		return default(OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E387C0", Offset = "0x6E377C0", VA = "0x186E387C0")]
	public static OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK> EJLELCHFLID(EOAIFLFPKCG FHNLMABBGIG)
	{
		return default(OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E38920", Offset = "0x6E37920", VA = "0x186E38920")]
	public static OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK> EJLELCHFLID(string DHMOFJBPGJC)
	{
		return default(OBFFLKDLIBJ<DFHEIEGNIJL, JAMACNPKBDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PDMPEBKNJAG
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KLIHAENHKAE : IDisposable, CENOEKKBPMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<JIGGBHLJOJK> NGPGOBOPHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float MOJDAPMNPHG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public COOHEFBPBIK GDHDCMLAPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
		[CompilerGenerated]
		get
		{
			return default(COOHEFBPBIK);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GMFCLEFCMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A360", Offset = "0x6E39360", VA = "0x186E3A360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JLMGNIGFOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E398F0", Offset = "0x6E388F0", VA = "0x186E398F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<OLFEEPPIMLJ> DKHMKACJFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int HJCAHALKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E39960", Offset = "0x6E38960", VA = "0x186E39960", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DGOKGPOFDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E3A890", Offset = "0x6E39890", VA = "0x186E3A890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B2A0", Offset = "0x6E3A2A0", VA = "0x186E3B2A0")]
	public KLIHAENHKAE(COOHEFBPBIK IECLEDMOCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E39730", Offset = "0x6E38730", VA = "0x186E39730", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ADD0", Offset = "0x6E39DD0", VA = "0x186E3ADD0")]
	public Vector3 PMPEHDMPLIJ(int GGBBONMHPBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ACA0", Offset = "0x6E39CA0", VA = "0x186E3ACA0", Slot = "6")]
	public Quaternion OKNKHLDCJKM(int GGBBONMHPBA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E39360", Offset = "0x6E38360", VA = "0x186E39360", Slot = "5")]
	public Vector3 BCFBLPIKAGK(int GGBBONMHPBA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E396D0", Offset = "0x6E386D0", VA = "0x186E396D0", Slot = "7")]
	public float DOEGOFDLNBE(int GGBBONMHPBA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E38A50", Offset = "0x6E37A50", VA = "0x186E38A50")]
	public void AJGDBPNEKKO(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float PEGACPFCNHH, bool LCFMJCFKLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E39900", Offset = "0x6E38900", VA = "0x186E39900")]
	private bool EJMDAAPIFIN(int ICFLKFLMNFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E39550", Offset = "0x6E38550", VA = "0x186E39550")]
	public void BLAJHIHLFEC(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A370", Offset = "0x6E39370", VA = "0x186E3A370")]
	public void KGFAGEBGIJC(int ICFLKFLMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E39400", Offset = "0x6E38400", VA = "0x186E39400")]
	public void BFBFPFINECA(int ICFLKFLMNFK, Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO, float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3AA20", Offset = "0x6E39A20", VA = "0x186E3AA20")]
	public void NKELCNLFMJJ(int ICFLKFLMNFK, float3 PAMMLHPIJIB, quaternion JKJHCABJJIO, float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A210", Offset = "0x6E39210", VA = "0x186E3A210")]
	public void KCNJDJKKJEG(int ICFLKFLMNFK, Vector3 PAMMLHPIJIB, float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E39790", Offset = "0x6E38790", VA = "0x186E39790")]
	public void EBNHJOHLMIK(int ICFLKFLMNFK, Vector3 LCMGGHKGECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E39A10", Offset = "0x6E38A10", VA = "0x186E39A10")]
	public static Quaternion FICANFGIKCN(Quaternion APDKCFMECLC, int ICFLKFLMNFK, float AHKCCPFNNEA, CENOEKKBPMN PBEMHELIHIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E3A400", Offset = "0x6E39400", VA = "0x186E3A400")]
	public Bounds MGAPJJCPIHE(Transform IMCFIOFNLHP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E399A0", Offset = "0x6E389A0", VA = "0x186E399A0", Slot = "10")]
	public virtual void FFJPLOKEGPO(bool LMMLDIJEBGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E3ABD0", Offset = "0x6E39BD0", VA = "0x186E3ABD0")]
	public NativeList<JIGGBHLJOJK> OBNCOKCGIFK(float EDFLCMJKFGF = 1f)
	{
		return default(NativeList<JIGGBHLJOJK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OLFEEPPIMLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 BFENJPJIDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float FFDPGNIGBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion GPMDDOOMBFP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D1A0", Offset = "0x6E3C1A0", VA = "0x186E3D1A0")]
	public OLFEEPPIMLJ(Vector3 JADOFHDDGIG, Quaternion APDKCFMECLC, float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E3CC50", Offset = "0x6E3BC50", VA = "0x186E3CC50")]
	public Quaternion CCLABEJAIHH(Vector3 IKMGCHAHKMB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E3CD10", Offset = "0x6E3BD10", VA = "0x186E3CD10")]
	public OLFEEPPIMLJ PECLLJHAKMO(Vector3 KMMPEGEMMLM, Vector3 CELFDIHBBFA, Vector3 EDBBBCJDAHH)
	{
		return default(OLFEEPPIMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D000", Offset = "0x6E3C000", VA = "0x186E3D000")]
	public KFGLHFDIMAG PGKAEMHNPPF(Vector3 IKMGCHAHKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class AMBNJEIMAKF : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E346C0", Offset = "0x6E336C0", VA = "0x186E346C0", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E33E70", Offset = "0x6E32E70", VA = "0x186E33E70")]
	private void BKAENLHMMCK(Dictionary<Guid, Guid> JFMJACLIDMN, NMGPNJJMKIB NPOJEEJPGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E33E10", Offset = "0x6E32E10", VA = "0x186E33E10")]
	private void BKAENLHMMCK(Dictionary<Guid, Guid> JFMJACLIDMN, BNKMFFDGFBF BBFANAJNBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E34440", Offset = "0x6E33440", VA = "0x186E34440")]
	private void BKAENLHMMCK(Dictionary<Guid, Guid> JFMJACLIDMN, HGKAECEKDDD PBNHAELOOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public AMBNJEIMAKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BJMCIHKKPLC : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E34830", Offset = "0x6E33830", VA = "0x186E34830", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public BJMCIHKKPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DOFDIPOOOGB : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E348E0", Offset = "0x6E338E0", VA = "0x186E348E0", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public DOFDIPOOOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OGMCKKOPDMK : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C940", Offset = "0x6E3B940", VA = "0x186E3C940", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OGMCKKOPDMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MGEACJPIGJI : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C720", Offset = "0x6E3B720", VA = "0x186E3C720", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public MGEACJPIGJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ICGOJDEBPMB : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E37A20", Offset = "0x6E36A20", VA = "0x186E37A20", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public ICGOJDEBPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class PJBFCIAEOHF : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D220", Offset = "0x6E3C220", VA = "0x186E3D220", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public PJBFCIAEOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BJEOMBAFFLA : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E34740", Offset = "0x6E33740", VA = "0x186E34740", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public BJEOMBAFFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OIGJCMOIBBB : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3CAA0", Offset = "0x6E3BAA0", VA = "0x186E3CAA0", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OIGJCMOIBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ECAFFGPLHLP : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E34A40", Offset = "0x6E33A40", VA = "0x186E34A40", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public ECAFFGPLHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LNMJKPHHBNC : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C620", Offset = "0x6E3B620", VA = "0x186E3C620", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LNMJKPHHBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class LACMDCCAJOI : FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly PGFHENJADFH IACGHGGFHBL;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B330", Offset = "0x6E3A330", VA = "0x186E3B330", Slot = "4")]
	public void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LACMDCCAJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IFFLOABKMEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public PMEDDBIJCLE FNBFBBNHKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public KGKCJPJFDGE AEIDFJKCCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> IJBKFKNBFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> EPEENFEMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public FINBDONGODN LMPOHJJKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool IHBCKLGPIIA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FHOCDONJILG
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAJFOLJKNOB(IDOKNJCLIJB NPGMGAMDPIC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EDBCHKENNGI
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly FHOCDONJILG[] OPOBEMCLBLL;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E354D0", Offset = "0x6E344D0", VA = "0x186E354D0")]
	public static void LBDBDHPIPPM(KGIKLNIIDMO CONAFKKIHKL, Dictionary<Guid, Guid> HDLCAOJAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E35240", Offset = "0x6E34240", VA = "0x186E35240")]
	public static void KIJJNLIGJKI(KGIKLNIIDMO? CONAFKKIHKL, EGDKNPFJADD CIFBKBGLLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E34BF0", Offset = "0x6E33BF0", VA = "0x186E34BF0")]
	public static void BIKLPDKOKCK(KGIKLNIIDMO? CONAFKKIHKL, EGDKNPFJADD MALFOLJCJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E34E70", Offset = "0x6E33E70", VA = "0x186E34E70")]
	public static void HHCGFMENJFC(IDOKNJCLIJB NPGMGAMDPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct IDOKNJCLIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public PMEDDBIJCLE KLBJLPIHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public KGIKLNIIDMO DBMIMADNHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> IJBKFKNBFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> EPEENFEMPFO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E37B60", Offset = "0x6E36B60", VA = "0x186E37B60")]
	public Guid PFBHPDCGMBC(Guid EEKOILIMLBO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FINBDONGODN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int KMIHOLOCMCG, [Out] Guid ACNFHGMNILP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class HKGFMNENEAB
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker JHGKNJKCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> ADPFGALNIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> EMEFEAHINBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> NKHPGAIGMJG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> FKEGOACHKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> KFFLMCKEJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E36DB0", Offset = "0x6E35DB0", VA = "0x186E36DB0")]
	public static HKGFMNENEAB MFIALFKCMAB(MEGLOJMOHAP EBLANDLJNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E36030", Offset = "0x6E35030", VA = "0x186E36030")]
	public static HKGFMNENEAB KKGDKOGJHNA(OOHGDDKPAKK BCBMMHGLHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E35D30", Offset = "0x6E34D30", VA = "0x186E35D30")]
	public static HKGFMNENEAB BMJBEBBMGDJ(IEnumerable<string> ADPFGALNIKG, IDictionary<long, int> HNFJGKHMKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E37410", Offset = "0x6E36410", VA = "0x186E37410")]
	private HKGFMNENEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E37530", Offset = "0x6E36530", VA = "0x186E37530")]
	private HKGFMNENEAB(IEnumerable<string> ADPFGALNIKG, IDictionary<long, int> HNFJGKHMKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E363E0", Offset = "0x6E353E0", VA = "0x186E363E0")]
	private void LKGMAJEACII(MEGLOJMOHAP EBLANDLJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E360A0", Offset = "0x6E350A0", VA = "0x186E360A0")]
	private void LKGMAJEACII(OOHGDDKPAKK BCBMMHGLHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E36E90", Offset = "0x6E35E90", VA = "0x186E36E90")]
	private void NDJNDBAOBEK(ByteString? POMKMCMIJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E36940", Offset = "0x6E35940", VA = "0x186E36940")]
	private void LKGMAJEACII(BMFHAPDBCMF? BAOAKGNNKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E362A0", Offset = "0x6E352A0", VA = "0x186E362A0")]
	private void LKGMAJEACII(EHGCIDBIDGP? CHMIAHGMJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E365E0", Offset = "0x6E355E0", VA = "0x186E365E0")]
	private void LKGMAJEACII(KGIKLNIIDMO? DBMIMADNHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E36E20", Offset = "0x6E35E20", VA = "0x186E36E20")]
	private void NCFAAHJKCNE(string? JPLICEEOAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E35EB0", Offset = "0x6E34EB0", VA = "0x186E35EB0")]
	private void CJKICJGKJLF(long COKBFGPAJIP, Guid HJJAGCKNGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E35FE0", Offset = "0x6E34FE0", VA = "0x186E35FE0")]
	private void CJKICJGKJLF(FEIMNDLPLMN? AIBGEKIEDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E35F80", Offset = "0x6E34F80", VA = "0x186E35F80")]
	private void CJKICJGKJLF(GBCBHBGEODM? AIBGEKIEDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LDAKAEFDGBF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IBHNAIJGFON : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> DIHCGFLIECM;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry HGLAPHAHNLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6E377F0", Offset = "0x6E367F0", VA = "0x186E377F0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object AEDGBICBIMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6E378C0", Offset = "0x6E368C0", VA = "0x186E378C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object DMNEEJMINJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6E37970", Offset = "0x6E36970", VA = "0x186E37970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object OEJFPPMIFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6E37710", Offset = "0x6E36710", VA = "0x186E37710", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
		public IBHNAIJGFON(IEnumerator<DictionaryEntry> DIHCGFLIECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E37670", Offset = "0x6E36670", VA = "0x186E37670", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E376C0", Offset = "0x6E366C0", VA = "0x186E376C0", Slot = "9")]
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
		private sealed class ABCOBHIIBHB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E33DC0", Offset = "0x6E32DC0", VA = "0x186E33DC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public ABCOBHIIBHB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6E33C70", Offset = "0x6E32C70", VA = "0x186E33C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6E33D70", Offset = "0x6E32D70", VA = "0x186E33D70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E3D980", Offset = "0x6E3C980", VA = "0x186E3D980", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object MLAECOMLIEC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D890", Offset = "0x6E3C890", VA = "0x186E3D890", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6E3DA60", Offset = "0x6E3CA60", VA = "0x186E3DA60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D7D0", Offset = "0x6E3C7D0", VA = "0x186E3D7D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D830", Offset = "0x6E3C830", VA = "0x186E3D830", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6E3DA00", Offset = "0x6E3CA00", VA = "0x186E3DA00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D490", Offset = "0x6E3C490", VA = "0x186E3D490", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D4F0", Offset = "0x6E3C4F0", VA = "0x186E3D4F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6E3D550", Offset = "0x6E3C550", VA = "0x186E3D550", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
		public RoomObjectCounts(Dictionary<int, int> KOGDIDFIEDO, [Optional] Dictionary<int, int> PHFAJDOHHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D3B0", Offset = "0x6E3C3B0", VA = "0x186E3D3B0")]
		[IteratorStateMachine(typeof(ABCOBHIIBHB))]
		private IEnumerator<DictionaryEntry> NBCGKOEHEBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E3DAB0", Offset = "0x6E3CAB0", VA = "0x186E3DAB0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D6D0", Offset = "0x6E3C6D0", VA = "0x186E3D6D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D5B0", Offset = "0x6E3C5B0", VA = "0x186E3D5B0", Slot = "9")]
		void IDictionary.Add(object MLAECOMLIEC, object BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D610", Offset = "0x6E3C610", VA = "0x186E3D610", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D670", Offset = "0x6E3C670", VA = "0x186E3D670", Slot = "8")]
		bool IDictionary.Contains(object MLAECOMLIEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D770", Offset = "0x6E3C770", VA = "0x186E3D770", Slot = "14")]
		void IDictionary.Remove(object MLAECOMLIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D430", Offset = "0x6E3C430", VA = "0x186E3D430", Slot = "15")]
		void ICollection.CopyTo(Array CHPMBGHOEJI, int KHAIDMGPIED)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class IMCIOOMANPK : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E37E50", Offset = "0x6E36E50", VA = "0x186E37E50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public IMCIOOMANPK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6E37CC0", Offset = "0x6E36CC0", VA = "0x186E37CC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6E37E00", Offset = "0x6E36E00", VA = "0x186E37E00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E384E0", Offset = "0x6E374E0", VA = "0x186E384E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object MLAECOMLIEC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6E383B0", Offset = "0x6E373B0", VA = "0x186E383B0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6E38590", Offset = "0x6E37590", VA = "0x186E38590", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6E382F0", Offset = "0x6E372F0", VA = "0x186E382F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6E38350", Offset = "0x6E37350", VA = "0x186E38350", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6E38530", Offset = "0x6E37530", VA = "0x186E38530", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6E37F70", Offset = "0x6E36F70", VA = "0x186E37F70", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6E37FD0", Offset = "0x6E36FD0", VA = "0x186E37FD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6E38030", Offset = "0x6E37030", VA = "0x186E38030", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x22E7910", Offset = "0x22E6910", VA = "0x1822E7910")]
		public Invention(long JHCIODFGPNM, int DCEOMHJEBBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E37EA0", Offset = "0x6E36EA0", VA = "0x186E37EA0")]
		[IteratorStateMachine(typeof(IMCIOOMANPK))]
		private IEnumerator<DictionaryEntry> NBCGKOEHEBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E385E0", Offset = "0x6E375E0", VA = "0x186E385E0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6E381B0", Offset = "0x6E371B0", VA = "0x186E381B0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E38090", Offset = "0x6E37090", VA = "0x186E38090", Slot = "9")]
		void IDictionary.Add(object MLAECOMLIEC, object BJDKOHEGDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E380F0", Offset = "0x6E370F0", VA = "0x186E380F0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E38150", Offset = "0x6E37150", VA = "0x186E38150", Slot = "8")]
		bool IDictionary.Contains(object MLAECOMLIEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E38290", Offset = "0x6E37290", VA = "0x186E38290", Slot = "14")]
		void IDictionary.Remove(object MLAECOMLIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E37F10", Offset = "0x6E36F10", VA = "0x186E37F10", Slot = "15")]
		void ICollection.CopyTo(Array CHPMBGHOEJI, int KHAIDMGPIED)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GABEMOMADFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> JDHPLDGIIHF;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public LDAKAEFDGBF(IReadOnlyDictionary<Guid, RoomObjectCounts> KEIJCDLDDNE, IReadOnlyList<Invention> AIHHKHGIANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B460", Offset = "0x6E3A460", VA = "0x186E3B460")]
	public static LDAKAEFDGBF MFIALFKCMAB(MEGLOJMOHAP EBLANDLJNLN)
	{
		return default(LDAKAEFDGBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C500", Offset = "0x6E3B500", VA = "0x186E3C500")]
	[CompilerGenerated]
	internal static int OPFCPCNAFKL([In] IReadOnlyDictionary<long, int> JKMDPGECFIN, long? COKBFGPAJIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BE40", Offset = "0x6E3AE40", VA = "0x186E3BE40")]
	[CompilerGenerated]
	internal static void NAJBNFDJCBP(int OBOIFICGAJH, [In] BMFHAPDBCMF KPBNAGMJMDC, [In] Dictionary<long, int> JKMDPGECFIN, [In] Dictionary<Guid, RoomObjectCounts> KEIJCDLDDNE)
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
