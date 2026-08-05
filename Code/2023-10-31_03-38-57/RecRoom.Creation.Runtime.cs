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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C43DA0", Offset = "0x5C431A0", VA = "0x185C43DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DBDPIGOGDKF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> MMEALOFDIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> LHKAHJPLGCP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C3D930", Offset = "0x5C3CD30", VA = "0x185C3D930")]
	public static bool DGFJFKPLLJM(Guid HPGEGGMJEFK, int FMIONPKAPPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DGCCCFHEMGP]
public enum CMJOPLNBJOP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	COSTUME_DUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	COSTUME_DUMMY_PLUS,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	COSTUME_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	COSTUME_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	COSTUME_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	COUCH,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COUCH_WOOD,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	COUCHCHAIR,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CRASHPAD_EXTRA_THICK,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CRASHPAD_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CRASHPAD_THICK,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CRASHPAD_THIN,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CREATOR_FREEGIFT_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	CURTAIN_NO_TASSELS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CURTAIN_TIED,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	CURTAIN_WAVY,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	D10,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	D10_V2,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	D12,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	D12_V2,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	D20,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	D20_V2,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	D4,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	D4_V2,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	D6,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	D6_V2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	D8,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	D8_V2,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	DART,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	DELAY_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	DEPRECATED_FLAG_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	DEPRECATED_FLAG_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	DEPRECATED_FLAG_RED,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	DEPRECATED_FLAG_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DEPRECATED_HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DEPRECATED_ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	DEPRECATED_SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DESKTOP_AUDIO_SHARING,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	DESKTOP_SHARING_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	DIALOGUEUI,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	DICE_SET,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	DICE_SET_V2,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DIE,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	DINER_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DINER_SIGN_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	DISC_GOLF_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	DISCGOLF_DISC,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	DISCGOLF_GOAL,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	DODGEBALL,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DODGEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OBAKADFALCF
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly Guid EBHINLCDJGG;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly Guid NALHKOBHJDJ;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly Guid PFBCMMDPLBG;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly Guid JOECEFLICJM;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid PBEDGGDFCJK;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid JIFPCDBPIPD;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid ANHGCAGHFGA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid DIGEOEDPMIN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid BLOKALAENIJ;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid CPCKFFCCFBP;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid KPABPGFKEPD;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid IHAGOLMCODJ;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid BKODAPKBNDK;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid KFNEFHFALKC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid ENCALEMNLBP;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid LHBGCEGCEMO;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid JBBABBNJDNP;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid GGLIGGADNMO;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid ODMJMAGDKLP;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid JEKFHKDCEHF;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid ANLLPAEIAIK;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid ILALPPOOJNH;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid DCIDEAJMNFN;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid MINCCMEIPOE;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid JGJLGOMCMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid FKFOMPCKICP;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid JCKGEMMKLPO;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid MDKIPEEADOL;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid LKHKIAJOIKG;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid LBDJBGJBGBP;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid GNIFPEOCMJP;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid MBBAOCKMOFL;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid IDBBNOCCMJH;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid GMMNGEGDMAN;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid JMLOIBJNEKM;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid LGMPMJBEBCB;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid OLAEGHGLKFO;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid PEMLGCHAHKH;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid JBNBDDCJAAI;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid HOAKEBCJGCF;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid LPGPIPBPCMF;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid NNLMAOABHCL;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid HJFEBLKNGAA;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid KHPDHJEPKJG;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid FDJKDEOMEDP;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid KFEDEFIHIFB;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid HEKOMHCGMJM;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid CPKDIJDEPLL;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid DJJNOBCNLJG;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid EONEMIAILCF;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid KCMHJILFMEK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid BNBDJHGKEEC;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid EOKCBLEHEAO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid IAJECLFIMHM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid AKDLKIKDGJF;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid CNKGDMAJDON;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HKCNKDIBCLB;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid CDHHPNEIBPI;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid DOBOJLJDPOG;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid PBGCENDOKEB;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid AKENIIOINGL;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid HAJOCHEKMGP;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid KBJNAFEGHGC;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid COLLKMKDNPL;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid AENNNOOGOMC;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid ELDHIGNHPDC;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid NKPICBHMINL;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid NKFEBHFJBOA;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid LDPFOKEPGFE;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid NHGDBKEFLED;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CNMNGBNECGJ;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PIHIMEGKEJH;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid PCHEFMEKPEF;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid BLCGOKCMHKI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DIHKNIJPMCJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid PAHAKBMEONP;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid BMMEHDNFFBO;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid GBJNHNDAEBP;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid CBBHLJOKLDI;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid EFKAAGCAEFG;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid FIGBAKFFNGJ;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid LKIOFHPLFMA;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid PGPOLHEGEHF;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid AGJGIAHACBC;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid BEJEGPKPANP;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid JHBGNCOBONE;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid FNAGIILAOBF;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid IKFGBMCKOAM;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid LPEJMCKOBIF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid MLACPFFPPEB;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FCBNMJNPACB;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid OJNDKJEOJDP;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid EPFOPABBMPB;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid GMDDFADCENF;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid DDEGHKOICCB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MIPBPJOJMGP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid GLJNLEHLMEE;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid AEOBMKHBEHO;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid DOGEIHCIJEA;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid PFGFGACMBLI;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GPMGBGMGIDC;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid OFHNLAMHCHP;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid CKGGGNPNFMN;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid MGHLDCBAMNJ;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid IFJECFNDBOB;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid CAJEHAABDJC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid FMDGGLFBPEP;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid CLAIFCNAAIB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid EDODPACJGIO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid PKPHOKNLCPO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid OIMODFPGKEA;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid OMJLDDNCHME;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid CBDFAGHJEGD;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid OLBOHKMNBMJ;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid ICBMMBGFIKJ;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid MAIMCGCFJKA;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JLIEGOJFLCO;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid KBLGNAMPBOG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid PMBENBMFECE;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid EKBGEIGALCO;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid NFNGPICJMPB;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid MMPNKONPGDO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid LCNPNMLNNMH;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid PGHGFBMCECI;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid HDFHLEKNDBB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid IDOIBIFOCFM;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid LHKGAKPHCPN;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid LNJJHONMJOF;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid FOPLBJNDGOO;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid GEHDOHDPKEH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid DCKEBKIMCFP;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid GCGANNAELOK;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid GBLEKMABCKB;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid PMICFJEMPKC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid DEMOOPAGLIO;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid PKGOGNEAEII;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid GCPMPLKNPJF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid FKBJGPHOBEH;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid GFHJPGJEOIN;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid NKFBPKFGAIH;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BBDDHHLKBMM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid CGCDPJJBKGM;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid ELMFMCFNKEM;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid IAKJFFADDMP;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid BBOOPAGDPFK;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid ANEEBBJBAKG;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid GNJEGJLJKIN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid DBMMABHFDCN;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid NICLNEHBFNL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DLPJBMIIGGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid LDJOGNDHALK;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid LEJMKNKMDEJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid DBNJNABHOAK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid MMLHAOAJLMC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid DDFAHKLPMKG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid NLOJKJCMFPG;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid MECJLIOKAGL;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid DNCIMBMLPAJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ALBLJPIGGNN;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid JJMDKEDIHDO;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid LAMOFHDPBAM;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid KOLIKHBCOKI;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JLMLAPMNIBG;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OCJPJFJBPCD;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid ONNEKCKDBPC;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HDJPPMPJPIF;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid CLCEPGLPOJJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LHCCCAPCAME;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid DALFONPBOGO;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid JGENNIONGFB;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid NFLINFIKOMJ;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid IIOJHHAOJMP;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid NEPMMEENNMF;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid MDNJEFOIMMG;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid AECPDBAOFDA;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ELPLCKBOHEJ;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid PCFDGHONNLF;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid MKMHKLNOCPE;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid NAPGADKHPED;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid OENJHMHLENE;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid JMGFJEANKLE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid AKIOMHEJHJH;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DNDGGJCHNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid MDPNPDICLOA;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid AIGMIDLPMEM;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid CFLAIFGCPNB;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid BMFGACFONNI;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid GMOPLPPMLDE;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid IHGKJIJOEOJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid GMHIPKOIDHG;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid JDNCLIGJDKB;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid OMEMDEKFEHA;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid KKKDHHMMLGO;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid FGPHHJOPLLE;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid NBMLBDAPMOP;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid HBBBIGOGLBN;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OJDJAIFMANJ;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid HPNCFNDBPFI;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid CKDLPIJGJDL;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid AHCALPAIPGO;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid MPPGEIOGMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid GDKCCANANLA;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid MAPCIIKKFNF;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid JOAENHPLMIM;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid BBHJNGDIPGK;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid IGMLBPIKHKF;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid DFDLHPIIAKB;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid PGFJPAPOHLB;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid ILJAOJGCGNN;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid OHGIMNLHFIE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid GHOMBEPHMIE;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid CFHDNMAIKEP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid KHPBJLFHLJB;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid DICOLADOABI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid OJLKLBJDKBD;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid APADLOJJPNH;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid LLGNHHKEKNN;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LFPPBBMGCAC;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KNLHKELDDFA;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid EEFGFCKCFDP;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid BKGIGNAFBNL;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid PKKBGBGOJAK;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid CLFHIBPLNEP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid PLDAEHPJEJD;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid JBKMGGICOKD;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid HLCIFBBOAFO;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid GJLKOLALMFM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid PAFCCKIEFMC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid JGENDPHLAPG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid OGJHDLLPLLD;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid FOLBIEMGNEE;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid JPMLPFJEKPB;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HEILHIHFAMN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid MMDOMOAAHMH;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid OMJADOOKPEN;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid GGEBBJBMBHE;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid GMPMJFBAOAH;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid DBDAPPOPPID;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MOHGJCGPKEO;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid EOBCPHHEEON;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid JMAAMCCMDCK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid NEJOKNGFFEL;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid JPNDEJGMFEB;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid HJCIBKENCNE;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid FLCAMKEEMJG;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid AMCLHPKFEIN;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid AFJIICLNIEE;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid DFPNKBBMFFA;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid ABKPOPOOBBG;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BNONKGFOHBE;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid DBBDFBHMEPO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid LMEKECDPANJ;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid OPDJKNBAEBA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid AMMNOOJHFIJ;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JHOIACAFKLP;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid DHIGILCFFGP;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid EOBIGJCKEPI;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid NKLBNNJMEHL;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid FHNOIOKJNHD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid KDGBJGFPAIO;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid OJHIEFCNEDB;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid AALKKLBNLPN;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid JBOPBCGIICD;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid ABLKGDCAJCF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid OJONNJCKCFM;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid OLGPBDPPLBJ;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid PABOGIKGFMF;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid KBJPGCIPCCP;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid EDICGPODMCM;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid JNFGDILEPHL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid GDCCAAIIOAC;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid KEGMMPLJFHO;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid JBJCPCFLOKP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid GFEEPMMGHEL;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid GJAOBPINNFK;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid MCGDIMCFEDD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid MOHIIIPPMMD;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid AMJODDGIOAL;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid FHIKLPIMBHO;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid IIBMACKJLNE;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid FIBCELFECFO;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HCDOHEGGDNK;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid EPFBEHJDIMG;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MPBOLBCOILB;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OIMHDADJBFN;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid CGMIBIFOPDI;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FJKHKKCNLNK;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid AJBCPBEIAOE;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NAKLFOEAGEC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PINACIHMLLB;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid LFHMKDNJJHJ;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid GCFOENGJHHA;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid JDGHAKOIAJN;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid BDFDLOFNFHK;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid JOIIJEHMJPM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid PBLCMIHHEDK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid BOPGFELLNDB;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid KBJDHJDGDDI;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid OGFKJGGKIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid LNNFBCNCAML;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FBCIBMMHIKA;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid KEJHCEGLBHG;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid FGHGKNJCEIM;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CPPLIGBKOFD;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid JHDIMMHAAEP;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid EOPHJHBOGPL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid BJCJGPNAGEA;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid LOEIFJPLACI;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid AJEOKLMOHPF;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid MOEICKJLJCJ;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FEDJJLPLHJL;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid OOBFCEFFLOC;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid AKGOELBJNMK;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid COHOGMHMCHK;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid IKGKOEFLNGG;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid MHEAAOPDLOB;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid DCLNMHGDPGP;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid ENPHMJNIABG;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid AHMLJOMJLFM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid MBFPAPLKFLF;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid ICLHDHNHIOI;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid PBBAEDPBKDP;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MKLFBOACCEH;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid GMKKKFNBJDL;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid NEPIKADNJBH;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid PADPPKGMFFB;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid NNHGPOAGHMG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid KNIHCCGOGGE;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid CNBDKHONMLN;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid BBOBAANCDNE;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CFNIGOLEGPI;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GNKAOADFLEF;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid BBOGLHMJLJN;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid FIIGEAOPIML;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid CMBFJKAJPHD;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid MOLLLBOAAGH;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid GFJIOCJKBNH;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid HKIECLPJJHL;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid LOHONPADKMF;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid GLHLIMGAIMO;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid LEHCBMBMOPP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid GJBBGAKNGMH;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid ACNCNLLPILD;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid BDFFMLHEFNM;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid NCKKKKHKFEK;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid KIBKELBOOMG;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid NJFFBNGPECO;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid NLDLNAECNNH;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FOAJLNBABLP;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid NAAOKMFCDGL;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid GDBMFOGPPKG;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid MKHIFABHHCI;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid PGLDLNGCOOH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid NBEMBDKMMJE;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid PGMBCCNGJIN;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid IJPEGFBBIHE;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HCBKEHCJKOJ;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LFPKOOILGMM;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid IIPNLKLNDMC;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid ONBCFMDLEGL;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid EGPAGJNHCFN;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ANJEFPLMCFD;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CBNAHGBHGBB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid EGJAEIJJGAK;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid DJPLKCDBGIB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BFPHCEBFGEM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid GBIOJOBNIGL;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid PCMBODLBNMB;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid EBNMKENHHMD;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid IIMNGBFCCDK;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid PIAFPNMJCDH;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid NKMNLPOEGPN;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid GJHFNPHIMIB;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid KFIDNDLFGIL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid JFFBIBPCNPI;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid ICNNALCFBGF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid GOIPAKLABPA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid EHDELIFELDD;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid ECMPPOLDGGF;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid HIKDLENCDJP;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OALLGBPDPIM;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid IHMBFPKPMID;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid MOEDLJBFPPA;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid BBCGPKHBJEG;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid DKOFHICBJEB;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid JMBCNICMGNP;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid JLHEBCOLFAG;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid NDCLEMPIPBO;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid HOJLIKHDBEF;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid BJLHCHBPOKK;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid JIKMDJAGBHM;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid KCHNODEPHBG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid FAEKGIGJOBD;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GBFIPGMCFHB;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid NMGEICIDOAP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid PLGDEJOMHDO;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid JABHMOLJLJB;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid FIHCKFPLDFE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid IINCNBBIIJD;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid BKILAOJHCLC;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid MOFCEBOGIBM;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid CIFCBEHKPNN;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid JKJFLEDGNOA;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid NGFLJHFDBMF;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid FJICLGFLLLK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid BEEAJOHAPAA;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid DPDOGAIJAHL;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EPIDBCNLHPF;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid JDADIBKLENG;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid CPBLONLHDKH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IGKLEONCNFI;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid MDGPABKGLNO;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid LOIBMCHIIHN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid NMPELNJGLGH;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid JKOCJDGPHGA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid IEDBKACKHCG;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid AGJFMCHFCMK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid LDEPFEENHOK;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid CDDBOLECFAD;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid IONLCANBBIB;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid CGJPDECILLI;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid EHGGGFMPJLD;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid EKFPFHJJJMB;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid MNKOPMNOLII;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid LACAOIBBOLM;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid BOHCHGCCHDG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid OJMOGJILJDG;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PHOHNFLAJLE;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid LJIOHMOOFDE;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid AMCFDFJKEJM;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HKEOHONIDHF;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid OJLAHPIFFKK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid JHJIKINIJNN;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PNIIJFGEGOB;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid FCPHNPOLLAL;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid HCLKJBICCIP;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid ODDPHHAOJKO;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid NNOIHEIMINO;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid IFFNONCILCP;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid PAEBKPBAPPN;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid KHOGHALLNNK;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid HDFGONFEMMF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid CGFMHFEMALI;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid OCKOFLAIKGF;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid JBLFAGFLGEM;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid CIDOPOFDPEC;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid GCOHEGAKFGI;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid EHIIKDBFAHD;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FCIDLABDGOM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid OGMFDJIGOIE;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid BPMNHCIBEIG;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid EAPLIALNNEI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid LDBAGLBDLHP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid MCGCJBEPCFO;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid KNNJPOHGOKE;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid ODBJDIDNAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid MGKADJGPDJE;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid NAKMJKDICAC;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid CDOEKDPAJFI;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid IDGBCDBACHF;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid JKDGKIKHFHM;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid IDPCAHJEEEK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid ACBAFJGDCNO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid AGEELHPFNBH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid ONLFCNABCNE;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid KFNMAPOOPAO;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid LAIENBGFEED;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid HPFGNGAJMLG;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid FIHAIDCKBOL;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HECOCMFDPKK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid LFKBNBOHCKF;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid HIJNDMAEJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid NGDJEKFIACI;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid KMELPEDPHGP;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid AIOJALKKEDC;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid BNCKHIBKDLO;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid HPPAMKFCEEH;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid OLNEOONOOCJ;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MLEFAJJFMAF;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid JJDNLNMNGMD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid PCJNFPEMLNC;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid OCPKPOBGNGI;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid AJPKAEBGHOB;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid HKAMKLHAPOL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid LLLHCPNAMEM;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid FHLMHLOOMJH;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid MMGFJBIGJAB;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid GDGKKEJHMJM;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid ONCBJDNJIDO;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid OHBMHOGKHNN;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid OOKKEIBGAKC;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid NPICJFLGAPG;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid BKDPINPDHEI;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid CKBLNMLEFGH;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid BPJIOCJCCEK;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid DLFAOKDIHMF;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid PJMDAJFANGK;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid NIKAOCPLMJH;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid GGMAIAOCKON;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid HKEMCCIJJHL;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid NBJMAOMHELO;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid BBHMLMJAKHH;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid JOPELJHGEDH;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid ACANNMENCIC;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LAALDNEOONJ;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid PHMIJCMIEJN;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid IDJKKPJIFNC;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid LDOILBLAELA;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid GPGIFKMJHAF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid AMHBJCNNHJD;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid HHAFAJCEOHO;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid CPBIGDHAFKK;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid NKEFCOJAHNI;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid MHKPMMDIACJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid OALMPCMINMC;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid PCLJCNIJFMO;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid GIDAHCLIHKI;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid KHOOKBPENCO;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid OMOOGDBACAJ;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid NKLMCDLFNBH;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid LIKFOPGJGKL;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid PCLHDCKIAFD;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid FIKCNOOMNJO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HOOMBFMPCOC;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid GMMLCPKOAEO;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid PBBNMBAFJFO;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid EDKHGPFKAMK;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid HCGNKONPCND;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid AEFCBELIKJG;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BIGALNGFHHH;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid KHBLFAHNFNI;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid GLEMCLDIJNF;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid FJLAHIKEDPP;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BOCPFELMNHH;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid PCLMKBIPPNK;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid FPPFEJBBOFK;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid IBKBFBFKFKI;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid PKFKNNIFPPA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LDKMIPAMNNK;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CEAGMFADEFB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid EDEGBEPKJLF;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid MKOENNJMKAN;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DJJIBICLLMP;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid IMEAIAAICFA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid MHCOACNCHCM;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid CCNEDKMPKHI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MIMCGHMMJGO;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MBAOCCDIPFF;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid GBFDOBEAEAL;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid ECFMAMDBJCO;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid HAPBCOFAAEP;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MHEEFMEHNPG;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid PFNEKHJLDEN;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid PMCJKIMMHPF;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid GNLDKOFPJPO;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid HLCOMIJEDJI;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid IFEPDCJNFCK;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid FIMOOBPBOME;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HDNJKPBAEIM;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid DJCMLONNPII;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid GLPBPGGJAHK;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid CKFMIAFGECG;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid PBFIIHHAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid JPHALOOAGGP;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid LKKLMLGMFFM;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MAINMOJNNHB;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid EGGNDCOBOJP;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid JAPEMPHALAG;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid FJOOJFOEMII;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid IFGFPAAMBBF;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid GDEBHHPFIOO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CGAEMGBEDLG;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid BACAKLEAODL;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid IBMLOLPHCLD;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid NIPGKIHKEGN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid KCOKDOJEJLI;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid PGNCOPCKNCO;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid PKIGHLIOGGN;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid KKLOCDMHNCC;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid MHNDFNJONKB;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid HHOEDHOJANF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid OEJDACMNNEN;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid FJDAIFHLMON;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private static readonly Dictionary<Guid, CMJOPLNBJOP> GKLIGHLJGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private static readonly Dictionary<CMJOPLNBJOP, Guid> FJPEDFDBCEO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, CMJOPLNBJOP> EBFLEPEMIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C43E80", Offset = "0x5C43280", VA = "0x185C43E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<CMJOPLNBJOP, Guid> DKAKBEGNENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C43E20", Offset = "0x5C43220", VA = "0x185C43E20")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KJOIBJOCMDC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C42290", Offset = "0x5C41690", VA = "0x185C42290")]
	public static bool DLPDNIOFPLO(GCPLFPLHHMP JCDBHBGOAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C41EE0", Offset = "0x5C412E0", VA = "0x185C41EE0")]
	private static bool DLPDNIOFPLO(APDCHHNPOLC KPELGHNGAAC, GCPLFPLHHMP JCDBHBGOAKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JGMDOBABCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public readonly NIJMJENDHMF LJMLCHKKNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public readonly IEnumerable<OKANLINDLJD> AJIIJKJDLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public readonly IReadOnlyList<OKANLINDLJD> BPBMCDEOLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public readonly IReadOnlyList<OIEFBDBCDBO<KPBMEJJGDHM>> DBOKANLIHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public readonly ByteString GAMHMNENGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public readonly HDLJICFGKCP DGINENKADGP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C41C40", Offset = "0x5C41040", VA = "0x185C41C40")]
	public JGMDOBABCKE(NIJMJENDHMF AAHMPKOCHNG, IEnumerable<OKANLINDLJD> NJLEGKPDGEP, IReadOnlyList<OKANLINDLJD> HAJFBOPNEHP, IReadOnlyList<OIEFBDBCDBO<KPBMEJJGDHM>> FHBFPDIPBMJ, ByteString IIMFOPGDKPK, HDLJICFGKCP GEDDKCHPIBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJLIOMNCAPM
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(FJKDGIECGLM GHFAAPNAFDE, [Out] Dictionary<int, int> LGEHNICEHEN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(HFIJIDAMADJ FKLHHALNBIB, NEGMFOFPIEE COMEFDGABLK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ICFGFEMBBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public readonly Guid KGGGDOKBCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private readonly Dictionary<Guid, Guid> LEIDFKNKMBP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> LEJPHCMILMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31765C0", Offset = "0x31759C0", VA = "0x1831765C0")]
	private ICFGFEMBBOF([In] Guid BIKPFEEBEBH, Dictionary<Guid, Guid> LDGAPNHENCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C41650", Offset = "0x5C40A50", VA = "0x185C41650")]
	public static ICFGFEMBBOF DFOAAKNMFKL(IReadOnlyDictionary<Guid, Guid> LGFLKHMOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C41820", Offset = "0x5C40C20", VA = "0x185C41820")]
	public static ICFGFEMBBOF FIMKPPEJHDK(IEnumerable<KeyValuePair<Guid, Guid>> LGFLKHMOEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C41770", Offset = "0x5C40B70", VA = "0x185C41770")]
	private static Dictionary<Guid, Guid> FIIDIPJPPNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C41660", Offset = "0x5C40A60", VA = "0x185C41660")]
	public Guid EDHDCECNBEG([In] Guid OGGNLGCIGBJ, bool OIMMENBDHBN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C41BD0", Offset = "0x5C40FD0", VA = "0x185C41BD0")]
	public bool KKEJPAOIHIB([In] Guid PIKCMFPLBNL, [Out] Guid LGHKIJLLGKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIDCAGPPFOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONLENKPGCBM(ByteString EGFEGIMIICO, ICFGFEMBBOF COPCBEEKKEN, [In] EKDOHGHOOFO OCAIIBKIACE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OIIOIHAKLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IACNENELADC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> MGJIPDPPKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> DHIPDKMJOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x76B3A0", Offset = "0x76A7A0", VA = "0x18076B3A0")]
	public IACNENELADC(IReadOnlyDictionary<Guid, Guid> JHAKGEEBEAM, IReadOnlyDictionary<Guid, Guid> KHGHLGCDLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FENDCAOPFJB
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C3E250", Offset = "0x5C3D650", VA = "0x185C3E250")]
	public static FNBBFCBBBEO AIGHJBAGKCO([In] JGMDOBABCKE MGCJPKOPNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C3FBD0", Offset = "0x5C3EFD0", VA = "0x185C3FBD0")]
	private static void IEDICKKINLO(FNBBFCBBBEO EELPBPDLKNI, [In] JGMDOBABCKE JDAMDICBLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C3E650", Offset = "0x5C3DA50", VA = "0x185C3E650")]
	public static bool GHKLFPJLKED(FNBBFCBBBEO EELPBPDLKNI, AHNEBFBCAHF PLKPJOBOMDB, [Out] IACNENELADC? LDGAPNHENCC, [Out] string? GHNPOMJGELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C3F940", Offset = "0x5C3ED40", VA = "0x185C3F940")]
	private static void HOBKALNHBBC(FNBBFCBBBEO EELPBPDLKNI, ICFGFEMBBOF? IFHPDALFBDB, AHNEBFBCAHF PLKPJOBOMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C406E0", Offset = "0x5C3FAE0", VA = "0x185C406E0")]
	private static void MJBJEPENJBD(FNBBFCBBBEO EELPBPDLKNI, AHNEBFBCAHF PLKPJOBOMDB, IReadOnlyCollection<ByteString>? CPNKKBHGMLG, IReadOnlyCollection<ByteString>? OEGGGMEJDGB, IReadOnlyCollection<ByteString>? IBFACCOGJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C40750", Offset = "0x5C3FB50", VA = "0x185C40750")]
	private static bool MJCIFPBACKJ(FNBBFCBBBEO EELPBPDLKNI, HFIJIDAMADJ FKLHHALNBIB, AHNEBFBCAHF PLKPJOBOMDB, [Out] string GHNPOMJGELJ, [Out] Dictionary<int, int> LGEHNICEHEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C40DF0", Offset = "0x5C401F0", VA = "0x185C40DF0")]
	private static Dictionary<Guid, APDCHHNPOLC> NLLOOIGCNIH(FNBBFCBBBEO EELPBPDLKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C410D0", Offset = "0x5C404D0", VA = "0x185C410D0")]
	private static void PHAEMECNJKN(bool HCKANGNGGLP, OKANLINDLJD CDDHPNGCCBG, Dictionary<Guid, Guid> PABIFALNAPF, ICFGFEMBBOF FHHAOMMMHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C3E3C0", Offset = "0x5C3D7C0", VA = "0x185C3E3C0")]
	private static void CLLCNEHAPOL(OKANLINDLJD CDDHPNGCCBG, Guid DBEDBKOFLEA, ADNDHDLJNLK? GNKBKAPOKDC, Dictionary<Guid, APDCHHNPOLC> NAIMJKFGNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C40230", Offset = "0x5C3F630", VA = "0x185C40230")]
	private static void LNAKDFAHPKL(IEnumerable<OKANLINDLJD> NADDOPMIPKH, IReadOnlyCollection<ByteString> CPNKKBHGMLG, IReadOnlyCollection<ByteString> OEGGGMEJDGB, IReadOnlyCollection<ByteString> IBFACCOGJEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AHNEBFBCAHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public bool HCKANGNGGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public HDLJICFGKCP GEDDKCHPIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public ADNDHDLJNLK? GNKBKAPOKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public ADNDHDLJNLK? AMHJHLHDBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public NIJMJENDHMF EDMMNKMLGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public OIIOIHAKLBI ONKMHMOBNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public BJLIOMNCAPM JBLDEMMBPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public KIDCAGPPFOJ PMJINDNNNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public OIEFBDBCDBO<FAPHLEEOOKF> JOOLIGMDONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public BNHHLKNAFIA FIMHLHGGEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public List<OKANLINDLJD> PKICGOLFEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public Dictionary<string, object> AFGJGJEBIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public CJBPNDIPCIL IBHJBDFOALA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FGONPOMMMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C3BD80", Offset = "0x5C3B180", VA = "0x185C3BD80")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ADNDHDLJNLK
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private const float PMBBHLLAPHA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public Vector3 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public Quaternion KBKHJHIFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public float NMGPAHAPPCF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 ANFMDAOLHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C3B910", Offset = "0x5C3AD10", VA = "0x185C3B910")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EKDOHGHOOFO KEGIKIAMIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C3BC40", Offset = "0x5C3B040", VA = "0x185C3BC40")]
		get
		{
			return default(EKDOHGHOOFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x870040", Offset = "0x86F440", VA = "0x180870040")]
	public ADNDHDLJNLK(Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NMGPAHAPPCF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C3B510", Offset = "0x5C3A910", VA = "0x185C3B510")]
	public static ADNDHDLJNLK AIBBLOPCGEE(ADNDHDLJNLK EBFCMPBKGBM, ADNDHDLJNLK APPCHMIFJDN)
	{
		return default(ADNDHDLJNLK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5C3B790", Offset = "0x5C3AB90", VA = "0x185C3B790")]
	public static ADNDHDLJNLK BNPEICKPPJA((Vector3, Quaternion, float) GHFAAPNAFDE)
	{
		return default(ADNDHDLJNLK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C3B7B0", Offset = "0x5C3ABB0", VA = "0x185C3B7B0")]
	public static ADNDHDLJNLK BNPEICKPPJA(Matrix4x4 IADDOCEOKGB)
	{
		return default(ADNDHDLJNLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5C3BA20", Offset = "0x5C3AE20", VA = "0x185C3BA20")]
	public ADNDHDLJNLK GDBGFLCOGAI(Matrix4x4 OLPLDGDFGHL)
	{
		return default(ADNDHDLJNLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5C3BD10", Offset = "0x5C3B110", VA = "0x185C3BD10")]
	public static ADNDHDLJNLK NJEBKOKBFLA(Vector3 LPAPEIIOLFG)
	{
		return default(ADNDHDLJNLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5C3BC80", Offset = "0x5C3B080", VA = "0x185C3BC80")]
	public readonly PECOGIDPBDO KMOKKAECKJN()
	{
		return default(PECOGIDPBDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HDLEGCMFGCH
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5C41310", Offset = "0x5C40710", VA = "0x185C41310")]
	public static ADNDHDLJNLK HODJPADNOMM([In] this PECOGIDPBDO LDMHFMNLDHG)
	{
		return default(ADNDHDLJNLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CEJICOAJIFG : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C3C780", Offset = "0x5C3BB80", VA = "0x185C3C780", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C3C1A0", Offset = "0x5C3B5A0", VA = "0x185C3C1A0")]
	private void COHMBEAKNHJ(Dictionary<Guid, Guid> MAHJMPDPAJD, CCNMKDLNBEM AIPNHICCMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C3C140", Offset = "0x5C3B540", VA = "0x185C3C140")]
	private void COHMBEAKNHJ(Dictionary<Guid, Guid> MAHJMPDPAJD, OBEFDLKJNII NCMCOGBJLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C3BEC0", Offset = "0x5C3B2C0", VA = "0x185C3BEC0")]
	private void COHMBEAKNHJ(Dictionary<Guid, Guid> MAHJMPDPAJD, MNCPJJEEMFN OFFGMJHABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CEJICOAJIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class DGMNPJNBEBH : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C3E1B0", Offset = "0x5C3D5B0", VA = "0x185C3E1B0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public DGMNPJNBEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HPKBOGLJMLG : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5C413A0", Offset = "0x5C407A0", VA = "0x185C413A0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HPKBOGLJMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class IAHFOCJAOKO : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5C41500", Offset = "0x5C40900", VA = "0x185C41500", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IAHFOCJAOKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JMPPKHJGEKI : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5C41CC0", Offset = "0x5C410C0", VA = "0x185C41CC0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JMPPKHJGEKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class MJPBPGJHADC : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5C43AA0", Offset = "0x5C42EA0", VA = "0x185C43AA0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MJPBPGJHADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class CPEBHIKLGMG : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5C3D790", Offset = "0x5C3CB90", VA = "0x185C3D790", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CPEBHIKLGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class ALJKLODNDNG : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5C3BDD0", Offset = "0x5C3B1D0", VA = "0x185C3BDD0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ALJKLODNDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MGIHDNJOAFK : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5C438E0", Offset = "0x5C42CE0", VA = "0x185C438E0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MGIHDNJOAFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class NDDMBGNNHBJ : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5C43BE0", Offset = "0x5C42FE0", VA = "0x185C43BE0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NDDMBGNNHBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class FJKJFFJNHDI : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5C41160", Offset = "0x5C40560", VA = "0x185C41160", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FJKJFFJNHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KMNDDDOEJHI : DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly System.Random BCFJBEABGOE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5C422C0", Offset = "0x5C416C0", VA = "0x185C422C0", Slot = "4")]
	public void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KMNDDDOEJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GCPLFPLHHMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public HFIJIDAMADJ FOIKACEEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public ODEFEMDFADD KNCGNPEHNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<int, int> PDGNMGMJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Dictionary<Guid, Guid> ANKPPIGPMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public CJBPNDIPCIL IBHJBDFOALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public bool EBNNBMFMGJK;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DAMJBFNNOGB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDOFPKDFLJM(HCBIDGGFGEC HIPGLCHANCO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class COEDPPMJMBM
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private static readonly DAMJBFNNOGB[] HGDKJJMCCHB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C3C800", Offset = "0x5C3BC00", VA = "0x185C3C800")]
	public static void APHBCCBGOCG(OKANLINDLJD GHFAAPNAFDE, Dictionary<Guid, Guid> GMGKJNOMMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5C3CE60", Offset = "0x5C3C260", VA = "0x185C3CE60")]
	public static void IDEIDPLFKOG(OKANLINDLJD? GHFAAPNAFDE, ICFGFEMBBOF FHHAOMMMHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5C3CA90", Offset = "0x5C3BE90", VA = "0x185C3CA90")]
	public static void DLPDNIOFPLO(HCBIDGGFGEC HIPGLCHANCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HCBIDGGFGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public HFIJIDAMADJ PFAHEBGKLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public OKANLINDLJD CDDHPNGCCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<int, int> PDGNMGMJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public Dictionary<Guid, Guid> ANKPPIGPMGA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5C41260", Offset = "0x5C40660", VA = "0x185C41260")]
	public Guid GGEGGBNGJHP(Guid OGGNLGCIGBJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CJBPNDIPCIL
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BEFNCFIJHAJ, [Out] Guid CINONHEMCBD);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LHOLDBBHPND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private readonly HashSet<string> FPJBIJEBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private readonly Dictionary<long, int> OMHOBKGBAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly HashSet<Guid> MBGKGLELBKN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> LOBDODNIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> NAHCFJFKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5C43420", Offset = "0x5C42820", VA = "0x185C43420")]
	public static LHOLDBBHPND IIFMHCALHFC(PPLFDHIJECO GBMIBBELHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5C43610", Offset = "0x5C42A10", VA = "0x185C43610")]
	public static LHOLDBBHPND OAECLJCNBGI(FNBBFCBBBEO KAMBPENKIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5C43490", Offset = "0x5C42890", VA = "0x185C43490")]
	public static LHOLDBBHPND JGBMLPJOFCB(IEnumerable<string> FPJBIJEBDCI, IDictionary<long, int> IMOMKBCPPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5C437C0", Offset = "0x5C42BC0", VA = "0x185C437C0")]
	private LHOLDBBHPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5C43680", Offset = "0x5C42A80", VA = "0x185C43680")]
	private LHOLDBBHPND(IEnumerable<string> FPJBIJEBDCI, IDictionary<long, int> IMOMKBCPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C43050", Offset = "0x5C42450", VA = "0x185C43050")]
	private void FOBLJMJAPPD(PPLFDHIJECO GBMIBBELHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5C42460", Offset = "0x5C41860", VA = "0x185C42460")]
	private void FOBLJMJAPPD(FNBBFCBBBEO KAMBPENKIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C42BB0", Offset = "0x5C41FB0", VA = "0x185C42BB0")]
	private void FOBLJMJAPPD(JEJHMNFKPNO? OGEFIHKILIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5C42A40", Offset = "0x5C41E40", VA = "0x185C42A40")]
	private void FOBLJMJAPPD(CGAIJCBPKPB? OMFNHGCDBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5C42650", Offset = "0x5C41A50", VA = "0x185C42650")]
	private void FOBLJMJAPPD(OKANLINDLJD? CDDHPNGCCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5C423F0", Offset = "0x5C417F0", VA = "0x185C423F0")]
	private void BALHCAANHIF(string? PJPGCKEEFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5C43250", Offset = "0x5C42650", VA = "0x185C43250")]
	private void GPLNJPGAGOP(LFKMOMNKOOB? LDHOHJBBHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5C43330", Offset = "0x5C42730", VA = "0x185C43330")]
	private void GPLNJPGAGOP(IJNBLEIDIKM? LDHOHJBBHDF)
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
