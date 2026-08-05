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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F80670", Offset = "0x6F7FA70", VA = "0x186F80670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PEPIOAPJBLA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> ENGAMDLFDBA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> ICKPAFEAPCO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> MHHJPEMBMKH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> AJCOGGFNINB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KEGFHNEFNOL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string ELIEBMKPFNC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string EPFOMBPANMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F80E70", Offset = "0x6F80270", VA = "0x186F80E70")]
	public static bool MBALLJIKIMP(Guid KAFEGGECLCF, int LOBAPENPMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F80DE0", Offset = "0x6F801E0", VA = "0x186F80DE0")]
	public static bool LEDHPAEIGOP(Guid KAFEGGECLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F80760", Offset = "0x6F7FB60", VA = "0x186F80760")]
	public static string APJILCOHCMN(Guid FNECNONNEND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JJCGKLGILPA]
public enum PKIMLHHKNKP
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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F801B0", Offset = "0x6F7F5B0", VA = "0x186F801B0", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BCEDLAFKJIB
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid LLLKBFOIAEF;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid NHPGIGGOMCD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid GKLMPPMCJHD;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid BOMCJMEPMLM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid KOJAOBKBGPA;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid EKHGAMKHIEB;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JBGIPLEKLKG;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid PELCHOMKLFB;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid MFIDAJINLLB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid GPIOBFMBLGM;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid JHPLOLNGHMO;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid AOCOINDLIFF;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid PLMHEALLLJG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid HIGNEGPBDKH;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid PLHEEGHDDOO;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid LPGDNMIPCBM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid LDGCFDAOBLP;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid DCNDDJGJDAC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid FNMDBAJOBLP;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JNDFEDDPHFP;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid NINCCCCLEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid DBBPCIECMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid PNHINLFPBAC;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid LOJNLNALPMA;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BLGBFFHPDHI;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid NFKNACPBCGB;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BBHFGGGHOLL;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EMIEDCKONCJ;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GJEPDEGOPDD;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KMPPHHIEAFJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CBCMEKNICNO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid HGHNLCEEAFI;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid NEEJKIEDBMN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid HCNGJNKLFBO;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid NKMHEAJAHMJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid GLPDPPBILEM;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid AKKPBDCPBOJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid BADONIHALOM;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid COEMLCBBEAM;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid CDCMHKDGKPI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid KGGPPNOLIPL;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid IFFOLMJHOCO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid HPOCDPLAOAP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HKNCKJIHLDB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid NFKLNDFKJHD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid KMEFFEIABKI;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid BNJPPOHNLOL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid COEHBANKBNB;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid MPOIFEBDFHH;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid JOBJKIHLONI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FCGLFOLGLBI;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GDBBMCNCIHM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GEGMMGLFABO;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DFPNJIMGPCC;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CGAIKIPNPDP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid IGOELHCJIII;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid HLLHEDOJGDE;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid OCKFADKPONC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid BAAIAGNBBMP;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid OIDPKFFNGCF;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid BMMBJMHBHNO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid IHFOIFAJJJC;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ICAJKGFIKLB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid AIPNBGDCJEI;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid KMJIMMKJOAG;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NPGIKLLBNBF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid LKHJKNHGKBI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid OCHPKJHEGGD;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GKPDOIBPCND;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid GHLNCPNKCFD;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid AKICNPICGPE;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid LCKABPMLCOJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid EDELIMOMFEB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid PKIDIPMIDCO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid IPNEIHONLFG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GIDFJFGFHPA;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid EICCFNOKMLJ;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid IMLECLMFOPE;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BBDBEBCLHNN;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OLPEKPHANGH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GDIHBKNLJBB;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid ICCKPKKADLB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid NHDNAFADGKC;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GCEMNLPCJCF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OKNBAJKHJAE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid DFDINICLGJG;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid PNDHGFPHJKD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid HGHMPCDNAIC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid BACIBMDOBEB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid BMOGMFKJJOH;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IHGIALAFEHO;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid PDJCKGGEGMO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid MIACBIEAHBO;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid LLIAEPFJLLD;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid DNMEFCPEILI;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid OPEEPHPDCAB;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid PCLOMJIMNBI;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid KKOKNEJNMBJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid ALFEPPOFKOM;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid BDALOBJKOJK;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EPHJPMEMNHN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid ELMEDGEEOMN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid GFHDGDJGPNL;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid LJABNBEDBCJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid IJPDKEPGBLO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MFHODJHMAFN;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid FBGADJJNDPP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JFOHIEBCJDI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KNIHGAKNLCB;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid CEPPHKJFCEB;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid FNHMAEPFGPL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JJPAHDHPKGK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid HBEPHFKAKJM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid OKDGCNMACEB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid CEFCOBLKEGD;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid MFIIJKKMBDC;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IPNDECLALDE;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid ODCNCAPMHBL;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid ICDPHAMHPMN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid BLNCKAONAMF;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid JCNJMFKAJCG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid GCCJIHKMDMN;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid OBJIIDBFKDA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid KOAIIMNDKDI;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid MPOFPLGDFHJ;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid BMPFLBCKCDM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid NBAGOOJPCNG;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid GPFJNBGAFJK;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid JKBKBGLJIHC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid AEAIHBHELMG;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid JFHGFNNFBHL;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid KEBCEONDOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid ANOKFPBFEPE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid DGAKNLGALFK;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid IGNMDBLJFNB;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid GDIHBMFOAFM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid GCNILKLAFAE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid JHGNCLJLONO;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid DMCBBLBAOLL;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid PMBAIOANLHF;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid DLIKHOGHMJA;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid HAMINFFJOGO;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid FGIAEDDOFDG;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid JICEBICLDAK;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid CNKCHCNKOCP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ECBGLPIDJNO;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid GJPCAAMHHKO;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DGBEMJHAMKM;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid KLDIHCBDFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid FMNAMAAOGBP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid EPJBAKPAHHH;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid IAOADOJMDBG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid BCCDNJHGAKP;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid ONICPCIIIKI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JCJFKNOGOOA;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OMCJIMEDIKF;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid MMGEMOAAEFG;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid KIJFMDCPOAN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid MKDDDOMIMNM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HAANGPHNCJA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid CMOFGJMAPMF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MGKKDONPELD;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AMFFMJHCFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid EAMMCJJICEH;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid NLKDFJOPMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid PFDOHDBFPJE;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid MKPPGDLJDFP;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid BCNAHCPJMDE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NMIKNNKHPKG;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid GKODAGICEOO;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid CAFPPDFKFLN;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid AAHFLEBPHLO;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid OLOLDBIOIPD;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FFDNFNLHJHN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NONIGOBDIHK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid MKCGOPMAIOK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NILHLJJBMDE;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid DGJAJIODIHD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid DILMDEDGPFI;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PDFAONGJAMM;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DIBIEKKMIJG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid FFHJHDOKAOP;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid GBOLHFAAGBK;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid CILOIKFKFPK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid FGPEOLIGACE;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid ABMMMGIAPDB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid MHOKDMHFCEE;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid LCJIPHAJEBI;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid JHPHHOHANHM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid IDPPBMKGIGC;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GAMANPGAOKP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid CGAILKLNGPK;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid DKPKJBODJNC;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid GNIOJMMIDPC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LHPIKJHENDL;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid GCCPNDOLIOA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid NLMFAOKDDOL;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid EIOHEOGDOMP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid EGEMLHOIJJL;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid KJMFALCIMHM;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid LDDHPJBJIMN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid AAKAHAJINAI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid FOBHGMIGPFN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid NGKHJJGCCLE;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid JAFIHACAPDL;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BPJKOEEMAAD;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid CFBOMDGOOCD;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid HODICJDELPI;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid ONGGBPLMMNF;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid LFPDBBLGJIP;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid MNFMPMKIGAK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid HIPDIJKABHJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid FHPPFJIFPFK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GMGDHCPDPPE;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AGNHBIIHDNG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid AJFMCNGJOLP;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid DEJFGFMBGGD;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid DLBJDJIFONM;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid IJFMCJMEFMM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CNIACKBLMFA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid AMHBFIPPDJA;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid ODCOMPMBIMA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KBMBKNFNGJD;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ABDBHGHCHGK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid BKNGDFCIMKF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KFEPIFIDCGI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JIOCHIGFELC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid IOGAEGEBKOP;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid EJHGIINPDMP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid EENOBMOHLFM;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid DCDGDKAODKG;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid EIFIEMDCEFB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid MOHNDOJCHOM;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid PCFIAGGDHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid ALOPLCMDGPP;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GNCMFMDKBLG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid KKIHPJNKBPK;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KDCGAKIEJAI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PGPNJENCFIG;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BAOAJEBKGEK;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GEKHACHMBFJ;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid BGCEEOOJIFI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid AOBFLMOIFAD;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid IGHHMCFBKKC;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NBFLCMDFLLP;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid AFLCCIDJKBM;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JNLCAJMAAIM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MGGIPDIDGMM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MNJGNGMJFBC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid GAOJBKBAPGI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KACDMNJHODP;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JGMFKMEDPJK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid MMIEONJIENN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid AHKAGOEKHEL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid FMNFPHPJNPA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CAFJOLFCEIG;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid MBMKOMLPBND;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid IEEDOGMCFME;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid OMKCHGNCCAJ;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid PCKEADDINPL;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MDOHKHNAPGO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DDIEHEOLKFC;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FHLAIOHPEGE;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BCKPEOGMFOI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid CIDPLKHOIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FKEAKEFIEJB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ONMPBOAJMAF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid FBECLPADIGI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid PAMDKCELDNF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PJJJKDDDNAP;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid IJBCMEDDEON;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LJOAIKLGDPD;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid JNCPNBEBJMM;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GNGMHOBMOBA;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid GILFBGJDHCA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DNOKKLLMAEF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid CPLPNCNONPL;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid MNCBKIPFBEG;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid KIEJMBFIFPK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DJEMCMCGIGG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid PGJLEHPJCPC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CGIGFDPOKKE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid DJNKICDPCFE;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MIAOCBADELH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CLANNONIJGL;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DFKNFGNMLMI;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid BOIHBPAKPIB;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IEMBKEJGJMH;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid AHFMCNOIIPO;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid ONHJLOKLBBJ;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid HPLJHAMJMJA;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid MIKPPBDGAHP;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HNMKONBFFNP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EPAFGIHOFDB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid FDNAGDKEOPP;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid JADNLGEFKMC;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid BFAFJEPNFBP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KJCMMKHFAFI;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid MCPBKGBPCCN;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JGDGNPIOKCK;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid MMLEDDCHOED;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GGNGILMBLHH;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid NMBLLINMICG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid PFKNKLIOAJM;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid EOADEEOGLJO;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KLLIJHIEIGN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid LAPIKCEOOOO;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid JCIFCPKJNII;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid MIJCDCPKOOI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LMEMLFBEELF;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LKEAHHMHFNA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OMFDJAEEODD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid IEJLBPNDAKJ;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid IAJHPCCPNKH;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GOOLKICGNJJ;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid DJAPNLHJOFE;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NBDJHEJGGMO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid EFMEHLDJEMM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GOLOKCMOAPK;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PPMHOAKHOJB;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid AAFCGGKEPKN;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid LMHOMFIJGDA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid OAJIJEDMGHK;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JJJCHPPONKO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JFHPDFDEFJB;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid PDFLPJOOPHL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid LFMHFPCEJPF;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid KNJHIAMIMGE;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KHEGOMAMAMK;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid NEOCIOCPPIE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LGKOACBDELD;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid JDEKMLPGFNB;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BBNOIOHOOFI;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NFIEKJMHPLK;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid BAMKFPOIINJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid KFLOAFJAPPP;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EAGFNLGJBIK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid BJOBILFMPNI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ACLDBAANBHP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid GADACKAADID;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid CEOAIIGNAOG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid JEOKMLFCGEC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid DMIONKNEJKL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid EFFJENANJOJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid IMCCJJGAAGJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid CPMNFCOEKPN;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid BCLKFIFPFGK;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid KLINPDCACLJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid BIPPIGOPGEK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CDEFJHPEECK;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid CELKIKLAJHG;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid GHGFKOAHIIE;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid BNBECIJAMCG;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CDCGKBPBMGN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid DKJMELIFLNH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LDPJGMLADFF;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid JNFNEKKPPFE;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid IJGAMBDBHJF;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KKFDMBFJHOF;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid MPJBABGKJOE;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid GHFOBENPGEP;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid LGONGLIPOOP;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid LJLKIDMDHGP;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid CPNGNOBGPKO;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid EFIAGJDKJNA;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid IEIKJBCFHJC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HFDOENANJLF;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid AJFDCKFJEOP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid EPIKEDNFADB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid POFIHIIOEMO;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JFGGKJGKFIM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid NKLHGJJEEBP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid OOEJDEKJHLM;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FAHBNCKANBD;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CNGAJGOEPHG;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LPHEOHOPABN;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid OHOHBKFKIKM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid PIODCMNGOGG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid ILHOLLOFPEC;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid LNOBIPKKKKJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid CPFKIEDIADA;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid IBBDLEJFBNG;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid JALPEMEMHDO;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid ENBAPAMPMNO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid OFFHDLAJOOD;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PCNPDCEPBEM;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IPCNBPIFEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid PBJNHGHFLNF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid JHBOOCEMFDE;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BMNMLFDFFMK;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CFGNKMNEANP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid JBMFMJKMKKF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid BHPBBHAFLHE;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FMLCEOLHDFH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid JHPFJGOHBLL;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid NDMMCNCDOKD;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid MEODJLOHBHG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid HABKNBBILNI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DOKGMFBBNBC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid MHDDFPFONLB;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GENJOBMKDAK;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid IMGMJHICEEK;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HNPJFCFKHPF;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid OLCBJAMIPKK;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid FMNHEKBNPNC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GKCHPHFNFII;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid JKKKJFMCLPM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HLJJHLKBLEB;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HOCIDJEEMKC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid KBHGMPJGGJB;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid OOMFNOMICMN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid GEGBEAILJJD;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid CPAGLNKLJBF;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid OKLMGIKEFGF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FHJEACOHPEC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid MBPGCEDNOKH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid INAGBJIJEMO;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid LBLKLLFNBNN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid BKMHNFCCMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JAHCIMOMODA;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid NIEFFCDOMLM;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HEPNKMJBBGM;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid JOJBDNHKAIG;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid AJEDJIDFEOE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid EMNFNCNDBAM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid DCCHABBOGEC;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid MCLFPODGGFF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FFNEOAHAJPI;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ODNJHLACGGI;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid OPPNEDPMFMM;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid PCNNGCMLJFF;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid DOMMLKKEEJI;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid JNBENFMJJOJ;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid LDAKPMOENKK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AGBKEBHGDBN;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid KFNAAMGJDFC;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid INKJJHOJHDM;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid BNPDOGBCEAE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid DMOMPLBHNCN;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JCAFHFGPICO;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OLFOFCGBOHK;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid GIGKKHBABNI;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid CIGBPCMCIJE;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DEOEJKLLHBO;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid ENNEEOLHJLG;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid ADCLONBMIMJ;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PMHDFMLIMPF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid MNJBJOFEMEF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BHBKFLNNLOC;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CPBMLMLLFMK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LFBGOMFHAML;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid FLINAPEPDJM;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BBDLDLINOAF;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid LHIFPGNOPNF;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid NODAKCMKCMC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LNDOBGKAGLO;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid IJDMGNECLOG;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid DDDENIKDMJF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid BGDJOBEEMKM;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid BCHHAMAIIPC;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid HDJNEMFLNKF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid EJPJPHAJNLJ;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DLKMHDIHEEI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GHDKFKNJBJE;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid KIBONAFGHLJ;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid CIBOLLJMGOD;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid HNBAJNGDBGD;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid AAKKHFOKJKC;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OPLGFICILOO;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid GDCMJFFJCHI;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid NOGGOFMPOCH;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GDIKEIDDOLE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PEHKCOKFHDO;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid FOHMHOMJEIE;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid GDJHELFEOPO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JIBGKGBGAMF;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid LNOHIIAPHJI;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid IDFKAAAENBF;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid FFEAADGLPKC;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid OKDAFHIMCHA;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid KHJPJFJCMAP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JBEICPDNHHA;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NMMJOEIFELH;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid MEGJBEOBCMI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid JMGHHANLFCC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid CIGEMNLJNEB;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid HECOBFOMBCP;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid IGENMLIGJON;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid MDOAIAOJDNL;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid EIFALOIDEBD;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EJDEDLAEMEN;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid GADJJHIGJHC;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid PLGFFOBNAIP;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid AGFECJMBBEO;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JLHCFBPIOOF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid LIJKFFHBOKO;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OLDLNLMHMDE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GDGGJNCKAAF;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid DHIFOPOPHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid ABEJLHPBEBE;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid CKDLOCDEECP;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid PDHGIIGHGDH;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GJDGECEGCGO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid KNPONNIEDEH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid HKLOLMABAAC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid JMPENGJBADA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid GPGGHDJHBNB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid MMLMIKCAKNP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BBKMJIPNCLB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PKHEHMMAKNI;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid JIDMDMIADIK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid CBANAGHJEHF;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid PLPLAKBAGBJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid LLOBCFIEEPL;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid NGFLFILINHL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid FINKAJNBOHP;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid CCHHOCAFHPO;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OFODFAGIOIH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MDPBICNCMOK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid GNHOCPFEBPL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid DPCDDGJAIMN;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FEMGFAMJJAN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BNEPJNDLNMN;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid OJIGGALNNEC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid HCAMAAOKBLL;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid IAJIEPGDCHI;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid JHDIJKJLGIF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JLMBNNCIPMK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PPMFNADNNBE;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid HBIHOMKCEME;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FBKDCEGOOPC;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid HFMDEACGELB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HNOBOELDGLP;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid ALJFCBEDNEL;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid PBPOGAMFKJA;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid ODOICDCHCFP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DDDBMFOLCNL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid AJFJFEGGAGN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DIIJJHJCKJP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BEDILNJOCHI;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid ACNGGPLAOCH;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid CJILHEMGMGG;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid HIMCAFDDMBB;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid HGMMNDEAJIK;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid CAMMKJEAJIP;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid GGAOOLCFBOD;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid CFDCONDEANC;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid BEMECEJCEGH;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid HKICJHCHDOI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid IKONEFLAKEB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LADONFOGLKG;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid LLDFMDDBBLG;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid MPCEHBAJPOB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid MEFMPGIONJN;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MKFPJDGDCOO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid EFPAOOINFBJ;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid LHPFNIMELJI;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid MPCEFODAJHE;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid ENNGKADGAGF;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid MFODBLOIOEF;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid PNABKHEIIFA;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid EIDKKCIKEOA;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid ELEEHODCNDM;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid FDIMDPADFEK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid IBNEJBDIDLN;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid DFBHLABFHOL;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid HJMGPALKEOJ;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid OKGPCDDDDFJ;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid JBFPLDMABNB;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid JCDIAKIGKJA;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid BDAJOLPODEA;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid LHFPHJJPLFC;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid MENLILIJLJL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MJDEBIPIIGP;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid ANINGPDENKA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid DJKDHONEBLL;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid DAEFMDBPPCB;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid BGFPOHPLMAD;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid JFKEODDIGMB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid CEHJBNOIPDO;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid HPHGJPIGAFO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid AMDJPKCBFFM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid ICBBNLNBLJK;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid FMJIDLLJKNO;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid LGFHGLLBMGF;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PMECDAMDDJD;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid EEHIMDOBFLE;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid NIGJBKCLOAP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid ENBJNOLKJPC;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid BKLFBENBLOO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid MPPJIHBDFFD;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid CCPGNLMAGDE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid HFBMKIMKFGJ;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid KNGEDHICOPJ;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid NCMGMDGJAHM;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid CLPIBNFEFFB;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid KEFPHEGEAGM;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid GCCNJGHAAKM;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GAMLKFPJGPH;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid MGDIKEPJDOG;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NOMMNCDMDPJ;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid GIADGDBIMCI;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid FMKPBIFGOCA;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid JCOAKAJFKPA;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid JKHMADFDADN;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid OMGPHDECIKI;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid JCJBCHBIOOH;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid JECNCMDINFI;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FJPMGKLGDON;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid OIGCIJFJJCG;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid AEDKEKHJNOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid MCEEHKEFOMG;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid EMGMKDGJAEG;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid ADPACDHGDDG;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid HOBOEFHBLLN;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid NFKPKOEGOHK;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid MIKOEGJENAJ;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid PFBILGECALC;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid MMOOOIAJAGA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid KECMHAFEFNI;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid JEFJHOFGONO;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid DPIJCPGDMPJ;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid KHKFPGNBDDO;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid GJALBKGCHCA;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid NAGDCHJFEBP;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid IPIOMMGKBFO;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, PKIMLHHKNKP> DINBBEGJEJM;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<PKIMLHHKNKP, Guid> BEIDBHMEDNE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, PKIMLHHKNKP> ILCALIPMKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B610", Offset = "0x6F6AA10", VA = "0x186F6B610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<PKIMLHHKNKP, Guid> NGFPFABMOKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B660", Offset = "0x6F6AA60", VA = "0x186F6B660")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPOLJMGOBOO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F80640", Offset = "0x6F7FA40", VA = "0x186F80640")]
	public static bool GAABALMONIL(FGDCBBIHJPP LPBLMGMBLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F80290", Offset = "0x6F7F690", VA = "0x186F80290")]
	private static bool GAABALMONIL(GDCNFDIBHNF AIGKLGGBPNP, FGDCBBIHJPP LPBLMGMBLHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BKPODGHPGOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly GKJHJDKELLF HCHNLCPEBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<CGBJPDKLJAK> MNPJFHKMJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<CGBJPDKLJAK> EDLJPLOMDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly AHPCDKCOAJM<PNODKKHPFBO> LCEECOGBNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<PBDBGAKNNHI<AMFCOJIMJGL>> PFCDGCPCGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString KMINCDMELKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly CIJDAANHOKH LJCEAAHNLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool PKIENCHKMAP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F6B6B0", Offset = "0x6F6AAB0", VA = "0x186F6B6B0")]
	public BKPODGHPGOE(GKJHJDKELLF EBPOLOFFMLH, IEnumerable<CGBJPDKLJAK> BNECGPCNHPJ, IReadOnlyList<CGBJPDKLJAK> IPCJPEIGAAO, AHPCDKCOAJM<PNODKKHPFBO> HDCHPLOFPMJ, IReadOnlyList<PBDBGAKNNHI<AMFCOJIMJGL>> MLGEGLCEINB, ByteString JAOFBOMKCEI, CIJDAANHOKH EEEBKDEJDEA, bool CGJGDDGPOKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ABGFJFDFGMM
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(MKLIEIHNHLA JGCOLLOOLHL, [Out] Dictionary<int, int> NMMJBOANBLF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KFBEOIPGGLH PIAMNJGMHFI, HJKGJPEGBOD EAPBOMPGKFH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HBMJDMALKJF : OKFBGDAOOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid NEOPGJGEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> KBHHCAIHOLF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> CPPLGFDHEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
	private HBMJDMALKJF([In] Guid CBKCHPIBNAB, Dictionary<Guid, Guid> JGPFNOGPAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F250", Offset = "0x6F6E650", VA = "0x186F6F250")]
	public static HBMJDMALKJF ODOFIFAGLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EC30", Offset = "0x6F6E030", VA = "0x186F6EC30")]
	public static HBMJDMALKJF GBFBJAABCDN(IReadOnlyDictionary<Guid, Guid> NJNKILBHKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EF30", Offset = "0x6F6E330", VA = "0x186F6EF30")]
	public static HBMJDMALKJF IKODJIKANGG(IEnumerable<KeyValuePair<Guid, Guid>> NJNKILBHKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F2E0", Offset = "0x6F6E6E0", VA = "0x186F6F2E0")]
	private static Dictionary<Guid, Guid> PNMCMDKBPJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ECB0", Offset = "0x6F6E0B0", VA = "0x186F6ECB0")]
	public void IKLAEJHDAAG(IReadOnlyDictionary<Guid, Guid> NJNKILBHKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EAD0", Offset = "0x6F6DED0", VA = "0x186F6EAD0")]
	public Guid BNFHFDDFGON([In] Guid FNECNONNEND, bool EKPHKOPCBJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EC40", Offset = "0x6F6E040", VA = "0x186F6EC40")]
	public bool HPMEEMMEGKL([In] Guid LPMIIFILJPI, [Out] Guid ILGMPKNCIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EC40", Offset = "0x6F6E040", VA = "0x186F6EC40", Slot = "4")]
	private bool NBKPFPHDEGA(Guid DOELFDCMLHC, [Out] Guid LJFKJHDEOPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPALPFADALE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NPJNGPAAGID
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBLFJIABLOP(ByteString NEENHFHMFPH, HBMJDMALKJF JGJJEOKFONG, [In] UniformTRS HFMIDHKPIIL, Space OMOGDKDBANE = Space.World);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LKIGJCCBCMF
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
public sealed class KKHAOPBLCJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OAGEEDLDOJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public GKJHJDKELLF staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OAGEEDLDOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F806F0", Offset = "0x6F7FAF0", VA = "0x186F806F0")]
		internal AHPCDKCOAJM<CCPDCNPKMEJ> BHKLJIBBFNL((AHPCDKCOAJM<PNODKKHPFBO> GraphId, AHPCDKCOAJM<AMFCOJIMJGL> NodeId) i)
		{
			return default(AHPCDKCOAJM<CCPDCNPKMEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private static readonly GLJFFNDGJDM<CCPDCNPKMEJ, int?> BOABMPJAOPO;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static readonly long BJDBDKHHCPO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F72B10", Offset = "0x6F71F10", VA = "0x186F72B10")]
	public static (long, long) IAHFMCNKBGO(GKJHJDKELLF LIBAKGBJBEP, AHPCDKCOAJM<PNODKKHPFBO> PAAPGLCPIFD, AHPCDKCOAJM<AMFCOJIMJGL> DOKBOJKBDAO)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F72F40", Offset = "0x6F72340", VA = "0x186F72F40")]
	public static long NMFOBKCGHEE([In] ReadOnlySpan<AHPCDKCOAJM<CCPDCNPKMEJ>> INKLMJJPOGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F73060", Offset = "0x6F72460", VA = "0x186F73060")]
	private static long NODLMEFMFKM()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BAMAAIHCDKK
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<PKIMLHHKNKP> AHBHBDIDJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HIDFPFBIOCA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> FNNCNKLABND
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> GJHJNLEHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public HIDFPFBIOCA(IReadOnlyDictionary<Guid, Guid> CLEIHAPOBDJ, IReadOnlyDictionary<Guid, Guid> IDELCIJPMNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HNHPIMIALAI
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CJPPKCDPMLI : IEnumerable<CGBJPDKLJAK>, IEnumerable, IEnumerator<CGBJPDKLJAK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private CGBJPDKLJAK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private KFBLPGHHNAO spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public KFBLPGHHNAO <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private MKGNHOAGOJM spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MKGNHOAGOJM <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private CGBJPDKLJAK System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
		[DebuggerHidden]
		public CJPPKCDPMLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B740", Offset = "0x6F6AB40", VA = "0x186F6B740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B9F0", Offset = "0x6F6ADF0", VA = "0x186F6B9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B850", Offset = "0x6F6AC50", VA = "0x186F6B850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGBJPDKLJAK> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F6B850", Offset = "0x6F6AC50", VA = "0x186F6B850", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F390", Offset = "0x6F6E790", VA = "0x186F6F390")]
	public static KFBLPGHHNAO CEOMPIAMFBG([In] BKPODGHPGOE CPMNKFEDIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F70AB0", Offset = "0x6F6FEB0", VA = "0x186F70AB0")]
	private static void PBBAMIGGHPM(KFBLPGHHNAO NGOHFOCFAGL, [In] BKPODGHPGOE NGEGEFPLJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F71110", Offset = "0x6F70510", VA = "0x186F71110")]
	public static ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC> PDELINOLEOJ(KFBLPGHHNAO NGOHFOCFAGL, MKGNHOAGOJM GNCNOKILEGH, HBMJDMALKJF? EALIJEFMKKL)
	{
		return default(ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F500", Offset = "0x6F6E900", VA = "0x186F6F500")]
	[IteratorStateMachine(typeof(CJPPKCDPMLI))]
	private static IEnumerable<CGBJPDKLJAK> GGICBLHEJKF(KFBLPGHHNAO NGOHFOCFAGL, MKGNHOAGOJM GNCNOKILEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FAB0", Offset = "0x6F6EEB0", VA = "0x186F6FAB0")]
	private static void JOCJGFHOCIP(KFBLPGHHNAO NGOHFOCFAGL, HBMJDMALKJF? EALIJEFMKKL, MKGNHOAGOJM GNCNOKILEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FCF0", Offset = "0x6F6F0F0", VA = "0x186F6FCF0")]
	private static void KJKNPOGDHDD(KFBLPGHHNAO NGOHFOCFAGL, MKGNHOAGOJM GNCNOKILEGH, IReadOnlyCollection<ByteString>? CBLPGDDOAJD, IReadOnlyCollection<ByteString>? BPGGPNPGLFO, IReadOnlyCollection<ByteString>? OJNGHOIEAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FD60", Offset = "0x6F6F160", VA = "0x186F6FD60")]
	private static bool KLACIBNHBFK(KFBLPGHHNAO NGOHFOCFAGL, KFBEOIPGGLH PIAMNJGMHFI, MKGNHOAGOJM GNCNOKILEGH, [Out][NotNullWhen(false)] string? PLAICKAFAFJ, [Out] Dictionary<int, int> NMMJBOANBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F70730", Offset = "0x6F6FB30", VA = "0x186F70730")]
	private static Dictionary<Guid, GDCNFDIBHNF> NJNAIBJENAD(KFBLPGHHNAO NGOHFOCFAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F70A10", Offset = "0x6F6FE10", VA = "0x186F70A10")]
	private static void ONLGNGDENOK(bool CJLEOPMPNMI, CGBJPDKLJAK MMJPLOBEPHL, Dictionary<Guid, Guid> GGPDNHMDJCI, HBMJDMALKJF EALIJEFMKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F703F0", Offset = "0x6F6F7F0", VA = "0x186F703F0")]
	private static void NDILGDNHOJJ(CGBJPDKLJAK MMJPLOBEPHL, Guid PHAPCMPPFPA, GGMLOLICOND? ODGKJAALFPE, Dictionary<Guid, GDCNFDIBHNF> JKGBCCNIOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F600", Offset = "0x6F6EA00", VA = "0x186F6F600")]
	private static void JACMELLOBJN(IEnumerable<CGBJPDKLJAK> NBJJPDFOHLC, IReadOnlyCollection<ByteString> CBLPGDDOAJD, IReadOnlyCollection<ByteString> BPGGPNPGLFO, IReadOnlyCollection<ByteString> OJNGHOIEAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MKGNHOAGOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public bool CJLEOPMPNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public CIJDAANHOKH EEEBKDEJDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public GGMLOLICOND? ODGKJAALFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public GGMLOLICOND? DPNMJIIIINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public GKJHJDKELLF GHNEKKECBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public LKIGJCCBCMF NJKGAPNGNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public ABGFJFDFGMM LIEGKEDHEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public LPALPFADALE EKBOEBDIGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public PBDBGAKNNHI<PNODKKHPFBO> KNNLIAAOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public KCEKFMOEPNL LJPIKOALBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public List<CGBJPDKLJAK> BOAEGGFNALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public Dictionary<string, object> DNMACFNAHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public HJHEKPNLCHK PNJMMIMEMDM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KIOIJFMOJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F80240", Offset = "0x6F7F640", VA = "0x186F80240")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GGMLOLICOND
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private const float AKBCODALIAG = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Vector3 CPGMOBFHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Quaternion CBCAIPELAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public float BMGLFPFGJFF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Matrix4x4 ANLHGCBLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E4F0", Offset = "0x6F6D8F0", VA = "0x186F6E4F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public UniformTRS OIAAGLKKGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E230", Offset = "0x6F6D630", VA = "0x186F6E230")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xF26A60", Offset = "0xF25E60", VA = "0x180F26A60")]
	public GGMLOLICOND(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float BMGLFPFGJFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EA00", Offset = "0x6F6DE00", VA = "0x186F6EA00")]
	public GGMLOLICOND(UniformTRS PJCEOOMCCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E270", Offset = "0x6F6D670", VA = "0x186F6E270")]
	public static GGMLOLICOND CDHLKDCFFEF(GGMLOLICOND AMMKPAGCALK, GGMLOLICOND EKFAJIDCOPB)
	{
		return default(GGMLOLICOND);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E8C0", Offset = "0x6F6DCC0", VA = "0x186F6E8C0")]
	public static GGMLOLICOND IDKOEJANABA((Vector3, Quaternion, float) JGCOLLOOLHL)
	{
		return default(GGMLOLICOND);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E740", Offset = "0x6F6DB40", VA = "0x186F6E740")]
	public static GGMLOLICOND IDKOEJANABA(Matrix4x4 LNPCKDOPEHA)
	{
		return default(GGMLOLICOND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E970", Offset = "0x6F6DD70", VA = "0x186F6E970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E660", Offset = "0x6F6DA60", VA = "0x186F6E660")]
	public GGMLOLICOND DLGBKNNKCGI(Matrix4x4 KELFOJAPBEF)
	{
		return default(GGMLOLICOND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E5F0", Offset = "0x6F6D9F0", VA = "0x186F6E5F0")]
	public static GGMLOLICOND DBFHEHOLLEH(Vector3 CPGMOBFHDAC)
	{
		return default(GGMLOLICOND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E8E0", Offset = "0x6F6DCE0", VA = "0x186F6E8E0")]
	public readonly FLFBBNJJMEH IJMGGGMJMEA()
	{
		return default(FLFBBNJJMEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum NFGFEJGKBFP
{
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PJCEOLDNHNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly EPAELINPOAI IJBNJPNGFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private readonly NAONGKGFBLO BBAOILJHMBI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x11A7440", Offset = "0x11A6840", VA = "0x1811A7440")]
	private PJCEOLDNHNC(EPAELINPOAI HBOEBNCIJMJ, NAONGKGFBLO JPADJJHLFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F81EB0", Offset = "0x6F812B0", VA = "0x186F81EB0")]
	public MIFFFGJILCH FDKHHGCIFIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F81F20", Offset = "0x6F81320", VA = "0x186F81F20")]
	public static ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC> ODOFIFAGLAJ(CFHFIFBGCNK<ALHKDJHEAFJ> JPADJJHLFIM)
	{
		return default(ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F81FD0", Offset = "0x6F813D0", VA = "0x186F81FD0")]
	public static ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC> ODOFIFAGLAJ(MIFFFGJILCH JPADJJHLFIM)
	{
		return default(ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F82080", Offset = "0x6F81480", VA = "0x186F82080")]
	public static ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC> ODOFIFAGLAJ(string POAIMKAKFBI)
	{
		return default(ABNAGONECLM<HIDFPFBIOCA, PJCEOLDNHNC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EPAELINPOAI
{
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DHIPCCCLPBG : IDisposable, LPLOOLNENLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private NativeList<LMKDMCGCAOO> AGDCKMMAAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private float ENEDKOABDIK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MCBOHJAEBBG NMFEKNPDLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0")]
		[CompilerGenerated]
		get
		{
			return default(MCBOHJAEBBG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool FOCAEFOPCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E190", Offset = "0x6F6D590", VA = "0x186F6E190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LOCDNHAMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BD50", Offset = "0x6F6B150", VA = "0x186F6BD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public List<DEOANEJKNIN> LOFCJCJCMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int DNNNECGKMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F6D030", Offset = "0x6F6C430", VA = "0x186F6D030", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float OBGMLJHAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F6BA40", Offset = "0x6F6AE40", VA = "0x186F6BA40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E1A0", Offset = "0x6F6D5A0", VA = "0x186F6E1A0")]
	public DHIPCCCLPBG(MCBOHJAEBBG OBCABLKNBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BCF0", Offset = "0x6F6B0F0", VA = "0x186F6BCF0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D070", Offset = "0x6F6C470", VA = "0x186F6D070")]
	public Vector3 KNGEANDFLPN(int DEFGGFLHDDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BB80", Offset = "0x6F6AF80", VA = "0x186F6BB80", Slot = "6")]
	public Quaternion BKHGEHGILPG(int DEFGGFLHDDI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BC50", Offset = "0x6F6B050", VA = "0x186F6BC50", Slot = "5")]
	public Vector3 BMHIFAIBDCJ(int DEFGGFLHDDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C480", Offset = "0x6F6B880", VA = "0x186F6C480", Slot = "7")]
	public float IJFNEDMNMCM(int DEFGGFLHDDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C5E0", Offset = "0x6F6B9E0", VA = "0x186F6C5E0")]
	public void KIAPPNOENCA(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP, bool HNNJCFCBOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BD60", Offset = "0x6F6B160", VA = "0x186F6BD60")]
	private bool GAFNCNFPLEE(int BMHEFIHIJJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F6CED0", Offset = "0x6F6C2D0", VA = "0x186F6CED0")]
	public void KLINFCCHNAA(Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C550", Offset = "0x6F6B950", VA = "0x186F6C550")]
	public void JNNOCGAHNIC(int BMHEFIHIJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E040", Offset = "0x6F6D440", VA = "0x186F6E040")]
	public void NEKBCFFDAHF(int BMHEFIHIJJJ, Vector3 CPGMOBFHDAC, Quaternion CBCAIPELAJP, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D540", Offset = "0x6F6C940", VA = "0x186F6D540")]
	public void LAMKNJAOHCH(int BMHEFIHIJJJ, float3 CPGMOBFHDAC, quaternion CBCAIPELAJP, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D6F0", Offset = "0x6F6CAF0", VA = "0x186F6D6F0")]
	public void MBHOIHMLNGE(int BMHEFIHIJJJ, Vector3 CPGMOBFHDAC, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C250", Offset = "0x6F6B650", VA = "0x186F6C250")]
	public void HBHBDJHCHDA(int BMHEFIHIJJJ, Vector3 ADDIIGBEIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F6D840", Offset = "0x6F6CC40", VA = "0x186F6D840")]
	public static Quaternion MDHHMLLAHEF(Quaternion GIOBPCBFDIE, int BMHEFIHIJJJ, float GPHHGLFJIPO, LPLOOLNENLA JHGABNDOANN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F6BDC0", Offset = "0x6F6B1C0", VA = "0x186F6BDC0")]
	public Bounds GPBJDFMHFCJ(Transform KELFOJAPBEF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C4E0", Offset = "0x6F6B8E0", VA = "0x186F6C4E0", Slot = "10")]
	public virtual void INCEICEEMEK(bool JFKHLPJBFPI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C3B0", Offset = "0x6F6B7B0", VA = "0x186F6C3B0")]
	public NativeList<LMKDMCGCAOO> IHHCLMBEIID(float HBFMIMKNHMF = 1f)
	{
		return default(NativeList<LMKDMCGCAOO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DEOANEJKNIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public float3 FGALHLKMLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float KOFPJFICEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public quaternion NPNGGENHGHO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F82A80", Offset = "0x6F81E80", VA = "0x186F82A80")]
	public DEOANEJKNIN(Vector3 MIIBBEPBJLP, Quaternion GIOBPCBFDIE, float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F82530", Offset = "0x6F81930", VA = "0x186F82530")]
	public Quaternion GABIKJGPDGF(Vector3 LIDLBHGKPBN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F82790", Offset = "0x6F81B90", VA = "0x186F82790")]
	public DEOANEJKNIN JIIKEFMALOF(Vector3 NKDCDMLJDPL, Vector3 HKNKMOEJNAI, Vector3 JIOCMICCELF)
	{
		return default(DEOANEJKNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F825F0", Offset = "0x6F819F0", VA = "0x186F825F0")]
	public ODCKHFAKBGM GPJNIKNLLDI(Vector3 LIDLBHGKPBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ELOEFAGNIEM : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F84CE0", Offset = "0x6F840E0", VA = "0x186F84CE0", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F84490", Offset = "0x6F83890", VA = "0x186F84490")]
	private void HJDBPCNDLFN(Dictionary<Guid, Guid> AJLLIGGEEBN, AJFONPPLOPM IICGABJOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F84430", Offset = "0x6F83830", VA = "0x186F84430")]
	private void HJDBPCNDLFN(Dictionary<Guid, Guid> AJLLIGGEEBN, NLDPCFOFOLG FCLBNEFMDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F84A60", Offset = "0x6F83E60", VA = "0x186F84A60")]
	private void HJDBPCNDLFN(Dictionary<Guid, Guid> AJLLIGGEEBN, MMHFINCLOBB NOHIJOLELJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ELOEFAGNIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class KKNIAMDFMEA : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F87410", Offset = "0x6F86810", VA = "0x186F87410", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KKNIAMDFMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class OPGJPLKBLCF : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6F88B60", Offset = "0x6F87F60", VA = "0x186F88B60", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OPGJPLKBLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class FAOILFLACLL : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D60", Offset = "0x6F84160", VA = "0x186F84D60", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FAOILFLACLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class CLDNJPCFNHA : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F82310", Offset = "0x6F81710", VA = "0x186F82310", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public CLDNJPCFNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IHLHEIODFAN : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F86910", Offset = "0x6F85D10", VA = "0x186F86910", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public IHLHEIODFAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LHJDFNCMLJP : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F874C0", Offset = "0x6F868C0", VA = "0x186F874C0", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public LHJDFNCMLJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FLGCBBJFEMC : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F84EC0", Offset = "0x6F842C0", VA = "0x186F84EC0", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FLGCBBJFEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MOFKIKFPEIG : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F87800", Offset = "0x6F86C00", VA = "0x186F87800", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MOFKIKFPEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MGHHNOHHIFL : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F87650", Offset = "0x6F86A50", VA = "0x186F87650", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MGHHNOHHIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GMHOEKJGIIE : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F862D0", Offset = "0x6F856D0", VA = "0x186F862D0", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GMHOEKJGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BJOIEALGCPB : IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public static readonly PJMPPAAJMHJ OLLCCHOIIAM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F821E0", Offset = "0x6F815E0", VA = "0x186F821E0", Slot = "4")]
	public void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BJOIEALGCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FGDCBBIHJPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public KFBEOIPGGLH GKEHKEEIHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public CIIDELJIHKK FKINAPFGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public Dictionary<int, int> IPAFIJPGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<Guid, Guid> NIOKNKFAEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public HJHEKPNLCHK PNJMMIMEMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public bool KJPBBFANAPK;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IEMGMMMLMFI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEAJMCNPJBD(KIBMHNAEFKM JFCJEEBHLKC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GMGFICOMNMC
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly IEMGMMMLMFI[] DDNPFMNCCOA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6F85190", Offset = "0x6F84590", VA = "0x186F85190")]
	public static void DJLNMBFAFIL(CGBJPDKLJAK JGCOLLOOLHL, Dictionary<Guid, Guid> MIBAJCPLJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F85420", Offset = "0x6F84820", VA = "0x186F85420")]
	public static void FLCOFALEDBL(CGBJPDKLJAK? JGCOLLOOLHL, HBMJDMALKJF PEBDKIBLKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F85A80", Offset = "0x6F84E80", VA = "0x186F85A80")]
	public static void GBJBFBDKMHM(CGBJPDKLJAK? JGCOLLOOLHL, HBMJDMALKJF EALIJEFMKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F856B0", Offset = "0x6F84AB0", VA = "0x186F856B0")]
	public static void GAABALMONIL(KIBMHNAEFKM JFCJEEBHLKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KIBMHNAEFKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public KFBEOIPGGLH EEBFGJNPNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public CGBJPDKLJAK MMJPLOBEPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Dictionary<int, int> IPAFIJPGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<Guid, Guid> NIOKNKFAEME;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F87370", Offset = "0x6F86770", VA = "0x186F87370")]
	public Guid DJPGADFBPGO(Guid FNECNONNEND)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HJHEKPNLCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EFKHHDMAOBK, [Out] Guid IIJNFOPNGOC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class EJCDMFDDOCE
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly ProfilerMarker NPDHIKGNHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private readonly HashSet<string> LHEKCMOKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly Dictionary<long, int> NPENBPDDECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly HashSet<Guid> ABPMDNPDKEA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IReadOnlyCollection<string> LLIEHEAHOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IReadOnlyDictionary<long, int> LIOFPLDFFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F82B00", Offset = "0x6F81F00", VA = "0x186F82B00")]
	public static EJCDMFDDOCE ACFKFNAOCKC(HGOBDFLLNNB JOMOCOIMIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6F840A0", Offset = "0x6F834A0", VA = "0x186F840A0")]
	public static EJCDMFDDOCE PHDHNOLDELJ(KFBLPGHHNAO LPCAFGABAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F82B70", Offset = "0x6F81F70", VA = "0x186F82B70")]
	public static EJCDMFDDOCE BJALDMAGBAK(IEnumerable<string> LHEKCMOKOMJ, IDictionary<long, int> MNMNAPBBJIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84310", Offset = "0x6F83710", VA = "0x186F84310")]
	private EJCDMFDDOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F841D0", Offset = "0x6F835D0", VA = "0x186F841D0")]
	private EJCDMFDDOCE(IEnumerable<string> LHEKCMOKOMJ, IDictionary<long, int> MNMNAPBBJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F830E0", Offset = "0x6F824E0", VA = "0x186F830E0")]
	private void GKIGGJCDJBC(HGOBDFLLNNB JOMOCOIMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F82EE0", Offset = "0x6F822E0", VA = "0x186F82EE0")]
	private void GKIGGJCDJBC(KFBLPGHHNAO LPCAFGABAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F83BE0", Offset = "0x6F82FE0", VA = "0x186F83BE0")]
	private void NFOHMJENGIA(ByteString? JAOFBOMKCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F832E0", Offset = "0x6F826E0", VA = "0x186F832E0")]
	private void GKIGGJCDJBC(CEILKCBGBFD? NIMLNKDMKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F83AA0", Offset = "0x6F82EA0", VA = "0x186F83AA0")]
	private void GKIGGJCDJBC(GAMAOEIHHFE? AJLPJFOPFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F83740", Offset = "0x6F82B40", VA = "0x186F83740")]
	private void GKIGGJCDJBC(CGBJPDKLJAK? MMJPLOBEPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F82CF0", Offset = "0x6F820F0", VA = "0x186F82CF0")]
	private void DJHFBMKJEIC(string? PKIJDPGDGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F82E10", Offset = "0x6F82210", VA = "0x186F82E10")]
	private void GBLIDODJANM(long KMMEAJEAKJI, Guid FACCECBBPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F82D60", Offset = "0x6F82160", VA = "0x186F82D60")]
	private void GBLIDODJANM(KECGNJMDPEP? MNADLIHJFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F82DB0", Offset = "0x6F821B0", VA = "0x186F82DB0")]
	private void GBLIDODJANM(AJDPGJBAJCJ? MNADLIHJFGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OEHIJLILJEM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class HFCDNINGGBM : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private readonly IEnumerator<DictionaryEntry> LGHHOJKALAL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public DictionaryEntry BOHKGECOJBO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6F86550", Offset = "0x6F85950", VA = "0x186F86550", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public object ECHGIIKNGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6F86610", Offset = "0x6F85A10", VA = "0x186F86610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object GFHLLJBPNAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6F866C0", Offset = "0x6F85AC0", VA = "0x186F866C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public object DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6F86470", Offset = "0x6F85870", VA = "0x186F86470", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
		public HFCDNINGGBM(IEnumerator<DictionaryEntry> LGHHOJKALAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F863D0", Offset = "0x6F857D0", VA = "0x186F863D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F86420", Offset = "0x6F85820", VA = "0x186F86420", Slot = "9")]
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
		private sealed class HNFICOOBHCD : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6F868C0", Offset = "0x6F85CC0", VA = "0x186F868C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public HNFICOOBHCD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6F86770", Offset = "0x6F85B70", VA = "0x186F86770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6F86870", Offset = "0x6F85C70", VA = "0x186F86870", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F89290", Offset = "0x6F88690", VA = "0x186F89290", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IDictionary.this[object LDCKBFKFIKC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6F891A0", Offset = "0x6F885A0", VA = "0x186F891A0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6F89370", Offset = "0x6F88770", VA = "0x186F89370", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F890E0", Offset = "0x6F884E0", VA = "0x186F890E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6F89140", Offset = "0x6F88540", VA = "0x186F89140", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6F89310", Offset = "0x6F88710", VA = "0x186F89310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6F88DA0", Offset = "0x6F881A0", VA = "0x186F88DA0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6F88E00", Offset = "0x6F88200", VA = "0x186F88E00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6F88E60", Offset = "0x6F88260", VA = "0x186F88E60", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
		public RoomObjectCounts(Dictionary<int, int> JMPLBDMHADD, [Optional] Dictionary<int, int> NFIHKIPHPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F88CC0", Offset = "0x6F880C0", VA = "0x186F88CC0")]
		[IteratorStateMachine(typeof(HNFICOOBHCD))]
		private IEnumerator<DictionaryEntry> CKBBJHFCDON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F893C0", Offset = "0x6F887C0", VA = "0x186F893C0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F88FE0", Offset = "0x6F883E0", VA = "0x186F88FE0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F88EC0", Offset = "0x6F882C0", VA = "0x186F88EC0", Slot = "9")]
		void IDictionary.Add(object LDCKBFKFIKC, object HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F88F20", Offset = "0x6F88320", VA = "0x186F88F20", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F88F80", Offset = "0x6F88380", VA = "0x186F88F80", Slot = "8")]
		bool IDictionary.Contains(object LDCKBFKFIKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F89080", Offset = "0x6F88480", VA = "0x186F89080", Slot = "14")]
		void IDictionary.Remove(object LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D40", Offset = "0x6F88140", VA = "0x186F88D40", Slot = "15")]
		void ICollection.CopyTo(Array CHDCMIMONFN, int IIACLAMOIEE)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class FOJAEBILFFG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6F85140", Offset = "0x6F84540", VA = "0x186F85140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public FOJAEBILFFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6F84FB0", Offset = "0x6F843B0", VA = "0x186F84FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6F850F0", Offset = "0x6F844F0", VA = "0x186F850F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F87090", Offset = "0x6F86490", VA = "0x186F87090", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IDictionary.this[object LDCKBFKFIKC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6F86F60", Offset = "0x6F86360", VA = "0x186F86F60", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F87140", Offset = "0x6F86540", VA = "0x186F87140", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6F86EA0", Offset = "0x6F862A0", VA = "0x186F86EA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6F86F00", Offset = "0x6F86300", VA = "0x186F86F00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6F870E0", Offset = "0x6F864E0", VA = "0x186F870E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F86B20", Offset = "0x6F85F20", VA = "0x186F86B20", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F86B80", Offset = "0x6F85F80", VA = "0x186F86B80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F86BE0", Offset = "0x6F85FE0", VA = "0x186F86BE0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x231A600", Offset = "0x2319A00", VA = "0x18231A600")]
		public Invention(long LPMIIFILJPI, int ABPDJOGPHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F86A50", Offset = "0x6F85E50", VA = "0x186F86A50")]
		[IteratorStateMachine(typeof(FOJAEBILFFG))]
		private IEnumerator<DictionaryEntry> CKBBJHFCDON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F87190", Offset = "0x6F86590", VA = "0x186F87190", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F86D60", Offset = "0x6F86160", VA = "0x186F86D60", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F86C40", Offset = "0x6F86040", VA = "0x186F86C40", Slot = "9")]
		void IDictionary.Add(object LDCKBFKFIKC, object HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6F86CA0", Offset = "0x6F860A0", VA = "0x186F86CA0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F86D00", Offset = "0x6F86100", VA = "0x186F86D00", Slot = "8")]
		bool IDictionary.Contains(object LDCKBFKFIKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F86E40", Offset = "0x6F86240", VA = "0x186F86E40", Slot = "14")]
		void IDictionary.Remove(object LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F86AC0", Offset = "0x6F85EC0", VA = "0x186F86AC0", Slot = "15")]
		void ICollection.CopyTo(Array CHDCMIMONFN, int IIACLAMOIEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> IHMNOLFONIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyList<Invention> ILFMMCCKNPM;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	public OEHIJLILJEM(IReadOnlyDictionary<Guid, RoomObjectCounts> PFAKCMLHPCB, IReadOnlyList<Invention> PBLHLNAFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F879B0", Offset = "0x6F86DB0", VA = "0x186F879B0")]
	public static OEHIJLILJEM ACFKFNAOCKC(HGOBDFLLNNB JOMOCOIMIGC)
	{
		return default(OEHIJLILJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F88A40", Offset = "0x6F87E40", VA = "0x186F88A40")]
	[CompilerGenerated]
	internal static int KOOOABECIOK([In] IReadOnlyDictionary<long, int> AHDOAHBIKCE, long? KMMEAJEAKJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F88390", Offset = "0x6F87790", VA = "0x186F88390")]
	[CompilerGenerated]
	internal static void JEBIHBDCPOO(int FOFMBKPGENL, [In] CEILKCBGBFD GCAHECHGLFG, [In] Dictionary<long, int> AHDOAHBIKCE, [In] Dictionary<Guid, RoomObjectCounts> PFAKCMLHPCB)
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
