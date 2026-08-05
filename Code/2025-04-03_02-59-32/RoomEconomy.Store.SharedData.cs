using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NOLPPHKIBGM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	CameraFilter = 0,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Potion_Head = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Potion_Hand = 3,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Food = 4,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	KO_Customization = 5,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Potion_HairDye = 6,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Coupon = 7,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	VFX = 8
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NLJANFOAFJJ
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Purchasable = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Owned = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Film = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Potion = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Food = 16,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GiftBox = 32,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Hat = 64,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	HeadHair = 128,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Eye = 256,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Torso = 512,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Glove = 1024,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OneStar = 2048,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TwoStar = 4096,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	ThreeStar = 8192,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	FourStar = 16384,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	FiveStar = 32768,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	KOIcon = 65536,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	HairDyes = 131072,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	EquipmentSkin = 262144,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Featured = 524288,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	New = 1048576,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Members = 2097152,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Other = 4194304,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Bottoms = 8388608,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Shoes = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Ear = 33554432,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Neck = 67108864,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Shoulder = 134217728,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Waist = 268435456,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	FacialHair = 536870912,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Hair = 536871040,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Accessory = 503316736,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	OwnershipFilters = 3,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ClothingTypeFilters = 1065355200,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConsumableFilters = 4390972,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	RarityFilters = 63488,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	SpecialTypeFilters = 3932160,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ClothingOrConsumables = 1069746172
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
