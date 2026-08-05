using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.Mathematics;
using Unity.Collections;
using Unity.Mathematics;
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x685E810", Offset = "0x685D210", VA = "0x18685E810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPIEBDPFKMB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> PEPJBGJFICI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> BNJDNPBIDGN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> OCKIDFCIOOG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string IMECGLGAGOO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string BCMHPNGIFDI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string FBBFNOAMMKO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6842CD0", Offset = "0x68416D0", VA = "0x186842CD0")]
	public static bool OEGLGLIHBPJ(Guid EJELBIAEGMF, int CBBMHKJBPJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6842C40", Offset = "0x6841640", VA = "0x186842C40")]
	public static bool LMOHOLPEHHC(Guid EJELBIAEGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6842570", Offset = "0x6840F70", VA = "0x186842570")]
	public static string LBLLPLHPMML(Guid JCMDDLFAGEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[POBIOMMNIGM]
public enum KGMPHGPNPFE
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
	DORM_CEILING_ANGLED,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DORM_CEILING_FLAT,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DORM_COMMUNITY_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DORM_DESK_LAMP,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DORM_DRESSER,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	DORM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	DORM_FLOOR_TRIM,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WOODSTACK
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ILOHBDMJDDC
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid MMCKAPCABCJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid CJKBIDDBJIC;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid EOPJDHINIIB;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid JOJKOCAAGHL;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid IKKEDBPDCGA;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid MMPHCCLHAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid PMNMDLLBFOC;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid MIKJIGEKGHD;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid NEFKBHHFCKA;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid FHPDKNKBICP;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid KKJLHPLDIOK;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid NONFPKICIFD;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid OPAIHINJCED;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid CKOPEDKAHHJ;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid HHDAIOEMENM;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid GCNLOEEEOKO;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid JBLGAIIPFJB;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid FIAKOLDMNOH;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid BFCEABMODKA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid GHFIBAOHHHL;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid ALJELMPJKDN;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid ELJOBEKIONL;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid MCCBCIHJFKH;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid OMEGELLEDIG;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid HHEKIBHPBLA;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid HEEGKMFMOBN;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid HJJBFKIHPEN;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid MHKGIGMBLDH;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid DPPIEFNGBIK;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid EFOGFFFNOFM;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid CLDGGKCPEAF;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid CFNNBBGFBHO;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid HHCOHEDNDFK;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid HEDMNIHKLLP;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid MIFFHADIBCH;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid GPNCHAIDMDG;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid IDDIMOIPFBE;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid CMAFCKFAFGH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid ALIGHEMLLHA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid LNEEHMOGBNB;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid DEDMKKAOKDB;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid KOFNNAMEMEK;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid DHKAGFNNMIC;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid NPFOJEPGGIJ;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid PGAPFFGMALM;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid AKIBAPGEAHM;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid PPHNAEGINIA;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid PKIAIPKBOAP;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid CJCPACNLLGO;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid MPLDANDKPHD;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid BIGPJODMFOP;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid CONEHJKENPN;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid BLIPLPFMLJC;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid BIICNDMNOOF;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid CKMFFAIDOPK;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LLAOCOHJLKL;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid JNIGPMFFLPA;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid HEALHDOAEED;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid BNPAPCACNOO;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid NCCHMMPLJBH;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid AKLDOKPIIEM;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid HDOOKPOFOIL;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid AMEGLHBEMEG;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid PMKFFOFKBBK;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid ILGAJBMMPLH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid CGPJPMCBFIF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid IPJACKBLNIC;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid NJIPBIGEONE;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid HIHGOKHBCFO;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid IDAEKIODKBC;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid EGOFIIKDJCP;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid FAJDJNHAKDK;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid HECFDCNKGGB;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid GNKLDKBBOGH;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid JFLJKBKBPKK;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid JKOLFDHIGOO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid KPLEOEFJMMK;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid AOAHAJEKCFH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid IMEOHGBGKLI;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid FIAODBHBJDK;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid PFIFBFDHGMB;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid EPOMNBPGOIJ;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid JIHAJMKIHEF;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid IEMMJDNLFMG;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid DHCPLHJFDJA;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid JNFJIEGOBFN;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid KDDODFGKLDO;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid BGGCEJGKOOL;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid HHBNDLAHOGK;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid NDMJNPFKCMA;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid EMCJBKOALLB;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid FJPKJDJEMFD;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid FKIFJPGPHGB;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid HNAPAJLANFO;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid NBBFBMAALMM;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BPFLKEADKPN;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid GBBMHFONJNE;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid CDPOBIOCPPK;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid NBDPOMMNENE;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid GHAAIPABAKP;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid FBKICOBAAAE;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid JCGFDBNGMFJ;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid PDLDELBAPHL;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid DPFPKPPPOME;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid CIJPHAGLNJA;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid MKDOMEJNPOI;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid BCIHGOBPBKJ;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid DJBJKGGIHEA;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid OJGJINDJLDG;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JKLMKNHEKNB;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid AMJLJLOBGOG;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid HLHBJDIKKEB;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid MANGJPDJDPH;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid NAMEILGFHOK;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid DBAGJKKMNGA;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid PCCJAGEANEK;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid KAPIKEPGGHK;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid OCDECJGPIFJ;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid KCKJPHAFFBE;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid BNFLKBMGNPO;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid FDKOBELGDPA;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid LAELMLBMGNG;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid JIBCLPKFOCJ;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid KLLGCJFDBNF;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid ILFDGDFGJHO;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid ANLMNOCIAOK;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid GJFIHFJBCJK;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid NFFIELCKGCI;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid FKKJKCCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid MCMADPANGNH;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid APDGMNEDODK;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid KMBBOOMIDGO;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid NGODAJBCGPE;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid FIKHONDBJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid EJCLLMFIFPH;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid GEPNBGNGFDF;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid FIFHBPMBPCJ;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid IMOLBPPGKIP;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid HPLLJNFPJLG;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid NPLIJFBALHN;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid JEEFPJHKDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid CBODHEPHLLK;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid CJIOPBIJEJJ;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid IHCCKELCEBJ;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid HLJJLIAFLMO;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid DBCHFGEOCOJ;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid BOBOCNGHBFF;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid PKDDNEEOKEL;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid KJJBOPNONLG;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid PEKFOKGFHAA;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid NCKHBBBGDGD;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid EGMBIIMJJGN;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid JLBLJKJNKMK;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid MIJEEHGJPAF;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid ELGBEGBHKMN;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid HGONMEMFHMH;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid BOPAJOJNJHL;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OMCCDHIKFFN;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid FLHMOPMBOGL;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid KKICCPFCEGB;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid FHFLJAMGCIF;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid BDEJLEHPJMH;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid KPNEGKKPMJO;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid KMLGMLJINGH;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid CONBHEEOAIO;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid KMMPDJKGNNP;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid JGIPGNJHOIK;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid CILBIMOGFIE;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid PCLNLCAAMJB;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid LKMFGLLCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid HFMMBLFGFFD;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid DJFIEPNICPI;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid KJJMNNEILCE;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid KCJGLOHHEPE;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid EDFMEMCFBOH;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid AIKLMFDBEEN;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid CCNLDACEAJF;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid LLJGJFHMOFB;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid EJHKNGBNPJJ;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid KHJJLNDEGOM;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid JFIEGKBCFEG;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid JCINBGBHJIB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid NLPKPFKPOPG;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid KAEDGHKBADM;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid LKGHPGIMJCI;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid IIGMAKEMGCB;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid NIGACNIBCAD;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid PBFOKPHJBBE;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid FAKFOIACLAM;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid KJGOMIBPFCL;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid IDKPBMINJBP;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid KFDFKOOKNMB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OHPJDJDFHFF;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid FHNALNGCMAK;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid BOIJDNJKNJL;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FDMIFGLFDIC;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid EKIAMPHHLMD;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid KAJAIONFCLH;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid MPCOOCFJLKG;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid AGBEGCOJFNI;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid OECNALFHJHI;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid PNHMMPIIPPP;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid CBBDBCMMKEJ;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid AIPBDMMGIFK;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid LIELCOJJMNO;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid ACOPALNGCLL;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid FMJCAEBEKOO;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid JIBPDLAIEFP;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid NBNFBCHPPNF;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid JJOCNNKNANC;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid GJFHKEMGIOG;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid MOLAICMLFHA;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid GKICHEBNGNP;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid LEKOGKOPHHG;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid POJBKPHILMK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid KFCEHFGABGJ;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid LCMNLJHAPKP;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid MGJGGGKEIGB;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid HMEMNPCAAFK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid BCALBGKOCNP;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid IFCBHNFIFCC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid PDDGFPENBEH;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid JFCMDLBGNLP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid LMNCHOMMBLL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid KCLPNCFOJDB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid EDBFEFLPMKD;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid KLOHDAONIPC;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid LHBEFJNKLFA;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid DPLMBIPFABI;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid DGOIPOMLODL;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid EMMBNMOHNCG;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid GFIOMEFNODM;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid EMIEANGDFJF;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid ELHCKDHBKCB;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid CHBBALGKGEG;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid MMEJHOEJEFL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid PKJIDALDFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid KBODBMCGDIH;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid OMLANHCLJLA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid JKANLLGEGPD;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid ICLMOEJGAEL;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid DCELBKGHGFB;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid LNGJJAHKDED;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid GOHJCMAMMOH;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid PGFAEMNPKKI;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid HPAJFHHBOCK;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid IKDPIADLNAA;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid HIKAIPKGGLD;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid KACPJAMKCGD;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid NKCGDJMFBEB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid KGDAAIJNMJF;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid AMPKMMJNDGF;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid PGOKGKMOILA;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid MLLGEJJHLHL;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid KFPNBMNMCAB;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid MNAFPCDHNEK;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid HANJDNFJBIC;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid AGAACMDAICF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid KEMAFDCMLIC;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid OCMKNNBBHFL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid HJIHFJGJJAM;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid DMELJIEPHMO;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid EKHJNBKMKEC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid OGLOKNIOGLL;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid CIEIJIFIOBM;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid EPAIJLBHDPG;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid PCIHPGLFCBM;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid KPAJHCILAIH;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid OEIGJPIONLE;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid DOIJDBMPJLM;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid GPLGOOOEOLL;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid PAMPFHCNNGP;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid MHEFOLHHMPM;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid KCPDHCIPMOJ;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid LKFIMPOBABP;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid GFBGJGHHEKE;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MIPKAFFAEIO;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid BDMKGMEKNFF;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid GBBLMECMIAH;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid HDFCLGEHEPE;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid IHADKPNFFMG;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid DFPGJAGHKHI;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid LKHOPPDEIEA;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid LJFPIMMEIHC;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid ELKEPFJMNAC;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid AAJIFBKIDNN;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid BDEKINEJIAE;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid IDNACHKAGFH;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid FPLCGJPCGKK;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid OGGEEMOEMLO;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid HHGEGKFENOC;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid MDDAOGGGDMI;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid GPMAMELACFN;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid BGPLGFNIOKA;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid MAILCCOIHGP;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid DFLOGNGCKHK;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid HHGMOMEJEGD;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid JMJPPLHAAGA;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid OIEKOBOAHLM;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid FAIBCJHMIKC;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OBOEEDFDIIK;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid APEFHNEDOPD;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid PMCGFMFEGAD;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid DKNMMJOGDOC;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid BHNANDOFPEL;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid GMEDCAFNBFA;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid FFNGJHGCCHH;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid KEDFIMHLAOD;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid AIMABPOPEEE;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid EJPAKEJHCOH;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid HCPEAILEPDM;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid LHNHKGJDNHA;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid FKKIPCOGHBJ;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid IPDIAFJALAB;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid CKFPOGBLNCE;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid ODCAMNHELDO;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid GODNNCPMADH;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid PICEOBAOBOJ;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BINPDHKIOKO;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid JMGEGDMMHLL;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid MJHAIPLOABN;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid JNKDFGDBDKK;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid GNLOGBFENOC;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid BALKFDNKNAN;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid COAKLOPNFOO;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid OOPOBNLGHIP;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid BAJFIBJBGPA;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DMCONMFEOIJ;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid KFDNMKNPCMD;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid GDNPLPFGPDI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid DNIBLPFBHKJ;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid HPONCCOAOEA;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid GNKNIOAOKEJ;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid BANMLBIFANE;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OLJOOIMONMD;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid CJEJELFLLMB;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid BDEPCNGMILM;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid DMEBGGOGFNI;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid LMACEMIGGDB;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid LCIEADLHDGC;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid PAFKFMLCAIG;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid HPFPAOJKHAH;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid ABEJNELKFKP;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid KOLHPAIKDPC;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid BIOFEOMIMNA;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid JJINKCKHFMJ;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid HMCKBKKNBMI;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid GKBDDJOCALF;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid JIDCPLDPCNG;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid IMPOEHBEEPJ;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid EFFOHFBCELE;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid BCMAEPKMOEN;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid NGANMDHHDLB;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid FIAANIKKOJB;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid JKMPMMFAEJN;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid ENIPMOOKLMO;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid KGGHIBDFONI;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid HBBBMHKLGAB;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid MFPCDGJFIIM;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid AAFIAKMGHAB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid BCGGKDPDEBD;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid NEIGIELBFOC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid NPEMJADCNJI;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid EGHFPLOJPBH;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IKPEGOOGGLG;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid OJLNIHCCNKP;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid CEIMPLHEPHB;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EGEJCOFGBEB;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EAAABDNCEBO;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid KBENFLKMLAH;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid EPIKPIHPBKE;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid DIONHDHLHOG;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid GLFHMOOHPCL;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid DMKEFLFKANK;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid GENEFOGMFNE;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid ABMHIBMMDCN;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid AIANPGAHCCL;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid BJEKOAEAPLE;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid MNGMIFDEFLJ;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid FEHPNNKGBFA;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid HPCHHMAMKGJ;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid GNPBGBBPNGB;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid OLJNLAAMPBH;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid FDKPEHIEIND;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid FMCFHCANPCP;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid JLBNJJHCCGK;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid HDEADNKPIIO;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid BIGJOOMPCCC;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid GBEBEFLIKIK;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid AMJDKNLGIHP;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid IDKODLNKHNG;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid BLHLENIMBDP;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid NHJCCFDKIMH;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid FCMOEIMBLPI;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid FMFCEPKPLLA;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid FIBAENANPLP;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid FLGBHBEDPKB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid OLEGNFJKOIA;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid AMCEDDJAKGK;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid OHNEHMEPAAG;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid HKFFNJHAPFK;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid HIOJFOLINED;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid AKLKEMIPJIB;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid NDHEBDDBOPB;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid MKKPBAKKILM;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid PBCJPHKDKOI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid AGLACLKPLEO;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid KDLECIKIJGI;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid AFOHKFOOCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid BDFNHIHDNBI;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid DEODMLDFJJB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid BLMOKFBPNAB;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid ABPEHLAKMAM;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid LBHPFPIBEBN;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid HMGENEBILNE;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid KFAJMFACONK;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid DNEDOFHBKIP;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid JIHPDIGDFKM;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid GLMGEENNCMB;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid CEFKKEJNFLJ;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid FMBGNIBJNNG;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid EDNCFIIBKNN;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid BAILPAEMADB;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid GMJICCJAKPC;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid OMGILKOFKJG;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid DEEBDJKOMKC;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid AEPNNLHEIDN;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid LNNGAFOMPOG;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid AFLJJCKKOBH;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid LLICHABFOKD;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid NFLOAGEKNIP;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid NPLNGNFLCOE;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid EHEFMMIMFAN;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid COHFNMPFEDN;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid MPNICLPBJHD;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid FHOOLFINHOK;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid NKAAJDIKEIK;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid HHCJKLPFFLP;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid DKOGPINEGCI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid LIEBBNCBOOF;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid HIIOBBAJFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid JMIHMCCACLK;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NEFAALLGEFG;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid NOGAIHAMJMB;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid ONAFEPGGHEM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid JBBNFAMCPCM;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid MDNJOOJFKKK;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid OAHLFMOGCLA;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid DBJEOIALGJP;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid FBNPHDJPFJK;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid ADBJCHMMOHH;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid GLMBHELADFB;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid LCPCCJDIKEI;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid CEKENEACMFB;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid JAGLKMHPIGP;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid MGFFIDECLHO;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid FDDBAMIMOLE;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid MJOOABLEMGD;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid LJMPAFGFJLN;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid COOIFFFNKKF;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid DEGBMBBCCGD;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid HLEOHAIEDHJ;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid IBEOFGFMIMF;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid DLIBKHHGLHN;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid FEICMEMKNMP;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid JDIILBNAPMP;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid GMHGGICFODD;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid AGGAHDEADPJ;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid EHJNCKJOJOF;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid GPIFEKHALIJ;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid OJDNCIOBFAC;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid HOJAPGCCABG;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid NJMKBLOMLIF;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid EAMLEMAGJPI;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid HHFCGJCCDDF;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GHIJCNLFIAH;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid KFMAEHMCHIC;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid DAPMDCAMKDN;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid PHOOAIOJBHA;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid GPOBLLFEHCD;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid OHAPOPIAGPL;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid BILKKFIDKJJ;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid DCFIFODOHIM;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid JLGHAAEEBPD;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HKLEDAEGIHE;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid AFJJDEIJBBC;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid IBCNLPECMFO;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid BHMFEEAIGMD;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid KAEFIABJMID;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid KFEOBJMIOKB;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid JLEBDNOABLL;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid CCKFIHJKIMA;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid PLGCALLANLM;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid CAHGLBIKGIB;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid AGECJDADNBN;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid AHJGMPGCIIN;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid AHMCKGNJBEL;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid HJLKNLHGIEA;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid HHLMOGIDPNE;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid CIPLBKCOKJG;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid CDGDHNAPKMF;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid HPJEBHNECOK;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid JICENBIAOHN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid DIMFKDAENGA;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid IPCFEHNNKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LOKIJLPPKAA;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid AIBOMIIPBAA;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid ACDEFOPBDAP;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid ANPAJLJGNBL;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid EOEDLKAMMDC;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid ACCDFPIPJHI;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid ENDIDGEKONN;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid KHCAECLEGPB;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid EPLEDLJBGDK;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid APLDEHMPAAE;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid NBJAFOEBKIB;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid LCEFLHMFPGP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid BIAJEHEDCLB;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid GOJDBEOAEBC;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PAIBNIBENNK;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid KKOPPKKEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid MMJDKIOOBNL;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid AJHDMBINPMD;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid AANEHJCBMML;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid NLPGDKDBPEO;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid PEOHBJNGDKC;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid NHEFBIGBAPK;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid PCKCPMAFJDF;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid BPBJCGMHEIF;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid IMEKJEALDNK;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid OJAHIDNBJBG;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid BNFJALGIBHN;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid PBCEGLJFJPK;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid DAFADKABAEC;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid MKDJGCHKCEH;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid CCAHMAPMINH;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid JKOFNBJLGCK;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid ADEGKAHPFPB;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid KFBBAJMLONG;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid BIGEGDKLKHO;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid KGNGOAMAMCH;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid OEJFDPPFMOK;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid JCEEPAKBBLM;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid GALFMNMHNPF;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid ILPOLAOADIO;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid EJFNKCAECLI;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid JCKICLEANHB;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid HMDCCDCLOIN;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid JDBPMAGHBKA;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid EALMONILPCP;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid LOIOLFFMDPJ;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid HJKMGNBOKIE;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid BCHAEKCJFGA;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid ODKAKIKOFEF;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid GIDLGJIADPP;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid OPNDAFJDIEI;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid NKIFMOOCNMP;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid DBKKIBKNCKO;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid IPOBKIFFEKG;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid OJFKLFJOIMJ;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid EOEJEAJNIOL;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid PHOJGKNBDDP;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid DLFGBIIJBIH;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid GMKCJOBINKI;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid DKFFDOMHOKK;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid PIMDGCGKBCD;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid OMDCKPFEGKC;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid IDIDGFOODBI;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid DFOBBJFLNIA;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid GKGAMKGBNNO;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid GPMJGGECNDB;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid FLGNNDIECAC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid MOKHOMDAAKA;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid LHGPLJHBJGJ;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid CNFJOBPOIHC;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid LKBFDPJPLOH;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid GPLLJCIBKHA;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid KGAHCNHEKON;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid KFGFHNNKMGJ;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid DEOABGFIEOI;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid DCHFPBFLAJH;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid FGGAGCJBDKB;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid LBFKCJECJMF;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid IOGJCLBJHMK;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid BAALAEPKNED;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid GLENMGEIBOG;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid OPBOOECIICJ;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid LHFCIOILKHP;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid ECGHGEKMOHO;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid GPMNCDNDNBK;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid AOJMBCPOKFE;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid IMAPKPNCADI;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid MOBMIEAMBGF;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid KHGEJNMCIPM;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid COELONKELBC;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid NLLBHPCMLMM;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid IMFMMOMKMFI;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid NBAIJAAKKDE;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid EPHLFJDIMIA;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid NEDLCLGFJFD;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid OAMGPDHDFFO;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid DGNGHBGACND;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid IEPADAFCDCM;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid ONKNEIEABAK;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid MPCNFCMICDD;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid KKDANNFLPMO;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid PMBHFOKFDAJ;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid PNEJIMHLLPD;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid KJALKGCLMAG;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid OIODHJFNIOM;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid JOBIEMNHKPD;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid LGMOJLKGJDN;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid BNPGNEAOKGF;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid HMGPAEKNDIO;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid FDNFKKFGDAA;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid MCAAIEMIMLE;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid OOCOAKAHPBJ;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid CKEMKJCBHJP;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid CCHIDEEGGBO;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid NJJADHBHOBN;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid DDFCOKIAMLO;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid LLGKDDHAOMF;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid HGLNANGDOND;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid KMAIBPFLJEA;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid IDDCPNJFMLD;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, KGMPHGPNPFE> HBBJNOMPIME;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<KGMPHGPNPFE, Guid> IFEGDMFHOAH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, KGMPHGPNPFE> HILFPAMPNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6847280", Offset = "0x6845C80", VA = "0x186847280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<KGMPHGPNPFE, Guid> PFMIFIJMHOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6847220", Offset = "0x6845C20", VA = "0x186847220")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JEKFOBFANLH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68476B0", Offset = "0x68460B0", VA = "0x1868476B0")]
	public static bool HOHDFPKIJMD(CJNIBIMONHC CBAFPKIJLBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6847300", Offset = "0x6845D00", VA = "0x186847300")]
	private static bool HOHDFPKIJMD(DCFEJAHKKGP FKCBGDEDKJB, CJNIBIMONHC CBAFPKIJLBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GLNFGJJAGOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly IKIIDFAANID GNGGACCOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<APDBPBGHHNA> NPPOOINMKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<APDBPBGHHNA> KKAHJKJMDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> EHJONJJDMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<KMLAHJFMIMO<KLHFMEEJLPO>> LLEHEKLFBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString CGEMAFBOLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly MHPBBFJHHCA NDEIGDCAPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool NJLCCAPAIEK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6843D30", Offset = "0x6842730", VA = "0x186843D30")]
	public GLNFGJJAGOH(IKIIDFAANID LKCBCPFCLLG, IEnumerable<APDBPBGHHNA> LOJFOEMAKPP, IReadOnlyList<APDBPBGHHNA> LDJEFKFFCLD, AEAOKLPMJLF<NBLNJAIONPA> MGFMAFPODJC, IReadOnlyList<KMLAHJFMIMO<KLHFMEEJLPO>> PAPJGKJACLK, ByteString INJPCGBMPNN, MHPBBFJHHCA ICMMIEHMPPG, bool NHNMLNJGBFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DALEGAPDBBG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(IJKMIEDCAHL EEOBDBMOHPL, [Out] Dictionary<int, int> IFFHHCOFDNF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JBNFDDCMJOC JBKJNBGCNBD, DCGNJFDHKNM LAKFFEHBCPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NCHIABGOPHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid BDBECJKJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> FGLLNLABGOK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> KBNKMBDOOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3951670", Offset = "0x3950070", VA = "0x183951670")]
	private NCHIABGOPHK([In] Guid BOPLAAFLPDP, Dictionary<Guid, Guid> KFDGOLLKDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x685BDE0", Offset = "0x685A7E0", VA = "0x18685BDE0")]
	public static NCHIABGOPHK CFMHOLCPJBP(IReadOnlyDictionary<Guid, Guid> ECMPJMNDDKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x685BA30", Offset = "0x685A430", VA = "0x18685BA30")]
	public static NCHIABGOPHK CCFMKKHPKLA(IEnumerable<KeyValuePair<Guid, Guid>> ECMPJMNDDKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x685BE60", Offset = "0x685A860", VA = "0x18685BE60")]
	private static Dictionary<Guid, Guid> OGOGCHPFLGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x685BF10", Offset = "0x685A910", VA = "0x18685BF10")]
	public Guid OHAEKMCJDMC([In] Guid JCMDDLFAGEN, bool KPOEBCKNEIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x685BDF0", Offset = "0x685A7F0", VA = "0x18685BDF0")]
	public bool FOIEMFPGCBI([In] Guid OBDGAAHPMCD, [Out] Guid EKNFFGLHIFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AMMHBENHMPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CEPCMMODIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIOJCIMJMME(ByteString AIOLAHHPMLA, NCHIABGOPHK BDMIDKNCHCH, [In] UniformTRS NGMELNEGGJI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NFDGOJHPENE
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
public class IMKKBIBMEKH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14EB210", Offset = "0x14E9C10", VA = "0x1814EB210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GAFJLOBEDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1005DD0", Offset = "0x10047D0", VA = "0x181005DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long FIJEDOMFNLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68472E0", Offset = "0x6845CE0", VA = "0x1868472E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x654E3C0", Offset = "0x654CDC0", VA = "0x18654E3C0")]
	public IMKKBIBMEKH(long OHELHAFFKFF, long FFMDBHBKAHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LHJCJMDGEAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, IMKKBIBMEKH> DHAHLDLLCKM;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> LFOFKJDNKDB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long KNOFPCMOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1005DD0", Offset = "0x10047D0", VA = "0x181005DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long LOEOFDEFPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1064C00", Offset = "0x1063600", VA = "0x181064C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68479A0", Offset = "0x68463A0", VA = "0x1868479A0")]
	public static LHJCJMDGEAE PFOOEKJDGPH(IKIIDFAANID PNKBCBLFJLI, KMLAHJFMIMO<NBLNJAIONPA> GGPNJLEIHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68476E0", Offset = "0x68460E0", VA = "0x1868476E0")]
	private void DHHOFLFLFEF(DJEHKJIICEM CDPKDOCKGIC, long GKBCFJABBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x685B950", Offset = "0x685A350", VA = "0x18685B950")]
	public LHJCJMDGEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DGEMCGGGLFB
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<KGMPHGPNPFE> GEBOEBKBFDC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PEDDIPNDCDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> ONHIDPBEGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> MIAAICJCKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x852C10", VA = "0x180854210")]
	public PEDDIPNDCDM(IReadOnlyDictionary<Guid, Guid> GKCABJDIPCP, IReadOnlyDictionary<Guid, Guid> MNJLJLDKCAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HACLHDPBLIH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68470B0", Offset = "0x6845AB0", VA = "0x1868470B0")]
	public static MKGCKILDBCF POMGLDKGEEK([In] GLNFGJJAGOH BOGLJELOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6846A50", Offset = "0x6845450", VA = "0x186846A50")]
	private static void PODPAOOOJOE(MKGCKILDBCF DBOHBIGAFPL, [In] GLNFGJJAGOH FGJMBKEDFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6844B90", Offset = "0x6843590", VA = "0x186844B90")]
	public static FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ> MAHAAEKPEBO(MKGCKILDBCF DBOHBIGAFPL, LLOIPIHFNCC JIGKKDILNGD, NCHIABGOPHK? FNGEJJPHMDK)
	{
		return default(FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68445A0", Offset = "0x6842FA0", VA = "0x1868445A0")]
	private static void FOEAEBHKOBH(MKGCKILDBCF DBOHBIGAFPL, NCHIABGOPHK? CFMMLFKMLEJ, LLOIPIHFNCC JIGKKDILNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6844B20", Offset = "0x6843520", VA = "0x186844B20")]
	private static void HEGNDHHJLPH(MKGCKILDBCF DBOHBIGAFPL, LLOIPIHFNCC JIGKKDILNGD, IReadOnlyCollection<ByteString>? KEIIEMOHKKB, IReadOnlyCollection<ByteString>? GAFIKHONIBH, IReadOnlyCollection<ByteString>? MDCKFNBCMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68463C0", Offset = "0x6844DC0", VA = "0x1868463C0")]
	private static bool NDFPJFJBJIB(MKGCKILDBCF DBOHBIGAFPL, JBNFDDCMJOC JBKJNBGCNBD, LLOIPIHFNCC JIGKKDILNGD, [Out][NotNullWhen(false)] string? BKMJJACFCBK, [Out] Dictionary<int, int> IFFHHCOFDNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6844840", Offset = "0x6843240", VA = "0x186844840")]
	private static Dictionary<Guid, DCFEJAHKKGP> HCKPLOAKJFO(MKGCKILDBCF DBOHBIGAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6844500", Offset = "0x6842F00", VA = "0x186844500")]
	private static void FNKDLPKELEA(bool MAOMJCNBOFL, APDBPBGHHNA HDCEGHKDECL, Dictionary<Guid, Guid> EKIGPGPLFCD, NCHIABGOPHK AMOMDKGDFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6843DC0", Offset = "0x68427C0", VA = "0x186843DC0")]
	private static void CHFJCONFHKI(APDBPBGHHNA HDCEGHKDECL, Guid JIEKFHKHKML, CKEBOLKOAHH? DGNMBPHNCLH, Dictionary<Guid, DCFEJAHKKGP> EJPHINOOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6844050", Offset = "0x6842A50", VA = "0x186844050")]
	private static void CPAENHDCHIK(IEnumerable<APDBPBGHHNA> LJKOCBDIJDL, IReadOnlyCollection<ByteString> KEIIEMOHKKB, IReadOnlyCollection<ByteString> GAFIKHONIBH, IReadOnlyCollection<ByteString> MDCKFNBCMPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LLOIPIHFNCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool MAOMJCNBOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public MHPBBFJHHCA ICMMIEHMPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public CKEBOLKOAHH? DGNMBPHNCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public CKEBOLKOAHH? GIAMOCHMCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public IKIIDFAANID FLOFPLONCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public NFDGOJHPENE FCHILBILBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public DALEGAPDBBG EDKCFPDPCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public AMMHBENHMPF MACIGCDHKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public KMLAHJFMIMO<NBLNJAIONPA> KJJMDODENIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public KBKMAHEHBMM OJPHFOFNDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<APDBPBGHHNA> MKPPOCINODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> CLELFACAFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public HNDGJLCILAM AJGIKFICJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool NNCBOGGFKGE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CBMMBGJKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x685B9E0", Offset = "0x685A3E0", VA = "0x18685B9E0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CKEBOLKOAHH
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float NKKFFLCBNOC = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 GLNEOPDBMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion NGGFFKDNCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float GIFACOBMIEN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 MJHNAJMAJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6841960", Offset = "0x6840360", VA = "0x186841960")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS FPJJALNEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6841D30", Offset = "0x6840730", VA = "0x186841D30")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB1CB90", Offset = "0xB1B590", VA = "0x180B1CB90")]
	public CKEBOLKOAHH(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float GIFACOBMIEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6842290", Offset = "0x6840C90", VA = "0x186842290")]
	public CKEBOLKOAHH(UniformTRS OBNNJPINDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6841F80", Offset = "0x6840980", VA = "0x186841F80")]
	public static CKEBOLKOAHH PEGPCCGOEBG(CKEBOLKOAHH EMNGIAIDBPA, CKEBOLKOAHH MJBALCFKHAG)
	{
		return default(CKEBOLKOAHH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6841D70", Offset = "0x6840770", VA = "0x186841D70")]
	public static CKEBOLKOAHH OCHPDIOAFKC((Vector3, Quaternion, float) EEOBDBMOHPL)
	{
		return default(CKEBOLKOAHH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6841D90", Offset = "0x6840790", VA = "0x186841D90")]
	public static CKEBOLKOAHH OCHPDIOAFKC(Matrix4x4 CNAAJOBBGJN)
	{
		return default(CKEBOLKOAHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6842200", Offset = "0x6840C00", VA = "0x186842200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6841B00", Offset = "0x6840500", VA = "0x186841B00")]
	public CKEBOLKOAHH HJKEFLGPCMN(Matrix4x4 OFGHBAGNEDJ)
	{
		return default(CKEBOLKOAHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6841F10", Offset = "0x6840910", VA = "0x186841F10")]
	public static CKEBOLKOAHH PACLLGAPFMM(Vector3 GLNEOPDBMFP)
	{
		return default(CKEBOLKOAHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6841A70", Offset = "0x6840470", VA = "0x186841A70")]
	public readonly CNGFDBIEJIM GLJHMMCMMDL()
	{
		return default(CNGFDBIEJIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FBPDIPEIIIP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6843CA0", Offset = "0x68426A0", VA = "0x186843CA0")]
	public static CKEBOLKOAHH AEHKFLGGAKA([In] this CNGFDBIEJIM BBCPNLGGBMJ)
	{
		return default(CKEBOLKOAHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BHOOBCEIDNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly IGFHKIJFLIG ABBELPKKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private readonly LHAJNHDLEEF PHCMKOHDDBE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD90010", Offset = "0xD8EA10", VA = "0x180D90010")]
	private BHOOBCEIDNJ(IGFHKIJFLIG IOHMFKLLMFN, LHAJNHDLEEF HEFEDHOBLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x68416D0", Offset = "0x68400D0", VA = "0x1868416D0")]
	public CGMLAKELBPB JBJDLGDACDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68417F0", Offset = "0x68401F0", VA = "0x1868417F0")]
	public static FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ> KHKANEAPNIK(OIDANPOCPEH<LMMCANLFCCL> HEFEDHOBLLH)
	{
		return default(FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6841740", Offset = "0x6840140", VA = "0x186841740")]
	public static FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ> KHKANEAPNIK(CGMLAKELBPB HEFEDHOBLLH)
	{
		return default(FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68418A0", Offset = "0x68402A0", VA = "0x1868418A0")]
	public static FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ> KHKANEAPNIK(string BNBJCPOHAOL)
	{
		return default(FNBKHJCMJJM<PEDDIPNDCDM, BHOOBCEIDNJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum IGFHKIJFLIG
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NEGFMPCBBCI : IDisposable, GMJFLFPDDCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private NativeList<PEHEHHOPNDC> LPFKDIMABND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float BCNEJLLIDJA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LHBGCBDDANP PJOJBODAGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0")]
		[CompilerGenerated]
		get
		{
			return default(LHBGCBDDANP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x856690", Offset = "0x855090", VA = "0x180856690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FDLNAGHLFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x685E510", Offset = "0x685CF10", VA = "0x18685E510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool AKMJDKNBCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x685E670", Offset = "0x685D070", VA = "0x18685E670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<BCDKNDLGGNE> PPLNCKJLCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int MBHMELDPCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x685D2E0", Offset = "0x685BCE0", VA = "0x18685D2E0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float INIDOELCADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x685CDB0", Offset = "0x685B7B0", VA = "0x18685CDB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x685E780", Offset = "0x685D180", VA = "0x18685E780")]
	public NEGFMPCBBCI(LHBGCBDDANP GBNNPAAOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x685D120", Offset = "0x685BB20", VA = "0x18685D120", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x685D4D0", Offset = "0x685BED0", VA = "0x18685D4D0")]
	public Vector3 HPIKBKFENOK(int OPBNGFFAEBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x685CEF0", Offset = "0x685B8F0", VA = "0x18685CEF0", Slot = "6")]
	public Quaternion BPFPKPODKPE(int OPBNGFFAEBH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x685E680", Offset = "0x685D080", VA = "0x18685E680", Slot = "5")]
	public Vector3 PEOKACLEMAC(int OPBNGFFAEBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x685E720", Offset = "0x685D120", VA = "0x18685E720", Slot = "7")]
	public float PJNEMDBONME(int OPBNGFFAEBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x685C4C0", Offset = "0x685AEC0", VA = "0x18685C4C0")]
	public void APJKKEOFCMF(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float EHEGOIJKGEH, bool EFAEKNLFPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x685CFC0", Offset = "0x685B9C0", VA = "0x18685CFC0")]
	private bool CICKNHGHDBA(int AANILPIOPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x685D180", Offset = "0x685BB80", VA = "0x18685D180")]
	public void FLBDHGKDKBG(Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float EHEGOIJKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x685D020", Offset = "0x685BA20", VA = "0x18685D020")]
	public void DOALMDHENKA(int AANILPIOPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x685E520", Offset = "0x685CF20", VA = "0x18685E520")]
	public void OAAKGPDNKFN(int AANILPIOPIM, Vector3 GLNEOPDBMFP, Quaternion NGGFFKDNCFB, float EHEGOIJKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x685D320", Offset = "0x685BD20", VA = "0x18685D320")]
	public void HCLGAJNNNEJ(int AANILPIOPIM, float3 GLNEOPDBMFP, quaternion NGGFFKDNCFB, float EHEGOIJKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x685E260", Offset = "0x685CC60", VA = "0x18685E260")]
	public void KBEGFPDMAIK(int AANILPIOPIM, Vector3 GLNEOPDBMFP, float EHEGOIJKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x685E3B0", Offset = "0x685CDB0", VA = "0x18685E3B0")]
	public void LLMAOICBOJI(int AANILPIOPIM, Vector3 GKJCNLBHEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x685DA70", Offset = "0x685C470", VA = "0x18685DA70")]
	public static Quaternion KAIIBIPJHJE(Quaternion CMAJCEDKDLM, int AANILPIOPIM, float FPPEBMAOPIM, GMJFLFPDDCH CNPDKPLDIJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x685C020", Offset = "0x685AA20", VA = "0x18685C020")]
	public Bounds ALPHPOALBMM(Transform OFGHBAGNEDJ)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x685D0B0", Offset = "0x685BAB0", VA = "0x18685D0B0", Slot = "10")]
	public virtual void DPAGLOPCMMB(bool ENCNMIDNNED = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x685D9A0", Offset = "0x685C3A0", VA = "0x18685D9A0")]
	public NativeList<PEHEHHOPNDC> ILAEEDNGONM(float NDOLINLGKFJ = 1f)
	{
		return default(NativeList<PEHEHHOPNDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BCDKNDLGGNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float3 IOJOFKPMLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float DDFFBPCPAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public quaternion NDCPKCKNLGM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x685F7E0", Offset = "0x685E1E0", VA = "0x18685F7E0")]
	public BCDKNDLGGNE(Vector3 FKMPANFIJIC, Quaternion CMAJCEDKDLM, float EHEGOIJKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x685F270", Offset = "0x685DC70", VA = "0x18685F270")]
	public Quaternion BNJCBHMACGA(Vector3 NMAFDGGPBKA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x685F330", Offset = "0x685DD30", VA = "0x18685F330")]
	public BCDKNDLGGNE FFMHFHEEJFO(Vector3 PJBLJKFEDDJ, Vector3 IIKGIHLJNDI, Vector3 EMCOKIDJIDF)
	{
		return default(BCDKNDLGGNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x685F630", Offset = "0x685E030", VA = "0x18685F630")]
	public MIKIOBLCAIG ODJJOEOAGCH(Vector3 NMAFDGGPBKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class BABJEFPJEAL : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x685E940", Offset = "0x685D340", VA = "0x18685E940", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x685ECA0", Offset = "0x685D6A0", VA = "0x18685ECA0")]
	private void MPOINPGKOBC(Dictionary<Guid, Guid> NGDBLPGPLKP, CFBJMAGICDI IAELMIEDKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x685E9C0", Offset = "0x685D3C0", VA = "0x18685E9C0")]
	private void MPOINPGKOBC(Dictionary<Guid, Guid> NGDBLPGPLKP, IMGGIJDHCKJ EGOFKDFGLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x685EA20", Offset = "0x685D420", VA = "0x18685EA20")]
	private void MPOINPGKOBC(Dictionary<Guid, Guid> NGDBLPGPLKP, BEBLBHGOKBE IFCEOHHPMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public BABJEFPJEAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class OOOMFJMPBKI : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6864B40", Offset = "0x6863540", VA = "0x186864B40", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public OOOMFJMPBKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PCOBIGIHLLB : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6864CF0", Offset = "0x68636F0", VA = "0x186864CF0", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PCOBIGIHLLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class BDEEPMDNAKP : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x685F860", Offset = "0x685E260", VA = "0x18685F860", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public BDEEPMDNAKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class OHPKCNBGOIP : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68647F0", Offset = "0x68631F0", VA = "0x1868647F0", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public OHPKCNBGOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OCAIAOIJBHP : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68646B0", Offset = "0x68630B0", VA = "0x1868646B0", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public OCAIAOIJBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MLAJFIJIMNF : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6861E10", Offset = "0x6860810", VA = "0x186861E10", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public MLAJFIJIMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PGAABBBMEMI : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6864E50", Offset = "0x6863850", VA = "0x186864E50", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PGAABBBMEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JKOGFBKOJMG : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6861C50", Offset = "0x6860650", VA = "0x186861C50", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public JKOGFBKOJMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HMMIFNNJLLH : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6861160", Offset = "0x685FB60", VA = "0x186861160", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public HMMIFNNJLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OPGOIJBOBBF : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6864BF0", Offset = "0x68635F0", VA = "0x186864BF0", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public OPGOIJBOBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OLFEMBBJGKH : NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public static readonly JBFANICNNPF BJAEDNFMGIP;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6864A10", Offset = "0x6863410", VA = "0x186864A10", Slot = "4")]
	public void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public OLFEMBBJGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CJNIBIMONHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public JBNFDDCMJOC OKMBFDMPMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public GLDAABPECNP DBJHMDBBFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public Dictionary<int, int> MAOLLEONHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public Dictionary<Guid, Guid> ELIPHANPJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public HNDGJLCILAM AJGIKFICJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool LGMHNFLKCBA;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NNCEPOECMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAJNMGLFPIL(COCBBCOGFBN GLDGMLIMKFH);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NMLOJOINDJG
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private static readonly NNCEPOECMGL[] JOIMOFLKDHG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6863BB0", Offset = "0x68625B0", VA = "0x186863BB0")]
	public static void LNHBAODOOHO(APDBPBGHHNA EEOBDBMOHPL, Dictionary<Guid, Guid> EKKOHAAMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6863550", Offset = "0x6861F50", VA = "0x186863550")]
	public static void FEPADNOGJDD(APDBPBGHHNA? EEOBDBMOHPL, NCHIABGOPHK EFKOGBMKMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6863E40", Offset = "0x6862840", VA = "0x186863E40")]
	public static void PDMKPFNIACA(APDBPBGHHNA? EEOBDBMOHPL, NCHIABGOPHK AMOMDKGDFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68637E0", Offset = "0x68621E0", VA = "0x1868637E0")]
	public static void HOHDFPKIJMD(COCBBCOGFBN GLDGMLIMKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct COCBBCOGFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public JBNFDDCMJOC FDKIFAIOGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public APDBPBGHHNA HDCEGHKDECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public Dictionary<int, int> MAOLLEONHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public Dictionary<Guid, Guid> ELIPHANPJHF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x685F9B0", Offset = "0x685E3B0", VA = "0x18685F9B0")]
	public Guid KCDCKPPJEIA(Guid JCMDDLFAGEN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HNDGJLCILAM
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int MIPNBBLBHBI, [Out] Guid APPKBEANEHO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class NFPNMDPLAGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private readonly HashSet<string> AEODHFNFPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<long, int> FPKCOOLHCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private readonly HashSet<Guid> JEIPEBDOFJD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> NPEPHHNIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> IBOLGJFHLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6863280", Offset = "0x6861C80", VA = "0x186863280")]
	public static NFPNMDPLAGP PFEHODGKDMH(HOHHBPKCDBA IJFOGIEFCHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6863210", Offset = "0x6861C10", VA = "0x186863210")]
	public static NFPNMDPLAGP JILCHOGDOIA(MKGCKILDBCF FBLMPHDMJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6863090", Offset = "0x6861A90", VA = "0x186863090")]
	public static NFPNMDPLAGP JBEGPPNAGEB(IEnumerable<string> AEODHFNFPHH, IDictionary<long, int> IHGBDJJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x68632F0", Offset = "0x6861CF0", VA = "0x1868632F0")]
	private NFPNMDPLAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6863410", Offset = "0x6861E10", VA = "0x186863410")]
	private NFPNMDPLAGP(IEnumerable<string> AEODHFNFPHH, IDictionary<long, int> IHGBDJJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6862580", Offset = "0x6860F80", VA = "0x186862580")]
	private void CEDOMGBGCHK(HOHHBPKCDBA IJFOGIEFCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6862770", Offset = "0x6861170", VA = "0x186862770")]
	private void CEDOMGBGCHK(MKGCKILDBCF FBLMPHDMJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6862960", Offset = "0x6861360", VA = "0x186862960")]
	private void CEDOMGBGCHK(IMOGEFNNDGB? GPKGNPPAAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6862C80", Offset = "0x6861680", VA = "0x186862C80")]
	private void CEDOMGBGCHK(FKBBAHCCEMF? CDPKDOCKGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6862190", Offset = "0x6860B90", VA = "0x186862190")]
	private void CEDOMGBGCHK(APDBPBGHHNA? HDCEGHKDECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6863020", Offset = "0x6861A20", VA = "0x186863020")]
	private void EKMINPAOIHH(string? HMOOFBNOFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6862E50", Offset = "0x6861850", VA = "0x186862E50")]
	private void EIJNBEGFELF(MDNJAABDKEK? DKPMEFDCMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6862F30", Offset = "0x6861930", VA = "0x186862F30")]
	private void EIJNBEGFELF(ONODJPBANDF? DKPMEFDCMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DMOPJLKJAOH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class EIIJGBDNHCN : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private readonly IEnumerator<DictionaryEntry> CBNHKGJHAAB;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry KJKKDIGCEOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6860DA0", Offset = "0x685F7A0", VA = "0x186860DA0", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object KJIEMALOMPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6860E60", Offset = "0x685F860", VA = "0x186860E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object NHLIMKDHAIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6860F10", Offset = "0x685F910", VA = "0x186860F10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object NHBEFFGDNPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6860CC0", Offset = "0x685F6C0", VA = "0x186860CC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
		public EIIJGBDNHCN(IEnumerator<DictionaryEntry> CBNHKGJHAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6860C20", Offset = "0x685F620", VA = "0x186860C20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6860C70", Offset = "0x685F670", VA = "0x186860C70", Slot = "9")]
		public void Reset()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class HJEPNGLOBOH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public RoomObjectCounts <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xC2A030", Offset = "0xC28A30", VA = "0x180C2A030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6861110", Offset = "0x685FB10", VA = "0x186861110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
			[DebuggerHidden]
			public HJEPNGLOBOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6860FC0", Offset = "0x685F9C0", VA = "0x186860FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x68610C0", Offset = "0x685FAC0", VA = "0x1868610C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public readonly Dictionary<int, int> ByInvention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public readonly Dictionary<int, int> ByGraph;

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly string[] keys1;

		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private static readonly string[] keys2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6865510", Offset = "0x6863F10", VA = "0x186865510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object LDDEKIBHION]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6865420", Offset = "0x6863E20", VA = "0x186865420", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6865600", Offset = "0x6864000", VA = "0x186865600", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6865360", Offset = "0x6863D60", VA = "0x186865360", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x68653C0", Offset = "0x6863DC0", VA = "0x1868653C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x68655A0", Offset = "0x6863FA0", VA = "0x1868655A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6865020", Offset = "0x6863A20", VA = "0x186865020", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6865080", Offset = "0x6863A80", VA = "0x186865080", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x68650E0", Offset = "0x6863AE0", VA = "0x1868650E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
		public RoomObjectCounts(Dictionary<int, int> APNKIGANHOP, [Optional] Dictionary<int, int> GPEBDELPOHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6864F40", Offset = "0x6863940", VA = "0x186864F40")]
		[IteratorStateMachine(typeof(HJEPNGLOBOH))]
		private IEnumerator<DictionaryEntry> ELJMKHOCFIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6865650", Offset = "0x6864050", VA = "0x186865650", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6865260", Offset = "0x6863C60", VA = "0x186865260", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6865140", Offset = "0x6863B40", VA = "0x186865140", Slot = "9")]
		void IDictionary.Add(object LDDEKIBHION, object DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68651A0", Offset = "0x6863BA0", VA = "0x1868651A0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6865200", Offset = "0x6863C00", VA = "0x186865200", Slot = "8")]
		bool IDictionary.Contains(object LDDEKIBHION)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6865300", Offset = "0x6863D00", VA = "0x186865300", Slot = "14")]
		void IDictionary.Remove(object LDDEKIBHION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6864FC0", Offset = "0x68639C0", VA = "0x186864FC0", Slot = "15")]
		void ICollection.CopyTo(Array MHMBNFEOIBK, int ILOCEPPJPDO)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class NBJMBDGCELE : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private DictionaryEntry <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public Invention <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			DictionaryEntry IEnumerator<DictionaryEntry>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0xC2A030", Offset = "0xC28A30", VA = "0x180C2A030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x6862140", Offset = "0x6860B40", VA = "0x186862140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
			[DebuggerHidden]
			public NBJMBDGCELE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x6861FB0", Offset = "0x68609B0", VA = "0x186861FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x68620F0", Offset = "0x6860AF0", VA = "0x1868620F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public readonly long id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public readonly int count;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly string[] keys;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		ICollection IDictionary.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6861960", Offset = "0x6860360", VA = "0x186861960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object LDDEKIBHION]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6861830", Offset = "0x6860230", VA = "0x186861830", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6861A10", Offset = "0x6860410", VA = "0x186861A10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6861770", Offset = "0x6860170", VA = "0x186861770", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x68617D0", Offset = "0x68601D0", VA = "0x1868617D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x68619B0", Offset = "0x68603B0", VA = "0x1868619B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x68613F0", Offset = "0x685FDF0", VA = "0x1868613F0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6861450", Offset = "0x685FE50", VA = "0x186861450", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x68614B0", Offset = "0x685FEB0", VA = "0x1868614B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F903E0", Offset = "0x1F8EDE0", VA = "0x181F903E0")]
		public Invention(long OBDGAAHPMCD, int OHELHAFFKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6861320", Offset = "0x685FD20", VA = "0x186861320")]
		[IteratorStateMachine(typeof(NBJMBDGCELE))]
		private IEnumerator<DictionaryEntry> ELJMKHOCFIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6861A60", Offset = "0x6860460", VA = "0x186861A60", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6861630", Offset = "0x6860030", VA = "0x186861630", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6861510", Offset = "0x685FF10", VA = "0x186861510", Slot = "9")]
		void IDictionary.Add(object LDDEKIBHION, object DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6861570", Offset = "0x685FF70", VA = "0x186861570", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68615D0", Offset = "0x685FFD0", VA = "0x1868615D0", Slot = "8")]
		bool IDictionary.Contains(object LDDEKIBHION)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6861710", Offset = "0x6860110", VA = "0x186861710", Slot = "14")]
		void IDictionary.Remove(object LDDEKIBHION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6861390", Offset = "0x685FD90", VA = "0x186861390", Slot = "15")]
		void ICollection.CopyTo(Array MHMBNFEOIBK, int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> COJIJMOCDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public readonly IReadOnlyList<Invention> NPKIHNNJOFP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public DMOPJLKJAOH(IReadOnlyDictionary<Guid, RoomObjectCounts> BCLAEOLCENM, IReadOnlyList<Invention> IMJAJAEIKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6860230", Offset = "0x685EC30", VA = "0x186860230")]
	public static DMOPJLKJAOH PFEHODGKDMH(HOHHBPKCDBA IJFOGIEFCHH)
	{
		return default(DMOPJLKJAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6860110", Offset = "0x685EB10", VA = "0x186860110")]
	[CompilerGenerated]
	internal static int MMCABKILNEE([In] IReadOnlyDictionary<long, int> ADJEABCHPEM, long? IFMLDDBEFLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x685FA60", Offset = "0x685E460", VA = "0x18685FA60")]
	[CompilerGenerated]
	internal static void GBNONOCJLDE(int IABOCGCAIGI, [In] IMOGEFNNDGB GFIJGNADJHA, [In] Dictionary<long, int> ADJEABCHPEM, [In] Dictionary<Guid, RoomObjectCounts> BCLAEOLCENM)
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
