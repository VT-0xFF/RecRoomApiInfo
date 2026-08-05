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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60F46D0", Offset = "0x60F38D0", VA = "0x1860F46D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FOGIICJMGJO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> APMMCNEMKIE;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> JJCPKACNJEG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string DCCEAOMLMEP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string OIGBBLKIPHM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string FDKHJCFJMLD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60F18A0", Offset = "0x60F0AA0", VA = "0x1860F18A0")]
	public static bool CDGEJHBIJLC(Guid CNPGGDBHFAA, int CHOHLLOIHFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60F19A0", Offset = "0x60F0BA0", VA = "0x1860F19A0")]
	public static string DECILIJIACB(Guid OHJPHHKPEGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MAIAJEOIBHM]
public enum GMGHPNDJDMG
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
public static class HOKJGDLKHOK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid AIIGLHKBGCG;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid PKFLGMLCAJJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid PCNGDNOEOOM;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid LCBJCHLAHEM;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid JPMGNGLMLBC;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid PHNGGINGKHK;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid OMBMICGKCHJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid DCFPGAJJKAM;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid FCBJFANMFKB;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid NHLGEKFECEF;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid JIGCHFEJOKO;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid HPIPBHLEDFO;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid DJCGOAHOBBO;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid EIDDPCJNBHD;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid CALNKCJHOGG;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid LGNPIJEAMCE;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid MNAAEFPLNDG;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid HGIBAPMCMOC;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid HPIMBKBLACJ;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid GBLINDHOKAB;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid PGACGNMAGFF;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid KHHPMEGOFDD;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid EEFLMGBCGDE;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid EMKCEPDFNNM;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid ELEPEPOPFMN;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid ELLAGKKKHDM;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid AMGOOJIOLLA;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid MHNLFFAAGMI;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid DIENBOBHAGH;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid KOHLFHKMKAG;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid OMJBNFLHAFN;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid MHKODLKLGIH;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid AGCKANNMECG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid PNAJJKKKDFP;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid EDEMKIJLNML;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid MHABDADJNHP;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid PDJDPLINMOM;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid ILKEJNGGGDI;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid IOCKOJOEPOF;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid JABAPMPCIEN;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid HPJMFNNEEFN;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid NMHEMEKDBNC;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid MIMOGIFOAOF;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid MOCHAIHJFKP;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid LMOHFNGGKIL;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid LEOILEFNBLK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid MMEFMHBADBC;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid BGGPINNICAP;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid PBAGGFDEHAN;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid AGPGMBNGJHC;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid GJEDNAGIKLN;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid FLKLDPPEIAF;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid KFEGKGDIPFF;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DCGOHJCIDJM;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid MOHOFBECLJA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid DDCNJNPCMIM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid FCOHJMMLLBP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid COPKDBGHFDA;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid OCGKDACOPGJ;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid IDINHKGONJA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid CIAJMMHNIPJ;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid KEOBBJIHNED;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BAIOJIMNJPG;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MENFBGFIOIA;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid CIAOOMHJAFH;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid FLJIFIIAACD;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HNBMGKMPPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid AJAJEIJHHNI;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid AHHBNJHEEAM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid BKBAGNKIALJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid LJOKPDMBGKL;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid IEDDENMCHHE;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid KNHMKIOMOAI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid GKLDNELJEMK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid DJOINCEJKGP;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid APJMBEBCBAC;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid OJPDCIDKNPP;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid GONNEMBLJAB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CFNCPDEKCEG;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid MCGIKFOJLDA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid KFCCMLBBPPE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid HGCMKKOLJEM;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid EOCHHHJINKM;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid EECBAOPGMPF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid CLJANCHPGEK;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid ADJJECMMCOM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GDKDOHOHLCC;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid FOJCIDGKFCH;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid HOGBMKNODHJ;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid CGPHEJBKLMM;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid BJOGOHIGMOM;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid OJKLDKKKPBF;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid DCJFMNHJBDA;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid PKKJOJBMDLP;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PGMKCIOAMBP;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid ICCGMFBBGEA;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid ONNJIGPGIOI;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid MABLJOPFCGL;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid ILNBPPEJGCH;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid KHDHMOEFJLP;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid JJNEMKOBHCD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid LLHAJODMJBB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid PLODNCBFIEO;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid NJHJLKBBENP;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid HNNAAKKFKDA;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid IFABFHKLOOM;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid JJJELDCBHKE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid CGFLIEBPGAA;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid KKFHOBNLGON;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid OHHJKJEGPFC;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid CIIEOOIDNFK;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid GKEDLFGALAJ;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid ALOHJFOPKBE;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid JMPFBCPJPHM;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid KCLHEEICJHK;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid CPINMDMLHBA;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid AEGMFMKMPOP;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid HMJAEAEDPBJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid BEHNMECLOEI;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid LADNDODBIAL;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid GAODOGCJMLK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid DPHHBDNDNOD;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid MMBABFHBDBP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid GHEHOBIBFCF;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid NMBFGMIJMFO;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid FPHHGHLIGGK;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid OCJPINEOPGP;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GNNDJOMFMFK;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid AMBHMGAKFFO;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid NFDAPLMPHPF;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid KMIDIMOBJGJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid KCPJKDBDOLO;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid LBHBFCLFNJL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid HNIKGNEGDEM;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid BAOFPJOOAEL;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BNJHHFMFDGC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FFDHLOILBHK;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid FEKCJJIIMKP;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid DHHLKJOANAM;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid HGPGCMPBODI;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid CACLGHIJGFP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid HJDCIBABPAP;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid BONCHPLPBMO;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid FCLGINNDPGN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid PLFOKPDPHNN;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid AKCPHMHJBMF;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid PHOICEFCKHJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid NKCOELHNCJP;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MOPJMNKJIAC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OMIBBIICALF;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid BFEPEDHDHIN;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid NHHJMNBNGKP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid IECGEAECCGK;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid NKBMCEDGDIO;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid BFOKKMPOANK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid KJEBKMGDBBJ;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid OHHMCHECJFF;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JPFLGLJLAIG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid HLFLDKPOLPH;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid LJKMJJPMDOL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid MPCKLIMAIAF;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid AEEOBIPJMEF;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid OJMPKAIFGBO;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid MMDNPMDPBFI;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LPLFANOCBBN;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NAGIHCCJKBH;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid BGIDEMBPBFO;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DPPBGHCDLDD;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid OHLJPPLLAGF;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid JHBCMKOCELG;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid EDBGBKDPMPA;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid JPAFANADLHF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid PEIHDPFMPLM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid GFFCJLLLADF;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid HEMKOPMEGIN;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid GIDIMOCNPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PONHGCCGHFB;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid ECAHGLBDMGH;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid CABNAMJHKAM;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid KFDKNEDNMEH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IHNAHDOOIED;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid HKCMLGADBLO;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid IDEOBIHKHFP;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid NPKGHKKGOMC;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid LKELMHPFEFJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid OCONFNLKBPK;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid ECLGLCHNEEB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BKDBMHACOOF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid KEINFGKICFD;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid MGGLBILMCIJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid FOLGNCFADIG;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid HKIPICCLHED;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid NGJILLHNOBA;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid PNFBEPEENFC;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid ADLCDPEMFHL;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid ONLPGKIPEIB;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid IPOPAKJLFEI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MFILLFJBPHM;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MLOGEPOLLLP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid POHNADHMBBH;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid BEBLMJIBLFI;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid LDMPIHAODMI;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CACCKEADDAL;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid LAAIGGOHIAI;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid EKIAGJGNDDI;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid IGOFDADGBMN;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KNLACODOGPH;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid AGHPMAAKFNO;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IOHIKPFEANC;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid BKIPJNNCPEB;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid COIBLLGCFHN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid OKBDGJCNPJD;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid BCDGIFHJHNL;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid BCIJGCBIOGK;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid CLHJAKPNCDK;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid GFGHKNIDOCP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid INIMLJGHKAL;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid KNNFGGNJDIP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GKJDPMNPNHG;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid KCLEEOMLPPA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IJNICBEOCNA;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid CEJFJLBHHHK;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid IAGPOADLKGF;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid BBOIAABBLPF;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid EKLGMOILEJD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FBNCBHJEBLC;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid NPMPMECEDMG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid KBIEOMLMPBI;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid IJFLNGGKPDA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid CEFDFMNLMEP;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid HHKBOCJEHGL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid IKMLPFAODBN;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid FEIPOEEPAAM;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid AFJMHBIMMBE;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid HFECIFEKEMI;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid FAEFAIJMFPC;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid BDOGPPNDELF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid IOLCKPKLHMO;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KGPOBLOOIPA;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MDFFJHKMMDO;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid PKDAIOLMBIP;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid MKLOGBHHKOP;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid BBBGIHNEIOD;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid HKCACGNHDHF;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BKAGCDBMLEF;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid HHBENEPMKCP;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid PKBODGEAGIJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid NMHOAHKFNAJ;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid KNCAOFECJCB;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EEAMNKKPKFO;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KENGCEKAGDM;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid BGMHEINFECL;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KLAPKNGOPJO;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid LAHAMKEMICK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid CGIBBHFPFGN;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid KNBDHAMEONE;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid IHFIGLGINFO;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid NKKBDHIAMGH;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid EAKIINHEAFA;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid BLCCGFIPBHP;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid JGHBKMENODL;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid LFHCJAECKAP;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid OOCOLHNHCEA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JOKNGIJKOJH;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid AANAFAPKDEO;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid AAGFDONDAME;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DDLHPAFEJML;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid HCIMEOIOBAM;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid FDLHAOCMACI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid GLBNABFCJKO;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid BJCPHMNMNEE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid NAJMPCILLLK;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid CPEPAELGIOH;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MPGFNAHKALJ;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid GNNNHKBKHFP;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid BNMAPPHJMAH;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HPFGDLHIDJF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid GJDDBCGJPHO;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid NKGIKCPHLAN;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid DBCODFIFJGP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid OFDJEBPIIAD;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid EJLGNNMONEO;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BDBICHCOGBP;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid ECPOEDNACKF;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HHBKPDCBLJO;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid BPJEBPOGHNB;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid OMKNEGHJKDI;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JIIBPBMPAOD;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid ENKBKJAFPMN;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KCGJIEBAPDM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PPACEMCONGC;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HGFEGMLLHAK;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid NMPKIHJGAAN;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid NJCMMIPLGKH;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid IKMILJGOOJL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid IKMFNJAELON;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid NJHEBEBFHEM;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid EJMKACDNAFL;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid KMCGBEEECGB;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KPMLFBIDCIN;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GAOAMIJFOAC;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid PLPAJHOGPCB;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid JBKOENHPOKB;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid GCFMJOAJFHO;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid KKPFEDMDCGE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid EMDEMHBMAKP;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid AMMDMFJGLCC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid PHLOLOPDHJM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid DMDCFGHLMGN;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HGLKDEDFPNA;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid BDCBIDIALCI;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid HCPNMGIBDJK;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid OCOGLBAIKCH;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid GBLODDHAANF;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid HOONPIOPMFC;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid NGDKJCIPCDH;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid PHOHJNPHCIM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid BABBINFGIJI;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid KNJGJFIIOEL;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid LLJOHNFFOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid DNLEFPNIJEL;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid BPOJNNANGIM;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid GIKKINGILPK;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid BGFONLEBLDO;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BLLMLLGFMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CGPFLLOIKOH;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid KPHFEINGICO;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid HIHCBOCFPNH;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid IOEFCHALNAN;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid OEAMIBDLMEN;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IDPNAHJOJBJ;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid BELMHOFFAJL;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KLDIJIILINA;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid DJIFKPOOIBL;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid FOBPDIDAGKK;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid KDHFEHFPBLK;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid LFBHMNJIEGM;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid GAOEMAGNCPM;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid GDMBALJDKBL;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid CNCJDAEMMGJ;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid DJBAECANAFI;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid INHEBOELNFJ;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid EOEFLDAIENH;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid HLODIIAHGFD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MOAFACNLBKI;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid ECEHPCNHILO;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid ACAFCNLPAJD;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid ALJECMMKKOA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MJGCBIBMMAF;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid HAJEJCKIBDG;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid HHNOGHEMEPC;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid OCOMONPPEJB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid GGONAJKFLNG;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LANCJBLBIGJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid OOFFGKILCAL;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid ONAHBKLBOCG;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid CHAADOKLAPJ;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid DKGOOPOFPDG;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GILBBMMOACJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid LDEEDFMEBCG;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid AONKKKGHNGB;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid BLNMLFEDHMH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid FHOLIGBABHC;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HIHBBJEGJBN;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid LFNODEDFMGO;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid KDGPBNOIAJH;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MHPOKJCKEKP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BKLLDDAMMHA;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid MBBBIJGECBG;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid MEHJPLPMOEA;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid FAEADEFFEBN;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CIKPCFPIBIE;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid CCJGHDINIAM;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid HLOLGAFFDDP;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid NIEOCLIHBNI;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid BDIPFFAADGM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid IFLGFEMEDBI;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid JGEOHHFAELJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid AJFOJHCMKEA;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LICJMHMKHPH;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid KCPHLKBGDKB;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ELPGAPANPGM;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid KGCBEHKAEKD;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid PIPHMJBNGGK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid KKKNGJOIDKN;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid AHAFHBNPBBA;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid NFDGFJKAGED;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid HNONLIBGDCM;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid EICLFHHKFIF;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JIFOMCIBDDF;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid AJGIJOPGAAM;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid DPJDBOMAKMP;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid FJPHFAJDECP;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BBPMGOGFJAJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid MNAJKANILKD;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid NGLNJBFOIOE;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CBJMOOAHHEG;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PPHAFKPALPD;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid AFPPOGDHOCC;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MJJPJFHLPHM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid CNOJCFFOGJE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid HHEFNPDPHAH;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid JLGILJCLCHA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid HEIDGMNODOB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid KBOOICAHMJN;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid HOCJNHNONLI;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid BAKCJIEAMAE;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid HMEHLLNGAKN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid IFCBIIPBJBO;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MBFOIOPKOPD;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LHHCKDDHIOK;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KOGJMLHKGJC;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid DCNHHGHHKPI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid GEJFNPNPEHB;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid LFAONGLHLBN;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid KNOPHAMGOEP;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid HHDOBNIAHMG;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AGJGGOFGCPF;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid CHGDMIBFCNF;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid JFNIONNCPBI;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid OLNBMDIDLKL;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid DKPINBFPIEJ;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GDJNDFINMEK;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid GCKDJCAFADH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid OAOMLBKBJCO;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid NEBIDDODPHI;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid PBCHHFJGIDK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid EJDPOPONJFO;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FJOJNAOBPMF;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid CBFDDIONFAM;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid OAMMJEMFECC;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MJECBBFCHGK;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid PBLGLIMPLNF;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid IABKKEDOANM;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid FOAEPBFOGDK;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid GNDFNPBANAL;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid BHIFELAICBE;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid HKICJOIABNG;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FLEINJHBGOA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid IHLFHPDENGN;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid MCNAJMNJHPF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid KBDJAGIMNHO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid KMLPKAGMLBF;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid DPFAELCJIID;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid BMINEKFPLAB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MFPPGBABOOB;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid LOOAIJJMCOC;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid PLIHGGFBCNM;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid GLPMGHJEEEG;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid EOBLJBKOLFB;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid PIEKKJNKBLM;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid PBANEELBEKP;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid JDHODIPKJNI;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid OINPDCGLHGE;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid EBJOMLCBAOK;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid FHCCFPGECJL;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid LLDCFPBNDAA;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid OOADEEEBLHL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid NIFEANJPPOG;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid LANNDANLHKI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid GCGEAMCPMLF;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid CDOLHJEEABK;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid HLCANCFGOOE;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid CLLOCDAGFLF;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid MEBBAGEOIHC;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid KHMEKHGAAND;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid KIBNNEMPBKE;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid BNKCEMHJCEB;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid AMJGJBAJGEI;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid OBDCDPNNHIO;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid HCLMOHJKCPN;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid PCIHLMMLDJP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GDGEPMJBFAG;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid IABIJCPIABI;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid COOLGNMEPOD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid AOOAECDEOGB;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid GMFBEFJJGLN;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid OFDMPAIFCOJ;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid CAEBJEBELPH;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid PHJKGDPOEIB;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid EDCALLLAFID;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HMCFPPPPPCA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid BNBMMDAFOMI;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid LFDFICEGNLO;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid DMDHMLEALMO;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid BPAACKNHMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid OBOHGOCNIEM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid HIMLHGEHLFL;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid DBIBHFAMABE;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid NIHEOJOKFFE;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid EJMHEPDLKDH;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid IJACGHLPLJI;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid KILFEGNCKMA;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid HDFNHHFKNGK;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HFLNKMJDAFN;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid GKFKCDHMPCE;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid NIKBJBNMAPO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid IHPJEAMCJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid PLPIOANILHP;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BEJGKHDONGB;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid EAGGKENKHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JLPBGPHMMOD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid GIBHEHJDMLP;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid BANHJGKGCPP;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid OMLHONFENMI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid ABBFPKOLKDF;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid CNBAAMJMDCJ;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid CLEJHLEOHLB;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid ILONLJOKAOA;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid KDOFMKACNCG;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid JGJJDPDGAIE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid LNLMBACHABA;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid PONDGOILOGF;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MLOIMJKMEBK;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid FOINMMCGDHN;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid OHGLGANKOEL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ECGCKFOCMDB;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid IPOELBJBHEP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid OPKLKCKIPMI;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JCPDDDCMFFA;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid OCFGIDHBFMP;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid CGLLLDHEIAM;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid MENOFGPPPFI;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid ILFFDCLCEDB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid MKFJIADPKMB;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid KNNJMHMGBGI;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CPNABLIKKIC;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IFDGAJDBHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid EMACOEAPGOK;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid FCOLIBKOEHB;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid OHOAAIGHJMM;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid KELBLKFKKKD;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OJKBPPJKJNL;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid HBJMMILALHO;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid ALJOKOBJKNA;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid AFJBABDILMD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid DKOFMFKCLLK;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GLBHNEODJFB;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid ALGCCMFNPFD;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid OJPLLCPKCDG;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid OOIJKMNABDI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid KMEGGKALEIK;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid KACHLMDKEDH;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid BFFGKFPIGFM;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid PBMBHGLPOMM;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid AMFJANPFLAI;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid NMIIMAHALAF;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PEDNBDNCDGE;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid NJDPAHOCGND;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid JDHFDKIKMGL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid DADGALPCEFO;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid EIJGIDNLNJL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid OLCIPLPEBMH;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid NJFEBPEPPEK;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EGGBBFEONIJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid FBABCPNBLGL;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid JGJEMJMCFKO;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid ONJKEPMIEME;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid MGPDCCMBPDE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid HGLNPMNGOEB;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid CBBNKHEGFAJ;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MCOELMHCMNP;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid PPCONHALPML;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid OFEGGBFBIBM;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid GFLAICOEIEG;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid OCLNOKPBHFB;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HAMDHCMOINH;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid HNKNMOOIKMP;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid DHGIDBLJFNP;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid DJNDCPJIIFG;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NKIOMHFDBEL;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid MLGKHBJEFPH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PFFFJGLNNEC;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid CKJIADEGLFG;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid LPNCHCDMPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid AJCNFCMKMGF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid JNEJKOALKOD;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid AFDIBBILPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid HOLLDNMHAGE;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid LKCCIKOCFOE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid NFENAJEOLOO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid IKPIMPJCJDP;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LNIHBALFJAL;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid LMBKNIFPJBG;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid MKCKAKPNIBD;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, GMGHPNDJDMG> HGDDHCBGPIF;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<GMGHPNDJDMG, Guid> DNGJPELEJAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, GMGHPNDJDMG> JAABEBOPLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60F2F40", Offset = "0x60F2140", VA = "0x1860F2F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<GMGHPNDJDMG, Guid> NHHLCKGMIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60F2FA0", Offset = "0x60F21A0", VA = "0x1860F2FA0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ECDBNMIFDGK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60F0B80", Offset = "0x60EFD80", VA = "0x1860F0B80")]
	public static bool KDPGMJDBLBI(CADKFMIMPIB OLKBBKFIGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60F0BB0", Offset = "0x60EFDB0", VA = "0x1860F0BB0")]
	private static bool KDPGMJDBLBI(MBICFHCMLGE MEADHOGLMCH, CADKFMIMPIB OLKBBKFIGBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NLIFPEMBLKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly DPFEBOHIMHK LNOLLDAAEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<ENBAAEOIEMA> GILFJNHJICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<ENBAAEOIEMA> GBGFKGDIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly IJMPLGOCAIG<ENDAAFIJDLG> FIIMOHPEHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<JJGAGGDHEOK<CNEFPEIGAAA>> DKIJOLLJOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString CIAPCAAIJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly EMHMDEFCEPO PAPPGIHGFPN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60F4640", Offset = "0x60F3840", VA = "0x1860F4640")]
	public NLIFPEMBLKB(DPFEBOHIMHK PIKOMEEEOAJ, IEnumerable<ENBAAEOIEMA> MILEALDCLGB, IReadOnlyList<ENBAAEOIEMA> DNOBFPGANEC, IJMPLGOCAIG<ENDAAFIJDLG> NJMLNHMKDLP, IReadOnlyList<JJGAGGDHEOK<CNEFPEIGAAA>> ALGBMHJNOJD, ByteString AOGIBMFDKBE, EMHMDEFCEPO MHMONDKDCML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EIFJBKCPEOA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(LIAJPOIIOHO GKNJGNIHLDH, [Out] Dictionary<int, int> ADDEDNKBJKB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(DAMFCNFGEAE CGALIOCEFBN, HFOHDFLGFEE MIMCDLIKEDA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IJIAPBOEGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid DFKELNKGGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> CODMLBNANDF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> LOMKEJFJJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3561B00", Offset = "0x3560D00", VA = "0x183561B00")]
	private IJIAPBOEGIK([In] Guid NFJNGHMMPBP, Dictionary<Guid, Guid> FCBFJNBLBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60F3000", Offset = "0x60F2200", VA = "0x1860F3000")]
	public static IJIAPBOEGIK AEJEDKPMAJA(IReadOnlyDictionary<Guid, Guid> KEGHOLJMCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60F3240", Offset = "0x60F2440", VA = "0x1860F3240")]
	public static IJIAPBOEGIK HHPIICEFDPF(IEnumerable<KeyValuePair<Guid, Guid>> KEGHOLJMCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60F3120", Offset = "0x60F2320", VA = "0x1860F3120")]
	private static Dictionary<Guid, Guid> GCGAONEFAOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60F3010", Offset = "0x60F2210", VA = "0x1860F3010")]
	public Guid AKFKOKMPGEM([In] Guid OHJPHHKPEGL, bool OEIDKOOKOOP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60F31D0", Offset = "0x60F23D0", VA = "0x1860F31D0")]
	public bool GKJGNPHBFAN([In] Guid EOHPLEHPKEN, [Out] Guid DELADOGMNBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBKFDHHEIDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KHPHFNGBMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APPDJDLGIOH(ByteString LNCKPNCHLEI, IJIAPBOEGIK ODIIIKDGMOH, [In] COOFBPBFEIJ OECKPHAKBFD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JIHOBJGDNFJ
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
public static class FPAEDEKGPAC
{
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly HashSet<GMGHPNDJDMG> DEIALLJIBMC;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MMEAJDGDEDN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> MOKHHBEIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> OBAOBFDAAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6A0", Offset = "0x7BA8A0", VA = "0x1807BB6A0")]
	public MMEAJDGDEDN(IReadOnlyDictionary<Guid, Guid> NKFHBGCBJHG, IReadOnlyDictionary<Guid, Guid> EDICBFNGPHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CALOEBGOKLP
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60EF520", Offset = "0x60EE720", VA = "0x1860EF520")]
	public static JDOFJAAAMEN LGBGEFOFDAC([In] NLIFPEMBLKB JBNEFCOEMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60EEE20", Offset = "0x60EE020", VA = "0x1860EEE20")]
	private static void IBIOBGNHMPC(JDOFJAAAMEN NLCOPPEGEPM, [In] NLIFPEMBLKB IIMAAIJLPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60EC3E0", Offset = "0x60EB5E0", VA = "0x1860EC3E0")]
	public static bool CEBIDODJOOG(JDOFJAAAMEN NLCOPPEGEPM, OLGHLKDNGKJ OOALGJPGGDM, IJIAPBOEGIK? DKMPDODOBDI, [Out] MMEAJDGDEDN? FCBFJNBLBNA, [Out] string? PLLLDOCFAPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60EEB90", Offset = "0x60EDD90", VA = "0x1860EEB90")]
	private static void HJKBHCNAGEI(JDOFJAAAMEN NLCOPPEGEPM, IJIAPBOEGIK? DJECFJLCBHM, OLGHLKDNGKJ OOALGJPGGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60EE390", Offset = "0x60ED590", VA = "0x1860EE390")]
	private static void DKHKNAOEMEP(JDOFJAAAMEN NLCOPPEGEPM, OLGHLKDNGKJ OOALGJPGGDM, IReadOnlyCollection<ByteString>? LDBOJCMDPHE, IReadOnlyCollection<ByteString>? DGDFIBNJKEN, IReadOnlyCollection<ByteString>? JKHLHOOFEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60EDCF0", Offset = "0x60ECEF0", VA = "0x1860EDCF0")]
	private static bool DBGECJJANNK(JDOFJAAAMEN NLCOPPEGEPM, DAMFCNFGEAE CGALIOCEFBN, OLGHLKDNGKJ OOALGJPGGDM, [Out] string PLLLDOCFAPI, [Out] Dictionary<int, int> ADDEDNKBJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60EE400", Offset = "0x60ED600", VA = "0x1860EE400")]
	private static Dictionary<Guid, MBICFHCMLGE> FPMHJOEPCFO(JDOFJAAAMEN NLCOPPEGEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60EF480", Offset = "0x60EE680", VA = "0x1860EF480")]
	private static void KDBIBCDLJKI(bool MNOHNHCMFPF, ENBAAEOIEMA KPJGGGPNEJL, Dictionary<Guid, Guid> PBNFLHOELBE, IJIAPBOEGIK NOAKEBJMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60EDA60", Offset = "0x60ECC60", VA = "0x1860EDA60")]
	private static void CLDOELLAGHP(ENBAAEOIEMA KPJGGGPNEJL, Guid PIPIJOMAIBD, JDGIDAIJOGF? JKOKOMOGBNF, Dictionary<Guid, MBICFHCMLGE> OJIJBEEIEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60EE6E0", Offset = "0x60ED8E0", VA = "0x1860EE6E0")]
	private static void GHJDPIKNPDO(IEnumerable<ENBAAEOIEMA> MAHOFPDMBDB, IReadOnlyCollection<ByteString> LDBOJCMDPHE, IReadOnlyCollection<ByteString> DGDFIBNJKEN, IReadOnlyCollection<ByteString> JKHLHOOFEJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OLGHLKDNGKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public bool MNOHNHCMFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public EMHMDEFCEPO MHMONDKDCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public JDGIDAIJOGF? JKOKOMOGBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public JDGIDAIJOGF? BIFDFJIPLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public DPFEBOHIMHK KNDPBIAAGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public JIHOBJGDNFJ NKKDBDJILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public EIFJBKCPEOA IJOEGDEFJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public CBKFDHHEIDH EBDCHLOKPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public JJGAGGDHEOK<ENDAAFIJDLG> KPCBIBNBDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public JHKEKFANGED GNHJECJFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public List<ENBAAEOIEMA> GLDGKKJKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<string, object> AAOMIDDEMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public IBHBCPBJNNL JGLCLBIHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public bool IPPKDHNFDNH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NFBLKLOEEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60F4910", Offset = "0x60F3B10", VA = "0x1860F4910")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JDGIDAIJOGF
{
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private const float CDOKJBECCOE = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Vector3 HBEJPCPOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public Quaternion KIIONLKEIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public float LNFDMKEIMFC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 PEIGGEPIGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60F3D50", Offset = "0x60F2F50", VA = "0x1860F3D50")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public COOFBPBFEIJ CJNCMEGKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60F35F0", Offset = "0x60F27F0", VA = "0x1860F35F0")]
		get
		{
			return default(COOFBPBFEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9DDA10", Offset = "0x9DCC10", VA = "0x1809DDA10")]
	public JDGIDAIJOGF(Vector3 HBEJPCPOKJI, Quaternion KIIONLKEIBO, float LNFDMKEIMFC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60F36A0", Offset = "0x60F28A0", VA = "0x1860F36A0")]
	public static JDGIDAIJOGF DNHLAHKAJCL(JDGIDAIJOGF DMKJLMNBOME, JDGIDAIJOGF JLIKCNAKPIG)
	{
		return default(JDGIDAIJOGF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60F3BD0", Offset = "0x60F2DD0", VA = "0x1860F3BD0")]
	public static JDGIDAIJOGF MLCODHGANFM((Vector3, Quaternion, float) GKNJGNIHLDH)
	{
		return default(JDGIDAIJOGF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60F3BF0", Offset = "0x60F2DF0", VA = "0x1860F3BF0")]
	public static JDGIDAIJOGF MLCODHGANFM(Matrix4x4 DHDIMMOMLDH)
	{
		return default(JDGIDAIJOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60F3920", Offset = "0x60F2B20", VA = "0x1860F3920")]
	public JDGIDAIJOGF HOPHJGCHINE(Matrix4x4 ABJBIFMIENO)
	{
		return default(JDGIDAIJOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60F3630", Offset = "0x60F2830", VA = "0x1860F3630")]
	public static JDGIDAIJOGF DDBKOHDAPFE(Vector3 HBEJPCPOKJI)
	{
		return default(JDGIDAIJOGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60F3B40", Offset = "0x60F2D40", VA = "0x1860F3B40")]
	public readonly ACLKEIAFHHL LGAFGOEJCPC()
	{
		return default(ACLKEIAFHHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JHFDPEAIAOM
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60F3F60", Offset = "0x60F3160", VA = "0x1860F3F60")]
	public static JDGIDAIJOGF LMOCHLEBBKJ([In] this ACLKEIAFHHL KPBGCHDNDLM)
	{
		return default(JDGIDAIJOGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EDBJFIFBPNP : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60F1820", Offset = "0x60F0A20", VA = "0x1860F1820", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60F0FC0", Offset = "0x60F01C0", VA = "0x1860F0FC0")]
	private void CGAPMJOOKAK(Dictionary<Guid, Guid> HLEIJIEMGGK, JPCDGDPHAOI GDBOLGFELOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60F0F60", Offset = "0x60F0160", VA = "0x1860F0F60")]
	private void CGAPMJOOKAK(Dictionary<Guid, Guid> HLEIJIEMGGK, EKLHDMGKFEB OCJAJJAIADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60F15A0", Offset = "0x60F07A0", VA = "0x1860F15A0")]
	private void CGAPMJOOKAK(Dictionary<Guid, Guid> HLEIJIEMGGK, AFEIHFPPPBK OHKLMHMPHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public EDBJFIFBPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GEBBFCBKNEB : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60F2EA0", Offset = "0x60F20A0", VA = "0x1860F2EA0", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public GEBBFCBKNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class KDKGCPOFMIA : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60F3FF0", Offset = "0x60F31F0", VA = "0x1860F3FF0", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public KDKGCPOFMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class KJGBANFCFBB : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60F4200", Offset = "0x60F3400", VA = "0x1860F4200", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public KJGBANFCFBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class OLPBANMIPBF : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60F4960", Offset = "0x60F3B60", VA = "0x1860F4960", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public OLPBANMIPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BFLIDKJPBOI : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60EC100", Offset = "0x60EB300", VA = "0x1860EC100", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public BFLIDKJPBOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BGJEKKEPIMM : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60EC240", Offset = "0x60EB440", VA = "0x1860EC240", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public BGJEKKEPIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class AGGMFPBPGLD : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60EC010", Offset = "0x60EB210", VA = "0x1860EC010", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public AGGMFPBPGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class OLDNNHNDBGA : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60F4750", Offset = "0x60F3950", VA = "0x1860F4750", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public OLDNNHNDBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class NAABKEIBLEP : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60F4480", Offset = "0x60F3680", VA = "0x1860F4480", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public NAABKEIBLEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JDJLJHJAPOE : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60F3E60", Offset = "0x60F3060", VA = "0x1860F3E60", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public JDJLJHJAPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MHAMHMLPCOM : HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly MBKLLOCHGOC DCEFLJKFPDI;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60F4350", Offset = "0x60F3550", VA = "0x1860F4350", Slot = "4")]
	public void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public MHAMHMLPCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CADKFMIMPIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public DAMFCNFGEAE LMCDLECLJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public GDGHHGOMGAP MIAFBAEHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<int, int> MBFLDLGNLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public Dictionary<Guid, Guid> LCLNGHHLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public IBHBCPBJNNL JGLCLBIHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public bool HFKBKHJLEAK;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HIOAPBEACND
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKAJNKNANEK(KIAHAPDNGMI FPOFNJFNKOG);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PCOCBLNPGBJ
{
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	private static readonly HIOAPBEACND[] CEBBBJKNLHE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60F4E60", Offset = "0x60F4060", VA = "0x1860F4E60")]
	public static void BJDLEOCGFJL(ENBAAEOIEMA GKNJGNIHLDH, Dictionary<Guid, Guid> MMIPLOPLGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60F54C0", Offset = "0x60F46C0", VA = "0x1860F54C0")]
	public static void LGFMCANMDOK(ENBAAEOIEMA? GKNJGNIHLDH, IJIAPBOEGIK JNAEJBAHENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60F4B80", Offset = "0x60F3D80", VA = "0x1860F4B80")]
	public static void BFJIOLMDBGG(ENBAAEOIEMA? GKNJGNIHLDH, IJIAPBOEGIK NOAKEBJMCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60F50F0", Offset = "0x60F42F0", VA = "0x1860F50F0")]
	public static void KDPGMJDBLBI(KIAHAPDNGMI FPOFNJFNKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KIAHAPDNGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public DAMFCNFGEAE PCJNODKAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public ENBAAEOIEMA KPJGGGPNEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<int, int> MBFLDLGNLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public Dictionary<Guid, Guid> LCLNGHHLCNG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60F4150", Offset = "0x60F3350", VA = "0x1860F4150")]
	public Guid OGPALDGOEIK(Guid OHJPHHKPEGL)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IBHBCPBJNNL
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int NKBIAPBCPPJ, [Out] Guid JPCEAJNGIKP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DJKJHNFKKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly HashSet<string> JMLINOIPAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly Dictionary<long, int> HMLNBOGIGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private readonly HashSet<Guid> CHNOMKHFBPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> EJLFGDLCCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> DGLEMLDHCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60F04F0", Offset = "0x60EF6F0", VA = "0x1860F04F0")]
	public static DJKJHNFKKDA JIEEHMNONBH(KCOMFGNMNDO OMKGFBDCDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60F0480", Offset = "0x60EF680", VA = "0x1860F0480")]
	public static DJKJHNFKKDA HIOGIJGLOOF(JDOFJAAAMEN LNNGKIKDIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60F0560", Offset = "0x60EF760", VA = "0x1860F0560")]
	public static DJKJHNFKKDA KLOHEGNFFKL(IEnumerable<string> JMLINOIPAGL, IDictionary<long, int> ADBEPLELBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60F0920", Offset = "0x60EFB20", VA = "0x1860F0920")]
	private DJKJHNFKKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60F0A40", Offset = "0x60EFC40", VA = "0x1860F0A40")]
	private DJKJHNFKKDA(IEnumerable<string> JMLINOIPAGL, IDictionary<long, int> ADBEPLELBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60F0110", Offset = "0x60EF310", VA = "0x1860F0110")]
	private void BAAMKCMKHJC(KCOMFGNMNDO OMKGFBDCDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60EFF20", Offset = "0x60EF120", VA = "0x1860EFF20")]
	private void BAAMKCMKHJC(JDOFJAAAMEN LNNGKIKDIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60EF690", Offset = "0x60EE890", VA = "0x1860EF690")]
	private void BAAMKCMKHJC(BDJLPIAJMMF? EAMCHADGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60F0310", Offset = "0x60EF510", VA = "0x1860F0310")]
	private void BAAMKCMKHJC(HNHNHHNHOJH? DEBAEMIFHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60EFB30", Offset = "0x60EED30", VA = "0x1860EFB30")]
	private void BAAMKCMKHJC(ENBAAEOIEMA? KPJGGGPNEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60F06E0", Offset = "0x60EF8E0", VA = "0x1860F06E0")]
	private void MINCIFIMGMI(string? JGODIGDGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60F0750", Offset = "0x60EF950", VA = "0x1860F0750")]
	private void PPPKLNGMPKN(CPHIFEJADFG? GBENGGNPEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60F0830", Offset = "0x60EFA30", VA = "0x1860F0830")]
	private void PPPKLNGMPKN(MPHOAPNBMKN? GBENGGNPEGE)
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
