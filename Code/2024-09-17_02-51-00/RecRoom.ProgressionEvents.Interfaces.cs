using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NEMMJPLBFPK
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
public interface COACONGPMNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO FPPFBKBNIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA7C305680291281", Offset = "0x0", VA = "0xA7C305800291281", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO BCJFJDKAOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29128580291281", Offset = "0x0", VA = "0x29128700291281", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NEMMJPLBFPK LLNHJHOCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2912858A7C3068", Offset = "0x0", VA = "0x2912870A7C3068", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int JIDLEAECNGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA7C3056802912D8", Offset = "0x0", VA = "0xA7C3058002912D8", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HLLLEMCPNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29142C802913DD", Offset = "0x0", VA = "0x29142E002913DD", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PAPOJMNGFHM;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IMDJFJLBCFF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x291305802912E0", Offset = "0x0", VA = "0x291307002912E0", Slot = "8")]
	JAGIEECCCMP<bool> PIFKEFDKGAJ();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2913058A76B244", Offset = "0x0", VA = "0x2913070A76B244", Slot = "9")]
	EOHNLEPDLDE GBEDMPFBKNA(bool KNEDLIBDPNF = false);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA7C37BA802913DD", Offset = "0x0", VA = "0xA7C37BC002913DD", Slot = "10")]
	EOHNLEPDLDE JBPJELNNPHP(int ACDNCOMKMKP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29142C8A7C37D8", Offset = "0x0", VA = "0x29142E0A7C37D8", Slot = "12")]
	void OBBBAKDCAHL();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA7C37E680291434", Offset = "0x0", VA = "0xA7C37E800291434", Slot = "13")]
	string POFHKDOMAFH(IIFNMNBEPND GAIFEGPIKGO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IIFNMNBEPND
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
