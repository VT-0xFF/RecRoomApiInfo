using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FKFDNAOIIJD
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
	VFX = 8,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AvatarItem_Effect = 9,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	AvatarItem_EffectGrenade = 10
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DDOGHLAONJF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ItemsTab,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ItemDetails,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	BuyButton,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TrialStart,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TrialFailed,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TrialEnd,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	GiftButton,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	GiftFailed,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	GiftSent,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	ConfirmButton,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ShareButton,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	PurchaseSuccessful,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	PurchaseError,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	NotEnoughTokensPrompt,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NotEnoughTokensCancel,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	NotEnoughTokensGet,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	WishlistButton,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	WishlistFailed,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	UnwishlistButton,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ViewMoreButton,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	NotEnoughTokensGet_TokenStore,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	NotEnoughTokensGet_PromptLowest,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	PurchaseSuccessfulPrompt_Tokens,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PurchaseSuccessfulPrompt_TokensItem,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	PurchaseSuccessful_ReturnToCheckout,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PurchaseSuccessful_GoShop,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	PurchaseSuccessful_TokenStore
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Flags]
public enum LONIDNALMFG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Purchasable = 1,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Owned = 2,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Film = 4,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Potion = 8,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Food = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	GiftBox = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Hat = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	HeadHair = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Eye = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Torso = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Glove = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	OneStar = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	TwoStar = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	ThreeStar = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	FourStar = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	FiveStar = 0x8000,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	KOIcon = 0x10000,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	HairDyes = 0x20000,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	EquipmentSkin = 0x40000,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Featured = 0x80000,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	New = 0x100000,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Members = 0x200000,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Other = 0x400000,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Bottoms = 0x800000,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Shoes = 0x1000000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Ear = 0x2000000,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Neck = 0x4000000,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Shoulder = 0x8000000,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Waist = 0x10000000,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	FacialHair = 0x20000000,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Hair = 0x20000080,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Accessory = 0x1E000100,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	OwnershipFilters = 3,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ClothingTypeFilters = 0x3F8007C0,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ConsumableFilters = 0x43003C,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	RarityFilters = 0xF800,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	SpecialTypeFilters = 0x3C0000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ClothingOrConsumables = 0x3FC307FC
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
