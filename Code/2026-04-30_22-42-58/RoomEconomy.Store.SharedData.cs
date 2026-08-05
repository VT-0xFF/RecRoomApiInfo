using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.Store
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum ConsumableCategory
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
		Avatar_GlitchEffectGrenade = 11,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		MeshGenTrinketConsumable = 12,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		MeshGenCostumeConsumable = 13,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		StudioConsumable = 14,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		RoomBoost = 30,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		BackpackGame = 40,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Roomie_Categories_Start = 100,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Roomie_ConversationalStatusEffect_Start = 100,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Roomie_ConversationalStatusEffect_Hyperactive = 100,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Roomie_ConversationalStatusEffect_Hiccups = 101,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Roomie_ConversationalStatusEffect_BroEnergy = 102,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Roomie_ConversationalStatusEffect_EvilGenius = 103,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Roomie_ConversationalStatusEffect_Unhinged = 104,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Roomie_ConversationalStatusEffect_Chill = 105,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Roomie_ConversationalStatusEffect_Wistful = 106,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Roomie_ConversationalStatusEffect_Pirate = 107,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Roomie_ConversationalStatusEffect_GreenThumb = 108,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Roomie_ConversationalStatusEffect_Speedster = 109,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Roomie_ConversationalStatusEffect_CUSTOM_3 = 110,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Roomie_ConversationalStatusEffect_CUSTOM_4 = 111,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Roomie_ConversationalStatusEffect_CUSTOM_5 = 112,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Roomie_ConversationalStatusEffect_CUSTOM_6 = 113,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Roomie_ConversationalStatusEffect_CUSTOM_7 = 114,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Roomie_ConversationalStatusEffect_CUSTOM_8 = 115,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Roomie_ConversationalStatusEffect_CUSTOM_9 = 116,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Roomie_ConversationalStatusEffect_CUSTOM_10 = 117,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Roomie_ConversationalStatusEffect_CUSTOM_11 = 118,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Roomie_ConversationalStatusEffect_CUSTOM_12 = 119,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Roomie_ConversationalStatusEffect_CUSTOM_13 = 120,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Roomie_ConversationalStatusEffect_CUSTOM_14 = 121,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Roomie_ConversationalStatusEffect_CUSTOM_15 = 122,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Roomie_ConversationalStatusEffect_CUSTOM_16 = 123,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Roomie_ConversationalStatusEffect_CUSTOM_17 = 124,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Roomie_ConversationalStatusEffect_CUSTOM_18 = 125,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Roomie_ConversationalStatusEffect_CUSTOM_19 = 126,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Roomie_ConversationalStatusEffect_CUSTOM_20 = 127,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Roomie_ConversationalStatusEffect_CUSTOM_21 = 128,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Roomie_ConversationalStatusEffect_CUSTOM_22 = 129,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Roomie_ConversationalStatusEffect_CUSTOM_23 = 130,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Roomie_ConversationalStatusEffect_CUSTOM_24 = 131,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Roomie_ConversationalStatusEffect_CUSTOM_25 = 132,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Roomie_ConversationalStatusEffect_End = 132,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Roomie_VoiceFilter_Start = 200,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Roomie_VoiceFilter_End = 200,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Roomie_Soundboard_Start = 300,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Roomie_Soundboard = 300,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Roomie_Soundboard_End = 300,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Roomie_Categories_End = 1000,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RROModifications_Start = 1001,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		RROModifications_Paintball_Start = 1001,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		RROModifications_Paintball_Ticket = 1002,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		RROModifications_Paintball_End = 1050,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		RROModifications_End = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		BattlePassConsumable_TimedBoost = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		BattlePassConsumable_LevelBoost = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		TimeLimitedActivity_Effect = 3000,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		TimeLimitedActivity_Effect_2 = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		TimeLimitedActivity_Effect_3 = 3002,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		TimeLimitedActivity_Effect_4 = 3003,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		TimeLimitedActivity_Effect_5 = 3004
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class JSZVAQGVUJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC3E0", Offset = "0xA3AB7E0", VA = "0x18A3AC3E0")]
		public static bool IBJHJZSQAYT(this ConsumableCategory a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC400", Offset = "0xA3AB800", VA = "0x18A3AC400")]
		public static bool KBYNXOZWJQO(this ConsumableCategory a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC430", Offset = "0xA3AB830", VA = "0x18A3AC430")]
		public static bool VYPENKFZEAE(this ConsumableCategory a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC420", Offset = "0xA3AB820", VA = "0x18A3AC420")]
		public static bool VIZMUQSALUP(this ConsumableCategory a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC3B0", Offset = "0xA3AB7B0", VA = "0x18A3AC3B0")]
		public static bool EQSTHHXSPUS(this ConsumableCategory a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC390", Offset = "0xA3AB790", VA = "0x18A3AC390")]
		public static bool EPSSJURUDWL(this ConsumableCategory a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum ItemPurchaseFunnelStep
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ItemsTab,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		ItemDetails,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		BuyButton,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TrialStart,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TrialFailed,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		TrialEnd,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		GiftButton,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		GiftFailed,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		GiftSent,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ShareButton,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PurchaseError,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		NotEnoughTokensPrompt,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		NotEnoughTokensCancel,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		NotEnoughTokensGet,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		WishlistButton,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		WishlistFailed,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		UnwishlistButton,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ViewMoreButton,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		NotEnoughTokensGet_TokenStore,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		NotEnoughTokensGet_PromptLowest,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		PurchaseSuccessfulPrompt_Tokens,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		PurchaseSuccessfulPrompt_TokensItem,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		PurchaseSuccessful_ReturnToCheckout,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		PurchaseSuccessful_GoShop,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		PurchaseSuccessful_TokenStore,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		PurchasePromotionFetched
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Flags]
	public enum StoreItemFilters
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Purchasable = 1,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Owned = 2,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Film = 4,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Potion = 8,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Food = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		GiftBox = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Hat = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		HeadHair = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Eye = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Torso = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Glove = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		OneStar = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		TwoStar = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		ThreeStar = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		FourStar = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		FiveStar = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		KOIcon = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		HairDyes = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		EquipmentSkin = 0x40000,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Featured = 0x80000,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		New = 0x100000,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Members = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Other = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Bottoms = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Shoes = 0x1000000,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Ear = 0x2000000,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Neck = 0x4000000,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Shoulder = 0x8000000,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Waist = 0x10000000,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		FacialHair = 0x20000000,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Roomie = 0x40000000,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Hair = 0x20000080,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Accessory = 0x1E000100,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		OwnershipFilters = 3,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ClothingTypeFilters = 0x3F8007C0,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		ConsumableFilters = 0x43003C,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		RarityFilters = 0xF800,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		SpecialTypeFilters = 0x3C0000,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		ClothingOrConsumables = 0x3FC307FC
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum RoomieStoreItemFilters
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Waist = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Eye = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Mouth = 8,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Equipment = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Face = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Wrist = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Topper = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Ear = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Hair = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Mask = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Wings = 0x800,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Nose = 0x1000
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
