using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Mathematics;
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x61B4FF0", Offset = "0x61B3DF0", VA = "0x1861B4FF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DOFGHOMICFC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PNMGAPOIIDH;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> POCFBIMIPGO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> NELIOKJELOL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string ACCKLOEFLON;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string GPIADLPJIHE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string CJAEKHINPNK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x619EB10", Offset = "0x619D910", VA = "0x18619EB10")]
	public static bool EMOKHIPDALE(Guid BNJPKMGLCKM, int BHNLBOAHKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x619EC10", Offset = "0x619DA10", VA = "0x18619EC10")]
	public static bool IOPEFBMAOAM(Guid BNJPKMGLCKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x619E490", Offset = "0x619D290", VA = "0x18619E490")]
	public static string DLGFEKMMAJP(Guid IIGMMHCLOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AFMKMJOKJIB]
public enum DPPMMAFDHEL
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
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HHKHFECFCAL
{
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid OICOPJDMEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid JGHHHLDCFIE;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid INHPDILIKDD;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid HGDCAJPBJFP;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid EGPBAIOFMPM;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid IPPJMFLFCJD;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid GDEEFMBJHMP;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid HNFIFCIFAEP;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid IONDPBJJKPG;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid DNLOHLKCHKB;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid KJABNFJKFMJ;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid DKPFLDCDFIP;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid ACMLGPNIKKP;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid JMFHCPMNILJ;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid CFMFPAAPIEO;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid BAOFIFEGGGM;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid GHPLHJBHEHP;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid MHIICODJJHP;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid KCDJDBHHDNO;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid CIGMFEKPPOP;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid MFJNPPLHCKE;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid DHGIIONHNIJ;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid JDJLNFKMAFH;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid JMOCJEAHJDO;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid LCODCEFBHCL;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid FCFOKGNCCNK;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid KGDPHGJFPCJ;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid ONOFNAHJMCL;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid JKOMKHFKCIJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid GHGBAOIPEAB;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid IHPLAGLPOHO;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid OKCFHGIMHPO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DJGGIGLLELL;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid BNPOOJMPJPP;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JDJKOLNKKAC;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid KHFENOLBIBE;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid HNOFFHHFNEN;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid HDOIIMKKEAL;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid IKPPPHILCGN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid GAIACBCOBPP;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid JBJOEJEINAG;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid BGGFDKEEFLM;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid GNEBLCMFPNA;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid MGPLMHCDOPE;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid KOEBPFMFGGC;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid GMCPLKHPCAM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid CCPHPLIGIIL;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid ICKMIDBAGDA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid OCDACAEINOG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid JEKPJBOKJNL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid FIALPBJFLDM;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid LEMEFHMLFGB;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CIGBDLHCAHF;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid EICDNEJNGMP;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid EFHIHKILGGK;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid KOJJNPMODCG;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DCKPHDGOHCL;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid MNDHMJIODCC;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid BHDIEIJLBEB;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid MHMBFFPCIDF;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid MLNDDHOAFLP;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid GGOBJINBKNP;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid HNODJHMHGCM;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid OMNIGFAPCCH;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid KJAKAJPAKDG;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid DELIGGFNHCJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid EDHPNDCLJNB;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid BIHKAOJHKDK;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid CMEEHNGCIJP;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HOBMEHJLODN;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid PNEIJIHOFEJ;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid CIBDNLCFELI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid GNFIABPHIKC;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid BACJDODCPNP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid FHLNMKNKHFG;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JMJKBJDFJCG;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid AMCHPADCOLL;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid KNHHFNDDLMF;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid PLKAAICHOHP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid LGEDDIHICBI;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid KMKJJFPFKKL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid OCFIHCBPDAD;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid AOHKCAOHFOM;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DJBBEPIGHHE;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CILBGCEFIJD;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid KHDLOIJMNJB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid EGNPMCHPOMO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid GNNNLKBGOEF;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid KOBOMMEBMPB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CPGBPOLJBAO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid NAJCPDMLFEN;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid OJPLJAGFNLC;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid FDIGNLIJDCN;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid DPFEDOKFODB;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MCDNLDNHGEH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JJPFIGGCBOJ;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JOOHHMNJKNI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid AAMELLLIFJA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NLMNLGBPALA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid OOIHKAOIHKB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid BABPLCFPJJC;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NAPCHEHAPFE;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid EKKNAMIBDAA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid ILCKOJBKHHC;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid LILJIFLEELK;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid MHAFFLOKNKM;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid PGCGFKOMIDL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid GHMANMFMKDK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid POJCOHBNNLA;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid NHCNMBHNKKG;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid FGJICHPHING;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid MABJCLKHHFH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid FPDPCKJEACB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid CMGHNNOBJME;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MODEFNHJFMD;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NFLPJIKBNEF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AEDNCFNIBAM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid CDDMNGEMJLH;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid GMBJKFOHHIG;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid DOJDDDEGAPA;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid EOLIJOAPHAM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid MCAFBADKGAN;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid LJNFPGCKNKJ;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid AFFDDCJFNMA;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid LHHFGCMPJJL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FEELNPEFEBA;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid ANGMGGPLKHP;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid MMOGGBHLPPC;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid LAEKBIFDOAH;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JLFKEINFFKG;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EJBPPPFBFLC;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MMOOJFCCHCJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid MMIFNBMAGHM;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PGINKMHFJHM;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BLAFDIPEKKD;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid EKEAACEBGPC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid GHDBLKFKGDB;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid HBPHPCDGAHF;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid FEFICPDPGBE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid DCKGENOPBEO;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid IBDHHOPANHE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid EANHIJMNAIG;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid EKHKIEHKOJN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid COPILMFGMPH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid ELEJDHFNCGE;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HKIJHKIFNME;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GOCDDIDLIJL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid IMOLICHHFLJ;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid NJCIDELHOBJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid IJAGNHBPMPP;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid GDCKDDBOCLL;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid KDFIEHECJGK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid FHHLNNIIMFB;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid LMNBKKKNHLF;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid BLNHEDHGHFE;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid JDLLKNBKIGC;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid PCMBOOAPHMK;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid CPNMJNHKDCG;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid MPPIBAGJOLH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid JKIPNNHNJCM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid EFGPIJLDGCP;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid PBKIFCNHGLD;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid NADOGPCJMPH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EEAMKPJMADH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid LOJBIAMAEBD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NFJBAEMDJJD;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid BOMNKDMOLAF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid EGOMIHIMDME;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JKNDEEAHPKF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid BNBNCBCPFNN;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NKMKINBKNGG;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid OBMMBEKPEBP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid JHEKJFAMFFO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CHODCMHIDJO;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid APHLPNCAIHP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid INMIKPOCBEP;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid OJLJOJLCGJI;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid DJPDNGPABHA;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid DAFFDHMAOBH;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid GNBGDKLEEPH;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid JKFGGEABGIC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid AGEHPIPHPDK;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid CLAHGMNFNHN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GKELKCBFMDB;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid BIEHDPOPEJN;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid KHAPJCAKBFA;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BDFPGNFHAPE;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid JOPJCPNICLB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid INKLKJMAFEH;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid ABMPGKNBING;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LFBHFOMLJPL;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BEHLAFLIEGB;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid HIIILGJHAFK;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid EIJGCBCFKDO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid MNCHCBEHAIC;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid EAEIHAPJFJD;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid OPNDPJPAILI;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid PGGHGBNDBLE;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OLHNAOODBHO;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid POKELKBOHCN;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid LIDEPPNINHP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid MKMHEIPIBGL;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid MAOPIBGLAII;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid OCCLFFIDLHF;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid HLCBBJNKMCG;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BLGNJEOPFAP;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid AOPNDPLELKE;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IFEALOGKKHM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GDOEBBGHACO;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid KBBEFODFBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid KIBMIHEMJGH;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid LADOHMNIMME;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid JDCDPMADIIM;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid JIICDFOFHAA;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid ECPIAGOBBGP;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid PIIDOGNKDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid LGEKGMMHLLI;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NBGOMGGALPA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid APNODNMPFND;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid GJDMLBNBEIG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid LLDGNFHGAJG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid MFGACKFOMCF;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid OJHKJNFFAGN;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid CDKIOHJCAPN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BEDAKHGBNMH;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KBIJIIOLGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid OFOAIFBEEOH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid MPFKKHPKACH;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid ADFMEGHKKDO;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid ELFAPGAFKOG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid BNFDNAEGMAO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FEBKENMBBON;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid PJKLKIKDGEI;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PDGFEEKNECB;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FAJGIDHDLOI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid KIIBOKLMKBK;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid AOCCEBCNNNH;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid MEBJBMEEGMD;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid DCBKCOEPADI;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid DJPENBPFCBP;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid HCPMICPNNPD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MKLBGAOBNCD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid DMEKGIBOJGK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid JPIOGCHMCBB;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid IJOBGJBLIKF;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MKGODHNOPAG;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid FFHGKPJJNCK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BLNDAGNBNAK;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid APMAMGEILKL;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid POHEDCEELHN;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid DBNAFPGPIAG;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid BCPFNHAEDLE;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BGAGOPPDAFD;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DIHICDEIAKO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid LAFKMILNJIG;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GLFENJNLAEB;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid EBBJGGCBEHK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid CFJFFAHIDJF;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid ODCPLJAJADN;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid COPKANLEECE;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid HCKNEMKEOCL;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid AHGECMKEMBN;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid PJDNMHENBPJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid FFHEHIPKGMN;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid OGEDFLCIIGK;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid AOMLPJGNNFK;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid BJALHCCKDHG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid AMGIENCHOFA;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GMLFINBDKGB;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HDGMLFJPLPL;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KFABEKHAEFC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid FECMKOCGBGA;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid MLBFCIPELAN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid DDGCBHELPGC;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid DHFJHBNGHAC;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid LCLKGANEAII;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid NOFNJAILPOG;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid BNJAKFDGGOB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid GAJDHPFLBOG;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid BDBGEKCGHMK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LLFMMBGBGNN;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid DNJDKJLFGGC;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid KCCBPBMPOEG;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FJJNNEJKLHM;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid BKKMJALCJLL;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NAPHFGJOBDA;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KCLBNLHOEBN;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid EDMLHMOFAHJ;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid ODFEHNCDJMN;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid KJHPPAFHAFA;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid JAEBMDGAAKI;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid DODOFOCONGL;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid EGHCNHGGMMD;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid EJKGLMHDOKH;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid OFKBPFAFKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JLGFODFEFEB;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ILCKHBDLCHD;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid AEKFFPKCOPG;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid LDHPIDHGCJN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid JDKCKHCMEKJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid ECLDGCNPJKL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid KFKILMPMJEA;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid OGJKLNMLMPB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid AHPDPLNFFKC;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid IGDMGKHLOFF;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DJBFMKLJAFG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid EAHHNHLGHOF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PGMLHNJLOBP;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid JPIPDCOGPCK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid CBEHDEDLKHK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid HLGFAHMKHJO;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid FPFJEMGFNLI;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid NENGPLJHEHG;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid ECMELOMNDAC;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid AHDAHJBBEAF;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid GFHNEPGFKKM;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid AIKDDIDMHMM;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid HPKOLGPPILM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid DIKOKEPDKOF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KLPCKOMPPIM;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid DDGJBKHEAPI;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid DMHPKFKBEAB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid LDJIBCHLEJJ;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LDBPBCPCCOC;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KAOMCGGIDNP;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LLEAPKPMFHP;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid GCGNOILAJAA;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid FLLNDDAGCNK;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid ONCGEDOFCJC;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid KPJEBJFDEMG;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid DKFKJHLCPHD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PAGKAFKODNN;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid GHIJNLOBIOB;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid MNGHFDHPAGB;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid AODBLCGAILL;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AJHHMEEOPJO;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BPLNBFEHLNG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid OLEDHMGPNKG;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid FNCLGPGIBAN;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid OPOGPBICBML;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid HAKIHLFJOKK;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid AMIFBDOHCEF;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid BPKOINBHOLP;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid HKAADFNJCOE;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid OOMLDLHHCNM;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid OIOCHJCBFCP;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BADHNLADDDN;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid IGNPKKOFMMM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid FJIGFOGADCK;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LEALNBEOEPB;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid GLIHMPHABPE;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid EAHKKIKAGAA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid FLJCEBPFACN;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FKKNHJEHMLJ;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid CKLJNBLJFDD;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid CKGOBAOLIFA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid BABAAJPGPIG;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid FKEHKLAEMOG;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid GHGIPHPECKJ;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid AGPHIDOCPCD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid LCHJCDLEMIK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid AFNFHDPKOKP;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GHHMGOODMLK;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HDFIOHMCBAJ;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid GMJJEHHMHCO;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IGHOKNKPABH;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid ADBJAEJDKFG;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KPGLBICFIEC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CDNNLHNAODJ;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid EBJFEIHIFKH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KCNDADLNKCH;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HKMHFJGMJGP;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KHBCCJFCIPD;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ICECEOBJBGH;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid MGLNIKBIHDD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid PDDEPNMCNDE;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid IOLGDBNFKJO;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IGKOCOIPGPD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid CIMCGPHALJH;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid MMJNKJJFLKO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid LGKLALEEBEO;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid GHKJDFMLDML;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LADCPJCDJCF;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid ILMOAOCAEMP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NCCBGMDKLEG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid FJOFKAJCPKK;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid HCANDBFGFPH;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid FOJNNGLOJIC;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid FBONMMBGBLL;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid LABGNGHNPFD;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FBGOBAANEKC;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid KODDKAGFLGC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid JAEIJOLDGDD;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid KCKHBHAFGDN;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid EJNIHCIGNLM;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid GMBOCODIMHG;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid LMFJJEMCEIB;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MILJKJCNAHL;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid MHANOMBMGKI;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid BGNNBGNJKDN;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid KHNBADBONCA;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CIFIAFGLHKG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KKBGELHGMPN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid DKMLJPKFKFK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid JAAAPFPIPCN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid NPKFPMDLFAB;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid ACENIFIFEJP;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid JBHJFFKBCKC;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid KAEPLDIBOAL;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EAJGEAPDOMG;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GFIFCKBKJEJ;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid FHKGPPNAGKD;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid DDBMLNOLDDM;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid GHAFHJOFFEG;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PMKAAKNCIAL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FDJMDFAFFGC;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid ECCMMHALHLE;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OOCHDIHAGCN;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PELKBFEKBIO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BLBFMKKCHLG;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid MFLIIKDEKPG;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid FCGLJFOJCJD;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid JJFCHFHDPCF;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid EIPDPDMAEKJ;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid KEIBNCPMJON;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FKJDLMBFAKM;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid HLONDOEHACI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid DPEAGMOPDGL;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HGKLJKMNOGL;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid MEGDNPDCFGD;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CGGPEMJLOFF;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid DKCJNLKIHHM;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ELDIOEDNDMP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid CGBBLOLJEOP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid PFAHDJNJPDM;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FIFHPFFAIIM;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FBGADMMDPPC;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid JLKBGCDBLEP;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid ENJMOFBFNJB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid ALEKHGDAOIM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NBCCEMFOEHE;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid HONCDHLNHHG;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid CELNBAAEFAA;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid BHDHBPCCFJE;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid EEILOCGNPJA;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid NGMBBCLNPNM;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LAGLIBKMDJO;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid PCPDOJLEACH;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid DOELPODKGGB;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid MMLNMNAHGDK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid LFBCJALEEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HNCIDLBKFFG;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid EMDGNHMBAGB;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid CNOBDHNGJBN;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid MGHEDDPICOM;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid PMPAADIMBDC;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GBMFMGGFEAG;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EJIMBPJOBJN;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OOCAHADOLEH;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid DNPECKGEDKI;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MNMGLBANMBK;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid EMMAKKMKJPD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid OCLNCCPFHHG;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid IJOIKEEAADL;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AHKMMAIFHGB;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid GCEFKBLJBDG;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid MDIOFJGFHIP;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid MKCBPEDIKBF;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid KLJNLJFMAFE;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DFDCPNINIGN;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PCCNJPMHECI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid LIKAICKCJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid NAPBMPKGPHL;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid PNCCNPNPPND;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid ANOOOHMHKOF;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CLAPHMMIJDK;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DLFOANMBNKL;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid EINAGKAALPD;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid PMFDIMMDAOK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid IACDELANIEJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid FMIIDGEIPCB;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid IJHIPFALAFL;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JKBLHFNIIJB;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DMDKMCPCPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JPPFDMCFEHD;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PPPNOILFBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid PPHLEKHCMHO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid NPGAMPBFOFG;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid MGAIPFNGGAD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid BAIIOKJJFCC;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid DEADPCECFFE;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid KOKCDCNMHPH;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid CKNPMIONKKN;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid NDPJHONJHNI;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid EFENBHNMMPK;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid DHFIEECIOPN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MHHEKAMAMNF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid FHFFMHOFMDA;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OCNNDNCHAMI;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid JLNICPGBCCD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid GOJPBHHLGBD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PHIHKEGMIAD;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid CJPIAGKIECH;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid KHBKOJMENLO;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid NKAHPMBBGML;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid EOGMGCLEKPG;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DDKIEDHAIAF;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid JPFBAHBOMCI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid CCEJCKEMOBG;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid BNDGDFNCHBD;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid FBFHBJGBFEC;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid PBMGOJMBFPK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid BPBAGGEIBKK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid JFHBKBLAOHH;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IDJDEBOFFAG;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid LMKBKGEJJLE;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid JBJIPGMDBHD;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid KMFALDOHIEO;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid HCGONKBAGHG;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid HHDBGJCHCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LCDDPNCJBLN;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid PHHLOMFNGCO;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid HAAKNCDIFGG;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid BGNNOELNHKG;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid AGJBMJDLCKO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MMPMKPMNPBF;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid JPMGJHGKFCK;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid MINGLABCLGB;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MPPGFKEBBIA;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid ANKIFKPKKGA;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid FHEBMKKFKLG;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid IGHNBFDKOFA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LNNIDLIOINB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BOKMLEMGCOG;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IJNHBHJOION;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid ANBLNOOHLMO;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid AHOBBIEILEG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid NPDMGILFIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid LAAEBFOHBKE;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid FIMAOMKIIJI;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid JBAPPCFGOMB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid DBDPDEPBKKK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid OFOMCINGMDI;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NJFNDKPNBJB;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid ADKMIOHFNOE;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid AJDENBNOFFN;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid LDJOOGNKEJG;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid BHICDKEGLKH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid NFNBDJLBBFA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid OJJBBAAHOKG;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid APNBGNMEOPL;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AEDBEPLGMCN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DGDKMCBDCHG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid KLFLOGOPHJK;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BOKDCBFCKBB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CBMIPKOOKCJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LFMEOPMCDDN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid BGBCHNOJKED;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid DDNFPCKIHJP;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid CHAOFGBPJFH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid CGCIEJHMHEM;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LOCPGMAKFOF;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid FBCCAGDDFHH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid KNLPDADBENK;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid APOGDJHPKKB;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid FKKLGMAMKGM;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid EJAGLHDKMJB;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OBOGFDGHGPH;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NAJNPEPONLJ;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid PFLKPEIAAPF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid EEDBADPPGMB;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid JPIEFCBIPFP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid KNHNHGICBAG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid IMGNEIPHGFH;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid LPMGILKIBOI;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid PHDOJMCGJGE;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MCNHOLEKNPN;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid IIPELOEIAPC;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid PGANCGJFBPI;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid OPMPGGHGILG;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid OEMGKJAKPAO;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid IPBLJIKOGBM;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HPONINHAFKK;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid EHDCOHCHBNO;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid AONBCOCNCFO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid PNFIICBKPHM;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid GNMFBLHGBEH;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid DGAGFKNGAJE;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid HIEPLLDGLGA;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid LOOMNGELFDN;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid HLLCAKLFJCG;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid KJEAKNDHAIL;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid ALNCPMKPIEH;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid JFPPPNKKBAK;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid IDJKDFMMGBC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid KLHLKHFIDMN;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid BOBFOJBLCHB;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private static readonly Dictionary<Guid, DPPMMAFDHEL> IBPDBJACHPC;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private static readonly Dictionary<DPPMMAFDHEL, Guid> IDBALHFELKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, DPPMMAFDHEL> IHFOCDPNLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61B43A0", Offset = "0x61B31A0", VA = "0x1861B43A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<DPPMMAFDHEL, Guid> LMIDILFGPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61B4350", Offset = "0x61B3150", VA = "0x1861B4350")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DGIEAOMCONK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x619E460", Offset = "0x619D260", VA = "0x18619E460")]
	public static bool IOECDGPKIJI(IODEFALBKCH AMGEMCGBPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x619E0B0", Offset = "0x619CEB0", VA = "0x18619E0B0")]
	private static bool IOECDGPKIJI(JMACJEMCHHE OKABCGPFCBI, IODEFALBKCH AMGEMCGBPKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GLNPCDFDDFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public readonly GJLGCHPALPF BGMOIOICPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public readonly IEnumerable<DOPOCMMEPIO> JPJIAIJENOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public readonly IReadOnlyList<DOPOCMMEPIO> LJPJAHADBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public readonly FCLFMGJFDHI<NMAMNOMMDEG> LCHPMKDBCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public readonly IReadOnlyList<NBIAJIMEIHA<HNBANOMJKFE>> BBFLFFNFDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public readonly ByteString DELHPANCMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public readonly MNPCFJKEKCM KHIGIEKFCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public readonly bool IKANDKMPIHF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61B42C0", Offset = "0x61B30C0", VA = "0x1861B42C0")]
	public GLNPCDFDDFE(GJLGCHPALPF AKGKLNLFINB, IEnumerable<DOPOCMMEPIO> DPGBPEOBEBF, IReadOnlyList<DOPOCMMEPIO> LGGBHJPLDLH, FCLFMGJFDHI<NMAMNOMMDEG> DJBNFIGPGBD, IReadOnlyList<NBIAJIMEIHA<HNBANOMJKFE>> IOEMHOOPKIC, ByteString JBLGKKBMMPI, MNPCFJKEKCM DJLIIKDFNFI, bool HEKIPNKNPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBDBGOBBOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(PJGMNCOIJJI LHODDAGAJKC, [Out] Dictionary<int, int> OLKMPJGBHCK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(HLHGHFGIPAC KHFPKLGPGLN, PMFNBEOAODG LMCKKAIJJAG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EILDPPNMCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public readonly Guid CMDCGLNLPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly Dictionary<Guid, Guid> LLBOEEGCBCI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> CHBLCMBADBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36956A0", Offset = "0x36944A0", VA = "0x1836956A0")]
	private EILDPPNMCME([In] Guid LKOPHAHFFJN, Dictionary<Guid, Guid> JOIAHDKFCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x619FA90", Offset = "0x619E890", VA = "0x18619FA90")]
	public static EILDPPNMCME EECCGMHGGBA(IReadOnlyDictionary<Guid, Guid> JCBFPLJKLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x619FAA0", Offset = "0x619E8A0", VA = "0x18619FAA0")]
	public static EILDPPNMCME GOABGAJDPJK(IEnumerable<KeyValuePair<Guid, Guid>> JCBFPLJKLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x619FE50", Offset = "0x619EC50", VA = "0x18619FE50")]
	private static Dictionary<Guid, Guid> LFGGCJHFCAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x619F980", Offset = "0x619E780", VA = "0x18619F980")]
	public Guid DDJCOFHNLIF([In] Guid IIGMMHCLOGB, bool AJOMHCKHDAA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x619FF00", Offset = "0x619ED00", VA = "0x18619FF00")]
	public bool MEKLNMBKCEC([In] Guid NLFEJIHGBIC, [Out] Guid NFILPFPHNMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMJDIDEMBID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHLPLJOEEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPNHMAJLCHC(ByteString FBMAMDNADFD, EILDPPNMCME NBLOBDBGLAD, [In] UniformTRS HHCCBPJPELH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GBLKLGDGGEJ
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
public class KCBJBMHFFJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x13693C0", Offset = "0x13681C0", VA = "0x1813693C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long MNLHHLJGNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xE9EFE0", Offset = "0xE9DDE0", VA = "0x180E9EFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long HAIIFLOIOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61B4FD0", Offset = "0x61B3DD0", VA = "0x1861B4FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA6A0", Offset = "0x5EB94A0", VA = "0x185EBA6A0")]
	public KCBJBMHFFJJ(long NJKDAMEBDBN, long HLOKBIOIIID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GKGNHKHLNBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private Dictionary<Guid, KCBJBMHFFJJ> CCNPKPFEIKP;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static Dictionary<Guid, int> BIEJBEEIPLF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long AKFFEJGBMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE9EFE0", Offset = "0xE9DDE0", VA = "0x180E9EFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long OEGIPFFCKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF10640", Offset = "0xF0F440", VA = "0x180F10640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61A0280", Offset = "0x619F080", VA = "0x1861A0280")]
	public static GKGNHKHLNBO HOGOCLGFHHO(GJLGCHPALPF DJAOGPCDKAP, NBIAJIMEIHA<NMAMNOMMDEG> PAPHFGBMKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x619FFC0", Offset = "0x619EDC0", VA = "0x18619FFC0")]
	private void AOMIOPBDJJP(HPOMKICNKIH FMEAKEGGFNK, long DFJNCONEOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61B4230", Offset = "0x61B3030", VA = "0x1861B4230")]
	public GKGNHKHLNBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IFBLILIJHAA
{
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly HashSet<DPPMMAFDHEL> HOCJJGCLJPC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EJGJCAEHGEB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> JHNHJICFCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> PMECOFLILEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	public EJGJCAEHGEB(IReadOnlyDictionary<Guid, Guid> NCGFBEOOGDN, IReadOnlyDictionary<Guid, Guid> MLLCFJCPJKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AGKNPIJJLLJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x619D610", Offset = "0x619C410", VA = "0x18619D610")]
	public static EHDPEFCJEPN PMBOODOMGOG([In] GLNPCDFDDFE MLPBIJMCIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x619AC10", Offset = "0x6199A10", VA = "0x18619AC10")]
	private static void DMFDILPHEBL(EHDPEFCJEPN GGEAIJONBBN, [In] GLNPCDFDDFE LACDHENOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x619BF80", Offset = "0x619AD80", VA = "0x18619BF80")]
	public static bool PIBGEDDDHHD(EHDPEFCJEPN GGEAIJONBBN, FFHFPNMEFOP PEDDINDECHF, EILDPPNMCME? AAFDEAEOFAI, [Out] EJGJCAEHGEB? JOIAHDKFCDN, [Out] string? EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x619A4C0", Offset = "0x61992C0", VA = "0x18619A4C0")]
	private static void ANMGKKMGBNJ(EHDPEFCJEPN GGEAIJONBBN, EILDPPNMCME? LGBFFJIJJEH, FFHFPNMEFOP PEDDINDECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x619BF10", Offset = "0x619AD10", VA = "0x18619BF10")]
	private static void OCLKPGKBOLB(EHDPEFCJEPN GGEAIJONBBN, FFHFPNMEFOP PEDDINDECHF, IReadOnlyCollection<ByteString>? JMDBFKNLOCI, IReadOnlyCollection<ByteString>? FPNKBMHEILD, IReadOnlyCollection<ByteString>? DGMEECPOKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x619B5F0", Offset = "0x619A3F0", VA = "0x18619B5F0")]
	private static bool JKOLIEHGKOI(EHDPEFCJEPN GGEAIJONBBN, HLHGHFGIPAC KHFPKLGPGLN, FFHFPNMEFOP PEDDINDECHF, [Out] string EPIMHJFIPDE, [Out] Dictionary<int, int> OLKMPJGBHCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x619B310", Offset = "0x619A110", VA = "0x18619B310")]
	private static Dictionary<Guid, JMACJEMCHHE> GKIAOKPGOKG(EHDPEFCJEPN GGEAIJONBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x619B270", Offset = "0x619A070", VA = "0x18619B270")]
	private static void EFDPNKEKPGI(bool HGAANHFMNHH, DOPOCMMEPIO NGOHHJIGFPK, Dictionary<Guid, Guid> PEBANJKMLGE, EILDPPNMCME HFBDHFJNOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x619BC80", Offset = "0x619AA80", VA = "0x18619BC80")]
	private static void NIOGMMCBFIC(DOPOCMMEPIO NGOHHJIGFPK, Guid CGFELJAGDKG, JLJKBAHDIIP? HKJCJCGPBPO, Dictionary<Guid, JMACJEMCHHE> GFLKNAANMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x619A760", Offset = "0x6199560", VA = "0x18619A760")]
	private static void CDJHOGIIPFO(IEnumerable<DOPOCMMEPIO> NKPKNIIJEIE, IReadOnlyCollection<ByteString> JMDBFKNLOCI, IReadOnlyCollection<ByteString> FPNKBMHEILD, IReadOnlyCollection<ByteString> DGMEECPOKGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FFHFPNMEFOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public bool HGAANHFMNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public MNPCFJKEKCM DJLIIKDFNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public JLJKBAHDIIP? HKJCJCGPBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public JLJKBAHDIIP? HJMMLEIOECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public GJLGCHPALPF PKBDMAIOHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public GBLKLGDGGEJ LOIOCCIIMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public OBDBGOBBOLJ PCGBBGBCDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public NMJDIDEMBID KHIFADNEOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public NBIAJIMEIHA<NMAMNOMMDEG> LNBHDNDNPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public HNBJAEJPJGK CDDGMEIPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public List<DOPOCMMEPIO> HFOLEKLFLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<string, object> KLMEDFFFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public HDDODFPPDIF OFKKKMIBFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public bool ICFGIPCOKHK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool LGIPCCAKHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x619FF70", Offset = "0x619ED70", VA = "0x18619FF70")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JLJKBAHDIIP
{
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private const float BLIIBLOEGKO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public Vector3 JPLKOMKCHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public Quaternion IHHAEIJMAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public float HDBPIAOAHOC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 PPHOCNLINLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61B4B40", Offset = "0x61B3940", VA = "0x1861B4B40")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS MMGJGFGFJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61B4780", Offset = "0x61B3580", VA = "0x1861B4780")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x9D1EA0", Offset = "0x9D0CA0", VA = "0x1809D1EA0")]
	public JLJKBAHDIIP(Vector3 JPLKOMKCHGP, Quaternion IHHAEIJMAPE, float HDBPIAOAHOC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61B4F00", Offset = "0x61B3D00", VA = "0x1861B4F00")]
	public JLJKBAHDIIP(UniformTRS BHDIDIBGMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61B4850", Offset = "0x61B3650", VA = "0x1861B4850")]
	public static JLJKBAHDIIP FKILHPONLJB(JLJKBAHDIIP OGCHMLDLLMJ, JLJKBAHDIIP LIPIIDFKKHJ)
	{
		return default(JLJKBAHDIIP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61B4600", Offset = "0x61B3400", VA = "0x1861B4600")]
	public static JLJKBAHDIIP BPFJNEHKLMP((Vector3, Quaternion, float) LHODDAGAJKC)
	{
		return default(JLJKBAHDIIP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61B4620", Offset = "0x61B3420", VA = "0x1861B4620")]
	public static JLJKBAHDIIP BPFJNEHKLMP(Matrix4x4 JNNFCLPMJHE)
	{
		return default(JLJKBAHDIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61B4E70", Offset = "0x61B3C70", VA = "0x1861B4E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61B4C50", Offset = "0x61B3A50", VA = "0x1861B4C50")]
	public JLJKBAHDIIP PFIONIKCOMJ(Matrix4x4 AFOLJDADEON)
	{
		return default(JLJKBAHDIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61B4AD0", Offset = "0x61B38D0", VA = "0x1861B4AD0")]
	public static JLJKBAHDIIP JNANGDNFBCI(Vector3 JPLKOMKCHGP)
	{
		return default(JLJKBAHDIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61B47C0", Offset = "0x61B35C0", VA = "0x1861B47C0")]
	public readonly OCLPOOMHKED FIMAKNBKBMK()
	{
		return default(OCLPOOMHKED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ADAAPHLKFCP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x619A430", Offset = "0x6199230", VA = "0x18619A430")]
	public static JLJKBAHDIIP BHAMAMDAIMH([In] this OCLPOOMHKED ILACEKALGJH)
	{
		return default(JLJKBAHDIIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class BAFAECMAFKE : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x619D780", Offset = "0x619C580", VA = "0x18619D780", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x619D800", Offset = "0x619C600", VA = "0x18619D800")]
	private void PPEFDMGILDM(Dictionary<Guid, Guid> IALALINBBEI, HKOICEPGOMN IIJMBCIOLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x619DDD0", Offset = "0x619CBD0", VA = "0x18619DDD0")]
	private void PPEFDMGILDM(Dictionary<Guid, Guid> IALALINBBEI, AAOEIMJJCCI AFCBDEHCBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x619DE30", Offset = "0x619CC30", VA = "0x18619DE30")]
	private void PPEFDMGILDM(Dictionary<Guid, Guid> IALALINBBEI, PGCPINOMMFK KDKHJDLLEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BAFAECMAFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JMAANNJNECE : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61B7DD0", Offset = "0x61B6BD0", VA = "0x1861B7DD0", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public JMAANNJNECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class OLJFHIPCNJL : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61B8350", Offset = "0x61B7150", VA = "0x1861B8350", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OLJFHIPCNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class FEENMIDAINB : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61B7AD0", Offset = "0x61B68D0", VA = "0x1861B7AD0", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public FEENMIDAINB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class OAJAOHIONBI : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61B8130", Offset = "0x61B6F30", VA = "0x1861B8130", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OAJAOHIONBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CECDPJJNOHF : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61B5240", Offset = "0x61B4040", VA = "0x1861B5240", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CECDPJJNOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ECCAOPDEBDJ : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61B6580", Offset = "0x61B5380", VA = "0x1861B6580", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public ECCAOPDEBDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class PFOPNEOHBAA : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61B84B0", Offset = "0x61B72B0", VA = "0x1861B84B0", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public PFOPNEOHBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GDBMLOAGLJN : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61B7C20", Offset = "0x61B6A20", VA = "0x1861B7C20", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public GDBMLOAGLJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MDFKHLPBDNG : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61B7E80", Offset = "0x61B6C80", VA = "0x1861B7E80", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MDFKHLPBDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MOOOHGEHLHJ : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61B8030", Offset = "0x61B6E30", VA = "0x1861B8030", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MOOOHGEHLHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BKMLHLMIDGO : DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly OICJCAJDLOL FMCMHPPCDLG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61B5110", Offset = "0x61B3F10", VA = "0x1861B5110", Slot = "4")]
	public void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public BKMLHLMIDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct IODEFALBKCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public HLHGHFGIPAC MIJEJKOAIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public NBCBBHAHPNB OGPAENPECNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public Dictionary<int, int> MNNLKIIPBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public Dictionary<Guid, Guid> FCCIOLJCKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public HDDODFPPDIF OFKKKMIBFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public bool BFMNGJACJAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface DFFBEAEELAB
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIIJOIMGCIH(CJIIGOCAMOC LLIMJCLBOJO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DFINBAJMINE
{
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly DFFBEAEELAB[] DKINOEABKOA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61B57F0", Offset = "0x61B45F0", VA = "0x1861B57F0")]
	public static void JEPLGAFCNKK(DOPOCMMEPIO LHODDAGAJKC, Dictionary<Guid, Guid> EPNEHLCIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61B5D00", Offset = "0x61B4B00", VA = "0x1861B5D00")]
	public static void POLDKDPDCEH(DOPOCMMEPIO? LHODDAGAJKC, EILDPPNMCME LPJKJGEGGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61B5A80", Offset = "0x61B4880", VA = "0x1861B5A80")]
	public static void MAKHOOLAOFG(DOPOCMMEPIO? LHODDAGAJKC, EILDPPNMCME HFBDHFJNOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61B5420", Offset = "0x61B4220", VA = "0x1861B5420")]
	public static void IOECDGPKIJI(CJIIGOCAMOC LLIMJCLBOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CJIIGOCAMOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public HLHGHFGIPAC DFEFEJPNOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public DOPOCMMEPIO NGOHHJIGFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public Dictionary<int, int> MNNLKIIPBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public Dictionary<Guid, Guid> FCCIOLJCKIB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61B5380", Offset = "0x61B4180", VA = "0x1861B5380")]
	public Guid HDIOFOIFKAB(Guid IIGMMHCLOGB)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HDDODFPPDIF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LJNCFHKPJLF, [Out] Guid IIDEPPDFKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EKHBGJIDFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly HashSet<string> PHAMNOEIBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly Dictionary<long, int> IJGPHHGFCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private readonly HashSet<Guid> NNAGFEBBMDE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyCollection<string> GGGLGHLGFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<long, int> KOAOBIJEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x61B6B40", Offset = "0x61B5940", VA = "0x1861B6B40")]
	public static EKHBGJIDFDE LKBPEJIAANM(CCLFGPLFGKK EEKNEAJDFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x61B6710", Offset = "0x61B5510", VA = "0x1861B6710")]
	public static EKHBGJIDFDE CJAIAHDDMFE(EHDPEFCJEPN JIFKFGFACBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x61B6950", Offset = "0x61B5750", VA = "0x1861B6950")]
	public static EKHBGJIDFDE GIPGMIPECGG(IEnumerable<string> PHAMNOEIBLG, IDictionary<long, int> LOHBMMPOMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61B79B0", Offset = "0x61B67B0", VA = "0x1861B79B0")]
	private EKHBGJIDFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61B7870", Offset = "0x61B6670", VA = "0x1861B7870")]
	private EKHBGJIDFDE(IEnumerable<string> PHAMNOEIBLG, IDictionary<long, int> LOHBMMPOMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61B7490", Offset = "0x61B6290", VA = "0x1861B7490")]
	private void NONJGAOFADA(CCLFGPLFGKK EEKNEAJDFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61B7680", Offset = "0x61B6480", VA = "0x1861B7680")]
	private void NONJGAOFADA(EHDPEFCJEPN JIFKFGFACBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61B6FA0", Offset = "0x61B5DA0", VA = "0x1861B6FA0")]
	private void NONJGAOFADA(ILCOAGMEOFB? GDOPFEEANMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61B72C0", Offset = "0x61B60C0", VA = "0x1861B72C0")]
	private void NONJGAOFADA(MJLPBMFLBIO? FMEAKEGGFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61B6BB0", Offset = "0x61B59B0", VA = "0x1861B6BB0")]
	private void NONJGAOFADA(DOPOCMMEPIO? NGOHHJIGFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61B6AD0", Offset = "0x61B58D0", VA = "0x1861B6AD0")]
	private void HGMPGAPDBHE(string? IPKMFHJOLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61B6870", Offset = "0x61B5670", VA = "0x1861B6870")]
	private void DKFNCNBDNDE(LLFJMNBDEOA? JJLKMMIJOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61B6780", Offset = "0x61B5580", VA = "0x1861B6780")]
	private void DKFNCNBDNDE(MBDKOBDAGGE? JJLKMMIJOGP)
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
