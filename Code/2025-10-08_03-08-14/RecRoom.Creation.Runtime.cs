using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.Build;
using RecRoom.CircuitsV1.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Algorithms;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Persistence;
using RecRoom.Protobuf;
using RecRoom.RendererV1.DataProviders;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F76C0", Offset = "0x84F64C0", VA = "0x1884F76C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CWIZMFTEAXK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly HashSet<Guid> JDPCLDBSQVU;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static readonly HashSet<Guid> HXVYJGUAUMQ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HashSet<Guid> OEKKAEDBCCE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HashSet<Guid> XEGYPDMNKKF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static string LHJNQOKVFED;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static string ZEFFQGQYZUG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static string XMUQQMFHCYD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84E5CB0", Offset = "0x84E4AB0", VA = "0x1884E5CB0")]
	public static bool BBDFXIALREG(Guid a, int b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84E5DB0", Offset = "0x84E4BB0", VA = "0x1884E5DB0")]
	public static bool IRTMQLKACVE(Guid a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84E5E40", Offset = "0x84E4C40", VA = "0x1884E5E40")]
	public static string MPSAEFCTKBD(Guid a)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DisallowSerialization]
public enum SpawnableToolType
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AC_UNIT,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	AI_MOVE_ORDER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	AIPATHPOINT,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	AMBIENCE_RADIO,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ANIMATIONGIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ANIMATIONGIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	ARENA_BEAM_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	ARENA_EMP,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	ARENA_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ARENA_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ARENA_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ARENA_ROCKET_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ARENA_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ARENA_SMG,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ART_CANVAS,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	ART_CANVAS_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	AUDIO_EFFECT_ZONE,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	AUDIO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	BACKGROUNDOBJECTS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BACKSTOPSHORT,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	BASKETBALL,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	BASKETBALLHOOP,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BEAN_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	BELL,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BLOOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BOOK_GREEN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BOOK_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BOOKSHELF_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	BOOKSHELF_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	BOOLEAN_NODE,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	BOOTH_SEAT,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	BOOTH_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	BOUNCE_PAD,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	BOWLING_BALL,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	BOWLING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	BOWLING_PIN,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BREAKER_BOX,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	BULLETIN_BOARD,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CAFE_CHAIR_ROUND,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	CAFE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	CAFE_TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CAFE_TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	CAMPFIRE,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	CANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CARDBOARD_BOX,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CC_FIRE_POTION,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CC_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CC_MEAT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CC_WAND,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CHECKPOINT_SANDBOX,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CIRCUIT_GROUP,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CIRCUIT_STAGE_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_TRAIL,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUITBEACON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CLAMP_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CLAPPERBOARD_VIDEO_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CLASSIC_CAR,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	COFFEE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	COFFEE_POT,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	COFFEE_TABLE_CURVY,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COLLISION_DETECTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COLORGRADING_NODE,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	COMBINATOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	COMPARER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CONCRETE_BARRIER,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CONCRETE_TUBE,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CONCRETEBLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CONE,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CONFETTI_GUN,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CONSTRUCTION_SMARTPROTRACTOR,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CONSTRUCTION_SMARTRULER,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CONSTRUCTION_UNITCUBE,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CONTEST_CATEGORY_TROPHY,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CONTROL_PANEL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CONTROL_PANEL_TALL,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	COSTUME_DUMMY,
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
	DORM_FLOOR_TRIM_1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DORM_FLOOR_TRIM_2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DORM_FLOOR_TRIM_3,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DORM_FLOOR_TRIM_4,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DORM_FLOOR_TRIM_5,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	DORM_FLOOR_TRIM_6,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DORM_FLOOR_TRIM_7,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	DORM_FLUORESCENT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DORM_HELP_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DORM_LADDER,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	DORM_LIGHT_SHAFTS,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	DORM_LOFT_BEAM,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DORM_LOFT_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DORM_LOFT_RAILING,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	DORM_LOFT_SHELVES,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	DORM_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	DORM_MIRROR_BUTTONS,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	DORM_RUG,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	DORM_SKYLIGHT_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	DORM_SKYLIGHT_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	DORM_WALL_1,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	DORM_WALL_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	DORM_WALL_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	DORM_WALL_2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DORM_WALL_3,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	DORM_WALL_4,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	DORM_WALL_LOFT_1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DORM_WALL_LOFT_1_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	DORM_WALL_LOFT_1_UP,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	DORM_WALL_LOFT_2,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	DORM_WALL_LOFT_2_DOWN,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DORM_WALL_LOFT_2_UP,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	DORM_WALL_PILLAR,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	DORM_WALL_STRIPE,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DORM_WINDOW_LARGE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	DORM_WINDOW_LARGE_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	DORM_WINDOW_SMALL_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DORM_WINDOW_SMALL_PANES,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	DRACULA_BLUNDERBUSS,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	DRACULA_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	DRACULA_BOSS_PLUSHY,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	DRACULA_CHESTCOINS_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	DRACULA_CHESTCOINS_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	DRACULA_CHESTCOINS_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	DRACULA_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	DRACULA_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DRACULA_HOOKSHOT,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DRACULA_HUNTER_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DRACULA_LOOT_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	DRACULA_LUNGING_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	DRACULA_MINIBOSS_BONE,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	DRACULA_MINIBOSSCOINS_BAT,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DRACULA_MINIBOSSCOINS_BONEMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DRACULA_MINIBOSSCOINS_BONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	DRACULA_MINIBOSSCOINS_MUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	DRACULA_MINIBOSSCOINS_WOLF,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	DRACULA_PITCHFORK,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	DRACULA_PUMPKIN_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DRACULA_RAKE,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	DRACULA_SHOVEL,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DRACULA_SMALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	DRACULA_STANDING_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	DRACULA_WALL_COLLECTABLE,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DRACULA_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	DRACULABATLUNGING,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	DRACULABATRANGED,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	DRACULABONETHROWER,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	DRACULAMELEE,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	DRACULAMUSKET,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	DRAWABLE_CLIPBOARD,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DRIVEIN_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DRIVEIN_SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	DUMPSTER,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	DYNAMIC_DOMELIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DYNAMIC_POINTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DYNAMIC_SPOTLIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	DYNAMIC_SPOTLIGHT_V2,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DYNAMINC_POINT_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	ELECTRICAL_UNIT,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	ELEMENT_SNAP_POINT,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	ERASER,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FENCE_FRAME,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	FENCE_PLANK,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	FILM_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	FLAG,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	FLAG_AND_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	FLAG_GOAL,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	FLATTREELARGE,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	FLATTREEMEDIUM,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	FLATTREESMALL,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	FOG_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	FRANKIES_FUEL_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	FRIENDOTRON,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	FULLBODYCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	FULLBODYPUPPETPROP,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	GAME_CONFIGURATION,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	GAME_GET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	GAME_ROLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	GAME_SET_SCORE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	GAME_SET_STATE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	GAME_STATE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	GAME_STATE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GAS_PUMP,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	GET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	GET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	GLOWSTICK_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	GLOWSTICK_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	GLOWSTICK_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	GLOWSTICK_RED,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	GOBLINBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	GOBLINBASICGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	GOBLINBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GOBLINBASICMELEEPIKE,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	GOBLINELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	GOBLINELITEGROUNDMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	GOBLINKNIGHTCHARGE,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	GOBLINKNIGHTSPIN,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GOBLINVOLLEY,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	GOLDEN_BUCKET,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	GREEN_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	GT_BOW,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	GT_CROSSBOW,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	GT_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	GT_SWORD,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	GUARD_RAIL,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	GUN_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	HAM,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	HANDHELD_STREAMER_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	HAY_BALE,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	HOLOTAR_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	HOLOTAR_PROJECTOR_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	HORIZONTALWALL,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	IBEAM_10M,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	IBEAM_5M,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	IBEAM_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ICEBREAKERS,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	IMPULSE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	IMPULSE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	INDICATOR_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	INK_SPACE_ROOM_HULL,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	INKSPACE_STAGE,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	INTERACTION_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	INTERACTION_VOLUME_V2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	INVISIBLE_COLLISION,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	INVISIBLE_COLLISION_V2,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	JACKOLANTERN,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	JUKEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	KEEPSAKE,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LASER_TAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LAUNDRY_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	LAWN_CHAIR,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	LEADERBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	LEADERBOARDPROJECTOR_V2,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	LIGHT_CHEVRONS,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	LIGHT_MARQUEE,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LIGHT_PENDANT,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LIGHT_STRIP_SHORT,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LINK_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LOCKERS,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LOG_PILE,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LOG_SCREEN,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LOGBENCH,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	MAGIC_DOOR,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	MAGNETIC_ANCHOR,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	MAKER_PEN_CHARADES,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	MAKER_PEN_TROPHY_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	MAKER_PEN_TROPHY_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	MAKER_PEN_TROPHY_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	MANNEQUINPROP,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	MARKER_BLACK,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	MARKER_BLUE,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	MARKER_BROWN,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	MARKER_ERASER,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	MARKER_GREEN,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	MARKER_MAGIC,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	MARKER_ORANGE,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	MARKER_PINK,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	MARKER_PURPLE,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	MARKER_RECOLORABLE,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	MARKER_RED,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	MARKER_SKYBLUE,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	MARKER_YELLOW,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	MARSHMALLOWSTICK,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	MESH_FENCE,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	MESHPRESENTER,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	MESSAGE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	METAL_BARREL,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	MICROPHONE_CONFERENCE,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	MICROPHONE_STAND,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	MINIFRIDGE,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	MOCKTAIL_GOBLET,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	MOCKTAIL_MARGARITA,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	MOCKTAIL_MARTINI,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	MOCKTAIL_MILKSHAKE,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	MOCKTAIL_SHAKER,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	MOCKTAIL_STEMLESS,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	MOCKTAIL_TALL,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	MODERATOR_PLAQUE_BRONZE,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MODERATOR_PLAQUE_GOLD,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	MODERATOR_PLAQUE_SILVER,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	MOVEABLE_WHITEBOARD,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	NAPKIN_HOLDER,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	NAVMESH_BAKE_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	OBJECT_PLAYER_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	OBJECT_RESPAWNER,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	OBJECT_SET_TAGS_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	OM_CREATION_SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PADDLEBALL_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	PADDLEBALL_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	PAINT_THROWER,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PAINTBALL_ASSAULT_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PAINTBALL_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	PAINTBALL_GRENADE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PAINTBALL_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	PAINTBALL_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PAINTBALL_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	PAINTBALL_SNIPER_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	PAINTBRUSH,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	PARTICLE_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	PARTICLE_EMITTER_V2,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	PINE_TREE_DEAD,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PING_PONG_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	PING_PONG_PADDLE,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	PIPE_BRACKET,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	PIPE_CURVED,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	PIPE_STRAIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	PIPE_STRAIGHT_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	PIRATE_BAR_STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	PIRATE_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	PIRATE_COCONUT_BOMB,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	PIRATE_CUTLASS,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PIRATE_FLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	PIRATE_FRYING_PAN,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PIRATE_HOOK_HAND,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	PIRATE_LOST_LOOT,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	PIRATE_MUG,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	PIRATE_OAR,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PIRATE_PLATE,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	PIRATE_PLUSH_FISH,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	PIRATE_PUSH_BROOM,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	PIRATE_RUM_JUG,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	PIRATE_SMALL_LOOT_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	PIRATEBASICMELEE,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PIRATEBOTTLETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	PIRATEEXPLOSIVETHROWING,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	PIRATEFLINTLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	PIRATEGIBBET,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	PISTON_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	PISTON_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	PLANT_DRACAENA,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	PLANT_FIG,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	PLANT_SNAKE,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	PLAYER_CREATED_SIGN,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	PLAYER_EVENT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	PLAYER_HIT_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	PLAYER_RESPAWN_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	PLAYER_RESPAWN_POINT,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	PLAYER_RESPAWN_POINT_V2,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	PLAYER_REVIVED_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	PLAYER_ROLE_MAP_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	PLAYER_TEAM_MAPPING_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	PLAYEREVENT_BROADCAST_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	POKERCHAIR,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	POLAROID,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	POOL_CUE,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	POOL_CUE_RACK,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	POOL_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	POOL_TRIANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	POP_UP_SHOP_1,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	POP_UP_SHOP_10,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	POP_UP_SHOP_2,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	POP_UP_SHOP_3,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	POP_UP_SHOP_4,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	POP_UP_SHOP_5,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	POP_UP_SHOP_6,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	POP_UP_SHOP_7,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	POP_UP_SHOP_8,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	POP_UP_SHOP_9,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	PROPBOX_RECTANGLE,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	PROPBOX_SQUARE,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	PROXIMITY_MINE,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	PUNCHING_BAG,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	PVP_WHIP,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	QUEST_POT,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	QUEST_POT_LARGE,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	RADIO,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	RALLY_BUGGY,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	RANDOM_NODE,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	RANGEFINDER_GADGET,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	RC_CAR,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	RC_CAR_SET,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	RC_REMOTE_CONTROL,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	RECRALLY_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	RECROYALE_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	REPLICATOR,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ROCK_01,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	ROCK_04,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	ROCK_CLIFF,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ROCK_CONE,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	ROCK_PLATEAU,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	ROCK_STUMP,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	ROCK_TALL,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	ROCK_WALL,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ROCK_WEDGE,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ROOM_CONSUMABLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ROOM_CURRENCY_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ROOM_DOOR,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ROOM_DOOR_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	ROOT_BEER_BOTTLE,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	ROTATOR_GIZMO,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ROTATOR_GIZMO_V2,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ROTJ_GRENADE,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ROTJ_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ROTJ_RAILGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ROTJ_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ROTJ_SMG,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ROUND_PICNIC_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	ROYALE_AMMUNITION_AUTOMATIC,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	ROYALE_AMMUNITION_EXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ROYALE_AMMUNITION_PISTOL,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	ROYALE_AMMUNITION_RIFLE,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	ROYALE_AMMUNITION_SHOTGUN,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	ROYALE_BACKPACK,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ROYALE_HEALTH_AND_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	ROYALE_HEALTH_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	ROYALE_ISLAND_MAP,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	ROYALE_SHIELD_POTION,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	SANDBOX_APPLE_MUSIC_PROMOTION_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	SANDBOX_AUDIO_SAMPLER,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	SANDBOX_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	SANDBOX_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	SANDBOX_CEILING,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	SANDBOX_CIRCUIT_BEACON,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	SANDBOX_COC_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	SANDBOX_EXPLOSION_EMITTER,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	SANDBOX_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	SANDBOX_GAMING_TABLE,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	SANDBOX_GAMING_TABLE_SMALL,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	SANDBOX_GLASS,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	SANDBOX_GRABBER,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	SANDBOX_LASER_POINTER,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	SANDBOX_MEEPLE,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	SANDBOX_MIRROR,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	SANDBOX_MUTEGESTURE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	SANDBOX_PLAYER_GOAL,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_2_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_3_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_4_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_5_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	SANDBOX_POPUPSHOP_PROGRESSIONEVENT_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	SANDBOX_PROJECTILE_LAUNCHER,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	SANDBOX_REMOTE_VIDEO_PLAYER,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	SANDBOX_SEAT,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	SANDBOX_SHAKEHANDS_POSTER,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	SANDBOX_STEERINGENGINE,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	SANDBOX_TEXT,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	SANDBOX_TEXT_2D,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	SANDBOX_TEXT_V2,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	SANDBOX_TEXT_V3,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	SANDBOX_TOGGLE_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	SANDBOX_TOGGLE_BUTTON_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	SANDBOX_TOOL_GOAL_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	SANDBOX_TOOL_GOAL_MEDIUM,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	SANDBOX_TOOL_GOAL_SMALL,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	SANDBOX_TRASHCAN_OFFICE,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	SANDBOX_WALL,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	SANDBOX_WALL_WINDOW,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	SCAFFOLDING_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	SCAFFOLDING_SHINY,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	SCFIFGROUNDEXPLOSIVE,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	SCIFI_POT,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	SCIFIBASICFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	SCIFIBASICGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	SCIFIELITEFLYINGRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	SCIFIELITEGROUNDRANGED,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	SCIFIKNIGHTASSASSIN,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	SCORE_INPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	SCOREBOARD_PROJECTOR,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	SCOREBOARD_SETUP_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	SELECTOR_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	SET_LEADERBOARD_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	SET_PLAYER_STAT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	SET_SCORE_OUTPUT_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	SFX_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	SFX_NODE_V2,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	SHAPE_CONTAINER,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	SHAPE_CONTAINER_OM,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	SHARED_GAME_AI,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	SHOWCASE_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	SITTINGLOG,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	SKYDOME_NODE,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	SMOOTH_LOOK_AT,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	SNOWBALL,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	SNOWBALL_PILE,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	SOCCER_BALL,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	SOCCER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	SOCCER_SHIELD,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	SOLOCUP,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	SPAWNERCIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	SPAWNERCIRCUIT_V2,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	SPEAKER,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	SPEAKER_CONCERT,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	SPORTS_CAR,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	SPRINGBOARD_STUNTRUNNER,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	STACKABLE_BLOCK,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	STAGELIGHT_CAN,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	STAGELIGHTV2,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	STANDEE_BEAR_01,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	STANDEE_FEMALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	STANDEE_FEMALE_02,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	STANDEE_FEMALE_03,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	STANDEE_MALE_01,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	STANDEE_PIRATE_01,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	STANDEE_PIRATE_02,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	STANDEE_PIRATE_DRUMMER,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	STANDEE_PIRATE_FIDDLE,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	STANDEE_PIRATE_PHOTO,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	STANDEE_PIRATE_SQUEEZEBOX,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	STATE_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	STATE_MACHINE_STATE,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	STEAM_VENT,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	STICKY_NOTE,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	STICKY_POSTER,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	STNMONSTERCOSTUMEDUMMY,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	STONEPILLAR,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	STOOL,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	STOOL_BOWLING_ALLEY,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	STOOL_WOODEN,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	STREAMING_CAMERA_POINT,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	STUNTRUNNER_BASEROOM_CEILING,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	STUNTRUNNER_BASEROOM_FLOOR,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	STUNTRUNNER_BASEROOM_WALL_LONG,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	STUNTRUNNER_BASEROOM_WALL_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	STUNTRUNNER_BOOM_MICROPHONE,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	STUNTRUNNER_BUTTON,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	STUNTRUNNER_CHECKPOINT_INVENTION,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	STUNTRUNNER_COMMENTATOR_BOOTH,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	STUNTRUNNER_COMMENTATOR_CAMERA,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	STUNTRUNNER_ENDING_GATE,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	STUNTRUNNER_GAME_RULE_CIRCUIT,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	STUNTRUNNER_JUMBOTRON,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	STUNTRUNNER_PICKUP,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	STUNTRUNNER_STARTING_GATE,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	SUN_DIRECTION_GADGET_CV2,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	SUN_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	SWING_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	TABLE_COFFEE_LARGE,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	TABLE_MEETING,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	TABLE_PINGPONG,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	TABLE_SHORT,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	TABLE_TALL,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	TABLE_UMBRELLA,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	TARGET,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	TELEPHONE_POLE,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	TENNIS_BALL,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	TERRAIN_GENERATOR,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	TEXTSCREEN,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	TEXTSCREENSCROLL,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	TEXTURED_QUAD,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	THROW_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	TILEABLE_ROPE_NET,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	TIMER_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	TOUCHPAD_COMPONENT,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	TRACTOR_TIRE,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	TRASH_BAG,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	TRASH_BIN,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	TRASH_CAN,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	TREE_STUMP,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	TRIGGER_HANDLE,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	TRIGGER_VOLUME,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	TRIGGER_VOLUME_CV2,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	TROPHY_DEVMOD,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	UGC_AREA,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	UGC_R2STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	UGC_STOREFRONT,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	VARIABLE_NODE,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	VECTOR_GADGET,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	VEHICLE_50SCAR,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	VEHICLE_TRUCK,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	VEHICLE_WOLF,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	VENDING_MACHINE,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	VERTICALWALL,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	WATER_JUG,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	WATERBOTTLE,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	WAVE_NODE,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	WELCOME_MAT,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	WELCOME_MAT_V2,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	WHITEBOARD_MARKERS,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	WINEBARREL,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	WOOD_PALLET,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	WOODEN_SPOOL,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	WOODSTACK
}
namespace _LogRegistration.RecRoom_Creation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84F7600", Offset = "0x84F6400", VA = "0x1884F7600", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DXOEUZRQSKV
	{
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public static readonly Guid VBXFNJARGEW;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public static readonly Guid JHQOCGXGCSO;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public static readonly Guid MTALJSTSBGA;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public static readonly Guid RBEOVJVIDSM;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public static readonly Guid NFFPLXSHXDN;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public static readonly Guid DAABMAWWKJF;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public static readonly Guid VDTIMSIIQOM;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public static readonly Guid CRUEVAAPIXT;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public static readonly Guid DRWUZZZCHYD;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static readonly Guid BGEHDCKBNEX;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static readonly Guid WZHEISACMQU;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static readonly Guid NPQVSUUQBGX;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static readonly Guid MSIVKVHSMYE;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public static readonly Guid XMAJVQFCMFF;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public static readonly Guid SDXWWJRYSRW;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public static readonly Guid CWMDPJHWJSN;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public static readonly Guid CSHWXAUQFPD;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public static readonly Guid PSWDAYKLWZO;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public static readonly Guid QCKUJYMFJWB;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static readonly Guid VCALBAPZSDA;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static readonly Guid ZKCMKDSXPSS;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static readonly Guid RCBGWPFTHZS;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static readonly Guid SJFYJPZOTKK;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public static readonly Guid PPOUBUUAZQI;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public static readonly Guid OGVLXSNXDVY;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public static readonly Guid RDSFZXXASNJ;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public static readonly Guid ZHJPBKOVYPQ;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public static readonly Guid GTBWHNJPZOL;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public static readonly Guid AHOLFMLHICT;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static readonly Guid BMKWSKWDVIU;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static readonly Guid FBNNCLOVYYC;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static readonly Guid PRQVEMCIUQH;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static readonly Guid KUSOCXMLXIC;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public static readonly Guid JNNFAPTRIYN;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public static readonly Guid ELUKPCWFOOL;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public static readonly Guid RHDDGXAHUOP;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public static readonly Guid WVKIZYSNPPD;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public static readonly Guid CBUPBCVYPVF;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public static readonly Guid KBXIHAYQGHH;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public static readonly Guid XARHQVGZKRV;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public static readonly Guid OHGHCNWCPGT;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public static readonly Guid NQTOJOKPMQJ;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public static readonly Guid CFTWXWYQOME;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public static readonly Guid SQVORWJOZVD;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public static readonly Guid WGOKGWGBPNY;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public static readonly Guid MIBXZKNUAFA;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public static readonly Guid CYXVEZERVMC;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public static readonly Guid YMJIFLXOODD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public static readonly Guid GFDPMOZEYPC;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public static readonly Guid ESGXQOFRHAJ;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public static readonly Guid ZKBMYSXYPAD;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public static readonly Guid ONOPKCIFTQQ;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public static readonly Guid NWDFTFIZOQI;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public static readonly Guid ULNYEDBSYFC;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public static readonly Guid IETZPNXVCOJ;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public static readonly Guid SAQYRKPPBGB;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public static readonly Guid VIXHVDTXBYW;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public static readonly Guid NTNTYUORTCE;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public static readonly Guid FNGUTMHDRQF;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public static readonly Guid XDSXMAJXVXC;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public static readonly Guid XUVCNATPEBJ;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public static readonly Guid DNRJLMCIIRJ;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly Guid PXXFQBUVFEI;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static readonly Guid TBTKYGCLEOL;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static readonly Guid HIGYXVDNNJJ;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static readonly Guid BIBJCQUDHFC;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public static readonly Guid DUPPZMJHATS;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public static readonly Guid QHDWYDWYBZR;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public static readonly Guid NDPEXYGYRFU;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public static readonly Guid LKCHTHUBZJL;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public static readonly Guid ZYBIBTBYESA;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public static readonly Guid WKOJZIARYJZ;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public static readonly Guid JPITIUFLYLP;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public static readonly Guid FITEXFPJPHW;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public static readonly Guid IVICBQHDCUS;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public static readonly Guid VPIMFCTLFBA;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public static readonly Guid OJHFNIEEFCA;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public static readonly Guid QXGKDPBLKWA;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public static readonly Guid ZFQDOZFVTWV;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public static readonly Guid HZUJEPJIELK;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public static readonly Guid TCSNRNDZWKJ;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public static readonly Guid JPFPMONLTCQ;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public static readonly Guid LFBVTFBZOWJ;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public static readonly Guid ZKDMXAHANLR;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public static readonly Guid MIPQKDHMNLX;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public static readonly Guid SJIFCHTNOJA;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public static readonly Guid SZOCYWHPDFR;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public static readonly Guid EIPGVRMDKTP;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public static readonly Guid MLYDYNJUKRG;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public static readonly Guid XQXLDAIAGVC;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public static readonly Guid LRMYZSVCKHN;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public static readonly Guid NLOYJYCHTKB;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public static readonly Guid RWJIHJIJZKP;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public static readonly Guid KDONPUDFGIP;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public static readonly Guid KEVTJJRCQEP;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public static readonly Guid JRIMZRVDBJY;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public static readonly Guid WMFBVTVHTHH;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public static readonly Guid XOFYWJXKZRL;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public static readonly Guid ZEPVSMZZDUW;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public static readonly Guid CTFMKIMRZOZ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public static readonly Guid QENQEFJLUYA;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public static readonly Guid DHRXSTABZBL;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly Guid QEYDYSXGNUS;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public static readonly Guid NKVEVDYYDPV;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public static readonly Guid KACTWRVZOFR;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public static readonly Guid ZELPDRMGQHW;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public static readonly Guid TNEEZLTDFAL;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public static readonly Guid NCWAMHCNOUQ;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public static readonly Guid TNOSTZGXXXD;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static readonly Guid AJZGXMLNHNQ;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly Guid TKTAGIOIVUH;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public static readonly Guid NLRLRBVYJLK;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public static readonly Guid PJBQRDRMHYC;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public static readonly Guid QNMDXKPOCBJ;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public static readonly Guid EYMEHWRGWRJ;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public static readonly Guid CFJLBTQQABU;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public static readonly Guid DZPAFKHJLZT;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public static readonly Guid PRZXVGVQYWR;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public static readonly Guid LAUKBPYSIJE;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public static readonly Guid YZJRHKRMPTD;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly Guid OICFWOCOWSB;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly Guid CVKESAXYSRR;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly Guid NQFWCAUZIUL;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly Guid ZJOLXKXGQCT;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly Guid VYNJQJDWHKL;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly Guid YUDYMETIHRR;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly Guid LMJXEUKXXKQ;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly Guid ZWSUKFMYNSX;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly Guid JJUQTJGLNRN;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly Guid UXFPZIBHYAL;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly Guid FBHJRSAXOLU;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly Guid XNSPYNTGEMZ;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly Guid ANERUTUUOXA;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly Guid MFZZIOLGAPC;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public static readonly Guid OOXLCXGVOUX;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public static readonly Guid SIBRTUFYGGZ;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public static readonly Guid CRCOKRXQJLM;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly Guid ZMGSPBCOXDC;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public static readonly Guid FUEIODKTVMJ;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public static readonly Guid UAUHUAPFFXV;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public static readonly Guid ZOKYOPHEDTE;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public static readonly Guid AHFFRLUUDOM;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public static readonly Guid IOWBWFKVKRG;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public static readonly Guid FKPLCNYNZRI;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public static readonly Guid HEMVAEZINDZ;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public static readonly Guid ZMFHFCVSPDN;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public static readonly Guid ZMKOCJPPYOW;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public static readonly Guid ZMPUZQJNIAF;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public static readonly Guid ZLEYSVAFTYU;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public static readonly Guid ZLKFQBUDDKD;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly Guid ZLPMNIOAMVM;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public static readonly Guid ZLUTKPHXWGV;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public static readonly Guid XVGVHLTNIMN;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static readonly Guid PHIUQWGZJFD;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static readonly Guid OKTJMDEVEKA;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static readonly Guid JVMJFPNJWXC;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static readonly Guid ZODOPDGDTBN;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static readonly Guid JVAOTNTDMLE;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public static readonly Guid QBQEWEMLMIU;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public static readonly Guid NWJXILBQVNO;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public static readonly Guid KLRREAPMWCP;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly Guid YOLUQEOIDNT;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public static readonly Guid XYXTJULLNGK;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public static readonly Guid XWNOUSFSESJ;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public static readonly Guid GOKSKFMBONK;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public static readonly Guid LHARDVWEMHC;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public static readonly Guid BYBWDCGZQBD;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public static readonly Guid SSLLMMNTBWI;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public static readonly Guid LHQLVQDWOPD;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public static readonly Guid LHLEYJJZFDU;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public static readonly Guid LIAZQDRRHLV;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public static readonly Guid CBIMFLTQZFM;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public static readonly Guid WGRFLRKEQGX;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public static readonly Guid VLZJRIJDKZY;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly Guid CBDFIEZTPUD;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public static readonly Guid EUZLJIBCJNG;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public static readonly Guid ZZFELCTSHSN;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public static readonly Guid UVGFJQMZQZD;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public static readonly Guid VZPXMEKCNRS;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public static readonly Guid VCHORLRTFYS;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public static readonly Guid COCHFQTEXEM;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public static readonly Guid VZKVHBAUQBM;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public static readonly Guid MNMKYJKAUII;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public static readonly Guid IQHAXVASTST;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public static readonly Guid SPUCQGZDTHI;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public static readonly Guid SFQZPDAGGGB;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public static readonly Guid LUMNFSQFRSN;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public static readonly Guid FJTRCGBUIDT;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public static readonly Guid JIKJSRRFZND;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public static readonly Guid HFPODSQVAFG;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public static readonly Guid YJYFGLTJCNO;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public static readonly Guid JTSCTWJGLYP;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public static readonly Guid OLPVZPKMKXF;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly Guid QJOPJRZAZBM;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public static readonly Guid WZIWKQSLUEN;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public static readonly Guid RKFXZXCZSOJ;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public static readonly Guid RTLGTTPNALK;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public static readonly Guid ELKMYYNWYSF;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public static readonly Guid KHPTEZAMWHU;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public static readonly Guid ETFKDUWWNQA;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public static readonly Guid TIDYWMSHYXD;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public static readonly Guid SQGRYODPEJM;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public static readonly Guid DIVKEKSEOAF;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public static readonly Guid NFTDFHAKWTL;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public static readonly Guid UFQDIRWPJNN;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly Guid XAIPLNEYBWK;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public static readonly Guid JYPRBIICHSF;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public static readonly Guid BFMJROZYZGB;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public static readonly Guid CAEDDXTTNPA;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public static readonly Guid JBCJUHULVUW;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public static readonly Guid PDKZXIRSDYR;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public static readonly Guid JDDNUCQTAHC;

		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public static readonly Guid ICNDWLNBUIF;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public static readonly Guid HIUNLZTFNNM;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public static readonly Guid ZCBMSSRAMAY;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public static readonly Guid FQVZJUNBABE;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public static readonly Guid VCRMLINEIAY;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public static readonly Guid ZUPZQNZXGMJ;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public static readonly Guid FIDLJXMKMYT;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public static readonly Guid TGOSMIKBBHO;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public static readonly Guid QNNCESXOBHB;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public static readonly Guid BUBNWBYXHWE;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public static readonly Guid NDKVYVATEFU;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public static readonly Guid VWYBWSRDFLK;

		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public static readonly Guid ARANLPZXJNF;

		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public static readonly Guid PONQCIOGEYL;

		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public static readonly Guid SGKTGRWKZKG;

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public static readonly Guid HGKYPJPXRNV;

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public static readonly Guid LPZREBKRSCW;

		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly Guid FUMKHLSMFFT;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public static readonly Guid VNVSCNSRBEL;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public static readonly Guid OWPIZDUWCTX;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public static readonly Guid IOUMTRNDTFB;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public static readonly Guid XNFHVPFVWFF;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public static readonly Guid WEDSRMTACRN;

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public static readonly Guid CANKDKDQTUK;

		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public static readonly Guid ZYRXDFCJWDR;

		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public static readonly Guid XZCRFDVARRJ;

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public static readonly Guid GELDHNDNZRK;

		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public static readonly Guid PHADTYQCRSV;

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public static readonly Guid ASYPVAOVOCQ;

		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public static readonly Guid VEVFGMCJMKQ;

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public static readonly Guid TMHEWTPXTZK;

		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly Guid NRXBYFSMMQD;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public static readonly Guid UBPDXMEPPUA;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly Guid QGUPEXWDEQB;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public static readonly Guid GKHGGFQHDQR;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public static readonly Guid QFKNWTHEVUK;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public static readonly Guid AIGTABJYDQX;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public static readonly Guid UZRWJGJKKBP;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly Guid ZDJEZNUAIWP;

		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public static readonly Guid RGBOLNWTYOH;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public static readonly Guid HXEUZRUQFRX;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public static readonly Guid YPYXRIBEKMF;

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public static readonly Guid NTGZOMNCIEO;

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public static readonly Guid LNKBLCFLPGO;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly Guid RDJLCLDZVJZ;

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public static readonly Guid TDYOUPIJOYW;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly Guid ALEOYZYNHMN;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public static readonly Guid BHCPKLWYQJZ;

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public static readonly Guid XUZWZUGZMAI;

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public static readonly Guid CYUDKWZNKFH;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly Guid VYRFSBYRYER;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly Guid WHPEAUKSBSF;

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly Guid CQWQDCPNEQF;

		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public static readonly Guid AFODNFZYTTV;

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public static readonly Guid XQAOGARBVQL;

		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public static readonly Guid ZIBNXXVLQNT;

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public static readonly Guid GZEJOXWPEMM;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public static readonly Guid NFRCBAXNZEG;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public static readonly Guid NAHGPDUHLIZ;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public static readonly Guid CUACPAQKVDI;

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public static readonly Guid TRAFXGWIZAH;

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public static readonly Guid ZLRFACCPEPL;

		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public static readonly Guid BKFIXUGNVRM;

		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public static readonly Guid QRJSNLZEKDL;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public static readonly Guid OEYVGOKVJQD;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public static readonly Guid DBVELSHKKPF;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public static readonly Guid GQPVBHMAHJQ;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public static readonly Guid YYNTKIIMWUM;

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public static readonly Guid PZIFZJHESBU;

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public static readonly Guid HVUYRUJVIEL;

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public static readonly Guid HNEZQYDWIBR;

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public static readonly Guid IQJQMOTAJRP;

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public static readonly Guid VPIEGRUEOLF;

		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public static readonly Guid ANKMPTDMRVS;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public static readonly Guid URQGZRYENZK;

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public static readonly Guid NPNDDBDQRUE;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public static readonly Guid GSITMJYPWDL;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public static readonly Guid KEBNRNJZZTL;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public static readonly Guid VAWRAGODXXU;

		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public static readonly Guid SBLDPGHKASQ;

		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public static readonly Guid BGEIYVBQAOD;

		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public static readonly Guid VLBJOKIUXAX;

		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public static readonly Guid UZFCYKZBLPY;

		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public static readonly Guid ZKEGHGCSEUL;

		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public static readonly Guid VDXCGSMRSIK;

		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public static readonly Guid AFBWEPUEAQD;

		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public static readonly Guid VZKABHJLHIV;

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public static readonly Guid UQJTJLUMBWD;

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public static readonly Guid XDHRLIUTEKW;

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public static readonly Guid RLKBPZDQJJM;

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public static readonly Guid DCSCIJDQGIU;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public static readonly Guid UWWHYFETGCF;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly Guid SZPMRUAIMXS;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly Guid HKVDRURIDBW;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly Guid NBEGVVZXBUU;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly Guid FAJDMEWFLQY;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly Guid SXRASVSOKET;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly Guid ZLHCRDWQIBV;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly Guid TDMSMKGNZMX;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly Guid KPYKKUJVHXJ;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly Guid HRENISSQKLH;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly Guid CLJLQOLHWKT;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly Guid YBGSPDTEZLK;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly Guid FSWNSLXZAPS;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly Guid JTIAVSZYMXT;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly Guid ORYPEFMQZZY;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly Guid PLLRSLMRJPI;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly Guid PCWEQLFFPYG;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly Guid UQWSXJHFGJP;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly Guid GQABDOCZJYB;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly Guid HZGVRBQEDRS;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly Guid JACWMWRVJTQ;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly Guid BUKZHLNKJQY;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly Guid DQWMCPJKMJM;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly Guid SEZDUQSAJAR;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly Guid BTWEGBYFJQH;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly Guid EQHPALKBWYW;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly Guid GBYWNTNXFWW;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly Guid BXOEZSWMWBW;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly Guid LBBNYVABEWC;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly Guid PJXOSBUBVCL;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly Guid ZFFFBGPAEKT;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly Guid QRMPXHJEZUL;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly Guid WPCLMBIEHTM;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly Guid OBFXJLWMLAM;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly Guid NRMNCHQODLP;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly Guid EWUOLPJKDDP;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly Guid UNUSZBCLZFU;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly Guid BKYGHWUPWMG;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly Guid WYIQSQKXOUP;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly Guid MKXOTZFPSEU;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly Guid SRISIUILYAM;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly Guid KDZKMDDOAJN;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly Guid UYVCNOYVKWU;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly Guid PXOUTRZCLMK;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly Guid GLKOYSJFQUZ;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly Guid NORVQBJMVKY;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly Guid WQHYVAOOWHZ;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly Guid FTIDDHYNWAG;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly Guid ALFFJUGRQCO;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly Guid EAOEKVUPSGM;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly Guid YQASFBQCEQW;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly Guid EJKCAQPFLNR;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly Guid ZCHCAOQHFLV;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly Guid OVAOQAVVJQI;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly Guid TGVGDKKGICL;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly Guid YTXUWRXCTEF;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly Guid LFNLNMTUFBD;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly Guid YOHPYRGEHNU;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly Guid MVLZSPGCBQV;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly Guid QYUOSWPWPJA;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly Guid GUCEOFOVMRI;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly Guid BAPMCVTSTPS;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly Guid EWEDXNIFNKB;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly Guid JFGPJPSBLUT;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly Guid YIVJVLZXMXP;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly Guid RKDROTAABLB;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly Guid RNVYOIQWSCU;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly Guid ARUSMYWCGBH;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly Guid DSTTDSFRBHM;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly Guid TJYYIWKLRUZ;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly Guid SCOTDNGPALQ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly Guid PKQJMWEMYBJ;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly Guid FLVFZOFLOVO;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly Guid MSDOVKFWMYZ;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly Guid RBRIALCRPSS;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly Guid KLZEITISEPT;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly Guid QHYPWYIROSM;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly Guid JZIYJEJQMOS;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly Guid TDZTKPCZBJB;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly Guid TGBYNKGIZVS;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly Guid EJWVKBDEZER;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly Guid WSDJRXQYEYC;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly Guid MGFDWETLGPG;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly Guid BUOWLCAHWLO;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly Guid EQTMRDPCHHU;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly Guid SROQHMJESWL;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly Guid KPJIKZDQGBD;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly Guid ZGHZYQSALME;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly Guid UUCRHCELXUB;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly Guid QWLYFBNVMGQ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly Guid NHYGLDUHXSK;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly Guid UBZNFDWLEUA;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly Guid YTNHPNFAAFA;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly Guid CDRFEAHESLD;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly Guid MRXADTESMHE;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly Guid YKMIXEHQFHJ;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly Guid VCNDYXZNWQL;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly Guid OUBAYKLSLGM;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly Guid BNIMIONISZC;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly Guid TGHZLBCMGQJ;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly Guid YEJQVXOHWXR;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly Guid VWZHFCSJQZR;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly Guid VFGWALSRYBM;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly Guid LWAWGSMMGON;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly Guid CVPKQJGVDNQ;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly Guid UNPNIFOWQJS;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly Guid DUCHMICLEQF;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly Guid LHXGICVISRF;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly Guid QCWDNDPXYGH;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public static readonly Guid AVOIYFFFMRW;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public static readonly Guid BGJAVYZBREB;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public static readonly Guid VOZTQDPNDOJ;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public static readonly Guid HTKQTRUBNNV;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public static readonly Guid TDLCPCXYUBH;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public static readonly Guid GJUKWHPFCIJ;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public static readonly Guid NBMYILAOJYW;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public static readonly Guid GZDVWEYVHFQ;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public static readonly Guid IPPRBEMSFRR;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public static readonly Guid HALRYFUTZJH;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public static readonly Guid IPUXYLGPPDA;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public static readonly Guid IQAEVSAMYOJ;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public static readonly Guid IOPIOWRFKMY;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public static readonly Guid IOUPMDLCTYH;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public static readonly Guid IOZWJKFADJQ;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public static readonly Guid IPFDGQYXMUZ;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public static readonly Guid IRANHZVZTTC;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public static readonly Guid IRFUFGPXDEL;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public static readonly Guid OOYNBCRGGMN;

		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public static readonly Guid VYHARHCTYKL;

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public static readonly Guid UVHIRODSNEC;

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public static readonly Guid NADPIHJQJZQ;

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public static readonly Guid LGLVQFQUGLM;

		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public static readonly Guid WUQIELHDXLM;

		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public static readonly Guid ELTFIXIBLHZ;

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public static readonly Guid MDPJNEZBSQD;

		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public static readonly Guid GMAHPZXARCK;

		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public static readonly Guid TCNLDHFUQZC;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public static readonly Guid VKHPEAUVJWF;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public static readonly Guid XQMCMGVAYWF;

		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public static readonly Guid LAATWIAKBRX;

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public static readonly Guid EWKDPJABTVA;

		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public static readonly Guid JIVHJJLAOGZ;

		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public static readonly Guid GCUSSVYJCIH;

		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public static readonly Guid LEBWCRALIWG;

		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public static readonly Guid QSCBDEBIEYW;

		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public static readonly Guid OXHAFMTZJCY;

		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public static readonly Guid RVFUNILLHJE;

		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public static readonly Guid IMBPGCSUKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public static readonly Guid MAOSMWQMFBS;

		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public static readonly Guid MBPAZELZAGL;

		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public static readonly Guid RHPLQTUJDEL;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public static readonly Guid NUUJBUJCIDO;

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public static readonly Guid VDCFDXKQQSX;

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public static readonly Guid DWGHNGLTGPI;

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public static readonly Guid DBXPDSVLILG;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public static readonly Guid WYOYAFBCSSD;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public static readonly Guid MMOGYUXKDRD;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public static readonly Guid VGRPVINFXFZ;

		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public static readonly Guid JYYNRINZFZF;

		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public static readonly Guid MYNANRKRWPL;

		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public static readonly Guid OHGNKHXTACW;

		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public static readonly Guid YYFHGXPXZQD;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public static readonly Guid WQDYXWGRQFT;

		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public static readonly Guid LSRRIYJZONE;

		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public static readonly Guid NKHMFPVTZCX;

		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public static readonly Guid KVLCLBUBFEE;

		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public static readonly Guid PWMQIMXXZIP;

		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public static readonly Guid NLTMPLNQNZV;

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public static readonly Guid DKYMSPACJEA;

		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public static readonly Guid MGRMJDVKUNN;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public static readonly Guid UFGQWOEOYNT;

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public static readonly Guid NAWPYBORGRX;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly Guid BFTPGAGOFDH;

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public static readonly Guid AUONUWUFRMI;

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public static readonly Guid TYLXCYGEYPC;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public static readonly Guid OBFEVQMRZGU;

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public static readonly Guid HIJMUMVSOSE;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public static readonly Guid EZKYTUYBOHE;

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public static readonly Guid MUYIHIWNDHU;

		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public static readonly Guid BFLKDKHPMXB;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public static readonly Guid JUTKTKWUVIY;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public static readonly Guid YCAFQOQUQXG;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public static readonly Guid KNOGMREPPRR;

		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public static readonly Guid SXJRVAKPFZH;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public static readonly Guid JYUEWVCYRVE;

		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public static readonly Guid JMXFVZHMWXJ;

		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public static readonly Guid QQVFCOJSGYG;

		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public static readonly Guid INMIQTFVYVB;

		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public static readonly Guid VHIBRGKNUXV;

		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public static readonly Guid CQKAVVIVMNL;

		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public static readonly Guid KPPFXFWVVGF;

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly Guid CWVGOORSFHT;

		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public static readonly Guid BWMZAPHOUDA;

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public static readonly Guid WXOVCGRDOFK;

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public static readonly Guid HHUGLZAYNAL;

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public static readonly Guid EBOEVZQWMSY;

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public static readonly Guid HEHISJDZLLR;

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public static readonly Guid QHMEUJDIKPO;

		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public static readonly Guid VSRVPASAWER;

		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public static readonly Guid RGEVIYBSJFC;

		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public static readonly Guid JTVFIYKWUYH;

		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public static readonly Guid XMUILEMVVBA;

		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public static readonly Guid ZQFFSYGWLFE;

		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public static readonly Guid XSPLHVGLLTL;

		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public static readonly Guid HWDYEJXBBPF;

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public static readonly Guid CTNREEKRNPU;

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public static readonly Guid ILSBMWXQNAF;

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public static readonly Guid ZBONXXXWNUS;

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public static readonly Guid AFFAJYIUADK;

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public static readonly Guid CWRHKSMQMAT;

		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public static readonly Guid LNQHZZUJAHD;

		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public static readonly Guid LNLBCTALQVU;

		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public static readonly Guid LJTLDHKDNSQ;

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public static readonly Guid VNXLPLKKIPM;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public static readonly Guid KKJRGIVBVUN;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public static readonly Guid JDCTVZNZQEN;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public static readonly Guid MLFTSAGYZWF;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public static readonly Guid UZJIZKMQZJS;

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public static readonly Guid MHYZEDECDGT;

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public static readonly Guid YPTLWTXIKUA;

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static readonly Guid JVLJVFNTPWV;

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static readonly Guid UOJNRSHSGWD;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static readonly Guid LCGLOZTUEFC;

		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public static readonly Guid HFZWDMLKEUJ;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public static readonly Guid CGPIVXVBRCV;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public static readonly Guid TXDDBGQZMBT;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public static readonly Guid VBUPGMQNANS;

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public static readonly Guid IFBDGEJAKEI;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public static readonly Guid FRTCLBCBIDX;

		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public static readonly Guid IGSZWSVQYLX;

		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public static readonly Guid QXHQSJANMZY;

		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public static readonly Guid IQZNRBUSTFG;

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public static readonly Guid MICNRVCTSUL;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public static readonly Guid UVJPUBFOTUR;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public static readonly Guid EUCTFEYOAIX;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public static readonly Guid EWDNTUKCFXD;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public static readonly Guid DKMESRQHEGT;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public static readonly Guid VUAUXUDFXWY;

		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public static readonly Guid AJIYADPTGTC;

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public static readonly Guid TATZVTHRJFD;

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public static readonly Guid QFEXKPHYZCQ;

		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public static readonly Guid WLIJYSUYDLE;

		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public static readonly Guid VWIABDTCOEF;

		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public static readonly Guid RINCXBYMHVO;

		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public static readonly Guid KHLWLQFMHBF;

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public static readonly Guid MDLSRVDNGQJ;

		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public static readonly Guid IKRBBBJDBBM;

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public static readonly Guid MXXMBWDKWYA;

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public static readonly Guid WCZKKVAKKTI;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public static readonly Guid FQWCZSREMMU;

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public static readonly Guid CYQBCWBTSHW;

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public static readonly Guid JUJRVTTFCLW;

		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public static readonly Guid IBYWPRDLRAJ;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public static readonly Guid ZPCTGBUFJMI;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public static readonly Guid FRBCVTEROMV;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public static readonly Guid EPRRXMEEUGR;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public static readonly Guid SAZCOOZUFED;

		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public static readonly Guid UFKGRBDIVQT;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public static readonly Guid WKPSHLDLWUU;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public static readonly Guid CMEIKMZYICV;

		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public static readonly Guid LZCGLSKBTAY;

		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public static readonly Guid PSSFKLCYVAS;

		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public static readonly Guid PSMYNEJBLPJ;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public static readonly Guid PSHRPXPECEA;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public static readonly Guid JDGAJJXSNYZ;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly Guid EGBXJHHKCUZ;

		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public static readonly Guid EFMCRMZSAMY;

		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public static readonly Guid VXFLLHAJGYO;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public static readonly Guid IGIJEEVAYSM;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public static readonly Guid ULBKFHXFEMO;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public static readonly Guid OCGKSIODHOD;

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public static readonly Guid BUDPJBYGLEK;

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public static readonly Guid JRYNSTTIUCA;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public static readonly Guid RZWIWDYZZER;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public static readonly Guid QJLLTDNYBUR;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public static readonly Guid NYIXSTAORNG;

		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public static readonly Guid PUXLBVSUWZY;

		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public static readonly Guid CBRXXHELPPW;

		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public static readonly Guid IFUBUGBMMNE;

		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public static readonly Guid AZUQRMJTPUD;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public static readonly Guid YOYZJHRPALD;

		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public static readonly Guid NLDZCRPCIYU;

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public static readonly Guid NNFGEAFHZBA;

		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public static readonly Guid HBNGSECRXET;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static readonly Guid SVWPDFQHZAK;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static readonly Guid VMVJFSZJUQS;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static readonly Guid QUOTVIJILVK;

		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public static readonly Guid BSRKJTCMBSY;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public static readonly Guid KGSAVHLYKQH;

		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public static readonly Guid GHXCHRVKAOW;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public static readonly Guid HARBGJMGTQN;

		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public static readonly Guid WNBGAWNCFSH;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public static readonly Guid RXKHLCUGYUB;

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public static readonly Guid LNLWONWFLLW;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public static readonly Guid IJHLIYGFGWM;

		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public static readonly Guid LHIDGCNDAXM;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public static readonly Guid LLKQMRHGHRK;

		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public static readonly Guid XPTJAGBIZAQ;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public static readonly Guid CZVUJUDIQNE;

		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public static readonly Guid GJSTKYFSMIO;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public static readonly Guid ZTBTHDTVQXZ;

		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public static readonly Guid BNKKUDMFEXC;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public static readonly Guid NEFJMKKTWLW;

		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public static readonly Guid QVBYBBOAWDT;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public static readonly Guid ZZGWQDKTNAK;

		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public static readonly Guid VEEVSJUSDUW;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public static readonly Guid VJXNRBKIDII;

		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public static readonly Guid YCRLMDODUKI;

		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public static readonly Guid IMJBKKFICDU;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public static readonly Guid PGMJQNRVODW;

		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public static readonly Guid WENSDIPKGXP;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public static readonly Guid YMIPOTIQXOE;

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public static readonly Guid UBEBVNWMBHC;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public static readonly Guid TIYALXOQNII;

		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public static readonly Guid NEJIPXGTSUZ;

		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public static readonly Guid IBFTXDUQKCD;

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public static readonly Guid YOJDBAZEKKJ;

		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public static readonly Guid ECIKXDSSVXA;

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public static readonly Guid HJNKAVDPMPP;

		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public static readonly Guid CGBZVMJWZJI;

		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public static readonly Guid MOHNUSSRKSL;

		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public static readonly Guid BDJLLTGPQWY;

		[Cpp2IlInjected.Token(Token = "0x4000505")]
		public static readonly Guid BQOXHGTGSGQ;

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		public static readonly Guid UNQGZSJRLNA;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public static readonly Guid HXHHSIWKLQT;

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public static readonly Guid VBEXYENVKMK;

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public static readonly Guid KENSGIBYWNC;

		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public static readonly Guid FLJJSPNJSBH;

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public static readonly Guid BXWKJXPSBGB;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public static readonly Guid WWKFGQQMEAI;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public static readonly Guid KNDBKQRXQPT;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public static readonly Guid HSSNGLSJCAG;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public static readonly Guid FWAZHQLEWQR;

		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public static readonly Guid KACOJVGZMTU;

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public static readonly Guid AWECAQWCOIG;

		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public static readonly Guid TVXNBFRJKPL;

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public static readonly Guid TGCXOOZPTOP;

		[Cpp2IlInjected.Token(Token = "0x4000514")]
		public static readonly Guid BFOJHWYQQMW;

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		public static readonly Guid OPBAIJBEYTV;

		[Cpp2IlInjected.Token(Token = "0x4000516")]
		public static readonly Guid LJKLAZIBXYY;

		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public static readonly Guid VUOMJTPAVEB;

		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public static readonly Guid IQVVRXPVXXK;

		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public static readonly Guid STSEQIOPDGG;

		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public static readonly Guid JAXRQLDEQNH;

		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public static readonly Guid QKDFXJTJDAJ;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public static readonly Guid ZVCTNVCIHKG;

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private static readonly Dictionary<Guid, SpawnableToolType> EFECGTLILHQ;

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private static readonly Dictionary<SpawnableToolType, Guid> NXRJDERDTEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IReadOnlyDictionary<Guid, SpawnableToolType> JTRBMOWPOYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84E9970", Offset = "0x84E8770", VA = "0x1884E9970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static IReadOnlyDictionary<SpawnableToolType, Guid> PURBDOTPXOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84E99C0", Offset = "0x84E87C0", VA = "0x1884E99C0")]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class OAPYPSNVGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84F7740", Offset = "0x84F6540", VA = "0x1884F7740")]
		public static bool PJKBZHYNVGE(ConnectableCloneParams a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84F7770", Offset = "0x84F6570", VA = "0x1884F7770")]
		private static bool PJKBZHYNVGE(GNBPGMVYAHJ a, ConnectableCloneParams b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface RCPQJAZNRJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeNewGraph(KJILUGPUMTM data, [Out] Dictionary<int, int> nodeIdMappings);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RunPreInitializationMigration(DEPRECATED_RoomPersistenceVersion roomDataVersion, RUEQTCXZDCS circuitData);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct R1CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		public readonly LCNHFLDFADN Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		public readonly IEnumerable<LZGZZRSUFGL> RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public readonly IReadOnlyList<LZGZZRSUFGL> AllPersistableData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public readonly Id32<DINEWLJZVXU> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public readonly IReadOnlyList<Id128<KSHTGNRFKHE>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SIHHGDGNYGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84F9060", Offset = "0x84F7E60", VA = "0x1884F9060")]
		public R1CreateTemplateParams(LCNHFLDFADN circuits, IEnumerable<LZGZZRSUFGL> rootData, IReadOnlyList<LZGZZRSUFGL> allPersistableData, Id32<DINEWLJZVXU> sourceGraphId, IReadOnlyList<Id128<KSHTGNRFKHE>> circuitNodeIds, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct R2CreateTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public readonly LCNHFLDFADN Circuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public readonly IReadOnlyList<LZGZZRSUFGL> PersistableViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public readonly Id32<DINEWLJZVXU> SourceGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public readonly IReadOnlyList<Id128<KSHTGNRFKHE>> CircuitNodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public readonly ByteString ObjectModelData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public readonly TemplateSerializationReason SerializationReason;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84F90D0", Offset = "0x84F7ED0", VA = "0x1884F90D0")]
		public R2CreateTemplateParams(LCNHFLDFADN circuits, Id32<DINEWLJZVXU> sourceGraphId, IReadOnlyList<Id128<KSHTGNRFKHE>> circuitNodeIds, ByteString objectModelData, IReadOnlyList<LZGZZRSUFGL> persistableViews, TemplateSerializationReason serializationReason)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OOGUZYJCDBI : QYGQDFVECJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public readonly Guid BZFKSXOAVWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<Guid, Guid> SXGHSLNEPLN;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x50E6920", Offset = "0x50E5720", VA = "0x1850E6920")]
		private OOGUZYJCDBI(Guid a, Dictionary<Guid, Guid> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84F7DA0", Offset = "0x84F6BA0", VA = "0x1884F7DA0")]
		public static OOGUZYJCDBI New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84F7CF0", Offset = "0x84F6AF0", VA = "0x1884F7CF0")]
		private static Dictionary<Guid, Guid> KNZCKCXSZMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C70", Offset = "0x84F6A70", VA = "0x1884F7C70")]
		public static OOGUZYJCDBI IIRQESTPCKP(IReadOnlyDictionary<Guid, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84F7E30", Offset = "0x84F6C30", VA = "0x1884F7E30")]
		public static OOGUZYJCDBI OHOWJLIJKJO(IEnumerable<KeyValuePair<Guid, Guid>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C80", Offset = "0x84F6A80", VA = "0x1884F7C80")]
		public Dictionary<Guid, Guid> IYQEHCUQSUG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
		public Dictionary<Guid, Guid> JJNJNHAJSVW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84F7B80", Offset = "0x84F6980", VA = "0x1884F7B80")]
		public void Add(Guid src, Guid dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84F8270", Offset = "0x84F7070", VA = "0x1884F8270")]
		public void SEGGKGZOZYF(IReadOnlyDictionary<Guid, Guid> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84F8120", Offset = "0x84F6F20", VA = "0x1884F8120")]
		public Guid PXCNOKVHJRH([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84F84F0", Offset = "0x84F72F0", VA = "0x1884F84F0")]
		public Guid XJGNOBCSEPC([In] Guid src)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C00", Offset = "0x84F6A00", VA = "0x1884F7C00")]
		public bool FWRHZDNATQB([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84F7C00", Offset = "0x84F6A00", VA = "0x1884F7C00", Slot = "4")]
		private bool LEPMIMVLZSD([In] Guid src, [Out] Guid a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface JVNBLFBPRAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DRXUUOXYMWF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VIKGGGTUCBT(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface UNDGOBUQMJY
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<ByteString> GetValidRoomCurrencies();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<ByteString> GetValidRoomConsumables();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class ORJDDSXTRCM : JVNBLFBPRAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BIIDRRWZCOF : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private string QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private string OKRCHDZTANI
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public BIIDRRWZCOF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84E5B60", Offset = "0x84E4960", VA = "0x1884E5B60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84E5B20", Offset = "0x84E4920", VA = "0x1884E5B20", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84E5C20", Offset = "0x84E4A20", VA = "0x1884E5C20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RBKDWSRDIQZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84E5C20", Offset = "0x84E4A20", VA = "0x1884E5C20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private Dictionary<string, HashSet<Guid>>? GQLOVSNXXKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		protected Dictionary<string, string>? MJLLXOFHHDO;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static IEnumerable<string> MORWYLLRSTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84F8840", Offset = "0x84F7640", VA = "0x1884F8840")]
			[IteratorStateMachine(typeof(BIIDRRWZCOF))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected abstract IReadOnlyCollection<string>? BEGCYIXXGIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected abstract bool MCMGPBCDDAU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected abstract bool MOIXQYJYHAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract List<Guid> BENRADNULZY(string a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool MUOJXOBJDWO(string a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84F8A20", Offset = "0x84F7820", VA = "0x1884F8A20")]
		public void MJJGTDJQYKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1026850", Offset = "0x1025650", VA = "0x181026850")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84F8590", Offset = "0x84F7390", VA = "0x1884F8590", Slot = "4")]
		public bool DRXUUOXYMWF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84F8E50", Offset = "0x84F7C50", VA = "0x1884F8E50", Slot = "5")]
		public bool VIKGGGTUCBT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84F8F20", Offset = "0x84F7D20", VA = "0x1884F8F20")]
		private bool VPKWNPIGRSL(string a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84F88A0", Offset = "0x84F76A0", VA = "0x1884F88A0")]
		protected List<Guid> JNAWXEKAOYW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected ORJDDSXTRCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class FQIZYAFWIKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public LCNHFLDFADN KCKLQXKRZAR;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84FB1B0", Offset = "0x84F9FB0", VA = "0x1884FB1B0")]
			internal Id32<KUBDOTYWEDD> XZSDICVYMMP((Id32<DINEWLJZVXU> GraphId, Id32<KSHTGNRFKHE> NodeId) i)
			{
				return default(Id32<KUBDOTYWEDD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private const int EDRECKKMUZJ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private readonly Dictionary<Id32<KUBDOTYWEDD>, KTQWHBSVUMR> VNPTEXANOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private long DWPJQVREECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private long OTPYPSJVGZK;

		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private static readonly ReadOnlyIdArray<KUBDOTYWEDD, int?> EJMFYCJAGCL;

		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private static readonly long UGPELXRHUJL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long OYZTBLXKFDZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84EA000", Offset = "0x84E8E00", VA = "0x1884EA000")]
		public static FQIZYAFWIKE TGVJKFBQDVP(LCNHFLDFADN a, Id128<DINEWLJZVXU> b, [Optional] FQIZYAFWIKE c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84E9B40", Offset = "0x84E8940", VA = "0x1884E9B40")]
		public static (long, long) QTMSPVZLNBT(LCNHFLDFADN a, Id32<DINEWLJZVXU> b, Id32<KSHTGNRFKHE> c)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84E9EE0", Offset = "0x84E8CE0", VA = "0x1884E9EE0")]
		public static long SKNHRDLGEQO([In] ReadOnlySpan<Id32<KUBDOTYWEDD>> nodeDefIds)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84E9A10", Offset = "0x84E8810", VA = "0x1884E9A10")]
		private static long ADQAOITLVJZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84F7580", Offset = "0x84F6380", VA = "0x1884F7580")]
		public FQIZYAFWIKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class KTQWHBSVUMR
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public long ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xEABA00", Offset = "0xEAA800", VA = "0x180EABA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long HAEHHRZVCPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8064960", Offset = "0x8063760", VA = "0x188064960")]
		public KTQWHBSVUMR(long a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class AINHIAUSUTD
	{
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public static readonly HashSet<SpawnableToolType> NMMHCHQLKWM;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class YKXHFHQMHYO
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class JJYBXUTFYOJ : IEnumerable<LZGZZRSUFGL>, IEnumerable, IEnumerator<LZGZZRSUFGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private LZGZZRSUFGL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			private SpawnableTemplateData EPKWJCXIJEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public SpawnableTemplateData HCJXBFPVMZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private SpawnTemplateParams BPGIHJMTLOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public SpawnTemplateParams ZLYCSLRYNQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private int ZTWVKUQIWZR;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private LZGZZRSUFGL TGTUKOHKNES
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public JJYBXUTFYOJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x84FAC50", Offset = "0x84F9A50", VA = "0x1884FAC50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84FAC10", Offset = "0x84F9A10", VA = "0x1884FAC10", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x84FAD60", Offset = "0x84F9B60", VA = "0x1884FAD60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LZGZZRSUFGL> RKNRZVDBDEB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x84FAD60", Offset = "0x84F9B60", VA = "0x1884FAD60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x850A080", Offset = "0x8508E80", VA = "0x18850A080")]
		public static SpawnableTemplateData TNLCTWASRSV([In] R2CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x850A200", Offset = "0x8509000", VA = "0x18850A200")]
		public static SpawnableTemplateData TNLCTWASRSV([In] R1CreateTemplateParams createTemplateParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x850A840", Offset = "0x8509640", VA = "0x18850A840")]
		private static HashSet<Id128<KGPKSSYXHLM>> WYWEEJWDFWL(IReadOnlyList<LZGZZRSUFGL> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8508BF0", Offset = "0x85079F0", VA = "0x188508BF0")]
		private static void EBRDESLWTVW(SpawnableTemplateData a, [In] R1CreateTemplateParams createParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8507600", Offset = "0x8506400", VA = "0x188507600")]
		public static Result<OOGUZYJCDBI, TryCloneTemplateError> CYXVKLTYOOH(SpawnableTemplateData a, SpawnTemplateParams b, OOGUZYJCDBI? srcRemapper, bool c)
		{
			return default(Result<OOGUZYJCDBI, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8509260", Offset = "0x8508060", VA = "0x188509260")]
		[IteratorStateMachine(typeof(JJYBXUTFYOJ))]
		private static IEnumerable<LZGZZRSUFGL> EFJHAHJQSEY(SpawnableTemplateData a, SpawnTemplateParams b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8509660", Offset = "0x8508460", VA = "0x188509660")]
		private static void HIRPCMJTYTR(SpawnableTemplateData a, SpawnTemplateParams b, IReadOnlyCollection<ByteString>? validRoomConsumables, IReadOnlyCollection<ByteString>? validRoomCurrencies, IReadOnlyCollection<ByteString>? validRoomKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85099F0", Offset = "0x85087F0", VA = "0x1885099F0")]
		private static bool THBHGATICBE(SpawnableTemplateData a, DEPRECATED_RoomPersistenceVersion b, SpawnTemplateParams c, [Out][NotNullWhen(false)] string? error, [Out] Dictionary<int, int> d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8509370", Offset = "0x8508170", VA = "0x188509370")]
		private static Dictionary<Guid, GNBPGMVYAHJ> FVSGRJKNEKS(SpawnableTemplateData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85096D0", Offset = "0x85084D0", VA = "0x1885096D0")]
		private static void KMBLGXTKRCU(bool a, LZGZZRSUFGL b, OOGUZYJCDBI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8509760", Offset = "0x8508560", VA = "0x188509760")]
		private static void NAKIFHGLKVW(LZGZZRSUFGL a, Guid b, SpawnTransformData? c, Dictionary<Guid, GNBPGMVYAHJ> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x850A390", Offset = "0x8509190", VA = "0x18850A390")]
		private static void TOKZVXEHPPH(IEnumerable<LZGZZRSUFGL> a, IReadOnlyCollection<ByteString> b, IReadOnlyCollection<ByteString> c, IReadOnlyCollection<ByteString> d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct SpawnTemplateParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public bool assignNewIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public TemplateSerializationReason serializationReason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public SpawnTransformData? spawnTransformData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public SpawnTransformData? originScopeTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public LCNHFLDFADN circuitsInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public UNDGOBUQMJY roomObjectReferenceProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public RCPQJAZNRJE circuitsV1CloneLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public Id128<DINEWLJZVXU> spawnIntoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public JWKBEMIEJCU globalCircuitGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public List<LZGZZRSUFGL> skipGameNodeViewDatas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public CreationInstantiationParameters instantiationParameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public CONATZAXQMO photonIdToPersistenceViewIdProvider;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct SpawnTransformData
	{
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private const float DEFAULT_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public float scale;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Matrix4x4 HGASQPLNLGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85018F0", Offset = "0x85006F0", VA = "0x1885018F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public UniformTRS GHJUYYSATOU
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8501610", Offset = "0x8500410", VA = "0x188501610")]
			get
			{
				return default(UniformTRS);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16B3350", Offset = "0x16B2150", VA = "0x1816B3350")]
		public SpawnTransformData(Vector3 position, Quaternion rotation, float scale = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8501D00", Offset = "0x8500B00", VA = "0x188501D00")]
		public SpawnTransformData(UniformTRS uniformTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8501A80", Offset = "0x8500880", VA = "0x188501A80")]
		public static SpawnTransformData XOJHJVVYCXE(SpawnTransformData a, SpawnTransformData b)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8501DD0", Offset = "0x8500BD0", VA = "0x188501DD0")]
		public static implicit operator SpawnTransformData((Vector3, Quaternion, float) data)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8501DF0", Offset = "0x8500BF0", VA = "0x188501DF0")]
		public static implicit operator SpawnTransformData(Matrix4x4 matrix)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85019F0", Offset = "0x85007F0", VA = "0x1885019F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8501650", Offset = "0x8500450", VA = "0x188501650")]
		public SpawnTransformData KAPSMCQBMAQ(Matrix4x4 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85015A0", Offset = "0x85003A0", VA = "0x1885015A0")]
		public static SpawnTransformData ARLKPOEWSFO(Vector3 a)
		{
			return default(SpawnTransformData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8501860", Offset = "0x8500660", VA = "0x188501860")]
		public readonly CircuitsRigidTransform PXIXVDHNOQY()
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TemplateContentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		Chip = 0,
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		Object = 99
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct TryCloneTemplateError
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		public readonly TryCloneTemplateErrorKind Kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private readonly XDRQUNZRUHP _innerError;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1973790", Offset = "0x1972590", VA = "0x181973790")]
		private TryCloneTemplateError(TryCloneTemplateErrorKind kind, XDRQUNZRUHP innerError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85021B0", Offset = "0x8500FB0", VA = "0x1885021B0")]
		public DAXFGKUQCIS KZRZANURPDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8502220", Offset = "0x8501020", VA = "0x188502220")]
		public static Result<OOGUZYJCDBI, TryCloneTemplateError> New(KZDWVBVHAYP<None> innerError)
		{
			return default(Result<OOGUZYJCDBI, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8502390", Offset = "0x8501190", VA = "0x188502390")]
		public static Result<OOGUZYJCDBI, TryCloneTemplateError> New(DAXFGKUQCIS innerError)
		{
			return default(Result<OOGUZYJCDBI, TryCloneTemplateError>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x85022D0", Offset = "0x85010D0", VA = "0x1885022D0")]
		public static Result<OOGUZYJCDBI, TryCloneTemplateError> New(string errorMsg)
		{
			return default(Result<OOGUZYJCDBI, TryCloneTemplateError>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TryCloneTemplateErrorKind
	{
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		PrepareTemplateForClone
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WBDFIMNPCAL : IDisposable, BMLNPZAMNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private NativeList<CurvePointData> HUKRUCLLAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private float HALIAGKSRAC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ShapeConfigFlags IFSMXXDVHYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool UTLVJSQWLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x85046A0", Offset = "0x85034A0", VA = "0x1885046A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SNPMMPNJZGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8505810", Offset = "0x8504610", VA = "0x188505810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public List<CurvePoint> MNAMMTLFYGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int KTRGQSZOXEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8505430", Offset = "0x8504230", VA = "0x188505430", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float YYSOKFFQFHF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8505470", Offset = "0x8504270", VA = "0x188505470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8506330", Offset = "0x8505130", VA = "0x188506330")]
		public WBDFIMNPCAL(ShapeConfigFlags a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8503BD0", Offset = "0x85029D0", VA = "0x188503BD0", Slot = "9")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8504D60", Offset = "0x8503B60", VA = "0x188504D60")]
		public Vector3 KEUOIGSRWPM(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8504570", Offset = "0x8503370", VA = "0x188504570", Slot = "6")]
		public Quaternion HNDISJRCQJN(int a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8505230", Offset = "0x8504030", VA = "0x188505230", Slot = "5")]
		public Vector3 KYOVACQYOIK(int a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8506180", Offset = "0x8504F80", VA = "0x188506180", Slot = "7")]
		public float ZHDRQULWSAT(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8503C90", Offset = "0x8502A90", VA = "0x188503C90")]
		public void GXXDHCEYZRD(Vector3 a, Quaternion b, float c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8503C30", Offset = "0x8502A30", VA = "0x188503C30")]
		private bool FTIQBJFCRSR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8505820", Offset = "0x8504620", VA = "0x188505820")]
		public void XKXKSVDQKNF(Vector3 a, Quaternion b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8503AE0", Offset = "0x85028E0", VA = "0x188503AE0")]
		public void DJKZOKOEREW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85061E0", Offset = "0x8504FE0", VA = "0x1885061E0")]
		public void ZWRBUKKKPHJ(int a, Vector3 b, Quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8505660", Offset = "0x8504460", VA = "0x188505660")]
		public void VBMOBVASDJN(int a, float3 b, quaternion c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8503990", Offset = "0x8502790", VA = "0x188503990")]
		public void ASFESPTFNSR(int a, Vector3 b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85052D0", Offset = "0x85040D0", VA = "0x1885052D0")]
		public void LIGRENQQIAE(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8505980", Offset = "0x8504780", VA = "0x188505980")]
		public static Quaternion ZCCVUXFCPTI(Quaternion a, int b, float c, BMLNPZAMNJE d)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85046B0", Offset = "0x85034B0", VA = "0x1885046B0")]
		public Bounds IEUURYQCITI(Transform a)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8503B70", Offset = "0x8502970", VA = "0x188503B70", Slot = "10")]
		public virtual void DPQGZPHGLXY(bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85055B0", Offset = "0x85043B0", VA = "0x1885055B0")]
		public NativeList<CurvePointData> OMXMDNWWMHM(float a = 1f)
		{
			return default(NativeList<CurvePointData>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CurvePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public float3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public float Radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public quaternion TwistRotation;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84F9990", Offset = "0x84F8790", VA = "0x1884F9990")]
		public CurvePoint(Vector3 pos, Quaternion rot, float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84F9440", Offset = "0x84F8240", VA = "0x1884F9440")]
		public Quaternion IYBXVZXOFOD(Vector3 a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84F96A0", Offset = "0x84F84A0", VA = "0x1884F96A0")]
		public CurvePoint WKPKXACFWGT(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(CurvePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84F9500", Offset = "0x84F8300", VA = "0x1884F9500")]
		public BTSODNVDPXU KEQHQHHWWJV(Vector3 a)
		{
			return null;
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class NMQBNERIEGA : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84FB630", Offset = "0x84FA430", VA = "0x1884FB630", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84FB990", Offset = "0x84FA790", VA = "0x1884FB990")]
		private void OVYXMEUXMAD(Dictionary<Guid, Guid> a, ObjectGroupData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84FB930", Offset = "0x84FA730", VA = "0x1884FB930")]
		private void OVYXMEUXMAD(Dictionary<Guid, Guid> a, VGNNCIMQNLG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84FB6B0", Offset = "0x84FA4B0", VA = "0x1884FB6B0")]
		private void OVYXMEUXMAD(Dictionary<Guid, Guid> a, KTJNPGQJUHH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NMQBNERIEGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class QKQYFJXZSZX : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8500CD0", Offset = "0x84FFAD0", VA = "0x188500CD0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public QKQYFJXZSZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class JHRDUTLJLWK : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84FAAB0", Offset = "0x84F98B0", VA = "0x1884FAAB0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JHRDUTLJLWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class TCZLLDPRGJW : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8501F50", Offset = "0x8500D50", VA = "0x188501F50", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TCZLLDPRGJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class ICXIQPHZXKS : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84F9D90", Offset = "0x84F8B90", VA = "0x1884F9D90", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ICXIQPHZXKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class KLIXFUHMGKD : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84FAEC0", Offset = "0x84F9CC0", VA = "0x1884FAEC0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KLIXFUHMGKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class ZWAYHKAXDQV : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x850ABE0", Offset = "0x85099E0", VA = "0x18850ABE0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ZWAYHKAXDQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class COPPULBMBBY : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84F9350", Offset = "0x84F8150", VA = "0x1884F9350", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public COPPULBMBBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class IMUYLSMDOIY : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84FA160", Offset = "0x84F8F60", VA = "0x1884FA160", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IMUYLSMDOIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class KNIAVSTIJZG : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x84FB000", Offset = "0x84F9E00", VA = "0x1884FB000", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KNIAVSTIJZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class TSNJIGSWOGE : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85020B0", Offset = "0x8500EB0", VA = "0x1885020B0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TSNJIGSWOGE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class YGXQKDUAMKX : TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public static readonly RGWZNZZYEQR EZMMNGYAWJW;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85074E0", Offset = "0x85062E0", VA = "0x1885074E0", Slot = "4")]
		public void HAUHUNIYQTM(PersistableCloneParams a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YGXQKDUAMKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ConnectableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public DEPRECATED_RoomPersistenceVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public ConnectableGraphData connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public CONATZAXQMO photonIdToPersistenceViewIdProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public bool objectModelEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface TBMHMDMVZKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HAUHUNIYQTM(PersistableCloneParams a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class WXRDGOWMTWI
	{
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private static readonly TBMHMDMVZKH[] NDWQVAFFQCM;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85063B0", Offset = "0x85051B0", VA = "0x1885063B0")]
		public static void JMAFTUICAMV(LZGZZRSUFGL a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8506C80", Offset = "0x8505A80", VA = "0x188506C80")]
		public static void XHOCSYDVVPD(LZGZZRSUFGL? data, OOGUZYJCDBI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8506A00", Offset = "0x8505800", VA = "0x188506A00")]
		public static void TUDMXMXTYRR(LZGZZRSUFGL? data, OOGUZYJCDBI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8506630", Offset = "0x8505430", VA = "0x188506630")]
		public static void PJKBZHYNVGE(PersistableCloneParams a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PersistableCloneParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		public LZGZZRSUFGL viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public Dictionary<int, int> nodeIdMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public Dictionary<Guid, Guid> guidMapping;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84FBF70", Offset = "0x84FAD70", VA = "0x1884FBF70")]
		public Guid FPDJCYMRTXQ(Guid a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface CONATZAXQMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetPersistenceViewId(int photonId, [Out] Guid persistenceViewId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class PersistedRoomDataReferences
	{
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private static readonly HashSet<Guid> XWMXRDPZMAB;

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly HashSet<Guid> WPZEVUEULSP;

		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private static readonly HashSet<Guid> UCXQBNMFBID;

		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly ProfilerMarker ONQNJGTGNXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private readonly HashSet<string> EWCZEBOPJZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private readonly Dictionary<long, int> IQKEWHJISFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private readonly HashSet<Guid> JFOFGYFEFGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private readonly HashSet<Guid> XAULUGWFWJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private readonly HashSet<Guid> TMQRDCCYBED;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyCollection<string> VOGUAZRJNIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyCollection<Guid> HDLMFZERSWD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyCollection<Guid> ZTGIPEXHKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyDictionary<long, int> SIELTIIEYST
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84FE610", Offset = "0x84FD410", VA = "0x1884FE610")]
		public static void NQKPEMREAHB(SpawnableTemplateData a, GXPZZIPDOXX b, OOGUZYJCDBI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85001B0", Offset = "0x84FEFB0", VA = "0x1885001B0")]
		public static PersistedRoomDataReferences QHYYWTUNYSX(PersistedRoomData a, GXPZZIPDOXX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84FE250", Offset = "0x84FD050", VA = "0x1884FE250")]
		public static PersistedRoomDataReferences GEQWEORWKNS(SpawnableTemplateData a, GXPZZIPDOXX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84FE550", Offset = "0x84FD350", VA = "0x1884FE550")]
		public static PersistedRoomDataReferences IJWZHGDMRWK(YWKRMCXBOWC a, XICIYJNZHHE b, GXPZZIPDOXX? unitySubAssetUsage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84FE050", Offset = "0x84FCE50", VA = "0x1884FE050")]
		public static PersistedRoomDataReferences FHVWXIVMHML(IEnumerable<string> a, IReadOnlyDictionary<long, int> b, IReadOnlyCollection<Guid> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8500B70", Offset = "0x84FF970", VA = "0x188500B70")]
		private PersistedRoomDataReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85009A0", Offset = "0x84FF7A0", VA = "0x1885009A0")]
		private PersistedRoomDataReferences(IEnumerable<string> referencedFilenames, IReadOnlyDictionary<long, int> inventionUsages, IReadOnlyCollection<Guid> referencedUnityAssetIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84FCC80", Offset = "0x84FBA80", VA = "0x1884FCC80")]
		private void BWKDESNEFPA(PersistedRoomData a, GXPZZIPDOXX? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84FC5F0", Offset = "0x84FB3F0", VA = "0x1884FC5F0")]
		private void BWKDESNEFPA(SpawnableTemplateData a, GXPZZIPDOXX? unitySubAssetUsage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84FDAA0", Offset = "0x84FC8A0", VA = "0x1884FDAA0")]
		private void ExtractReferencesFromObjectModelData(ByteString? objectModelData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84FCF20", Offset = "0x84FBD20", VA = "0x1884FCF20")]
		private void BWKDESNEFPA(YWKRMCXBOWC? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84FC570", Offset = "0x84FB370", VA = "0x1884FC570")]
		private void BWKDESNEFPA(XICIYJNZHHE? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x84FC390", Offset = "0x84FB190", VA = "0x1884FC390")]
		private void BWKDESNEFPA(GRJGPEXUVQW? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8500470", Offset = "0x84FF270", VA = "0x188500470")]
		private static bool RVGBVUUPLJL(GRJGPEXUVQW a, int b, [Out] string? filenameReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8500230", Offset = "0x84FF030", VA = "0x188500230")]
		private static bool QSQPIJWFRQD(GRJGPEXUVQW a, int b, [Out] Guid c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84FF3C0", Offset = "0x84FE1C0", VA = "0x1884FF3C0")]
		private static void NQKPEMREAHB(XICIYJNZHHE? root, GXPZZIPDOXX a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x84FFF20", Offset = "0x84FED20", VA = "0x1884FFF20")]
		private static void NQKPEMREAHB(GRJGPEXUVQW? customProperties, GXPZZIPDOXX a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84FF020", Offset = "0x84FDE20", VA = "0x1884FF020")]
		private static void NQKPEMREAHB(YWKRMCXBOWC? root, GXPZZIPDOXX a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x84FF8D0", Offset = "0x84FE6D0", VA = "0x1884FF8D0")]
		private static void NQKPEMREAHB(CircuitsV2.Protobuf.CircuitNodeData? node, GXPZZIPDOXX a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84FC010", Offset = "0x84FAE10", VA = "0x1884FC010")]
		private void BWKDESNEFPA(CircuitsV2.Protobuf.CircuitNodeData? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x84FE2D0", Offset = "0x84FD0D0", VA = "0x1884FE2D0")]
		private void GKPLQETAVAW(Guid? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84FC880", Offset = "0x84FB680", VA = "0x1884FC880")]
		private void BWKDESNEFPA(LZGZZRSUFGL? a, GXPZZIPDOXX? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84FF490", Offset = "0x84FE290", VA = "0x1884FF490")]
		private static void NQKPEMREAHB(LZGZZRSUFGL? viewData, GXPZZIPDOXX a, OOGUZYJCDBI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84FE4E0", Offset = "0x84FD2E0", VA = "0x1884FE4E0")]
		private void HKNHCXKCHAH(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84FD9D0", Offset = "0x84FC7D0", VA = "0x1884FD9D0")]
		private void DDOSWKPLBKJ(long a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84FD920", Offset = "0x84FC720", VA = "0x1884FD920")]
		private void DDOSWKPLBKJ(RecRoom.Protobuf.InventionPieceData? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84FD970", Offset = "0x84FC770", VA = "0x1884FD970")]
		private void DDOSWKPLBKJ(CircuitsV2.Protobuf.InventionPieceData? a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct UgcRoomSaveStatsDetailed
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private class NBPHOLAXRDW : IDictionaryEnumerator, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private readonly IEnumerator<DictionaryEntry> LQPDZLYIHGB;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public DictionaryEntry Entry
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x84FB400", Offset = "0x84FA200", VA = "0x1884FB400", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public object Key
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0x84FB4D0", Offset = "0x84FA2D0", VA = "0x1884FB4D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public object Value
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x84FB580", Offset = "0x84FA380", VA = "0x1884FB580", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public object Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x84FB320", Offset = "0x84FA120", VA = "0x1884FB320", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
			public NBPHOLAXRDW(IEnumerator<DictionaryEntry> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x84FB280", Offset = "0x84FA080", VA = "0x1884FB280", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x84FB2D0", Offset = "0x84FA0D0", VA = "0x1884FB2D0", Slot = "9")]
			public void Reset()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct RoomObjectCounts : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			[CompilerGenerated]
			private sealed class UDFQZCXWDGS : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000583")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000584")]
				private DictionaryEntry QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000585")]
				public RoomObjectCounts WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				private DictionaryEntry XHUWCNTZZGE
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0x8502770", Offset = "0x8501570", VA = "0x188502770", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
				[DebuggerHidden]
				public UDFQZCXWDGS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8502670", Offset = "0x8501470", VA = "0x188502670", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F7")]
				[Cpp2IlInjected.Address(RVA = "0x8502630", Offset = "0x8501430", VA = "0x188502630", Slot = "8")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public readonly Dictionary<int, int> ByInvention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public readonly Dictionary<int, int> ByGraph;

			[Cpp2IlInjected.Token(Token = "0x4000581")]
			private static readonly string[] keys1;

			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private static readonly string[] keys2;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private ICollection RKSQSOFWVEO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x8501350", Offset = "0x8500150", VA = "0x188501350", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x8501190", Offset = "0x84FFF90", VA = "0x188501190", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x8501270", Offset = "0x8500070", VA = "0x188501270", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private bool KTMYFJXJZBH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x8501050", Offset = "0x84FFE50", VA = "0x188501050", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			private bool SDJMXCVLFKU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x8501140", Offset = "0x84FFF40", VA = "0x188501140", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private ICollection NEVCRDOHGLO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0x8500E20", Offset = "0x84FFC20", VA = "0x188500E20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private int OWDSBBERCWB
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x85013D0", Offset = "0x85001D0", VA = "0x1885013D0", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private bool ONNZBNYBYTO
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x85010F0", Offset = "0x84FFEF0", VA = "0x1885010F0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object QMKEPHWMILP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0x8501420", Offset = "0x8500220", VA = "0x188501420", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			public RoomObjectCounts(Dictionary<int, int> byInvention, [Optional] Dictionary<int, int> byGraph)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8500E70", Offset = "0x84FFC70", VA = "0x188500E70")]
			[IteratorStateMachine(typeof(UDFQZCXWDGS))]
			private IEnumerator<DictionaryEntry> BGWABGPQCHL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x85012B0", Offset = "0x85000B0", VA = "0x1885012B0", Slot = "19")]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8500F30", Offset = "0x84FFD30", VA = "0x188500F30", Slot = "13")]
			private IDictionaryEnumerator EULOJDUUTBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8500EE0", Offset = "0x84FFCE0", VA = "0x188500EE0", Slot = "9")]
			private void EKDNYQHKNXL(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8501000", Offset = "0x84FFE00", VA = "0x188501000", Slot = "10")]
			private void IHFSNUXCNJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8500DD0", Offset = "0x84FFBD0", VA = "0x188500DD0", Slot = "8")]
			private bool AMZYDHBGVTR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85010A0", Offset = "0x84FFEA0", VA = "0x1885010A0", Slot = "14")]
			private void NXNAWEJUCGO(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8500D80", Offset = "0x84FFB80", VA = "0x188500D80", Slot = "15")]
			private void ACZLMEPWXIC(Array a, int b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct Invention : IDictionary, ICollection, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			[CompilerGenerated]
			private sealed class IFDXVVMMGMG : IEnumerator<DictionaryEntry>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000589")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400058A")]
				private DictionaryEntry QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400058B")]
				public Invention WFAEFPOXIOJ;

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				private DictionaryEntry XHUWCNTZZGE
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryEntry);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0x84FA110", Offset = "0x84F8F10", VA = "0x1884FA110", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
				[DebuggerHidden]
				public IFDXVVMMGMG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x84F9FF0", Offset = "0x84F8DF0", VA = "0x1884F9FF0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x84F9FB0", Offset = "0x84F8DB0", VA = "0x1884F9FB0", Slot = "8")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public readonly long id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public readonly int count;

			[Cpp2IlInjected.Token(Token = "0x4000588")]
			private static readonly string[] keys;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private ICollection RKSQSOFWVEO
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x84FA8F0", Offset = "0x84F96F0", VA = "0x1884FA8F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IDictionary.this[object key]
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x84FA710", Offset = "0x84F9510", VA = "0x1884FA710", Slot = "4")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x84FA820", Offset = "0x84F9620", VA = "0x1884FA820", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private bool KTMYFJXJZBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x84FA5D0", Offset = "0x84F93D0", VA = "0x1884FA5D0", Slot = "12")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private bool SDJMXCVLFKU
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x84FA6C0", Offset = "0x84F94C0", VA = "0x1884FA6C0", Slot = "11")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ICollection NEVCRDOHGLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x84FA3B0", Offset = "0x84F91B0", VA = "0x1884FA3B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private int OWDSBBERCWB
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x84FA940", Offset = "0x84F9740", VA = "0x1884FA940", Slot = "16")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private bool ONNZBNYBYTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x84FA670", Offset = "0x84F9470", VA = "0x1884FA670", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object QMKEPHWMILP
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x84FA990", Offset = "0x84F9790", VA = "0x1884FA990", Slot = "17")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2AD1130", Offset = "0x2ACFF30", VA = "0x182AD1130")]
			public Invention(long id, int count)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x84FA400", Offset = "0x84F9200", VA = "0x1884FA400")]
			[IteratorStateMachine(typeof(IFDXVVMMGMG))]
			private IEnumerator<DictionaryEntry> BGWABGPQCHL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x84FA860", Offset = "0x84F9660", VA = "0x1884FA860", Slot = "19")]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x84FA4B0", Offset = "0x84F92B0", VA = "0x1884FA4B0", Slot = "13")]
			private IDictionaryEnumerator EULOJDUUTBO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x84FA460", Offset = "0x84F9260", VA = "0x1884FA460", Slot = "9")]
			private void EKDNYQHKNXL(object a, object b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84FA580", Offset = "0x84F9380", VA = "0x1884FA580", Slot = "10")]
			private void IHFSNUXCNJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x84FA360", Offset = "0x84F9160", VA = "0x1884FA360", Slot = "8")]
			private bool AMZYDHBGVTR(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x84FA620", Offset = "0x84F9420", VA = "0x1884FA620", Slot = "14")]
			private void NXNAWEJUCGO(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x84FA310", Offset = "0x84F9110", VA = "0x1884FA310", Slot = "15")]
			private void ACZLMEPWXIC(Array a, int b)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public readonly IReadOnlyDictionary<Guid, RoomObjectCounts> RoomObjectCountsByObjectTypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public readonly IReadOnlyList<Invention> Inventions;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
		public UgcRoomSaveStatsDetailed(IReadOnlyDictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId, IReadOnlyList<Invention> inventions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8502F80", Offset = "0x8501D80", VA = "0x188502F80")]
		public static UgcRoomSaveStatsDetailed QHYYWTUNYSX(PersistedRoomData a)
		{
			return default(UgcRoomSaveStatsDetailed);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85027C0", Offset = "0x85015C0", VA = "0x1885027C0")]
		[CompilerGenerated]
		internal static int JYKVDRGPUZD([In] IReadOnlyDictionary<long, int> inventionIdToIndex, long? a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85028E0", Offset = "0x85016E0", VA = "0x1885028E0")]
		[CompilerGenerated]
		internal static void NOAUCTBOARD(int a, [In] YWKRMCXBOWC graphData, [In] Dictionary<long, int> inventionIdToIndex, [In] Dictionary<Guid, RoomObjectCounts> roomObjectCountsByObjectTypeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum UnitySubAssetKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		StudioObject,
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		AudioClip,
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		Projectile,
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		ParticleVfx
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class GXPZZIPDOXX
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public sealed class UnitySubAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public readonly Guid LLBPFNWOAUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public readonly IReadOnlyList<Guid> HDLMFZERSWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public readonly UnitySubAssetKind JSZILMLWUMV;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8503930", Offset = "0x8502730", VA = "0x188503930")]
			public UnitySubAsset(Guid unityAssetId, IReadOnlyList<Guid> referencedUnityAssetIds, UnitySubAssetKind kind)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private readonly OOGUZYJCDBI DYWYGTASWTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private readonly Dictionary<Guid, UnitySubAsset> PDLLNPUNRSK;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public OOGUZYJCDBI JQPTGEGVIWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A10", Offset = "0x84F8810", VA = "0x1884F9A10")]
		public void Add(Guid exportId, Guid unitySubAssetId, IReadOnlyList<Guid> referencedUnityAssetsIds, UnitySubAssetKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x84F9C10", Offset = "0x84F8A10", VA = "0x1884F9C10")]
		public bool MMIQGJNFFQC(Guid a, [Out] UnitySubAsset b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x84F9D00", Offset = "0x84F8B00", VA = "0x1884F9D00")]
		public GXPZZIPDOXX()
		{
		}
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
