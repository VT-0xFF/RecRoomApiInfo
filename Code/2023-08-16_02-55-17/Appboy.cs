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
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A550", Offset = "0x6C09750", VA = "0x186C0A550")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A090", Offset = "0x6C09290", VA = "0x186C0A090")]
	public string PrintOutObjectValues(object CHHANMGFDPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ICGGBJEEKKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PABJCOOALGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Action<OLCGJFAHBAG> JNHGOHPJNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Action<OLCGJFAHBAG> BAKAMBOOLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action<OLCGJFAHBAG> OOPLGBMJMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Action<OLCGJFAHBAG, ADLOFHMDDFN> KKFKDIHEKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Action<OLCGJFAHBAG, Uri> EPLOCGNLODL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OIJGNDJPBJG
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	PUSH_PERMISSIONS_PROMPT_RESPONSE,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	PUSH_TOKEN_RECEIVED_FROM_SYSTEM,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PUSH_RECEIVED,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	PUSH_OPENED,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PUSH_DELETED,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IN_APP_MESSAGE,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NEWS_FEED_UPDATED,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	CONTENT_CARDS_UPDATED,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	SDK_AUTHORIZATION_FAILED
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AIHOINJGFOA
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HDALBPBDLFB(bool IKDAAHFOPEL);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JPECKNGHHCK(string FDCOCHLAHJD);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ICGGBJEEKKM GPHMBMKBJLF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ICGGBJEEKKM EIFNMGJEAED
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6C0A050", Offset = "0x6C09250", VA = "0x186C0A050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static PABJCOOALGN JEMOFEJMFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogCustomEvent(string EGNEACPABPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogCustomEvent(string EGNEACPABPP, Dictionary<string, object> EAAEGPDMONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogPurchase(string DBGOBKCEBNN, string CHBPNOBILJI, decimal FKEEBANIOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogPurchase(string DBGOBKCEBNN, string CHBPNOBILJI, decimal FKEEBANIOFP, int FOMJHFOGHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogPurchase(string DBGOBKCEBNN, string CHBPNOBILJI, decimal FKEEBANIOFP, int FOMJHFOGHKP, Dictionary<string, object> EAAEGPDMONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void ChangeUser(string OFEEHFFCCPI, [Optional] string OEJCGKKILAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetSdkAuthenticationSignature(string OEJCGKKILAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserFirstName(string CFBAKOGEGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserLastName(string IFBNHFEHGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserEmail(string NPPFMJCDIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserGender(MCAFMKGCIKB GIOIIGIDJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserDateOfBirth(int ODLGPIEGPKM, int GLPMHDNBAGA, int BCEOOHCBHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserCountry(string DFIOIMJHEEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserHomeCity(string EEGALMIOFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserEmailNotificationSubscriptionType(GCHBAAGCHCM HGDAMPIKKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserPushNotificationSubscriptionType(GCHBAAGCHCM ICCMOOKOAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserPhoneNumber(string GPPIGCABCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttribute(string JCEGKCPOPDM, bool NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttribute(string JCEGKCPOPDM, int NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttribute(string JCEGKCPOPDM, float NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttribute(string JCEGKCPOPDM, string NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttributeToNow(string JCEGKCPOPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string JCEGKCPOPDM, long ODIDJAODBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void UnsetCustomUserAttribute(string JCEGKCPOPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void IncrementCustomUserAttribute(string JCEGKCPOPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void IncrementCustomUserAttribute(string JCEGKCPOPDM, int OPJHFDLHEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetCustomUserAttributeArray(string JCEGKCPOPDM, List<string> LMFDNLBGHBA, int JPJMMBFGIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void AddToCustomUserAttributeArray(string JCEGKCPOPDM, string NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RemoveFromCustomUserAttributeArray(string JCEGKCPOPDM, string NABCGCEIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void setUserFacebookData(string CBAMDKIAKIM, string CFBAKOGEGGN, string IFBNHFEHGII, string NPPFMJCDIEA, string HLENMCLKKCJ, string APKCLECNFLJ, MCAFMKGCIKB? GIOIIGIDJPG, int? BIDNLNCJOML, string KPJBKLMIGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void setUserTwitterData(int? LPBNEJCAOGM, string BPFJAPMCGAH, string JPKENOAMLIN, string HBCOIOANGHN, int? HMBAPBEHDKC, int? PDEPNAFOEFP, int? LAGLGFNGIHC, string DIPGKDFIAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetUserLastKnownLocation(double LPJGEAFBIPA, double IKDGCIAOLFB, [Optional] double? IDODMEJFDGB, [Optional] double? DHMNBOIBEMO, [Optional] double? BDIOEBEMFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void PromptUserForPushPermissions(bool LBPKDOAODIL, [Optional] HDALBPBDLFB PGEJGBJNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetPushTokenReceivedFromSystemDelegate(JPECKNGHHCK AODAAJDENGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogInAppMessageClicked(string FIIFPCJMBOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogInAppMessageImpression(string FIIFPCJMBOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogInAppMessageButtonClicked(string FIIFPCJMBOI, int JGFHKLPGLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogContentCardClicked(string EJLHKBEOPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogContentCardImpression(string EJLHKBEOPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void LogContentCardDismissed(string EJLHKBEOPGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetAttributionData(string EEJKKLJEOGP, string JNIKPIHJDEA, string IGCFJKFGIMO, string AHOMANPPLCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestGeofences(decimal LPJGEAFBIPA, decimal IKDGCIAOLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void AddAlias(string MPMAIIAEABJ, string EJOOMEOOAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void ConfigureListener(OIJGNDJPBJG KBEIGCJGJJM, string GEFBJOMCAOB, string MOCNIBGCBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void SetInAppMessageDisplayAction(AIHOINJGFOA AFILCGOMEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void AddToSubscriptionGroup(string CJNGPAPKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
		public static void RemoveFromSubscriptionGroup(string CJNGPAPKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0A010", Offset = "0x6C09210", VA = "0x186C0A010")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C09F90", Offset = "0x6C09190", VA = "0x186C09F90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C08FB0", Offset = "0x6C081B0", VA = "0x186C08FB0")]
		private void DALIDFHNBDH(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C09BC0", Offset = "0x6C08DC0", VA = "0x186C09BC0")]
		private void MGDBBDLIIDP(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C08EB0", Offset = "0x6C080B0", VA = "0x186C08EB0")]
		private void AGCFKBFMFOH(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C09C40", Offset = "0x6C08E40", VA = "0x186C09C40")]
		private void OGPLKDMMJFB(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C09930", Offset = "0x6C08B30", VA = "0x186C09930")]
		private void LGIOKKENPFO(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C090A0", Offset = "0x6C082A0", VA = "0x186C090A0")]
		private void GGFBFMPEFHC(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C09A40", Offset = "0x6C08C40", VA = "0x186C09A40")]
		private void LHNMGHPHDIO(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C09D50", Offset = "0x6C08F50", VA = "0x186C09D50")]
		private void OPFPJOOHOBM(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C09220", Offset = "0x6C08420", VA = "0x186C09220")]
		private void HKDCLKINNHF(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C08F30", Offset = "0x6C08130", VA = "0x186C08F30")]
		private void COFBKFENJOL(string JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C09690", Offset = "0x6C08890", VA = "0x186C09690")]
		public static void InAppMessageBeforeDisplayed(OLCGJFAHBAG JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C09820", Offset = "0x6C08A20", VA = "0x186C09820")]
		public static void InAppMessageDismissed(OLCGJFAHBAG JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C097A0", Offset = "0x6C089A0", VA = "0x186C097A0")]
		public static void InAppMessageClicked(OLCGJFAHBAG JPOEHOENKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C09710", Offset = "0x6C08910", VA = "0x186C09710")]
		public static void InAppMessageButtonClicked(OLCGJFAHBAG JPOEHOENKPI, ADLOFHMDDFN JILNEJAIIFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C098A0", Offset = "0x6C08AA0", VA = "0x186C098A0")]
		public static void InAppMessageHTMLClicked(OLCGJFAHBAG JPOEHOENKPI, Uri HEEAGBHJANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public AppboyBindingTester()
		{
		}
	}
}
namespace Appboy.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static GameObject PEJFNLJIKME;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static GameObject JHOAALADPKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6C0B9E0", Offset = "0x6C0ABE0", VA = "0x186C0B9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0BB90", Offset = "0x6C0AD90", VA = "0x186C0BB90")]
		public static void setPushPromptResponseReceivedDelegate(HDALBPBDLFB PGEJGBJNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0BBF0", Offset = "0x6C0ADF0", VA = "0x186C0BBF0")]
		public static void setPushTokenReceivedFromSystemDelegate(JPECKNGHHCK PGEJGBJNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C0BB30", Offset = "0x6C0AD30", VA = "0x186C0BB30")]
		public static void setInAppMessageListener(PABJCOOALGN JEMOFEJMFHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public BrazeInternalGameObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HDALBPBDLFB OHBAGOIBFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JPECKNGHHCK OFONAKONDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public PABJCOOALGN iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		public void setPushPromptResponseReceivedDelegate(HDALBPBDLFB PGEJGBJNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		public void setPushTokenReceivedFromSystemDelegate(JPECKNGHHCK PGEJGBJNBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B940", Offset = "0x6C0AB40", VA = "0x186C0B940")]
		public void onPushPromptResponseReceived(string GGGBLCGFJEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B9C0", Offset = "0x6C0ABC0", VA = "0x186C0B9C0")]
		public void onPushTokenReceivedFromSystem(string FDCOCHLAHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B170", Offset = "0x6C0A370", VA = "0x186C0B170")]
		public void beforeInAppMessageDisplayed(string CCMCGBHFFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B5C0", Offset = "0x6C0A7C0", VA = "0x186C0B5C0")]
		public void onInAppMessageDismissed(string CCMCGBHFFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B540", Offset = "0x6C0A740", VA = "0x186C0B540")]
		public void onInAppMessageClicked(string CCMCGBHFFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B1F0", Offset = "0x6C0A3F0", VA = "0x186C0B1F0")]
		public void onInAppMessageButtonClicked(string NHKNKNFLGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B640", Offset = "0x6C0A840", VA = "0x186C0B640")]
		public void onInAppMessageHTMLClicked(string NHKNKNFLGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public BrazeInternalComponent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PHOBPKCNEOP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C18670", Offset = "0x6C17870", VA = "0x186C18670")]
	public static Color? FFAMIPMEGHN(string OMGLEEEBCHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C187E0", Offset = "0x6C179E0", VA = "0x186C187E0")]
	public static Color FFAMIPMEGHN(int OMGLEEEBCHI)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class HHOCKPLFOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual string HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FBA0", Offset = "0x6C0EDA0", VA = "0x186C0FBA0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x94CC00", Offset = "0x94BE00", VA = "0x18094CC00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual int DBLOIEKKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FA40", Offset = "0x6C0EC40", VA = "0x186C0FA40", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FC50", Offset = "0x6C0EE50", VA = "0x186C0FC50", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual bool EFLKDNAHMBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C107D0", Offset = "0x6C0F9D0", VA = "0x186C107D0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FA80", Offset = "0x6C0EC80", VA = "0x186C0FA80", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual NDMDKNAKKKG ICCHCPPDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FBD0", Offset = "0x6C0EDD0", VA = "0x186C0FBD0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual BKNKILHPNMK NHDPPJDPGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C10890", Offset = "0x6C0FA90", VA = "0x186C10890", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public virtual void CKPKOIJGHLD(string AHNCNGDFOIB, HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F9E0", Offset = "0x6C0EBE0", VA = "0x186C0F9E0", Slot = "10")]
	public virtual void CKPKOIJGHLD(HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C10910", Offset = "0x6C0FB10", VA = "0x186C10910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C104B0", Offset = "0x6C0F6B0", VA = "0x186C104B0")]
	public static HHOCKPLFOAE OMHOCPNBHHH(string LFGPCDPDPCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C10510", Offset = "0x6C0F710", VA = "0x186C10510")]
	public static string OMHOCPNBHHH(HHOCKPLFOAE ANIFGLPKOMK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FB00", Offset = "0x6C0ED00", VA = "0x186C0FB00")]
	public static bool IJMFMDJGAHN(HHOCKPLFOAE GGFLAOCNMAP, object PIINDHALINJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C10730", Offset = "0x6C0F930", VA = "0x186C10730")]
	public static bool PFFDPAELFMB(HHOCKPLFOAE GGFLAOCNMAP, object PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1A326B0", Offset = "0x1A318B0", VA = "0x181A326B0", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA9FC80", Offset = "0xA9EE80", VA = "0x180A9FC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C105A0", Offset = "0x6C0F7A0", VA = "0x186C105A0")]
	internal static string PABCAEBBMEP(string EHONFPOODGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FC90", Offset = "0x6C0EE90", VA = "0x186C0FC90")]
	public static HHOCKPLFOAE OBECMMGPMOG(string FFDIBHPGDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public HHOCKPLFOAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class NDMDKNAKKKG : HHOCKPLFOAE, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MOIPHKDDHCM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NDMDKNAKKKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<HHOCKPLFOAE>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private HHOCKPLFOAE <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public MOIPHKDDHCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C16EC0", Offset = "0x6C160C0", VA = "0x186C16EC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C16CE0", Offset = "0x6C15EE0", VA = "0x186C16CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C16C90", Offset = "0x6C15E90", VA = "0x186C16C90")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C16E80", Offset = "0x6C16080", VA = "0x186C16E80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<HHOCKPLFOAE> MMJCDAHHHJB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C170C0", Offset = "0x6C162C0", VA = "0x186C170C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C17060", Offset = "0x6C16260", VA = "0x186C17060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C17020", Offset = "0x6C16220", VA = "0x186C17020", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C16F50", Offset = "0x6C16150", VA = "0x186C16F50", Slot = "4")]
	public override void CKPKOIJGHLD(string AHNCNGDFOIB, HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C16FB0", Offset = "0x6C161B0", VA = "0x186C16FB0", Slot = "17")]
	[IteratorStateMachine(typeof(MOIPHKDDHCM))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C17170", Offset = "0x6C16370", VA = "0x186C17170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C17310", Offset = "0x6C16510", VA = "0x186C17310")]
	public NDMDKNAKKKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class BKNKILHPNMK : HHOCKPLFOAE, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KPPLPGBOAEM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BKNKILHPNMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, HHOCKPLFOAE>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KeyValuePair<string, HHOCKPLFOAE> <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFF0", Offset = "0xA0A1F0", VA = "0x180A0AFF0")]
		[DebuggerHidden]
		public KPPLPGBOAEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C12D60", Offset = "0x6C11F60", VA = "0x186C12D60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C12B40", Offset = "0x6C11D40", VA = "0x186C12B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C12AF0", Offset = "0x6C11CF0", VA = "0x186C12AF0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C12D20", Offset = "0x6C11F20", VA = "0x186C12D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, HHOCKPLFOAE> OGJGHBOHIPH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AB70", Offset = "0x6C09D70", VA = "0x186C0AB70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AC40", Offset = "0x6C09E40", VA = "0x186C0AC40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C0AB20", Offset = "0x6C09D20", VA = "0x186C0AB20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A970", Offset = "0x6C09B70", VA = "0x186C0A970", Slot = "4")]
	public override void CKPKOIJGHLD(string AHNCNGDFOIB, HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AAB0", Offset = "0x6C09CB0", VA = "0x186C0AAB0", Slot = "17")]
	[IteratorStateMachine(typeof(KPPLPGBOAEM))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C0ACF0", Offset = "0x6C09EF0", VA = "0x186C0ACF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B0F0", Offset = "0x6C0A2F0", VA = "0x186C0B0F0")]
	public BKNKILHPNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ILPAINLGLEO : HHOCKPLFOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private string CJLCFHBIMKK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override string HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E9420", Offset = "0x7E8620", VA = "0x1807E9420", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	public ILPAINLGLEO(string HIAJJOKHEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C111A0", Offset = "0x6C103A0", VA = "0x186C111A0")]
	public ILPAINLGLEO(bool HIAJJOKHEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C11160", Offset = "0x6C10360", VA = "0x186C11160")]
	public ILPAINLGLEO(int HIAJJOKHEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C11110", Offset = "0x6C10310", VA = "0x186C11110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
internal class KJNDDCFPAED : HHOCKPLFOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HHOCKPLFOAE PLJCCFDIDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string NCIBKMKPAKM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C126F0", Offset = "0x6C118F0", VA = "0x186C126F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override HHOCKPLFOAE JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C12750", Offset = "0x6C11950", VA = "0x186C12750", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override int DBLOIEKKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C12560", Offset = "0x6C11760", VA = "0x186C12560", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C12870", Offset = "0x6C11A70", VA = "0x186C12870", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override bool EFLKDNAHMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C12940", Offset = "0x6C11B40", VA = "0x186C12940", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C12620", Offset = "0x6C11820", VA = "0x186C12620", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override NDMDKNAKKKG ICCHCPPDAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C127C0", Offset = "0x6C119C0", VA = "0x186C127C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override BKNKILHPNMK NHDPPJDPGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C12A00", Offset = "0x6C11C00", VA = "0x186C12A00", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x43D5EA0", Offset = "0x43D50A0", VA = "0x1843D5EA0")]
	public KJNDDCFPAED(HHOCKPLFOAE FAJIGANDLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x43D5E10", Offset = "0x43D5010", VA = "0x1843D5E10")]
	public KJNDDCFPAED(HHOCKPLFOAE FAJIGANDLBD, string AHNCNGDFOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C12330", Offset = "0x6C11530", VA = "0x186C12330")]
	private void BNDJKAKDCIM(HHOCKPLFOAE CNHFECEGNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C12490", Offset = "0x6C11690", VA = "0x186C12490", Slot = "10")]
	public override void CKPKOIJGHLD(HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C123A0", Offset = "0x6C115A0", VA = "0x186C123A0", Slot = "4")]
	public override void CKPKOIJGHLD(string AHNCNGDFOIB, HHOCKPLFOAE AMDJMJBMDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x43D5B70", Offset = "0x43D4D70", VA = "0x1843D5B70", Slot = "0")]
	public override bool Equals(object PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA9FC80", Offset = "0xA9EE80", VA = "0x180A9FC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C12AB0", Offset = "0x6C11CB0", VA = "0x186C12AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IDDOFGOCEHO
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C11100", Offset = "0x6C10300", VA = "0x186C11100")]
	public static HHOCKPLFOAE OBECMMGPMOG(string FFDIBHPGDJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AKLODKJNJBA
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C08E20", Offset = "0x6C08020", VA = "0x186C08E20")]
	public static object OENBNLCELEJ(Type CHLCAOMGHHN, string NABCGCEIEGG, bool PKIJHAFIBBM, object HMGHIIACOGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GLIFPOEHGMN
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E320", Offset = "0x6C0D520", VA = "0x186C0E320")]
	public static Dictionary<string, string> POLNJABICJD(BKNKILHPNMK HGJLONEPADA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EHEPHOBDHAG
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E0C0", Offset = "0x6C0D2C0", VA = "0x186C0E0C0")]
	public static string EOCBIGNABDB(Dictionary<string, string> JLHBIMEGIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xF136F0", Offset = "0xF128F0", VA = "0x180F136F0")]
	public static string MFDHDJJCPGO<T>(List<T> MLEOGHHEJOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MLAIOFKKBGG
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ADVERTISING,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	ANNOUNCEMENTS,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NEWS,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	SOCIAL,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NO_CATEGORY
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NDJEILBFGEF
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GNLKLDODGFM
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string IHKAGPCEMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string OJKBJFIDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string GIPCKPCMNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Dictionary<string, string> PEBGOFOIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x88F7E0", Offset = "0x88E9E0", VA = "0x18088F7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MOAAGJELIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9E7BA0", Offset = "0x9E6DA0", VA = "0x1809E7BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xBB0690", Offset = "0xBAF890", VA = "0x180BB0690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long JAPODEHKKPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xC91530", Offset = "0xC90730", VA = "0x180C91530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string KPKIGNJJBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EE80", Offset = "0x6C0E080", VA = "0x186C0EE80")]
	public GNLKLDODGFM(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EB30", Offset = "0x6C0DD30", VA = "0x186C0EB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E670", Offset = "0x6C0D870", VA = "0x186C0E670")]
	private string FIFMMLPPBND(BKNKILHPNMK HGJLONEPADA, string JCEGKCPOPDM, string HMGHIIACOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E7D0", Offset = "0x6C0D9D0", VA = "0x186C0E7D0")]
	private int IFKGGIOFCDA(BKNKILHPNMK HGJLONEPADA, string JCEGKCPOPDM, int HMGHIIACOGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E980", Offset = "0x6C0DB80", VA = "0x186C0E980")]
	private long OIFKEGJNJAM(BKNKILHPNMK HGJLONEPADA, string JCEGKCPOPDM, long HMGHIIACOGF)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HLAFLCJFGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<JOPCPKBPGCG> HBLAKHKMLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool OOHIFDIJNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x94D9A0", Offset = "0x94CBA0", VA = "0x18094D9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C10BA0", Offset = "0x6C0FDA0", VA = "0x186C10BA0")]
	public HLAFLCJFGPC(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C10940", Offset = "0x6C0FB40", VA = "0x186C10940")]
	private static JOPCPKBPGCG DJFIJEAJKAC(BKNKILHPNMK HGJLONEPADA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NOAMNGOCHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<string> DKCFNJKDPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HMJNGGMNJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HDKNJJKLAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string JMAPJEOJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x88F7E0", Offset = "0x88E9E0", VA = "0x18088F7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string DJFONDMEIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C177B0", Offset = "0x6C169B0", VA = "0x186C177B0")]
	public NOAMNGOCHAL(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C17390", Offset = "0x6C16590", VA = "0x186C17390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HOLGKMHNKJF
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MCEDGGAHPDM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NOAMNGOCHAL KNBMELEGKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int MDJBGAJNHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C20", Offset = "0x8C7E20", VA = "0x1808C8C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x902EF0", Offset = "0x9020F0", VA = "0x180902EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string FJGEJDMAGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int POJELADJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x890870", Offset = "0x88FA70", VA = "0x180890870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4BC0", Offset = "0xAC3DC0", VA = "0x180AC4BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDictionary<string, object> KMJBAFBGODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C13B70", Offset = "0x6C12D70", VA = "0x186C13B70")]
	public MCEDGGAHPDM(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C12DF0", Offset = "0x6C11FF0", VA = "0x186C12DF0")]
	private object PFBGCFPOAAB(HHOCKPLFOAE MEMCJAOBNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C13490", Offset = "0x6C12690", VA = "0x186C13490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GCHBAAGCHCM
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum MCAFMKGCIKB
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Male,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Female,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	NotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	PreferNotToSay
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DCBIKFHPIDB
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CJGBHNFDCDD : JOPCPKBPGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string FIMLGFAMJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string IIGGPONGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string BHGCKHKDNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C0F0", Offset = "0x6C0B2F0", VA = "0x186C0C0F0")]
	public CJGBHNFDCDD(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BF00", Offset = "0x6C0B100", VA = "0x186C0BF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OHHKGMAHCOK : JOPCPKBPGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string FIMLGFAMJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string OJKBJFIDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string JNLFDIPLAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string IIGGPONGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string BHGCKHKDNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x978C00", Offset = "0x977E00", VA = "0x180978C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C18060", Offset = "0x6C17260", VA = "0x186C18060")]
	public OHHKGMAHCOK(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C17DB0", Offset = "0x6C16FB0", VA = "0x186C17DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DGEKCNINAOI : JOPCPKBPGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string OJKBJFIDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JNLFDIPLAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string IIGGPONGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string BHGCKHKDNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C6C0", Offset = "0x6C0B8C0", VA = "0x186C0C6C0")]
	public DGEKCNINAOI(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C470", Offset = "0x6C0B670", VA = "0x186C0C470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DLCFKMJKNLI : JOPCPKBPGCG
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string JNLFDIPLAMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string FIMLGFAMJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string OJKBJFIDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x99DC40", Offset = "0x99CE40", VA = "0x18099DC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x99DCE0", Offset = "0x99CEE0", VA = "0x18099DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string IIGGPONGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string BHGCKHKDNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x978C00", Offset = "0x977E00", VA = "0x180978C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CE40", Offset = "0x6C0C040", VA = "0x186C0CE40")]
	public DLCFKMJKNLI(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CB90", Offset = "0x6C0BD90", VA = "0x186C0CB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JOPCPKBPGCG
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string LGLKBNOIMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool NPPEEHLBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x94E3A0", Offset = "0x94D5A0", VA = "0x18094E3A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8D38A0", Offset = "0x8D2AA0", VA = "0x1808D38A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long MCFDMKPMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xD6B320", Offset = "0xD6A520", VA = "0x180D6B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public long OIAEILKGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AF0", Offset = "0xABFCF0", VA = "0x180AC0AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HashSet<MLAIOFKKBGG> ENJAGJJPFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private string LLHJGKIFPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Dictionary<string, string> PEBGOFOIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C11940", Offset = "0x6C10B40", VA = "0x186C11940")]
	public JOPCPKBPGCG(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C11550", Offset = "0x6C10750", VA = "0x186C11550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C11340", Offset = "0x6C10540", VA = "0x186C11340")]
	public string JCOPJEHLPOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MDHIPLKMDEH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string LGLKBNOIMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NPPEEHLBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x94E3A0", Offset = "0x94D5A0", VA = "0x18094E3A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8D38A0", Offset = "0x8D2AA0", VA = "0x1808D38A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long MCFDMKPMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xD6B320", Offset = "0xD6A520", VA = "0x180D6B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long NFNCFIGCGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AF0", Offset = "0xABFCF0", VA = "0x180AC0AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string FIMLGFAMJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x89A500", VA = "0x18089B300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x89A3F0", VA = "0x18089B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string OJKBJFIDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8BE190", Offset = "0x8BD390", VA = "0x1808BE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string JNLFDIPLAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string IIGGPONGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x903CE0", Offset = "0x902EE0", VA = "0x180903CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string BHGCKHKDNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x97BA90", Offset = "0x97AC90", VA = "0x18097BA90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9ED500", Offset = "0x9EC700", VA = "0x1809ED500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool GJIMLENFHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x97BA80", Offset = "0x97AC80", VA = "0x18097BA80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x979C20", Offset = "0x978E20", VA = "0x180979C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool LONPHNOAEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xDE29F0", Offset = "0xDE1BF0", VA = "0x180DE29F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xDE15C0", Offset = "0xDE07C0", VA = "0x180DE15C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool LLEAPKIKKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x10F5E20", Offset = "0x10F5020", VA = "0x1810F5E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C14130", Offset = "0x6C13330", VA = "0x186C14130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool EMMFEEOMHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x10F5EE0", Offset = "0x10F50E0", VA = "0x1810F5EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6C141F0", Offset = "0x6C133F0", VA = "0x186C141F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool KOFBHFDEOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9840", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1C6D610", Offset = "0x1C6C810", VA = "0x181C6D610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string LLHJGKIFPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9AF470", Offset = "0x9AE670", VA = "0x1809AF470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Dictionary<string, string> PEBGOFOIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9CCD40", Offset = "0x9CBF40", VA = "0x1809CCD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x978C00", Offset = "0x977E00", VA = "0x180978C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C14A50", Offset = "0x6C13C50", VA = "0x186C14A50")]
	public MDHIPLKMDEH(BKNKILHPNMK HGJLONEPADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C142B0", Offset = "0x6C134B0", VA = "0x186C142B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C14200", Offset = "0x6C13400", VA = "0x186C14200")]
	public void NEDGNGLKMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C14140", Offset = "0x6C13340", VA = "0x186C14140")]
	public void KCAOOFLJANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KLMJBDAAJGL : DOJOHGILEHM
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C12AE0", Offset = "0x6C11CE0", VA = "0x186C12AE0")]
	public KLMJBDAAJGL(BKNKILHPNMK HGJLONEPADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class DOJOHGILEHM : MEJGILPKEME, MKMBFCBLMDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool NNIFGFBICOJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string AMDHHAKEDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA07360", Offset = "0xA06560", VA = "0x180A07360", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA40", Offset = "0xB7CC40", VA = "0x180B7DA40", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Color? KABHIJDJDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x204DEE0", Offset = "0x204D0E0", VA = "0x18204DEE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D410", Offset = "0x6C0C610", VA = "0x186C0D410", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Color? FMLAFLOPDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D3F0", Offset = "0x6C0C5F0", VA = "0x186C0D3F0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D3D0", Offset = "0x6C0C5D0", VA = "0x186C0D3D0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public List<ADLOFHMDDFN> CECOJGBFICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BCA0", VA = "0x18099CAA0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xD75100", Offset = "0xD74300", VA = "0x180D75100", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D430", Offset = "0x6C0C630", VA = "0x186C0D430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D700", Offset = "0x6C0C900", VA = "0x186C0D700")]
	public DOJOHGILEHM(BKNKILHPNMK HGJLONEPADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ADLOFHMDDFN
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int MFECLIGNHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xB4F8A0", Offset = "0xB4EAA0", VA = "0x180B4F8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string JIANFOCJEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string IADKJGLGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DCBIKFHPIDB JAMGHNCMHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x890870", Offset = "0x88FA70", VA = "0x180890870")]
		[CompilerGenerated]
		get
		{
			return default(DCBIKFHPIDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xAC4BC0", Offset = "0xAC3DC0", VA = "0x180AC4BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Color? OCDBIHCMJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C08250", Offset = "0x6C07450", VA = "0x186C08250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6C08240", Offset = "0x6C07440", VA = "0x186C08240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Color? GLEOMLDIMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4E60", Offset = "0x2ED4060", VA = "0x182ED4E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2ED4E50", Offset = "0x2ED4050", VA = "0x182ED4E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C08270", Offset = "0x6C07470", VA = "0x186C08270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C085A0", Offset = "0x6C077A0", VA = "0x186C085A0")]
	public ADLOFHMDDFN(BKNKILHPNMK HGJLONEPADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OLCGJFAHBAG
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MKMBFCBLMDB
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	List<ADLOFHMDDFN> CECOJGBFICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PELILCJFGFB : DOJOHGILEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C12AE0", Offset = "0x6C11CE0", VA = "0x186C12AE0")]
	public PELILCJFGFB(BKNKILHPNMK HGJLONEPADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CFDMFIHNKNF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BC50", Offset = "0x6C0AE50", VA = "0x186C0BC50")]
	public static OLCGJFAHBAG CEBENPFHKNH(string FIIFPCJMBOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum LFJFFKHKOMN
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class INPMIAHHILM
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C111E0", Offset = "0x6C103E0", VA = "0x186C111E0")]
	public static BKNKILHPNMK LDDCKCHFFEC(string LKGBLLFCBPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HCIDCBLOBEH : MEJGILPKEME
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NDJEILBFGEF IJGPDKCPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x131E790", Offset = "0x131D990", VA = "0x18131E790")]
		[CompilerGenerated]
		get
		{
			return default(NDJEILBFGEF);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x40ADF50", Offset = "0x40AD150", VA = "0x1840ADF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool BNDLEEBBPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1293CF0", Offset = "0x1292EF0", VA = "0x181293CF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1293D00", Offset = "0x1292F00", VA = "0x181293D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Color? CMFBFNBBJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F260", Offset = "0x6C0E460", VA = "0x186C0F260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F280", Offset = "0x6C0E480", VA = "0x186C0F280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F2A0", Offset = "0x6C0E4A0", VA = "0x186C0F2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F510", Offset = "0x6C0E710", VA = "0x186C0F510")]
	public HCIDCBLOBEH(BKNKILHPNMK HGJLONEPADA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class MEJGILPKEME : OLCGJFAHBAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	protected string BEIHAECHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool ILJDLCDIHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool FHKBGHLLBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int AAKCLIBMIDG;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Color? GLEOMLDIMFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x126D420", Offset = "0x126C620", VA = "0x18126D420", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x126DDE0", Offset = "0x126CFE0", VA = "0x18126DDE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color? OCDBIHCMJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C15490", Offset = "0x6C14690", VA = "0x186C15490", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C15480", Offset = "0x6C14680", VA = "0x186C15480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string HDJMFJGJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x928E20", Offset = "0x928020", VA = "0x180928E20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9ED510", Offset = "0x9EC710", VA = "0x1809ED510", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Color? JDPFHMNJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x20E0FA0", Offset = "0x20E01A0", VA = "0x1820E0FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x20E10F0", Offset = "0x20E02F0", VA = "0x1820E10F0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color? NDGCCEIFJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6C15430", Offset = "0x6C14630", VA = "0x186C15430", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C15420", Offset = "0x6C14620", VA = "0x186C15420", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string BENOBFFHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFD0", Offset = "0x8DB1D0", VA = "0x1808DBFD0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BA0", Offset = "0x8D7DA0", VA = "0x1808D8BA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string GCEJMFHMPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x999860", Offset = "0x998A60", VA = "0x180999860", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD00", Offset = "0x9ACF00", VA = "0x1809ADD00", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Dictionary<string, string> PEBGOFOIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4E0", Offset = "0x8D96E0", VA = "0x1808DA4E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C80", Offset = "0x8D7E80", VA = "0x1808D8C80", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DCBIKFHPIDB DJGDLNCINHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xABADF0", Offset = "0xAB9FF0", VA = "0x180ABADF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DCBIKFHPIDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xD9C650", Offset = "0xD9B850", VA = "0x180D9C650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string IADKJGLGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EA0", Offset = "0x8D40A0", VA = "0x1808D4EA0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E70", Offset = "0x8D4070", VA = "0x1808D4E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HOLGKMHNKJF HCDFMPGJNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E90", Offset = "0x8D4090", VA = "0x1808D4E90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(HOLGKMHNKJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BB0", Offset = "0x8D3DB0", VA = "0x1808D4BB0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int JICHKAHLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xF2A1E0", Offset = "0xF293E0", VA = "0x180F2A1E0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C15450", Offset = "0x6C14650", VA = "0x186C15450", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6C154B0", Offset = "0x6C146B0", VA = "0x186C154B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C15B20", Offset = "0x6C14D20", VA = "0x186C15B20")]
	public MEJGILPKEME(BKNKILHPNMK HGJLONEPADA)
	{
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
