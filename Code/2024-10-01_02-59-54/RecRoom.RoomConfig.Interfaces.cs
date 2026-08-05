using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[LPDJILJKCIH]
public enum LHBBFBHIOIF
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DORM_ROOM = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	REC_CENTER = 1,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LEGACY_CHARADES = 2,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	LAKE = 3,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	PROPULSION = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	DODGEBALL = 5,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	THE_LOUNGE = 6,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	PADDLEBALL = 7,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	RIVER = 8,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	HOMESTEAD = 9,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	QUARRY = 10,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	CLEAR_CUT = 11,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	SPILLWAY = 12,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	QUEST_FOR_THE_GOLDEN_TROPHY = 13,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ORIENTATION = 14,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	THE_RISE_OF_JUMBOTRON = 15,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CURSE_OF_THE_CRIMSON_CAULDRON = 16,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	THE_ISLE_OF_LOST_SKULLS = 17,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	SOCCER = 18,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	PERFORMANCE_HALL = 19,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PSVR_ROOM_CALIBRATION = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PARK = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	WAREHOUSE = 22,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	CYBERJUNK_CITY = 23,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	MAKER_ROOM = 24,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	FRONTIER_SQUADS = 25,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	FRONTIER_SOLOS = 26,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	CRESCENDO_OF_THE_BLOOD_MOON = 27,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	BOWLING_ALLEY = 28,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	STUNTRUNNER = 30,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	STUNTRUNNER_THE_MAIN_EVENT = 31,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	STUNTRUNNER_BASE_ROOM = 32,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	REGISTRATION = 33,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	AR_ROOM = 34,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	DRIVEIN = 35,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	CHARADES_THE_INK_SPACE = 36,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	THE_INK_SPACE_BASE_ROOM = 37,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	FRONTIER_UGC = 38,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RECRALLY = 39,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	MAKER_ROOM_2 = 40,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	CUSTOM_DORM_ROOM = 41
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NMCPJJOOGAP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Dictionary<string, LHBBFBHIOIF> GACMMPEBJIP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7484DF0", Offset = "0x74841F0", VA = "0x187484DF0")]
	public static bool FDPJDJCOJAH(string PMBCBEBMHBL, [Out] LHBBFBHIOIF FIGDNNLIGBB)
	{
		return default(bool);
	}
}
namespace Cpp2IlInjected;

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
