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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DAFB70", Offset = "0x5DAE970", VA = "0x185DAFB70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KHJOEFPIBHK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> BDAIICPGEAN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> JEJIEFBMAJG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string FLPDMBAPNGK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string OCAAIMNLJAO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string DDKBHICEOAK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DADEF0", Offset = "0x5DACCF0", VA = "0x185DADEF0")]
	public static bool JCAGPMBAOGE(Guid CDKNIOFMIMM, int FCDPHNOEICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD870", Offset = "0x5DAC670", VA = "0x185DAD870")]
	public static string BBOCNOLNFDJ(Guid CHLMGBPAGHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DCGGHMFAHHI]
public enum IDKGLLDIGLO
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
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DKACNJNOANN
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid NFCGJNLFCIA;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid JIEKABOLNGN;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid FKGMFKGGEGC;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid AIIDOCIEGOK;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid MAFEAHEFMDH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid KIKHOPPJCED;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid HEPJCJNJIAG;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid GPCGGCHKLJL;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid PDKIBEJGJJO;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid BEEEEKKIEPN;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid DIPHLPKEIKJ;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid CJBBMJJNMFD;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid HOALDCLNLDG;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid NJDANPBHGLA;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid GGFLLAHFMLB;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid NBFMJJLIBNM;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid CFKPDLKJNJP;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid IIJADMJLDFE;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid LMAMKEJOIOC;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid KNGGGDDAJPC;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid KMFPNDGNLBP;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid JCBLDJJJIJL;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid IHBEECOOACI;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid ENEEPEDKHJO;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid OCABLCDKACL;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid NFLNIBHOAED;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid MECEIMKPLEB;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid NIFOGMNIEOB;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid PMCKFNINHHP;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid OLHDBDGPOBI;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid JAJAFLEJAEE;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid CMCPNCFMJCB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid JDADOEDBIEE;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid LNLNKMKLGHD;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid LDEGACHELKH;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid IEFKMGJKMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid CFIJCGKOMMG;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid BDBHJOKDEFE;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid AAJELGBJBKD;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid MMMPKIALOCG;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid FLKKBHPHKAB;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid IDHJILEOALJ;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid PPGEOGNEJDN;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid JIHHFHOJIOM;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid ANDOBEPEAOH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid BIOGGHHABNI;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DDJOOAGBBMP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid NDCDMFFOMII;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid KCGFMLGHAFI;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid LENJPMFHNHM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid EIGGMDLHNIK;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid FOFADGOLEPM;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid AKIJINFIJDN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid BIODCGLFCNM;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid FFEOJKEHAGK;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid PKDCEKKIGJN;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid BOGPJHANLCN;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid MMEBOABCLOA;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid NMLGBMAALMG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid MCLJOGBAHJP;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid JHJDDOBDGEA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid KMGCFNGNLLK;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ENDINMKJCHM;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid GPAJJNNMEGG;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid BHJILABGFFD;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid APKGCLDCMED;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid BOCAMPEEHGO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PDKJCJFDHDC;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid POANMOIMEPF;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid LNPLIOHMIKL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DOGAOPHFDPE;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid FBNIKMCEBDD;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid HJFNIKPKNJO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid PAMHAPKKAKO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CLAJENMFFEK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid MCICEHBMNGG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BLPDMODFOLD;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid ICELABGPGJL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid JKHIGKLPGEB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid JKFLFDAJBIA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LNMAKLDEABE;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid GFIMPCNFOJH;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid OALCAMFJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid COBAIOECBAI;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid LNGDBMHAEGF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid KOIENDLKIPN;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid CJHGMACBIJP;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid PODCNLGKDBP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid DKIHCGLFFAD;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid OCAKGLBPDEE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid HPJPLOELGJP;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid FIIDDFMAOBI;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid IEHIKHKIPJI;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CGBLALOHOIG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid ABMHBLNOMJN;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid OODENMCKMMO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid PNEAEDKIBFD;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid PIAFOLDLLGO;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid BFEENLBJAGJ;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid JJINOKMHBKD;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BJMFPOFAFBE;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid EENKOMFEHKO;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JHKFHELJKOG;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid AIAPKKHBGGG;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid BKMGEDFOLEO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid GJJGPNKMCMJ;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ODPCLHPMFJA;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid NGOKDILOLJM;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid LMOJPMBKEDH;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid ILLKNGCALJP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid FENGOOFCECH;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid ALOOKPCNOIH;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GNOHIJKPBHD;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid OHFNDMOOJDC;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid OBAJNGLEBIB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid IDFDONKAOGP;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JKHFNBEAJKC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LICFEMHKMMG;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid JGEFMGMBKCD;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid NHOPGAHFMAE;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid LJKNIDFJMCK;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid KBFEJOPIJJH;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid LABFILKBNHB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid AGAGLJBEKMH;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid HBCMLGKHNJN;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid FNNIKCBECLH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid HBIDOLCONOH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid AAEFFKPAPHN;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid ODLAMGKJLIJ;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BILEHOLANAO;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid CLLJOCCJBOD;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NNAJMGCEBMM;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LENNALIKHAG;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid PKLNOMCBGEP;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid JPAJEABNELA;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GMPJGEBHAFG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid JPLLDBIKAIC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid OBDHAMAIAGF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid MOMBDDDEKEI;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid FKMNMMNOGDJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid LAFIBLCAKHE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid BNFKCLNIDCH;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid LIHBNGIIDNK;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid DFMAPLIIPDM;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid LDEIAEBLCPJ;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid BNNILMPBMGP;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid NMLJIILMNHE;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid EJNOKOLMCKA;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid FKEFMDKNDID;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid JJKMCGCFKHJ;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid NKNDIKGDNMF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JALALIGFNKI;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EGEKOEPLMBP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OGABHIKBGHP;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GFCHEBFPFPD;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NOBAICFDLMI;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid PHDELNFBFPH;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid LOFFLCHDIJN;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid CFHJKNJEOLE;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OFLEJACPEEA;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid DOHFLJMHDFA;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid KNCEMMFBBPD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid JGFJCEJPMDN;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid FKMMNPPJBPB;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid FHGDCPKHKPF;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid BIAGIHKGNFM;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid BAOEAKMLKPG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BMNKPILFLGE;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid CMKNFFDAJKN;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid HEGHPALMIKL;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid BGDKBADKPPK;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid LGMKHEJPCOH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IENIGOBCOMP;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BCJPFCPMJCO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GBCANKPPGDA;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GDAPFFIPGMK;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid LEPEDIBDAAN;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid MNCMIHFECAE;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid GAMKIJCFMGG;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid LFCEDFLCMAN;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid GCAFAJAINJF;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid MNBKNGMPEJL;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PFDGMMNNHGP;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid OGCGHCJCACO;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid GKDLPIHJGDI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid OKDFJJEPFOD;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid EDOGMIFOBNG;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid GFIINBCOOEK;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid IFLMAOGHMFP;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid AGBJOPJMBDP;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid IHHIACLMMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid BGLAMKAMCKO;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid KCJINONOMDC;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid DKFBBBFGMJC;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CPDHIGHPIMI;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid KLAOMPJLBGG;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid PJCEENMBKJO;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid JNNADCAELGE;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid DBKCCBMKKOB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OIKEKIDLBDG;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid DOMPBCEAKGJ;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid GCALGJEINHI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid ALCJFEMODEP;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HNIKPFOAKNB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid NLBLBAFJAHP;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid JMLKMDCFEFH;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid JEGHLBBOOAE;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BIGLBJLLIIO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid FAHNBCFDKMN;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid OPNKGIBINJK;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid IFKLJBFGLNG;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid MMONJLEFPDF;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid BEJDDCPEKBN;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid EKMFEPDIELC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid EHBJEMIOKPI;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid HFIDAOKEKJG;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid LNBDGLIMDKC;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IMMGNKMPKPM;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid PIHPGGLOPMB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid DMMHFIKMLFN;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid HGPPEFFGJPO;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid KMEDDCDDLIF;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid HCJGIOHFDMO;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid IKKCIKJCLKG;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid CDKLMIBFDGK;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid DNMHJMLIDAE;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid EBGJJKMMNDH;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid OFJDJPKBKIH;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid CNFEDJPACNO;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FGFGCIFIALD;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FKGINJOPEEI;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid JDBANBJLKKC;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid EEHOAIFOBEB;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid OEPFGCJJGGN;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid GEDPKDMGDIN;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid BBAMBDBEDHO;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PGFLFOJMCOB;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid JKCIJLDEHBA;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid BLAKJGHDGLN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid IIDOFEKBEMG;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid GBKPPAAMMPH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid HJJLKAKOACN;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid DPAHHANPBIH;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid BMFLKPADLEM;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid OIBFFFCLPJO;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid CNBICJEBBKA;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid LOKLBPNIOOB;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DDLMOAFDCKA;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid HDIEDJAEGFI;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid FHMECJDIJKM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid GNAAFCLBHNA;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid BCFOCLOACDL;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid GOPGHPGDEHL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid MEMNKJDGOGN;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GJNJCJOLBAM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PCHLIDLINCH;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid MBJDFPDDENK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid BMCHFKKCCGM;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid NNHPFIPPNOG;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MMFHGIPIMOD;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid JNFMHFINDCL;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid FMICNAAGLKP;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid AKDBHLJELGD;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid DGMKDANHPAE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EJCJMAEFNJE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid KHNKMPHFOKD;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid MLJECBCFCOI;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KPLFDIJNEAB;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OPLELDJAPJA;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid AKCOEANFPFE;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid FHFNPAIMCPG;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid IEMAMIOJNKD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid GCLBKFFLAFE;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GIGIMMFPJIC;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid KHAFBCBFFEC;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid DAANBFHNCAI;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid GCDPIPEBLKD;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid PNCCIPDJCAH;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid NKJCDAGOODA;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GFCAIFMDFNC;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid EIEMEEAKFLA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid GLHFJPBADAJ;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid PGKEDHNJEOE;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid FOCEBKJFJLH;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DAMCOGPKICP;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid EGKDBJEMGGE;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid BNPKCOOFJHN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CKLHFKMMEJA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid OPODHPBLCIG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid CPGCCNMGMAH;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FFEHOOMOCLL;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid FIBOMCOLHIM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid BNHPMHHJLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid OHGHHJBILCJ;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid DAJKPJAMOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid LOFLFGBHDEK;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid BHJHCLDLEHA;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid HIMKFPNCODC;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid OCHFHLPKJOG;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CPALHEHNLFF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid CJPHDJFJOHB;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid HKKGNMKCLOF;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid BHPEKNHGCDP;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DCFJNCIPMBD;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid JGDJGBHNEKP;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid BCMFLDOAOAD;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid CACLCNEMJJL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid DJPHFPCOEPK;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid JBMDAEPGAAK;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid AAGLGEIAPHH;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HCJCPOAKMEK;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid LOENCECKNOO;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid INODMKEFBBC;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid DDOKHNIMMMB;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid GPFFKNJNODJ;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid AIFJNICGHHM;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid IKOEKBALFCM;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid MCNOCHCPGOK;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid AAFLPGDBMBN;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid EFKHANPBHOL;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid OOPBILBNDGC;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid EGOPGMFMOJO;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid CIMEEGJGFCG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OLDMJAABCDN;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid NNGFBJOCHGM;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid FNJLIFJADKH;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid DOAPNEILLCI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid LBMJACDIFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CDMHBDAAKFH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid LOOAGCDKADG;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid DGCGHFPFEMK;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid FGAKJFEOJMH;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid MJCGFBHIOGI;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid JCCFEKHDEBC;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid MMLDMABPDJE;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid FAIJCLOLODC;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HCDMBNAKBHL;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid AKOMOLHCCDE;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KABOLJLBNMB;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GIENIFCMGMB;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid JKCAIMCHEKL;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid HIBECHNEBLL;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid JAPBFPMKLOD;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid GGDDCLHALGK;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JFJKLGJICGI;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PEABAOPIOOL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid LJKCBGBEENA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid OBHEBLBGFOK;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid MHOHGLHHMGJ;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid AHFNMLJIJKM;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid ABJKNJAIJDA;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid MIBBAIBFDCA;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid BLIOILOEDAJ;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid CCMHCBNHOID;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IMNPPMGJOPO;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid BODPJOJPILH;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid FOKNMABOFME;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid MPKKDOEEPHM;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CNFKPODEMHP;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid JPBLKPHCGLP;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid JGNLKMEGCMN;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid AEBECBJGBPM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid FJGMLFKLBPI;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JDPAIKPLGCB;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid FPJAHPIJEOJ;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid HNKKIOHBJDC;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MKJPMAABMDE;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid AOKJHKGMEPI;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid LELHHAAHJEC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid CAIKEPHBADF;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid EPOLHMIGJDI;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid NDCEJLLKHEO;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid PIMKIMLMGPL;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MEGGCCGLKGH;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid FNFHOJHEHDN;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid ADFMKLAGPPO;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid KPDGMIOJKOF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid HCIMCDCNHJK;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid ONBEIGFPKHC;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid IBNGKJBLMAC;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid BHCAHJHAKEL;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid IIGALALDONI;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid IPPNFODFCBB;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid OBDFDPIMCNI;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid OGKGDPNONAI;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid KLHALAHNELL;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KNFMMHIODAB;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid LJBMNIJCELM;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid MDKPDNAKPEI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid HGMOMFILPEO;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid DNKLKGGECIC;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IGOMGJMJEHD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid ICNGFJEEFIP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid EHIOEOEJOJL;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid PAADNCOOAHJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid NFDLKGDHMIG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid EOAIJJKLOKM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid FJIDLDALHPF;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid CIOADJJGFFG;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid MLPDDAFHDKF;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IBHMLAGNDIA;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid MOJPIONHMFK;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid GOLBLGLILOC;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid KDHBHBHDAFN;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid PFPIJMDOJNI;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid IJBKALCLODI;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid DMGJEEAJCCC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid GEONCJKCDJL;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DHMFBLHPGAC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NFCLGIHAICJ;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid IPGJCBMPGLO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid JCAIPDGKDBM;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid MOBNONDMDNK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid HGJDMPNOABC;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HAJGDIPIJFP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid LGIEDEHLPFF;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid AABBCHHOEFJ;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid IBGOEBOGBBK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BELBKHOJJFA;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid KOMACJCDMPO;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid CHOLPNPGHMM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid ECNGKKLNKFD;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid LGCMIPIEDFH;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid EAHHEEBCOMK;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid KDDKPAACCJC;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid PFDEHICGHEB;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid MDOCPJOOIOK;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid FBCPFDGNHDE;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid AFOBJHHHGDJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KJOAKACDDDP;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KPIJPJHMEKD;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid DPHJPPGICCI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PJCIMDLKDLC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid OEOAJCDJOIG;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid CBACJGDMPPO;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid HBDNECNAPAI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GNODOHHEJOB;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid CMOECFKGKCD;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid IFNAGBEFEIN;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid DCGGLDIAFED;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid LNJGCAMKKHG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid GAKPCPNMDHC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GFLPEFLDIOC;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EJPPHIGAHIO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid NGEFKIFGLPH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid ANNCBNPOAKD;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid FLDHOKIBEAD;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid AGLPMPBGGEP;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid AMHODNEFCAP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FGCGIBMBMEF;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid NJINLANGIEM;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid LBNDMPKOJGP;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid IHMHGIENCKI;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid FNDMALPHGMI;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid BCODKJEMMNN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid HIJBJJJAOCM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid OGDCAIHFMDH;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid FPGPAANECBA;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid LPOBDLGJMMO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid NPIILGNMFGG;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid DLHCAHDAIAD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid DJDBHLAOBHF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IMMHMPDPPJE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid ANPELFDFANO;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid JLGPIMCLNGD;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid NOOAJLMBDMJ;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid BMNMHIGLFJN;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid IMCELGAOGDG;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid ENAGBIIEAFF;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid EBKKENPLGEI;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid IGHEOCBKEBP;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid CIDIBNNJDHP;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid HNMHCALPEKG;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid PNICEPDHNKK;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid FCIBAMGDHPL;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid COFBJCBAMAP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid LJBPACOCPND;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid PJJJBALCPHD;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid JBPJBCHBDJN;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid AEDDBGOJPFA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid AEFDOCNKOHL;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid GFGCKOGICEI;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid OHJEOLKPBCA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid HDCLEMGNKNG;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid PFIDHMFCGDI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid PCKEINLLCPI;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OKBHNPDHDEI;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid CLPJFHDPLLA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid CJOGPNMJAHN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid HONHKFPFHDN;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid AHDKOAHPEOB;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid GINPEDMOOBJ;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid CJMOFINFCON;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid OPPBPKAHGOE;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid HGDDCPANJAG;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid FJFIIJFLIOB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JFDABDDJNCC;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid OAEKEEPPEHI;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IPJPJCAOMCN;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid EFDABHPJBFK;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NFGDDMOCOBO;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid AOELKFOLNCJ;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid CFIKDPKFGEB;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid FKFHBOMEELD;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid PNKICMNFKHL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IODCDLLFAFI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid OMNFOOCPAJJ;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid ALOPMBCOGMH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid OJLPOMGBCJI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid CBAOBGEGDDI;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NFAOPICLOHM;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid HNNCNHBMGMK;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid DCPDAHCJOLD;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid IOOBIEPFMJJ;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid LLMCKHGLLLD;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid IMKLKCMJPCA;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DHEKKFBGAJJ;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid KDPHMGINMAL;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid DDBADCOGDBN;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid NEABBAEGHBB;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid ONGONFJGGLF;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MGENNHIKLOI;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PGOIDCDIFFA;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid GKFCKMLKLJI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid PJKMNALHCMF;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid FJHCIINNPPA;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid GFBKLKNDLHB;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid AHKLJKCNFMF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid ONFDJJDFAKK;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid DKDCHAPPPMD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid OFPNEOFBPAC;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid BHNBMMMHDLJ;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid POCLMANJMLD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid DDKGHLDHKME;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid OCLLDFEMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid COPJLLPLDJD;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid MBGBJIFEOCL;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid FIGMNALCGAI;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GDHMMFMEMPF;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid IIMJABOONBD;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid MJICNFADBMD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GAGPFIFKACD;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid IPHONOPJFIC;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GKJGFHGOPIB;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid ILLBLMAGKEF;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid IADEKFABGJG;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid LJGCLDOEOLH;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IOKCFNIBBII;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid BCJAJKBPKGI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid ELBEHDEMBEH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid EHMCDLOAMPH;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid CKKPJGMGJAM;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid BJLJDOJFEMC;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid HFJHAKEEFCE;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NLCALAMNIAJ;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid NBEAIFGBCGE;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid NELAAADJHPF;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid GDECBPDGBBK;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid ENGLOIOAEGD;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MCJNELKMKKK;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid HJBJFMPJFEN;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid LPIDCOKJFNL;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KNAJKOBMLBK;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid DNOOPHCHCGK;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid EDCDJGCKIJE;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid PMOKNAHOGJL;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid OBOKPOBOLKO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid IPHHKNBFCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KOOGDHFFOGI;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LAEPEDLBHAC;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid KIFJDFJFMKI;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid OFCMLPDLNOJ;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid EIBMIIJKLLD;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid NJAKMIMCANH;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid KBGFMOLJJOD;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid GAPNHEMNFMP;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid BLAKJPJNKBL;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid NHPBKMKBDMB;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid GEPELPGLILL;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid OMLJHFENPDK;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid ENNFNDMDFEF;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid BGOEPJJNGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid MNJEPNADFJA;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid FPOGNIGMLDE;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private static readonly Dictionary<Guid, IDKGLLDIGLO> DDAKNGKPGIA;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly Dictionary<IDKGLLDIGLO, Guid> JGMEDPHNLNI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, IDKGLLDIGLO> LLDDBHEDNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8EE0", Offset = "0x5DA7CE0", VA = "0x185DA8EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<IDKGLLDIGLO, Guid> CIECGFPEGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8E80", Offset = "0x5DA7C80", VA = "0x185DA8E80")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OCLFBIKMJEJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFFA0", Offset = "0x5DAEDA0", VA = "0x185DAFFA0")]
	public static bool FOFLBIFDGOO(NAALFLMFBIP PIEAOHOHIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFBF0", Offset = "0x5DAE9F0", VA = "0x185DAFBF0")]
	private static bool FOFLBIFDGOO(GOIOCFGAJCC NEEKJCNICKO, NAALFLMFBIP PIEAOHOHIHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct AHILEPIHJMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public readonly BGICKMOFPDK ENKIPBPANKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public readonly IEnumerable<DAOFGAIMCID> DOCHODHHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly IReadOnlyList<DAOFGAIMCID> IKJGOKHFNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly MLOCHKHLPON<BJGNAPHFBHH> HDKDNDKCEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<BEBLNOOFELI<DOHDAHLOGBC>> BECAFMBPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly ByteString JBLEIENKOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly PJPOBLJMCAB EABIPLIICEJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7130", Offset = "0x5DA5F30", VA = "0x185DA7130")]
	public AHILEPIHJMO(BGICKMOFPDK LLFPPCBHGKE, IEnumerable<DAOFGAIMCID> IBLICCMMPOF, IReadOnlyList<DAOFGAIMCID> BCLMCJHKLOK, MLOCHKHLPON<BJGNAPHFBHH> MPDMMACMJMP, IReadOnlyList<BEBLNOOFELI<DOHDAHLOGBC>> JBBMMCDNPFH, ByteString IJCJOCGHMML, PJPOBLJMCAB INNGOFDOKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NCJNOMAECCK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(HKCIOKHAFKH KNAIEKIJLBC, [Out] Dictionary<int, int> AOLACIFDIFJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CKBBFEIEAHJ GAILGEDDGFK, PDEDIOEFGGF CNAINHJNPJF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ALMMPCPLCGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly Guid PGEKMMOLNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly Dictionary<Guid, Guid> OBLONKLHJOF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> HMCJFMKKGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33C3630", Offset = "0x33C2430", VA = "0x1833C3630")]
	private ALMMPCPLCGH([In] Guid IDMMLINKOED, Dictionary<Guid, Guid> BHBDFAGCOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8DE0", Offset = "0x5DA7BE0", VA = "0x185DA8DE0")]
	public static ALMMPCPLCGH NOGGNOAEOAE(IReadOnlyDictionary<Guid, Guid> MFAFPHDLFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8A30", Offset = "0x5DA7830", VA = "0x185DA8A30")]
	public static ALMMPCPLCGH EHGHFGEJNBL(IEnumerable<KeyValuePair<Guid, Guid>> MFAFPHDLFJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8910", Offset = "0x5DA7710", VA = "0x185DA8910")]
	private static Dictionary<Guid, Guid> ECEBLHEGPAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8800", Offset = "0x5DA7600", VA = "0x185DA8800")]
	public Guid DHKLBPJMEMB([In] Guid CHLMGBPAGHG, bool BJDLMLJBIMG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DA89C0", Offset = "0x5DA77C0", VA = "0x185DA89C0")]
	public bool EDJLJFKCHKJ([In] Guid JPODHBJFPKM, [Out] Guid GMFJJIFJBJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JNHKDLADDLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LPMBBCCNKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKNPCKIALBL(ByteString BBFMJKBFLAL, ALMMPCPLCGH MIFHCDMFOHJ, [In] FCGNMDMHCJG EPMHCPOLHBA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GIGCBPBIGGG
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
public sealed class OGLOAINANNM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> OFNBENOFFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> CMEAIOFHLME
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77D1D0", Offset = "0x77BFD0", VA = "0x18077D1D0")]
	public OGLOAINANNM(IReadOnlyDictionary<Guid, Guid> GFCMOECNKBB, IReadOnlyDictionary<Guid, Guid> NKFANFNIFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HNLMIGALNNP
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD330", Offset = "0x5DAC130", VA = "0x185DAD330")]
	public static FELPPMCJBNI PEHKDBBPDAB([In] AHILEPIHJMO BCJCHODADNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC520", Offset = "0x5DAB320", VA = "0x185DAC520")]
	private static void JILKLAOCMAB(FELPPMCJBNI HMMBBDCCCLF, [In] AHILEPIHJMO GIMDMDIGDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB230", Offset = "0x5DAA030", VA = "0x185DAB230")]
	public static bool IOIJINLMCGI(FELPPMCJBNI HMMBBDCCCLF, FEEIADPAAEP BMOIDJLPBLF, [Out] OGLOAINANNM? BHBDFAGCOBH, [Out] string? LMJIIJBFLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA900", Offset = "0x5DA9700", VA = "0x185DAA900")]
	private static void EDODGMJMKOA(FELPPMCJBNI HMMBBDCCCLF, ALMMPCPLCGH? EEIGADCODED, FEEIADPAAEP BMOIDJLPBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD030", Offset = "0x5DABE30", VA = "0x185DAD030")]
	private static void LGOMOOIAODN(FELPPMCJBNI HMMBBDCCCLF, FEEIADPAAEP BMOIDJLPBLF, IReadOnlyCollection<ByteString>? NJEFPNBGEHO, IReadOnlyCollection<ByteString>? HMIKDOLCMIM, IReadOnlyCollection<ByteString>? KLCPMPCDEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAB90", Offset = "0x5DA9990", VA = "0x185DAAB90")]
	private static bool IJDLGKMBNIP(FELPPMCJBNI HMMBBDCCCLF, CKBBFEIEAHJ GAILGEDDGFK, FEEIADPAAEP BMOIDJLPBLF, [Out] string LMJIIJBFLBD, [Out] Dictionary<int, int> AOLACIFDIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD4A0", Offset = "0x5DAC2A0", VA = "0x185DAD4A0")]
	private static Dictionary<Guid, GOIOCFGAJCC> PLBOEIPOLJH(FELPPMCJBNI HMMBBDCCCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA870", Offset = "0x5DA9670", VA = "0x185DAA870")]
	private static void CKCKPAMIDMH(bool FKFJEMPNPHC, DAOFGAIMCID APGGBDCPJKP, Dictionary<Guid, Guid> OJPFLIDHOIL, ALMMPCPLCGH KJKDFMFADKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD0A0", Offset = "0x5DABEA0", VA = "0x185DAD0A0")]
	private static void NMAKEBHDHMO(DAOFGAIMCID APGGBDCPJKP, Guid GJOOKJOAKIA, EFGKHEPLODF? MDLJBKBMKAP, Dictionary<Guid, GOIOCFGAJCC> CJIDLPIGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DACB80", Offset = "0x5DAB980", VA = "0x185DACB80")]
	private static void KNHKOKLGKGL(IEnumerable<DAOFGAIMCID> AAFDAAGJNDN, IReadOnlyCollection<ByteString> NJEFPNBGEHO, IReadOnlyCollection<ByteString> HMIKDOLCMIM, IReadOnlyCollection<ByteString> KLCPMPCDEOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FEEIADPAAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public bool FKFJEMPNPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public PJPOBLJMCAB INNGOFDOKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public EFGKHEPLODF? MDLJBKBMKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public EFGKHEPLODF? NAFOMBAFPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public BGICKMOFPDK DOPGDNBHHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public GIGCBPBIGGG HAEHAEPGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public NCJNOMAECCK BGPEKEKDNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public JNHKDLADDLN CIMANADANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public BEBLNOOFELI<BJGNAPHFBHH> GPHGEJNHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public NMFJLPOPFLE AILCCIALHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public List<DAOFGAIMCID> MFJAPJGHEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<string, object> MLOCMFLFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public HFDMOKDNIMJ BLOLKHAJAGL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HOIODGKFGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DA97B0", Offset = "0x5DA85B0", VA = "0x185DA97B0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EFGKHEPLODF
{
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private const float EEPBMLJANBC = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Vector3 LMGPBOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Quaternion BPBCJFMFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public float OINLNNPPPEB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 DEHFFHPGPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9320", Offset = "0x5DA8120", VA = "0x185DA9320")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FCGNMDMHCJG CDHAMIBELGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DA8F40", Offset = "0x5DA7D40", VA = "0x185DA8F40")]
		get
		{
			return default(FCGNMDMHCJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B98E0", VA = "0x1808BAAE0")]
	public EFGKHEPLODF(Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, float OINLNNPPPEB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9530", Offset = "0x5DA8330", VA = "0x185DA9530")]
	public static EFGKHEPLODF PPNOOBFHBHG(EFGKHEPLODF BMNEKBHDGLJ, EFGKHEPLODF LKMGNBKBEHN)
	{
		return default(EFGKHEPLODF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA91A0", Offset = "0x5DA7FA0", VA = "0x185DA91A0")]
	public static EFGKHEPLODF DNODACOFDOB((Vector3, Quaternion, float) KNAIEKIJLBC)
	{
		return default(EFGKHEPLODF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DA91C0", Offset = "0x5DA7FC0", VA = "0x185DA91C0")]
	public static EFGKHEPLODF DNODACOFDOB(Matrix4x4 KJNMKBEALDE)
	{
		return default(EFGKHEPLODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8F80", Offset = "0x5DA7D80", VA = "0x185DA8F80")]
	public EFGKHEPLODF DDLBBCKAFJB(Matrix4x4 AGLGKAHAKII)
	{
		return default(EFGKHEPLODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9430", Offset = "0x5DA8230", VA = "0x185DA9430")]
	public static EFGKHEPLODF NHMHBOCEPID(Vector3 LMGPBOPOFGA)
	{
		return default(EFGKHEPLODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DA94A0", Offset = "0x5DA82A0", VA = "0x185DA94A0")]
	public readonly DINMCNDDOHA PLMJHBPIPBF()
	{
		return default(DINMCNDDOHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CBLIEMHIFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8DF0", Offset = "0x5DA7BF0", VA = "0x185DA8DF0")]
	public static EFGKHEPLODF BOGMGPIBEFC([In] this DINMCNDDOHA HLCOOGAGOEK)
	{
		return default(EFGKHEPLODF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HGGBOHOCPEI : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9A70", Offset = "0x5DA8870", VA = "0x185DA9A70", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9AF0", Offset = "0x5DA88F0", VA = "0x185DA9AF0")]
	private void ICCEBOLFPDH(Dictionary<Guid, Guid> KLNKDLKFAGI, KOMDCIOAHNO MAGPNJJBDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA350", Offset = "0x5DA9150", VA = "0x185DAA350")]
	private void ICCEBOLFPDH(Dictionary<Guid, Guid> KLNKDLKFAGI, BMIGLCANNGO PGDIBDPMLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA0D0", Offset = "0x5DA8ED0", VA = "0x185DAA0D0")]
	private void ICCEBOLFPDH(Dictionary<Guid, Guid> KLNKDLKFAGI, HBKGLKCNPMM GOLGGDGBOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HGGBOHOCPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PIFNHCENEGO : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0190", Offset = "0x5DAEF90", VA = "0x185DB0190", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public PIFNHCENEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LKCLPBGELDP : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8C0", Offset = "0x5DAD6C0", VA = "0x185DAE8C0", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LKCLPBGELDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class ALCLILADLCE : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DA86B0", Offset = "0x5DA74B0", VA = "0x185DA86B0", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ALCLILADLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class HLAOAPBMDLC : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA550", Offset = "0x5DA9350", VA = "0x185DAA550", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HLAOAPBMDLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GDBPJOLFNKN : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9800", Offset = "0x5DA8600", VA = "0x185DA9800", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GDBPJOLFNKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HHHCPHIDEHO : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA3B0", Offset = "0x5DA91B0", VA = "0x185DAA3B0", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HHHCPHIDEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class JJOAJKBNBFD : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD780", Offset = "0x5DAC580", VA = "0x185DAD780", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public JJOAJKBNBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class LMOBNMJJKBD : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEA20", Offset = "0x5DAD820", VA = "0x185DAEA20", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public LMOBNMJJKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ONOAGGOGDAO : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFFD0", Offset = "0x5DAEDD0", VA = "0x185DAFFD0", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public ONOAGGOGDAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class HLMPCNIJBJP : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA770", Offset = "0x5DA9570", VA = "0x185DAA770", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public HLMPCNIJBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GHIJMAMMCMG : BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly System.Random GFMBDJKJEFO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9940", Offset = "0x5DA8740", VA = "0x185DA9940", Slot = "4")]
	public void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public GHIJMAMMCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NAALFLMFBIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public CKBBFEIEAHJ PPBKIGHJOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public IKOAJBBCJOK OCDJOJEKIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<int, int> BBNJDCBFLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, Guid> CMJPAAFBCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public HFDMOKDNIMJ BLOLKHAJAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public bool KLCMDPANGMF;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BNGPHJECGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDBLEHHJHNA(ACKJHMPDKOD JILHCGHCJGC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NJDBHNBOGGC
{
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private static readonly BNGPHJECGFD[] KPHBAEFNMAF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEFB0", Offset = "0x5DADDB0", VA = "0x185DAEFB0")]
	public static void JFHNCDIOMCE(DAOFGAIMCID KNAIEKIJLBC, Dictionary<Guid, Guid> JEFFKDPIANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF240", Offset = "0x5DAE040", VA = "0x185DAF240")]
	public static void JLOGJMNAADI(DAOFGAIMCID? KNAIEKIJLBC, ALMMPCPLCGH KJKDFMFADKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEBE0", Offset = "0x5DAD9E0", VA = "0x185DAEBE0")]
	public static void FOFLBIFDGOO(ACKJHMPDKOD JILHCGHCJGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ACKJHMPDKOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public CKBBFEIEAHJ KHEDJBJPIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public DAOFGAIMCID APGGBDCPJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public Dictionary<int, int> BBNJDCBFLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public Dictionary<Guid, Guid> CMJPAAFBCNB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7080", Offset = "0x5DA5E80", VA = "0x185DA7080")]
	public Guid HEGBNICFDOP(Guid CHLMGBPAGHG)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HFDMOKDNIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int DCHPHODNNMK, [Out] Guid JDDDNADPAFG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AIHLGBKELGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly HashSet<string> BIFONCKAGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Dictionary<long, int> DOFCEDPLGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private readonly HashSet<Guid> PEOKNNPENAO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> LLKKBICJKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> ILKGGOOBKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7FB0", Offset = "0x5DA6DB0", VA = "0x185DA7FB0")]
	public static AIHLGBKELGE FDIGIDDKELL(LJCPPKMEKBD PBPDKBKCOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DA81A0", Offset = "0x5DA6FA0", VA = "0x185DA81A0")]
	public static AIHLGBKELGE JBLPOLPBHFN(FELPPMCJBNI CFBAEIDJGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8020", Offset = "0x5DA6E20", VA = "0x185DA8020")]
	public static AIHLGBKELGE IEFMAPDEMDP(IEnumerable<string> BIFONCKAGGP, IDictionary<long, int> PJFLDAOPIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8450", Offset = "0x5DA7250", VA = "0x185DA8450")]
	private AIHLGBKELGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8570", Offset = "0x5DA7370", VA = "0x185DA8570")]
	private AIHLGBKELGE(IEnumerable<string> BIFONCKAGGP, IDictionary<long, int> PJFLDAOPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7C40", Offset = "0x5DA6A40", VA = "0x185DA7C40")]
	private void CLECHDBGMCL(LJCPPKMEKBD PBPDKBKCOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7A50", Offset = "0x5DA6850", VA = "0x185DA7A50")]
	private void CLECHDBGMCL(FELPPMCJBNI CFBAEIDJGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DA75B0", Offset = "0x5DA63B0", VA = "0x185DA75B0")]
	private void CLECHDBGMCL(BNKINDFMDNI? NANDDCHCAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DA7E40", Offset = "0x5DA6C40", VA = "0x185DA7E40")]
	private void CLECHDBGMCL(KFGENKOPJGC? JAHOBDMOOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DA71C0", Offset = "0x5DA5FC0", VA = "0x185DA71C0")]
	private void CLECHDBGMCL(DAOFGAIMCID? APGGBDCPJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DA83E0", Offset = "0x5DA71E0", VA = "0x185DA83E0")]
	private void PGNCKNCFLFM(string? IODCMPIOMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8300", Offset = "0x5DA7100", VA = "0x185DA8300")]
	private void LJKMLHGONMO(NLLBAMJONOJ? FIOGPPOJCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DA8210", Offset = "0x5DA7010", VA = "0x185DA8210")]
	private void LJKMLHGONMO(OPIDEFCLAAI? FIOGPPOJCKI)
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
