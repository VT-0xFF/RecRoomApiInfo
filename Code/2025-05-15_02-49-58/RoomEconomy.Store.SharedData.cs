using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FPEBHBIPBLO
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
public enum KHPHOANPFAN
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	ItemsTab,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ItemDetails,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BuyButton,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TrialStart,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TrialFailed,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TrialEnd,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	GiftButton,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	GiftFailed,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	GiftSent,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	ConfirmButton,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	ShareButton,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PurchaseSuccessful,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PurchaseError,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	NotEnoughTokensPrompt,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NotEnoughTokensCancel,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	NotEnoughTokensGet,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	WishlistButton,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	WishlistFailed,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	UnwishlistButton,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ViewMoreButton,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	NotEnoughTokensGet_TokenStore,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	NotEnoughTokensGet_PromptLowest,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	PurchaseSuccessfulPrompt_Tokens,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	PurchaseSuccessfulPrompt_TokensItem,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	PurchaseSuccessful_ReturnToCheckout,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PurchaseSuccessful_GoShop,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	PurchaseSuccessful_TokenStore
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JOHNAICEDOD
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Purchasable = 1,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Owned = 2,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Film = 4,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Potion = 8,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Food = 16,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	GiftBox = 32,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Hat = 64,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	HeadHair = 128,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Eye = 256,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Torso = 512,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Glove = 1024,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	OneStar = 2048,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwoStar = 4096,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	ThreeStar = 8192,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FourStar = 16384,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveStar = 32768,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	KOIcon = 65536,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	HairDyes = 131072,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	EquipmentSkin = 262144,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Featured = 524288,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	New = 1048576,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Members = 2097152,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Other = 4194304,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Bottoms = 8388608,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Shoes = 16777216,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Ear = 33554432,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Neck = 67108864,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Shoulder = 134217728,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Waist = 268435456,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	FacialHair = 536870912,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Hair = 536871040,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Accessory = 503316736,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	OwnershipFilters = 3,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ClothingTypeFilters = 1065355200,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	ConsumableFilters = 4390972,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	RarityFilters = 63488,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	SpecialTypeFilters = 3932160,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
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
