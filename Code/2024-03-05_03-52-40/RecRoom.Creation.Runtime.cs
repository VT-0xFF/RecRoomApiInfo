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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x6085DA0", Offset = "0x6084BA0", VA = "0x186085DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CEPFDJNDACK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> OFBHALJFLEJ;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> CPFOOLBLBLK;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string JPEJFEEIBGE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string IIBCAEDJGBM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string GDDJELOOMOF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6080B50", Offset = "0x607F950", VA = "0x186080B50")]
	public static bool PDHEKLMEPGM(Guid GLICEGHOOEI, int HKDLOIFPDOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60804D0", Offset = "0x607F2D0", VA = "0x1860804D0")]
	public static string FOJOPCBLDDH(Guid MAAFBDMNKAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ANLCCDICJJJ]
public enum LKNMCKGMKEB
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
public static class OPOMLFOOHAP
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid EFIHFALHCOA;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid CEOHEPMDGHH;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid LGKECNALKDD;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid AMKHJDCHDBG;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid PMPDGHPNCMG;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid APGJLNENPFA;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid FENDMAJENOM;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid DKDKHMPHDFH;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid AKOMDBCIFIP;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid MJOOEEIEPDA;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid JHPLGAONENL;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid LBAPOIEDDHF;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid PNBGGHOLBCE;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid DHBKACFMEJB;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid GDHHNDEFBJL;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid GLGNEEIMNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid IEFIAKKMOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid NAFPAIIPOEJ;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid DBPMBGLBJDI;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid EBHDDDGGJPO;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid IOEDELKNBOC;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid JOLAMKONBEL;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid DHCMLFAEPOF;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid LIIOGBFFHEA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid BCDBDLFKAPJ;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid JANIDPDJKGM;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid CKIPBHBIDKF;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid NPCACNBDMCB;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid JALMKGDHNBH;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid HMDDJEKCLKE;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid HPMKFCKDMNG;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid LNKCHABEMME;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid FMNAKDEBBON;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid EIPKOJBCNFM;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid JMFDPCAGPBM;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid JHDKHGNKMHP;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid KAPAMLLJEHI;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid IEECHOIHMEO;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid IBCPDBKFIDC;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid MJDGGONBAAH;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid MKINKJMMOLD;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid DOLJJEBPDOK;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid MKKLLAEPGBM;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid KHANFIDFPDF;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid NDDAFICJDAN;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid PJENMKLNJFD;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid FGNMEDKBEFI;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid MFNMPJNJNGH;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid JOAAJGANABM;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid IMCBANMIFHK;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid KGJCLFONNKC;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid JHEMIGLDLJJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid OLOICALEKPL;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid NCMJGBICOFM;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid FOKIGENKKPL;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid MDDHMJDOAEM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid MIIJGIPFPMO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid DDIJPNNNMCE;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid BIBCBHIDMKN;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid IAMEFGDOGJM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid OCFFDHPBFNE;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid LDBBBFOKDPH;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid PPAFBKKDAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid OKPLNALMAGA;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid AMCKIDIOIDE;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid EIELCELIMOP;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid ELIBKJAPMDO;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid NOINANOAOIG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid EMGPOLKFAOH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid PMDPBJHPEJP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JLEJKLMDPKD;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid KHIFEPBNNAC;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CDBENJCAMFO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid EPFJGJDONKK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid OCGAHANOOAN;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid JPKFPBHJCFF;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid KNMOEIDLKLD;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid JJKIADDMLOF;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid EIDFNEJDJHA;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid JPJPGDEGPDC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid AKOCEGPEICC;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid AAJENKACHBG;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid BIOGBNNBMAA;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid EBBJKDBJJKE;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid HBMCJBLOOPF;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid NEMFMFMLOMN;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid EOCCILFGNFL;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid OHPGEEJCOPA;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid HNDEEGAEKKD;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid OIKFFCLGCIF;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid EIMPIHNMEHA;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid MPMBCIIKCNP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid ODCLOFMMPKB;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid ECAKFEGCLDN;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid DNDPNJJGODJ;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid AJFBFLGEOEO;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid CLNGACFBEMB;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid LKPEOMJDLEE;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid OEFPMGDDHEA;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid DFMIJOLPIBA;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid FNPCCKHJKLD;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid NOGANOMHCDN;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid KJBHHDJPCOM;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid MDFNOPNDMNH;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid FDJINAFABKO;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid LKKBABBKMII;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid DJOFLEHOEGP;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid NIMPCOHDAEC;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid AEIFHIFOLLN;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid GEMCNKJEJFD;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid IGPGKDMNKHM;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid NBFCFAGMMEA;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid MCNJOGOKONG;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid BCFKHDKFOHI;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid PJFPCHLHGNA;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid KDENNBJMGCC;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid DDCIIFPHAOA;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid OLGCGKFFFJC;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid CCGACHKHOCC;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid NLDLLAPHGFH;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid AANCHCLDBOC;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid PJGEGLPAIMA;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid OLPJDBOMEKP;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid BKOLNEAFMPI;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid BEMJPHHMOND;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid IFLDNKKAKFE;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid PFHPMKLAEGA;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid LAKDOPMEPPO;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BFEPECPCBLC;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid AOOEHJMIIJM;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid PPFNMKFPOGK;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid EGAEKBIFAGP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid KCDJPNGECIG;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid JJOEOBOLDOE;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid DOHNPLINHON;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid NLLMPAPDPON;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid FFAMMMLPNJG;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid KMFGEDHHMCO;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid PFMAPEBAKDJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid LBHCNELOCGO;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid MCODDPJHFKD;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid OJLGICJIKFN;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid CCEMKIEIDEE;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid LCCIENJGOAP;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid OPFKJJHBFDA;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid KIHEINJIBDH;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid CAFDLDNNNCD;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid CDFEODMKCOM;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid NLHPPPAHGHF;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid KIAHKLMKBOE;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid BNALOOLGOGA;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid BKKABPKBCAF;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid OPDJBNBMKAC;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid GLCAJCEBJAI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid FJCDAJEGPIN;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid LEHHPBGIPCE;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid JLBELLCOGCK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid ALNKGFKALPC;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid NIFKHCHJJHM;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid GMPHFODLEHF;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid EOFLOIAGBPJ;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid KMKDLIAAKDJ;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid CBGCJOOFKEC;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid OCLHKBMHLPP;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid DHLEPGJNCII;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid DAEGEKKPGEG;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid IJHIAJIDPHC;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid JPIJANJKDPL;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid KECKEBLJPFN;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid DJAJBEIDDIN;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid IMFIMKIKGGH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid NAEBDDAFEDH;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid FFLJJCGCDIL;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid AOAJCAMPLAI;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid GABOLIAGOHL;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid DCIGNIFEBID;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid IKCCBGIDIEL;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid NKCHOOHKJBG;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid KFLCJEBHIDC;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HNKBFJKLGAE;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid IGNKIIMHHFE;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid EIOEOLIHGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HFLKAAAGJAK;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid CHPBFCOLMBH;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid BAHEFDALIOP;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid GPEGKLHFOHI;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid AHHHGKNCPLB;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid JOHKDHMIKCG;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid BLMOPPJDPNL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid PMFGDPOEBKI;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid MKLOKHLFBOG;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid OKEAAGIGAME;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PHGOPOPEANL;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid OEBCBGPDDCD;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid JJBNPOLCNID;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid NNLMFPAKEMN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid BFFEBPJECDL;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid IOIFCENDJCE;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid MBJMGIPHMKP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid FPLJGJACCKA;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid NEHCFABGHNL;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid HLCCMOJPBAO;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HHFEPPDMIAA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid BPEAABJEEIB;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid BNNEOFHFOBA;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid AHJMMNLOMFA;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid JHEHLHANABG;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid OKGGJKMHFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid NDMCALCAAEK;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid LKJEHPKDLGJ;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid AFNBIFJHJGA;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid DKPEBNAABEG;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid KOMPPOFMIIF;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid PABGEMMGGOG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid LOPOFKDGNCB;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid OEPFBCIABJD;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid JPECHECAJDI;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid NMIFKNJAIHL;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LADFIJKIKLL;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid NIILMMJMIDP;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid NFKGPLOPEAM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid OEIGDHMAHPE;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid FMCHLEJPOLM;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NEFHAALDDDC;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JKKIIAKGGBG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid ICNJBFLKAHN;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MEFPDBHBLIG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HHMHLEPBDMM;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid FKIPEAAJGNA;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid KNKNDGDNFBM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid NKBJENEEFFL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid EBFNKKFIEJE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid POMBAEJIDCF;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid ECLHAKLCJIG;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid IBIIPALMGKK;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid MFHJBJMOLMO;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid HBFKHAKHOGE;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid LGLPEBLIEFG;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid FJMLMOBPDGF;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MKAGIBJMMPB;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid KFHHDIGELFE;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid JDIKLEOLGMI;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid OFEGBNGDLKG;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid FFJPGKHDIKI;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid MDEJAHGHCKH;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid EKGOINOHFPM;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid HBEIBHCJIJA;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid GINKMDLMAFF;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid ELKEEKMELNC;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid EKGOOKJHOJP;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid KEHPECOGAAG;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid HKIOOCCPBKJ;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid CKDDHMGGAEH;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid HCCILBNKALM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid BLHMKPIDIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid PKJEDEFOLEI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid HOIPPOMCJKH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid DJMLIDFIFHP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid OPBBJMDDGNJ;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid KODAFMDGLCF;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid LNCDKFLFCAH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid FCNDOBPOIIC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid JPNPJCFLNKE;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid NHNLCBDAHDF;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid OGOIKFGKIDP;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid IKIKFPOBHDM;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid DIMFCFLHPHD;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid OCBBCEIABLE;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid JHAJLBNFCNI;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid GOIKACOGJEE;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid KKDFDOKIJED;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid DPMIFHIHFJP;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid JGIBKOKCNMA;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MFKEEHDEEIM;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid AHEIJBIDDOK;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid MGNBKCCEPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid MMICEONGHFI;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid APBBEDAGHHM;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid EPBAJOFNIKH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid ADHNCGFEIGE;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid PDPNGAOILID;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid DGEBFOGJJIP;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid AONNECKNJAJ;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid NEKLICAHIPE;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid ONALMHAMLAC;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid PFJAKDOAHNF;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid ILLGKNPHPLN;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid GACKBEAAKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid IDJCKOCPENJ;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid BJAGBHNMGIN;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid KFAALKGFIAF;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid HELCNDJEJIC;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid NICJHEEINMK;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid AALDILAMLGD;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid GGCPACBBEJJ;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid AFNMFALINAD;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid EFMAEBCJAOB;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid DOOMLAKKJOI;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid EEMCDILAIMF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid BKBAMOOHCOJ;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid GICCDKLCBHF;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid CIEJKGFLHIG;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid NDINOINMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid GIBDIBKHOKF;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid HBMDGLNPKCB;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid EIDFNIPEIKN;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid GIAFINCPJAF;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid IDBCPJOJLDF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid JJGOEDFAMPC;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid NIIOCAMNCPM;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid DPCBMJLLGGF;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GENKACCALCA;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid LCEFIBEGAHJ;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid LAAPJAGLPBI;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid BKPJCGKGCAP;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid LKPPJICLMEA;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid PBJPHPHFGKD;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid LABIEBKCHJM;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid FBFIELAJEGG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid KLHONNELCEE;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid CCAEIGKFBMH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid NJINDEGANKP;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid JNGIPFCANGA;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid JIHJNPMMPJO;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid ANIBLGMMIIK;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IIMFAPJHCLL;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid NKFMOOGLGAB;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid EDNIBFNJDCL;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid HFEHKLJAMHH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid NHBDKBEOCED;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IIJGHGGPOAK;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HBGJACIMHDE;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid KHCJBKJKOOB;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid NJJPJCEPDJD;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid IKNHBADFGHA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid HKBAMIKHAAO;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid NLKFLLICNBB;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid JAOFDPNFAOK;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid IBIGALFDLAI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid IMCLPPOPAKP;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid AAGECHGHFEG;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid GKIDHOLAPOK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid MKBCDINFAFD;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid JBMBJCODCLO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid PIPKGFGDEEC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KMAJNONKHAP;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid CDEOANFKOEO;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid HBMPLEPCADA;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid IAACNJILHGN;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid KJAJMGOOFLD;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid JGPIDIPBOPI;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid GOEHFNEFIOO;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid KJMPBKCLKBD;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid ALNJIDKNOHA;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid GFNJAMOLPDA;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid OGKFINODBOA;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid MOIFKJLAPJO;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid CEMGBAFAFKN;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid FFHEJIIDGCO;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BDGAFOOCDAK;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid NPBJCFMMBFM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid IAELMLDENLA;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid GJBJKPABBCN;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid LNEHKCCBPBH;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid PODCDIGDPPA;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid HNOINBLMMCB;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid FKBLGNFDBFC;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JOPJFPFINIO;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid PKPIPHAIJAC;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid HLBPNINLHHD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LGALAIKHLMF;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid CIOEJJCLACA;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid BNJFLHENCEP;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid GHEMCHHAOCH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid EKBAGANEKDD;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid COGEDDEOKOF;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid NBBICCCMGPM;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid INACOKHEJKN;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid DELECEAJCNF;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid MGKHEGHKLLJ;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid MKDBIOJLFOH;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid NJJJNDLHMHL;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid ANOEMKNNNNN;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid KCBGJFJMBFK;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid HEOFBHCEKKJ;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid NDPKNENPBFC;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid HCGMLIGLBKD;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid CEHICBBFNNN;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid HLJINNJMABB;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid IOGLAFEBPNG;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IDPFPHKFKDD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid AMJIONLEEMK;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid GFINPAGJJGE;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid BLMJOKKGNPO;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid EJPMJGCDOCB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid FPPNNKMKCMK;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid MCDNBGDJHPP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid PEPDIOMFMHN;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid AMCMFOHHAHJ;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid KGNPDKDPJEK;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid DLEOFIHJHGE;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid NEBPPMHAEAI;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid LIFEHGECEGH;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid IKKNJBFBFLC;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid CLFHOHNPIIN;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid EACIEGAHKPB;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid NHAMNDLJBBF;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid GDCBLEMMFOA;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid BPMCPBMBEAL;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid HLFFEAONPOA;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid GJJJHJLBJBB;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid GOPKKIPLCBP;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid MEMMPPMAFIE;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid KHAIGJFECFE;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid BAIEFHJFAAH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid LJNHCMLALKH;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid BPPJIAOPAGK;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid GNNKHGPFMBI;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid LEIKCPLAGCP;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IOIBIECJNKK;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid JABJAIGOJHD;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid APIKMAALNHG;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid CEFFJNEIPDO;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid EAEBAAINHPI;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid AFCPHLBCPEI;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid LIPFMAIAMNK;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid FKNIKGHNCID;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid JEHMGBGKJDB;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid PJLGIKKCFLI;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid NOFOIGEFPFB;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid IGJANEBOGAK;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NDJEDMCBLCE;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid JNCOEDPDCCD;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid OIGDBFEGKIC;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid IJOCMCBNFBC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid DJLPOIFJMLE;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid AKALOCIAMDH;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid DGEMHIIPDBJ;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid FPFPAAKGDEL;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid PEGOIFNDMOG;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid FHJAGMLHBNF;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid DOAFEAKOHBH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid KNIMGMIGMME;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid GOMLGGJIFNM;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid NKGCODAADDL;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid IHAOKAOJEBA;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid DNMMMCKBEJD;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid EKMODOJMOPD;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid FPDEJFMHPIB;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid GICKIEIIKHG;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid FBBMIMBHDMH;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid PPNNFCILGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid CJLAFDCMJKF;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid HBGCNNCDLNB;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid OEHCNALOLJE;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid NMBCPKNLMCG;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid NLABPLEDMAN;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid JFLLCMDMGKO;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid KHKELOGPMOO;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid OELLCANAFKL;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid MDJHNBGILND;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid NJPGIEILCHE;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid IAPOIMAJKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid GECONNBPMIA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid PBLMAJDBFHA;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid FHMDDHBAMGI;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid OLJCPFAAHNM;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid FIFAFDPODBH;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid FMDKCKHDKFK;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid BGICHDDLFKF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid EHANFDFCFIG;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid BPKKKGANOBD;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid POBKHMLCFGM;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid MEMMEAMFLOH;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid FKDIDKNGFFD;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid NMIOOLJPBAD;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid CGLBCPEONCK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KFEFJCKNPIC;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid IONECEMOHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid DLLPKIGEGHN;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid OKHCIGJNAEK;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid BPCKFECONIA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid OHEMGIPPHJE;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid CFPFCDNCOKI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid BFGNLBIOGHA;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KPPLMBEFKIK;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid EMPCGBOEAOM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IEAEJMHOBJN;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid KOJKEDMLPID;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid MFINFMGDADD;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid LMAOBIDJAKA;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid DDFEMHAMENG;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid EPIEJHPNJLH;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid PLGNBNAOEII;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid FGKAKEOJEJB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid FEBGLKMONPA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid KCCBDFPMOAN;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid ODMAAEKCHPO;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid CPIOAKBAJGN;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid BGAMFMKILBC;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid KHCOAILCEDA;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid OIMJKIPFCBI;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid JEBFJMIIGHH;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid AHGEAKBKBDK;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid HEFJKBMFOIM;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid OHHGLOAKPOP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid LGOHAHIDFDH;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid NOCLPALOOCH;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid KNCLMLAOOJA;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid PEHMCKPEONE;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid MJFPBKDLBAP;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid PNDCBEPHMBE;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid NBKACKBENGP;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AEDFNLBIGEJ;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid MNNNIFJMMCM;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid MAHAMEBIBGP;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid LHHEOIBLBLL;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid PAEGMOIDHKL;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid HHFPAKPOAJE;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid JFKJCFADHGK;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MBCEHGNICIC;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid DMAPIFNIKOH;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid DOMBKAIGPHG;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid LFLHJKPBLCB;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid BEMEAIDIOMM;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid NFMODJOPAII;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CCKBGHLOLND;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid DMDHCNHHJAP;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid PAEKFLLIJFB;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid OKPFOAMBPOK;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid NMJLBJAKPOP;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid DAKJHHKCNJG;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid JIAAHEHECKC;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid MGODPCCKPIP;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid EKDHAEMCGPG;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid IOANNLDPIDD;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid CPAPIGEPJHH;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid EOMCFBKJPDM;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid MEMECIKBJKH;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid NENGLGDPIBI;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GIDOEIBKKEG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid LDGMCEELKMM;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GDOFHDBBJDK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid PHJJPACMKFO;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid OBLFDAIBOIC;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid AOJDMDCMIPD;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid BHECKHKDOMH;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid EACENCNIOFC;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid KJLKEPEMKIH;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid KFHBKCLDDDE;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid BEPEFHIAAEP;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid KOCOHCJCKCK;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid NHANNAGOJPJ;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid HFKGMHFNDGG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid BHBAKPNCLMJ;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid ONNFBJONHGH;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid MMAKAJKBPHN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid CFPLDLPJHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid EIIGMELFKNH;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid KNCDDJOHOJD;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid GMFOJPCKDKD;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid GPAHNHOMHPB;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid NBNMLBIFIDI;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid CFHPBHHLHIH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AKOICDNHNOF;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid NALNBKLIFFA;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid MIJNAGODKDI;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid GIAPGALJFOB;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid FNDGKOHBFLF;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid PMMGJGCDOPE;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid JIOCPLACCOG;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid NKKEELILGMH;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid GJECKIMLBOE;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid HBPGIGGEKOO;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid PBIFBLLIGBM;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid CNLJEKJGBCI;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid OPIHHNCFOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid GLHJEKMGBCM;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid MPBCNHHBCGI;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DNEHBIBKGMO;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid KJNAMLENCGM;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KHHCAHAFJBN;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid FEAEFOHOGGG;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid NOPAHMBNJHI;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid NJIAKEILHEP;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, LKNMCKGMKEB> EBALLGCPJBD;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<LKNMCKGMKEB, Guid> MLMDNNPFKOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, LKNMCKGMKEB> OJMLCNMMJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6085F20", Offset = "0x6084D20", VA = "0x186085F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<LKNMCKGMKEB, Guid> OELBHELACDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6085F80", Offset = "0x6084D80", VA = "0x186085F80")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IJHIPHMEKOK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6084210", Offset = "0x6083010", VA = "0x186084210")]
	public static bool BBBJNFFCFIP(NAJIEOPGGBE AAGCPCGFIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6083E60", Offset = "0x6082C60", VA = "0x186083E60")]
	private static bool BBBJNFFCFIP(DECFJFAAKIE IMFOFMLKKCI, NAJIEOPGGBE AAGCPCGFIKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KNDPAJFDJAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly EJICJFAANKO PMEJPKLAIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<LFOPNJNFJEF> EPFLKOCHDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<LFOPNJNFJEF> IGDPJHCJJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly GPIFJNELMMP<NCFLANDMDIF> JAMIBDGGGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<GGCJJCNEEOD<PBHGKOBAGBF>> KMMGIKFIPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString HNFDAAKIKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly NPODKHHHLKJ NJNGGEFPNIE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60858E0", Offset = "0x60846E0", VA = "0x1860858E0")]
	public KNDPAJFDJAA(EJICJFAANKO FLDGGEELLEL, IEnumerable<LFOPNJNFJEF> CGHJDAIAFJO, IReadOnlyList<LFOPNJNFJEF> PLHBGHMKDNE, GPIFJNELMMP<NCFLANDMDIF> IKBMILCAMPN, IReadOnlyList<GGCJJCNEEOD<PBHGKOBAGBF>> HGNOHAJBAJK, ByteString CBELJEOPHMN, NPODKHHHLKJ CIAOCBBOOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KHOCHALFEGO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KONBAKOKGLI EEDANCJJEPL, [Out] Dictionary<int, int> DKBKCACKKLE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JDFGNIKEHDK FNMNOMJBEDG, EHLHLJFHLKP OIFCKDIDJBI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HDOIHBNNCAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid JOGNIMDELDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> FDDKNMNGBIO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FGCCFAJAPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34FE1E0", Offset = "0x34FCFE0", VA = "0x1834FE1E0")]
	private HDOIHBNNCAL([In] Guid MAFLBFLBJGP, Dictionary<Guid, Guid> LAIGOBNKIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60838E0", Offset = "0x60826E0", VA = "0x1860838E0")]
	public static HDOIHBNNCAL IEHILGECONL(IReadOnlyDictionary<Guid, Guid> KKIBPCIKJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6083A00", Offset = "0x6082800", VA = "0x186083A00")]
	public static HDOIHBNNCAL JNBPCOOMNPF(IEnumerable<KeyValuePair<Guid, Guid>> KKIBPCIKJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6083DB0", Offset = "0x6082BB0", VA = "0x186083DB0")]
	private static Dictionary<Guid, Guid> LGKJJMMOMLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60838F0", Offset = "0x60826F0", VA = "0x1860838F0")]
	public Guid IHBOHOMNGBB([In] Guid MAAFBDMNKAP, bool OOAHMPFMABD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6083870", Offset = "0x6082670", VA = "0x186083870")]
	public bool GNAHDPKMCPO([In] Guid FJIJLBIGEAH, [Out] Guid LIPMNECMGFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GIHIJIHNJJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DINCJKDOFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APHAODHFANA(ByteString HLMOCJJFAAD, HDOIHBNNCAL JONPFMINPNF, [In] GDAMDHJKEHO IPKHHKOHKOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MMCKANBMILK
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
public sealed class ICKNKLBGFAA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> CKAIJHIPJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> IGOAFJOFADE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x1807C6440")]
	public ICKNKLBGFAA(IReadOnlyDictionary<Guid, Guid> FMHFHCANCFN, IReadOnlyDictionary<Guid, Guid> DHLMOCEMBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BOOKLJHOFPD
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6080360", Offset = "0x607F160", VA = "0x186080360")]
	public static DFJJCJFCLFK OIEHHGNKCKN([In] KNDPAJFDJAA DINOFILOMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x607F680", Offset = "0x607E480", VA = "0x18607F680")]
	private static void GDJFJDPOJKB(DFJJCJFCLFK AFFJDALMPHK, [In] KNDPAJFDJAA NLCDIDLEGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x607E000", Offset = "0x607CE00", VA = "0x18607E000")]
	public static bool EJKHOAFNLOP(DFJJCJFCLFK AFFJDALMPHK, KKLJBIGALJP INDDMDCIDEH, HDOIHBNNCAL? EMKDCNBACEH, [Out] ICKNKLBGFAA? LAIGOBNKIHB, [Out] string? JCNMJFGAPPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x607D220", Offset = "0x607C020", VA = "0x18607D220")]
	private static void AMKEJGJGEMN(DFJJCJFCLFK AFFJDALMPHK, HDOIHBNNCAL? KADEBMHHHLP, KKLJBIGALJP INDDMDCIDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6080010", Offset = "0x607EE10", VA = "0x186080010")]
	private static void JJKDPJLGPJI(DFJJCJFCLFK AFFJDALMPHK, KKLJBIGALJP INDDMDCIDEH, IReadOnlyCollection<ByteString>? PBPJAACHMAC, IReadOnlyCollection<ByteString>? LIPHPMFEGMM, IReadOnlyCollection<ByteString>? DDNDMKKHLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x607D4B0", Offset = "0x607C2B0", VA = "0x18607D4B0")]
	private static bool CKGIINHPMAG(DFJJCJFCLFK AFFJDALMPHK, JDFGNIKEHDK FNMNOMJBEDG, KKLJBIGALJP INDDMDCIDEH, [Out] string JCNMJFGAPPH, [Out] Dictionary<int, int> DKBKCACKKLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6080080", Offset = "0x607EE80", VA = "0x186080080")]
	private static Dictionary<Guid, DECFJFAAKIE> KDODJGACOBB(DFJJCJFCLFK AFFJDALMPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x607FF70", Offset = "0x607ED70", VA = "0x18607FF70")]
	private static void GNEPJOAMPAB(bool HIMLOOAKKPG, LFOPNJNFJEF GFLPCNIDJEE, Dictionary<Guid, Guid> HCDKAFNPLAB, HDOIHBNNCAL HFOKDFBOMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x607FCE0", Offset = "0x607EAE0", VA = "0x18607FCE0")]
	private static void GHGMPAMBDBJ(LFOPNJNFJEF GFLPCNIDJEE, Guid EDKNOFODGOE, FNOLPCPJAEL? HEELALHEJGM, Dictionary<Guid, DECFJFAAKIE> IPMAHBFLOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x607DB50", Offset = "0x607C950", VA = "0x18607DB50")]
	private static void DIEKKOLBNIP(IEnumerable<LFOPNJNFJEF> PDIIBHICJCN, IReadOnlyCollection<ByteString> PBPJAACHMAC, IReadOnlyCollection<ByteString> LIPHPMFEGMM, IReadOnlyCollection<ByteString> DDNDMKKHLCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KKLJBIGALJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool HIMLOOAKKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public NPODKHHHLKJ CIAOCBBOOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public FNOLPCPJAEL? HEELALHEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public FNOLPCPJAEL? LGAOAHMHGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public EJICJFAANKO INMCGJJHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public MMCKANBMILK AABDBPCAAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public KHOCHALFEGO JEGJBHJMMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public GIHIJIHNJJE NPKLFNCEFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public GGCJJCNEEOD<NCFLANDMDIF> LAEMJIJOINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public IAMCKOBJMPC GFMOOKCIGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<LFOPNJNFJEF> AKFOEFMDGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> ICMKPJODMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public IGIFILMIGAO LIAALHNPOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool PFCONDGPMOF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GCPJKGJMBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6085890", Offset = "0x6084690", VA = "0x186085890")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FNOLPCPJAEL
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float DPEELDAFFIB = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion OKEJHHGCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float BJOKGACKCGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 EOMENJFPOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6083520", Offset = "0x6082320", VA = "0x186083520")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GDAMDHJKEHO ADEBMGMJOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6083260", Offset = "0x6082060", VA = "0x186083260")]
		get
		{
			return default(GDAMDHJKEHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9BAFC0", Offset = "0x9B9DC0", VA = "0x1809BAFC0")]
	public FNOLPCPJAEL(Vector3 AJFNKFFNDBD, Quaternion OKEJHHGCFPM, float BJOKGACKCGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60832A0", Offset = "0x60820A0", VA = "0x1860832A0")]
	public static FNOLPCPJAEL FGBKEBHLHEJ(FNOLPCPJAEL FEOGIMKDFKL, FNOLPCPJAEL HJMIPMJGBIO)
	{
		return default(FNOLPCPJAEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6082EC0", Offset = "0x6081CC0", VA = "0x186082EC0")]
	public static FNOLPCPJAEL CCJKPBOFOJB((Vector3, Quaternion, float) EEDANCJJEPL)
	{
		return default(FNOLPCPJAEL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6082EE0", Offset = "0x6081CE0", VA = "0x186082EE0")]
	public static FNOLPCPJAEL CCJKPBOFOJB(Matrix4x4 NOCBMIFHKJK)
	{
		return default(FNOLPCPJAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6083040", Offset = "0x6081E40", VA = "0x186083040")]
	public FNOLPCPJAEL ENKOFEDLNFG(Matrix4x4 NBCGMJPEDEM)
	{
		return default(FNOLPCPJAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60836C0", Offset = "0x60824C0", VA = "0x1860836C0")]
	public static FNOLPCPJAEL OCNDJDANOPI(Vector3 AJFNKFFNDBD)
	{
		return default(FNOLPCPJAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6083630", Offset = "0x6082430", VA = "0x186083630")]
	public readonly GOABJNOFLFM MNJNIDAJJIE()
	{
		return default(GOABJNOFLFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CKAMKLDEKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6081630", Offset = "0x6080430", VA = "0x186081630")]
	public static FNOLPCPJAEL HNIDGDAGOFO([In] this GOABJNOFLFM OELHNDCFEMO)
	{
		return default(FNOLPCPJAEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ANPCGBCAMMF : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x607D0B0", Offset = "0x607BEB0", VA = "0x18607D0B0", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x607CAD0", Offset = "0x607B8D0", VA = "0x18607CAD0")]
	private void CHMJHOGMKFH(Dictionary<Guid, Guid> ABMPPGPIPFL, ONMDCKEFFJK PDIAJGHJCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x607CA70", Offset = "0x607B870", VA = "0x18607CA70")]
	private void CHMJHOGMKFH(Dictionary<Guid, Guid> ABMPPGPIPFL, GOLEBKDNIGH JNANKIJKABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x607C7F0", Offset = "0x607B5F0", VA = "0x18607C7F0")]
	private void CHMJHOGMKFH(Dictionary<Guid, Guid> ABMPPGPIPFL, JEDFGDIBNKC GIBBLNIBCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ANPCGBCAMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class PKKOFBMOFKG : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6085FE0", Offset = "0x6084DE0", VA = "0x186085FE0", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PKKOFBMOFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class KNNJCALHLJF : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6085970", Offset = "0x6084770", VA = "0x186085970", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KNNJCALHLJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class EPDMJKAAJDB : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6081880", Offset = "0x6080680", VA = "0x186081880", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EPDMJKAAJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JLPCPDBHPAA : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6084240", Offset = "0x6083040", VA = "0x186084240", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JLPCPDBHPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GHDMLJHHGKK : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6083730", Offset = "0x6082530", VA = "0x186083730", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GHDMLJHHGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class LPPLMFOAPLN : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6085AD0", Offset = "0x60848D0", VA = "0x186085AD0", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public LPPLMFOAPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BDDLPALDHBA : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x607D130", Offset = "0x607BF30", VA = "0x18607D130", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BDDLPALDHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class KIHOBBLBGNB : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60856D0", Offset = "0x60844D0", VA = "0x1860856D0", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KIHOBBLBGNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EELJKJFEGGC : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60816C0", Offset = "0x60804C0", VA = "0x1860816C0", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EELJKJFEGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class OFLCLAGABOH : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6085E20", Offset = "0x6084C20", VA = "0x186085E20", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public OFLCLAGABOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class MFIAAKJGEJG : MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly NOCBPIGGDCC NFBAMMPEHDK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6085C70", Offset = "0x6084A70", VA = "0x186085C70", Slot = "4")]
	public void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MFIAAKJGEJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NAJIEOPGGBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public JDFGNIKEHDK OCEOBDFJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public NNLNEGLAHPL IALNFHCOJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> HCNNGAPJPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> EFPJPOBNKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public IGIFILMIGAO LIAALHNPOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool CLABDCIHJCG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MEFNMEOABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNIPCBHGJCH(PLPAHBLFLPJ LBFKMJPAODA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KDDKCBFKBBB
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly MEFNMEOABMP[] BLAGAMGCCCM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6084830", Offset = "0x6083630", VA = "0x186084830")]
	public static void DPKCFNEOIKH(LFOPNJNFJEF EEDANCJJEPL, Dictionary<Guid, Guid> LJMODDPDCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6084DA0", Offset = "0x6083BA0", VA = "0x186084DA0")]
	public static void ILBNKGCEBJG(LFOPNJNFJEF? EEDANCJJEPL, HDOIHBNNCAL DMAFKDEOILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6084AC0", Offset = "0x60838C0", VA = "0x186084AC0")]
	public static void EMOKKOGIKBA(LFOPNJNFJEF? EEDANCJJEPL, HDOIHBNNCAL HFOKDFBOMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6084460", Offset = "0x6083260", VA = "0x186084460")]
	public static void BBBJNFFCFIP(PLPAHBLFLPJ LBFKMJPAODA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PLPAHBLFLPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public JDFGNIKEHDK DNFGNAJFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public LFOPNJNFJEF GFLPCNIDJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> HCNNGAPJPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> EFPJPOBNKDH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6086080", Offset = "0x6084E80", VA = "0x186086080")]
	public Guid HEGFOOCPLEA(Guid MAAFBDMNKAP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface IGIFILMIGAO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int BFKGGHOFFAP, [Out] Guid FGHNAJOAGKF);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FLCBIKJNMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> DFLGJNAIKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> NDJKGGLEDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> HHBBHLHKAMD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> NPLBFBCCENK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> ECMENJKJADP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60819D0", Offset = "0x60807D0", VA = "0x1860819D0")]
	public static FLCBIKJNMLA EBADGCBHGFA(KLBAPEHGMHI BHDDKICEAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6081C10", Offset = "0x6080A10", VA = "0x186081C10")]
	public static FLCBIKJNMLA GNOCFIHJPOI(DFJJCJFCLFK LCNIGJDIADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6081C80", Offset = "0x6080A80", VA = "0x186081C80")]
	public static FLCBIKJNMLA KGIDIHGIIGK(IEnumerable<string> DFLGJNAIKIP, IDictionary<long, int> JIFFHJBNPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6082DA0", Offset = "0x6081BA0", VA = "0x186082DA0")]
	private FLCBIKJNMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6082C60", Offset = "0x6081A60", VA = "0x186082C60")]
	private FLCBIKJNMLA(IEnumerable<string> DFLGJNAIKIP, IDictionary<long, int> JIFFHJBNPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6081E00", Offset = "0x6080C00", VA = "0x186081E00")]
	private void MCPAJEMJFGE(KLBAPEHGMHI BHDDKICEAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6082000", Offset = "0x6080E00", VA = "0x186082000")]
	private void MCPAJEMJFGE(DFJJCJFCLFK LCNIGJDIADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60821F0", Offset = "0x6080FF0", VA = "0x1860821F0")]
	private void MCPAJEMJFGE(FMLBMMGCHNG? GOKLEGFJHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6082A80", Offset = "0x6081880", VA = "0x186082A80")]
	private void MCPAJEMJFGE(GJGPLLBOCJG? NBFOPMANPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6082690", Offset = "0x6081490", VA = "0x186082690")]
	private void MCPAJEMJFGE(LFOPNJNFJEF? GFLPCNIDJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6082BF0", Offset = "0x60819F0", VA = "0x186082BF0")]
	private void MOMMCDMMGBO(string? BDJCCJPLCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6081B30", Offset = "0x6080930", VA = "0x186081B30")]
	private void GHPFEHDPEHI(DDMJKHAPCLF? FDIFMHMLOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6081A40", Offset = "0x6080840", VA = "0x186081A40")]
	private void GHPFEHDPEHI(MNEFLAFCBBB? FDIFMHMLOCB)
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
