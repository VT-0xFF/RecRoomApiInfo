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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7801AA0", Offset = "0x7800EA0", VA = "0x187801AA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLDDFNALNCC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> FNELJKLCJHO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GCOBEMGADFH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GLEGDHKNLNL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> LEHEPNEAGMO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KKDCGLBCAGE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CIHBLILCKII;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string MLCJCLHNNOC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x77FF8A0", Offset = "0x77FECA0", VA = "0x1877FF8A0")]
	public static bool LPIBMGCALCB(Guid MOPGLFIIMKA, int PJIDJDLIDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77FF810", Offset = "0x77FEC10", VA = "0x1877FF810")]
	public static bool BCJPBCGKPGA(Guid MOPGLFIIMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77FF9A0", Offset = "0x77FEDA0", VA = "0x1877FF9A0")]
	public static string MGCFLLNOLLP(Guid KDBHLLEACIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MGFFKDLKBDO]
public enum AAFGMPNJNKB
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
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77FF780", Offset = "0x77FEB80", VA = "0x1877FF780", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DCLGAAJCAIC
{
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid EINNNKCFOKF;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid FMOALBPKJCL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid CPDCFFHKONB;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid DKLCIKGDNHF;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid OPPOACPMBOB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KBLIPNEOIKI;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid MANJLBFLLBE;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid FBMKHBGNBIM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KNGPGGIGCDG;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid ADJAEGDEMMI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PLCNBKGCPMM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid MFDKICBCGKC;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid BCMIFEFHBJF;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid HFHLLNNAPKC;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid MCCCJJNNBMJ;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HMHNJBIACFG;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid NHPOHDJAFKN;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid ABBPMHOAKGJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid MKCCFGPNGIM;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid DKPENGLONKO;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid BHPGJFINKBD;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid FEBNJDBPKBC;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DLNDCNMJJJN;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid IOFIKMGAPHF;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid IPPGHBJALHF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid OGBBPCIBJDJ;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid MKHLEBOLNBO;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid PPIDNDBGDGP;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid LLBPJHJMBCE;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid JPMLEHAPGAM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid MAHFKKHEIAO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid GFOOMEJMAJO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid IAJCOAPJMDF;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid PLNCOHHKFMK;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid DAPECDCOMPO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid LCEMGLKJJEF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CKGKGNMMDMI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid AJLONGAHPDF;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid MPOIKBCHCNM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CJLPAHBIFPM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KGHKHOFIDBA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid PDOLEIHHMMA;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid GAMHGNLCJKF;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid IJNJEOBGCJP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CNPMBHGOMKC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid PPAPKDCBKAN;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid AJCHBEHKJAL;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid ADHOLMPBILI;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BOBLDMMPEDE;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FICMJEGLBMH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid HIEIGNBBHIL;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MPJKDELPOGE;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid BCCDNHEEIKP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid EGLONFMKKDG;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid PONNCGCOECJ;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid FHEDCNHKOIF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DHBLDLNPKOO;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid DBNCOLGAKDH;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid BLHPOOMFEKD;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid HCBEKDCCPLC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DEPHJDIBOAF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EGKPEOMCOBM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PLIDAMEDDDH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JCEDNGCFOBE;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid JMMJHKOKFNA;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid IEPBFBPELFF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid IICFNIMINOL;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MEDCGCIGNJI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid DJJEDHAIDBB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GOACIBNCCLL;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid MEPFEEPJEHM;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FMPKPFHJCLE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BPJKFHJCIPP;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BJAPGCALANH;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid AIPOLOOLHEO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NBPNKDHFPPF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MFCHGJGNCIO;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid DCCDOODJBFN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid LKDBDMDALCE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid FNDJEMAEFJK;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid EDJJOODEMCM;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid JFLOMAAHNPI;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid NBJNOKONBMI;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid KMNFECIHDJH;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid GAEBLBKKIDJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid MHKDHMHFAON;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid NLMPMPEMOBE;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FDBCLCAJGPM;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DDCAMBLEFCF;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid AHHNPMIMINB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid EFEMOBIPGAC;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CMHFDCNJIOA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid GIKNBLFJBFG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DIICHBANAGA;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid BNBEOEPOCBP;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid JFLPKKKBADF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid BAHNAIDLBKL;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid PCJHPAOCIKM;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KEJNHODNEJA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid AEIFAMIMFIP;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid OHNNEMHCLNE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid ALAAKOBNBMJ;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid DPMHIDBBBBK;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid FHLPPDHPCLH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid ECKNOEPJPDP;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid PBICCHKLOHL;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HPIDOADHLMB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GEDNFBDGBFF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid OCBIAGKPKMM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid AKFPIENNBMO;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EKBDMBEBGIF;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid CJMJKBLLNNH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid CFKNPNHFDFI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid MEGKCGKIEKP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HBCGHPJBBPM;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid LPOEJMDJDIK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BIFMPDFPAAC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LJMBABAIOIO;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HMMHKKGBKLM;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid DPMBNCAAJLL;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid FLGFDACAMPI;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid HFEDKIMGDFE;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HBLCJCNDIHA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid OKJEODMBIIC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid KDOLKPPHFPA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid NICJFGBKGOL;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid ELOKPCFOGBA;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid AIJGFBLAFEO;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JFEECGEKFPC;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid ABEKCBKPEPE;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid HPDKENOKDOJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid EGFDAAOJJEA;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MBJEELACDJN;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid KCPCFJNBFJM;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid OCGBMCMFGJB;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid DHDNBHGJCMO;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid APGLMNHIBBK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid GICNBHKHMMH;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid EDLGCMDCPBB;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid AHIGOIPDPHN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PFOENHADAKM;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid POBBNOKCMGM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid JGICFHAJKGB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BLNJHGFNGNB;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IFCLJNCENNG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid PKHEFIBAHDB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid POFEHPIHGFE;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid MIIDONPIOIC;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid ILCMLIBEOID;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid EBMDJKCPFHD;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KNJJDLFJFDE;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid BIHJFCLKKNI;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DIOFEECMGKM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid IGGFMBKCGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid DOANMOKKNKA;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid IAAIBGAEBCK;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PHPAOPFFFJL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KLIAJCDAGBB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OFJFMCBEOGE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid CODAPMBIAPK;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid CBIDEMBFLLA;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid OEAPJIFEFGA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid DHNHACLBMGF;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JNBHKCKIBIK;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PGGCNMGGFHD;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IIDEMMAKDJG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid HEGBOJEHLNK;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid DHCMAAENJGE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid GJOBOPNMMKL;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid HKJEGGAKNCN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid PAPJKNKAPJK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid JAICCAKONDA;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FHMADLOBMKI;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid AMIJPKELEBK;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid CKLPOFEHKHK;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HECIFLHKGON;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GOCCAIBNOAJ;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid NLMEJBEGJAA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BMMJJEPOMEH;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid NPDKKMBCPLM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid GHAEEBLMLFD;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GHHMBILDNHK;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid POKFOCJFCEM;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid LJIJKEKKGKM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid FAPIINAODHE;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HLDKBCCBNPE;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FGLHELHKJAG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid GOIPAPLFCPN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid EDOPKNHGFCI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid LPLDFMOLMCN;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid BMJLIBPKJOP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FJJLOFGJCIP;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid GDLDAMLJKHL;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid IFFKNFGOBCB;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid FJEOKNPOEGC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid OGHBIJELPOC;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid IOFCCOCEFIJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid FDCLABKDBMF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PFLPMFJOFOD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LEAHHPDBKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid IJKAJFLKLIB;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IMLDNCNFMGF;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NBCLJOBFJIL;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid PMKJFAKMEFK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JDCMNMMLIKO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid PGGGELNHKNC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid CHCKGOMOJPE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid KFJGGCDAIJJ;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid MLBGFAHMFLP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid LAMBKIAFBJG;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid EBFCBONEHHO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid JJIIFGJAJHK;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid CAFFOMJLOJG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NBJINJGACFO;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid HDBIMGFMHEP;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GJGPGHMMICP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GKHGELNIBDH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid DDDHNDNHPOF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid GJDMKFMIIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid OPIIKKCLJON;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid JPFALLCMBEN;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GOPJOHCOILE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid DMKCADJPDDG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid LBANODJGJFP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FFDDAJLFJHC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GDINEDABLDB;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid JAECFLJBKHP;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid PPCBCGADPPA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid OBCMGMFEEGP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid MALINELFHJO;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DJKPCHMABMK;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid LNBCDIDLGOM;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid MEIKFBGABFM;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FKJAJNOBGML;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid JNGPHIPJPCM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid OHLGCFKBDGM;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid HDJIPPIDCEL;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid DHINFMGHBMC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid OFOIGFFKGOE;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid GCPJJPGLCPM;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NGHABKOPJEL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid JMNMLJFBMJA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid JGKJFLGGMKL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HIJJOKHGLNE;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid ADILIPGBFLH;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CIHLPIKBDEP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DHIGGEDEKJL;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid MIBFPEEBLPL;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid GADKLDKMHFO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid ONEPFEGIDBG;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid CCAIMHANPNL;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid CEPCNMMNJBD;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid OJIDMLHJFGL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DFANDMOACGP;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid DOBFLBIACOB;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid BKOLBCEOKGO;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FOBGPBMKAAM;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid DCFAABCGAJG;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid DFJKHGLCJPC;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid DDKOILJFKFE;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GPDMHOINGKL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid ELJOLCAGJHA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NHDBFKIJEJM;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid OMOJGJJCPAB;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CDGEGOHEOIO;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid AKKPLKBBOAO;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid IBJKKFOONKK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HJPHEHGIMOC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid ODHILCFDFKA;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid LDNBANNGFKA;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid LNKFOJKCOKB;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid EEHEEIFPINB;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid BNBOJGJJAGK;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid FPJLIBAMFND;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid ABHJLBOLGJL;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid INHEFFLMECG;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid BBIJIIKGECD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid HJJFHGBBGPF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DEFEDNAIOEH;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid CKAJHABMHKC;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EPKKGHJCEPO;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid PNHGPKDGPOO;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid BJIDMOCIDEM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid DGLODCDLHOB;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PPFFIPCAMLN;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid MLDMCMDEFOB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid PONBFBFICNL;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HPGIOCHKNFJ;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MHNNAHEPOHM;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid ICIBPLFKKBL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid DDCALIJLLDN;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HHAALEAPNGK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid EPEGAPAMPBC;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DOOALNMNJAM;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid HKAFJNGJGLN;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid BAHDEBJAOND;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid JMKGGKOKHAO;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid MIGEEFBKMML;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid PLHBMJAHGCK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OAJCPCLBJFC;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid EJHDDNABIHH;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GOOGBECIDHL;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid FIMJKHDKABO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PHPKPDFJFHI;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BHJKIELNFHD;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid FBONJDHIIEB;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid DKEFLOGCEHM;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HMMCNHLDEGC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EJMNEJCIFND;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DBMELDKKEJK;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KCINHBPDOEP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid DMJEMIBOKJF;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid PGNGEBEHCDN;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KMFOGFENPLD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid DNIADMKPPDE;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid KIEFILJIKIE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AKGEJKIIIPF;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid CGOLOHCGMPF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid DOMIDBFCCGJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid JFIIJKBCFPJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid DAFJILKLFLP;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EDOJIIDIINF;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid HNBGAKPMFMG;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid IKBONNDFBEB;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid CADMIJLOMPM;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid AAOOCHHMMPB;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid BKLDHMKHGOE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid JKHFBJJLIFF;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HGPBMDHJGLC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KAKCMCHLDFH;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid HBLLEMFENDD;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid FMKKIOAKABO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid NDLHNEPFAMI;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DMKOJGMEOIP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid LMIAFJACNBB;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CMGKLGLLOPK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DPJJCGLMJKJ;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NNMEALPAIFL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PDEHJHNJBNG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FLOLCCLHDDM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HEBDIKMDFLO;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BEDLPJADLOD;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid IKJPEPPDOMA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IIKOPCAONDM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid MPADKHKJPKO;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NBODJOAPMHP;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid BBACLBOBIDH;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid OHAIAGCFNFA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid NJNCKEMMAJG;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid MHILKPGMPDC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid KPDCJPFMECO;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid ADOHGNPGPPK;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid JGCNEFDPMJK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid IFJIFPJECJI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KEEHAKMEDLL;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid NACNOEOMGFB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid PDFFKEFENMN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid DNJIALIFAHC;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid GNJOECHAHGF;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid MADNIPOKMNH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PMAGLKKMICM;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CGLFKPAFMGH;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid AGFMCOENFLF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid HEDPHEOFCGE;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid GAMLFEAIEGG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid PKBGPFGJCEP;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PNIELDLDABP;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid ANLEBHLGJIC;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid PFHGJKIFEPG;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid CMMBBGAFIHF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid IMEGCNLBDHM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid KOOAHFJNDOL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid NADEMLHFJDN;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid OINGENFEJAE;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid JCBPFBMNFIL;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid CMOJIHPJJGM;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LFDKFHJJBIC;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid LLDPOHFKCPB;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid PGCAIDHGLAI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid PCEJBKHHEBH;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid NLJODICPCBD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid BLOAHNBMLMO;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FMELIJGJJII;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid NPEIIOCPGGD;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid KALDOHCCEKO;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FBNLBGEFBJO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid JFABPHIIFLH;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid LLALIJOFADN;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid FLEFEFADOLM;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MJLADMKNPME;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid IFEAMJJJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid OLNLHOBDGEA;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid DAMEJMANAIL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NGKKGPGJGKC;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid DAENJIGCHDM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JLNGNPHELIK;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid DOFOHEEGIPG;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BLJNEOMJHNL;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid AMHGGOKKBHC;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid PGOCCFOEEJN;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IMJJDHMCKHC;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid NPONIDHOBEA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid ELKCECAPELF;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid BLCAKLDHHLL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid IIPLALOBHNE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid GOLECLJCEOP;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid NBANLCMHILL;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid LIOELCDLINO;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PDILEEEKFAH;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid OEGEBOJHDFM;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid LMBCMIOBPJO;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid HIMPAOLFJLM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid JJDBHPBJPFP;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid MDMILJNNDKM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid LIMCAINJOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid LEDFLFOHIMA;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid JKCKLHMPFOO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid GIEFPJNLKIP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid LJMEBDMPBBK;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid EKAAJAGBCGK;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DIBBMINCJLM;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid IKGHFDDMJLI;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid BFNIAMBNJON;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid LHBAJHOEFOC;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FOEOIIGEOOD;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BAFOLNBBPFA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid CEAINBLKKOK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid JCJICDAMPFN;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid PLJAKADEJJF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid CDIFBMJHLPM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid MBLEMADEDMO;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid BKGOHMCOLNO;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid FOFJLALJAGF;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid EPJGKJDBJIF;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CKLFAFAHPNE;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid LCFCEFCDHMI;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PACBLEMIPKN;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid GPAEPDBGCPE;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid IKLKHCFLEPL;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid LHDAAKJCAJD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid IGICAONJBFI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid KEAPOLMNIAF;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DHHNAHBKEDE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid AJAJJLPJAJC;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid GHAAPMOKGDE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid EKGPIOPEJAF;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid BNNDOCLJLAL;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BBGIPNKOKKP;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid CJKMIPONNEA;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid AHHCEGFDBBN;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid HIFDBOBFAJE;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid ABEOAKHFBNF;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid AJJGHCJNNIJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GEFLBFOOBAG;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid HJIHMFCBFHO;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid NLOCKIOMOKB;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid OFOCFEIFNID;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid IKKALCINJJG;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid FICIEMIJOMO;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid ODHIBPPLENH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid IDCNOLDOBOA;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid OELGLAKDMIH;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid CCIFCAEFFFG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid MEDIGKEEMND;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid FCINFEHBPMD;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IKNGPMMMPCF;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CLAEDNPAANF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid AEGLGOKODHD;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid DDKEOIHHNFH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HNDCCFPLPCF;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid KOEBPKJKBBF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HFCHAFCOHLL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid PAAMGGEDEHG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid OPMAGCGBNHA;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid AKNKPOBGOBE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid BEBIMHENIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid GKDKAPICOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KOHJPCHIOBH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid BIHAFLKILCN;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BOOBLMLOMFH;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid NNDJDCANPOB;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid NBAHMFKBHIK;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid JPCNGLIPPOK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid LJCFFHNKNGI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid IIOLDLIJDPA;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid ENOECLOMNBD;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid LNCMAGLKAJH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid HCELPFPKOBO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OCGPBJJEAIB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid KBEANIAIJNH;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid AKKALKLJLFN;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid EHKPGPEHBAO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid MLBGMFILFBF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid KCGIIPEGCDG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JCMLNNHFGAM;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FHJKOFFGLHP;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid DDBCMOHBAED;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid ICJCBJHJNBA;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EKCMGAKMBJP;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid DBFIDBAJMCB;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid OEANNGPCPIB;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid KGLAGEAOFON;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HAMKGDKMNLG;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BJPOLHDOPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CFHFAJLCOJH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OMJMCKIIGGA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MIKPAICLDAG;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid NJOGHBAAJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid GEKOHDFBFFM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BHLJDMKLEBE;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CDCGHFONEKE;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid OPMFIJBIPOF;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid IFNHPKJBDOJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LHCHJONHDNG;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid LEOOAKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ACENOJNGCPF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FJLFNBKMMIA;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid GGGKFFCCIEN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AMCKKHPJDIO;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid GKGAICKLMFP;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid MJNIFJGJEAK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid IHPNBJOMOPB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid KHBOCDCCAEO;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid GECKOCCNJBL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid MGLFEBCNEBB;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid BFIHHKMFEML;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid PIELEDCPNFG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid HBEFDEKKDNA;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IEFNKEAECDN;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid CDHEFBMIHNB;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid KJHDKJAKEIO;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid MDJDBMKFHEM;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid GJACJOGLHOH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid JENDMEIJHOI;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PJGIEMFLOFL;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid OJDNNMCIIFL;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid LPPLFGCLMDH;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid ODEACFJLAEA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid BNCPDCALDCB;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid KEHCAPDHAAF;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid IALGPHOICAJ;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid GBLAJAOPMPD;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid IDBOCADOGOE;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid AINFCCNGFOK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid HJJPEHIPPNC;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid EADCHDNEJFJ;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid HICDIBOABON;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid CKLCKJKNKCB;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid PLIKEOHOKMK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid EJDNOBEMAAF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid NKIFDAOIPLB;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid CFPFFJLODDB;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid OJDPBPCLJBJ;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid PFIGONCDCEM;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid GIHHOADEHLL;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid HNENHKABAAG;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid NENFOFKGDHE;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid NNMAFEBAACI;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid CINAICNFNKK;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IMLDBHOOBNL;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BKPDJBPANGJ;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid GLEJDDPLDJA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid JJNEBBOJHKB;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid MBIELKKKLJF;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid OKABLGPNFDD;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid GJPEFEHPLLC;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid EPJENBBPMNK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid NHCLCOIEFKK;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid KLHOKGLHHJL;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid IPJCNDLNCNC;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid CJMAGHIPBPG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid BBNOACFCNME;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid PIKFDANFOLA;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid BKPEHEFJBII;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid LGFJNFIAMBD;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid LOAMAOELADO;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid ICGHEJOOBKL;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid NJDNDPGGOGN;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid GPOADFEBNDG;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid GLDLOKGADKF;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid IGHMNPDPBFL;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid JCFKHPCPMMC;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid OHJKOEJNAJJ;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid APKBGCFKEDO;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NMKJMEKDILE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid MMOPPJDOLOJ;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid OBECACHOOIN;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IABKAKNGOIG;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid KLDOEHLBJIE;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid CLDODLKIKFN;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid AFJBKDEGIJC;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid JFMAAHBOAOH;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid GCDJELMJPPI;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid AEMGAPIFAIK;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid AAIPFJJMFIJ;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid IDJIPBOJNGH;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid EBCAJHANNAN;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid DEMLGFDKFFP;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid JJBIHKBFNMF;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid IFOOOHNCJDE;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid EBMLOGFIOOB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid CGPAEDJNMJF;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid AGLCEMFCLDG;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid IBECAOJAMHH;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid MKLKFKAHCDD;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AJECLAGKIEA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid ALJJJODPJFO;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LNOGAGEOHNB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid KGOBJOINFLC;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid IHNLDKEFFJN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid NDEPGILFNGA;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid KIAJEEFDDCL;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid KIOFNPMOOKK;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid NBCOEFNEJBE;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid CKDMLAFFGPM;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid EKIEMJIKCIB;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid EPJGPFMBLKB;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid BHMOPGCDEJF;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid JMHOCKIOEJA;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid BLABKIEIIDE;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid PFKCMIHLEEH;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid IPHNFLJDFCL;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid GHDHCGJLMMG;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid FMDFCMJCKEE;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid DBFFDCLFPFN;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid DFMCMHILDBG;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid AFHCFAJPOMA;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid NDBEFGHCLKP;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid MGKMPPBJHLF;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid HBNCKCDLJMJ;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid JALJLLHAPKE;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid NNOAOJGBKDL;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid OMJEFIIDGPK;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid BPBPFAONIIA;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid JBAPIPEINII;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid JACGDJBGMLL;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid CIDHJNPHOIG;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid HAOOLLGDPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid NNPPNMKMLCH;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private static readonly Dictionary<Guid, AAFGMPNJNKB> MDDOFAJNCAH;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private static readonly Dictionary<AAFGMPNJNKB, Guid> GDJGDNODNOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, AAFGMPNJNKB> EJBLHJJJCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77FE640", Offset = "0x77FDA40", VA = "0x1877FE640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<AAFGMPNJNKB, Guid> IADKKENPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77FE6A0", Offset = "0x77FDAA0", VA = "0x1877FE6A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LDPCMDLPIIF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77FF750", Offset = "0x77FEB50", VA = "0x1877FF750")]
	public static bool BHLKBNPIDDI(KDFIOBGMCKI JMMCJMCMHFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77FF3A0", Offset = "0x77FE7A0", VA = "0x1877FF3A0")]
	private static bool BHLKBNPIDDI(PGGPHIEPECH INAPFKLHCFN, KDFIOBGMCKI JMMCJMCMHFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLOEJKDOJAC
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(GLFFEKDOONK HPMNBNLACCC, [Out] Dictionary<int, int> ODJJGKDICKO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CECIAOOGNBJ IMBPBNFJOJI, OHKCFPDJBLP ENEJNOFHCKK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NBPCEOCLKPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public readonly FKHMMAMFILM HNCHLIJOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public readonly IEnumerable<AJANKEAEBKF> BAOFPGCHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public readonly IReadOnlyList<AJANKEAEBKF> KMDGPPKMKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public readonly IJOGBJOFPED<IIPIDDOCOEJ> ANLABBNIHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public readonly IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> BPILBGPMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public readonly PMPPGEHDHDG IDFGCEEIFJG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DNGIKEGIDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7801A30", Offset = "0x7800E30", VA = "0x187801A30")]
	public NBPCEOCLKPL(FKHMMAMFILM AMKOHDPAPAH, IEnumerable<AJANKEAEBKF> MMILFLIJGKL, IReadOnlyList<AJANKEAEBKF> IGMNEMEHKGA, IJOGBJOFPED<IIPIDDOCOEJ> KDPCJIDKAOJ, IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> NKNAKCLICEO, PMPPGEHDHDG JDEGECKGDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LAJJJIBBMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public readonly FKHMMAMFILM HNCHLIJOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public readonly IReadOnlyList<AJANKEAEBKF> HNJDFAPBFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public readonly IJOGBJOFPED<IIPIDDOCOEJ> ANLABBNIHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public readonly IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> BPILBGPMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly ByteString MKFKHBADIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly PMPPGEHDHDG IDFGCEEIFJG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77FF330", Offset = "0x77FE730", VA = "0x1877FF330")]
	public LAJJJIBBMCJ(FKHMMAMFILM AMKOHDPAPAH, IJOGBJOFPED<IIPIDDOCOEJ> KDPCJIDKAOJ, IReadOnlyList<HNEIHDEKOKM<EICBKBBFNCN>> NKNAKCLICEO, ByteString IPFKGJNKLLP, IReadOnlyList<AJANKEAEBKF> BBPKDHCIDPH, PMPPGEHDHDG JDEGECKGDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FDGJONAJEGL : CDPGIEKANHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly Guid HABBGKDBAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private readonly Dictionary<Guid, Guid> IMOLDFICHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4785340", Offset = "0x4784740", VA = "0x184785340")]
	private FDGJONAJEGL(Guid PEAIBFEEFNN, Dictionary<Guid, Guid> IMOLDFICHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77FEF00", Offset = "0x77FE300", VA = "0x1877FEF00")]
	public static FDGJONAJEGL HBLBJMFGHFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77FEF90", Offset = "0x77FE390", VA = "0x1877FEF90")]
	private static Dictionary<Guid, Guid> JILALMGEAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x77FF320", Offset = "0x77FE720", VA = "0x1877FF320")]
	public static FDGJONAJEGL MLEHEJFNBMM(IReadOnlyDictionary<Guid, Guid> IEAOMLJNJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77FEB90", Offset = "0x77FDF90", VA = "0x1877FEB90")]
	public static FDGJONAJEGL CJNKOJHGIHK(IEnumerable<KeyValuePair<Guid, Guid>> IEAOMLJNJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77FEE80", Offset = "0x77FE280", VA = "0x1877FEE80")]
	public Dictionary<Guid, Guid> FDLGLIFOKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
	public Dictionary<Guid, Guid> MGFABAPOOCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77FF0E0", Offset = "0x77FE4E0", VA = "0x1877FF0E0")]
	public void JJBKLNLGAIJ(Guid IEAOMLJNJLM, Guid NOOEFABFCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77FE910", Offset = "0x77FDD10", VA = "0x1877FE910")]
	public void AHFPINECEEG(IReadOnlyDictionary<Guid, Guid> OAPKJBPLDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77FF1D0", Offset = "0x77FE5D0", VA = "0x1877FF1D0")]
	public Guid LIENCPOMHFE([In] Guid IEAOMLJNJLM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77FF040", Offset = "0x77FE440", VA = "0x1877FF040")]
	public Guid JIPHMKMLBHE([In] Guid IEAOMLJNJLM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77FF160", Offset = "0x77FE560", VA = "0x1877FF160")]
	public bool KKEAJLPKNJO([In] Guid IEAOMLJNJLM, [Out] Guid NOOEFABFCIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77FF160", Offset = "0x77FE560", VA = "0x1877FF160", Slot = "4")]
	private bool KOLOEKPAOLK([In] Guid IEAOMLJNJLM, [Out] Guid NOOEFABFCIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HDIPPPGHJED
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
public sealed class ANGFJFHLANP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CPBHAJGLAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public FKHMMAMFILM staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CPBHAJGLAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77FE5D0", Offset = "0x77FD9D0", VA = "0x1877FE5D0")]
		internal IJOGBJOFPED<GOENONHHIDE> HFDLOPPLKHP((IJOGBJOFPED<IIPIDDOCOEJ> GraphId, IJOGBJOFPED<EICBKBBFNCN> NodeId) i)
		{
			return default(IJOGBJOFPED<GOENONHHIDE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private static readonly OEEMOMGNMIG<GOENONHHIDE, int?> DJBBCGFOOHM;

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly long IPNGFLJKHML;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77EDCB0", Offset = "0x77ED0B0", VA = "0x1877EDCB0")]
	public static (long, long) KELFCCJDGBM(FKHMMAMFILM PFBIIMDEJON, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77EE0E0", Offset = "0x77ED4E0", VA = "0x1877EE0E0")]
	public static long KJOLAEIMGAP([In] ReadOnlySpan<IJOGBJOFPED<GOENONHHIDE>> KOJJNBAOKMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77EDB90", Offset = "0x77ECF90", VA = "0x1877EDB90")]
	private static long GMAFMAMJGBL()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EGJPNPBLPKJ
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public static readonly HashSet<AAFGMPNJNKB> PCHGIFGNACI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CMPGCBLAAPE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AJKEHBGOGBL : IEnumerable<AJANKEAEBKF>, IEnumerable, IEnumerator<AJANKEAEBKF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private AJANKEAEBKF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private GJFHOGEHOEN spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public GJFHOGEHOEN <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private LEDMHIIMKEB spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public LEDMHIIMKEB <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private AJANKEAEBKF System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public AJKEHBGOGBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77ED8C0", Offset = "0x77ECCC0", VA = "0x1877ED8C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77EDB40", Offset = "0x77ECF40", VA = "0x1877EDB40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77ED9D0", Offset = "0x77ECDD0", VA = "0x1877ED9D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<AJANKEAEBKF> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77ED9D0", Offset = "0x77ECDD0", VA = "0x1877ED9D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x77FBD20", Offset = "0x77FB120", VA = "0x1877FBD20")]
	public static GJFHOGEHOEN IFNMFLHNDDM([In] LAJJJIBBMCJ HKJIFKCIMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77FBEA0", Offset = "0x77FB2A0", VA = "0x1877FBEA0")]
	public static GJFHOGEHOEN IFNMFLHNDDM([In] NBPCEOCLKPL HKJIFKCIMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x77FDA40", Offset = "0x77FCE40", VA = "0x1877FDA40")]
	private static HashSet<HNEIHDEKOKM<JAAKNCCKNAM>> NPCFECLMJCP(IReadOnlyList<AJANKEAEBKF> PPELGBEJKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x77FB240", Offset = "0x77FA640", VA = "0x1877FB240")]
	private static void BOACMCEOAKI(GJFHOGEHOEN DFIPIEIPLIL, [In] NBPCEOCLKPL NJHMFPDKMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x77FC020", Offset = "0x77FB420", VA = "0x1877FC020")]
	public static KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD> NJBLHPOCNPI(GJFHOGEHOEN DFIPIEIPLIL, LEDMHIIMKEB ALMPKCCMMPO, FDGJONAJEGL? IOEIFJKKPCI, bool HKKLKFKMNJC)
	{
		return default(KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x77FB930", Offset = "0x77FAD30", VA = "0x1877FB930")]
	[IteratorStateMachine(typeof(AJKEHBGOGBL))]
	private static IEnumerable<AJANKEAEBKF> GNGLKEPGCLK(GJFHOGEHOEN DFIPIEIPLIL, LEDMHIIMKEB ALMPKCCMMPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x77FE560", Offset = "0x77FD960", VA = "0x1877FE560")]
	private static void PDPGAJHFNLC(GJFHOGEHOEN DFIPIEIPLIL, LEDMHIIMKEB ALMPKCCMMPO, IReadOnlyCollection<ByteString>? DBMFDGFMHGD, IReadOnlyCollection<ByteString>? KPFGKICBCEJ, IReadOnlyCollection<ByteString>? IMBCLFMGIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x77FD3A0", Offset = "0x77FC7A0", VA = "0x1877FD3A0")]
	private static bool NJGOMECBIKP(GJFHOGEHOEN DFIPIEIPLIL, CECIAOOGNBJ IMBPBNFJOJI, LEDMHIIMKEB ALMPKCCMMPO, [Out][NotNullWhen(false)] string? AFHGIBDEPMG, [Out] Dictionary<int, int> ODJJGKDICKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x77FBA40", Offset = "0x77FAE40", VA = "0x1877FBA40")]
	private static Dictionary<Guid, PGGPHIEPECH> HNMEHMBMKJI(GJFHOGEHOEN DFIPIEIPLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x77FB8A0", Offset = "0x77FACA0", VA = "0x1877FB8A0")]
	private static void GJEBOGCLLNA(bool EILLGGOAABF, AJANKEAEBKF LLCPKAOMDKB, FDGJONAJEGL DOFJJLPMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77FE290", Offset = "0x77FD690", VA = "0x1877FE290")]
	private static void OHPIPBKMEFB(AJANKEAEBKF LLCPKAOMDKB, Guid OAGBMEMFNEC, HBGPLGNJAFP? FJCLEKOFLIC, Dictionary<Guid, PGGPHIEPECH> PEKDCFAHDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77FDDE0", Offset = "0x77FD1E0", VA = "0x1877FDDE0")]
	private static void OAILELAFKMD(IEnumerable<AJANKEAEBKF> LEKKGFMOAKF, IReadOnlyCollection<ByteString> DBMFDGFMHGD, IReadOnlyCollection<ByteString> KPFGKICBCEJ, IReadOnlyCollection<ByteString> IMBCLFMGIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LEDMHIIMKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool EILLGGOAABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public PMPPGEHDHDG JDEGECKGDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public HBGPLGNJAFP? FJCLEKOFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public HBGPLGNJAFP? CANICLOCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public FKHMMAMFILM PAMEHHNGMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public HDIPPPGHJED DHLJNCCCHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public PLOEJKDOJAC KFDAJBGDHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public HNEIHDEKOKM<IIPIDDOCOEJ> ICBOOCHOAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public LPCHFMKMBHL HEGHFNIJCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public List<AJANKEAEBKF> CNPMEHJNPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public NKNHEFKHIEC JABMAAHJJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public BDCNJCBJENN OJOAFNPGHPP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HBGPLGNJAFP
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private const float KMJHOPMPEFJ = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public Vector3 INHMOEHIHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public Quaternion AJFJKBHPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public float KJPCKOGHHCN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 PHIFMGOOJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7804700", Offset = "0x7803B00", VA = "0x187804700")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS KIAADAGNFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x78046C0", Offset = "0x7803AC0", VA = "0x1878046C0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x12A34D0", Offset = "0x12A28D0", VA = "0x1812A34D0")]
	public HBGPLGNJAFP(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float KJPCKOGHHCN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7804C20", Offset = "0x7804020", VA = "0x187804C20")]
	public HBGPLGNJAFP(UniformTRS OFCIAIFNCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x78048A0", Offset = "0x7803CA0", VA = "0x1878048A0")]
	public static HBGPLGNJAFP OGFIHHGOBJB(HBGPLGNJAFP KLDFHLFOOFN, HBGPLGNJAFP JLEPMHLOLMN)
	{
		return default(HBGPLGNJAFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7804520", Offset = "0x7803920", VA = "0x187804520")]
	public static HBGPLGNJAFP CLMIANKGGAM((Vector3, Quaternion, float) HPMNBNLACCC)
	{
		return default(HBGPLGNJAFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7804540", Offset = "0x7803940", VA = "0x187804540")]
	public static HBGPLGNJAFP CLMIANKGGAM(Matrix4x4 CIBFGKMMHIG)
	{
		return default(HBGPLGNJAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7804B90", Offset = "0x7803F90", VA = "0x187804B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7804440", Offset = "0x7803840", VA = "0x187804440")]
	public HBGPLGNJAFP BFFDIFNFLON(Matrix4x4 KHDOKFIGIID)
	{
		return default(HBGPLGNJAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7804B20", Offset = "0x7803F20", VA = "0x187804B20")]
	public static HBGPLGNJAFP PDJGKMBHNFL(Vector3 INHMOEHIHAJ)
	{
		return default(HBGPLGNJAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7804810", Offset = "0x7803C10", VA = "0x187804810")]
	public readonly OGKLGKEPIME NOIIKCNABCJ()
	{
		return default(OGKLGKEPIME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum GGHBBAIPEIE
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct AMIFPGHHAMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public readonly MGFAONBINNM KDGBOJEHLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly ALOCPDILHNE OCMEIJOCFON;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1536EA0", Offset = "0x15362A0", VA = "0x181536EA0")]
	private AMIFPGHHAMD(MGFAONBINNM AGBLNEPGFKF, ALOCPDILHNE JHILPMHBEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7802510", Offset = "0x7801910", VA = "0x187802510")]
	public IFNDEKFLNMG ADDLMCFKJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7802640", Offset = "0x7801A40", VA = "0x187802640")]
	public static KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD> HBLBJMFGHFK(AJOONLBHDFN<LPCAMBCOBBH> JHILPMHBEAE)
	{
		return default(KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78026F0", Offset = "0x7801AF0", VA = "0x1878026F0")]
	public static KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD> HBLBJMFGHFK(IFNDEKFLNMG JHILPMHBEAE)
	{
		return default(KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7802580", Offset = "0x7801980", VA = "0x187802580")]
	public static KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD> HBLBJMFGHFK(string FBNMFJBDLBJ)
	{
		return default(KGPHFOFOMPJ<FDGJONAJEGL, AMIFPGHHAMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MGFAONBINNM
{
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OLANLGHAKMJ : IDisposable, MGEJOGHOFMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private NativeList<NPAMCAHKLLB> NKAMAGDGADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private float INOCILPHAOB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AEPLEEMHJAE CGHCBPAPPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0")]
		[CompilerGenerated]
		get
		{
			return default(AEPLEEMHJAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GEJIEIINNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6783400", Offset = "0x6782800", VA = "0x186783400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool CPIKKFPKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6783410", Offset = "0x6782810", VA = "0x186783410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<NMFEOPJMKMG> AOKGNIIHCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MDGENNPIBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x780B440", Offset = "0x780A840", VA = "0x18780B440", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float MDMJNNLIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x780CEE0", Offset = "0x780C2E0", VA = "0x18780CEE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x780D1E0", Offset = "0x780C5E0", VA = "0x18780D1E0")]
	public OLANLGHAKMJ(AEPLEEMHJAE KHCEBCMPDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x780B480", Offset = "0x780A880", VA = "0x18780B480", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x780C8E0", Offset = "0x780BCE0", VA = "0x18780C8E0")]
	public Vector3 IPEFFBBKKMK(int NMAOAJDPHDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x780B150", Offset = "0x780A550", VA = "0x18780B150", Slot = "6")]
	public Quaternion CDFPEKNOFOE(int NMAOAJDPHDG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x780B4E0", Offset = "0x780A8E0", VA = "0x18780B4E0", Slot = "5")]
	public Vector3 FAEHEKEDMEI(int NMAOAJDPHDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x780CE80", Offset = "0x780C280", VA = "0x18780CE80", Slot = "7")]
	public float KEAMNFFPBEJ(int NMAOAJDPHDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x780BF40", Offset = "0x780B340", VA = "0x18780BF40")]
	public void HHHJABJBOBH(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN, bool JDBJPOKGAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x780D020", Offset = "0x780C420", VA = "0x18780D020")]
	private bool LOFCOBJJEGG(int OMJMCJFMAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x780AFD0", Offset = "0x780A3D0", VA = "0x18780AFD0")]
	public void CALDNHFONCM(Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x780C850", Offset = "0x780BC50", VA = "0x18780C850")]
	public void IDMDPNPPJOL(int OMJMCJFMAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x780B2F0", Offset = "0x780A6F0", VA = "0x18780B2F0")]
	public void DCBBLGCIKHO(int OMJMCJFMAEC, Vector3 INHMOEHIHAJ, Quaternion AJFJKBHPFHG, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x780BD90", Offset = "0x780B190", VA = "0x18780BD90")]
	public void HCGNCIKBIDL(int OMJMCJFMAEC, float3 INHMOEHIHAJ, quaternion AJFJKBHPFHG, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x780AE80", Offset = "0x780A280", VA = "0x18780AE80")]
	public void BJGFNGCCDJN(int OMJMCJFMAEC, Vector3 INHMOEHIHAJ, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x780D080", Offset = "0x780C480", VA = "0x18780D080")]
	public void OJJFDFNKBLA(int OMJMCJFMAEC, Vector3 BELINKGJHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x780B580", Offset = "0x780A980", VA = "0x18780B580")]
	public static Quaternion FBHOJKBLNJJ(Quaternion CLAPLHOFOCL, int OMJMCJFMAEC, float FHDPKENDHHG, MGEJOGHOFMB LBDEADMEFAB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x780A9E0", Offset = "0x7809DE0", VA = "0x18780A9E0")]
	public Bounds BEGHGMFPEOH(Transform KHDOKFIGIID)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x780B280", Offset = "0x780A680", VA = "0x18780B280", Slot = "10")]
	public virtual void CJLAFBGEEAD(bool OLFEKIEFLOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x780CDB0", Offset = "0x780C1B0", VA = "0x18780CDB0")]
	public NativeList<NPAMCAHKLLB> JGNKCHOCOHJ(float DJBLLBGHJKF = 1f)
	{
		return default(NativeList<NPAMCAHKLLB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NMFEOPJMKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public float3 KLIFIKMFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public float DNCJLMMFDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public quaternion FLOEGJNKEGE;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x780A960", Offset = "0x7809D60", VA = "0x18780A960")]
	public NMFEOPJMKMG(Vector3 HDCIJLICBPE, Quaternion CLAPLHOFOCL, float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x780A700", Offset = "0x7809B00", VA = "0x18780A700")]
	public Quaternion KDOHGNIDMMF(Vector3 GOMJGIJPEPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x780A410", Offset = "0x7809810", VA = "0x18780A410")]
	public NMFEOPJMKMG INJIDPFHMCH(Vector3 HDBCFOLFNAG, Vector3 PHDAOMIKAEK, Vector3 LGCFJLIODLF)
	{
		return default(NMFEOPJMKMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x780A7C0", Offset = "0x7809BC0", VA = "0x18780A7C0")]
	public MOHJALJOHDG PLDKCFIDFOH(Vector3 GOMJGIJPEPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class ABDFHOGPKDK : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7801BD0", Offset = "0x7800FD0", VA = "0x187801BD0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7801C50", Offset = "0x7801050", VA = "0x187801C50")]
	private void HIGNIPKJOBC(Dictionary<Guid, Guid> NMJDLOPPLAC, IKDFKAGOHDD CDCPPBNMECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7802230", Offset = "0x7801630", VA = "0x187802230")]
	private void HIGNIPKJOBC(Dictionary<Guid, Guid> NMJDLOPPLAC, GDHKNMBNDDM PNJALCDMDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7802290", Offset = "0x7801690", VA = "0x187802290")]
	private void HIGNIPKJOBC(Dictionary<Guid, Guid> NMJDLOPPLAC, FLCHKOCAIKL GEOBBHOELPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public ABDFHOGPKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class DDBBGCJGBEA : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7802C60", Offset = "0x7802060", VA = "0x187802C60", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public DDBBGCJGBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class IGBEIHICKDD : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x78052E0", Offset = "0x78046E0", VA = "0x1878052E0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public IGBEIHICKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class BAEGAAGLGGG : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x78027A0", Offset = "0x7801BA0", VA = "0x1878027A0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public BAEGAAGLGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class JPJDMOKILLB : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7806000", Offset = "0x7805400", VA = "0x187806000", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public JPJDMOKILLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class GBNLHFCCECO : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7802FE0", Offset = "0x78023E0", VA = "0x187802FE0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GBNLHFCCECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IPMKKJBIFIB : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7805440", Offset = "0x7804840", VA = "0x187805440", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public IPMKKJBIFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EHEILHPAKPF : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7802EF0", Offset = "0x78022F0", VA = "0x187802EF0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public EHEILHPAKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CHDDOKBEMDN : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7802AA0", Offset = "0x7801EA0", VA = "0x187802AA0", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public CHDDOKBEMDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NIGEHEJEJEL : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x780A250", Offset = "0x7809650", VA = "0x18780A250", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public NIGEHEJEJEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JFDENFNEEHD : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7805F00", Offset = "0x7805300", VA = "0x187805F00", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public JFDENFNEEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GKCCCMOIIOH : LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public static readonly GMFCIKPILEI DNFHPJNNBNM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7803120", Offset = "0x7802520", VA = "0x187803120", Slot = "4")]
	public void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GKCCCMOIIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KDFIOBGMCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public CECIAOOGNBJ IOFNCNFBMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public BLLECNEFLJH ODLLAENGAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	public Dictionary<int, int> LCOKNFPJJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public Dictionary<Guid, Guid> LKPGCBMECHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public BDCNJCBJENN OJOAFNPGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public bool HKKLKFKMNJC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LCNMJMEAHGH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJGLFAEHKAL(LOIDIAHFBHD FCLDNCGEPDK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KGKILFDGCMG
{
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private static readonly LCNMJMEAHGH[] HNOPNNFIHOH;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7806890", Offset = "0x7805C90", VA = "0x187806890")]
	public static void GFPGJBOONKL(AJANKEAEBKF HPMNBNLACCC, FDGJONAJEGL CLCOBGKMHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x78065F0", Offset = "0x78059F0", VA = "0x1878065F0")]
	public static void FHLNPFHPMCF(AJANKEAEBKF? HPMNBNLACCC, FDGJONAJEGL IHNMKJMHLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7806B10", Offset = "0x7805F10", VA = "0x187806B10")]
	public static void IDADFPAEGGO(AJANKEAEBKF? HPMNBNLACCC, FDGJONAJEGL DOFJJLPMOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7806220", Offset = "0x7805620", VA = "0x187806220")]
	public static void BHLKBNPIDDI(LOIDIAHFBHD FCLDNCGEPDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LOIDIAHFBHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	public CECIAOOGNBJ DJBNMKPDJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	public AJANKEAEBKF LLCPKAOMDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public Dictionary<int, int> LCOKNFPJJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	public Dictionary<Guid, Guid> LKPGCBMECHD;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x780A1A0", Offset = "0x78095A0", VA = "0x18780A1A0")]
	public Guid EAPCCPHDGML(Guid KDBHLLEACIN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BDCNJCBJENN
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MPMIOODMBHB, [Out] Guid HAKKJNGNPMC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LMBINBOIHNM
{
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private static readonly ProfilerMarker DFKJCBCEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private readonly HashSet<string> CBLOAFIJHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private readonly Dictionary<long, int> OHOLFLKBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private readonly HashSet<Guid> NDHKCHLBILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private readonly HashSet<Guid> EKCJACKLPAH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> GGOIBNGNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<Guid> MDMGKOGPKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> NLDNGDGJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7809370", Offset = "0x7808770", VA = "0x187809370")]
	public static void OFJMJCEBMLA(GJFHOGEHOEN NFDGFGANBGL, HLKKJKFMIAO AGOBBPJADOI, FDGJONAJEGL LHOCDDNBHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7807360", Offset = "0x7806760", VA = "0x187807360")]
	public static LMBINBOIHNM BAHCIPINBIP(AOIFKBLFGKD LLMAFCHBBPF, [Optional] HLKKJKFMIAO? AGOBBPJADOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x78075C0", Offset = "0x78069C0", VA = "0x1878075C0")]
	public static LMBINBOIHNM GEMBHALPGMJ(GJFHOGEHOEN JCBEMBCJJDD, [Optional] HLKKJKFMIAO? AGOBBPJADOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7809BB0", Offset = "0x7808FB0", VA = "0x187809BB0")]
	public static LMBINBOIHNM PKBCAHCPIMO(IEnumerable<string> CBLOAFIJHFK, IDictionary<long, int> MCCLLFNCLID, IReadOnlyCollection<Guid> EKCJACKLPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7809E70", Offset = "0x7809270", VA = "0x187809E70")]
	private LMBINBOIHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7809FD0", Offset = "0x78093D0", VA = "0x187809FD0")]
	private LMBINBOIHNM(IEnumerable<string> CBLOAFIJHFK, IDictionary<long, int> MCCLLFNCLID, IReadOnlyCollection<Guid> EKCJACKLPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7808180", Offset = "0x7807580", VA = "0x187808180")]
	private void NOINGPDMFIC(AOIFKBLFGKD LLMAFCHBBPF, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7807F60", Offset = "0x7807360", VA = "0x187807F60")]
	private void NOINGPDMFIC(GJFHOGEHOEN JCBEMBCJJDD, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7807640", Offset = "0x7806A40", VA = "0x187807640")]
	private void KEDJNPCHAKL(ByteString? IPFKGJNKLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x78085B0", Offset = "0x78079B0", VA = "0x1878085B0")]
	private void NOINGPDMFIC(KKGLKNAHIHO? BKHMOJGGBFN, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7808910", Offset = "0x7807D10", VA = "0x187808910")]
	private static void OFJMJCEBMLA(KKGLKNAHIHO? BKHMOJGGBFN, HLKKJKFMIAO AGOBBPJADOI, FDGJONAJEGL LHOCDDNBHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7809100", Offset = "0x7808500", VA = "0x187809100")]
	private static void OFJMJCEBMLA(ANNEGHIHGIH? BLGGFHHEDNC, HLKKJKFMIAO AGOBBPJADOI, FDGJONAJEGL LHOCDDNBHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x78083A0", Offset = "0x78077A0", VA = "0x1878083A0")]
	private void NOINGPDMFIC(ANNEGHIHGIH? BLGGFHHEDNC, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x78073E0", Offset = "0x78067E0", VA = "0x1878073E0")]
	private void ELJBFNFDKNJ(Guid? KDBHLLEACIN, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7807B60", Offset = "0x7806F60", VA = "0x187807B60")]
	private void NOINGPDMFIC(AJANKEAEBKF? LLCPKAOMDKB, HLKKJKFMIAO? AGOBBPJADOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7808CB0", Offset = "0x78080B0", VA = "0x187808CB0")]
	private static void OFJMJCEBMLA(AJANKEAEBKF? LLCPKAOMDKB, HLKKJKFMIAO AGOBBPJADOI, FDGJONAJEGL LHOCDDNBHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7807AF0", Offset = "0x7806EF0", VA = "0x187807AF0")]
	private void LBCPPAIJFLB(string? AAONMEAJPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7809A80", Offset = "0x7808E80", VA = "0x187809A80")]
	private void OKMGHJONHCA(long MECDHNFPFJI, Guid BMLBMKLGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7809A30", Offset = "0x7808E30", VA = "0x187809A30")]
	private void OKMGHJONHCA(NNDECOOIPBP? DFEOOOBLPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7809B50", Offset = "0x7808F50", VA = "0x187809B50")]
	private void OKMGHJONHCA(ALCGHNFBBFL? DFEOOOBLPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GLPFMGNOPMK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class ICAMMBOPFHC : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private readonly IEnumerator<DictionaryEntry> CBEBKIBOLIJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DictionaryEntry KDCIFHBCHNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x78050B0", Offset = "0x78044B0", VA = "0x1878050B0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7805180", Offset = "0x7804580", VA = "0x187805180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object HDKOPKMNJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7805230", Offset = "0x7804630", VA = "0x187805230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7804FD0", Offset = "0x78043D0", VA = "0x187804FD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
		public ICAMMBOPFHC(IEnumerator<DictionaryEntry> CBEBKIBOLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7804F30", Offset = "0x7804330", VA = "0x187804F30", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7804F80", Offset = "0x7804380", VA = "0x187804F80", Slot = "9")]
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
		private sealed class BJMPNMENFFP : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A6C0", VA = "0x180B4B2C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7802A50", Offset = "0x7801E50", VA = "0x187802A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public BJMPNMENFFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7802900", Offset = "0x7801D00", VA = "0x187802900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7802A00", Offset = "0x7801E00", VA = "0x187802A00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x780D840", Offset = "0x780CC40", VA = "0x18780D840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IDictionary.this[object DJBLFBEBKGO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x780D750", Offset = "0x780CB50", VA = "0x18780D750", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x780D930", Offset = "0x780CD30", VA = "0x18780D930", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x780D690", Offset = "0x780CA90", VA = "0x18780D690", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x780D6F0", Offset = "0x780CAF0", VA = "0x18780D6F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x780D8D0", Offset = "0x780CCD0", VA = "0x18780D8D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x780D350", Offset = "0x780C750", VA = "0x18780D350", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x780D3B0", Offset = "0x780C7B0", VA = "0x18780D3B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x780D410", Offset = "0x780C810", VA = "0x18780D410", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
		public RoomObjectCounts(Dictionary<int, int> BGFCJAKEJHO, [Optional] Dictionary<int, int> INBAEHPCLMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x780D270", Offset = "0x780C670", VA = "0x18780D270")]
		[IteratorStateMachine(typeof(BJMPNMENFFP))]
		private IEnumerator<DictionaryEntry> JIKFHNKJCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x780D980", Offset = "0x780CD80", VA = "0x18780D980", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x780D590", Offset = "0x780C990", VA = "0x18780D590", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x780D470", Offset = "0x780C870", VA = "0x18780D470", Slot = "9")]
		void IDictionary.Add(object DJBLFBEBKGO, object FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x780D4D0", Offset = "0x780C8D0", VA = "0x18780D4D0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x780D530", Offset = "0x780C930", VA = "0x18780D530", Slot = "8")]
		bool IDictionary.Contains(object DJBLFBEBKGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x780D630", Offset = "0x780CA30", VA = "0x18780D630", Slot = "14")]
		void IDictionary.Remove(object DJBLFBEBKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x780D2F0", Offset = "0x780C6F0", VA = "0x18780D2F0", Slot = "15")]
		void ICollection.CopyTo(Array LLPLHOOOAEB, int CJFNAFNJJLB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class EGAAHKGCECJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A6C0", VA = "0x180B4B2C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7802EA0", Offset = "0x78022A0", VA = "0x187802EA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public EGAAHKGCECJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7802D10", Offset = "0x7802110", VA = "0x187802D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7802E50", Offset = "0x7802250", VA = "0x187802E50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7805C20", Offset = "0x7805020", VA = "0x187805C20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IDictionary.this[object DJBLFBEBKGO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7805AF0", Offset = "0x7804EF0", VA = "0x187805AF0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7805CD0", Offset = "0x78050D0", VA = "0x187805CD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7805A30", Offset = "0x7804E30", VA = "0x187805A30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7805A90", Offset = "0x7804E90", VA = "0x187805A90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7805C70", Offset = "0x7805070", VA = "0x187805C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x78056B0", Offset = "0x7804AB0", VA = "0x1878056B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7805710", Offset = "0x7804B10", VA = "0x187805710", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7805770", Offset = "0x7804B70", VA = "0x187805770", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2668BD0", Offset = "0x2667FD0", VA = "0x182668BD0")]
		public Invention(long NCJKGMLAKGH, int ECKHNAPCKGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x78055E0", Offset = "0x78049E0", VA = "0x1878055E0")]
		[IteratorStateMachine(typeof(EGAAHKGCECJ))]
		private IEnumerator<DictionaryEntry> JIKFHNKJCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7805D20", Offset = "0x7805120", VA = "0x187805D20", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x78058F0", Offset = "0x7804CF0", VA = "0x1878058F0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x78057D0", Offset = "0x7804BD0", VA = "0x1878057D0", Slot = "9")]
		void IDictionary.Add(object DJBLFBEBKGO, object FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7805830", Offset = "0x7804C30", VA = "0x187805830", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7805890", Offset = "0x7804C90", VA = "0x187805890", Slot = "8")]
		bool IDictionary.Contains(object DJBLFBEBKGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x78059D0", Offset = "0x7804DD0", VA = "0x1878059D0", Slot = "14")]
		void IDictionary.Remove(object DJBLFBEBKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7805650", Offset = "0x7804A50", VA = "0x187805650", Slot = "15")]
		void ICollection.CopyTo(Array LLPLHOOOAEB, int CJFNAFNJJLB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> ONCPNEGKANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public readonly IReadOnlyList<Invention> PGIPGBDOHIL;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
	public GLPFMGNOPMK(IReadOnlyDictionary<Guid, RoomObjectCounts> KCOMFKJOGHK, IReadOnlyList<Invention> JOLAMBIJHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7803250", Offset = "0x7802650", VA = "0x187803250")]
	public static GLPFMGNOPMK BAHCIPINBIP(AOIFKBLFGKD LLMAFCHBBPF)
	{
		return default(GLPFMGNOPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7803C60", Offset = "0x7803060", VA = "0x187803C60")]
	[CompilerGenerated]
	internal static int OLLALAKLJME([In] IReadOnlyDictionary<long, int> JEPHLJIJLCC, long? MECDHNFPFJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7803D80", Offset = "0x7803180", VA = "0x187803D80")]
	[CompilerGenerated]
	internal static void PAOMOCEIABO(int DHGAHNKIPJG, [In] KKGLKNAHIHO ODLECLOBCAO, [In] Dictionary<long, int> JEPHLJIJLCC, [In] Dictionary<Guid, RoomObjectCounts> KCOMFKJOGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class HLKKJKFMIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private readonly FDGJONAJEGL KGONHBJHLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly Dictionary<Guid, IReadOnlyList<Guid>> KDIOPCLFEJN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FDGJONAJEGL OAEKJOLOFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7804CF0", Offset = "0x78040F0", VA = "0x187804CF0")]
	public void JJBKLNLGAIJ(Guid CONPLABKGDH, Guid JAKHAHOHBFH, IReadOnlyList<Guid> MENKHPMOLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7804DA0", Offset = "0x78041A0", VA = "0x187804DA0")]
	public bool MOAHGBEDPFP(Guid FEJOFABKKKO, [Out] IReadOnlyList<Guid> EKCJACKLPAH, [Out] bool OPIGEKKMBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7804E90", Offset = "0x7804290", VA = "0x187804E90")]
	public HLKKJKFMIAO()
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
