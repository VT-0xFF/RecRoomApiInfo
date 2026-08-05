using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DFFIAHGGDAN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CollectionGracePeriod,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Ended,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Completed
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CGLEIMDAFHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO ABDEANINMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29A93B8029A8EC", Offset = "0x0", VA = "0x29A93D0029A8EC", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO FMBAELDHGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29A93E8A96D584", Offset = "0x0", VA = "0x29A9400A96D584", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DFFIAHGGDAN DBAAKCOKCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA7479F28029A964", Offset = "0x0", VA = "0xA7479F40029A964", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int CIFFACNHIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29AA038029A964", Offset = "0x0", VA = "0x29AA050029A964", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FJMPCGAMMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29AA5A8A96D054", Offset = "0x0", VA = "0x29AA5C0A96D054", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NDBMLECNHEC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ECGPCCFKGPP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29AA038A96D028", Offset = "0x0", VA = "0x29AA050A96D028", Slot = "8")]
	ELLFHPNCMJG<bool> OGILGANHKCE();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA96D0428029AA56", Offset = "0x0", VA = "0xA96D0440029AA56", Slot = "9")]
	NNKCIMLKELB FHADBKEGAAO(bool PEEBIPHCPFH = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29AA5A8029AA56", Offset = "0x0", VA = "0x29AA5C0029AA56", Slot = "10")]
	NNKCIMLKELB GJGFMMJEDLF(int GFHNADHLMEN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA96D0428029AAAD", Offset = "0x0", VA = "0xA96D0440029AAAD", Slot = "12")]
	void EKFIONJFMJG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29AAD38029AAB0", Offset = "0x0", VA = "0x29AAD50029AAB0", Slot = "13")]
	string PIMKJEPAPDJ(PNPPHHDIELP JBMADCBPCDE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum PNPPHHDIELP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	HubRoomName,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	ProgressionEventCurrencyName,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	EventInfoFirstPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	EventInfoFirstPanelBody,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	EventInfoSecondPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	EventInfoSecondPanelBody,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	EventInfoThirdPanelTitle,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	EventInfoThirdPanelBody,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TutorialFirstIntro_PressFeaturedRoomButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TutorialFirstIntro_PressChallengesButton_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TutorialFirstIntro_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TutorialFirstIntro_PressTodaysRoom_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	TutorialBackup_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	TutorialBackup_PressTodaysRoomButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	TutorialBackup_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	TutorialReward_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TutorialReward_PressViewAllRoomsButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TutorialReward_PressBackButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TutorialReward_ClaimReward_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	TutorialReward_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TutorialRewardBackup_PressChallengesButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	TutorialRewardBackup_PressViewAllRoomsButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TutorialRewardBackup_PressBackButton_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TutorialRewardBackup_ClaimReward_NewWatch,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	TutorialRewardBackup_PressProgressionEventChip_OldWatch,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ExplorePageBanner_DescriptionText,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	RoomCarousel_RegularRoomsHeader,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RoomCarousel_PremiumRoomsHeader,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	MainPage_EventEnded_SpendCurrencyBeforeTimeRunsOutPrompt,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	MainPage_EventEnded_SpendCurrencyButtonText,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	MainPage_EventEnded_SpendCurrencyBonusRewardsText,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	RoomCarousel_RegularRoomsDesc,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	RoomCarousel_PremiumRoomsDesc
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
