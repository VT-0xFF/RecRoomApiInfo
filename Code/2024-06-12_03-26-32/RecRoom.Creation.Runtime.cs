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
using Unity.Collections;
using Unity.Mathematics;
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6867520", Offset = "0x6866120", VA = "0x186867520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FHAKGDMDJFF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> LAFHDPMCEDO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OOLJFEJBHGD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> PKOKKEMOAOK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string MKOMDJKDLFI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string JECNCFEKFOI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string JEIAEACMNEP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x684E370", Offset = "0x684CF70", VA = "0x18684E370")]
	public static bool EFOJLFFGCEL(Guid NPGANANAJCP, int FHCMMGGHCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x684E2E0", Offset = "0x684CEE0", VA = "0x18684E2E0")]
	public static bool DLMAAMKBNKM(Guid NPGANANAJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x684E470", Offset = "0x684D070", VA = "0x18684E470")]
	public static string EKKEABCECCC(Guid CICFLOBNFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JBPFIGNFLBL]
public enum KBJDPOHDFCM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY_OM,
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
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LPEFOMLKNOM
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid DAJEIIPOOGP;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid CAHMENNEJJK;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid HJHPFOKEDEM;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid OBJOHKFIOKH;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid IKOGDENDBAK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid HKPJHOPALPO;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid GAADCLLKBAO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid CDHKMJBIFBN;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid DOICCMJDFIA;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid NLLGMCKNHHM;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid IIGFAFDPGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid JCOCKOEGOBD;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid CILEFDLDGJK;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JDCGPDNPNPA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid PIBBPFAIMHC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid NBJHKNKEPIC;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid DIOEPBEGABD;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid OBHCHKJLJPK;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid FJFKAJDHCHH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid OBOJJIIPCPC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid MNMOOIJAKKC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid LIHKJDGEKAG;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid CCHBNHMJJKF;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid JFLOHEJJAOH;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid LGMFDHCDMGM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid JGOEBCPFKOM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid GPIKOFDENLD;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid DLOOCKPOCIL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid MLPAJDMCONJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid AOBFMJBGPLO;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CDFILGAJFPM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid BJAGDJHFCLJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid JJILNGAMGGN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid LLFIGDCDFMJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid DEILIHHEJGO;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid KKNBAMIPHBP;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid NAHMPHDOAKJ;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid MEIFHLJPHKI;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid PFPDDINEHMG;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid CHGPKKAKJMC;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid KCGNOOBALFG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid BKHPOACNNGE;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid EAAGLOPMJEE;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid GNJFMPLADIC;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CIPJJALFNLN;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid HDOADCDBCHI;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid EFBKLPKHGBN;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid BCBJOLEBCAG;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid BAGFNAGPCJA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KINDAMEIJCH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CCFIKMFILPB;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid DCGJJMHLADJ;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid GDLFMEPPBGP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid BGMNKANGOIL;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid FMLGMMMBAMM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid HPIEJKAIHOJ;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OOCPJKIFEEM;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LCKIJBKOCND;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid KILCEJFBPPA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid KPINMOOGAMH;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid GBAPGOBJNFA;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CBKLNIFKBLG;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid CFFENCPNPMG;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FJJOCABLGCB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CPAICICEAHG;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MJMNEJECMFF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid FMCALFMDJBL;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid FFBOINFFIDM;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid LPPJKNFMGDJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid HGMHPBFJFCN;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid LJCIADEPLPH;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ILHDFHCHAMF;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MKMKMEEEDAJ;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid HHHCNONDBLJ;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid KPLCFNNPGFG;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid FFNBJCNOKAN;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid FMLDKKGFFCC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid DGGNGPENIOK;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CPBAJLPGAPN;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid JOHPDECCOOI;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid EFAKCDFBIGM;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid KLAFBIEHGEN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BMHMIMGDOKO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid HCLFPFHOAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid CAKINJFBHPO;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JFBOLNLICLF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FNJFOKKFHEE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid PKADDDOLIME;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid LJPNGEPEAHI;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid EFAIDGDLAGP;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid JEMGEBGFNPI;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MNOAFBDDHMG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid CKBLJGMKBAF;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid LKNDODIKEKE;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid MGIGAKFPJPM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid AIIFKIDFNJH;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid PEJFHGHDCKD;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid OHOFKHFEELF;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid GFCDFBNPKGN;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid APOLGFNIFEH;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid NLBLLALJEJI;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid FEEMJECLCFE;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid IONEHGPMGMJ;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid NDMNKKNPAKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid FAMLHPPFCDP;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PHCOIDPOOFD;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DEGBODKCAEO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JFMOKBBPNPL;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OIGJMIDFLFM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PAAELOKNHDM;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KOCGFAFFMNP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid LFIDMFBGMKD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OJLMJLDCOJN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid KLPDADILGOL;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid CKNPFHCBBPH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BPHGCEEFHGI;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid GAJKDKCFEGL;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FCBCOEGMBEJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid PDGHENDLCJM;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NJDCCNCHDAH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid BEICACAOEHN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid NJFKKFFGOLI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid IAOJGIJCDKF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HLLHMKILDEL;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid JHNDLNLNFOP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid OGCNMAIFBKN;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid AMABLANEAKN;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid LDPODCLLGKA;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid BOAFFFGMFLP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IOEEICAOAIP;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid LOMLOBLPPMA;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KFNACMIACCJ;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid LHNGCFEPFGK;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid ENOOJDAKCLN;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid JGIKFDNNNJP;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PJGABLIOAAN;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid AJGCECFJJAM;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid HDJNLNFJJCB;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid PHLJJEIEHMM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid KCIBDPNDLPA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid MCIINPDCKHN;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid BAHGDOJHJHH;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid KOHKBANLGMK;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid DGPCPPICBOP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid BCDJJGELCLD;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid LKFFNPLAFNM;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BLPNBIGHPHG;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid BIEDFHNJNGI;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ODMEDDMBAPE;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid JHAMNBHPMFB;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid KMJNAAPBCBF;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EFAEGDGLFIB;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid IEEPNALABBC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KEFAOOICLMN;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid KNGGDMEGHFJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BNHEEGKICED;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid OKPOGFFJMCN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MEHDDPELJPA;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid CEDBJACLCKE;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid AGHDDHKCHLE;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KLEIJPGECJA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PFCENBHCIPP;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HAHDBIIDLHO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DLMEAMGKEKE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid OICNFFCJHGD;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HHAEKELDCLG;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HJAPIEGOBPP;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid MLBJPGBLFID;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid KAHDGMLICLO;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid KFPHMBBIKMB;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NEBFDOCCJAH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid FMGDIJIMKNB;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid GLCLDMFOIJA;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid DJMLNMBGHEN;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LMHIJOGPHIB;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid DNDJNADNGCL;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid CNMDLAHMHLK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid AOMMGBHHDFD;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid HOIAINCCFOO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OILDIEAFGKF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid DFPILCMOLHJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid NBMCCICDNPB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid LCMLFCCJFGC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid OIIDILJJJJI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid OFJAGJFPBDM;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid PDJNEIGMNLP;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid PJJIBNMFHJF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CPFNLOIIGLN;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid POKKHLLLIJC;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OFECOMCFJNL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid HAFLFGMODIF;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid CFBEDIJBLCP;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid AIDOMIKNKLG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid AGJFGMJDACD;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid EAAGJIFKPIJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid IOLKGOBCOFD;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid DDPLFJOJMDD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid NFLECGKLDHI;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid DLHFCFIHAFM;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid DFIHMMNNIKM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DLOBCCLCGCK;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IOFKACFJKPC;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CCADNIFNJLB;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid OFJFEPGOIBI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid OGBIEFMJGAC;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PMKKAPGNGDP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid GJALCOCIEOL;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid OPHGDJKLHHC;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid MEMPDGHMCAG;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid IHOJHJLJDBL;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LGHCBPBEFDE;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid NBCODPBIKDI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid CGHBAEKMLFH;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PNCLGKEDGFE;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid FKJLKECBGBM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid CIEPCGCBPMD;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CGBLPAFLJBG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid BDLMJOINLPG;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid OKBLOEJOFIC;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid OADIJAPMEEG;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid HMJJKJJOGJP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DJHAOCLJHJA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid DCNFNPLPNBP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid KDLHGJOOPDB;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KBAEJCDKPPO;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid ANICIEIPBJF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FPPHNHECPKD;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid CJNFIJPCBFK;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid JPCNHLABMLH;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid BHMIBIOFMGO;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid FBDPIDIBNAG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HDDCMDHJKJN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid NJLJKKNCGKE;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid MEJPHGCDMEA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid CPDBMDGAGML;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid GKKCHDHFJJI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid EGBMGJLMPBE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid JKNGAHKNIHI;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid NCJNFFFGBHC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid LPBIMMEFGBC;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid LFIKKLMMOFL;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid PHNBKJEMFHD;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid FGDCOILOHHI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid KOJDBAGMPGC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid FKHJBBHBHDD;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid FHMCHOCJMGG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid HPKINDPDPOC;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid JPBLNEJJNEH;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid DGKGLDJHNNL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid HLFOICPANKD;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid OJBJBJCKFLP;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BHHADBLHNLK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid OCMJEOBDFFN;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NADKLLFPBPO;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid PMDJGOOAMJN;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid HGMMJLFOPAL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid BPLPMOKEHBK;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid PENMHGENLMD;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KPGAGFFHDJJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid LECGGMJHILL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid IHKGOCPCOFE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid MKMMLMOFAAB;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid DGFHHGDCICI;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HGPIILBCMDG;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid ANGMLMHFGGF;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid CBPAGAOBCKI;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid KCKDLANOPBF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid LGCILPMDACL;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid PDDCAIONNFL;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid ENGAJNENAOH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid DBKOHDGIMEE;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PGEIJCCDCNK;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid HCPMFKJDKDL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid KJLPKIPPADD;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid CJABAKIKOII;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MBPMNIOEAMG;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid IHHNPKBPMPD;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid LMIJDIGKMGA;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GAGHOPPINFF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid MEHNAFJDMGL;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid KEFBBLOEBKB;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid NMJEKPAOBPI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FKIBKHHCCEN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid DOABOEPBJPA;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid JOFHJGBAFBI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid OPHAJHAGJEB;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NPPDJCGCCAH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GCOBELFJOBG;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid EJDPDKJBEBF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid NIGGFNHGMLD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid AKGBIOMKPCL;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HKKBICMFKAF;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CHBFKOFDFDM;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid ODIMPGAENIF;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid NBLBNHGEEKC;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid OFDJOPJOILL;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JOMIAJHCLJJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid BBAEOCABOHK;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid MMNCMOALJDK;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid NPPJBKNMPOL;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid JBBJEMMKKFB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid HKLLJBLLIBO;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid BLMLEFDLHGF;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid JPOBOAKBCGN;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid MHAIBCHLHGA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid AFOCKBBDPDD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid KBFHNJCDEEG;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LDIANAHHDAL;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DNABGMEOPCA;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid HJINIGNCKPC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid DENNECGDKOI;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid MINDAMALJKL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LNKPMFLKFJG;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid MMOMMMDIIPH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid AFELOCEEICA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JOKDKCPGDBI;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid PDOOIEBBOPA;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid IPNFNEELBIJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid ADKIEFGLKDO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid EIKFMMANLGC;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid NAAJJJNIGHI;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LMKNCFJLIII;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid AGEMEAMFPFD;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid INFIFNCFAMJ;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid OMPJGOHNLDP;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid KBFHLJCIAIG;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NGANHEKLKNP;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid JCHNPIGIIKC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid DLIBHMEMJPN;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid NCICEIECMNA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid EAKBCEIMEMF;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid NDNBMJGGBBO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MEJAJMKFNJF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid LEICJLBHBHA;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid PDAGPCIJHNA;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JICJJFDMOOH;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid ADIPJBKPDNJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid CKIBMFPLGFE;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EOBPANCDNMM;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid MIHGDDOGNIH;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JGHIAOHHAPE;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid LDECKLIIEIB;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid MPDFLFOCBPI;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid NGJGOPLJIMK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid DLNNCMPAOIB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid FGPBPCFNMGK;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid GAHLACPLMAK;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid MOPFFJLIKFC;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OOOAIKNHLEP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid ADJBMBPAHHI;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid LENJGCNGMPO;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid EKPJDBJGMNL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PCFPFBKHOPC;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid PLICPPGKBHG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid IHCGKFKKDDC;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CICOMPINOGL;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid EBMPLCNPIFL;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid DMBNHLIBHKC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid GCFIJJDIEJK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid KCEJOOEMIKM;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid BHJFKHICAFD;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CICGOPIJCDA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid CBCKOGMFCMM;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid NACAIDNNHPB;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid PLPHOBAFAJG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid EPHIEMNMJDF;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid OANJHKIECPE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EMIJLOHDGNJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid NIJIGHILLBB;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KCCJIFMLOIH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid LJHCEPFOIBG;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid OACGOMJMLAI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid CBDAKKAPFPK;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CGFKAPLNLLJ;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid JLBEECNNLDB;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid CLLNAPIKOEB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid IJEKMLKAIHF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LBHGGHPKKGF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JALIOJDIAEG;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OJIJOKBHIHM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid AAPANGHADHH;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PFEDLABNGDD;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JNPDCFCGGMA;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid MDIOPPBPELH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid CBKCNNFAFAF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid FFGGPJIDNPI;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid ABIDGBKGDLF;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid CPAJOFLEMFJ;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid DAENGNKPJCK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid BCAKDMEMKKK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid FBAIILGMJCH;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid EEPDNJGHLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KLPDEPCFFDO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid KDCBJDNFJBK;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GCKPKOPPEHB;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KJJBCADCGHC;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid MNAGGOGDDFB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid LFJIAIJHJJC;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid GINLKDNIILK;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid PMLEPFLGBJC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid EJMMPPICPHI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid CEFNPJMIHGM;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid HAAJPKABJII;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid HDCMBPJOMIL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HJCBOKIFFMB;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid NOLCFGOGKIM;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid JEFJCJEMIAG;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid AKKDNCKEAHP;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NJHIPONGIHN;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BBIJNNNEIKH;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid IFKDJFLGBEG;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid HDPLDAAPEJO;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid AFKEBDKLEEK;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid CLOJPKPNBPE;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid EBOGIDOJECB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid GINCELHAEMJ;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid HLJLIAJGDPF;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid OKKKLNICDOC;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid MCLAAHPKBIN;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid BGMLDPLIJCB;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FKGIOMLCBGE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid HBBPGEMDCIB;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GHMIKOLGJMK;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid DEKBDJODAGL;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid PCPLKKKFFKE;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid LPLFDGIOBJI;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid BENDIHHJDLL;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid NAOPMJMFIMO;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid LBDOFAGGNGD;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid NMEMJGBDKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ENFLBEBHMLJ;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid CDGBIKIHMCF;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid IKNLJECBGOE;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid NDLEPPIHNIA;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid FFDCFKMEPJO;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid NOBGOPMFOGA;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JLPHAOEAIHO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid JAMECHNGDPF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AEDGLDJDODH;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid ADHGGFNFBDM;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid PADIGCEMJAB;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid AEJBJOJLAKG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid FCJAKGDNNBE;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid IODDJJHGLPP;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid CPMLDJNBKMI;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid DEGJFOAKJBD;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid DCPOGPFGCPK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid ENCEPBELHBD;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid GHHGHPMKIIC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid PPDIDPCLKLA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid FGAMOBFOCHE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid JEOEBLFKACP;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LPGKPBPJIHA;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid ILMHJLHAGID;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid ALDAMKHJGKL;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid PBJIELPKHLG;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid MAPADCINBOP;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid AKJAGFGIIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid MOOCPNPFPCI;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid IHDFMCOLCHB;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid KDELMCNAEND;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid LABMOKHEKAG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BKICEHNOPAD;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid AGBMIMOCMHD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid EHLFJOMKFPL;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid MNLEGEHGBEC;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid IKAABKELAKC;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OPEDAAGAKKD;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NFCNCOHPKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MPANGCBKAIF;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid IGONHCMAIKC;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JOOFMLILDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid KAMMEODHIFC;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid KAJIJNGNOJK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DEBJNMEEEHM;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid MLLLNGEEGAI;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid HKELCAIEGLO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid JDEDIJDBIDP;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid PJLHCLLNMHG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid PELAGPAHLBB;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid JFPHDLMOBLP;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid CNLMCFGIJOI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HOEAKNONAGL;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid HABJLAHLGOC;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid CCPJJKLENBG;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FJLAIPDOCDM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid DDDECMPFONG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid IEIEOOENDAD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid AHELCHNHDLB;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid ANGKPKCNCHA;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid BOOLMOLNPHO;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid BOCCNJPMKGK;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KIKIFKJHHKC;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid KNODALCOMOL;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MGDBBPBIFKD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid FJJADBPIEFG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid HMNPNOMEDHI;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid ADPMAGECJAK;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OPANLAAKDND;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid FHPCAKDHNEG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid NBAJCJHENAH;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid OIPPKPJEBFB;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid PGDAJCGFGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid MBPHPECMHGF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid NGOPNBDKEKB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LMFKAEDPOLA;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid CDEEBJLNCCN;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid OHPDAGEDMEA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid INJBJDNJGDP;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JJGADNEDCPN;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid HBLGDILKLGP;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid OLFCFKOGMKB;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid KIIIABEHDOB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BNCJEPOLPBF;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JCPFFMNPDGM;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid GLOEOJKJNLA;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid GEBCHJBACNL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid KDIPEMJLHCI;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid OCGIIFGDPDF;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid GGELEHDPLGG;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid OMLOJLEADPF;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid PGKJANBPDLP;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid ACAEKKHFNIM;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid DFEEHMCPPKB;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid PHMHFHNELND;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid AKNKHAFMLDM;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid AFEDLPABIOM;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CMCJGEPNKAF;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid PFABNABPPHO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JENJNMBMDCO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid NLGGLMMLFBK;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid AKJBMECAFEB;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PCANDBKIEPL;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid BNOCOHOEFAI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid OMEGOKIIGOB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid HIAHGBBJPBB;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid ADOBCMJNLFH;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OEEMJCFGIOA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid NNNOLDGBHKK;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid LKJLPNFIHMB;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid PLDBLEMFKHD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid KGICCJPIGAI;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid GBABPFJNGBC;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid EKMHJHDHAML;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ALCPEEEPHBK;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid NAGMPABOHDF;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid BMDKFKJHGMO;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid OCHGFNBIPKB;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid AMICEGBIJBP;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid OIOLMKIJOCB;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid BNONGPCHGAC;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid BFEBALBNALB;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid AJPENIMGDEP;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid KOKBNAFGKGF;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid INBKDPNKOOP;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid IMEPHFEDHLM;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid PLCOEPAEBBJ;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GOOAOHAHJLH;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid ALGPGBFAECL;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid BPAOBKJLIGP;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid HLHHGMAAEPK;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid IJJGCKHHDFG;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid JJFPKMKEBCO;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid LNEBAEBKBKO;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid JOEEONAGGBP;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid HBPEFCOCPDP;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid PEKFJHPJGNI;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid FBNGLEHMEDI;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid GHMBDDKLBID;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid FPIDKGEOGFO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GEBGPAGECNE;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid FHPCNFAJPOF;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid DIDFLABKPJK;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid KAPMGFJHKHE;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid HPMNLGIFNGH;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid MOIBNMFLOOP;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EPKFDLOAHCJ;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid AOONDGJBMKH;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid PIPFHAEKDMG;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid BGJDBFHDMIB;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid FEMJKNHLDBJ;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid KMFJFBHDEBN;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid BKHBBMMIBBC;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid IOEBAKDHAKL;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid FNACHENMLCP;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid OGCDDOFHKCI;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid IANJPMMEEAO;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid JGOOANHAJEN;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid MIHNOKFJLEJ;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IBCAGLHOFIE;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid FGJCFENHAIK;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid CAPCMNCOLIO;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid EBCDKMOANJM;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid FODKHHOJHEG;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid AHKPHGFNDDB;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid FABGPLNMPKE;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid PHELDOPFFGH;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid JOKKGMMPPCA;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid MLHHCLEDAHD;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid FBGPMAEHAGH;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GKJMPBIHBOP;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid LNIFOKACEPN;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IABOBAOEMHG;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid LKDPDJHLMLA;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid CIIKHOGABOP;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GBEOCHLNOAL;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid MAJJPKOFKGI;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid DHPIFGJOCHL;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GCIIANBJFJP;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid FBKAOHAGPME;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid OCBJANEILFG;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid EDJAOFFCHFL;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid MBPEFOEKEAI;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid EFDAFBIMEJH;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid OFHBEMKNPKI;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MNIPDIJKCNN;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid JLFJDELFODM;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid ECCJJDPMHCH;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid OJHCBAABPJJ;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid IEKICLECHGM;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid KLPBGFHNGCO;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid KALCJPNHLKE;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NAIKBHBLJPK;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid PPBILOMLMIC;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid PEKOPMHLHMI;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, KBJDPOHDFCM> DBJPPKFHCFH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<KBJDPOHDFCM, Guid> EBBDAIJOIHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, KBJDPOHDFCM> LGNNAMMDLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x684FCC0", Offset = "0x684E8C0", VA = "0x18684FCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<KBJDPOHDFCM, Guid> PLHIKGBAGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x684FD20", Offset = "0x684E920", VA = "0x18684FD20")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DPDCIGDILMG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x684AA90", Offset = "0x6849690", VA = "0x18684AA90")]
	public static bool CABCGIPAGJC(HKFDIHGNKEE PNLMENMENDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x684AAC0", Offset = "0x68496C0", VA = "0x18684AAC0")]
	private static bool CABCGIPAGJC(JDFEKFKGGLB BGLILLMPOMB, HKFDIHGNKEE PNLMENMENDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MAJIOAOGKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly CMAKDEJOIDK ODCFJIKNEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<CBEKBKNFPHF> AIOACMPCEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<CBEKBKNFPHF> GIFDJPEBEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly DCECDLKENED<AJNNPPKMCNH> HKEPKMJHIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<KPOKIIDKMFA<GIGLGMMBICO>> CIJHGMFHNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString CMPBNFLNGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly LLFCHAKAIDN JOCOAKDHAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool JDGLFJGEPBP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x684FD80", Offset = "0x684E980", VA = "0x18684FD80")]
	public MAJIOAOGKNG(CMAKDEJOIDK FPCOEIJKNOL, IEnumerable<CBEKBKNFPHF> MBOIBNMPCFB, IReadOnlyList<CBEKBKNFPHF> AGKCMFGOPGM, DCECDLKENED<AJNNPPKMCNH> GAEKPMCPKGF, IReadOnlyList<KPOKIIDKMFA<GIGLGMMBICO>> MLDPEHCFCCN, ByteString PDAGFKMPJHK, LLFCHAKAIDN JBNLJBPGOLP, bool LLFLEIENIFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CILEKAJPLMM
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(EFIAIOGFPPN IMCLGJBJJKP, [Out] Dictionary<int, int> GPFAKGGIBIP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(NKGKLFPECPE ODIDLNLLPKD, FHPOKODLPCF LDCKNKDPCEA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DMMKAFJGGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid NFMBBKIFBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> KFJPCBKKJMB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> DAMLLHHCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A5C1C0", Offset = "0x3A5ADC0", VA = "0x183A5C1C0")]
	private DMMKAFJGGJP([In] Guid BFOEDLBGJFO, Dictionary<Guid, Guid> KHOHDIIDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x684A5B0", Offset = "0x68491B0", VA = "0x18684A5B0")]
	public static DMMKAFJGGJP KFBOOIMCKEM(IReadOnlyDictionary<Guid, Guid> DGBLFFMLMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x684A5C0", Offset = "0x68491C0", VA = "0x18684A5C0")]
	public static DMMKAFJGGJP NECEAGCMBOD(IEnumerable<KeyValuePair<Guid, Guid>> DGBLFFMLMBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x684A970", Offset = "0x6849570", VA = "0x18684A970")]
	private static Dictionary<Guid, Guid> PAFOKAJELEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x684A4A0", Offset = "0x68490A0", VA = "0x18684A4A0")]
	public Guid EKBJAALHEGN([In] Guid CICFLOBNFHG, bool EILEFAFAIDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x684AA20", Offset = "0x6849620", VA = "0x18684AA20")]
	public bool PPJLJGEDMHE([In] Guid EPKGPGILADI, [Out] Guid JEBDIEFPECK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MFKKCDJOFKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CIGKNHKCONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGCBEAACMHC(ByteString EJGADLCOEON, DMMKAFJGGJP AGCIOAAGKOA, [In] UniformTRS NPDGGGFDHKL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AEJHDGLHHJP
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ALPANMDKDIA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14E0260", Offset = "0x14DEE60", VA = "0x1814E0260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LMNGILIFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xFFACA0", Offset = "0xFF98A0", VA = "0x180FFACA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long DJNMGMEDIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x684A3F0", Offset = "0x6848FF0", VA = "0x18684A3F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x655ADF0", Offset = "0x65599F0", VA = "0x18655ADF0")]
	public ALPANMDKDIA(long HDFABDCMCAG, long EMKEMBBFFDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MFECBDDHKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, ALPANMDKDIA> FIOIBKKAPDA;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> KLENDJBDAME;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long HFLCHOIHPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xFFACA0", Offset = "0xFF98A0", VA = "0x180FFACA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long IMHBPBGINPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x105B610", Offset = "0x105A210", VA = "0x18105B610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68500E0", Offset = "0x684ECE0", VA = "0x1868500E0")]
	public static MFECBDDHKJG MOPLLCFIHEM(CMAKDEJOIDK KEOKIHAOOPA, KPOKIIDKMFA<AJNNPPKMCNH> HCGNBJICGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x684FE10", Offset = "0x684EA10", VA = "0x18684FE10")]
	private void EIGOFFKAAOB(OBMNEEPHOCK LNFMEAPGAAK, long GAPJMACKCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6864090", Offset = "0x6862C90", VA = "0x186864090")]
	public MFECBDDHKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MNEODNAIALH
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<KBJDPOHDFCM> DFBPEBIFAOF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FBHLBDHJBNI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> AFFOBFHNBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> KONEJOCIHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public FBHLBDHJBNI(IReadOnlyDictionary<Guid, Guid> IPEONJDIILC, IReadOnlyDictionary<Guid, Guid> OMBOLAKBLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FDCDOKMGBBD
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x684D860", Offset = "0x684C460", VA = "0x18684D860")]
	public static HPDBDHCAGJL KHIAJICDJKE([In] MAJIOAOGKNG PNIHJGEOJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x684D9E0", Offset = "0x684C5E0", VA = "0x18684D9E0")]
	private static void NBNNPACEEMA(HPDBDHCAGJL IDKMLMHCNKG, [In] MAJIOAOGKNG GOHGEGLPEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x684B710", Offset = "0x684A310", VA = "0x18684B710")]
	public static GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA> JJNMMFOPNPJ(HPDBDHCAGJL IDKMLMHCNKG, GPBJEHFODJI MICCOJOHAPK, DMMKAFJGGJP? LPEBNCBNHDJ)
	{
		return default(GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x684E040", Offset = "0x684CC40", VA = "0x18684E040")]
	private static void NKABOEODIDH(HPDBDHCAGJL IDKMLMHCNKG, DMMKAFJGGJP? BGFEPGBHOKH, GPBJEHFODJI MICCOJOHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x684B6A0", Offset = "0x684A2A0", VA = "0x18684B6A0")]
	private static void IOIKLDPDFHB(HPDBDHCAGJL IDKMLMHCNKG, GPBJEHFODJI MICCOJOHAPK, IReadOnlyCollection<ByteString>? GKINGAJKMEF, IReadOnlyCollection<ByteString>? GOFDBLKDGLG, IReadOnlyCollection<ByteString>? FFPNFIMCJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x684CF40", Offset = "0x684BB40", VA = "0x18684CF40")]
	private static bool JPBPGPDPBIH(HPDBDHCAGJL IDKMLMHCNKG, NKGKLFPECPE ODIDLNLLPKD, GPBJEHFODJI MICCOJOHAPK, [Out][NotNullWhen(false)] string? MCOFJPDPPAJ, [Out] Dictionary<int, int> GPFAKGGIBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x684B3C0", Offset = "0x6849FC0", VA = "0x18684B3C0")]
	private static Dictionary<Guid, JDFEKFKGGLB> IJPCPOFDJCK(HPDBDHCAGJL IDKMLMHCNKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x684AE70", Offset = "0x6849A70", VA = "0x18684AE70")]
	private static void AAHBFKBBDMF(bool AJHJFJAKJIH, CBEKBKNFPHF PDLNDIJBMLD, Dictionary<Guid, Guid> CAJLDJHNDIM, DMMKAFJGGJP CPNMNIEODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x684D5D0", Offset = "0x684C1D0", VA = "0x18684D5D0")]
	private static void KACMEPCGMML(CBEKBKNFPHF PDLNDIJBMLD, Guid DLOOBAJOEIC, MLPGIAJIGFI? AFMBBBIIABF, Dictionary<Guid, JDFEKFKGGLB> GCHEGKIJKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x684AF10", Offset = "0x6849B10", VA = "0x18684AF10")]
	private static void AMOLGIFBJGE(IEnumerable<CBEKBKNFPHF> IHPDHIKPDIJ, IReadOnlyCollection<ByteString> GKINGAJKMEF, IReadOnlyCollection<ByteString> GOFDBLKDGLG, IReadOnlyCollection<ByteString> FFPNFIMCJMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GPBJEHFODJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool AJHJFJAKJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public LLFCHAKAIDN JBNLJBPGOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public MLPGIAJIGFI? AFMBBBIIABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public MLPGIAJIGFI? LMJBOPEMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public CMAKDEJOIDK NNFKOIMOGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public AEJHDGLHHJP LKLGDBJKCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public CILEKAJPLMM IOHNGBHPFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public MFKKCDJOFKG LGHMBAKOMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public KPOKIIDKMFA<AJNNPPKMCNH> CBPCFNJPMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public NFJAEEDNHJG FLHBEBMBPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<CBEKBKNFPHF> DJPEIAGLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> ABDLLNCEOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public IDNCKJOIHCE FACHJHKGCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool PAHIOIAFKOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CJFCIBNEGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x684F9E0", Offset = "0x684E5E0", VA = "0x18684F9E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MLPGIAJIGFI
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float HACIANILPOO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 DFPHDEDIHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion DELGPMLKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float IADPMFLONGE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 HCDHCPGJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6864710", Offset = "0x6863310", VA = "0x186864710")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS DHGOAJOEEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68646D0", Offset = "0x68632D0", VA = "0x1868646D0")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB179A0", Offset = "0xB165A0", VA = "0x180B179A0")]
	public MLPGIAJIGFI(Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float IADPMFLONGE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6864A50", Offset = "0x6863650", VA = "0x186864A50")]
	public MLPGIAJIGFI(UniformTRS PDHFAPOKMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6864450", Offset = "0x6863050", VA = "0x186864450")]
	public static MLPGIAJIGFI HDAOEJEHFIM(MLPGIAJIGFI GPMGJNAOOEP, MLPGIAJIGFI KGJHCFLMHBA)
	{
		return default(MLPGIAJIGFI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6864820", Offset = "0x6863420", VA = "0x186864820")]
	public static MLPGIAJIGFI NBHHLKKAPBL((Vector3, Quaternion, float) IMCLGJBJJKP)
	{
		return default(MLPGIAJIGFI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6864840", Offset = "0x6863440", VA = "0x186864840")]
	public static MLPGIAJIGFI NBHHLKKAPBL(Matrix4x4 AGFIHLAPICC)
	{
		return default(MLPGIAJIGFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68649C0", Offset = "0x68635C0", VA = "0x1868649C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x68641B0", Offset = "0x6862DB0", VA = "0x1868641B0")]
	public MLPGIAJIGFI CIGJBGEAPFG(Matrix4x4 KHIOEALLADK)
	{
		return default(MLPGIAJIGFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x68643E0", Offset = "0x6862FE0", VA = "0x1868643E0")]
	public static MLPGIAJIGFI DKFOIFHOBNP(Vector3 DFPHDEDIHFK)
	{
		return default(MLPGIAJIGFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6864120", Offset = "0x6862D20", VA = "0x186864120")]
	public readonly IBGMJDOMBAG CDEPCDLMLEE()
	{
		return default(IBGMJDOMBAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CPBKDGOLLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x684A410", Offset = "0x6849010", VA = "0x18684A410")]
	public static MLPGIAJIGFI HOCDLDBAMPP([In] this IBGMJDOMBAG HNFMOHFACKF)
	{
		return default(MLPGIAJIGFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KDKPMEFLAGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly ILDCHPCKCOG BJGJKEOGLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private readonly NKGCJHELBDN ENKCOGJMEAP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD86720", Offset = "0xD85320", VA = "0x180D86720")]
	private KDKPMEFLAGA(ILDCHPCKCOG OLADDMOOKPM, NKGCJHELBDN OCNKPKOJGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x684FA30", Offset = "0x684E630", VA = "0x18684FA30")]
	public CDNNBELNBJI KLGHIFFJEPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x684FAA0", Offset = "0x684E6A0", VA = "0x18684FAA0")]
	public static GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA> PPOPBMPFEOP(ALFLEFIPKNP<LOGIJBPEHJN> OCNKPKOJGAA)
	{
		return default(GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x684FB50", Offset = "0x684E750", VA = "0x18684FB50")]
	public static GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA> PPOPBMPFEOP(CDNNBELNBJI OCNKPKOJGAA)
	{
		return default(GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x684FC00", Offset = "0x684E800", VA = "0x18684FC00")]
	public static GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA> PPOPBMPFEOP(string NLIIHJGKEKF)
	{
		return default(GFFELLBKJIA<FBHLBDHJBNI, KDKPMEFLAGA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum ILDCHPCKCOG
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MMFIKNICFON : IDisposable, KLGIOJENOKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private NativeList<LPFJHNJFEMI> GGNLHDCCGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float CGFHICKLEPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PJNOCAJGACO PLEMNJOLHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
		[CompilerGenerated]
		get
		{
			return default(PJNOCAJGACO);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MMPKLFIKFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6866C40", Offset = "0x6865840", VA = "0x186866C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool AHAPFIBFNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68667D0", Offset = "0x68653D0", VA = "0x1868667D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<HHNJPNPOKMN> ACDOKPGNFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PHGMBFDOJBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6866790", Offset = "0x6865390", VA = "0x186866790", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float IDJNINDAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6865290", Offset = "0x6863E90", VA = "0x186865290")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6867280", Offset = "0x6865E80", VA = "0x186867280")]
	public MMFIKNICFON(PJNOCAJGACO NBEBDBNCFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68653D0", Offset = "0x6863FD0", VA = "0x1868653D0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6866C50", Offset = "0x6865850", VA = "0x186866C50")]
	public Vector3 PGJELIKLHME(int BIIBCGDMKEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68667E0", Offset = "0x68653E0", VA = "0x1868667E0", Slot = "6")]
	public Quaternion NMAHEPBLLOO(int BIIBCGDMKEH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6865090", Offset = "0x6863C90", VA = "0x186865090", Slot = "5")]
	public Vector3 BLPCBLBPJBH(int BIIBCGDMKEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68668B0", Offset = "0x68654B0", VA = "0x1868668B0", Slot = "7")]
	public float NOHOFCMADFL(int BIIBCGDMKEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6865640", Offset = "0x6864240", VA = "0x186865640")]
	public void IDPBHDEFLEH(Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float HNLLDLBIGBG, bool KABHKOHABJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6865430", Offset = "0x6864030", VA = "0x186865430")]
	private bool FILMBNENPGE(int KOMPHCFPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6867120", Offset = "0x6865D20", VA = "0x186867120")]
	public void PHHEONFJPND(Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float HNLLDLBIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6866BB0", Offset = "0x68657B0", VA = "0x186866BB0")]
	public void PDGLAKBHABN(int KOMPHCFPFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6866910", Offset = "0x6865510", VA = "0x186866910")]
	public void OHCEJLDOAML(int KOMPHCFPFKH, Vector3 DFPHDEDIHFK, Quaternion DELGPMLKBMI, float HNLLDLBIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6865490", Offset = "0x6864090", VA = "0x186865490")]
	public void GAKCBONOKAN(int KOMPHCFPFKH, float3 DFPHDEDIHFK, quaternion DELGPMLKBMI, float HNLLDLBIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6866A60", Offset = "0x6865660", VA = "0x186866A60")]
	public void OKJLNLIIKMG(int KOMPHCFPFKH, Vector3 DFPHDEDIHFK, float HNLLDLBIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6865130", Offset = "0x6863D30", VA = "0x186865130")]
	public void CHFLNCDMBNL(int KOMPHCFPFKH, Vector3 KLEPCPADMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6865FA0", Offset = "0x6864BA0", VA = "0x186865FA0")]
	public static Quaternion JKJFEHPFINL(Quaternion JLMIPDKPKDA, int KOMPHCFPFKH, float HJAJJIBCMNB, KLGIOJENOKL JAHJLINGCAO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6864BF0", Offset = "0x68637F0", VA = "0x186864BF0")]
	public Bounds AFKAJPFEDGB(Transform KHIOEALLADK)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6865F30", Offset = "0x6864B30", VA = "0x186865F30", Slot = "10")]
	public virtual void IFIPEAFIOCO(bool NDOHPHJKMCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6864B20", Offset = "0x6863720", VA = "0x186864B20")]
	public NativeList<LPFJHNJFEMI> AFDEBNFINCP(float INPJNELNFBD = 1f)
	{
		return default(NativeList<LPFJHNJFEMI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HHNJPNPOKMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float3 KJEIHCPEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float DHCHBNIPLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public quaternion IBHCPOKELNN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x686B560", Offset = "0x686A160", VA = "0x18686B560")]
	public HHNJPNPOKMN(Vector3 CILJGBPKAKN, Quaternion JLMIPDKPKDA, float HNLLDLBIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x686B4A0", Offset = "0x686A0A0", VA = "0x18686B4A0")]
	public Quaternion PHOBDCJNGPG(Vector3 ALGFLILJAIC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x686B1A0", Offset = "0x6869DA0", VA = "0x18686B1A0")]
	public HHNJPNPOKMN MLBIEKMDECN(Vector3 NDKCGECCBLK, Vector3 JNALGIEJIJE, Vector3 POOIGAMHEOG)
	{
		return default(HHNJPNPOKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x686AFF0", Offset = "0x6869BF0", VA = "0x18686AFF0")]
	public DLLKKLLPMGP JHNDPHDGIBJ(Vector3 ALGFLILJAIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class ANMFLBBBMFL : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6867F00", Offset = "0x6866B00", VA = "0x186867F00", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6867930", Offset = "0x6866530", VA = "0x186867930")]
	private void DAHNOPHEJBP(Dictionary<Guid, Guid> EELHFJLFPNB, DCDHIAKLOJO NKIFNEKEMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68678D0", Offset = "0x68664D0", VA = "0x1868678D0")]
	private void DAHNOPHEJBP(Dictionary<Guid, Guid> EELHFJLFPNB, FLFONBIGDAG ICAHKGMGLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6867650", Offset = "0x6866250", VA = "0x186867650")]
	private void DAHNOPHEJBP(Dictionary<Guid, Guid> EELHFJLFPNB, HAAFMLJCADP FBLCCKCCAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public ANMFLBBBMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DHBKKHHACAF : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68682F0", Offset = "0x6866EF0", VA = "0x1868682F0", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public DHBKKHHACAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EMCMJEPOMEB : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6869950", Offset = "0x6868550", VA = "0x186869950", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EMCMJEPOMEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class NFBOACHPNFG : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x686D640", Offset = "0x686C240", VA = "0x18686D640", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NFBOACHPNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FCDBBECMAOH : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6869AB0", Offset = "0x68686B0", VA = "0x186869AB0", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public FCDBBECMAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKFPNLKALGG : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x686DB40", Offset = "0x686C740", VA = "0x18686DB40", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OKFPNLKALGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class INBFFDACADP : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x686CA80", Offset = "0x686B680", VA = "0x18686CA80", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public INBFFDACADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MCMFBIBFPAM : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x686D550", Offset = "0x686C150", VA = "0x18686D550", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MCMFBIBFPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GMKAIOGCOCG : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x686AE30", Offset = "0x6869A30", VA = "0x18686AE30", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GMKAIOGCOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class BKPFPECKBLA : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6868030", Offset = "0x6866C30", VA = "0x186868030", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BKPFPECKBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BPCNHHELBPH : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68681F0", Offset = "0x6866DF0", VA = "0x1868681F0", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BPCNHHELBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IDLBJJOGKPA : CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public static readonly BLPBEHBHIGM BBFOEEIEGEH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x686B5E0", Offset = "0x686A1E0", VA = "0x18686B5E0", Slot = "4")]
	public void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public IDLBJJOGKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HKFDIHGNKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public NKGKLFPECPE IDPOJNOELJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public APOKBMPMKIC DIFNEKBIFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public Dictionary<int, int> PGDDIJDBBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public Dictionary<Guid, Guid> LOPEBMLEMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public IDNCKJOIHCE FACHJHKGCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool CPJPHKBDDMA;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CPLOIBCLHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMAPEGMLBGG(BIJCKBLKKFF JHNOBFKBFNE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FNIMDGFLCOK
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private static readonly CPLOIBCLHCA[] KOMONEPCMEM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x686A5B0", Offset = "0x68691B0", VA = "0x18686A5B0")]
	public static void NDPODHIKFDF(CBEKBKNFPHF IMCLGJBJJKP, Dictionary<Guid, Guid> HPFOHBBBDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x686A320", Offset = "0x6868F20", VA = "0x18686A320")]
	public static void HENOJPDNBFL(CBEKBKNFPHF? IMCLGJBJJKP, DMMKAFJGGJP PNHJIPCAFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x686A0A0", Offset = "0x6868CA0", VA = "0x18686A0A0")]
	public static void EFMDGAIHEEE(CBEKBKNFPHF? IMCLGJBJJKP, DMMKAFJGGJP CPNMNIEODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6869CD0", Offset = "0x68688D0", VA = "0x186869CD0")]
	public static void CABCGIPAGJC(BIJCKBLKKFF JHNOBFKBFNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct BIJCKBLKKFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public NKGKLFPECPE HKPIMNNHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public CBEKBKNFPHF PDLNDIJBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public Dictionary<int, int> PGDDIJDBBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public Dictionary<Guid, Guid> LOPEBMLEMPF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6867F80", Offset = "0x6866B80", VA = "0x186867F80")]
	public Guid CBIBEHJIEEA(Guid CICFLOBNFHG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IDNCKJOIHCE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int GDJJHAJNKNO, [Out] Guid JGLNOCFFGML);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class EILOGJMNOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private readonly HashSet<string> HKICJKANMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<long, int> ANDIJOOMBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private readonly HashSet<Guid> KALILKAJOGJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> CFCAAMNLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> JOMDICJMHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6869680", Offset = "0x6868280", VA = "0x186869680")]
	public static EILOGJMNOML OHPDIGAPLGB(HLKJAJHEMPF AFAEGADIMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6868770", Offset = "0x6867370", VA = "0x186868770")]
	public static EILOGJMNOML KIKNCIBAOAI(HPDBDHCAGJL NPDPKHPGHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x68685F0", Offset = "0x68671F0", VA = "0x1868685F0")]
	public static EILOGJMNOML ICBPJPFBBCJ(IEnumerable<string> HKICJKANMHC, IDictionary<long, int> JJJLDOLJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6869830", Offset = "0x6868430", VA = "0x186869830")]
	private EILOGJMNOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68696F0", Offset = "0x68682F0", VA = "0x1868696F0")]
	private EILOGJMNOML(IEnumerable<string> HKICJKANMHC, IDictionary<long, int> JJJLDOLJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6868CE0", Offset = "0x68678E0", VA = "0x186868CE0")]
	private void NOAECEFKENM(HLKJAJHEMPF AFAEGADIMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6869490", Offset = "0x6868090", VA = "0x186869490")]
	private void NOAECEFKENM(HPDBDHCAGJL NPDPKHPGHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x68689B0", Offset = "0x68675B0", VA = "0x1868689B0")]
	private void NOAECEFKENM(MFJCFEEFMNJ? BLPDMPJLPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x68692C0", Offset = "0x6867EC0", VA = "0x1868692C0")]
	private void NOAECEFKENM(CCBHLLAHGJD? LNFMEAPGAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6868ED0", Offset = "0x6867AD0", VA = "0x186868ED0")]
	private void NOAECEFKENM(CBEKBKNFPHF? PDLNDIJBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6868580", Offset = "0x6867180", VA = "0x186868580")]
	private void HBJOKCDGLPP(string? MJEGMENNIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68688D0", Offset = "0x68674D0", VA = "0x1868688D0")]
	private void MDBCCHKMJMC(KEIACDFOPNP? LOOJANBOBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x68687E0", Offset = "0x68673E0", VA = "0x1868687E0")]
	private void MDBCCHKMJMC(LLIHNCHEBMD? LOOJANBOBNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct IFAKPPHFJJH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class OGOEMCFFNIA : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private readonly IEnumerator<DictionaryEntry> CACLGIIFKFJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry DNPJAEMKGON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x686D910", Offset = "0x686C510", VA = "0x18686D910", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object NEMDOAJKGDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x686D9E0", Offset = "0x686C5E0", VA = "0x18686D9E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object EPAONLOANJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x686DA90", Offset = "0x686C690", VA = "0x18686DA90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x686D830", Offset = "0x686C430", VA = "0x18686D830", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
		public OGOEMCFFNIA(IEnumerator<DictionaryEntry> CACLGIIFKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x686D790", Offset = "0x686C390", VA = "0x18686D790", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x686D7E0", Offset = "0x686C3E0", VA = "0x18686D7E0", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class IMNLAAOJCDO : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x686CA30", Offset = "0x686B630", VA = "0x18686CA30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
			[DebuggerHidden]
			public IMNLAAOJCDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x686C8E0", Offset = "0x686B4E0", VA = "0x18686C8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x686C9E0", Offset = "0x686B5E0", VA = "0x18686C9E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x686E250", Offset = "0x686CE50", VA = "0x18686E250", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object DPHIOKCFMFC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x686E160", Offset = "0x686CD60", VA = "0x18686E160", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x686E340", Offset = "0x686CF40", VA = "0x18686E340", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x686E0A0", Offset = "0x686CCA0", VA = "0x18686E0A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x686E100", Offset = "0x686CD00", VA = "0x18686E100", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x686E2E0", Offset = "0x686CEE0", VA = "0x18686E2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x686DD60", Offset = "0x686C960", VA = "0x18686DD60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x686DDC0", Offset = "0x686C9C0", VA = "0x18686DDC0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x686DE20", Offset = "0x686CA20", VA = "0x18686DE20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
		public RoomObjectCounts(Dictionary<int, int> INAMMMNNMEN, [Optional] Dictionary<int, int> JOBEOMDLKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x686DC80", Offset = "0x686C880", VA = "0x18686DC80")]
		[IteratorStateMachine(typeof(IMNLAAOJCDO))]
		private IEnumerator<DictionaryEntry> OMMGAHOLFAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x686E390", Offset = "0x686CF90", VA = "0x18686E390", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x686DFA0", Offset = "0x686CBA0", VA = "0x18686DFA0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x686DE80", Offset = "0x686CA80", VA = "0x18686DE80", Slot = "9")]
		void IDictionary.Add(object DPHIOKCFMFC, object GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x686DEE0", Offset = "0x686CAE0", VA = "0x18686DEE0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x686DF40", Offset = "0x686CB40", VA = "0x18686DF40", Slot = "8")]
		bool IDictionary.Contains(object DPHIOKCFMFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x686E040", Offset = "0x686CC40", VA = "0x18686E040", Slot = "14")]
		void IDictionary.Remove(object DPHIOKCFMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x686DD00", Offset = "0x686C900", VA = "0x18686DD00", Slot = "15")]
		void ICollection.CopyTo(Array CHPEIOMPEEH, int OPDMGNJCACB)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class DMIMBJNJGHG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x6868530", Offset = "0x6867130", VA = "0x186868530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
			[DebuggerHidden]
			public DMIMBJNJGHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x68683A0", Offset = "0x6866FA0", VA = "0x1868683A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x68684E0", Offset = "0x68670E0", VA = "0x1868684E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x686D260", Offset = "0x686BE60", VA = "0x18686D260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object DPHIOKCFMFC]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x686D130", Offset = "0x686BD30", VA = "0x18686D130", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x686D310", Offset = "0x686BF10", VA = "0x18686D310", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x686D070", Offset = "0x686BC70", VA = "0x18686D070", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x686D0D0", Offset = "0x686BCD0", VA = "0x18686D0D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x686D2B0", Offset = "0x686BEB0", VA = "0x18686D2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x686CCF0", Offset = "0x686B8F0", VA = "0x18686CCF0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x686CD50", Offset = "0x686B950", VA = "0x18686CD50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x686CDB0", Offset = "0x686B9B0", VA = "0x18686CDB0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F7EB20", Offset = "0x1F7D720", VA = "0x181F7EB20")]
		public Invention(long EPKGPGILADI, int HDFABDCMCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x686CC20", Offset = "0x686B820", VA = "0x18686CC20")]
		[IteratorStateMachine(typeof(DMIMBJNJGHG))]
		private IEnumerator<DictionaryEntry> OMMGAHOLFAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x686D360", Offset = "0x686BF60", VA = "0x18686D360", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x686CF30", Offset = "0x686BB30", VA = "0x18686CF30", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x686CE10", Offset = "0x686BA10", VA = "0x18686CE10", Slot = "9")]
		void IDictionary.Add(object DPHIOKCFMFC, object GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x686CE70", Offset = "0x686BA70", VA = "0x18686CE70", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x686CED0", Offset = "0x686BAD0", VA = "0x18686CED0", Slot = "8")]
		bool IDictionary.Contains(object DPHIOKCFMFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x686D010", Offset = "0x686BC10", VA = "0x18686D010", Slot = "14")]
		void IDictionary.Remove(object DPHIOKCFMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x686CC90", Offset = "0x686B890", VA = "0x18686CC90", Slot = "15")]
		void ICollection.CopyTo(Array CHPEIOMPEEH, int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> LBDNODEBGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public readonly IReadOnlyList<Invention> GCGBAMMLBFM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public IFAKPPHFJJH(IReadOnlyDictionary<Guid, RoomObjectCounts> OGHEAFBPPPH, IReadOnlyList<Invention> PPOKJCIHAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x686BEF0", Offset = "0x686AAF0", VA = "0x18686BEF0")]
	public static IFAKPPHFJJH OHPDIGAPLGB(HLKJAJHEMPF AFAEGADIMPI)
	{
		return default(IFAKPPHFJJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x686BDD0", Offset = "0x686A9D0", VA = "0x18686BDD0")]
	[CompilerGenerated]
	internal static int LCLELHJHNHN([In] IReadOnlyDictionary<long, int> EFNMIFFBBNK, long? OBHGHNIDHDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x686B710", Offset = "0x686A310", VA = "0x18686B710")]
	[CompilerGenerated]
	internal static void FKCBHJDILOL(int CCHPGDDOCCL, [In] MFJCFEEFMNJ HJEAEGOGKGP, [In] Dictionary<long, int> EFNMIFFBBNK, [In] Dictionary<Guid, RoomObjectCounts> OGHEAFBPPPH)
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
