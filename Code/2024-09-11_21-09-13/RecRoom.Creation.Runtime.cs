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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AF9060", Offset = "0x6AF7660", VA = "0x186AF9060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HDOKLJJOPAF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> EILJKBIDFOJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> MALFBDNKGBH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> PHFGCAKJOAF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> HIPCOCPANGL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string AHLIBFNNDEB;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JOPFKHLHMPK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string OBHEJNJNGDB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2ED0", Offset = "0x6AE14D0", VA = "0x186AE2ED0")]
	public static bool MGIJJGNPGGC(Guid KMNLJKKADGG, int BLOGGCFNENL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AE27C0", Offset = "0x6AE0DC0", VA = "0x186AE27C0")]
	public static bool DNNLBCKOCPE(Guid KMNLJKKADGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2850", Offset = "0x6AE0E50", VA = "0x186AE2850")]
	public static string MEBALMPAGOP(Guid GDCMEHKEAMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LPHINGJEECL]
public enum JPHBPNIDNGG
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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8FD0", Offset = "0x6AF75D0", VA = "0x186AF8FD0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PJONCAPEBAG
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HDKOKCLFDLF;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid PKODJFNFJAO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KBFIIGJGKNA;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid LHCDLJPAAKN;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BDDMLDMKOGH;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid PLLCHIAGOHH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid ODPCJKEENHG;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid ONMKGGDKLFL;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid ICMMFAGLHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid IGPOOHFDHNK;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid MFPDDOJHLPC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid KENGLLKDBIE;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DNONOPMGCBG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LCBKGHPOBID;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid BFCHCBJAHHM;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid GIJNBHPPEMI;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid MIGDCPBGPJA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid OIGKMFNDOHA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid CPGFJIDOFDP;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JEFJBFIHGBG;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid CHHLBIOLCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid MGFPPHFHOEC;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid OJDPALGLFHC;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid ILLMJNOMBLF;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BCHIHGBJFGK;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid BKGEMHFOLNP;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MACNPJMKABP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid BFFBLKGHCBB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IPGEPPHFIFM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid DJGEFAHOHKO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid HNNEJAMDEJN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EONIFEHFKLM;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid GNALKJBNBMO;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid EAGBNEMMHJJ;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid FEOGNNOKAJL;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid BNKIGNAKLBB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BLLOEMPGAJG;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid BKFIPJOGLMJ;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NCHAADDGDKF;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid FEGKPAGNBAH;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid DIPBHCFIFKP;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OCOLPPMMHCC;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid BABMFDJGGKE;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid IEMGOEOBGGO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid BCHFELDNNBF;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid DDGBPIBCANJ;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid IBEHPMMKIPM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid PCPOMLMAMND;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid MNNLKMEPNMI;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ICCBBBPHGCE;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid DLFBFLAALHF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NANFOLDDHPN;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GDBLLEAEHOB;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid EPOKFLGCJJG;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid LNBIJBICLDP;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid CJCLOOEKOOA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid AFPPDJJLLOM;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid OAAKCLENOFA;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HFFPHMGAACF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid DOCIKOJPMOL;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid MFLJNCMGHEM;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid GBCPGBFBALP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GPGJHMOMIKB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GFIBJAIPJFP;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid ICDKHFIIDKC;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JDDAMFHEJDF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid PMIFFJFBJPD;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid GHLLCBGCBFG;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid FAONCEOGDDI;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid BKBDHNCEBFD;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid HAJNLIEMAHA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid ECFKOMNADKJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid IHACCIHEOHE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GFLHEGFAAMF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid HMBBGFMIEFN;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid CKGEDMDOPHG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid IILOKBFMHGO;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid HIGKOPBMPGO;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid EEAIPLKDOMN;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid LGDAJAOMIIA;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JFEKMMPPDHA;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid FEBKBMGCICK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid HCPHLNEGNFK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid LNMBNPCMNNA;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GPKLMIPKCGB;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid MLGMGBCIFFM;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid PBJOKPJEFOM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid BGFFOBJEFOD;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid EKALIIAMCIK;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid CICMJCLNJEK;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid OMBOOODMENF;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GLPAFLHIEBP;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid DHHDHCAOALK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid JBBJGCFDBLJ;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid CFDENINPLOG;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid DKLHKHBDCKC;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid DNBGPBHACML;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid FPHEKJMAKJI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid HJALBAGFEKB;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid ANGBCCPFPLF;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NGCGKCBLKEE;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid FAACIAIIKBG;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid ACDFJMGDIJI;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid GIDLPDELPJE;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CPACLEEPKBG;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JODJHIMBFDC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GGJGBLMBOJL;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NGJEAEAFGFI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid OGMAGAOBKDB;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid BIHDKOOEJOG;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid BBENAJEALAL;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid EOHLBHIKJMB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PLDHMMNLEEI;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid DHCHFLDHGHO;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid NOLBKAJDILN;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OLGKGJJJACJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid HPBLGFKBEDC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid COJANFNHEII;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid ADNDBFCLDDC;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid GFBFAJKLIFE;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid DGOLPCOMJEN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JKNODJPEMPG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LMHJDHIJBHF;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid DHKODLKLGGG;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid NDJCBNJGMLD;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid FHNOAOODLKA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid BFJKKHOAAOE;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EOPNEPCCOIA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid HMELBNGDIJJ;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid HKBHFBFCOMK;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid DBJJHLGLBNB;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid LALFKLPJHGI;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LFGBMFMMFII;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid JPDPKDNFPHH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid KLDEBMAIFEF;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CNDJMEADPPL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PJNKJHOINPP;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid OJEEGGBFODF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JMPKKMJFBGI;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JKIMFNMCEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MFOFPOJDHAN;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ODMFLDBIAGO;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid PAAECIBIMPG;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid BICFJOJFGAI;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid GIOJNMMJPCL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid FIDPMNNPKLF;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DKDMFOADFAN;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HGBGMJHMKLP;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid ELJGKPBCPIE;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JDAAFJDNMNP;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid MNOMOCBBLLM;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FNLHGAEBPGP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid CJECNFBEFEN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid IKJHKKKAABJ;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JGAKAPIHIAK;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid CBOJFKINPBA;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid EFKJHCKFFGF;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HFMICIHCEBM;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KEOKPAAOHPE;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid EFPHAMCBLMB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid EPIHEHOMKIL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MOIIOOBNNBO;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid PJAAOKBMOKE;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid DENAEPCPNBI;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid AEJALBAGFKN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IMPIFAGOGBM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid FFFDOODFNEG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid LFHBIAMFOCB;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid JHPHILKOICO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DFMKIKEJMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid FBAAEODBKGK;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid NFGMHNEEFBD;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid JEHBLECKOHG;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid GLGGGOOKONG;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid PBKNLEAOBGI;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GOPNHANMKPN;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid ACDDJIEGMOF;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid EHHECFBAIGA;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid LMEKKCHHJEB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HCAIIIBBOMO;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid FDKJOIKBFPE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid AFMGDLKGGIE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LNCGHDLMAKM;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid NFEJMFOJCBM;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid AIDFPEDNMAF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid JPDLFACGMPG;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid HBIHEBPIOLE;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NOHDJEOLPKH;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid MDNIOFKAMHB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid ADPOPGFBLBF;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid ABDIAIAJIJH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid IAGJEGAKCMA;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid CICKILBAGCG;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid OCHEPOLKADE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid KJMCJPCOBJP;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid HHNMONNEKPO;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MDPDNCOIMDO;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid FHGKMLHKHGP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DLFGKDNNKKO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid NBFKPIKIPKP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid LIBFEJMKAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PDHJIMGOJPM;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid EKDNKPMIEJL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid GGKDMHCKGEN;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ILBDPGHFJMP;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid AONKCNCANFJ;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid HKJBLHHHIKJ;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid NPLDALDHDCN;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OEPKKBMKGMI;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JEOJGJCDABI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid HNHAODMEECE;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CIIBBGNKMLC;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid IANIGCDCFPI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid JFGGHAOFHDO;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid MKDCCEFBPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid KGCBDDOALKM;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IGAAFKGJHPG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid NPJPELEEBEA;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid MANEEBGJCKL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CEAJEDDKINA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid GGEGFPHPJMA;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid LPMAFJDELEA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid IOCFPIKEFJB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid OAKGNCFPGDP;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid DMMAEKFBKHC;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BAOFKIGPCNN;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FIGLKKJGJKN;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ODLADADFFOE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid IEMALCLOLFL;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid BPJOJEIJJFB;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid AELMHDFFEEF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid BIMJKIPLIEA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FMJEAOLAMIG;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid DLNAOLOLIFA;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid IGPMFCFHNED;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid IMODPKIGKME;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid IFMHMBEKBCN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid MMJHBEMGDHM;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid LDLKMHLHHPA;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid ELFFLLKCKEN;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KKPLIIGAANP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OFBGHCGCENO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid FCOACPINILA;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid IHFMIJEBMAK;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid BEOKCBILFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid GBAJMLHLFEM;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid PILGBEBMAGK;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid NADCNNKJKLA;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid OKJBOEIEDKG;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BGLFKFLJNON;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid AELMFACPKLM;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid JCBPMJGDCIB;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid NAPLNCEJMAK;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid GEJFKCNBMFO;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid NMONEJBJEGC;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PIJCMOPHPAA;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid DEMPGGGNCPJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid EGOGEAACBGH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid GNBCNPOJJDH;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ACOMOHMFMGP;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid AFFANIGMHKA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid LIBGMFGKAOE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid GOOBMLMNIPK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid LCMOFPMLMIC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KNOIPAIDMJM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid EIFEICPEKII;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NAFIOODBDAI;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AINIEFINCGB;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid MMMHCDHICJP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PPNEHFJJHFE;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KFBAOLPICCE;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HBIBCEPKFEF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MHIPPPAJIBB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid KEBDLJDKBCJ;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid DGLEHJIMOPE;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HLOHOPBFCEM;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid MCAGBBCDHDD;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid NDMDFAIBHML;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid EDDNNIEDBBI;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GEHGDBDFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NAIIGMAKPOB;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DELJFJDPJHB;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OGEDFLPCKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KCNNGMLLGOI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid DICECJAFNGK;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HMCDIJPDKKH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LOGOBADBDJL;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid KJMELDHLADO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BGCPICHHIPI;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid PLJBKLEKKKG;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid HGHIHCCEDNK;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid FFJCNDCNANL;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NFKAOICJECG;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid NKEPGBADMCG;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LJLDEKAIOBF;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid FMDLNHLLKOB;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid AHIFDDIHFBD;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PLFEGNKJBHK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CKMCEJHMHNJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid BOAPCGEMMMG;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid NBAIMLGLOEL;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MGEPMLFMKHC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid CEEPJAGGBNK;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OIFKNIDAJEK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LMGPPJJECBC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid ECKLOIIEPCD;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid GJMGGEDDOMG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid INCPNLHELCJ;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NMMGHIEBHID;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid FBCJABAGGCB;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid AGKGKIJGFEN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid DFLAFCHIDAO;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MLNFHOPCDNK;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ELNICPJHMLE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid PBJNCPPPOEK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid DMOLBCDGNME;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid NDELEDAOOKK;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid OFEDNDGJCMH;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid OLJFBKCNIEP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid BIAGPFEFAHD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid LJLGBNMIIKD;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid PKKKHNAPDBD;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid LLNBKAEJIIC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KCOOHNINKPM;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JOEDKNHNHIA;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid EBJPJBLEFMA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid FMBLGBOKNCK;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid OBJBEACCDOP;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid LIHCNCEPIGK;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid JJKHLBDMJNC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid PCNPOHEMOEM;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid FGJFHBHBMBH;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid CGJDAFNIPCB;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid OIHHCHLPDGK;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EELNALJOCJG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid MHKHIFNBFJD;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid PBKBNPLOJBK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KPCDOCFFJBB;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PAGABBBDGEH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid LMFAPIJDMBC;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FIEANKGBHIN;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid MFJOJMCFBPH;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid OELAEMEEBJP;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid CJNFIPDPEGO;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid PCOMFGEIEII;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid POKDMEHBEOL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JBAKECKBJOI;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid KANGDPFMPLG;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AMKPIONMPEA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid LMDMGJGDJLH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PIFCLJMGBDD;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid BCCBMDDFNIM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LCMOHKMCFLJ;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid IOKICEKHJEF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BDBPPMOEPEK;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid DPLMFKJKAGA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid EJJMFFBECFG;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LLLHPAPBBOD;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid ECDKFEDDLLN;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid AHCHKNAPPKG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JMOACMIGBKO;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid GADOBJHPFOF;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FJPLHIIFFNI;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HJNCGMFBJIE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid HOHBPNKDCEL;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EPAKKFOJDCJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid CEINJEGAMCI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KPBEFEJFKDF;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid MEPPAFGFKPK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid DEHABPPNFHM;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid CPIICGDBNFM;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid NEBMDGMDLAM;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KOLCFDEIBCE;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid LHKBNCNNODF;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BGMICLNAONF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid DDKAKPHNFIG;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MACMJKDBFNC;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid EMCJJBDJLPE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid JJGOJFNLIGC;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GMOHJFIPCMJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid LFGDGDENDLC;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JNLBPMGBLEN;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid CMOMACGOJJB;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid EOECKLGPOMO;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PMJBHMNGBDE;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PIKCOEMBEPE;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FICLIKNAKJP;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid FJKFAGNPABN;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid GLIKLABFAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid IAMMKNIDCKI;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid DPKDNKBOLDB;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid NOBBNLHPHPL;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GKFBEMPGIOO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GAKOKFPHDLD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid FLALGFGICAH;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid IBNGNADIJMH;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid MJFECKGLLBP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid KFGCKDECABA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid JJIPABAPAKB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OOJFBPKDMND;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FAHDCINPIDP;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PENPIHBKNBA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid KKAAIGPAAPM;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid CEKDPNNGNMF;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid FPLMNEDPGFL;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid PFDMNCKHFDH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HOEKDPHEOAK;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid LPFPFHGDEHL;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid MFHPNHLOGAC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid NJNKGPMEBPE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid ENODGKDMIOK;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OCJKBOIIDLC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid AJJKDNDMAOA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GCEFKKMAJMG;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid BKBBKEKOEEM;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid FKGKKNOOBDG;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LEAKFANHMDI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JPMALDOMPEC;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid HEAECHKBOJD;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LMAGCKMCCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid MCFIBBDPBDD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid OFOEAIDHGKD;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FICINIKHMOO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid CFJCOLIHOFO;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid NKLLBMMOKPE;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid IOICPCCFPJG;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GKEPEDJOKPP;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid FAHBNNBPDLM;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid FEPDAHHELFC;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PGEBMJJNFBB;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid AEIGMJHAPGD;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid IJDDEKAIJPP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PLALKEHIIIA;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid BECMGMMOCHM;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KMKBAPIDOJA;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid GHJNBDEGMJD;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid KCCGBBLEABI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid PLBCFOPJFBE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MFPJMFOGFMD;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid ILHCPLHODJH;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid BJMPFOKJPMM;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid KLKCNNJMKLM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid IHNIIIGMODN;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid GGEHJLNPHLL;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid PFILJIOGPPH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid OOLCEOPLBII;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GDAEHAADEOD;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid PFIJOENAMBN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid MAAAJALNPDK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid ECFDJGFMOHH;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OOAJMMBMJLE;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HBBFAKOJHOL;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JGHEGJFIPGB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid JHJNBPMPJMH;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid GMOLDPFECFE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PKAAGMLPNMD;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NILEEINCHKI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid AHAHEIBCDCH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid ECKLGKMOBED;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid IGMPNMMMBGO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid FCDHACMJKHO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid EJJKMBHGHOD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NEBLCFBIPNL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GIOJDDGPOLN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid DPPPBMHGMAM;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PNFCPJDDIFI;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GPOBMEJCGNA;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid JHCJGNMOLBP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid MHCJFFNJNNL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid FEGAHFKCIKO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AMLFMEKMENO;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid NCHCLKEAFFE;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DMILPLAKBBA;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid NDOOHDOKAGP;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid DPDNNHGGPJK;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid OEPKCHCPOIG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DEHCFNIGGJG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GLMIFEIENCN;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JOPAHLHKDKH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid IDAJHIILHIH;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HELDKGJBOCA;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid KGBPOJLOMDL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EAANIDNNFIA;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid COKFJLEOKKD;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HGPIEHEOPOG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LFAIJELKJNN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LKGPEPCEGPF;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid CDCFHBLICHC;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid MBDILMNIFMC;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OBHOPLMIBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid NABAKCEODGH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HLDAGAHACDJ;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid JHGHDFKPHMB;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BBPNBPAAIFA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid CNAIBCHHIGF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GFNHIIFDPBC;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NAFFPODBBCC;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GGNHHOANAFB;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid FDNFLAHBILG;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid BBCBMJOIFIG;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid NBFIDHBINMP;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid ADOCBJFKPNN;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid GKLJLCJLGGO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IAKJPHCCJOI;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OOCBLHIIHNE;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid MHENHCHGBKB;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid JKOCAJJGFMB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid CGNHOIKGHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid NFMFGGCJGPP;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid KDIGBLHDDPN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid IGCDJDBDFDP;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid PNFJCBEFMFF;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid AFBEMKIJOJN;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid HPEANAGFLNP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid OJOGOOMIKBI;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid IMMBMFOJBCB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid NPEHMLCKGEN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PCEEELJEHEL;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid JAKEMGKFHFC;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HNAGPICANIL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid BNNFHBMLCEO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid NDFDCNNFHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid KIMKANMCCOG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KLHGPDCEBLM;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BGLDOJGNCLD;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid BBBJEHJHKGP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid NICKIIOALOJ;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid BAEBCHBLFLA;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HNFLEELCJJP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JDFJAIEIPNJ;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid JDPBEINJJCD;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid EFMGKLEBFPG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EDBEHGENFAK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid ILBJDBIOIEH;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid HPAPPPGNALO;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid JJCGLPHGAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid HMBHFMKLEGI;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OFNPJNACDCB;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid LGLPFFLNAOC;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CHKOMLBJCFI;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid EIGNJMFOIHK;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid ILJECBPMFLF;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid NMPHNJCLLLP;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid DLMEKEGIEKP;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid CEHGDMHGFEA;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid NPEBIDHJNJE;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid GEFKCPDPJFP;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid OOJJGMEDFJL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid HDPFCKCMPGH;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid EKPKFCFEHEM;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid NGJGJJENJPF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid HNPPOJNLOEJ;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid DDBINEAAJIF;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid BCOGHOGENNO;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid DMGCBECJGKA;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid PJNCMABNJPF;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid OFCDBKHKKMC;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid NDJGCCBMLHK;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid BAEHDIMCNHI;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PJLAMIOKKPM;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid FBFJLKEGCDB;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NDFHBDHPMAP;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid BAKBDLJFBCM;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid CDOLLNKOCHA;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid OCOJNKGGIEN;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid PBLBPIEKCML;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid CECDAMIMCIA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid PDNLMAFBGFB;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid EKHALDEMFHE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid KPGKNLBFNHC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DECDFHINJFP;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid BJCIMCACICD;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid BNLNOLJBIJB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid EMAGPOOMNJH;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid ODGPDNKBOMM;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid KPILHELGNIP;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid GJELIHNCFEB;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid GOPNBKBCBOC;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid DILKAMFJBPD;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid HOEINCOKMAL;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OHIDDIFPFND;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid PACGKAJAPMB;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid FLFJCPBNIGL;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid HNENOCFJKAB;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid DINBJNDDGCO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid MHOBDLHFGLO;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid GELMKMECIFB;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid JEHFJHFOGID;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid MMEFNHHOFPD;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid AHBNFOOHJPK;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid HGDJFCCANFM;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid OECNIGOENDF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid JIFINBIMINP;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid PHFBPBAADFE;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid DBPMIHKPBLI;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid NGKCDIMGNAM;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid KBHGMFIGONN;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid HIMCIHCDBBB;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid AIOGAABJOMJ;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid NPOJPIFGNHM;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid FMEKOBNJNKH;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BNFCBFHGGEE;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid HNFAEJKPHOK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid PMMFOKDPDIE;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid DJPLFJKGKEO;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid KPELCOEBOJA;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid AAJFBDNEFFD;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DMCMPFCIOLH;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid AMMCBMMBLMK;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid ICPEECBKBHL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid DEOCAOLCCLC;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid ONLOHOIIMBP;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid BINJGMNKPHC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid COGONPHLFFC;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid DHFDIBCBINM;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid DDLHKLNIDBL;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid BKINAGHAGNF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid FGIMHOGEFMM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid IMJDFGOLBBA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid GNLGIJDGFAJ;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid CNAPKEHIJDP;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid KMIGIGOOOEH;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid LHKJHNFDMHN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid JFBEJCKGAEF;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid HKMLDNAMOMH;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid ELICBBLFDHI;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, JPHBPNIDNGG> DOOCBJCKPNK;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<JPHBPNIDNGG, Guid> PGIHMKFJLCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, JPHBPNIDNGG> POADFOKGJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF91C0", Offset = "0x6AF77C0", VA = "0x186AF91C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<JPHBPNIDNGG, Guid> PFPGHEPAJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9170", Offset = "0x6AF7770", VA = "0x186AF9170")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KADFJDNADNM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF81F0", Offset = "0x6AF67F0", VA = "0x186AF81F0")]
	public static bool FCGPJGFCDNC(IEALKJHANJD LKDNOIBMBHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8220", Offset = "0x6AF6820", VA = "0x186AF8220")]
	private static bool FCGPJGFCDNC(BHLNHBCANEC GANDHMGOAJC, IEALKJHANJD LKDNOIBMBHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct OOGABBFJNCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly JLECLAOCGDF HDDAPIGIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<GIFFLNOJBNJ> EPBGGLAELPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<GIFFLNOJBNJ> FBMMLEJICFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MJGAEDNBJIL<IKLMIGOGHKN> KMMOFBGNADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<JEBPJLMNFAK<BKFIMEBJLKC>> JAOGKIHPEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString FOFOFDJFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly FEOJIMLIEKI AIJLGHOGBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool HKOPGAAEBGE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AF90E0", Offset = "0x6AF76E0", VA = "0x186AF90E0")]
	public OOGABBFJNCK(JLECLAOCGDF ECLICOGMAKB, IEnumerable<GIFFLNOJBNJ> NCIIFBLDHLJ, IReadOnlyList<GIFFLNOJBNJ> BDDNJCJKJAB, MJGAEDNBJIL<IKLMIGOGHKN> LOPIFPAENDO, IReadOnlyList<JEBPJLMNFAK<BKFIMEBJLKC>> GHBNDFGNFCN, ByteString NEDEGDAHEJL, FEOJIMLIEKI JMIHOMEEEFK, bool OJMJJMIGEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BGGMOFKLAKG
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IBAEALIFPCH JGCMECODHDI, [Out] Dictionary<int, int> AOKFDGNCJEN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CHNAKMPIEHA BBBADJFIKMN, IEEHEGKHHAJ JCDDPJAFJGF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ELNODJJABGN : DEPNHKKPJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid JEHCHOPAGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> AEGFENKNOMP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> GBDJAAHJCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A63140", Offset = "0x3A61740", VA = "0x183A63140")]
	private ELNODJJABGN([In] Guid EJOKDLLGAEO, Dictionary<Guid, Guid> BMOMDHBLJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1DF0", Offset = "0x6AE03F0", VA = "0x186AE1DF0")]
	public static ELNODJJABGN GGBAHLJJLHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2280", Offset = "0x6AE0880", VA = "0x186AE2280")]
	public static ELNODJJABGN MFENNMNMAAF(IReadOnlyDictionary<Guid, Guid> NOABIFEPKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1AC0", Offset = "0x6AE00C0", VA = "0x186AE1AC0")]
	public static ELNODJJABGN FCBPILPDBLL(IEnumerable<KeyValuePair<Guid, Guid>> NOABIFEPKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1A10", Offset = "0x6AE0010", VA = "0x186AE1A10")]
	private static Dictionary<Guid, Guid> BEJLBLNLPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AE2000", Offset = "0x6AE0600", VA = "0x186AE2000")]
	public void LDNKOEOHFFO(IReadOnlyDictionary<Guid, Guid> NOABIFEPKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1EF0", Offset = "0x6AE04F0", VA = "0x186AE1EF0")]
	public Guid JDHNNGJDFON([In] Guid GDCMEHKEAMI, bool LLAFMJGOHKC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1E80", Offset = "0x6AE0480", VA = "0x186AE1E80")]
	public bool NIILIJBILDP([In] Guid MCAKFNPAKIL, [Out] Guid IPKNBAEDOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE1E80", Offset = "0x6AE0480", VA = "0x186AE1E80", Slot = "4")]
	private bool HOCKKCJEPLK(Guid MILPHOELICC, [Out] Guid JPCKHGMDGNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GEFKOELBIAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GCCFAKHHEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CENBFOHJAFB(ByteString EMFPJLNEBKH, ELNODJJABGN OLNJDDDNBEK, [In] UniformTRS EIGBOIGNAGA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LPMHJBPKPOO
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
public class ALGNPAFACOK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB57770", Offset = "0xB55D70", VA = "0x180B57770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long IEODLFEEOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x11DE8B0", Offset = "0x11DCEB0", VA = "0x1811DE8B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long DJAAPIKMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AE19A0", Offset = "0x6ADFFA0", VA = "0x186AE19A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67E36F0", Offset = "0x67E1CF0", VA = "0x1867E36F0")]
	public ALGNPAFACOK(long FIGHABPEBPG, long NPANMPAIAHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JDNKHHLKKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, ALGNPAFACOK> AECEPIFLIBM;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> OGCLKOKJAHK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long PCEACMPKCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11DE8B0", Offset = "0x11DCEB0", VA = "0x1811DE8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long HONBFCGHBMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1211180", Offset = "0x120F780", VA = "0x181211180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE4160", Offset = "0x6AE2760", VA = "0x186AE4160")]
	public static JDNKHHLKKMG OEAMALEFNPC(JLECLAOCGDF JBFBEAMBAPF, JEBPJLMNFAK<IKLMIGOGHKN> INFPELOEOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE3E90", Offset = "0x6AE2490", VA = "0x186AE3E90")]
	private void EADFOKAEJMI(KJBJNDHGBLH KOHLOCENPAH, long HOPAJJEJAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8160", Offset = "0x6AF6760", VA = "0x186AF8160")]
	public JDNKHHLKKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FAPBACBFDDC
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<JPHBPNIDNGG> PKJIINHJEIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EEIANKKJGFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> LJHDDMPAMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> FFMOCDDMNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88AB80", Offset = "0x889180", VA = "0x18088AB80")]
	public EEIANKKJGFN(IReadOnlyDictionary<Guid, Guid> EHHJKPHKAEP, IReadOnlyDictionary<Guid, Guid> JJEDNPAFFPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PJONKLMKOKE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EOIPFJMAPOI : IEnumerable<GIFFLNOJBNJ>, IEnumerable, IEnumerator<GIFFLNOJBNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private GIFFLNOJBNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private NNCILDJKCFE spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public NNCILDJKCFE <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private CDGKLFDEMGC spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public CDGKLFDEMGC <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GIFFLNOJBNJ System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public EOIPFJMAPOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2290", Offset = "0x6AE0890", VA = "0x186AE2290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AE2560", Offset = "0x6AE0B60", VA = "0x186AE2560", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AE23A0", Offset = "0x6AE09A0", VA = "0x186AE23A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GIFFLNOJBNJ> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AE23A0", Offset = "0x6AE09A0", VA = "0x186AE23A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AF96C0", Offset = "0x6AF7CC0", VA = "0x186AF96C0")]
	public static NNCILDJKCFE EDMHNFOHDKG([In] OOGABBFJNCK EFGENHBHNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB800", Offset = "0x6AF9E00", VA = "0x186AFB800")]
	private static void IADNMNNMJDP(NNCILDJKCFE JMJDIKMJDHH, [In] OOGABBFJNCK FOKOOANFGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9DD0", Offset = "0x6AF83D0", VA = "0x186AF9DD0")]
	public static BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI> HCKGLLCBPPC(NNCILDJKCFE JMJDIKMJDHH, CDGKLFDEMGC IAPGLPNOEJB, ELNODJJABGN? BNDPMFOBHFK)
	{
		return default(BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBE60", Offset = "0x6AFA460", VA = "0x186AFBE60")]
	[IteratorStateMachine(typeof(EOIPFJMAPOI))]
	private static IEnumerable<GIFFLNOJBNJ> IDKMBNCDCHL(NNCILDJKCFE JMJDIKMJDHH, CDGKLFDEMGC IAPGLPNOEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9B40", Offset = "0x6AF8140", VA = "0x186AF9B40")]
	private static void GHBNPNEJKAG(NNCILDJKCFE JMJDIKMJDHH, ELNODJJABGN? BNDPMFOBHFK, CDGKLFDEMGC IAPGLPNOEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9840", Offset = "0x6AF7E40", VA = "0x186AF9840")]
	private static void EHEIEOAOHAM(NNCILDJKCFE JMJDIKMJDHH, CDGKLFDEMGC IAPGLPNOEJB, IReadOnlyCollection<ByteString>? HANOEGJNFOP, IReadOnlyCollection<ByteString>? JBLJLHGAMNL, IReadOnlyCollection<ByteString>? MNDFPHMHFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBF70", Offset = "0x6AFA570", VA = "0x186AFBF70")]
	private static bool KHLILCKGDFD(NNCILDJKCFE JMJDIKMJDHH, CHNAKMPIEHA BBBADJFIKMN, CDGKLFDEMGC IAPGLPNOEJB, [Out][NotNullWhen(false)] string? ENDMINEHNJK, [Out] Dictionary<int, int> AOKFDGNCJEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC610", Offset = "0x6AFAC10", VA = "0x186AFC610")]
	private static Dictionary<Guid, BHLNHBCANEC> KPGDOBJIEDD(NNCILDJKCFE JMJDIKMJDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC8F0", Offset = "0x6AFAEF0", VA = "0x186AFC8F0")]
	private static void PIGFKGJHPGF(bool BHMHOHKJJPC, GIFFLNOJBNJ LBLEGAGFFHC, Dictionary<Guid, Guid> ICMILFMMCDP, ELNODJJABGN BNDPMFOBHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF98B0", Offset = "0x6AF7EB0", VA = "0x186AF98B0")]
	private static void GBKILIMKCDI(GIFFLNOJBNJ LBLEGAGFFHC, Guid HDMMLBENEIG, LCLJBGMBADM? HACCKBIBOJG, Dictionary<Guid, BHLNHBCANEC> IDOPNOLLBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9210", Offset = "0x6AF7810", VA = "0x186AF9210")]
	private static void EACEJNIOGAJ(IEnumerable<GIFFLNOJBNJ> JNMENJEOCOH, IReadOnlyCollection<ByteString> HANOEGJNFOP, IReadOnlyCollection<ByteString> JBLJLHGAMNL, IReadOnlyCollection<ByteString> MNDFPHMHFEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CDGKLFDEMGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool BHMHOHKJJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public FEOJIMLIEKI JMIHOMEEEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public LCLJBGMBADM? HACCKBIBOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public LCLJBGMBADM? DBBODODCLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public JLECLAOCGDF JHICGKHDFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public LPMHJBPKPOO KPLMKJNLGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public BGGMOFKLAKG GHCKAPBDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public GEFKOELBIAM JNHLOKPDDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public JEBPJLMNFAK<IKLMIGOGHKN> OALDCHIBHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public PHGLNNNIEFI FHHPLGGCIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<GIFFLNOJBNJ> EICPAJOKGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> JDDCBBMCKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public HCNJGFMMAMJ LOJPDEGJDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool KOLMHNICOEE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KEGAAIDDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE19C0", Offset = "0x6ADFFC0", VA = "0x186AE19C0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LCLJBGMBADM
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float KKLLLILLFFA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion JOLHFCINNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float DKEHAFKGJAC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 BNALGHEFHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6AF85D0", Offset = "0x6AF6BD0", VA = "0x186AF85D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS HLCJAODMFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8880", Offset = "0x6AF6E80", VA = "0x186AF8880")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xCC5C60", Offset = "0xCC4260", VA = "0x180CC5C60")]
	public LCLJBGMBADM(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float DKEHAFKGJAC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8F00", Offset = "0x6AF7500", VA = "0x186AF8F00")]
	public LCLJBGMBADM(UniformTRS CGAGOIBCFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8B80", Offset = "0x6AF7180", VA = "0x186AF8B80")]
	public static LCLJBGMBADM KLJDAOBOJGL(LCLJBGMBADM LDJCBIBELIM, LCLJBGMBADM EGBCFNCILHM)
	{
		return default(LCLJBGMBADM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8860", Offset = "0x6AF6E60", VA = "0x186AF8860")]
	public static LCLJBGMBADM BIEOCAPMHCM((Vector3, Quaternion, float) JGCMECODHDI)
	{
		return default(LCLJBGMBADM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF86E0", Offset = "0x6AF6CE0", VA = "0x186AF86E0")]
	public static LCLJBGMBADM BIEOCAPMHCM(Matrix4x4 NEOIADOHDBN)
	{
		return default(LCLJBGMBADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8E70", Offset = "0x6AF7470", VA = "0x186AF8E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8950", Offset = "0x6AF6F50", VA = "0x186AF8950")]
	public LCLJBGMBADM IDCLGIOBIAA(Matrix4x4 FLDLBOHKNDN)
	{
		return default(LCLJBGMBADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8E00", Offset = "0x6AF7400", VA = "0x186AF8E00")]
	public static LCLJBGMBADM KLOPIFAFOBJ(Vector3 LEELMECKGCG)
	{
		return default(LCLJBGMBADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AF88C0", Offset = "0x6AF6EC0", VA = "0x186AF88C0")]
	public readonly OMNAEPPNJLF GFIFGFLDJMC()
	{
		return default(OMNAEPPNJLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KBGBLKINNCB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B01FB0", Offset = "0x6B005B0", VA = "0x186B01FB0")]
	public static LCLJBGMBADM PDNLCPCOOEL([In] this OMNAEPPNJLF BJNJBGHPMEH)
	{
		return default(LCLJBGMBADM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PLMHLPKCMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NIOLOMFIONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly HFDFMBCLPDO LJIJAODAALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly JHLAIJINHDF GBEMDMBPCFL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xF42D50", Offset = "0xF41350", VA = "0x180F42D50")]
	private NIOLOMFIONI(HFDFMBCLPDO FODBPFPIPNA, JHLAIJINHDF NOPDAHPFOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B05FD0", Offset = "0x6B045D0", VA = "0x186B05FD0")]
	public HAGOHGINEAC PBIOBIEADLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B05DB0", Offset = "0x6B043B0", VA = "0x186B05DB0")]
	public static BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI> GGBAHLJJLHO(HBJAJJJGMOP<BLGMJKLPHOM> NOPDAHPFOAF)
	{
		return default(BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B05E60", Offset = "0x6B04460", VA = "0x186B05E60")]
	public static BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI> GGBAHLJJLHO(HAGOHGINEAC NOPDAHPFOAF)
	{
		return default(BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B05F10", Offset = "0x6B04510", VA = "0x186B05F10")]
	public static BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI> GGBAHLJJLHO(string DPABOJGMGDH)
	{
		return default(BCLNLKLFCPB<EEIANKKJGFN, NIOLOMFIONI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HFDFMBCLPDO
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MJPKBCCDGKG : IDisposable, JPJGPMBJKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<NNEBOAEPEKN> CIBMIMCNCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float IDPHAJLBODO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PDHKOOFCPLC LCGLCJMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
		[CompilerGenerated]
		get
		{
			return default(PDHKOOFCPLC);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EGJLJKDHKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B03630", Offset = "0x6B01C30", VA = "0x186B03630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NEMMKLLLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B04A40", Offset = "0x6B03040", VA = "0x186B04A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<DEJMAJEIODJ> CDIOCHAHGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int HDIPHNLKHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6B035F0", Offset = "0x6B01BF0", VA = "0x186B035F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float DFBOPOHFPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B04820", Offset = "0x6B02E20", VA = "0x186B04820")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B05D20", Offset = "0x6B04320", VA = "0x186B05D20")]
	public MJPKBCCDGKG(PDHKOOFCPLC OGECPHANGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B041E0", Offset = "0x6B027E0", VA = "0x186B041E0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B05450", Offset = "0x6B03A50", VA = "0x186B05450")]
	public Vector3 LCKOOLMHIML(int LBBGOBFOJMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B040B0", Offset = "0x6B026B0", VA = "0x186B040B0", Slot = "6")]
	public Quaternion DPFDECMOPNF(int LBBGOBFOJMO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B03550", Offset = "0x6B01B50", VA = "0x186B03550", Slot = "5")]
	public Vector3 AHGGHKBIGJK(int LBBGOBFOJMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B05B40", Offset = "0x6B04140", VA = "0x186B05B40", Slot = "7")]
	public float PAMIOFNFPJH(int LBBGOBFOJMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B037A0", Offset = "0x6B01DA0", VA = "0x186B037A0")]
	public void BNGPPHLNEPB(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB, bool MLPOKKMDLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6B04C00", Offset = "0x6B03200", VA = "0x186B04C00")]
	private bool KMAMEKKGMOO(int DKKILDIMGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B05BA0", Offset = "0x6B041A0", VA = "0x186B05BA0")]
	public void PGCBCMJMOFA(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B049B0", Offset = "0x6B02FB0", VA = "0x186B049B0")]
	public void GJBEGENPCJL(int DKKILDIMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B05920", Offset = "0x6B03F20", VA = "0x186B05920")]
	public void LHDMHFAJCKE(int DKKILDIMGOP, Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA, float PPAGJHCGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B04A50", Offset = "0x6B03050", VA = "0x186B04A50")]
	public void JGLGPGFHAFF(int DKKILDIMGOP, float3 LEELMECKGCG, quaternion JOLHFCINNMA, float PPAGJHCGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B046D0", Offset = "0x6B02CD0", VA = "0x186B046D0")]
	public void EEOKHGJCCFD(int DKKILDIMGOP, Vector3 LEELMECKGCG, float PPAGJHCGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B03640", Offset = "0x6B01C40", VA = "0x186B03640")]
	public void BNCFJPNNMPB(int DKKILDIMGOP, Vector3 DBBPPLLNKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B04C60", Offset = "0x6B03260", VA = "0x186B04C60")]
	public static Quaternion LAHHGFMJAOG(Quaternion CNFFBLAHCCM, int DKKILDIMGOP, float NEKBEIIBCOC, JPJGPMBJKJG PEOCJAHEBJI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B04240", Offset = "0x6B02840", VA = "0x186B04240")]
	public Bounds ECGLKPMAFBP(Transform FLDLBOHKNDN)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B034E0", Offset = "0x6B01AE0", VA = "0x186B034E0", Slot = "10")]
	public virtual void ABJMNIBHDEP(bool DDANGCHOHPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B05A70", Offset = "0x6B04070", VA = "0x186B05A70")]
	public NativeList<NNEBOAEPEKN> MEAPDIJDCBJ(float NNDGIKKJHBE = 1f)
	{
		return default(NativeList<NNEBOAEPEKN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DEJMAJEIODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 EHFBMINIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float FMHJKFJFPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion PJPINBPCIFN;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD680", Offset = "0x6AFBC80", VA = "0x186AFD680")]
	public DEJMAJEIODJ(Vector3 NJELOECLOIL, Quaternion CNFFBLAHCCM, float PPAGJHCGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD5C0", Offset = "0x6AFBBC0", VA = "0x186AFD5C0")]
	public Quaternion NKKOGHHFOAA(Vector3 JFCINBHKCNC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD2C0", Offset = "0x6AFB8C0", VA = "0x186AFD2C0")]
	public DEJMAJEIODJ CDONOFLGCBD(Vector3 DGGNJONHEJB, Vector3 MCNGHMOCPMH, Vector3 KJILIJGBEEP)
	{
		return default(DEJMAJEIODJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD110", Offset = "0x6AFB710", VA = "0x186AFD110")]
	public OFLAGGJKOFE ABMOMGBJIBK(Vector3 JFCINBHKCNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class IMMENHBNHLC : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B01340", Offset = "0x6AFF940", VA = "0x186B01340", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B00A80", Offset = "0x6AFF080", VA = "0x186B00A80")]
	private void KECBNDOKDEK(Dictionary<Guid, Guid> FABCAMOOBOM, BMPPDAIFHOM AENOCDNNIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B012E0", Offset = "0x6AFF8E0", VA = "0x186B012E0")]
	private void KECBNDOKDEK(Dictionary<Guid, Guid> FABCAMOOBOM, KBHOPGCMIOF AHJNDCLHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B01060", Offset = "0x6AFF660", VA = "0x186B01060")]
	private void KECBNDOKDEK(Dictionary<Guid, Guid> FABCAMOOBOM, GMCNJDGNDGL GEAGHEFCPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public IMMENHBNHLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FFCEAFDILJP : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE9E0", Offset = "0x6AFCFE0", VA = "0x186AFE9E0", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public FFCEAFDILJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class NNPILIIJEHC : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B06040", Offset = "0x6B04640", VA = "0x186B06040", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public NNPILIIJEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class HAPJKEONPMK : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B004E0", Offset = "0x6AFEAE0", VA = "0x186B004E0", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public HAPJKEONPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BMDFKFCAOGI : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCD40", Offset = "0x6AFB340", VA = "0x186AFCD40", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public BMDFKFCAOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JDHPONLADHL : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B01CE0", Offset = "0x6B002E0", VA = "0x186B01CE0", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JDHPONLADHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JGNNFEPLEDM : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B01E20", Offset = "0x6B00420", VA = "0x186B01E20", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JGNNFEPLEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GLBJDMFKBDP : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B003F0", Offset = "0x6AFE9F0", VA = "0x186B003F0", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public GLBJDMFKBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class KFILAIMBEAG : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B02070", Offset = "0x6B00670", VA = "0x186B02070", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public KFILAIMBEAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class CCBAFOOCEEM : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCF60", Offset = "0x6AFB560", VA = "0x186AFCF60", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public CCBAFOOCEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LEHLGFCPOOD : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B02220", Offset = "0x6B00820", VA = "0x186B02220", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public LEHLGFCPOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AGALIBCCAHO : CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly EBNBPDJNCHE GMGLDOFMCCI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCC10", Offset = "0x6AFB210", VA = "0x186AFCC10", Slot = "4")]
	public void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public AGALIBCCAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IEALKJHANJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public CHNAKMPIEHA CJEHFDAEGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public PHAOBOBOLNJ PGHGMIKCCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> IOKAMMKIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> BBBIEAIOAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public HCNJGFMMAMJ LOJPDEGJDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool LILKAOEDHFA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CHPCHEEMMEB
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHJABFDNLCN(HKAMHKGMHEG MAPCLDAKLGH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FDEBNNGGCKC
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly CHPCHEEMMEB[] EEIOFBFMFCE;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD8A0", Offset = "0x6AFBEA0", VA = "0x186AFD8A0")]
	public static void BLKKMEKIJAC(GIFFLNOJBNJ JGCMECODHDI, Dictionary<Guid, Guid> JPLMLJMLDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AFDF00", Offset = "0x6AFC500", VA = "0x186AFDF00")]
	public static void HHBKHJEFNKA(GIFFLNOJBNJ? JGCMECODHDI, ELNODJJABGN PENHLMLHKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE190", Offset = "0x6AFC790", VA = "0x186AFE190")]
	public static void KDDADMLODEG(GIFFLNOJBNJ? JGCMECODHDI, ELNODJJABGN BNDPMFOBHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFDB30", Offset = "0x6AFC130", VA = "0x186AFDB30")]
	public static void FCGPJGFCDNC(HKAMHKGMHEG MAPCLDAKLGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct HKAMHKGMHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public CHNAKMPIEHA ICCJMFPBOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public GIFFLNOJBNJ LBLEGAGFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> IOKAMMKIHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> BBBIEAIOAEK;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6B009E0", Offset = "0x6AFEFE0", VA = "0x186B009E0")]
	public Guid ADBNFNOIBLH(Guid GDCMEHKEAMI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCNJGFMMAMJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int AIJLAMCPGBD, [Out] Guid EIIHCHLAOLD);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class GKGEHBGNFMJ
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker LPDNAGKJIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> LDEHKGBLCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> LLKIBBMMEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> DLEKGOLMBGC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> FKIKDPDPBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> MCLPJPGIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF2C0", Offset = "0x6AFD8C0", VA = "0x186AFF2C0")]
	public static GKGEHBGNFMJ MIJGDMLAPNC(ANPHFBDJECI LLAPGPIJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF330", Offset = "0x6AFD930", VA = "0x186AFF330")]
	public static GKGEHBGNFMJ NNJNBKBGBLO(NNCILDJKCFE KNFCFIPMHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEFC0", Offset = "0x6AFD5C0", VA = "0x186AFEFC0")]
	public static GKGEHBGNFMJ KLOGKNNOOBD(IEnumerable<string> LDEHKGBLCHK, IDictionary<long, int> LPFOLEFLHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B00190", Offset = "0x6AFE790", VA = "0x186B00190")]
	private GKGEHBGNFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B002B0", Offset = "0x6AFE8B0", VA = "0x186B002B0")]
	private GKGEHBGNFMJ(IEnumerable<string> LDEHKGBLCHK, IDictionary<long, int> LPFOLEFLHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF840", Offset = "0x6AFDE40", VA = "0x186AFF840")]
	private void PFOGBOJKMMO(ANPHFBDJECI LLAPGPIJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFA50", Offset = "0x6AFE050", VA = "0x186AFFA50")]
	private void PFOGBOJKMMO(NNCILDJKCFE KNFCFIPMHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEA90", Offset = "0x6AFD090", VA = "0x186AFEA90")]
	private void EJEGCKNCFDC(ByteString? NEDEGDAHEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFC50", Offset = "0x6AFE250", VA = "0x186AFFC50")]
	private void PFOGBOJKMMO(GILAJLCEBJH? JPBBEMPIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF700", Offset = "0x6AFDD00", VA = "0x186AFF700")]
	private void PFOGBOJKMMO(HFBMPHDALGE? KOHLOCENPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF3A0", Offset = "0x6AFD9A0", VA = "0x186AFF3A0")]
	private void PFOGBOJKMMO(GIFFLNOJBNJ? LBLEGAGFFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AFEF50", Offset = "0x6AFD550", VA = "0x186AFEF50")]
	private void KAGCFJNGJLM(string? KOGNIKOANFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF190", Offset = "0x6AFD790", VA = "0x186AFF190")]
	private void KOLJBPMCBEC(long BCCFEKJCEMP, Guid NKPBBHPHCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF140", Offset = "0x6AFD740", VA = "0x186AFF140")]
	private void KOLJBPMCBEC(PHLKDJLLLOI? MEPPEIGFLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF260", Offset = "0x6AFD860", VA = "0x186AFF260")]
	private void KOLJBPMCBEC(HICHCNEAPCF? MEPPEIGFLNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LHEBMMADLHP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class HDGOEGPCOJA : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> GMBMPHHMOPJ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry DHAMAAIGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6B007B0", Offset = "0x6AFEDB0", VA = "0x186B007B0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object PJJDBLNOLBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6B00880", Offset = "0x6AFEE80", VA = "0x186B00880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object PGPGCBGPPOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B00930", Offset = "0x6AFEF30", VA = "0x186B00930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B006D0", Offset = "0x6AFECD0", VA = "0x186B006D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
		public HDGOEGPCOJA(IEnumerator<DictionaryEntry> GMBMPHHMOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6B00630", Offset = "0x6AFEC30", VA = "0x186B00630", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6B00680", Offset = "0x6AFEC80", VA = "0x186B00680", Slot = "9")]
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
		private sealed class DFGMBAPDKOF : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6AFD850", Offset = "0x6AFBE50", VA = "0x186AFD850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public DFGMBAPDKOF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD700", Offset = "0x6AFBD00", VA = "0x186AFD700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6AFD800", Offset = "0x6AFBE00", VA = "0x186AFD800", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B06770", Offset = "0x6B04D70", VA = "0x186B06770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object LFOBGDLOPID]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6B06680", Offset = "0x6B04C80", VA = "0x186B06680", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6B06850", Offset = "0x6B04E50", VA = "0x186B06850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6B065C0", Offset = "0x6B04BC0", VA = "0x186B065C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6B06620", Offset = "0x6B04C20", VA = "0x186B06620", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6B067F0", Offset = "0x6B04DF0", VA = "0x186B067F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6B06280", Offset = "0x6B04880", VA = "0x186B06280", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6B062E0", Offset = "0x6B048E0", VA = "0x186B062E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6B06340", Offset = "0x6B04940", VA = "0x186B06340", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
		public RoomObjectCounts(Dictionary<int, int> LKBJHGLHENI, [Optional] Dictionary<int, int> BOEIBKPILON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6B061A0", Offset = "0x6B047A0", VA = "0x186B061A0")]
		[IteratorStateMachine(typeof(DFGMBAPDKOF))]
		private IEnumerator<DictionaryEntry> MEKHDKOFICG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6B068A0", Offset = "0x6B04EA0", VA = "0x186B068A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6B064C0", Offset = "0x6B04AC0", VA = "0x186B064C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B063A0", Offset = "0x6B049A0", VA = "0x186B063A0", Slot = "9")]
		void IDictionary.Add(object LFOBGDLOPID, object KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6B06400", Offset = "0x6B04A00", VA = "0x186B06400", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B06460", Offset = "0x6B04A60", VA = "0x186B06460", Slot = "8")]
		bool IDictionary.Contains(object LFOBGDLOPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6B06560", Offset = "0x6B04B60", VA = "0x186B06560", Slot = "14")]
		void IDictionary.Remove(object LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6B06220", Offset = "0x6B04820", VA = "0x186B06220", Slot = "15")]
		void ICollection.CopyTo(Array DKEEEGEFALD, int HGFDMIDEFHN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class AEBDIEHMCPG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6AFCBC0", Offset = "0x6AFB1C0", VA = "0x186AFCBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public AEBDIEHMCPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6AFCA30", Offset = "0x6AFB030", VA = "0x186AFCA30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6AFCB70", Offset = "0x6AFB170", VA = "0x186AFCB70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B01A00", Offset = "0x6B00000", VA = "0x186B01A00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object LFOBGDLOPID]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6B018D0", Offset = "0x6AFFED0", VA = "0x186B018D0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6B01AB0", Offset = "0x6B000B0", VA = "0x186B01AB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6B01810", Offset = "0x6AFFE10", VA = "0x186B01810", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6B01870", Offset = "0x6AFFE70", VA = "0x186B01870", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6B01A50", Offset = "0x6B00050", VA = "0x186B01A50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6B01490", Offset = "0x6AFFA90", VA = "0x186B01490", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6B014F0", Offset = "0x6AFFAF0", VA = "0x186B014F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6B01550", Offset = "0x6AFFB50", VA = "0x186B01550", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x20A2BD0", Offset = "0x20A11D0", VA = "0x1820A2BD0")]
		public Invention(long MCAKFNPAKIL, int FIGHABPEBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6B013C0", Offset = "0x6AFF9C0", VA = "0x186B013C0")]
		[IteratorStateMachine(typeof(AEBDIEHMCPG))]
		private IEnumerator<DictionaryEntry> MEKHDKOFICG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6B01B00", Offset = "0x6B00100", VA = "0x186B01B00", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6B016D0", Offset = "0x6AFFCD0", VA = "0x186B016D0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B015B0", Offset = "0x6AFFBB0", VA = "0x186B015B0", Slot = "9")]
		void IDictionary.Add(object LFOBGDLOPID, object KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B01610", Offset = "0x6AFFC10", VA = "0x186B01610", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B01670", Offset = "0x6AFFC70", VA = "0x186B01670", Slot = "8")]
		bool IDictionary.Contains(object LFOBGDLOPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B017B0", Offset = "0x6AFFDB0", VA = "0x186B017B0", Slot = "14")]
		void IDictionary.Remove(object LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B01430", Offset = "0x6AFFA30", VA = "0x186B01430", Slot = "15")]
		void ICollection.CopyTo(Array DKEEEGEFALD, int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> IPIKMDPKOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> BMOFLMBLGGN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
	public LHEBMMADLHP(IReadOnlyDictionary<Guid, RoomObjectCounts> OKKHNBLCNEG, IReadOnlyList<Invention> GPNOKCKBLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B029E0", Offset = "0x6B00FE0", VA = "0x186B029E0")]
	public static LHEBMMADLHP MIJGDMLAPNC(ANPHFBDJECI LLAPGPIJJLB)
	{
		return default(LHEBMMADLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B033C0", Offset = "0x6B019C0", VA = "0x186B033C0")]
	[CompilerGenerated]
	internal static int MKHMCCMAOHD([In] IReadOnlyDictionary<long, int> NGKFBPFKMCH, long? BCCFEKJCEMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6B02320", Offset = "0x6B00920", VA = "0x186B02320")]
	[CompilerGenerated]
	internal static void JONDGMEDJPP(int OGJBOBIGPPC, [In] GILAJLCEBJH IPEEJDIIKEP, [In] Dictionary<long, int> NGKFBPFKMCH, [In] Dictionary<Guid, RoomObjectCounts> OKKHNBLCNEG)
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
