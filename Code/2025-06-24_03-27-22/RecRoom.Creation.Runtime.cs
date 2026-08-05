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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C7E0", Offset = "0x7D3B3E0", VA = "0x187D3C7E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AGDJCJEFDGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> JOKLNNLMHKH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> KENLPAIEMBJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> GHLNCODKBPH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> HOPHIGJBLJG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KJAAIELPEFD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DEBEELMBAEK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string CBJJDJABDIF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D2A0F0", Offset = "0x7D28CF0", VA = "0x187D2A0F0")]
	public static bool OAHDJFJDHJO(Guid FCKMKNONCDI, int ICBNHNJJJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D299E0", Offset = "0x7D285E0", VA = "0x187D299E0")]
	public static bool CAGKBDBGHFL(Guid FCKMKNONCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D29A70", Offset = "0x7D28670", VA = "0x187D29A70")]
	public static string CBENMAAAMMP(Guid LHECJJHBNHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ELLGIIGJDFK]
public enum LMKJJLJAMCK
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
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BFA0", Offset = "0x7D3ABA0", VA = "0x187D3BFA0", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPIPMJLAONC
{
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KINMFKKADPI;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid LMIMJFODKDI;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MNINAPPDOIM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid BLMALMDKAAO;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid DEBBFMHJICM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid GEOCEPANILN;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid JLJKDJPAJDN;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid HPCKHDDNIPG;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid OGCPEPANIAI;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid KDLIBAMFINC;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ANLIDHIAJMC;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CAEOKABHKEG;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MEKLPDHLNME;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KIGHODOCFIK;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LNALOMJIJAE;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid AFIHGIAFAKP;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid KICJFHPGJIJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DILMNFKNGGB;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid OEHMAJHILEC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KFNKPKHPEID;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid EPEBIOOMJJG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid GMHIEMIKMKG;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid EFKFAIPPCKJ;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid AAIBLOOAGMD;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid LCJNCBCBPNK;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GKFDNMOFOMG;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid KAOAMBLIHGJ;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid PFEKNIIIEOL;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid EOLBFKEIHGM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MBPCEMALDCP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CAMKLAIMPPC;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid KHDDNKNPNPD;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PHGDAFEJJFK;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NLBPFJGOOMB;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid KNOINPACFPH;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid NLHBIEPHPGH;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid NADMLHFDDNM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid DIFOGDIEAKM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid LDKHFPKPDLP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid BAKGBMEHPHD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid NOLNDNOMDKH;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid EPKDJHGKOHB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LKJKNOPDPDL;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid EEJLDDGIKGL;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LOPDALCBAJK;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid PDGDFBPADPO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid OOAOLBGAHHD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MODJKAPDMHF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid MLCOHKKJEHG;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid ELONDEAKMJO;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid MLICHEJPCNP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid DOJIENNLFPN;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid NCDIBAFALBC;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NPBGDILGNNF;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JMPNDMPDFOC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GGEAGOMLEGL;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid GOHCNMNGPEH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid AJECBJIPOLP;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HDOFKCCIFJN;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid AJNGADOKAJK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid NBIKBNFHFGO;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MIBCMGAHAHB;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid CICGLLLHGBG;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid PMHHDOBNJCI;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid PIKBEGHBEJK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid DDGCKKIBJLD;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid HPOMFHPAOIE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid CHAGCABOHLH;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid DLPOACNEGKD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid JGFKILLJEMK;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid DPIDNGPJMHN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid POHPMNKAHDN;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EBALDBFALHP;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid DKJPLAHEMBG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BPACBLOOGKA;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FHGCLODDAFH;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HOJANLMPGIN;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IAJBGANEGHH;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid ONNNFJJGJNJ;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IMCCGDKDLBO;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid DLGNHEOGMPE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid EDGKEMIFGHC;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid JMPFLJCAFJD;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid EAMNDLDANNN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid PMIFKFIMHPI;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid CKAOMDMKJGL;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EPMPCBDMJAG;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid AAPBMJPEHBG;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PDPEKIGFFDF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid BMDNCPFOGHI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid OPDAANDENCO;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FLFMNNJMEHM;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DBBLNDMLPMP;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid EODKBEEIJJC;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid CPMKENFHMII;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid NJFENHJCANC;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid FHDFJHFIHHB;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid KMFMLGOONDA;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid KMMGENBFMPI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid PJHDIKHBOEN;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid MAFACKGPPLM;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid HBCANNDFLOA;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid CMCOAEDAFFM;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid MAHLCDANMGM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid GBIBDAMBBHA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid LCJLGLMOJOH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid PCGFGEICHNK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DOGJAAONHCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid CHMGOKOEOGA;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EMOPPNMMGOC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid EFFNENBFGMN;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid CKJJPOPPBHJ;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid FCKKPCNEODB;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid EMMJGFHMHIC;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid HBOEPLMGAAA;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid BMGMEADLAMF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid LMNHIKEAIAP;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid GCOPHIELBLM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid BFMACBABJJJ;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid JNOGICJOKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid KDFPMIAALDJ;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid BLBGIIFICPE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NAOCOFPMDKF;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ANDPPGHOAIJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid PJKJHBBDEJA;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid NJJIPDJBHFJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid PLELPEIIFGK;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid CLKOOIJCGOC;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid NGOIDKIPFFK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid JIILHPOJPCG;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid CJDEAIOFPHC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BHBJKGDHADH;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IOMLOEBFNGC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid CJHBJPHNALF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NFMBDELEGGK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GCPDJFJODCL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid PBGMBOIELIN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid LOEOGCPHIOG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid JBMEBIMBFPD;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid DIMEGHEJKIB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid BGONKMCNBOK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HLDANHGIOGO;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LLDJKPADDMP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid FOHGECCNKLO;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid OBCGAJAGINP;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid EACINDCAFIE;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FKGILGJJMGK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid HLBIDOOFKNG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid NODILKJOFMC;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid LKHHDJKAHDE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid AOBKMLONGAK;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid KMNBBHJJIDN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid FDAIAHKAFFD;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid JKMEHACPODF;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid ALJDKELIGDP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid BEAOPDNLBBN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid HHGBFFPCCHO;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid ELPOHAKNOKO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid MONKAFNNBIF;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LLIFJPCMPNF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ICNAODHOPBA;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid IAMIBEFLGLN;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid KICJIPMGLEB;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid FCEMDHDCGPJ;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BENAFFENCHH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KIAACKMIELJ;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid EMCLKHEFDCC;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid PNKCMLEAIAC;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid HMFENAOFGIF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid PEIMPEKOAOJ;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HMMIEGLACDK;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid CBLAMGPHPNE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid CFLHHCFOPNL;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid EMPHOLLEPMM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid LGFCGAOAHAN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid GOCFLOMDJMC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid CEMHHAFJJOD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid GJONBCAJLEM;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid AENKHFFBNPP;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DCBECBKOOMM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NFFMKNBDOFC;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid ODOAFGOFMDM;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid EKLBGEDDPEC;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BJLCFBBIIFC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid GKOPHEAJOPE;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AEPGIOMPFJC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid APDMNBDDEFJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid CNABMOEPLLM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FKBICHHBFPD;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JNJGCMGDMIB;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PGCLCHGIFEN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JGDODGAPNIC;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid DNCFFBGDKBN;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DMCMKPPEKAA;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid ADHLMCEMOFH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid AJIOFDLMJOE;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid OOEMMPPLFIB;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid PFJDCLIPDKN;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid JKADDHFDLAK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid KFCCHNICGIO;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AKOAEMDMLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid NHFGHEBOCJI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid NCFJDLJDCJM;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid OKHDHFHHKMJ;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BIDGNBIABHH;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid PDLPAONHJHH;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid AELIALAAKCF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid EJHOBFDGKEH;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid DOMPDOAABND;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid MLKCIHOFEHH;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid BJCLNFGPHAE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GBDDOMCMEHL;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid NJFJABCNPMI;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HGPEONLMMCC;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DHBKMOBOBPN;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid LKGDOHNOMPK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NAKDKCIJJAO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid JHKJODOLFNP;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid PHNAFNNONON;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KJFPAFAPNBD;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid JIDGCDMAEKI;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BBKKMFKAPLF;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid PGFNLIGAEEP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid IHAJKBFBIAI;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IKALHEFDOJP;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FDIEFGEOKNE;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid FLHHJCIFAPD;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid KNGKCFIIJPO;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid AFKGFDNBBLI;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid ECBMDCDKAMP;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LALKKIEKAHI;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid EEGJPKJGKEC;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid DIPPPHIBCMC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NEMKIDFKCFB;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid CJHDBLIGPOI;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid PDADAJPGAHD;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OPLBBGJCIJE;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid OHPCPNEPKBE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HKNKAJJCNJH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid IFKPEALLKIL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid COEMMAMAMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid AIJENLBPKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid KPAPGFFNELM;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PACPFBMFKCC;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid AAFIAGCOECF;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid KFJEBBJBGDE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid GFECBIOBHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid HHLJIELKFNB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid FBPGMFJMFOA;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid ENNNPKMGIHH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FKDPCMGMCAN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PLNMPDPCJLO;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid DIKMNMPANIH;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid OMHCDADLKHA;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MMMHEPHEFHF;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CPBNHKNGPDI;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid AODGFMFJOCC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DHGLKNCOLAC;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid JDBMLLPJKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LHAMKABDKGH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid MPFNPNADILF;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GJGMDFCIILJ;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NDGFGJNEMDG;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid ECIGJOCPHIG;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NPFDJFKPMLM;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MIECKNMGCNH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid KHDCJFIIOBI;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid NAGPIKFCPFF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LNBALBEEOON;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid JCBGCIJCABB;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid DJOJIAPBKPC;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JFOMCKMBMHL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid EIHIIDHJOAM;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid LLOABKBJDAF;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HLFGIIOMHJI;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid BHMENLMNLIB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid AEICPELGGIH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid PMKAABMIEEO;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid MEOGBMEAMKM;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid GOFFGCJNNPD;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid DGDDHJPDHDC;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid IOMJCFOHCKK;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid CBGOEJOPJFJ;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid HIPHHCHJBCK;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid DINPKAGBPKM;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid BNACAAIFAAN;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NHALCJDAFIA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid FNACLDIMKCI;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid MPFLOEGCEPM;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid MPJLFFFCJBI;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NEJHDDNFLHP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid MNEJEPBKNND;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LEJMOBPEKNC;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OJEJADIELFP;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid FMBHOEGJIKI;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FNEPDOAFOBP;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JADBMDLLBHM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JBJGANLGGFM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JCMLGHOCNGI;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid KIOHOGMLEBK;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid LKLMOEDPCLI;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LGONFAFFGEL;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JGAKIIOOGJC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid ICNJBBNJKID;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid NHMJNPPJFNL;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FEIBLGIMLHC;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid IONLCGGDAJJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid KFKAMFAEFDC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid JPPJAFONPGD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid BFPKAKOPJJE;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid EACLOANCFIA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid ONIFLILCDCL;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid JGEMDOACFIF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid FMAMPEKNPGG;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid POMNBCFIKLD;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid APPGAFFOFCI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid NCGGMPNPKBJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ECALLPKGAHH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid OJNKOBGJNEG;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LDMPONMKBPM;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid FIDFMIFKPHG;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OPFIJFMFIAB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid GBJGAAHCKDE;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid CDPALIIAEBA;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KDDNPBMNDBM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid DEACHHBKKCL;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid PPJCAJIOGDF;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid CJOMDIFMNEE;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid POGHBJKBFMJ;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid PEMNMIBBJMJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid GBAONBNNNOO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BMMPDOAODBL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid KIMBLMGKFAB;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid ECOOHFLJJME;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FDHBLOIFEGB;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NPOPKKOGKEM;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PMGAMLLHJKK;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid AOFMILAFIGH;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid CBFNOKKMEHE;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CMBGEJBDFOH;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NLEMANDOKCL;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid GCKOEKIOGKC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid EOJHIAFLNEO;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EIHAIKJKBGO;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BAGIDFBBFEG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid EILDHLBIBFB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid IHJBPELFFMN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid IOFHOHNJKOG;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HFLOKGBFINF;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid PGBGOFFEHAM;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid JLPKFCDKOLB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid HMOHLOGGOAM;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid MLCBCIMKCPA;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid MLOKGNCFBLD;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid POJLLHOKDPE;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid BEPCLNJPMAA;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GMKLNCPMFNI;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MHIJDHADCNH;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ALENJGCEJDK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BPPFPIEDBNG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid MBDBHHNBKJL;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid KCEFLIMKJAM;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid NCCAIBNKKFB;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid CKMLLAMOJCL;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid OOBAAOHHONG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid COMGMILBJIL;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid CMJMHJINKKP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KNKHKPDLCHH;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid PBLAMIGBLEC;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ECBHOLFBDNE;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FHHGLDAHDPH;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid JPDEDLHKMGE;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid POKNOHEPBNN;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid BHICIICMOOC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid LEGIHFNINEL;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid DFLBHCANMCF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid JCHDMNIGLLK;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid JBDAAPAHCPO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid BHNPDCEHBJN;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid FLHPIGHHCJD;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid NOHMNCHBGJG;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid BFHEOMHGCDP;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid DLAEACJPOIO;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid GGPHILLIIMP;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid OJIAIAKGDEF;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PKDACFJMBHD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid JJBHFEEOJKC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid DKBOFJJCNCN;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OECCAPJFCGB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid NEIKLANJBFN;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JGJIBGLAIIH;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ACNFJGDLNLP;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid MFBCEKJOPPP;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid PAOCHHKDHJN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid OKFNDLCFEGK;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid OLPFLAFDBNB;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid HLPPEFHJGAN;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid IFIDDNHCIDD;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LCLAKEHELKD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid MGNNMBEOFAE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IBILLHAKOFP;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid DBDBONOHBBF;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid LIPPLGAPLBO;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid OKINPLDBFAP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid NJJDPPPNKBK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid CCNPPDIHPNN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid NJOJBPFPHAI;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid OPHJLGNMDEB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CGIPOAHAJEF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid CNJBLHIKOHA;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OICBMNJFOLK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid IELKLIIFCJO;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid PLBEIKKELFD;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid NLELDBIIOJK;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PJCLKBJFPCO;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DCJOGIFGIBI;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AANBGDBHJNN;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid HGNFBGBGBFN;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid HNONNHJCNGH;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid CEHANBBDHFE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid EOIAGEKAFGP;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JNMIEOOBMON;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid IOALABDDEJH;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid NNJLHMFEMAE;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid MCIBEBGFPBE;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid MDCDFGPHAHC;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid EHNKBPCCANE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid LLADMPKFOCL;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid AGPFLLIPEBG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid OFOMIPPHOIG;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DBJNOAJIEEC;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid AOJIMJHIIOK;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid IIDGDFJBMNA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid OFDDFGHEGFL;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid KAANLNDPKOA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid FJNFHJJGLDM;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid OBMPIFDLNIP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MCJPKNDFFKL;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid KEKLBFMLNJA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid BEFKCNLKFCE;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid BEJEABGJCGJ;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid IPLDMIABCHK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CHILCLLDMDH;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid ACNLFNKEJKM;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid ABFADGJNELI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GPOKOPDFAEM;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CJMDHCAKLNH;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid CCMIPFMKGHF;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MPIHOMHBFND;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid HKOMFEGOIJP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid BCPAGLPCDOG;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid CDLJOELLOFH;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid LJLLMKJJMFC;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid JAGEPGKPHNM;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid OFPECGNEMBP;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JNAKFIHFPDG;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid HPNDBCBJBGD;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid MPGKHHANHGM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid EDDMHCPMCCN;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GKAJAEPLNMG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid OCKDLBGBMAP;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid GKDPIAFNHNN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid CPCHOBIHCCH;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MEPHDBEPJFE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid LKBJGNFFOHN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FHHACBDPBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HMNHGBMOBLE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid HENGHEGGGBP;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid GCODEGEBGPG;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BPIMAPFDJJL;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IDDGCPLLNBC;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid IFCECAFGDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid CCHGCFHCDPO;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid HKGAKJJGMIO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BDGPJPNABGL;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid OBBAKPCADOE;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid MHNNHMDCDFB;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid GKDEDELLEDJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid HHCIGBBAKOA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid OHHCMDIBHPM;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid KFJNCNFMAAH;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MNOCEKLHPGI;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FLEIFIMPIGO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid ACAIHFJBJGJ;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid ODOMLLEGHFI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MDMKHONAPJH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ANMCLANEHOI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BOOFEMINFMH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid DEBDALICBJC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid IGCLHLAHNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid LCCNBEGKPIJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid OBDAEENPJNF;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid ADJOEKGNFJD;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid JGPEOLGLINL;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid PJGGCCGCFEJ;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid LFOBEMHJBCK;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LCFNADGMCJP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KHOOFLMGEPD;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid IEPNDPEKCPO;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid DBIDNPCAKEC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid HIPFMFIDLKE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid KJCENPEFJDL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid LFMELHLALLO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid JOIKELMIEJC;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid MLMDDFLGECE;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KMDCPHOKPKN;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid MNCBGOPCAOH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid HMBMMKBDPBH;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid IBODOKGKKFN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid BNINMNGKOEO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid ICBLFMIJHFG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid FGHCLMACANA;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BJDGKANPIIA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LGAGMGAIIAH;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid MJOFLFKCMJP;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JCFIKKBHGDK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid EFKIFDDGLDL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid IDBLGJHPNFC;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid GJGOGELOFKK;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid HNCKBNPLFLK;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DJDNNAOAEPN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid GPKMFMLFINC;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid GAGKAMBKLEM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid MFFCEIGIAJP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MGKMKBJBGKI;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid IGONAFBCMKE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid AHAOABGGMFB;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OMIEMPFEFBH;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid HHOEFJPEOBC;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid IEIMLNJFOKG;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid AOILFMNBGKG;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid BDOOFLJKNIK;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid MACDMAOCOAE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid FJAPIHJCKAG;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid PDMFDKNEGDB;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid NDAIFKMJKCE;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid MOCGNCENHGG;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid NIKKEGBELPA;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid CEPBFAOOAGH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid EIEIKCGJPOD;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid CCOHGMABINF;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PGPHFPBKGMA;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid HHCLMDBAEIE;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GAHAHOAOKED;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid GNGFOFOKMDC;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid MMMCEGLMPGJ;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid INGKEOKECFC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid KGHGIGFNDIK;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid IOJCJCDDDMK;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JEBJDOGOLHE;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid KDDMGLLGEGB;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid OCIGMAHCLAL;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid GEKKGBLHGEL;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid JHEDMNKJCDK;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid KIKHCADADPM;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid PBKLGDOIGGE;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid NLPCCDINHMD;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid MIHIECCPAEN;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid JPGHMMHFMGJ;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid PFLGIKOEHEJ;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid MEHMFDAPLEO;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid HPFCCHJNCDM;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid OBBGFCNBFGO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid MDHLIPPNICI;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid PPCHKIJMAKM;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid GCCPAIDONLC;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid KHDEOGIBLFE;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid DHLFNLDFGFL;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid DIBOGMNLBJE;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid NCOBFHPEKLM;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid DHPFLPKHAPA;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid MCMLAJFNJAL;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid KLBKOCILIEF;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid AKOEHFLJJDG;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid PNKNIALJIJE;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid LENKCKGDFEH;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid EEAHGJJCMCL;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid FGHPEHFMEJO;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid DKFBEHNGGHA;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid EIBMDHLKJPI;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid KAFGFMCEEIL;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid DKCLOFHAKKI;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IBAPLKMOFMA;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid NEJOJJCENJP;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid NCNFODKOOFC;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid CDFBILKCHHH;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CMBGLILELHG;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid ADFNNILFIEK;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid HEDICKKAEIG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid JPFGMEGBDIA;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid HCNLECLDKLI;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid IIKDIEMEONL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid JDAAICIOGLK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid MMGKJJOGJNI;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid DIPJKIAKFHC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid HOEEPHCODNJ;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid GBIFCOIHCOH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid HEJNLNDADBI;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid BEFHDLFNLKC;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid HNJFEIFMJLL;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid ILCAKMCBBBA;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid NMJOAOPHEMO;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid PGKJDGEJEBM;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid AMLIEAEGGEJ;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid NCBMKLCFKMJ;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid HIINIEALLNA;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid ANPJFKGPAPO;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid JOKLAAJGKEI;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public static readonly Guid DAPOJJKLDFE;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public static readonly Guid LLMLOOMNHLC;

	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public static readonly Guid LDADGNMCLIG;

	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public static readonly Guid ONOEGHAPKAF;

	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public static readonly Guid DJGOLNECDOK;

	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public static readonly Guid MLFAIFNFDAD;

	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public static readonly Guid MEDGCJFCBLH;

	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public static readonly Guid MCEJDDFNMDE;

	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public static readonly Guid EBEMOJEIDCN;

	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public static readonly Guid KANGCCFKBCP;

	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public static readonly Guid BBMMFIOEJLA;

	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public static readonly Guid DKFBHCLKEOO;

	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public static readonly Guid LJIAHMEEOIL;

	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public static readonly Guid CMDNGNJMNFE;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static readonly Guid FMFDGPHCLLH;

	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly Guid EMNLIPBALGM;

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	public static readonly Guid KDEBFLEGFNP;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static readonly Guid HGPOGGOJFOD;

	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly Guid NMCOHBNGKGG;

	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly Guid HCNPNLIMBMN;

	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public static readonly Guid EDIFGHKMHEN;

	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public static readonly Guid KAALOPDGACL;

	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public static readonly Guid BLCEPENGKFA;

	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public static readonly Guid EGJCMDLHJLK;

	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public static readonly Guid PPMHHFHMJFB;

	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public static readonly Guid IFFGAOCAAOI;

	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public static readonly Guid IJGCHFNPLOE;

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public static readonly Guid JJAJOMCBOFL;

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public static readonly Guid PAAJNGOFAFF;

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public static readonly Guid PHOGPPPAMAP;

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public static readonly Guid CFNFPIBNEEH;

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public static readonly Guid JFKIMPJMOPH;

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public static readonly Guid MPFAMOINPGK;

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public static readonly Guid BKMMNEDDODJ;

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public static readonly Guid JAGLKLBDJOE;

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public static readonly Guid LLEBIKOJCMK;

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private static readonly Dictionary<Guid, LMKJJLJAMCK> ABJAMKKKKMI;

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private static readonly Dictionary<LMKJJLJAMCK, Guid> BOGFPBCLOCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LMKJJLJAMCK> CEBAFEECPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CD00", Offset = "0x7D3B900", VA = "0x187D3CD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LMKJJLJAMCK, Guid> EMADKONNJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CCB0", Offset = "0x7D3B8B0", VA = "0x187D3CCB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OHOEKDGADCD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGCKNHJLFJI(Guid LHECJJHBNHF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FMDJKIDGLHP(Guid LHECJJHBNHF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class HMCBPDCKBFB : OHOEKDGADCD
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LMNAENAJPCE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public LMNAENAJPCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BDF0", Offset = "0x7D3A9F0", VA = "0x187D3BDF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BF50", Offset = "0x7D3AB50", VA = "0x187D3BF50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BEB0", Offset = "0x7D3AAB0", VA = "0x187D3BEB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D3BEB0", Offset = "0x7D3AAB0", VA = "0x187D3BEB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MLONIAFKNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public HMCBPDCKBFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private IEnumerator<string> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private Dictionary<string, HashSet<Guid>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private string <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter<List<Guid>?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C070", Offset = "0x7D3AC70", VA = "0x187D3C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C780", Offset = "0x7D3B380", VA = "0x187D3C780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private Dictionary<string, HashSet<Guid>>? PPJPBBDMKOL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static IEnumerable<string> GHAOONODCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D3B7D0", Offset = "0x7D3A3D0", VA = "0x187D3B7D0")]
		[IteratorStateMachine(typeof(LMNAENAJPCE))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract IReadOnlyCollection<string>? PMOIDDOKKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected abstract bool COACEKNMGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected abstract bool PDLPFHEBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task<List<Guid>> CFKCNCHMNEO(string GGKFDOCECBH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BBB0", Offset = "0x7D3A7B0", VA = "0x187D3BBB0")]
	[AsyncStateMachine(typeof(MLONIAFKNHI))]
	public Task OGNEJNDGFDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x11FF100", Offset = "0x11FDD00", VA = "0x1811FF100")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B900", Offset = "0x7D3A500", VA = "0x187D3B900", Slot = "4")]
	public bool JGCKNHJLFJI(Guid LHECJJHBNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B830", Offset = "0x7D3A430", VA = "0x187D3B830", Slot = "5")]
	public bool FMDJKIDGLHP(Guid LHECJJHBNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B710", Offset = "0x7D3A310", VA = "0x187D3B710")]
	private bool AIOAIDPAINO(string AMMNBOHIAEL, Guid LHECJJHBNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected HMCBPDCKBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PCPKPNGMEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CC80", Offset = "0x7D3B880", VA = "0x187D3CC80")]
	public static bool CNGMKPOAMJP(BLOBFEKCEDA JONHLOKNFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C860", Offset = "0x7D3B460", VA = "0x187D3C860")]
	private static bool CNGMKPOAMJP(FBOLJECIJIH GAPFGOJCKND, BLOBFEKCEDA JONHLOKNFFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NKEKBNMEGCM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(BPNDFKFFJNJ PEDMEJIDLNB, [Out] Dictionary<int, int> CLBIGPMKDLO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NMCPHPKNFMD OAHIFNEIMIB, GBFNBAPAGPL DHDHPEPEHPH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JKAHKNHDHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public readonly HFFDMDCBNIF APBPIBEOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public readonly IEnumerable<FJFJDBNHDLA> BMLFHNNKKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly IReadOnlyList<FJFJDBNHDLA> FHAKMEJLMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public readonly IKLALLBKLKC<FNJCFKDMDPO> NNMBAJABALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public readonly IReadOnlyList<BMAAMMAFHBI<DKJICOCFIKD>> FNOKKKAPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public readonly OICIMGAKEEF EFGJHAEMENP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JFJGOGEMFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BD80", Offset = "0x7D3A980", VA = "0x187D3BD80")]
	public JKAHKNHDHOA(HFFDMDCBNIF BAJMAFHHPOP, IEnumerable<FJFJDBNHDLA> GJNNPOIHKMN, IReadOnlyList<FJFJDBNHDLA> GAGIMOMMMCI, IKLALLBKLKC<FNJCFKDMDPO> MCLIOLJNHFD, IReadOnlyList<BMAAMMAFHBI<DKJICOCFIKD>> OIDHEIIAMFJ, OICIMGAKEEF KKACGGHLLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HNONHECLNKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public readonly HFFDMDCBNIF APBPIBEOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	public readonly IReadOnlyList<FJFJDBNHDLA> KBBKFKAPNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public readonly IKLALLBKLKC<FNJCFKDMDPO> NNMBAJABALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public readonly IReadOnlyList<BMAAMMAFHBI<DKJICOCFIKD>> FNOKKKAPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public readonly ByteString OOKLHMOGCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public readonly OICIMGAKEEF EFGJHAEMENP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BD10", Offset = "0x7D3A910", VA = "0x187D3BD10")]
	public HNONHECLNKM(HFFDMDCBNIF BAJMAFHHPOP, IKLALLBKLKC<FNJCFKDMDPO> MCLIOLJNHFD, IReadOnlyList<BMAAMMAFHBI<DKJICOCFIKD>> OIDHEIIAMFJ, ByteString BGJDBEFJPBC, IReadOnlyList<FJFJDBNHDLA> PMEILFIDCKE, OICIMGAKEEF KKACGGHLLBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FEBMDIJDLGI : PJPDNOFBGFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public readonly Guid EJPANHPHONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<Guid, Guid> IGFGOFBOBHO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8BDD0", Offset = "0x4C8A9D0", VA = "0x184C8BDD0")]
	private FEBMDIJDLGI(Guid ACFEMIJCPEM, Dictionary<Guid, Guid> IGFGOFBOBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B1D0", Offset = "0x7D39DD0", VA = "0x187D3B1D0")]
	public static FEBMDIJDLGI JHMOIFLKJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B260", Offset = "0x7D39E60", VA = "0x187D3B260")]
	private static Dictionary<Guid, Guid> JIODFILKMKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B310", Offset = "0x7D39F10", VA = "0x187D3B310")]
	public static FEBMDIJDLGI NCBBLDFOPMM(IReadOnlyDictionary<Guid, Guid> ENEAIMANIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B3A0", Offset = "0x7D39FA0", VA = "0x187D3B3A0")]
	public static FEBMDIJDLGI NOPJHIAKMDO(IEnumerable<KeyValuePair<Guid, Guid>> ENEAIMANIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B690", Offset = "0x7D3A290", VA = "0x187D3B690")]
	public Dictionary<Guid, Guid> OFPEAJMPMCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
	public Dictionary<Guid, Guid> JEAMBEMOPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B320", Offset = "0x7D39F20", VA = "0x187D3B320")]
	public void NKAMMCABBBC(Guid ENEAIMANIIG, Guid JAKICABDOHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AEB0", Offset = "0x7D39AB0", VA = "0x187D3AEB0")]
	public void DLFFJNCDPHH(IReadOnlyDictionary<Guid, Guid> ONIOALGJIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AD60", Offset = "0x7D39960", VA = "0x187D3AD60")]
	public Guid DKGLCKIMNHC([In] Guid ENEAIMANIIG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B130", Offset = "0x7D39D30", VA = "0x187D3B130")]
	public Guid IIOPCKDFHEH([In] Guid ENEAIMANIIG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ACF0", Offset = "0x7D398F0", VA = "0x187D3ACF0")]
	public bool BBPJLKHEHNJ([In] Guid ENEAIMANIIG, [Out] Guid JAKICABDOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ACF0", Offset = "0x7D398F0", VA = "0x187D3ACF0", Slot = "4")]
	private bool GLHDIMHKNCC([In] Guid ENEAIMANIIG, [Out] Guid JAKICABDOHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ABCIEIAGGDN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class EANOBNJLMFC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EEKHNCMGDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public HFFDMDCBNIF staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EEKHNCMGDCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7D40DD0", Offset = "0x7D3F9D0", VA = "0x187D40DD0")]
		internal IKLALLBKLKC<CMOKKKPGLHC> MFPJMKKBNLE((IKLALLBKLKC<FNJCFKDMDPO> GraphId, IKLALLBKLKC<DKJICOCFIKD> NodeId) i)
		{
			return default(IKLALLBKLKC<CMOKKKPGLHC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private static readonly JBAFCMMBKLF<CMOKKKPGLHC, int?> BOAAPFLPPJD;

	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private static readonly long GGMKOLNJDJN;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D700", Offset = "0x7D2C300", VA = "0x187D2D700")]
	public static (long, long) OPBMGMPLDIN(HFFDMDCBNIF LMGLNOGCBHD, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D2D5E0", Offset = "0x7D2C1E0", VA = "0x187D2D5E0")]
	public static long APIANKLNIEN([In] ReadOnlySpan<IKLALLBKLKC<CMOKKKPGLHC>> MPEBEBJGPBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D2DBA0", Offset = "0x7D2C7A0", VA = "0x187D2DBA0")]
	private static long PMJNLKMPHBF()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CPFBNEGNJDN
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public static readonly HashSet<LMKJJLJAMCK> BHLCJAPAJOO;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EEBIJPLMEHO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AHKAGGOKDLL : IEnumerable<FJFJDBNHDLA>, IEnumerable, IEnumerator<FJFJDBNHDLA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private FJFJDBNHDLA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private KBIDKABIPIG spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public KBIDKABIPIG <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private FACDGBFMPNH spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public FACDGBFMPNH <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private FJFJDBNHDLA System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public AHKAGGOKDLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CD50", Offset = "0x7D3B950", VA = "0x187D3CD50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CFD0", Offset = "0x7D3BBD0", VA = "0x187D3CFD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CE60", Offset = "0x7D3BA60", VA = "0x187D3CE60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FJFJDBNHDLA> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CE60", Offset = "0x7D3BA60", VA = "0x187D3CE60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E720", Offset = "0x7D3D320", VA = "0x187D3E720")]
	public static KBIDKABIPIG GOOMAPFEGLO([In] HNONHECLNKM PNKBKBNPKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E890", Offset = "0x7D3D490", VA = "0x187D3E890")]
	public static KBIDKABIPIG GOOMAPFEGLO([In] JKAHKNHDHOA PNKBKBNPKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F4E0", Offset = "0x7D3E0E0", VA = "0x187D3F4E0")]
	private static HashSet<BMAAMMAFHBI<HJPPLLAJNDP>> LNKAMPDEMMM(IReadOnlyList<FJFJDBNHDLA> GEIDDCHNCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D8C0", Offset = "0x7D3C4C0", VA = "0x187D3D8C0")]
	private static void CGNABPEMDEN(KBIDKABIPIG PGONMCAOFPK, [In] JKAHKNHDHOA DFHFDKFPLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F880", Offset = "0x7D3E480", VA = "0x187D3F880")]
	public static MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE> NANENKJDLDC(KBIDKABIPIG PGONMCAOFPK, FACDGBFMPNH ADGLLNKEOEP, FEBMDIJDLGI? DHGPPFIMMFL, bool HDCBFMLDHJM)
	{
		return default(MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F3D0", Offset = "0x7D3DFD0", VA = "0x187D3F3D0")]
	[IteratorStateMachine(typeof(AHKAGGOKDLL))]
	private static IEnumerable<FJFJDBNHDLA> LHCPGCJFAMG(KBIDKABIPIG PGONMCAOFPK, FACDGBFMPNH ADGLLNKEOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DF20", Offset = "0x7D3CB20", VA = "0x187D3DF20")]
	private static void FFDLBMAEPIH(KBIDKABIPIG PGONMCAOFPK, FACDGBFMPNH ADGLLNKEOEP, IReadOnlyCollection<ByteString>? FOBHNMEHFGO, IReadOnlyCollection<ByteString>? GKKICKJFDFD, IReadOnlyCollection<ByteString>? EAEBEIFONKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3ED40", Offset = "0x7D3D940", VA = "0x187D3ED40")]
	private static bool LHBICFIHFKN(KBIDKABIPIG PGONMCAOFPK, NMCPHPKNFMD OAHIFNEIMIB, FACDGBFMPNH ADGLLNKEOEP, [Out][NotNullWhen(false)] string? AJLIMPCCGHB, [Out] Dictionary<int, int> CLBIGPMKDLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DF90", Offset = "0x7D3CB90", VA = "0x187D3DF90")]
	private static Dictionary<Guid, FBOLJECIJIH> GFFBBJKNIPD(KBIDKABIPIG PGONMCAOFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EA20", Offset = "0x7D3D620", VA = "0x187D3EA20")]
	private static void IEDOCLCGNJK(bool OOBCEMAELFP, FJFJDBNHDLA DPGLACKNALH, FEBMDIJDLGI EBFGALPEOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EAB0", Offset = "0x7D3D6B0", VA = "0x187D3EAB0")]
	private static void JNAOEGPOCHC(FJFJDBNHDLA DPGLACKNALH, Guid OAKDFCIMAJM, FGFDBKMHGAO? KDLBCEBKMNN, Dictionary<Guid, FBOLJECIJIH> GKCNPADHDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E270", Offset = "0x7D3CE70", VA = "0x187D3E270")]
	private static void GIDDEINMJBL(IEnumerable<FJFJDBNHDLA> EBFEALAOEGG, IReadOnlyCollection<ByteString> FOBHNMEHFGO, IReadOnlyCollection<ByteString> GKKICKJFDFD, IReadOnlyCollection<ByteString> EAEBEIFONKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FACDGBFMPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public bool OOBCEMAELFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public OICIMGAKEEF KKACGGHLLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	public FGFDBKMHGAO? KDLBCEBKMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public FGFDBKMHGAO? LEMMBFOBLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public HFFDMDCBNIF BOHJNGKJPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public ABCIEIAGGDN NFFKCHIAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public NKEKBNMEGCM DEGMGNNIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public BMAAMMAFHBI<FNJCFKDMDPO> JHNBIODKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public FKPLOGODLGI IIMJDOBDOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public List<FJFJDBNHDLA> EKCCKNPACGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public ILDPOIGDHNO NJAKKEHADMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	public ELEFFOCNANC BPGHLLOOGMN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FGFDBKMHGAO
{
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private const float DGJNCELPLLO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054A")]
	public Vector3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400054B")]
	public Quaternion BFEELDCLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400054C")]
	public float LHHOCCKJGIB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Matrix4x4 KOFGIBAHFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D46100", Offset = "0x7D44D00", VA = "0x187D46100")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UniformTRS PDECKAKAKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7D45E40", Offset = "0x7D44A40", VA = "0x187D45E40")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x14F55F0", Offset = "0x14F41F0", VA = "0x1814F55F0")]
	public FGFDBKMHGAO(Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float LHHOCCKJGIB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D46290", Offset = "0x7D44E90", VA = "0x187D46290")]
	public FGFDBKMHGAO(UniformTRS OKMFCAACMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45BC0", Offset = "0x7D447C0", VA = "0x187D45BC0")]
	public static FGFDBKMHGAO BCOJNJAPJDH(FGFDBKMHGAO LIPFJJEAFCE, FGFDBKMHGAO NCAEDLHMCBO)
	{
		return default(FGFDBKMHGAO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D45E80", Offset = "0x7D44A80", VA = "0x187D45E80")]
	public static FGFDBKMHGAO GHOKLFELACP((Vector3, Quaternion, float) PEDMEJIDLNB)
	{
		return default(FGFDBKMHGAO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45EA0", Offset = "0x7D44AA0", VA = "0x187D45EA0")]
	public static FGFDBKMHGAO GHOKLFELACP(Matrix4x4 IKEEPBAGBLK)
	{
		return default(FGFDBKMHGAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D46200", Offset = "0x7D44E00", VA = "0x187D46200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D459A0", Offset = "0x7D445A0", VA = "0x187D459A0")]
	public FGFDBKMHGAO ADKGDMPMPAF(Matrix4x4 NMIBCHFJGAE)
	{
		return default(FGFDBKMHGAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7D46090", Offset = "0x7D44C90", VA = "0x187D46090")]
	public static FGFDBKMHGAO LDGJIFOFNHB(Vector3 IIBJECFMAJC)
	{
		return default(FGFDBKMHGAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D46000", Offset = "0x7D44C00", VA = "0x187D46000")]
	public readonly GMKNICPDGDB GJHEKJNHJEP()
	{
		return default(GMKNICPDGDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GBNILMPEHDG
{
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MMHBPJBOBJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	public readonly IOGOEJHPNCC DHOHPDPPIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private readonly EFKBKOGFPPJ CPLJFBGAKFJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x17BE2E0", Offset = "0x17BCEE0", VA = "0x1817BE2E0")]
	private MMHBPJBOBJE(IOGOEJHPNCC OCHMMOHMIHP, EFKBKOGFPPJ FBILGMMOBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BBF0", Offset = "0x7D4A7F0", VA = "0x187D4BBF0")]
	public LFDALKKIPJD PMIKKIFILHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B9D0", Offset = "0x7D4A5D0", VA = "0x187D4B9D0")]
	public static MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE> JHMOIFLKJAD(LPLMBEAJACA<BOFEABKGBFC> FBILGMMOBHC)
	{
		return default(MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BA80", Offset = "0x7D4A680", VA = "0x187D4BA80")]
	public static MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE> JHMOIFLKJAD(LFDALKKIPJD FBILGMMOBHC)
	{
		return default(MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BB30", Offset = "0x7D4A730", VA = "0x187D4BB30")]
	public static MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE> JHMOIFLKJAD(string HEMNFEKFCDO)
	{
		return default(MDDPJNIIBBI<FEBMDIJDLGI, MMHBPJBOBJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IOGOEJHPNCC
{
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FBLCFPKOCGO : IDisposable, IIDGFLNLEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private NativeList<PENOEPANFIA> JAFNDBEGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private float GFLDFOHFKDG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DAMCLPLILIH CIBCHAPBFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		[CompilerGenerated]
		get
		{
			return default(DAMCLPLILIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NEMPOJDGLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C48E60", Offset = "0x6C47A60", VA = "0x186C48E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BEOAMBCLKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C48E70", Offset = "0x6C47A70", VA = "0x186C48E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public List<IFJMBGALBMJ> GBFAIBEFOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IMEJEAEFBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D433E0", Offset = "0x7D41FE0", VA = "0x187D433E0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DKKLFOLJLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D40EA0", Offset = "0x7D3FAA0", VA = "0x187D40EA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D43630", Offset = "0x7D42230", VA = "0x187D43630")]
	public FBLCFPKOCGO(DAMCLPLILIH GEFKHBLJENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7D41E80", Offset = "0x7D40A80", VA = "0x187D41E80", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D420B0", Offset = "0x7D40CB0", VA = "0x187D420B0")]
	public Vector3 FHOEJGACGPA(int IFAMDLCCFIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7D41EE0", Offset = "0x7D40AE0", VA = "0x187D41EE0", Slot = "6")]
	public Quaternion EDOHBCJOLIA(int IFAMDLCCFIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7D42010", Offset = "0x7D40C10", VA = "0x187D42010", Slot = "5")]
	public Vector3 EFLLFBGELIG(int IFAMDLCCFIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D435D0", Offset = "0x7D421D0", VA = "0x187D435D0", Slot = "7")]
	public float PNEDCIPLLAB(int IFAMDLCCFIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D40FE0", Offset = "0x7D3FBE0", VA = "0x187D40FE0")]
	public void BLJABGHPHGJ(Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO, bool ANHBBDEMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D43570", Offset = "0x7D42170", VA = "0x187D43570")]
	private bool PMKLDOEGEJJ(int HNMFMBNLNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D425F0", Offset = "0x7D411F0", VA = "0x187D425F0")]
	public void JABEKHDLIBP(Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D418C0", Offset = "0x7D404C0", VA = "0x187D418C0")]
	public void BOCFAHAMJIP(int HNMFMBNLNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D43420", Offset = "0x7D42020", VA = "0x187D43420")]
	public void MJILCFJEFDM(int HNMFMBNLNOA, Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D41C00", Offset = "0x7D40800", VA = "0x187D41C00")]
	public void CNFFDLIOFJF(int HNMFMBNLNOA, float3 IIBJECFMAJC, quaternion BFEELDCLMGM, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D41AB0", Offset = "0x7D406B0", VA = "0x187D41AB0")]
	public void CMHCNNBDJJL(int HNMFMBNLNOA, Vector3 IIBJECFMAJC, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7D41950", Offset = "0x7D40550", VA = "0x187D41950")]
	public void CFCLBFLBHHB(int HNMFMBNLNOA, Vector3 AKLPJIPJBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7D42750", Offset = "0x7D41350", VA = "0x187D42750")]
	public static Quaternion JINDDNADEKA(Quaternion LJJPEGCDGFJ, int HNMFMBNLNOA, float MOIJDGCLMHM, IIDGFLNLEEE JKMNDIFKIHJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D42F50", Offset = "0x7D41B50", VA = "0x187D42F50")]
	public Bounds KODMFMOJBPH(Transform NMIBCHFJGAE)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7D42580", Offset = "0x7D41180", VA = "0x187D42580", Slot = "10")]
	public virtual void HJFKJNMEDBN(bool HINMNCDJELF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7D41DB0", Offset = "0x7D409B0", VA = "0x187D41DB0")]
	public NativeList<PENOEPANFIA> DKDBKJLIFDC(float ILMGKPBMCOJ = 1f)
	{
		return default(NativeList<PENOEPANFIA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IFJMBGALBMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public float3 AIFJIFCFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public float IPENPJMNGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public quaternion DKGBKDEHDEF;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AB90", Offset = "0x7D49790", VA = "0x187D4AB90")]
	public IFJMBGALBMJ(Vector3 JGJDJFGJGGN, Quaternion LJJPEGCDGFJ, float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AAD0", Offset = "0x7D496D0", VA = "0x187D4AAD0")]
	public Quaternion MJIGLDNIHGL(Vector3 HLIFPOIPBBB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A7E0", Offset = "0x7D493E0", VA = "0x187D4A7E0")]
	public IFJMBGALBMJ HKENKFCNNMN(Vector3 LFOFJPAGKEI, Vector3 MDJHAKBHNJG, Vector3 OPIDHCKPECC)
	{
		return default(IFJMBGALBMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A640", Offset = "0x7D49240", VA = "0x187D4A640")]
	public ICNDDNCEPCN AGJAGFDFBAM(Vector3 HLIFPOIPBBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OEFEEBGLKJM : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C410", Offset = "0x7D4B010", VA = "0x187D4C410", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C710", Offset = "0x7D4B310", VA = "0x187D4C710")]
	private void EPKPDAIOBII(Dictionary<Guid, Guid> PBGDGAKAPHI, BJABCOFBFEK OONJPAMBAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CCE0", Offset = "0x7D4B8E0", VA = "0x187D4CCE0")]
	private void EPKPDAIOBII(Dictionary<Guid, Guid> PBGDGAKAPHI, BHFNMBGEIMA NGPFNNGHACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C490", Offset = "0x7D4B090", VA = "0x187D4C490")]
	private void EPKPDAIOBII(Dictionary<Guid, Guid> PBGDGAKAPHI, EHGBOKKDHOH GMBGIBBBBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public OEFEEBGLKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class PEBJEACPHJA : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CE80", Offset = "0x7D4BA80", VA = "0x187D4CE80", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PEBJEACPHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PHFAOAGFFAM : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CF30", Offset = "0x7D4BB30", VA = "0x187D4CF30", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PHFAOAGFFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FMBIMFGAMPO : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7D46360", Offset = "0x7D44F60", VA = "0x187D46360", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public FMBIMFGAMPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NDIGGIMIKHN : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BC60", Offset = "0x7D4A860", VA = "0x187D4BC60", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NDIGGIMIKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class PCECBMAGKHB : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CD40", Offset = "0x7D4B940", VA = "0x187D4CD40", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PCECBMAGKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CANHGKCDOOH : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D1D0", Offset = "0x7D3BDD0", VA = "0x187D3D1D0", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CANHGKCDOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GNHCAJHKPEG : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A550", Offset = "0x7D49150", VA = "0x187D4A550", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GNHCAJHKPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BAOKDNCDHGB : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D020", Offset = "0x7D3BC20", VA = "0x187D3D020", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BAOKDNCDHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DNCNNAPPCAC : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D710", Offset = "0x7D3C310", VA = "0x187D3D710", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DNCNNAPPCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class LEHFJPLKJDP : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B8D0", Offset = "0x7D4A4D0", VA = "0x187D4B8D0", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LEHFJPLKJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class PMJDHDFJKBJ : EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public static readonly FEEFJJJAJOL PDPEOCFMKHG;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D090", Offset = "0x7D4BC90", VA = "0x187D4D090", Slot = "4")]
	public void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PMJDHDFJKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BLOBFEKCEDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public NMCPHPKNFMD JBMEHOAGBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public JBANPOMFHOI LNPKDGKOILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public Dictionary<int, int> LPPBCDNCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	public Dictionary<Guid, Guid> AAKGNFOOEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	public ELEFFOCNANC BPGHLLOOGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	public bool HDCBFMLDHJM;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface EFFNCFNAPBK
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEDCJNHDIBP(POELAEJGEJJ ICBKOECKANM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FCDMHKADHHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private static readonly EFFNCFNAPBK[] HOAHJOEKHKC;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7D44EE0", Offset = "0x7D43AE0", VA = "0x187D44EE0")]
	public static void GLLPOLGKPAH(FJFJDBNHDLA PEDMEJIDLNB, FEBMDIJDLGI EHCPCDGNAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7D44C50", Offset = "0x7D43850", VA = "0x187D44C50")]
	public static void DDNIAHKHLHD(FJFJDBNHDLA? PEDMEJIDLNB, FEBMDIJDLGI MHLIBOLPJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7D45160", Offset = "0x7D43D60", VA = "0x187D45160")]
	public static void LKLINFMEDPB(FJFJDBNHDLA? PEDMEJIDLNB, FEBMDIJDLGI EBFGALPEOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7D44880", Offset = "0x7D43480", VA = "0x187D44880")]
	public static void CNGMKPOAMJP(POELAEJGEJJ ICBKOECKANM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct POELAEJGEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	public NMCPHPKNFMD MKJDKOOPEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	public FJFJDBNHDLA DPGLACKNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public Dictionary<int, int> LPPBCDNCNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public Dictionary<Guid, Guid> AAKGNFOOEGE;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D4D1C0", Offset = "0x7D4BDC0", VA = "0x187D4D1C0")]
	public Guid JKABAEHGEFG(Guid LHECJJHBNHF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface ELEFFOCNANC
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LOPGNPCCEFP, [Out] Guid HLAACJFJEIA);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class FNCPAHEOJIK
{
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private static readonly HashSet<Guid> GEFCJHFEOJC;

	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private static readonly ProfilerMarker DOKCIJIHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private readonly HashSet<string> APIPJHMMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private readonly Dictionary<long, int> JGJIMGAPAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private readonly HashSet<Guid> DBGGBNPEJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private readonly HashSet<Guid> NPGAGENBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private readonly HashSet<Guid> KOFLMAOPIAN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public IReadOnlyCollection<string> DHCKJEHGJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<Guid> PABMJEAGIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<Guid> DAJEGICCHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyDictionary<long, int> NCGHCCGHGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7D48950", Offset = "0x7D47550", VA = "0x187D48950")]
	public static void OFMONCKLBEC(KBIDKABIPIG IFKHJLOCEDB, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7D47E40", Offset = "0x7D46A40", VA = "0x187D47E40")]
	public static FNCPAHEOJIK LGHGNPCLNCH(LCCGADBLEIF DEELHKGGHPE, JONEILGCLIJ? HHPKAENJEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7D47AB0", Offset = "0x7D466B0", VA = "0x187D47AB0")]
	public static FNCPAHEOJIK FIDOFHJOHAA(KBIDKABIPIG LKLOBAIKGNC, JONEILGCLIJ? HHPKAENJEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7D479F0", Offset = "0x7D465F0", VA = "0x187D479F0")]
	public static FNCPAHEOJIK EEMLLGCFMND(ANIGEDLOIAN DHDHPEPEHPH, OPBKPLGJGDO NKHJILJFELH, JONEILGCLIJ? HHPKAENJEEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D47DB0", Offset = "0x7D469B0", VA = "0x187D47DB0")]
	public static FNCPAHEOJIK JMJJKIFPHNN(IEnumerable<string> APIPJHMMDBF, IReadOnlyDictionary<long, int> NEGFBIEFNME, IReadOnlyCollection<Guid> KOFLMAOPIAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A160", Offset = "0x7D48D60", VA = "0x187D4A160")]
	private FNCPAHEOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7D4A2F0", Offset = "0x7D48EF0", VA = "0x187D4A2F0")]
	private FNCPAHEOJIK(IEnumerable<string> APIPJHMMDBF, IReadOnlyDictionary<long, int> NEGFBIEFNME, IReadOnlyCollection<Guid> KOFLMAOPIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D46C50", Offset = "0x7D45850", VA = "0x187D46C50")]
	private void DGOCKOKMCDF(LCCGADBLEIF DEELHKGGHPE, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D46880", Offset = "0x7D45480", VA = "0x187D46880")]
	private void DGOCKOKMCDF(KBIDKABIPIG LKLOBAIKGNC, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7D499F0", Offset = "0x7D485F0", VA = "0x187D499F0")]
	private void PEKABCGIDFF(ByteString? BGJDBEFJPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7D46EF0", Offset = "0x7D45AF0", VA = "0x187D46EF0")]
	private void DGOCKOKMCDF(ANIGEDLOIAN? HMGDINOCJAI, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7D47970", Offset = "0x7D46570", VA = "0x187D47970")]
	private void DGOCKOKMCDF(OPBKPLGJGDO? NKHJILJFELH, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D46B10", Offset = "0x7D45710", VA = "0x187D46B10")]
	private void DGOCKOKMCDF(CHIMAOJHKLG? KJFBCNFFHPL, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D46640", Offset = "0x7D45240", VA = "0x187D46640")]
	private static bool CNCLNNAFACH(CHIMAOJHKLG KJFBCNFFHPL, int LOCJFJMBAGP, [Out] Guid BDEGPEJOAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D49350", Offset = "0x7D47F50", VA = "0x187D49350")]
	private static void OFMONCKLBEC(OPBKPLGJGDO? HMGDINOCJAI, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D497B0", Offset = "0x7D483B0", VA = "0x187D497B0")]
	private static void OFMONCKLBEC(CHIMAOJHKLG? KJFBCNFFHPL, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D49420", Offset = "0x7D48020", VA = "0x187D49420")]
	private static void OFMONCKLBEC(ANIGEDLOIAN? HMGDINOCJAI, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D48300", Offset = "0x7D46F00", VA = "0x187D48300")]
	private static void OFMONCKLBEC(PNDBJGBCDFJ? PBOIPJOJPLG, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D47650", Offset = "0x7D46250", VA = "0x187D47650")]
	private void DGOCKOKMCDF(PNDBJGBCDFJ? PBOIPJOJPLG, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D47B30", Offset = "0x7D46730", VA = "0x187D47B30")]
	private void GBCFPLHIMHA(Guid? LHECJJHBNHF, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D47250", Offset = "0x7D45E50", VA = "0x187D47250")]
	private void DGOCKOKMCDF(FJFJDBNHDLA? DPGLACKNALH, JONEILGCLIJ? HHPKAENJEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D47EC0", Offset = "0x7D46AC0", VA = "0x187D47EC0")]
	private static void OFMONCKLBEC(FJFJDBNHDLA? DPGLACKNALH, JONEILGCLIJ HHPKAENJEEI, FEBMDIJDLGI HFPGEIGGLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D47D40", Offset = "0x7D46940", VA = "0x187D47D40")]
	private void JKPMJHJHDGB(string? AOKCDEEDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D46510", Offset = "0x7D45110", VA = "0x187D46510")]
	private void CGJGNFEMIOP(long CJCDDDPLOLA, Guid NOIFDPBHJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D464C0", Offset = "0x7D450C0", VA = "0x187D464C0")]
	private void CGJGNFEMIOP(FCJCOEPMNHE? ICMPOPKBODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7D465E0", Offset = "0x7D451E0", VA = "0x187D465E0")]
	private void CGJGNFEMIOP(LFOMGOGIPLD? ICMPOPKBODL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct FBNAGJKLBHK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class OBFJBPINJLB : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private readonly IEnumerator<DictionaryEntry> PBCAONFLPOM;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DictionaryEntry GHLAAEIFKFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C1E0", Offset = "0x7D4ADE0", VA = "0x187D4C1E0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object JOMDPKHKCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C2B0", Offset = "0x7D4AEB0", VA = "0x187D4C2B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object IOOEMCNJEAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C360", Offset = "0x7D4AF60", VA = "0x187D4C360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7D4C100", Offset = "0x7D4AD00", VA = "0x187D4C100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
		public OBFJBPINJLB(IEnumerator<DictionaryEntry> PBCAONFLPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D4C060", Offset = "0x7D4AC60", VA = "0x187D4C060", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D4C0B0", Offset = "0x7D4ACB0", VA = "0x187D4C0B0", Slot = "9")]
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
		private sealed class CHEPFBCCEAJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D3D4B0", Offset = "0x7D3C0B0", VA = "0x187D3D4B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public CHEPFBCCEAJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D3D360", Offset = "0x7D3BF60", VA = "0x187D3D360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7D3D460", Offset = "0x7D3C060", VA = "0x187D3D460", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D4D830", Offset = "0x7D4C430", VA = "0x187D4D830", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IDictionary.this[object MEPFFFGIFGB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D740", Offset = "0x7D4C340", VA = "0x187D4D740", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D910", Offset = "0x7D4C510", VA = "0x187D4D910", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D680", Offset = "0x7D4C280", VA = "0x187D4D680", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D6E0", Offset = "0x7D4C2E0", VA = "0x187D4D6E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D8B0", Offset = "0x7D4C4B0", VA = "0x187D4D8B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D340", Offset = "0x7D4BF40", VA = "0x187D4D340", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D3A0", Offset = "0x7D4BFA0", VA = "0x187D4D3A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7D4D400", Offset = "0x7D4C000", VA = "0x187D4D400", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
		public RoomObjectCounts(Dictionary<int, int> PCIMDGPNFBC, [Optional] Dictionary<int, int> OOHIBFOGAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D260", Offset = "0x7D4BE60", VA = "0x187D4D260")]
		[IteratorStateMachine(typeof(CHEPFBCCEAJ))]
		private IEnumerator<DictionaryEntry> JDEHPNBKEED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D960", Offset = "0x7D4C560", VA = "0x187D4D960", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D580", Offset = "0x7D4C180", VA = "0x187D4D580", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D460", Offset = "0x7D4C060", VA = "0x187D4D460", Slot = "9")]
		void IDictionary.Add(object MEPFFFGIFGB, object OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D4C0", Offset = "0x7D4C0C0", VA = "0x187D4D4C0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D520", Offset = "0x7D4C120", VA = "0x187D4D520", Slot = "8")]
		bool IDictionary.Contains(object MEPFFFGIFGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D620", Offset = "0x7D4C220", VA = "0x187D4D620", Slot = "14")]
		void IDictionary.Remove(object MEPFFFGIFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D2E0", Offset = "0x7D4BEE0", VA = "0x187D4D2E0", Slot = "15")]
		void ICollection.CopyTo(Array IKALPCJBCLK, int EMMACFPOKFB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class NMGGAIHGKEJ : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D4C010", Offset = "0x7D4AC10", VA = "0x187D4C010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public NMGGAIHGKEJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BE80", Offset = "0x7D4AA80", VA = "0x187D4BE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7D4BFC0", Offset = "0x7D4ABC0", VA = "0x187D4BFC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D4B250", Offset = "0x7D49E50", VA = "0x187D4B250", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IDictionary.this[object MEPFFFGIFGB]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B120", Offset = "0x7D49D20", VA = "0x187D4B120", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B300", Offset = "0x7D49F00", VA = "0x187D4B300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B060", Offset = "0x7D49C60", VA = "0x187D4B060", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B0C0", Offset = "0x7D49CC0", VA = "0x187D4B0C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B2A0", Offset = "0x7D49EA0", VA = "0x187D4B2A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ACE0", Offset = "0x7D498E0", VA = "0x187D4ACE0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D4AD40", Offset = "0x7D49940", VA = "0x187D4AD40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ADA0", Offset = "0x7D499A0", VA = "0x187D4ADA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x290F750", Offset = "0x290E350", VA = "0x18290F750")]
		public Invention(long ALPNKEJICNA, int DPOOEAFKIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AC10", Offset = "0x7D49810", VA = "0x187D4AC10")]
		[IteratorStateMachine(typeof(NMGGAIHGKEJ))]
		private IEnumerator<DictionaryEntry> JDEHPNBKEED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B350", Offset = "0x7D49F50", VA = "0x187D4B350", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AF20", Offset = "0x7D49B20", VA = "0x187D4AF20", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AE00", Offset = "0x7D49A00", VA = "0x187D4AE00", Slot = "9")]
		void IDictionary.Add(object MEPFFFGIFGB, object OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AE60", Offset = "0x7D49A60", VA = "0x187D4AE60", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AEC0", Offset = "0x7D49AC0", VA = "0x187D4AEC0", Slot = "8")]
		bool IDictionary.Contains(object MEPFFFGIFGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B000", Offset = "0x7D49C00", VA = "0x187D4B000", Slot = "14")]
		void IDictionary.Remove(object MEPFFFGIFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7D4AC80", Offset = "0x7D49880", VA = "0x187D4AC80", Slot = "15")]
		void ICollection.CopyTo(Array IKALPCJBCLK, int EMMACFPOKFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> DHCGLBIACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	public readonly IReadOnlyList<Invention> MFIKGHGGBHN;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	public FBNAGJKLBHK(IReadOnlyDictionary<Guid, RoomObjectCounts> NABGEAFDKLF, IReadOnlyList<Invention> JIGGDIKIGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D43EA0", Offset = "0x7D42AA0", VA = "0x187D43EA0")]
	public static FBNAGJKLBHK LGHGNPCLNCH(LCCGADBLEIF DEELHKGGHPE)
	{
		return default(FBNAGJKLBHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D43D80", Offset = "0x7D42980", VA = "0x187D43D80")]
	[CompilerGenerated]
	internal static int FHNPNNEBFLO([In] IReadOnlyDictionary<long, int> HLDCHLDKCLC, long? CJCDDDPLOLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D436C0", Offset = "0x7D422C0", VA = "0x187D436C0")]
	[CompilerGenerated]
	internal static void CDHKHBHJBEC(int ECDJPAHBIEG, [In] ANIGEDLOIAN EMNFIFLHCBD, [In] Dictionary<long, int> HLDCHLDKCLC, [In] Dictionary<Guid, RoomObjectCounts> NABGEAFDKLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LKMJNFGKNOD
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
public sealed class JONEILGCLIJ
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class GAMAIPHAINK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public readonly Guid KPPDJDHAMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public readonly IReadOnlyList<Guid> PABMJEAGIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public readonly LKMJNFGKNOD DHOHPDPPIAL;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7D4A4F0", Offset = "0x7D490F0", VA = "0x187D4A4F0")]
		public GAMAIPHAINK(Guid IJGNKDKNEFC, IReadOnlyList<Guid> KOFLMAOPIAN, LKMJNFGKNOD OCHMMOHMIHP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000589")]
	private readonly FEBMDIJDLGI GFGNJBGLJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private readonly Dictionary<Guid, GAMAIPHAINK> IMLFAHGKBCM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FEBMDIJDLGI NIMDCLIOBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B620", Offset = "0x7D4A220", VA = "0x187D4B620")]
	public void NKAMMCABBBC(Guid MDFGFOJLHAL, Guid BEABKMLHJKD, IReadOnlyList<Guid> JEDMJEHAGED, LKMJNFGKNOD OCHMMOHMIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B530", Offset = "0x7D4A130", VA = "0x187D4B530")]
	public bool DDIGECKKIBN(Guid AHEIOMLMLHH, [Out] GAMAIPHAINK LDPEGKHGNJJ, [Out] bool EMMKKDBPFHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B830", Offset = "0x7D4A430", VA = "0x187D4B830")]
	public JONEILGCLIJ()
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
