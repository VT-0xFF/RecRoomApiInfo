using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DCE0", Offset = "0x7F1C2E0", VA = "0x187F1DCE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KFBIIJDFHGE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LFNDKOOMJLG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> DHBJGBDOHBO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> FILKMMILNGF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> KHHKGODGLKJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string EBOCPKHIADL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JEOINPCJMLK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string HONKNBNOMIN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C420", Offset = "0x7F0AA20", VA = "0x187F0C420")]
	public static bool EIEAHGALPHC(Guid DIABBEIHLHE, int NOCGJAPIDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C520", Offset = "0x7F0AB20", VA = "0x187F0C520")]
	public static bool LEDJPMAAENC(Guid DIABBEIHLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C5B0", Offset = "0x7F0ABB0", VA = "0x187F0C5B0")]
	public static string NPGCLKBKFCN(Guid PPIICOOCLEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AKMGCHAMAFN]
public enum MPGDIMCNADA
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
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DORM_BUNK_BED,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DORM_CAMPUS_MAP,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELEMENT_SNAP_POINT,
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
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F10430", Offset = "0x7F0EA30", VA = "0x187F10430", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MIFGOIIHHFJ
{
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid LGFGOJJGPME;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid OAHILODGDHM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid GDODEIKBCJK;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PHONKGMFKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid IOPAEJKHJFI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid NOFDKNPECKP;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid OMGJEMJLPEL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid FDBDLKOIKPP;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid HGDGMLNGDLD;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid LJAOFMAKPCH;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid EOKIOOHMIII;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid DAMHMHKDEPI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid FOGEGDENPPO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GICNKNBFFMO;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid DKKGHEDJKME;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid INHMJJHNDGC;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid IEOPPFPFHPJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DFBDDMOLDLL;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LHIAJAJEONA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid DKCCOBHFPMP;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid JICEHKEKMPG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid BNDMKELHKGA;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BPHKHGIKAAD;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OIIJEJGOAKO;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CMJFNOIMHNJ;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EFEMHFNLKFP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid IOMNGKFKBPI;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid MFPCFLMDDGL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid MPBOIPCBMPI;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid HLGNPAJKNHC;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CGHHELJBIGK;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid JHDACFKPIIK;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid LAAGIDEHNCE;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid DKIBBFEJBNI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid MMIECEJPLKJ;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid CEHOHFHJDCL;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid HANOBLCPDDI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid DAEPDGBPGJB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid GOAEMPAEJGN;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JJFCBAGLKJJ;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid HMFKIABCJGF;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HIKHHOLINDN;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid DNNMFBIFFDL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid IOJNBNLNGNB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid IEKLOMADKJE;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid HBCAHDELBHK;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JFLDJPKBKAL;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid DDDJGELDAEO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid NOBNCFFGAPI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EDACMFJBNDE;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JNDBOAJMOMC;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LBILMHOLKDL;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid HABKLPBDHII;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid GAJPHNCIDMP;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid PNEBHAJFEIJ;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid KBKCICIKCGO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid JOABFOAKGPM;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BDLEAEOPMAJ;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HDCHJCECAHG;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid KJAAPMBECJM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid GAPIGGCAOHG;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OPHMFDICACH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid ALEPBKLAKGA;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid PELHPBHLHMJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KICHFMKKJNN;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid NBMMGGNBFHJ;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OPACFEJBKIE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NMILHFHIENB;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AEDFPMPBFMB;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid CPMAHNACNHN;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NEFBHIEPJKC;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DJBPEBHCBPN;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid BFFIDNAIPLK;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid KNBIKGKCLHI;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid HNFDBDKHAEG;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid DOBJPPIFOIF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid GAOLOIJKAPF;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JGEFGDANNIH;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NLMKACNAMKB;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid DIKDCELJNBJ;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid POFBOCNJDPE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid GDMDFIMDADM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FEHBDHGOOLD;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid ILNICKDMJCD;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KANAIGHIHBF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid KBEIIFFAHGM;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid JFHLAMNOEOE;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid IKMHNIIJAKM;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OJGDADJBJCF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid AENDHDGOEEM;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid MMHBDJGNPFC;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OEJBLOABMAP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GICFEANJAOG;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid ALAGEAJEFOB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OLOKMJMMIBL;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid ECLDGOOEOEE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FDHLFGOJEEF;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid ABHMDAGECMI;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IABIELAEANM;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HCBGIADLHJD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid CGDILGFGNKN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid IOMACDPEMOK;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KMDCIOIKOBB;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid ANENAOCNLOM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid BAADPOJGBLM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid CGEEBCODJKM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid PBDKNCLGAEA;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid AEBLLNOFPIP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid PJMCNKFIIKC;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FPCFDNJDEDD;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid CBMLGKINKNP;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid LEKOONMOFOB;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid NOAIEJAMNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid JHAPBCLELKP;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid IMMFFCHLECM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid KJGGCOEFFIM;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid HCPHNPBADGI;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid OCLPNPHNLPF;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid DKFKELMOJBG;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid LJICEGNMLPP;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BHMKLDEBPAB;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid CEGBHMPCMDE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MHJNLCGIBED;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MPKDHEIFNKD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid NOAOIIKANBC;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid ACBABKFAFAH;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid HLHICPOMLHM;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid FOBLAAOLLEL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid DIKLGDEAFBJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid KBIGGGBMFID;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid MBJNDFJEOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid INCDAIIINPG;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid DBPCOHOGDGM;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid BOMMAAKLEKI;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid CNMPCMGFIKD;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BBMOJGGMMNC;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid KCFAONKJHFB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LFLJAHIBBEI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid FCKBEAFILCO;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid ONLKJIPHDAC;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid BIKMOAHCBHD;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CICLMKBHHOM;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid PGCGEKKGOAP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid MACBLDNHHBB;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AAGEKHHGLCF;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid MMCANMHKAFO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid PJOJIGLLKAH;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HNLIPGNEAGM;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid FJMHBBIECEM;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JDCGOCDONFE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid PFBEKHJLMDI;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid MBCBMHAHHDM;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid JAJKFEJKBHL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid JCEBPAGFMJK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid DEGDBNKMPGO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid LACKBGLOEGB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FPPFNKODBCL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid HJIGKAJKCLJ;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid PMBOJHIDOHH;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid NCNCHPJCAGH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KEEBFINHMLD;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DDMEPKBJFAE;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IOIHAGBMCIM;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid IFLNEKANDIP;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid DCCMJKBMJCI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid HDKEAICLDCB;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BNDFHIJFEIG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid EIDOCANNNAL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid EOGOPMLBCBM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid FNMHGGOLKCH;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid NFBHKCEGKLG;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid IFIIKDHCBAH;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid JGKONALMPMP;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LGMIHJGNJBM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid OGNEMKPJJJH;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid PNPJLCCNGOP;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LEBMOAHLKKI;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid BAEHDBACMKG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid AJAKLHMJKPE;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid HNKAFHCGIDB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid BAAHOJFDLHK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid FKNECGDDEOE;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HNMGLAGIAJH;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid HMGNEOGNHHP;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid GNOKBFNIJHL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid EALHEPDCGAP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid NLPKGBPIKCE;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid HINPIGFPBDM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid OHFPJLLNDDK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid AGOANKHCDNF;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid KGMHBCBKPOO;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid PNKKIGPFKKM;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GCCNHALAPJK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PAOFOABKKBH;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid LOBDLOMLHLA;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NALPDOEHJJI;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IKMCHKANGGA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid KKMHBICKPJE;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid NHJJBBCPMND;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid OFFLHNCAFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HJGCEIGFKDB;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid AAGHJHMOAGI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid KMKDIHCAACE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NPHDDEDAJDH;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid EPBPCGOLEFP;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LBHPICJLMIA;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid AMEDJANKDLK;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid LFOPIIHAELD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid ODHJCPPLCOB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KGFLCNMAMOD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid DIIMCGENOPE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid ANCCIEIPFON;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid ANNEMEAPFAA;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid OIJEMOHCKOO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FOGDNBLKFMO;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid GLPCHDDOHEL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid DPFNDELPCLO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MNHJHHGPNIB;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid CDJECDOFCHM;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KEIPLFJDLEK;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid KACDPCNEAEJ;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NMLCMBCJPBB;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DAEEAJAKHFA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid GBBHDBPBNLP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid EGKODEOEOOI;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CBEFGFBMOIH;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IGGNLOBOHAK;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid INKIMIMFNEP;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid COHACBKIHBC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PEGEEGBEKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid ODKFJFCNCDA;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KCNBHHOGLKL;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LHPEBLHJLIH;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid CALJKPFFAAK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid NILNIBNOANL;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KHBBLOPGFCJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid NONBGGLOGCI;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid GONDCDJGDIL;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid PEKDLOOIHHB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid MMNGBEOCOKL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CPCOLIOPAIK;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid PFENKIKKHKL;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid LKKPLILIAFH;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid JLCBEKDJJIB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid NDGAPBEOILO;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AANAKLJABFE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid PPJHNOAKJKB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid CEHHFJKKGMA;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid AMDMLIPODNE;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid KLEFCGJLFGP;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid NCAOPKNAFKG;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid GCCLHHPONAJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KLFMFIEHCOB;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid CLFICHNCIJJ;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BFJFOIONACI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HADFJILCAHM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid PBLGIJMEMMC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NEHLDEOCAMC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FFHNNMLEPBI;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid KAAMFNMBDIA;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid LHEGJHJLGGD;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid JOLOBOJIANM;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LPKNJOJFBEI;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid IHCLEFBGOMH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid GGIHCKDMEPM;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OBDOKLKFDDK;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid ENPHEHCFLNG;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NOOGECEMAAJ;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid IBGMDKJIBME;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DECEPMCKBDO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid DAJKJCGOIOD;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid NFFDLJHGGEG;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid ELHGDIGIPPH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BJMBPBBJIOM;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid LJFOABIHNCM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid MNHCGNNIMPA;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid CHIMNBEAJJG;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid EDDJCIAMHCH;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid KBDAGNNGLOI;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid JCGOJLKGBNG;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid FMPAGKCDEGF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MKJLLPPAPBK;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid DPKACBJEDNI;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid EPBANCNGHFI;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid JNDANOGAEOL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid JEIBEOHEAAP;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid GHEMJFAKIOK;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid GMKOEFALOME;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid FNOHPDIHMMK;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid KLOHPLGNMGC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid CCNBIADJEEF;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KDDDIDHOOMM;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid INPELBDBKHH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid HJLNHGJCHKN;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid DICJMPFFINP;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid BELIOMCDBKH;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid BOKKJONENGM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid CEDAGACAFGL;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JCJLPGPICJP;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid AHOJFAHAGKF;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid KHCHDBIGFIH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PAHNEOCMMCB;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid ACNAEDMKDBL;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid AFODKNPOHBH;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid ACFNIHGBLFC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid CNIHJAAMMGK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid CGBEOJOCFJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LNLJLDIFOCE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid MMDDBJADGMH;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BDCNOPKOJDK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CNDCNEKPHIL;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid NILHGBBDALE;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MICCIHGGDFO;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid MKMDJGELNGG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid HIMFDOIJJKJ;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid BPLHPLDKMKH;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid DDGIHKPHHMG;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid BENJIPEKLIN;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid NKDIKBBPOPE;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid BPANFGGMIGA;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid MAIDAHNDDKL;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OIHOIAFMAOH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid BPHJCMPPCNA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid OBFKMELOBGN;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid DEAOLCGJLAL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid GJAOPKMMINO;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CDGFBEJPOCM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GEGIGHEEELA;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid HNJKCJHOHNP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid BOJMFCJMPBM;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OPMCGGAJILP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid KPDMKGJANNH;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid KKOGABAIJMN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid ANMBBIJMIJB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid HLEOMGLCDGB;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CGODEEGEDPC;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KANFDPADONF;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid OEBKJOKLAHM;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MLHKNOCFJAM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid BPLINMPBFJE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid INPIMMKNAGB;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid GOMNMOLOFDK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EMNNBPMIHME;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JIKBEEJLHPJ;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FHCEMGCLIBN;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid PHGNFAPGMFB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid GDOAGJMFAEH;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid ECJPPDMGBPG;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JHJBBFGILOC;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MHKBCIBKAIG;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid EEGNEJLGNHJ;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid FGDPLHKMNBF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JLAGNHOAGDE;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid FCACDCAGEKD;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid CBGJMIAIMAF;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FNBJFBENIFE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid EMPOOBCGPHJ;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid EMABBMPIMFN;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid AALKKELIFAA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid CLMEPFDEIJA;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid DCJGKCENFNM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EMFFEPOAPEO;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid ADGDFDBKDLH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid HGJIPEMFLBP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid EOFIDNHNGID;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HDAFEBEPKBN;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LAMPMOFBPAH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FJNGMMGMFJK;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KLGCOGHBDMA;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid GONMPDIHLMF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid DJIJAABANID;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid LAHPBMEDDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid BPLJGDOCPDN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid NLJKBHLHKIF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid MLOHPMOELJG;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid BFMGOMOFCDI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid EKBPJMFGLOC;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DHMECPNGAMM;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PEDJIEPIEIF;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid EJDPJCFIJAA;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid ANLLMKEOIGP;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid NDMBCIBHCMP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid IEJAEHNNIFB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid JFFMGLIDGJI;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid CINPAIDIKAM;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PBOKIJOAHPP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid GDGAOAEPBIB;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BPNJDNCKKJE;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid HLMNKHFCLHA;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BNCKJPNIGCO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid PHBFIINIGNN;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid AEJBDCPFJIJ;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid FLFCNHLCDKI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IMBFDJKOKHB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid IEAOBECNGBB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid HOBEBIBPBHF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid ENEDOMLICNC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid NFLDKNFLCIJ;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid IFIEAHFJJCP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PMHHNECKKFN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid DDMODLBMKGA;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid HPBDKPMOIEH;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid HGKOKFGBPPC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid OPOLIGOOICM;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid JIOIILMFMGN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid CJCPKOAFCJC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MPANEIEBOEN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid LCBLKBIEGLE;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid NDFMJCCMGKK;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid GAGBABEPFDG;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ELFCGCBBHNE;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PIGEAJIDFBJ;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid FGIDKLPCINP;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid BPKGFLEFDBJ;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid BHMCNFAMNOJ;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid ODIMJPCIKFM;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JMLOCFKKGGH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JPGEFLLGIMA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NLBEGADPGHC;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GILOFKCKHCC;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BFOMBBBAAHG;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid AINKOEHFPJH;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid HOIDEKILODE;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid FCCCONFOCLP;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid DPIMAEKKLAM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid BPCNBOKOLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IMPEDPJFEOE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid JOPGAMOHFMG;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OAHKLCAHPHM;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid NBGOOGDACBN;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid LMCEGPGPHIJ;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GILBMGNICPI;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MFMFJDLLKGO;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid ABJAAGGMMBI;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DBBEGLEMOOB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid INIDPFDJEMI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid OPHDJJFOOMI;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid GJKILDPHMAK;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NCCFGHOPKPO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid ICKDMNIEKIH;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FGHAOLCHDHI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DEFDICJEOMO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CLMJAMIALGM;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid BHKHDGGEKMD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MJDOCKKJJJE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JFBMHGJKCNF;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid FNKCCFEKJOD;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid AFIOMIHNDDI;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid LNMEOOIOADP;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid EFJNGAFDMCD;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid CFFKGOFHOMG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid LIIHDKIGGML;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KAGMPBOAHMG;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid LILHLMMGMDG;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid FFPFLHEENBK;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid DNDJPCJDBIN;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid MEIHMGPKGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid EAAGCELNLME;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid KEMELBNBJKO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid KHEOLIAAFHM;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid GDCHFNBFKJO;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid LCFCIIBHIGN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid EINJJOFLFNM;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JBABHKINLME;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid AMDIMIJFCJO;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid OHCNMOBDECA;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid LHMBJPJFAPG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MBFHFKMGCFJ;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid AIFMIDIHNCI;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid OOAMCKGICFM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FDPPELJPPAC;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid KKJEGCKLFBC;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EKDHPIPOELP;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CNLKFAGOPBL;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MENNKACHIJK;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid OHEGHCABIKM;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid PGKAFDEOKPF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid BPELODMACAK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OGFONDJHGOG;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid INMOIMLMOPC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid COBEOKNAIPH;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid OHBHCHJLFCD;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid NFJDOGMFKPP;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MHPNMLJLBLM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid CLDEONJPJBO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid FBIJEOLFMLK;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid NIKMHEDPKOK;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid NEEAAAHJFHP;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid MJOHCLJGNFP;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid KDLBKGJIGIG;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid IKBKPHABNNB;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid FCMKBFLHBKN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid OKMOODIOPFB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid JDBCBJDPHHC;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FJCPCNEFJND;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid DHICMHMNKFO;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid OHAMIAMDINO;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid ALFPMJECELC;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid BEDOEDHJJPK;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CADALHGEEAI;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid CCKPHJKLFBA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HIJMCMNENFJ;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid HHFJHEEJKBC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JFHGNIELJDE;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BAEOJGKDJDI;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid DGDHCNFAJEC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JDOJCNICBLI;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid AGNLEHLHAAA;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid ONPMMMBBIJF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid DJDFKIILNNK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid HLCJFMFDFDF;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JLIJMBDCHCK;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid HDKIDICMBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid ODAKMODDLDB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid LCIBKEEFICA;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid EOJKPJIPEHI;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid KGAHKMGMOBB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid EDBGHBNOMGK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid BALPCHDCCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid JNHJIBHOBCH;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid EHFABMLNDKF;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid ALJBGFOIGOF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid JIPBMFEIEDO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid LIHLDAGBMDA;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MBCNKBEKKLG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid FOOHKIJBFKD;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JNPNAOPHHEK;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid ADHEGKFINJN;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid IGMOPDNNOAE;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid PNJKCNLLPKN;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid GFCGDLPMHPO;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid CEHNDHOEMDL;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid HKLECMKLNIE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid ACPLJJMCJIM;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HGBHHLKFFEL;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid HELLEOMHADE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid PJPAFJADNEI;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid LGDBNHMNFMH;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid DODPEGIAGEC;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid EMHGCNABNFP;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid LMJENOANDEP;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid EBMFGHIMMPB;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid CKGABNIEEKG;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid HAENOOOPJHK;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid NPBPDLIPHKF;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid OODCACJDEIF;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid FAFKKKAJHNK;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid OFJLDBFCEIF;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid EKOFFGCLHGE;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid KJJGFEMIKAH;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GDPECICCGAD;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid CFONGPMONCJ;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid HFEHKOPLMHN;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid HNNMFOEJBOI;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid IEHDCPBAPCJ;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid LDLJIKPMDHE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EFNHDGBKLKA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid BGOHDGKKHDJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid CKLNIDNGEGB;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid EJHFEKOBNMO;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid IJBMPJDMHDJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid IOLLEDPLGHB;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid IIPHLMPDCAH;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid IFEHDJIGBDF;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DEFNBAGDLIH;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OLAEEFACONP;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid KLJHKHDKBCF;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid LJIBCCGIFHJ;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid PHENOLBGHKF;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid KHLAPPJDEHP;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KILCCELFKJB;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid KJENGNMILHN;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid DNBAEFLGPKM;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid PBKBIMAMEPB;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid CILMAODFMGN;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid BBEAEOJINJC;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid MJJKJALMBEO;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid NJOKKOFAGBC;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid DHFMFHMCNDF;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid KGJLHMAMBBC;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid ALDCHNIAEOM;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid OGKAGKCMJDB;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid OMCMDLOHAPC;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid NLJLHJNGONJ;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid LMHDOMLOLFK;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GAOOBHOMEJM;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid OAOIGIMICLL;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid NGGKGGJHMIC;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GDKKBPKKNJD;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid DNPLOFFGCLH;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid FABAFBPEJGE;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid HOGJJAOCAJP;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid AFICMDBDICA;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid EIDMBPJKKEO;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DMJKJPAHBPO;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid POKKPFCCEJA;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid NMNGOKGBKDH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid NJFKNBBDINJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid NFGLMICNAKM;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DNLCLJBNFHN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AONPMCPNNPF;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid DFOHDLCJFEN;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid EALGOGLHMEP;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid ALCCGAACCBC;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid NMNAIILACIO;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid HKOJNOHKIMK;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid BGINDFPFKJF;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid KEHILBJPPMJ;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid OGOOBENLDEA;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid FNLNCLGJGGF;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid PJDJNFMKFEK;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid MBMFHFPGOGM;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid NEHBHKJLNOC;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid LEMJIPCKOJH;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid OEDALNHHONN;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid ILCADMLOKGJ;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid DJKFHMNHOCI;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid KEPOHBNAMOG;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid NGCLFECHOGC;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid OAAKPKNPONP;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid CNCOHKNOIPB;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid LFBGMDFKKDF;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid OEENGOONFGB;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid OADMAIDDMMG;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid PIADEABKCLF;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid KBLJJIDDLFK;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid HAKEAJIPKAB;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid HHKAEHKBNGG;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid EBLIFLMCEMG;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid APFJKEPKHJA;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid EBEEIMDNBCO;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid LJIHPLEIFAP;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid KDOJJLHNPGG;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid MKGHAJJLJHC;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid KCMIGJFHHCN;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid IFMDCONMCBN;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid DKIPKGIEABL;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid OMDOENDNADE;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid HNHOAHDHIEC;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid OCJCIAFIEPD;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid KEHGHPBOCMO;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid PCECCJHKNLG;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid HOEJMEINNHO;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid LIBCAPCEJLK;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private static readonly Dictionary<Guid, MPGDIMCNADA> AJDLBCENFHF;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private static readonly Dictionary<MPGDIMCNADA, Guid> FAEDEKNADFC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, MPGDIMCNADA> AOJNDKHAFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F10500", Offset = "0x7F0EB00", VA = "0x187F10500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<MPGDIMCNADA, Guid> JBAJPBHIJME
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F10560", Offset = "0x7F0EB60", VA = "0x187F10560")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DLAIBCBFKNJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B7B0", Offset = "0x7F09DB0", VA = "0x187F0B7B0")]
	public static bool LPEIPHDFMAG(PPIANNGFPBI NBHNGJKDPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B390", Offset = "0x7F09990", VA = "0x187F0B390")]
	private static bool LPEIPHDFMAG(ODNFMHOMGMG ANABIAJOBHJ, PPIANNGFPBI NBHNGJKDPME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DBJLHIPEANA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CEFFNLIIODN ACJFHCNBBBO, [Out] Dictionary<int, int> AKBFFFFFIPK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(BAHICIMNAGL NNNAPGOHBPE, APIIFFJGBAO DJLNHNMKKOH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CEJHFMAMKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly PECDCMDDDNJ CNOLLKCJMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public readonly IEnumerable<BFMGGPKDIJO> AMDBPNDKEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public readonly IReadOnlyList<BFMGGPKDIJO> IELHAHKLHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public readonly LLDGDOINCKI<DMMBIHDCELP> MGLLOJHJJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public readonly IReadOnlyList<MGAFLBIECIE<FELJLHNDBFC>> NBJAABDBNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public readonly BCECCNIMOIF IECNANFMMHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HBFNKBFDBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F0ABB0", Offset = "0x7F091B0", VA = "0x187F0ABB0")]
	public CEJHFMAMKHG(PECDCMDDDNJ DHBBLFMACJJ, IEnumerable<BFMGGPKDIJO> BONGIIPGEKF, IReadOnlyList<BFMGGPKDIJO> KOJCICIHAFH, LLDGDOINCKI<DMMBIHDCELP> ENAOBJKOEBF, IReadOnlyList<MGAFLBIECIE<FELJLHNDBFC>> LEKBOLJCIGJ, BCECCNIMOIF LEBANJBNKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JCFFIHBFJJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public readonly PECDCMDDDNJ CNOLLKCJMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public readonly IReadOnlyList<BFMGGPKDIJO> AAJHOAOILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public readonly LLDGDOINCKI<DMMBIHDCELP> MGLLOJHJJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public readonly IReadOnlyList<MGAFLBIECIE<FELJLHNDBFC>> NBJAABDBNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public readonly ByteString FOALPEBEDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly BCECCNIMOIF IECNANFMMHP;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C3B0", Offset = "0x7F0A9B0", VA = "0x187F0C3B0")]
	public JCFFIHBFJJF(PECDCMDDDNJ DHBBLFMACJJ, LLDGDOINCKI<DMMBIHDCELP> ENAOBJKOEBF, IReadOnlyList<MGAFLBIECIE<FELJLHNDBFC>> LEKBOLJCIGJ, ByteString KKBBMCLDDHM, IReadOnlyList<BFMGGPKDIJO> LBHBAOMDDMB, BCECCNIMOIF LEBANJBNKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GFBKOJBAFFI : ONIBJMBIAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly Guid CPNEMOBDBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private readonly Dictionary<Guid, Guid> DIJLOLAHCLM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CCF5E0", Offset = "0x4CCDBE0", VA = "0x184CCF5E0")]
	private GFBKOJBAFFI(Guid AKIILKDBBDO, Dictionary<Guid, Guid> DIJLOLAHCLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BA10", Offset = "0x7F0A010", VA = "0x187F0BA10")]
	public static GFBKOJBAFFI BFOPDLPDKBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BD10", Offset = "0x7F0A310", VA = "0x187F0BD10")]
	private static Dictionary<Guid, Guid> GJIKOCIPGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BAA0", Offset = "0x7F0A0A0", VA = "0x187F0BAA0")]
	public static GFBKOJBAFFI CCKJPLCGCNF(IReadOnlyDictionary<Guid, Guid> LFMKIINCPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C040", Offset = "0x7F0A640", VA = "0x187F0C040")]
	public static GFBKOJBAFFI IPNKCGLKMML(IEnumerable<KeyValuePair<Guid, Guid>> LFMKIINCPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B990", Offset = "0x7F09F90", VA = "0x187F0B990")]
	public Dictionary<Guid, Guid> AMHDJGCONPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
	public Dictionary<Guid, Guid> DFOPNGNENIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0C330", Offset = "0x7F0A930", VA = "0x187F0C330")]
	public void JDPCENHCAFL(Guid LFMKIINCPNH, Guid PFPDPIHOEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BDC0", Offset = "0x7F0A3C0", VA = "0x187F0BDC0")]
	public void IAFKANMLFDD(IReadOnlyDictionary<Guid, Guid> BNNKFGEGFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BBC0", Offset = "0x7F0A1C0", VA = "0x187F0BBC0")]
	public Guid FIJMANNIDEA([In] Guid LFMKIINCPNH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BB20", Offset = "0x7F0A120", VA = "0x187F0BB20")]
	public Guid FABPKFIFKFJ([In] Guid LFMKIINCPNH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BAB0", Offset = "0x7F0A0B0", VA = "0x187F0BAB0")]
	public bool EOLHEGFNIHG([In] Guid LFMKIINCPNH, [Out] Guid PFPDPIHOEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BAB0", Offset = "0x7F0A0B0", VA = "0x187F0BAB0", Slot = "4")]
	private bool OHJCMIKKKAD([In] Guid LFMKIINCPNH, [Out] Guid PFPDPIHOEAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JNLHIBDCMNA
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGJAPDEEMPK(Guid PPIICOOCLEP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDOFMOMBLJG(Guid PPIICOOCLEP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OEIBIFBAJPP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class AGCPGOLMHMC : JNLHIBDCMNA
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FDEMPKEPJCH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public FDEMPKEPJCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B7E0", Offset = "0x7F09DE0", VA = "0x187F0B7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B940", Offset = "0x7F09F40", VA = "0x187F0B940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B8A0", Offset = "0x7F09EA0", VA = "0x187F0B8A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B8A0", Offset = "0x7F09EA0", VA = "0x187F0B8A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CNGNKLOJDDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public AGCPGOLMHMC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0AC20", Offset = "0x7F09220", VA = "0x187F0AC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B330", Offset = "0x7F09930", VA = "0x187F0B330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private Dictionary<string, HashSet<Guid>>? MMHEEAJMAJG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private static IEnumerable<string> FCLJMPPDOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A9E0", Offset = "0x7F08FE0", VA = "0x187F0A9E0")]
		[IteratorStateMachine(typeof(FDEMPKEPJCH))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract IReadOnlyCollection<string>? DOBMFFNDNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool PKJNGMGNMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected abstract bool PBDHIOMLEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> DDODDPMDGDE(string KJOFNPECEGH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F0AA40", Offset = "0x7F09040", VA = "0x187F0AA40")]
	[AsyncStateMachine(typeof(CNGNKLOJDDP))]
	public Task NHPGJMGLCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x121E280", Offset = "0x121C880", VA = "0x18121E280")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A730", Offset = "0x7F08D30", VA = "0x187F0A730", Slot = "4")]
	public bool JGJAPDEEMPK(Guid PPIICOOCLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A660", Offset = "0x7F08C60", VA = "0x187F0A660", Slot = "5")]
	public bool JDOFMOMBLJG(Guid PPIICOOCLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A5A0", Offset = "0x7F08BA0", VA = "0x187F0A5A0")]
	private bool BHJAEOLNAEF(string BOCAKAEKPJM, Guid PPIICOOCLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected AGCPGOLMHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MPFNPHJGHFO
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class POIFEAKJMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public PECDCMDDDNJ staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public POIFEAKJMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E1F0", Offset = "0x7F2C7F0", VA = "0x187F2E1F0")]
		internal LLDGDOINCKI<OKPADGEFIDP> BKDOJCBBPCF((LLDGDOINCKI<DMMBIHDCELP> GraphId, LLDGDOINCKI<FELJLHNDBFC> NodeId) i)
		{
			return default(LLDGDOINCKI<OKPADGEFIDP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private static readonly LJHBAJLPPDM<OKPADGEFIDP, int?> IFAKGKDFAJP;

	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private static readonly long GKNFEOEHMFJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F106E0", Offset = "0x7F0ECE0", VA = "0x187F106E0")]
	public static (long, long) FCPDHAIKBNF(PECDCMDDDNJ NGBCHJAFBCF, LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F10B80", Offset = "0x7F0F180", VA = "0x187F10B80")]
	public static long OPJOCELNNHB([In] ReadOnlySpan<LLDGDOINCKI<OKPADGEFIDP>> JCAKGGFHDBC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F105C0", Offset = "0x7F0EBC0", VA = "0x187F105C0")]
	private static long BCPPMDLHCEK()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EBOPGMCBBNC
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public static readonly HashSet<MPGDIMCNADA> AEDNNOLMDGA;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PGEKCOPDJHF
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NBPLPLOOLHJ : IEnumerable<BFMGGPKDIJO>, IEnumerable, IEnumerator<BFMGGPKDIJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private BFMGGPKDIJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private JLGGBMOCGCA spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public JLGGBMOCGCA <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private OOJLJHCEKJJ spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public OOJLJHCEKJJ <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private BFMGGPKDIJO System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public NBPLPLOOLHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A5F0", Offset = "0x7F28BF0", VA = "0x187F2A5F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A870", Offset = "0x7F28E70", VA = "0x187F2A870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A700", Offset = "0x7F28D00", VA = "0x187F2A700", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BFMGGPKDIJO> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A700", Offset = "0x7F28D00", VA = "0x187F2A700", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CB20", Offset = "0x7F2B120", VA = "0x187F2CB20")]
	public static JLGGBMOCGCA ONJGGOLIDEG([In] JCFFIHBFJJF DGGGFBEHBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C990", Offset = "0x7F2AF90", VA = "0x187F2C990")]
	public static JLGGBMOCGCA ONJGGOLIDEG([In] CEJHFMAMKHG DGGGFBEHBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F2BAE0", Offset = "0x7F2A0E0", VA = "0x187F2BAE0")]
	private static HashSet<MGAFLBIECIE<NECMPPLIMIG>> LPJAKPLHHHL(IReadOnlyList<BFMGGPKDIJO> MOPJNDMHEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C330", Offset = "0x7F2A930", VA = "0x187F2C330")]
	private static void NBKEBOJJEGI(JLGGBMOCGCA JEAKMFJJLPH, [In] CEJHFMAMKHG GJBLKJEMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CCA0", Offset = "0x7F2B2A0", VA = "0x187F2CCA0")]
	public static FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL> PIHCBPJEFNA(JLGGBMOCGCA JEAKMFJJLPH, OOJLJHCEKJJ OIKHMDHGABF, GFBKOJBAFFI? AICPGDAIBGP, bool FEBBLDONFFJ)
	{
		return default(FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B9D0", Offset = "0x7F29FD0", VA = "0x187F2B9D0")]
	[IteratorStateMachine(typeof(NBPLPLOOLHJ))]
	private static IEnumerable<BFMGGPKDIJO> KGOBEBJGMDJ(JLGGBMOCGCA JEAKMFJJLPH, OOJLJHCEKJJ OIKHMDHGABF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AFE0", Offset = "0x7F295E0", VA = "0x187F2AFE0")]
	private static void FCLPFELKMON(JLGGBMOCGCA JEAKMFJJLPH, OOJLJHCEKJJ OIKHMDHGABF, IReadOnlyCollection<ByteString>? JJEMBHPNNPM, IReadOnlyCollection<ByteString>? GMKGCCLELDC, IReadOnlyCollection<ByteString>? JECBANEKEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B330", Offset = "0x7F29930", VA = "0x187F2B330")]
	private static bool IKBMANELHEB(JLGGBMOCGCA JEAKMFJJLPH, BAHICIMNAGL NNNAPGOHBPE, OOJLJHCEKJJ OIKHMDHGABF, [Out][NotNullWhen(false)] string? NNDNCFBMBFL, [Out] Dictionary<int, int> AKBFFFFFIPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B050", Offset = "0x7F29650", VA = "0x187F2B050")]
	private static Dictionary<Guid, ODNFMHOMGMG> GJLGEIGOHBG(JLGGBMOCGCA JEAKMFJJLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2ACC0", Offset = "0x7F292C0", VA = "0x187F2ACC0")]
	private static void BMFCCGADNGD(bool HFBCDMLHHAN, BFMGGPKDIJO OLLCMNMACHB, GFBKOJBAFFI HLMAACDBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AD50", Offset = "0x7F29350", VA = "0x187F2AD50")]
	private static void EMGCGKIJPHI(BFMGGPKDIJO OLLCMNMACHB, Guid NFFCEGGNLPM, IOBICBHECDB? CONIINOMBBP, Dictionary<Guid, ODNFMHOMGMG> JMKDHPGAJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2BE80", Offset = "0x7F2A480", VA = "0x187F2BE80")]
	private static void MNBCCIKHKGO(IEnumerable<BFMGGPKDIJO> FFDEFNBGNAF, IReadOnlyCollection<ByteString> JJEMBHPNNPM, IReadOnlyCollection<ByteString> GMKGCCLELDC, IReadOnlyCollection<ByteString> JECBANEKEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OOJLJHCEKJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public bool HFBCDMLHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public BCECCNIMOIF LEBANJBNKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public IOBICBHECDB? CONIINOMBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public IOBICBHECDB? PGHCKFMMLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public PECDCMDDDNJ OJMNONDLJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public OEIBIFBAJPP IGOAIJGCIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public DBJLHIPEANA NEDJCCBPPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public MGAFLBIECIE<DMMBIHDCELP> FFPAPIMMIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public JJHPOJACGFF GPONIOJKHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public List<BFMGGPKDIJO> HIMPFIHKAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public AKGINPGMGBG JCLBIBKAALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public PPFEINPAPOF CMPMIMIAOJF;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IOBICBHECDB
{
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private const float JHFEOONLEMK = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public Vector3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public float HKINPNLCPPL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 JPHGJIJPFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F25630", Offset = "0x7F23C30", VA = "0x187F25630")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS NHHDDCGLDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F24F40", Offset = "0x7F23540", VA = "0x187F24F40")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1549520", Offset = "0x1547B20", VA = "0x181549520")]
	public IOBICBHECDB(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float HKINPNLCPPL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F25840", Offset = "0x7F23E40", VA = "0x187F25840")]
	public IOBICBHECDB(UniformTRS ONPHFIKAMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F253B0", Offset = "0x7F239B0", VA = "0x187F253B0")]
	public static IOBICBHECDB LINNJCEMIGD(IOBICBHECDB NBIJLPJHNNE, IOBICBHECDB CEPBDOIBDIC)
	{
		return default(IOBICBHECDB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F250E0", Offset = "0x7F236E0", VA = "0x187F250E0")]
	public static IOBICBHECDB EIMKEBEILPD((Vector3, Quaternion, float) ACJFHCNBBBO)
	{
		return default(IOBICBHECDB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F24F80", Offset = "0x7F23580", VA = "0x187F24F80")]
	public static IOBICBHECDB EIMKEBEILPD(Matrix4x4 KHKKIAOOKFD)
	{
		return default(IOBICBHECDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F257B0", Offset = "0x7F23DB0", VA = "0x187F257B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F25190", Offset = "0x7F23790", VA = "0x187F25190")]
	public IOBICBHECDB KNOPGKDOIEC(Matrix4x4 DFOHJKCGEGI)
	{
		return default(IOBICBHECDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F25740", Offset = "0x7F23D40", VA = "0x187F25740")]
	public static IOBICBHECDB OIPEDMEPEHH(Vector3 NHLFNDFGAHK)
	{
		return default(IOBICBHECDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F25100", Offset = "0x7F23700", VA = "0x187F25100")]
	public readonly FGKKHNHKCDK FIHBCGBBFFB()
	{
		return default(FGKKHNHKCDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum BLNJFAKLOPL
{
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MLIAPIJGKDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public readonly MKPLJEGKGIB ILFPPKIKMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private readonly KNIOCFDMLBC KCJJACIMGPP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x17F5060", Offset = "0x17F3660", VA = "0x1817F5060")]
	private MLIAPIJGKDL(MKPLJEGKGIB PDFIFNAMHFC, KNIOCFDMLBC PDNNJCJEKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A580", Offset = "0x7F28B80", VA = "0x187F2A580")]
	public JEIAJFOIEEM KKENIGECHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A360", Offset = "0x7F28960", VA = "0x187F2A360")]
	public static FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL> BFOPDLPDKBM(JPDJMBGFCJM<DICNEKFFPEP> PDNNJCJEKHE)
	{
		return default(FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A410", Offset = "0x7F28A10", VA = "0x187F2A410")]
	public static FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL> BFOPDLPDKBM(JEIAJFOIEEM PDNNJCJEKHE)
	{
		return default(FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A4C0", Offset = "0x7F28AC0", VA = "0x187F2A4C0")]
	public static FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL> BFOPDLPDKBM(string BOMLNJNCGJK)
	{
		return default(FANMKCKHALG<GFBKOJBAFFI, MLIAPIJGKDL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum MKPLJEGKGIB
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GFCCCLMPCDD : IDisposable, CGAFCLPGFCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private NativeList<FEALKEEJBEM> POGMDDCOHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private float JLHKNIAAFJA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PMDGEEGMAGC FLADFPDGLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(PMDGEEGMAGC);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OHDNMFOOJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E17360", Offset = "0x6E15960", VA = "0x186E17360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LHJNNDMLMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E17370", Offset = "0x6E15970", VA = "0x186E17370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<DINAMGFHKNC> AILLODHGPME
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JDJNGFLKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F23360", Offset = "0x7F21960", VA = "0x187F23360", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float BJDJAGIFDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F223E0", Offset = "0x7F209E0", VA = "0x187F223E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F243E0", Offset = "0x7F229E0", VA = "0x187F243E0")]
	public GFCCCLMPCDD(PMDGEEGMAGC ENCLHPAOMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F21EE0", Offset = "0x7F204E0", VA = "0x187F21EE0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F23DE0", Offset = "0x7F223E0", VA = "0x187F23DE0")]
	public Vector3 OPOKOKODNJK(int JAENDMHBLHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F242B0", Offset = "0x7F228B0", VA = "0x187F242B0", Slot = "6")]
	public Quaternion PMCOOJCDFAF(int JAENDMHBLHP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F22E00", Offset = "0x7F21400", VA = "0x187F22E00", Slot = "5")]
	public Vector3 IACOJFBJPKJ(int JAENDMHBLHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F23300", Offset = "0x7F21900", VA = "0x187F23300", Slot = "7")]
	public float JMOOFIKCBFJ(int JAENDMHBLHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F22520", Offset = "0x7F20B20", VA = "0x187F22520")]
	public void FOFNIMEPKHD(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ, bool LFFGHPJLCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F21C30", Offset = "0x7F20230", VA = "0x187F21C30")]
	private bool AAAGMGFOBAM(int BADANGAHACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F233A0", Offset = "0x7F219A0", VA = "0x187F233A0")]
	public void NEJCICOHLPL(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F21C90", Offset = "0x7F20290", VA = "0x187F21C90")]
	public void AKMNPDJPFFG(int BADANGAHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F22EA0", Offset = "0x7F214A0", VA = "0x187F22EA0")]
	public void INGHMDMMPOD(int BADANGAHACL, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F23150", Offset = "0x7F21750", VA = "0x187F23150")]
	public void JKNKCLCHDFO(int BADANGAHACL, float3 NHLFNDFGAHK, quaternion CFFPEJBOBIA, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F21D20", Offset = "0x7F20320", VA = "0x187F21D20")]
	public void BDGEMHICAMB(int BADANGAHACL, Vector3 NHLFNDFGAHK, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F22FF0", Offset = "0x7F215F0", VA = "0x187F22FF0")]
	public void JDPBDNLPDFF(int BADANGAHACL, Vector3 IFDADDNBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F23500", Offset = "0x7F21B00", VA = "0x187F23500")]
	public static Quaternion OCJMDGGCBPA(Quaternion LFABKDOANNB, int BADANGAHACL, float DFIBLOLLKDB, CGAFCLPGFCC LMPCNNDDJCA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F21F40", Offset = "0x7F20540", VA = "0x187F21F40")]
	public Bounds EMKKPJEDMGH(Transform DFOHJKCGEGI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F21E70", Offset = "0x7F20470", VA = "0x187F21E70", Slot = "10")]
	public virtual void CKLOJADLBBG(bool JDOKENHFDLJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F23D10", Offset = "0x7F22310", VA = "0x187F23D10")]
	public NativeList<FEALKEEJBEM> OKFEGGBGBKL(float INEDJNOFGHJ = 1f)
	{
		return default(NativeList<FEALKEEJBEM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DINAMGFHKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public float3 DGHMAMNELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public float OLEEDNHGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public quaternion FGKGCNBOBOD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F20E30", Offset = "0x7F1F430", VA = "0x187F20E30")]
	public DINAMGFHKNC(Vector3 JPAIMFCOEEF, Quaternion LFABKDOANNB, float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F20A80", Offset = "0x7F1F080", VA = "0x187F20A80")]
	public Quaternion IJOLOHGJPAP(Vector3 GJGHBLDDKFD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F20B40", Offset = "0x7F1F140", VA = "0x187F20B40")]
	public DINAMGFHKNC OIBELDCADHE(Vector3 IJENGPDKIFC, Vector3 JHKDOAICGKN, Vector3 FFBFOACIANB)
	{
		return default(DINAMGFHKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F208E0", Offset = "0x7F1EEE0", VA = "0x187F208E0")]
	public DHIKODJBPAN CNOMKGGBOPG(Vector3 GJGHBLDDKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EHFIHPOABFB : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F21BB0", Offset = "0x7F201B0", VA = "0x187F21BB0", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F215D0", Offset = "0x7F1FBD0", VA = "0x187F215D0")]
	private void CHBFGHOEHDL(Dictionary<Guid, Guid> DPNACLMILIK, ANNKEIPAMBG LJELIFFFLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F21570", Offset = "0x7F1FB70", VA = "0x187F21570")]
	private void CHBFGHOEHDL(Dictionary<Guid, Guid> DPNACLMILIK, BGHHIEPNOOI HFPOGIBPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F212F0", Offset = "0x7F1F8F0", VA = "0x187F212F0")]
	private void CHBFGHOEHDL(Dictionary<Guid, Guid> DPNACLMILIK, CODKAGIAMKD HJEDMOICLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EHFIHPOABFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DIGBGKGJHJF : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F20830", Offset = "0x7F1EE30", VA = "0x187F20830", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DIGBGKGJHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DFELKMMBGKH : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F205A0", Offset = "0x7F1EBA0", VA = "0x187F205A0", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DFELKMMBGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LHOGBPLGDLJ : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A200", Offset = "0x7F28800", VA = "0x187F2A200", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LHOGBPLGDLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HJIBDPKPLMH : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F24810", Offset = "0x7F22E10", VA = "0x187F24810", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HJIBDPKPLMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EHAGCPBIPAN : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F211B0", Offset = "0x7F1F7B0", VA = "0x187F211B0", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EHAGCPBIPAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CAELFLPGJEI : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E100", Offset = "0x7F1C700", VA = "0x187F1E100", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CAELFLPGJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class ECFDFIHCJKK : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F210C0", Offset = "0x7F1F6C0", VA = "0x187F210C0", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ECFDFIHCJKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class HAENLEFDJHD : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F24650", Offset = "0x7F22C50", VA = "0x187F24650", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HAENLEFDJHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class HMNEGHPCLMM : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F24A30", Offset = "0x7F23030", VA = "0x187F24A30", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HMNEGHPCLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IHNAMEOBDIH : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F24E40", Offset = "0x7F23440", VA = "0x187F24E40", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IHNAMEOBDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class DGMIIBKENDP : POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public static readonly IFODOLLCKFJ KCHMAFOKPAH;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F20700", Offset = "0x7F1ED00", VA = "0x187F20700", Slot = "4")]
	public void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DGMIIBKENDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct PPIANNGFPBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public BAHICIMNAGL PFGEKBLLNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public MILLFFLLMNA JAKDLAGACLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public Dictionary<int, int> OJFAPNIBJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public Dictionary<Guid, Guid> LPKAKJAEENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public PPFEINPAPOF CMPMIMIAOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public bool FEBBLDONFFJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface POICKLIILMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLLGPKBBIJE(IGHPKNGGEGC GNEHEBCDONM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DDDNFINPMLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private static readonly POICKLIILMC[] JLCNLBAJDDJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F480", Offset = "0x7F1DA80", VA = "0x187F1F480")]
	public static void DIEHMAEGMKC(BFMGGPKDIJO ACJFHCNBBBO, GFBKOJBAFFI CKHCLDAOHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FAD0", Offset = "0x7F1E0D0", VA = "0x187F1FAD0")]
	public static void MPDNFDFEPLE(BFMGGPKDIJO? ACJFHCNBBBO, GFBKOJBAFFI GBGMIHHJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD60", Offset = "0x7F1E360", VA = "0x187F1FD60")]
	public static void NMCFBCLJKHM(BFMGGPKDIJO? ACJFHCNBBBO, GFBKOJBAFFI HLMAACDBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F700", Offset = "0x7F1DD00", VA = "0x187F1F700")]
	public static void LPEIPHDFMAG(IGHPKNGGEGC GNEHEBCDONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IGHPKNGGEGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public BAHICIMNAGL GLAKLLDGIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public BFMGGPKDIJO OLLCMNMACHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public Dictionary<int, int> OJFAPNIBJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public Dictionary<Guid, Guid> LPKAKJAEENK;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F24D90", Offset = "0x7F23390", VA = "0x187F24D90")]
	public Guid NEOEBKEOJON(Guid PPIICOOCLEP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface PPFEINPAPOF
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MFJHNBBEAJM, [Out] Guid FLDFIEHNGOG);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class KFJNLJMOJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private static readonly HashSet<Guid> OMHIOBIMGJD;

	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private static readonly ProfilerMarker LMLJFBCFFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private readonly HashSet<string> HJKOECHMGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private readonly Dictionary<long, int> PJCJFAOELIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly HashSet<Guid> NAPJAPIHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private readonly HashSet<Guid> KFCNOGBIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly HashSet<Guid> LPJCCHCLJGN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> OHMDHKOHLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> AMJKFGDNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> DHHOFMFPELF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> KHEIBNGOIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F28820", Offset = "0x7F26E20", VA = "0x187F28820")]
	public static void OHIJNJOFNAI(JLGGBMOCGCA MMPNGNDPMBN, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F26230", Offset = "0x7F24830", VA = "0x187F26230")]
	public static KFJNLJMOJAL DOMGNPIEMGM(AJMAHGBGLEH MODBIBDJKOA, AJPMMEDAFEP? IECHOFAKDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F26800", Offset = "0x7F24E00", VA = "0x187F26800")]
	public static KFJNLJMOJAL KJAPIBANIEC(JLGGBMOCGCA LIFFLKOANCF, AJPMMEDAFEP? IECHOFAKDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F265C0", Offset = "0x7F24BC0", VA = "0x187F265C0")]
	public static KFJNLJMOJAL HODFJMHGBHE(AHAMAKFMPAK DJLNHNMKKOH, EINJJNLDDMB DCGEKCKMHBF, AJPMMEDAFEP? IECHOFAKDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F264C0", Offset = "0x7F24AC0", VA = "0x187F264C0")]
	public static KFJNLJMOJAL HJABMEIFNAK(IEnumerable<string> HJKOECHMGKH, IReadOnlyDictionary<long, int> MJEONPDBCLA, IReadOnlyCollection<Guid> LPJCCHCLJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F29E70", Offset = "0x7F28470", VA = "0x187F29E70")]
	private KFJNLJMOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A000", Offset = "0x7F28600", VA = "0x187F2A000")]
	private KFJNLJMOJAL(IEnumerable<string> HJKOECHMGKH, IReadOnlyDictionary<long, int> MJEONPDBCLA, IReadOnlyCollection<Guid> LPJCCHCLJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F27260", Offset = "0x7F25860", VA = "0x187F27260")]
	private void MIJHJBGMBKF(AJMAHGBGLEH MODBIBDJKOA, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F27580", Offset = "0x7F25B80", VA = "0x187F27580")]
	private void MIJHJBGMBKF(JLGGBMOCGCA LIFFLKOANCF, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F27C10", Offset = "0x7F26210", VA = "0x187F27C10")]
	private void OFPNAMLODGA(ByteString? KKBBMCLDDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F26F20", Offset = "0x7F25520", VA = "0x187F26F20")]
	private void MIJHJBGMBKF(AHAMAKFMPAK? CMAFOEIBEKN, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F27500", Offset = "0x7F25B00", VA = "0x187F27500")]
	private void MIJHJBGMBKF(EINJJNLDDMB? DCGEKCKMHBF, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F26AC0", Offset = "0x7F250C0", VA = "0x187F26AC0")]
	private void MIJHJBGMBKF(BEGDADLJNFJ? BFNAPFBIKJH, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F26880", Offset = "0x7F24E80", VA = "0x187F26880")]
	private static bool MAILFFDLFIA(BEGDADLJNFJ BFNAPFBIKJH, int IFEKDHDAHFP, [Out] Guid BDKJFJIBLPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F29450", Offset = "0x7F27A50", VA = "0x187F29450")]
	private static void OHIJNJOFNAI(EINJJNLDDMB? CMAFOEIBEKN, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F29210", Offset = "0x7F27810", VA = "0x187F29210")]
	private static void OHIJNJOFNAI(BEGDADLJNFJ? BFNAPFBIKJH, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F29520", Offset = "0x7F27B20", VA = "0x187F29520")]
	private static void OHIJNJOFNAI(AHAMAKFMPAK? CMAFOEIBEKN, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F281D0", Offset = "0x7F267D0", VA = "0x187F281D0")]
	private static void OHIJNJOFNAI(AMBBPGFAHJM? ADFICJOCHFA, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F26C00", Offset = "0x7F25200", VA = "0x187F26C00")]
	private void MIJHJBGMBKF(AMBBPGFAHJM? ADFICJOCHFA, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F262B0", Offset = "0x7F248B0", VA = "0x187F262B0")]
	private void EINEKFAEJAG(Guid? PPIICOOCLEP, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F27810", Offset = "0x7F25E10", VA = "0x187F27810")]
	private void MIJHJBGMBKF(BFMGGPKDIJO? OLLCMNMACHB, AJPMMEDAFEP? IECHOFAKDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F298A0", Offset = "0x7F27EA0", VA = "0x187F298A0")]
	private static void OHIJNJOFNAI(BFMGGPKDIJO? OLLCMNMACHB, AJPMMEDAFEP IECHOFAKDHN, GFBKOJBAFFI IHBIHIAMEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F26550", Offset = "0x7F24B50", VA = "0x187F26550")]
	private void HJFPLCGKLMN(string? DJHPCBACCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F266E0", Offset = "0x7F24CE0", VA = "0x187F266E0")]
	private void IDAHGEDFIIP(long GHKEFPGHNPK, Guid NHDKLIMHKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F267B0", Offset = "0x7F24DB0", VA = "0x187F267B0")]
	private void IDAHGEDFIIP(IEIODDFLDHL? GDKPENFFPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F26680", Offset = "0x7F24C80", VA = "0x187F26680")]
	private void IDAHGEDFIIP(AOGHIGKKIKF? GDKPENFFPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct CMOGKLJMEBH
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class OCCKFEOACBF : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private readonly IEnumerator<DictionaryEntry> OOGKDOBKKND;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry BGELCNJOMDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7F2AAA0", Offset = "0x7F290A0", VA = "0x187F2AAA0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object MBLBFBKCCDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7F2AB60", Offset = "0x7F29160", VA = "0x187F2AB60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object IBMJNNAJGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2AC10", Offset = "0x7F29210", VA = "0x187F2AC10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A9C0", Offset = "0x7F28FC0", VA = "0x187F2A9C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
		public OCCKFEOACBF(IEnumerator<DictionaryEntry> OOGKDOBKKND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A920", Offset = "0x7F28F20", VA = "0x187F2A920", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A970", Offset = "0x7F28F70", VA = "0x187F2A970", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class HPDFNPIBLOG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0x7F24D40", Offset = "0x7F23340", VA = "0x187F24D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public HPDFNPIBLOG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F24BF0", Offset = "0x7F231F0", VA = "0x187F24BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7F24CF0", Offset = "0x7F232F0", VA = "0x187F24CF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E890", Offset = "0x7F2CE90", VA = "0x187F2E890", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object BLIBAMJKLIA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E7A0", Offset = "0x7F2CDA0", VA = "0x187F2E7A0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E980", Offset = "0x7F2CF80", VA = "0x187F2E980", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E6E0", Offset = "0x7F2CCE0", VA = "0x187F2E6E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E740", Offset = "0x7F2CD40", VA = "0x187F2E740", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E920", Offset = "0x7F2CF20", VA = "0x187F2E920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E3A0", Offset = "0x7F2C9A0", VA = "0x187F2E3A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E400", Offset = "0x7F2CA00", VA = "0x187F2E400", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2E460", Offset = "0x7F2CA60", VA = "0x187F2E460", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
		public RoomObjectCounts(Dictionary<int, int> NDNICBGIMKH, [Optional] Dictionary<int, int> AIGCIHOAGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E2C0", Offset = "0x7F2C8C0", VA = "0x187F2E2C0")]
		[IteratorStateMachine(typeof(HPDFNPIBLOG))]
		private IEnumerator<DictionaryEntry> FCCEAJDECJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E9D0", Offset = "0x7F2CFD0", VA = "0x187F2E9D0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E5E0", Offset = "0x7F2CBE0", VA = "0x187F2E5E0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E4C0", Offset = "0x7F2CAC0", VA = "0x187F2E4C0", Slot = "9")]
		void IDictionary.Add(object BLIBAMJKLIA, object KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E520", Offset = "0x7F2CB20", VA = "0x187F2E520", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E580", Offset = "0x7F2CB80", VA = "0x187F2E580", Slot = "8")]
		bool IDictionary.Contains(object BLIBAMJKLIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E680", Offset = "0x7F2CC80", VA = "0x187F2E680", Slot = "14")]
		void IDictionary.Remove(object BLIBAMJKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E340", Offset = "0x7F2C940", VA = "0x187F2E340", Slot = "15")]
		void ICollection.CopyTo(Array DDENONPPKCL, int KHMHPNKMLMD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class GIKNEPBCIMB : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x7F24600", Offset = "0x7F22C00", VA = "0x187F24600", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public GIKNEPBCIMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7F24470", Offset = "0x7F22A70", VA = "0x187F24470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7F245B0", Offset = "0x7F22BB0", VA = "0x187F245B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F25F50", Offset = "0x7F24550", VA = "0x187F25F50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object BLIBAMJKLIA]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7F25E20", Offset = "0x7F24420", VA = "0x187F25E20", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7F26000", Offset = "0x7F24600", VA = "0x187F26000", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7F25D60", Offset = "0x7F24360", VA = "0x187F25D60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F25DC0", Offset = "0x7F243C0", VA = "0x187F25DC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F25FA0", Offset = "0x7F245A0", VA = "0x187F25FA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7F259E0", Offset = "0x7F23FE0", VA = "0x187F259E0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7F25A40", Offset = "0x7F24040", VA = "0x187F25A40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7F25AA0", Offset = "0x7F240A0", VA = "0x187F25AA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x296EC20", Offset = "0x296D220", VA = "0x18296EC20")]
		public Invention(long HLIPPIOIAJK, int FOAMCIPOLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F25910", Offset = "0x7F23F10", VA = "0x187F25910")]
		[IteratorStateMachine(typeof(GIKNEPBCIMB))]
		private IEnumerator<DictionaryEntry> FCCEAJDECJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F26050", Offset = "0x7F24650", VA = "0x187F26050", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F25C20", Offset = "0x7F24220", VA = "0x187F25C20", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F25B00", Offset = "0x7F24100", VA = "0x187F25B00", Slot = "9")]
		void IDictionary.Add(object BLIBAMJKLIA, object KKGBKLFKCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F25B60", Offset = "0x7F24160", VA = "0x187F25B60", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F25BC0", Offset = "0x7F241C0", VA = "0x187F25BC0", Slot = "8")]
		bool IDictionary.Contains(object BLIBAMJKLIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7F25D00", Offset = "0x7F24300", VA = "0x187F25D00", Slot = "14")]
		void IDictionary.Remove(object BLIBAMJKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7F25980", Offset = "0x7F23F80", VA = "0x187F25980", Slot = "15")]
		void ICollection.CopyTo(Array DDENONPPKCL, int KHMHPNKMLMD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> LMIMLIBGAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public readonly IReadOnlyList<Invention> GEMFOAJIBNE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	public CMOGKLJMEBH(IReadOnlyDictionary<Guid, RoomObjectCounts> IKBLFCCIPLL, IReadOnlyList<Invention> INOCOPOLOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E2A0", Offset = "0x7F1C8A0", VA = "0x187F1E2A0")]
	public static CMOGKLJMEBH DOMGNPIEMGM(AJMAHGBGLEH MODBIBDJKOA)
	{
		return default(CMOGKLJMEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F360", Offset = "0x7F1D960", VA = "0x187F1F360")]
	[CompilerGenerated]
	internal static int JAAIGNLDION([In] IReadOnlyDictionary<long, int> KGDOGMDBELP, long? GHKEFPGHNPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1ECB0", Offset = "0x7F1D2B0", VA = "0x187F1ECB0")]
	[CompilerGenerated]
	internal static void GEJBBIOMFMA(int INFMNKFKBAC, [In] AHAMAKFMPAK EOAPKPHDLHF, [In] Dictionary<long, int> KGDOGMDBELP, [In] Dictionary<Guid, RoomObjectCounts> IKBLFCCIPLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum MHICFAGLKOH
{
	[Cpp2IlInjected.Token(Token = "0x4000585")]
	StudioObject,
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	AudioClip,
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	Projectile,
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	ParticleVfx
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class AJPMMEDAFEP
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class NPJEHEPPPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public readonly Guid MLKNKNCKMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public readonly IReadOnlyList<Guid> AMJKFGDNBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly MHICFAGLKOH ILFPPKIKMEE;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A8C0", Offset = "0x7F28EC0", VA = "0x187F2A8C0")]
		public NPJEHEPPPNM(Guid JJMDOACODNI, IReadOnlyList<Guid> LPJCCHCLJGN, MHICFAGLKOH PDFIFNAMHFC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private readonly GFBKOJBAFFI EGLGNFPHMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private readonly Dictionary<Guid, NPJEHEPPPNM> BCCMAINDEMN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GFBKOJBAFFI PABBPMALBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DE50", Offset = "0x7F1C450", VA = "0x187F1DE50")]
	public void JDPCENHCAFL(Guid IKGBJKAGFKJ, Guid DFOMLKALLEO, IReadOnlyList<Guid> LPDOKNCGHBE, MHICFAGLKOH PDFIFNAMHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DD60", Offset = "0x7F1C360", VA = "0x187F1DD60")]
	public bool BLLDOPAGIIJ(Guid AECHEPHMHHL, [Out] NPJEHEPPPNM NEGAOOELCKE, [Out] bool MMDADBBHHNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E060", Offset = "0x7F1C660", VA = "0x187F1E060")]
	public AJPMMEDAFEP()
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
