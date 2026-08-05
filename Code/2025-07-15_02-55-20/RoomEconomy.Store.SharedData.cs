using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IMHHDDPKMBF
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
	AvatarItem_EffectGrenade = 10,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Avatar_GlitchEffectGrenade = 11
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EEKKIAKPIIN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	ItemsTab,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ItemDetails,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	BuyButton,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TrialStart,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TrialFailed,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TrialEnd,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	GiftButton,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	GiftFailed,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	GiftSent,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	ConfirmButton,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ShareButton,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	PurchaseSuccessful,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	PurchaseError,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	NotEnoughTokensPrompt,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	NotEnoughTokensCancel,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NotEnoughTokensGet,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	WishlistButton,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	WishlistFailed,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	UnwishlistButton,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ViewMoreButton,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	NotEnoughTokensGet_TokenStore,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	NotEnoughTokensGet_PromptLowest,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PurchaseSuccessfulPrompt_Tokens,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	PurchaseSuccessfulPrompt_TokensItem,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	PurchaseSuccessful_ReturnToCheckout,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	PurchaseSuccessful_GoShop,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	PurchaseSuccessful_TokenStore
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Flags]
public enum DNIDHNKGLEC
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Purchasable = 1,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Owned = 2,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Film = 4,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Potion = 8,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Food = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	GiftBox = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Hat = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	HeadHair = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Eye = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Torso = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Glove = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OneStar = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	TwoStar = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	ThreeStar = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	FourStar = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	FiveStar = 0x8000,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	KOIcon = 0x10000,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	HairDyes = 0x20000,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	EquipmentSkin = 0x40000,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Featured = 0x80000,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	New = 0x100000,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Members = 0x200000,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Other = 0x400000,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Bottoms = 0x800000,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Shoes = 0x1000000,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Ear = 0x2000000,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Neck = 0x4000000,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Shoulder = 0x8000000,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Waist = 0x10000000,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	FacialHair = 0x20000000,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RoomieHat = 0x40000000,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Hair = 0x20000080,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Accessory = 0x1E000100,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Roomie = 0x40000000,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	OwnershipFilters = 3,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ClothingTypeFilters = 0x3F8007C0,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ConsumableFilters = 0x43003C,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	RarityFilters = 0xF800,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	SpecialTypeFilters = 0x3C0000,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
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
