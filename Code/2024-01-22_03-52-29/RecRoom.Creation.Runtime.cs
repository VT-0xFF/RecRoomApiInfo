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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FD50B0", Offset = "0x5FD44B0", VA = "0x185FD50B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MBCOMBMCBMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> EFFPKDBHNLG;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> EFCGKIDDLGC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string CBADDJJBAKH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EGDDJKCHMDP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string HIJFJKLDFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2F80", Offset = "0x5FD2380", VA = "0x185FD2F80")]
	public static bool LKNAJIBDCIC(Guid NODOCIKOMIO, int NLKPMLDNPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2900", Offset = "0x5FD1D00", VA = "0x185FD2900")]
	public static string IFMLKNDPJLD(Guid EFNPBHMDENF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PCNDDFIDHMM]
public enum FHHJKBKPGKO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COSTUME_DUMMY_OM,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JCAPLBPMPCL
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid AHDOKFIICOH;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid MKGEHDOAHNC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid ECLCLPKCJOE;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid MEPDLEJHEHN;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid IMLEHGHICNP;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid LPKIMGFKHHC;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid JDIFFNCCBDC;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid ACFPBKODEFG;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid HCCCAMOJFOB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid CNGDOGFACHA;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid HDCLJPBPCND;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid CLPIOMPENEO;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid PHBEBJOHDFI;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid KIHHFLAENFI;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid EAAMKLNAAMD;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid PANPMIGCODC;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid DGBBPFDJODA;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid BNPDJMAMAPA;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid ALBFJOEKBNB;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid NCNHLFODCIB;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid JMABAKHDPJL;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid KMBPOHHODML;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid EMMKHGHMKNM;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid NLHGKCGKPGA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid DBKNOCEGJNM;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid KBELNLMOCBG;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid BPEEDGPIGNE;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid HFDDJIIDDAJ;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid LEFOEDNBPKA;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid HFMKNAJHDDB;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid GFLNIOIPFPP;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid GJNPLENEHHD;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid MJMEBPJDDLD;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid AODJIGLNLOC;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid OFGAPAEMAPC;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid FAJJJDMKNGH;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid OGOLBPNCBDN;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid HGGFNPAPCDH;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid IFGOGDINPLH;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid GHMBOPPJIBI;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid DKIMFNEJOOJ;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid MIMAMFPEIMB;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid BGFNCMCPCNC;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid COFKOPEBGMJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid KPEEEEEKIGI;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid PKILIHCMGIH;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid PPAJFFKOLEF;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid JBBFKIMCFDI;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid IIACNBNIDNK;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid OGJENJDBICL;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid MDEFMHPHHMC;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid JNJCNKKHEHB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid EOBPGDOACNN;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid CECHAPOIIAC;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid JHMJCFJHHBM;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid EPDAKJHMELM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LDGMJNLGGMC;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid LHDGHADDKEL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid CGFCMHOIEKC;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid EEAADFPHAAD;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid PEJHALEAODN;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid BNMEHLHAOKP;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid FHOOLPKNLHA;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid LJDIIFJIEOK;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid PKOHGPGIIBG;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid MEJPBAJKKNO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid ONLANPJAKNI;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid LPCBOHBFGIF;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid NPEDJEGNEPG;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid KJAEGKFIBJF;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid NDNDFIHGLOJ;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid FLEHEDJIOJM;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid PCGCJELIDLF;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid LKEFJAHHIJO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid DBLDOKLDFJC;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BFODMHNDENF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LNACFAJGGMO;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ICJOOKBFOOO;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid KGCGPPMEDGG;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid CLEFHGPEEIE;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid LAIIIPIANON;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid MELJEGCEDPH;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid ECBBOFAKEAI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid OMIOJFMPLDF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JCLAENIJEAD;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid JPFOJMFHPPA;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid DNDGFMKBCBB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid INFLCKAAOHC;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid OHELLNINCFO;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid GJAKJOKCDEF;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid ENJIHBECIFI;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid JHMBANIGAAG;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid BFLIJFODJNH;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid BCPMFANBDLL;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid JCPJFMNNDJO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GCBIOANNBPN;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid BGCIADPOCEA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid OEEJGJGMGPF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NDONBKGOGMH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid NKCDCDALDJE;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EBFNJKNDLBM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid OGDJLIFJGCN;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid DHGJNOEPKIK;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid AMCBJCEDFBG;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FIPDBILDMPG;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OMNBCBPNLKH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid MAGEJOBCBHB;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid DCFOIKOKPLO;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid DJDKGLEJFCN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid JIEKKOPGDBO;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EGLCJJAPBHG;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GOKBPEBPKLF;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid IEGOMEJGELB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid HFKKMBENLNA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid DICPGANINHP;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JLEELBELMKC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid GJPFEGHPECJ;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid EBEILHKFDAP;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HKALINHICIH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid EBOENEAGECM;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid IBGDNFJGEOK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BFDJBIFLBIC;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MMCHJJAFDDM;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid CNJPBMHPHAH;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid KCMBKAJHHAN;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid GMABOHOCMNB;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GHPIPOIBDNB;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MGBMLANGGIE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid NKEEGGHCMPF;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid NAAKKPPIDFN;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NFPEFABLPMG;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid JCGAPDPLCIB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid NFGELADKLAG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid NLNDOEEHALD;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid KILEDEDCOLH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BCOOLBNLIBH;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid HHIAGFELGML;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid AJLLPJCGPLL;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid LDDMCCLPJLL;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid OJJDGEPHGGN;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid GKFKAADDCFC;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid IOOHAJBGDKL;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JFMMKBHEJDN;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid BKOALJDPNIO;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid HGLIJKOAEEM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid FGHKDCKBCII;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid KLDJECDAMKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid NBCLAALAHEN;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid HNDOFOFLMOO;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PDBEEMDKDLI;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NCKAKBNGCOO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid KNKICEPOINE;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid GOIEBEOIODD;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid NKMJEGKHPHP;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid ACMAKHACLOP;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid DIJOBJOBEKH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid BFIGEMAKGAE;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid BIHHOOHHAOH;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid BGCLENCBIAO;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid LHCFHLNDDIA;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FNDCGHGJFEL;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid GKNPGECMKEE;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid MNCBKBFNPPD;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid BBNOFHDANJN;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid BHGMIGGIOFC;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid IFKAEOGALPM;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid AAMMGAOMCGH;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid LPGKNKIHLPM;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid DAGPAHNBOMG;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid PEEFEBGICJG;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid GMGNPMGOKNC;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid NIDNPHBAHEE;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid AFPFDHEJMIC;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid PCPCBNGLAEL;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid KEONCIHDHLK;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid KBPJFNFCOHL;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid HFKLIAJOCDG;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid FKKJJEDMDFO;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid NFLCPIPNBBL;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid AEHNGODDHLO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid DJJCIMPICPL;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HFEHEDFOLKE;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NOHDNCDGMNE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid EJKNFLPNOJP;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid DAIMPINNINL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid MHHBPOJEEII;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid OLNDAFJKNBO;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BMJIENIGOKL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MFBJJOBOHFO;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid FEJHNJDBAOD;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid JJBHFFBOCBC;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid ABGJMDKECJG;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid HDDEIJLBNLK;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid DAIPMACNCCI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FKBBLJCPNGK;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid GOBIDDAHMHI;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid NGDFDKIGJNG;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid HACBPIMHCNB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid ANGCCELBAGB;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid PFJHCFFJODA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid NMHLHNOIGHI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid POHCNGKJBPO;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid LCKLLEMNBPJ;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid JLGKFMGMBID;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid KDOBKKHKJJH;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid ELCDJNBACCG;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid FLBMJBBMCME;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HJCBCKDOCHA;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid MGPEECJDOCB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid NKNPFCIPPKL;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid ONPAKFEBAHM;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OJFHMCCIMOH;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid HOCKPNNHFFK;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid DFGMBKJMPMK;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid BBMPEHCOMEN;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid IBMBAHLHMGM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid CCGNNNGJJPC;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid JEAOGAMGKMA;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid OEGEJKFILHL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NJACBNNLFBC;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid EAMMMODKOEL;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid MPINHPNDINL;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid DDEIFPBAJOF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid HOJIOIEEJEL;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid GBIKJKOPCHD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid NLKMNEHGGNN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid IHGPLKIOKLK;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid BBINDEFMGEF;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid HGGAMBFIAJB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid LLPOPBPCNGA;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid LPGGPBCPIBP;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid DKEFMGCBMBD;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid DDOCAHKHCNN;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid FMGLFAOABIO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid LAPOEABDNJM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid BMGCJPKKCAL;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid JNMEJINJACM;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid GCKHADOGHMC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid OMGCGNBKKBL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid EGFCEBCFEEF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid PNGIAFCHEMD;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DDJBIOPKNAP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid JMEOIDPFCIK;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CFCNDKJFPJD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid CEAIKMECLIN;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid EGBCLCHJOAE;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid AHIEGECMLNC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FBCBPFKHIIC;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid AEFMLPEHFBB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid FAOADAFFAON;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DGNOAIGJLLP;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LKEGILCGOPI;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid JFFHBCJLHFI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PHFEGAGIHLB;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid JFEDNKMMKOB;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid NFMCLCJOPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid FBBEMCPMGJN;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid GCHPBKKIKIP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid IPDGGCPLGBK;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid GFBHCABMALL;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid CGBJCNDKAIK;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LIBIGHKHOLO;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid JKKPIDMGAPG;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid IDNLACKKPJK;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid IIJGJHOFAFB;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid GIOJEFNDFGH;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid OEABFKHPCGH;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid PDDFOBJKOKK;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid APOPNBPLNBD;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid KNEBOBCFPDB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid HOBEEMNFEJI;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid PAIJAPBAGOA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GEFDMBPEHMI;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid AGDMNBFCKPF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid MOHJMAFLAMH;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid OIJDGOOAHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid KKIBIOOAIEM;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid ACBBPCBPFOL;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid PHAEOHFBGCN;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid LCLIKHFHKLJ;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid IKPCAKPNPEB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid GMHBBIKDFGE;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid CIIKOJFMLMH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid OJENPNGBOKC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid ECPMHAIAEIO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid PKOHPFNCJBG;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OCBLHOBGMGI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid FBEHDLMDECB;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid KDOMMAAFOEO;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid PBJGBFDCIFC;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MLDEFDENFBO;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid MEGNNHFLNMI;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid CMGPKNHHDEN;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid LICKHOKHEPA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid PJGAPDHBPCI;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid ANNNKMJJHAL;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KCHJENIKFFK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OLHOKHJBPHH;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid COMBJKMKOFI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid CKGNAFBFPLK;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid ICBJOFIKHNE;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid DOBECBLBKFE;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid ENFHAGOJNDC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid HPGHNDGPNOG;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid COLIKBCBEJD;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid EFEBLDEJKCK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid KAIDEIOFNGK;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid MNLMLHONDOF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid FBLENAKONMN;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid GKDJNDBLONF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid KNHKFFFCLDF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid FINDDHOEHKF;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid MBCJLMOIBIN;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KJOKIENPCAM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LOHMNDFEDFG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid HPIAEFHDGID;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid FHNHMNLJHGJ;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LLBDEAGLNKC;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HIHONLAIIFG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FECLDLNKPGF;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid AKJOIBCOJCO;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid MCCJAIKGELI;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GMOMMHPGKIO;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid POPABODHDGP;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid FMECKHAMPPH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CKHNCNFGOOK;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid JBABEINMBKI;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid MAFCFFILNLD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HODOEKFBOFC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid MIAGDDAHBID;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MPMDAMKFLNM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid EGKBNLHIAAH;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid AHHHMKKOAGG;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid OPIPOGDNLNI;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid OCAMEAKEDNG;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid JNDHFNOJICM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GMCNAFNCKKM;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid DGCJPOKENHL;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid DBOLDAJNCMK;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid LCCNIDAALKF;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid GHEAHBDIGGO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NMLGJGFBFOI;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid CDMJBCFPFAB;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid LGNOMLPCHKN;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GNFFPEOABMA;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid PMEHLCJEAFA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid NNBHOACAJJH;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid NCHKBPBLCCP;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AMNLFPNLFJC;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid FGEHPALPMDF;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EKIGPHGOEPL;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid GDMAFOMMAMJ;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid DBHKFNJDNFC;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid AFPBGNMOAHH;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid HGPIOOOJCJM;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid HEFBEEKNELG;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid NMCBJNLJCAA;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JJDBJJFMDKJ;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid NHCIAGKJEIA;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid LMABIHCBPEL;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PFOPNAMOIJI;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PDFMMGIEPOG;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid OCIFFLPDKLC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid GIIAMHDEEIA;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid JEDLDBLANDN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid NALGKADLFHJ;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid PAFDDNKJHIO;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid DPKLDILJNKC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid KDLFCAHOBJN;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid MEAIPBAFAAC;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid AFELGDLMJIA;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JDMMEHCJCKP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid KOKCAFGHFFF;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid IBPMNPDPEJK;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid OOBHAGAAANF;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid PCPLNIFDOAI;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid JAPDOHAINHO;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid DGHMNMMONOC;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid GMHIIMFOBMK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DMJAEPGFAIK;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KPPBNPGPDOD;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid LBPKNJGLCBK;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HENCNAGIBAK;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KFMMJNOCPJG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid GIKJPGANOOA;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid ACLGBLEAMFL;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid MKDFJFLLICL;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid LDDLCOGBDED;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid FLPBBFFPICM;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EPLJBKBLJLH;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid AHBGPHBCDAF;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid IJMCBKBGCHN;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid AINAJFDCAIM;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IJJMGNIMOHN;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid CFMODBJAAKM;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid KJMJNOHPHBP;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid JELLGGNCAKB;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid LMPFFGDAPBA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid EIDFGACACFH;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DMCFGFFNDOO;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid OIKEEIIHHPC;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HLMCILKLGIM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid HKFBIDANKCC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid DMNEPACEPGJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid JMIIHPKFHNN;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid FEDCKKCBAOK;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid KEDFLGFPBEH;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid CEKFMAENDGN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EPIAGEHODCL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid BOMHFNILFDI;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid OAJIIGOJPPI;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid NJAPIBACNOL;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid CGGBMAIEOKH;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid LHGJFELHFMJ;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid PLHPJCOMOPC;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KCAPIPHHAMN;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid EPIAOMOGHIE;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid NBGKAHBKBCF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid EKFPLKNAMCM;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IBFOOHPNHNI;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid LDIOJHCHLCA;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid FDEFLGCKKGL;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid HNNGHLKHEDN;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GEJCFFPDFPH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid KNPEMIHFFHH;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid KGFANJAKFMB;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid AJKNELKGPJM;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid PBIMFKBOCJG;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid NKNNNJDDIIL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid BECAGDKLJCH;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid CDNCLMLHALF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid DHEHHFHLODN;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid HIGDNNGKAMN;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid EAEAIJDNMDP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid OCDOBAKOCCB;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FHGLIBNDNEC;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid JANMIABOODI;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid OKHJBMDOJPE;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KIPHEICNKGO;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ILOADECBFML;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid FHCABMGDBHJ;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GFEMCCDBGKH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid BFACFFIMMIL;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid AFHCBMAGHHD;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid NCJMPOLHDKK;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid LOGFNOPIJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid COEBOFIOFPE;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid PHCMHEODBLK;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GJFLCIGKMGB;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid FDINMDHHAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid MFGJFCOHAME;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid KODNOAOFICH;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid DHIIGPDANDC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid ABJPCFFGJGC;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IKPEAGLOLJB;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HGKEJFKFDAL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KBOEKBALJBK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid AJFOGLLGNHK;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid OLMIOBHMNJK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid NFHELEKPHJJ;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid DAECJJLLMNI;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FDKGMKICACA;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid OCIPHJFFDHL;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid IPFJDJACEAA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid GHPAKBJBLIP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FHGLDLMICCP;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid MLMALKGEGLL;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid CDGPNDGJDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FJKCBKDHKAE;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid FCDMBABMONL;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EKNGMLNEPDG;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BGLCJGGNLCF;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid AGPJIIOPDNI;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid LIJJDDOHIIC;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid BKGILMNODID;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid EJEGFDAFIPO;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid AFMGGPCBDIN;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid GJAOGDMCFEA;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid EOKLINIBFEA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JNEOGNKLNIL;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid AKDELBCDGHL;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid GFMIMIFJKCD;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DHENNJFMOAF;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid LMEEEFPDLEB;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DDJBPHBHHLC;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid HCEGGFLBLMD;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid BAKDDGKHMPO;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid COGDPKCPFJE;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid OBBMFDGLLIM;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid JMFOOCHDPJB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LMDMLEEKGIL;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid JIAOLHDNEAK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid PEJPABEIGEA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid MHEEJOIBGNG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid GPOOHCAOHLC;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid EDLPMFCDNLD;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid JPIIBCPIGKL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid ILJMJOMIBPL;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IDMCPLPDHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid DCHLHOFOOHP;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid MCALKCIIENP;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CGFPCHEKHHM;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid PHFJFKMEHBG;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GPPOCHCJOEC;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid GNJEEFNODCL;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid NCDGFACNIHE;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JLOBJFDENNA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid IGGLKBMFDDO;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid FOIDDDAFKBC;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NMMBHPEEFAG;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid DMLADKJEOCN;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JANBJFNHDDK;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EPFGJFMBIBL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid ECCMELHFDCA;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid GLIBAKMOLHK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid NGPNOKNBDGM;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid BHKDDBHMDPB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid FOIJAEMPEED;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid GIACCEMCMBA;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GBODJJJHCHD;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid AHCPJJGPOPA;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid ICLFDLAOFOL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid PMMPAPGNDNE;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid NLJEJLOOAGP;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid EBCKHJNIIMK;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NHFPMBGIGEP;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid NGAJAKMNMOP;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid CJHBBGJDFGC;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid FKHNDOPFPHG;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid JMEMLFBOCHC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid JNPCDKGFEJP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid PIDFMLOPBKG;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid FGOKPMJLADI;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid MCPGBLAALPE;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid BEODMBCMPEE;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid FNGLLOLNJPE;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid LCNAAFEOBFJ;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid FFLNDADFDMO;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid DIIEBDANIIJ;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid HDDFGMMIDCE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GICHBEFKAJJ;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IALOGCLICMA;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid LODIGGBCPAC;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid PMIFALMOGAN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid AINNIBCHKNE;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid JLFLDENFLAO;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid PJIJBPHEDFP;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid DPHALGHNHDD;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid NMCPNCJDIJD;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ALLOHMJJIFF;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid HGLBEAMCNEP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid FNKOGKEGMKJ;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid AJKLKIHJLJA;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid BEEFFDOCDCK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid IOPIAPKFCIJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid CPLNIPNLBED;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JNENHONHDDN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid BELAHMINOOP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid GKKCHFDDJFL;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KMJDFLHDIAE;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid OHHDLADAIGH;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid IOIMNAOLGFB;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid EGEOMKGMPAM;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CIGJEDOPLAB;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MPLOBOOAOED;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid BPNDCILBEBG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid MJDBEMNEPLH;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KKMJFBJEDOL;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid HFGPDDOKOHH;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid CDBGGPHDFJE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid DAOPHOAJFEM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid GEJLAHHLKHH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid BDKKADLBAED;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid IBDJHABGEFN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid GHLNGHEPIHC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid OJJCBOLCHNO;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PAINJOMEGCF;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid CKDIOEOCOLC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid FFPMJPGNLLP;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid JJKHNMLNFJD;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid CBEELHPIJMN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid EMEHJBDHPHE;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid HGBADIHKLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid NNKLFCGLCCF;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid LGDPDDFDAGN;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, FHHJKBKPGKO> OPDMFDEHBIG;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<FHHJKBKPGKO, Guid> JAGOCNGEFCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, FHHJKBKPGKO> DLNKNOPBHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF2D0", Offset = "0x5FCE6D0", VA = "0x185FCF2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<FHHJKBKPGKO, Guid> IIGABEFMNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF270", Offset = "0x5FCE670", VA = "0x185FCF270")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HKAJMEAFFNF
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD620", Offset = "0x5FCCA20", VA = "0x185FCD620")]
	public static bool GAEMKEMDBHH(CLHIKJKKHHD GMKHIOLJBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD270", Offset = "0x5FCC670", VA = "0x185FCD270")]
	private static bool GAEMKEMDBHH(JBODPBEIODF HGKLPPPBEHG, CLHIKJKKHHD GMKHIOLJBKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct AGLHMLHLFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly EMNIIMAFOAI IDKGPGKEPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<KLJIPFAKCGO> AKJEAKDCCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<KLJIPFAKCGO> GBMJEFADBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly AFJMJHOPNGM<FKEJMIAIMND> GHBCAELGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<OIFGKAAGFMP<FJBFPEKHLHL>> CNIHHAFLEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString OJACBGMOMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly ILGHOHLPOAM KIKEOIEGLLG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBAB0", Offset = "0x5FCAEB0", VA = "0x185FCBAB0")]
	public AGLHMLHLFKN(EMNIIMAFOAI FEAOHIEMDJE, IEnumerable<KLJIPFAKCGO> FKJEHNNJPKB, IReadOnlyList<KLJIPFAKCGO> OPCNHICFOHJ, AFJMJHOPNGM<FKEJMIAIMND> KNBMGJBJOJF, IReadOnlyList<OIFGKAAGFMP<FJBFPEKHLHL>> OJOPABIHLLP, ByteString MGCJPKMCFHD, ILGHOHLPOAM AGCAECBIAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AOBEAPPCOMA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(ANBHPPKGMGP GMLIPIALCHN, [Out] Dictionary<int, int> JHDPDCEOOIC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(DGDKKFAPKLN LBLEJLCGCDF, MHOMJPFGMML EBFBGELNKCG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HDJLBMPIFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid JPLKKACCAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> LNFHMFAHGKC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> BKGCLLBNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33B8020", Offset = "0x33B7420", VA = "0x1833B8020")]
	private HDJLBMPIFFB([In] Guid PDAIFLLNEJH, Dictionary<Guid, Guid> KMMMEIHOLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCC70", Offset = "0x5FCC070", VA = "0x185FCCC70")]
	public static HDJLBMPIFFB HFAMILENOAI(IReadOnlyDictionary<Guid, Guid> OIOPBANPNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCC80", Offset = "0x5FCC080", VA = "0x185FCCC80")]
	public static HDJLBMPIFFB MKHJGOFBJLN(IEnumerable<KeyValuePair<Guid, Guid>> OIOPBANPNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCAB0", Offset = "0x5FCBEB0", VA = "0x185FCCAB0")]
	private static Dictionary<Guid, Guid> CAFFPJFAIPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCB60", Offset = "0x5FCBF60", VA = "0x185FCCB60")]
	public Guid EIAINKJMNND([In] Guid EFNPBHMDENF, bool GFDPGJOLHCN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD030", Offset = "0x5FCC430", VA = "0x185FCD030")]
	public bool PGEJGCNBMAD([In] Guid NONJEEALACK, [Out] Guid DDNHGPFNKFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LDDGHDOKOBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BJKMFDFMJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOEOGBDBLGM(ByteString PKBBOCAODJK, HDJLBMPIFFB EMNODFBMDIK, [In] JCNCEDDNMOO FJHMCHGAOAI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HDKCHILCGJL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class EEJHBODJCBP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> INJBGDLHPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> FHHEAJMHIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7999C0", Offset = "0x798DC0", VA = "0x1807999C0")]
	public EEJHBODJCBP(IReadOnlyDictionary<Guid, Guid> JAOHCLDFECB, IReadOnlyDictionary<Guid, Guid> EOCEDFLEMPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JNCDEKEABDC
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF9D0", Offset = "0x5FCEDD0", VA = "0x185FCF9D0")]
	public static KIAKEKFEBBA FANMENLDJLA([In] AGLHMLHLFKN CGJAGIEJGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FD02D0", Offset = "0x5FCF6D0", VA = "0x185FD02D0")]
	private static void JDLAFGECFEN(KIAKEKFEBBA POEOHECAHGP, [In] AGLHMLHLFKN BEGEKAAKHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0F60", Offset = "0x5FD0360", VA = "0x185FD0F60")]
	public static bool PNPLAEIFONH(KIAKEKFEBBA POEOHECAHGP, FBEPECHNKFA HGEEFNIDLBK, HDJLBMPIFFB? EBPCCEKIMEJ, [Out] EEJHBODJCBP? KMMMEIHOLPO, [Out] string? HNINMPIFBCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0CD0", Offset = "0x5FD00D0", VA = "0x185FD0CD0")]
	private static void PCPEPKGBPHL(KIAKEKFEBBA POEOHECAHGP, HDJLBMPIFFB? NGNAELFIBGE, FBEPECHNKFA HGEEFNIDLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FD09D0", Offset = "0x5FCFDD0", VA = "0x185FD09D0")]
	private static void NHGCGBAJPLI(KIAKEKFEBBA POEOHECAHGP, FBEPECHNKFA HGEEFNIDLBK, IReadOnlyCollection<ByteString>? LIDJLDPDCLD, IReadOnlyCollection<ByteString>? FFFOEICMFJM, IReadOnlyCollection<ByteString>? FBJFDFPMPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF330", Offset = "0x5FCE730", VA = "0x185FCF330")]
	private static bool AIMHAFDEKJC(KIAKEKFEBBA POEOHECAHGP, DGDKKFAPKLN LBLEJLCGCDF, FBEPECHNKFA HGEEFNIDLBK, [Out] string HNINMPIFBCK, [Out] Dictionary<int, int> JHDPDCEOOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFFF0", Offset = "0x5FCF3F0", VA = "0x185FCFFF0")]
	private static Dictionary<Guid, JBODPBEIODF> FHBKBHPMKFK(KIAKEKFEBBA POEOHECAHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0930", Offset = "0x5FCFD30", VA = "0x185FD0930")]
	private static void KNCHOOFFGPN(bool PJCKDEMBJIE, KLJIPFAKCGO EHOBCDNONMP, Dictionary<Guid, Guid> HHDBPDHAMGP, HDJLBMPIFFB CJALOMDFDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0A40", Offset = "0x5FCFE40", VA = "0x185FD0A40")]
	private static void PCLIAIEFNGO(KLJIPFAKCGO EHOBCDNONMP, Guid CCNLGPPMKJP, IAAHOLKMHEC? EFDJGAEKDMF, Dictionary<Guid, JBODPBEIODF> HDAEIPNFHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFB40", Offset = "0x5FCEF40", VA = "0x185FCFB40")]
	private static void FEDNKAEOIIO(IEnumerable<KLJIPFAKCGO> FICLFJPLCLI, IReadOnlyCollection<ByteString> LIDJLDPDCLD, IReadOnlyCollection<ByteString> FFFOEICMFJM, IReadOnlyCollection<ByteString> FBJFDFPMPBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FBEPECHNKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool PJCKDEMBJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public ILGHOHLPOAM AGCAECBIAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public IAAHOLKMHEC? EFDJGAEKDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public IAAHOLKMHEC? DOBMCIDKMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public EMNIIMAFOAI DKCLABEAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public HDKCHILCGJL FILHPAMKOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public AOBEAPPCOMA HFNCJBCKHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public LDDGHDOKOBO HEEDBLINCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public OIFGKAAGFMP<FKEJMIAIMND> BELFMHBJOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public NCFEJMLBHNC NHDPBGODEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<KLJIPFAKCGO> IABANIFPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> JNLNNJPCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public KMMOFIAFJCD MFEEFPEHAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool NKBJCLDKDEJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool ABIFBCGDCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBB40", Offset = "0x5FCAF40", VA = "0x185FCBB40")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IAAHOLKMHEC
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float KINHHFCDBIA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion GIJALKLADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float GLDPLANNJMB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 LBIDBBDJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD9F0", Offset = "0x5FCCDF0", VA = "0x185FCD9F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JCNCEDDNMOO ODBPGCMGEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD9B0", Offset = "0x5FCCDB0", VA = "0x185FCD9B0")]
		get
		{
			return default(JCNCEDDNMOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x934050", Offset = "0x933450", VA = "0x180934050")]
	public IAAHOLKMHEC(Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN, float GLDPLANNJMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDB70", Offset = "0x5FCCF70", VA = "0x185FCDB70")]
	public static IAAHOLKMHEC MEFOMFOKBIH(IAAHOLKMHEC AOGBEAODJPP, IAAHOLKMHEC GHNDBOLALMJ)
	{
		return default(IAAHOLKMHEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDDF0", Offset = "0x5FCD1F0", VA = "0x185FCDDF0")]
	public static IAAHOLKMHEC OOICJOKLJBF((Vector3, Quaternion, float) GMLIPIALCHN)
	{
		return default(IAAHOLKMHEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDE10", Offset = "0x5FCD210", VA = "0x185FCDE10")]
	public static IAAHOLKMHEC OOICJOKLJBF(Matrix4x4 FJBAMKBHLLB)
	{
		return default(IAAHOLKMHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD790", Offset = "0x5FCCB90", VA = "0x185FCD790")]
	public IAAHOLKMHEC ACGMELKGOAI(Matrix4x4 FIFLCPFGAIF)
	{
		return default(IAAHOLKMHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDB00", Offset = "0x5FCCF00", VA = "0x185FCDB00")]
	public static IAAHOLKMHEC FLCMGEFNBPF(Vector3 BCGGHPIMKDA)
	{
		return default(IAAHOLKMHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDF70", Offset = "0x5FCD370", VA = "0x185FCDF70")]
	public readonly GNLPJKAHBMM PGIEKBCBBBP()
	{
		return default(GNLPJKAHBMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LMGMJCEFCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2870", Offset = "0x5FD1C70", VA = "0x185FD2870")]
	public static IAAHOLKMHEC FICKGELECOI([In] this GNLPJKAHBMM LHCHBOKBAPK)
	{
		return default(IAAHOLKMHEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GBMPOCHAOBA : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC980", Offset = "0x5FCBD80", VA = "0x185FCC980", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC0C0", Offset = "0x5FCB4C0", VA = "0x185FCC0C0")]
	private void APBCFAFEFLG(Dictionary<Guid, Guid> BKNJGLECBGN, NHJLNEMJDIE IGIOMDIKBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC6A0", Offset = "0x5FCBAA0", VA = "0x185FCC6A0")]
	private void APBCFAFEFLG(Dictionary<Guid, Guid> BKNJGLECBGN, FLFPFPLNEAI AMCEHIEIDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC700", Offset = "0x5FCBB00", VA = "0x185FCC700")]
	private void APBCFAFEFLG(Dictionary<Guid, Guid> BKNJGLECBGN, MPJLLKHGHOH KLHKDJLNHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public GBMPOCHAOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HFMMCKIMEOH : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD1D0", Offset = "0x5FCC5D0", VA = "0x185FCD1D0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public HFMMCKIMEOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MPBLOPBBAEG : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3A60", Offset = "0x5FD2E60", VA = "0x185FD3A60", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MPBLOPBBAEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FICHLFNBDDJ : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBB90", Offset = "0x5FCAF90", VA = "0x185FCBB90", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FICHLFNBDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class GALMBNGDGJC : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBEA0", Offset = "0x5FCB2A0", VA = "0x185FCBEA0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public GALMBNGDGJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class HPGMAPCPCOC : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD650", Offset = "0x5FCCA50", VA = "0x185FCD650", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public HPGMAPCPCOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class LBAHKLBNEIM : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5FD26D0", Offset = "0x5FD1AD0", VA = "0x185FD26D0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public LBAHKLBNEIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class KFEKEDCNKFG : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5FD25E0", Offset = "0x5FD19E0", VA = "0x185FD25E0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public KFEKEDCNKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class PFCHJPBHHNE : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5130", Offset = "0x5FD4530", VA = "0x185FD5130", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public PFCHJPBHHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FIHILCCOLDF : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBCE0", Offset = "0x5FCB0E0", VA = "0x185FCBCE0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FIHILCCOLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class ACJHANLAFDF : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB9B0", Offset = "0x5FCADB0", VA = "0x185FCB9B0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public ACJHANLAFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HFGNPDCIGIC : JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly CFDDPFCCMNG COLOFLINHKA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD0A0", Offset = "0x5FCC4A0", VA = "0x185FCD0A0", Slot = "4")]
	public void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public HFGNPDCIGIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CLHIKJKKHHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public DGDKKFAPKLN IEOKPDEFBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public HFIGKDGFHIF FJBMAFDNAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> LACIBOMOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> BHCJIMDKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public KMMOFIAFJCD MFEEFPEHAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool PKKABGFJAFG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JOECNNDJCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJMGHKDEDFM(GDCGNNADODL PPKABFBJBHA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IONKGJFNKPF
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly JOECNNDJCPD[] MDBAHOHODLN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE6B0", Offset = "0x5FCDAB0", VA = "0x185FCE6B0")]
	public static void LHNCBCOFMLA(KLJIPFAKCGO GMLIPIALCHN, Dictionary<Guid, Guid> MAIFGNOCGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE940", Offset = "0x5FCDD40", VA = "0x185FCE940")]
	public static void PPCBGFPMNBI(KLJIPFAKCGO? GMLIPIALCHN, HDJLBMPIFFB HLPELEDCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE000", Offset = "0x5FCD400", VA = "0x185FCE000")]
	public static void DEJHAJEMFLJ(KLJIPFAKCGO? GMLIPIALCHN, HDJLBMPIFFB CJALOMDFDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE2E0", Offset = "0x5FCD6E0", VA = "0x185FCE2E0")]
	public static void GAEMKEMDBHH(GDCGNNADODL PPKABFBJBHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GDCGNNADODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public DGDKKFAPKLN CHEDAGNNKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public KLJIPFAKCGO EHOBCDNONMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> LACIBOMOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> BHCJIMDKHAK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCA00", Offset = "0x5FCBE00", VA = "0x185FCCA00")]
	public Guid ADHHLLGFGHL(Guid EFNPBHMDENF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface KMMOFIAFJCD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int FNJBDIDNEMB, [Out] Guid CPCGPFDFPHM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NMGJNGAHAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> JFINELKJJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> CHKHLDHANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> EOHNPDFLNAC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> ENFPNLOGFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> JMBHPEMNPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4DE0", Offset = "0x5FD41E0", VA = "0x185FD4DE0")]
	public static NMGJNGAHAFD JJHFKAKJMDJ(MOAAIJOHEOA BLCBNGIOOOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4D70", Offset = "0x5FD4170", VA = "0x185FD4D70")]
	public static NMGJNGAHAFD HGNHAIGPDJI(KIAKEKFEBBA ELEICICGMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4A20", Offset = "0x5FD3E20", VA = "0x185FD4A20")]
	public static NMGJNGAHAFD BLFNPFNCIJP(IEnumerable<string> JFINELKJJDP, IDictionary<long, int> BHDEEFEMJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4E50", Offset = "0x5FD4250", VA = "0x185FD4E50")]
	private NMGJNGAHAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4F70", Offset = "0x5FD4370", VA = "0x185FD4F70")]
	private NMGJNGAHAFD(IEnumerable<string> JFINELKJJDP, IDictionary<long, int> BHDEEFEMJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3BC0", Offset = "0x5FD2FC0", VA = "0x185FD3BC0")]
	private void ADLIKNHJMPN(MOAAIJOHEOA BLCBNGIOOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4320", Offset = "0x5FD3720", VA = "0x185FD4320")]
	private void ADLIKNHJMPN(KIAKEKFEBBA ELEICICGMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4510", Offset = "0x5FD3910", VA = "0x185FD4510")]
	private void ADLIKNHJMPN(KDFCDBKMDNP? MMKDJDGOBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3DC0", Offset = "0x5FD31C0", VA = "0x185FD3DC0")]
	private void ADLIKNHJMPN(EBGIKBNGAMA? LJOKPMONGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3F30", Offset = "0x5FD3330", VA = "0x185FD3F30")]
	private void ADLIKNHJMPN(KLJIPFAKCGO? EHOBCDNONMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FD49B0", Offset = "0x5FD3DB0", VA = "0x185FD49B0")]
	private void AFNHFAHLMAF(string? CJPNODEEJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4C90", Offset = "0x5FD4090", VA = "0x185FD4C90")]
	private void CKIJCDBMLIN(IENKNBKNKNM? EPIGOBHNMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4BA0", Offset = "0x5FD3FA0", VA = "0x185FD4BA0")]
	private void CKIJCDBMLIN(PAKLEMPFBIA? EPIGOBHNMCO)
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
