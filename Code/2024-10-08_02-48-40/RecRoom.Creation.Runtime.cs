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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BEF370", Offset = "0x6BEE570", VA = "0x186BEF370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OEFGPHGMCHH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> MPAKEMCGGHE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OHPNFEGBNOC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> CCBNIPEPNNO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> PIMOFFKLAJN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string NMCOONCJPPL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string FHLPHNPNMED;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string GDCKIDLJHCG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFB00", Offset = "0x6BEED00", VA = "0x186BEFB00")]
	public static bool IICNIDBEMCM(Guid JOBMKEOFKGC, int BOOANCANFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFA70", Offset = "0x6BEEC70", VA = "0x186BEFA70")]
	public static bool FJACHGLBKFL(Guid JOBMKEOFKGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF3F0", Offset = "0x6BEE5F0", VA = "0x186BEF3F0")]
	public static string EOFBNJELDMN(Guid KGBBBBHDKAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CPJHCBMNPMK]
public enum GDAPMDMPHOL
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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEF70", Offset = "0x6BEE170", VA = "0x186BEEF70", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BNJCBPGAKNJ
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid LJLBALLOPCJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid EKEMNJGBBOE;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid FEAJOLCNPIC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid AACOEHLDCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid MAPBKKNPLPI;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FAHEDBGBPMG;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid NMNFCODIJKE;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid CHLMLPJOJIG;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid DLNDGLKDFPO;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid DIMKGGDLLNN;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid ELMIFGJFJBH;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JNJAHEHIABB;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid OLBKBLCNFJL;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid GJDAGCLKIEM;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid EDBFJHLACDK;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid KJDEBFMPGFJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NNBLPOEACHN;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid OKEFEBGGGKL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OBECIOEMMHC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid FHHINBNPACO;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid HIDAKGJCFKA;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PIOMGKKJKHM;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid PFMNDNGOBDM;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid POAAOJDHLGE;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid BNKPFIDCHGD;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid IMPNAPDPIPJ;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FMADICOBNEA;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid BPKDIEIEBGB;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid PDNFCNDLDBN;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid ALIBCBBKBEH;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid PKDAHFCOEAG;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid OPKNMKACPJK;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid GKNJACNFPIC;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid FBKPKJCBANA;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ILODFPKGBIG;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid HFPLOOGAOFH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NEMMDNBNIAP;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JBJBJOHMNII;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NBFMGKNDBAF;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HNNHDCPPFEB;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid CGLELKHEKGK;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid OKHCNMHEEAM;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CGOHCIPAJIB;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OHBLIBPKEHE;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid EECPALBBMDO;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid KJGGFLOLOLC;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid IDCJAIJELPM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid BEPGKBGGDHE;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid LHOHNPOGLMF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LAIDPICNIIO;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid AJGNCMOOODP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid NJIGADPIKCF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid KBFCEFGJDDI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KAPHKMIBKGK;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JPOONNILHLK;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid FODGDJCOAAN;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid IKKDFECOKEC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid ADFKCDJFOMF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid ACEEACMODJN;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid GMCEPAMDCIA;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid GLDPFLBBFNJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid OLNLDBECEMM;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LMIDLKLHBFP;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid BHONPHLOPAF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid HEPKFMOMODK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid EPPCCCLGMLA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid DGMGLMMNIGN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid OAKCGACIONP;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid HPADEMADGCA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid LCBEHILFHCK;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PKPDDADEADA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EDMNDBOIMNB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DIGEPMCNKHA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LJMIBFHEJDO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BIFEHEFMBNJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NHLKKMOPNIH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid CMADOBBLALE;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid CCAODMEKNGG;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid JEEMOPEGMFP;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid AHIOPNIBGEJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JGMBEGHPOPK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid HDKKDKMNGJB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid KMKDMFIDJME;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid AMCEDJLHHLC;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid JMBNFEDECBL;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid IFMPKEOOAAF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid JNNODMPMLIM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid FAMANFPJDAM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid MMEDEPMGBOE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid BCKHPAKKFCN;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HKBALICOJOE;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid JNPOBDEJDAN;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BEGKKJOHMNI;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FCDFEIMALNA;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid EANNGCMGONK;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid GEMBIMMOIFM;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid OODFGAMJKJL;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid NBBNCKIACGF;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid JJAHADALMFB;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid LFICDMALDOJ;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid PLGONCADHDH;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DMJMOHNFGFP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid NEILPCAIAPE;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid OJIDFIONBFJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid LFBGKBDNCBE;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid OGCGKCGJFHC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DDBKCIPMKAM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid KJFAMDIHLBO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KLOAGDOOEIJ;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid MNDALBHNEIF;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid INKFCNFJKCE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid APFOEJGLGDA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid JJDOPJABPKA;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid IDMDCINCFBK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KNJIOGKCGHP;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FCDAKHPCCDM;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid DEABNMKFFLN;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FMJKHCPPPCH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid JGEBJDBHKHB;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CACIAFNEMMJ;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid OMLFBFCGMBL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid HGLACCHJFEM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid HMLBMEOOKJP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid EGKNEFIPJCP;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DHCAGGIKLMK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HMBBEKHOHAL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid KEDONIKNEGP;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ANHKMBDCHCG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid MCCCBLNDBJF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OPLAGJBHEBA;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid FGHFCPAOFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid FALGFKFNLDA;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid FFLGPEODMKH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EBBKKNMFGFC;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid EOHHLCHNNKK;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid IOOALKMKLEH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid KANKBAMAOPE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid GNDDLDFIMNO;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BHINPAOMJAK;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GDGIGOOBDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid LEBJOCHLGFK;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid DDNKNJJIINN;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid KPEBENKOEIO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid NFLOCAPIEKI;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MNHMEHJHPAL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid JOIEADDDCKK;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid BNGNAHEAJKF;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid CLPNCCMDBHN;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IFNLGAEFDPC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid AAKNIADJFLM;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid DEFAMDOJHLE;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ADDIKABNNBD;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HKDFDJHGPPK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid IAAEAAKECPG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid LEFIGPBOHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid BLMBDJLCFEF;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid JCKFOOOJCHN;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid NLOAOFODLIJ;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid LHGLNJMKBEH;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PMLDGKLAJJI;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid APNCHGODADL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid AKFDDNLKOEA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid GCCAINDEPNC;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid PCJHLHLNKBF;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid ENKBDNKGHCG;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid JAKMNELFABH;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid AKCAPPBEGCE;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JEEIKLPMPOD;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid KJIGMCAJPOL;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PBBOPNPNIPF;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PMAOBKDJHCL;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid AOIEOHIBBBG;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IAEGAPJPDMM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PIHJCNGDKCH;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid MJLADKHBBHH;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KCOJLJNELJB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid AHLGMICCMKP;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid HGHBLMFJPJB;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid EMAOJLOBAPE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PCGMPHLIEMG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid LAFDAFDODCD;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid DJKIHBLIIGE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LJJAEJPGKBD;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid ECIBFLBBKIA;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid ONKDIBIADIJ;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MDCCLOFCJDN;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OHBGCDCGDKN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid KFCKGENCMJO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid OJMNPIEBFEM;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid FCFIAKJLGGH;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid DPLACODHCLN;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid EOIMEOKNLMF;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid FCGMPMOOGEM;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LKBOCJFCDLN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid KLHDAJNMGDM;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid CEODACIMEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid GGKDAMKEKBP;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid NMLAAPGKLOM;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid NDAEAHEPJDG;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid KHBMJOELBFK;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid PKFIEFAPAPH;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid DLEGKIHGELP;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JDCMCOGEGPI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid CFJKOMLDCOK;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid MJFDEKNPAMG;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid DFNPILLJJDK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EDJICGNPPLF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BFFFHAFAEBH;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid PJNLMJCKCJN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid COOKJNFOGOJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid NKCHGNMJPEF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid BBIHPNAOHJN;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid JFLEGMNFHGN;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid NICFHCFOIBM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid KIPODMGFLMH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid GJBLDBPFGKB;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid IIPIHKOGPHC;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JEABMLIHAKC;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid DFNJDBAKKBM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid ABHFKFOPAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IMLHMGNCABI;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NPAMBLAHJFG;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid AMPIEMABLNF;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid MLIDHNGGDAK;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid MCLDJPIHFBK;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid HMNBOIGMAOI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid AFPMCDOCNFA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FIBLNFEGAIH;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid MAFMNMKGJJB;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid NACGJPGPFFI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid EPGPIAFGION;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid IHPHICHNGHO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid DMKBODJFEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HAPGCJAPIJE;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid KCPFCGEDKKF;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid OOIIFOHKJPE;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DAKCGHLCMKC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid PHHFJJNPOCF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid OALOLINKKEO;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid NJLMBMHBBJH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid HFEKFHGDPNJ;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid CPDLCLDKHMP;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid IACNCPDOIDE;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DBCHNGKABMN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid NKFEFFFAKBH;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NLEPNPEMAGA;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid CHADIKMEFOC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid KMHCGEKEALA;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid FJGMJLCHJGG;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid LODFOMGOIPI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid GJNMCIADMHA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid NMJOFAPMDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid BNLOOHFGCDE;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid LLNALFKNCJJ;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OCHMHOHIJMF;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid DGGLNHDLJAE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid LBADHPDBMKB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid PLFEIHLIGOB;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid EFDKEFFBIHN;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid LNIHAOKBDOF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid IEHHDGBPPMO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid OFIMPGGIELL;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid HHBOOLOBGBM;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid MJIAKJJCMLA;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid DNKIBFBKINB;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid EKCGDEFEMBK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid LONMEPEHAPE;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MDCJNPIIGFA;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GJLMDACAMGK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FCBKHFONFCI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid EGEJOIJLGLE;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid AFMBHONDMGH;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid FOIKANFFDLA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MLEEGOHJDGF;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid KAJPEPMHBGD;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NNONPMCAHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KKCJBPDPJLO;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid JIDMIADFDFN;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid EBNFABEFKMD;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KDGDBDFBGMK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid FAPFBGLEIFC;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BCKEACCNKFO;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid AHBIBLLMLGF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid MGIJKEFBJML;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid OEEBMBDDAPC;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GPOMOGMKHNF;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid PCGAKKNHKGF;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DJMNEFHKAAF;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid FIEOIGNFHDA;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid IDHHBMOOBHK;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CKKCKJGDJHF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DIADAGAONAJ;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid BMJGOCAEAHI;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid BHAGKPNNDPD;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid LNFMBIHPBJC;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid PKBCBGGFGAO;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid NNNAKFOBDEE;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid HEGOMOGGGNK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OHCNNAFBBGB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NOAGBGAIKFD;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid POIFOGKJAPO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PHEMMEHOEKD;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid IJOLJEPCJBD;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid CKDKNDNPDBK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid JPLPHLNILEC;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid JEPFNLBOFCB;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid EKPNDCPLDIK;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid KAPBELMKLFF;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid MCLHPJLPKIK;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid EHCOMAGPLMN;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid PJJMLCEKLPN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid FPDHKGDFPGA;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid HEFEJOFFCGD;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid DBKBLBGANKL;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid IAOMKIKPPNF;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid NLPGPLJPPDO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid PBMIJPHDFHP;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid AFGANIDCKII;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BJMMEMBOIOP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FEOAKCJLCIM;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid DPKDIDHFLCM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NJINIBOACDN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JEOCKNHNMKL;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid JCILOJJKKJN;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid NEBHJCOLJDN;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid EPIJHGJLMOE;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KJFOLOHCAPK;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid PBEDKPICLGI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid DOCGIKHDLHA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid ICOJEOJMKID;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid EBBEMILKCAE;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid APLIKGLKDPD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid PFPOCGBKNAH;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid MNCAEFFPMCH;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid GOAFMLIHCPA;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid PEGHBGIHOOH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LCJKHMDALDI;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid GEJDOBLBIIM;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid EBNBELDOIFC;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid BEDDEMJNOBK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid MKPPDONEINA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid CJHIAILDLGL;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid JFMLGPIJGPP;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KGLMEKEHDDM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CJPBAICFEBD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid MFMAFOFGLPL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid HGLAJJBCGIL;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid OPHIDAAOAGL;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid HFCCABBMGBA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid NPAEHJEJJLL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NHKCJHFCAIE;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid NPDFABFGNGK;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GJHFCANPKHE;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid HEBNGIKADKN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid BAAICMLMONH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LEEPEHCOEKJ;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IOGGAKFDLPB;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FBAFCPBEPPI;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NAOGEGKLBDG;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid LGOMAIBEDAG;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid KIBPLOHMHKH;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid IMKLHNPBDGD;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid LPBJEBEEEMO;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid HOACDGEBLHB;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DHJOCKNOILE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid HJHJNGOIJAI;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid PFJAJPLGADE;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid EIDAHNJCFKB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid OGLBHICINKE;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid APHBMAFDHDA;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid FKMFEDOHFEF;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid MLLHICBKHGK;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid BHBKFDHFIIN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PFJBBMOBPOM;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid KAHFGFHNELK;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid ECBCGIHNHFM;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ICPMBMDMOBJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid NJONEJBOENM;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HJGDNMJNENG;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid APIEKHMDPBB;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EEKDJNCOCGO;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid CKBFMNMNNGP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid DLCICMLLCOM;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid IGDDHGEPJDP;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid DHFNNALENOD;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FMHLJPJEJIB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid MBFEPIFFEFH;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid CKECGHDEIJB;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NCKLKCALCIA;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid JONGJPBDBDD;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid OBHEHBNBAJC;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid LBMMBCFLJCF;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid BFAJMBMBGMN;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JGIKCMFKOPO;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid LFFLMMFJLLI;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DJPBOPPEHON;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ENKGAABJFLI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid PFJFMGPOEHB;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid LGHOAJBNFHC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid ALADLDBBKOO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid IBKGKENABKO;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid AEBOEELJCMH;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MPFLGAPOBJH;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid BONHOEBBOPD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid FBBHBKLKEIO;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid DBMFDPAAIGN;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid BEIPCBIEJEG;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid PLEMMFDJGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid PLMPNHBOLBK;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid IPFBKPFNIAE;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BKKKOBAODIF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid BHCFACBIBFN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid GPOGENDJLBB;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid FFLDDLDBBOK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid FNAKGPFBEOO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid KIDCNHCCKCB;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid DMHPNGIDDNB;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid OKNHGGKGDAN;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid DEPBDLNHMAP;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid BOPAPPCKHIF;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid INJDOMOPMGE;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PKAGOKFADPE;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid JNGPMGCDALO;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid DKMFCPDMAEK;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FFLFOGGIIKP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid DDFJIFMNDHL;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GLAICCNHPJM;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KNOAJFNLIHL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid MGLLEDFCALM;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GPIEMDBGMJA;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid OKAAMEENDAJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid DFOMFHKFGME;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DFMJJNBMCOB;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid JAMNBPLEBDI;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid IBDOECMLFEG;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid LDOOBHLPIBM;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid IPOJOIGPACG;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid BPCMANNOMFF;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BFOAKPFNMNN;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid NIEAEMMBJJP;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid OKNHFCIADGC;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid AJCKOFLGNCK;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid MGNEKPPMAEF;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NCKKLGBLCCJ;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid BIPOFDDCOJD;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CJFCGFGIMCK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DPNHJJJHPFJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid GNGAIJIBMHB;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid BPOLDOMPONI;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid ALGEHJKEHIL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PEEPFMKBMNF;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid FJGFMIHGKDK;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid NOFOEMEFPPC;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid CDDKLKJAGEC;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid BKLHKMFACIH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PLHCAJHCJNH;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LNNMCNGLJIH;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid CPKCAHHOFPP;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid GINFKFEIGIK;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid HGNDNGCJLEO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid NHJOMIJFCJO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HMFONOEBBPB;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid BNPOBPCMOCE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid DFJIONBEHEC;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EMIBNOFCJOP;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid KACFOAOCHLB;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid JHGJOAOKOEJ;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid EOCMAEEALBM;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid FCMABBMKEML;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JJBBDCINBKL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OECJJLEFKIK;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MMMBLMMDILH;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid BJCPFGKCPAI;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid NLKMPMCGGEF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid BLFOGOGBGPO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid GPBDDECMDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CGEFJJPJIOG;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid DLAGJGAOGJG;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PNGBJBFMIPE;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DNHPHMHBGAM;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid AOLADJECENE;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid NIJHADBKDFK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HKKAOACFOLK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid EMCCOCCHPPO;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ALOKCCHHGEK;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid DLAFIJEGGPH;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid DCFAJOKKBGI;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid CKPFHHAGHJI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid LEIJLMDOGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid ABNKIANOLBK;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid PHFJFKIHHMB;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CMAPJFBHKHB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid DEBADGEMPPF;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid POOAOBGJEAA;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid FKCBBPALHKJ;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NHDPEOMGCOA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid LGEKIOOCPAN;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid KPDHGNFJIFE;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid ELMLEMCGPBP;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KELKCANCADK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid DAFGADOCLOP;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid NJBCCMFNMOC;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid DJKBFNABBHI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LHPACBNBNPE;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IKBDJNGKFIL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid GIPFOEFOACK;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid MKHFJHBGOHC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid GNIPNOBHLDP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid MKPJJCAIDIP;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid LOGJEEJJHFN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NALBIPHMHHK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid KPCPMHCGEML;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid GHKEMNDLBFO;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid GEBFGCHGNON;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid EBAHDIOJPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid GNHALMPJGIE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid COKPMALOKAM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid NMLPGDJNJAC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid NPLLHBDHAKB;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid EMFJFHNHAFN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid PFKJLBDFGED;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid CJEBIKECGDA;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BBPEGOPPKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CKEABDKMCCF;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KLKKNDOLLPJ;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid GFGGEFJFHJK;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid MKKMCJAGCCE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid AEDHCDKAFNG;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PDNMDKAOJOK;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PHDOPLEBAEF;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid FNFBPFDALFH;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid EICNBBJBHCH;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EFKJJEHIALK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PEADGOPILFG;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LEHBADKOANL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid MNOAHMADGOG;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DMFEDKNLBCB;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid IEAKLMOIKHO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid BBKDNGNANAK;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid MCAGOKHFACB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid MHBMKCCANON;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid EHLGELGONNG;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid PEGNEKFFMPC;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid HKFADBKCIEA;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid DDMMPHEPFMJ;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid LGEJPNFBNIA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid KFFOKIKEGCL;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid DNKHIFOPBGM;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid JDOHLJFEEIC;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid MBNHAAGGJGC;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid LMLFPHJHHEF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid GEOMAHFALJG;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid LCOEMIDHBKK;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid KLJLIHNJJEO;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid OIHJEEFMLLN;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid LAAONCGDDLL;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid MPDIEOMGCAM;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid LCNADCFGFBA;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid DOMKNHGBKIL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DMHCOGOOJBG;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid LHCGAKGPLAL;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid NEJDNOCPJDC;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid CHDOPMAINFH;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid MDGJBMCDFNE;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid BFHCMBPGFMD;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid HKCABAEMILA;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid KDJFJDHNDNJ;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid GDLDANMFHDO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid CHIINCLNOCL;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid ILKFMBFGPHJ;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid NPOKPFHCEAF;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid ECELDOACEGD;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid NKHIJHPOHNO;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid BIFNAGGPFMG;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid EOBNJGLBMCO;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid INFADJJEGCJ;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid GFIGJDNLJIH;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid KJGGOPELKEL;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid FDKOOPHKHMC;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid ABHDODJGBMK;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid EMBEIMGDENO;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid GIHNJEFJIAO;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid BJNNNKBJJFE;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid DFIJBJDOMAN;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid FCOBBLMNLOL;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid FGNMBCMCFCN;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid JJOGFKDCIEJ;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid IFIBKGIICKO;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid FKAOJCLOOKL;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid GFKALOAPFCN;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid BBIPNLPNFBO;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid AONGEAEMHGE;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid ONNJNFJNDJD;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid CJKHDMLIOGK;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid HGLAMFLKILK;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid GOJNGCCIHMA;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid IKDAKGLFPLH;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid AHJDLFHHIPF;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid ALGGOEGNJKG;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BKNJNFAOBFP;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid EMENGMAMCEI;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid BJJOLGAEBCL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid EEKLIKKCJGM;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid GNNECEKMNOK;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid NOFKMIJBMCJ;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid CBILJBLNIDM;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid OKLMJGOGFDE;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid ACFDOKJFNGB;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid LAPJPFGALOM;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid CIMBCIEBAOB;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid MEEKLFAEOGO;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid JMJCOMODFBK;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid CCPDGNLHLAC;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid LPGDHENCLIG;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid MDKHOOHEFAO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid AFCGJONBDOJ;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid JPJLDMHHHHF;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid ALIKPJCJFFO;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid MKHNKILEILC;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid FKHDGKOLNFB;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid LLCDIFHMNMB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid HEMBKGFAFBI;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid PKBFKKNBHML;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	public static readonly Guid COJOKOCJPGH;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public static readonly Guid GCBBJGJKLFG;

	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public static readonly Guid HKHMIIDAMDG;

	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private static readonly Dictionary<Guid, GDAPMDMPHOL> MDPFHALAAFO;

	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private static readonly Dictionary<GDAPMDMPHOL, Guid> NGLICCMAKDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, GDAPMDMPHOL> DDBPHMDILNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5F60", Offset = "0x6BD5160", VA = "0x186BD5F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<GDAPMDMPHOL, Guid> BLGEMCDAODC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD5FB0", Offset = "0x6BD51B0", VA = "0x186BD5FB0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ACEIBGPPEGI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5B80", Offset = "0x6BD4D80", VA = "0x186BD5B80")]
	public static bool OJNECFDAFJE(GHOJPFLKLMI ECOPCJEOHAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5BB0", Offset = "0x6BD4DB0", VA = "0x186BD5BB0")]
	private static bool OJNECFDAFJE(LJHEJCOGDAJ EFECIMDANAO, GHOJPFLKLMI ECOPCJEOHAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HDMENMLEJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly MONPBPLADEK KALLHCKJMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IEnumerable<EJACNHLCCNH> BCHJDPKHCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly IReadOnlyList<EJACNHLCCNH> LPPMFJPFOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly GJCCLPKGONN<EJPHCCLFAJF> BNMMBPEAELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly IReadOnlyList<JFDDFNFCNKH<JKFBFCDNFMP>> OCELMPGNGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly ByteString BMMEEJHEIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	public readonly INGPKEPCHCJ KAIICKDHCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	public readonly bool JDBNMHDPPNF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE620", Offset = "0x6BED820", VA = "0x186BEE620")]
	public HDMENMLEJBK(MONPBPLADEK LEGIOODPGCD, IEnumerable<EJACNHLCCNH> CFILLPNNBGA, IReadOnlyList<EJACNHLCCNH> EOHHKLFMCLK, GJCCLPKGONN<EJPHCCLFAJF> HOLODOCCCKK, IReadOnlyList<JFDDFNFCNKH<JKFBFCDNFMP>> AMBCHLBJNLM, ByteString IEGFEHLJHFH, INGPKEPCHCJ OHKAIEHGIJM, bool AOOFOKACNJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JAAPBLIEILE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(GCIHFAHHGNC LJIEGDEDOHM, [Out] Dictionary<int, int> OPNBHKFPICF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(DODBLCJEJDB BLCELCAHLFI, LMHBHKPKHKI INIPJDMNOMG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FFHLGKAPDCK : HHCEHBJDAKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	public readonly Guid KEDCAKCCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly Dictionary<Guid, Guid> EDGACPJENNF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KDNEEEGKPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7210", Offset = "0x3BD6410", VA = "0x183BD7210")]
	private FFHLGKAPDCK([In] Guid PHDFEODMPOG, Dictionary<Guid, Guid> LJFFNCGCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE310", Offset = "0x6BED510", VA = "0x186BEE310")]
	public static FFHLGKAPDCK MIFIOLMMIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDE10", Offset = "0x6BED010", VA = "0x186BEDE10")]
	public static FFHLGKAPDCK FDKKNNILIFE(IReadOnlyDictionary<Guid, Guid> IBIHOJGCANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDF30", Offset = "0x6BED130", VA = "0x186BEDF30")]
	public static FFHLGKAPDCK HJFPDEPKDEA(IEnumerable<KeyValuePair<Guid, Guid>> IBIHOJGCANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE260", Offset = "0x6BED460", VA = "0x186BEE260")]
	private static Dictionary<Guid, Guid> KNLGFHKEMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE3A0", Offset = "0x6BED5A0", VA = "0x186BEE3A0")]
	public void PCEGPFKIOFE(IReadOnlyDictionary<Guid, Guid> IBIHOJGCANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDE20", Offset = "0x6BED020", VA = "0x186BEDE20")]
	public Guid HENAMDIBPAD([In] Guid KGBBBBHDKAF, bool EIHGLOHPALC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDDA0", Offset = "0x6BECFA0", VA = "0x186BEDDA0")]
	public bool BAOGPOJBOJO([In] Guid MHMAFIBKDFF, [Out] Guid BMHOIDJAGCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDDA0", Offset = "0x6BECFA0", VA = "0x186BEDDA0", Slot = "4")]
	private bool ECFMBGBNNOA(Guid MMPBCCIBPMB, [Out] Guid OPBMEKKEPKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GLDJNMHPAHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HDPKHAJIFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBKBNNNFJGC(ByteString JBEAHJPLJPJ, FFHLGKAPDCK DAGNBMDBOLL, [In] UniformTRS HGOKNIFGHAK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FBMGGIIEAJO
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
public class JDPPDCGOCPA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x94C410", Offset = "0x94B610", VA = "0x18094C410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CHEABLNPPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1313520", Offset = "0x1312720", VA = "0x181313520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long EBIIFAJMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEF50", Offset = "0x6BEE150", VA = "0x186BEEF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68C8710", Offset = "0x68C7910", VA = "0x1868C8710")]
	public JDPPDCGOCPA(long NDEFEFEFLCE, long KHBJJIAKALK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CDGJOHFLNPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private Dictionary<Guid, JDPPDCGOCPA> IBFGCKEFEJD;

	[Cpp2IlInjected.Token(Token = "0x4000500")]
	public static Dictionary<Guid, int> NFBJIKIIFBE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long DFPEDPHFFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1313520", Offset = "0x1312720", VA = "0x181313520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KDFIBGJOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99CD10", Offset = "0x99BF10", VA = "0x18099CD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6000", Offset = "0x6BD5200", VA = "0x186BD6000")]
	public static CDGJOHFLNPN EGJCGOFDGIG(MONPBPLADEK DKCKMHIMFPJ, JFDDFNFCNKH<EJPHCCLFAJF> CIBMHFLHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6670", Offset = "0x6BD5870", VA = "0x186BD6670")]
	private void MFFBNNCGCNL(NJEHGCGMDBB MOPDELCEJCO, long COIJLGNINGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA2E0", Offset = "0x6BE94E0", VA = "0x186BEA2E0")]
	public CDGJOHFLNPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EHONKBGDFIB
{
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	public static readonly HashSet<GDAPMDMPHOL> DMLHDFIMAME;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FFNKJPBHLPP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> PKFEOBFJBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> JPDHOBBKEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
	public FFNKJPBHLPP(IReadOnlyDictionary<Guid, Guid> CEAKLBEEEPN, IReadOnlyDictionary<Guid, Guid> PPHJIFHFJHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EJNFCAADLAH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MDMHMJCKJHL : IEnumerable<EJACNHLCCNH>, IEnumerable, IEnumerator<EJACNHLCCNH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private EJACNHLCCNH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private CKNINEKHDGO spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CKNINEKHDGO <>3__spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private NNCPKBNPKLH spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public NNCPKBNPKLH <>3__spawnParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private EJACNHLCCNH System.Collections.Generic.IEnumerator<RecRoom.Protobuf.PersistenceViewData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9D6DA0", Offset = "0x9D5FA0", VA = "0x1809D6DA0")]
		[DebuggerHidden]
		public MDMHMJCKJHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF000", Offset = "0x6BEE200", VA = "0x186BEF000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF2D0", Offset = "0x6BEE4D0", VA = "0x186BEF2D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF110", Offset = "0x6BEE310", VA = "0x186BEF110", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EJACNHLCCNH> System.Collections.Generic.IEnumerable<RecRoom.Protobuf.PersistenceViewData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF110", Offset = "0x6BEE310", VA = "0x186BEF110", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BEACC0", Offset = "0x6BE9EC0", VA = "0x186BEACC0")]
	public static CKNINEKHDGO EDJKAHOLOIP([In] HDMENMLEJBK IPCFJMJEBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BED160", Offset = "0x6BEC360", VA = "0x186BED160")]
	private static void LDPNHMLPGDD(CKNINEKHDGO LNKCBGOFPCN, [In] HDMENMLEJBK HKKIDEGEENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB730", Offset = "0x6BEA930", VA = "0x186BEB730")]
	public static KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI> IFCFJGGFFKF(CKNINEKHDGO LNKCBGOFPCN, NNCPKBNPKLH HKDIFCOAHNK, FFHLGKAPDCK? FDKCFEIMLDA)
	{
		return default(KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB170", Offset = "0x6BEA370", VA = "0x186BEB170")]
	[IteratorStateMachine(typeof(MDMHMJCKJHL))]
	private static IEnumerable<EJACNHLCCNH> GGDONGMGDGC(CKNINEKHDGO LNKCBGOFPCN, NNCPKBNPKLH HKDIFCOAHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BED830", Offset = "0x6BECA30", VA = "0x186BED830")]
	private static void LMDKDDGDEEA(CKNINEKHDGO LNKCBGOFPCN, FFHLGKAPDCK? FDKCFEIMLDA, NNCPKBNPKLH HKDIFCOAHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BED7C0", Offset = "0x6BEC9C0", VA = "0x186BED7C0")]
	private static void LIHGOOFCAGG(CKNINEKHDGO LNKCBGOFPCN, NNCPKBNPKLH HKDIFCOAHNK, IReadOnlyCollection<ByteString>? DMLAMNADGFD, IReadOnlyCollection<ByteString>? FKFFDIPBDBD, IReadOnlyCollection<ByteString>? BOLKKHDDDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA620", Offset = "0x6BE9820", VA = "0x186BEA620")]
	private static bool DDOICIPPECD(CKNINEKHDGO LNKCBGOFPCN, DODBLCJEJDB BLCELCAHLFI, NNCPKBNPKLH HKDIFCOAHNK, [Out][NotNullWhen(false)] string? BAHJDCJDFHC, [Out] Dictionary<int, int> OPNBHKFPICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDAC0", Offset = "0x6BECCC0", VA = "0x186BEDAC0")]
	private static Dictionary<Guid, LJHEJCOGDAJ> OAEFEKPHODM(CKNINEKHDGO LNKCBGOFPCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA580", Offset = "0x6BE9780", VA = "0x186BEA580")]
	private static void ADGPFJIBDHG(bool FKAPOAAECFL, EJACNHLCCNH BDKKOCLKBDN, Dictionary<Guid, Guid> ADCAFLHGLKP, FFHLGKAPDCK FDKCFEIMLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAE30", Offset = "0x6BEA030", VA = "0x186BEAE30")]
	private static void GBBEGGPBIBF(EJACNHLCCNH BDKKOCLKBDN, Guid FBKBPKIAJNO, HEEPAHOGMNL? ICJEOBHJJBE, Dictionary<Guid, LJHEJCOGDAJ> CAGPDOKNLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB280", Offset = "0x6BEA480", VA = "0x186BEB280")]
	private static void GGODIMFHJME(IEnumerable<EJACNHLCCNH> COPDBGFCOAP, IReadOnlyCollection<ByteString> DMLAMNADGFD, IReadOnlyCollection<ByteString> FKFFDIPBDBD, IReadOnlyCollection<ByteString> BOLKKHDDDFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NNCPKBNPKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public bool FKAPOAAECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public INGPKEPCHCJ OHKAIEHGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public HEEPAHOGMNL? ICJEOBHJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public HEEPAHOGMNL? CIEFAIFEAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public MONPBPLADEK OCNCAJEFKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public FBMGGIIEAJO OEMEFBCALEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public JAAPBLIEILE IGAJNMMJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public GLDJNMHPAHH BCIDJEECECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public JFDDFNFCNKH<EJPHCCLFAJF> GFPHECKFHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public JKKGEHGGKGE ALCLHEODPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public List<EJACNHLCCNH> GNOMMDOLIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public Dictionary<string, object> IEDAMOHBBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public KOLCINMHAPJ IPFJOENFFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public bool FDLJJKLHFBO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KPBHDKDDEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF320", Offset = "0x6BEE520", VA = "0x186BEF320")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct HEEPAHOGMNL
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private const float EKHFPKHLBEP = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public Vector3 FJFKFIAGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public Quaternion MBMKLLFOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float DKGNMCFDBJD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Matrix4x4 IHPLFKPFCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEA70", Offset = "0x6BEDC70", VA = "0x186BEEA70")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public UniformTRS EFALECPMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEA30", Offset = "0x6BEDC30", VA = "0x186BEEA30")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xDFBB70", Offset = "0xDFAD70", VA = "0x180DFBB70")]
	public HEEPAHOGMNL(Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DKGNMCFDBJD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEE80", Offset = "0x6BEE080", VA = "0x186BEEE80")]
	public HEEPAHOGMNL(UniformTRS HLKIPLIPJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEB70", Offset = "0x6BEDD70", VA = "0x186BEEB70")]
	public static HEEPAHOGMNL PJLJAJODMDG(HEEPAHOGMNL MBOJNCFILKL, HEEPAHOGMNL PHGODHPMHAK)
	{
		return default(HEEPAHOGMNL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE830", Offset = "0x6BEDA30", VA = "0x186BEE830")]
	public static HEEPAHOGMNL CFMDMKLGJEH((Vector3, Quaternion, float) LJIEGDEDOHM)
	{
		return default(HEEPAHOGMNL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE6B0", Offset = "0x6BED8B0", VA = "0x186BEE6B0")]
	public static HEEPAHOGMNL CFMDMKLGJEH(Matrix4x4 EHBDGHKCPJG)
	{
		return default(HEEPAHOGMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEDF0", Offset = "0x6BEDFF0", VA = "0x186BEEDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE8E0", Offset = "0x6BEDAE0", VA = "0x186BEE8E0")]
	public HEEPAHOGMNL GPILJMEBBOM(Matrix4x4 PKBNMONECNF)
	{
		return default(HEEPAHOGMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE9C0", Offset = "0x6BEDBC0", VA = "0x186BEE9C0")]
	public static HEEPAHOGMNL JKMOHKPLMNA(Vector3 FJFKFIAGEPM)
	{
		return default(HEEPAHOGMNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE850", Offset = "0x6BEDA50", VA = "0x186BEE850")]
	public readonly JMFFCBMGCHD GAGMLADPNOB()
	{
		return default(JMFFCBMGCHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NLEOADGKGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA0E0", Offset = "0x6BF92E0", VA = "0x186BFA0E0")]
	public static HEEPAHOGMNL BPDPKGDOCAP([In] this JMFFCBMGCHD AEFKHDNCNFD)
	{
		return default(HEEPAHOGMNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ILMEKCOLOEB
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	Circuit = 0,
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	Other = 99
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct GNFOLFHBDDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public readonly CGPAPADLBPO BNDKOPLNLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private readonly NDNNGNKGHFF HKIHPGKHCOF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1070F90", Offset = "0x1070190", VA = "0x181070F90")]
	private GNFOLFHBDDI(CGPAPADLBPO MBLCENENKDK, NDNNGNKGHFF HMMADODBHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8900", Offset = "0x6BF7B00", VA = "0x186BF8900")]
	public KPFAPPGFMLF MDIDBNHNKOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8A20", Offset = "0x6BF7C20", VA = "0x186BF8A20")]
	public static KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI> MIFIOLMMIDE(CCFMJGNHIMA<EPFCCNCFAEJ> HMMADODBHFN)
	{
		return default(KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8970", Offset = "0x6BF7B70", VA = "0x186BF8970")]
	public static KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI> MIFIOLMMIDE(KPFAPPGFMLF HMMADODBHFN)
	{
		return default(KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8AD0", Offset = "0x6BF7CD0", VA = "0x186BF8AD0")]
	public static KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI> MIFIOLMMIDE(string LFNBFALPBBN)
	{
		return default(KJEOKHCIBGM<FFNKJPBHLPP, GNFOLFHBDDI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CGPAPADLBPO
{
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CFIODBEIONC : IDisposable, NDLOIOCPGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private NativeList<LINEJHJGLFA> AIMJMMNOFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private float PNHNDHJKHMF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AKFFOEJDADO FFEPGKCKNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		[CompilerGenerated]
		get
		{
			return default(AKFFOEJDADO);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x897BE0", Offset = "0x896DE0", VA = "0x180897BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DGFLGFAINHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3560", Offset = "0x6BF2760", VA = "0x186BF3560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BBIALNKACOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2BE0", Offset = "0x6BF1DE0", VA = "0x186BF2BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public List<CMNLFHGNMBJ> PBGELLOIMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int FJIIFNDJPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6BF42C0", Offset = "0x6BF34C0", VA = "0x186BF42C0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GIHMPACPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3D90", Offset = "0x6BF2F90", VA = "0x186BF3D90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4740", Offset = "0x6BF3940", VA = "0x186BF4740")]
	public CFIODBEIONC(AKFFOEJDADO CBEJFPKIGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2BF0", Offset = "0x6BF1DF0", VA = "0x186BF2BF0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BF36A0", Offset = "0x6BF28A0", VA = "0x186BF36A0")]
	public Vector3 GOLMEMHCJJB(int JJIKJNIEJIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3570", Offset = "0x6BF2770", VA = "0x186BF3570", Slot = "6")]
	public Quaternion GAAPPODLKPJ(int JJIKJNIEJIJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3B70", Offset = "0x6BF2D70", VA = "0x186BF3B70", Slot = "5")]
	public Vector3 HAJHDPFFKAP(int JJIKJNIEJIJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4370", Offset = "0x6BF3570", VA = "0x186BF4370", Slot = "7")]
	public float OFEJABHMNJA(int JJIKJNIEJIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2C50", Offset = "0x6BF1E50", VA = "0x186BF2C50")]
	public void EDPJHIJFEMI(Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DLNPAPKJAEH, bool HHHFMNEGJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2B80", Offset = "0x6BF1D80", VA = "0x186BF2B80")]
	private bool BMJAKBAGPEK(int KKILHBCJCKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3C10", Offset = "0x6BF2E10", VA = "0x186BF3C10")]
	public void HEKCGCGDHKB(Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF40D0", Offset = "0x6BF32D0", VA = "0x186BF40D0")]
	public void JPMKKFKDFBC(int KKILHBCJCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF43D0", Offset = "0x6BF35D0", VA = "0x186BF43D0")]
	public void OOODEGEAJCH(int KKILHBCJCKM, Vector3 FJFKFIAGEPM, Quaternion MBMKLLFOFFL, float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3F20", Offset = "0x6BF3120", VA = "0x186BF3F20")]
	public void IBKGHLLDGMH(int KKILHBCJCKM, float3 FJFKFIAGEPM, quaternion MBMKLLFOFFL, float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BF45F0", Offset = "0x6BF37F0", VA = "0x186BF45F0")]
	public void PHGCHDPEBJK(int KKILHBCJCKM, Vector3 FJFKFIAGEPM, float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4160", Offset = "0x6BF3360", VA = "0x186BF4160")]
	public void LFGMNEIGHLE(int KKILHBCJCKM, Vector3 DJCLDHHAKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2380", Offset = "0x6BF1580", VA = "0x186BF2380")]
	public static Quaternion BKCMLIHJNPI(Quaternion CMACADCFGJN, int KKILHBCJCKM, float OBPNKDPIJIB, NDLOIOCPGDC DHFOOLOHMJI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1EF0", Offset = "0x6BF10F0", VA = "0x186BF1EF0")]
	public Bounds BCDNIIJDOLA(Transform PKBNMONECNF)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4300", Offset = "0x6BF3500", VA = "0x186BF4300", Slot = "10")]
	public virtual void OCHLJAKEOBE(bool MNIDKLJNGFF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4520", Offset = "0x6BF3720", VA = "0x186BF4520")]
	public NativeList<LINEJHJGLFA> PCCLJBDLJMH(float JNHPDBMNMGD = 1f)
	{
		return default(NativeList<LINEJHJGLFA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CMNLFHGNMBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public float3 LFHLHOFOIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	public float OLGFJNHDAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	public quaternion GKHLHBNDJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4D20", Offset = "0x6BF3F20", VA = "0x186BF4D20")]
	public CMNLFHGNMBJ(Vector3 GGLFFACIDJM, Quaternion CMACADCFGJN, float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BF47D0", Offset = "0x6BF39D0", VA = "0x186BF47D0")]
	public Quaternion HDLLIFKJFGD(Vector3 BHMBDKAILFL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4A30", Offset = "0x6BF3C30", VA = "0x186BF4A30")]
	public CMNLFHGNMBJ NDLMDKPFJBK(Vector3 BJNABGKHLFI, Vector3 LBNOEOMFMMI, Vector3 BEPMGBBHIHH)
	{
		return default(CMNLFHGNMBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4890", Offset = "0x6BF3A90", VA = "0x186BF4890")]
	public PLOFGIKDEHO HHPCELJLMHI(Vector3 BHMBDKAILFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class GIJGKGEGDGB : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6E10", Offset = "0x6BF6010", VA = "0x186BF6E10", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6EF0", Offset = "0x6BF60F0", VA = "0x186BF6EF0")]
	private void GFPBGLCIAKO(Dictionary<Guid, Guid> CCDLLLDOHAI, EDMKJEMKILM JGPMJPHNEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6E90", Offset = "0x6BF6090", VA = "0x186BF6E90")]
	private void GFPBGLCIAKO(Dictionary<Guid, Guid> CCDLLLDOHAI, LIHDOGICPGH JDCDLONICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF74D0", Offset = "0x6BF66D0", VA = "0x186BF74D0")]
	private void GFPBGLCIAKO(Dictionary<Guid, Guid> CCDLLLDOHAI, OGCMONDAGMD CGAIAKAMDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GIJGKGEGDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NGPCJDOAFPK : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA030", Offset = "0x6BF9230", VA = "0x186BFA030", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public NGPCJDOAFPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GGEKDKHALCG : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6CB0", Offset = "0x6BF5EB0", VA = "0x186BF6CB0", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GGEKDKHALCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MKPODPPCDLI : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9D30", Offset = "0x6BF8F30", VA = "0x186BF9D30", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public MKPODPPCDLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ILOCDBDPBCE : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8D40", Offset = "0x6BF7F40", VA = "0x186BF8D40", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public ILOCDBDPBCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KMLGHHCNDDI : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9880", Offset = "0x6BF8A80", VA = "0x186BF9880", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KMLGHHCNDDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MCPCBGPFPLL : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9BA0", Offset = "0x6BF8DA0", VA = "0x186BF9BA0", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public MCPCBGPFPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FNEAKIOFOHP : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6BC0", Offset = "0x6BF5DC0", VA = "0x186BF6BC0", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public FNEAKIOFOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class BJIJEEBFOFK : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1D40", Offset = "0x6BF0F40", VA = "0x186BF1D40", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public BJIJEEBFOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class HJMAGNPJGCD : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8B90", Offset = "0x6BF7D90", VA = "0x186BF8B90", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public HJMAGNPJGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class PBHHNOCPACC : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA1A0", Offset = "0x6BF93A0", VA = "0x186BFA1A0", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public PBHHNOCPACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DIGNODEGNAJ : PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public static readonly CBMPMGGEJPF GCEFDKPKLNO;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5140", Offset = "0x6BF4340", VA = "0x186BF5140", Slot = "4")]
	public void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public DIGNODEGNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GHOJPFLKLMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public DODBLCJEJDB AIIGKGFGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public IOGMKCMHFBD DJHDKFELKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public Dictionary<int, int> HHAFNFHMNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public Dictionary<Guid, Guid> FOAJMAFAHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public KOLCINMHAPJ IPFJOENFFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	public bool JFPADJJAHEN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PLIEPIDFNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BONMDKHMLEG(BJDHHKELLMI KFFLEDGHLFE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ABBFADBNLBC
{
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private static readonly PLIEPIDFNPM[] KJAFENFGNEI;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1070", Offset = "0x6BF0270", VA = "0x186BF1070")]
	public static void KHGPHFIKMJG(EJACNHLCCNH LJIEGDEDOHM, Dictionary<Guid, Guid> KONGHOPNAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0B60", Offset = "0x6BEFD60", VA = "0x186BF0B60")]
	public static void DIOIFLAECMG(EJACNHLCCNH? LJIEGDEDOHM, FFHLGKAPDCK NLFJBJBBAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0DF0", Offset = "0x6BEFFF0", VA = "0x186BF0DF0")]
	public static void FGLNIADKKON(EJACNHLCCNH? LJIEGDEDOHM, FFHLGKAPDCK FDKCFEIMLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1300", Offset = "0x6BF0500", VA = "0x186BF1300")]
	public static void OJNECFDAFJE(BJDHHKELLMI KFFLEDGHLFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BJDHHKELLMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	public DODBLCJEJDB ACFHADFHONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	public EJACNHLCCNH BDKKOCLKBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	public Dictionary<int, int> HHAFNFHMNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	public Dictionary<Guid, Guid> FOAJMAFAHKA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1CA0", Offset = "0x6BF0EA0", VA = "0x186BF1CA0")]
	public Guid JKCPBCOIDJG(Guid KGBBBBHDKAF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KOLCINMHAPJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EBMCEJIFGAO, [Out] Guid GMNAHAKHFIO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class FBCEKBNKHAM
{
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private static readonly ProfilerMarker KJACHJMMNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly HashSet<string> DLLMIOJKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private readonly Dictionary<long, int> NMLJFCIFJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private readonly HashSet<Guid> ELKHBPHDCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IReadOnlyCollection<string> PDONKHFHLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyDictionary<long, int> PKOGIFEJGAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5460", Offset = "0x6BF4660", VA = "0x186BF5460")]
	public static FBCEKBNKHAM MJIKEFGMENP(IEALNJAENAA AICAHIPDPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BF53F0", Offset = "0x6BF45F0", VA = "0x186BF53F0")]
	public static FBCEKBNKHAM INEOLGFEPMG(CKNINEKHDGO OKKCEMEEEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5270", Offset = "0x6BF4470", VA = "0x186BF5270")]
	public static FBCEKBNKHAM EKHBONDKLOH(IEnumerable<string> DLLMIOJKDDB, IDictionary<long, int> NFNDFBGBGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6960", Offset = "0x6BF5B60", VA = "0x186BF6960")]
	private FBCEKBNKHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6A80", Offset = "0x6BF5C80", VA = "0x186BF6A80")]
	private FBCEKBNKHAM(IEnumerable<string> DLLMIOJKDDB, IDictionary<long, int> NFNDFBGBGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6420", Offset = "0x6BF5620", VA = "0x186BF6420")]
	private void OHOAPNBEIBH(IEALNJAENAA AICAHIPDPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6630", Offset = "0x6BF5830", VA = "0x186BF6630")]
	private void OHOAPNBEIBH(CKNINEKHDGO OKKCEMEEEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5650", Offset = "0x6BF4850", VA = "0x186BF5650")]
	private void NJDJHHCIGHB(ByteString? IEGFEHLJHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5E70", Offset = "0x6BF5070", VA = "0x186BF5E70")]
	private void OHOAPNBEIBH(EPHMIGNHEKE? LPLEFLJFGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BF62E0", Offset = "0x6BF54E0", VA = "0x186BF62E0")]
	private void OHOAPNBEIBH(NECNHNCODBL? MOPDELCEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5B10", Offset = "0x6BF4D10", VA = "0x186BF5B10")]
	private void OHOAPNBEIBH(EJACNHLCCNH? BDKKOCLKBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6830", Offset = "0x6BF5A30", VA = "0x186BF6830")]
	private void PDGDFNFIECI(string? CKPAOIDAPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF54D0", Offset = "0x6BF46D0", VA = "0x186BF54D0")]
	private void MKALHKNHCCG(long EEGPJCABCPF, Guid HLKLOHEIJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BF55A0", Offset = "0x6BF47A0", VA = "0x186BF55A0")]
	private void MKALHKNHCCG(JOKDLLJEFND? GCNAJGFEFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BF55F0", Offset = "0x6BF47F0", VA = "0x186BF55F0")]
	private void MKALHKNHCCG(DGHBMBILGMF? GCNAJGFEFDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct GLGMLLLMBDH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class CNABCHCGKCL : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private readonly IEnumerator<DictionaryEntry> IMIFNCDPODH;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public DictionaryEntry EJMCMJLODLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6BF4F20", Offset = "0x6BF4120", VA = "0x186BF4F20", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object KEBPHANPJPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6BF4FE0", Offset = "0x6BF41E0", VA = "0x186BF4FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public object GOGBANOMEKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6BF5090", Offset = "0x6BF4290", VA = "0x186BF5090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public object HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6BF4E40", Offset = "0x6BF4040", VA = "0x186BF4E40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		public CNABCHCGKCL(IEnumerator<DictionaryEntry> IMIFNCDPODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4DA0", Offset = "0x6BF3FA0", VA = "0x186BF4DA0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4DF0", Offset = "0x6BF3FF0", VA = "0x186BF4DF0", Slot = "9")]
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
		private sealed class NFACPCJKBAL : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x90B430", Offset = "0x90A630", VA = "0x18090B430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6BF9FE0", Offset = "0x6BF91E0", VA = "0x186BF9FE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public NFACPCJKBAL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9E90", Offset = "0x6BF9090", VA = "0x186BF9E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9F90", Offset = "0x6BF9190", VA = "0x186BF9F90", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BFA870", Offset = "0x6BF9A70", VA = "0x186BFA870", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IDictionary.this[object CPBLLDDDHEE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA780", Offset = "0x6BF9980", VA = "0x186BFA780", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA950", Offset = "0x6BF9B50", VA = "0x186BFA950", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA6C0", Offset = "0x6BF98C0", VA = "0x186BFA6C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA720", Offset = "0x6BF9920", VA = "0x186BFA720", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA8F0", Offset = "0x6BF9AF0", VA = "0x186BFA8F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA380", Offset = "0x6BF9580", VA = "0x186BFA380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA3E0", Offset = "0x6BF95E0", VA = "0x186BFA3E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6BFA440", Offset = "0x6BF9640", VA = "0x186BFA440", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
		public RoomObjectCounts(Dictionary<int, int> ABEKIOCOJGJ, [Optional] Dictionary<int, int> APFOLFBOFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA2A0", Offset = "0x6BF94A0", VA = "0x186BFA2A0")]
		[IteratorStateMachine(typeof(NFACPCJKBAL))]
		private IEnumerator<DictionaryEntry> HPCMDCDEHHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA9A0", Offset = "0x6BF9BA0", VA = "0x186BFA9A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA5C0", Offset = "0x6BF97C0", VA = "0x186BFA5C0", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA4A0", Offset = "0x6BF96A0", VA = "0x186BFA4A0", Slot = "9")]
		void IDictionary.Add(object CPBLLDDDHEE, object JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA500", Offset = "0x6BF9700", VA = "0x186BFA500", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA560", Offset = "0x6BF9760", VA = "0x186BFA560", Slot = "8")]
		bool IDictionary.Contains(object CPBLLDDDHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA660", Offset = "0x6BF9860", VA = "0x186BFA660", Slot = "14")]
		void IDictionary.Remove(object CPBLLDDDHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6BFA320", Offset = "0x6BF9520", VA = "0x186BFA320", Slot = "15")]
		void ICollection.CopyTo(Array IEIBCNCHGJN, int KINMHNEMPOD)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class LOONPAOCKOA : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x90B430", Offset = "0x90A630", VA = "0x18090B430", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6BF9B50", Offset = "0x6BF8D50", VA = "0x186BF9B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
			[DebuggerHidden]
			public LOONPAOCKOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6BF99C0", Offset = "0x6BF8BC0", VA = "0x186BF99C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9B00", Offset = "0x6BF8D00", VA = "0x186BF9B00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BF95A0", Offset = "0x6BF87A0", VA = "0x186BF95A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IDictionary.this[object CPBLLDDDHEE]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9470", Offset = "0x6BF8670", VA = "0x186BF9470", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9650", Offset = "0x6BF8850", VA = "0x186BF9650", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6BF93B0", Offset = "0x6BF85B0", VA = "0x186BF93B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9410", Offset = "0x6BF8610", VA = "0x186BF9410", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6BF95F0", Offset = "0x6BF87F0", VA = "0x186BF95F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9030", Offset = "0x6BF8230", VA = "0x186BF9030", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6BF9090", Offset = "0x6BF8290", VA = "0x186BF9090", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6BF90F0", Offset = "0x6BF82F0", VA = "0x186BF90F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x21E8950", Offset = "0x21E7B50", VA = "0x1821E8950")]
		public Invention(long MHMAFIBKDFF, int NDEFEFEFLCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8F60", Offset = "0x6BF8160", VA = "0x186BF8F60")]
		[IteratorStateMachine(typeof(LOONPAOCKOA))]
		private IEnumerator<DictionaryEntry> HPCMDCDEHHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6BF96A0", Offset = "0x6BF88A0", VA = "0x186BF96A0", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9270", Offset = "0x6BF8470", VA = "0x186BF9270", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9150", Offset = "0x6BF8350", VA = "0x186BF9150", Slot = "9")]
		void IDictionary.Add(object CPBLLDDDHEE, object JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BF91B0", Offset = "0x6BF83B0", VA = "0x186BF91B0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9210", Offset = "0x6BF8410", VA = "0x186BF9210", Slot = "8")]
		bool IDictionary.Contains(object CPBLLDDDHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BF9350", Offset = "0x6BF8550", VA = "0x186BF9350", Slot = "14")]
		void IDictionary.Remove(object CPBLLDDDHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BF8FD0", Offset = "0x6BF81D0", VA = "0x186BF8FD0", Slot = "15")]
		void ICollection.CopyTo(Array IEIBCNCHGJN, int KINMHNEMPOD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> OCHADMLOFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	public readonly IReadOnlyList<Invention> MNECCEGHAAD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public GLGMLLLMBDH(IReadOnlyDictionary<Guid, RoomObjectCounts> OMMBCBICIFP, IReadOnlyList<Invention> NLBNGOKOEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7870", Offset = "0x6BF6A70", VA = "0x186BF7870")]
	public static GLGMLLLMBDH MJIKEFGMENP(IEALNJAENAA AICAHIPDPHC)
	{
		return default(GLGMLLLMBDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7750", Offset = "0x6BF6950", VA = "0x186BF7750")]
	[CompilerGenerated]
	internal static int EMFOEPBKPEF([In] IReadOnlyDictionary<long, int> FFGPMDFPGKL, long? EEGPJCABCPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8250", Offset = "0x6BF7450", VA = "0x186BF8250")]
	[CompilerGenerated]
	internal static void NNIAIJBBKKI(int PNLGKFKLJJI, [In] EPHMIGNHEKE DEOEONBJACK, [In] Dictionary<long, int> FFGPMDFPGKL, [In] Dictionary<Guid, RoomObjectCounts> OMMBCBICIFP)
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
