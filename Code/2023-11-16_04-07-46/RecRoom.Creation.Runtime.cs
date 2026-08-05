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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB4E20", Offset = "0x5DB3E20", VA = "0x185DB4E20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PKEMKOLBKCF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> CCAGMHHOLHA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> GFAJGKFJDOL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string AOPDJGGKMEH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string LIJHMMBDFLF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string KGGBBIHOPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5AF0", Offset = "0x5DB4AF0", VA = "0x185DB5AF0")]
	public static bool CLDEGCPBIHF(Guid NLGEGKJAILC, int LBKPKCCEMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5BF0", Offset = "0x5DB4BF0", VA = "0x185DB5BF0")]
	public static string OPHICODCEBK(Guid BCPPFHNPEMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CDGAMGBIKNI]
public enum DAEJBFPJELB
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
public static class EMAJANNPFAK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Guid KANHOHKNOIM;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid HEPHIOHOJNL;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid AOONPMKMGBA;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid CJLMPCJAMGL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid GDLGFFFFIFM;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid PECEKLDBGBE;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid FCDMCLEHOOI;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid BAAOCMGBGPC;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid JMEIACJHFAF;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid ICFAHIGCBJK;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid GGHBIMPILJM;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid OHEABKGFEJB;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid AJPMNELMKEJ;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid JBFCDNAHMAD;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid KJOELIDODJH;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid FCBDMHCCOGL;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid MJKNDOCGDOG;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid KGHOPPJKPFP;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid IAKANDKBOOF;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid FDIKDKNPDDP;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid IANDDPIKNPN;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid PBDAEPFDBJC;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid EOHJBFHJPIM;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid HFPCHJAABML;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid PAHOLMFELMG;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid CDNCPLKGHPD;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid MONHIIMJBCM;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid HDKCEAKFIKO;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid KCKMPLNHNGF;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid EOLOBHLOJKK;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid KKNOCCPNGFC;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid CLIOMLKNNCO;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid DILFLGEGPEH;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid KABCKPDKFIF;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid NMKEEPEGCMF;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid KEJEIPDDODG;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid MNHJMMNHOLG;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid NPADGHMIJED;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid HPAOPBNDBPC;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid JDLBDGANNFB;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid GJCNDPIAKML;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid JMJBNIIKBMP;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid KHGEPHHPGDD;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid PAOFPALKIHH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid LGOAHCIHJPA;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid AAMNHAAAJPD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DDGLPPKPELM;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid HJKEPMMDNCL;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid DDPFPJOJKGC;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid EEAMHOBMHKI;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid IAKPEGKIHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid CEJILGMNGJA;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid HJBBMOFIGBL;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid EGDIFAPCPEC;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid IHDLKPLAOCM;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid KDBDPPBLNDF;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid IDNANPIHLGP;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid FGEEOGGDNMK;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid DGIHKHKMECE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid HHMGDBKEDOC;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid IMILJKLINFB;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid IKHHHFCNMNE;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid NJCGGJEOGOM;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid BJKHEGDIFGM;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MOFPFMEBPEE;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid KJDKHHIMAAF;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid HAMJIONJIOK;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid PNHJBLBPBPO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid GDMHABOFHIL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid POGHECJLLKK;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid FJMLDEBOANA;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid CFIOOJMFMDE;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid FHBABMBMCIJ;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid DMEANEGHHIL;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid DAMHOPEOBKN;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid CINAHPGEKOH;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid FGDPHMOFKEK;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid NBBEEFNCNOE;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid ANJDABCFJIF;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CKPFPKDEBHD;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid LBGHCFGBCEK;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid CFOKFOFLHME;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid GLIEILILOBE;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid OJNJIPINGLM;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid GMDGCDHHNJD;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid JKEJOJHJDON;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid PLKJJJDNJBN;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GGLGPPNPHLJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid PBPBAIBGGKG;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid FPEEFBAABEK;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid JCPNAKGLGFB;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid GGMBEELLAAH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid FMICBILFIJC;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid BGDHAHHJCPL;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JJPANGBJJOK;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid LNAJMHCOFDF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CEOIBOFFDMA;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LHHMLPFCJFJ;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid FBCOKGKPHDB;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NBAMKOICIFC;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid HMOKKLGCNBN;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DMGCGIJEJEL;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MHEONKHDPFB;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid JMFGKJLKPBJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LDLLCAABBFB;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FKPIMKCMKDG;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid CFODKOMFLKG;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid NIAEBENICHH;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid MKGEJPNPMBL;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid DBGMDGNEKEA;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid DFCMHPGIOMD;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid EAJHMBPHKCN;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NIEFHPIDJEE;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid MHONJPCAIJB;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid MMHKNLHLEFL;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid PCJHJDPPNEM;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid HPEAHBBKEJD;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid LDCCBFNCILL;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid AEIFHEJFOOI;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid EOGKINOECDB;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid IMCFLMOJADC;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid NANHJKDGFKH;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid CMBILCBBHHA;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid INPAFBAOOLJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid CGJGGBNBGKB;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid MECIJFKJMGB;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid EEHBCLBCNFL;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid FICOLMNPCML;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid FFLGPEALIND;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid GOHOLGFBDFJ;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid BPNIBDGCFOP;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid IMFAAIHGGGJ;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid NJGBJLGEKFF;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid MMBJEPLJFCM;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid KIPKBNGPCHC;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid GNMFDINFNOO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid BJJDNJJPFLP;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BPCJHJKMFAF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid DNFOGEBLHHM;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid MJNHNAKMHFJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JKNMKILGNGO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid MCCLIJKDHGM;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid FCBBKBKJKEB;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid IPJKHBMMPAB;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid DBEBMOENMNK;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid BMDBIMODLAM;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid HDPEFAKDHJO;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid HABMFJCODDJ;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid JCIIBIIBKHO;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid FDDKAJFHAHE;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OPBKOPOOCOP;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid PNFJDDMGICA;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid DFMNEDFGPPD;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid FJHHEHHBFKC;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid OEEPGIICMON;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid GODGJMFOILI;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid NOOOOEMPCOF;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid AGCJKHLFCKH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid IILKIEPNNDJ;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid CIFCIAOHNHG;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid IEHKHDJDNLL;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid NKBLIOOCNMD;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid CLAOBADMDOD;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CBDFBPOGMKN;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid PBKDNCBFJDK;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid FKANPNAHAOH;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid BABMNLCFOOA;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid GLGBBBDBPJG;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid DILDGBMNOOB;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid BIHOAKGIOHM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid DFJLMOKLJED;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid JGEAGOKBAIB;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid ACDGIEOCDMJ;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid MIBOOJBFHPP;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid JLAONCIOFJD;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MBKKOLKJFII;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid ONOMKPJMDFM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid MILBOHGOFPI;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid EMNLIPGLFCF;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid KNNPMANFAOP;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid EBFNPIFDOFK;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid PAPKCMCEJLF;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid AGCGOLKLAFC;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid JPELIGMNJOA;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid FGEANOGHLJD;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid ILKJDCBDNOJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid BLJFNLOBNNM;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid CDFKOADGIPN;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid GEHDLAKOFBA;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid MHKAMHLDMKG;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid ACJONCKNIAH;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid OPIKJHCPOPN;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid LJCDAPOLLLI;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid LMILPNOEDGO;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid KDFNNDJMPLP;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid GEFHLBCLDEE;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid DBAALFBIOOD;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid HAFEKHJLPLB;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid ALDODABIHAB;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid CBLBNGJCMPI;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid MMNGMIBCHJM;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid OGIDOPIHGKB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid EJEHPDCMAGE;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid NPCPFKMAPGK;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid EEHGCKJFOPG;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid ILBOFGEAHHF;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid EGEJDCBMJOL;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid JGEOBHDMLNO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid HLCDBAMBAEF;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid IKFINKBKJLB;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid MPNEDLABHJA;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid KEPOFGONEHC;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid MKDHJMGKEBL;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid KBOBHFMFKAM;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid HFDNGEHBNDP;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid INJPEHDCNKP;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid CBDGBAIJELE;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid IKAGIDIMJBN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NHDJMMCCLOK;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid KDBOIGBIFDK;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid COFAILHKGFG;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid BCKMEMJKFDC;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid ECAJHBMPLJF;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid ICPFHNHDEMM;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IOHPJMLFBKI;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid CBILGKLOFOG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid BMGJCLFGKBI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid KMEIPKCBDCE;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid LADPPJDIANN;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid NAHONKIKBNP;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FJJLGNOEKIF;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid ONKCBCBHJCG;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid JIIMMMBEMOO;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid OKIDLMANPHG;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid FFICFJJIBDC;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid MOOJJNHAGMO;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid PFMFHMBLFFO;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid LPBPHOFCHHF;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid FGDHFCIDMOC;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KIBOKHAAELJ;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MBDCIHHEGJN;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid HPIEOIPFDAC;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid LIMIILCAKFD;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid CFAJMJDEALJ;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid MAEDCNPMBGD;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid LDOHDFIEBLI;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid PDLBCOAEDKL;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid JFFKEPCNNMM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid DFFMNACEPHA;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid EHCDFEMBGFM;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid DGALJLEKMDB;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid EKMHBEGJPKJ;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid GEOCIPJFFAG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid MHJBBGBEBCJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid LMCDGFKIJND;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid MKKCHBGJAIP;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid GIMKDEKJBHH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid KHKHBEIMJCG;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CICAMIHOAEC;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid NNMONLLCLKF;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid CGAAGCNKGMH;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid KIPJFEJJOKP;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid KOCIMBIGHDA;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PFMGNMDMIDI;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid CPILEPAODKG;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid JBBIJAKOAGF;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid CMGIEAMKLMA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid LMBHBGIKKHH;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid KOBAPAOKFAO;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid NAJMNKKPLFG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid NPMFEFJEFDA;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid OGDKFAOCGGE;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid KIECIMDGEIA;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid HPKBPOLDOCD;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MCPFOJFDBBM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid INFKGJNBIKO;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid MGBOBIHHNBB;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid HKNHBLPBHHF;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid EALODAMJMEH;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid PAOMLLIKAKA;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid CGKPKLJOFPC;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid KMFMPIJPIGM;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid MCJCCLDPPLB;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid PLIGFGHCPGC;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid EJHPFAHDPEI;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid GEKGBOPBKHH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid CCMDMBENHBI;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid NBILCHFBMJG;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid CINGFEKJGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid APAHGMPMHNE;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KEKDLPHHAHM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid CJNMENBAMNM;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid CCIDKJPIDGD;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid LKFPANOBNKE;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid KBCENNCHPCA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid CIDDBAPBJGH;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid FKEPFFIEICH;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid FAKKMIEJAOL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid DHKDEAIELFO;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid CAEANKNOBFI;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid GIPDJJHJGHH;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid IKFADCPMDBE;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid KOFLCJBMCMO;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid FELOAINEHIM;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid KIAJDHNJFJA;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid IOLELGGCMKC;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MGLLBJKGOCA;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid OJMEAPCDLDE;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid NCPNMKHMNOO;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid BAHFIGLBBGO;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid HNIONHOLBCH;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid HADFALEDNMN;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GGJEBDKLMKO;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid AHLCGCFILBJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid JNJLFMGHCJC;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid FHHLKMDOJKG;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid KHINHCLIGFE;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GKOFNPGLGAM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid JCDDBHDFMCE;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid HCDJHEABELI;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid FJJKDACNAKB;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid ALBHBCABNIB;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid FDKFEOOBPKA;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid HCDNAENKODE;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LJPALKAIFBL;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid GJEJJMIIKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid JKLACDOOCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid DPIIKANMKCE;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid CFEDKHACDEN;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HIPCEMFJDAB;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid ODNAIDCDJKL;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid LCDPCGMIFEL;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid LIIPNIJKBCN;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid FCKGMAIEIAP;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid IBBBBPELBFH;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid OIFHKEGAGIB;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid MBFFHJJFJIH;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid IFMNNBEMNBO;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid ALGDFIFFJOB;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LFIJOPEHEAO;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid DNDOPBAFLOJ;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid EMBMBKODNHE;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GIBBPNPMJLF;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid DFFMOJDMIPC;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid DMJJANINMKI;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid GHNGFNDKMBD;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid FEKNHJEEKOF;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid NONLMEKCKDL;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid GIGMOHEFALN;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid LMAGDBNKNHN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid FJMJKGANIMJ;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid CLFMMBBKHIN;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid MICDIGNFAOB;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KOEICLBADGG;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid KADEDCGIAEL;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid KNLKEPBFDMK;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid GDPBCJBNMDO;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid JJCEKKGLNFF;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid OJBBFBBANCF;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid ACICHHBIFMO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid COBOBNDFNJH;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid PCLJBNKFPJD;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid DHGOELLBGEH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid LAHNDJDFOOG;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid GGNJAIBDOFM;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid OKKAMEIAPIL;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid CJMCPLJMKDK;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid MAFCPKFKNCA;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BDAOEFHILBL;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid CFIJHECFHBL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KOFEKHPILKL;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid MFEOBBGNGCK;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid ALGLILADJOP;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid MJGBFGKAPCO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid NEGKKPMONDH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid PEBLPCGKJJI;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid FBKNHLGEEGN;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid BEIDGGPILAB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid KMCHHCBIKBJ;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ECDPKCOLACL;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid GBNHFMJCLOO;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid HEPHADFCHGJ;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid ICLGIJIFBFP;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid KLLKBMKGCPI;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KKOLOKFFJPG;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid MODNDKNPAGI;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid KHOMPIHKMBI;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid ALOPPPNHNGG;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid JABPFDPCOGO;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid BJAOFLDKHDL;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid ENKJPGFPCCD;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid GJKCBNJJJDD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid OMMPAGIJODD;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid LIOMBJDAGBJ;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid OCDDLLMGMNJ;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid IEJAGEHOJHH;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid GFGIPKFCNCI;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid FAKLPBNAMHI;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KMJMNDFJFMM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid CLJPKJCOAJE;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid IEKPNFIJOIK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid PDDOONKDMNN;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid AOICLAPMAEK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid FDHKLAKGGOA;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid HEOPMANJBMB;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid IGFDAMEFIFK;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid BCEHNKFNOFP;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid BCCFAAOHJIC;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid KAIFNBAKFPC;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AOONJOCGIPK;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid ABJPNPEAMMC;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid ALHGECJIHOP;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid KHENOBBNBEM;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid ABILCBNFDCI;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid JKMCGKCFIBP;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid BKNBAFBPMLP;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid ILMPIGBKADE;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid NEIKKLONMAB;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AMGCKMALLAP;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid OPNANNFCLGC;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MHGEHHMCADI;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid IIKKGGDOKBG;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid LLNCAOCAKEB;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GHGONHEHAJM;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid ELBIPOLCLBD;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid MBMPMGKGKME;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HJIPANELODA;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid OKKEACECJCL;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid NELDJNMINPP;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid LAGOJGPNODA;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid IPKHJKIBEMK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid NOHHACPPMGF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NCBCIAANEAF;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid NEOLIKEKICG;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid GDNLGEGLOGE;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid JFDJFFDIECO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid OCNPJFEJNNN;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid PPCEFPPBANF;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid ACDACBHHIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid CMIDDMFHHFB;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid ECGLEHJIDAA;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid PFHFMDANEOK;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HPPBJGMIKLJ;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid JKOAEOEENOO;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid CHLGMJCHFIH;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid OOJIFACJALK;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid BDOHAJHIKNI;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DGFJKJBJNOB;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid OPOKFABJGGC;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid BKGOAAMMDPL;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid PMPOHKKPDAP;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HMEAMBBOEHB;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid FKELJNOFGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid AINDCCEKPLK;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid NOOJANDBLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid NFFLFEDHMDH;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid DBBEMBLFMGI;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid JNGMAPIMLCL;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid EOBIPHJNCPL;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid MDDICODNOEE;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid OODAGAOHIDI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid HIKEMKPPKMO;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid IGKGECGABJD;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid MPLCOJHBCIO;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid HBALMFLGFBA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid HPKEOJJCDPB;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid MOGCOLNEPOC;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid DCOFAJBCJPI;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid KLOHEMMIBIA;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FFFPECPBJHO;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid AJAMDBDGGON;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid JEPDDHJIDIL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid KPHKCLHIGEK;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid FCBHKPBECOM;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MOIEIJLDKHA;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid BAJDOPGKAEP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid DPJJDGGHPPN;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid MILAOHNHAJK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KFEAFBDJPGO;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid DJEMKHFFELA;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid EHLEAIBABEC;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid NCINPCBEOHD;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IKLDNBGLGPB;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid ILGNAOLJEHC;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid LAKFIFIJPAO;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid INIPEFGOCGF;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid CIKJLJNAFLK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid HONJHOLPFFF;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid GOPMFAIGMID;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid GBNKGLNHIGO;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid PNINJFFLLPC;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid CFNHJILPFPL;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid PMKDPLMOJHM;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid POFACIKBNCB;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid FAJCALJLFIB;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid AIAMHJJFKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid NAFLBMBLFGP;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid NBMFDBECBDL;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PCHEGLCPPIC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid LBEGLNONJHL;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid HGHMEGOPDEM;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid LEJABLMOKCC;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JJMJEHIEJNP;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid MDLCLCEMCNO;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid IJICBIBIFJO;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid IJJDIJNNLMI;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid MNKKLDFLMIO;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JNIONDKCIAA;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid KCIEIIOBKNH;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid PMJPLAKAIHM;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid LIHGBMKFHJH;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid NPCBHMOHNME;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid ILMFIDPJGPO;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid FBHHOCIHJHD;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AJEIMCKILOL;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid OBOIOLJHJND;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid EHKLPMDKAOB;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid LFEFAKFLJNK;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PLEDMBJIECP;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid BDFFNJCBELL;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid BCHELCNDBFP;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid KBJOCIFKPPB;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid HKHBDNKLLLN;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid MPKCGLGBGNC;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid HNLOKKHOHNJ;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid EPPOFOGBLIE;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid KGIMGBJJOPN;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid BMBCEFOHCHH;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IFCLMOICDNP;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid ELLLMNFIBON;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BCIPLHEENEG;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid LPKGMBDCLPK;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid GNHHJIPDGDA;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid OOBDNCIENDD;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid KONEIONLEPL;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid GHKIADBPKNK;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BNIFOMAAFFM;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid KMEBFELBOPC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid DCEPGGHNPMM;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AJIEPLMGMNH;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid PLBEFHJPLEA;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid DCGECOKDJIC;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid ODDIMHDHOKO;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid MBNIPFECJLP;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid JGFMENCIDPA;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid NKJIKHPNIEB;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid IBMOCMBJGPD;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BEDFDKPONBP;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid HMKBMJPMLDL;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid EHANOGNHBBA;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid LDJNFPLKGNG;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid JHLLGOGECFH;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid OBLGGNPOONL;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid CPKEGDDMBPL;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid EHGDOHKBFCG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BDEBMKILKAI;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid JIACFBKDIOF;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid KNCEKIPBJNN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid IPCEEMEFMOG;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid DFDAAEIKGAC;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid EBFBCPBDKLF;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid MNMNIPGHGDC;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid MNNBFOPEPEA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid NKGILDHGAHK;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid OIDGOFLPIHO;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid CFLBCBKOHPN;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid CHPDCHLILJG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CBMCMJBKKDB;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid KKFLEDEFNJO;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid NECJKBEBMCJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid LIFOLBDOKCO;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid NGNAMEMLFGD;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid LBAAEEGNPBD;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid EGPFEJEPNLK;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid AEPKJFPHPMA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid BCMMMEFNPIG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid NFOFHEFKLDG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid CEPNAJKJIKO;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid LENMLDHMDEE;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid NICBKMKNOAC;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid EAOINJKKEJE;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid MGKLHNIJOCN;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid DKFEOKFDDPD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid BODDHFLJJHF;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	private static readonly Dictionary<Guid, DAEJBFPJELB> KLKHADIAMIE;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private static readonly Dictionary<DAEJBFPJELB, Guid> AFMDBBFMGEG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, DAEJBFPJELB> EILIJAFGNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0E70", Offset = "0x5DAFE70", VA = "0x185DB0E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<DAEJBFPJELB, Guid> HCGFBBNOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0E10", Offset = "0x5DAFE10", VA = "0x185DB0E10")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OMFMKGFMHIG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4EA0", Offset = "0x5DB3EA0", VA = "0x185DB4EA0")]
	public static bool JCLNFMGLDFM(LPIJCOLNNNB EHCJPLEHHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4ED0", Offset = "0x5DB3ED0", VA = "0x185DB4ED0")]
	private static bool JCLNFMGLDFM(BPENDGACPHH IOCPKHOAOLP, LPIJCOLNNNB EHCJPLEHHFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FJDEKHAMLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public readonly GAHGHHAOCKA LADNMFLNBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public readonly IEnumerable<GNLAKLLEMDG> LGBFCLAEJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly IReadOnlyList<GNLAKLLEMDG> PPPMNDBJFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly GPIHCBBBGNP<HGHDFKDLHJG> MFKAOOELAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<KOOPHFOGCOG<FHNJFMCLFOD>> LCHACHCBGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly ByteString BIHPFPICBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly PHDGGOKABHO OGFJPMHOGPK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0ED0", Offset = "0x5DAFED0", VA = "0x185DB0ED0")]
	public FJDEKHAMLDL(GAHGHHAOCKA NKNGJKKPNGL, IEnumerable<GNLAKLLEMDG> DDIKIEEAAOL, IReadOnlyList<GNLAKLLEMDG> PLCPJDAGJNH, GPIHCBBBGNP<HGHDFKDLHJG> AIHEBDAIIGH, IReadOnlyList<KOOPHFOGCOG<FHNJFMCLFOD>> EABFHJEFJKD, ByteString CBBAIMCNEPI, PHDGGOKABHO NFCINOFLINK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KLFJLGBFDCO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(OLJALEANAAC FCLEEDACIMH, [Out] Dictionary<int, int> EKLEHFELKMM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(HGLNEIGIEKC ENDGKKCAGAC, ACAKLDDEHDO DGJPDKMIACB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GMNPDJCKOLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly Guid HHMLMEMINIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private readonly Dictionary<Guid, Guid> NOGECPHNPBL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> LDBNABKGGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x33CD8C0", Offset = "0x33CC8C0", VA = "0x1833CD8C0")]
	private GMNPDJCKOLM([In] Guid KICLEENPOBA, Dictionary<Guid, Guid> GMJEKNFIDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1480", Offset = "0x5DB0480", VA = "0x185DB1480")]
	public static GMNPDJCKOLM JCFOAHBADCD(IReadOnlyDictionary<Guid, Guid> CLPOPIKKNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1060", Offset = "0x5DB0060", VA = "0x185DB1060")]
	public static GMNPDJCKOLM FLKELLBLKMH(IEnumerable<KeyValuePair<Guid, Guid>> CLPOPIKKNDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DB15A0", Offset = "0x5DB05A0", VA = "0x185DB15A0")]
	private static Dictionary<Guid, Guid> LPICNHAKLJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1490", Offset = "0x5DB0490", VA = "0x185DB1490")]
	public Guid KEJCBFHPDNL([In] Guid BCPPFHNPEMA, bool KJECDMBBLOH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1410", Offset = "0x5DB0410", VA = "0x185DB1410")]
	public bool FOILGNBEAAG([In] Guid LPCEACMGEAL, [Out] Guid AEEDOHOCEBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NGCDCJKBFFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LODDGFKFEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJBPOCIDFHA(ByteString LNCOLHOCFJN, GMNPDJCKOLM GLKBJLIGAMM, [In] DJCDPGPAJPK CLBHCAMAIIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOIILOIOLGK
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
public sealed class EPCDIEOMIJK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> PFFPHEOICLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> OBIDJOAEPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	public EPCDIEOMIJK(IReadOnlyDictionary<Guid, Guid> KAEOLFDNBPJ, IReadOnlyDictionary<Guid, Guid> MGFJPKMDNPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CGIBDEDIFAL
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DADE90", Offset = "0x5DACE90", VA = "0x185DADE90")]
	public static LMMHGEMEALB CLAAKIIAHPN([In] FJDEKHAMLDL LOMCEOBNKMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE4B0", Offset = "0x5DAD4B0", VA = "0x185DAE4B0")]
	private static void INGJHCPGKOC(LMMHGEMEALB CKGNJDLGMIG, [In] FJDEKHAMLDL FJOCOGFOIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF760", Offset = "0x5DAE760", VA = "0x185DAF760")]
	public static bool NPAHCDALHFG(LMMHGEMEALB CKGNJDLGMIG, IKIPLKJCGPO NPIPPDBKIPF, [Out] EPCDIEOMIJK? GMJEKNFIDPK, [Out] string? KHEFJOIGNAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF4D0", Offset = "0x5DAE4D0", VA = "0x185DAF4D0")]
	private static void NILKNAECJFG(LMMHGEMEALB CKGNJDLGMIG, GMNPDJCKOLM? NPNOFGMFOMA, IKIPLKJCGPO NPIPPDBKIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0A50", Offset = "0x5DAFA50", VA = "0x185DB0A50")]
	private static void OOGFFPKNCEG(LMMHGEMEALB CKGNJDLGMIG, IKIPLKJCGPO NPIPPDBKIPF, IReadOnlyCollection<ByteString>? JOCJFJMAEPK, IReadOnlyCollection<ByteString>? IJMBHCGBAEN, IReadOnlyCollection<ByteString>? FFLHGJANMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEB10", Offset = "0x5DADB10", VA = "0x185DAEB10")]
	private static bool KCCFKGCNDPA(LMMHGEMEALB CKGNJDLGMIG, HGLNEIGIEKC ENDGKKCAGAC, IKIPLKJCGPO NPIPPDBKIPF, [Out] string KHEFJOIGNAL, [Out] Dictionary<int, int> EKLEHFELKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DADBB0", Offset = "0x5DACBB0", VA = "0x185DADBB0")]
	private static Dictionary<Guid, BPENDGACPHH> BLBBDKLKPGL(LMMHGEMEALB CKGNJDLGMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF1B0", Offset = "0x5DAE1B0", VA = "0x185DAF1B0")]
	private static void LEDPBEODIFH(bool EJLKKGDIJJH, GNLAKLLEMDG FGNJDLEPFIE, Dictionary<Guid, Guid> OBDOIEADAEB, GMNPDJCKOLM IGJDHMBNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF240", Offset = "0x5DAE240", VA = "0x185DAF240")]
	private static void NHMHLNLEFLC(GNLAKLLEMDG FGNJDLEPFIE, Guid MNPCJGJALGG, ONCPKBJBBBJ? IGCJNAJDFCJ, Dictionary<Guid, BPENDGACPHH> GIPCCEHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE000", Offset = "0x5DAD000", VA = "0x185DAE000")]
	private static void HJBCEHPMDCL(IEnumerable<GNLAKLLEMDG> GFIHJNDFACH, IReadOnlyCollection<ByteString> JOCJFJMAEPK, IReadOnlyCollection<ByteString> IJMBHCGBAEN, IReadOnlyCollection<ByteString> FFLHGJANMOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IKIPLKJCGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public bool EJLKKGDIJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public PHDGGOKABHO NFCINOFLINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public ONCPKBJBBBJ? IGCJNAJDFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public ONCPKBJBBBJ? EOECGFMLKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public GAHGHHAOCKA BLDAAEGLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public OOIILOIOLGK JLEMAPEJNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public KLFJLGBFDCO LJBIGDBEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public NGCDCJKBFFH JLHCCPBDDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public KOOPHFOGCOG<HGHDFKDLHJG> NCABGMDNELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public OFBFMNGJOOM IDALCMBCHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public List<GNLAKLLEMDG> OKFGKDOHEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Dictionary<string, object> INLFCKCNFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public EHIAAJGBJDI BEABFIGAHIP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BIAGPAJJEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1990", Offset = "0x5DB0990", VA = "0x185DB1990")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ONCPKBJBBBJ
{
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private const float KPLKADAJJFP = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Vector3 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public Quaternion LGOFCBEILGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public float EKPAHLHAMGH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 CDAHPAABFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5280", Offset = "0x5DB4280", VA = "0x185DB5280")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DJCDPGPAJPK BDEKJLIFJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5390", Offset = "0x5DB4390", VA = "0x185DB5390")]
		get
		{
			return default(DJCDPGPAJPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8C4AD0", Offset = "0x8C3AD0", VA = "0x1808C4AD0")]
	public ONCPKBJBBBJ(Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM, float EKPAHLHAMGH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5460", Offset = "0x5DB4460", VA = "0x185DB5460")]
	public static ONCPKBJBBBJ EMINOHICBMB(ONCPKBJBBBJ IGPIMCJILMM, ONCPKBJBBBJ FBGMINJDGBI)
	{
		return default(ONCPKBJBBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5970", Offset = "0x5DB4970", VA = "0x185DB5970")]
	public static ONCPKBJBBBJ OKGBDLIDGHC((Vector3, Quaternion, float) FCLEEDACIMH)
	{
		return default(ONCPKBJBBBJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5990", Offset = "0x5DB4990", VA = "0x185DB5990")]
	public static ONCPKBJBBBJ OKGBDLIDGHC(Matrix4x4 DAGOOGENCFD)
	{
		return default(ONCPKBJBBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DB56E0", Offset = "0x5DB46E0", VA = "0x185DB56E0")]
	public ONCPKBJBBBJ IDFDHJENMFK(Matrix4x4 PIMEBPKGKBD)
	{
		return default(ONCPKBJBBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5900", Offset = "0x5DB4900", VA = "0x185DB5900")]
	public static ONCPKBJBBBJ NOGKDDEMNEJ(Vector3 LPGLCEHEHMC)
	{
		return default(ONCPKBJBBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DB53D0", Offset = "0x5DB43D0", VA = "0x185DB53D0")]
	public readonly BKMICNMPBCG DFCJOHJBNLL()
	{
		return default(BKMICNMPBCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IEDAJIGHBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1900", Offset = "0x5DB0900", VA = "0x185DB1900")]
	public static ONCPKBJBBBJ ILNHPOEMNLG([In] this BKMICNMPBCG IEOMMHOPOKN)
	{
		return default(ONCPKBJBBBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JDOHBOMNKJE : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2350", Offset = "0x5DB1350", VA = "0x185DB2350", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1D70", Offset = "0x5DB0D70", VA = "0x185DB1D70")]
	private void ELICEFHBJHA(Dictionary<Guid, Guid> LBMABADDJCP, MMOIHLFFNJB EBPHHIPHJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1D10", Offset = "0x5DB0D10", VA = "0x185DB1D10")]
	private void ELICEFHBJHA(Dictionary<Guid, Guid> LBMABADDJCP, IFIOPNMNMMF OKNANOPOFEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1A90", Offset = "0x5DB0A90", VA = "0x185DB1A90")]
	private void ELICEFHBJHA(Dictionary<Guid, Guid> LBMABADDJCP, FLOCHBICKGK HDIOMENJKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public JDOHBOMNKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EBJOGICDGDD : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0C80", Offset = "0x5DAFC80", VA = "0x185DB0C80", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EBJOGICDGDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HJBOCKMOPKB : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB17A0", Offset = "0x5DB07A0", VA = "0x185DB17A0", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HJBOCKMOPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class HBHGJDJNPEH : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1650", Offset = "0x5DB0650", VA = "0x185DB1650", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public HBHGJDJNPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PKHNPEIFELB : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6B40", Offset = "0x5DB5B40", VA = "0x185DB6B40", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public PKHNPEIFELB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LEMLBLMMOBO : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5DB23D0", Offset = "0x5DB13D0", VA = "0x185DB23D0", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public LEMLBLMMOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class MKKPIEPOCOB : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2510", Offset = "0x5DB1510", VA = "0x185DB2510", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MKKPIEPOCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class EGPMNOEDIOL : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0D20", Offset = "0x5DAFD20", VA = "0x185DB0D20", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EGPMNOEDIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class MMKOIGNNLBA : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB26B0", Offset = "0x5DB16B0", VA = "0x185DB26B0", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MMKOIGNNLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class CPBDCIEEPPJ : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0AC0", Offset = "0x5DAFAC0", VA = "0x185DB0AC0", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public CPBDCIEEPPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class GAHLDOGJHEJ : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0F60", Offset = "0x5DAFF60", VA = "0x185DB0F60", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public GAHLDOGJHEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NOIGPAEBGOL : LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly System.Random NFLIPJFJELF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4CF0", Offset = "0x5DB3CF0", VA = "0x185DB4CF0", Slot = "4")]
	public void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NOIGPAEBGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LPIJCOLNNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public HGLNEIGIEKC CEJKGGNMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public EGOJCLFIGGP MCGJAFFGDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public Dictionary<int, int> CCMDAAOAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public Dictionary<Guid, Guid> FCEFGDJBGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public EHIAAJGBJDI BEABFIGAHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public bool CPKPNGNNIFI;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LGDHCLFHMDC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHHDHOONJDI(ILPMPAOPKLK GNLDFCJAPBG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NIAGMNHBODN
{
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private static readonly LGDHCLFHMDC[] DENPBPPONED;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3D60", Offset = "0x5DB2D60", VA = "0x185DB3D60")]
	public static void DKJACCLKPFG(GNLAKLLEMDG FCLEEDACIMH, Dictionary<Guid, Guid> KICFOCJJPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DB43C0", Offset = "0x5DB33C0", VA = "0x185DB43C0")]
	public static void JPKKAIGHNEI(GNLAKLLEMDG? FCLEEDACIMH, GMNPDJCKOLM IGJDHMBNIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3FF0", Offset = "0x5DB2FF0", VA = "0x185DB3FF0")]
	public static void JCLNFMGLDFM(ILPMPAOPKLK GNLDFCJAPBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ILPMPAOPKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public HGLNEIGIEKC KOJKLPFMCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public GNLAKLLEMDG FGNJDLEPFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public Dictionary<int, int> CCMDAAOAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public Dictionary<Guid, Guid> FCEFGDJBGME;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DB19E0", Offset = "0x5DB09E0", VA = "0x185DB19E0")]
	public Guid IIOKHKPGJAE(Guid BCPPFHNPEMA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EHIAAJGBJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int CPLNGJLJPLP, [Out] Guid DMLCAJBLKAF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class MNPDEFHCJKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	private readonly HashSet<string> DOPPJJDKLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	private readonly Dictionary<long, int> AAIPEDHHNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	private readonly HashSet<Guid> BMAENKDIKHP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> FFDCHHHFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> BJIDGCIOIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB38C0", Offset = "0x5DB28C0", VA = "0x185DB38C0")]
	public static MNPDEFHCJKK PIMLKIFJJJJ(LNIMNABFGFK EINEAGMJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3850", Offset = "0x5DB2850", VA = "0x185DB3850")]
	public static MNPDEFHCJKK MHNDPHJJPMM(LMMHGEMEALB GENKAONMCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2870", Offset = "0x5DB1870", VA = "0x185DB2870")]
	public static MNPDEFHCJKK ENHHJKAMAHO(IEnumerable<string> DOPPJJDKLLO, IDictionary<long, int> FOBLKKJAOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3C40", Offset = "0x5DB2C40", VA = "0x185DB3C40")]
	private MNPDEFHCJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3B00", Offset = "0x5DB2B00", VA = "0x185DB3B00")]
	private MNPDEFHCJKK(IEnumerable<string> DOPPJJDKLLO, IDictionary<long, int> FOBLKKJAOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3070", Offset = "0x5DB2070", VA = "0x185DB3070")]
	private void KBGGOCLBNHA(LNIMNABFGFK EINEAGMJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3660", Offset = "0x5DB2660", VA = "0x185DB3660")]
	private void KBGGOCLBNHA(LMMHGEMEALB GENKAONMCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2BD0", Offset = "0x5DB1BD0", VA = "0x185DB2BD0")]
	private void KBGGOCLBNHA(BCKBELGDNLN? GLACNLFCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2A60", Offset = "0x5DB1A60", VA = "0x185DB2A60")]
	private void KBGGOCLBNHA(OIECKNNLLPE? OCIGNENFCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3270", Offset = "0x5DB2270", VA = "0x185DB3270")]
	private void KBGGOCLBNHA(GNLAKLLEMDG? FGNJDLEPFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DB29F0", Offset = "0x5DB19F0", VA = "0x185DB29F0")]
	private void JFIKFDHLPNA(string? CKOKDENOFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3A20", Offset = "0x5DB2A20", VA = "0x185DB3A20")]
	private void POGKCCJNOEO(LIMEAMKBAFB? AOMJDFPIBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3930", Offset = "0x5DB2930", VA = "0x185DB3930")]
	private void POGKCCJNOEO(DBHBEIOJGEK? AOMJDFPIBKC)
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
