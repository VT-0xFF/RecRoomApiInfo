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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x686B040", Offset = "0x6869A40", VA = "0x18686B040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CHOPKDMECMD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> AFMCECNKOKB;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> OHKOHPOGLEM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> LDHCFMLFNOP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static string EACIFOLONHP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string MJBGOCKHMEA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string LOOAIDEJDPI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6854660", Offset = "0x6853060", VA = "0x186854660")]
	public static bool HHPPKPBFNAI(Guid GOGHIBAALEE, int IGLEECJOBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6854760", Offset = "0x6853160", VA = "0x186854760")]
	public static bool LGFANPFKJHJ(Guid GOGHIBAALEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6853F90", Offset = "0x6852990", VA = "0x186853F90")]
	public static string DKMLCNAEHFK(Guid BMIGIGGJPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AILMMLAHFMB]
public enum NIMOGNKKNOB
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
public static class PBLOBAKEDIN
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Guid OJCKGLBGFLJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Guid GONLIHOLBKI;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Guid FFPANPPGIIJ;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Guid NLIFNJCECBN;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Guid PIGGJBOBBMK;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Guid IPFGNAFBMIM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Guid FEJDKKHOOHB;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Guid OEFPMANOMKL;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Guid LBNEJKMAEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Guid OLHMLPDJCJB;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Guid AFDLCAPFOOO;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Guid DEPGEMMBGPN;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Guid EAKEKKHAFAF;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Guid ECDNIEHNEDA;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Guid NDEFLOBEEKC;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Guid ALCBDAMKNFK;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Guid FJIKKMKHKEN;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Guid BIDALDNPPBB;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Guid GMDNKHAPMKA;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Guid EFLGKFKLAHP;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Guid GCLPNIMJJIO;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Guid PEJFBBHOCIK;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Guid FLHPIINNMNB;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Guid LOLAIPHNPPG;

	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly Guid CJLJOILKLNL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly Guid NMDPBILKJCG;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly Guid FNKHFGBIBNH;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly Guid GDBHELFMOGB;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly Guid LHFONCGBDOJ;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly Guid JMDAGEHDHFD;

	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public static readonly Guid GIGMBHNLPPP;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly Guid EMLBMJGCBPA;

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly Guid KLFPKMPPIKJ;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly Guid KFGBBCANFLB;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly Guid BLICICGBMAA;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly Guid MFGJCIIGPDO;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly Guid BHMNEOBMABB;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly Guid JABMCKENECH;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly Guid ECBBAMEOKID;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly Guid CPAKKPFFGAH;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly Guid CMAMGEJJGOC;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly Guid AECHNJBKIEB;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly Guid KMKHCPFMFJF;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly Guid DBLMOKANFGC;

	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public static readonly Guid MGPHCLJAFJL;

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public static readonly Guid FGAKFNNJBEI;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly Guid CHEGHJFCFMN;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly Guid JLIJPGMBKND;

	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public static readonly Guid NEOEEDIIBHC;

	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public static readonly Guid BCBJEFOJDLF;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly Guid DCGGHPPNHHI;

	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public static readonly Guid HDNNFNMOOMJ;

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public static readonly Guid JECDGHJNDOD;

	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public static readonly Guid CLEFDNJIBCA;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly Guid BKDFCAHPACJ;

	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public static readonly Guid LBMHBBBJIDN;

	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly Guid ENNGDIPBHNF;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly Guid LFLELKOGLCC;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly Guid OGKACMCCCCC;

	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public static readonly Guid DADMACAAENM;

	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	public static readonly Guid MKOGCDKOEDC;

	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	public static readonly Guid FIJEPKPCBBD;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly Guid PEMNPGLMDNK;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public static readonly Guid BFJLHPBFHPP;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public static readonly Guid GHNFIJFOOKH;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	public static readonly Guid IMHIKNOMFHN;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly Guid BJDLMMHNDKA;

	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	public static readonly Guid GFEFHGNAHPF;

	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public static readonly Guid ANKGLDOCGAB;

	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public static readonly Guid CMMNOAGCHIP;

	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public static readonly Guid JFOEPCLFILM;

	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public static readonly Guid JGBEMCOKBMP;

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public static readonly Guid CLLDAIBEBLA;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public static readonly Guid MJODMIHBMKD;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public static readonly Guid BGJOPLJINCM;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public static readonly Guid NBOOHBHNNCO;

	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public static readonly Guid PFGFHCLDEJJ;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public static readonly Guid HJHLCGPOLDH;

	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public static readonly Guid JIMMNGNBJID;

	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public static readonly Guid EMEMALEEKJP;

	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public static readonly Guid KICAOHJJLDH;

	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public static readonly Guid IGBAAHMBCKD;

	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public static readonly Guid MINOKKLHOPE;

	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public static readonly Guid NAAMEFAKCFA;

	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public static readonly Guid CFLPFBOPPEH;

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	public static readonly Guid BCIJBLEONPO;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static readonly Guid OIDDEJFPFGO;

	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public static readonly Guid AOPOLBFGDIE;

	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public static readonly Guid GGKAMPJCBCG;

	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public static readonly Guid PINPGGLCMLC;

	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public static readonly Guid LOPNDDOLEGE;

	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public static readonly Guid GCMGDEGGPEL;

	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public static readonly Guid KJGNADGOFED;

	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public static readonly Guid KCMJBKIBCFD;

	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public static readonly Guid MMLCBDGCCNC;

	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public static readonly Guid BMCCPBPJCBF;

	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public static readonly Guid HKDIPPEHAHA;

	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public static readonly Guid GFFDELIHJJJ;

	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public static readonly Guid LDNIJHCKABD;

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly Guid DBKILPOBFLK;

	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public static readonly Guid KDEFHEBBJGJ;

	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public static readonly Guid HMEPBGBAGHC;

	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public static readonly Guid KHLMGDKJJPK;

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly Guid MBFIHHOFHEC;

	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public static readonly Guid OGEGPPFKKNC;

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public static readonly Guid BFPBOIKNPKP;

	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public static readonly Guid EBHFJCLHPPK;

	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	public static readonly Guid CKAICMNHMOC;

	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	public static readonly Guid PLKDPOOFINL;

	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	public static readonly Guid JJLHLFDCNHE;

	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public static readonly Guid OPGMNPAENJP;

	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly Guid DONNLAABONE;

	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	public static readonly Guid JPJCOCOCKGI;

	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	public static readonly Guid BMIGMPFAPDA;

	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	public static readonly Guid CLMFJBIGNDN;

	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	public static readonly Guid EEEKNAEIBOH;

	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	public static readonly Guid IADHDPHIJNM;

	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public static readonly Guid FOCBDPOKBMN;

	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public static readonly Guid HHLPHBFDKFI;

	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public static readonly Guid HLEKGHPPJHL;

	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public static readonly Guid MOKLNNIELFB;

	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public static readonly Guid EGOHNCEBIPF;

	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public static readonly Guid CIOMPJPIBJP;

	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public static readonly Guid LFOALPGJMGK;

	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public static readonly Guid PMKAEGCBEBL;

	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	public static readonly Guid AAFBGHBGGBP;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public static readonly Guid HOFCCAFOAAP;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public static readonly Guid IOFPCAMHHJH;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public static readonly Guid OMNDIAIJHOD;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public static readonly Guid ABPANJDEJGM;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	public static readonly Guid OAKCANFNLEM;

	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	public static readonly Guid BOMLGFKELDM;

	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	public static readonly Guid JAGPMLKBAML;

	[Cpp2IlInjected.Token(Token = "0x4000300")]
	public static readonly Guid MMOCMOLPCGK;

	[Cpp2IlInjected.Token(Token = "0x4000301")]
	public static readonly Guid AAJIELOACIE;

	[Cpp2IlInjected.Token(Token = "0x4000302")]
	public static readonly Guid PMACIPGDAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public static readonly Guid DPAGEAHODPF;

	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public static readonly Guid EFFFHAHKJGH;

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	public static readonly Guid IGIDNOEADFO;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	public static readonly Guid POFEDJHICCI;

	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public static readonly Guid PKGGJNJPCGF;

	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public static readonly Guid NEJGFMGGGPG;

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	public static readonly Guid MOLAHLNFOBL;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	public static readonly Guid AIDEDOADKHB;

	[Cpp2IlInjected.Token(Token = "0x400030B")]
	public static readonly Guid AFBCHOOJOFP;

	[Cpp2IlInjected.Token(Token = "0x400030C")]
	public static readonly Guid ACJAEGJAFMF;

	[Cpp2IlInjected.Token(Token = "0x400030D")]
	public static readonly Guid MBEHMKKKNAI;

	[Cpp2IlInjected.Token(Token = "0x400030E")]
	public static readonly Guid ONPPDOCPDDM;

	[Cpp2IlInjected.Token(Token = "0x400030F")]
	public static readonly Guid HHMFBOMPAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000310")]
	public static readonly Guid IJPIGKLOCNB;

	[Cpp2IlInjected.Token(Token = "0x4000311")]
	public static readonly Guid JCAJNDHKINE;

	[Cpp2IlInjected.Token(Token = "0x4000312")]
	public static readonly Guid PFHHFKGNCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000313")]
	public static readonly Guid ALNJKKGDPOO;

	[Cpp2IlInjected.Token(Token = "0x4000314")]
	public static readonly Guid IJAHAFGCIJA;

	[Cpp2IlInjected.Token(Token = "0x4000315")]
	public static readonly Guid HJEEEMDCAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000316")]
	public static readonly Guid IFDINGFCIFI;

	[Cpp2IlInjected.Token(Token = "0x4000317")]
	public static readonly Guid PNLKCGNBJOD;

	[Cpp2IlInjected.Token(Token = "0x4000318")]
	public static readonly Guid OPNCCGFJGLP;

	[Cpp2IlInjected.Token(Token = "0x4000319")]
	public static readonly Guid LELLHIHBJNI;

	[Cpp2IlInjected.Token(Token = "0x400031A")]
	public static readonly Guid EDAEAGPFJEO;

	[Cpp2IlInjected.Token(Token = "0x400031B")]
	public static readonly Guid KFJEGBKENPG;

	[Cpp2IlInjected.Token(Token = "0x400031C")]
	public static readonly Guid HDIDGIALOGA;

	[Cpp2IlInjected.Token(Token = "0x400031D")]
	public static readonly Guid PCOLIPMBFJA;

	[Cpp2IlInjected.Token(Token = "0x400031E")]
	public static readonly Guid OIJABHIKFLC;

	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public static readonly Guid HLKAHAEJHDB;

	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public static readonly Guid DJGLIGJDCGO;

	[Cpp2IlInjected.Token(Token = "0x4000321")]
	public static readonly Guid CCJJPDMHNOE;

	[Cpp2IlInjected.Token(Token = "0x4000322")]
	public static readonly Guid OOBGEGBKOHG;

	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public static readonly Guid NDOAPDDOBKH;

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly Guid IBLNHMKCPMP;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	public static readonly Guid NFMHBJGIJLE;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	public static readonly Guid LPKDBNAMIFG;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	public static readonly Guid OHPJLMJNPNB;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	public static readonly Guid OBDFEEGKGAH;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static readonly Guid EIGGJEIEENM;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static readonly Guid LHJLHGFJHOB;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static readonly Guid IKILJHIFJJB;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static readonly Guid GMOLJEOOPBO;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static readonly Guid HCHPLLGDFBM;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static readonly Guid OPHEAEHLEPH;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static readonly Guid CMCDCOOGJCO;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static readonly Guid GOAJMKNHCFL;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static readonly Guid GALDKEHMMKL;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static readonly Guid BEHJADFDFIO;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static readonly Guid APHACIGGKFL;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static readonly Guid MMBGECKOKIG;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static readonly Guid HBCECNJEFJK;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static readonly Guid HBEFIIINICB;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	public static readonly Guid BDIBCKGEHEG;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public static readonly Guid OPABMFNPOEA;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public static readonly Guid MEKAJKHBPGE;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static readonly Guid LODCBPNAFOB;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	public static readonly Guid OCGIDGAJDOI;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static readonly Guid KDMGDIELCIM;

	[Cpp2IlInjected.Token(Token = "0x400033D")]
	public static readonly Guid DIJPKFCOOEJ;

	[Cpp2IlInjected.Token(Token = "0x400033E")]
	public static readonly Guid FGEJMEHEIOG;

	[Cpp2IlInjected.Token(Token = "0x400033F")]
	public static readonly Guid JGKAEHPAIFN;

	[Cpp2IlInjected.Token(Token = "0x4000340")]
	public static readonly Guid ADECBFGDKMB;

	[Cpp2IlInjected.Token(Token = "0x4000341")]
	public static readonly Guid KNBJFENEGIF;

	[Cpp2IlInjected.Token(Token = "0x4000342")]
	public static readonly Guid PHPFKNLOACK;

	[Cpp2IlInjected.Token(Token = "0x4000343")]
	public static readonly Guid IGHDPNDGOLB;

	[Cpp2IlInjected.Token(Token = "0x4000344")]
	public static readonly Guid HGDIHFDLFFN;

	[Cpp2IlInjected.Token(Token = "0x4000345")]
	public static readonly Guid APEJIFGCGIP;

	[Cpp2IlInjected.Token(Token = "0x4000346")]
	public static readonly Guid KNFNEOJGMEG;

	[Cpp2IlInjected.Token(Token = "0x4000347")]
	public static readonly Guid JBFNBCKLIBE;

	[Cpp2IlInjected.Token(Token = "0x4000348")]
	public static readonly Guid HJAPKNEBHLC;

	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public static readonly Guid IGLGJHCCCDP;

	[Cpp2IlInjected.Token(Token = "0x400034A")]
	public static readonly Guid IECHBOFDBND;

	[Cpp2IlInjected.Token(Token = "0x400034B")]
	public static readonly Guid JOAHAAMBOLM;

	[Cpp2IlInjected.Token(Token = "0x400034C")]
	public static readonly Guid FFPGICCGBOK;

	[Cpp2IlInjected.Token(Token = "0x400034D")]
	public static readonly Guid LGJEFCDJEDA;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	public static readonly Guid KDNKOIJOEHJ;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	public static readonly Guid PGGJBGFPCMM;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly Guid IFHMLFKACLL;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	public static readonly Guid BCODEALNBPI;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public static readonly Guid AOBKKPOLLPO;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	public static readonly Guid KKMLACBJHPJ;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	public static readonly Guid ANPJIGMOBHO;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	public static readonly Guid GJLCBCACNKK;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	public static readonly Guid HLNOGJCJBNI;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	public static readonly Guid MGANCGOJKGC;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	public static readonly Guid KJKFFMCNFCO;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	public static readonly Guid CMKFLIEDHMJ;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	public static readonly Guid IHEOGMOKOHG;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	public static readonly Guid BCHLMKGKHKB;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public static readonly Guid BPKJJFCMPBF;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	public static readonly Guid FKFCMJJICNG;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	public static readonly Guid AOOCCLIKGDM;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	public static readonly Guid BNNEPJGLNBD;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	public static readonly Guid BFAMGECCOCD;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	public static readonly Guid DBBOGOAILDB;

	[Cpp2IlInjected.Token(Token = "0x4000362")]
	public static readonly Guid NBMNNAKKCMP;

	[Cpp2IlInjected.Token(Token = "0x4000363")]
	public static readonly Guid MGMMNINFNKO;

	[Cpp2IlInjected.Token(Token = "0x4000364")]
	public static readonly Guid NDPNBPMFKOF;

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	public static readonly Guid ACAHGJPMBPN;

	[Cpp2IlInjected.Token(Token = "0x4000366")]
	public static readonly Guid BDNCNMEKHPL;

	[Cpp2IlInjected.Token(Token = "0x4000367")]
	public static readonly Guid HLBJEABBDOE;

	[Cpp2IlInjected.Token(Token = "0x4000368")]
	public static readonly Guid GOIOCGGGAHG;

	[Cpp2IlInjected.Token(Token = "0x4000369")]
	public static readonly Guid PMEOMECBJDA;

	[Cpp2IlInjected.Token(Token = "0x400036A")]
	public static readonly Guid DNGMHHBNPEL;

	[Cpp2IlInjected.Token(Token = "0x400036B")]
	public static readonly Guid FCJCHEOMING;

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	public static readonly Guid BPEDFFIBKHN;

	[Cpp2IlInjected.Token(Token = "0x400036D")]
	public static readonly Guid MIDAEEEFMIA;

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	public static readonly Guid PNHIBGBLAFL;

	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public static readonly Guid OEIDFAFMBEN;

	[Cpp2IlInjected.Token(Token = "0x4000370")]
	public static readonly Guid NBCAGNHIMLH;

	[Cpp2IlInjected.Token(Token = "0x4000371")]
	public static readonly Guid AIOJFGGDMKG;

	[Cpp2IlInjected.Token(Token = "0x4000372")]
	public static readonly Guid EOKKBJKOKBP;

	[Cpp2IlInjected.Token(Token = "0x4000373")]
	public static readonly Guid FJGKALPHNBM;

	[Cpp2IlInjected.Token(Token = "0x4000374")]
	public static readonly Guid MMEFHAJNLBB;

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public static readonly Guid LMGMFENOAMI;

	[Cpp2IlInjected.Token(Token = "0x4000376")]
	public static readonly Guid DOFJJHHDKFD;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public static readonly Guid BDDKOCBHDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000378")]
	public static readonly Guid LOAGPEKCGHP;

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public static readonly Guid KBJMLLDPCEJ;

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public static readonly Guid DICNJLGHFBL;

	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public static readonly Guid CLNAAHILHDB;

	[Cpp2IlInjected.Token(Token = "0x400037C")]
	public static readonly Guid HBBOJJACAHF;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	public static readonly Guid GKJIMANCGAK;

	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public static readonly Guid KAJICEGJEML;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public static readonly Guid OIJMMLOMLNH;

	[Cpp2IlInjected.Token(Token = "0x4000380")]
	public static readonly Guid AGPOFMIIPAC;

	[Cpp2IlInjected.Token(Token = "0x4000381")]
	public static readonly Guid DCIDBPHBJJC;

	[Cpp2IlInjected.Token(Token = "0x4000382")]
	public static readonly Guid LKLMGDBAFDO;

	[Cpp2IlInjected.Token(Token = "0x4000383")]
	public static readonly Guid FEPCBJAINKK;

	[Cpp2IlInjected.Token(Token = "0x4000384")]
	public static readonly Guid MCLMGMMFMHD;

	[Cpp2IlInjected.Token(Token = "0x4000385")]
	public static readonly Guid ODCHDNIBOID;

	[Cpp2IlInjected.Token(Token = "0x4000386")]
	public static readonly Guid PCIAEAOBJAC;

	[Cpp2IlInjected.Token(Token = "0x4000387")]
	public static readonly Guid GGKBEOODEKF;

	[Cpp2IlInjected.Token(Token = "0x4000388")]
	public static readonly Guid KPGDADHBIAD;

	[Cpp2IlInjected.Token(Token = "0x4000389")]
	public static readonly Guid OHFDKNAKAKL;

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	public static readonly Guid LMHAAOEHIDC;

	[Cpp2IlInjected.Token(Token = "0x400038B")]
	public static readonly Guid OLHFGCPCPAL;

	[Cpp2IlInjected.Token(Token = "0x400038C")]
	public static readonly Guid JJACOHKLDIB;

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static readonly Guid MCAFAFLCPPG;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static readonly Guid DCNKDJDLCPM;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	public static readonly Guid MNFPJLHCNNK;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	public static readonly Guid NMEKONLDLHI;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public static readonly Guid HNECEMLGOGC;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	public static readonly Guid LFKFGPPNJBM;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	public static readonly Guid JIJCDFBIFFK;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static readonly Guid AGKFADOFAEF;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static readonly Guid PGHOBPMKAPH;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static readonly Guid KOOELMPAMDM;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static readonly Guid CILPJDBIMIF;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static readonly Guid JOMPNNIMCIN;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static readonly Guid ADGPPADGNLN;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly Guid FNFPCBLHGIC;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static readonly Guid JJHBAGBJKOG;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static readonly Guid EMMAJOOKNFM;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static readonly Guid CLMKALIKOIJ;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static readonly Guid MCHBEIHGANC;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static readonly Guid EJINNANPBPM;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static readonly Guid PICAMCAHGON;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static readonly Guid EFEBIGNILPF;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public static readonly Guid PBMIFKHHECP;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public static readonly Guid KLKJNEMCBLJ;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public static readonly Guid ECNFBAAHIAC;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static readonly Guid FGGJLHMODKC;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static readonly Guid AEMGIDIMOGM;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static readonly Guid OFPLNLNBFPI;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static readonly Guid JLHCFACNIOB;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	public static readonly Guid BPEBLBDEGCO;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	public static readonly Guid MNCFCKCFGPE;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static readonly Guid AGFDOHCEGAA;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public static readonly Guid MLAJGJPKFGL;

	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static readonly Guid LDKAICDIHNE;

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static readonly Guid MJLHBKOBDOP;

	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	public static readonly Guid DNPAIGGFLBC;

	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public static readonly Guid OPEHOELGNCK;

	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public static readonly Guid OKGHDMEMHOP;

	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public static readonly Guid ODNNMNJPDLB;

	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public static readonly Guid HOPLNPAOBAM;

	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	public static readonly Guid BIGEHFKGHNE;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	public static readonly Guid EMMEBACHOPL;

	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	public static readonly Guid NCBHDJJCGLC;

	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	public static readonly Guid BIOAKONKPCB;

	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	public static readonly Guid HNCEANOJGFG;

	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public static readonly Guid BDMMANHLFDB;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public static readonly Guid OOAFICGFAIM;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public static readonly Guid PHPDFBELAIM;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public static readonly Guid NEDGMGBHMKE;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public static readonly Guid HDMDNHMPGON;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public static readonly Guid NADNEPFLAOM;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public static readonly Guid AFCKANOHJFC;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public static readonly Guid IHADMOIEBID;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public static readonly Guid JJBLLFGLKJC;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public static readonly Guid DKIMKBCOCPL;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public static readonly Guid HJDLIIHLPEL;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public static readonly Guid AHPHOKOEAPI;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public static readonly Guid JOGDPBMIMHC;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public static readonly Guid JDEAAJEGEEO;

	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	public static readonly Guid MCPHOHFJIMH;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	public static readonly Guid EAFDFMGIDOI;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	public static readonly Guid OMGKOKFGEEI;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	public static readonly Guid BDLLCHDFNBJ;

	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public static readonly Guid IKJCFHJABJA;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public static readonly Guid OFGKJOHEBNL;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public static readonly Guid AMAABMEODHD;

	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	public static readonly Guid FBCJAEAFFEO;

	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	public static readonly Guid KCLFMMEDFDH;

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public static readonly Guid PFENDFIDBPE;

	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public static readonly Guid CIKKDAPFJKO;

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	public static readonly Guid LHBDMAKLEJI;

	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public static readonly Guid ALJEFLHNOMA;

	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public static readonly Guid EIJAMAHGJOB;

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public static readonly Guid KLNHMPLBJCB;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public static readonly Guid LHDAHLGBMDF;

	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	public static readonly Guid PACDLEJCLHC;

	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	public static readonly Guid CGFFBLCJKAB;

	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	public static readonly Guid IINBILACJEN;

	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public static readonly Guid CKAKBGOKBNO;

	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public static readonly Guid DEOPAGFHLAK;

	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public static readonly Guid AFIDJEBPNJG;

	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public static readonly Guid DBGDOMFGIHH;

	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public static readonly Guid AJNKBMNNLLP;

	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public static readonly Guid OCGNAGFBFLH;

	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public static readonly Guid ALLMJNNOGMP;

	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public static readonly Guid DPAOKMKFCIF;

	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public static readonly Guid KJIGHBFIJIB;

	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public static readonly Guid KLKFGIFGDEK;

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	public static readonly Guid EODLHHONAEI;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	public static readonly Guid PCIBFAIJDCL;

	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	public static readonly Guid ICGKDMHGONC;

	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public static readonly Guid IFFCKDAOBBC;

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public static readonly Guid EBCMOJENILD;

	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public static readonly Guid NODCEIIKMFN;

	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public static readonly Guid EALBBIHKNOP;

	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public static readonly Guid EOALFPFMNCH;

	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public static readonly Guid LHBDACDCACD;

	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public static readonly Guid CDEDFFPJODB;

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public static readonly Guid PHKLHDDKJMP;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public static readonly Guid HLGJNMNKFPF;

	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public static readonly Guid FHGLJLHLOCJ;

	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public static readonly Guid EPHFGAMELAG;

	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public static readonly Guid FFHNPDAFJFI;

	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public static readonly Guid KPECPNONKIL;

	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public static readonly Guid PEMBDIEDEME;

	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public static readonly Guid IICKEIKHPEF;

	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public static readonly Guid PCAENEODHDN;

	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public static readonly Guid IBLDJFGNGIM;

	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public static readonly Guid PPAKGPJIALI;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public static readonly Guid AFIOOBPLKNJ;

	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public static readonly Guid IIKAEOLPKOO;

	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public static readonly Guid HLIAPLLAAPE;

	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public static readonly Guid JKMHNBKFHAH;

	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public static readonly Guid LLFMNANMHHH;

	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public static readonly Guid FIJPELINELE;

	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public static readonly Guid KIOAHCNFFID;

	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public static readonly Guid ILMPMMGBNDF;

	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public static readonly Guid MPPEPGGNGBC;

	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public static readonly Guid IKLFCEAHKAE;

	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly Guid AFACBGNCKKC;

	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public static readonly Guid IIMHOIEKHNC;

	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public static readonly Guid NBBDIAOEPAO;

	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public static readonly Guid GDDPBPIBGOC;

	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public static readonly Guid DCOPGKOLNJB;

	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public static readonly Guid NABFHIBEJGM;

	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public static readonly Guid GNIJFHDCBOO;

	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public static readonly Guid BIBEBIKDEFM;

	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public static readonly Guid FJIEACEBDHO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public static readonly Guid OEOKBEEFLJE;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public static readonly Guid MHAGOAIJGOG;

	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public static readonly Guid PGJODENPGAH;

	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public static readonly Guid GDBLAIKBLEB;

	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public static readonly Guid ABNJBPMCGJI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	public static readonly Guid EKEHFHBPHBI;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	public static readonly Guid LILBJDEHNBC;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	public static readonly Guid OEFAHCEGOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	public static readonly Guid AHGAGHKOPPL;

	[Cpp2IlInjected.Token(Token = "0x4000415")]
	public static readonly Guid ECEDLFBDADB;

	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly Guid OBDALDKKKHM;

	[Cpp2IlInjected.Token(Token = "0x4000417")]
	public static readonly Guid FOOLCHIDEFN;

	[Cpp2IlInjected.Token(Token = "0x4000418")]
	public static readonly Guid DJKJHHBGOIO;

	[Cpp2IlInjected.Token(Token = "0x4000419")]
	public static readonly Guid GBNAJMHNGOC;

	[Cpp2IlInjected.Token(Token = "0x400041A")]
	public static readonly Guid ACOGDACHFKD;

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	public static readonly Guid AKBIPOPKEEC;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public static readonly Guid LFKJCGBNFDK;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	public static readonly Guid BPDLOKAFNHI;

	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public static readonly Guid FBCBMCKLOJG;

	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public static readonly Guid EHCGDPMMGNB;

	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public static readonly Guid CBNBFEBBKHF;

	[Cpp2IlInjected.Token(Token = "0x4000421")]
	public static readonly Guid OHPNJFMELDM;

	[Cpp2IlInjected.Token(Token = "0x4000422")]
	public static readonly Guid GFLNFNLBOLK;

	[Cpp2IlInjected.Token(Token = "0x4000423")]
	public static readonly Guid HNLCNLMDDLA;

	[Cpp2IlInjected.Token(Token = "0x4000424")]
	public static readonly Guid DHAHCAAJPON;

	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public static readonly Guid JLLEFJBFGHP;

	[Cpp2IlInjected.Token(Token = "0x4000426")]
	public static readonly Guid ACIIBIKIEDF;

	[Cpp2IlInjected.Token(Token = "0x4000427")]
	public static readonly Guid GNCLPKOCIGF;

	[Cpp2IlInjected.Token(Token = "0x4000428")]
	public static readonly Guid AHMAPPNPMAK;

	[Cpp2IlInjected.Token(Token = "0x4000429")]
	public static readonly Guid ADGPNDAAIEC;

	[Cpp2IlInjected.Token(Token = "0x400042A")]
	public static readonly Guid HPBPJPDFIIB;

	[Cpp2IlInjected.Token(Token = "0x400042B")]
	public static readonly Guid LMPGOBJFDIE;

	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public static readonly Guid MCIMJHACKBP;

	[Cpp2IlInjected.Token(Token = "0x400042D")]
	public static readonly Guid HOOJHBCOCGC;

	[Cpp2IlInjected.Token(Token = "0x400042E")]
	public static readonly Guid PGGCPDNFIHA;

	[Cpp2IlInjected.Token(Token = "0x400042F")]
	public static readonly Guid FLKHOBCIEIG;

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	public static readonly Guid IOPAKPHOAAL;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public static readonly Guid NLMBIEPBPHI;

	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public static readonly Guid DAIDCIDFMOE;

	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public static readonly Guid IMJKLDOINHA;

	[Cpp2IlInjected.Token(Token = "0x4000434")]
	public static readonly Guid DMPKBOLOLCM;

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	public static readonly Guid NHBHPCNDFOP;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	public static readonly Guid HEELIMNICDN;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	public static readonly Guid NAPBDBGKMAM;

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	public static readonly Guid BPFGKFJGBLD;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	public static readonly Guid IIKLFLKGKGL;

	[Cpp2IlInjected.Token(Token = "0x400043A")]
	public static readonly Guid NKHFOBEODAL;

	[Cpp2IlInjected.Token(Token = "0x400043B")]
	public static readonly Guid OGGAEMGKKBJ;

	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public static readonly Guid GBIKFGMONMI;

	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public static readonly Guid GJHAGNDFEJP;

	[Cpp2IlInjected.Token(Token = "0x400043E")]
	public static readonly Guid CGACAJAKBJL;

	[Cpp2IlInjected.Token(Token = "0x400043F")]
	public static readonly Guid GGEKGEDCGIN;

	[Cpp2IlInjected.Token(Token = "0x4000440")]
	public static readonly Guid JINHPCIOKMD;

	[Cpp2IlInjected.Token(Token = "0x4000441")]
	public static readonly Guid BEEGJOFKIHA;

	[Cpp2IlInjected.Token(Token = "0x4000442")]
	public static readonly Guid DHLNMPCJFHE;

	[Cpp2IlInjected.Token(Token = "0x4000443")]
	public static readonly Guid KCCKLLBPMDC;

	[Cpp2IlInjected.Token(Token = "0x4000444")]
	public static readonly Guid IAHFCGMAFMP;

	[Cpp2IlInjected.Token(Token = "0x4000445")]
	public static readonly Guid NLAKHCCAPDA;

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public static readonly Guid OKNBJFMPGGL;

	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public static readonly Guid DLBDOBIJLNC;

	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly Guid AMGPIBEFMDK;

	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public static readonly Guid PLGECJNGLHJ;

	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly Guid OCGALHICENA;

	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly Guid EFNPHNBANLI;

	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly Guid GHKDICNAKMC;

	[Cpp2IlInjected.Token(Token = "0x400044D")]
	public static readonly Guid ECBJJHNKMHM;

	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public static readonly Guid NJACMOECEOL;

	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public static readonly Guid GCIBJBKKNPL;

	[Cpp2IlInjected.Token(Token = "0x4000450")]
	public static readonly Guid BGIEMLENLGE;

	[Cpp2IlInjected.Token(Token = "0x4000451")]
	public static readonly Guid BHCJFJNCAGL;

	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public static readonly Guid CEAJFGDILKL;

	[Cpp2IlInjected.Token(Token = "0x4000453")]
	public static readonly Guid MABEGCCGNLI;

	[Cpp2IlInjected.Token(Token = "0x4000454")]
	public static readonly Guid PCDCDBKFJBK;

	[Cpp2IlInjected.Token(Token = "0x4000455")]
	public static readonly Guid PMKBMAEIOFN;

	[Cpp2IlInjected.Token(Token = "0x4000456")]
	public static readonly Guid GCCFPNIHOOF;

	[Cpp2IlInjected.Token(Token = "0x4000457")]
	public static readonly Guid CJGMAIGLNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000458")]
	public static readonly Guid BEAJOOOOEGL;

	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public static readonly Guid CHCIFHJEFKC;

	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public static readonly Guid MFHPIJNFCMF;

	[Cpp2IlInjected.Token(Token = "0x400045B")]
	public static readonly Guid PNJOJNJFNBM;

	[Cpp2IlInjected.Token(Token = "0x400045C")]
	public static readonly Guid POOIDOJACNE;

	[Cpp2IlInjected.Token(Token = "0x400045D")]
	public static readonly Guid MGJBDGCBLIO;

	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public static readonly Guid DGFNJDMPOJL;

	[Cpp2IlInjected.Token(Token = "0x400045F")]
	public static readonly Guid HOHBEAIMDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000460")]
	public static readonly Guid CJHAPHPFLDM;

	[Cpp2IlInjected.Token(Token = "0x4000461")]
	public static readonly Guid OADKNOAANBD;

	[Cpp2IlInjected.Token(Token = "0x4000462")]
	public static readonly Guid MCCJMDMEKKE;

	[Cpp2IlInjected.Token(Token = "0x4000463")]
	public static readonly Guid BBFANOHEACE;

	[Cpp2IlInjected.Token(Token = "0x4000464")]
	public static readonly Guid NEEMHDMCFNE;

	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public static readonly Guid DGNFDAEFPJB;

	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public static readonly Guid NKGLFDGIIFJ;

	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public static readonly Guid LALILKGOPIH;

	[Cpp2IlInjected.Token(Token = "0x4000468")]
	public static readonly Guid IMMKGHPBPMA;

	[Cpp2IlInjected.Token(Token = "0x4000469")]
	public static readonly Guid BENIMFKBJDI;

	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public static readonly Guid FHODGHGPMIK;

	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public static readonly Guid JPFNMPCBJAL;

	[Cpp2IlInjected.Token(Token = "0x400046C")]
	public static readonly Guid AIJOOHFAJLO;

	[Cpp2IlInjected.Token(Token = "0x400046D")]
	public static readonly Guid GAPGNNOJJOD;

	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public static readonly Guid GDONNEPOMPI;

	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public static readonly Guid MHFFBOAEPPO;

	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public static readonly Guid OEIPBGMHJCB;

	[Cpp2IlInjected.Token(Token = "0x4000471")]
	public static readonly Guid ECMKIJJCPDN;

	[Cpp2IlInjected.Token(Token = "0x4000472")]
	public static readonly Guid CLJAHACFBJC;

	[Cpp2IlInjected.Token(Token = "0x4000473")]
	public static readonly Guid NLJMMOENBLP;

	[Cpp2IlInjected.Token(Token = "0x4000474")]
	public static readonly Guid LOMJEBACINO;

	[Cpp2IlInjected.Token(Token = "0x4000475")]
	public static readonly Guid OONDOJIFIOO;

	[Cpp2IlInjected.Token(Token = "0x4000476")]
	public static readonly Guid BEJNLIBKJMD;

	[Cpp2IlInjected.Token(Token = "0x4000477")]
	public static readonly Guid DBCEGEBBEKP;

	[Cpp2IlInjected.Token(Token = "0x4000478")]
	public static readonly Guid AIKBLLJKBPL;

	[Cpp2IlInjected.Token(Token = "0x4000479")]
	public static readonly Guid PPGALIMPCDG;

	[Cpp2IlInjected.Token(Token = "0x400047A")]
	public static readonly Guid EHOHEGHKPNM;

	[Cpp2IlInjected.Token(Token = "0x400047B")]
	public static readonly Guid GONJDBJBEEG;

	[Cpp2IlInjected.Token(Token = "0x400047C")]
	public static readonly Guid MGGLLHOFHBL;

	[Cpp2IlInjected.Token(Token = "0x400047D")]
	public static readonly Guid NGEIFGKMEEC;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	public static readonly Guid EPAOELNHICH;

	[Cpp2IlInjected.Token(Token = "0x400047F")]
	public static readonly Guid PHFBJBLJBJC;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	public static readonly Guid HPCFMACOFPE;

	[Cpp2IlInjected.Token(Token = "0x4000481")]
	public static readonly Guid PAJJIDCGPKF;

	[Cpp2IlInjected.Token(Token = "0x4000482")]
	public static readonly Guid PMAOENEJGLP;

	[Cpp2IlInjected.Token(Token = "0x4000483")]
	public static readonly Guid FPCMDJGBMLA;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public static readonly Guid BGCLEFCFOCB;

	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public static readonly Guid IFKGLMNFBNG;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	public static readonly Guid BOCHPLFKBFE;

	[Cpp2IlInjected.Token(Token = "0x4000487")]
	public static readonly Guid NHCDMLONEHG;

	[Cpp2IlInjected.Token(Token = "0x4000488")]
	public static readonly Guid HPFPFMKCMHD;

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	public static readonly Guid ACAELGHEFFK;

	[Cpp2IlInjected.Token(Token = "0x400048A")]
	public static readonly Guid ILJNNFDKFJJ;

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	public static readonly Guid JCBGFAPHLNN;

	[Cpp2IlInjected.Token(Token = "0x400048C")]
	public static readonly Guid IMEMCBIHBMI;

	[Cpp2IlInjected.Token(Token = "0x400048D")]
	public static readonly Guid JEJJHKNBHGI;

	[Cpp2IlInjected.Token(Token = "0x400048E")]
	public static readonly Guid GKAEGPEHODO;

	[Cpp2IlInjected.Token(Token = "0x400048F")]
	public static readonly Guid IFJDGINOEDA;

	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public static readonly Guid JHLNJDNPHIG;

	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public static readonly Guid EBHEDOHFIGF;

	[Cpp2IlInjected.Token(Token = "0x4000492")]
	public static readonly Guid PJFELODGLAM;

	[Cpp2IlInjected.Token(Token = "0x4000493")]
	public static readonly Guid CCMKMICIMAN;

	[Cpp2IlInjected.Token(Token = "0x4000494")]
	public static readonly Guid PKPJPDLPAMA;

	[Cpp2IlInjected.Token(Token = "0x4000495")]
	public static readonly Guid DOPJJEFBKDP;

	[Cpp2IlInjected.Token(Token = "0x4000496")]
	public static readonly Guid CNIHPEMJKLM;

	[Cpp2IlInjected.Token(Token = "0x4000497")]
	public static readonly Guid AGKBOPMOJIG;

	[Cpp2IlInjected.Token(Token = "0x4000498")]
	public static readonly Guid LABLLDGCCBH;

	[Cpp2IlInjected.Token(Token = "0x4000499")]
	public static readonly Guid AJFHELMILNA;

	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public static readonly Guid DIKGHKOGLCC;

	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public static readonly Guid MOHOPHNPNAE;

	[Cpp2IlInjected.Token(Token = "0x400049C")]
	public static readonly Guid DCGMKDLDKHE;

	[Cpp2IlInjected.Token(Token = "0x400049D")]
	public static readonly Guid NPCJANFBDPB;

	[Cpp2IlInjected.Token(Token = "0x400049E")]
	public static readonly Guid HAGIAGBBCAA;

	[Cpp2IlInjected.Token(Token = "0x400049F")]
	public static readonly Guid MMJICBADLCG;

	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	public static readonly Guid FEAGLHDLCFO;

	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	public static readonly Guid EDNGHMEKING;

	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	public static readonly Guid PGELAGBILIJ;

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	public static readonly Guid DLHBHDMMBNF;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	public static readonly Guid IPFMEFMBPHI;

	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	public static readonly Guid HGGPDDAEIPM;

	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	public static readonly Guid DAKIIGCLFBI;

	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	public static readonly Guid KGENLGKLOBO;

	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	public static readonly Guid GFGHILDAECD;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	public static readonly Guid GLABGDGPIKK;

	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	public static readonly Guid MOCGCFNKPHL;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	public static readonly Guid KMFKLLPNOMB;

	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public static readonly Guid DINPHBPBBFK;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public static readonly Guid MLGLCOCMOMD;

	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly Guid LEGHLALDKII;

	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly Guid JCENHFBANPO;

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public static readonly Guid ACFLECAFDPL;

	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public static readonly Guid CNGOCFJMPNF;

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public static readonly Guid ONJMJDCDNBM;

	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public static readonly Guid FIOCNIMGDMB;

	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public static readonly Guid MIDHMPFFIJG;

	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public static readonly Guid DFKAKDCOENF;

	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public static readonly Guid IHJBODKNDKC;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	public static readonly Guid NJJHMPKFCBA;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	public static readonly Guid GLIJAMBDELM;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	public static readonly Guid FIEAIEOLKBB;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	public static readonly Guid GACGJINKEBC;

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	public static readonly Guid ADGIBMOKKAH;

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	public static readonly Guid DFGNJJJGAPM;

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	public static readonly Guid LBGADMNBLEC;

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	public static readonly Guid ACNCEEHIGPJ;

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	public static readonly Guid JFDKCPKJGPO;

	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	public static readonly Guid MNIMNHBKIOJ;

	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	public static readonly Guid KKENCIEBNPJ;

	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	public static readonly Guid IEKPBCGFPPP;

	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	public static readonly Guid DDKGKNCNNOD;

	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	public static readonly Guid BKNPONGOIFA;

	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	public static readonly Guid DOCECFJDEIM;

	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	public static readonly Guid IOPEKCPALIM;

	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	public static readonly Guid EPHEGAFNKJC;

	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	public static readonly Guid LNNADKNCHHB;

	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	public static readonly Guid APENFKDOAIC;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	public static readonly Guid IPBBCKFFLHG;

	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	public static readonly Guid JLOEDKKMBAB;

	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	public static readonly Guid LOPEHPJPPMF;

	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	public static readonly Guid HILDBOPEAPG;

	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	public static readonly Guid GGOFLIIKOLM;

	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	public static readonly Guid LJBOOGGHMGN;

	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	public static readonly Guid LDLPMPFMOID;

	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	public static readonly Guid NHILGLJMNGO;

	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public static readonly Guid POKOMADOCDO;

	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public static readonly Guid GOICAGDLJBH;

	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public static readonly Guid BMCDNIODMME;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public static readonly Guid NGOCEOBOBPN;

	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public static readonly Guid DMNKLPMJFEL;

	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public static readonly Guid OIJAKHDJBDH;

	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	public static readonly Guid FFEEGPBGLLN;

	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	public static readonly Guid CFICFMOEFGD;

	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	public static readonly Guid JFLEMNJDGBN;

	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public static readonly Guid GBOBCCHFIPP;

	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public static readonly Guid GOCMLMCBHNI;

	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public static readonly Guid JBBHIHBIBNC;

	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public static readonly Guid LNFPIEGCPFM;

	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public static readonly Guid NFIKHCHDMDK;

	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public static readonly Guid DKGICAGIEHA;

	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public static readonly Guid COIAFBDEJBF;

	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public static readonly Guid FKAKOHJKCMB;

	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public static readonly Guid FPLPKIBOJIO;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public static readonly Guid MBHFGJOAGJO;

	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public static readonly Guid LNCIOABPFDO;

	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public static readonly Guid DCFJFNOBOBP;

	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public static readonly Guid JOHFNAJCPDE;

	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	public static readonly Guid NLODGAJOPFM;

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	public static readonly Guid NNAAGLFNACB;

	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	public static readonly Guid BDJHDBGJFCP;

	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public static readonly Guid MGOKANCNJKN;

	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private static readonly Dictionary<Guid, NIMOGNKKNOB> HLAJKGCMMKO;

	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private static readonly Dictionary<NIMOGNKKNOB, Guid> MNOGCBKKFKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IReadOnlyDictionary<Guid, NIMOGNKKNOB> KANGHPPFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x686B120", Offset = "0x6869B20", VA = "0x18686B120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IReadOnlyDictionary<NIMOGNKKNOB, Guid> LNMAGNHBBCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x686B0C0", Offset = "0x6869AC0", VA = "0x18686B0C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BOBHBNJLHOP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6853F60", Offset = "0x6852960", VA = "0x186853F60")]
	public static bool GFADOONDCGG(FOKFGHKJMNH GBKPPKDHJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6853BB0", Offset = "0x68525B0", VA = "0x186853BB0")]
	private static bool GFADOONDCGG(BBIHDCMBHHK EGLLCDAKFDC, FOKFGHKJMNH GBKPPKDHJJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CMFFKGIJCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	public readonly JJFIGGLPIGB PPOJOFFDOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public readonly IEnumerable<CLPMHIGOAIJ> ANFPCBCBGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	public readonly IReadOnlyList<CLPMHIGOAIJ> DMMHPBOOLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	public readonly OMNCLBBEMMM<MBFOKBNJOGA> CNONFEAJNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	public readonly IReadOnlyList<KGKBCIBEALI<CBPAPLPKJIA>> ILOLHMBLDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	public readonly ByteString ELCBPEANFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	public readonly IHNHOJFCAGB GHPIDJMDBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	public readonly bool GDGBGJKNGBB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6855710", Offset = "0x6854110", VA = "0x186855710")]
	public CMFFKGIJCMI(JJFIGGLPIGB CNIIOPGOJLJ, IEnumerable<CLPMHIGOAIJ> KKBIMFOFNGE, IReadOnlyList<CLPMHIGOAIJ> KMFGLBNFGFG, OMNCLBBEMMM<MBFOKBNJOGA> AHGHNIKKDCB, IReadOnlyList<KGKBCIBEALI<CBPAPLPKJIA>> BIILJCKAIMK, ByteString KOADJAOGDAM, IHNHOJFCAGB LJBKIKDAFAG, bool LHFDPEBGNAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HCNEIKNBNCD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(JCMNDGEIIDM LINJEFIAFHO, [Out] Dictionary<int, int> BEMKPCOBMPC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(CCFJLIPPODM AHPJAMFDMOD, HBDMDNBJLMN ODFMJNJDFPC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NPCGBDMKPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	public readonly Guid ODNHAOIFPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private readonly Dictionary<Guid, Guid> HNLOMFBHOPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<Guid, Guid> FLCOMCGAGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x398CB80", Offset = "0x398B580", VA = "0x18398CB80")]
	private NPCGBDMKPBF([In] Guid FPEHLFHNOKK, Dictionary<Guid, Guid> HHLPKJODEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x686AB70", Offset = "0x6869570", VA = "0x18686AB70")]
	public static NPCGBDMKPBF JAOEEMAEEPC(IReadOnlyDictionary<Guid, Guid> FNFOACPOHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x686AB80", Offset = "0x6869580", VA = "0x18686AB80")]
	public static NPCGBDMKPBF KICMCMLAMMI(IEnumerable<KeyValuePair<Guid, Guid>> FNFOACPOHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x686AAC0", Offset = "0x68694C0", VA = "0x18686AAC0")]
	private static Dictionary<Guid, Guid> GNLIOFODNOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x686AF30", Offset = "0x6869930", VA = "0x18686AF30")]
	public Guid NHKMEMDEKAN([In] Guid BMIGIGGJPJD, bool BNKFKNFODHE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x686AA50", Offset = "0x6869450", VA = "0x18686AA50")]
	public bool BODBHNFONDI([In] Guid DKFNFHGODON, [Out] Guid KHBOBOKNEEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ELDNMMEIFHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool INMPDDDBHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGBBAPGEGII(ByteString OEECENNMMAJ, NPCGBDMKPBF KMIEFHNBABG, [In] UniformTRS MHMOHGLIJFC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KDCHLGCMFGD
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
public class DKMLECNJPPC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14FAAE0", Offset = "0x14F94E0", VA = "0x1814FAAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long KNBAAJDAKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x100EA70", Offset = "0x100D470", VA = "0x18100EA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long AAOEKPEAHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68557A0", Offset = "0x68541A0", VA = "0x1868557A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6549080", Offset = "0x6547A80", VA = "0x186549080")]
	public DKMLECNJPPC(long IHGHLPOONHD, long EOLEDCNIOAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HIDNHCACJKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private Dictionary<Guid, DKMLECNJPPC> ILAKDJJDHKJ;

	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	public static Dictionary<Guid, int> IPFOGIOJIHN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long NGPJKGPMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x100EA70", Offset = "0x100D470", VA = "0x18100EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long NPDNNCJLJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10742F0", Offset = "0x1072CF0", VA = "0x1810742F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6856010", Offset = "0x6854A10", VA = "0x186856010")]
	public static HIDNHCACJKC NAELJEKOFDA(JJFIGGLPIGB ILIAHIGMKEA, KGKBCIBEALI<MBFOKBNJOGA> ONOJGPGNBBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6855D40", Offset = "0x6854740", VA = "0x186855D40")]
	private void EEHAENGFBJK(PNBAGIHICGF LLENHGPBNOK, long LDFPIPAGGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6869FC0", Offset = "0x68689C0", VA = "0x186869FC0")]
	public HIDNHCACJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EGIPPAFJMNL
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	public static readonly HashSet<NIMOGNKKNOB> ABBBAFFOECE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class BKIJNJFFJJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<Guid, Guid> PAMBEMPEPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<Guid, Guid> EMLFPGLBPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85DA50", VA = "0x18085F050")]
	public BKIJNJFFJJH(IReadOnlyDictionary<Guid, Guid> LIIDGFNFNOE, IReadOnlyDictionary<Guid, Guid> HCCEEGEICCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AJAKKOPGKPH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x684F260", Offset = "0x684DC60", VA = "0x18684F260")]
	public static NKJFELDKILB JKMELACOKHG([In] CMFFKGIJCMI JPMCAGEILEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x684EC00", Offset = "0x684D600", VA = "0x18684EC00")]
	private static void JJEOPNIMNFN(NKJFELDKILB CDGFPMKAKKF, [In] CMFFKGIJCMI BKNDIBPHIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x684F3E0", Offset = "0x684DDE0", VA = "0x18684F3E0")]
	public static CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA> MIILLICGEJD(NKJFELDKILB CDGFPMKAKKF, FKIDNLLDNAD NOCNMNEPBPK, NPCGBDMKPBF? NEGOOGBOKEM)
	{
		return default(CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x684E680", Offset = "0x684D080", VA = "0x18684E680")]
	private static void CBIHLDKDLLC(NKJFELDKILB CDGFPMKAKKF, NPCGBDMKPBF? ONHAIMNMPMD, FKIDNLLDNAD NOCNMNEPBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6850C10", Offset = "0x684F610", VA = "0x186850C10")]
	private static void NBKEPEKNOBF(NKJFELDKILB CDGFPMKAKKF, FKIDNLLDNAD NOCNMNEPBPK, IReadOnlyCollection<ByteString>? KDLLCGHNPLC, IReadOnlyCollection<ByteString>? PHPCGLNINEG, IReadOnlyCollection<ByteString>? EJMGIIKEBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x684DF50", Offset = "0x684C950", VA = "0x18684DF50")]
	private static bool APNCFMEMMIF(NKJFELDKILB CDGFPMKAKKF, CCFJLIPPODM AHPJAMFDMOD, FKIDNLLDNAD NOCNMNEPBPK, [Out][NotNullWhen(false)] string? GGEHLADLJHF, [Out] Dictionary<int, int> BEMKPCOBMPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x684E920", Offset = "0x684D320", VA = "0x18684E920")]
	private static Dictionary<Guid, BBIHDCMBHHK> IDHOFGFNBJB(NKJFELDKILB CDGFPMKAKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x684E5E0", Offset = "0x684CFE0", VA = "0x18684E5E0")]
	private static void BCJDJEHBDAJ(bool NFMPHBFDKEA, CLPMHIGOAIJ OOCANEMEHMO, Dictionary<Guid, Guid> PJHAKAOJACO, NPCGBDMKPBF NNDLLGGGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6850C80", Offset = "0x684F680", VA = "0x186850C80")]
	private static void NFEEIENNJGD(CLPMHIGOAIJ OOCANEMEHMO, Guid FJGJOCKJEPL, JLPKCCHHOBF? LOEAAGGJLEJ, Dictionary<Guid, BBIHDCMBHHK> BGNKCOMEAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6850F10", Offset = "0x684F910", VA = "0x186850F10")]
	private static void OOBDPLBDPLC(IEnumerable<CLPMHIGOAIJ> AGFJAJICAFC, IReadOnlyCollection<ByteString> KDLLCGHNPLC, IReadOnlyCollection<ByteString> PHPCGLNINEG, IReadOnlyCollection<ByteString> EJMGIIKEBJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FKIDNLLDNAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	public bool NFMPHBFDKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	public IHNHOJFCAGB LJBKIKDAFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	public JLPKCCHHOBF? LOEAAGGJLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	public JLPKCCHHOBF? ECOHEKEHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	public JJFIGGLPIGB LGBHEGCIDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	public KDCHLGCMFGD EOKGOJJGLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public HCNEIKNBNCD FPPGIGAMJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public ELDNMMEIFHD CPMCFFGOOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public KGKBCIBEALI<MBFOKBNJOGA> GADKFKOOJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public FMFKDINCNHA JFJBMODINLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public List<CLPMHIGOAIJ> GKFCIBKMPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public Dictionary<string, object> NCKKEOPPNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public HABHJCFDBAE OIEIBAOFOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public bool HDCJGFKCFLN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool NMJPNOKBNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6855A60", Offset = "0x6854460", VA = "0x186855A60")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JLPKCCHHOBF
{
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private const float DPMOGHINGFH = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public Vector3 HGDCPNGLIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public Quaternion LCDJINCAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public float CDPPGBMBKAI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Matrix4x4 EHBDPGFEMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x686A0E0", Offset = "0x6868AE0", VA = "0x18686A0E0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public UniformTRS MDOFMCGLJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x686A680", Offset = "0x6869080", VA = "0x18686A680")]
		get
		{
			return default(UniformTRS);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB25FB0", Offset = "0xB249B0", VA = "0x180B25FB0")]
	public JLPKCCHHOBF(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float CDPPGBMBKAI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x686A980", Offset = "0x6869380", VA = "0x18686A980")]
	public JLPKCCHHOBF(UniformTRS KENMMCDCGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x686A390", Offset = "0x6868D90", VA = "0x18686A390")]
	public static JLPKCCHHOBF GHHLAHNHJGF(JLPKCCHHOBF BMBBFJPOJEB, JLPKCCHHOBF IHOICACLCIL)
	{
		return default(JLPKCCHHOBF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x686A370", Offset = "0x6868D70", VA = "0x18686A370")]
	public static JLPKCCHHOBF GCLAHEGAFFN((Vector3, Quaternion, float) LINJEFIAFHO)
	{
		return default(JLPKCCHHOBF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x686A1F0", Offset = "0x6868BF0", VA = "0x18686A1F0")]
	public static JLPKCCHHOBF GCLAHEGAFFN(Matrix4x4 FPPOIAGEIML)
	{
		return default(JLPKCCHHOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x686A8F0", Offset = "0x68692F0", VA = "0x18686A8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x686A6C0", Offset = "0x68690C0", VA = "0x18686A6C0")]
	public JLPKCCHHOBF LMJCOLJMHLF(Matrix4x4 FMAJPAMCPCL)
	{
		return default(JLPKCCHHOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x686A610", Offset = "0x6869010", VA = "0x18686A610")]
	public static JLPKCCHHOBF IMCBHNJDELL(Vector3 HGDCPNGLIKJ)
	{
		return default(JLPKCCHHOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x686A050", Offset = "0x6868A50", VA = "0x18686A050")]
	public readonly GGMPGLNPCBC BGKEDLKNCNP()
	{
		return default(GGMPGLNPCBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EPGOHFPPGKC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x68559D0", Offset = "0x68543D0", VA = "0x1868559D0")]
	public static JLPKCCHHOBF DPDGBGOPMCB([In] this GGMPGLNPCBC HIKEOGPAJAF)
	{
		return default(JLPKCCHHOBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct GLBFMPMGNOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public readonly LPEIMEOBPJE GKALJEBOGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private readonly IKKDIOOIDLA BMDBNDKFJMP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86310", VA = "0x180D87910")]
	private GLBFMPMGNOA(LPEIMEOBPJE OIOHIJOOPGO, IKKDIOOIDLA GAHKOMMOEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6855CD0", Offset = "0x68546D0", VA = "0x186855CD0")]
	public OMJGEBPKLHO JDIAJCJABGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6855C20", Offset = "0x6854620", VA = "0x186855C20")]
	public static CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA> FJAAFKPDAIA(GAHFFFJJFCN<MOOMEEOMEEK> GAHKOMMOEFA)
	{
		return default(CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6855AB0", Offset = "0x68544B0", VA = "0x186855AB0")]
	public static CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA> FJAAFKPDAIA(OMJGEBPKLHO GAHKOMMOEFA)
	{
		return default(CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6855B60", Offset = "0x6854560", VA = "0x186855B60")]
	public static CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA> FJAAFKPDAIA(string CPHJFLBHKNA)
	{
		return default(CIKECDEKJAI<BKIJNJFFJJH, GLBFMPMGNOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum LPEIMEOBPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	PrepareTemplateForClone
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BBOLDBLJMMJ : IDisposable, HJDCABNHDIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private NativeList<BEEODNIICBD> PJAFAMKKBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private float PCFDMCMFONO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DEIDGEMLJNI LAIAKDHPJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		[CompilerGenerated]
		get
		{
			return default(DEIDGEMLJNI);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MJOAAHKJJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68534E0", Offset = "0x6851EE0", VA = "0x1868534E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EEMGODGEJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6852E10", Offset = "0x6851810", VA = "0x186852E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public List<JCELHGJAGMP> IIKDFOONNIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int PKKAKJDFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6853000", Offset = "0x6851A00", VA = "0x186853000", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float BLCJJEOMNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6852EC0", Offset = "0x68518C0", VA = "0x186852EC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6853B20", Offset = "0x6852520", VA = "0x186853B20")]
	public BBOLDBLJMMJ(DEIDGEMLJNI GAEADNFFCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68521A0", Offset = "0x6850BA0", VA = "0x1868521A0", Slot = "9")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6853650", Offset = "0x6852050", VA = "0x186853650")]
	public Vector3 PELFKKEGDIA(int AFLJKADDJPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6853040", Offset = "0x6851A40", VA = "0x186853040", Slot = "6")]
	public Quaternion MIEEFLBBHBB(int AFLJKADDJPM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6852E20", Offset = "0x6851820", VA = "0x186852E20", Slot = "5")]
	public Vector3 IKIFEHDGBLA(int AFLJKADDJPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6853420", Offset = "0x6851E20", VA = "0x186853420", Slot = "7")]
	public float NODABNJNJCN(int AFLJKADDJPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6852520", Offset = "0x6850F20", VA = "0x186852520")]
	public void GPKJEKELICC(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float EOGPEOAFBNO, bool BEGEGFCFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6853480", Offset = "0x6851E80", VA = "0x186853480")]
	private bool NOFBDNJIJAE(int IBIOMAJIBPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68534F0", Offset = "0x6851EF0", VA = "0x1868534F0")]
	public void OEAJALMOFPM(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float EOGPEOAFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68522D0", Offset = "0x6850CD0", VA = "0x1868522D0")]
	public void FIBMMEOCHOL(int IBIOMAJIBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6851860", Offset = "0x6850260", VA = "0x186851860")]
	public void BBOCGAACGMF(int IBIOMAJIBPB, Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD, float EOGPEOAFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6853270", Offset = "0x6851C70", VA = "0x186853270")]
	public void NIKIEDEHONO(int IBIOMAJIBPB, float3 HGDCPNGLIKJ, quaternion LCDJINCAHMD, float EOGPEOAFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68523D0", Offset = "0x6850DD0", VA = "0x1868523D0")]
	public void GAAGGOGEALJ(int IBIOMAJIBPB, Vector3 HGDCPNGLIKJ, float EOGPEOAFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6853110", Offset = "0x6851B10", VA = "0x186853110")]
	public void NBFBPDKPLKD(int IBIOMAJIBPB, Vector3 NFFLDAHKGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68519B0", Offset = "0x68503B0", VA = "0x1868519B0")]
	public static Quaternion CDDNFGIMAHC(Quaternion OBKMAHDAHKH, int IBIOMAJIBPB, float CNBGIAJLBJF, HJDCABNHDIJ OAEELHFAOGE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68513C0", Offset = "0x684FDC0", VA = "0x1868513C0")]
	public Bounds ADNPMEHDEEI(Transform FMAJPAMCPCL)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6852360", Offset = "0x6850D60", VA = "0x186852360", Slot = "10")]
	public virtual void FINCHIHDFLJ(bool KDAOHDCMGMC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6852200", Offset = "0x6850C00", VA = "0x186852200")]
	public NativeList<BEEODNIICBD> EFPEEODBDDN(float JIBIPLAADBH = 1f)
	{
		return default(NativeList<BEEODNIICBD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JCELHGJAGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	public float3 PHJFFHJCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	public float GCPNMPPNPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	public quaternion GMILEANOFIN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x686E9D0", Offset = "0x686D3D0", VA = "0x18686E9D0")]
	public JCELHGJAGMP(Vector3 BCPGICOCGEJ, Quaternion OBKMAHDAHKH, float EOGPEOAFBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x686E460", Offset = "0x686CE60", VA = "0x18686E460")]
	public Quaternion JKCFJCHKIEP(Vector3 FCBGHELDCII)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x686E6D0", Offset = "0x686D0D0", VA = "0x18686E6D0")]
	public JCELHGJAGMP MKKHHEDBAII(Vector3 HIEBEFGABCG, Vector3 MDNCDOKEHED, Vector3 PFENNDOHCJM)
	{
		return default(JCELHGJAGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x686E520", Offset = "0x686CF20", VA = "0x18686E520")]
	public OGHJPEDAPMA KPCFKJNLDDL(Vector3 FCBGHELDCII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class DIKCNNGOBCO : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x686C110", Offset = "0x686AB10", VA = "0x18686C110", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x686BB40", Offset = "0x686A540", VA = "0x18686BB40")]
	private void BBLMJBPOPMK(Dictionary<Guid, Guid> ICCMKOBOFIB, LIFAMKPBCPB LMAGINCLLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x686B860", Offset = "0x686A260", VA = "0x18686B860")]
	private void BBLMJBPOPMK(Dictionary<Guid, Guid> ICCMKOBOFIB, KLIFGFOICDI HBPLHDMKGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x686B8C0", Offset = "0x686A2C0", VA = "0x18686B8C0")]
	private void BBLMJBPOPMK(Dictionary<Guid, Guid> ICCMKOBOFIB, LGCAACJNKPM MMFHPDKOKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public DIKCNNGOBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IDJGBCIMBJG : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x686DA80", Offset = "0x686C480", VA = "0x18686DA80", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public IDJGBCIMBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class JLGALAMAFHC : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x686EA50", Offset = "0x686D450", VA = "0x18686EA50", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public JLGALAMAFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class EILIHFLFPII : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x686C190", Offset = "0x686AB90", VA = "0x18686C190", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public EILIHFLFPII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class ALJFNJDPMFB : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x686B230", Offset = "0x6869C30", VA = "0x18686B230", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public ALJFNJDPMFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class IDFOGCOKMMH : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x686D940", Offset = "0x686C340", VA = "0x18686D940", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public IDFOGCOKMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class DIGCCLMFNIJ : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x686B6C0", Offset = "0x686A0C0", VA = "0x18686B6C0", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public DIGCCLMFNIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ELGCFGAEOHA : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x686C2E0", Offset = "0x686ACE0", VA = "0x18686C2E0", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public ELGCFGAEOHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KGGAJMLCIOH : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x686F060", Offset = "0x686DA60", VA = "0x18686F060", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KGGAJMLCIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class CAPJMDPELPE : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x686B450", Offset = "0x6869E50", VA = "0x18686B450", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public CAPJMDPELPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JOPMIOGADNA : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x686EF60", Offset = "0x686D960", VA = "0x18686EF60", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public JOPMIOGADNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class MDOBFAAIGDL : COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	public static readonly PNPOGLPEGCB PIJNCOJONDM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x686F400", Offset = "0x686DE00", VA = "0x18686F400", Slot = "4")]
	public void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MDOBFAAIGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FOKFGHKJMNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	public CCFJLIPPODM DMDAEILPBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	public GMLDAHHCABJ AJOAPCJAGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	public Dictionary<int, int> CDKKHHPJMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	public Dictionary<Guid, Guid> KBCLLAKEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	public HABHJCFDBAE OIEIBAOFOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	public bool JDGOCFMKIOM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface COMBNHHGOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMADOJJNIKK(CONBGIGHPNG LLLHPMMENLL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class POCLBFIKDMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private static readonly COMBNHHGOLP[] PCENGCDCADH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6870AD0", Offset = "0x686F4D0", VA = "0x186870AD0")]
	public static void GKMKMNHANNL(CLPMHIGOAIJ LINJEFIAFHO, Dictionary<Guid, Guid> OHCPFIMIIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6870FE0", Offset = "0x686F9E0", VA = "0x186870FE0")]
	public static void OIECAHOGFHO(CLPMHIGOAIJ? LINJEFIAFHO, NPCGBDMKPBF LBHGKHPEOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6870D60", Offset = "0x686F760", VA = "0x186870D60")]
	public static void HJCKHJHCFLL(CLPMHIGOAIJ? LINJEFIAFHO, NPCGBDMKPBF NNDLLGGGOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6870700", Offset = "0x686F100", VA = "0x186870700")]
	public static void GFADOONDCGG(CONBGIGHPNG LLLHPMMENLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CONBGIGHPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	public CCFJLIPPODM GGAFKGFAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	public CLPMHIGOAIJ OOCANEMEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	public Dictionary<int, int> CDKKHHPJMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	public Dictionary<Guid, Guid> KBCLLAKEFAP;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x686B610", Offset = "0x686A010", VA = "0x18686B610")]
	public Guid JGNBJHGOJBM(Guid BMIGIGGJPJD)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HABHJCFDBAE
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int EOKJHNNGMOH, [Out] Guid AJDLHLGCKNN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class HCPPCCJPAPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private readonly HashSet<string> IGCHFCECBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private readonly Dictionary<long, int> CNFFMOCJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private readonly HashSet<Guid> ELFFCHLNDLH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IReadOnlyCollection<string> GGAGFAHHLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyDictionary<long, int> PCMMCOJMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x686C9A0", Offset = "0x686B3A0", VA = "0x18686C9A0")]
	public static HCPPCCJPAPN MDNOBPMCPMI(CKJAAMAMPKA FCMADEBOIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x686C930", Offset = "0x686B330", VA = "0x18686C930")]
	public static HCPPCCJPAPN LDOPLIDJGBA(NKJFELDKILB OGNMEMPIHHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x686C7B0", Offset = "0x686B1B0", VA = "0x18686C7B0")]
	public static HCPPCCJPAPN KELGNDKCAFP(IEnumerable<string> IGCHFCECBHD, IDictionary<long, int> JDMLHOKHBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x686D6E0", Offset = "0x686C0E0", VA = "0x18686D6E0")]
	private HCPPCCJPAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x686D800", Offset = "0x686C200", VA = "0x18686D800")]
	private HCPPCCJPAPN(IEnumerable<string> IGCHFCECBHD, IDictionary<long, int> JDMLHOKHBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x686CD40", Offset = "0x686B740", VA = "0x18686CD40")]
	private void PEJHKDNOIMH(CKJAAMAMPKA FCMADEBOIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x686D320", Offset = "0x686BD20", VA = "0x18686D320")]
	private void PEJHKDNOIMH(NKJFELDKILB OGNMEMPIHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x686CA10", Offset = "0x686B410", VA = "0x18686CA10")]
	private void PEJHKDNOIMH(KDBOOPNNIJF? GFFCILHEGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x686D510", Offset = "0x686BF10", VA = "0x18686D510")]
	private void PEJHKDNOIMH(OCLHCEIPGFB? LLENHGPBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x686CF30", Offset = "0x686B930", VA = "0x18686CF30")]
	private void PEJHKDNOIMH(CLPMHIGOAIJ? OOCANEMEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x686C570", Offset = "0x686AF70", VA = "0x18686C570")]
	private void ELKDCIIBGCH(string? EOECEMBLGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x686C6D0", Offset = "0x686B0D0", VA = "0x18686C6D0")]
	private void HOICKNLELHJ(LOLBALEJJPK? ANBPDKALDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x686C5E0", Offset = "0x686AFE0", VA = "0x18686C5E0")]
	private void HOICKNLELHJ(EOFGNLCAIFD? ANBPDKALDDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct NGBJMNDKJEF
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JOAJLILOPCL : IDictionaryEnumerator, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private readonly IEnumerator<DictionaryEntry> OBCBMANCKCF;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DictionaryEntry FMDGDNDKPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x686ED30", Offset = "0x686D730", VA = "0x18686ED30", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public object HJDGBLHMFIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x686EE00", Offset = "0x686D800", VA = "0x18686EE00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public object JNHPIMBJPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x686EEB0", Offset = "0x686D8B0", VA = "0x18686EEB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x686EC50", Offset = "0x686D650", VA = "0x18686EC50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
		public JOAJLILOPCL(IEnumerator<DictionaryEntry> OBCBMANCKCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x686EBB0", Offset = "0x686D5B0", VA = "0x18686EBB0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x686EC00", Offset = "0x686D600", VA = "0x18686EC00", Slot = "9")]
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
		private sealed class FPGAONKHMGM : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x686C520", Offset = "0x686AF20", VA = "0x18686C520", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public FPGAONKHMGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x686C3D0", Offset = "0x686ADD0", VA = "0x18686C3D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x686C4D0", Offset = "0x686AED0", VA = "0x18686C4D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6871E30", Offset = "0x6870830", VA = "0x186871E30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IDictionary.this[object NDDCLPHCEEO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6871D40", Offset = "0x6870740", VA = "0x186871D40", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6871F20", Offset = "0x6870920", VA = "0x186871F20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6871C80", Offset = "0x6870680", VA = "0x186871C80", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6871CE0", Offset = "0x68706E0", VA = "0x186871CE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6871EC0", Offset = "0x68708C0", VA = "0x186871EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6871940", Offset = "0x6870340", VA = "0x186871940", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68719A0", Offset = "0x68703A0", VA = "0x1868719A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6871A00", Offset = "0x6870400", VA = "0x186871A00", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
		public RoomObjectCounts(Dictionary<int, int> LEIFIKDOCPJ, [Optional] Dictionary<int, int> HBHCHGCHIBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6871860", Offset = "0x6870260", VA = "0x186871860")]
		[IteratorStateMachine(typeof(FPGAONKHMGM))]
		private IEnumerator<DictionaryEntry> EDGEIOJFONM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6871F70", Offset = "0x6870970", VA = "0x186871F70", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6871B80", Offset = "0x6870580", VA = "0x186871B80", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6871A60", Offset = "0x6870460", VA = "0x186871A60", Slot = "9")]
		void IDictionary.Add(object NDDCLPHCEEO, object JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6871AC0", Offset = "0x68704C0", VA = "0x186871AC0", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6871B20", Offset = "0x6870520", VA = "0x186871B20", Slot = "8")]
		bool IDictionary.Contains(object NDDCLPHCEEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6871C20", Offset = "0x6870620", VA = "0x186871C20", Slot = "14")]
		void IDictionary.Remove(object NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68718E0", Offset = "0x68702E0", VA = "0x1868718E0", Slot = "15")]
		void ICollection.CopyTo(Array PFKJAOOHGBN, int DHNLEFJCEAH)
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct Invention : IDictionary, ICollection, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class LMLAOGHOOOH : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x686F3B0", Offset = "0x686DDB0", VA = "0x18686F3B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public LMLAOGHOOOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x686F220", Offset = "0x686DC20", VA = "0x18686F220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x686F360", Offset = "0x686DD60", VA = "0x18686F360", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x686E170", Offset = "0x686CB70", VA = "0x18686E170", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IDictionary.this[object NDDCLPHCEEO]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x686E040", Offset = "0x686CA40", VA = "0x18686E040", Slot = "4")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x686E220", Offset = "0x686CC20", VA = "0x18686E220", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IDictionary.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x686DF80", Offset = "0x686C980", VA = "0x18686DF80", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IDictionary.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x686DFE0", Offset = "0x686C9E0", VA = "0x18686DFE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ICollection IDictionary.Values
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x686E1C0", Offset = "0x686CBC0", VA = "0x18686E1C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int ICollection.Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x686DC00", Offset = "0x686C600", VA = "0x18686DC00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool ICollection.IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x686DC60", Offset = "0x686C660", VA = "0x18686DC60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object ICollection.SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x686DCC0", Offset = "0x686C6C0", VA = "0x18686DCC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FADB40", Offset = "0x1FAC540", VA = "0x181FADB40")]
		public Invention(long DKFNFHGODON, int IHGHLPOONHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x686DB30", Offset = "0x686C530", VA = "0x18686DB30")]
		[IteratorStateMachine(typeof(LMLAOGHOOOH))]
		private IEnumerator<DictionaryEntry> EDGEIOJFONM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x686E270", Offset = "0x686CC70", VA = "0x18686E270", Slot = "19")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x686DE40", Offset = "0x686C840", VA = "0x18686DE40", Slot = "13")]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x686DD20", Offset = "0x686C720", VA = "0x18686DD20", Slot = "9")]
		void IDictionary.Add(object NDDCLPHCEEO, object JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x686DD80", Offset = "0x686C780", VA = "0x18686DD80", Slot = "10")]
		void IDictionary.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x686DDE0", Offset = "0x686C7E0", VA = "0x18686DDE0", Slot = "8")]
		bool IDictionary.Contains(object NDDCLPHCEEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x686DF20", Offset = "0x686C920", VA = "0x18686DF20", Slot = "14")]
		void IDictionary.Remove(object NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x686DBA0", Offset = "0x686C5A0", VA = "0x18686DBA0", Slot = "15")]
		void ICollection.CopyTo(Array PFKJAOOHGBN, int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> GPKCGNDNHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public readonly IReadOnlyList<Invention> IDBEEHNOPFH;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
	public NGBJMNDKJEF(IReadOnlyDictionary<Guid, RoomObjectCounts> JPFGGGBMGCI, IReadOnlyList<Invention> CFOHFDABILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x686FD10", Offset = "0x686E710", VA = "0x18686FD10")]
	public static NGBJMNDKJEF MDNOBPMCPMI(CKJAAMAMPKA FCMADEBOIJK)
	{
		return default(NGBJMNDKJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x686FBF0", Offset = "0x686E5F0", VA = "0x18686FBF0")]
	[CompilerGenerated]
	internal static int FLELJICNMHH([In] IReadOnlyDictionary<long, int> KOINKLHHONB, long? NEALIGNIMIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x686F530", Offset = "0x686DF30", VA = "0x18686F530")]
	[CompilerGenerated]
	internal static void CAMFGBGECMH(int KBFPGHJHKBF, [In] KDBOOPNNIJF FJDAAFNFKIN, [In] Dictionary<long, int> KOINKLHHONB, [In] Dictionary<Guid, RoomObjectCounts> JPFGGGBMGCI)
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
