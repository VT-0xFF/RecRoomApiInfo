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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7484EA0", Offset = "0x74834A0", VA = "0x187484EA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KDHPMFNHFFG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> DIIAGGJBGOH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> GPDEANJDOLE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> MFADFKNCGMK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> MAPAPBEGHNH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JCKJMIEPNLA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string DELHIOFENCF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string LKAOLMDMKKM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7483640", Offset = "0x7481C40", VA = "0x187483640")]
	public static bool IAICNONDCIM(Guid GFKNGELHANN, int LEJLFFNOBFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74835B0", Offset = "0x7481BB0", VA = "0x1874835B0")]
	public static bool CFBBGBGELIF(Guid GFKNGELHANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7483740", Offset = "0x7481D40", VA = "0x187483740")]
	public static string IJKEFIAHCBO(Guid JINNLDEOCMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLGCHEPGBJF]
public enum NNAJHDBLNCB
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7484E10", Offset = "0x7483410", VA = "0x187484E10", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FENLILPMDGC
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid AFIBMKMAGOA;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid DOAMJDAHPGI;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid BCEHMGLMBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid LICOBBFIPGF;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LEHOKLBPJHB;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid GLPHJHKIMHJ;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid JGGFHICJGGI;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid DGGBBOJPNKL;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HAOCANJIALA;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid GPKMAONKAAM;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid CHODLLKHAOG;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid CFLNPMOKLCO;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DJHBJNNIFIC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid GILPPDNANLN;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid EAOPPCKCCAF;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid DCNGDHCAHCK;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid KHKNPAGCIKH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid FIEEPAEPDLP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid BOLNICKMCOM;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid MCMADNAMFBK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid OKKKOLAIMLE;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FAIIHLOILAH;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid EJABKIMNNGA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid FBPPLKCAIKO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid EONBDPOAIIB;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid IANFPIFDEDP;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid PFIBBEOMIEG;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid CHODMIDPNLN;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CKGCMDICPPA;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid EABNBAFJGFK;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid ONNOBDFNLKF;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid NAFDAJNCJCB;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid KLNCCAGDEDA;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MNFLHEAOJLA;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid LHJGLJMGONI;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid MJLNFCKKACJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NGBCFONJPOH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JPKPHHBJAEE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid AFPKGKHINNB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JBIPCLCBJHD;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BBNPMLDGAHL;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DJJPHAPAJGA;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid NDHINJAJFCP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid NGKGKFPLCJO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid LJPGEFEEJFC;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid MJLINLMAACH;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid KOCMHPMBNEH;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid FHIFDNHCLIE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid ECMPLJHHIFP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid GODCIODIOCP;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JPIFPPNBADM;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HAKICEJMBBM;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid DEOCIEINHHM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ACLMECCOJBD;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CBMAJOHAOLM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KGPMBCFJHEB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid JDGCDDPBHED;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EJNPDODOJLC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid EAJBEAJOLCE;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KFLPCEKBJCO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid KFFFFPNONCI;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FJOKHHEDPOB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ALCPDCKIKKD;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid HLIKCCNEJGG;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid JPDGAPMEBPI;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid MGFBECEINPO;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid BJBBAOLLGPP;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid LLFHLGPHGPO;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid PNGGANPLEJI;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid AFKBOGBAAAP;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid AAAGJPJKNGB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid LEEGCCJBCPP;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid GGDBFOOBIBF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid EBCFGDPGILI;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid NIONIDNJDAC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PFDNJKPFJIO;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid DPIIKAMGKNP;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid PALMHOGPNMM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid OGNENOPOOII;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NFIAEMLFHEB;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BOHMBMCHEEO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BCAKBFAOCGL;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid PEFLKFHCKKE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BCIGPJCCCFF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid NDOPKPNDPKJ;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NADLLODDMKM;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HADJEMMCIND;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid EFABFHFHNBL;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid HIOAOFOBKIN;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid CJNEJPHGKCL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid IIMLJNFCDHC;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ALMAHJGHPLI;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid NEDMJCJCOOL;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid HEIMEONPCDD;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid KGMGLCFFALM;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid GCHOLPDJAFF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid MCGFOBFKCPO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid LFOIIOBENHI;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid GHGIJBNPDCN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid GLFNGOIHAEG;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid MAKMJAHHHDF;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid CAJFEECDOLP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid LPDFEIOGDLC;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid ODNCBANOBHP;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EBDHBINLFCB;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid EJEPEDACKKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid IJDDAKMPJHP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NAFIDGNACBJ;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EDJMBHDAEFP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid KBGABIKOJBD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid KNIKGECLPNA;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JOCAJFPKKOE;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid ADGEMGDEFLL;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LCPOIJKEGIB;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JEPKINOLELB;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OEDDMIEGLJJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid DBEIJCJOFFM;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid GLJPBMBKHIH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OBDFLOHEMAA;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LNINCNOPOOC;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LLOBNGFMGMN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid MIIFEFADPGD;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid EKEEBIIFOJM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid LPEKDPJMNAG;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid PKCMOMBMNAN;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DHFNGINBHGJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid IJDLJFPIAAJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid FJIJGJIOJGE;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PDMKMHMCBFL;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid NAACECLHNLC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid ADEPGLIEJOI;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MENNJFCCCDD;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid BELHMAGBHID;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid ACJNFFGINOE;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid PJKIAIIFJOO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid INLLDALGDAI;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NBHAIDBCECC;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CPHECGLNGMC;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid FBBMNBKPNCG;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GFFJEJKPOFD;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NOMAMEGMODH;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid AALIAMGNCIC;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid MGDCNAIACDO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid EHOBNBICEHF;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid AHCMLDDJBHI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid DEGHBHANADH;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid OKIGMEPFFEM;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid BEMALDKIIPO;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LJBEMOOCMCC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid LNIPEBBDMPN;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid ILEMHOCBKKG;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ADIHBGMMPII;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NBEABIPLAAK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid IILPJGEAAFB;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid JGHIHKBCEJO;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid FDBKEMIEDEM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid ANBNMHNIIAL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BEBFKFHONGG;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid ANMFIOFIGAB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NIDLBHEKOJF;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid AIEBKOLHNFF;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid IBEOEHBPBPA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid PGIPMKGKKLO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid EPCCLHMCLEB;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HHJGKKCDMEG;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid NLBJCCKGLCK;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid OGFNLMKFDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid CDEHPLGONBL;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OFCPPKGHGGB;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PLKMGOMJAKN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KCBLFKOKJGH;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DPJALGCMDGF;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid AHNENGFNMIN;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid NCPILBHKLEP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid BIDIHPAFAPK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid DANIKGGGGEK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid LJGFPMOGJEH;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid LDADFCCICMO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IAMEPMLBPNB;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PNOHCBHGJON;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BGGENAPMGBE;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid KCBINBKLBDE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FEINIHCIPOG;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid BCFEDENEHOP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid AGCMKANBNAG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid NDLLMLFLDKA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid PBHNIDPLKNI;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid LHELPHOAIEM;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid FGJDKDCDAAM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid BPFDJPJDBAE;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid ECOAKCNBEAN;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JMGLDBNBBMP;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid DIGAHKFHGBL;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LNNOPGIBCMD;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GMINGFBFMMF;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid JLCFDGADOME;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid NMIJEEPHCFH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid OLFGHHOMCJE;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid FGMCDJKENPJ;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MEAPDJCEMEF;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid AKPBCLHFCPN;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid PNBFHBICMCE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid GBMJMDDEDAG;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid CNPIDACAGML;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid KFFBBAKIGOA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DDBHJKKCIBF;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JHJIEPIDIFG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid INLOPKPJBON;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid HJIOPLGMDPG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid IBCOMLGBCMN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CLFPCAJDKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid DIIFKPFBBOM;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid BJDHCFGJPII;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid DOBICJBMLOI;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid AGLHJMJJMGA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid EANCOAJGNPH;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid ILANNMMBNPP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid GMFJFOLCHPN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FMDHEMAHECP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid LLMIHKMJJFP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JEFBNANHAMP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid DECKMAIEMHD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid HNKJFBHFKHD;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NIPAALNPNOB;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid AJPEOHGMEPP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid BAKHOIJGGHB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid HDCNOINEMGC;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KHBICAAPKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid NLBHEDECOPA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid CKCPALNFMBD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid OGLNKJGEHBH;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NIEKEEEJMIP;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid LLEMPOCOPAL;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid CDGCOOBEOIP;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid LJIMLGCJBBE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid BCJGEMOFKOG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid NFAIBLMKECF;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid OBDGCJDBBBI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid EJKDIPMAIJE;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid AOBEMKHLDND;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid EPDOOLOEANK;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid BLDPELPCNBA;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid MPEIJJHPCHD;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FOJOJHBILIB;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid GDJMPOGAHCL;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid IKIMCDNPKDH;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KKIAEKNFCKH;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PFIBINKNBBN;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MHGLJHDDFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid NEJEPDMNDLO;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BEIBDMKAPOC;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid DPHBMIJDDFG;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid JEOILKMEHAO;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid EJJFEAAHDEN;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid MAHHCJBADIJ;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid LBIEFDIONII;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid ECMJFPCDCBP;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GDAHNMBLJBN;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CMGHHHNNABI;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KHEEDOFCELO;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid NNPPGACGBKM;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid PFJPKILPKJK;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid HAJGKMACKBB;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HABBKKIDOHG;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid IBOBDMCBBNP;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid POIFHCDJHJH;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid PFBACHJADPD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid JACPLANPCJI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LNHDADICKKP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PNPAADDMLJC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MPOLNOHIMDJ;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid EONKMCHAFLG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GCEALNGELAA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid AIIFIIDMCEP;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid ABJBMEHHCGI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DEGBNGADEKP;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid ODFJBEILCKD;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PAJAFCLMEEN;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid BCNBJGMIPHI;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid EKLDKEIEADP;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid CMIFDMLGIOG;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LHKCIFKLDHH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid OCPCKPAIEMN;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GIACOOMBKGI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CGDNLPFEECE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HMLPABGPMMN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MFENIKDIMEF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid FAHOKEAOJND;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HFMBKKGKDAF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid BJGKMCNADGK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid BIDCKBKLGLA;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid ICPCPHHIDDA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EHAHCEIBIHF;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AJBCHJFJHEJ;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid GNIJKBGEPEE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid JDGHPHBDLMI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JNDOEPKLBLP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid PMHODCICAGJ;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid PMJLGHCLBPD;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid LGCJEJGMDCP;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid NFLIFKIEDGD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid IANKBGJFIHB;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid POAEDLAMGOB;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid BGIHLEPBJAK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid DGHFAENOKPM;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid EFJMJGENONB;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid LKGGGLIGHCO;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid AEBEGIFLADI;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid IEBAMFLKDIH;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid CPCHFKMJJMC;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LFHFMELAAEJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid BBLLLGNFCBD;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid DKODNLGJDOK;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid PJMAIIKKGML;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GMPCDAPACPK;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HJINGIDLLAC;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid IOFNCBBKJJD;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid HCCALKBFHCD;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid OJMGMNAOCCG;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid KIHIFILLFMD;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HDFAHHEAJJH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid LPJPAEEKBJG;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid DECDADFKICC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MDDGHPFAOFK;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid ACHPGDICAEH;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid NKNEHFBEOJA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DEPCBIHODOA;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LNHHGEHMKAD;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid MGMBINKNFII;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid FLFMDNABPGN;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid IEDJOBBIAEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid GKOIBGIGFBJ;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid IMGELMFODFP;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid FFLAEFPAHHI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid EOOBNNEOJKF;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid CCKNBIPEEGG;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid FNLIDKFJCHM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid CABICECFJIM;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid IAOODAPANOH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid KMJBJDLBELE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PIIDNPHEGMH;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid FMDLHCJGEHG;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid NGPNCFAAHKK;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NFIJEFKFGBH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid AEDNNJJFCAK;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GBKGAKCJKKH;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid CINGJDKLHME;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid BLPAMAFEHNI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AAPJCEMKONK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NFMJAJJGCME;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IEADNMOLMBM;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid AENNKGHKAHA;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DHALILBKCOA;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LALIKFFIMCE;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NNPDNIGJOCP;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LKCNAELBEAE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MDEDMMAEKAK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid HELLBOJJKNA;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HIPPAALPLAE;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CAEPIFPAJLK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid DDDEGPNGAHL;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EGFDONGJOCG;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid ALNACJLDHFI;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NBBCNDHKHNG;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PFFGFIGFFCK;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NJDJPKLNGCJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PMHLOGNILLL;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ADLEMFCKOID;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid ILOALLIKACM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid BHIKFFKOKJF;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid CMKFDFPKMAD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CFMCJKGJMIN;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid PIDAOODCNAJ;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid JKLGECBAOII;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid CNAPHBGDEEE;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid DPLHOKPJOHF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ELMKJCHMOMO;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid INKHFBDELNH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid CCOGAPLAHPK;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid MCGNAGIPLOF;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid CPAMEHGKOIC;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid JBDBNKHHABO;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid MJMNDHFJCEG;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid ALDJKJHJMBD;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid NNBECJHBFBJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid DKBEFHGICKN;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid OEPFCPOBBGK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DELIHOPLFCK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid DPLFHLNININ;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid MHPBEKGLDBP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid DNLHHEKMPJH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KAEPGGHJENH;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid AEFIAJAHOBG;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid CLJNJOKMBGI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MIIAALKLMEP;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid GODCBPAIPHI;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid BLIHNLCICFH;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CBIFJILENFI;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FFMJOKPNEKE;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid ABGBPNPMFIG;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid AFFNAMMPMDL;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DIEIKNHPKBE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid NKBJKIOCKJB;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid IHBOEMLGBOD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid HHIHMKNMHHC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid NBONEHCHFCO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid LGCKALJIKKO;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid ABBONOHIBGO;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid JLGEOGJFCPO;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CJAGOBLMIMM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid MKEACKOPNGD;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid MLCDKJDAHCN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid MBFHGKGDMKM;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JCHCJHBMFPO;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FOKICPNPFBE;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid BPNMPKKNKPO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LGODCHPPICD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CHLKFIPNHIO;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid POCHNDJJGNF;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid ABLIEHCNBII;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid FGCIKPEFFIK;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid AMIMGBFHFHO;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid MCHCMBCIGHD;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid LIOKIMIBLGJ;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid IFJMDCBAGCI;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid BAFKPBCMMNB;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid NGPLNMBICLJ;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid NGCENHEOKNP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NOOHBOPFLBO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid OBIIKGKLDHN;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid INDNLCCMFDE;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid FAOFIGEGHPD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid GGDBCFHLPMH;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid HCBJIDJCBFC;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid HIHFHCMJJEL;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid OPMKKAPIKDF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid CCMFELKKLIE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid BENGAFMIFBG;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid OGAGABANGGN;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid BHFAFGNLLHE;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NEGHFJGMNCN;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid IDKBODEDLOM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid AEDJNGIEBBK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid EDPGOADIOLL;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid PDJNCNFMMGE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid IPKKKCHKOIK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GCJFDKNEJOJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid IMHCKHKCEHA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid ABBDKEAFKMH;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid KGLGOBPFDBM;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PCBJPAPLOIK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CMCCMENDDFH;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid GLLJDFDKGNH;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CHDMEOMDMCL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JDBANNIFGLO;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid DFCJFJONKPI;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid MKCICFKOKOB;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid JIEKOLKCNLI;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid FMMCFLGDNKA;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid FDGPCDDDAMH;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NFPEGHCJPNJ;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DDDFLDBOINN;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid OCFNHKHJPIM;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JJEFAAGPPME;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OELEKPKDFMG;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid GJFAIEHALNO;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid KGCCGPJFBNM;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MNCBCEEHHAD;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid EDNBFJJDMHJ;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EKLCLAHBIBA;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MDMAGPGADCE;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid IKJLJGHPCEG;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid MMCCEBEHDFD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid APFPPGEPHHI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid AHOOFFCACML;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid DDLPBGLBKPO;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid OPCNGBMEDKM;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GKEBNLMPBLF;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IOCALGDAFDM;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid KCLNDBEBOAG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid GLMMIJGNHPB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid KAFEKAPHJIO;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid DODLIEEODBL;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid AMJCNEOIFIN;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid PPKNKGAHNPE;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NLMHJJNPGFC;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LCAFIILILIC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BJJDFJNEGEM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid JPICDDHDAMI;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid NHPEGGNJLPN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid IIOBIMFPKDI;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid AAJDAGCMDBB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid KDHBPOINLMD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PHNAGMAJPOD;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JABGHCJKOAD;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NFJMMBDMPFN;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid EBGNJAANCDM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid COJIBKACOCE;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MHGHDPKPANK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid FLGKLHPIPHA;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid DNIJGOCJLDH;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid BOLJJKLCKLF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid NLKCPOEIMAO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid HADLBLALDLI;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid NGKPLKPFBLJ;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BMIEBLMMEIO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ILAALEHAPMG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid IPLOIBBDPCA;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid JFAIMHLNAHJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PADAEPFOGHL;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid LGIALAHOCAK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid MGDDINLDCHM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid KPOKAKCDPEC;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid DPBIHCFNKEK;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid EAEHOKODDDC;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MABONBIAKHN;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid MCBGKJLFHGG;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid KPEOCFIPIME;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid LPJMCGOOBDC;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid GKBADMPIJFF;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid IKFPNOKAIFC;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MDLILKLJGDF;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid NEPGONDNFHB;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid FAMCGDBCHHP;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid AAGGEOFMDKF;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid NOEOHNGOMIJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid CHGAHOEEOKF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NDKOBAGOODD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid GIPDDLELHJJ;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid JJAMLGLLHLO;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid DMLAFDGOKAG;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LLKILHCLBBC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid FHCIHIPDIOG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid MCHDKCLHKGM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid PPPIMPONHMI;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid MEJJIGIDCGL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid MDLPEIPGEBL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid FLCGDIDNFFM;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid HBJABCGJBLO;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid EPBDIFCPDAP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid FMLEFKHMEBE;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid IKIBHPNHHJD;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid FPIPHANJPGA;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid DCPBKCBPHCK;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LJFIFOLFKPG;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid CKIHGBNPPBI;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid EGFJACNDIKO;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid CAKKKGKIDAE;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid MJLCPPEGCOI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid GEGMBHJGBDH;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid NJLJCIDDLOM;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid OLDDBHNHOJP;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid PKHOOLIDFDG;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid LBODAIDCDJK;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid ILKACCOPILD;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid EEECGABONKP;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid APGPEOJONOB;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LJIPOIHAOJE;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid KIAPHIJPHLO;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid LOJHCDAAFIL;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid HIOEAINFFCD;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NBLILOMHFHG;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DMNOLPMEONA;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid IGCJCNEGHIB;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid HCBHIHJEEAF;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid CDPDGJJJKOB;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid DDOMKFPFCAP;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid JNPHNEJHLIN;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid LPNNODBFNFP;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid HKFAACNMIKE;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid FBJCCJGDGJL;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid MOEMIFEIGOL;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid BILIINMLJFP;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid NGIFLKMOFGB;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid FBAFPECINFL;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid NEEFOEPPKIP;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid ANIICCOPJKE;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid KBJIPKFOHGB;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid HLFCCCJEDOB;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid EOLMBBDOKAB;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid NIGAFHFAJPE;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid DMNGOABLFKM;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid LGGFDJHMOPB;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid HLMBAOOPOFF;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid JLEAIJNPBIC;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid CHBLNONJBHA;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid EGAOOGAPLFI;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid GBGNKIFEBFE;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid KCONCMLAJGM;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid DNLOKJLPOJF;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid PAKHDCGOKJL;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid NGCLJNOMFDE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid CLKABJJEJGK;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid EEGBOEIFHOP;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid ABILDNJGKNE;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid IFADOEMCBIB;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid HPFLKJDFKDD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid MOHGCJNHBBE;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid HAIOFMDFMIB;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid EHECCPDHEID;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid PBIJNKDPFBD;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid LDCOIAIJCGK;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid HOALEOGILCF;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid ILADOLEECEI;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid OEKCHGDEDBC;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid AMFMJJKOIND;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid CJKKDJPJPLE;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid CLMAEFDLKEO;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid KEPLHNGEHFL;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid PMIKAHGAJPJ;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid JNIENAKPHLG;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DKMOIPCKKML;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid OBHNODNCBMN;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid KOJPKHPDKLP;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid LIOCKGNOFFF;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid OALIICANGOM;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid MKGPDPPPCOI;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid JJMFEGPNGJC;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid AAMPONIJJAG;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid NFLJLHPNDKA;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LBEIOHODJGD;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid GCKEBAOHBEM;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid INHGMNLKINF;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid KBICKNNBMDK;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid NKPICDPFNMK;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid NIGKOPDDJOA;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, NNAJHDBLNCB> EACOHGKJGIL;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<NNAJHDBLNCB, Guid> MAFPCONNMLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, NNAJHDBLNCB> NKENAFIJKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7480AD0", Offset = "0x747F0D0", VA = "0x187480AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<NNAJHDBLNCB, Guid> FKLKEFNEDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7480B30", Offset = "0x747F130", VA = "0x187480B30")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BOJFKFDPHGK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x747F420", Offset = "0x747DA20", VA = "0x18747F420")]
	public static bool PAGGELJHEPL(GEEFLNEJECB CCCFPIOHJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x747F070", Offset = "0x747D670", VA = "0x18747F070")]
	private static bool PAGGELJHEPL(ODFHIEJDKOP NAKBEFGIDDJ, GEEFLNEJECB CCCFPIOHJHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BKJMEMNJGKO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(EDOGCENJNMI GIDGOODJFLJ, [Out] Dictionary<int, int> JHJMIFAGJNM);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(GPALOJEHCIG OADLADAPAPE, AFABNNPHMLA ABMBJFPEDIC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct EPBJGFJEJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly CBKCDAKDLFJ BPOBAIJOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<PGEJPEMIJFO> LAIECHLPADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<PGEJPEMIJFO> ECEBGCNFNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly AAFGLNNJOHN<IBLJEHJLOFH> DAHNLNMMDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> PAMININKGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly LHMJOHFKNMN PIJJDAIACLB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MHEEAOGJICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7480A60", Offset = "0x747F060", VA = "0x187480A60")]
	public EPBJGFJEJOG(CBKCDAKDLFJ ILAAHLCCMFF, IEnumerable<PGEJPEMIJFO> EHMJINIHOLK, IReadOnlyList<PGEJPEMIJFO> DFCNIJCIELP, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> AEFHPDNLPHB, LHMJOHFKNMN IBPBICKJEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PPIFKJCHPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly CBKCDAKDLFJ BPOBAIJOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly IReadOnlyList<PGEJPEMIJFO> DHEKJBCJOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly AAFGLNNJOHN<IBLJEHJLOFH> DAHNLNMMDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	public readonly IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> PAMININKGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	public readonly ByteString BOKPONNLDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	public readonly LHMJOHFKNMN PIJJDAIACLB;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7484F20", Offset = "0x7483520", VA = "0x187484F20")]
	public PPIFKJCHPKA(CBKCDAKDLFJ ILAAHLCCMFF, AAFGLNNJOHN<IBLJEHJLOFH> NKNBCGMJPLG, IReadOnlyList<HMBFEKDDECL<MOHGMBIPFPM>> AEFHPDNLPHB, ByteString OMKDFLCLBEL, IReadOnlyList<PGEJPEMIJFO> MMLEGOOCNMD, LHMJOHFKNMN IBPBICKJEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DONKPAPFINF : KEFHNHHELAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public readonly Guid FOICIACKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly Dictionary<Guid, Guid> JAGFBALGAPL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x446F410", Offset = "0x446DA10", VA = "0x18446F410")]
	private DONKPAPFINF(Guid JEMMODECALM, Dictionary<Guid, Guid> JAGFBALGAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x747F8E0", Offset = "0x747DEE0", VA = "0x18747F8E0")]
	public static DONKPAPFINF FEOBEKOIKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x747FD70", Offset = "0x747E370", VA = "0x18747FD70")]
	private static Dictionary<Guid, Guid> JCNFMEJCPGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x747FCE0", Offset = "0x747E2E0", VA = "0x18747FCE0")]
	public static DONKPAPFINF GKPKDBABGAI(IReadOnlyDictionary<Guid, Guid> MOEBIEOOLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x747F970", Offset = "0x747DF70", VA = "0x18747F970")]
	public static DONKPAPFINF FGADDIPPMBN(IEnumerable<KeyValuePair<Guid, Guid>> MOEBIEOOLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x747FC60", Offset = "0x747E260", VA = "0x18747FC60")]
	public Dictionary<Guid, Guid> GDKNDOCHCAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
	public Dictionary<Guid, Guid> CAAPGIHEDBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x747FCF0", Offset = "0x747E2F0", VA = "0x18747FCF0")]
	public void HBHDBABAKDP(Guid MOEBIEOOLFC, Guid JEFFDGNDMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x747FE20", Offset = "0x747E420", VA = "0x18747FE20")]
	public void KNIHKDJBCNG(IReadOnlyDictionary<Guid, Guid> KLOOEFFGDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x747F790", Offset = "0x747DD90", VA = "0x18747F790")]
	public Guid FCBGDEIPOMI([In] Guid MOEBIEOOLFC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74800A0", Offset = "0x747E6A0", VA = "0x1874800A0")]
	public Guid LGIFLKDNMCB([In] Guid MOEBIEOOLFC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x747F720", Offset = "0x747DD20", VA = "0x18747F720")]
	public bool BEHHBGGAONF([In] Guid MOEBIEOOLFC, [Out] Guid JEFFDGNDMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x747F720", Offset = "0x747DD20", VA = "0x18747F720", Slot = "4")]
	private bool JKBBHCKIJMK([In] Guid MOEBIEOOLFC, [Out] Guid JEFFDGNDMGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JAPHFPAPJMH
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
public sealed class BBIIHOLIHNO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ENCAFCJNJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public CBKCDAKDLFJ staticCircuits;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ENCAFCJNJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74809F0", Offset = "0x747EFF0", VA = "0x1874809F0")]
		internal AAFGLNNJOHN<GDEODHDOKBB> NNGILGCFKDN((AAFGLNNJOHN<IBLJEHJLOFH> GraphId, AAFGLNNJOHN<MOHGMBIPFPM> NodeId) i)
		{
			return default(AAFGLNNJOHN<GDEODHDOKBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private static readonly GIBMKDJCJAI<GDEODHDOKBB, int?> KEIBKCNFAFG;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	private static readonly long AOFDJLBKABA;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x746EA10", Offset = "0x746D010", VA = "0x18746EA10")]
	public static (long, long) OMHBBBBPNBH(CBKCDAKDLFJ MIOKKEMFKLB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x746E7C0", Offset = "0x746CDC0", VA = "0x18746E7C0")]
	public static long OBBFGDGPJPF([In] ReadOnlySpan<AAFGLNNJOHN<GDEODHDOKBB>> PAEICPDCAED)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x746E8F0", Offset = "0x746CEF0", VA = "0x18746E8F0")]
	private static long ODPMEAFGCIF()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HKPFELDLPOC
{
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	public static readonly HashSet<NNAJHDBLNCB> ILEAMHHDKLG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BBKPLGJJICI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DHEGAFGGJNC : IEnumerable<PGEJPEMIJFO>, IEnumerable, IEnumerator<PGEJPEMIJFO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private PGEJPEMIJFO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private JPCGGCJPLNG spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public JPCGGCJPLNG <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private OLDHBFDBLMP spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public OLDHBFDBLMP <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PGEJPEMIJFO System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public DHEGAFGGJNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x747F450", Offset = "0x747DA50", VA = "0x18747F450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x747F6D0", Offset = "0x747DCD0", VA = "0x18747F6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x747F560", Offset = "0x747DB60", VA = "0x18747F560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PGEJPEMIJFO> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x747F560", Offset = "0x747DB60", VA = "0x18747F560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x747D7D0", Offset = "0x747BDD0", VA = "0x18747D7D0")]
	public static JPCGGCJPLNG CCCFICPOBBA([In] PPIFKJCHPKA GDJBLLJCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x747D910", Offset = "0x747BF10", VA = "0x18747D910")]
	public static JPCGGCJPLNG CCCFICPOBBA([In] EPBJGFJEJOG GDJBLLJCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x747EA10", Offset = "0x747D010", VA = "0x18747EA10")]
	private static void PJKEHJNEEKD(JPCGGCJPLNG LKDEHGABKEG, [In] EPBJGFJEJOG HAHBFBIHAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x747C220", Offset = "0x747A820", VA = "0x18747C220")]
	public static JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK> BOHCEGDFKLA(JPCGGCJPLNG LKDEHGABKEG, OLDHBFDBLMP OFDIFFMDEIL, DONKPAPFINF? ICAIFLKHMJH, bool BEMCOKKNHBO)
	{
		return default(JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x747E620", Offset = "0x747CC20", VA = "0x18747E620")]
	[IteratorStateMachine(typeof(DHEGAFGGJNC))]
	private static IEnumerable<PGEJPEMIJFO> JOOPPEIMGPA(JPCGGCJPLNG LKDEHGABKEG, OLDHBFDBLMP OFDIFFMDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x747BE70", Offset = "0x747A470", VA = "0x18747BE70")]
	private static void BCHNMCNKGOO(JPCGGCJPLNG LKDEHGABKEG, OLDHBFDBLMP OFDIFFMDEIL, IReadOnlyCollection<ByteString>? AIDBIPICINF, IReadOnlyCollection<ByteString>? PKNNBMDJHBP, IReadOnlyCollection<ByteString>? NOCMOEDNJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x747DF00", Offset = "0x747C500", VA = "0x18747DF00")]
	private static bool EEHMLJOFMAM(JPCGGCJPLNG LKDEHGABKEG, GPALOJEHCIG OADLADAPAPE, OLDHBFDBLMP OFDIFFMDEIL, [Out][NotNullWhen(false)] string? IFMHONGNKHP, [Out] Dictionary<int, int> JHJMIFAGJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x747E730", Offset = "0x747CD30", VA = "0x18747E730")]
	private static Dictionary<Guid, ODFHIEJDKOP> NGGIEMCGDKO(JPCGGCJPLNG LKDEHGABKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x747E590", Offset = "0x747CB90", VA = "0x18747E590")]
	private static void ICEDONHCEMG(bool HBBFJHPDMOA, PGEJPEMIJFO JOHGLFIKFAB, DONKPAPFINF CDGFGMLIACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x747BEE0", Offset = "0x747A4E0", VA = "0x18747BEE0")]
	private static void BNNDHMNBCOM(PGEJPEMIJFO JOHGLFIKFAB, Guid IEJINLAAIEE, EECCCHFFOKH? AJGOLEIDBFF, Dictionary<Guid, ODFHIEJDKOP> OECHIBFMIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x747DA50", Offset = "0x747C050", VA = "0x18747DA50")]
	private static void DHEHMPCDHJF(IEnumerable<PGEJPEMIJFO> PMJMEDOOBGD, IReadOnlyCollection<ByteString> AIDBIPICINF, IReadOnlyCollection<ByteString> PKNNBMDJHBP, IReadOnlyCollection<ByteString> NOCMOEDNJII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OLDHBFDBLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public bool HBBFJHPDMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public LHMJOHFKNMN IBPBICKJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public EECCCHFFOKH? AJGOLEIDBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public EECCCHFFOKH? JOEFDLECGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public CBKCDAKDLFJ LMDCJLMIMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public JAPHFPAPJMH JJIGOCONNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public BKJMEMNJGKO NCBNEJOMEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public HMBFEKDDECL<IBLJEHJLOFH> CODLLOBEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public GOKGCFFOMBC GIJCHDOJCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public List<PGEJPEMIJFO> MKCGHMELGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public DPGADNNJFDK AIJADBHHPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public NANIGBALGKC IDHAEEOBBHH;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EECCCHFFOKH
{
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private const float MBJLBHEMGPD = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public Vector3 NDADPNJPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public Quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public float JJCKONKIIAI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Matrix4x4 PLGNDNPAAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7480710", Offset = "0x747ED10", VA = "0x187480710")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public UniformTRS KBKKLLHFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7480450", Offset = "0x747EA50", VA = "0x187480450")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x11B8B30", Offset = "0x11B7130", VA = "0x1811B8B30")]
	public EECCCHFFOKH(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float JJCKONKIIAI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7480920", Offset = "0x747EF20", VA = "0x187480920")]
	public EECCCHFFOKH(UniformTRS BMLDHHAAADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7480490", Offset = "0x747EA90", VA = "0x187480490")]
	public static EECCCHFFOKH NOMKMHMAFCC(EECCCHFFOKH LDIAONMHHPK, EECCCHFFOKH LGFOKGJLAKP)
	{
		return default(EECCCHFFOKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7480350", Offset = "0x747E950", VA = "0x187480350")]
	public static EECCCHFFOKH HEGJABMHLEC((Vector3, Quaternion, float) GIDGOODJFLJ)
	{
		return default(EECCCHFFOKH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x74801D0", Offset = "0x747E7D0", VA = "0x1874801D0")]
	public static EECCCHFFOKH HEGJABMHLEC(Matrix4x4 ENDPMLEHCPG)
	{
		return default(EECCCHFFOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7480890", Offset = "0x747EE90", VA = "0x187480890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7480370", Offset = "0x747E970", VA = "0x187480370")]
	public EECCCHFFOKH KDBONIINNPO(Matrix4x4 EJNLPEDOMDD)
	{
		return default(EECCCHFFOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7480820", Offset = "0x747EE20", VA = "0x187480820")]
	public static EECCCHFFOKH PHHOCGLAHNH(Vector3 NDADPNJPMFO)
	{
		return default(EECCCHFFOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7480140", Offset = "0x747E740", VA = "0x187480140")]
	public readonly ODGDOIFMABH EDGBBAJHLII()
	{
		return default(ODGDOIFMABH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NCBPMFMOAFO
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	Chip = 0,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	Object = 99
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct APDCNNEILDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public readonly FACJHAIJCBP BELNLGLGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private readonly EAPODONBJNH OHADHGKBDNK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1445330", Offset = "0x1443930", VA = "0x181445330")]
	private APDCNNEILDK(FACJHAIJCBP OPCPCOOFBPO, EAPODONBJNH MBMAIKIPCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x746E750", Offset = "0x746CD50", VA = "0x18746E750")]
	public KFNJBCGDAAC GKEMHLBEJFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x746E5F0", Offset = "0x746CBF0", VA = "0x18746E5F0")]
	public static JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK> FEOBEKOIKMG(JCAFAJJIGLP<IDMEFNAINAN> MBMAIKIPCEP)
	{
		return default(JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x746E6A0", Offset = "0x746CCA0", VA = "0x18746E6A0")]
	public static JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK> FEOBEKOIKMG(KFNJBCGDAAC MBMAIKIPCEP)
	{
		return default(JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x746E530", Offset = "0x746CB30", VA = "0x18746E530")]
	public static JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK> FEOBEKOIKMG(string EGLHNNKLMPO)
	{
		return default(JOFBNNGKBOO<DONKPAPFINF, APDCNNEILDK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum FACJHAIJCBP
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FJJCFEJLJCK : IDisposable, DGCJMFNLGOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private NativeList<MJHFHLJEIGI> BGOPNEFNKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private float OMEDHCLBPOL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EDJKJELJDNI GEJIFEELINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		[CompilerGenerated]
		get
		{
			return default(EDJKJELJDNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ELOFBOFNBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7481B90", Offset = "0x7480190", VA = "0x187481B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LFKCOAIMLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x74817A0", Offset = "0x747FDA0", VA = "0x1874817A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public List<JIFBEECLMOG> JJDBEKNHGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KMLMJEEIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7481760", Offset = "0x747FD60", VA = "0x187481760", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public float BKDLGHCLDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74817B0", Offset = "0x747FDB0", VA = "0x1874817B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7483310", Offset = "0x7481910", VA = "0x187483310")]
	public FJJCFEJLJCK(EDJKJELJDNI PNCPEFMKILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7481600", Offset = "0x747FC00", VA = "0x187481600", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7482630", Offset = "0x7480C30", VA = "0x187482630")]
	public Vector3 OLHJLNGKDCP(int MKNOLMMOIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7482490", Offset = "0x7480A90", VA = "0x187482490", Slot = "6")]
	public Quaternion KPPCNMJKMKI(int MKNOLMMOIDN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74816C0", Offset = "0x747FCC0", VA = "0x1874816C0", Slot = "5")]
	public Vector3 EGGEPAMJNMK(int MKNOLMMOIDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7482560", Offset = "0x7480B60", VA = "0x187482560", Slot = "7")]
	public float LPMDBMBIBDP(int MKNOLMMOIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7481BA0", Offset = "0x74801A0", VA = "0x187481BA0")]
	public void JEPJCFNHICM(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG, bool PFIOKBPIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7481660", Offset = "0x747FC60", VA = "0x187481660")]
	private bool EEDNFKKLCGB(int CBGBGBENCLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7480B90", Offset = "0x747F190", VA = "0x187480B90")]
	public void AGBHPMMALLN(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7481570", Offset = "0x747FB70", VA = "0x187481570")]
	public void DHINNJNMEEL(int CBGBGBENCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7481A40", Offset = "0x7480040", VA = "0x187481A40")]
	public void HHHGLBIIDHE(int CBGBGBENCLJ, Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74813C0", Offset = "0x747F9C0", VA = "0x1874813C0")]
	public void DGNJDGMJDCI(int CBGBGBENCLJ, float3 NDADPNJPMFO, quaternion MLMNPOCKAAE, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74818F0", Offset = "0x747FEF0", VA = "0x1874818F0")]
	public void GGEAIJDFBEI(int CBGBGBENCLJ, Vector3 NDADPNJPMFO, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7481260", Offset = "0x747F860", VA = "0x187481260")]
	public void CLBDAFMCDDI(int CBGBGBENCLJ, Vector3 FGKLFPNFOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7482B00", Offset = "0x7481100", VA = "0x187482B00")]
	public static Quaternion POEGKLFGHHM(Quaternion PPMLNGGNBKE, int CBGBGBENCLJ, float CALGKFELBND, DGCJMFNLGOG EELACOIEKHA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7480CF0", Offset = "0x747F2F0", VA = "0x187480CF0")]
	public Bounds BBKFAKILJHD(Transform EJNLPEDOMDD)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x74825C0", Offset = "0x7480BC0", VA = "0x1874825C0", Slot = "10")]
	public virtual void MODGEBILPEA(bool LLIPCEAABGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7481190", Offset = "0x747F790", VA = "0x187481190")]
	public NativeList<MJHFHLJEIGI> BNJKFCOOCKK(float LNCKOKFDLOI = 1f)
	{
		return default(NativeList<MJHFHLJEIGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct JIFBEECLMOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public float3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public float GKIFEDCHHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public quaternion FKNHDDJJKFK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x748B150", Offset = "0x7489750", VA = "0x18748B150")]
	public JIFBEECLMOG(Vector3 MIGPGADKMKK, Quaternion PPMLNGGNBKE, float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x748B090", Offset = "0x7489690", VA = "0x18748B090")]
	public Quaternion OPBKLKHJPAL(Vector3 BNCGOADGBEC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x748AC00", Offset = "0x7489200", VA = "0x18748AC00")]
	public JIFBEECLMOG EMDIBGHJPJE(Vector3 EGMAFANNMDH, Vector3 FLGEHDOGMHA, Vector3 EAAGIJIANMM)
	{
		return default(JIFBEECLMOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x748AEF0", Offset = "0x74894F0", VA = "0x18748AEF0")]
	public EKMMPMKCJDC JMHHEDJHGMP(Vector3 BNCGOADGBEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DIMPLCABOEH : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7487580", Offset = "0x7485B80", VA = "0x187487580", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7486CD0", Offset = "0x74852D0", VA = "0x187486CD0")]
	private void KFFHFBIPIAN(Dictionary<Guid, Guid> CFPKNEIKIKE, JLBIEEGABNH MCACLCBLOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74872A0", Offset = "0x74858A0", VA = "0x1874872A0")]
	private void KFFHFBIPIAN(Dictionary<Guid, Guid> CFPKNEIKIKE, LMKDEHOCNGG JGDHDECDAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7485900", VA = "0x187487300")]
	private void KFFHFBIPIAN(Dictionary<Guid, Guid> CFPKNEIKIKE, CFKGFFEBMPB FHAEHIHLDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public DIMPLCABOEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FKEJOMOMFHK : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74877F0", Offset = "0x7485DF0", VA = "0x1874877F0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public FKEJOMOMFHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class FMNAPIPOFFN : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74878A0", Offset = "0x7485EA0", VA = "0x1874878A0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public FMNAPIPOFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class LIIKGMDLBAC : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x748B550", Offset = "0x7489B50", VA = "0x18748B550", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public LIIKGMDLBAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class ODNBFLGLKAK : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x748B6B0", Offset = "0x7489CB0", VA = "0x18748B6B0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public ODNBFLGLKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class FIIILEODOMK : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74876B0", Offset = "0x7485CB0", VA = "0x1874876B0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public FIIILEODOMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KKJDJBNALKM : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x748B3B0", Offset = "0x74899B0", VA = "0x18748B3B0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public KKJDJBNALKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HCEPEBOKPGE : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7488EF0", Offset = "0x74874F0", VA = "0x187488EF0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public HCEPEBOKPGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CILOABDNMJP : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7486B10", Offset = "0x7485110", VA = "0x187486B10", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public CILOABDNMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OGHGPADHKAD : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x748B8D0", Offset = "0x7489ED0", VA = "0x18748B8D0", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public OGHGPADHKAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JEJAIMKOJNM : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x748AB00", Offset = "0x7489100", VA = "0x18748AB00", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public JEJAIMKOJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PELPOOBMBCL : AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public static readonly NDHJEABDDIM EKIKEEJFNOB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x748BA90", Offset = "0x748A090", VA = "0x18748BA90", Slot = "4")]
	public void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public PELPOOBMBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GEEFLNEJECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public GPALOJEHCIG EPKMALKPPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public IHGCCLJDJEE IMLHMGJEAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public Dictionary<int, int> FIAFJNNBENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public Dictionary<Guid, Guid> NHGLAMLKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public NANIGBALGKC IDHAEEOBBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public bool BEMCOKKNHBO;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AAHFIAKDNIC
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGAOLFHCIKG(EHJKIIMOGCK OLEAIIMPJKK);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GGJNFNHJJFP
{
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private static readonly AAHFIAKDNIC[] PKDDPCOOJNA;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7487DB0", Offset = "0x74863B0", VA = "0x187487DB0")]
	public static void CGGNINPJGME(PGEJPEMIJFO GIDGOODJFLJ, DONKPAPFINF BAECODDAGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x74882A0", Offset = "0x74868A0", VA = "0x1874882A0")]
	public static void INDHHODHKNA(PGEJPEMIJFO? GIDGOODJFLJ, DONKPAPFINF CPCNOHLGENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7488030", Offset = "0x7486630", VA = "0x187488030")]
	public static void HIJBKGCFLFL(PGEJPEMIJFO? GIDGOODJFLJ, DONKPAPFINF CDGFGMLIACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7488530", Offset = "0x7486B30", VA = "0x187488530")]
	public static void PAGGELJHEPL(EHJKIIMOGCK OLEAIIMPJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EHJKIIMOGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public GPALOJEHCIG DEIHKPLMGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public PGEJPEMIJFO JOHGLFIKFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	public Dictionary<int, int> FIAFJNNBENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public Dictionary<Guid, Guid> NHGLAMLKEGK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7487600", Offset = "0x7485C00", VA = "0x187487600")]
	public Guid CCGOKCMOMFG(Guid JINNLDEOCMO)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NANIGBALGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int HMLBEPAJOAO, [Out] Guid GFFEBMAHLLG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CCKFEHFPIPE
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private static readonly ProfilerMarker PDIOODCNHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private readonly HashSet<string> MBANHHFADJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly Dictionary<long, int> LJCPDBIBBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly HashSet<Guid> PKKKLLKEBGL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IReadOnlyCollection<string> GNFABBJLGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyDictionary<long, int> HECLMEPIEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74851E0", Offset = "0x74837E0", VA = "0x1874851E0")]
	public static CCKFEHFPIPE DALBGHDBMPE(BDHMMMHCHAA MIMFFPFKBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7485880", Offset = "0x7483E80", VA = "0x187485880")]
	public static CCKFEHFPIPE HCMHKEDDPMF(JPCGGCJPLNG FJHAIHHNMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7485960", Offset = "0x7483F60", VA = "0x187485960")]
	public static CCKFEHFPIPE JANBICADHOG(IEnumerable<string> MBANHHFADJF, IDictionary<long, int> AJLBPKJAMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74869F0", Offset = "0x7484FF0", VA = "0x1874869F0")]
	private CCKFEHFPIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74868B0", Offset = "0x7484EB0", VA = "0x1874868B0")]
	private CCKFEHFPIPE(IEnumerable<string> MBANHHFADJF, IDictionary<long, int> AJLBPKJAMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74865F0", Offset = "0x7484BF0", VA = "0x1874865F0")]
	private void LNGNCLOPHKL(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7485F50", Offset = "0x7484550", VA = "0x187485F50")]
	private void LNGNCLOPHKL(JPCGGCJPLNG FJHAIHHNMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74853D0", Offset = "0x74839D0", VA = "0x1874853D0")]
	private void GJFHJCCPLIA(ByteString? OMKDFLCLBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7485AE0", Offset = "0x74840E0", VA = "0x187485AE0")]
	private void LNGNCLOPHKL(PFGLFMIDBPK? JGHOOBNHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74864B0", Offset = "0x7484AB0", VA = "0x1874864B0")]
	private void LNGNCLOPHKL(BMEMLKEGJDK? HPEELAFENFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7486150", Offset = "0x7484750", VA = "0x187486150")]
	private void LNGNCLOPHKL(PGEJPEMIJFO? JOHGLFIKFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x74858F0", Offset = "0x7483EF0", VA = "0x1874858F0")]
	private void ILBCNKOPFIH(string? IIGPCPLEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7485300", Offset = "0x7483900", VA = "0x187485300")]
	private void EDMPEIPLJGB(long NLOEKCPDMHG, Guid IBBBMNKKNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74852B0", Offset = "0x74838B0", VA = "0x1874852B0")]
	private void EDMPEIPLJGB(KNDFDBHNIBN? OHEFHJJHHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7485250", Offset = "0x7483850", VA = "0x187485250")]
	private void EDMPEIPLJGB(JIHLANEPKAC? OHEFHJJHHNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct JDAOMBIMOML
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FPEFPFJJHIJ : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private readonly IEnumerator<DictionaryEntry> KGHMANIHPMP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DictionaryEntry JCPGOBIGPKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7487B80", Offset = "0x7486180", VA = "0x187487B80", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public object PJGLJNJMAMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7487C50", Offset = "0x7486250", VA = "0x187487C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object DEDOPNLMLPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7487D00", Offset = "0x7486300", VA = "0x187487D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7487AA0", Offset = "0x74860A0", VA = "0x187487AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
		public FPEFPFJJHIJ(IEnumerator<DictionaryEntry> KGHMANIHPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7487A00", Offset = "0x7486000", VA = "0x187487A00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7487A50", Offset = "0x7486050", VA = "0x187487A50", Slot = "9")]
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
		private sealed class BJELAOKNENM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C7")]
				[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x7485190", Offset = "0x7483790", VA = "0x187485190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public BJELAOKNENM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7485040", Offset = "0x7483640", VA = "0x187485040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7485140", Offset = "0x7483740", VA = "0x187485140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x748C190", Offset = "0x748A790", VA = "0x18748C190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IDictionary.this[object LKMGECEEGEE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x748C0A0", Offset = "0x748A6A0", VA = "0x18748C0A0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x748C280", Offset = "0x748A880", VA = "0x18748C280", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x748BFE0", Offset = "0x748A5E0", VA = "0x18748BFE0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x748C040", Offset = "0x748A640", VA = "0x18748C040", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x748C220", Offset = "0x748A820", VA = "0x18748C220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x748BCA0", Offset = "0x748A2A0", VA = "0x18748BCA0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x748BD00", Offset = "0x748A300", VA = "0x18748BD00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x748BD60", Offset = "0x748A360", VA = "0x18748BD60", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
		public RoomObjectCounts(Dictionary<int, int> AACLDLLEEPJ, [Optional] Dictionary<int, int> CHABFBIIKIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x748BBC0", Offset = "0x748A1C0", VA = "0x18748BBC0")]
		[IteratorStateMachine(typeof(BJELAOKNENM))]
		private IEnumerator<DictionaryEntry> GEKMLJJPOPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x748C2D0", Offset = "0x748A8D0", VA = "0x18748C2D0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x748BEE0", Offset = "0x748A4E0", VA = "0x18748BEE0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x748BDC0", Offset = "0x748A3C0", VA = "0x18748BDC0", Slot = "9")]
		void IDictionary.Add(object LKMGECEEGEE, object KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x748BE20", Offset = "0x748A420", VA = "0x18748BE20", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x748BE80", Offset = "0x748A480", VA = "0x18748BE80", Slot = "8")]
		bool IDictionary.Contains(object LKMGECEEGEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x748BF80", Offset = "0x748A580", VA = "0x18748BF80", Slot = "14")]
		void IDictionary.Remove(object LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x748BC40", Offset = "0x748A240", VA = "0x18748BC40", Slot = "15")]
		void ICollection.CopyTo(Array CJFOOLJEHLK, int EAHKFAJBNDN)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class JNBNIIBHFFD : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x748B360", Offset = "0x7489960", VA = "0x18748B360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public JNBNIIBHFFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x748B1D0", Offset = "0x74897D0", VA = "0x18748B1D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x748B310", Offset = "0x7489910", VA = "0x18748B310", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7489620", Offset = "0x7487C20", VA = "0x187489620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IDictionary.this[object LKMGECEEGEE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x74894F0", Offset = "0x7487AF0", VA = "0x1874894F0", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x74896D0", Offset = "0x7487CD0", VA = "0x1874896D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7489430", Offset = "0x7487A30", VA = "0x187489430", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7489490", Offset = "0x7487A90", VA = "0x187489490", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7489670", Offset = "0x7487C70", VA = "0x187489670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x74890B0", Offset = "0x74876B0", VA = "0x1874890B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7489110", Offset = "0x7487710", VA = "0x187489110", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7489170", Offset = "0x7487770", VA = "0x187489170", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x25777D0", Offset = "0x2575DD0", VA = "0x1825777D0")]
		public Invention(long KGHCKLKGJKM, int BBEJNKBNMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7488FE0", Offset = "0x74875E0", VA = "0x187488FE0")]
		[IteratorStateMachine(typeof(JNBNIIBHFFD))]
		private IEnumerator<DictionaryEntry> GEKMLJJPOPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7489720", Offset = "0x7487D20", VA = "0x187489720", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74892F0", Offset = "0x74878F0", VA = "0x1874892F0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74891D0", Offset = "0x74877D0", VA = "0x1874891D0", Slot = "9")]
		void IDictionary.Add(object LKMGECEEGEE, object KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7489230", Offset = "0x7487830", VA = "0x187489230", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7489290", Offset = "0x7487890", VA = "0x187489290", Slot = "8")]
		bool IDictionary.Contains(object LKMGECEEGEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x74893D0", Offset = "0x74879D0", VA = "0x1874893D0", Slot = "14")]
		void IDictionary.Remove(object LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7489050", Offset = "0x7487650", VA = "0x187489050", Slot = "15")]
		void ICollection.CopyTo(Array CJFOOLJEHLK, int EAHKFAJBNDN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> BGPNPDNMBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	public readonly IReadOnlyList<Invention> LJFHPGBAGEJ;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
	public JDAOMBIMOML(IReadOnlyDictionary<Guid, RoomObjectCounts> PODDKBOPOBD, IReadOnlyList<Invention> DIKLGMDDAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7489910", Offset = "0x7487F10", VA = "0x187489910")]
	public static JDAOMBIMOML DALBGHDBMPE(BDHMMMHCHAA MIMFFPFKBEA)
	{
		return default(JDAOMBIMOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x748A320", Offset = "0x7488920", VA = "0x18748A320")]
	[CompilerGenerated]
	internal static int LAKAIODJHCE([In] IReadOnlyDictionary<long, int> LDKEOKCLNEL, long? NLOEKCPDMHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x748A440", Offset = "0x7488A40", VA = "0x18748A440")]
	[CompilerGenerated]
	internal static void PDGLMLNOEEA(int GMINNGIPAGF, [In] PFGLFMIDBPK JMGPEDKGBMB, [In] Dictionary<long, int> LDKEOKCLNEL, [In] Dictionary<Guid, RoomObjectCounts> PODDKBOPOBD)
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
