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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F6BAE0", Offset = "0x5F6A4E0", VA = "0x185F6BAE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HEPHBHEJFBH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly HashSet<Guid> JCHCMLEGPFB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly HashSet<Guid> MMMKHDKLGHL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static string MEPFOHANJIL;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EMDHDFIHAEM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MJDKABGKPMG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F68920", Offset = "0x5F67320", VA = "0x185F68920")]
	public static bool NELLEGHJFEA(Guid DHLCEDEOEOB, int JEEKABJKNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F68A20", Offset = "0x5F67420", VA = "0x185F68A20")]
	public static string PBNDPJFEJAE(Guid INAIFGAIEKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GEGPELKHDGP]
public enum JHIIBNNCDDM
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
public static class AAAANBOJJDK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Guid EGINBPKBKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly Guid OBEMFGDPJLM;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly Guid JPEIMOKDONL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly Guid PDKEOLOEMMM;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly Guid DFAAOGIMGCA;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly Guid ONELAHFMHCD;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly Guid PMACDIMFHKC;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly Guid KLHDNMJCLEB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly Guid BCCOKLGOCGC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly Guid LHGIAECNKIF;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly Guid DMLJNJNFPNF;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly Guid COBGEDAFGOJ;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly Guid CFFFBNOBJJD;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly Guid FFBAIJAAMLK;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly Guid HNILMEBAECL;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly Guid BFGCFKLPBAO;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly Guid FDCJPANDKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly Guid HHBHDIIJBNH;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly Guid OGMLKANPNIJ;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly Guid IAKLNAJIJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly Guid IDGPIOEIFGE;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly Guid HPIONIHNAOC;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly Guid LJIAPGIPOFB;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	public static readonly Guid LMJMLNEKFPA;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly Guid OPAIJAJJKMG;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly Guid HCMMCGKHDMK;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly Guid GLPOCGPIEHE;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly Guid KPKDDLDMCIK;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly Guid EJECJAFLGPN;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly Guid DBAFDILGKEH;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly Guid BOPPICBKMPL;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly Guid BLHCNLIKHKE;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly Guid LGKOEANCJJE;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly Guid LMBOACPGJGP;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Guid HGNAKINKJBH;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Guid FBOBNCCJCPK;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Guid NIJCAIGHNHO;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Guid GNBKMNKHHAE;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Guid PAKKGDDOELM;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Guid OFNIDHPMKNN;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Guid IDEDMOPNOBK;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid LALDAPEGOOK;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid NBFLPNBFDEH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid BMLJPOHAKHJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid OOGEHAFBOMK;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid DFOHHIAEHHN;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid PFIKCCIJDGM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid LFGBDKLHLDO;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid JHOGJGEFJID;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid ABIOGEFJKAP;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid LAIHIGHHJJM;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid APKCJDEKEBN;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid IMNPLKBMKOE;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid PKBAFDDKBKG;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid PEOPCJJAHHG;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid FNPCONBLPAA;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid LGLGHMCDNBJ;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid HJNGPIAFLCO;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid CPEJGFNFKJE;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid PNMJGGBPEJM;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid MILLEDKMCEM;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ECFEEHFKGLG;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid MNBGMDHLBMF;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid HMLPMKFCIGP;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid FPJGBGDIABJ;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid PJOJPPDCDCC;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid OEHLKHHHPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid EODMMFMIHJL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid IOAPEKKNJBF;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LHFPJHCLKHN;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid ECKEOICOEHG;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid JANNCBNKLPK;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid FJCDHJNHHPI;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid HLLFJPBCCLF;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KAEJNCCMGIC;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid LIJJGOOPMLD;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MLBIGFJMMEL;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid HOLJKFGFOMF;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid JNLHCIMDCLJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid NHLLKEGOKFN;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid ACFICKBFPEC;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid PDBLOJBAJDN;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid JHLJLKBKOIL;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid COCCAKAOKNL;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid ABIDEABCCGG;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid FOCMLAGOIAN;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid GKMICNOMJMA;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid IOMCBIFEICL;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid BBMBMOJAAIE;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid OOIABONLJPH;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MNHHPOIPOGF;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid MMEBJFLKDLP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid OKGGJPNJDGG;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid FKCHDIMKCNN;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid HAKNDOFAFFC;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid GMMJMEKKHOH;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid GHPCLEONFCA;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid FAOKNOACDON;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid NCHLNINLOBL;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid ICNGKJKFIBG;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DMEJNHDNDCC;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid FJGOCCJLGJG;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid IKPKIBKLNLH;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid LNJCJJFBFOO;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid ENFILLAJNEF;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ODNJJHMKEGC;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid GCMJOHMINLM;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid FEBCMPCHPJK;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid INKAMDAAPBC;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid CNEILBDJFLI;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid OEDELLIJGCH;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid LCIFOKNDKHJ;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid CFDGLHNGAHH;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid COMGBHLFBIK;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid NCAGHEPNHLE;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid PPIFIOFAFAE;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid HJECEFOPKBD;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PFJNGPBJBLF;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid CNOAHNFFLOF;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid IDFOHPHGCIB;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FODMEBKMAIF;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid BGJKCNNEJOF;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid APDKBDMFGGN;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid EBJINJNEOBM;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid PKPMDBLDEIH;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid ADBJFPNMPBH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid MBLKIOCCAOO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid CLLCJMBNIKE;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid GMHMLOAMCLL;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid NAJCGBAHPIF;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid JNBAOHOCNMO;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid FIGJFDOEGIP;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid GHCMAHIADBE;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid MNDHAFLCOAH;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid ALNJBLPJNKF;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid PDGECILIHNF;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid NJKMMDLJPPO;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid OMPMIDCLAJN;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid BGLEFLDKNLG;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid JBFKJDGHIGE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid IMOAMHMFLGN;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid AJIGFKDNNOD;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid KEMDDKNIIGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid HAEELOKKMAN;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MNCNLLIPGGH;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid BKCEIDBBHKB;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid JCJJLMANFCD;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid GFLDPCDFLEB;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid DHIMIEIJFHK;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid FAMKDEPIDCC;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JKOPOALMIFO;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid EGHJCBBBMJP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid AHIHDEIHNFJ;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid ADMJJPMJJGE;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid CCCMPNCAOEB;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid FONBBNMHGDD;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid GHHJBNNHJCL;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid JJJMGNIEAIK;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid EFFOBICCNCI;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid NEMMJAMOHCH;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid FFINMOOKDKH;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid OCDFOIGEECC;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid PBIMIDJGAFI;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid KANDMGAJJDC;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid AKIGONEGABG;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid LEFJPIMIAGP;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid AIOEJJDGIBC;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid NMBBBMMPBDC;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid KBBONBAPGPB;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid COJAAJDMPGO;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid HCGPFLPKPKP;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid BGFBFLLNNNC;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid HHJIOPBKGLL;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid AJAJLBPCOIM;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid DBJBENGKLLN;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid JCLDNJOMFEM;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PJLNHGAFGJL;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid ELBBMPCKMLG;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid JLIAFKCPHPN;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid CFFOOLNOAIH;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid BJCINFMKBKK;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid CDDONPBIOBA;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid HGKAALKBAMH;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid CDJAIDBJJGA;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid JLDLBDNDBHL;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid FJNGJELAPND;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DGMJBDBDGDJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid EPJNKCCCNCE;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid EBAFKGBCIFM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid KFBELLOHJCF;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid CPFPFJNIFFE;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid BLLGNBIDOML;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid LNCPKBJFOJH;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid JMOHJJMELGB;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid FCLGFABMEDP;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid FHPHBJCNBCK;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid PNECHJOJADN;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid BMDIKNPKPKL;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid CEMFBIOPIMO;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid JOCIDPEBPCP;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid HHICBMDNLBN;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid CIIPFOFICOK;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid CDILALFIHFA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid GEKJANNGANJ;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid DICMLOIALDE;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid FNCKONFHHPD;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid HILMELJJIAE;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid NBFNCEPCLKM;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid EFGHHIPBBOI;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid JMGHAPCFKLK;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid PJOHGCCMFBM;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid HCOFPIFAGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid HJOLAFDLBCD;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid AFLBHOKMAKO;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid MFNEHJJDPMC;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid OELIOHHJFJA;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid GEMPLLJMPAP;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid IGMKHEKCBDP;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid BFFJGMFGLCM;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid IKPFIFIEKGA;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid IEJABFJIPMH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid KEJDDGCKJKG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid JLFIGFIGCNC;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid IGMPJEPEIFG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid JLGFHCHBDEG;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid OGLNGLIIOKO;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid LDLKJCLKACG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid EECKEMPJDOB;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid CALAGAJCHLE;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid GKOBCBOPFIG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid IDNGNMMGCGB;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid EAHEKILMPMI;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid BFAMLFEIFBO;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid MJECBJPMDGH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid KEJBEFHFGGJ;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid FBNPABFNKEK;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid INGDMPKEMFB;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid HDHNDEDHFGD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid NOFBGJMNFJB;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid PAAGIAMOHMH;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid KMEDELIFFGB;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid HMKBLIHCKJD;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid IPIIOENCKJL;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid GIHBEFCHHAM;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid BCPJADBLPKB;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid IHOFMDCHNIC;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid DFFBDOPMPHM;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid JDGPKBGHEPF;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid BEEAEFNGPPI;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid IOMAHEGNDHM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid AOJGAAMEFNO;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid NDJAIBGPBBN;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid PNKPJCJFMGI;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GOJJLCMHEGK;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid PLCKFIGKPNF;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid EFKJIKEOCFH;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid KMHIHEKPBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid CANAOFDNLKO;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid PANCDBPCMPG;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid CEECJFDEIJD;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid CKDGICIECBI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid IEDOMJIPLJG;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid MFEDDMGFMJA;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid LIDJFJMPBHO;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid NNBALIMKLNA;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid GMLDAGGCGIL;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid GNOLMCHJJHC;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid AAPFCPFAIKO;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid FNIHCOIFCBG;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid CFFAGELMMGB;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid FNHMBKJEPCM;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid BCAIFCOHCGM;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid LIIOHDFCIJN;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid LEJJHNEFGIL;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ICAFDMCCEHB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid JNEOGGLODIK;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid IEPMECDHOGH;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid OPAPKLEAKLL;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid MNCJKDKGPKM;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid EGMCEGIIHKP;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid PAMOFLKKONB;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid MOBLJLIIGHM;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid GEMFMLFGHMF;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid DBKEDHEBLCC;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid HGBFMBFKFOH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid ACOGBIFHJNC;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid CGIBGODDCLL;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IIJAEBPFJMI;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid NLCGKPMGABJ;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid MDNMDNGDNJN;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid FIGMBIMKLLK;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid AGBIPOMIPGE;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid PJPDFGFKJLO;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid CDONNNOGPBK;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid DCFNAJPKCAM;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid BFINCNGBFPF;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid MGGCHFAAPEL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid FGNOLKFCGOO;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid NNAGFOIAFLH;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid ODCBEOOAHDA;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid KEGNJLGILKG;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid AGIPNANIEOM;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid GGLCIOHMJIF;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid IMLDAHOCOLB;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid OHHLENCLJNE;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid MEJCGJOBKKC;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid EEMNDBIBJCB;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid JDNCEFBLHDF;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid AKBIPGDMGAN;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid KMLFNDPBHBI;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid GKNBFGIIDFP;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid AFIGFDKAMCN;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid ENBEGDMPAEI;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid HLKBACMGEGP;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid PEOADAPLFIO;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid BDBHCOHJOIB;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid INFABHDIGFF;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid HPOOHOBOKPG;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid OHIIHFBELCG;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GGCPMAOAGHK;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid GJALKJPCNCH;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid KKDLBNHMCLK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid ANIEHMGBGGI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid AEPJMBMEMEE;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid CDIMIKDKKIM;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid IFBGBGEEBDG;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid GCEDOHGDFLH;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid NGCDCGNNHCD;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid EFEAPMMHJBL;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid DOJENHBBPJH;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid IJDBGBCBENN;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HLCEAJFANPO;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid MOJBDNJENBC;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid AFIDKJLOEGN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid PIKIPFOIICH;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid LBEBJFFCIGL;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid OEKPFNAOJCM;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid DOBEPFHAPAE;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid LKDAGCBLBLI;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid PEPGPDOLHCB;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid APMFFPIBILO;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid CNPMPFDMKOB;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid EKAPHODFHAA;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid FIGJMGLLJJJ;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid OMJJLOMKIGP;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid KHALOLCDEGH;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid KAFDIPCPILG;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid BJAGIDJNGHG;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid EOENJCALAPM;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid IFDKDPGNHMB;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid PFFLCFOJDAP;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid KIFKJDKAHGL;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid PDPCIOJONDO;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid LLMEHGHONEM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid MPDMCJCPKDE;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid AGPFKOJANLF;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ECIOKKEIILH;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid JLIJDCILLHB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid GLHKKGGGOFM;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid CCNNFPMCLMF;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid BHOIIAFKJMC;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid NMGOIMGAKBH;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid BFFJKKLJAKE;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid LGAIPLMBCED;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NMPMMHGFAKC;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid MOPHGICKNAL;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid LFCMGGAEHAE;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid ONHFPBJBMHN;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid LDEPEHGGAGA;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KAIJJABKMEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid LLLALBOIANO;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid IHLEEJNKJMK;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid HFOPHHGNEJP;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MMBCAHILLFB;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid HFDGLPNJINB;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid GKFKBFHHEHK;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid DBBGKJKEEDM;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid CNJJCPKAKJC;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid ELIPLHOMPNK;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid EGNHGCOCJGP;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LIPDNEDKJHL;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid GFFKGDDOLBD;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid MENJGHEMCKA;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid ABEJMMPJKDA;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid PNEMAIFKKFM;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid HOFLAKPJIJA;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid MCNNALGKHBF;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid JPELNOGPBIJ;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid BIPKHMDCNIF;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid EIDBHKKANBP;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid OEJDIKDFHPD;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid EBOOKEFLPIA;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid OIHPNNLPCBK;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid DLJHGBHGION;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid ANLMLEFCBID;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid MPGGNMGNOCB;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid NCNIBLGBBJI;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid NDHABOBDBMM;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid KOCJKBEBEEA;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid CNJEIOIKEMG;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid DKBHBODIJNL;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid IDALBMCOHBO;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid HJODKPFDLDK;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid COHOCIIEBKA;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EIEOEHLKONH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid OHPNFAKGGOJ;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid OALEIHECJDA;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid DLEEGGOJDCG;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid AELAOAIDBDC;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid MJDDILFFOGN;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KBMAMIOEHEF;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid PJIJMIJHMJK;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid CCNKOFLBLCP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid KPJHLNLPBGI;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid KEOENJEOJOH;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid CBGOHCADBMO;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid OHKCELGJFCN;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid BPPBJMEDAMD;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid DCCGFGGIEEI;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid BKKFMLKPEBA;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid CNFACJDNFGH;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid MAGPHAODBAO;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid FOHFNHOKHIO;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid JDGKMJLANPL;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid GHLFAKPMPHJ;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid LGDDJGEJOED;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid JFDPOHENFHK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid GHNNBKNPOCL;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid KEPHJFJEDHL;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KBGEHEGGNFL;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ENILNCEGFHO;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid NHGPGBLGNMI;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid JABIJLFNDNH;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid JBIOEJLIAFC;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid GEIHDGPFADO;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid AEBCIAMALFO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid KMKFMKKLEDK;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid IMGHJIPFDGP;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid KLDKJIHBMCK;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid DHDGENOJODJ;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid HFDOJLFCBLD;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid MOHFNAPAAOH;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OAHHGLBMKNN;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid FMGHKNHOJEB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid IEEIPNNAHKN;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid ACBJKHEOHIP;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid HOGHNDBJLEG;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid HKHBDOPIECP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid HHLHAFMINJH;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OLPFNGLNDLF;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid HIFEPHEAAIA;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid CJLGKDKAOEI;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid GKGEJNHNGKA;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid IJJPIOLGFLP;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid JCAHMMLMGKN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid EAIHIJHMKLC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid NONFFMHEJCE;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid DGCOGPHLLBC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid IEHAAANAJJI;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid JPAOAJOOHMD;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid JKIJJHOPLCE;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid CBDEEMKFHHN;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid LHCFPDFCLDK;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid NLJNLHLHFIA;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid LOGNOBIDLFH;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid DELEKMDEKLF;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid FGMGBNADNJK;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid BLGNMDJMPAG;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid LFDDHLBADPC;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid OGJFFPDLKOF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid KDLHBGPCHKL;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid OHGJIABDMMO;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid GGDPBCJGPCI;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid LJEEAHFHGCJ;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid CJEMLALMDBP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid KNDLJCGLOIL;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid PNDEOIAABBE;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid KGPEKMMNBGH;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid ABMOAONCBKB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid JHMJLHGLNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid CJHAMFIMHGP;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid LBLGGIHNKFM;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid PFPCPJCCLBD;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid GIAHIGOFCHI;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid LCKDOCMDCDL;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid KAFLFKILGMG;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid MPIIPNFBABA;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid EPNDMCILLEL;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid AKCLJOPPLDN;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid ELFLAEGJEDG;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid IDNDMMEJCFJ;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid FEJDFMEBKBE;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid OLBGENHBENJ;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid OBENKJLGLAO;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid KHDMJCPJPJA;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid CNDMACBHGLK;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid HBIBMEPKDBP;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid PALBMDCHDPC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid JFNLHKJKGNM;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid GEBEOMFBMOA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid HELCMODCDJP;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid JKKCOOGHIGO;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid DJCPKHLAFCI;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid JCACMJNBLPF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid JONAKIINPHA;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid DOLEFCONAOO;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid AECFJPGEEJN;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid AIILKFBPGNF;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid EIFMHPOOBJJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid OCNKPPJPNCN;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid FDILHPMEEFG;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid JDHGEADHJFB;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid INFEMNJLEEE;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid AFMPEAOMINI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid JFKKLNJKEOO;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid IENIFKFDCDI;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid ABJAHIEHKDC;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid FCCCOJFJKFO;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid CADIIIGIFGL;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CONCKLADKML;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid LIHGDDPOBIL;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid KHGAKOHGOBD;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid FNNHFJPHEIJ;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid PDMELPIIBMN;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid OFCDJNPEKEJ;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid EFKONJNCKLK;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid DHPBMJAMECC;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid NOAMHKANCML;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BFDMKGEJGMN;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid LBHIMAFLNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid OFIFEEAIKFD;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid EIIBGCJBMDH;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid NPHBIMHHCMN;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid EHNHMIGNEKF;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid ELNENNEJEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid AKMIAHAPJON;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid PNIENKLELOC;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid GEGONIAMHIB;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid NJCCOJABJMB;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid PDKNLNCOPAD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid CIPCNEAOEFE;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid ENEDCJNKLKL;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid GAFJCBMBMLO;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid AINJMJMGFHP;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid HELIKEAAFOL;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid FDCFAOPKIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid MJENPEDAJGF;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid ANKNNJJIMJI;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid ECLABOBCJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid NHOCKDKOLHF;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid IKCGAEKMDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid CCBMGIHCEKN;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid BKOHKABCKBJ;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid LBEMIIAPPBG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid JGJFAFLDBHM;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid BHEOBCIFPGA;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid BLONLMKHABN;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LPGGPLHLGEI;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid LOICKFAEDEM;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid MFAFCGHLFKL;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid JNJIMDOJION;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid LEMPOEDIPGN;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid OEGGBKKOFPO;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid OIFHHMIJCDK;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid FIEAGCILIFM;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid JOABPMCKHKG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid CBKOLKIHMPA;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid GIIKPBDKGMH;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid LPCKKJCGHNG;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid EODMMNAKCHH;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid DCKGPLIKLGM;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid CNGOEMJAIDI;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid OLOGMNNLBNP;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid BGEJMPEOBDE;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid FLEANIKCONI;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid DBEOJMAHKOG;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid GFKCHDKNPML;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid GLCPAMIDCKC;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid HDGAKPONGEL;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DOKMPCKBEPH;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid OGGDHMMOAIK;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid NGHPPDOMPOD;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid CGFKBLNLGEP;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid ANHILIHONGO;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid OMJHJIDLLPN;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private static readonly Dictionary<Guid, JHIIBNNCDDM> BPLCLNPGLMP;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private static readonly Dictionary<JHIIBNNCDDM, Guid> OFELBFIFOHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, JHIIBNNCDDM> CACCKOILNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F62720", Offset = "0x5F61120", VA = "0x185F62720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<JHIIBNNCDDM, Guid> NMEGLAKAGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F626C0", Offset = "0x5F610C0", VA = "0x185F626C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CEGPLCEMDDE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F63040", Offset = "0x5F61A40", VA = "0x185F63040")]
	public static bool GAHBMKNNDIH(OFENKDFPGPL ADCJHMDPJJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F63070", Offset = "0x5F61A70", VA = "0x185F63070")]
	private static bool GAHBMKNNDIH(DMNCNCGHJGF HLLJNBMNEIN, OFENKDFPGPL ADCJHMDPJJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ENMAEJLBCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public readonly APAALMMIDKA NDAEJLNMKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public readonly IEnumerable<NEEDBNPPDKD> DOHPCCIFDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public readonly IReadOnlyList<NEEDBNPPDKD> EMOJGOCADCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public readonly JLGMECJOLDI<BIKLLPOLGEF> IIINILHEGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public readonly IReadOnlyList<JGKGEKHGJKB<PNMLFKAJNIK>> OPNHDKKDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public readonly ByteString AKGPGLKJDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public readonly KMDIJJHPMKL LCCEBKJAACE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F63DF0", Offset = "0x5F627F0", VA = "0x185F63DF0")]
	public ENMAEJLBCIN(APAALMMIDKA NHDMFLIAHJE, IEnumerable<NEEDBNPPDKD> NJFPPBLMKHP, IReadOnlyList<NEEDBNPPDKD> LDNDKPMLEBD, JLGMECJOLDI<BIKLLPOLGEF> IAONMJHKCGE, IReadOnlyList<JGKGEKHGJKB<PNMLFKAJNIK>> ABDACOMEDCJ, ByteString OLHDHKMBPNF, KMDIJJHPMKL KPNPBJJKALE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BLPHBBCBHAF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JDOBICHLIBG MFNOAEFOKBK, [Out] Dictionary<int, int> EDBHGNANCGC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KHNJGFFJIHB PAIMJLHPFFA, BIEAPHKLNKI JEOOKFJJAJE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LPAGPPDJDCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public readonly Guid FNICOCEDJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly Dictionary<Guid, Guid> MGLMBOBCCPM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> PHFLOEOPCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34C4220", Offset = "0x34C2C20", VA = "0x1834C4220")]
	private LPAGPPDJDCN([In] Guid IBKONICOADH, Dictionary<Guid, Guid> HNEBAIMGNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B720", Offset = "0x5F6A120", VA = "0x185F6B720")]
	public static LPAGPPDJDCN LNCGCICCBOD(IReadOnlyDictionary<Guid, Guid> CIJHJKBKDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B730", Offset = "0x5F6A130", VA = "0x185F6B730")]
	public static LPAGPPDJDCN NNAGEAJAGLD(IEnumerable<KeyValuePair<Guid, Guid>> CIJHJKBKDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B670", Offset = "0x5F6A070", VA = "0x185F6B670")]
	private static Dictionary<Guid, Guid> DOMLLIODOHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B560", Offset = "0x5F69F60", VA = "0x185F6B560")]
	public Guid BGLKPAKIODD([In] Guid INAIFGAIEKH, bool DAOOFLGIBID)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B4F0", Offset = "0x5F69EF0", VA = "0x185F6B4F0")]
	public bool AMCCHFJLFFM([In] Guid PDDHPPHOJPD, [Out] Guid DNKJGFNAEOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJCHGJAMKJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DGMFHIGLCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFFCBAMFOKP(ByteString PJMNJIAJCCH, LPAGPPDJDCN FLHPEMKANCN, [In] HJCCAGLBLFO BNEPNNLMPBG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GHEIKLPNLIL
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
public sealed class KDHNOMLNCHO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<Guid, Guid> CLEFCBAPKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<Guid, Guid> CLENPEPNEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
	public KDHNOMLNCHO(IReadOnlyDictionary<Guid, Guid> IOLGNLONOGG, IReadOnlyDictionary<Guid, Guid> OMMEKJHMIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HDIILJICGBG
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F680B0", Offset = "0x5F66AB0", VA = "0x185F680B0")]
	public static PPHKBHJMEHL JGBNAKKAILE([In] ENMAEJLBCIN ELHJIMMNLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F682C0", Offset = "0x5F66CC0", VA = "0x185F682C0")]
	private static void MFNGPCNGMMO(PPHKBHJMEHL IBFPDPLHIAO, [In] ENMAEJLBCIN GGPHDAEIMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F66A30", Offset = "0x5F65430", VA = "0x185F66A30")]
	public static bool HKBLFKHMGOJ(PPHKBHJMEHL IBFPDPLHIAO, BFHOHAMMFGK EPFANAGCDLH, LPAGPPDJDCN? FNPOGLNNHDJ, [Out] KDHNOMLNCHO? HNEBAIMGNAF, [Out] string? JKDHCOHJJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F65670", Offset = "0x5F64070", VA = "0x185F65670")]
	private static void ALNDBLJMAED(PPHKBHJMEHL IBFPDPLHIAO, LPAGPPDJDCN? COLHDCDFPBJ, BFHOHAMMFGK EPFANAGCDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F65BE0", Offset = "0x5F645E0", VA = "0x185F65BE0")]
	private static void CGCEPHEAHCA(PPHKBHJMEHL IBFPDPLHIAO, BFHOHAMMFGK EPFANAGCDLH, IReadOnlyCollection<ByteString>? IHCLNOBGGKI, IReadOnlyCollection<ByteString>? DDHFLHBILEG, IReadOnlyCollection<ByteString>? CMHONKNGCHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F65C50", Offset = "0x5F64650", VA = "0x185F65C50")]
	private static bool FEJOCMEEPKK(PPHKBHJMEHL IBFPDPLHIAO, KHNJGFFJIHB PAIMJLHPFFA, BFHOHAMMFGK EPFANAGCDLH, [Out] string JKDHCOHJJFE, [Out] Dictionary<int, int> EDBHGNANCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F65900", Offset = "0x5F64300", VA = "0x185F65900")]
	private static Dictionary<Guid, DMNCNCGHJGF> BBHAHCBIBHH(PPHKBHJMEHL IBFPDPLHIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F68220", Offset = "0x5F66C20", VA = "0x185F68220")]
	private static void MEDCIAPABCL(bool OBKOCIHLFKG, NEEDBNPPDKD GKOAKJGNMLA, Dictionary<Guid, Guid> FOMDMJCBKIL, LPAGPPDJDCN BHDPPHGJDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F667A0", Offset = "0x5F651A0", VA = "0x185F667A0")]
	private static void HHCCGNEBDKE(NEEDBNPPDKD GKOAKJGNMLA, Guid AMHILLKCIHF, BADCMLILDDC? NLBOCHPFLGH, Dictionary<Guid, DMNCNCGHJGF> IDBHKGEKJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F662F0", Offset = "0x5F64CF0", VA = "0x185F662F0")]
	private static void GAIAGAPMOEJ(IEnumerable<NEEDBNPPDKD> IJECIMPMGAG, IReadOnlyCollection<ByteString> IHCLNOBGGKI, IReadOnlyCollection<ByteString> DDHFLHBILEG, IReadOnlyCollection<ByteString> CMHONKNGCHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BFHOHAMMFGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public bool OBKOCIHLFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public KMDIJJHPMKL KPNPBJJKALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public BADCMLILDDC? NLBOCHPFLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public BADCMLILDDC? GFEBEFNMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public APAALMMIDKA IDPPDBMMJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public GHEIKLPNLIL BGKJHPNNMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public BLPHBBCBHAF HDBIMHGOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public EJCHGJAMKJK ODMMCBGMPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public JGKGEKHGJKB<BIKLLPOLGEF> AOIDNFEHPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public BPPMJABJILE DMGGOKCBGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public List<NEEDBNPPDKD> EEMFLPJJJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public Dictionary<string, object> GBFHIDPKAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public FIGDEDFGLLI HOLFAHFMDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public bool HINOGGGKGLG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OCJLIKKPCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F62FF0", Offset = "0x5F619F0", VA = "0x185F62FF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BADCMLILDDC
{
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const float HNOBJPALFNA = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public Vector3 HGKJDOIPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public Quaternion PGPLGEJKHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public float CMIJAKFGAEH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Matrix4x4 OCKKJONNMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F62BD0", Offset = "0x5F615D0", VA = "0x185F62BD0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HJCCAGLBLFO NEBAFICOCJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5F62900", Offset = "0x5F61300", VA = "0x185F62900")]
		get
		{
			return default(HJCCAGLBLFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9391B0", Offset = "0x937BB0", VA = "0x1809391B0")]
	public BADCMLILDDC(Vector3 HGKJDOIPDNM, Quaternion PGPLGEJKHLI, float CMIJAKFGAEH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F62CE0", Offset = "0x5F616E0", VA = "0x185F62CE0")]
	public static BADCMLILDDC NAKMHAFPIPA(BADCMLILDDC BBCCHMIJNJG, BADCMLILDDC AFKJOCJIOPA)
	{
		return default(BADCMLILDDC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F628E0", Offset = "0x5F612E0", VA = "0x185F628E0")]
	public static BADCMLILDDC CPALPDKLBCM((Vector3, Quaternion, float) MFNOAEFOKBK)
	{
		return default(BADCMLILDDC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F62780", Offset = "0x5F61180", VA = "0x185F62780")]
	public static BADCMLILDDC CPALPDKLBCM(Matrix4x4 LMCFKCFFACO)
	{
		return default(BADCMLILDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F629B0", Offset = "0x5F613B0", VA = "0x185F629B0")]
	public BADCMLILDDC IIAEMDHIGFA(Matrix4x4 AOOGIIEBLDG)
	{
		return default(BADCMLILDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F62940", Offset = "0x5F61340", VA = "0x185F62940")]
	public static BADCMLILDDC FKFDOFECEIF(Vector3 HGKJDOIPDNM)
	{
		return default(BADCMLILDDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F62F60", Offset = "0x5F61960", VA = "0x185F62F60")]
	public readonly KIAFDOMBGOF NFCFDCEEJFJ()
	{
		return default(KIAFDOMBGOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CPNFDPCNEGK
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F63420", Offset = "0x5F61E20", VA = "0x185F63420")]
	public static BADCMLILDDC CBDOHNHDMBK([In] this KIAFDOMBGOF NHHBAHIFHJK)
	{
		return default(BADCMLILDDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EFIEHENMJBC : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F634B0", Offset = "0x5F61EB0", VA = "0x185F634B0", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F637B0", Offset = "0x5F621B0", VA = "0x185F637B0")]
	private void NJOADBBFCEP(Dictionary<Guid, Guid> AIGCNNFGACN, ANAJMFAEPKF HOOBFJLCDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F63D90", Offset = "0x5F62790", VA = "0x185F63D90")]
	private void NJOADBBFCEP(Dictionary<Guid, Guid> AIGCNNFGACN, JAKJDODKKEJ JBNKCOAFCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F63530", Offset = "0x5F61F30", VA = "0x185F63530")]
	private void NJOADBBFCEP(Dictionary<Guid, Guid> AIGCNNFGACN, MBJAHFLIGBH ELDMJKGECIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public EFIEHENMJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KFICNPBIJOH : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F69E60", Offset = "0x5F68860", VA = "0x185F69E60", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public KFICNPBIJOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PODFONIEOAP : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BEA0", Offset = "0x5F6A8A0", VA = "0x185F6BEA0", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public PODFONIEOAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class FHODEAGHPOI : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F65220", Offset = "0x5F63C20", VA = "0x185F65220", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public FHODEAGHPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class JAAKMLPGLEE : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F69A80", Offset = "0x5F68480", VA = "0x185F69A80", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public JAAKMLPGLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GDGKGBONCCK : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F65530", Offset = "0x5F63F30", VA = "0x185F65530", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public GDGKGBONCCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class OBJHNOCOOLO : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BB60", Offset = "0x5F6A560", VA = "0x185F6BB60", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public OBJHNOCOOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class OLAEKFPLBCI : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BD00", Offset = "0x5F6A700", VA = "0x185F6BD00", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public OLAEKFPLBCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class JBKMOBKJFEC : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F69CA0", Offset = "0x5F686A0", VA = "0x185F69CA0", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public JBKMOBKJFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class FNBEGIEHICO : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F65370", Offset = "0x5F63D70", VA = "0x185F65370", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public FNBEGIEHICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class KLHHCIBKABG : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69F00", Offset = "0x5F68900", VA = "0x185F69F00", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public KLHHCIBKABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class FBBHICMCKOP : FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly OJFMLPFCHHH JDMICEPCAHP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5F63E80", Offset = "0x5F62880", VA = "0x185F63E80", Slot = "4")]
	public void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public FBBHICMCKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OFENKDFPGPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public KHNJGFFJIHB OMDPMMKPCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public GOEODLJAHJB OGPBCONHMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public Dictionary<int, int> AMNMKICAHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public Dictionary<Guid, Guid> MJMAMMJNFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public FIGDEDFGLLI HOLFAHFMDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public bool GOEPFHPEIFG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FIIFEMDMFMH
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJBNHGKJFOB(ONLAIHKCGGG MOEFCJDHOBB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FBKGDAHGLME
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private static readonly FIIFEMDMFMH[] KDBEHNGMCBO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F64310", Offset = "0x5F62D10", VA = "0x185F64310")]
	public static void EJNNPIPGLAJ(NEEDBNPPDKD MFNOAEFOKBK, Dictionary<Guid, Guid> AAFNLMENGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F63FB0", Offset = "0x5F629B0", VA = "0x185F63FB0")]
	public static void DAFOBKHFGNN(NEEDBNPPDKD? MFNOAEFOKBK, LPAGPPDJDCN EPPPHJIBDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F64970", Offset = "0x5F63370", VA = "0x185F64970")]
	public static void PBMIDBFBGMM(NEEDBNPPDKD? MFNOAEFOKBK, LPAGPPDJDCN BHDPPHGJDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F645A0", Offset = "0x5F62FA0", VA = "0x185F645A0")]
	public static void GAHBMKNNDIH(ONLAIHKCGGG MOEFCJDHOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ONLAIHKCGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public KHNJGFFJIHB FPDPMPLJLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public NEEDBNPPDKD GKOAKJGNMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public Dictionary<int, int> AMNMKICAHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public Dictionary<Guid, Guid> MJMAMMJNFDP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BDF0", Offset = "0x5F6A7F0", VA = "0x185F6BDF0")]
	public Guid CMMBAOPCMNG(Guid INAIFGAIEKH)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface FIGDEDFGLLI
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int LPPHPKNCHJD, [Out] Guid BLOINJLJNBI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LLJHOMDAIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	private readonly HashSet<string> BLOGPGNOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly Dictionary<long, int> INMOOLAKFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private readonly HashSet<Guid> OFINDJPBHFE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyCollection<string> GABFINDOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, int> IGLNHLCEABJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B220", Offset = "0x5F69C20", VA = "0x185F6B220")]
	public static LLJHOMDAIPF MPCJLOGMECO(JFMKOBKPDPB ILKGBPMJIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A180", Offset = "0x5F68B80", VA = "0x185F6A180")]
	public static LLJHOMDAIPF ECDOMMAOKPO(PPHKBHJMEHL HCEMJKPODKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A000", Offset = "0x5F68A00", VA = "0x185F6A000")]
	public static LLJHOMDAIPF CHGMBEOKIOF(IEnumerable<string> BLOGPGNOIHA, IDictionary<long, int> JNPEBKEPIDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B3D0", Offset = "0x5F69DD0", VA = "0x185F6B3D0")]
	private LLJHOMDAIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B290", Offset = "0x5F69C90", VA = "0x185F6B290")]
	private LLJHOMDAIPF(IEnumerable<string> BLOGPGNOIHA, IDictionary<long, int> JNPEBKEPIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A7B0", Offset = "0x5F691B0", VA = "0x185F6A7B0")]
	private void KMCJBJKHION(JFMKOBKPDPB ILKGBPMJIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AFC0", Offset = "0x5F699C0", VA = "0x185F6AFC0")]
	private void KMCJBJKHION(PPHKBHJMEHL HCEMJKPODKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A9B0", Offset = "0x5F693B0", VA = "0x185F6A9B0")]
	private void KMCJBJKHION(KIIGMFKIPLN? LMAHFBOHCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F6AE50", Offset = "0x5F69850", VA = "0x185F6AE50")]
	private void KMCJBJKHION(ENHCHOGMCKE? JACJPEOECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A3C0", Offset = "0x5F68DC0", VA = "0x185F6A3C0")]
	private void KMCJBJKHION(NEEDBNPPDKD? GKOAKJGNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F6B1B0", Offset = "0x5F69BB0", VA = "0x185F6B1B0")]
	private void LMNGBGODBBF(string? EFDOONEIEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A1F0", Offset = "0x5F68BF0", VA = "0x185F6A1F0")]
	private void JHPDLCBPKBG(DDNNDJIEGON? DNPCINMMFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A2D0", Offset = "0x5F68CD0", VA = "0x185F6A2D0")]
	private void JHPDLCBPKBG(BHNFDNEDFBH? DNPCINMMFOO)
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
