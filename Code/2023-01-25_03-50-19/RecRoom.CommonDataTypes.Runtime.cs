using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6127070", Offset = "0x6126070", VA = "0x186127070")]
	public bool OBKPJMJDFBO(PDOCDCCKIGM ENMJLAELNLM, out Color OEGNINEOMFI, bool MAPHBKEIAJD = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public PDOCDCCKIGM Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PDOCDCCKIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FIGKNNHKKAK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	MODE_10
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GCBKCODFFDG
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Code,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PartyGesture,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	ProfileScreen,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	PeopleMenuShortcut,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	InviteToPartyDialog,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	PartyInviteInChat
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CJLGFFPLMAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NKDEDNBOINB
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JDHEIBJJDJD
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KBOHECOFCGM
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	WALK
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
