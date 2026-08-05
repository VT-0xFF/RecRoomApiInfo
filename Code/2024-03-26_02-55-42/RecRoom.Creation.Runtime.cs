using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x615D6E0", Offset = "0x615CAE0", VA = "0x18615D6E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EFKLDPFGHIG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> DFOPKOCIJDN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> NKHHOHICBEL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> NJGHOENEEKG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EGJNFCKHNFG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string ONEMABCODNE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string BHBKKNCFPCC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6158E70", Offset = "0x6158270", VA = "0x186158E70")]
	public static bool LBKPCFANFEC(Guid DOANPKJFKBP, int NHJPDJCEJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6158760", Offset = "0x6157B60", VA = "0x186158760")]
	public static bool ECFDGEBFGJA(Guid DOANPKJFKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61587F0", Offset = "0x6157BF0", VA = "0x1861587F0")]
	public static string EMEHJPIGNDC(Guid GFLAAGJEJNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MCCBEADDPDN]
public enum GBGGDKPOLHH
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
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COSTUME_DUMMY_OM,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class APBABOOJBGD
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid JFJBBPNMFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid AGMHKKBGKMO;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid MMGGLLBCDBF;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid IIKEBPHIHFO;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid MHMBKLFHBKB;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid LKGGDGBBHGA;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid CLAHFAPMHDB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid LNBIEKLIEHB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid BOKPJJKLKGP;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid CMMOKNGMCNA;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid ACHICEBHADP;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid FBPGKOKPCAH;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid FNIMPCKAIIP;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid LHCAOJAJNCC;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid LDKKJJHFBFO;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid AMIFFKILLDA;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid HJGBKGMAPBK;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid DLEGGEGHGFP;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid MOEPJICCKMC;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid JJPMMDALIFN;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid OFBCJDNOPKA;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid EJJGDOAJNNC;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid KCFIGIPEEON;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid LFCAMJKLOOP;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid OAKFENBIEGO;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid MCAMEMAICAC;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid IKKHNELCBKH;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid AHOOFBOPJKG;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid CKBFCPPMPCP;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid EFALEGBLODO;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid BMEIHNJMMBC;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid MKNELMIJGFN;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid MKAENHJKEHF;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid NCPCGOPICOE;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid INMDPGJKAIM;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid KNLNCPPMMLA;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid NFMEAILJLKK;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid BLFJOIBHPLC;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid LEJBIFOBMFI;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid EHIIOFLIAAN;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid GAINFPEHEOB;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid PDHGOPELDMP;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid BPLGENMIMNN;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid MGMGPEDFBPO;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid NPIJNNCNKKC;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid BJGHJCLMIIF;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid OKCLAHKIJFE;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid DNLIPOMKPFG;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid BIBMPDOLONJ;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid HNFIKOANJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid FENAGJMAHBK;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid LGLLOGDEMFE;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid IICAEENALKC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JEBDNAODJOD;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid CEIAINMCBAN;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid PKIKFOEIMKO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid LPJMPIJDFNM;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid JLAAAFLCCBM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid HKBINPGBGJO;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid CEHJGOLGCJA;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid PNNPEEOEDNN;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid OGCEKJPFKNL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid EANJEKADAHK;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NLKBLDKNAAF;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid AFOGBFPKILK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PFMNLEPJMAG;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LJOMPGHJJJM;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid JOCADGDEGKO;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DECINMDAPNH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid KPLHAHJNGEE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid ANJNONJCNHE;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KMLDHJADFBD;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid GPLFHAKGALL;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid IEBBMLKCNCJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LOKEINMACNL;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LPDDGCMBNHO;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid EBCFHDGJMNK;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CGOHMNHAAOJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid CEMFLMOLICO;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid EAOMCHLCEKL;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid MLNDBLMGHJG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JCBEHLCDJBN;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid HLKCFLEJEJO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KFOALANLFBN;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid MMOGAMDEMPO;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OBDOLKJHJKO;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid HMFALCCDFGK;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid AEOBFCLJGMD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid ELIMINGKHCE;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GDDJMMICHNA;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid NFMCCOALHAN;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid IHNCCEGOPLG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FHOJBLKECAH;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid BMPNIBFBMGL;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid KANKLDCPGCH;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid KPDCONFAJEH;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid HNPFCDFLDCH;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NEFFKDHGIEN;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid AGHBNCCJDMF;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JEHGDPONNED;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid CLGHEEEKCLP;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid EIHBCBDNHOK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid OCJPMBGOOIG;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid JOFLHFFEFNP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid NPOBEGBIHPB;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid LKIHCDECNIH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BLNPLCPOOED;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid IKCJPNMKJFL;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid HGNKABGLPCN;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EMPGPKBFLFA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid LBLLCGPBMBP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JFDEEBPCLGM;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid HMNLPPFCAMD;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid COKDFFALIDA;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid DLOOIFGPBNO;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid IAFDPJMIKKP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid BPDOHJCONFL;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid GFNHBELFNOG;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JNKPEBCGJLK;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid KKDDMCFNGIB;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid GAAHEMEMEIA;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid CAGAGINHMNF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MHEOOCEPNOK;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid MFGMDENINHK;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid OBBJCPLODLG;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BOIINMKNHPL;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KLFENABDGCP;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid LILCNEEJHFA;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HDKLKENJMFN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid JCBAMMMHLBP;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid MCGAABHLFAH;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid OAPIPJOOKFH;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid KFIKALMGKDN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid CAFLGGOAKGH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid CKHAHHCJNAP;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid EJHMHFMMAKE;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MPMMDDHNOPH;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid JPGMOHNAKME;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid GCKJGNFFHFO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid ELHFKCJHKEM;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EKODHGMBDLE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid KCHAJFPCKAC;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EHJEFKNFOJL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid GGMJCMLLKAI;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid MJLDPAEIKNJ;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JLHFCJNLLLB;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid KGONDPPAFCB;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid GBCBDIGGMED;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DFNDLLEEABM;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid IEGPMGMNKOE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid JFMGNCOOHCE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HPJJCGCLLGE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid DCDFACFGMNE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid FNPIJALHFLA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid OAIPAMFHOKN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BDMCEADHAFO;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JOBOADAAAJD;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid DKIIHAMBLHL;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid LJEGKBDNPKG;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid CDDCGKFELPA;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid LBPPJDJOPLA;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OJMHJFLENAL;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid LPOPPGCHFOG;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid FIMDFAJOCDG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid PPDMAPPPKCA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid NMNDIDEKEKL;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid CKPKPKOFNFI;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid FKBKELBKBHP;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid GDMLPHECKEB;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid OKGEDMFIBEJ;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PMDKAPOFBLD;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid OCBFFCEKMLL;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid KCABCIGIDNE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid AAAGOIOFPKN;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid KELMLHFHGFD;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid EFEFDOAPPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DLGEACPEHHD;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MDIMKFFOFGA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid NBIHLKFMIOH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PGBCKGPDHHI;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid AJAOGDCLEID;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HBFOEGPKKMA;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid IJNHDOECMHL;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid CDEJFGKGDFC;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid JGIIDCOOKKI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CHPJFBIPPJA;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid NEKHHDLEBFM;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid NMHMNAGODOC;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PPDLLCLIJMI;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid KFNPILNHMLK;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid AFJICGHCDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid BENHNLKDBNN;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid LIIPNKPBDPA;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid APCHFBDDPGF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid DBGIPNOBHCO;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid MGAOGPBJIMH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid LPLFAGKGCJM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid AFKMPGDMCGK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid ICCLMIPAHEJ;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BPDLEGKMNAA;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid FDCEJPIDBFM;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid IAAHDANENKD;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid HGHDFLOPCDC;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid HKFNNHGAJHG;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CFGHFDABCDP;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid IEOGOKMCBFF;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid DMBADKEOOAP;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid ODEJBBMGKHJ;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid NJNMHHPPICA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid JJEJADEHEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid PFFLCHDDBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid KFKLBHDOIFK;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HNMLAHHHDEG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid ENHHKEINKJL;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid BNFJOMNJJDO;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid FNFNOAHEOLB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid JFKEPGMFEMI;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid OKOPFHKNPKG;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid MFHDLCGCDBH;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid PCJNNBCGOLB;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IPKOIOKHEIH;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ENNDPICIHEF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BDJLAMKKINO;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JGEIMFDHJHI;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid OGMKMALLHLA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid DNNNHBIJBIB;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid ONNHLOFFIME;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid HCMFACMMMHK;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FILKJGCMBIB;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HAMHGNANLCN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid IIEOEIPICME;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid HDJOOLGEIDB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid PDNOAELAFLA;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid JCBALPNPMHC;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid AKLALCKFFJK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid CBLHAFLNEKN;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GDNDEKJKMPG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid IPJBMKIHMGG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KNCMIKPLJKH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid LFEADDCNGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid EHLOAIAJFEH;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IGGCNHKDHBB;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid IGEMANGCFNJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid FMNCDFJKCMJ;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid IBFCMBDOBOM;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid NMKBBEKPLMH;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid ANDKHPCLJDI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid FLIKAIFGLHH;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid NEFJNKELCLH;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid NPOBKLPHCMA;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid NADAGHFMGLE;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid AJKHBNJNPAH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid INOCPMKGHPO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MMEDLBDEMLA;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid CPINCEBHGDK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid GNNKDHCKOGE;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CODHOONEEKE;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid JFNJFBPCINL;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid COHNPAFAFMG;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid OKECFOFIGNH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LCDCFOPBFNC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid GIIECKBBGOE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid OFGGBICHEPN;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid AMBDFPHLHNF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BDKMBPDAIOJ;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid NEBIILCICKG;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid CNLADPAKMBF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid KOKNGGOEDCL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid EKIFEKIGJKD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid IHALGIJAIAJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid AIILBKKHHDA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HIKGGFKAOFH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid FCCFPOJOGEL;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid JFDNLIIKGFA;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid BPMKFFFEOAF;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HBHJIBJFPII;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GGDJJGCGPIB;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid CNHHJCAGIPI;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid APIFPKIBKFG;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid FGBAAFFMJEF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FBCFCHMHNFC;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid HECLCIJLGGD;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid KGODAMHILEG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid KBPPLFKOLGK;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid JPHCIOKPGGH;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid BBCHOOJNCGC;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid KDLKMKCIEHB;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BJDFAFKCFDG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid MCHBEKFBNJL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MFKIGMGECFH;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid ALLCOOCFEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CCDACBJENKK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BAFDKENPFLG;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GPOEFOECHFE;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid LEJKEEEHKJJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NBPLFMOHCPI;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid EGIDLIGGBGM;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid IMDEGEJMJPE;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid HDEBKIBONFI;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid CNBNHECLEHM;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid PPJCKBLGPIG;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid LPGBFLDNFJJ;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid EHMHNLJPBHH;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid CPMFLCOMLPA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FBBABGOHEIJ;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid HOACMDELEBA;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid NCNIENEMACP;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid OCNHNLLNFKO;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid DCGPDGFNMHH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid CFOJNAGIAKL;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid CHHPHEAEEIH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid FHLHFLOHBIK;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid BPFCKEAEDIN;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid NHNLNIGMLJG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MGPMEEACKKL;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid HODHAKIPHHK;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MHDBOLMIFOL;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid DBAAJBPGBCD;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GFICBDPAOCF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid GCKCEHOFOAC;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid HPMGGFEPBND;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KNEMIDAPEAG;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid OOBEMOLDGGK;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CHBCEKBPABH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid ICKOKEAFPFH;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid JIMGIHDCCHH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid LJNDMAKHMOP;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid JOPDHIIKMOM;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MHBCBFNFOMP;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid DMAJCLDEDBC;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HKGFAHKHLCD;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid FDCLLOHDBOA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid CNAMGBHJOID;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BJEGCNBGFEA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid DIMHCOBCHHC;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid EHGBODOEHNE;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid NBPCIFLPNBB;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid ADGJDPAINAA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid IHDEHOJEOEN;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid OLCHNNPJGCC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CMFKIAJPAFF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid ICOHFJBGAKD;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JCOCCFLDIDE;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GEDGKBKGILA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid EAJCHNEIOFG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid KHNDLENDKIE;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid EKFONDDNPEB;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid ECEHHGHJMHI;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PMFPPCJCMGI;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid NBCJOPHNOLC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid NGHJGFHAFHD;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LBIBGFKMNDL;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LCNPKNNFFNA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OMLNMDLDHIO;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid IGBEJHEDBHL;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid FLANJJDHOEI;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CNJBEJOKLAH;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HHKDOCMJKMG;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BLPDJKAMGIF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BJHDCMAEMCG;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid ACJCCAIGIMN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid DMNLJIIKANJ;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FKGFPFELPBO;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid INHBKHPEPAH;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid EKOOCMIKHJD;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid CDABLANALON;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LIKJFNDCBIJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid NHGBOOGFEMO;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid ENCPOPAHPLA;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid ADPACGGAEKO;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PEBBBOEMDJB;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid OCPPENEJKOC;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid AMOAKOIICIG;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid OEFKNFKIBJH;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BLFMJKAKONC;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid LLKDNPCNPLE;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid OGPAAPBAGHK;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid BCILFJGAOKA;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MEJIBNHPLJG;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LHEGMDOFOML;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ECCICELKFFE;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid DGMPNIMPEDF;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid EBGFFKNMMMC;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid PIJDEHAAEMF;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid JGKODMCJPCP;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid GMFNAGIKHGK;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid KCDOFBJEAIN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid NLFJJMMJIPL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid ADIMMJGGBLE;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IFBMEDAFONK;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid LIBFFKOCMBP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid DFJJCKKKNIG;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid ANCLKDIHNAA;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid KJDDPDDOCIP;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid NOBGEJCOIFC;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid LGDHLAABMPN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid ELDLLNHPKMI;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid LKGLFNGFFFN;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid PBDHHELNBOK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LNAECMDOOKI;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid OJHDGNIDGOG;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid MIOILAGGIPH;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid FGKEJNFNHDB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid LEMCFAOMACI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid KKKCPJJJAHA;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid LMPDKEHHLAK;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid GCONIFBJNGG;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NEMCKNOBPFN;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EKMBDOOMGFM;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid MNHCMBNGAOJ;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid BOJIFKLNODI;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid DPHBBBFHPNG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HKIJCGCGJJG;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid CKALMAGHIDJ;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid IPJLOBAANAA;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid PNBPBLECIGC;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid IJIBBCKPHKN;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LNGNHPLJOJN;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid OHALEJIJIKB;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid ELKNIOFMJNC;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid ABIMDLICJDP;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid OBDBDGJFCAJ;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid MFDPKOGFGCO;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid LPAJKDKPMCC;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid EGDPPCLOBBP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid DPAHHMAPHGC;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid KBNDAFLGEIM;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KHPNNABNOOB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KNEBAKCAEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ANHNINIKENI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid DDGLFGHAAGF;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid IENGDMLEIAM;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid KPKBCDACJBM;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid MEMLFJDGLEC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid HGDBAKJOIDC;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LKEBFBMCJGB;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid AJJFGLBEBHF;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid IMNOMEHFEBI;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ODMBAIANKAI;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid MAKHNBJCDAO;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HDHGEEBCJJN;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid AHINIGMDEIO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid BODOINJKFBE;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid EENEADAJGKB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid CMLHFCNEJJL;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid BHABGPLCNOF;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid OPENIKHBPEN;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid EMOPALHODCG;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid IEFFMOFJNIA;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MKLNKJJAPHF;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid BDCFHKCGINC;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid MIJHJALCEHN;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NKHIDEFJOME;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JCDNFONCBJH;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid FHKGLIDDHPD;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KJIGICAMOGF;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid JLENANONOGP;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid LNJHMMFEGKA;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid NHFBHNAPNPP;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JEAPIIOGGJB;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LCBLJLNJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid JCNNEMNLOGO;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BKMIOGKENAC;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid CHJGLMBNEEI;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid JOFOHLCKJAK;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid KPIMMKAFABH;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid GOLFJCEFHMC;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid LLDKJDDAEPK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid BPJIEEIKMEL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid JKKCFPJOCOL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid MNEFFHPLJEB;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid CLLEJJDBOMK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MINNKAGAAIN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid OFAKMFJINBG;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid CNKMCLJMBNF;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid KADHFDHDOAH;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid NKDDEBCFEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid GMDEBIBMLLO;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid FGINDHGDJEI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid AJMIEHFGGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MHHJNPCFMKD;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DJEIDAOIFBB;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid GPJBNADMMLB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid POECNCBCEFB;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KLDKJNGNBEH;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid LDFHCNKOEKK;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IKHPIFIGAAN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid KHDDMFJIANE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PKGCDNGJABB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid AOCOBGCHMFO;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid LPKALGDAFAF;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NGOFBPPFGGE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid AOBJOEOOGKH;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid IIMIFGBAMLD;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid EFOKIMHABLA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid EHDKGLIDLGN;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid POPHAPOBLDL;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid CJBLDIHBAIE;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid DKMPPNJLNCB;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KBOBNFNFBBF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JAPIPHNLPHN;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid OCJPLLPCNMD;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid CEHHLFACOIO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IJOJJPLAIPF;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid OFCDDKBLIHJ;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid ADHJCEJEOLN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid KOBJEBDJOKP;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid OPOOLBFOCGN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid MBKBIBDDPBL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid LFLBHDMFOOG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid CPFOHLPMCHI;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KJEHNGDPLJN;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid DIMNNJIKMFI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MBGENNNKIND;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid IBBMFMMFHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid JCGFKNNJBLL;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid INDLFDJOBOA;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid AMJIEFEBHPC;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid MODALPKIFHL;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid DICMLKEELNH;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid BKICDALIHHH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DNAFLMNJCCF;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid BLOLOKDOLON;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid ECCOLLNPJGH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid MGPEPCLMIIL;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid FFNGDOOHFLB;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid HOEFIMONIIC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid NHEFICEAMHC;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LJLAOBFEHDD;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BBOOCBLKPOO;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid FDFABKEGKBF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid MNDCLCPNENG;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid ALIDHGHALMK;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid GGCHCNHPBJI;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid EJDDPKGIPEL;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PKGCEKAFPNF;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid KHEKPIDIDDJ;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid IADIMAIJBBL;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid AGLGPHCFFHJ;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid DJLODPIOJMJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid BCGBBLIMNBK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid OJNDBKAJHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GDLKNLLFKDO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid NGJLGJJJEPF;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FJGKEDJGAPB;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LHMILGJGICE;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid IALDDBNNANK;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BINOAELNCEI;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid HALFLOFEHCC;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid OFFDGHNAIOD;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BILDDLNKHEM;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid FGCLJCDPONN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid ANDIGKLJNFD;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid HBBLBPDEGFM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid MBNFIPNKNNK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid GIOKOICABJO;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid EHMOBGHBHFO;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid LLCOFCMLHBI;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid CADKDFCCALK;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid COKBICMDFLB;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid LOBDAMINNLO;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid HECHJPELHEK;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid OCHBKDJMKED;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid CEGLJPPKGFO;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid CFJHEDHAPGM;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CHJBLHFKFLE;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NBHHMLBHMGJ;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid CKNCFLPAMDD;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid GHHEGBEGNME;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid IPAJLGAOAKA;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CPIEAEOMFKE;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KPDPPIHPIOK;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid MOCEJGEKGPN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid AILKNCKACFK;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BDMBOKIMJOB;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid LAEBEPHJCBG;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LAEBELNBEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CMKOLMMDIPA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid OBIJLHCMFLL;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid DANECFGGOOO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid ALFLLMHPGDC;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid MJLAGJOHDEB;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid PJFABLNMLED;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid MKJPDEMDAFG;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid CDHPHHNPCJE;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<Guid, GBGGDKPOLHH> LEPLOOICDND;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private static readonly Dictionary<GBGGDKPOLHH, Guid> FLGOLPEPLLN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, GBGGDKPOLHH> HAHEDJDHGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61582A0", Offset = "0x61576A0", VA = "0x1861582A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<GBGGDKPOLHH, Guid> NNGKDGBPAND
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6158300", Offset = "0x6157700", VA = "0x186158300")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OJDNPDAPAEB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x615DB10", Offset = "0x615CF10", VA = "0x18615DB10")]
	public static bool GOEFIHMGLJH(JNBCEHNJAHL DKCFFOJFDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x615D760", Offset = "0x615CB60", VA = "0x18615D760")]
	private static bool GOEFIHMGLJH(OCMPEAPAOIJ NCELHEHEEBE, JNBCEHNJAHL DKCFFOJFDPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct PMAKODLLFKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly MKGONMAKPOP NFLCOONKBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IEnumerable<BIGDCOAAKFF> IIKIGIPGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly IReadOnlyList<BIGDCOAAKFF> DLFOPOABEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly CEECNPFCENP<MCMKDNBCCKK> DJLMGNOEOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly IReadOnlyList<GOKHJMFPAGK<HELLJKJMNFC>> OPNLOEEGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly ByteString LDIODFLFCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly BKDFAGEHBLO PJIDAPEJHOP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x615DC40", Offset = "0x615D040", VA = "0x18615DC40")]
	public PMAKODLLFKB(MKGONMAKPOP GIJLPAJJMAB, IEnumerable<BIGDCOAAKFF> NKKBGAEACAL, IReadOnlyList<BIGDCOAAKFF> HHKPGPEFIOO, CEECNPFCENP<MCMKDNBCCKK> FPPDNFNFKBE, IReadOnlyList<GOKHJMFPAGK<HELLJKJMNFC>> EPBMNOLBIII, ByteString OBGBICMFCEM, BKDFAGEHBLO IDAENCEBDLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DAEOOAIMOEJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JPKMBJIHNJE FLKOGFDGJDF, [Out] Dictionary<int, int> KJBBFENAMOP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(MGKNMOMBPMH OHMKHNFOPHK, AHOOKNIONID HOGEFENBJNA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JBGICJBDPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public readonly Guid DCGMOFGBOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private readonly Dictionary<Guid, Guid> MOEADDNJGIF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FDFCBEIEIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x358AD20", Offset = "0x358A120", VA = "0x18358AD20")]
	private JBGICJBDPIA([In] Guid EKGONJIAGPB, Dictionary<Guid, Guid> ILHDKDIKOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x615AF90", Offset = "0x615A390", VA = "0x18615AF90")]
	public static JBGICJBDPIA HEEJNBCKMLL(IReadOnlyDictionary<Guid, Guid> ACOIOBJKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x615AA20", Offset = "0x6159E20", VA = "0x18615AA20")]
	public static JBGICJBDPIA BIAMBLDOIDG(IEnumerable<KeyValuePair<Guid, Guid>> ACOIOBJKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x615AEE0", Offset = "0x615A2E0", VA = "0x18615AEE0")]
	private static Dictionary<Guid, Guid> CLKNOJGGFDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x615ADD0", Offset = "0x615A1D0", VA = "0x18615ADD0")]
	public Guid BKDNJLFGFMB([In] Guid GFLAAGJEJNJ, bool KOJONEHLGIJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x615AFA0", Offset = "0x615A3A0", VA = "0x18615AFA0")]
	public bool JJICNJOLBAD([In] Guid BFMGPLIBCKL, [Out] Guid PJOEMABOBAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HMCALOFNCPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GBBOKMIJDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMCHCKHHIFC(ByteString DLLPIJIIKNF, JBGICJBDPIA BMNLDHEBAHL, [In] GJDFICJAJLG CBCDBAMPANM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KJLOBACKIPO
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
public static class MMNOLGIONAD
{
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly HashSet<GBGGDKPOLHH> NFMAHBGLOFM;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LOKKIOOCPPE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> GMGJHDFALLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> EHCBFGLAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public LOKKIOOCPPE(IReadOnlyDictionary<Guid, Guid> LDHNBNLIHAL, IReadOnlyDictionary<Guid, Guid> FDHKCLHAJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AMHGDDNINCE
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6154FF0", Offset = "0x61543F0", VA = "0x186154FF0")]
	public static MFJGGHGIICB BJKFLMADBKH([In] PMAKODLLFKB PNBLCMNEPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6155460", Offset = "0x6154860", VA = "0x186155460")]
	private static void ECNHADKBNBF(MFJGGHGIICB AFDDOIKHMPK, [In] PMAKODLLFKB HBOAFEBMDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61566D0", Offset = "0x6155AD0", VA = "0x1861566D0")]
	public static bool LLIMHGNJHMA(MFJGGHGIICB AFDDOIKHMPK, FEAIMBDOLPK IHPJBHJDJHK, JBGICJBDPIA? DELBLJOLBJB, [Out] LOKKIOOCPPE? ILHDKDIKOME, [Out] string? NBDBHDLNPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6155AC0", Offset = "0x6154EC0", VA = "0x186155AC0")]
	private static void HPEPADOJAKI(MFJGGHGIICB AFDDOIKHMPK, JBGICJBDPIA? EBFPBAHOJAP, FEAIMBDOLPK IHPJBHJDJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61553F0", Offset = "0x61547F0", VA = "0x1861553F0")]
	private static void DLPCFBAKLAF(MFJGGHGIICB AFDDOIKHMPK, FEAIMBDOLPK IHPJBHJDJHK, IReadOnlyCollection<ByteString>? LDAIPJEMPKJ, IReadOnlyCollection<ByteString>? KDDNEHGJMIC, IReadOnlyCollection<ByteString>? JBDMDOKEEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6155D50", Offset = "0x6155150", VA = "0x186155D50")]
	private static bool JMDNNCGBNEL(MFJGGHGIICB AFDDOIKHMPK, MGKNMOMBPMH OHMKHNFOPHK, FEAIMBDOLPK IHPJBHJDJHK, [Out] string NBDBHDLNPOA, [Out] Dictionary<int, int> KJBBFENAMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61563F0", Offset = "0x61557F0", VA = "0x1861563F0")]
	private static Dictionary<Guid, OCMPEAPAOIJ> LCJKFHDMGAM(MFJGGHGIICB AFDDOIKHMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6157D50", Offset = "0x6157150", VA = "0x186157D50")]
	private static void MCABKBMIONL(bool ICEPBMFJHJJ, BIGDCOAAKFF IMAEGLAPIGI, Dictionary<Guid, Guid> FKIHEDIHHFD, JBGICJBDPIA ABCCNINJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6155160", Offset = "0x6154560", VA = "0x186155160")]
	private static void DLCFNDIKPHN(BIGDCOAAKFF IMAEGLAPIGI, Guid BMKAAAENICD, EFNHMENPKEI? IICCLPICBGL, Dictionary<Guid, OCMPEAPAOIJ> LJJEPFOCJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6157DF0", Offset = "0x61571F0", VA = "0x186157DF0")]
	private static void NGCJJAFLHBL(IEnumerable<BIGDCOAAKFF> EOLIBMJJOIF, IReadOnlyCollection<ByteString> LDAIPJEMPKJ, IReadOnlyCollection<ByteString> KDDNEHGJMIC, IReadOnlyCollection<ByteString> JBDMDOKEEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FEAIMBDOLPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public bool ICEPBMFJHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public BKDFAGEHBLO IDAENCEBDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public EFNHMENPKEI? IICCLPICBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public EFNHMENPKEI? CKCCKABKBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public MKGONMAKPOP HAEBEPELPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public KJLOBACKIPO DJDFFHGNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public DAEOOAIMOEJ NPINAFCEGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public HMCALOFNCPB OKMMPIOLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public GOKHJMFPAGK<MCMKDNBCCKK> JEPFBAAHOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public PELBMOOKELN MGHJCCHNDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public List<BIGDCOAAKFF> HDABEMHEHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Dictionary<string, object> FGNPJKKKIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public BKAPJAGEEGC PCHDPCPPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public bool OFJALDMDKPG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JGKDFMKADBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x615A630", Offset = "0x6159A30", VA = "0x18615A630")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EFNHMENPKEI
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private const float KLDCMJLLJAO = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Vector3 CJBHLOLHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Quaternion APMJJPLCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public float FHPLKKAFLOA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 EEHPDHKEMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6159F70", Offset = "0x6159370", VA = "0x186159F70")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GJDFICJAJLG JAPPNDHLALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x615A490", Offset = "0x6159890", VA = "0x18615A490")]
		get
		{
			return default(GJDFICJAJLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9DDF80", Offset = "0x9DD380", VA = "0x1809DDF80")]
	public EFNHMENPKEI(Vector3 CJBHLOLHNJP, Quaternion APMJJPLCLEP, float FHPLKKAFLOA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x615A560", Offset = "0x6159960", VA = "0x18615A560")]
	public EFNHMENPKEI(GJDFICJAJLG MOPMDJINIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6159C60", Offset = "0x6159060", VA = "0x186159C60")]
	public static EFNHMENPKEI CAFJNCBGHNL(EFNHMENPKEI NCGFJMKBOIN, EFNHMENPKEI FFNFNILHJMH)
	{
		return default(EFNHMENPKEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x615A470", Offset = "0x6159870", VA = "0x18615A470")]
	public static EFNHMENPKEI KAHNABMFJPM((Vector3, Quaternion, float) FLKOGFDGJDF)
	{
		return default(EFNHMENPKEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x615A310", Offset = "0x6159710", VA = "0x18615A310")]
	public static EFNHMENPKEI KAHNABMFJPM(Matrix4x4 FGCIMJDEIDG)
	{
		return default(EFNHMENPKEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x615A4D0", Offset = "0x61598D0", VA = "0x18615A4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x615A080", Offset = "0x6159480", VA = "0x18615A080")]
	public EFNHMENPKEI GKKBHDJFGKD(Matrix4x4 KDNNBEIJOEO)
	{
		return default(EFNHMENPKEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x615A2A0", Offset = "0x61596A0", VA = "0x18615A2A0")]
	public static EFNHMENPKEI HIICJAEPCNN(Vector3 CJBHLOLHNJP)
	{
		return default(EFNHMENPKEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6159EE0", Offset = "0x61592E0", VA = "0x186159EE0")]
	public readonly ACOHAKLONJE COKAMLKJIEG()
	{
		return default(ACOHAKLONJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HBIEMINIJMC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x615A680", Offset = "0x6159A80", VA = "0x18615A680")]
	public static EFNHMENPKEI PCALCLFLMNI([In] this ACOHAKLONJE MEEBIDIALDO)
	{
		return default(EFNHMENPKEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LHNHNHLHBAI : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x615CA30", Offset = "0x615BE30", VA = "0x18615CA30", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x615CAB0", Offset = "0x615BEB0", VA = "0x18615CAB0")]
	private void KLPNODODCBG(Dictionary<Guid, Guid> CAFLMFHGBOK, KJCBAOLDIGA HNDFFJIPGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x615D090", Offset = "0x615C490", VA = "0x18615D090")]
	private void KLPNODODCBG(Dictionary<Guid, Guid> CAFLMFHGBOK, EJBFNMGLJEJ GGIDAEPFEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x615D0F0", Offset = "0x615C4F0", VA = "0x18615D0F0")]
	private void KLPNODODCBG(Dictionary<Guid, Guid> CAFLMFHGBOK, ABBBFDPBOOB ANLDOHODEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LHNHNHLHBAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class BHDIOGADLNJ : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6158360", Offset = "0x6157760", VA = "0x186158360", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public BHDIOGADLNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class MGGNAPADNIN : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x615D370", Offset = "0x615C770", VA = "0x18615D370", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public MGGNAPADNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class IMODGOIDEIF : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x615A8D0", Offset = "0x6159CD0", VA = "0x18615A8D0", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public IMODGOIDEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class KGMJOBPGAGE : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x615C760", Offset = "0x615BB60", VA = "0x18615C760", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public KGMJOBPGAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class CEMBIFOPHDC : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6158400", Offset = "0x6157800", VA = "0x186158400", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public CEMBIFOPHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class JGALCJKLMFE : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x615C5C0", Offset = "0x615B9C0", VA = "0x18615C5C0", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public JGALCJKLMFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DGEDJIFLEDO : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6158670", Offset = "0x6157A70", VA = "0x186158670", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DGEDJIFLEDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JEKJCMICCIC : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x615B010", Offset = "0x615A410", VA = "0x18615B010", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public JEKJCMICCIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HKNIBFJFHHK : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x615A710", Offset = "0x6159B10", VA = "0x18615A710", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HKNIBFJFHHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class OPFKHGIAABI : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x615DB40", Offset = "0x615CF40", VA = "0x18615DB40", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public OPFKHGIAABI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class DGDKEMIFKCG : NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly AKKBHCODENJ HEICDDBKLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6158540", Offset = "0x6157940", VA = "0x186158540", Slot = "4")]
	public void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DGDKEMIFKCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct JNBCEHNJAHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public MGKNMOMBPMH PAKIAOEKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public JGJPKKIFJJF IGIJCMBMNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public Dictionary<int, int> JFOAMCIGJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public Dictionary<Guid, Guid> LEIENEGGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public BKAPJAGEEGC PCHDPCPPMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public bool AKEOPEJBMIG;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NKEDGCJJCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFLAJHPAGHN(LCNNKHCDKND GKPEBPKPIBC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class POEDEACLHPC
{
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private static readonly NKEDGCJJCBP[] JIDOOCIDGEH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x615DCD0", Offset = "0x615D0D0", VA = "0x18615DCD0")]
	public static void AEDNCDNDLCL(BIGDCOAAKFF FLKOGFDGJDF, Dictionary<Guid, Guid> DEGIJHLIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x615DF60", Offset = "0x615D360", VA = "0x18615DF60")]
	public static void APKHGCAHMCJ(BIGDCOAAKFF? FLKOGFDGJDF, JBGICJBDPIA BFGBNKMOMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x615E2C0", Offset = "0x615D6C0", VA = "0x18615E2C0")]
	public static void BAHNHGIAHMJ(BIGDCOAAKFF? FLKOGFDGJDF, JBGICJBDPIA ABCCNINJDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x615E5A0", Offset = "0x615D9A0", VA = "0x18615E5A0")]
	public static void GOEFIHMGLJH(LCNNKHCDKND GKPEBPKPIBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LCNNKHCDKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public MGKNMOMBPMH CKFFOENPONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public BIGDCOAAKFF IMAEGLAPIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public Dictionary<int, int> JFOAMCIGJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public Dictionary<Guid, Guid> LEIENEGGBBI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x615C980", Offset = "0x615BD80", VA = "0x18615C980")]
	public Guid OGOOOMLGINA(Guid GFLAAGJEJNJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BKAPJAGEEGC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int HDBMLMBMDGE, [Out] Guid OJKBMLGAOMM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JFEALAHABGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<string> PPILAHGOOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly Dictionary<long, int> PGJCPBDEPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private readonly HashSet<Guid> PAODEMHPAPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> PAMFDCDNPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> OGFHCNCJFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x615B240", Offset = "0x615A640", VA = "0x18615B240")]
	public static JFEALAHABGJ DNDAIAOCMDL(DFCHLNBLLMO HADHNEGDEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x615B1D0", Offset = "0x615A5D0", VA = "0x18615B1D0")]
	public static JFEALAHABGJ CHJGLCBDLEH(MFJGGHGIICB KHNPGCMAPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x615B480", Offset = "0x615A880", VA = "0x18615B480")]
	public static JFEALAHABGJ HGIGAMFIBBG(IEnumerable<string> PPILAHGOOBB, IDictionary<long, int> GELAGCGINAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x615C4A0", Offset = "0x615B8A0", VA = "0x18615C4A0")]
	private JFEALAHABGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x615C360", Offset = "0x615B760", VA = "0x18615C360")]
	private JFEALAHABGJ(IEnumerable<string> PPILAHGOOBB, IDictionary<long, int> GELAGCGINAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x615B7F0", Offset = "0x615ABF0", VA = "0x18615B7F0")]
	private void INCBBGKMODB(DFCHLNBLLMO HADHNEGDEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x615B600", Offset = "0x615AA00", VA = "0x18615B600")]
	private void INCBBGKMODB(MFJGGHGIICB KHNPGCMAPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x615BDE0", Offset = "0x615B1E0", VA = "0x18615BDE0")]
	private void INCBBGKMODB(CDCJAOLLGLH? BEOJJJNJFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x615C120", Offset = "0x615B520", VA = "0x18615C120")]
	private void INCBBGKMODB(MKNFDCLJGPM? HBIAHPFPLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x615B9F0", Offset = "0x615ADF0", VA = "0x18615B9F0")]
	private void INCBBGKMODB(BIGDCOAAKFF? IMAEGLAPIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x615C2F0", Offset = "0x615B6F0", VA = "0x18615C2F0")]
	private void PHPIBHLHHEK(string? NNNIBCOAFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x615B3A0", Offset = "0x615A7A0", VA = "0x18615B3A0")]
	private void EEOLBECEFEM(AOKHGHKKKDH? KKFJLPHOPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x615B2B0", Offset = "0x615A6B0", VA = "0x18615B2B0")]
	private void EEOLBECEFEM(MDKKCEDOADD? KKFJLPHOPBA)
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
