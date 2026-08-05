using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPMMBBENJOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84C820", Offset = "0x84BC20", VA = "0x18084C820")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84C2C0", Offset = "0x84B6C0", VA = "0x18084C2C0")]
	public string PrintOutObjectValues(object FIHKDNCJKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KFMHHKKALJG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	PUSH_PERMISSIONS_PROMPT_RESPONSE,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	PUSH_TOKEN_RECEIVED_FROM_SYSTEM,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	PUSH_RECEIVED,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PUSH_OPENED,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	PUSH_DELETED,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	IN_APP_MESSAGE,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	NEWS_FEED_UPDATED,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	CONTENT_CARDS_UPDATED,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	SDK_AUTHORIZATION_FAILED
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JEEOLCDGFFP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BDKLOIDOADH(bool LNDPFBFHEEO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GGFOBNODFCE(string IAIFDAAIBBN);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static KPMMBBENJOF CFDGAHLLJHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static KPMMBBENJOF JHINKHHJBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x84C280", Offset = "0x84B680", VA = "0x18084C280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static DBFEDBGOADG KNBCBFLINKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogCustomEvent(string GKGIBNLOHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogCustomEvent(string GKGIBNLOHML, Dictionary<string, object> GEMCEOCDICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogPurchase(string BHCLBPGHNMK, string GGIOFCKFHCA, decimal GOPFHBMOMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogPurchase(string BHCLBPGHNMK, string GGIOFCKFHCA, decimal GOPFHBMOMFI, int DBKDHFIFEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogPurchase(string BHCLBPGHNMK, string GGIOFCKFHCA, decimal GOPFHBMOMFI, int DBKDHFIFEPD, Dictionary<string, object> GEMCEOCDICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void ChangeUser(string MLJCPGIBJAD, [Optional] string KBJFLCEDPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetSdkAuthenticationSignature(string KBJFLCEDPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserFirstName(string OFCJIDFABLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserLastName(string CJCDCJCEKHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserEmail(string HOHPJIFOGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserGender(BBNFEPOFPIB BGFBGCMMPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserDateOfBirth(int ECJFKBLPNEK, int KPNJMLEJCOP, int PJNDPEIGEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserCountry(string NHCNHKHFJAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserHomeCity(string IKGIPDLIDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserEmailNotificationSubscriptionType(OPJCLOBFPCG NHEPCAHMDOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserPushNotificationSubscriptionType(OPJCLOBFPCG CKPINGAPOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserPhoneNumber(string CCNEFKHDEDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttribute(string PEDCMDADFIN, bool OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttribute(string PEDCMDADFIN, int OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttribute(string PEDCMDADFIN, float OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttribute(string PEDCMDADFIN, string OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttributeToNow(string PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string PEDCMDADFIN, long PDHPDOJIFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void UnsetCustomUserAttribute(string PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void IncrementCustomUserAttribute(string PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void IncrementCustomUserAttribute(string PEDCMDADFIN, int BKAFLCMHPBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetCustomUserAttributeArray(string PEDCMDADFIN, List<string> ELFCOFFIPBP, int CGDIEJGGJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void AddToCustomUserAttributeArray(string PEDCMDADFIN, string OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RemoveFromCustomUserAttributeArray(string PEDCMDADFIN, string OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void setUserFacebookData(string IKNAICAHDBD, string OFCJIDFABLF, string CJCDCJCEKHC, string HOHPJIFOGAO, string EODPPHGLMDC, string PJCJFCBHNON, BBNFEPOFPIB? BGFBGCMMPIA, int? MCJOAMOJOOG, string EADAMPDPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void setUserTwitterData(int? FOGIMEGCCMO, string NMLFLNGKLBB, string FIKHOKLHCII, string ANGPLEOPDHC, int? NFNGGBLOLHH, int? MCAIOAOHPBP, int? ALDCMHJKJJE, string GKMHHAONMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetUserLastKnownLocation(double CBKAPACBMDK, double KDAONHMFLHC, [Optional] double? PGAICCINBMG, [Optional] double? NIBNNACGGBH, [Optional] double? DFKIGJCEPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void PromptUserForPushPermissions(bool FLCIILKBKLN, [Optional] BDKLOIDOADH PDLLOFHPKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetPushTokenReceivedFromSystemDelegate(GGFOBNODFCE DKNDKNDDKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogInAppMessageClicked(string EDHNAAHMMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogInAppMessageImpression(string EDHNAAHMMJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogInAppMessageButtonClicked(string EDHNAAHMMJJ, int OELBDIOGBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogContentCardClicked(string NMJILHGFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogContentCardImpression(string NMJILHGFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void LogContentCardDismissed(string NMJILHGFCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetAttributionData(string NJJKHAJKBPP, string LGCFLCPJFIJ, string EHIPLOAFNJH, string NKJAJFAJAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestGeofences(decimal CBKAPACBMDK, decimal KDAONHMFLHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void AddAlias(string MCMLFINNKFD, string HEAIDDJFOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void ConfigureListener(KFMHHKKALJG IHHJBDJAIEA, string MFAFOADAADI, string BAGEENCOBFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void SetInAppMessageDisplayAction(JEEOLCDGFFP FHCNPHCKMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void AddToSubscriptionGroup(string GNBDDFJPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void RemoveFromSubscriptionGroup(string GNBDDFJPEIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84C240", Offset = "0x84B640", VA = "0x18084C240")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DBFEDBGOADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<DOIJHMCJAOA> IBEKHJOGECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<DOIJHMCJAOA> PEKPNKDMDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<DOIJHMCJAOA> IGBPGIIEANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<DOIJHMCJAOA, BCJIPEBGBJD> CINCOKLGDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<DOIJHMCJAOA, Uri> GHPACCAGLIA;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84C190", Offset = "0x84B590", VA = "0x18084C190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84BA00", Offset = "0x84AE00", VA = "0x18084BA00")]
		private void LANMPPCGNNL(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84B5C0", Offset = "0x84A9C0", VA = "0x18084B5C0")]
		private void FBFNOPJMFOH(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84B3F0", Offset = "0x84A7F0", VA = "0x18084B3F0")]
		private void AFGGKIGIGHD(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84B630", Offset = "0x84AA30", VA = "0x18084B630")]
		private void ILNLIMDFOLD(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84C080", Offset = "0x84B480", VA = "0x18084C080")]
		private void NJFJKEOKPDH(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84BAE0", Offset = "0x84AEE0", VA = "0x18084BAE0")]
		private void LHHFHOJLFAG(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84B460", Offset = "0x84A860", VA = "0x18084B460")]
		private void DKFHKDMEJJL(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84B1B0", Offset = "0x84A5B0", VA = "0x18084B1B0")]
		private void ACFEPOHGGDP(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84BC40", Offset = "0x84B040", VA = "0x18084BC40")]
		private void MGCBGHBFBBD(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84B990", Offset = "0x84AD90", VA = "0x18084B990")]
		private void KJPHKAFFOFA(string PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84B740", Offset = "0x84AB40", VA = "0x18084B740")]
		public static void InAppMessageBeforeDisplayed(DOIJHMCJAOA PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84B8A0", Offset = "0x84ACA0", VA = "0x18084B8A0")]
		public static void InAppMessageDismissed(DOIJHMCJAOA PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84B830", Offset = "0x84AC30", VA = "0x18084B830")]
		public static void InAppMessageClicked(DOIJHMCJAOA PBDOHNMILPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84B7B0", Offset = "0x84ABB0", VA = "0x18084B7B0")]
		public static void InAppMessageButtonClicked(DOIJHMCJAOA PBDOHNMILPN, BCJIPEBGBJD FPMBFOOFFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84B910", Offset = "0x84AD10", VA = "0x18084B910")]
		public static void InAppMessageHTMLClicked(DOIJHMCJAOA PBDOHNMILPN, Uri FADOFCIHGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BCHMDJALAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84D5F0", Offset = "0x84C9F0", VA = "0x18084D5F0")]
	public static string JGIOGHPJJGB(Dictionary<string, string> HLFLEOMHHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28E26A0", Offset = "0x28E1AA0", VA = "0x1828E26A0")]
	public static string HBGPAGPDPLO<T>(List<T> EGGGJKKPDIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BHBICBHJDBO
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84E1E0", Offset = "0x84D5E0", VA = "0x18084E1E0")]
	public static Color? FGCOBNLNGNH(string GIEABNIMPMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84E330", Offset = "0x84D730", VA = "0x18084E330")]
	public static Color FGCOBNLNGNH(int GIEABNIMPMM)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HCCIEDDFGBM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8537E0", Offset = "0x852BE0", VA = "0x1808537E0")]
	public static object LGFEOKNPBNK(Type NNEDBKLGMOJ, string OBEEJPGJPFD, bool MOAEEBGMBIN, object DFNADAHDJII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MEHEPIFGEEP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8588A0", Offset = "0x857CA0", VA = "0x1808588A0")]
	public static Dictionary<string, string> JIGIBDFLILB(CFLKAEFNNCM FAEELMJGFKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class BIICIBIGONA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84E900", Offset = "0x84DD00", VA = "0x18084E900", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int LHKINEKCIKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84F550", Offset = "0x84E950", VA = "0x18084F550", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84EAB0", Offset = "0x84DEB0", VA = "0x18084EAB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool LNCLIJHLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84E7D0", Offset = "0x84DBD0", VA = "0x18084E7D0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84EAF0", Offset = "0x84DEF0", VA = "0x18084EAF0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual GHLDLDFIMIP PGEAEHGNDJH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84E940", Offset = "0x84DD40", VA = "0x18084E940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual CFLKAEFNNCM IILPFEPIBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84E880", Offset = "0x84DC80", VA = "0x18084E880", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
	public virtual void HINMMBAADBG(string ENCMFNBKHKC, BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84EA50", Offset = "0x84DE50", VA = "0x18084EA50", Slot = "10")]
	public virtual void HINMMBAADBG(BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84F590", Offset = "0x84E990", VA = "0x18084F590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84E070", VA = "0x18084EC70")]
	public static BIICIBIGONA JHFAHDJBNPM(string PBKDJDKCHFJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84EBF0", Offset = "0x84DFF0", VA = "0x18084EBF0")]
	public static string JHFAHDJBNPM(BIICIBIGONA EFBOINOKFAK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84EB70", Offset = "0x84DF70", VA = "0x18084EB70")]
	public static bool JAICCEKEELH(BIICIBIGONA DKLJHPKNDLA, object EALBLGNMNKM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84E9D0", Offset = "0x84DDD0", VA = "0x18084E9D0")]
	public static bool HBJIFBKOLOD(BIICIBIGONA DKLJHPKNDLA, object EALBLGNMNKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84E930", Offset = "0x84DD30", VA = "0x18084E930", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84E9C0", Offset = "0x84DDC0", VA = "0x18084E9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84E620", Offset = "0x84DA20", VA = "0x18084E620")]
	internal static string CIFGBKNEHOL(string EDMIJLJMCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84ECE0", Offset = "0x84E0E0", VA = "0x18084ECE0")]
	public static BIICIBIGONA KHALACIHLLC(string IIPNNHLPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BIICIBIGONA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class GHLDLDFIMIP : BIICIBIGONA, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DJJMGCGBEKO : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GHLDLDFIMIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<BIICIBIGONA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public DJJMGCGBEKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851B30", VA = "0x180852730", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x852530", Offset = "0x851930", VA = "0x180852530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8524E0", Offset = "0x8518E0", VA = "0x1808524E0")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8526E0", Offset = "0x851AE0", VA = "0x1808526E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<BIICIBIGONA> BMNFAONCKID;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x853400", Offset = "0x852800", VA = "0x180853400", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8534D0", Offset = "0x8528D0", VA = "0x1808534D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x853550", Offset = "0x852950", VA = "0x180853550", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8533A0", Offset = "0x8527A0", VA = "0x1808533A0", Slot = "4")]
	public override void HINMMBAADBG(string ENCMFNBKHKC, BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x853320", Offset = "0x852720", VA = "0x180853320", Slot = "17")]
	[IteratorStateMachine(typeof(DJJMGCGBEKO))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x853590", Offset = "0x852990", VA = "0x180853590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x853750", Offset = "0x852B50", VA = "0x180853750")]
	public GHLDLDFIMIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class CFLKAEFNNCM : BIICIBIGONA, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LOMFNMGKNEA : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CFLKAEFNNCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Dictionary<string, BIICIBIGONA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public LOMFNMGKNEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x858700", Offset = "0x857B00", VA = "0x180858700", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x858490", Offset = "0x857890", VA = "0x180858490", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x858440", Offset = "0x857840", VA = "0x180858440")]
		private void HMGBLPCOLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8586B0", Offset = "0x857AB0", VA = "0x1808586B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, BIICIBIGONA> KAJNPBHOIHI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8501B0", Offset = "0x84F5B0", VA = "0x1808501B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x850110", Offset = "0x84F510", VA = "0x180850110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8502A0", Offset = "0x84F6A0", VA = "0x1808502A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x850000", Offset = "0x84F400", VA = "0x180850000", Slot = "4")]
	public override void HINMMBAADBG(string ENCMFNBKHKC, BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x84FF80", Offset = "0x84F380", VA = "0x18084FF80", Slot = "17")]
	[IteratorStateMachine(typeof(LOMFNMGKNEA))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8502F0", Offset = "0x84F6F0", VA = "0x1808502F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8506F0", Offset = "0x84FAF0", VA = "0x1808506F0")]
	public CFLKAEFNNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MAMOEJNMCKL : BIICIBIGONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string DKHGCHDNMPF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public MAMOEJNMCKL(string HDHFPDPCGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8587E0", Offset = "0x857BE0", VA = "0x1808587E0")]
	public MAMOEJNMCKL(bool HDHFPDPCGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x858820", Offset = "0x857C20", VA = "0x180858820")]
	public MAMOEJNMCKL(int HDHFPDPCGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x858790", Offset = "0x857B90", VA = "0x180858790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
internal class NPFKKKFNBGP : BIICIBIGONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BIICIBIGONA KIBEMDALPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string OHNLPAKNPBG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85A700", Offset = "0x859B00", VA = "0x18085A700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override BIICIBIGONA OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x85A670", Offset = "0x859A70", VA = "0x18085A670", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int LHKINEKCIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x85A9B0", Offset = "0x859DB0", VA = "0x18085A9B0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85A780", Offset = "0x859B80", VA = "0x18085A780", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool LNCLIJHLNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x85A260", Offset = "0x859660", VA = "0x18085A260", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A860", Offset = "0x859C60", VA = "0x18085A860", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override GHLDLDFIMIP PGEAEHGNDJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85A3F0", Offset = "0x8597F0", VA = "0x18085A3F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override CFLKAEFNNCM IILPFEPIBMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85A330", Offset = "0x859730", VA = "0x18085A330", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x85AAB0", Offset = "0x859EB0", VA = "0x18085AAB0")]
	public NPFKKKFNBGP(BIICIBIGONA EAJGMINAEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
	public NPFKKKFNBGP(BIICIBIGONA EAJGMINAEAA, string ENCMFNBKHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x85A940", Offset = "0x859D40", VA = "0x18085A940")]
	private void KGJINEABJGO(BIICIBIGONA EJNMEINGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x85A590", Offset = "0x859990", VA = "0x18085A590", Slot = "10")]
	public override void HINMMBAADBG(BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85A4A0", Offset = "0x8598A0", VA = "0x18085A4A0", Slot = "4")]
	public override void HINMMBAADBG(string ENCMFNBKHKC, BIICIBIGONA PLEGHPOCGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x85A3E0", Offset = "0x8597E0", VA = "0x18085A3E0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x84E9C0", Offset = "0x84DDC0", VA = "0x18084E9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x85AA80", Offset = "0x859E80", VA = "0x18085AA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IBJDIMLKKCF
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x853F90", Offset = "0x853390", VA = "0x180853F90")]
	public static BIICIBIGONA KHALACIHLLC(string IIPNNHLPIBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OPJCLOBFPCG
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DIPKMECLJDL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DPDGMNNGFNK JCGGONGFIGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int PJBGNPPEBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850C10", VA = "0x180851810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string BGECGFOCGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JOKLICKKEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E0", Offset = "0x84CCE0", VA = "0x18084D8E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D860", Offset = "0x84CC60", VA = "0x18084D860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> DALGBMODMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x851ED0", Offset = "0x8512D0", VA = "0x180851ED0")]
	public DIPKMECLJDL(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x851090", Offset = "0x850490", VA = "0x180851090")]
	private object DIHGBENFCNI(BIICIBIGONA ILPFPPMNEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x851820", Offset = "0x850C20", VA = "0x180851820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DPDGMNNGFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> DFFGGGCIBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string MDEKGJDGOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string HHLODGHAFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string JENMGLPAOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string GDGFKIGKMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x851800", Offset = "0x850C00", VA = "0x180851800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x852C50", Offset = "0x852050", VA = "0x180852C50")]
	public DPDGMNNGFNK(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x852810", Offset = "0x851C10", VA = "0x180852810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OBBAHIBCLOE
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	ADVERTISING,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ANNOUNCEMENTS,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	NEWS,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	SOCIAL,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NO_CATEGORY
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HMDDEIHHFOI
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum AEMHJLKPJOM
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JKIFABCDFHP
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<IEIFDPBPDIP> GLAJBIJIIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NFMOKHJKOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8551C0", Offset = "0x8545C0", VA = "0x1808551C0")]
	public JKIFABCDFHP(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x854F70", Offset = "0x854370", VA = "0x180854F70")]
	private static IEIFDPBPDIP EHGCMMCJPDE(CFLKAEFNNCM FAEELMJGFKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BBNFEPOFPIB
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Male,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Female,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	NotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	PreferNotToSay
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LKPMPHDMCFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BJJKMCIOOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string MPCONLNPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string AFKEEINEMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> DLPKDBFNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int NFJADJNFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x857630", Offset = "0x856A30", VA = "0x180857630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x857290", Offset = "0x856690", VA = "0x180857290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long LPLDPFABAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x857640", Offset = "0x856A40", VA = "0x180857640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string EDMOGLLNIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8541D0", Offset = "0x8535D0", VA = "0x1808541D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x857940", Offset = "0x856D40", VA = "0x180857940")]
	public LKPMPHDMCFJ(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x857650", Offset = "0x856A50", VA = "0x180857650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8572A0", Offset = "0x8566A0", VA = "0x1808572A0")]
	private string JFKGBNKFDMH(CFLKAEFNNCM FAEELMJGFKF, string PEDCMDADFIN, string DFNADAHDJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x857440", Offset = "0x856840", VA = "0x180857440")]
	private int LFBHHMKHIEF(CFLKAEFNNCM FAEELMJGFKF, string PEDCMDADFIN, int DFNADAHDJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8570B0", Offset = "0x8564B0", VA = "0x1808570B0")]
	private long IIIMAAAOONG(CFLKAEFNNCM FAEELMJGFKF, string PEDCMDADFIN, long DFNADAHDJII)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HOIOLLGLPNG
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DOIJHMCJAOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JHHJLKNIOAE
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<BCJIPEBGBJD> FBPKJHJMHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class LKALOIPCFOB : DOIJHMCJAOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected string GIKLMJPEMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int DDCHMMMOJEF;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? PKBALCNEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x855F60", Offset = "0x855360", VA = "0x180855F60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x856060", Offset = "0x855460", VA = "0x180856060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? KOHKDKOKFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x855F90", Offset = "0x855390", VA = "0x180855F90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x855EA0", Offset = "0x8552A0", VA = "0x180855EA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string MPPEJGJPPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? NPJMEPDBAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x855FF0", Offset = "0x8553F0", VA = "0x180855FF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x855F40", Offset = "0x855340", VA = "0x180855F40", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? ECAENKNEPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x855EE0", Offset = "0x8552E0", VA = "0x180855EE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x856050", Offset = "0x855450", VA = "0x180856050", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string PPKIFMNCBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x855F20", Offset = "0x855320", VA = "0x180855F20", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x855F00", Offset = "0x855300", VA = "0x180855F00", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string IBHMBHJJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x856030", Offset = "0x855430", VA = "0x180856030", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x855F50", Offset = "0x855350", VA = "0x180855F50", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> DLPKDBFNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x855F10", Offset = "0x855310", VA = "0x180855F10", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x856010", Offset = "0x855410", VA = "0x180856010", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HMDDEIHHFOI NCNGLIDAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x855FC0", Offset = "0x8553C0", VA = "0x180855FC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(HMDDEIHHFOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x855FB0", Offset = "0x8553B0", VA = "0x180855FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string EOKAHLMAOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x855F80", Offset = "0x855380", VA = "0x180855F80", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x855FD0", Offset = "0x8553D0", VA = "0x180855FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AEMHJLKPJOM MEILFIPIKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x856040", Offset = "0x855440", VA = "0x180856040", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(AEMHJLKPJOM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x855F30", Offset = "0x855330", VA = "0x180855F30", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NEOCJMEBDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x855EB0", Offset = "0x8552B0", VA = "0x180855EB0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x856070", Offset = "0x855470", VA = "0x180856070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x856620", Offset = "0x855A20", VA = "0x180856620")]
	public LKALOIPCFOB(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BCJIPEBGBJD
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GGDFMHPFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A0", Offset = "0x84A5A0", VA = "0x18084B1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84D870", Offset = "0x84CC70", VA = "0x18084D870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string MLEANJPMHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string EOKAHLMAOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HMDDEIHHFOI GEHNMKEKFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84D8E0", Offset = "0x84CCE0", VA = "0x18084D8E0")]
		[CompilerGenerated]
		get
		{
			return default(HMDDEIHHFOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D860", Offset = "0x84CC60", VA = "0x18084D860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? KOHKDKOKFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x84D8B0", Offset = "0x84CCB0", VA = "0x18084D8B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x84D850", Offset = "0x84CC50", VA = "0x18084D850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? PKBALCNEIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x84D880", Offset = "0x84CC80", VA = "0x18084D880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x84D910", Offset = "0x84CD10", VA = "0x18084D910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x84D920", Offset = "0x84CD20", VA = "0x18084D920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x84DC00", Offset = "0x84D000", VA = "0x18084DC00")]
	public BCJIPEBGBJD(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OLNIDPAMFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x85AB50", Offset = "0x859F50", VA = "0x18085AB50")]
	public static CFLKAEFNNCM IPPHNOCMPCC(string MLDKCBPDJNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PGJNGFOFPMM
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x85B230", Offset = "0x85A630", VA = "0x18085B230")]
	public static DOIJHMCJAOA PLFJKPCBLEL(string EDHNAAHMMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HDEMMBPBOFO : BCDMGHOBLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x853860", Offset = "0x852C60", VA = "0x180853860")]
	public HDEMMBPBOFO(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class BCDMGHOBLPO : LKALOIPCFOB, JHHJLKNIOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string FHICHLGMKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84C150", VA = "0x18084CD50", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x84CCF0", Offset = "0x84C0F0", VA = "0x18084CCF0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? DLAIGNAFHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84CD30", Offset = "0x84C130", VA = "0x18084CD30", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84CD10", Offset = "0x84C110", VA = "0x18084CD10", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? ICFDAOANKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x84CC90", Offset = "0x84C090", VA = "0x18084CC90", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84CCD0", Offset = "0x84C0D0", VA = "0x18084CCD0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<BCJIPEBGBJD> FBPKJHJMHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84CD60", Offset = "0x84C160", VA = "0x18084CD60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x84CCB0", Offset = "0x84C0B0", VA = "0x18084CCB0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD70", Offset = "0x84C170", VA = "0x18084CD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x84CFF0", Offset = "0x84C3F0", VA = "0x18084CFF0")]
	public BCDMGHOBLPO(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JEJOKKBEADB : BCDMGHOBLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x853860", Offset = "0x852C60", VA = "0x180853860")]
	public JEJOKKBEADB(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MGFDGMFNDEG : LKALOIPCFOB
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HOIOLLGLPNG HNDFNCBDJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x858BC0", Offset = "0x857FC0", VA = "0x180858BC0")]
		[CompilerGenerated]
		get
		{
			return default(HOIOLLGLPNG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x858BD0", Offset = "0x857FD0", VA = "0x180858BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HFDALLBOJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x858BB0", Offset = "0x857FB0", VA = "0x180858BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x858BE0", Offset = "0x857FE0", VA = "0x180858BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? DCFEIHJGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84CD30", Offset = "0x84C130", VA = "0x18084CD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84CD10", Offset = "0x84C110", VA = "0x18084CD10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x858BF0", Offset = "0x857FF0", VA = "0x180858BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x858E30", Offset = "0x858230", VA = "0x180858E30")]
	public MGFDGMFNDEG(CFLKAEFNNCM FAEELMJGFKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CBLCANPNNAD
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PCILMOBLLPG : IEIFDPBPDIP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string ECNMCJNFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string EBHBMJKPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8507E0", Offset = "0x84FBE0", VA = "0x1808507E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string DIDGDBHNLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8507F0", Offset = "0x84FBF0", VA = "0x1808507F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x85AE40", Offset = "0x85A240", VA = "0x18085AE40")]
	public PCILMOBLLPG(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x85AC80", Offset = "0x85A080", VA = "0x18085AC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KHMECCGEMFK : IEIFDPBPDIP
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string ECNMCJNFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string MPCONLNPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8507E0", Offset = "0x84FBE0", VA = "0x1808507E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string DBAPPAIBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8507F0", Offset = "0x84FBF0", VA = "0x1808507F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string EBHBMJKPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x850790", Offset = "0x84FB90", VA = "0x180850790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string DIDGDBHNLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x850810", Offset = "0x84FC10", VA = "0x180850810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x850800", Offset = "0x84FC00", VA = "0x180850800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x855950", Offset = "0x854D50", VA = "0x180855950")]
	public KHMECCGEMFK(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x855700", Offset = "0x854B00", VA = "0x180855700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IEIFDPBPDIP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string HDNNFHNBJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string CJOIENFDBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool CDCAJFGCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x854200", Offset = "0x853600", VA = "0x180854200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x853FA0", Offset = "0x8533A0", VA = "0x180853FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long NEAPFLLCBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8541E0", Offset = "0x8535E0", VA = "0x1808541E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long FLFDFMMLAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8541F0", Offset = "0x8535F0", VA = "0x1808541F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<OBBAHIBCLOE> HAGELGFCHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string BLJBIGCCFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8541D0", Offset = "0x8535D0", VA = "0x1808541D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> DLPKDBFNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x854590", Offset = "0x853990", VA = "0x180854590")]
	public IEIFDPBPDIP(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x854210", Offset = "0x853610", VA = "0x180854210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x853FB0", Offset = "0x8533B0", VA = "0x180853FB0")]
	public string CLJECBGHJOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CPPFJAMNMEN : IEIFDPBPDIP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string DBAPPAIBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string ECNMCJNFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8507E0", Offset = "0x84FBE0", VA = "0x1808507E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string MPCONLNPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8507F0", Offset = "0x84FBF0", VA = "0x1808507F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string EBHBMJKPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x850790", Offset = "0x84FB90", VA = "0x180850790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DIDGDBHNLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x850810", Offset = "0x84FC10", VA = "0x180850810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x850800", Offset = "0x84FC00", VA = "0x180850800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x850A70", Offset = "0x84FE70", VA = "0x180850A70")]
	public CPPFJAMNMEN(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x850820", Offset = "0x84FC20", VA = "0x180850820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MILBCOLMNHI
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string HDNNFHNBJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string CJOIENFDBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool CDCAJFGCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x854200", Offset = "0x853600", VA = "0x180854200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x853FA0", Offset = "0x8533A0", VA = "0x180853FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long NEAPFLLCBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8541E0", Offset = "0x8535E0", VA = "0x1808541E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long LLICEPOGPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8541F0", Offset = "0x8535F0", VA = "0x1808541F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string ECNMCJNFIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8541A0", Offset = "0x8535A0", VA = "0x1808541A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string MPCONLNPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8541D0", Offset = "0x8535D0", VA = "0x1808541D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string DBAPPAIBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8541B0", Offset = "0x8535B0", VA = "0x1808541B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string EBHBMJKPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string DIDGDBHNLCA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8507E0", Offset = "0x84FBE0", VA = "0x1808507E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool DFKHBEIKGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x859100", Offset = "0x858500", VA = "0x180859100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8592A0", Offset = "0x8586A0", VA = "0x1808592A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool MMLELELOLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8590F0", Offset = "0x8584F0", VA = "0x1808590F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8590E0", Offset = "0x8584E0", VA = "0x1808590E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool FPOEIJKKKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8592B0", Offset = "0x8586B0", VA = "0x1808592B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x859290", Offset = "0x858690", VA = "0x180859290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PKBHPFPBGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8591C0", Offset = "0x8585C0", VA = "0x1808591C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x859280", Offset = "0x858680", VA = "0x180859280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool EEOACJCOGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x859270", Offset = "0x858670", VA = "0x180859270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8591B0", Offset = "0x8585B0", VA = "0x1808591B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string BLJBIGCCFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x850790", Offset = "0x84FB90", VA = "0x180850790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> DLPKDBFNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x850810", Offset = "0x84FC10", VA = "0x180850810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x850800", Offset = "0x84FC00", VA = "0x180850800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x859970", Offset = "0x858D70", VA = "0x180859970")]
	public MILBCOLMNHI(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8592C0", Offset = "0x8586C0", VA = "0x1808592C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8591D0", Offset = "0x8585D0", VA = "0x1808591D0")]
	public void JMOGPILBKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x859110", Offset = "0x858510", VA = "0x180859110")]
	public void IGEHLGBGFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class HDHKDAMBLBC : IEIFDPBPDIP
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string MPCONLNPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8507A0", Offset = "0x84FBA0", VA = "0x1808507A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string DBAPPAIBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8507E0", Offset = "0x84FBE0", VA = "0x1808507E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string EBHBMJKPLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8507F0", Offset = "0x84FBF0", VA = "0x1808507F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string DIDGDBHNLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x850780", Offset = "0x84FB80", VA = "0x180850780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x850790", Offset = "0x84FB90", VA = "0x180850790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x853A80", Offset = "0x852E80", VA = "0x180853A80")]
	public HDHKDAMBLBC(CFLKAEFNNCM FAEELMJGFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x853870", Offset = "0x852C70", VA = "0x180853870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Appboy.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private BDKLOIDOADH AAEDHEOCPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private GGFOBNODFCE ENDOAODIAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public DBFEDBGOADG iamListener;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
		public void setPushPromptResponseReceivedDelegate(BDKLOIDOADH PDLLOFHPKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
		public void setPushTokenReceivedFromSystemDelegate(GGFOBNODFCE PDLLOFHPKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x84FC80", Offset = "0x84F080", VA = "0x18084FC80")]
		public void onPushPromptResponseReceived(string MMNLMBDAEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x84FCF0", Offset = "0x84F0F0", VA = "0x18084FCF0")]
		public void onPushTokenReceivedFromSystem(string IAIFDAAIBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x84F5D0", Offset = "0x84E9D0", VA = "0x18084F5D0")]
		public void beforeInAppMessageDisplayed(string KFPMLDEAJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x84F9A0", Offset = "0x84EDA0", VA = "0x18084F9A0")]
		public void onInAppMessageDismissed(string KFPMLDEAJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x84F940", Offset = "0x84ED40", VA = "0x18084F940")]
		public void onInAppMessageClicked(string KFPMLDEAJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x84F630", Offset = "0x84EA30", VA = "0x18084F630")]
		public void onInAppMessageButtonClicked(string MLEBFDDCBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x84FA00", Offset = "0x84EE00", VA = "0x18084FA00")]
		public void onInAppMessageHTMLClicked(string MLEBFDDCBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GameObject GHLPOEBBIHE;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject CLHFPJDPLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x84FD10", Offset = "0x84F110", VA = "0x18084FD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x84FEC0", Offset = "0x84F2C0", VA = "0x18084FEC0")]
		public static void setPushPromptResponseReceivedDelegate(BDKLOIDOADH PDLLOFHPKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84FF20", Offset = "0x84F320", VA = "0x18084FF20")]
		public static void setPushTokenReceivedFromSystemDelegate(GGFOBNODFCE PDLLOFHPKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x84FE60", Offset = "0x84F260", VA = "0x18084FE60")]
		public static void setInAppMessageListener(DBFEDBGOADG KNBCBFLINKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
		public BrazeInternalGameObject()
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
