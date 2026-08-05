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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DD3450", Offset = "0x5DD2850", VA = "0x185DD3450")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IOEGNNCIMLB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> JLMDDHDBOKP;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> KKFJAEHNLIO;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string MHABOKEICKC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string DFAHJFEIJNG;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string DBBHLABJACM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1A50", Offset = "0x5DD0E50", VA = "0x185DD1A50")]
	public static bool JOPDJPJFGAG(Guid EKIMDAEOLHD, int JHENPMMBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DD13D0", Offset = "0x5DD07D0", VA = "0x185DD13D0")]
	public static string AFENPDKBOCJ(Guid GJKCBNEBGAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JECPEKLNMOD]
public enum BNJNNEEIOCD
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
public static class NIMOGLIIDKK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid CJJEIEDCLDC;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid JJDFKAJDAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid EMEPMCODABD;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid CDGBMADMHKE;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid HAEBNLGINDF;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid JEMDBBJNPDF;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid APCJBEFALNE;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid GFGCIGDPJIA;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid OPHCKNAPJCG;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid NPJOIOHGCLD;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid CBMFIPHFHOF;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid MBOLOAAPHOA;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid FLCDPKMMMIG;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid COBBCNIPNLP;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid PDNGBABBBCF;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid PODNLKFNIOD;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid FMONGJPEOJE;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid OPLDGICCDOL;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid PIJMGDLEKCA;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid DEBLLKKCAIF;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid AIIMOPHFENI;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid NLBLMJJGANE;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid OJNEHLEAPCA;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid FLPHIKCCPCI;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid ALPLKDFBIPM;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid CKPBLMMGOIL;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid DHHHPFMMMHJ;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid PAOLPMDPDMH;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid BMBBDOAGHIF;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid EBNGJLHCJCG;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid AKKACOOKIJD;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid BBPFBHCBKJN;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid HDIHADCGMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid MJEDOIPLNJD;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid ODCFHOPPLAE;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid GCGGFCNKMDC;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid EHADKKOHCIP;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid BHPGLHJKOHP;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid DMOIFHLMMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid EOCKIHNHHCF;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid DMIPMJPFNHL;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid KLLGGLLIEBL;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid NFCJMFGJHLG;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid PLGHALCNLPH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid BAGNODCDBNO;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid OKNAKCDCCPB;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid ALIBEBEIMKO;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid LNNPCDLCBFN;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BGHKAKOOPFN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid FNAIBCLFMBO;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid MEDKGGOGMIA;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid NLBEAFAAKDD;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid GNHLCDKCDON;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid PBCHKCDKKFA;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid NFJEBHFEJCP;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid IMOOGKELOHI;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DGDPIADPIEM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid PHIDFJFGMDB;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid CMAFLLADHOO;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid CKBEFMCHNHM;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid NJBKCPPGKPD;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid JJCNLPGKBEL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid AOAFABKKKPF;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid PDKDEBCKOJC;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid DMCOOBLCELB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid BFPKNFCIILN;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid ACDKMKDPBCF;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid KGHOAHDJJMO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid FAHMCALHIOG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid LNILNOFPFNO;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid HDKHIKFEHMH;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid DFDNEIFKONE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid AKLCMCNNOCJ;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KNPOGDHNDGJ;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid IGDBLEMJLBO;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KEEMCALOPKN;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid AOAPICNPNNG;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid HGBKFHCKJOO;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid KNIGAOFPMPE;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid FHOKHPJBNPF;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NICJFNGLCFN;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid EOLGFOKHNNF;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid NICIILNKHEA;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid HNCFPAGJBAL;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid BLBPMGIANLA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid NIECIDNBOEI;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid IFLCHOCNAHF;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid IKMFHJJIGGH;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid PJBMPCBAMMG;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GFLIABALEFI;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JHHNOCJHILA;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GEODBHDGBCD;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid CICDBPILLIF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid HNOKNMBFADC;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PJALKPMMNAB;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid GGLKAMEJGML;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid MAIJHDKMNKI;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid DLCAAAJNNKC;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid GNOPJEIBHPI;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid HMBGLKEMLAB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid JAEIGOLEJGJ;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid PEPAHGGNPOB;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid JKLPBAAOJGN;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CAPONENGNGE;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid BNGENMFKDHI;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid DOIJGOPFACB;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ELHPGJPJLID;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid FFNNMFIBNFP;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid EOLLLFMLBNP;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid JEFGOOHONDP;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GLCIHKCBPKO;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid AMHFJMDMOPL;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid HEMDILAAOHA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid OJKMHBOMKLK;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid AEDEMNAGLII;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid BDJCIACFFEB;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid MPFCGGKACAF;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid MOCEKIFLCJF;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid DGNINPIADLK;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid FOIOAGIHIJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid DLFGJMOGLIP;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid MOLPAFGFAHD;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid LNDNILLMIFC;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid INCJJIGGEKD;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid IAAMKHBHILC;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid AOMINOBEDBG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid JOBLMIHPHEH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GPNKHEKLCCJ;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid MGOPIMCOEIF;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid AAEODNGOKDL;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BMABCABLDIG;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid CEEGADOBJBK;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LEAPFACLFAP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid AJFPODGEAFI;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid NMPCEALECDA;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid PECLBMCMCGG;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid IMAMNBOIHJD;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid KLNCJMOCABG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid PJPLBJMHMBO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid MNDAPICDHJN;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid LELCBGLJAGO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid BIIGNJPIAHF;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid EDPNDEFOLJK;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid MPBAOPGNKED;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid EMBFIMJGFHA;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid NNJCJOCLIPA;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid FJGCJCHJKGO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JLHGEBMMAGN;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid INBINPIPOPA;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MELKEGFLGAC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid ODEADDKFCGG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid EENGBCPCCMA;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid HHODABBAHOK;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid NJHEOOKIJBL;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid BAGHMAOIIIG;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid CFDMFGIDFOK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid BLKEKAGMGDA;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid HJFMINFFEHL;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid ANIJKPFFDKM;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid MLNPNGLBAPA;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid POHBDHPLHIC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid KIIADBCGEIK;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid IMLBHAPKAHO;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LFBPBELBMBK;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid IABEILHEHHJ;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JLCNJMCDAEE;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NBOGMKKMMCG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid COKLFJHDBGM;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid ECEKCEKFLCK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MGJPDHHJFCC;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid NJOKDMBFCFO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IBONBOLNFDD;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid IPMLPDIJFJC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid PFMDNDPPCMM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid JFMOBNHPEDJ;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HGMNEANGLPL;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid BMBFMNIIDII;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid BNAIDMMACFM;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid FGNJDBLOKMP;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid FDPAPGBOPGE;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid AJCLOMOHAHH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid OIFKJODIGLA;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BKJNMKKOKFP;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid IEOIIHLHCIB;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid ONOEEOMHFLP;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid MGDCJICFNKI;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid CGMOBJNDIIB;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid ACDBNEEKOLB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid HLKHCOOBOCL;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid KDAJNGDHCOD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid EOCODLJGIPK;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FDEJLIHFMBH;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid IBGDNPHBGHF;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid JOLFNJEJIKA;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CPLHICOCKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid CGIHMENEDLI;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid JKKJCEINDKI;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid JKNBBAKIIGH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid NENOBDOGAAF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid AKBMKLMBEOK;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BNBIAELLGCK;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid INELLHDGAFD;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid OLFDBJLNPGA;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid GMHJBFEDEGM;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid ALOOGAOOBBG;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid IMCOCOKDIOA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid NBKGNPBEGOI;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid BIOOAJPMJJM;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid OOJPOHLIOAF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid ABDIBDPLEOI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid BBOJLIOMEKD;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid GANAKEHIKFP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LOHOJLBOCDA;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid PPJBPBLIFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KDACNJNDHJE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid HBNLNIBJJIG;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid FMJHOOFCEHB;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid AJBBOMAMCGP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid FOPCGCFOCMC;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid NFHBFPNCAPP;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KEKOAPHABOI;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid FMCNPGNDLKG;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid IHNNEJILGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid LPDILFPNHII;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid HEDOBDBEKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid GIOJBGNHOAM;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid CDLDCPKPEHF;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid OHDNKHIHEJH;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid IMFBJBEOEBH;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid PFJACJELIDP;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KAHONOLCJOP;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid LABPDPMKDKN;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid OACIMGMEFNA;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid OADGFFAKELL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid IEBLFFHMLIO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid FFOHCJKOGJI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid LEBKHEFOMCK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid GHJLIIEPMGH;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid OBAGPNMENMG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid ADKGHDOKOPL;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KBBMDBOLBOC;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid HCGOAIOOFPN;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid KOOJHENCNDE;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid MPIPFIDGMGE;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid IPKGBNBHDGL;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid COHIHKEPHOC;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid NPKLBPLGGPL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid JODOADCCOMP;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid IAOFNOMLCJG;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid FLFMPGDDHHG;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JNIOMGAKDDK;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid GKIJFJKNNMM;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid IBDGNCKBOMN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid OGKLACCOHJL;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid BICPBOGLHKF;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid AKMLJADOJNL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid HGBDCDGHNHM;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid LEOKHEKKEOG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid DHOONIDCHDI;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NFADNFFCLGO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid FGPIMBOLBII;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid AEIANFJLDEN;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LNLFGANGMNM;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid MOCNLKCABCP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid MJGBEPPGBDC;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid PDCGJJNCJOK;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BMMFMPBGIJB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid JNJAICDDKEG;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid GHMMONHFNHF;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GPICNFACLGO;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid PDJIHAJMJGM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid ALAICEMKMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid AHGNOONNEJC;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid OGEFJIONKDN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid JLPCCNEFONM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid HCCLIBADMNM;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid PCKLPCDJMKA;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid AEKJHEOBONJ;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid OICLIJODEOC;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid HKBAEPDPFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OMMAFENONAF;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid NPMMKCMNLNF;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid CCCPBMMBHMM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid ECAPIJCKHHA;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid GNDIKPKENPG;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid KBOHNFFONAE;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid MGNHNHCGDEC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CLJAINJMINI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid BBPGDBFLEEP;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid KJPDLGECFBG;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid COKNLABFEON;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PGEPFJBHKFK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid OEJOFGLCECN;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DICPHGMIHOF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid CLOMHIICMHF;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid MMEAGLCNIHO;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid KBCCEDCHJKP;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid ENAKDJGBAHB;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HJCDBMPBGFA;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid MKGAPLONNHH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid EGAECIBABEF;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid LICOLCIPNCK;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid OKAENKCOKLD;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid OOMKDCKKCEC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid FGKNDLAGDOA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid LAGNPGGLJAA;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid ADGFBLEFMPC;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid BIEIHIKECPK;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid NCAPGGILFEF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid PBNIDBLNFHK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid ENOEONALMPM;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MLAOFLNFNFH;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GFIPIPFLPJH;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid HKGPGHFBLLJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid KHMLJOEKKAK;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid LOBLLLGJNFO;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid GBMMDLFMFGC;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid CNMNGMDCAIL;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid AGMGEMMCNMA;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NNLKJHGOFBK;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid AMKKKOMBJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CLMIJAOODPG;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid CMCOONEEAMH;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid OKDAJMBHAED;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid OPCLKPIFIDE;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BFNCKPOABDF;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IEDNJKHAOCD;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid LNAOJLJAMCA;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid GBNAPACLGGE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid DAKGCDPAAGH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid LBPPGGMFMJJ;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid NDANDEMFPOD;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BJGHDFCLOOF;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid GPPBIHJBOOD;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid PBFBCEBDFJJ;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid NNDJBFPBOHH;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EIDBEOEKONF;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid FIKEIDBOMCL;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid MGMFBIKHJLH;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid HKJKNCIBEHH;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid GFBCDBFDAMJ;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid CIIPLLHPAGO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid JHHJHPLGNCC;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid BAAHODCHJKJ;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HCJCGMAOBHC;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid LMPGGHJIMFG;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KJGPFDADLDN;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid JILDPDGBJEI;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid EBCMMDPECAL;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid EKGCDECIAAD;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid BJNLPEFGOJL;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid OEBPHDNCGNE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid BHLOJKPMFEB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid JAMMMGEIOHF;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid OIOKJDLFFNN;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid HMLBBOPJLID;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid MEEKJMIOCEA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ODKPHJOOAGO;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid MLCINEJNPGB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HBMFAPHEEIG;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid HDGMACEHNHC;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid ENODFPPNKJN;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid HCFKGCFHJOP;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid OHCDOICOKIG;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid JDLGPBPPBNN;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid CDPGHHAEPMF;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid JGLDJBKLJPF;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FPNNHIDICIM;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid MPIAIBNPHLJ;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid AMLNKIFBGKB;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid EIPNAPHCCKL;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LMGGOCIEJHL;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid EEAGCDJBHMM;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BGKCNALKAPI;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid JEOCFANNABF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid ODDBJPCBILH;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OOLMEPAPMKO;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid EAHJCANGPGD;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid LGPLNDKJGNN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid HLGDLABLLPB;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DCOJCHGPGNP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LMEMIDJEJFC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid CBFGBOCBLAH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NGODIILMCBJ;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid FIPIIJFCDEB;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid GMDILNNFHCC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid IHNJFGJAHEM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid PJAKMNEIEPG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid OLHNELBMIBC;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid NIHEJMKCHNH;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid OFOHHFBDIIB;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CIAJBJIKLHD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OECFLPDEGCP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid KFLGMGBFECI;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid GELDAAJBNIL;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FHJIMPFNGFL;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid LBIGNDIACJF;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid FLDBMDDBHEH;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid OBHAHHBAHFN;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid NCEHHDHFPIL;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid ODOLKFNAIDC;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid LDCPINOEJEI;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HILGOFAHMDM;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid CACCALPGJEO;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid LGCJHGMPACJ;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid HLJCMNKDOHN;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid KNHOIGLEONL;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid BMILKKCBMFM;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid PDPBHCAPDAE;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AMIFLEPIGCL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid CNMGDBIGAHJ;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid FLGJPDJHAPJ;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid OLGFKLGHNJJ;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MKCEEKNMHKD;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid ODAMLMIENBL;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid PINDMFAIFCG;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid NOBLDOCJPFA;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid LFGCNGAODDK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid PKJLPNGJIGH;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid OMDGLCMGNOM;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid OHFKNDHDEED;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BJGBILKCBOE;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HFNKEEFGEBD;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid HMCGNJIGBMG;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid BDIHAANGGFH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid IIFJLDIFDAP;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid ACPLDMCNJBB;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid HBFCGENNKAP;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HODLFNAAGJJ;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FFONPFPAEEN;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid AMEJFPAACDL;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid MLILAPDEKPI;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid PMPMJKKJJCF;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid EDNDAJKLKBL;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid ODCCOAJJBON;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid CNBNJLNHACP;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid NFHDGKCMEFA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid LBBOHDOLNFH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid ILCEEDEODII;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid JPNKLHMFPOC;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid DEPGOKFFLNP;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CFJENIHGIPG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid PMJNADHDCBO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HDGNNDKFOHB;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GFDOEFHPCNH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid CDOBFEILHPA;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid HFDFDLAMIFO;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PKFBHFCKJPE;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid POIHCMOONEF;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid OJELJBHOOMK;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid AJKOILKMOJP;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid CMKKMNICHCK;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid HGOBAJCEKND;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid KFOMLFOIKAF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid GHODGIJFGJF;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OAMENEFFCBM;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid ELGDLIIAHFL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JFNMGAEHPLD;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid AMKODJCGEDL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid DNKCBHKDCIP;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid GCJFMJIOLLE;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid EHIDBHPOBCB;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid AAGEFDNLCID;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid OCIFJAMLIHP;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid LBJKJMECKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid MJHEDEEOPEP;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid IILEKNCFMMI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid JEOBKLHEOOM;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid OKCCDFOPEBA;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid DMLKFKFHCCK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid CEAGJIJHLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BFHIPJFNGAM;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ELDDFEFBLLN;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid DCDLJFCHPKI;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid ABIGMJHBIAA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid AINJAKKEABP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid CCJNBLFHNKE;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid DCKGBFEGCKH;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid CDGIEPPMPEC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid EAAGODBCNIK;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid IPBFNJACAOE;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NPGAEGFDOAA;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MNFHFJPLONH;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DKNJBLGKGDO;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid AFLKALAJEEL;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BFGGKPGDJIM;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid AMEEKIANMPN;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OLOAKJGOPOG;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid PKFEEIIEONH;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid EOLMPBNLMAD;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid BMEBEDPDIMI;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DAPCGNPOKPA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid GIDCKHBBMHE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid OFDMHBOIFFL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid DBBOPKKBEFN;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CINEGEBLKDI;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid DGDMEPLCHFN;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid FCJKLJMMGHK;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid NCMPOLJMPJE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid OCIKAMCABKC;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid FEFGBHAOLIL;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid IEIPFDCODJM;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid BDMHDLBHELB;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid CIOPANLBPAB;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GEJABCHCNFL;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IKHGLJLAGCH;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid FHPCGKMHIFJ;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GCLLMFANBNG;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid LIEFOOHOAOG;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PDMJMDBIBFN;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid NMDHFAMPCBI;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid BOJCOGMCMJG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid BOGKKECGBPL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid EONENNMOMMF;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid JGGAOEKMBIF;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid KLOEDILJFAH;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid DOEKNNMIBLD;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid HKDPKPAJDIO;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid AJFCMIKCMLI;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid EPNDCLIPDJM;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid DPLDFCCBKDF;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid NHFCBNOADMO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid IEGKJCCFDGH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid KAIHOBPFIJN;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid MFHFEKMFELB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MAHMEBHOFMB;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid DEPGCLIOHHD;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid IBAGNPMJKBI;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid DLNGNPMAJHL;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid GNEBHOGALIL;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid AINPJPMLBCB;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid EHDMPHKMKEI;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid LLNPOJBEDMF;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid DEBIKIIIDJE;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LJIJBHFMMCH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid OFMMGGAOFPG;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid EJJMBIBEMDA;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KPHBODMAGJB;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid KLCDNOFKCKA;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AFCKIBODAKH;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid BADCJJIOCPF;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GEFAODAEIGI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid CFBMJFOAAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid BNCAKFONGML;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid BPCJGIPCAEC;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid JAGJOLDCGMO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid IHBLBOABDJI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid IALAJFBGLCC;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid BGPPDKHKGME;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid JNILCECJOND;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid FHMJFKNNFLB;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid AIOJLAMJCFK;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid IPCNDDJDEJI;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid PEFJECOHFNA;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NDNCLDLEAJM;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid DKEAIEHJKON;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid HGGHLBKCLAL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid PODGHNBFDDP;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IOMGCPBCNJN;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MMDMOIDCHOO;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid HDKHLEIKPMP;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid BKKJOFHCHKB;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid GPIIBAIFLOE;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid LGICPGMHFCN;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AIEGPJBMJPO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid MLEBHHFKDKJ;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid DBJKKPEPCAD;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid BJLBFLKAPLH;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid JCBOCLNIFBN;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid DGHPLABMIHG;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid JBFKPBFINBJ;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid OJAMGPEMKOO;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CBCGNCCJJOG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid KIPLPCDCJJA;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid MMMCPNANLBN;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid OBCMFBKHGOE;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CENPJMLGLIK;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid GELIDOPDEKN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid ENKDOMJDNOK;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid CJGDEDANIDM;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid IDAADJEMPBO;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid ANKEMIAFKGO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KHBHMMLKBHD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid IHDNBNLANHN;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private static readonly Dictionary<Guid, BNJNNEEIOCD> KLCLDDMBNFD;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly Dictionary<BNJNNEEIOCD, Guid> HGHCAKLABPE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, BNJNNEEIOCD> IBECNEPDIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DD33F0", Offset = "0x5DD27F0", VA = "0x185DD33F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<BNJNNEEIOCD, Guid> GBCGPBEPNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3390", Offset = "0x5DD2790", VA = "0x185DD3390")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JBMLPOBDPOH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD27D0", Offset = "0x5DD1BD0", VA = "0x185DD27D0")]
	public static bool CMNLFCJLLNA(ELHNKIJACNB MHFDKIJODCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2420", Offset = "0x5DD1820", VA = "0x185DD2420")]
	private static bool CMNLFCJLLNA(LFMBNEFAPFF LAIGFFBGCFN, ELHNKIJACNB MHFDKIJODCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HPOPCKCEFCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public readonly OBPBNMACFOC HBBPMGHMKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public readonly IEnumerable<GGMHGDCHGBB> NGFEFEDGPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly IReadOnlyList<GGMHGDCHGBB> EFOKMMLDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly JLMPPIICGFM<OEPBFKIMMIA> JHINJMAAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<OAOLHLLLMNK<ABLFAKCHCDH>> BDDNHBPPJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly ByteString AMGCGBKBBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly DEOPKAALPDI OJJGOOHLEFJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1080", Offset = "0x5DD0480", VA = "0x185DD1080")]
	public HPOPCKCEFCG(OBPBNMACFOC PGLEPFIODKC, IEnumerable<GGMHGDCHGBB> LBLHNOAOPJP, IReadOnlyList<GGMHGDCHGBB> PFMDPOKDCNL, JLMPPIICGFM<OEPBFKIMMIA> IACMBEIPAIP, IReadOnlyList<OAOLHLLLMNK<ABLFAKCHCDH>> PCOAKPMLEAI, ByteString OMAPIGDEOMO, DEOPKAALPDI LJPPPJEBNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LPOAPJJJNKB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(CAIMAGCBAOK KKOACPFFAML, [Out] Dictionary<int, int> LFFLBGCHIAE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(FNNPBGAIKGP LCHMIGEIFBI, HFCABEBDKOM FIEEKCAHNKD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AGIPFCANOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly Guid NDABKMOOFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly Dictionary<Guid, Guid> MBJCCMCEFFP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> AEGKCEFOAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33D2860", Offset = "0x33D1C60", VA = "0x1833D2860")]
	private AGIPFCANOOI([In] Guid LMPDHJALJPD, Dictionary<Guid, Guid> ECPIKAJHMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEA30", Offset = "0x5DCDE30", VA = "0x185DCEA30")]
	public static AGIPFCANOOI GCAKOJEHPMB(IReadOnlyDictionary<Guid, Guid> HBIBOPDHGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEB50", Offset = "0x5DCDF50", VA = "0x185DCEB50")]
	public static AGIPFCANOOI OJOAAEKKPFD(IEnumerable<KeyValuePair<Guid, Guid>> HBIBOPDHGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE910", Offset = "0x5DCDD10", VA = "0x185DCE910")]
	private static Dictionary<Guid, Guid> ALKEEKKFKJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEA40", Offset = "0x5DCDE40", VA = "0x185DCEA40")]
	public Guid GPLCFLKBKIG([In] Guid GJKCBNEBGAL, bool AEECDBEINBF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE9C0", Offset = "0x5DCDDC0", VA = "0x185DCE9C0")]
	public bool BAFLKBAAJIG([In] Guid EPDCALNHKAP, [Out] Guid DDPJMBGCAND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BOHICGMKMLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HELFMIOMOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKMDPBEAKHM(ByteString HMABDLODHOL, AGIPFCANOOI OCECMBMNNHF, [In] JFBNODFHPDI CCMMEAFFBOI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CLKJNJNIBJK
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
public sealed class NMDCKLMNHED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> AMHPCIBHJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> INKNAJAAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77CB20", Offset = "0x77BF20", VA = "0x18077CB20")]
	public NMDCKLMNHED(IReadOnlyDictionary<Guid, Guid> OJHPLDHMHOH, IReadOnlyDictionary<Guid, Guid> KOOOBJKIKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ABOJDDLAIMD
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC460", Offset = "0x5DCB860", VA = "0x185DCC460")]
	public static LCEOMNOIJLM GGIJBPAJKBH([In] HPOPCKCEFCG AEJLJEPKDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE2B0", Offset = "0x5DCD6B0", VA = "0x185DCE2B0")]
	private static void PJLGPPCCCFJ(LCEOMNOIJLM PFIBNMHNNJO, [In] HPOPCKCEFCG MKLJCOHDCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC640", Offset = "0x5DCBA40", VA = "0x185DCC640")]
	public static bool LNLJIOLCDNF(LCEOMNOIJLM PFIBNMHNNJO, PPJMIMOBDKC HMFCEONLNBF, [Out] NMDCKLMNHED? ECPIKAJHMBF, [Out] string? HCMLCAPJMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBA00", Offset = "0x5DCAE00", VA = "0x185DCBA00")]
	private static void BMCPKAINHLH(LCEOMNOIJLM PFIBNMHNNJO, AGIPFCANOOI? GELHOCHCPDG, PPJMIMOBDKC HMFCEONLNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC5D0", Offset = "0x5DCB9D0", VA = "0x185DCC5D0")]
	private static void IBLKOEGPJEC(LCEOMNOIJLM PFIBNMHNNJO, PPJMIMOBDKC HMFCEONLNBF, IReadOnlyCollection<ByteString>? KGKBBFMDMJM, IReadOnlyCollection<ByteString>? CHMEDMHDJFL, IReadOnlyCollection<ByteString>? FNMOFNMADFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDC10", Offset = "0x5DCD010", VA = "0x185DCDC10")]
	private static bool ONBILBPKLHF(LCEOMNOIJLM PFIBNMHNNJO, FNNPBGAIKGP LCHMIGEIFBI, PPJMIMOBDKC HMFCEONLNBF, [Out] string HCMLCAPJMPH, [Out] Dictionary<int, int> LFFLBGCHIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD930", Offset = "0x5DCCD30", VA = "0x185DCD930")]
	private static Dictionary<Guid, LFMBNEFAPFF> MOPNFBLDJHK(LCEOMNOIJLM PFIBNMHNNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC140", Offset = "0x5DCB540", VA = "0x185DCC140")]
	private static void BPDEPHMJEAA(bool HGOMEEGAMNE, GGMHGDCHGBB MNCIMHLDOFF, Dictionary<Guid, Guid> DJNJKENAMED, AGIPFCANOOI KONBKKOGEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC1D0", Offset = "0x5DCB5D0", VA = "0x185DCC1D0")]
	private static void CJFCMLLMIGH(GGMHGDCHGBB MNCIMHLDOFF, Guid AMIMNKPKDLC, JGDFGFNDDCO? BCHHOKNFHKA, Dictionary<Guid, LFMBNEFAPFF> PPAPFICLNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBC90", Offset = "0x5DCB090", VA = "0x185DCBC90")]
	private static void BOJIPPODCJD(IEnumerable<GGMHGDCHGBB> HBMIBEJNEEA, IReadOnlyCollection<ByteString> KGKBBFMDMJM, IReadOnlyCollection<ByteString> CHMEDMHDJFL, IReadOnlyCollection<ByteString> FNMOFNMADFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PPJMIMOBDKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public bool HGOMEEGAMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public DEOPKAALPDI LJPPPJEBNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public JGDFGFNDDCO? BCHHOKNFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public JGDFGFNDDCO? JJPICPONKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public OBPBNMACFOC GAMBHOLKOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public CLKJNJNIBJK LPADEOMPLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public LPOAPJJJNKB LAFHCKPIEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public BOHICGMKMLH HEBIMFLCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public OAOLHLLLMNK<OEPBFKIMMIA> BLKKFGICLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public EIHLGDDJJLI BEPPEJNLKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public List<GGMHGDCHGBB> JAFGAMIKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<string, object> INEPCGFKFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public LKNPHGJLPOD CPJMHGAAIAB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OPCPDFFPALK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4B60", Offset = "0x5DD3F60", VA = "0x185DD4B60")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JGDFGFNDDCO
{
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private const float GLKALFECNBB = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Vector3 JCADPOBEOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Quaternion KCLDFAAPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public float HHEJIMODBII;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 HNINLDCNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2AC0", Offset = "0x5DD1EC0", VA = "0x185DD2AC0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JFBNODFHPDI GLPADNLABDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2A80", Offset = "0x5DD1E80", VA = "0x185DD2A80")]
		get
		{
			return default(JFBNODFHPDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8F30A0", Offset = "0x8F24A0", VA = "0x1808F30A0")]
	public JGDFGFNDDCO(Vector3 JCADPOBEOPO, Quaternion KCLDFAAPKAB, float HHEJIMODBII = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2BD0", Offset = "0x5DD1FD0", VA = "0x185DD2BD0")]
	public static JGDFGFNDDCO LBGNODFJDDI(JGDFGFNDDCO ECLIMLPEPIL, JGDFGFNDDCO MGOMDDNJLHK)
	{
		return default(JGDFGFNDDCO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD29D0", Offset = "0x5DD1DD0", VA = "0x185DD29D0")]
	public static JGDFGFNDDCO GOCBKKMEEIH((Vector3, Quaternion, float) KKOACPFFAML)
	{
		return default(JGDFGFNDDCO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2870", Offset = "0x5DD1C70", VA = "0x185DD2870")]
	public static JGDFGFNDDCO GOCBKKMEEIH(Matrix4x4 IFIHPMOFBLG)
	{
		return default(JGDFGFNDDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E50", Offset = "0x5DD2250", VA = "0x185DD2E50")]
	public JGDFGFNDDCO PLOLKNPEKEB(Matrix4x4 BMCDLFLGACJ)
	{
		return default(JGDFGFNDDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2800", Offset = "0x5DD1C00", VA = "0x185DD2800")]
	public static JGDFGFNDDCO BJFJCKPEMJJ(Vector3 JCADPOBEOPO)
	{
		return default(JGDFGFNDDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DD29F0", Offset = "0x5DD1DF0", VA = "0x185DD29F0")]
	public readonly BOPPJOLNCCI GOFDINBCJNI()
	{
		return default(BOPPJOLNCCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class APDKNBNGKKF
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEF00", Offset = "0x5DCE300", VA = "0x185DCEF00")]
	public static JGDFGFNDDCO OBJGMCEHPMO([In] this BOPPJOLNCCI EAODMOEAJOC)
	{
		return default(JGDFGFNDDCO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HFBNKKFBBLN : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0ED0", Offset = "0x5DD02D0", VA = "0x185DD0ED0", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0610", Offset = "0x5DCFA10", VA = "0x185DD0610")]
	private void KFAIKNCJGOO(Dictionary<Guid, Guid> OLLIACKEHHH, FDPDFNBFAEK POBPDBGABDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0E70", Offset = "0x5DD0270", VA = "0x185DD0E70")]
	private void KFAIKNCJGOO(Dictionary<Guid, Guid> OLLIACKEHHH, EBHFDIMPOJF NGMLBPCIEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0BF0", Offset = "0x5DCFFF0", VA = "0x185DD0BF0")]
	private void KFAIKNCJGOO(Dictionary<Guid, Guid> OLLIACKEHHH, AHEHKDMDOIJ ACHMHCBDPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HFBNKKFBBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CIJFGIHLEON : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEF90", Offset = "0x5DCE390", VA = "0x185DCEF90", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public CIJFGIHLEON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class JPLADIMNBJJ : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3070", Offset = "0x5DD2470", VA = "0x185DD3070", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JPLADIMNBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class GENJOJNCPLH : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0410", Offset = "0x5DCF810", VA = "0x185DD0410", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public GENJOJNCPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class DAJHNDLHPCE : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF170", Offset = "0x5DCE570", VA = "0x185DCF170", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DAJHNDLHPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class COPEINIGNFM : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF030", Offset = "0x5DCE430", VA = "0x185DCF030", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public COPEINIGNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class OOMAHEOOBMM : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DD49C0", Offset = "0x5DD3DC0", VA = "0x185DD49C0", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public OOMAHEOOBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class FAGKKCPLLFA : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0320", Offset = "0x5DCF720", VA = "0x185DD0320", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public FAGKKCPLLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IILMFDPEHHP : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1110", Offset = "0x5DD0510", VA = "0x185DD1110", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IILMFDPEHHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NENGDKLLNBG : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD31D0", Offset = "0x5DD25D0", VA = "0x185DD31D0", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public NENGDKLLNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class IJAFCIEDMGE : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD12D0", Offset = "0x5DD06D0", VA = "0x185DD12D0", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public IJAFCIEDMGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class HIFKHHHPFLJ : OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly System.Random EBOKILKNFPK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0F50", Offset = "0x5DD0350", VA = "0x185DD0F50", Slot = "4")]
	public void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HIFKHHHPFLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ELHNKIJACNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public FNNPBGAIKGP AJLAIKHEKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public JHBBHNDOHOA DJIALDNJHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<int, int> ANHKEMLFMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, Guid> MDIMCFDJOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public LKNPHGJLPOD CPJMHGAAIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public bool MFEFNNBCMHE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OJJLJJKIJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PECAHPEJBEO(GMCMMBMBBNA BGKGEEOIKCP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DFLIPNDPGGE
{
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private static readonly OJJLJJKIJBK[] FPKPGHHPNOL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFAC0", Offset = "0x5DCEEC0", VA = "0x185DCFAC0")]
	public static void GPJBMHPEHAN(GGMHGDCHGBB KKOACPFFAML, Dictionary<Guid, Guid> ACGLHHDOFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF760", Offset = "0x5DCEB60", VA = "0x185DCF760")]
	public static void FLDMNJBPDBO(GGMHGDCHGBB? KKOACPFFAML, AGIPFCANOOI KONBKKOGEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF390", Offset = "0x5DCE790", VA = "0x185DCF390")]
	public static void CMNLFCJLLNA(GMCMMBMBBNA BGKGEEOIKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GMCMMBMBBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public FNNPBGAIKGP ALINPDJLFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public GGMHGDCHGBB MNCIMHLDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public Dictionary<int, int> ANHKEMLFMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public Dictionary<Guid, Guid> MDIMCFDJOCG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0560", Offset = "0x5DCF960", VA = "0x185DD0560")]
	public Guid DJHMBILELNB(Guid GJKCBNEBGAL)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LKNPHGJLPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BKGAHBLHNBK, [Out] Guid ICHIIDMKPOI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OMAAGKHKCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly HashSet<string> OMKAMLMCHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Dictionary<long, int> LDIIAMNCOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private readonly HashSet<Guid> OHBHMLPGELA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> AKAOKFBECGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> HBJEGDMFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD46F0", Offset = "0x5DD3AF0", VA = "0x185DD46F0")]
	public static OMAAGKHKCPD OMDEJIMGCPB(LBKGIILDFAD BMAKDMAHBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD36A0", Offset = "0x5DD2AA0", VA = "0x185DD36A0")]
	public static OMAAGKHKCPD DOBGDHFKNHM(LCEOMNOIJLM GGFGKOFKPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3780", Offset = "0x5DD2B80", VA = "0x185DD3780")]
	public static OMAAGKHKCPD IOBBBAKLFFO(IEnumerable<string> OMKAMLMCHDB, IDictionary<long, int> GPAFPJDAHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD48A0", Offset = "0x5DD3CA0", VA = "0x185DD48A0")]
	private OMAAGKHKCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4760", Offset = "0x5DD3B60", VA = "0x185DD4760")]
	private OMAAGKHKCPD(IEnumerable<string> OMKAMLMCHDB, IDictionary<long, int> GPAFPJDAHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3CF0", Offset = "0x5DD30F0", VA = "0x185DD3CF0")]
	private void MCKILBHONHK(LBKGIILDFAD BMAKDMAHBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4500", Offset = "0x5DD3900", VA = "0x185DD4500")]
	private void MCKILBHONHK(LCEOMNOIJLM GGFGKOFKPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3EF0", Offset = "0x5DD32F0", VA = "0x185DD3EF0")]
	private void MCKILBHONHK(NPDMEBBAKNO? AFFGDBELLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4390", Offset = "0x5DD3790", VA = "0x185DD4390")]
	private void MCKILBHONHK(JAOLGFHDKJL? JKACDAAJHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3900", Offset = "0x5DD2D00", VA = "0x185DD3900")]
	private void MCKILBHONHK(GGMHGDCHGBB? MNCIMHLDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3710", Offset = "0x5DD2B10", VA = "0x185DD3710")]
	private void DPKMPPBNNEG(string? BAGICNHBKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DD34D0", Offset = "0x5DD28D0", VA = "0x185DD34D0")]
	private void DEENHOLHNGF(PGCHABGJLDO? KOEHNHBNHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DD35B0", Offset = "0x5DD29B0", VA = "0x185DD35B0")]
	private void DEENHOLHNGF(IBENOODNNLA? KOEHNHBNHLO)
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
